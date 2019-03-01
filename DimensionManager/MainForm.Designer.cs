namespace DimensionManager
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.axisSelectCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.savedNotificationLabel = new System.Windows.Forms.Label();
            this.platformOffsetZBox = new DimensionManager.DecimalBox();
            this.backJackBox = new DimensionManager.CoordsBox();
            this.masterAntBox = new DimensionManager.CoordsBox();
            this.azimuthAntBox = new DimensionManager.CoordsBox();
            this.bitOffsetBox = new DimensionManager.CoordsBox();
            this.frontRightJackBox = new DimensionManager.CoordsBox();
            this.mastRotateOffsetBox = new DimensionManager.CoordsBox();
            this.frontLeftJackBox = new DimensionManager.CoordsBox();
            this.axisBBox = new DimensionManager.CoordsBox();
            this.axisABox = new DimensionManager.CoordsBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ось";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.axisBBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.axisSelectCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.axisABox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задаваемая ось";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Точка B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Точка A";
            // 
            // axisSelectCombo
            // 
            this.axisSelectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axisSelectCombo.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.axisSelectCombo.Location = new System.Drawing.Point(172, 23);
            this.axisSelectCombo.Name = "axisSelectCombo";
            this.axisSelectCombo.Size = new System.Drawing.Size(92, 21);
            this.axisSelectCombo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Мастер-антенна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Remote-антенна";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.backJackBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.masterAntBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.azimuthAntBox);
            this.groupBox2.Controls.Add(this.bitOffsetBox);
            this.groupBox2.Controls.Add(this.frontRightJackBox);
            this.groupBox2.Controls.Add(this.mastRotateOffsetBox);
            this.groupBox2.Controls.Add(this.frontLeftJackBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 212);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Координаты точек";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Задний домкрат";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Передний правый домкрат";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Передний левый домкрат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ось поворота мачты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Буровой став";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 406);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(187, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "<save>";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.platformOffsetZBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 56);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Другие параметры";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Высота платформы";
            // 
            // savedNotificationLabel
            // 
            this.savedNotificationLabel.AutoSize = true;
            this.savedNotificationLabel.Location = new System.Drawing.Point(205, 411);
            this.savedNotificationLabel.Name = "savedNotificationLabel";
            this.savedNotificationLabel.Size = new System.Drawing.Size(0, 13);
            this.savedNotificationLabel.TabIndex = 2;
            // 
            // platformOffsetZBox
            // 
            this.platformOffsetZBox.Location = new System.Drawing.Point(171, 22);
            this.platformOffsetZBox.MaximumSize = new System.Drawing.Size(9999, 20);
            this.platformOffsetZBox.MinimumSize = new System.Drawing.Size(0, 20);
            this.platformOffsetZBox.Name = "platformOffsetZBox";
            this.platformOffsetZBox.Size = new System.Drawing.Size(92, 20);
            this.platformOffsetZBox.TabIndex = 1;
            this.platformOffsetZBox.Value = 0F;
            // 
            // backJackBox
            // 
            this.backJackBox.Location = new System.Drawing.Point(148, 181);
            this.backJackBox.Name = "backJackBox";
            this.backJackBox.Size = new System.Drawing.Size(425, 20);
            this.backJackBox.TabIndex = 18;
            this.backJackBox.X = 0F;
            this.backJackBox.Y = 0F;
            this.backJackBox.Z = 0F;
            // 
            // masterAntBox
            // 
            this.masterAntBox.Location = new System.Drawing.Point(148, 25);
            this.masterAntBox.Name = "masterAntBox";
            this.masterAntBox.Size = new System.Drawing.Size(425, 20);
            this.masterAntBox.TabIndex = 6;
            this.masterAntBox.X = 0F;
            this.masterAntBox.Y = 0F;
            this.masterAntBox.Z = 0F;
            // 
            // azimuthAntBox
            // 
            this.azimuthAntBox.Location = new System.Drawing.Point(148, 51);
            this.azimuthAntBox.Name = "azimuthAntBox";
            this.azimuthAntBox.Size = new System.Drawing.Size(425, 20);
            this.azimuthAntBox.TabIndex = 8;
            this.azimuthAntBox.X = 0F;
            this.azimuthAntBox.Y = 0F;
            this.azimuthAntBox.Z = 0F;
            // 
            // bitOffsetBox
            // 
            this.bitOffsetBox.Location = new System.Drawing.Point(148, 77);
            this.bitOffsetBox.Name = "bitOffsetBox";
            this.bitOffsetBox.Size = new System.Drawing.Size(425, 20);
            this.bitOffsetBox.TabIndex = 9;
            this.bitOffsetBox.X = 0F;
            this.bitOffsetBox.Y = 0F;
            this.bitOffsetBox.Z = 0F;
            // 
            // frontRightJackBox
            // 
            this.frontRightJackBox.Location = new System.Drawing.Point(148, 155);
            this.frontRightJackBox.Name = "frontRightJackBox";
            this.frontRightJackBox.Size = new System.Drawing.Size(425, 20);
            this.frontRightJackBox.TabIndex = 12;
            this.frontRightJackBox.X = 0F;
            this.frontRightJackBox.Y = 0F;
            this.frontRightJackBox.Z = 0F;
            // 
            // mastRotateOffsetBox
            // 
            this.mastRotateOffsetBox.Location = new System.Drawing.Point(148, 103);
            this.mastRotateOffsetBox.Name = "mastRotateOffsetBox";
            this.mastRotateOffsetBox.Size = new System.Drawing.Size(425, 20);
            this.mastRotateOffsetBox.TabIndex = 10;
            this.mastRotateOffsetBox.X = 0F;
            this.mastRotateOffsetBox.Y = 0F;
            this.mastRotateOffsetBox.Z = 0F;
            // 
            // frontLeftJackBox
            // 
            this.frontLeftJackBox.Location = new System.Drawing.Point(148, 129);
            this.frontLeftJackBox.Name = "frontLeftJackBox";
            this.frontLeftJackBox.Size = new System.Drawing.Size(425, 20);
            this.frontLeftJackBox.TabIndex = 11;
            this.frontLeftJackBox.X = 0F;
            this.frontLeftJackBox.Y = 0F;
            this.frontLeftJackBox.Z = 0F;
            // 
            // axisBBox
            // 
            this.axisBBox.Location = new System.Drawing.Point(148, 75);
            this.axisBBox.Name = "axisBBox";
            this.axisBBox.Size = new System.Drawing.Size(425, 20);
            this.axisBBox.TabIndex = 4;
            this.axisBBox.X = 0F;
            this.axisBBox.Y = 0F;
            this.axisBBox.Z = 0F;
            // 
            // axisABox
            // 
            this.axisABox.Location = new System.Drawing.Point(148, 50);
            this.axisABox.Name = "axisABox";
            this.axisABox.Size = new System.Drawing.Size(425, 20);
            this.axisABox.TabIndex = 1;
            this.axisABox.X = 0F;
            this.axisABox.Y = 0F;
            this.axisABox.Z = 0F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 441);
            this.Controls.Add(this.savedNotificationLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DimensionManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CoordsBox axisABox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox axisSelectCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CoordsBox axisBBox;
        private System.Windows.Forms.Label label4;
        private CoordsBox masterAntBox;
        private System.Windows.Forms.Label label5;
        private CoordsBox azimuthAntBox;
        private CoordsBox bitOffsetBox;
        private CoordsBox mastRotateOffsetBox;
        private CoordsBox frontLeftJackBox;
        private CoordsBox frontRightJackBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private CoordsBox backJackBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private DecimalBox platformOffsetZBox;
        private System.Windows.Forms.Label savedNotificationLabel;
    }
}

