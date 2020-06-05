namespace RandomGenerator
{
    partial class FrmRandGen
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
            this.btnGenRand = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenRand
            // 
            this.btnGenRand.Location = new System.Drawing.Point(151, 250);
            this.btnGenRand.Name = "btnGenRand";
            this.btnGenRand.Size = new System.Drawing.Size(272, 126);
            this.btnGenRand.TabIndex = 0;
            this.btnGenRand.Text = "Shuffle and Read";
            this.btnGenRand.UseVisualStyleBackColor = true;
            this.btnGenRand.Click += new System.EventHandler(this.btnGenRand_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(146, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 75);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = " Take a Deep Calming Breath.\r\n Concentrate on your question.\r\n Your in-depth Read" +
    "ing";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // FrmRandGen
            // 
            this.ClientSize = new System.Drawing.Size(579, 552);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGenRand);
            this.Name = "FrmRandGen";
            this.Text = "Mahjong Divination App";
            this.Load += new System.EventHandler(this.FrmRandGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumGen;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button btnGenRand;
        private System.Windows.Forms.Label lblTitle;
    }
}

