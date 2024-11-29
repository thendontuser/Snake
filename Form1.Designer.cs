namespace Snake
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            ScoreLabel = new Label();
            ScoreNumberLabel = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreLabel.ForeColor = SystemColors.Control;
            ScoreLabel.Location = new Point(12, 9);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(68, 21);
            ScoreLabel.TabIndex = 0;
            ScoreLabel.Text = "Score:";
            // 
            // ScoreNumberLabel
            // 
            ScoreNumberLabel.AutoSize = true;
            ScoreNumberLabel.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreNumberLabel.ForeColor = SystemColors.Control;
            ScoreNumberLabel.Location = new Point(86, 9);
            ScoreNumberLabel.Name = "ScoreNumberLabel";
            ScoreNumberLabel.Size = new Size(20, 21);
            ScoreNumberLabel.TabIndex = 1;
            ScoreNumberLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1342, 696);
            Controls.Add(ScoreNumberLabel);
            Controls.Add(ScoreLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Snake Game";
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label ScoreLabel;
        private Label ScoreNumberLabel;
    }
}