namespace Устный_счёт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_think = new System.Windows.Forms.Label();
            this.text_answer = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_divs = new System.Windows.Forms.Button();
            this.text_max = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_think
            // 
            this.label_think.BackColor = System.Drawing.Color.White;
            this.label_think.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_think.Enabled = false;
            this.label_think.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_think.Location = new System.Drawing.Point(2, 9);
            this.label_think.Name = "label_think";
            this.label_think.Size = new System.Drawing.Size(338, 85);
            this.label_think.TabIndex = 0;
            this.label_think.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_answer
            // 
            this.text_answer.Enabled = false;
            this.text_answer.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_answer.Location = new System.Drawing.Point(346, 9);
            this.text_answer.Name = "text_answer";
            this.text_answer.Size = new System.Drawing.Size(202, 85);
            this.text_answer.TabIndex = 1;
            this.text_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_answer_KeyDown);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(2, 141);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(101, 35);
            this.button_plus.TabIndex = 2;
            this.button_plus.Text = "Сложение";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(2, 100);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(546, 23);
            this.progress.TabIndex = 3;
            this.progress.Visible = false;
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(109, 141);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(111, 35);
            this.button_minus.TabIndex = 2;
            this.button_minus.Text = "Вычитание";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_mult
            // 
            this.button_mult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mult.Location = new System.Drawing.Point(226, 141);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(121, 35);
            this.button_mult.TabIndex = 2;
            this.button_mult.Text = "Умножение";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_divs
            // 
            this.button_divs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divs.Location = new System.Drawing.Point(353, 141);
            this.button_divs.Name = "button_divs";
            this.button_divs.Size = new System.Drawing.Size(101, 35);
            this.button_divs.TabIndex = 2;
            this.button_divs.Text = "Деление";
            this.button_divs.UseVisualStyleBackColor = true;
            this.button_divs.Click += new System.EventHandler(this.button_divs_Click);
            // 
            // text_max
            // 
            this.text_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_max.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_max.Location = new System.Drawing.Point(460, 141);
            this.text_max.Name = "text_max";
            this.text_max.Size = new System.Drawing.Size(88, 33);
            this.text_max.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 188);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.button_divs);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.text_answer);
            this.Controls.Add(this.label_think);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устный счёт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_think;
        private System.Windows.Forms.TextBox text_answer;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_divs;
        private System.Windows.Forms.TextBox text_max;
    }
}

