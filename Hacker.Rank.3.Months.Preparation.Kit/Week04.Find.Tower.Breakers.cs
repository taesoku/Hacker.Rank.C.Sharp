using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank._3.Months.Preparation.Kit
{
    class Week04FindTowerBreakers
    {

        public static void Answer()
        {
            var inputs1 = new Dictionary<int, int>();
            inputs1[100000] = 1;
            inputs1[100001] = 1;
            inputs1[374625] = 796723;
            inputs1[950929] = 183477;
            inputs1[732159] = 779867;
            inputs1[598794] = 596985;
            inputs1[156054] = 445934;
            inputs1[156030] = 99998;
            inputs1[58097] = 459353;
            inputs1[866372] = 333784;
            inputs1[601251] = 142899;
            inputs1[708233] = 651036;
            inputs1[20590] = 56425;
            inputs1[970129] = 722162;
            inputs1[832631] = 938765;
            inputs1[212387] = 779;
            inputs1[181866] = 992436;
            inputs1[183446] = 617621;
            inputs1[304311] = 611791;
            inputs1[524875] = 7068;
            inputs1[432043] = 23068;
            inputs1[291295] = 524893;
            inputs1[611991] = 399952;
            inputs1[139526] = 46677;
            inputs1[292211] = 973975;
            inputs1[366445] = 232824;
            inputs1[456173] = 90627;
            inputs1[785353] = 618526;
            inputs1[199719] = 382549;
            inputs1[514351] = 983453;
            inputs1[592549] = 466869;
            inputs1[46461] = 860135;
            inputs1[607682] = 680461;
            inputs1[170563] = 450601;
            inputs1[65067] = 13268;
            inputs1[949100] = 942415;
            inputs1[965850] = 563416;
            inputs1[808580] = 385504;
            inputs1[304683] = 15970;
            inputs1[97695] = 230946;
            inputs1[684388] = 241080;
            inputs1[440252] = 683418;
            inputs1[122066] = 610135;
            inputs1[495289] = 833383;
            inputs1[34397] = 173404;
            inputs1[909526] = 391149;
            inputs1[258839] = 182278;
            inputs1[662672] = 755532;
            inputs1[311782] = 425252;
            inputs1[520186] = 207989;
            inputs1[546834] = 567829;
            inputs1[184897] = 31321;
            inputs1[969804] = 842475;
            inputs1[775308] = 449856;
            inputs1[939711] = 395240;
            inputs1[895029] = 926868;
            inputs1[598035] = 727436;
            inputs1[922082] = 326615;
            inputs1[88513] = 570573;
            inputs1[196028] = 520952;
            inputs1[45238] = 961389;
            inputs1[325404] = 844725;
            inputs1[388765] = 747489;
            inputs1[271411] = 539814;
            inputs1[828925] = 586884;
            inputs1[356834] = 965473;
            inputs1[280998] = 607171;
            inputs1[542819] = 276062;
            inputs1[140956] = 296341;
            inputs1[802378] = 165305;
            inputs1[74568] = 15640;
            inputs1[987110] = 423497;
            inputs1[772419] = 394971;
            inputs1[198761] = 293555;
            inputs1[5524] = 14083;
            inputs1[815646] = 198888;
            inputs1[707017] = 711503;
            inputs1[729172] = 790354;
            inputs1[771445] = 606097;
            inputs1[74062] = 926510;
            inputs1[358547] = 651224;
            inputs1[115896] = 915166;
            inputs1[863298] = 850231;
            inputs1[623439] = 449552;
            inputs1[330973] = 95432;
            inputs1[63573] = 370902;
            inputs1[311053] = 668992;
            inputs1[325257] = 666073;
            inputs1[729771] = 591431;
            inputs1[637702] = 274784;
            var outputs = new List<int>();
            foreach (var i in inputs1)
                outputs.Add(FindTowerBreakers(i.Key, i.Value));
        }
        
        private static int FindTowerBreakers(int n, int m)
        {
            return (m == 1 || n%2 == 0) ? 2 : 1;
        }
    }
}
