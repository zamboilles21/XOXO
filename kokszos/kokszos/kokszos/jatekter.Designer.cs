
namespace kokszos
{
    partial class jatekter
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
            this.player_1_name = new System.Windows.Forms.Label();
            this.player_2_name = new System.Windows.Forms.Label();
            this.player1_turn = new System.Windows.Forms.PictureBox();
            this.player2_turn = new System.Windows.Forms.PictureBox();
            this.imgbox_player_1 = new System.Windows.Forms.PictureBox();
            this.imgbox_player_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player1_turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_player_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_player_2)).BeginInit();
            this.SuspendLayout();
            // 
            // player_1_name
            // 
            this.player_1_name.AutoSize = true;
            this.player_1_name.Location = new System.Drawing.Point(374, 9);
            this.player_1_name.Name = "player_1_name";
            this.player_1_name.Size = new System.Drawing.Size(45, 13);
            this.player_1_name.TabIndex = 0;
            this.player_1_name.Text = "Player 1";
            this.player_1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_2_name
            // 
            this.player_2_name.AutoSize = true;
            this.player_2_name.Location = new System.Drawing.Point(374, 439);
            this.player_2_name.Name = "player_2_name";
            this.player_2_name.Size = new System.Drawing.Size(45, 13);
            this.player_2_name.TabIndex = 1;
            this.player_2_name.Text = "Player 2";
            // 
            // player1_turn
            // 
            this.player1_turn.Location = new System.Drawing.Point(582, 9);
            this.player1_turn.Name = "player1_turn";
            this.player1_turn.Size = new System.Drawing.Size(200, 100);
            this.player1_turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1_turn.TabIndex = 5;
            this.player1_turn.TabStop = false;
            // 
            // player2_turn
            // 
            this.player2_turn.Location = new System.Drawing.Point(12, 349);
            this.player2_turn.Name = "player2_turn";
            this.player2_turn.Size = new System.Drawing.Size(200, 100);
            this.player2_turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2_turn.TabIndex = 4;
            this.player2_turn.TabStop = false;
            // 
            // imgbox_player_1
            // 
            this.imgbox_player_1.Location = new System.Drawing.Point(12, 12);
            this.imgbox_player_1.Name = "imgbox_player_1";
            this.imgbox_player_1.Size = new System.Drawing.Size(100, 100);
            this.imgbox_player_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbox_player_1.TabIndex = 3;
            this.imgbox_player_1.TabStop = false;
            // 
            // imgbox_player_2
            // 
            this.imgbox_player_2.Location = new System.Drawing.Point(682, 349);
            this.imgbox_player_2.Name = "imgbox_player_2";
            this.imgbox_player_2.Size = new System.Drawing.Size(100, 100);
            this.imgbox_player_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbox_player_2.TabIndex = 2;
            this.imgbox_player_2.TabStop = false;
            // 
            // jatekter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 461);
            this.Controls.Add(this.player1_turn);
            this.Controls.Add(this.player2_turn);
            this.Controls.Add(this.imgbox_player_1);
            this.Controls.Add(this.imgbox_player_2);
            this.Controls.Add(this.player_2_name);
            this.Controls.Add(this.player_1_name);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(810, 500);
            this.Name = "jatekter";
            this.ShowIcon = false;
            this.Text = "Játéktér";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.jatekter_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.jatekter_FormClosing);
            this.Load += new System.EventHandler(this.jatekter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player1_turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_player_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox_player_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player_1_name;
        private System.Windows.Forms.Label player_2_name;
        private System.Windows.Forms.PictureBox imgbox_player_2;
        private System.Windows.Forms.PictureBox imgbox_player_1;
        private System.Windows.Forms.PictureBox player2_turn;
        private System.Windows.Forms.PictureBox player1_turn;
    }
}