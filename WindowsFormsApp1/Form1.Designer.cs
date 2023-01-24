namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelForTime = new System.Windows.Forms.Label();
            this.buttonShowTime = new System.Windows.Forms.Button();
            this.buttonAnother = new System.Windows.Forms.Button();
            this.comboBoxTimeFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForTime
            // 
            this.labelForTime.AutoSize = true;
            this.labelForTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForTime.Location = new System.Drawing.Point(560, 97);
            this.labelForTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForTime.Name = "labelForTime";
            this.labelForTime.Size = new System.Drawing.Size(240, 33);
            this.labelForTime.TabIndex = 0;
            this.labelForTime.Text = "Текущее время";
            // 
            // buttonShowTime
            // 
            this.buttonShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowTime.Location = new System.Drawing.Point(150, 97);
            this.buttonShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowTime.Name = "buttonShowTime";
            this.buttonShowTime.Size = new System.Drawing.Size(112, 35);
            this.buttonShowTime.TabIndex = 1;
            this.buttonShowTime.Text = "Время";
            this.buttonShowTime.UseVisualStyleBackColor = true;
            this.buttonShowTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonShowTime_MouseClick);
            this.buttonShowTime.MouseLeave += new System.EventHandler(this.buttonShowTime_MouseLeave);
            this.buttonShowTime.MouseHover += new System.EventHandler(this.buttonShowTime_MouseHover);
            // 
            // buttonAnother
            // 
            this.buttonAnother.Location = new System.Drawing.Point(150, 212);
            this.buttonAnother.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnother.Name = "buttonAnother";
            this.buttonAnother.Size = new System.Drawing.Size(195, 35);
            this.buttonAnother.TabIndex = 2;
            this.buttonAnother.Text = "Ещё одна кнопка";
            this.buttonAnother.UseVisualStyleBackColor = true;
            this.buttonAnother.Click += new System.EventHandler(this.buttonAnother_Click);
            // 
            // comboBoxTimeFormat
            // 
            this.comboBoxTimeFormat.FormattingEnabled = true;
            this.comboBoxTimeFormat.Items.AddRange(new object[] {
            "Полное время",
            "Только дата",
            "Краткое время",
            "Часы"});
            this.comboBoxTimeFormat.Location = new System.Drawing.Point(314, 97);
            this.comboBoxTimeFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTimeFormat.Name = "comboBoxTimeFormat";
            this.comboBoxTimeFormat.Size = new System.Drawing.Size(180, 28);
            this.comboBoxTimeFormat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTimeFormat);
            this.Controls.Add(this.buttonAnother);
            this.Controls.Add(this.buttonShowTime);
            this.Controls.Add(this.labelForTime);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForTime;
        private System.Windows.Forms.Button buttonShowTime;
        private System.Windows.Forms.Button buttonAnother;
        private System.Windows.Forms.ComboBox comboBoxTimeFormat;
        private System.Windows.Forms.Label label1;
    }
}

