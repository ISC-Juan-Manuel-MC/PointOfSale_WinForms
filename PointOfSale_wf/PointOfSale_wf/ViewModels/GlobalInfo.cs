using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale_wf.ViewModels
{
    public class GlobalInfo
    {
        public static string CompanyName = null;

        public static void LoadDefaultValues()
        {
            GlobalInfo.CompanyName = "Malco Corporate";
        }

    }
}
