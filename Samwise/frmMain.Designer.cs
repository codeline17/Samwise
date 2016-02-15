namespace Samwise
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.mainTmr = new System.Windows.Forms.Timer(this.components);
            this.tmrLiveScore = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtDebug
            // 
            this.txtDebug.BackColor = System.Drawing.Color.DimGray;
            this.txtDebug.ForeColor = System.Drawing.Color.Lime;
            this.txtDebug.Location = new System.Drawing.Point(0, 166);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(924, 95);
            this.txtDebug.TabIndex = 0;
            this.txtDebug.Text = "TryMe";
            // 
            // mainTmr
            // 
            this.mainTmr.Tick += new System.EventHandler(this.mainTmr_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 261);
            this.Controls.Add(this.txtDebug);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Samwise Gamgee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Timer mainTmr;
        private System.Windows.Forms.Timer tmrLiveScore;
    }
}

