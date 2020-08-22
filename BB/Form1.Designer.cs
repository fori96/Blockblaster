namespace BB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.life = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.ask = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.player.Location = new System.Drawing.Point(12, 425);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 15);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Gold;
            this.ball.Location = new System.Drawing.Point(236, 268);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Location = new System.Drawing.Point(15, 451);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(38, 15);
            this.life.TabIndex = 4;
            this.life.Text = "Élet: 3";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(741, 451);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(38, 15);
            this.score.TabIndex = 5;
            this.score.Text = "Pont: ";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ask
            // 
            this.ask.AutoSize = true;
            this.ask.BackColor = System.Drawing.Color.Gainsboro;
            this.ask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ask.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ask.Location = new System.Drawing.Point(335, 225);
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(130, 39);
            this.ask.TabIndex = 6;
            this.ask.Text = "Új játék?";
            this.ask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.BackColor = System.Drawing.Color.Gainsboro;
            this.yes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yes.Location = new System.Drawing.Point(315, 292);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(66, 34);
            this.yes.TabIndex = 6;
            this.yes.Text = "igen";
            this.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.BackColor = System.Drawing.Color.Gainsboro;
            this.no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.no.Location = new System.Drawing.Point(418, 292);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(66, 34);
            this.no.TabIndex = 6;
            this.no.Text = "nem";
            this.no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.Color.Gainsboro;
            this.win.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.win.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.win.Location = new System.Drawing.Point(315, 100);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(169, 47);
            this.win.TabIndex = 6;
            this.win.Text = "Győzelem";
            this.win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.win);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.ask);
            this.Controls.Add(this.score);
            this.Controls.Add(this.life);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label ask;
        private System.Windows.Forms.Label yes;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label win;
    }
}

