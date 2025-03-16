namespace SymbolicIntegration
{
    partial class InputFunction
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.themeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.degreeButton = new SymbolicIntegration.design.RoundButton();
            this.ctgButton = new SymbolicIntegration.design.RoundButton();
            this.tgButton = new SymbolicIntegration.design.RoundButton();
            this.sinButton = new SymbolicIntegration.design.RoundButton();
            this.cosButton = new SymbolicIntegration.design.RoundButton();
            this.lnButton = new SymbolicIntegration.design.RoundButton();
            this.logButton = new SymbolicIntegration.design.RoundButton();
            this.divisionButton = new SymbolicIntegration.design.RoundButton();
            this.switchTheme = new SymbolicIntegration.design.SwitchButton();
            this.startIntegration = new SymbolicIntegration.design.RoundButton();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.ForeColor = System.Drawing.Color.White;
            this.richTextBox.Location = new System.Drawing.Point(13, 218);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(700, 50);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "";
            // 
            // themeText
            // 
            this.themeText.AutoSize = true;
            this.themeText.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeText.ForeColor = System.Drawing.Color.White;
            this.themeText.Location = new System.Drawing.Point(581, 15);
            this.themeText.Name = "themeText";
            this.themeText.Size = new System.Drawing.Size(87, 16);
            this.themeText.TabIndex = 14;
            this.themeText.Text = "Темная тема";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите функцию:";
            // 
            // degreeButton
            // 
            this.degreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.degreeButton.ColorPen = System.Drawing.Color.White;
            this.degreeButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreeButton.ForeColor = System.Drawing.Color.White;
            this.degreeButton.Location = new System.Drawing.Point(117, 274);
            this.degreeButton.Name = "degreeButton";
            this.degreeButton.Rounding = 60;
            this.degreeButton.RoundingEnable = true;
            this.degreeButton.Size = new System.Drawing.Size(80, 55);
            this.degreeButton.TabIndex = 24;
            this.degreeButton.UseVisualStyleBackColor = false;
            this.degreeButton.Click += new System.EventHandler(this.degreeButton_Click);
            // 
            // ctgButton
            // 
            this.ctgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ctgButton.ColorPen = System.Drawing.Color.White;
            this.ctgButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctgButton.ForeColor = System.Drawing.Color.White;
            this.ctgButton.Location = new System.Drawing.Point(633, 274);
            this.ctgButton.Name = "ctgButton";
            this.ctgButton.Rounding = 60;
            this.ctgButton.RoundingEnable = true;
            this.ctgButton.Size = new System.Drawing.Size(80, 55);
            this.ctgButton.TabIndex = 23;
            this.ctgButton.Text = "ctg( )";
            this.ctgButton.UseVisualStyleBackColor = false;
            this.ctgButton.Click += new System.EventHandler(this.ctgButton_Click);
            // 
            // tgButton
            // 
            this.tgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tgButton.ColorPen = System.Drawing.Color.White;
            this.tgButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tgButton.ForeColor = System.Drawing.Color.White;
            this.tgButton.Location = new System.Drawing.Point(547, 274);
            this.tgButton.Name = "tgButton";
            this.tgButton.Rounding = 60;
            this.tgButton.RoundingEnable = true;
            this.tgButton.Size = new System.Drawing.Size(80, 55);
            this.tgButton.TabIndex = 22;
            this.tgButton.Text = "tg( )";
            this.tgButton.UseVisualStyleBackColor = false;
            this.tgButton.Click += new System.EventHandler(this.tgButton_Click);
            // 
            // sinButton
            // 
            this.sinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sinButton.ColorPen = System.Drawing.Color.White;
            this.sinButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinButton.ForeColor = System.Drawing.Color.White;
            this.sinButton.Location = new System.Drawing.Point(461, 274);
            this.sinButton.Name = "sinButton";
            this.sinButton.Rounding = 60;
            this.sinButton.RoundingEnable = true;
            this.sinButton.Size = new System.Drawing.Size(80, 55);
            this.sinButton.TabIndex = 21;
            this.sinButton.Text = "sin( )";
            this.sinButton.UseVisualStyleBackColor = false;
            this.sinButton.Click += new System.EventHandler(this.sinButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cosButton.ColorPen = System.Drawing.Color.White;
            this.cosButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosButton.ForeColor = System.Drawing.Color.White;
            this.cosButton.Location = new System.Drawing.Point(375, 274);
            this.cosButton.Name = "cosButton";
            this.cosButton.Rounding = 60;
            this.cosButton.RoundingEnable = true;
            this.cosButton.Size = new System.Drawing.Size(80, 55);
            this.cosButton.TabIndex = 20;
            this.cosButton.Text = "cos( )";
            this.cosButton.UseVisualStyleBackColor = false;
            this.cosButton.Click += new System.EventHandler(this.cosButton_Click);
            // 
            // lnButton
            // 
            this.lnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lnButton.ColorPen = System.Drawing.Color.White;
            this.lnButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnButton.ForeColor = System.Drawing.Color.White;
            this.lnButton.Location = new System.Drawing.Point(289, 274);
            this.lnButton.Name = "lnButton";
            this.lnButton.Rounding = 60;
            this.lnButton.RoundingEnable = true;
            this.lnButton.Size = new System.Drawing.Size(80, 55);
            this.lnButton.TabIndex = 19;
            this.lnButton.Text = "ln( )";
            this.lnButton.UseVisualStyleBackColor = false;
            this.lnButton.Click += new System.EventHandler(this.lnButton_Click);
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logButton.ColorPen = System.Drawing.Color.White;
            this.logButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.ForeColor = System.Drawing.Color.White;
            this.logButton.Location = new System.Drawing.Point(203, 274);
            this.logButton.Name = "logButton";
            this.logButton.Rounding = 60;
            this.logButton.RoundingEnable = true;
            this.logButton.Size = new System.Drawing.Size(80, 55);
            this.logButton.TabIndex = 18;
            this.logButton.Text = "log( )";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.divisionButton.ColorPen = System.Drawing.Color.White;
            this.divisionButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.ForeColor = System.Drawing.Color.White;
            this.divisionButton.Location = new System.Drawing.Point(31, 274);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Rounding = 60;
            this.divisionButton.RoundingEnable = true;
            this.divisionButton.Size = new System.Drawing.Size(80, 55);
            this.divisionButton.TabIndex = 17;
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // switchTheme
            // 
            this.switchTheme.BackColorON = System.Drawing.Color.Black;
            this.switchTheme.Checked = false;
            this.switchTheme.Location = new System.Drawing.Point(674, 12);
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.Size = new System.Drawing.Size(48, 19);
            this.switchTheme.TabIndex = 4;
            this.switchTheme.Text = "switchButton1";
            this.switchTheme.Click += new System.EventHandler(this.switchTheme_Click);
            // 
            // startIntegration
            // 
            this.startIntegration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.startIntegration.ColorPen = System.Drawing.Color.White;
            this.startIntegration.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startIntegration.ForeColor = System.Drawing.Color.White;
            this.startIntegration.Location = new System.Drawing.Point(300, 357);
            this.startIntegration.Name = "startIntegration";
            this.startIntegration.Rounding = 70;
            this.startIntegration.RoundingEnable = true;
            this.startIntegration.Size = new System.Drawing.Size(150, 50);
            this.startIntegration.TabIndex = 1;
            this.startIntegration.Text = "Найти интеграл";
            this.startIntegration.UseVisualStyleBackColor = false;
            this.startIntegration.Click += new System.EventHandler(this.startIntegration_Click);
            // 
            // InputFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.degreeButton);
            this.Controls.Add(this.ctgButton);
            this.Controls.Add(this.tgButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.lnButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.themeText);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.switchTheme);
            this.Controls.Add(this.startIntegration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "InputFunction";
            this.Text = "Курсовая работа. Нурманов Р.Х.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private design.SwitchButton switchTheme;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label themeText;
        private System.Windows.Forms.Label label1;
        private design.RoundButton startIntegration;
        private design.RoundButton degreeButton;
        private design.RoundButton ctgButton;
        private design.RoundButton tgButton;
        private design.RoundButton sinButton;
        private design.RoundButton cosButton;
        public design.RoundButton lnButton;
        private design.RoundButton logButton;
        private design.RoundButton divisionButton;
    }
}

