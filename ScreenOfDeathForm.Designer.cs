namespace WumpusTest
{
    partial class ScreenOfDeathForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenOfDeathForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowScores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(558, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(234, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Escape";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnShowScores
            // 
            this.btnShowScores.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowScores.Location = new System.Drawing.Point(36, 464);
            this.btnShowScores.Name = "btnShowScores";
            this.btnShowScores.Size = new System.Drawing.Size(408, 61);
            this.btnShowScores.TabIndex = 5;
            this.btnShowScores.Text = "Show High Scores";
            this.btnShowScores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Informal Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your score is 100";
            // 
            // ScreenOfDeathForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 562);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowScores);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenOfDeathForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowScores;
        private System.Windows.Forms.Label label1;
    }
}
