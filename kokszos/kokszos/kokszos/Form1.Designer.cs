
namespace kokszos
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
            this.lbl_player1_name = new System.Windows.Forms.Label();
            this.lbl_player2_name = new System.Windows.Forms.Label();
            this.txtbx_player1_name = new System.Windows.Forms.TextBox();
            this.txtbx_player2_name = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_player1_name
            // 
            this.lbl_player1_name.AutoSize = true;
            this.lbl_player1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_player1_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_player1_name.Name = "lbl_player1_name";
            this.lbl_player1_name.Size = new System.Drawing.Size(164, 29);
            this.lbl_player1_name.TabIndex = 0;
            this.lbl_player1_name.Text = "Player 1 neve:";
            // 
            // lbl_player2_name
            // 
            this.lbl_player2_name.AutoSize = true;
            this.lbl_player2_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_player2_name.Location = new System.Drawing.Point(12, 60);
            this.lbl_player2_name.Name = "lbl_player2_name";
            this.lbl_player2_name.Size = new System.Drawing.Size(164, 29);
            this.lbl_player2_name.TabIndex = 1;
            this.lbl_player2_name.Text = "Player 2 neve:";
            // 
            // txtbx_player1_name
            // 
            this.txtbx_player1_name.Location = new System.Drawing.Point(182, 18);
            this.txtbx_player1_name.Name = "txtbx_player1_name";
            this.txtbx_player1_name.Size = new System.Drawing.Size(181, 20);
            this.txtbx_player1_name.TabIndex = 2;
            // 
            // txtbx_player2_name
            // 
            this.txtbx_player2_name.Location = new System.Drawing.Point(182, 69);
            this.txtbx_player2_name.Name = "txtbx_player2_name";
            this.txtbx_player2_name.Size = new System.Drawing.Size(181, 20);
            this.txtbx_player2_name.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(144, 110);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 141);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txtbx_player2_name);
            this.Controls.Add(this.txtbx_player1_name);
            this.Controls.Add(this.lbl_player2_name);
            this.Controls.Add(this.lbl_player1_name);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 180);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_player1_name;
        private System.Windows.Forms.Label lbl_player2_name;
        private System.Windows.Forms.TextBox txtbx_player1_name;
        private System.Windows.Forms.TextBox txtbx_player2_name;
        private System.Windows.Forms.Button btn_start;
    }
}

