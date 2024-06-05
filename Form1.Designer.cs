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
            ScoreLabel.ForeColor = SystemColors.Control;
            ScoreLabel.Location = new Point(12, 9);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(49, 20);
            ScoreLabel.TabIndex = 0;
            ScoreLabel.Text = "Score:";
            // 
            // ScoreNumberLabel
            // 
            ScoreNumberLabel.AutoSize = true;
            ScoreNumberLabel.ForeColor = SystemColors.Control;
            ScoreNumberLabel.Location = new Point(64, 9);
            ScoreNumberLabel.Name = "ScoreNumberLabel";
            ScoreNumberLabel.Size = new Size(0, 20);
            ScoreNumberLabel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(782, 553);
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