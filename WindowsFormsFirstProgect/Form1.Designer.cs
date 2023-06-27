
namespace WindowsFormsFirstProgect
{
    partial class Calculator
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
            this.plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Null = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Tahoma", 16F);
            this.plus.Location = new System.Drawing.Point(654, 109);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(69, 65);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Tahoma", 16F);
            this.Minus.Location = new System.Drawing.Point(573, 109);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 65);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Tahoma", 16F);
            this.multiply.Location = new System.Drawing.Point(573, 180);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 71);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Tahoma", 16F);
            this.divide.Location = new System.Drawing.Point(654, 180);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(69, 71);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.One.Location = new System.Drawing.Point(25, 109);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(75, 65);
            this.One.TabIndex = 4;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Two.Location = new System.Drawing.Point(106, 109);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(75, 65);
            this.Two.TabIndex = 5;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Tahoma", 12F);
            this.three.Location = new System.Drawing.Point(187, 109);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 65);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Tahoma", 12F);
            this.four.Location = new System.Drawing.Point(25, 180);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 58);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Tahoma", 12F);
            this.five.Location = new System.Drawing.Point(106, 180);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 58);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Tahoma", 12F);
            this.six.Location = new System.Drawing.Point(187, 180);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 58);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Tahoma", 12F);
            this.seven.Location = new System.Drawing.Point(25, 244);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 61);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Tahoma", 12F);
            this.eight.Location = new System.Drawing.Point(106, 244);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 61);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nine.Location = new System.Drawing.Point(187, 244);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 61);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // Null
            // 
            this.Null.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Null.Location = new System.Drawing.Point(106, 311);
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(75, 65);
            this.Null.TabIndex = 13;
            this.Null.Text = "0";
            this.Null.UseVisualStyleBackColor = true;
            this.Null.Click += new System.EventHandler(this.Null_Click);
            // 
            // Console
            // 
            this.Console.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Console.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Console.Location = new System.Drawing.Point(25, 12);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(698, 69);
            this.Console.TabIndex = 14;
            this.Console.TextChanged += new System.EventHandler(this.Console_TextChanged_1);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(654, 257);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(69, 71);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "C";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // equally
            // 
            this.equally.Font = new System.Drawing.Font("Tahoma", 16F);
            this.equally.Location = new System.Drawing.Point(573, 257);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(75, 71);
            this.equally.TabIndex = 16;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = true;
            this.equally.Click += new System.EventHandler(this.equally_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.Null);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.plus);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button Null;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button equally;
    }
}

