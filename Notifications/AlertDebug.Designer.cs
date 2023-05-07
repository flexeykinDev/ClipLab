namespace ClipLab.Notifications
{
    partial class AlertDebug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertDebug));
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.Success = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblDebugNotifications = new System.Windows.Forms.Label();
            this.debugLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(761, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Success
            // 
            this.Success.BackColor = System.Drawing.Color.LightGreen;
            this.Success.FlatAppearance.BorderSize = 0;
            this.Success.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Success.ForeColor = System.Drawing.Color.ForestGreen;
            this.Success.Location = new System.Drawing.Point(579, 344);
            this.Success.Margin = new System.Windows.Forms.Padding(0);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(150, 35);
            this.Success.TabIndex = 1;
            this.Success.Text = "Успешно";
            this.Success.UseVisualStyleBackColor = false;
            this.Success.Click += new System.EventHandler(this.Success_Click);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.LightPink;
            this.btnError.FlatAppearance.BorderSize = 0;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.ForeColor = System.Drawing.Color.DarkRed;
            this.btnError.Location = new System.Drawing.Point(406, 344);
            this.btnError.Margin = new System.Windows.Forms.Padding(0);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(150, 35);
            this.btnError.TabIndex = 2;
            this.btnError.Text = "Ошибка :(";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnWarning.FlatAppearance.BorderSize = 0;
            this.btnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarning.ForeColor = System.Drawing.Color.Gold;
            this.btnWarning.Location = new System.Drawing.Point(236, 344);
            this.btnWarning.Margin = new System.Windows.Forms.Padding(0);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(150, 35);
            this.btnWarning.TabIndex = 3;
            this.btnWarning.Text = "Предупреждение";
            this.btnWarning.UseVisualStyleBackColor = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.LightCyan;
            this.btnHint.FlatAppearance.BorderSize = 0;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnHint.Location = new System.Drawing.Point(63, 344);
            this.btnHint.Margin = new System.Windows.Forms.Padding(0);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(150, 35);
            this.btnHint.TabIndex = 4;
            this.btnHint.Text = "Подсказка";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblDebugNotifications
            // 
            this.lblDebugNotifications.AutoSize = true;
            this.lblDebugNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))));
            this.lblDebugNotifications.ForeColor = System.Drawing.Color.White;
            this.lblDebugNotifications.Location = new System.Drawing.Point(330, 291);
            this.lblDebugNotifications.Name = "lblDebugNotifications";
            this.lblDebugNotifications.Size = new System.Drawing.Size(154, 15);
            this.lblDebugNotifications.TabIndex = 5;
            this.lblDebugNotifications.Text = "Debug меню уведомлений";
            // 
            // debugLogo
            // 
            this.debugLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))));
            this.debugLogo.Image = ((System.Drawing.Image)(resources.GetObject("debugLogo.Image")));
            this.debugLogo.Location = new System.Drawing.Point(171, 103);
            this.debugLogo.Margin = new System.Windows.Forms.Padding(0);
            this.debugLogo.Name = "debugLogo";
            this.debugLogo.Size = new System.Drawing.Size(471, 188);
            this.debugLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.debugLogo.TabIndex = 6;
            this.debugLogo.TabStop = false;
            // 
            // AlertDebug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 456);
            this.Controls.Add(this.debugLogo);
            this.Controls.Add(this.lblDebugNotifications);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.btnExit);
            this.Name = "AlertDebug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AlertDebug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btnExit;
        private Button Success;
        private Button btnError;
        private Button btnWarning;
        private Button btnHint;
        private Label lblDebugNotifications;
        private PictureBox debugLogo;
    }
}