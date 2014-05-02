namespace BlackJack
{
    partial class BlackJack
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
            this.hit = new System.Windows.Forms.Button();
            this.playercard1 = new System.Windows.Forms.PictureBox();
            this.stand = new System.Windows.Forms.Button();
            this.playercard2 = new System.Windows.Forms.PictureBox();
            this.dealercard1 = new System.Windows.Forms.PictureBox();
            this.dealercard2 = new System.Windows.Forms.PictureBox();
            this.bet = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.betsum = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playercount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dealercount = new System.Windows.Forms.Label();
            this.messagebox = new System.Windows.Forms.Label();
            this.playercard3 = new System.Windows.Forms.PictureBox();
            this.playercard4 = new System.Windows.Forms.PictureBox();
            this.playercard5 = new System.Windows.Forms.PictureBox();
            this.dealercard3 = new System.Windows.Forms.PictureBox();
            this.dealercard4 = new System.Windows.Forms.PictureBox();
            this.dealercard5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.amountbetted = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playercard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // hit
            // 
            this.hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit.Location = new System.Drawing.Point(25, 352);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(87, 45);
            this.hit.TabIndex = 0;
            this.hit.Text = "Hit";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // playercard1
            // 
            this.playercard1.Location = new System.Drawing.Point(325, 243);
            this.playercard1.Name = "playercard1";
            this.playercard1.Size = new System.Drawing.Size(60, 85);
            this.playercard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playercard1.TabIndex = 1;
            this.playercard1.TabStop = false;
            // 
            // stand
            // 
            this.stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stand.Location = new System.Drawing.Point(128, 352);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(85, 47);
            this.stand.TabIndex = 2;
            this.stand.Text = "Stand";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // playercard2
            // 
            this.playercard2.Location = new System.Drawing.Point(249, 243);
            this.playercard2.Name = "playercard2";
            this.playercard2.Size = new System.Drawing.Size(59, 85);
            this.playercard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playercard2.TabIndex = 3;
            this.playercard2.TabStop = false;
            // 
            // dealercard1
            // 
            this.dealercard1.InitialImage = null;
            this.dealercard1.Location = new System.Drawing.Point(249, 86);
            this.dealercard1.Name = "dealercard1";
            this.dealercard1.Size = new System.Drawing.Size(59, 85);
            this.dealercard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealercard1.TabIndex = 4;
            this.dealercard1.TabStop = false;
            // 
            // dealercard2
            // 
            this.dealercard2.Location = new System.Drawing.Point(325, 86);
            this.dealercard2.Name = "dealercard2";
            this.dealercard2.Size = new System.Drawing.Size(59, 85);
            this.dealercard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealercard2.TabIndex = 5;
            this.dealercard2.TabStop = false;
            // 
            // bet
            // 
            this.bet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet.Location = new System.Drawing.Point(419, 352);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(198, 47);
            this.bet.TabIndex = 6;
            this.bet.Text = "Play";
            this.bet.UseVisualStyleBackColor = true;
            this.bet.Click += new System.EventHandler(this.bet_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.user.Location = new System.Drawing.Point(284, 360);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(68, 29);
            this.user.TabIndex = 11;
            this.user.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dealer: Tina ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(414, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bet Amount:";
            // 
            // betsum
            // 
            this.betsum.AutoSize = true;
            this.betsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsum.ForeColor = System.Drawing.Color.Yellow;
            this.betsum.Location = new System.Drawing.Point(527, 306);
            this.betsum.Name = "betsum";
            this.betsum.Size = new System.Drawing.Size(0, 24);
            this.betsum.TabIndex = 14;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(564, 305);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(23, 23);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(593, 305);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(23, 23);
            this.subtract.TabIndex = 16;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(415, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Account:";
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.Color.Yellow;
            this.account.Location = new System.Drawing.Point(502, 275);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(0, 24);
            this.account.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(234, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Player Count:";
            // 
            // playercount
            // 
            this.playercount.AutoSize = true;
            this.playercount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playercount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.playercount.Location = new System.Drawing.Point(377, 203);
            this.playercount.Name = "playercount";
            this.playercount.Size = new System.Drawing.Size(0, 25);
            this.playercount.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(234, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dealer Count:";
            // 
            // dealercount
            // 
            this.dealercount.AutoSize = true;
            this.dealercount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealercount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dealercount.Location = new System.Drawing.Point(378, 56);
            this.dealercount.Name = "dealercount";
            this.dealercount.Size = new System.Drawing.Size(0, 25);
            this.dealercount.TabIndex = 22;
            // 
            // messagebox
            // 
            this.messagebox.AutoSize = true;
            this.messagebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagebox.ForeColor = System.Drawing.Color.White;
            this.messagebox.Location = new System.Drawing.Point(29, 17);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(0, 37);
            this.messagebox.TabIndex = 23;
            this.messagebox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playercard3
            // 
            this.playercard3.Location = new System.Drawing.Point(175, 243);
            this.playercard3.Name = "playercard3";
            this.playercard3.Size = new System.Drawing.Size(59, 85);
            this.playercard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playercard3.TabIndex = 26;
            this.playercard3.TabStop = false;
            // 
            // playercard4
            // 
            this.playercard4.Location = new System.Drawing.Point(100, 243);
            this.playercard4.Name = "playercard4";
            this.playercard4.Size = new System.Drawing.Size(59, 85);
            this.playercard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playercard4.TabIndex = 27;
            this.playercard4.TabStop = false;
            // 
            // playercard5
            // 
            this.playercard5.Location = new System.Drawing.Point(25, 243);
            this.playercard5.Name = "playercard5";
            this.playercard5.Size = new System.Drawing.Size(59, 85);
            this.playercard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playercard5.TabIndex = 28;
            this.playercard5.TabStop = false;
            // 
            // dealercard3
            // 
            this.dealercard3.Location = new System.Drawing.Point(405, 86);
            this.dealercard3.Name = "dealercard3";
            this.dealercard3.Size = new System.Drawing.Size(59, 85);
            this.dealercard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealercard3.TabIndex = 29;
            this.dealercard3.TabStop = false;
            // 
            // dealercard4
            // 
            this.dealercard4.Location = new System.Drawing.Point(486, 86);
            this.dealercard4.Name = "dealercard4";
            this.dealercard4.Size = new System.Drawing.Size(59, 85);
            this.dealercard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealercard4.TabIndex = 30;
            this.dealercard4.TabStop = false;
            // 
            // dealercard5
            // 
            this.dealercard5.Location = new System.Drawing.Point(567, 86);
            this.dealercard5.Name = "dealercard5";
            this.dealercard5.Size = new System.Drawing.Size(59, 85);
            this.dealercard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealercard5.TabIndex = 31;
            this.dealercard5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.dealer;
            this.pictureBox1.Location = new System.Drawing.Point(54, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // amountbetted
            // 
            this.amountbetted.AutoSize = true;
            this.amountbetted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountbetted.ForeColor = System.Drawing.Color.Yellow;
            this.amountbetted.Location = new System.Drawing.Point(518, 223);
            this.amountbetted.Name = "amountbetted";
            this.amountbetted.Size = new System.Drawing.Size(0, 24);
            this.amountbetted.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.betbox;
            this.pictureBox2.Location = new System.Drawing.Point(445, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BlackJack.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(234, 352);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(647, 417);
            this.Controls.Add(this.amountbetted);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dealercard5);
            this.Controls.Add(this.dealercard4);
            this.Controls.Add(this.dealercard3);
            this.Controls.Add(this.playercard5);
            this.Controls.Add(this.playercard4);
            this.Controls.Add(this.playercard3);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.dealercount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.playercount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.betsum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.dealercard2);
            this.Controls.Add(this.dealercard1);
            this.Controls.Add(this.playercard2);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.playercard1);
            this.Controls.Add(this.hit);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlackJack";
            this.Text = "BLACKJACK";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playercard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealercard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //#endregion

        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.PictureBox playercard1;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.PictureBox playercard2;
        private System.Windows.Forms.PictureBox dealercard1;
        private System.Windows.Forms.PictureBox dealercard2;
        private System.Windows.Forms.Button bet;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label betsum;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label playercount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dealercount;
        private System.Windows.Forms.Label messagebox;
        private System.Windows.Forms.PictureBox playercard3;
        private System.Windows.Forms.PictureBox playercard4;
        private System.Windows.Forms.PictureBox playercard5;
        private System.Windows.Forms.PictureBox dealercard3;
        private System.Windows.Forms.PictureBox dealercard4;
        private System.Windows.Forms.PictureBox dealercard5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label amountbetted;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

        #endregion