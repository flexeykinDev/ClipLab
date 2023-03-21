namespace Kursach.Forms
{
    partial class FormDownload
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
            this.panelDownloadBase = new System.Windows.Forms.Panel();
            this.labelDownloadTip = new System.Windows.Forms.Label();
            this.labelHelpInput = new System.Windows.Forms.Label();
            this.buttonDownloadSender = new System.Windows.Forms.Button();
            this.textboxInputURL = new System.Windows.Forms.TextBox();
            this.panelDownloadBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDownloadBase
            // 
            this.panelDownloadBase.Controls.Add(this.labelDownloadTip);
            this.panelDownloadBase.Controls.Add(this.labelHelpInput);
            this.panelDownloadBase.Controls.Add(this.buttonDownloadSender);
            this.panelDownloadBase.Controls.Add(this.textboxInputURL);
            this.panelDownloadBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDownloadBase.Location = new System.Drawing.Point(0, 0);
            this.panelDownloadBase.Name = "panelDownloadBase";
            this.panelDownloadBase.Size = new System.Drawing.Size(800, 450);
            this.panelDownloadBase.TabIndex = 0;
            this.panelDownloadBase.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDownloadBase_Paint);
            // 
            // labelDownloadTip
            // 
            this.labelDownloadTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDownloadTip.AutoSize = true;
            this.labelDownloadTip.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDownloadTip.Location = new System.Drawing.Point(321, 244);
            this.labelDownloadTip.Name = "labelDownloadTip";
            this.labelDownloadTip.Size = new System.Drawing.Size(170, 28);
            this.labelDownloadTip.TabIndex = 3;
            this.labelDownloadTip.Text = "Праймери Колар";
            // 
            // labelHelpInput
            // 
            this.labelHelpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelpInput.AutoSize = true;
            this.labelHelpInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHelpInput.Location = new System.Drawing.Point(342, 109);
            this.labelHelpInput.Name = "labelHelpInput";
            this.labelHelpInput.Size = new System.Drawing.Size(139, 28);
            this.labelHelpInput.TabIndex = 2;
            this.labelHelpInput.Text = "Вставь ссылку";
            // 
            // buttonDownloadSender
            // 
            this.buttonDownloadSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadSender.Location = new System.Drawing.Point(257, 289);
            this.buttonDownloadSender.Name = "buttonDownloadSender";
            this.buttonDownloadSender.Size = new System.Drawing.Size(300, 46);
            this.buttonDownloadSender.TabIndex = 1;
            this.buttonDownloadSender.Text = "типа скачать";
            this.buttonDownloadSender.UseVisualStyleBackColor = true;
            // 
            // textboxInputURL
            // 
            this.textboxInputURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxInputURL.Location = new System.Drawing.Point(257, 151);
            this.textboxInputURL.Name = "textboxInputURL";
            this.textboxInputURL.Size = new System.Drawing.Size(300, 23);
            this.textboxInputURL.TabIndex = 0;
            // 
            // FormDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDownloadBase);
            this.Name = "FormDownload";
            this.Text = "Скачать";
            this.Load += new System.EventHandler(this.FormDownload_Load);
            this.panelDownloadBase.ResumeLayout(false);
            this.panelDownloadBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDownloadBase;
        private Button buttonDownloadSender;
        private TextBox textboxInputURL;
        private Label labelHelpInput;
        private Label labelDownloadTip;
    }
}