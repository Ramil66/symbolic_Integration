namespace SymbolicIntegration
{
    partial class OutputFunction
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IntegralRichTextBox = new System.Windows.Forms.RichTextBox();
            this.functionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.exitButton = new SymbolicIntegration.design.RoundButton();
            this.backButton = new SymbolicIntegration.design.RoundButton();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.ForeColor = System.Drawing.Color.White;
            this.richTextBox.Location = new System.Drawing.Point(22, 236);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(700, 277);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введенная функция:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Полученный интеграл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Шаги интегрирования:";
            // 
            // IntegralRichTextBox
            // 
            this.IntegralRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.IntegralRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntegralRichTextBox.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntegralRichTextBox.ForeColor = System.Drawing.Color.White;
            this.IntegralRichTextBox.Location = new System.Drawing.Point(22, 145);
            this.IntegralRichTextBox.Name = "IntegralRichTextBox";
            this.IntegralRichTextBox.ReadOnly = true;
            this.IntegralRichTextBox.Size = new System.Drawing.Size(700, 50);
            this.IntegralRichTextBox.TabIndex = 6;
            this.IntegralRichTextBox.Text = "";
            // 
            // functionRichTextBox
            // 
            this.functionRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.functionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.functionRichTextBox.Font = new System.Drawing.Font("Cambria Math", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionRichTextBox.ForeColor = System.Drawing.Color.White;
            this.functionRichTextBox.Location = new System.Drawing.Point(22, 55);
            this.functionRichTextBox.Name = "functionRichTextBox";
            this.functionRichTextBox.ReadOnly = true;
            this.functionRichTextBox.Size = new System.Drawing.Size(700, 50);
            this.functionRichTextBox.TabIndex = 7;
            this.functionRichTextBox.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exitButton.ColorPen = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(632, 519);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rounding = 50;
            this.exitButton.RoundingEnable = true;
            this.exitButton.Size = new System.Drawing.Size(90, 30);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Закрыть";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backButton.ColorPen = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(536, 519);
            this.backButton.Name = "backButton";
            this.backButton.Rounding = 50;
            this.backButton.RoundingEnable = true;
            this.backButton.Size = new System.Drawing.Size(90, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OutputFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.functionRichTextBox);
            this.Controls.Add(this.IntegralRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.richTextBox);
            this.Name = "OutputFunction";
            this.Text = "Курсовая работа. Нурманов Р.Х.";
            this.Load += new System.EventHandler(this.OutputFunction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private design.RoundButton backButton;
        private design.RoundButton exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox IntegralRichTextBox;
        private System.Windows.Forms.RichTextBox functionRichTextBox;
    }
}