using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale_wf.Views.Tools
{
    public class UserControlBase: UserControl
    {
        protected MainView MainView = null;

        public virtual void InitializeControl(MainView View,bool IsHeader = false)
        {
            this.MainView = View;
            SetMovement();
            LoadStyles(IsHeader);
            LoadGlobalInfo();
        }

        private void SetMovement()
        {
            WindowMovement.SetMovement(this.MainView, this);
        }

        private void LoadStyles(bool IsHeader)
        {
            Styles.StyleModel Style = IsHeader ? this.MainView.ApplicationStyle.TitleStyle() : this.MainView.ApplicationStyle.CurrentStyle;
            
            this.BackColor = Style.Background;
            this.ForeColor = Style.ForeColor;
            this.Font = new Font(Style.FontFamily,
                                 Style.FontSize,
                                 this.Font.Style);
        }

        public virtual void LoadGlobalInfo()
        {

        }

    }
}
