namespace Bonus
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
            this.components = new System.ComponentModel.Container();
            this.forcreate = new System.Windows.Forms.Timer(this.components);
            this.move = new System.Windows.Forms.VScrollBar();
            this.forfall = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forcreate
            // 
            this.forcreate.Enabled = true;
            this.forcreate.Interval = 800;
            this.forcreate.Tick += new System.EventHandler(this.forcreate_Tick);
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(9, 9);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(17, 443);
            this.move.TabIndex = 1;
            this.move.Value = 1;
            this.move.Scroll += new System.Windows.Forms.ScrollEventHandler(this.move_Scroll);
            // 
            // forfall
            // 
            this.forfall.Enabled = true;
            this.forfall.Tick += new System.EventHandler(this.forfall_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(29, 7);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 13);
            this.score.TabIndex = 2;
            this.score.Text = "label1";
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.SystemColors.Control;
            this.gameover.Font = new System.Drawing.Font("Times New Roman", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.Location = new System.Drawing.Point(120, 94);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(700, 254);
            this.gameover.TabIndex = 3;
            this.gameover.Text = "GameOver";
            this.gameover.Visible = false;
            // 
            // final
            // 
            this.final.BackColor = System.Drawing.SystemColors.Menu;
            this.final.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Location = new System.Drawing.Point(180, 371);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(537, 51);
            this.final.TabIndex = 4;
            this.final.Text = "You Score ";
            this.final.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.player.Location = new System.Drawing.Point(32, 34);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 5;
            this.player.Text = "player";
            this.player.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 487);
            this.Controls.Add(this.player);
            this.Controls.Add(this.final);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.score);
            this.Controls.Add(this.move);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer forcreate;
        private System.Windows.Forms.VScrollBar move;
        private System.Windows.Forms.Timer forfall;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.Button player;
    }
}

