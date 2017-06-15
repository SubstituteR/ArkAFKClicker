using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]

namespace KlickerGUI
{
    static class SafeNativeMethods
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetFocus();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, UIntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern uint MapVirtualKey(uint uCode, uint uMapType);

    }

    static class ManagedMethods
    {
        //bits 0-15 = repeat count (2 bytes)
        //bits 16-23 = scan code (1 byte)
        //bit 24 = extended key (1 bit)
        //bits 25-28 = reserved, do not use.  (4 bits)
        //bit 29 = context code (0 for WM_KEYDOWN, 1 for WM_KEYUP)
        //bit 30 = previous keystate, 1 = down, 0 = up
        //bit 31 = transition state, 0 for WM_KEYDOWN, 1 for WM_KEYUP)
        internal static uint ConstructlParam(ushort count, Keys Key, bool extended, bool contextcode, KeyState previousstate, KeyState transitionstate)
        {
            uint lParam = 0x00000000; //4 bytes
            uint ScanCode = SafeNativeMethods.MapVirtualKey((uint) Key, 0) << 16; //Key scancode and set it to the bits 16-23
            lParam |= count; //combine the 16 bits for count
            lParam |= ScanCode;
            if (extended)
            {
                lParam |= (0x1 << 24); //24th bit
            }
            if (contextcode)
            {
                lParam |= (0x1 << 29); //29th bit
            }

            lParam |= ((uint) previousstate << 30); //30th bit


            lParam |= ((uint) transitionstate << 31); //31st bit

            return lParam;
        }




        //Keydown states:
        //Context = ALWAYS FALSE
        //Key down = 100, down, down
        //Key up = 101, up, up

        internal static void SendKeyOnce(IntPtr hWnd, Keys Key)
        {

            uint lParam = ConstructlParam(1, Key, false, false, KeyState.Down, KeyState.Down);
            if (SafeNativeMethods.SendMessage(hWnd, 0x0100, (IntPtr)Key, (UIntPtr)lParam) != (IntPtr) 0)
            {
                MessageBox.Show("ERR");
            }
            lParam = ConstructlParam(1, Key, false, false, KeyState.Up, KeyState.Up);

            if (SafeNativeMethods.SendMessage(hWnd, 0x0101, (IntPtr)Key, (UIntPtr)lParam) != (IntPtr)0)
            {
                MessageBox.Show("ERR");
            }

        }




        internal static void SendKeyUp(IntPtr hWnd, Keys Key)
        {

            uint lParam = ConstructlParam(1, Key, false, false, KeyState.Up, KeyState.Up);

            if (SafeNativeMethods.SendMessage(hWnd, 0x0101, (IntPtr)Key, (UIntPtr)lParam) != (IntPtr)0)
            {
                MessageBox.Show("ERR");
            }

        }




        internal static void SendMouseAsKeyboardOnce(IntPtr hWnd)
        {
            SendKeyOnce(hWnd, Keys.LButton);
        }

        internal static void SendMouseAsKeyboardUp(IntPtr hWnd)
        {
            SendKeyUp(hWnd, Keys.LButton);
        }

        internal static void SendMouseOnce(IntPtr hWnd)
        {
            SafeNativeMethods.SendMessage(hWnd, (UInt32)0x0201, (IntPtr)Keys.LButton, (UIntPtr)0);
            SafeNativeMethods.SendMessage(hWnd, (UInt32)0x0208, (IntPtr)Keys.LButton, (UIntPtr)0);
        }


        internal static void SendMouseUp(IntPtr hWnd)
        {
            SafeNativeMethods.SendMessage(hWnd, (UInt32)0x0208, (IntPtr)Keys.LButton, (UIntPtr)0);
        }

        public enum KeyState
        {
            Down = 0,
            Up = 1
        }

    }
}
