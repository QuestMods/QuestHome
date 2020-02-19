using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuestHome.UI.Popups
{
    public partial class ADBShell : Form
    {
        private ADB adb;
        private List<string> lastCMDs = new List<string>(10);
        private int lastCMDIndex = 0;

        public ADBShell(ADB adb)
        {
            this.adb = adb;
            InitializeComponent();
            this.Text = $"ADB Shell Session with {adb.currentDevice.Serial}";
            LogLine(DateTime.Now, $"Shell session with {adb.currentDevice.Serial} started.");
        }

        private void BringUp()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                TopMost = true;
                Focus();
                BringToFront();
                TopMost = false;
            }
        }

        private void Txt_chat_input_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SendCommand(txt_chat_input.Text);
                    txt_chat_input.Clear();
                    break;

                case Keys.Up:
                    txt_chat_input.Text = lastCMDs[lastCMDIndex - 1];
                    lastCMDIndex = lastCMDs.IndexOf(txt_chat_input.Text);
                    break;

                case Keys.Down:
                    txt_chat_input.Text = lastCMDs[lastCMDIndex + 1];
                    lastCMDIndex = lastCMDs.IndexOf(txt_chat_input.Text);
                    break;

                default:
                    return;
            }
            e.Handled = true;
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            SendCommand(txt_chat_input.Text);
            txt_chat_input.Clear();
        }

        private void SendCommand(string cmd = null, bool show = true)
        {
            if (cmd is null) cmd = txt_chat_input.Text;
            if (show) LogLine(DateTime.Now, adb.SendCommand(cmd));
        }

        private void LogLine(DateTime dateTime, string text)
        {
            if (string.IsNullOrWhiteSpace(text)) { return; }
            string timestamp = dateTime.ToString("HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
            var line = $"[{timestamp}] {text}";
            lst_shell.Items.Add(line);
            if (lst_shell.Items.Count > 150) lst_shell.Items.RemoveAt(0);
        }

        private void lst_shell_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index == 2 && lastCMDs.Count > 1) e.ItemHeight = lastCMDs.Last().Count(f => f == '/'); ;
        }

        //DrawItem event handler for your ListBox
        private void lst_shell_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(lst_shell.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }
    }
}