namespace ClipLab.Forms
{
    partial class FormEdit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtBoxInput1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.btnBrowseInput2 = new System.Windows.Forms.Button();
            this.btnBrowseInput1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSaveAudio = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.lbl2tab2 = new System.Windows.Forms.Label();
            this.lbl1tab2 = new System.Windows.Forms.Label();
            this.txtSaveVideo = new System.Windows.Forms.TextBox();
            this.txtOpenVideo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTab3Time = new System.Windows.Forms.Label();
            this.lblTab3Save = new System.Windows.Forms.Label();
            this.lblTab3 = new System.Windows.Forms.Label();
            this.lblTire = new System.Windows.Forms.Label();
            this.txtTab3Input = new System.Windows.Forms.TextBox();
            this.btnTab3Input = new System.Windows.Forms.Button();
            this.txtTab3Output = new System.Windows.Forms.TextBox();
            this.btnTab3Output = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl3);
            this.tabPage1.Controls.Add(this.lbl2);
            this.tabPage1.Controls.Add(this.btnBrowseOutput);
            this.tabPage1.Controls.Add(this.txtBoxInput1);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Controls.Add(this.txtBoxOutput);
            this.tabPage1.Controls.Add(this.txtBoxInput2);
            this.tabPage1.Controls.Add(this.btnConcatenate);
            this.tabPage1.Controls.Add(this.btnBrowseInput2);
            this.tabPage1.Controls.Add(this.btnBrowseInput1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Об\'єднання";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(72, 192);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(323, 25);
            this.lbl3.TabIndex = 35;
            this.lbl3.Text = "Шлях збереження об\'єднаних відео";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(72, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(78, 25);
            this.lbl2.TabIndex = 34;
            this.lbl2.Text = "2 Відео:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOutput.Image = global::ClipLab.Properties.Resources.icons8_opened_folder_50;
            this.btnBrowseOutput.Location = new System.Drawing.Point(505, 205);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(83, 49);
            this.btnBrowseOutput.TabIndex = 33;
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtBoxInput1
            // 
            this.txtBoxInput1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxInput1.Location = new System.Drawing.Point(73, 68);
            this.txtBoxInput1.Name = "txtBoxInput1";
            this.txtBoxInput1.ReadOnly = true;
            this.txtBoxInput1.Size = new System.Drawing.Size(394, 29);
            this.txtBoxInput1.TabIndex = 27;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(72, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 25);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "1 Відео:";
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxOutput.Location = new System.Drawing.Point(73, 231);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.Size = new System.Drawing.Size(394, 29);
            this.txtBoxOutput.TabIndex = 32;
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxInput2.Location = new System.Drawing.Point(73, 137);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.ReadOnly = true;
            this.txtBoxInput2.Size = new System.Drawing.Size(394, 29);
            this.txtBoxInput2.TabIndex = 28;
            // 
            // btnConcatenate
            // 
            this.btnConcatenate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConcatenate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcatenate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConcatenate.Location = new System.Drawing.Point(244, 297);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(271, 94);
            this.btnConcatenate.TabIndex = 31;
            this.btnConcatenate.Text = "ОБ\'ЄДНАТИ";
            this.btnConcatenate.UseVisualStyleBackColor = true;
            this.btnConcatenate.Click += new System.EventHandler(this.btnConcatenate_Click);
            // 
            // btnBrowseInput2
            // 
            this.btnBrowseInput2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseInput2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseInput2.Image = global::ClipLab.Properties.Resources.icons8_opened_folder_50;
            this.btnBrowseInput2.Location = new System.Drawing.Point(505, 113);
            this.btnBrowseInput2.Name = "btnBrowseInput2";
            this.btnBrowseInput2.Size = new System.Drawing.Size(83, 47);
            this.btnBrowseInput2.TabIndex = 29;
            this.btnBrowseInput2.UseVisualStyleBackColor = true;
            this.btnBrowseInput2.Click += new System.EventHandler(this.btnBrowseInput2_Click);
            // 
            // btnBrowseInput1
            // 
            this.btnBrowseInput1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseInput1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseInput1.Image = global::ClipLab.Properties.Resources.icons8_opened_folder_50;
            this.btnBrowseInput1.Location = new System.Drawing.Point(505, 46);
            this.btnBrowseInput1.Name = "btnBrowseInput1";
            this.btnBrowseInput1.Size = new System.Drawing.Size(83, 45);
            this.btnBrowseInput1.TabIndex = 30;
            this.btnBrowseInput1.UseVisualStyleBackColor = true;
            this.btnBrowseInput1.Click += new System.EventHandler(this.btnBrowseInput1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConvert);
            this.tabPage2.Controls.Add(this.btnSaveAudio);
            this.tabPage2.Controls.Add(this.btnOpenVideo);
            this.tabPage2.Controls.Add(this.lbl2tab2);
            this.tabPage2.Controls.Add(this.lbl1tab2);
            this.tabPage2.Controls.Add(this.txtSaveVideo);
            this.tabPage2.Controls.Add(this.txtOpenVideo);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MP4 у MP3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(140, 263);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(511, 61);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "ОБРОБИТИ";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSaveAudio
            // 
            this.btnSaveAudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAudio.Image = global::ClipLab.Properties.Resources.icons8_opened_folder_50;
            this.btnSaveAudio.Location = new System.Drawing.Point(576, 174);
            this.btnSaveAudio.Name = "btnSaveAudio";
            this.btnSaveAudio.Size = new System.Drawing.Size(75, 69);
            this.btnSaveAudio.TabIndex = 5;
            this.btnSaveAudio.UseVisualStyleBackColor = true;
            this.btnSaveAudio.Click += new System.EventHandler(this.btnSaveAudio_Click);
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenVideo.Image = global::ClipLab.Properties.Resources.icons8_opened_folder_50;
            this.btnOpenVideo.Location = new System.Drawing.Point(576, 83);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(75, 62);
            this.btnOpenVideo.TabIndex = 4;
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // lbl2tab2
            // 
            this.lbl2tab2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2tab2.AutoSize = true;
            this.lbl2tab2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2tab2.Location = new System.Drawing.Point(140, 174);
            this.lbl2tab2.Name = "lbl2tab2";
            this.lbl2tab2.Size = new System.Drawing.Size(213, 25);
            this.lbl2tab2.TabIndex = 3;
            this.lbl2tab2.Text = "Шлях збереження MP3";
            // 
            // lbl1tab2
            // 
            this.lbl1tab2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1tab2.AutoSize = true;
            this.lbl1tab2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1tab2.Location = new System.Drawing.Point(140, 83);
            this.lbl1tab2.Name = "lbl1tab2";
            this.lbl1tab2.Size = new System.Drawing.Size(262, 25);
            this.lbl1tab2.TabIndex = 2;
            this.lbl1tab2.Text = "Вставте відео у форматі MP4";
            // 
            // txtSaveVideo
            // 
            this.txtSaveVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaveVideo.Location = new System.Drawing.Point(140, 208);
            this.txtSaveVideo.Name = "txtSaveVideo";
            this.txtSaveVideo.ReadOnly = true;
            this.txtSaveVideo.Size = new System.Drawing.Size(416, 29);
            this.txtSaveVideo.TabIndex = 1;
            // 
            // txtOpenVideo
            // 
            this.txtOpenVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpenVideo.Location = new System.Drawing.Point(140, 116);
            this.txtOpenVideo.Name = "txtOpenVideo";
            this.txtOpenVideo.ReadOnly = true;
            this.txtOpenVideo.Size = new System.Drawing.Size(416, 29);
            this.txtOpenVideo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTab3Time);
            this.tabPage3.Controls.Add(this.lblTab3Save);
            this.tabPage3.Controls.Add(this.lblTab3);
            this.tabPage3.Controls.Add(this.lblTire);
            this.tabPage3.Controls.Add(this.txtTab3Input);
            this.tabPage3.Controls.Add(this.btnTab3Input);
            this.tabPage3.Controls.Add(this.txtTab3Output);
            this.tabPage3.Controls.Add(this.btnTab3Output);
            this.tabPage3.Controls.Add(this.btnTrim);
            this.tabPage3.Controls.Add(this.txtEndTime);
            this.tabPage3.Controls.Add(this.txtStartTime);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Кліп";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTab3Time
            // 
            this.lblTab3Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTab3Time.AutoSize = true;
            this.lblTab3Time.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTab3Time.Location = new System.Drawing.Point(177, 207);
            this.lblTab3Time.Name = "lblTab3Time";
            this.lblTab3Time.Size = new System.Drawing.Size(140, 25);
            this.lblTab3Time.TabIndex = 10;
            this.lblTab3Time.Text = "таймкоди (сек)";
            // 
            // lblTab3Save
            // 
            this.lblTab3Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTab3Save.AutoSize = true;
            this.lblTab3Save.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTab3Save.Location = new System.Drawing.Point(170, 144);
            this.lblTab3Save.Name = "lblTab3Save";
            this.lblTab3Save.Size = new System.Drawing.Size(222, 25);
            this.lblTab3Save.TabIndex = 9;
            this.lblTab3Save.Text = "Шлях збереження Кліпа";
            // 
            // lblTab3
            // 
            this.lblTab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTab3.AutoSize = true;
            this.lblTab3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTab3.Location = new System.Drawing.Point(170, 58);
            this.lblTab3.Name = "lblTab3";
            this.lblTab3.Size = new System.Drawing.Size(262, 25);
            this.lblTab3.TabIndex = 8;
            this.lblTab3.Text = "Вставте відео у форматі MP4";
            // 
            // lblTire
            // 
            this.lblTire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTire.AutoSize = true;
            this.lblTire.Location = new System.Drawing.Point(348, 238);
            this.lblTire.Name = "lblTire";
            this.lblTire.Size = new System.Drawing.Size(26, 21);
            this.lblTire.TabIndex = 7;
            this.lblTire.Text = "—";
            // 
            // txtTab3Input
            // 
            this.txtTab3Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTab3Input.Location = new System.Drawing.Point(173, 100);
            this.txtTab3Input.Name = "txtTab3Input";
            this.txtTab3Input.ReadOnly = true;
            this.txtTab3Input.Size = new System.Drawing.Size(287, 29);
            this.txtTab3Input.TabIndex = 6;
            // 
            // btnTab3Input
            // 
            this.btnTab3Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTab3Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab3Input.Image = global::ClipLab.Properties.Resources.icons8_opened_folder_50;
            this.btnTab3Input.Location = new System.Drawing.Point(469, 70);
            this.btnTab3Input.Name = "btnTab3Input";
            this.btnTab3Input.Size = new System.Drawing.Size(76, 59);
            this.btnTab3Input.TabIndex = 5;
            this.btnTab3Input.UseVisualStyleBackColor = true;
            this.btnTab3Input.Click += new System.EventHandler(this.btnTab3Input_Click);
            // 
            // txtTab3Output
            // 
            this.txtTab3Output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTab3Output.Location = new System.Drawing.Point(173, 172);
            this.txtTab3Output.Name = "txtTab3Output";
            this.txtTab3Output.ReadOnly = true;
            this.txtTab3Output.Size = new System.Drawing.Size(287, 29);
            this.txtTab3Output.TabIndex = 4;
            // 
            // btnTab3Output
            // 
            this.btnTab3Output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTab3Output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab3Output.Image = global::ClipLab.Properties.Resources.icons8_opened_folder_50;
            this.btnTab3Output.Location = new System.Drawing.Point(469, 144);
            this.btnTab3Output.Name = "btnTab3Output";
            this.btnTab3Output.Size = new System.Drawing.Size(77, 57);
            this.btnTab3Output.TabIndex = 3;
            this.btnTab3Output.UseVisualStyleBackColor = true;
            this.btnTab3Output.Click += new System.EventHandler(this.btnTab3Output_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrim.Location = new System.Drawing.Point(177, 284);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(369, 48);
            this.btnTrim.TabIndex = 2;
            this.btnTrim.Text = "ЗРОБИТИ КЛІП";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // txtEndTime
            // 
            this.txtEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndTime.Location = new System.Drawing.Point(392, 235);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(154, 29);
            this.txtEndTime.TabIndex = 1;
            this.txtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStartTime.Location = new System.Drawing.Point(173, 235);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(159, 29);
            this.txtStartTime.TabIndex = 0;
            this.txtStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormEdit";
            this.Text = "РЕДАКТУВАТИ";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lbl3;
        private Label lbl2;
        private Button btnBrowseOutput;
        private TextBox txtBoxInput1;
        private Label lbl1;
        private TextBox txtBoxOutput;
        private TextBox txtBoxInput2;
        private Button btnConcatenate;
        private Button btnBrowseInput2;
        private Button btnBrowseInput1;
        private TabPage tabPage2;
        private Button btnConvert;
        private Button btnSaveAudio;
        private Button btnOpenVideo;
        private Label lbl2tab2;
        private Label lbl1tab2;
        private TextBox txtSaveVideo;
        private TextBox txtOpenVideo;
        private TabPage tabPage3;
        private TextBox txtTab3Input;
        private Button btnTab3Input;
        private TextBox txtTab3Output;
        private Button btnTab3Output;
        private Button btnTrim;
        private TextBox txtEndTime;
        private TextBox txtStartTime;
        private Label lblTab3;
        private Label lblTire;
        private Label lblTab3Time;
        private Label lblTab3Save;
    }
}