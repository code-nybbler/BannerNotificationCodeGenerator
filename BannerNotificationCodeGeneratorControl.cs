using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace BannerNotificationCodeGenerator
{
    public partial class BannerNotificationCodeGeneratorControl : PluginControlBase
    {
        private Settings mySettings;

        public BannerNotificationCodeGeneratorControl()
        {
            InitializeComponent();
        }

        private void BannerNotificationCodeGeneratorControl_Load(object sender, EventArgs e)
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void BannerNotificationCodeGeneratorControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchXML = txt_fetch.Text;
                string message = txt_message.Text;
                string level = lst_level.SelectedItem.ToString();

                string entityTagPrefix = Regex.Match(fetchXML, "<entity name=[\"']").ToString();
                string entity = fetchXML.Substring(fetchXML.IndexOf(entityTagPrefix) + entityTagPrefix.Length, Regex.Match(fetchXML, "<entity name=[\"'](?i)[a-z_]+[\"']").ToString().Replace(entityTagPrefix, "").Length - 1);

                string script = string.Format(@"function toggleBannerNotification(executionContext) {{
                    var formContext = executionContext.getFormContext();
                    var recordID = formContext.data.entity.getId();
	                var fetchXML = `{0}`;

                    fetchXML = fetchXML.Replace(""$$"", recordID);    
	                fetchXML = '?fetchXml=' + encodeURIComponent(fetchXML);     

	                // call web api
	                Xrm.WebApi.retrieveMultipleRecords('{1}', fetchXML).then(
		                function success(result) {{
			                if(result.entities.length > 0) {{
				                var message = '{2}';
				                var type = '{3}';
				                var id = '123';
				                Xrm.Page.ui.setFormNotification(message, type, id);
			                }}
		                }},
		                function(error) {{ console.log(error.message); }}
	                ); 
                }}", fetchXML, entity, message, level);

                txt_script.Text = script;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_script.Text);
        }

        private void lst_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lst_level.SelectedIndex;
            int count = lst_level.Items.Count;
            for (int idx = 0; idx < count; idx++)
            {
                if (idx != index) lst_level.SetItemChecked(idx, false);
            }
        }
    }
}