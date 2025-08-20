namespace AutoShutdown
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnCountdown = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.chkForce = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSchedule.Location = new System.Drawing.Point(16, 32);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(256, 23);
            this.dtpSchedule.TabIndex = 0;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(280, 32);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(160, 24);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Schedule Shutdown";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel Scheduled Shutdown";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Countdown (seconds to shut):";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(188, 74);
            this.txtSeconds.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.txtSeconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(84, 23);
            this.txtSeconds.TabIndex = 2;
            this.txtSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnCountdown
            // 
            this.btnCountdown.Location = new System.Drawing.Point(280, 72);
            this.btnCountdown.Name = "btnCountdown";
            this.btnCountdown.Size = new System.Drawing.Size(160, 24);
            this.btnCountdown.TabIndex = 3;
            this.btnCountdown.Text = "Start Countdown";
            this.btnCountdown.UseVisualStyleBackColor = true;
            this.btnCountdown.Click += new System.EventHandler(this.btnCountdown_Click);
            // 
            // chkForce
            // 
            this.chkForce.AutoSize = true;
            this.chkForce.Location = new System.Drawing.Point(16, 112);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(196, 19);
            this.chkForce.TabIndex = 6;
            this.chkForce.Text = "Force close apps (/f) if needed";
            this.chkForce.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 152);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Ready.";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 184);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkForce);
            this.Controls.Add(this.btnCountdown);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.dtpSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoShutdown";
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtSeconds;
        private System.Windows.Forms.Button btnCountdown;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.CheckBox chkForce;
    }
}