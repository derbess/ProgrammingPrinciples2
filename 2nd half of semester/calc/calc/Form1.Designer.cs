namespace calc
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
            this.pow = new System.Windows.Forms.Button();
            this.pow2 = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.oneoverx = new System.Windows.Forms.Button();
            this.tenpow = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.memorysave = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.dote = new System.Windows.Forms.Button();
            this.memoryminus = new System.Windows.Forms.Button();
            this.memoryclear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.memoryplus = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clearnumber = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.memoryread = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Pi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pow
            // 
            this.pow.AutoSize = true;
            this.pow.BackColor = System.Drawing.SystemColors.GrayText;
            this.pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pow.Location = new System.Drawing.Point(3, 95);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(80, 35);
            this.pow.TabIndex = 0;
            this.pow.Text = "X^2";
            this.pow.UseVisualStyleBackColor = false;
            this.pow.Click += new System.EventHandler(this.fun2_Click);
            // 
            // pow2
            // 
            this.pow2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pow2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pow2.Location = new System.Drawing.Point(85, 95);
            this.pow2.Name = "pow2";
            this.pow2.Size = new System.Drawing.Size(80, 35);
            this.pow2.TabIndex = 1;
            this.pow2.Text = "X^Y";
            this.pow2.UseVisualStyleBackColor = false;
            this.pow2.Click += new System.EventHandler(this.fun1_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.SystemColors.GrayText;
            this.sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sin.Location = new System.Drawing.Point(166, 95);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(80, 35);
            this.sin.TabIndex = 2;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.fun2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(249, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "cos";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.fun2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(331, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "tan";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.fun2_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.GrayText;
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sqrt.Location = new System.Drawing.Point(3, 312);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(80, 35);
            this.sqrt.TabIndex = 5;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.fun2_Click);
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.SystemColors.GrayText;
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.factorial.Location = new System.Drawing.Point(86, 131);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(80, 35);
            this.factorial.TabIndex = 6;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.fun2_Click);
            // 
            // oneoverx
            // 
            this.oneoverx.BackColor = System.Drawing.SystemColors.GrayText;
            this.oneoverx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneoverx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oneoverx.Location = new System.Drawing.Point(167, 131);
            this.oneoverx.Name = "oneoverx";
            this.oneoverx.Size = new System.Drawing.Size(80, 35);
            this.oneoverx.TabIndex = 7;
            this.oneoverx.Text = "1/x";
            this.oneoverx.UseVisualStyleBackColor = false;
            this.oneoverx.Click += new System.EventHandler(this.fun2_Click);
            // 
            // tenpow
            // 
            this.tenpow.BackColor = System.Drawing.SystemColors.GrayText;
            this.tenpow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenpow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tenpow.Location = new System.Drawing.Point(250, 131);
            this.tenpow.Name = "tenpow";
            this.tenpow.Size = new System.Drawing.Size(80, 35);
            this.tenpow.TabIndex = 8;
            this.tenpow.Text = "10^X";
            this.tenpow.UseVisualStyleBackColor = false;
            this.tenpow.Click += new System.EventHandler(this.fun2_Click);
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.SystemColors.GrayText;
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mod.Location = new System.Drawing.Point(332, 131);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(80, 35);
            this.mod.TabIndex = 9;
            this.mod.Text = "mod";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.fun1_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Location = new System.Drawing.Point(86, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 35);
            this.button12.TabIndex = 10;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.num_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Location = new System.Drawing.Point(167, 203);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 35);
            this.button13.TabIndex = 11;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.num_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Location = new System.Drawing.Point(250, 203);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 35);
            this.button14.TabIndex = 12;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.num_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.SystemColors.GrayText;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addition.Location = new System.Drawing.Point(331, 167);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(80, 35);
            this.addition.TabIndex = 13;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.fun1_Click);
            // 
            // memorysave
            // 
            this.memorysave.BackColor = System.Drawing.SystemColors.GrayText;
            this.memorysave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorysave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memorysave.Location = new System.Drawing.Point(85, 59);
            this.memorysave.Name = "memorysave";
            this.memorysave.Size = new System.Drawing.Size(80, 35);
            this.memorysave.TabIndex = 14;
            this.memorysave.Text = "MS";
            this.memorysave.UseVisualStyleBackColor = false;
            this.memorysave.Click += new System.EventHandler(this.memorysave_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button16.Location = new System.Drawing.Point(85, 240);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 35);
            this.button16.TabIndex = 15;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.num_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button17.Location = new System.Drawing.Point(166, 240);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 35);
            this.button17.TabIndex = 16;
            this.button17.Text = "5";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.num_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button18.Location = new System.Drawing.Point(249, 240);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 35);
            this.button18.TabIndex = 17;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.num_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.SystemColors.GrayText;
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtraction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtraction.Location = new System.Drawing.Point(332, 203);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(80, 35);
            this.subtraction.TabIndex = 18;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.fun1_Click);
            // 
            // dote
            // 
            this.dote.BackColor = System.Drawing.SystemColors.GrayText;
            this.dote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dote.Location = new System.Drawing.Point(249, 313);
            this.dote.Name = "dote";
            this.dote.Size = new System.Drawing.Size(80, 35);
            this.dote.TabIndex = 19;
            this.dote.Text = ".";
            this.dote.UseVisualStyleBackColor = false;
            this.dote.Click += new System.EventHandler(this.dote_Click);
            // 
            // memoryminus
            // 
            this.memoryminus.BackColor = System.Drawing.SystemColors.GrayText;
            this.memoryminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryminus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoryminus.Location = new System.Drawing.Point(331, 59);
            this.memoryminus.Name = "memoryminus";
            this.memoryminus.Size = new System.Drawing.Size(80, 35);
            this.memoryminus.TabIndex = 20;
            this.memoryminus.Text = "M-";
            this.memoryminus.UseVisualStyleBackColor = false;
            this.memoryminus.Click += new System.EventHandler(this.memoryminus_Click);
            // 
            // memoryclear
            // 
            this.memoryclear.BackColor = System.Drawing.SystemColors.GrayText;
            this.memoryclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoryclear.Location = new System.Drawing.Point(167, 59);
            this.memoryclear.Name = "memoryclear";
            this.memoryclear.Size = new System.Drawing.Size(80, 35);
            this.memoryclear.TabIndex = 21;
            this.memoryclear.Text = "MC";
            this.memoryclear.UseVisualStyleBackColor = false;
            this.memoryclear.Click += new System.EventHandler(this.memoryclear_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.Location = new System.Drawing.Point(166, 313);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 35);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button24.Location = new System.Drawing.Point(167, 276);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(80, 35);
            this.button24.TabIndex = 23;
            this.button24.Text = "2";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.num_Click);
            // 
            // plusminus
            // 
            this.plusminus.BackColor = System.Drawing.SystemColors.GrayText;
            this.plusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusminus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plusminus.Location = new System.Drawing.Point(85, 313);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(80, 35);
            this.plusminus.TabIndex = 24;
            this.plusminus.Text = "±";
            this.plusminus.UseVisualStyleBackColor = false;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button26.Location = new System.Drawing.Point(86, 276);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(80, 35);
            this.button26.TabIndex = 25;
            this.button26.Text = "1";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.num_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.SystemColors.GrayText;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplication.Location = new System.Drawing.Point(331, 240);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(80, 35);
            this.multiplication.TabIndex = 26;
            this.multiplication.Text = "×";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.fun1_Click);
            // 
            // memoryplus
            // 
            this.memoryplus.BackColor = System.Drawing.SystemColors.GrayText;
            this.memoryplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryplus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoryplus.Location = new System.Drawing.Point(249, 59);
            this.memoryplus.Name = "memoryplus";
            this.memoryplus.Size = new System.Drawing.Size(80, 35);
            this.memoryplus.TabIndex = 27;
            this.memoryplus.Text = "M+";
            this.memoryplus.UseVisualStyleBackColor = false;
            this.memoryplus.Click += new System.EventHandler(this.memoryplus_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button29.Location = new System.Drawing.Point(250, 276);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(80, 35);
            this.button29.TabIndex = 28;
            this.button29.Text = "3";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.num_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.GrayText;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equal.Location = new System.Drawing.Point(332, 312);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(80, 35);
            this.equal.TabIndex = 29;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.GrayText;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(85, 167);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 35);
            this.clear.TabIndex = 30;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.unique_Click);
            // 
            // clearnumber
            // 
            this.clearnumber.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearnumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearnumber.Location = new System.Drawing.Point(166, 167);
            this.clearnumber.Name = "clearnumber";
            this.clearnumber.Size = new System.Drawing.Size(80, 35);
            this.clearnumber.TabIndex = 31;
            this.clearnumber.Text = "CE";
            this.clearnumber.UseVisualStyleBackColor = false;
            this.clearnumber.Click += new System.EventHandler(this.clearnumber_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.GrayText;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backspace.Location = new System.Drawing.Point(249, 167);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(80, 35);
            this.backspace.TabIndex = 32;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.unique_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.GrayText;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.division.Location = new System.Drawing.Point(332, 276);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(80, 35);
            this.division.TabIndex = 33;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.fun1_Click);
            // 
            // memoryread
            // 
            this.memoryread.BackColor = System.Drawing.SystemColors.GrayText;
            this.memoryread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryread.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memoryread.Location = new System.Drawing.Point(3, 59);
            this.memoryread.Name = "memoryread";
            this.memoryread.Size = new System.Drawing.Size(80, 35);
            this.memoryread.TabIndex = 34;
            this.memoryread.Text = "MR";
            this.memoryread.UseVisualStyleBackColor = false;
            this.memoryread.Click += new System.EventHandler(this.memoryread_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(2, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 29);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(3, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.fun1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(3, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 37;
            this.button2.Text = "e^x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.fun2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(2, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 35);
            this.button3.TabIndex = 38;
            this.button3.Text = "log";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.fun2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(3, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 35);
            this.button6.TabIndex = 39;
            this.button6.Text = "X^1/Y";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.fun1_Click);
            // 
            // Pi
            // 
            this.Pi.BackColor = System.Drawing.SystemColors.GrayText;
            this.Pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pi.Location = new System.Drawing.Point(3, 276);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(80, 35);
            this.Pi.TabIndex = 40;
            this.Pi.Text = "π";
            this.Pi.UseVisualStyleBackColor = false;
            this.Pi.Click += new System.EventHandler(this.Pi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(417, 359);
            this.Controls.Add(this.Pi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.memoryread);
            this.Controls.Add(this.division);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clearnumber);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.memoryplus);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.memoryclear);
            this.Controls.Add(this.memoryminus);
            this.Controls.Add(this.dote);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.memorysave);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.tenpow);
            this.Controls.Add(this.oneoverx);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.pow2);
            this.Controls.Add(this.pow);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Calculator.exe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button pow2;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button oneoverx;
        private System.Windows.Forms.Button tenpow;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button memorysave;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button dote;
        private System.Windows.Forms.Button memoryminus;
        private System.Windows.Forms.Button memoryclear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button memoryplus;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearnumber;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button memoryread;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Pi;
    }
}

