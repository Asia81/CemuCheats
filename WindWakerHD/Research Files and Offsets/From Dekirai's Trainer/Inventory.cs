using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindWakerHD_Rewrite
{
    public class Inventory
    {
        public static async Task<uint[]> GetItemAddress(string Itemname)
        {
            List<uint> getaddress = new List<uint>();

            switch (Itemname)
            {
                case "Telescope":
                    getaddress.Add(0x150736BC);
                    break;

                case "Wind Waker":
                    getaddress.Add(0x150736BE);
                    break;

                case "Grappling Hook":
                    getaddress.Add(0x150736BF);
                    break;

                case "Picto Box":
                case "Deluxe Box":
                    getaddress.Add(0x150736C4);
                    break;

                case "Iron Boots":
                    getaddress.Add(0x150736C5);
                    break;

                case "Hookshot":
                    getaddress.Add(0x150736CF);
                    break;

                case "Bombs":
                    getaddress.Add(0x150736C9);
                    break;

                case "Skull Hammer":
                    getaddress.Add(0x150736D0);
                    break;

                case "Hero's Bow":
                case "Hero's Bow (Fire & Ice)":
                case "Hero's Bow (Fire, Ice & Light)":
                    getaddress.Add(0x150736C8);
                    break;

                case "Magic Armor":
                    getaddress.Add(0x150736C6);
                    break;

                case "Boomerang":
                    getaddress.Add(0x150736C1);
                    break;

                case "Deku Leaf":
                    getaddress.Add(0x150736C2);
                    break;

                case "Bait Bag":
                    getaddress.Add(0x150736C7);
                    break;

                case "Delivery Bag":
                    getaddress.Add(0x150736CE);
                    break;
                case "Spoils Bag":
                    getaddress.Add(0x150736C0);
                    break;

                case "Hero's Sword":
                case "Master Sword":
                case "Master Sword (half restored)":
                case "Master Sword (fully restored)":
                    getaddress.Add(0x1507368E);
                    break;

                case "Hero's Shield":
                case "Mirror Shield":
                    getaddress.Add(0x1507368F);
                    break;

                case "Hero's Charm":
                    getaddress.Add(0x15073738);
                    break;

                case "Power Bracelets":
                    getaddress.Add(0x15073690);
                    break;

                default:
                    getaddress.Add(0x150736BC);
                    break;
            }

            return getaddress.ToArray();
        }

        public static async Task<byte[]> GetItemValue(string Itemname)
        {
            List<byte> getitem = new List<byte>();

            switch (Itemname)
            {
                case "Telescope":
                    getitem.Add(0x20);
                    break;

                case "Wind Waker":
                    getitem.Add(0x22);
                    break;

                case "Grappling Hook":
                    getitem.Add(0x25);
                    break;

                case "Picto Box":
                    getitem.Add(0x23);
                    break;

                case "Deluxe Box":
                    getitem.Add(0x26);
                    break;

                case "Iron Boots":
                    getitem.Add(0x29);
                    break;

                case "Hookshot":
                    getitem.Add(0x2F);
                    break;

                case "Bombs":
                    getitem.Add(0x31);
                    break;

                case "Skull Hammer":
                    getitem.Add(0x33);
                    break;

                case "Hero's Bow":
                    getitem.Add(0x27);
                    break;

                case "Hero's Bow (Fire & Ice)":
                    getitem.Add(0x35);
                    break;

                case "Hero's Bow (Fire, Ice & Light)":
                    getitem.Add(0x36);
                    break;

                case "Magic Armor":
                    getitem.Add(0x2A);
                    break;

                case "Boomerang":
                    getitem.Add(0x2D);
                    break;

                case "Deku Leaf":
                    getitem.Add(0x34);
                    break;

                case "Bait Bag":
                    getitem.Add(0x2C);
                    break;

                case "Delivery Bag":
                    getitem.Add(0x30);
                    break;

                case "Spoils Bag":
                    getitem.Add(0x24);
                    break;

                case "Hero's Sword":
                    getitem.Add(0x38);
                    break;

                case "Master Sword":
                    getitem.Add(0x39);
                    break;

                case "Master Sword (half restored)":
                    getitem.Add(0x3A);
                    break;

                case "Master Sword (fully restored)":
                    getitem.Add(0x3E);
                    break;

                case "Hero's Shield":
                    getitem.Add(0x3B);
                    break;

                case "Mirror Shield":
                    getitem.Add(0x3C);
                    break;

                case "Hero's Charm":
                    getitem.Add(0x01);
                    break;

                case "Tingle Bottle":
                    getitem.Add(0x21);
                    break;

                case "Power Bracelets":
                    getitem.Add(0x28);
                    break;

                case "No Bottle":
                    getitem.Add(0xFF);
                    break;

                case "Empty":
                    getitem.Add(0x50);
                    break;

                case "Red Elixier":
                    getitem.Add(0x51);
                    break;

                case "Green Elixier":
                    getitem.Add(0x52);
                    break;

                case "Blue Elixier":
                    getitem.Add(0x53);
                    break;

                case "Soup (Half)":
                    getitem.Add(0x54);
                    break;

                case "Soup":
                    getitem.Add(0x55);
                    break;

                case "Water":
                    getitem.Add(0x56);
                    break;

                case "Fairy":
                    getitem.Add(0x57);
                    break;

                case "Pollen":
                    getitem.Add(0x58);
                    break;

                case "Magic Water":
                    getitem.Add(0x59);
                    break;

                default:
                    getitem.Add(0x20);
                    break;
            }

            return getitem.ToArray();
        }
    }
}