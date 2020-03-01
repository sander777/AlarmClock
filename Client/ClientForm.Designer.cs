namespace Client
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.Timer = new System.Windows.Forms.Label();
            this.TimerForm = new System.Windows.Forms.TextBox();
            this.AlarmClock = new System.Windows.Forms.Label();
            this.AlarmLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SetAlarmClock = new System.Windows.Forms.Button();
            this.SetTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(67, 48);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(141, 34);
            this.Timer.TabIndex = 0;
            this.Timer.Text = "Timer.\r\nInput time in seconds";
            this.Timer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerForm
            // 
            this.TimerForm.Location = new System.Drawing.Point(92, 85);
            this.TimerForm.Name = "TimerForm";
            this.TimerForm.Size = new System.Drawing.Size(100, 22);
            this.TimerForm.TabIndex = 1;
            // 
            // AlarmClock
            // 
            this.AlarmClock.AutoSize = true;
            this.AlarmClock.Location = new System.Drawing.Point(102, 169);
            this.AlarmClock.Name = "AlarmClock";
            this.AlarmClock.Size = new System.Drawing.Size(82, 17);
            this.AlarmClock.TabIndex = 2;
            this.AlarmClock.Text = "Alarm Clock";
            // 
            // AlarmLabel
            // 
            this.AlarmLabel.AutoSize = true;
            this.AlarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AlarmLabel.Location = new System.Drawing.Point(84, 283);
            this.AlarmLabel.Name = "AlarmLabel";
            this.AlarmLabel.Size = new System.Drawing.Size(124, 46);
            this.AlarmLabel.TabIndex = 4;
            this.AlarmLabel.Text = "Alarm";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(92, 201);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Enter += new System.EventHandler(this.dateTimePicker_Enter);
            // 
            // SetAlarmClock
            // 
            this.SetAlarmClock.Location = new System.Drawing.Point(70, 229);
            this.SetAlarmClock.Name = "SetAlarmClock";
            this.SetAlarmClock.Size = new System.Drawing.Size(160, 39);
            this.SetAlarmClock.TabIndex = 6;
            this.SetAlarmClock.Text = "Set Alarm Clock";
            this.SetAlarmClock.UseVisualStyleBackColor = true;
            this.SetAlarmClock.Click += new System.EventHandler(this.SetAlarmClock_Click);
            // 
            // SetTimer
            // 
            this.SetTimer.Location = new System.Drawing.Point(92, 113);
            this.SetTimer.Name = "SetTimer";
            this.SetTimer.Size = new System.Drawing.Size(100, 32);
            this.SetTimer.TabIndex = 7;
            this.SetTimer.Text = "Set Timer";
            this.SetTimer.UseVisualStyleBackColor = true;
            this.SetTimer.Click += new System.EventHandler(this.SetTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::Client.Properties.Resources.refresh_512;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(214, 200);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(26, 23);
            this.refresh.TabIndex = 8;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.SetTimer);
            this.Controls.Add(this.SetAlarmClock);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.AlarmLabel);
            this.Controls.Add(this.AlarmClock);
            this.Controls.Add(this.TimerForm);
            this.Controls.Add(this.Timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.TextBox TimerForm;
        private System.Windows.Forms.Label AlarmClock;
        private System.Windows.Forms.Label AlarmLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button SetAlarmClock;
        private System.Windows.Forms.Button SetTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button refresh;
    }
}

