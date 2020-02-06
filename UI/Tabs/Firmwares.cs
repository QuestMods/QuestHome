using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestHome.UI
{
    public partial class MainForm
    {
        private readonly Uri fwRepositoryURL = new Uri("https://quest.minopia.de/fw");
        private List<Classes.Firmware> lastFwResponse;

        public void PreloadFirmwares()
        {
            Task.Factory.StartNew(() => LoadAvailableFirmwares());
        }

        private List<Classes.Firmware> LoadAvailableFirmwares(Uri url = null)
        {
            try
            {
                if (url is null) url = fwRepositoryURL;
                Logger.Debug("Requesting list of available firmwares from {}", url.AbsoluteUri);
                var txt = webClient.DownloadString(url);
                lastFwResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Classes.Firmware>>(txt);
                Logger.Trace(lastFwResponse.ToJson());
                return lastFwResponse;
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Can't load available firmwares", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                switch (result)
                {
                    case DialogResult.Retry:
                        LoadAvailableFirmwares(); break;
                    case DialogResult.Ignore:
                        break;

                    default:
                        Application.Exit(); break;
                }
            }
            return new List<Classes.Firmware>();
        }

        private void FillFirmwares(bool clear = true, List<Classes.Firmware> lst = null)
        {
            if (lst is null) lst = lastFwResponse;
            if (lst is null || lst.Count < 1) return;
            if (clear) lst_fw.Items.Clear();
            foreach (var fw in lst)
            {
                lst_fw.Items.Add(fw);
            }
        }

        private void lst_fw_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFirmware(lst_fw.SelectedItem as Classes.Firmware);
        }

        private void FillFirmware(Classes.Firmware fw)
        {
            txt_fw_id.Text = fw.Id;
            txt_fw_release.Text = $"{((fw.Released == DateTime.MinValue) ? "?" : fw.Released.Date.ToString("d"))} (Added: {fw.Added})";
            txt_fw_changelog.Text = fw.Changelog?.Replace("\\n", "\n");
            // if (box_fw_mirror_color_bak != Color.Empty) box_fw_mirror.BackColor = box_fw_mirror_color_bak;
            box_fw_mirror.Items.Clear();
            var lst = new List<Classes.Mirror>();
            foreach (var mirror in fw.Mirrors)
            {
                var m = new Classes.Mirror(mirror);
                lst.Add(m);
            }
            lst = lst.OrderBy(m => m.Reply.RoundtripTime).ToList();
            box_fw_mirror.Items.AddRange(lst.ToArray());
            box_fw_mirror.SelectedIndex = 0;
        }

        private void btn_fw_apply_Click(object sender, EventArgs e)
        {
            var mirror = box_fw_mirror.SelectedItem as Classes.Mirror;
            MessageBox.Show(mirror.URL.AbsoluteUri);
        }

        // Color box_fw_mirror_color_bak;
        private void box_fw_mirror_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var mirror = box_fw_mirror.SelectedItem as Classes.Mirror;
            /*box_fw_mirror_color_bak  = box_fw_mirror.BackColor;
            if (mirror.Reply.RoundtripTime < 25) box_fw_mirror.BackColor = Color.LightGreen;
            else if (mirror.Reply.RoundtripTime < 50) box_fw_mirror.BackColor = Color.LightBlue;
            else if (mirror.Reply.RoundtripTime < 150) box_fw_mirror.BackColor = Color.Orange;
            else box_fw_mirror.BackColor = Color.OrangeRed;*/
        }

        private void openInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fw = lst_fw.SelectedItem as Classes.Firmware;
            if (fw.ChangelogURL is null) return;
            var uri = new Uri(fw.ChangelogURL);
            uri.OpenInDefault();
        }
    }
}