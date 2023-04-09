
namespace guessing_number
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblguessed = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.lblguesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Minecrafter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(338, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CheckNumber);
            // 
            // lblguessed
            // 
            this.lblguessed.AutoSize = true;
            this.lblguessed.Font = new System.Drawing.Font("Minecrafter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguessed.Location = new System.Drawing.Point(215, 127);
            this.lblguessed.Name = "lblguessed";
            this.lblguessed.Size = new System.Drawing.Size(275, 15);
            this.lblguessed.TabIndex = 0;
            this.lblguessed.Text = "Guess The Number Between:";
            this.lblguessed.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Minecrafter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumber.Location = new System.Drawing.Point(231, 183);
            this.TxtNumber.Multiline = true;
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(331, 31);
            this.TxtNumber.TabIndex = 3;
            this.TxtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // lblguesses
            // 
            this.lblguesses.AutoSize = true;
            this.lblguesses.Font = new System.Drawing.Font("Minecrafter Alt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguesses.Location = new System.Drawing.Point(275, 355);
            this.lblguesses.Name = "lblguesses";
            this.lblguesses.Size = new System.Drawing.Size(245, 18);
            this.lblguesses.TabIndex = 4;
            this.lblguesses.Text = "You Guessed 0 Times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblguesses);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblguessed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblguessed;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Label lblguesses;
    }
}

