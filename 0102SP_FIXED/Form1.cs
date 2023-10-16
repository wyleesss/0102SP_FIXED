using System.Diagnostics;

namespace _0102SP_FIXED
{

    public partial class Form1 : Form
    {
        Process[] processes = Process.GetProcesses();

        public Form1()
        {
            InitializeComponent();

            processListView.Columns.Add("Process Name", 230, HorizontalAlignment.Center);
            processListView.Columns.Add("ID", 100, HorizontalAlignment.Center);
            processListView.Columns.Add("CPU Usage (%)", 150, HorizontalAlignment.Center);
            processListView.Columns.Add("Memory Usage (MB)", 200, HorizontalAlignment.Center);
            processListView.Columns.Add("Start Time", 100, HorizontalAlignment.Center);
            processListView.Columns.Add("Thread Count", 145, HorizontalAlignment.Center);
            processListView.Font = new Font(processListView.Font, FontStyle.Bold);

            update();
        }

        public void update()
        {
            this.processListView.Items.Clear();

            this.timeLabel.Text = DateTime.Now.ToLongTimeString();
            processes = Process.GetProcesses();
            this.countLabel.Text = processes.Length.ToString();

            foreach (var process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());

                try { item.SubItems.Add(process.TotalProcessorTime.TotalSeconds.ToString("0.00")); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                try { item.SubItems.Add((process.WorkingSet64 / (1024 * 1024)).ToString("0.00")); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                try { item.SubItems.Add(process.StartTime.ToShortTimeString()); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                try { item.SubItems.Add(process.Threads.Count.ToString()); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                processListView.Items.Add(item);
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            update();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.timer.Interval = Convert.ToInt16(numericUpDown1.Value) * 1000;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            programmState.Text = "stopped";
            programmState.ForeColor = Color.Red;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            programmState.Text = "running";
            programmState.ForeColor = Color.Blue;
            update();
        }
    }
}