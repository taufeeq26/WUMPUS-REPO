namespace WumpusTest
{
    partial class HighScoreDisplayForm
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
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highScoreLabel.Location = new System.Drawing.Point(44, 54);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(363, 236);
            this.highScoreLabel.TabIndex = 0;
            this.highScoreLabel.Text = "label1";
            // 
            // HighScoreDisplayForm
            // 
            this.ClientSize = new System.Drawing.Size(461, 388);
            this.Controls.Add(this.highScoreLabel);
            this.Name = "HighScoreDisplayForm";
            this.Load += new System.EventHandler(this.HighScoreDisplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label highScoreLabel;
    }
}
