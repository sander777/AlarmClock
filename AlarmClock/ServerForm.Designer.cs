namespace AlarmClock
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.ConectionInfo = new System.Windows.Forms.Label();
            this.Tasks = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ConectionInfo
            // 
            this.ConectionInfo.AutoSize = true;
            this.ConectionInfo.Location = new System.Drawing.Point(12, 9);
            this.ConectionInfo.Name = "ConectionInfo";
            this.ConectionInfo.Size = new System.Drawing.Size(94, 17);
            this.ConectionInfo.TabIndex = 0;
            this.ConectionInfo.Text = "ConectionInfo";
            // 
            // Tasks
            // 
            this.Tasks.Location = new System.Drawing.Point(15, 40);
            this.Tasks.Name = "Tasks";
            this.Tasks.ReadOnly = true;
            this.Tasks.Size = new System.Drawing.Size(759, 225);
            this.Tasks.TabIndex = 1;
            this.Tasks.Text = "";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.ConectionInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerForm";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConectionInfo;
        private System.Windows.Forms.RichTextBox Tasks;
    }
}

