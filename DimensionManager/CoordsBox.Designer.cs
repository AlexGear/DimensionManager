﻿namespace DimensionManager
{
    partial class CoordsBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(24, 3);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(92, 20);
            this.xBox.TabIndex = 1;
            this.xBox.Tag = "X";
            this.xBox.Text = "0";
            this.xBox.Validating += new System.ComponentModel.CancelEventHandler(this.coordBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(164, 3);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(92, 20);
            this.yBox.TabIndex = 3;
            this.yBox.Tag = "Y";
            this.yBox.Text = "0";
            this.yBox.Validating += new System.ComponentModel.CancelEventHandler(this.coordBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z";
            // 
            // zBox
            // 
            this.zBox.Location = new System.Drawing.Point(314, 3);
            this.zBox.Name = "zBox";
            this.zBox.Size = new System.Drawing.Size(92, 20);
            this.zBox.TabIndex = 5;
            this.zBox.Tag = "Z";
            this.zBox.Text = "0";
            this.zBox.Validating += new System.ComponentModel.CancelEventHandler(this.coordBox_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CoordsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label1);
            this.Name = "CoordsBox";
            this.Size = new System.Drawing.Size(414, 27);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}