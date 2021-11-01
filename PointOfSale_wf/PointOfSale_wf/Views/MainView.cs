using PointOfSale_wf.Views.Tools;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PointOfSale_wf.ViewModels;

namespace PointOfSale_wf.Views
{
    public partial class MainView : FormBase
    {
        

        public MainView()
        {
            InitializeComponent();
            GlobalInfo.LoadDefaultValues();

            bool IsHeader = true;
            pnlWindowControl.InitializeControl(this,IsHeader);
            mnbMenu.InitializeControl(this,!IsHeader);
        }


    }
}
