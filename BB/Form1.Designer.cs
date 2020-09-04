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
            this.life_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.newgame = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.level_label = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.close_label = new System.Windows.Forms.Label();
            this.credit_label = new System.Windows.Forms.Label();
            this.scoreboard_label = new System.Windows.Forms.Label();
            this.scoreboard_panel = new System.Windows.Forms.Panel();
            this.sb_title = new System.Windows.Forms.Label();
            this.end_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.playername = new System.Windows.Forms.TextBox();
            this.readme_panel = new System.Windows.Forms.Panel();
            this.desc_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.scoreboard_panel.SuspendLayout();
            this.end_panel.SuspendLayout();
            this.readme_panel.SuspendLayout();
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
            this.player.Location = new System.Drawing.Point(461, 417);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 15);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Gold;
            this.ball.Location = new System.Drawing.Point(603, 266);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // life_label
            // 
            this.life_label.AutoSize = true;
            this.life_label.Location = new System.Drawing.Point(287, 451);
            this.life_label.Name = "life_label";
            this.life_label.Size = new System.Drawing.Size(38, 15);
            this.life_label.TabIndex = 4;
            this.life_label.Text = "Élet: 3";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Location = new System.Drawing.Point(741, 451);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(38, 15);
            this.score_label.TabIndex = 5;
            this.score_label.Text = "Pont: ";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newgame
            // 
            this.newgame.AutoSize = true;
            this.newgame.BackColor = System.Drawing.Color.Gainsboro;
            this.newgame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newgame.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.newgame.Location = new System.Drawing.Point(23, 160);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(96, 34);
            this.newgame.TabIndex = 6;
            this.newgame.Text = "Új játék";
            this.newgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Gainsboro;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.result.Location = new System.Drawing.Point(33, 25);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(169, 47);
            this.result.TabIndex = 6;
            this.result.Text = "Győzelem";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // level_label
            // 
            this.level_label.AutoSize = true;
            this.level_label.Location = new System.Drawing.Point(495, 451);
            this.level_label.Name = "level_label";
            this.level_label.Size = new System.Drawing.Size(38, 15);
            this.level_label.TabIndex = 5;
            this.level_label.Text = "Szint: ";
            this.level_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_panel.Controls.Add(this.close_label);
            this.menu_panel.Controls.Add(this.credit_label);
            this.menu_panel.Controls.Add(this.scoreboard_label);
            this.menu_panel.Controls.Add(this.newgame);
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(250, 477);
            this.menu_panel.TabIndex = 7;
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.BackColor = System.Drawing.Color.Gainsboro;
            this.close_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.close_label.Location = new System.Drawing.Point(27, 329);
            this.close_label.Name = "close_label";
            this.close_label.Size = new System.Drawing.Size(92, 34);
            this.close_label.TabIndex = 9;
            this.close_label.Text = "Kilépés";
            this.close_label.Click += new System.EventHandler(this.close_Click);
            // 
            // credit_label
            // 
            this.credit_label.AutoSize = true;
            this.credit_label.BackColor = System.Drawing.Color.Gainsboro;
            this.credit_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.credit_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.credit_label.Location = new System.Drawing.Point(27, 273);
            this.credit_label.Name = "credit_label";
            this.credit_label.Size = new System.Drawing.Size(76, 34);
            this.credit_label.TabIndex = 8;
            this.credit_label.Text = "Leírás";
            this.credit_label.Click += new System.EventHandler(this.credit_label_Click);
            // 
            // scoreboard_label
            // 
            this.scoreboard_label.AutoSize = true;
            this.scoreboard_label.BackColor = System.Drawing.Color.Gainsboro;
            this.scoreboard_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreboard_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreboard_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.scoreboard_label.Location = new System.Drawing.Point(25, 218);
            this.scoreboard_label.Name = "scoreboard_label";
            this.scoreboard_label.Size = new System.Drawing.Size(112, 34);
            this.scoreboard_label.TabIndex = 7;
            this.scoreboard_label.Text = "Ranglista";
            this.scoreboard_label.Click += new System.EventHandler(this.scoreboard_label_Click);
            // 
            // scoreboard_panel
            // 
            this.scoreboard_panel.BackColor = System.Drawing.Color.Silver;
            this.scoreboard_panel.Controls.Add(this.sb_title);
            this.scoreboard_panel.Location = new System.Drawing.Point(250, 0);
            this.scoreboard_panel.Name = "scoreboard_panel";
            this.scoreboard_panel.Size = new System.Drawing.Size(551, 477);
            this.scoreboard_panel.TabIndex = 8;
            this.scoreboard_panel.Visible = false;
            // 
            // sb_title
            // 
            this.sb_title.AutoSize = true;
            this.sb_title.BackColor = System.Drawing.Color.Gray;
            this.sb_title.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sb_title.ForeColor = System.Drawing.Color.Maroon;
            this.sb_title.Location = new System.Drawing.Point(163, 68);
            this.sb_title.Name = "sb_title";
            this.sb_title.Size = new System.Drawing.Size(225, 52);
            this.sb_title.TabIndex = 1;
            this.sb_title.Text = "RANGLISTA";
            // 
            // end_panel
            // 
            this.end_panel.Controls.Add(this.label1);
            this.end_panel.Controls.Add(this.btn_save);
            this.end_panel.Controls.Add(this.playername);
            this.end_panel.Controls.Add(this.result);
            this.end_panel.Location = new System.Drawing.Point(255, 100);
            this.end_panel.Name = "end_panel";
            this.end_panel.Size = new System.Drawing.Size(250, 270);
            this.end_panel.TabIndex = 2;
            this.end_panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(82, 200);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // playername
            // 
            this.playername.Location = new System.Drawing.Point(33, 146);
            this.playername.Name = "playername";
            this.playername.Size = new System.Drawing.Size(160, 23);
            this.playername.TabIndex = 0;
            // 
            // readme_panel
            // 
            this.readme_panel.Controls.Add(this.desc_label);
            this.readme_panel.Controls.Add(this.label2);
            this.readme_panel.Location = new System.Drawing.Point(250, 0);
            this.readme_panel.Name = "readme_panel";
            this.readme_panel.Size = new System.Drawing.Size(551, 477);
            this.readme_panel.TabIndex = 9;
            this.readme_panel.Visible = false;
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.desc_label.Location = new System.Drawing.Point(60, 103);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(0, 20);
            this.desc_label.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Program leírás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.readme_panel);
            this.Controls.Add(this.end_panel);
            this.Controls.Add(this.life_label);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.level_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.scoreboard_panel);
            this.Name = "Form1";
            this.Text = "Blockblaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.scoreboard_panel.ResumeLayout(false);
            this.scoreboard_panel.PerformLayout();
            this.end_panel.ResumeLayout(false);
            this.end_panel.PerformLayout();
            this.readme_panel.ResumeLayout(false);
            this.readme_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label life_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label newgame;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label level_label;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.Label credit_label;
        private System.Windows.Forms.Label scoreboard_label;
        private System.Windows.Forms.Panel scoreboard_panel;
        private System.Windows.Forms.Label sb_title;
        private System.Windows.Forms.Panel end_panel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox playername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel readme_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label desc_label;
    }
}

