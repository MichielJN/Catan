using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19, S20, S21, S22, S23, S24, S25, S26, S27, S28, S29, S30, S31, S32, S33, S34, S35, S36, S37, S38, S39, S40, S41, S42, S43, S44, S45, S46, S47, S48, S49, S50, S51, S52, S53, S54, S55, S56, S57, S58, S59, S60, S61, S62, S63, S64, S65, S66, S67, S68, S69, S70, S71, S72
//D1, D2, D3,D4,D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20 ,D21, D22, D23, D24, D25, D26, D27, D28, D29,D30, D31, D32, D33, D34, D35, D36, D37, D38, D39, D40, D41, D42, D43, D44, D45, D46, D47, D48, D49, D50, D51, D52, D53, D54
//Button d1, Button d2, Button d3, Button d4, Button d5, Button d6, Button d7, Button d8, Button d9, Button d10, Button d11, Button d12, Button d13, Button d14, Button d15, Button d16, Button d17, Button d18, Button d19, Button d20, Button d21, Button d22, Button d23, Button d24, Button d25, Button d26, Button d27, Button d28, Button d29, Button d30, Button d31, Button d32, Button d33, Button d34, Button d35, Button d36, Button d37, Button d38, Button d39, Button d40, Button d41, Button d42, Button d43, Button d44, Button d45, Button d46, Button d47, Button d48, Button d49, Button d50, Button d51, Button d52, Button d53, Button d54
//Button s1, Button s2, Button s3, Button s4, Button s5, Button s6, Button s7, Button s8, Button s9, Button s10, Button s11, Button s12, Button s13, Button s14, Button s15, Button s16, Button s17, Button s18, Button s19, Button s20, Button s21, Button s22, Button s23, Button s24, Button s25, Button s26, Button s27, Button s28, Button s29, Button s30, Button s31, Button s32, Button s33, Button s34, Button s35, Button s36, Button s37, Button s38, Button s39, Button s40, Button s41, Button s42, Button s43, Button s44, Button s45, Button s46, Button s47, Button s48, Button s49, Button s50, Button s51, Button s52, Button s53, Button s54, Button s55, Button s56, Button s57, Button s58, Button s59, Button s60, Button s61, Button s62, Button s63, Button s64, Button s65, Button s66, Button s67, Button s68, Button s69, Button s70, Button s71, Button s72
namespace Catan
{
    public class InterfaceButtons
    {
        public void DisableVillages(Button[] SettlementButtons)
        {
            SettlementButtons[0].Enabled = false;
            SettlementButtons[1].Enabled = false;
            SettlementButtons[2].Enabled = false;
            SettlementButtons[3].Enabled = false;
            SettlementButtons[4].Enabled = false;
            SettlementButtons[5].Enabled = false;
            SettlementButtons[6].Enabled = false;
            SettlementButtons[7].Enabled = false;
            SettlementButtons[8].Enabled = false;
            SettlementButtons[9].Enabled = false;
            SettlementButtons[10].Enabled = false;
            SettlementButtons[11].Enabled = false;
            SettlementButtons[12].Enabled = false;
            SettlementButtons[13].Enabled = false;
            SettlementButtons[14].Enabled = false;
            SettlementButtons[15].Enabled = false;
            SettlementButtons[16].Enabled = false;
            SettlementButtons[17].Enabled = false;
            SettlementButtons[18].Enabled = false;
            SettlementButtons[19].Enabled = false;
            SettlementButtons[20].Enabled = false;
            SettlementButtons[21].Enabled = false;
            SettlementButtons[22].Enabled = false;
            SettlementButtons[23].Enabled = false;
            SettlementButtons[24].Enabled = false;
            SettlementButtons[25].Enabled = false;
            SettlementButtons[26].Enabled = false;
            SettlementButtons[27].Enabled = false;
            SettlementButtons[28].Enabled = false;
            SettlementButtons[29].Enabled = false;
            SettlementButtons[30].Enabled = false;
            SettlementButtons[31].Enabled = false;
            SettlementButtons[32].Enabled = false;
            SettlementButtons[33].Enabled = false;
            SettlementButtons[34].Enabled = false;
            SettlementButtons[35].Enabled = false;
            SettlementButtons[36].Enabled = false;
            SettlementButtons[37].Enabled = false;
            SettlementButtons[38].Enabled = false;
            SettlementButtons[39].Enabled = false;
            SettlementButtons[40].Enabled = false;
            SettlementButtons[41].Enabled = false;
            SettlementButtons[42].Enabled = false;
            SettlementButtons[43].Enabled = false;
            SettlementButtons[44].Enabled = false;
            SettlementButtons[45].Enabled = false;
            SettlementButtons[46].Enabled = false;
            SettlementButtons[47].Enabled = false;
            SettlementButtons[48].Enabled = false;
            SettlementButtons[49].Enabled = false;
            SettlementButtons[50].Enabled = false;
            SettlementButtons[51].Enabled = false;
            SettlementButtons[52].Enabled = false;
            SettlementButtons[53].Enabled = false;
        }

        public void EnableVillages(Button[] SettlementButtons)
        {
            SettlementButtons[0].Enabled = true;
            SettlementButtons[1].Enabled = true;
            SettlementButtons[2].Enabled = true;
            SettlementButtons[3].Enabled = true;
            SettlementButtons[4].Enabled = true;
            SettlementButtons[5].Enabled = true;
            SettlementButtons[6].Enabled = true;
            SettlementButtons[7].Enabled = true;
            SettlementButtons[8].Enabled = true;
            SettlementButtons[9].Enabled = true;
            SettlementButtons[10].Enabled = true;
            SettlementButtons[11].Enabled = true;
            SettlementButtons[12].Enabled = true;
            SettlementButtons[13].Enabled = true;
            SettlementButtons[14].Enabled = true;
            SettlementButtons[15].Enabled = true;
            SettlementButtons[16].Enabled = true;
            SettlementButtons[17].Enabled = true;
            SettlementButtons[18].Enabled = true;
            SettlementButtons[19].Enabled = true;
            SettlementButtons[20].Enabled = true;
            SettlementButtons[21].Enabled = true;
            SettlementButtons[22].Enabled = true;
            SettlementButtons[23].Enabled = true;
            SettlementButtons[24].Enabled = true;
            SettlementButtons[25].Enabled = true;
            SettlementButtons[26].Enabled = true;
            SettlementButtons[27].Enabled = true;
            SettlementButtons[28].Enabled = true;
            SettlementButtons[29].Enabled = true;
            SettlementButtons[30].Enabled = true;
            SettlementButtons[31].Enabled = true;
            SettlementButtons[32].Enabled = true;
            SettlementButtons[33].Enabled = true;
            SettlementButtons[34].Enabled = true;
            SettlementButtons[35].Enabled = true;
            SettlementButtons[36].Enabled = true;
            SettlementButtons[37].Enabled = true;
            SettlementButtons[38].Enabled = true;
            SettlementButtons[39].Enabled = true;
            SettlementButtons[40].Enabled = true;
            SettlementButtons[41].Enabled = true;
            SettlementButtons[42].Enabled = true;
            SettlementButtons[43].Enabled = true;
            SettlementButtons[44].Enabled = true;
            SettlementButtons[45].Enabled = true;
            SettlementButtons[46].Enabled = true;
            SettlementButtons[47].Enabled = true;
            SettlementButtons[48].Enabled = true;
            SettlementButtons[49].Enabled = true;
            SettlementButtons[50].Enabled = true;
            SettlementButtons[51].Enabled = true;
            SettlementButtons[52].Enabled = true;
            SettlementButtons[53].Enabled = true;
        }

        public void DisableStreets(Button[] streetButtons)
        {
            streetButtons[0].Enabled = false;
            streetButtons[1].Enabled = false;
            streetButtons[2].Enabled = false;
            streetButtons[3].Enabled = false;
            streetButtons[4].Enabled = false;
            streetButtons[5].Enabled = false;
            streetButtons[6].Enabled = false;
            streetButtons[7].Enabled = false;
            streetButtons[8].Enabled = false;
            streetButtons[9].Enabled = false;
            streetButtons[10].Enabled = false;
            streetButtons[11].Enabled = false;
            streetButtons[12].Enabled = false;
            streetButtons[13].Enabled = false;
            streetButtons[14].Enabled = false;
            streetButtons[15].Enabled = false;
            streetButtons[16].Enabled = false;
            streetButtons[17].Enabled = false;
            streetButtons[18].Enabled = false;
            streetButtons[19].Enabled = false;
            streetButtons[20].Enabled = false;
            streetButtons[21].Enabled = false;
            streetButtons[22].Enabled = false;
            streetButtons[23].Enabled = false;
            streetButtons[24].Enabled = false;
            streetButtons[25].Enabled = false;
            streetButtons[26].Enabled = false;
            streetButtons[27].Enabled = false;
            streetButtons[28].Enabled = false;
            streetButtons[29].Enabled = false;
            streetButtons[30].Enabled = false;
            streetButtons[31].Enabled = false;
            streetButtons[32].Enabled = false;
            streetButtons[33].Enabled = false;
            streetButtons[34].Enabled = false;
            streetButtons[35].Enabled = false;
            streetButtons[36].Enabled = false;
            streetButtons[37].Enabled = false;
            streetButtons[38].Enabled = false;
            streetButtons[39].Enabled = false;
            streetButtons[40].Enabled = false;
            streetButtons[41].Enabled = false;
            streetButtons[42].Enabled = false;
            streetButtons[43].Enabled = false;
            streetButtons[44].Enabled = false;
            streetButtons[45].Enabled = false;
            streetButtons[46].Enabled = false;
            streetButtons[47].Enabled = false;
            streetButtons[48].Enabled = false;
            streetButtons[49].Enabled = false;
            streetButtons[50].Enabled = false;
            streetButtons[51].Enabled = false;
            streetButtons[51].Enabled = false;
            streetButtons[52].Enabled = false;
            streetButtons[53].Enabled = false;
            streetButtons[54].Enabled = false;
            streetButtons[55].Enabled = false;
            streetButtons[56].Enabled = false;
            streetButtons[57].Enabled = false;
            streetButtons[58].Enabled = false;
            streetButtons[59].Enabled = false;
            streetButtons[60].Enabled = false;
            streetButtons[61].Enabled = false;
            streetButtons[62].Enabled = false;
            streetButtons[63].Enabled = false;
            streetButtons[64].Enabled = false;
            streetButtons[65].Enabled = false;
            streetButtons[66].Enabled = false;
            streetButtons[67].Enabled = false;
            streetButtons[68].Enabled = false;
            streetButtons[69].Enabled = false;
            streetButtons[70].Enabled = false;
            streetButtons[71].Enabled = false;

        }

        public void EnableStreets(Button[] streetButtons)
        {
            streetButtons[0].Enabled = true;
            streetButtons[1].Enabled = true;
            streetButtons[2].Enabled = true;
            streetButtons[3].Enabled = true;
            streetButtons[4].Enabled = true;
            streetButtons[5].Enabled = true;
            streetButtons[6].Enabled = true;
            streetButtons[7].Enabled = true;
            streetButtons[8].Enabled = true;
            streetButtons[9].Enabled = true;
            streetButtons[10].Enabled = true;
            streetButtons[11].Enabled = true;
            streetButtons[12].Enabled = true;
            streetButtons[13].Enabled = true;
            streetButtons[14].Enabled = true;
            streetButtons[15].Enabled = true;
            streetButtons[16].Enabled = true;
            streetButtons[17].Enabled = true;
            streetButtons[18].Enabled = true;
            streetButtons[19].Enabled = true;
            streetButtons[20].Enabled = true;
            streetButtons[21].Enabled = true;
            streetButtons[22].Enabled = true;
            streetButtons[23].Enabled = true;
            streetButtons[24].Enabled = true;
            streetButtons[25].Enabled = true;
            streetButtons[26].Enabled = true;
            streetButtons[27].Enabled = true;
            streetButtons[28].Enabled = true;
            streetButtons[29].Enabled = true;
            streetButtons[30].Enabled = true;
            streetButtons[31].Enabled = true;
            streetButtons[32].Enabled = true;
            streetButtons[33].Enabled = true;
            streetButtons[34].Enabled = true;
            streetButtons[35].Enabled = true;
            streetButtons[36].Enabled = true;
            streetButtons[37].Enabled = true;
            streetButtons[38].Enabled = true;
            streetButtons[39].Enabled = true;
            streetButtons[40].Enabled = true;
            streetButtons[41].Enabled = true;
            streetButtons[42].Enabled = true;
            streetButtons[43].Enabled = true;
            streetButtons[44].Enabled = true;
            streetButtons[45].Enabled = true;
            streetButtons[46].Enabled = true;
            streetButtons[47].Enabled = true;
            streetButtons[48].Enabled = true;
            streetButtons[49].Enabled = true;
            streetButtons[50].Enabled = true;
            streetButtons[51].Enabled = true;
            streetButtons[51].Enabled = true;
            streetButtons[52].Enabled = true;
            streetButtons[53].Enabled = true;
            streetButtons[54].Enabled = true;
            streetButtons[55].Enabled = true;
            streetButtons[56].Enabled = true;
            streetButtons[57].Enabled = true;
            streetButtons[58].Enabled = true;
            streetButtons[59].Enabled = true;
            streetButtons[60].Enabled = true;
            streetButtons[61].Enabled = true;
            streetButtons[62].Enabled = true;
            streetButtons[63].Enabled = true;
            streetButtons[64].Enabled = true;
            streetButtons[65].Enabled = true;
            streetButtons[66].Enabled = true;
            streetButtons[67].Enabled = true;
            streetButtons[68].Enabled = true;
            streetButtons[69].Enabled = true;
            streetButtons[70].Enabled = true;
            streetButtons[71].Enabled = true;

        }


    }
}
