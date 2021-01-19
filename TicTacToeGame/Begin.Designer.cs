namespace TicTacToeGame
{
    partial class Begin
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
            this.startGame3x3Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startGame5x5Button = new System.Windows.Forms.Button();
            this.startGame4x4Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playNowLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGame3x3Button
            // 
            this.startGame3x3Button.Location = new System.Drawing.Point(6, 46);
            this.startGame3x3Button.Name = "startGame3x3Button";
            this.startGame3x3Button.Size = new System.Drawing.Size(306, 23);
            this.startGame3x3Button.TabIndex = 0;
            this.startGame3x3Button.Text = "Start game 3x3";
            this.startGame3x3Button.UseVisualStyleBackColor = true;
            this.startGame3x3Button.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startGame5x5Button);
            this.groupBox1.Controls.Add(this.startGame4x4Button);
            this.groupBox1.Controls.Add(this.startGame3x3Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a table";
            // 
            // startGame5x5Button
            // 
            this.startGame5x5Button.Location = new System.Drawing.Point(6, 104);
            this.startGame5x5Button.Name = "startGame5x5Button";
            this.startGame5x5Button.Size = new System.Drawing.Size(306, 23);
            this.startGame5x5Button.TabIndex = 15;
            this.startGame5x5Button.Text = "Start game 5x5";
            this.startGame5x5Button.UseVisualStyleBackColor = true;
            this.startGame5x5Button.Click += new System.EventHandler(this.startGame5x5Button_Click);
            // 
            // startGame4x4Button
            // 
            this.startGame4x4Button.Location = new System.Drawing.Point(6, 75);
            this.startGame4x4Button.Name = "startGame4x4Button";
            this.startGame4x4Button.Size = new System.Drawing.Size(306, 23);
            this.startGame4x4Button.TabIndex = 14;
            this.startGame4x4Button.Text = "Start game 4x4";
            this.startGame4x4Button.UseVisualStyleBackColor = true;
            this.startGame4x4Button.Click += new System.EventHandler(this.startGame4x4Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.playNowLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 58);
            this.panel1.TabIndex = 3;
            // 
            // playNowLabel
            // 
            this.playNowLabel.AutoSize = true;
            this.playNowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.playNowLabel.Location = new System.Drawing.Point(42, 12);
            this.playNowLabel.Name = "playNowLabel";
            this.playNowLabel.Size = new System.Drawing.Size(238, 31);
            this.playNowLabel.TabIndex = 0;
            this.playNowLabel.Text = "Tic Tac Toe Game";
            // 
            // Begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Begin";
            this.Text = "Tic Tac Toe Game";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startGame3x3Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playNowLabel;
        private System.Windows.Forms.Button startGame5x5Button;
        private System.Windows.Forms.Button startGame4x4Button;
    }
}

