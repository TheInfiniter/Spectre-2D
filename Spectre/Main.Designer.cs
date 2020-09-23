namespace Spectre
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbInitial = new System.Windows.Forms.PictureBox();
            this.btnInitial = new System.Windows.Forms.Button();
            this.txtDomeAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbSpectre = new System.Windows.Forms.PictureBox();
            this.pcbFilter = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDispMax = new System.Windows.Forms.TextBox();
            this.txtAmpMax = new System.Windows.Forms.TextBox();
            this.txtDispMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmpMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoisePercent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateSpectre = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterPercent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.radioUpload = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.btnStretch = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetNoise = new System.Windows.Forms.Button();
            this.labelSKO = new System.Windows.Forms.Label();
            this.chkLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpectre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFilter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbInitial
            // 
            this.pcbInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbInitial.Location = new System.Drawing.Point(11, 13);
            this.pcbInitial.Margin = new System.Windows.Forms.Padding(4);
            this.pcbInitial.Name = "pcbInitial";
            this.pcbInitial.Size = new System.Drawing.Size(512, 512);
            this.pcbInitial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbInitial.TabIndex = 0;
            this.pcbInitial.TabStop = false;
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(7, 22);
            this.btnInitial.Margin = new System.Windows.Forms.Padding(4);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(119, 60);
            this.btnInitial.TabIndex = 1;
            this.btnInitial.Text = "Создать изображение";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // txtDomeAmount
            // 
            this.txtDomeAmount.Location = new System.Drawing.Point(111, 23);
            this.txtDomeAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomeAmount.Name = "txtDomeAmount";
            this.txtDomeAmount.Size = new System.Drawing.Size(44, 22);
            this.txtDomeAmount.TabIndex = 2;
            this.txtDomeAmount.Text = "75";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbSpectre
            // 
            this.pcbSpectre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbSpectre.Location = new System.Drawing.Point(531, 13);
            this.pcbSpectre.Margin = new System.Windows.Forms.Padding(4);
            this.pcbSpectre.Name = "pcbSpectre";
            this.pcbSpectre.Size = new System.Drawing.Size(512, 512);
            this.pcbSpectre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSpectre.TabIndex = 4;
            this.pcbSpectre.TabStop = false;
            // 
            // pcbFilter
            // 
            this.pcbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFilter.Location = new System.Drawing.Point(1051, 13);
            this.pcbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.pcbFilter.Name = "pcbFilter";
            this.pcbFilter.Size = new System.Drawing.Size(512, 512);
            this.pcbFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFilter.TabIndex = 5;
            this.pcbFilter.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDispMax);
            this.groupBox1.Controls.Add(this.txtAmpMax);
            this.groupBox1.Controls.Add(this.txtDispMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAmpMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDomeAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 535);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(273, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Купола";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(164, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(164, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDispMax
            // 
            this.txtDispMax.Location = new System.Drawing.Point(195, 87);
            this.txtDispMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtDispMax.Name = "txtDispMax";
            this.txtDispMax.Size = new System.Drawing.Size(44, 22);
            this.txtDispMax.TabIndex = 9;
            this.txtDispMax.Text = "2";
            // 
            // txtAmpMax
            // 
            this.txtAmpMax.Location = new System.Drawing.Point(195, 55);
            this.txtAmpMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmpMax.Name = "txtAmpMax";
            this.txtAmpMax.Size = new System.Drawing.Size(44, 22);
            this.txtAmpMax.TabIndex = 8;
            this.txtAmpMax.Text = "2";
            // 
            // txtDispMin
            // 
            this.txtDispMin.Location = new System.Drawing.Point(111, 87);
            this.txtDispMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtDispMin.Name = "txtDispMin";
            this.txtDispMin.Size = new System.Drawing.Size(44, 22);
            this.txtDispMin.TabIndex = 6;
            this.txtDispMin.Text = "1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дисперсия";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmpMin
            // 
            this.txtAmpMin.Location = new System.Drawing.Point(111, 55);
            this.txtAmpMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmpMin.Name = "txtAmpMin";
            this.txtAmpMin.Size = new System.Drawing.Size(44, 22);
            this.txtAmpMin.TabIndex = 4;
            this.txtAmpMin.Text = "1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Амплитуда";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(110, 23);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(44, 22);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.Text = "142";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ширина";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(110, 55);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(44, 22);
            this.txtHeight.TabIndex = 14;
            this.txtHeight.Text = "128";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Высота";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoisePercent
            // 
            this.txtNoisePercent.Location = new System.Drawing.Point(110, 23);
            this.txtNoisePercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoisePercent.Name = "txtNoisePercent";
            this.txtNoisePercent.Size = new System.Drawing.Size(44, 22);
            this.txtNoisePercent.TabIndex = 12;
            this.txtNoisePercent.Text = "5";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Шум, %";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateSpectre
            // 
            this.btnCreateSpectre.Enabled = false;
            this.btnCreateSpectre.Location = new System.Drawing.Point(7, 22);
            this.btnCreateSpectre.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateSpectre.Name = "btnCreateSpectre";
            this.btnCreateSpectre.Size = new System.Drawing.Size(115, 60);
            this.btnCreateSpectre.TabIndex = 16;
            this.btnCreateSpectre.Text = "Создать спектр";
            this.btnCreateSpectre.UseVisualStyleBackColor = true;
            this.btnCreateSpectre.Click += new System.EventHandler(this.btnCreateSpectre_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(130, 22);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(115, 60);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterPercent
            // 
            this.txtFilterPercent.Location = new System.Drawing.Point(110, 55);
            this.txtFilterPercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterPercent.Name = "txtFilterPercent";
            this.txtFilterPercent.Size = new System.Drawing.Size(44, 22);
            this.txtFilterPercent.TabIndex = 18;
            this.txtFilterPercent.Text = "99";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Фильтр, %";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWidth
            // 
            this.labelWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWidth.Location = new System.Drawing.Point(162, 23);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(52, 22);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "0";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeight
            // 
            this.labelHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHeight.Location = new System.Drawing.Point(162, 55);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(52, 22);
            this.labelHeight.TabIndex = 20;
            this.labelHeight.Text = "0";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelHeight);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.labelWidth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Location = new System.Drawing.Point(296, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 123);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размеры";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNoisePercent);
            this.groupBox3.Controls.Add(this.txtFilterPercent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(529, 535);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 123);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шум и фильтрация";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpload);
            this.groupBox4.Controls.Add(this.radioUpload);
            this.groupBox4.Controls.Add(this.radioCreate);
            this.groupBox4.Controls.Add(this.btnInitial);
            this.groupBox4.Location = new System.Drawing.Point(701, 535);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 123);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Изображение";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(134, 23);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(113, 60);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Загрузить изображение";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // radioUpload
            // 
            this.radioUpload.Location = new System.Drawing.Point(140, 88);
            this.radioUpload.Name = "radioUpload";
            this.radioUpload.Size = new System.Drawing.Size(107, 24);
            this.radioUpload.TabIndex = 19;
            this.radioUpload.TabStop = true;
            this.radioUpload.Text = "Загрузить";
            this.radioUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioUpload.UseVisualStyleBackColor = true;
            this.radioUpload.CheckedChanged += new System.EventHandler(this.radioUpload_CheckedChanged);
            // 
            // radioCreate
            // 
            this.radioCreate.Location = new System.Drawing.Point(22, 88);
            this.radioCreate.Name = "radioCreate";
            this.radioCreate.Size = new System.Drawing.Size(90, 24);
            this.radioCreate.TabIndex = 0;
            this.radioCreate.TabStop = true;
            this.radioCreate.Text = "Создать";
            this.radioCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCreate.UseVisualStyleBackColor = true;
            this.radioCreate.CheckedChanged += new System.EventHandler(this.radioCreate_CheckedChanged);
            // 
            // btnStretch
            // 
            this.btnStretch.Enabled = false;
            this.btnStretch.Location = new System.Drawing.Point(130, 22);
            this.btnStretch.Margin = new System.Windows.Forms.Padding(4);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(115, 60);
            this.btnStretch.TabIndex = 18;
            this.btnStretch.Text = "Растянуть";
            this.btnStretch.UseVisualStyleBackColor = true;
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkLog);
            this.groupBox5.Controls.Add(this.btnFilter);
            this.groupBox5.Controls.Add(this.btnCreateSpectre);
            this.groupBox5.Location = new System.Drawing.Point(1221, 535);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 123);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтрация";
            // 
            // dialogOpenFile
            // 
            this.dialogOpenFile.FileName = "dialogOpenFile";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetNoise);
            this.groupBox6.Controls.Add(this.btnStretch);
            this.groupBox6.Location = new System.Drawing.Point(961, 535);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 123);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Управление";
            // 
            // btnSetNoise
            // 
            this.btnSetNoise.Enabled = false;
            this.btnSetNoise.Location = new System.Drawing.Point(7, 23);
            this.btnSetNoise.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetNoise.Name = "btnSetNoise";
            this.btnSetNoise.Size = new System.Drawing.Size(115, 60);
            this.btnSetNoise.TabIndex = 19;
            this.btnSetNoise.Text = "Наложить шум";
            this.btnSetNoise.UseVisualStyleBackColor = true;
            this.btnSetNoise.Click += new System.EventHandler(this.btnSetNoise_Click);
            // 
            // labelSKO
            // 
            this.labelSKO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSKO.Location = new System.Drawing.Point(1481, 577);
            this.labelSKO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSKO.Name = "labelSKO";
            this.labelSKO.Size = new System.Drawing.Size(82, 22);
            this.labelSKO.TabIndex = 21;
            this.labelSKO.Text = "0";
            this.labelSKO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkLog
            // 
            this.chkLog.Location = new System.Drawing.Point(7, 89);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(238, 24);
            this.chkLog.TabIndex = 27;
            this.chkLog.Text = "Логарифмический масштаб";
            this.chkLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 663);
            this.Controls.Add(this.labelSKO);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbFilter);
            this.Controls.Add(this.pcbSpectre);
            this.Controls.Add(this.pcbInitial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpectre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFilter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbInitial;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.TextBox txtDomeAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbSpectre;
        private System.Windows.Forms.PictureBox pcbFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDispMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmpMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDispMax;
        private System.Windows.Forms.TextBox txtAmpMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoisePercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateSpectre;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStretch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.RadioButton radioUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog dialogOpenFile;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetNoise;
        private System.Windows.Forms.Label labelSKO;
        private System.Windows.Forms.CheckBox chkLog;
    }
}

