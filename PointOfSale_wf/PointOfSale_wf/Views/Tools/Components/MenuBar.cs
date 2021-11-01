using PointOfSale_wf.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale_wf.Views.Tools.Components
{
    public partial class MenuBar : UserControlBase
    {
        public MenuBar()
        {
            InitializeComponent();
            LoadMenuOptions();
        }

        public override void InitializeControl(MainView View, bool IsHeader = false)
        {
            base.InitializeControl(View, IsHeader);
            this.SetStyleToTitleButton();
        }

        private void SetStyleToTitleButton()
        {
            Styles.StyleModel Title = this.MainView.ApplicationStyle.TitleStyle();
            btnMenuTitle.Font = new Font(Title.FontFamily, Title.FontSize, btnMenuTitle.Font.Style);
        }

        public override void LoadGlobalInfo()
        {
            base.LoadGlobalInfo();
            this.btnMenuTitle.Text = GlobalInfo.CompanyName;
        }

        private void LoadMenuOptions()
        {
            flpMenuItemList.Controls.Add(new MenuItem());
            flpMenuItemList.Controls.Add(new MenuItem());
            flpMenuItemList.Controls.Add(new MenuItem());
            flpMenuItemList.Controls.Add(new MenuItem());
            flpMenuItemList.Controls.Add(new MenuItem());
            flpMenuItemList.Controls.Add(new MenuItem());
            flpMenuItemList.Controls.Add(new MenuItem());
        }
    }
}
