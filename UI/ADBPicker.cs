using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestHome.UI
{
    public partial class ADBPicker : Form
    {
        private IniData config;
        private bool canClose = false;

        public ADBPicker()
        {
            InitializeComponent();
            config = Program.config;
            FillList();
        }

        private void FillList()
        {
            lst_found.Items.Clear();
            foreach (var path in ADB.DefaultSearchPaths)
            {
                if (path.Exists) lst_found.Items.Add(path.FullName);
            }
        }

        private void lst_found_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_found.SelectedIndex < 0) return;
            txt_selected.Text = lst_found.SelectedItem.ToString();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(txt_selected.Text))
            {
                MessageBox.Show("Selected File does not exist.\n\nTry again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                config["ADB"]["path"] = txt_selected.Text;
                canClose = true;
                Close();
            }
        }

        private void btn_custom_Click(object sender, EventArgs e)
        {
            txt_selected.Text = Utils.pickFile("Select adb.exe", null, "adb.exe|adb.exe|All files (*.*)|*.*").FullName;
        }

        private void ADBPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose) Application.Exit();
        }
    }
}