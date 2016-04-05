namespace SMSSender
{
    partial class HTTPSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTTPSetup));
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.parameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.cmbProtocol.Location = new System.Drawing.Point(7, 7);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(71, 21);
            this.cmbProtocol.TabIndex = 0;
            this.cmbProtocol.Tag = "";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(84, 8);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(320, 20);
            this.txtURL.TabIndex = 1;
            // 
            // dgvParams
            // 
            this.dgvParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameterName,
            this.parameterValue});
            this.dgvParams.Location = new System.Drawing.Point(7, 34);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.Size = new System.Drawing.Size(397, 140);
            this.dgvParams.TabIndex = 2;
            // 
            // parameterName
            // 
            this.parameterName.HeaderText = "Parameter";
            this.parameterName.Name = "parameterName";
            // 
            // parameterValue
            // 
            this.parameterValue.HeaderText = "Value";
            this.parameterValue.Name = "parameterValue";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(397, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HTTPSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 212);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvParams);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.cmbProtocol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HTTPSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTPSetup";
            this.Load += new System.EventHandler(this.HTTPSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProtocol;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterValue;
    }
}