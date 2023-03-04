using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindWakerHD_Rewrite
{
    class Geckocodes
    {
        public enum Cheat
        {
            Health = 0,
            Magic = 1,
            Rupee = 2,
            Arrow = 3,
            Bomb = 4,
            Air = 5,
            InfItems = 6,
            ForestWater = 7,
            MoonJump = 8,
            SuperSwim = 9,
            SuperCrouch = 10,
            CompletedMap = 11,
            AllCharts = 12
        }

        private List<UInt32> infhealth = new List<UInt32>();
        private List<UInt32> moonjump = new List<UInt32>();
        private List<UInt32> infmagic = new List<UInt32>();
        private List<UInt32> infrupees = new List<UInt32>();
        private List<UInt32> infarrows = new List<UInt32>();
        private List<UInt32> infbombs = new List<UInt32>();
        private List<UInt32> infair = new List<UInt32>();
        private List<UInt32> infforestwater = new List<UInt32>();
        private List<UInt32> infitems = new List<UInt32>();
        private List<UInt32> superswim = new List<UInt32>();
        private List<UInt32> supercrouch = new List<UInt32>();
        private List<UInt32> completedmap = new List<UInt32>();
        private List<UInt32> alltreasurecharts = new List<UInt32>();

        public List<uint> GetInfHealth()
        {
            infhealth.Add(0x00000000); //8-Bit
            infhealth.Add(0x15073683); //Address
            infhealth.Add(0x00000050); //Value
            infhealth.Add(0x00000000);
            return infhealth;
        }

        public List<uint> GetMoonJump()
        {
            moonjump.Add(0x09020000); //32-Bit & CodeType: Conditional logical AND
            moonjump.Add(0x102F48A8); //Button activator address
            moonjump.Add(0x00000020); //L Button
            moonjump.Add(0x00000000);
            moonjump.Add(0x30000000);
            moonjump.Add(0x10976AB4);
            moonjump.Add(0x48700000);
            moonjump.Add(0x48800000);
            moonjump.Add(0x00120340);
            moonjump.Add(0x42100000);
            moonjump.Add(0xD0000000);
            moonjump.Add(0xDEADCAFE);
            return moonjump;
        }

        public List<uint> GetInfMagic()
        {
            infmagic.Add(0x00000000); //8-Bit
            infmagic.Add(0x15073694); //Address
            infmagic.Add(0x00000020); //Value
            infmagic.Add(0x00000000);
            return infmagic;
        }

        public List<uint> GetInfRupees()
        {
            infrupees.Add(0x00010000); //16-Bit
            infrupees.Add(0x15073684); //Address
            infrupees.Add(0x00001388); //Value
            infrupees.Add(0x00000000);
            return infrupees;
        }

        public List<uint> GetInfArrows()
        {
            infarrows.Add(0x00000000); //8-Bit
            infarrows.Add(0x150736E9); //Address
            infarrows.Add(0x00000063); //Value
            infarrows.Add(0x00000000);
            return infarrows;
        }

        public List<uint> GetInfBombs()
        {
            infbombs.Add(0x00000000); //8-Bit
            infbombs.Add(0x150736EA); //Address
            infbombs.Add(0x00000063); //Value
            infbombs.Add(0x00000000);
            return infbombs;
        }

        public List<uint> GetInfAir()
        {
            infair.Add(0x00020000); //32-Bit
            infair.Add(0x10976DFC); //Address
            infair.Add(0x00000384); //Value
            infair.Add(0x00000000);
            return infair;
        }

        public List<uint> GetInfForestWater()
        {
            infforestwater.Add(0x00020000); //32-Bit
            infforestwater.Add(0x150736E4); //Address
            infforestwater.Add(0x0104D2F0); //Value
            infforestwater.Add(0x00000000);
            return infforestwater;
        }

        public List<uint> GetInfItems()
        {
            infitems.Add(0x00020000); //32-Bit
            infitems.Add(0x1507371C); //Address
            infitems.Add(0x63636363); //Value
            infitems.Add(0x00000000);
            infitems.Add(0x00020000); //32-Bit
            infitems.Add(0x15073720); //Address
            infitems.Add(0x63636363); //Value
            infitems.Add(0x00000000);
            return infitems;
        }

        public List<uint> GetSuperswim()
        {
            superswim.Add(0x00020000); //32-Bit
            superswim.Add(0x10976DFC); //Address
            superswim.Add(0x00000DFF); //Value
            superswim.Add(0x00000000);
            return superswim;
        }

        public List<uint> GetSupercrouch()
        {
            supercrouch.Add(0x00020000); //32-Bit
            supercrouch.Add(0x10537550); //Address
            supercrouch.Add(0x41F00000); //Value
            supercrouch.Add(0x00000000);
            return supercrouch;
        }

        public List<uint> GetCompletedMap()
        {
            completedmap.Add(0x02000031); //8-Bit & Skip write
            completedmap.Add(0x15073784); //Address
            completedmap.Add(0x00000003); //Value
            completedmap.Add(0x00000001); //Skips on each write
            completedmap.Add(0x00000000);
            completedmap.Add(0x00000000);
            return completedmap;
        }

        public List<uint> GetAllTreasureCharts()
        {
            alltreasurecharts.Add(0x00020000); //8-Bit
            alltreasurecharts.Add(0x15073754); //Address
            alltreasurecharts.Add(0xFFFFFFFF); //Value
            alltreasurecharts.Add(0x00000000);
            alltreasurecharts.Add(0x00020000); //8-Bit
            alltreasurecharts.Add(0x15073758); //Address
            alltreasurecharts.Add(0xFFFFFFFF); //Value
            alltreasurecharts.Add(0x00000000);
            return alltreasurecharts;
        }

        //Buttons:
        //Left Stick Left: 40000000
        //Left Stick Right: 20000000
        //Left Stick Up: 10000000
        //Left Stick Down: 08000000
        //Right Stick left: 04000000
        //Right Stick right: 02000000
        //Right Stick up: 01000000
        //Right Stick down: 00800000
        //Left Stick press: 00040000
        //Right Stick press: 00020000
        //TV: 00010000
        //A: 00008000
        //B: 00004000
        //X: 00002000
        //Y: 00001000
        //dPad left: 00000800
        //dPad right: 00000400
        //dPad up: 00000200
        //dPad down: 00000100
        //ZL: 00000080
        //ZR: 00000040
        //L: 00000020
        //R: 00000010
        //Plus: 00000008
        //Minus: 00000004
        //Home: 00000002
    }
}
