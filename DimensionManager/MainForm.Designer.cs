﻿namespace DimensionManager
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
            this.rearJack = new DimensionManager.CoordsBox();
            this.masterAntBox = new DimensionManager.CoordsBox();
            this.remoteAntBox = new DimensionManager.CoordsBox();
            this.drillingRigBox = new DimensionManager.CoordsBox();
            this.frontRightJack = new DimensionManager.CoordsBox();
            this.mastBox = new DimensionManager.CoordsBox();
            this.frontLeftJack = new DimensionManager.CoordsBox();
            this.axisBBox = new DimensionManager.CoordsBox();
            this.axisABox = new DimensionManager.CoordsBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.axisSelectCombo.Location = new System.Drawing.Point(148, 23);
            this.axisSelectCombo.Name = "axisSelectCombo";
            this.axisSelectCombo.Size = new System.Drawing.Size(116, 21);
            this.axisSelectCombo.TabIndex = 2;
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
            this.groupBox2.Controls.Add(this.rearJack);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.masterAntBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.remoteAntBox);
            this.groupBox2.Controls.Add(this.drillingRigBox);
            this.groupBox2.Controls.Add(this.frontRightJack);
            this.groupBox2.Controls.Add(this.mastBox);
            this.groupBox2.Controls.Add(this.frontLeftJack);
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
            this.saveButton.Location = new System.Drawing.Point(12, 340);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rearJack
            // 
            this.rearJack.Location = new System.Drawing.Point(148, 181);
            this.rearJack.Name = "rearJack";
            this.rearJack.Size = new System.Drawing.Size(425, 20);
            this.rearJack.TabIndex = 18;
            this.rearJack.X = 0F;
            this.rearJack.Y = 0F;
            this.rearJack.Z = 0F;
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
            // remoteAntBox
            // 
            this.remoteAntBox.Location = new System.Drawing.Point(148, 51);
            this.remoteAntBox.Name = "remoteAntBox";
            this.remoteAntBox.Size = new System.Drawing.Size(425, 20);
            this.remoteAntBox.TabIndex = 8;
            this.remoteAntBox.X = 0F;
            this.remoteAntBox.Y = 0F;
            this.remoteAntBox.Z = 0F;
            // 
            // drillingRigBox
            // 
            this.drillingRigBox.Location = new System.Drawing.Point(148, 77);
            this.drillingRigBox.Name = "drillingRigBox";
            this.drillingRigBox.Size = new System.Drawing.Size(425, 20);
            this.drillingRigBox.TabIndex = 9;
            this.drillingRigBox.X = 0F;
            this.drillingRigBox.Y = 0F;
            this.drillingRigBox.Z = 0F;
            // 
            // frontRightJack
            // 
            this.frontRightJack.Location = new System.Drawing.Point(148, 155);
            this.frontRightJack.Name = "frontRightJack";
            this.frontRightJack.Size = new System.Drawing.Size(425, 20);
            this.frontRightJack.TabIndex = 12;
            this.frontRightJack.X = 0F;
            this.frontRightJack.Y = 0F;
            this.frontRightJack.Z = 0F;
            // 
            // mastBox
            // 
            this.mastBox.Location = new System.Drawing.Point(148, 103);
            this.mastBox.Name = "mastBox";
            this.mastBox.Size = new System.Drawing.Size(425, 20);
            this.mastBox.TabIndex = 10;
            this.mastBox.X = 0F;
            this.mastBox.Y = 0F;
            this.mastBox.Z = 0F;
            // 
            // frontLeftJack
            // 
            this.frontLeftJack.Location = new System.Drawing.Point(148, 129);
            this.frontLeftJack.Name = "frontLeftJack";
            this.frontLeftJack.Size = new System.Drawing.Size(425, 20);
            this.frontLeftJack.TabIndex = 11;
            this.frontLeftJack.X = 0F;
            this.frontLeftJack.Y = 0F;
            this.frontLeftJack.Z = 0F;
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
            this.axisABox.TabIndex = 0;
            this.axisABox.X = 0F;
            this.axisABox.Y = 0F;
            this.axisABox.Z = 0F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 370);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private CoordsBox remoteAntBox;
        private CoordsBox drillingRigBox;
        private CoordsBox mastBox;
        private CoordsBox frontLeftJack;
        private CoordsBox frontRightJack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private CoordsBox rearJack;
        private System.Windows.Forms.Button saveButton;
    }
}

