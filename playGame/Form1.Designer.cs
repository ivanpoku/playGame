namespace playGame
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
            this.playGameLabel = new System.Windows.Forms.Label();
            this.playCountdown = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameLabel
            // 
            this.playGameLabel.AutoSize = true;
            this.playGameLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameLabel.Location = new System.Drawing.Point(183, 165);
            this.playGameLabel.Name = "playGameLabel";
            this.playGameLabel.Size = new System.Drawing.Size(155, 32);
            this.playGameLabel.TabIndex = 0;
            this.playGameLabel.Text = "Play Game";
            // 
            // playCountdown
            // 
            this.playCountdown.AutoSize = true;
            this.playCountdown.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playCountdown.Location = new System.Drawing.Point(252, 217);
            this.playCountdown.Name = "playCountdown";
            this.playCountdown.Size = new System.Drawing.Size(22, 24);
            this.playCountdown.TabIndex = 1;
            this.playCountdown.Text = "3";
            this.playCountdown.Click += new System.EventHandler(this.playCountdown_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(187, 263);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(151, 49);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.LimeGreen;
            this.background.Location = new System.Drawing.Point(-6, -6);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(525, 489);
            this.background.TabIndex = 3;
            this.background.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.playCountdown);
            this.Controls.Add(this.playGameLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Play Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playGameLabel;
        private System.Windows.Forms.Label playCountdown;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label background;
    }
}

