namespace game15
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
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(87, 339);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(222, 23);
            this.button17.TabIndex = 16;
            this.button17.Text = "Новая игра";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.button17);
            this.Name = "Form1";
            this.Text = "Пятнашки";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button17;
    }
}

