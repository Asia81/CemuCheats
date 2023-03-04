using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindWakerHD_Rewrite
{
    public class Objects
    {
        public static async Task<uint[]> GetObjectAddress(string Objectname)
        {
            List<uint> getaddress = new List<uint>();

            switch (Objectname)
            {
                case "Grass x1":
                    getaddress.Add(0x106EE1E4);
                    break;

                case "Grass x7":
                    getaddress.Add(0x106EE1F0);
                    break;

                case "Grass x21":
                    getaddress.Add(0x106EE1FC);
                    break;

                case "Bush":
                    getaddress.Add(0x106EE268);
                    break;

                case "Palm":
                    getaddress.Add(0x106EEAB4);
                    break;

                case "Seagull":
                    getaddress.Add(0x106EEB14);
                    break;

                case "Orca":
                    getaddress.Add(0x106EEE14);
                    break;

                case "Boat":
                    getaddress.Add(0x106EEB44);
                    break;

                case "Stone":
                    getaddress.Add(0x106EE5BC);
                    break;

                case "Postbox":
                    getaddress.Add(0x106EF318);
                    break;

                case "Ship":
                    getaddress.Add(0x106EF33C);
                    break;

                default: //default is Postbox
                    getaddress.Add(0x106EF318);
                    break;
            }

            return getaddress.ToArray();
        }

        public static async Task<uint[]> GetObjectValue(string Objectname)
        {
            List<uint> getvalue = new List<uint>();

            switch (Objectname)
            {
                case "Grass":
                    getvalue.Add(0x01B3FF00);
                    break;

                case "Bush":
                    getvalue.Add(0x010AFF00);
                    break;

                case "Wood Fence":
                    getvalue.Add(0x012FFF00);
                    break;

                case "Door":
                    getvalue.Add(0x0131FF00);
                    break;

                case "Earth Temple Door":
                    getvalue.Add(0x012D0100);
                    break;

                case "Torch":
                    getvalue.Add(0x00B9FF00);
                    break;

                case "Wood Box":
                    getvalue.Add(0x01C50000);
                    break;

                case "Pots":
                    getvalue.Add(0x01C50500);
                    break;

                case "Hit Switch":
                    getvalue.Add(0x01C3FF00);
                    break;

                case "Stone":
                    getvalue.Add(0x01C60000);
                    break;

                case "Watch Tower":
                    getvalue.Add(0x00A4FF00);
                    break;

                case "Iron Shoe Switch":
                    getvalue.Add(0x001C0000);
                    break;

                case "Table":
                    getvalue.Add(0x00400000);
                    break;

                case "Searcher":
                    getvalue.Add(0x0042FF00);
                    break;

                case "Water Lily":
                    getvalue.Add(0x0078FF00);
                    break;

                case "Wind Temple Gate":
                    getvalue.Add(0x005EFF00);
                    break;

                case "Sun Moon Symbol":
                    getvalue.Add(0x001E0000);
                    break;

                case "Broken Stone Block":
                    getvalue.Add(0x0060FF00);
                    break;

                case "Palm Tree":
                    getvalue.Add(0x0049FF00);
                    break;

                case "Wood Sign":
                    getvalue.Add(0x00B6FF34);
                    break;

                case "Pollen":
                    getvalue.Add(0x00BBFF00);
                    break;

                case "Moblin":
                    getvalue.Add(0x00BCFF02);
                    break;

                case "Moblin Statue":
                    getvalue.Add(0x00F9FF00);
                    break;

                case "Gods Tower Bell":
                    getvalue.Add(0x00FAFF00);
                    break;

                case "Seagull":
                    getvalue.Add(0x00C2FF00);
                    break;

                case "Heart":
                    getvalue.Add(0x00FFFF00);
                    break;

                case "Boat":
                    getvalue.Add(0x00A5FF00);
                    break;

                case "Kargaroc":
                    getvalue.Add(0x00B5FF1A);
                    break;

                case "Rat":
                    getvalue.Add(0x00C6FF18);
                    break;

                case "Rathole":
                    getvalue.Add(0x00C7FF00);
                    break;

                case "Crab":
                    getvalue.Add(0x00C8FF00);
                    break;

                case "Helmaroc King":
                    getvalue.Add(0x00C9FF00);
                    break;

                case "Armos":
                    getvalue.Add(0x00CBFF0B);
                    break;

                case "Armos Knight":
                    getvalue.Add(0x00CAFF0C);
                    break;

                case "Morth":
                    getvalue.Add(0x00CDFF14);
                    break;

                case "ChuChu":
                    getvalue.Add(0x00CEFF16);
                    break;

                case "Skullhead":
                    getvalue.Add(0x00CFFF0F);
                    break;

                case "Wizzrobe":
                    getvalue.Add(0x00D0FF11);
                    break;

                case "Peahat":
                    getvalue.Add(0x00D1FF08);
                    break;

                case "Zelda":
                    getvalue.Add(0x00D2FF3C);
                    break;

                case "Jalhalla":
                    getvalue.Add(0x00D3FF00);
                    break;

                case "Poe":
                    getvalue.Add(0x00D4FF0D);
                    break;

                case "Propeller Peahat":
                    getvalue.Add(0x00D1FF1F);
                    break;

                case "Shooting Flower":
                    getvalue.Add(0x00D5FF21);
                    break;

                case "Boko Baba":
                    getvalue.Add(0x00D6FF07);
                    break;

                case "Valoo":
                    getvalue.Add(0x00DEFF00);
                    break;

                case "Single Pollen":
                    getvalue.Add(0x0139FF00);
                    break;

                case "Orca":
                    getvalue.Add(0x013EFF3B);
                    break;

                case "Willi":
                    getvalue.Add(0x015A0000);
                    break;

                case "Baito":
                    getvalue.Add(0x015CFF00);
                    break;

                case "Jabu":
                    getvalue.Add(0x0166FF00);
                    break;

                case "Little Fairy":
                    getvalue.Add(0x0168FF00);
                    break;

                case "Pirate Ship":
                    getvalue.Add(0x0039FF00);
                    break;

                case "Fire Keese":
                    getvalue.Add(0x00D7FF17);
                    break;

                case "Magtail":
                    getvalue.Add(0x00D8FF05);
                    break;

                case "Hiding Barrel":
                    getvalue.Add(0x01C8FF00);
                    break;

                case "Vertical Fire Fountain":
                    getvalue.Add(0x010BFF00);
                    break;

                case "Horizontal Vine":
                    getvalue.Add(0x00650000);
                    break;

                case "Lifting up Vine":
                    getvalue.Add(0x00660000);
                    break;

                case "Vine Platform":
                    getvalue.Add(0x00A3FF00);
                    break;

                case "Vertical Vine":
                    getvalue.Add(0x0067FF00);
                    break;

                case "Wood Wall":
                    getvalue.Add(0x018EFF00);
                    break;

                case "Haning Platform":
                    getvalue.Add(0x005AFF00);
                    break;

                case "Pig":
                    getvalue.Add(0x00DCFF00);
                    break;

                case "Octorok":
                    getvalue.Add(0x00E30141);
                    break;

                case "Big Octo":
                    getvalue.Add(0x00E1FF1C);
                    break;

                case "Bokoblin":
                    getvalue.Add(0x00BDFF01);
                    break;

                case "Hole":
                    getvalue.Add(0x00470000);
                    break;

                case "Warship":
                    getvalue.Add(0x00B3FF38);
                    break;

                case "Postbox":
                    getvalue.Add(0x0043FF35);
                    break;

                case "Rope with Anchor":
                    getvalue.Add(0x01AFFF00);
                    break;

                case "Red Flag":
                    getvalue.Add(0x00AF0000);
                    break;

                case "Flag with Skullhead":
                    getvalue.Add(0x00B00000);
                    break;

                case "Deciduous Tree":
                    getvalue.Add(0x0197FF00);
                    break;

                case "Falling Stone":
                    getvalue.Add(0x01A6FF00);
                    break;

                case "Valoos tail":
                    getvalue.Add(0x00DFFF00);
                    break;

                case "Magma stains":
                    getvalue.Add(0x01B2FF00);
                    break;

                case "Wood Floor":
                    getvalue.Add(0x0064FF00);
                    break;

                case "Wood Planks":
                    getvalue.Add(0x002D0000);
                    break;

                case "Helmaroc King (Boss)":
                    getvalue.Add(0x00EEFF00);
                    break;

                case "Stone Block":
                    getvalue.Add(0x00EFFF00);
                    break;

                case "Metal Plate":
                    getvalue.Add(0x00F8FF00);
                    break;

                case "Small Cannon":
                    getvalue.Add(0x003DFF00);
                    break;

                case "Wood Border":
                    getvalue.Add(0x003EFF00);
                    break;

                case "Hanging Flower":
                    getvalue.Add(0x0061FF00);
                    break;

                case "Fire circle":
                    getvalue.Add(0x01A8FF00);
                    break;

                case "Giant hanging Flower":
                    getvalue.Add(0x0062FF00);
                    break;

                case "Eyed Vine":
                    getvalue.Add(0x00FBFF00);
                    break;

                case "Swimming tree stomp":
                    getvalue.Add(0x0021FF00);
                    break;

                case "Invisible ground":
                    getvalue.Add(0x004A0700);
                    break;

                case "High shooting Flower":
                    getvalue.Add(0x0053FF00);
                    break;

                case "Wood Box (Metal)":
                    getvalue.Add(0x0054FF00);
                    break;

                case "Lantern on Rope":
                    getvalue.Add(0x00BAFF00);
                    break;

                case "Electro Beam":
                    getvalue.Add(0x00E8FF00);
                    break;

                case "Wood Spikes":
                    getvalue.Add(0x0132FF00);
                    break;

                case "Wood Door":
                    getvalue.Add(0x00730000);
                    break;

                case "Nut-looking plant":
                    getvalue.Add(0x0129FF00);
                    break;

                case "Stalfos":
                    getvalue.Add(0x00BEFF04);
                    break;

                case "Statue (Requires light)":
                    getvalue.Add(0x004B003D);
                    break;

                case "Stone Wall (Requires light)":
                    getvalue.Add(0x004CFF00);
                    break;

                case "Note Wall":
                    getvalue.Add(0x004DFF00);
                    break;

                case "Stair (Requires a switch)":
                    getvalue.Add(0x004EFF00);
                    break;

                case "Earth Temple Wall":
                    getvalue.Add(0x004FFF00);
                    break;

                case "Plate switch":
                    getvalue.Add(0x001D0000);
                    break;

                case "Vulcano Isle's lava":
                    getvalue.Add(0x0033FF00);
                    break;

                case "Ice Isle's frozenness":
                    getvalue.Add(0x0037FF00);
                    break;

                case "Part of a ship":
                    getvalue.Add(0x0108FF00);
                    break;

                case "Mighty Darknut":
                    getvalue.Add(0x00BFFF03);
                    break;

                case "Little pot tree":
                    getvalue.Add(0x0112FF00);
                    break;

                case "Wind blowing stone":
                    getvalue.Add(0x00A1FF00);
                    break;

                case "Fairy (unobtainable)":
                    getvalue.Add(0x01710000);
                    break;

                case "Wall (Requires Phantom Sword)":
                    getvalue.Add(0x0036FF00);
                    break;

                case "Puzzle":
                    getvalue.Add(0x0119FF00);
                    break;

                case "Iron boots jump box":
                    getvalue.Add(0x00A6FF3D);
                    break;

                case "Broken stone":
                    getvalue.Add(0x01200037);
                    break;

                case "Lenzo":
                    getvalue.Add(0x0177FF3B);
                    break;

                case "Spike platform":
                    getvalue.Add(0x007AFF32);
                    break;

                case "Ferris Wheel":
                    getvalue.Add(0x007BFF00);
                    break;

                case "Stone Wall (Outset Island)":
                    getvalue.Add(0x0086FF00);
                    break;

                case "Golden fence":
                    getvalue.Add(0x0089FF00);
                    break;

                case "Windfall thing":
                    getvalue.Add(0x0080FF00);
                    break;

                case "Wood Planks (Square)":
                    getvalue.Add(0x0024FF00);
                    break;

                case "Statue (Requires bomb)":
                    getvalue.Add(0x00A2FF00);
                    break;

                case "Face rock":
                    getvalue.Add(0x00810000);
                    break;

                case "Leaf pile":
                    getvalue.Add(0x00900000);
                    break;

                case "Hookshot aim":
                    getvalue.Add(0x00940000);
                    break;

                case "Ganon's bed":
                    getvalue.Add(0x00920000);
                    break;

                case "Figurine Gallery valve":
                    getvalue.Add(0x0095FF00);
                    break;

                case "Beta invisible water":
                    getvalue.Add(0x008EFF00);
                    break;

                case "Beta water":
                    getvalue.Add(0x008F0000);
                    break;

                case "Bent palm tree":
                    getvalue.Add(0x0085FF00);
                    break;

                case "Earth Temple Face":
                    getvalue.Add(0x0084FF00);
                    break;

                case "Darknut statue":
                    getvalue.Add(0x018C0000);
                    break;

                case "Ganondorf's ship wreck":
                    getvalue.Add(0x007DFF00);
                    break;

                case "Ship wreck":
                    getvalue.Add(0x007FFF00);
                    break;

                case "Hyrule portal":
                    getvalue.Add(0x006BFF00);
                    break;

                case "Water source":
                    getvalue.Add(0x0097FF00);
                    break;

                case "Tower of Gods pillar":
                    getvalue.Add(0x00960000);
                    break;

                case "Skull Hammer stump":
                    getvalue.Add(0x0099FF00);
                    break;

                case "Gohma":
                    getvalue.Add(0x00EAFF00);
                    break;

                case "Figurine socket":
                    getvalue.Add(0x0194FF00);
                    break;

                case "Merchant's hat":
                    getvalue.Add(0x0195FF00);
                    break;

                case "Ganondorf":
                    getvalue.Add(0x00F8FF00);
                    break;

                case "Miniblin":
                    getvalue.Add(0x00F7FF00);
                    break;

                case "White flower":
                    getvalue.Add(0x01CEFF00);
                    break;

                case "Grabbling Hook rope":
                    getvalue.Add(0x01BEFF00);
                    break;

                case "Boomerang":
                    getvalue.Add(0x01B0FF00);
                    break;

                case "Bomb":
                    getvalue.Add(0x0126FF00);
                    break;

                case "Arrow":
                    getvalue.Add(0x01D8FF00);
                    break;

                case "Sail":
                    getvalue.Add(0x00ABFF00);
                    break;

                case "Wood Box with pillar":
                    getvalue.Add(0x010CFF00);
                    break;

                case "Enemy sphere":
                    getvalue.Add(0x018FFF00);
                    break;

                default:
                    getvalue.Add(0x0043FF35); //default is Postbox
                        break;
            }

            return getvalue.ToArray();
        }
    }
}
