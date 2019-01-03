namespace ScientificCalculatorApp
{
    partial class Form1
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
            this.equation = new System.Windows.Forms.Label();
            this.button05 = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonBracket2 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonAns = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonBracket1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonEXP = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.buttonBIN = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.buttonMplus = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.Color.White;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.Color.DarkGray;
            this.equation.Location = new System.Drawing.Point(49, 58);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 20);
            this.equation.TabIndex = 0;
            // 
            // button05
            // 
            this.button05.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button05.Location = new System.Drawing.Point(210, 135);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(50, 29);
            this.button05.TabIndex = 1;
            this.button05.Text = "^";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSin.Location = new System.Drawing.Point(210, 181);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(50, 29);
            this.buttonSin.TabIndex = 1;
            this.buttonSin.Text = "sin ";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonBracket2
            // 
            this.buttonBracket2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBracket2.Location = new System.Drawing.Point(210, 225);
            this.buttonBracket2.Name = "buttonBracket2";
            this.buttonBracket2.Size = new System.Drawing.Size(50, 29);
            this.buttonBracket2.TabIndex = 1;
            this.buttonBracket2.Text = ")";
            this.buttonBracket2.UseVisualStyleBackColor = true;
            this.buttonBracket2.Click += new System.EventHandler(this.buttonBracket_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(259, 275);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(46, 35);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(259, 329);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(46, 35);
            this.buttonMultiply.TabIndex = 1;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(259, 383);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(46, 35);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonAns
            // 
            this.buttonAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAns.Location = new System.Drawing.Point(259, 436);
            this.buttonAns.Name = "buttonAns";
            this.buttonAns.Size = new System.Drawing.Size(46, 35);
            this.buttonAns.TabIndex = 1;
            this.buttonAns.Text = "Ans";
            this.buttonAns.UseVisualStyleBackColor = true;
            this.buttonAns.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(155, 135);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 29);
            this.button12.TabIndex = 1;
            this.button12.Text = "²";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(155, 181);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 29);
            this.button13.TabIndex = 1;
            this.button13.Text = " HEX";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonBracket1
            // 
            this.buttonBracket1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBracket1.Location = new System.Drawing.Point(155, 225);
            this.buttonBracket1.Name = "buttonBracket1";
            this.buttonBracket1.Size = new System.Drawing.Size(50, 29);
            this.buttonBracket1.TabIndex = 1;
            this.buttonBracket1.Text = "(";
            this.buttonBracket1.UseVisualStyleBackColor = true;
            this.buttonBracket1.Click += new System.EventHandler(this.buttonBracket_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(179, 274);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 35);
            this.button9.TabIndex = 1;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(179, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 35);
            this.button6.TabIndex = 1;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(179, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonEXP
            // 
            this.buttonEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXP.Location = new System.Drawing.Point(179, 436);
            this.buttonEXP.Name = "buttonEXP";
            this.buttonEXP.Size = new System.Drawing.Size(46, 35);
            this.buttonEXP.TabIndex = 1;
            this.buttonEXP.Text = "EXP";
            this.buttonEXP.UseVisualStyleBackColor = true;
            this.buttonEXP.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(100, 135);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 29);
            this.button19.TabIndex = 1;
            this.button19.Text = "√";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonBIN
            // 
            this.buttonBIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBIN.Location = new System.Drawing.Point(100, 181);
            this.buttonBIN.Name = "buttonBIN";
            this.buttonBIN.Size = new System.Drawing.Size(50, 29);
            this.buttonBIN.TabIndex = 1;
            this.buttonBIN.Text = " BIN";
            this.buttonBIN.UseVisualStyleBackColor = true;
            this.buttonBIN.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(100, 225);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 29);
            this.button21.TabIndex = 1;
            this.button21.Text = "ENG";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(111, 274);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 35);
            this.button8.TabIndex = 1;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(111, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(111, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(111, 436);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(46, 35);
            this.buttonDot.TabIndex = 1;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOFF.Location = new System.Drawing.Point(46, 135);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(50, 29);
            this.buttonOFF.TabIndex = 1;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(46, 181);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(50, 29);
            this.button27.TabIndex = 1;
            this.button27.Text = " 1/x";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(46, 225);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(50, 29);
            this.button28.TabIndex = 1;
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(46, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 35);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(46, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(46, 436);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(46, 35);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(265, 135);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(50, 29);
            this.button33.TabIndex = 1;
            this.button33.Text = "log ";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(265, 181);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(50, 29);
            this.button34.TabIndex = 1;
            this.button34.Text = "cos ";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(265, 225);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(50, 29);
            this.button35.TabIndex = 1;
            this.button35.UseVisualStyleBackColor = true;
            // 
            // buttonAC
            // 
            this.buttonAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAC.Location = new System.Drawing.Point(326, 275);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(46, 35);
            this.buttonAC.TabIndex = 1;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(326, 329);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(46, 35);
            this.buttonDivide.TabIndex = 1;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(326, 383);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(46, 35);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(326, 436);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(46, 35);
            this.buttonEqual.TabIndex = 1;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Location = new System.Drawing.Point(320, 135);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(50, 29);
            this.button40.TabIndex = 1;
            this.button40.Text = "ln ";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // button41
            // 
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(320, 181);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(50, 29);
            this.button41.TabIndex = 1;
            this.button41.Text = "tan ";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonMplus
            // 
            this.buttonMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMplus.Location = new System.Drawing.Point(320, 225);
            this.buttonMplus.Name = "buttonMplus";
            this.buttonMplus.Size = new System.Drawing.Size(50, 29);
            this.buttonMplus.TabIndex = 1;
            this.buttonMplus.Text = "M+";
            this.buttonMplus.UseVisualStyleBackColor = true;
            this.buttonMplus.Click += new System.EventHandler(this.buttonMplus_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(46, 81);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(324, 29);
            this.result.TabIndex = 2;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 493);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonEXP);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonAns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonAC);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.buttonMplus);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.buttonBracket1);
            this.Controls.Add(this.buttonBracket2);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.buttonBIN);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.equation);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonBracket2;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonAns;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button buttonBracket1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonEXP;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button buttonBIN;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button buttonMplus;
        private System.Windows.Forms.TextBox result;
    }
}

