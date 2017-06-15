using System;
using System.Windows.Forms;

namespace KlickerGUI
{


    class GlobalHotkey
    {

        private int modifier;
        private int key;
        private IntPtr hWnd;
        private int id;
        private bool registered;

        public bool Registered
        {
            get
            {
                return registered;
            }
        }

        public GlobalHotkey(int modifier, Keys key, Form form)
        {
            this.modifier = modifier;
            this.key = (int)key;
            hWnd = form.Handle;
            id = GetHashCode();
        }


        public override int GetHashCode()
        {
            return modifier ^ key ^ hWnd.ToInt32();
        }


        public bool Register()
        {
            if (registered)
            {
                return true;
            }
            if (SafeNativeMethods.RegisterHotKey(hWnd, id, modifier, key))
            {
                registered = true;
                return true;
            }
            return false;
        }

        public bool Unregiser()
        {
            if (!registered)
            {
                return true;
            }
            if (SafeNativeMethods.UnregisterHotKey(hWnd, id))
            {
                registered = false;
                return true;
            }
            return false;
        }

        public bool Update(int modifier, Keys key, Form form)
        {
            if (registered)
            {
                if (!Unregiser())
                {
                    return false;
                }
            }

            this.modifier = modifier;
            this.key = (int)key;
            hWnd = form.Handle;
            id = GetHashCode();

            if (!Register())
            {
                return false;
            }

            return true;
        }

        public bool Toggle()
        {

            if (registered)
            {
                return Unregiser();
            }
            else
            {
                return Register();
            }
        }

        public bool SetState(bool State)
        {
            if (State)
            {
                return Register();
            }
            return Unregiser();
        }


        public static class Constants
        {
            //modifiers
            public const int NOMOD = 0x0000;
            public const int ALT = 0x0001;
            public const int CTRL = 0x0002;
            public const int SHIFT = 0x0004;
            public const int WIN = 0x0008;

            //windows message id for hotkey
            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }
    }
}
