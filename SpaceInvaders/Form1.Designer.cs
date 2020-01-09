namespace SpaceInvaders
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PBFuel1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Score1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PBFuel2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Score2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            // 
            // timer3
            // 
            this.timer3.Interval = 5;
//            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(482, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(522, 229);
            this.button1.TabIndex = 10;
            this.button1.Text = "START\r\nLevel2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 5;
//            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Strip
            // 
            this.Strip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.PBFuel1,
            this.toolStripStatusLabel2,
            this.Score1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.PBFuel2,
            this.toolStripStatusLabel6,
            this.Score2,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8});
            this.Strip.Location = new System.Drawing.Point(0, 883);
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(1474, 43);
            this.Strip.TabIndex = 13;
            this.Strip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 38);
            this.toolStripStatusLabel1.Text = "Player 1";
            // 
            // PBFuel1
            // 
            this.PBFuel1.Name = "PBFuel1";
            this.PBFuel1.Size = new System.Drawing.Size(150, 37);
            this.PBFuel1.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(77, 38);
            this.toolStripStatusLabel2.Text = "Lives";
            // 
            // Score1
            // 
            this.Score1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1.ForeColor = System.Drawing.Color.Red;
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(32, 38);
            this.Score1.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(493, 38);
            this.toolStripStatusLabel3.Text = "                                                                                ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(108, 38);
            this.toolStripStatusLabel4.Text = "Player2";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 38);
            // 
            // PBFuel2
            // 
            this.PBFuel2.Name = "PBFuel2";
            this.PBFuel2.Size = new System.Drawing.Size(150, 37);
            this.PBFuel2.Step = 1;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(77, 38);
            this.toolStripStatusLabel6.Text = "Lives";
            // 
            // Score2
            // 
            this.Score2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.ForeColor = System.Drawing.Color.Red;
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(32, 38);
            this.Score2.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(31, 38);
            this.toolStripStatusLabel7.Text = "   ";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(277, 30);
            this.toolStripStatusLabel8.Text = "                                            ";
            // 
            // player1
            // 
            this.player1.AccessibleName = "player1";
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::SpaceInvaders.Properties.Resources.ah6_right;
            this.player1.Location = new System.Drawing.Point(155, 411);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(103, 42);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Tag = "player";
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::SpaceInvaders.Properties.Resources.z11_left;
            this.player2.Location = new System.Drawing.Point(1258, 411);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(92, 42);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            this.player2.Tag = "player";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(482, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(522, 229);
            this.button2.TabIndex = 14;
            this.button2.Text = "START\r\nLevel 1\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(482, 592);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(522, 229);
            this.button3.TabIndex = 15;
            this.button3.Text = "START\r\nLevel 3\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1474, 926);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Strip);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chopper Duel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            this.Strip.ResumeLayout(false);
            this.Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.StatusStrip Strip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar PBFuel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Score1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripProgressBar PBFuel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel Score2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

