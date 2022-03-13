namespace Hangman__GUI_
{
    partial class HangmanOptionMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpMenuOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.tbDifficultySlider = new System.Windows.Forms.TrackBar();
            this.flpMenuOptions.SuspendLayout();
            this.gbDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDifficultySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Options";
            // 
            // flpMenuOptions
            // 
            this.flpMenuOptions.AutoScroll = true;
            this.flpMenuOptions.Controls.Add(this.gbDifficulty);
            this.flpMenuOptions.Location = new System.Drawing.Point(9, 36);
            this.flpMenuOptions.Margin = new System.Windows.Forms.Padding(0);
            this.flpMenuOptions.Name = "flpMenuOptions";
            this.flpMenuOptions.Size = new System.Drawing.Size(366, 416);
            this.flpMenuOptions.TabIndex = 2;
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.tbDifficultySlider);
            this.gbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDifficulty.Location = new System.Drawing.Point(3, 3);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(360, 100);
            this.gbDifficulty.TabIndex = 0;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Difficulty (Reduces the number of attempts)";
            // 
            // tbDifficultySlider
            // 
            this.tbDifficultySlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDifficultySlider.Location = new System.Drawing.Point(3, 22);
            this.tbDifficultySlider.Name = "tbDifficultySlider";
            this.tbDifficultySlider.Size = new System.Drawing.Size(354, 75);
            this.tbDifficultySlider.TabIndex = 0;
            // 
            // HangmanOptionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.flpMenuOptions);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "HangmanOptionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.flpMenuOptions.ResumeLayout(false);
            this.gbDifficulty.ResumeLayout(false);
            this.gbDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDifficultySlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.FlowLayoutPanel flpMenuOptions;
        public System.Windows.Forms.GroupBox gbDifficulty;
        public System.Windows.Forms.TrackBar tbDifficultySlider;
    }
}