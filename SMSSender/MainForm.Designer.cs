namespace SMSSender
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.message = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.httpSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.abtLbl = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.isUnicode = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Location = new System.Drawing.Point(4, 55);
            this.message.MaxLength = 160;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(338, 160);
            this.message.TabIndex = 0;
            this.message.Text = "";
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.abtLbl});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settings
            // 
            this.settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpSetup});
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(58, 20);
            this.settings.Text = "Settings";
            // 
            // httpSetup
            // 
            this.httpSetup.Name = "httpSetup";
            this.httpSetup.Size = new System.Drawing.Size(150, 22);
            this.httpSetup.Text = "HTTP API Setup";
            this.httpSetup.Click += new System.EventHandler(this.httpSetup_Click);
            // 
            // abtLbl
            // 
            this.abtLbl.Name = "abtLbl";
            this.abtLbl.Size = new System.Drawing.Size(48, 20);
            this.abtLbl.Text = "About";
            this.abtLbl.Click += new System.EventHandler(this.abtLbl_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(346, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stLbl
            // 
            this.stLbl.Name = "stLbl";
            this.stLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Location = new System.Drawing.Point(4, 223);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(338, 23);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "To:";
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.to.Location = new System.Drawing.Point(30, 31);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(249, 20);
            this.to.TabIndex = 5;
            // 
            // isUnicode
            // 
            this.isUnicode.AutoSize = true;
            this.isUnicode.Location = new System.Drawing.Point(282, 32);
            this.isUnicode.Name = "isUnicode";
            this.isUnicode.Size = new System.Drawing.Size(66, 17);
            this.isUnicode.TabIndex = 6;
            this.isUnicode.Text = "Unicode";
            this.isUnicode.UseVisualStyleBackColor = true;
            this.isUnicode.CheckedChanged += new System.EventHandler(this.isUnicode_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 275);
            this.Controls.Add(this.isUnicode);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTP SMS Sender";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem httpSetup;
        private System.Windows.Forms.ToolStripMenuItem abtLbl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stLbl;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.CheckBox isUnicode;
    }
}

