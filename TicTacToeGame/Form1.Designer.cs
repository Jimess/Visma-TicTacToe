﻿namespace TicTacToeGame
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
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box5 = new System.Windows.Forms.PictureBox();
            this.box6 = new System.Windows.Forms.PictureBox();
            this.box7 = new System.Windows.Forms.PictureBox();
            this.box8 = new System.Windows.Forms.PictureBox();
            this.box9 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).BeginInit();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box1.Location = new System.Drawing.Point(109, 114);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(150, 150);
            this.box1.TabIndex = 0;
            this.box1.TabStop = false;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box2.Location = new System.Drawing.Point(265, 114);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(150, 150);
            this.box2.TabIndex = 1;
            this.box2.TabStop = false;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box3.Location = new System.Drawing.Point(421, 114);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(150, 150);
            this.box3.TabIndex = 2;
            this.box3.TabStop = false;
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box4.Location = new System.Drawing.Point(109, 270);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(150, 150);
            this.box4.TabIndex = 3;
            this.box4.TabStop = false;
            // 
            // box5
            // 
            this.box5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box5.Location = new System.Drawing.Point(265, 270);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(150, 150);
            this.box5.TabIndex = 4;
            this.box5.TabStop = false;
            // 
            // box6
            // 
            this.box6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box6.Location = new System.Drawing.Point(421, 270);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(150, 150);
            this.box6.TabIndex = 5;
            this.box6.TabStop = false;
            // 
            // box7
            // 
            this.box7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box7.Location = new System.Drawing.Point(109, 426);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(150, 150);
            this.box7.TabIndex = 6;
            this.box7.TabStop = false;
            // 
            // box8
            // 
            this.box8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box8.Location = new System.Drawing.Point(265, 426);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(150, 150);
            this.box8.TabIndex = 7;
            this.box8.TabStop = false;
            // 
            // box9
            // 
            this.box9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.box9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box9.Location = new System.Drawing.Point(421, 426);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(150, 150);
            this.box9.TabIndex = 8;
            this.box9.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(775, 114);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(180, 39);
            this.gameOverLabel.TabIndex = 10;
            this.gameOverLabel.Text = "Gameover";
            this.gameOverLabel.Visible = false;
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(655, 185);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(411, 39);
            this.restartLabel.TabIndex = 11;
            this.restartLabel.Text = "Press Enter to Play Again";
            this.restartLabel.Visible = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(807, 255);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(127, 39);
            this.winnerLabel.TabIndex = 12;
            this.winnerLabel.Text = "Winner";
            this.winnerLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.PictureBox box5;
        private System.Windows.Forms.PictureBox box6;
        private System.Windows.Forms.PictureBox box7;
        private System.Windows.Forms.PictureBox box8;
        private System.Windows.Forms.PictureBox box9;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.Label winnerLabel;
    }
}

