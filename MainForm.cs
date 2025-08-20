using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace AutoShutdown
{
    public partial class MainForm : Form
    {
        private DateTime? _scheduledAt;
        private int _scheduledSeconds;

        public MainForm()
        {
            InitializeComponent();
            dtpSchedule.Value = DateTime.Now.AddMinutes(5);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            var target = dtpSchedule.Value;
            var now = DateTime.Now;
            if (target <= now)
            {
                MessageBox.Show("Please choose a future time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var seconds = (int)Math.Round((target - now).TotalSeconds);
            ScheduleShutdown(seconds);
            _scheduledAt = target;
            _scheduledSeconds = seconds;
            timerUpdate.Start();
        }

        private void btnCountdown_Click(object sender, EventArgs e)
        {
            int seconds = (int)txtSeconds.Value;
            ScheduleShutdown(seconds);
            _scheduledAt = DateTime.Now.AddSeconds(seconds);
            _scheduledSeconds = seconds;
            timerUpdate.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                RunShutdownArgs("/a");
                lblStatus.Text = "Canceled any scheduled shutdowns.";
                _scheduledAt = null;
                timerUpdate.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cancel failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (_scheduledAt.HasValue)
            {
                var remaining = _scheduledAt.Value - DateTime.Now;
                if (remaining.TotalSeconds <= 0)
                {
                    lblStatus.Text = "Shutdown imminent...";
                    timerUpdate.Stop();
                }
                else
                {
                    lblStatus.Text = $"Shutdown scheduled at {_scheduledAt:yyyy-MM-dd HH:mm:ss} (in {FormatSpan(remaining)}).";
                }
            }
            else
            {
                lblStatus.Text = "Ready.";
            }
        }

        private void ScheduleShutdown(int seconds)
        {
            try
            {
                var sb = new StringBuilder();
                sb.Append("/s /t ").Append(seconds);
                if (chkForce.Checked) sb.Append(" /f");
                RunShutdownArgs(sb.ToString());
                lblStatus.Text = $"Scheduled shutdown in {seconds} seconds.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Schedule failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FormatSpan(TimeSpan ts)
        {
            if (ts.TotalHours >= 1)
                return $"{(int)ts.TotalHours}h {ts.Minutes}m {ts.Seconds}s";
            if (ts.TotalMinutes >= 1)
                return $"{(int)ts.TotalMinutes}m {ts.Seconds}s";
            return $"{(int)Math.Max(0, Math.Round(ts.TotalSeconds))}s";
        }

        private static void RunShutdownArgs(string args)
        {
            var psi = new ProcessStartInfo("shutdown", args)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }
    }
}