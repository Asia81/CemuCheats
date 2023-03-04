using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindWakerHD_Rewrite
{
    public class Linktweaks
    {
        public static async Task<byte[]> GetMaxHearts(string Hearts)
        {
            List<byte> gethearts = new List<byte>();
            switch (Hearts)
            {
                case "1 Heart":
                    gethearts.Add(0x04);
                    break;

                case "2 Hearts":
                    gethearts.Add(0x08);
                    break;

                case "3 Hearts":
                    gethearts.Add(0x0C);
                    break;

                case "4 Hearts":
                    gethearts.Add(0x10);
                    break;

                case "5 Hearts":
                    gethearts.Add(0x14);
                    break;

                case "6 Hearts":
                    gethearts.Add(0x18);
                    break;

                case "7 Hearts":
                    gethearts.Add(0x1C);
                    break;

                case "8 Hearts":
                    gethearts.Add(0x20);
                    break;

                case "9 Hearts":
                    gethearts.Add(0x24);
                    break;

                case "10 Hearts":
                    gethearts.Add(0x28);
                    break;

                case "11 Hearts":
                    gethearts.Add(0x2C);
                    break;

                case "12 Hearts":
                    gethearts.Add(0x30);
                    break;

                case "13 Hearts":
                    gethearts.Add(0x34);
                    break;

                case "14 Hearts":
                    gethearts.Add(0x38);
                    break;

                case "15 Hearts":
                    gethearts.Add(0x3C);
                    break;

                case "16 Hearts":
                    gethearts.Add(0x40);
                    break;

                case "17 Hearts":
                    gethearts.Add(0x44);
                    break;

                case "18 Hearts":
                    gethearts.Add(0x48);
                    break;

                case "19 Hearts":
                    gethearts.Add(0x4C);
                    break;

                case "20 Hearts":
                    gethearts.Add(0x50);
                    break;
            }
            return gethearts.ToArray();
        }

        public static async Task<byte[]> GetMaxMagic(string Magic)
        {
            List<byte> getmagic = new List<byte>();
            switch (Magic)
            {
                case "No Magic":
                    getmagic.Add(0x00);
                    break;

                case "Normal Magic":
                    getmagic.Add(0x10);
                    break;

                case "Double Magic":
                    getmagic.Add(0x20);
                    break;
            }
            return getmagic.ToArray();
        }
    }
}
