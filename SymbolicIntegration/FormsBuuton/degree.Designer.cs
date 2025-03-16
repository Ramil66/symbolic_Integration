namespace SymbolicIntegration.FormsBuuton
{
    partial class degree
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
            this.label2 = new System.Windows.Forms.Label();
            this.roundButton2 = new SymbolicIntegration.design.RoundButton();
            this.roundButton1 = new SymbolicIntegration.design.RoundButton();
            this.denominator = new System.Windows.Forms.RichTextBox();
            this.numenator = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите значение числа и ее степени:";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.roundButton2.ColorPen = System.Drawing.Color.White;
            this.roundButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.roundButton2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(632, 244);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.RoundingEnable = true;
            this.roundButton2.Size = new System.Drawing.Size(90, 30);
            this.roundButton2.TabIndex = 10;
            this.roundButton2.Text = "Закрыть";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.roundButton1.ColorPen = System.Drawing.Color.White;
            this.roundButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.roundButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(536, 244);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.RoundingEnable = true;
            this.roundButton1.Size = new System.Drawing.Size(90, 30);
            this.roundButton1.TabIndex = 9;
            this.roundButton1.Text = "ОК";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // denominator
            // 
            this.denominator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.denominator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denominator.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.denominator.ForeColor = System.Drawing.Color.White;
            this.denominator.Location = new System.Drawing.Point(300, 128);
            this.denominator.Margin = new System.Windows.Forms.Padding(0);
            this.denominator.Name = "denominator";
            this.denominator.Size = new System.Drawing.Size(150, 80);
            this.denominator.TabIndex = 7;
            this.denominator.Text = "";
            // 
            // numenator
            // 
            this.numenator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numenator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numenator.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numenator.ForeColor = System.Drawing.Color.White;
            this.numenator.Location = new System.Drawing.Point(437, 77);
            this.numenator.Margin = new System.Windows.Forms.Padding(0);
            this.numenator.Name = "numenator";
            this.numenator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numenator.Size = new System.Drawing.Size(100, 40);
            this.numenator.TabIndex = 6;
            this.numenator.Text = "";
            // 
            // degree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(734, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.denominator);
            this.Controls.Add(this.numenator);
            this.Name = "degree";
            this.Text = "degree";
            this.Load += new System.EventHandler(this.degree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private design.RoundButton roundButton2;
        private design.RoundButton roundButton1;
        private System.Windows.Forms.RichTextBox denominator;
        private System.Windows.Forms.RichTextBox numenator;
    }
}