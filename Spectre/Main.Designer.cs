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
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpectre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFilter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbInitial
            // 
            this.pcbInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbInitial.Location = new System.Drawing.Point(12, 12);
            this.pcbInitial.Name = "pcbInitial";
            this.pcbInitial.Size = new System.Drawing.Size(402, 320);
            this.pcbInitial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbInitial.TabIndex = 0;
            this.pcbInitial.TabStop = false;
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(540, 342);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(90, 49);
            this.btnInitial.TabIndex = 1;
            this.btnInitial.Text = "Создать изображение";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // txtDomeAmount
            // 
            this.txtDomeAmount.Location = new System.Drawing.Point(83, 19);
            this.txtDomeAmount.Name = "txtDomeAmount";
            this.txtDomeAmount.Size = new System.Drawing.Size(34, 20);
            this.txtDomeAmount.TabIndex = 2;
            this.txtDomeAmount.Text = "3";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbSpectre
            // 
            this.pcbSpectre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbSpectre.Location = new System.Drawing.Point(420, 12);
            this.pcbSpectre.Name = "pcbSpectre";
            this.pcbSpectre.Size = new System.Drawing.Size(402, 320);
            this.pcbSpectre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSpectre.TabIndex = 4;
            this.pcbSpectre.TabStop = false;
            // 
            // pcbFilter
            // 
            this.pcbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFilter.Location = new System.Drawing.Point(828, 12);
            this.pcbFilter.Name = "pcbFilter";
            this.pcbFilter.Size = new System.Drawing.Size(402, 320);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Купола";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(123, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(123, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDispMax
            // 
            this.txtDispMax.Location = new System.Drawing.Point(146, 71);
            this.txtDispMax.Name = "txtDispMax";
            this.txtDispMax.Size = new System.Drawing.Size(34, 20);
            this.txtDispMax.TabIndex = 9;
            this.txtDispMax.Text = "7";
            // 
            // txtAmpMax
            // 
            this.txtAmpMax.Location = new System.Drawing.Point(146, 45);
            this.txtAmpMax.Name = "txtAmpMax";
            this.txtAmpMax.Size = new System.Drawing.Size(34, 20);
            this.txtAmpMax.TabIndex = 8;
            this.txtAmpMax.Text = "2";
            // 
            // txtDispMin
            // 
            this.txtDispMin.Location = new System.Drawing.Point(83, 71);
            this.txtDispMin.Name = "txtDispMin";
            this.txtDispMin.Size = new System.Drawing.Size(34, 20);
            this.txtDispMin.TabIndex = 6;
            this.txtDispMin.Text = "3";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дисперсия";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmpMin
            // 
            this.txtAmpMin.Location = new System.Drawing.Point(83, 45);
            this.txtAmpMin.Name = "txtAmpMin";
            this.txtAmpMin.Size = new System.Drawing.Size(34, 20);
            this.txtAmpMin.TabIndex = 4;
            this.txtAmpMin.Text = "1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Амплитуда";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(300, 357);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(34, 20);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.Text = "128";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(223, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ширина";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(300, 383);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(34, 20);
            this.txtHeight.TabIndex = 14;
            this.txtHeight.Text = "128";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(223, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Высота";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoisePercent
            // 
            this.txtNoisePercent.Location = new System.Drawing.Point(417, 357);
            this.txtNoisePercent.Name = "txtNoisePercent";
            this.txtNoisePercent.Size = new System.Drawing.Size(34, 20);
            this.txtNoisePercent.TabIndex = 12;
            this.txtNoisePercent.Text = "5";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(340, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Шум, %";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateSpectre
            // 
            this.btnCreateSpectre.Enabled = false;
            this.btnCreateSpectre.Location = new System.Drawing.Point(636, 342);
            this.btnCreateSpectre.Name = "btnCreateSpectre";
            this.btnCreateSpectre.Size = new System.Drawing.Size(90, 49);
            this.btnCreateSpectre.TabIndex = 16;
            this.btnCreateSpectre.Text = "Создать спектр";
            this.btnCreateSpectre.UseVisualStyleBackColor = true;
            this.btnCreateSpectre.Click += new System.EventHandler(this.btnCreateSpectre_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(732, 342);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 49);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterPercent
            // 
            this.txtFilterPercent.Location = new System.Drawing.Point(417, 383);
            this.txtFilterPercent.Name = "txtFilterPercent";
            this.txtFilterPercent.Size = new System.Drawing.Size(34, 20);
            this.txtFilterPercent.TabIndex = 18;
            this.txtFilterPercent.Text = "85";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(340, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Фильтр, %";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWidth
            // 
            this.labelWidth.Location = new System.Drawing.Point(878, 342);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(71, 23);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "0";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeight
            // 
            this.labelHeight.Location = new System.Drawing.Point(955, 342);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(71, 23);
            this.labelHeight.TabIndex = 20;
            this.labelHeight.Text = "0";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.txtFilterPercent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnCreateSpectre);
            this.Controls.Add(this.txtNoisePercent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbFilter);
            this.Controls.Add(this.pcbSpectre);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.pcbInitial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpectre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFilter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

