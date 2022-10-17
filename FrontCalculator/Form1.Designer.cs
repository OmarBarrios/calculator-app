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
            this.displayNum = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            this.coma = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayNum
            // 
            this.displayNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNum.Location = new System.Drawing.Point(12, 44);
            this.displayNum.Multiline = true;
            this.displayNum.Name = "displayNum";
            this.displayNum.Size = new System.Drawing.Size(350, 93);
            this.displayNum.TabIndex = 0;
            this.displayNum.TextChanged += new System.EventHandler(this.displayNum_TextChanged);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(12, 172);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(83, 55);
            this.average.TabIndex = 1;
            this.average.Text = "%";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(190, 172);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(83, 55);
            this.clear.TabIndex = 3;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(279, 172);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(83, 55);
            this.remove.TabIndex = 4;
            this.remove.Text = "<=";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.button4_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(279, 233);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(83, 55);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(190, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 55);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(101, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 55);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 233);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 55);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(279, 294);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(83, 55);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(190, 294);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(83, 55);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // eigth
            // 
            this.eigth.Location = new System.Drawing.Point(101, 294);
            this.eigth.Name = "eigth";
            this.eigth.Size = new System.Drawing.Size(83, 55);
            this.eigth.TabIndex = 10;
            this.eigth.Text = "8";
            this.eigth.UseVisualStyleBackColor = true;
            this.eigth.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 294);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(83, 55);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // substract
            // 
            this.substract.Location = new System.Drawing.Point(279, 355);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(83, 55);
            this.substract.TabIndex = 16;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.operator_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(190, 355);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(83, 55);
            this.six.TabIndex = 15;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(101, 355);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(83, 55);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 355);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(83, 55);
            this.four.TabIndex = 13;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(279, 416);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(83, 55);
            this.sum.TabIndex = 20;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.operator_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(190, 416);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(83, 55);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(101, 416);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(83, 55);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 416);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(83, 55);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(279, 477);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(83, 55);
            this.equal.TabIndex = 24;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // coma
            // 
            this.coma.Location = new System.Drawing.Point(190, 477);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(83, 55);
            this.coma.TabIndex = 23;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = true;
            this.coma.Click += new System.EventHandler(this.coma_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(101, 477);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(83, 55);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(12, 477);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(83, 55);
            this.button24.TabIndex = 21;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(12, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(38, 36);
            this.button25.TabIndex = 25;
            this.button25.Text = "---";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(306, 114);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 20);
            this.equation.TabIndex = 26;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 536);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.coma);
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
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.average);
            this.Controls.Add(this.displayNum);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculadora_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayNum;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
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
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label equation;
    }
}

