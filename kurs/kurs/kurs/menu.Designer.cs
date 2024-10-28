
namespace kurs
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.START = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Transparent;
            this.START.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.ForeColor = System.Drawing.SystemColors.ControlText;
            this.START.Location = new System.Drawing.Point(304, 186);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(157, 55);
            this.START.TabIndex = 0;
            this.START.Text = "СТАРТ";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // record
            // 
            this.record.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.ForeColor = System.Drawing.SystemColors.ControlText;
            this.record.Location = new System.Drawing.Point(304, 257);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(157, 55);
            this.record.TabIndex = 1;
            this.record.Text = "РЕКОРД";
            this.record.UseVisualStyleBackColor = true;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quit.Location = new System.Drawing.Point(304, 401);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(157, 55);
            this.quit.TabIndex = 3;
            this.quit.Text = "ВЫХОД";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 113);
            this.label1.TabIndex = 4;
            this.label1.Text = "ElDorado";
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.info.Location = new System.Drawing.Point(304, 331);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(157, 55);
            this.info.TabIndex = 5;
            this.info.Text = "ИНФО";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ткаченко С.И. О724Б";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.record);
            this.Controls.Add(this.START);
            this.Controls.Add(this.label2);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Label label2;
    }
}