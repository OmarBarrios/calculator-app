namespace FrontCalculator
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.displayNum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eigth = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.removeValue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.equation2 = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayNum
            // 
            this.displayNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNum.Location = new System.Drawing.Point(6, 29);
            this.displayNum.Multiline = true;
            this.displayNum.Name = "displayNum";
            this.displayNum.Size = new System.Drawing.Size(274, 93);
            this.displayNum.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OperationClear);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(146, 177);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(64, 44);
            this.clear.TabIndex = 3;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.OperationClear);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(216, 277);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(64, 44);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(146, 277);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(64, 44);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // eigth
            // 
            this.eigth.Location = new System.Drawing.Point(76, 277);
            this.eigth.Name = "eigth";
            this.eigth.Size = new System.Drawing.Size(64, 44);
            this.eigth.TabIndex = 10;
            this.eigth.Text = "8";
            this.eigth.UseVisualStyleBackColor = true;
            this.eigth.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(6, 277);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(64, 44);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // substract
            // 
            this.substract.Location = new System.Drawing.Point(216, 327);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(64, 44);
            this.substract.TabIndex = 16;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.Operator_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(146, 327);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(64, 44);
            this.six.TabIndex = 15;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(76, 327);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(64, 44);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(6, 327);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(64, 44);
            this.four.TabIndex = 13;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(216, 377);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(64, 44);
            this.sum.TabIndex = 20;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.Operator_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(146, 377);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(64, 44);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(76, 377);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(64, 44);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(6, 377);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(64, 44);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(216, 427);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(64, 44);
            this.equal.TabIndex = 24;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(76, 427);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(64, 44);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(306, 96);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 20);
            this.equation.TabIndex = 26;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(11, 122);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(0, 0);
            this.average.TabIndex = 1;
            this.average.Text = "%";
            this.average.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(146, 427);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(64, 44);
            this.button24.TabIndex = 21;
            this.button24.Text = ",";
            this.button24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(216, 227);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(64, 44);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // removeValue
            // 
            this.removeValue.Location = new System.Drawing.Point(216, 177);
            this.removeValue.Name = "removeValue";
            this.removeValue.Size = new System.Drawing.Size(64, 44);
            this.removeValue.TabIndex = 27;
            this.removeValue.Text = "<=";
            this.removeValue.UseVisualStyleBackColor = true;
            this.removeValue.Click += new System.EventHandler(this.RemoveValue);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "_/x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 44);
            this.button3.TabIndex = 29;
            this.button3.Text = "x^2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 44);
            this.button4.TabIndex = 30;
            this.button4.Text = "1/x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 44);
            this.button5.TabIndex = 31;
            this.button5.Text = "+/-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 44);
            this.button6.TabIndex = 32;
            this.button6.Text = "%";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 141);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 30);
            this.button7.TabIndex = 33;
            this.button7.Text = "MC";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(53, 141);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 30);
            this.button8.TabIndex = 34;
            this.button8.Text = "MR";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 141);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 30);
            this.button9.TabIndex = 36;
            this.button9.Text = "M-";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(102, 141);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(38, 30);
            this.button10.TabIndex = 35;
            this.button10.Text = "M+";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(239, 141);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(41, 30);
            this.button11.TabIndex = 38;
            this.button11.Text = "M\"";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(191, 141);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 30);
            this.button12.TabIndex = 37;
            this.button12.Text = "MS";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // equation2
            // 
            this.equation2.AutoSize = true;
            this.equation2.Location = new System.Drawing.Point(236, 100);
            this.equation2.Name = "equation2";
            this.equation2.Size = new System.Drawing.Size(0, 13);
            this.equation2.TabIndex = 39;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(200, 39);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(0, 13);
            this.historyLabel.TabIndex = 40;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(285, 475);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.equation2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeValue);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eigth);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.average);
            this.Controls.Add(this.displayNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculadora_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eigth;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button removeValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label equation2;
        private System.Windows.Forms.Label historyLabel;
    }
}

