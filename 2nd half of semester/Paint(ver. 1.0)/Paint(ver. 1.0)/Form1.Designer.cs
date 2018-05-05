namespace Paint_ver._1._0_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bline = new System.Windows.Forms.Button();
            this.brectangle = new System.Windows.Forms.Button();
            this.bcircle = new System.Windows.Forms.Button();
            this.btriangle = new System.Windows.Forms.Button();
            this.firstcolor = new System.Windows.Forms.Button();
            this.secondcolor = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Gray = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Aqua = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.beraser = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(873, 453);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // bpen
            // 
            this.bpen.Location = new System.Drawing.Point(89, 0);
            this.bpen.Name = "bpen";
            this.bpen.Size = new System.Drawing.Size(40, 44);
            this.bpen.TabIndex = 1;
            this.bpen.Text = "Pen";
            this.bpen.UseVisualStyleBackColor = true;
            this.bpen.Click += new System.EventHandler(this.Object_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // bline
            // 
            this.bline.Location = new System.Drawing.Point(135, 0);
            this.bline.Name = "bline";
            this.bline.Size = new System.Drawing.Size(40, 44);
            this.bline.TabIndex = 4;
            this.bline.Text = "Line";
            this.bline.UseVisualStyleBackColor = true;
            this.bline.Click += new System.EventHandler(this.Object_Click);
            // 
            // brectangle
            // 
            this.brectangle.Location = new System.Drawing.Point(181, 0);
            this.brectangle.Name = "brectangle";
            this.brectangle.Size = new System.Drawing.Size(40, 44);
            this.brectangle.TabIndex = 5;
            this.brectangle.Text = "Rectangle";
            this.brectangle.UseVisualStyleBackColor = true;
            this.brectangle.Click += new System.EventHandler(this.Object_Click);
            // 
            // bcircle
            // 
            this.bcircle.Location = new System.Drawing.Point(227, 0);
            this.bcircle.Name = "bcircle";
            this.bcircle.Size = new System.Drawing.Size(40, 44);
            this.bcircle.TabIndex = 6;
            this.bcircle.Text = "Circle";
            this.bcircle.UseVisualStyleBackColor = true;
            this.bcircle.Click += new System.EventHandler(this.Object_Click);
            // 
            // btriangle
            // 
            this.btriangle.Location = new System.Drawing.Point(273, 0);
            this.btriangle.Name = "btriangle";
            this.btriangle.Size = new System.Drawing.Size(40, 44);
            this.btriangle.TabIndex = 7;
            this.btriangle.Text = "Triangle";
            this.btriangle.UseVisualStyleBackColor = true;
            this.btriangle.Click += new System.EventHandler(this.Object_Click);
            // 
            // firstcolor
            // 
            this.firstcolor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstcolor.Location = new System.Drawing.Point(635, 0);
            this.firstcolor.Name = "firstcolor";
            this.firstcolor.Size = new System.Drawing.Size(40, 44);
            this.firstcolor.TabIndex = 8;
            this.firstcolor.UseVisualStyleBackColor = false;
            this.firstcolor.Click += new System.EventHandler(this.firstcolor_Click);
            // 
            // secondcolor
            // 
            this.secondcolor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondcolor.Location = new System.Drawing.Point(681, 0);
            this.secondcolor.Name = "secondcolor";
            this.secondcolor.Size = new System.Drawing.Size(40, 44);
            this.secondcolor.TabIndex = 9;
            this.secondcolor.UseVisualStyleBackColor = false;
            this.secondcolor.Click += new System.EventHandler(this.secondcolor_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(728, 0);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(20, 20);
            this.White.TabIndex = 10;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.Color_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Location = new System.Drawing.Point(754, 24);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(20, 20);
            this.Orange.TabIndex = 11;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Color_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Red.Location = new System.Drawing.Point(754, 0);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(20, 20);
            this.Red.TabIndex = 12;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Color_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Silver;
            this.Gray.Location = new System.Drawing.Point(728, 24);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(20, 20);
            this.Gray.TabIndex = 13;
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.Color_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green.Location = new System.Drawing.Point(777, 24);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(20, 20);
            this.Green.TabIndex = 17;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Color_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(803, 0);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(20, 20);
            this.Blue.TabIndex = 16;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Color_Click);
            // 
            // Pink
            // 
            this.Pink.BackColor = System.Drawing.Color.Fuchsia;
            this.Pink.Location = new System.Drawing.Point(803, 24);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(20, 20);
            this.Pink.TabIndex = 15;
            this.Pink.UseVisualStyleBackColor = false;
            this.Pink.Click += new System.EventHandler(this.Color_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(777, 0);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(20, 20);
            this.Yellow.TabIndex = 14;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Color_Click);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(827, 24);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(20, 20);
            this.Aqua.TabIndex = 21;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.Click += new System.EventHandler(this.Color_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(853, 0);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(20, 20);
            this.Black.TabIndex = 20;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Color_Click);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.Brown;
            this.Brown.Location = new System.Drawing.Point(853, 24);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(20, 20);
            this.Brown.TabIndex = 19;
            this.Brown.UseVisualStyleBackColor = false;
            this.Brown.Click += new System.EventHandler(this.Color_Click);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.Location = new System.Drawing.Point(827, 0);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(20, 20);
            this.Purple.TabIndex = 18;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.Color_Click);
            // 
            // beraser
            // 
            this.beraser.Location = new System.Drawing.Point(589, 0);
            this.beraser.Name = "beraser";
            this.beraser.Size = new System.Drawing.Size(40, 44);
            this.beraser.TabIndex = 22;
            this.beraser.Text = "Eraser";
            this.beraser.UseVisualStyleBackColor = true;
            this.beraser.Click += new System.EventHandler(this.Object_Click);
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(543, 0);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(40, 44);
            this.fill.TabIndex = 23;
            this.fill.Text = "Fill";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.Object_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(6, 0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(40, 44);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "New";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Size";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(886, 525);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.beraser);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Brown);
            this.Controls.Add(this.Purple);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.White);
            this.Controls.Add(this.secondcolor);
            this.Controls.Add(this.firstcolor);
            this.Controls.Add(this.btriangle);
            this.Controls.Add(this.bcircle);
            this.Controls.Add(this.brectangle);
            this.Controls.Add(this.bline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bline;
        private System.Windows.Forms.Button brectangle;
        private System.Windows.Forms.Button bcircle;
        private System.Windows.Forms.Button btriangle;
        private System.Windows.Forms.Button firstcolor;
        private System.Windows.Forms.Button secondcolor;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Aqua;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Brown;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button beraser;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

