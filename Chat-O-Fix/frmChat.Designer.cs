namespace Chat_O_Fix
{
    partial class frmChat
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.tmrQuoteChecker = new System.Windows.Forms.Timer(this.components);
            this.txtChatQuots = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtQuote
            // 
            this.txtQuote.Location = new System.Drawing.Point(15, 321);
            this.txtQuote.Multiline = true;
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.Size = new System.Drawing.Size(434, 45);
            this.txtQuote.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(465, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 45);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send...";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(67, 289);
            this.txtAlias.MaxLength = 10;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(151, 20);
            this.txtAlias.TabIndex = 1;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(12, 292);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(49, 13);
            this.lblAlias.TabIndex = 4;
            this.lblAlias.Text = "My Alias:";
            // 
            // tmrQuoteChecker
            // 
            this.tmrQuoteChecker.Enabled = true;
            this.tmrQuoteChecker.Interval = 500;
            this.tmrQuoteChecker.Tick += new System.EventHandler(this.tmrQuoteChecker_Tick);
            // 
            // txtChatQuots
            // 
            this.txtChatQuots.Location = new System.Drawing.Point(6, 6);
            this.txtChatQuots.Multiline = true;
            this.txtChatQuots.Name = "txtChatQuots";
            this.txtChatQuots.Size = new System.Drawing.Size(547, 265);
            this.txtChatQuots.TabIndex = 5;
            // 
            // frmChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 387);
            this.Controls.Add(this.txtChatQuots);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChat";
            this.Text = "Chat-O-Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuote;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Timer tmrQuoteChecker;
        private System.Windows.Forms.TextBox txtChatQuots;
    }
}

