
namespace kurs
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.labelINFO = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelINFO
            // 
            this.labelINFO.AutoSize = true;
            this.labelINFO.BackColor = System.Drawing.Color.Transparent;
            this.labelINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelINFO.ForeColor = System.Drawing.Color.White;
            this.labelINFO.Location = new System.Drawing.Point(-1, 39);
            this.labelINFO.Name = "labelINFO";
            this.labelINFO.Size = new System.Drawing.Size(776, 403);
            this.labelINFO.TabIndex = 0;
            this.labelINFO.Text = resources.GetString("labelINFO.Text");
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quit.Location = new System.Drawing.Point(564, 467);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(157, 55);
            this.quit.TabIndex = 4;
            this.quit.Text = "НАЗАД";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.labelINFO);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelINFO;
        private System.Windows.Forms.Button quit;
    }
}