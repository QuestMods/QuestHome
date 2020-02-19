using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestHome.UI
{
    public partial class MainForm
    {
        private readonly Uri homeRepositoryURL = new Uri("https://quest.minopia.de/homes/api/?format=json");
        private List<Classes.Environment> lastHomeResponse;

        public void InitializeHomes()
        {
            Task.Factory.StartNew(() => LoadAvailableHomes());
        }

        private void LoadAvailableHomes(Uri url = null)
        {
            try
            {
                if (url is null) url = homeRepositoryURL;
                var txt = webClient.DownloadString(url);
                lastHomeResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Classes.Environment>>(txt);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Can't load available homes", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                switch (result)
                {
                    case DialogResult.Retry:
                        LoadAvailableHomes(); break;
                    case DialogResult.Ignore:
                        break;

                    default:
                        Application.Exit(); break;
                }
            }
        }

        private void FillHomes(bool clear = true)
        {
            if (lastHomeResponse is null) return;
            if (clear) lst_homes.Items.Clear();
            foreach (var home in lastHomeResponse)
            {
                lst_homes.Items.Add(home, false);
            }
        }
    }
}