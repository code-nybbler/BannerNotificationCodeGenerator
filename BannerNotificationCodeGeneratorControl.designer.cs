namespace BannerNotificationCodeGenerator
{
    partial class BannerNotificationCodeGeneratorControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_fetch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_script = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_level = new System.Windows.Forms.CheckedListBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(2145, 34);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(59, 29);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // txt_fetch
            // 
            this.txt_fetch.Location = new System.Drawing.Point(7, 76);
            this.txt_fetch.Multiline = true;
            this.txt_fetch.Name = "txt_fetch";
            this.txt_fetch.Size = new System.Drawing.Size(1060, 937);
            this.txt_fetch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "FetchXML";
            // 
            // btn_Generate
            // 
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Generate.Location = new System.Drawing.Point(1073, 187);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(1060, 36);
            this.btn_Generate.TabIndex = 8;
            this.btn_Generate.Text = "Generate Code";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_script
            // 
            this.txt_script.Location = new System.Drawing.Point(1073, 271);
            this.txt_script.Multiline = true;
            this.txt_script.Name = "txt_script";
            this.txt_script.ReadOnly = true;
            this.txt_script.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_script.Size = new System.Drawing.Size(1060, 742);
            this.txt_script.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1069, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "JavaScript";
            // 
            // lst_level
            // 
            this.lst_level.CheckOnClick = true;
            this.lst_level.FormattingEnabled = true;
            this.lst_level.Items.AddRange(new object[] {
            "INFO",
            "WARNING",
            "ERROR"});
            this.lst_level.Location = new System.Drawing.Point(1073, 108);
            this.lst_level.Name = "lst_level";
            this.lst_level.Size = new System.Drawing.Size(1060, 73);
            this.lst_level.TabIndex = 11;
            this.lst_level.SelectedIndexChanged += new System.EventHandler(this.lst_level_SelectedIndexChanged);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(1073, 76);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(1060, 26);
            this.txt_message.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1069, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Message (this will appear if the query returns a result)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 1016);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "$$ - indicate GUID of current record.";
            // 
            // btn_Copy
            // 
            this.btn_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Copy.Location = new System.Drawing.Point(2056, 229);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 36);
            this.btn_Copy.TabIndex = 15;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // BannerNotificationCodeGeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.lst_level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_script);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fetch);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BannerNotificationCodeGeneratorControl";
            this.Size = new System.Drawing.Size(2145, 1068);
            this.Load += new System.EventHandler(this.BannerNotificationCodeGeneratorControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TextBox txt_fetch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_script;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox lst_level;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Copy;
    }
}
