using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlickerGUI
{
    public partial class MainUI : Form
    {
        private IntPtr[] gameHandles = null;
        
        private GlobalHotkey ghk;

        public MainUI()
        {
            InitializeComponent();
            ghk = new GlobalHotkey(GlobalHotkey.Constants.CTRL | GlobalHotkey.Constants.SHIFT, Keys.C, this);
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == GlobalHotkey.Constants.WM_HOTKEY_MSG_ID)
            {
                ToggleClicking();
            }
            base.WndProc(ref m);
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            FindGame();
            CreateLabelBinding(ClickingstatusLabel, Settings.Status, "Clicking");
            CreateLabelBinding(GamefocusedstatusLabel, Settings.Status, "GameForeground");
            CreateLabelBinding(FoundgamestatusLabel, Settings.Status, "GameFound");
            CreateLabelBinding(HotkeyenabledstatusLabel, Settings.Status, "HotkeyEnabled");
        }




        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ghk.Unregiser();
        }

        private void ConfigureButton_Click(object sender, EventArgs e)
        {
            
            Program.settingsUI.ShowDialog();   
        }

        private void ToggleClicking()
        {
            Settings.Status.Clicking = !Settings.Status.Clicking;

            Text = Settings.Status.Clicking.ToString();
            if (Settings.Status.Clicking)
            {
                ClickTimer.Start();
            }
            else
            {
                ClickTimer.Stop();
                IntPtr[] localHandles = gameHandles;
                foreach (IntPtr gameHandle in localHandles)
                {
                    //Clear Clicking
                    ManagedMethods.SendMouseAsKeyboardUp(gameHandle);
                    ManagedMethods.SendMouseUp(gameHandle);
                }
            }
        }

        private void FindGame()
        {
            List<IntPtr> newHandles = new List<IntPtr> { };
            foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("ShooterGame"))
            {
                newHandles.Add(proc.MainWindowHandle);
            }
            gameHandles = newHandles.ToArray();
            Settings.Status.GameFound = (gameHandles.Length > 0);
            Settings.Status.HotkeyEnabled = ghk.SetState(Settings.Status.GameFound);
        }

        private void CheckFocus()
        {
            IntPtr[] localHandles = gameHandles; //Keep our handles even if gameHandles updates.
            IntPtr focusedHandle = SafeNativeMethods.GetForegroundWindow();
            Settings.Status.GameForeground = localHandles.Contains(focusedHandle);
        }

        private void GamesearchTimer_Tick(object sender, EventArgs e)
        {
            FindGame();
            CheckFocus();
        }


        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            IntPtr[] localHandles = gameHandles; //Keep our handles even if gameHandles updates.
            IntPtr focusedHandle = SafeNativeMethods.GetForegroundWindow();

            foreach (IntPtr gameHandle in localHandles)
            {
                if (gameHandle == focusedHandle)
                {
                    ManagedMethods.SendMouseAsKeyboardOnce(gameHandle);

                }
                else
                {
                    ManagedMethods.SendMouseOnce(gameHandle);
                }
            }
        }




        private void CreateLabelBinding(Label ObjectToBind, object ObjectFromBind, string PropertyToBind)
        {

            Binding TextBind = new Binding("Text", ObjectFromBind, PropertyToBind);
            Binding ColorBind = new Binding("ForeColor", ObjectFromBind, PropertyToBind);
            TextBind.Format += new ConvertEventHandler(FormatTextBind);
            ColorBind.Format += new ConvertEventHandler(FormatColorBind);
            ObjectToBind.DataBindings.Add(TextBind);
            ObjectToBind.DataBindings.Add(ColorBind);
        }

        //Format Bindings
        private void FormatColorBind(object sender, ConvertEventArgs e)
        {
            if ((bool)e.Value == true)
            {
                e.Value = Color.DarkGreen;
            }
            else
            {
                e.Value = Color.DarkRed;
            }
        }

        private void FormatTextBind(object sender, ConvertEventArgs e)
        {
            if ((bool)e.Value == true)
            {
                e.Value = "✔️";
            }
            else
            {
                e.Value = "✖️";
            }
        }

    }
}
