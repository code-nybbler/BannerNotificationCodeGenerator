using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using XrmToolBox.Extensibility;

namespace BannerNotificationCodeGenerator
{
    public partial class BannerNotificationCodeGeneratorControl : PluginControlBase
    {
        private Settings mySettings;
        private string script, webResourceName, webResourceDisplayName, webResourceDesc, solutionName;

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

                script = string.Format(@"function toggleBannerNotification(executionContext) {{
                    var formContext = executionContext.getFormContext();
                    var recordID = formContext.data.entity.getId();
	                var fetchXML = `{0}`;

                    fetchXML = fetchXML.replace(""$$"", recordID);    
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
                EnableWRInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateWebResource(string script)
        {
            Entity wr = new Entity("webresource");
            wr["content"] = Base64Encode(script);
            wr["displayname"] = webResourceDisplayName;
            wr["description"] = webResourceDesc;
            wr["name"] = webResourceName;
            wr["webresourcetype"] = new OptionSetValue(3); // JS

            try
            {
                QueryByAttribute qba = new QueryByAttribute("webresource"); // create query to check existing web resources
                qba.ColumnSet = new ColumnSet(true);
                qba.AddAttributeValue("name", webResourceName); // add filter for name

                if (Service.RetrieveMultiple(qba).Entities.FirstOrDefault() == null) // does not already exist
                {
                    try
                    {
                        CreateRequest cr = new CreateRequest
                        {
                            Target = wr
                        };
                        cr.Parameters.Add("SolutionUniqueName", solutionName);
                        CreateResponse cresp = (CreateResponse)Service.Execute(cr);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not create web resource: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("A web resource with this name already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve a list of existing web resources to check for name conflicts: " + ex.Message);
            }
        }

        private void btn_CreateWR_Click(object sender, EventArgs e)
        {
            DisableWRInputs();

            solutionName = box_Solution.SelectedItem.ToString();
            webResourceName = txt_WRName.Text;
            webResourceDisplayName = txt_WRDisplayName.Text;
            webResourceDesc = txt_WRDesc.Text;

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Creating web resource...",
                Work = (w, e2) =>
                {
                    // This code is executed in another thread
                    CreateWebResource(script);

                    w.ReportProgress(-1, "Web resource created successfully.");
                    e2.Result = 1;
                },
                ProgressChanged = e2 =>
                {
                    SetWorkingMessage(e2.UserState.ToString());
                },
                PostWorkCallBack = e2 =>
                {
                    EnableWRInputs();
                },
                AsyncArgument = null,
                // Progress information panel size
                MessageWidth = 340,
                MessageHeight = 150
            });
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        private void txt_fetch_TextChanged(object sender, EventArgs e)
        {
            //DisableWRInputs();
        }

        private void EnableWRInputs()
        {
            box_Solution.Enabled = true;
            txt_WRName.Enabled = true;
            txt_WRDisplayName.Enabled = true;
            txt_WRDesc.Enabled = true;
            btn_CreateWR.Enabled = true;
        }

        private void DisableWRInputs()
        {
            box_Solution.Enabled = false;
            txt_WRName.Enabled = false;
            txt_WRDisplayName.Enabled = false;
            txt_WRDesc.Enabled = false;
            btn_CreateWR.Enabled = false;
        }

        private void RetrieveSolutions()
        {
            QueryExpression query = new QueryExpression
            {
                EntityName = "solution",
                ColumnSet = new ColumnSet("uniquename"),
                Criteria = new FilterExpression()
            };

            query.Criteria.AddCondition("ismanaged", ConditionOperator.Equal, false);

            try
            {
                foreach (Entity solution in Service.RetrieveMultiple(query).Entities)
                {
                    if (solution["uniquename"].ToString() != "System" && solution["uniquename"].ToString() != "Active" && solution["uniquename"].ToString() != "Basic" && solution["uniquename"].ToString() != "ActivityFeeds")
                    {
                        box_Solution.Items.Add(solution["uniquename"]);
                    }
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void box_Solution_Click(object sender, EventArgs e)
        {
            box_Solution.Items.Clear();
            RetrieveSolutions();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_script.Text);

            MessageBox.Show("Copied to clipboard!");
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