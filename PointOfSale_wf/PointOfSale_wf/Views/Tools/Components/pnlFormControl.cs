using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale_wf.Views.Tools.Components
{
    public partial class pnlFormControl : UserControlBase
    {

        public pnlFormControl()
        {
            InitializeComponent();
        }

        public override void InitializeControl(MainView View, bool IsHeader = false)
        {
            base.InitializeControl(View,IsHeader);
            SetIconStatus();
            SetEvents();
        }

        private void SetIconStatus()
        {
            if(this.MainView.WindowState == FormWindowState.Maximized)
            {
                pbxRestore.Visible = true;
                pbxMaximize.Visible = false;
            }
            else
            {
                pbxRestore.Visible = false;
                pbxMaximize.Visible = true;
            }
        }

        private void SetEvents()
        {
            this.pbxClose.Click += (o, e) => { CloseApplication(); };
            this.pbxRestore.Click += (o, e) => { Restore(); };
            this.pbxMaximize.Click += (o, e) => { Maximize(); };
            this.pbxMinimize.Click += (o, e) => { Minimize(); };

            this.MainView.Resize += (o, e) => { SetIconStatus(); };

            this.pnlSpace.DoubleClick += (o, e) => { DoubleClickEvent(); };
        }

        private void CloseApplication()
        {
            Application.Exit();
        }

        private void Minimize()
        {
            this.MainView.WindowState = FormWindowState.Minimized;
        }

        private void Maximize()
        {
            this.MainView.WindowState = FormWindowState.Maximized;
        }

        private void Restore()
        {
            this.MainView.WindowState = FormWindowState.Normal;
        }
    
        private void DoubleClickEvent()
        {
            if(this.MainView.WindowState == FormWindowState.Maximized)
            {
                this.Restore();
            }
            else
            {
                this.Maximize();
            }
        }

    }
}
