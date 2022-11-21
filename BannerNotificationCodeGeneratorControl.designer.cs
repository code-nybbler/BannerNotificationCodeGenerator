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
            this.btn_CreateWR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_WRDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_WRDisplayName = new System.Windows.Forms.TextBox();
            this.txt_WRName = new System.Windows.Forms.TextBox();
            this.box_Solution = new System.Windows.Forms.ComboBox();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.txt_fetch.TextChanged += new System.EventHandler(this.txt_fetch_TextChanged);
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
            this.txt_script.Size = new System.Drawing.Size(1060, 499);
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
            this.btn_Copy.Location = new System.Drawing.Point(2058, 229);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 36);
            this.btn_Copy.TabIndex = 15;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_CreateWR
            // 
            this.btn_CreateWR.Enabled = false;
            this.btn_CreateWR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateWR.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_CreateWR.Location = new System.Drawing.Point(979, 68);
            this.btn_CreateWR.Name = "btn_CreateWR";
            this.btn_CreateWR.Size = new System.Drawing.Size(75, 36);
            this.btn_CreateWR.TabIndex = 16;
            this.btn_CreateWR.Text = "Create";
            this.btn_CreateWR.UseVisualStyleBackColor = true;
            this.btn_CreateWR.Click += new System.EventHandler(this.btn_CreateWR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txt_WRDesc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_WRDisplayName);
            this.groupBox1.Controls.Add(this.txt_WRName);
            this.groupBox1.Controls.Add(this.box_Solution);
            this.groupBox1.Controls.Add(this.btn_CreateWR);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(1073, 776);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 237);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web Resource Generation";
            // 
            // txt_WRDesc
            // 
            this.txt_WRDesc.Enabled = false;
            this.txt_WRDesc.Location = new System.Drawing.Point(6, 110);
            this.txt_WRDesc.Multiline = true;
            this.txt_WRDesc.Name = "txt_WRDesc";
            this.txt_WRDesc.Size = new System.Drawing.Size(1048, 121);
            this.txt_WRDesc.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Display Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name (include prefix)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Solution";
            // 
            // txt_WRDisplayName
            // 
            this.txt_WRDisplayName.Enabled = false;
            this.txt_WRDisplayName.Location = new System.Drawing.Point(542, 56);
            this.txt_WRDisplayName.Name = "txt_WRDisplayName";
            this.txt_WRDisplayName.Size = new System.Drawing.Size(262, 26);
            this.txt_WRDisplayName.TabIndex = 19;
            // 
            // txt_WRName
            // 
            this.txt_WRName.Enabled = false;
            this.txt_WRName.Location = new System.Drawing.Point(274, 56);
            this.txt_WRName.Name = "txt_WRName";
            this.txt_WRName.Size = new System.Drawing.Size(262, 26);
            this.txt_WRName.TabIndex = 18;
            // 
            // box_Solution
            // 
            this.box_Solution.Enabled = false;
            this.box_Solution.FormattingEnabled = true;
            this.box_Solution.Location = new System.Drawing.Point(6, 56);
            this.box_Solution.Name = "box_Solution";
            this.box_Solution.Size = new System.Drawing.Size(262, 28);
            this.box_Solution.TabIndex = 17;
            this.box_Solution.Click += new System.EventHandler(this.box_Solution_Click);
            // 
            // BannerNotificationCodeGeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btn_CreateWR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_WRDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_WRDisplayName;
        private System.Windows.Forms.TextBox txt_WRName;
        private System.Windows.Forms.ComboBox box_Solution;
    }
}
