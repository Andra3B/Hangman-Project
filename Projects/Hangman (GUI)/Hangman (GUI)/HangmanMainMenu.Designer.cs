namespace Hangman__GUI_
{
    partial class HangmanMainMenu
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.flpMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hangman";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMenuOptions
            // 
            this.flpMenuOptions.Controls.Add(this.btnPlay);
            this.flpMenuOptions.Controls.Add(this.btnOption);
            this.flpMenuOptions.Location = new System.Drawing.Point(10, 65);
            this.flpMenuOptions.Margin = new System.Windows.Forms.Padding(0);
            this.flpMenuOptions.Name = "flpMenuOptions";
            this.flpMenuOptions.Size = new System.Drawing.Size(362, 384);
            this.flpMenuOptions.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(362, 75);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Tag = "HangmanGameWindow";
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnOption
            // 
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.Location = new System.Drawing.Point(0, 85);
            this.btnOption.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(362, 75);
            this.btnOption.TabIndex = 2;
            this.btnOption.Tag = "HangmanOptionMenu";
            this.btnOption.Text = "Options";
            this.btnOption.UseVisualStyleBackColor = true;
            // 
            // HangmanMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.flpMenuOptions);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "HangmanMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.flpMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.FlowLayoutPanel flpMenuOptions;
        public System.Windows.Forms.Button btnPlay;
        public System.Windows.Forms.Button btnOption;
    }
}

