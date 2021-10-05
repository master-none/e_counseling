
namespace e_counseling
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_studentprofile = new System.Windows.Forms.Button();
            this.btn_logcomplaint = new System.Windows.Forms.Button();
            this.btn_managecomplaint = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_studentprofile
            // 
            this.btn_studentprofile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_studentprofile.Image = ((System.Drawing.Image)(resources.GetObject("btn_studentprofile.Image")));
            this.btn_studentprofile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_studentprofile.Location = new System.Drawing.Point(0, 110);
            this.btn_studentprofile.Name = "btn_studentprofile";
            this.btn_studentprofile.Size = new System.Drawing.Size(412, 81);
            this.btn_studentprofile.TabIndex = 1;
            this.btn_studentprofile.UseVisualStyleBackColor = false;
            this.btn_studentprofile.Click += new System.EventHandler(this.btn_studentprofile_Click);
            // 
            // btn_logcomplaint
            // 
            this.btn_logcomplaint.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_logcomplaint.Image = ((System.Drawing.Image)(resources.GetObject("btn_logcomplaint.Image")));
            this.btn_logcomplaint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logcomplaint.Location = new System.Drawing.Point(0, 192);
            this.btn_logcomplaint.Name = "btn_logcomplaint";
            this.btn_logcomplaint.Size = new System.Drawing.Size(412, 74);
            this.btn_logcomplaint.TabIndex = 2;
            this.btn_logcomplaint.UseVisualStyleBackColor = false;
            this.btn_logcomplaint.Click += new System.EventHandler(this.btn_logcomplaint_Click);
            // 
            // btn_managecomplaint
            // 
            this.btn_managecomplaint.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_managecomplaint.Image = ((System.Drawing.Image)(resources.GetObject("btn_managecomplaint.Image")));
            this.btn_managecomplaint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_managecomplaint.Location = new System.Drawing.Point(1, 267);
            this.btn_managecomplaint.Name = "btn_managecomplaint";
            this.btn_managecomplaint.Size = new System.Drawing.Size(411, 76);
            this.btn_managecomplaint.TabIndex = 3;
            this.btn_managecomplaint.UseVisualStyleBackColor = false;
            this.btn_managecomplaint.Click += new System.EventHandler(this.btn_managecomplaint_Click);
            // 
            // btn_schedule
            // 
            this.btn_schedule.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_schedule.Image = ((System.Drawing.Image)(resources.GetObject("btn_schedule.Image")));
            this.btn_schedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_schedule.Location = new System.Drawing.Point(0, 344);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(413, 76);
            this.btn_schedule.TabIndex = 4;
            this.btn_schedule.UseVisualStyleBackColor = false;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 420);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(412, 79);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(405, 501);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_schedule);
            this.Controls.Add(this.btn_managecomplaint);
            this.Controls.Add(this.btn_logcomplaint);
            this.Controls.Add(this.btn_studentprofile);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_studentprofile;
        private System.Windows.Forms.Button btn_logcomplaint;
        private System.Windows.Forms.Button btn_managecomplaint;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button btn_settings;
    }
}