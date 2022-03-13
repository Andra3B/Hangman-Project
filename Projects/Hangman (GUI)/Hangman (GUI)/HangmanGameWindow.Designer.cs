namespace Hangman__GUI_
{
    partial class HangmanGameWindow
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
            this.tlpTopbar = new System.Windows.Forms.TableLayoutPanel();
            this.lblGuessedLetters = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblFragmentedWord = new System.Windows.Forms.Label();
            this.txtLetterInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tlpTopbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTopbar
            // 
            this.tlpTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tlpTopbar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTopbar.ColumnCount = 2;
            this.tlpTopbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpTopbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopbar.Controls.Add(this.lblGuessedLetters, 1, 1);
            this.tlpTopbar.Controls.Add(this.lblAttempts, 0, 1);
            this.tlpTopbar.Controls.Add(this.lblFragmentedWord, 0, 0);
            this.tlpTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopbar.Location = new System.Drawing.Point(0, 0);
            this.tlpTopbar.Name = "tlpTopbar";
            this.tlpTopbar.RowCount = 2;
            this.tlpTopbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopbar.Size = new System.Drawing.Size(484, 86);
            this.tlpTopbar.TabIndex = 0;
            // 
            // lblGuessedLetters
            // 
            this.lblGuessedLetters.AutoSize = true;
            this.lblGuessedLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessedLetters.ForeColor = System.Drawing.Color.White;
            this.lblGuessedLetters.Location = new System.Drawing.Point(188, 43);
            this.lblGuessedLetters.Name = "lblGuessedLetters";
            this.lblGuessedLetters.Size = new System.Drawing.Size(292, 42);
            this.lblGuessedLetters.TabIndex = 2;
            this.lblGuessedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.ForeColor = System.Drawing.Color.White;
            this.lblAttempts.Location = new System.Drawing.Point(4, 43);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(177, 42);
            this.lblAttempts.TabIndex = 1;
            this.lblAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFragmentedWord
            // 
            this.lblFragmentedWord.AutoSize = true;
            this.tlpTopbar.SetColumnSpan(this.lblFragmentedWord, 2);
            this.lblFragmentedWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFragmentedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFragmentedWord.ForeColor = System.Drawing.Color.White;
            this.lblFragmentedWord.Location = new System.Drawing.Point(4, 1);
            this.lblFragmentedWord.Name = "lblFragmentedWord";
            this.lblFragmentedWord.Size = new System.Drawing.Size(476, 41);
            this.lblFragmentedWord.TabIndex = 0;
            this.lblFragmentedWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetterInput
            // 
            this.txtLetterInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLetterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetterInput.Location = new System.Drawing.Point(189, 126);
            this.txtLetterInput.MaximumSize = new System.Drawing.Size(100, 100);
            this.txtLetterInput.MaxLength = 1;
            this.txtLetterInput.MinimumSize = new System.Drawing.Size(100, 100);
            this.txtLetterInput.Multiline = true;
            this.txtLetterInput.Name = "txtLetterInput";
            this.txtLetterInput.Size = new System.Drawing.Size(100, 100);
            this.txtLetterInput.TabIndex = 1;
            this.txtLetterInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(114, 234);
            this.btnSubmit.MaximumSize = new System.Drawing.Size(250, 60);
            this.btnSubmit.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(250, 60);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // HangmanGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLetterInput);
            this.Controls.Add(this.tlpTopbar);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "HangmanGameWindow";
            this.Text = "HangmanGameWindow";
            this.tlpTopbar.ResumeLayout(false);
            this.tlpTopbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpTopbar;
        public System.Windows.Forms.Label lblFragmentedWord;
        public System.Windows.Forms.Label lblGuessedLetters;
        public System.Windows.Forms.Label lblAttempts;
        public System.Windows.Forms.TextBox txtLetterInput;
        public System.Windows.Forms.Button btnSubmit;
    }
}