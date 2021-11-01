using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static PointOfSale_wf.Views.Tools.Styles;

namespace PointOfSale_wf.Views.Tools
{
    public class FormBase : Form
    {
        public Styles ApplicationStyle = null;

        public FormBase()
        {
            this.LoadStyles();
            this.SetMovement();
        }

        private void SetMovement()
        {
            WindowMovement.SetMovement(this);
        }

        public void InvokeMouseDown(MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void LoadStyles()
        {
            this.ApplicationStyle = new Styles();
            StyleModel Style =  this.ApplicationStyle.CurrentStyle;

            this.BackColor = Style.Background;
            this.ForeColor = Style.ForeColor;
            this.Font = new Font(Style.FontFamily,
                                 Style.FontSize,
                                 this.Font.Style);
        }
    }
}
