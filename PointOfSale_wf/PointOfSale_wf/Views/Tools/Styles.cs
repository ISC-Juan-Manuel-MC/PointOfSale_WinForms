using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PointOfSale_wf.Views.Tools
{
    public class Styles
    {

        public class StyleModel
        {
            public Color Background { get; set; }
            public Color ForeColor { get; set; }
            public String FontFamily { get; set; }
            public int FontSize { get; set; }

            public StyleModel(Color background, Color foreColor, string fontFamily, int fontSize)
            {
                this.Background = background;
                this.ForeColor = foreColor;
                this.FontFamily = fontFamily;
                this.FontSize = fontSize;
            }
        }

        public static Color ColorBlue = Color.FromArgb(1, 22, 56);
        public static Color ColorGreen = Color.FromArgb(0,207,95);
        public static Color ColorWhite = Color.White;
        public static Color ColorBlack = Color.Black;
        public static Color ColorGray = Color.LightGray;
        public static String FontFamilyTitle = "Raleway-ExtraBold";
        public static String FontFamilySubTitle = "Raleway-Medium";
        public static String FontFamilyBody = "Montserrat-Regular";
        public static int FontSizeTitle = 14;
        public static int FontSizeBody = 9;

        public StyleModel CurrentStyle = null;

        public Styles()
        {
            this.CurrentStyle = this.BodyStyle();
        }

        public StyleModel TitleStyle()
        {
            return new StyleModel(ColorGreen, ColorBlue, FontFamilyTitle,FontSizeTitle);
        }

        public StyleModel BodyStyle()
        {
            return new StyleModel( ColorGray, ColorBlue, FontFamilyBody, FontSizeBody);
        }


    }
}

