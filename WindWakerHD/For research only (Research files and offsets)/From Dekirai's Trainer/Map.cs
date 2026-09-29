using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindWakerHD_Rewrite
{
    public class Map
    {
        public static async Task<uint[]> SetMap(string Mapname)
        {
            List<uint> getmap = new List<uint>();

            switch (Mapname)
            {
                case "A_mori":
                    getmap.Add(0x415F6D6F);
                    getmap.Add(0x72690000);
                    break;
                case "A_nami":
                    getmap.Add(0x415F6E61);
                    getmap.Add(0x6D690000);
                    break;
                case "A_umikz":
                    getmap.Add(0x415F756D);
                    getmap.Add(0x696B7A00);
                    break;
                case "Abesso":
                    getmap.Add(0x41626573);
                    getmap.Add(0x736F0000);
                    break;
                case "Abship":
                    getmap.Add(0x41627368);
                    getmap.Add(0x69700000);
                    break;
                case "Adanmae":
                    getmap.Add(0x4164616E);
                    getmap.Add(0x6D616500);
                    break;
                case "ADMumi":
                    getmap.Add(0x41444d75);
                    getmap.Add(0x6d690000);
                    break;
                case "Asoko":
                    getmap.Add(0x41736f6b);
                    getmap.Add(0x6f000000);
                    break;
                case "Atorizk":
                    getmap.Add(0x41746f72);
                    getmap.Add(0x697a6b00);
                    break;
                case "Cave01":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30310000);
                    break;
                case "Cave02":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30320000);
                    break;
                case "Cave03":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30330000);
                    break;
                case "Cave04":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30340000);
                    break;
                case "Cave05":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30350000);
                    break;
                case "Cave06":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30360000);
                    break;
                case "Cave07":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30370000);
                    break;
                case "Cave08":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30380000);
                    break;
                case "Cave09":
                    getmap.Add(0x43617665);
                    getmap.Add(0x30390000);
                    break;
                case "Cave10":
                    getmap.Add(0x43617665);
                    getmap.Add(0x31300000);
                    break;
                case "Cave11":
                    getmap.Add(0x43617665);
                    getmap.Add(0x31310000);
                    break;
                case "Comori":
                    getmap.Add(0x436F6D6F);
                    getmap.Add(0x72690000);
                    break;
                case "DmSpot0":
                    getmap.Add(0x446D5370);
                    getmap.Add(0x6F743000);
                    break;
                case "E3ROOP": //Blackscreen but no crash
                    getmap.Add(0x4533524F);
                    getmap.Add(0x4F500000);
                    break;
                case "Ebesso":
                    getmap.Add(0x45626573);
                    getmap.Add(0x736F0000);
                    break;
                case "Edaichi":
                    getmap.Add(0x45646169);
                    getmap.Add(0x63686900);
                    break;
                case "Ekaze":
                    getmap.Add(0x456b617a);
                    getmap.Add(0x65000000);
                    break;
                case "Fairy01":
                    getmap.Add(0x46616972);
                    getmap.Add(0x79303100);
                    break;
                case "Fairy02":
                    getmap.Add(0x46616972);
                    getmap.Add(0x79303200);
                    break;
                case "Fairy03":
                    getmap.Add(0x46616972);
                    getmap.Add(0x79303300);
                    break;
                case "Fairy04":
                    getmap.Add(0x46616972);
                    getmap.Add(0x79303400);
                    break;
                case "Fairy05":
                    getmap.Add(0x46616972);
                    getmap.Add(0x79303500);
                    break;
                case "Fairy06":
                    getmap.Add(0x46616972);
                    getmap.Add(0x79303600);
                    break;
                case "figureA":
                    getmap.Add(0x66696775);
                    getmap.Add(0x72654100);
                    break;
                case "figureB":
                    getmap.Add(0x66696775);
                    getmap.Add(0x72654200);
                    break;
                case "figureC":
                    getmap.Add(0x66696775);
                    getmap.Add(0x72654300);
                    break;
                case "figureD":
                    getmap.Add(0x66696775);
                    getmap.Add(0x72654400);
                    break;
                case "figureE":
                    getmap.Add(0x66696775);
                    getmap.Add(0x72654500);
                    break;
                case "figureF":
                    getmap.Add(0x66696775);
                    getmap.Add(0x72654600);
                    break;
                case "figureG":
                    getmap.Add(0x66696775);
                    getmap.Add(0x72654700);
                    break;
                case "GanonA":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e410000);
                    break;
                case "GanonB":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e420000);
                    break;
                case "GanonC":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e430000);
                    break;
                case "GanonD":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e440000);
                    break;
                case "GanonE":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e450000);
                    break;
                case "GanonJ":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e4A0000);
                    break;
                case "GanonL":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e4C0000);
                    break;
                case "GanonM":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e4D0000);
                    break;
                case "GanonN":
                    getmap.Add(0x47616e6f);
                    getmap.Add(0x6e4E0000);
                    break;
                case "Hyroom":
                    getmap.Add(0x4879726f);
                    getmap.Add(0x6f6d0000);
                    break;
                case "Hyrule":
                    getmap.Add(0x48797275);
                    getmap.Add(0x6c650000);
                    break;
                case "I_SubAN": //Console crash
                    getmap.Add(0x495F5375);
                    getmap.Add(0x62414E00);
                    break;
                case "ITest61":
                    getmap.Add(0x49546573);
                    getmap.Add(0x74363100);
                    break;
                case "ITest62":
                    getmap.Add(0x49546573);
                    getmap.Add(0x74363200);
                    break;
                case "ITest63":
                    getmap.Add(0x49546573);
                    getmap.Add(0x74363300);
                    break;
                case "Kaisen":
                    getmap.Add(0x4b616973);
                    getmap.Add(0x656e0000);
                    break;
                case "kazan":
                    getmap.Add(0x6B617A61);
                    getmap.Add(0x6E000000);
                    break;
                case "kaze":
                    getmap.Add(0x6b617a65);
                    getmap.Add(0x00000000);
                    break;
                case "kazeB":
                    getmap.Add(0x6b617a65);
                    getmap.Add(0x42000000);
                    break;
                case "kenroom":
                    getmap.Add(0x6b656e72);
                    getmap.Add(0x6f6f6d00);
                    break;
                case "kinBOSS":
                    getmap.Add(0x6b696e42);
                    getmap.Add(0x4f535300);
                    break;
                case "kindan":
                    getmap.Add(0x6b696e64);
                    getmap.Add(0x616e0000);
                    break;
                case "kinMB":
                    getmap.Add(0x6b696e4d);
                    getmap.Add(0x42000000);
                    break;
                case "LinkRM":
                    getmap.Add(0x4c696e6b);
                    getmap.Add(0x524d0000);
                    break;
                case "LinkUG":
                    getmap.Add(0x4c696e6b);
                    getmap.Add(0x55470000);
                    break;
                case "M_Dai":
                    getmap.Add(0x4d5f4461);
                    getmap.Add(0x69000000);
                    break;
                case "M_DaiB":
                    getmap.Add(0x4d5f4461);
                    getmap.Add(0x69420000);
                    break;
                case "M_Dra09":
                    getmap.Add(0x4d5f4472);
                    getmap.Add(0x61303900);
                    break;
                case "M_DragB":
                    getmap.Add(0x4d5f4472);
                    getmap.Add(0x61674200);
                    break;
                case "M_NewD2":
                    getmap.Add(0x4d5f4e65);
                    getmap.Add(0x77443200);
                    break;
                case "M2ganon":
                    getmap.Add(0x4d326761);
                    getmap.Add(0x6e6f6e00);
                    break;
                case "ma2room":
                    getmap.Add(0x6d613272);
                    getmap.Add(0x6f6f6d00);
                    break;
                case "ma3room":
                    getmap.Add(0x6d613052);
                    getmap.Add(0x6f6f6d00);
                    break;
                case "majroom":
                    getmap.Add(0x6d616a72);
                    getmap.Add(0x6f6f6d00);
                    break;
                case "MajyuE":
                    getmap.Add(0x4d616a79);
                    getmap.Add(0x75450000);
                    break;
                case "MiniHyo":
                    getmap.Add(0x4d696e69);
                    getmap.Add(0x48796f00);
                    break;
                case "MiniKaz":
                    getmap.Add(0x4d696e69);
                    getmap.Add(0x4b617a00);
                    break;
                case "Mjtower":
                    getmap.Add(0x4d6a746f);
                    getmap.Add(0x77657200);
                    break;
                case "Msmoke":
                    getmap.Add(0x4d736d6f);
                    getmap.Add(0x6b650000);
                    break;
                case "Mukao":
                    getmap.Add(0x4D756B61);
                    getmap.Add(0x6F000000);
                    break;
                case "Name":
                    getmap.Add(0x4E616D65);
                    getmap.Add(0x00000000);
                    break;
                case "Nitiyou":
                    getmap.Add(0x4e697469);
                    getmap.Add(0x796f7500);
                    break;
                case "Obombh":
                    getmap.Add(0x4f626f6d);
                    getmap.Add(0x62680000);
                    break;
                case "Obshop":
                    getmap.Add(0x4f627368);
                    getmap.Add(0x6f700000);
                    break;
                case "Ocean":
                    getmap.Add(0x4f636561);
                    getmap.Add(0x6e000000);
                    break;
                case "Ocmera":
                    getmap.Add(0x4f636d65);
                    getmap.Add(0x72610000);
                    break;
                case "Ocrogh":
                    getmap.Add(0x4f63726f);
                    getmap.Add(0x67680000);
                    break;
                case "Ojhous":
                    getmap.Add(0x4f6a686f);
                    getmap.Add(0x75730000);
                    break;
                case "Ojhous2":
                    getmap.Add(0x4f6a686f);
                    getmap.Add(0x75733200);
                    break;
                case "Omasao":
                    getmap.Add(0x4f6d6173);
                    getmap.Add(0x616f0000);
                    break;
                case "Omori":
                    getmap.Add(0x4f6d6f72);
                    getmap.Add(0x69000000);
                    break;
                case "Onobuta":
                    getmap.Add(0x4f6e6f62);
                    getmap.Add(0x75746100);
                    break;
                case "Opub":
                    getmap.Add(0x4f707562);
                    getmap.Add(0x00000000);
                    break;
                case "Orichh":
                    getmap.Add(0x4f726963);
                    getmap.Add(0x68680000);
                    break;
                case "Otkura":
                    getmap.Add(0x4F746B75);
                    getmap.Add(0x72610000);
                    break;
                case "Pdrgsh":
                    getmap.Add(0x50647267);
                    getmap.Add(0x73680000);
                    break;
                case "Pfigure":
                    getmap.Add(0x50666967);
                    getmap.Add(0x75726500);
                    break;
                case "Pjavdou":
                    getmap.Add(0x506a6176);
                    getmap.Add(0x646f7500);
                    break;
                case "Pnezumi":
                    getmap.Add(0x506e657a);
                    getmap.Add(0x756d6900);
                    break;
                case "PShip":
                    getmap.Add(0x50536869);
                    getmap.Add(0x70000000);
                    break;
                case "PShip2":
                    getmap.Add(0x50536869);
                    getmap.Add(0x70320000);
                    break;
                case "PShip3":
                    getmap.Add(0x50536869);
                    getmap.Add(0x70330000);
                    break;
                case "sea":
                    getmap.Add(0x73656100);
                    getmap.Add(0x00000000);
                    break;
                case "sea_E":
                    getmap.Add(0x7365615F);
                    getmap.Add(0x45000000);
                    break;
                case "sea_T":
                    getmap.Add(0x7365615F);
                    getmap.Add(0x54000000);
                    break;
                case "ShipD":
                    getmap.Add(0x53686970);
                    getmap.Add(0x44000000);
                    break;
                case "Siren":
                    getmap.Add(0x53697265);
                    getmap.Add(0x6E000000);
                    break;
                case "SirenB":
                    getmap.Add(0x53697265);
                    getmap.Add(0x6E420000);
                    break;
                case "SirenMB":
                    getmap.Add(0x53697265);
                    getmap.Add(0x6E4D4200);
                    break;
                case "SubD42":
                    getmap.Add(0x53756244);
                    getmap.Add(0x34320000);
                    break;
                case "SubD43":
                    getmap.Add(0x53756244);
                    getmap.Add(0x34330000);
                    break;
                case "SubD44":
                    getmap.Add(0x53756244);
                    getmap.Add(0x34340000);
                    break;
                case "SubD51":
                    getmap.Add(0x53756244);
                    getmap.Add(0x35310000);
                    break;
                case "SubD71":
                    getmap.Add(0x53756244);
                    getmap.Add(0x37310000);
                    break;
                case "tincle":
                    getmap.Add(0x74696E63);
                    getmap.Add(0x6C650000);
                    break;
                case "TF_01":
                    getmap.Add(0x54465F30);
                    getmap.Add(0x31000000);
                    break;
                case "TF_02":
                    getmap.Add(0x54465F30);
                    getmap.Add(0x32000000);
                    break;
                case "TF_03":
                    getmap.Add(0x54465F30);
                    getmap.Add(0x33000000);
                    break;
                case "TF_04":
                    getmap.Add(0x54465F30);
                    getmap.Add(0x34000000);
                    break;
                case "TF_06":
                    getmap.Add(0x54465F30);
                    getmap.Add(0x36000000);
                    break;
                case "TyuTyu":
                    getmap.Add(0x54797554);
                    getmap.Add(0x79750000);
                    break;
                case "WarpD":
                    getmap.Add(0x57617270);
                    getmap.Add(0x44000000);
                    break;
                default: //default is 'sea'
                    getmap.Add(0x73656100);
                    getmap.Add(0x00000000);
                    break;
            }
            return getmap.ToArray();
        }

        public static async Task<string> GetRealName(string name)
        {
            string mapName;

            switch (name)
            {
                case "sea":
                    mapName = "Great Sea";
                    break;
                case "sea_E":
                    mapName = "Credits";
                    break;
                case "sea_T":
                    mapName = "Title screen";
                    break;
                case "Name":
                    mapName = "File select";
                    break;
                case "Ocean":
                    mapName = "Boating Course";
                    break;
                case "Abship":
                    mapName = "Submarine Interior";
                    break;
                case "ma2room":
                    mapName = "Forsaken Fortress - Interior I";
                    break;
                case "ma3room":
                    mapName = "Forsaken Fortress - Interior II";
                    break;
                case "majroom":
                    mapName = "Forsaken Fortress - Interior III";
                    break;
                case "MajyuE":
                    mapName = "Forsaken Fortress - Exterior";
                    break;
                case "Mjtower":
                    mapName = "Forsaken Fortress - Helmaroc's Room";
                    break;
                case "M2tower":
                    mapName = "Forsaken Fortress - Helmaroc's Room";
                    break;
                case "M2ganon":
                    mapName = "Forsaken Fortress - Ganondorf's lair";
                    break;
                case "LinkRM":
                    mapName = "Outset Island - Link's House";
                    break;
                case "LinkUG":
                    mapName = "Outset Island - Basement";
                    break;
                case "Siren":
                    mapName = "Tower of Gods";
                    break;
                case "SirenMB":
                    mapName = "Tower of Gods - Miniboss Room";
                    break;
                case "SirenB":
                    mapName = "Tower of Gods - Boss Room";
                    break;
                case "Obshop":
                    mapName = "Beedle's Shop Ship";
                    break;
                case "Ojhous":
                    mapName = "Outset Island - Orca's House";
                    break;
                case "Ojhous2":
                    mapName = "Outset Island - Sturgeon's House";
                    break;
                case "Omasao":
                    mapName = "Outset Island - Mesa's House";
                    break;
                case "Onobuta":
                    mapName = "Outset Island - Abe'S House";
                    break;
                case "A_mori":
                    mapName = "Outset Island - Forest";
                    break;
                case "A_umikz":
                    mapName = "Pirate Ship - Deck";
                    break;
                case "Asoko":
                    mapName = "Pirate Ship - Interior";
                    break;
                case "Pnezumi":
                    mapName = "Windfall Island - Prison";
                    break;
                case "Pdrgsh":
                    mapName = "Windfall Island - Potion Shop";
                    break;
                case "Obombh":
                    mapName = "Windfall Island - Bomb Shop";
                    break;
                case "Orichh":
                    mapName = "Windfall Island - Auction House";
                    break;
                case "Opub":
                case "Opubh":
                    mapName = "Windfall Island - Cafe Bar";
                    break;
                case "Ocmera":
                    mapName = "Windfall Island - Lenzo's Studio";
                    break;
                case "Nitiyou":
                    mapName = "Windfall Island - School of Joy";
                    break;
                case "Kaisen":
                    mapName = "Windfall Island - Minigame House";
                    break;
                case "Atorizk":
                    mapName = "Dragon Roost Island - Mail Center";
                    break;
                case "Adanmae":
                    mapName = "Dragon Roost Island - Spring";
                    break;
                case "Comori":
                    mapName = "Dragon Roost Island - Komali's Room";
                    break;
                case "M_NewD2":
                    mapName = "Dragon Roost Cavern";
                    break;
                case "M_Dra09":
                    mapName = "Dragon Roost Cavern - Outside";
                    break;
                case "M_DragB":
                    mapName = "Dragon Roost Cavern - Boss Room";
                    break;
                case "Omori":
                    mapName = "Forest Haven - Interior";
                    break;
                case "Ocrogh":
                    mapName = "Forest Haven - Bomb Shop";
                    break;
                case "Otkura":
                    mapName = "Forest Haven - Behind waterfall";
                    break;
                case "Edaichi":
                    mapName = "Earth Temple - Entrance";
                    break;
                case "M_Dai":
                    mapName = "Earth Temple";
                    break;
                case "M_DaiMB":
                    mapName = "Earth Temple - Miniboss Room";
                    break;
                case "M_DaiB":
                    mapName = "Earth Temple - Boss Room";
                    break;
                case "Ekaze":
                    mapName = "Wind Temple - Entrance";
                    break;
                case "kaze":
                    mapName = "Wind Temple";
                    break;
                case "kazeMB":
                    mapName = "Wind Temple - Miniboss Room";
                    break;
                case "kazeB":
                    mapName = "Wind Temple - Boss Room";
                    break;
                case "kindan":
                    mapName = "Forbidden Woods";
                    break;
                case "kinMB":
                    mapName = "Forbidden Woods - Miniboss Room";
                    break;
                case "kinBOSS":
                    mapName = "Forbidden Woods - Boss Room";
                    break;
                case "Pjavdou":
                    mapName = "Outset Island - Jabun's Cavern";
                    break;
                case "Hyrule":
                    mapName = "Hyrule Castle - Exterior";
                    break;
                case "Hyroom":
                    mapName = "Hyrule Castle - Interior";
                    break;
                case "kenroom":
                    mapName = "Hyrule Castle - Basement";
                    break;
                case "ADMumi":
                    mapName = "Tower of Gods - Cutscene";
                    break;
                case "MiniKaz":
                    mapName = "Inside Fire Mountain";
                    break;
                case "MiniHyo":
                    mapName = "Inside Ice Ring Isle";
                    break;
                case "ITest62":
                    mapName = "Inside Ice Ring Isle - Grotto";
                    break;
                case "ITest63":
                    mapName = "Shark Island - Cave";
                    break;
                case "Cave01":
                    mapName = "Bomb Island - Cave";
                    break;
                case "Cave02":
                    mapName = "Star Island - Cave";
                    break;
                case "Cave03":
                    mapName = "Cliff Plateau Isles - Cave";
                    break;
                case "Cave04":
                    mapName = "Rock Spire Isle - Cave";
                    break;
                case "Cave05":
                    mapName = "Horsehoe Island - Cave";
                    break;
                case "Cave07":
                    mapName = "Pawprint Isle - Cave";
                    break;
                case "Cave09":
                    mapName = "Savage Labyrinth";
                    break;
                case "Cave10":
                    mapName = "Savage Labyrinth";
                    break;
                case "Cave11":
                    mapName = "Savage Labyrinth";
                    break;
                case "ShipD":
                    mapName = "Islet of Steel - Interior";
                    break;
                case "SubD42":
                    mapName = "Needle Rock Isle - Cave";
                    break;
                case "SubD43":
                    mapName = "Angular Isles - Cave";
                    break;
                case "SubD44":
                    mapName = "Stonewatcher Island - Cave";
                    break;
                case "SubD71":
                    mapName = "Bomb Island - Early Cave";
                    break;
                case "TF_01":
                    mapName = "Stonewatcher Island - Triforce Cave";
                    break;
                case "TF_02":
                    mapName = "Overlook Island - Triforce Cave";
                    break;
                case "TF_03":
                    mapName = "Bird's Peak Rock - Triforce Cave";
                    break;
                case "TF_04":
                    mapName = "Link's Oasis - Triforce Cave";
                    break;
                case "TF_06":
                    mapName = "Dragon Roost Island - Cave";
                    break;
                case "TyuTyu":
                    mapName = "Pawprint Isle - Cave";
                    break;
                case "Abesso":
                    mapName = "Link's Oasis";
                    break;
                case "Fairy01":
                    mapName = "Northern Fairy Island - Fairy";
                    break;
                case "Fairy02":
                    mapName = "Eastern Fairy Island - Fairy";
                    break;
                case "Fairy03":
                    mapName = "Western Fairy Island - Fairy";
                    break;
                case "Fairy04":
                    mapName = "Outset Island Forest - Fairy";
                    break;
                case "Fairy05":
                    mapName = "Thorned Fairy Island - Fairy";
                    break;
                case "Fairy06":
                    mapName = "Southern Fairy Island - Fairy";
                    break;
                case "WarpD":
                    mapName = "Diamond Steppe Island - Cave";
                    break;
                case "PShip":
                    mapName = "Ghost Ship";
                    break;
                case "GanonA":
                    mapName = "Ganon's Tower - Entrance";
                    break;
                case "GanonB":
                    mapName = "Ganon's Tower - DRC Trial";
                    break;
                case "GanonC":
                    mapName = "Ganon's Tower - WT Trial";
                    break;
                case "GanonD":
                    mapName = "Ganon's Tower - FW Trial";
                    break;
                case "GanonE":
                    mapName = "Ganon's Tower - ET Trial";
                    break;
                case "GanonN":
                    mapName = "Ganon's Tower - Staircase to Center";
                    break;
                case "GanonM":
                    mapName = "Ganon's Tower - Center";
                    break;
                case "GanonJ":
                    mapName = "Ganon's Tower - Maze";
                    break;
                case "GanonL":
                    mapName = "Ganon's Tower - Staircase to Ganon";
                    break;
                case "GanonK":
                    mapName = "Ganon's Tower - Ganon's Room";
                    break;
                case "GTower":
                    mapName = "Ganon's Tower - Final Fight";
                    break;
                case "Xboss0":
                    mapName = "Ganon's Tower - DRC Trial Boss";
                    break;
                case "Xboss1":
                    mapName = "Ganon's Tower - FW Trial Boss";
                    break;
                case "Xboss2":
                    mapName = "Ganon's Tower - ET Trial Boss";
                    break;
                case "Xboss3":
                    mapName = "Ganon's Tower - WT Trial Boss";
                    break;
                case "ENDumi":
                    mapName = "End Game Cutscene";
                    break;
                case "Pfigure":
                    mapName = "Nintendo Gallery";
                    break;
                case "figureA":
                    mapName = "Gallery - Great Sea Figurines";
                    break;
                case "figureB":
                    mapName = "Gallery - Windfall Island Figurines";
                    break;
                case "figureC":
                    mapName = "Gallery - Outset Island Figurines";
                    break;
                case "figureD":
                    mapName = "Gallery - Boss Figurines";
                    break;
                case "figureE":
                    mapName = "Gallery - Enemy Figurines";
                    break;
                case "figureF":
                    mapName = "Gallery - DRC Figurines";
                    break;
                case "figureG":
                    mapName = "Gallery - Forest Haven Figurines";
                    break;
                ////////UNUSED\\\\\\\\
                case "Cave06":
                    mapName = "Outset Island - Unused Cave";
                    break;
                case "DmSpot0":
                    mapName = "Outset Island - Test";
                    break;
                case "A_nami":
                    mapName = "Invisible Island";
                    break;
                case "ITest61":
                    mapName = "Bomb Island - Cave Test";
                    break;
                case "Ebesso":
                    mapName = "Unused Island";
                    break;
                case "kazan":
                    mapName = "Unused Fire Mountain";
                    break;
                case "Mukao":
                    mapName = "Unused Temple Island";
                    break;
                case "Cave08":
                    mapName = "Unused Room (Room + Spawn: 3)";
                    break;
                case "Msmoke":
                    mapName = "Msmoke - Test Room";
                    break;
                case "PShip2":
                    mapName = "Submarine - Unused Room";
                    break;
                case "PShip3":
                    mapName = "Submarine - Unused Room 2";
                    break;
                case "SubD51":
                    mapName = "Bomb Island - Early Cave";
                    break;
                case "tincle":
                    mapName = "Tingle's Paint Room";
                    break;
                //////UNUSED END\\\\\\
                default:
                    mapName = "Stage not defined";
                    break;
            }

            return mapName;
        }

        public static async Task<string[]> GetRoomName(string Roomid)
        {
            List<string> getroom = new List<string>();

            switch (Roomid)
            {
                case "0":
                    getroom.Add("Great Sea"); //sea
                    break;

                case "1":
                    getroom.Add("Forsaken Fortress"); //sea
                    break;

                case "2":
                    getroom.Add("Star Island"); //sea
                    break;

                case "3":
                    getroom.Add("Northern Fairy Island"); //sea
                    break;

                case "4":
                    getroom.Add("Gale Isle"); //sea
                    break;

                case "5":
                    getroom.Add("Crescent Moon Island"); //sea
                    break;

                case "6":
                    getroom.Add("Seven-Star Isles"); //sea
                    break;

                case "7":
                    getroom.Add("Overlook Island"); //sea
                    break;

                case "8":
                    getroom.Add("Four-Eye Reef"); //sea
                    break;

                case "9":
                    getroom.Add("Mother and Child Isles"); //sea
                    break;

                case "10":
                    getroom.Add("Spectacle Island"); //sea
                    break;

                case "11":
                    getroom.Add("Windfall Island"); //sea
                    break;

                case "12":
                    getroom.Add("Pawprint Isle"); //sea
                    break;

                case "13":
                    getroom.Add("Dragon Roost Island"); //sea
                    break;

                case "14":
                    getroom.Add("Flight Control Platform"); //sea
                    break;

                case "15":
                    getroom.Add("Western Fairy Island"); //sea
                    break;

                case "16":
                    getroom.Add("Rock Spire Isle"); //sea
                    break;

                case "17":
                    getroom.Add("Tingle Island"); //sea
                    break;

                case "18":
                    getroom.Add("North Triangle Isle"); //sea
                    break;

                case "19":
                    getroom.Add("Eastern Fairy Isle"); //sea
                    break;

                case "20":
                    getroom.Add("Fire Mountain"); //sea
                    break;

                case "21":
                    getroom.Add("Star Belt Archipelago"); //sea
                    break;

                case "22":
                    getroom.Add("Three-Eye Isle"); //sea
                    break;

                case "23":
                    getroom.Add("Greatfish Isle"); //sea
                    break;

                case "24":
                    getroom.Add("Cyclops Reef"); //sea
                    break;

                case "25":
                    getroom.Add("Six-Eye Reef"); //sea
                    break;

                case "26":
                    getroom.Add("Tower of Gods"); //sea
                    break;

                case "27":
                    getroom.Add("East Triangle Isle"); //sea
                    break;

                case "28":
                    getroom.Add("Thorned Faily Island"); //sea
                    break;

                case "29":
                    getroom.Add("Needle Rock Isle"); //sea
                    break;

                case "30":
                    getroom.Add("Islet of Steel"); //sea
                    break;

                case "31":
                    getroom.Add("Stonewatcher Island"); //sea
                    break;

                case "32":
                    getroom.Add("South Triangle Isle"); //sea
                    break;

                case "33":
                    getroom.Add("Link's Oasis"); //sea
                    break;

                case "34":
                    getroom.Add("Bomb Island"); //sea
                    break;

                case "35":
                    getroom.Add("Bird's Peak Rock"); //sea
                    break;

                case "36":
                    getroom.Add("Diamond Steppe Island"); //sea
                    break;

                case "37":
                    getroom.Add("Five-Eye Reef"); //sea
                    break;

                case "38":
                    getroom.Add("Shark Island"); //sea
                    break;

                case "39":
                    getroom.Add("Southern Fairy Island"); //sea
                    break;

                case "40":
                    getroom.Add("Ice Ring Isle"); //sea
                    break;

                case "41":
                    getroom.Add("Forest Haven"); //sea
                    break;

                case "42":
                    getroom.Add("Cliff Plateu Isles"); //sea
                    break;

                case "43":
                    getroom.Add("Horsehoe Isle"); //sea
                    break;

                case "44":
                    getroom.Add("Outset Island"); //sea
                    break;

                case "45":
                    getroom.Add("Headstone Island"); //sea
                    break;

                case "46":
                    getroom.Add("Two-Eye Reef"); //sea
                    break;

                case "47":
                    getroom.Add("Angular Isles"); //sea
                    break;

                case "48":
                    getroom.Add("Boating Course"); //sea
                    break;

                case "49":
                    getroom.Add("Five-Star Isles"); //sea
                    break;

                default:
                    getroom.Add("Room not defined yet");
                    break;
            }
            return getroom.ToArray();
        }
    }
}