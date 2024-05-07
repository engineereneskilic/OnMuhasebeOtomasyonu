using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace _BusinessLayer
{
    public static class cammonClass
    {
        public static string ZeroIfEmpty(this string s)
        {
            return string.IsNullOrEmpty(s) ? "0" : s;
        }
        public static string ToTitleCase(string metin)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(metin);
        }
        public static string ToStringTL(double fiyat)
        {
            //return String.Format("{0:C1}", fiyat);
            string[] sadece_fiyat = fiyat.ToString("C").Split(' ');
            return sadece_fiyat[0];
        }

        public static Color DisabledColor()
        {
            Color DisabledColor = Color.FromArgb(240, 240, 240);

            return DisabledColor;
        }

        public static string MonthDateToString(int MonthDate)
        {
            string monthString;

            switch (MonthDate)
            {
                case 1:
                    monthString = "Ocak";
                    break;
                case 2:
                    monthString = "Şubat";
                    break;
                case 3:
                    monthString = "Mart";
                    break;
                case 4:
                    monthString = "Nisan";
                    break;
                case 5:
                    monthString = "Mayıs";
                    break;
                case 6:
                    monthString = "Haziran";
                    break;
                case 7:
                    monthString = "Temmuz";
                    break;
                case 8:
                    monthString = "Ağustos";
                    break;
                case 9:
                    monthString = "Eylül";
                    break;
                case 10:
                    monthString = "Ekim";
                    break;
                case 11:
                    monthString = "Kasım";
                    break;
                case 12:
                    monthString = "Aralık";
                    break;
                default:
                    monthString = "Bilinmiyor";
                    break;
            }

            return monthString;
        }

        
    }
 }
