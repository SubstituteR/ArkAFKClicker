using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlickerGUI
{
    public partial class SettingsUI : Form
    {

        private bool capture = false;

        public SettingsUI()
        {
            InitializeComponent();
        }

        private void Hotkey_Click(object sender, EventArgs e)
        {
            hotkeyLabel.Text = "Hotkey ...";
        }

        private void Capture_Key(object sender, EventArgs e)
        {

        }

        private void SettingsUI_Load(object sender, EventArgs e)
        {
            //Todo
            //this entire form.
        }
    }
}
