using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale_wf.Views.Tools
{
    public class WindowMovement
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


        public static void SetMovement(Form Window)
        {
            Window.MouseDown += (o, e) => {
                ReleaseCapture();
                SendMessage(Window.Handle, 0x112, 0xf012, 0);
            };
        }

        public static void SetMovement(MainView Window, UserControl Control)
        {
            Control.MouseDown += (o, e) =>
            {
                Window.InvokeMouseDown(e);
            };

        }

    }
}
