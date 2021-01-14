namespace Launcher_DiamondLifeRP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_connect = new System.Windows.Forms.Button();
            this.progbar_connect = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.Location = new System.Drawing.Point(649, 397);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(0);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(142, 44);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // progbar_connect
            // 
            this.progbar_connect.BackColor = System.Drawing.SystemColors.Info;
            this.progbar_connect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progbar_connect.Location = new System.Drawing.Point(12, 397);
            this.progbar_connect.Name = "progbar_connect";
            this.progbar_connect.Size = new System.Drawing.Size(634, 44);
            this.progbar_connect.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progbar_connect.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progbar_connect);
            this.Controls.Add(this.btn_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiamondLife Launcher";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ProgressBar progbar_connect;
    }
}

