using UnityEngine;

namespace PGCompany.AttributeSystem
{
    internal static class 丏丟丌丌丝丛丙丕丈
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<int, PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂> 丅万丂世不丘丕下一;
        private static readonly System.Collections.Generic.Dictionary<int, string> 丕七丘三丄丞三世上;
        private static readonly System.Collections.Generic.Dictionary<string, int> 丙一世丕且丆万世丗;
        
        // Methods
        internal static PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂 丛丗丗丙丞丈且丌与(int 丂世丒下丁三丄东丆)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            if((PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈.丅万丂世不丘丕下一.ContainsKey(key:  丂世丒下丁三丄东丆)) != false)
            {
                    val_4 = null;
                val_4 = null;
                PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂 val_2 = PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈.丅万丂世不丘丕下一.Item[丂世丒下丁三丄东丆];
                return (PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂)val_5;
            }
            
            val_5 = 0;
            return (PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂)val_5;
        }
        internal static object 丈丟世业丝世丘丞丆(int 丂世丒下丁三丄东丆)
        {
            var val_3;
            var val_4;
            object val_5;
            val_3 = null;
            val_3 = null;
            if((PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈.丅万丂世不丘丕下一.ContainsKey(key:  丂世丒下丁三丄东丆)) != false)
            {
                    val_4 = null;
                val_4 = null;
                if(PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈.丅万丂世不丘丕下一.Item[丂世丒下丁三丄东丆] == null)
            {
                    return (object)val_5;
            }
            
                val_5 = val_2.<丒丙丙丂丗丅丟专业>k__BackingField;
                return (object)val_5;
            }
            
            val_5 = 0;
            return (object)val_5;
        }
        private static 丏丟丌丌丝丛丙丕丈()
        {
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂> val_1 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂>();
            .<专东丐丈上且上丟丈>k__BackingField = "attr_PlayerLevel";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 1201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = true;
            val_1.Add(key:  177, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossSum_Total";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 2201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  153, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossGroup";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 3201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  129, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMax_Total";
            .<上七东下丏不丕丐丑>k__BackingField = 4201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  105, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_LootBoxLotterySuperSpin";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 5201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  81, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_LootBoxLotteryHardSpend";
            .<上七东下丏不丕丐丑>k__BackingField = 6201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  57, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_PlayerRandomSeed_LootRate";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 7201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  33, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_LootBoxLevelMax_OpenedTotal";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 8201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  9, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_LootBoxLevelMax_OpenedDynamic";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 9201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  241, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_1";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 10201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  217, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_2";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 11201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  193, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_3";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 12201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  169, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_4";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 13201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  145, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_5";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 14201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  121, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_6";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 15201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  97, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_7";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 16201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  73, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop1League_8";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 17201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  49, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_GameOfferStep";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 18201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  25, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMedian_7d";
            .<上七东下丏不丕丐丑>k__BackingField = 19201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  1, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMedian_15d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 20201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  233, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMedian_30d";
            .<上七东下丏不丕丐丑>k__BackingField = 21201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  209, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMedian_90d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 22201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  185, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossAvg_7d";
            .<上七东下丏不丕丐丑>k__BackingField = 23201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  161, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossAvg_15d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 24201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  137, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossAvg_30d";
            .<上七东下丏不丕丐丑>k__BackingField = 25201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  113, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossAvg_90d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 26201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  89, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMax_7d";
            .<上七东下丏不丕丐丑>k__BackingField = 27201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  65, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMax_15d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 28201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  41, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMax_30d";
            .<上七东下丏不丕丐丑>k__BackingField = 29201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  17, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMax_90d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 30201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  249, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossSum_7d";
            .<上七东下丏不丕丐丑>k__BackingField = 31201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  225, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossSum_15d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 32201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossSum_30d";
            .<上七东下丏不丕丐丑>k__BackingField = 33201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  177, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossSum_90d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 34201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  153, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_1";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 35201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  129, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_2";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 36201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  105, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_3";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 37201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  81, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_4";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 38201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  57, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_5";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 39201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  33, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_6";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 40201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  9, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_7";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 41201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  241, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CompetitionTop3League_8";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 42201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  217, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_FeatureLottery_TutorialComplete";
            .<上七东下丏不丕丐丑>k__BackingField = 43201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  193, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_FeatureBattlePass_TutorialComplete";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 44201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  169, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_PlayerExp";
            .<上七东下丏不丕丐丑>k__BackingField = 45201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  145, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Competition_League_Current";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 46201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  121, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Competition_Score_Current";
            .<上七东下丏不丕丐丑>k__BackingField = 47201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  97, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossAvg_Total";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 48201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  73, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_GrossMedian_Total";
            .<上七东下丏不丕丐丑>k__BackingField = 49201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  49, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_Count_Total";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 50201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  25, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Payment_CountRefund_Total";
            .<上七东下丏不丕丐丑>k__BackingField = 51201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  1, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Test_AB";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 52201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  233, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Test_ABC";
            .<上七东下丏不丕丐丑>k__BackingField = 53201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  209, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_BattleCounter_1h";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 54201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  185, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_BattleCounter_1d";
            .<上七东下丏不丕丐丑>k__BackingField = 55201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  161, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_BattleCounter_7d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 56201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  137, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_BattleCounter_30d";
            .<上七东下丏不丕丐丑>k__BackingField = 57201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  113, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_attr_LootBox_2170_Mech_OpenDelta";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = 58201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  89, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_FeaturePixelPass_TutorialComplete";
            .<上七东下丏不丕丐丑>k__BackingField = 59201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  65, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_TimeFromLastPixelPassStart_Sec";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 60201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  41, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_BattleCounter_Total";
            .<上七东下丏不丕丐丑>k__BackingField = 61201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  17, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_WinRate_1h";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 62201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  249, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_WinRate_1d";
            .<上七东下丏不丕丐丑>k__BackingField = 63201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  225, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_WinRate_7d";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 64201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_WinRate_30d";
            .<上七东下丏不丕丐丑>k__BackingField = 65201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  177, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_WinRate_Total";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 66201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  66201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<上七东下丏不丕丐丑>k__BackingField = 67201;
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Version_Client";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  67201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Time_Since_Registration";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 68201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  68201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Registration_Time";
            .<上七东下丏不丕丐丑>k__BackingField = 69201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  69201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_LastSession_Time";
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<上七东下丏不丕丐丑>k__BackingField = 70201;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  70201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<上七东下丏不丕丐丑>k__BackingField = 71201;
            .<专东丐丈上且上丟丈>k__BackingField = "attr_Trigger_GemAbuser";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  71201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            .<专东丐丈上且上丟丈>k__BackingField = "attr_CurrentPixelPassPemium_IsActive";
            .<上七东下丏不丕丐丑>k__BackingField = 72201;
            .<丑三七上且丈丝万丞>k__BackingField = true;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  72201, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            int val_75 = 71201 + 2000;
            .<专东丐丈上且上丟丈>k__BackingField = "attr_LootBox_2180_Mutant_OpenDelta";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = val_75;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  val_75, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            int val_77 = 71201 + 3000;
            .<专东丐丈上且上丟丈>k__BackingField = "attr_LootBox_13027_OpenCounter";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = val_77;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  val_77, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            int val_79 = 71201 + 4000;
            .<专东丐丈上且上丟丈>k__BackingField = "Attr_Lotbox_ChristmasCombo_OpenCounter";
            .<丑三七上且丈丝万丞>k__BackingField = false;
            .<上七东下丏不丕丐丑>k__BackingField = val_79;
            .<丒丙丙丂丗丅丟专业>k__BackingField = 0;
            val_1.Add(key:  val_79, value:  new PGCompany.AttributeSystem.Data.丑不且丁丌专不东丂());
            PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈.丅万丂世不丘丕下一 = val_1;
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_80 = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            if(val_80 != null)
            {
                    val_80.Add(key:  177, value:  "attr_PlayerLevel");
            }
            else
            {
                    val_80.Add(key:  177, value:  "attr_PlayerLevel");
            }
            
            val_80.Add(key:  153, value:  "attr_Payment_GrossSum_Total");
            if(val_80 != null)
            {
                    val_80.Add(key:  129, value:  "attr_Payment_GrossGroup");
            }
            else
            {
                    val_80.Add(key:  129, value:  "attr_Payment_GrossGroup");
            }
            
            val_80.Add(key:  105, value:  "attr_Payment_GrossMax_Total");
            if(val_80 != null)
            {
                    val_80.Add(key:  81, value:  "attr_LootBoxLotterySuperSpin");
            }
            else
            {
                    val_80.Add(key:  81, value:  "attr_LootBoxLotterySuperSpin");
            }
            
            val_80.Add(key:  57, value:  "attr_LootBoxLotteryHardSpend");
            if(val_80 != null)
            {
                    val_80.Add(key:  33, value:  "attr_PlayerRandomSeed_LootRate");
            }
            else
            {
                    val_80.Add(key:  33, value:  "attr_PlayerRandomSeed_LootRate");
            }
            
            val_80.Add(key:  9, value:  "attr_LootBoxLevelMax_OpenedTotal");
            if(val_80 != null)
            {
                    val_80.Add(key:  241, value:  "attr_LootBoxLevelMax_OpenedDynamic");
            }
            else
            {
                    val_80.Add(key:  241, value:  "attr_LootBoxLevelMax_OpenedDynamic");
            }
            
            val_80.Add(key:  217, value:  "attr_CompetitionTop1League_1");
            if(val_80 != null)
            {
                    val_80.Add(key:  193, value:  "attr_CompetitionTop1League_2");
            }
            else
            {
                    val_80.Add(key:  193, value:  "attr_CompetitionTop1League_2");
            }
            
            val_80.Add(key:  169, value:  "attr_CompetitionTop1League_3");
            if(val_80 != null)
            {
                    val_80.Add(key:  145, value:  "attr_CompetitionTop1League_4");
            }
            else
            {
                    val_80.Add(key:  145, value:  "attr_CompetitionTop1League_4");
            }
            
            val_80.Add(key:  121, value:  "attr_CompetitionTop1League_5");
            if(val_80 != null)
            {
                    val_80.Add(key:  97, value:  "attr_CompetitionTop1League_6");
            }
            else
            {
                    val_80.Add(key:  97, value:  "attr_CompetitionTop1League_6");
            }
            
            val_80.Add(key:  73, value:  "attr_CompetitionTop1League_7");
            if(val_80 != null)
            {
                    val_80.Add(key:  49, value:  "attr_CompetitionTop1League_8");
            }
            else
            {
                    val_80.Add(key:  49, value:  "attr_CompetitionTop1League_8");
            }
            
            val_80.Add(key:  25, value:  "attr_GameOfferStep");
            if(val_80 != null)
            {
                    val_80.Add(key:  1, value:  "attr_Payment_GrossMedian_7d");
            }
            else
            {
                    val_80.Add(key:  1, value:  "attr_Payment_GrossMedian_7d");
            }
            
            val_80.Add(key:  233, value:  "attr_Payment_GrossMedian_15d");
            if(val_80 != null)
            {
                    val_80.Add(key:  209, value:  "attr_Payment_GrossMedian_30d");
            }
            else
            {
                    val_80.Add(key:  209, value:  "attr_Payment_GrossMedian_30d");
            }
            
            val_80.Add(key:  185, value:  "attr_Payment_GrossMedian_90d");
            if(val_80 != null)
            {
                    val_80.Add(key:  161, value:  "attr_Payment_GrossAvg_7d");
            }
            else
            {
                    val_80.Add(key:  161, value:  "attr_Payment_GrossAvg_7d");
            }
            
            val_80.Add(key:  137, value:  "attr_Payment_GrossAvg_15d");
            if(val_80 != null)
            {
                    val_80.Add(key:  113, value:  "attr_Payment_GrossAvg_30d");
            }
            else
            {
                    val_80.Add(key:  113, value:  "attr_Payment_GrossAvg_30d");
            }
            
            val_80.Add(key:  89, value:  "attr_Payment_GrossAvg_90d");
            if(val_80 != null)
            {
                    val_80.Add(key:  65, value:  "attr_Payment_GrossMax_7d");
            }
            else
            {
                    val_80.Add(key:  65, value:  "attr_Payment_GrossMax_7d");
            }
            
            val_80.Add(key:  41, value:  "attr_Payment_GrossMax_15d");
            if(val_80 != null)
            {
                    val_80.Add(key:  17, value:  "attr_Payment_GrossMax_30d");
            }
            else
            {
                    val_80.Add(key:  17, value:  "attr_Payment_GrossMax_30d");
            }
            
            val_80.Add(key:  249, value:  "attr_Payment_GrossMax_90d");
            if(val_80 != null)
            {
                    val_80.Add(key:  225, value:  "attr_Payment_GrossSum_7d");
            }
            else
            {
                    val_80.Add(key:  225, value:  "attr_Payment_GrossSum_7d");
            }
            
            val_80.Add(key:  201, value:  "attr_Payment_GrossSum_15d");
            if(val_80 != null)
            {
                    val_80.Add(key:  177, value:  "attr_Payment_GrossSum_30d");
            }
            else
            {
                    val_80.Add(key:  177, value:  "attr_Payment_GrossSum_30d");
            }
            
            val_80.Add(key:  153, value:  "attr_Payment_GrossSum_90d");
            if(val_80 != null)
            {
                    val_80.Add(key:  129, value:  "attr_CompetitionTop3League_1");
            }
            else
            {
                    val_80.Add(key:  129, value:  "attr_CompetitionTop3League_1");
            }
            
            val_80.Add(key:  105, value:  "attr_CompetitionTop3League_2");
            if(val_80 != null)
            {
                    val_80.Add(key:  81, value:  "attr_CompetitionTop3League_3");
            }
            else
            {
                    val_80.Add(key:  81, value:  "attr_CompetitionTop3League_3");
            }
            
            val_80.Add(key:  57, value:  "attr_CompetitionTop3League_4");
            if(val_80 != null)
            {
                    val_80.Add(key:  33, value:  "attr_CompetitionTop3League_5");
            }
            else
            {
                    val_80.Add(key:  33, value:  "attr_CompetitionTop3League_5");
            }
            
            val_80.Add(key:  9, value:  "attr_CompetitionTop3League_6");
            if(val_80 != null)
            {
                    val_80.Add(key:  241, value:  "attr_CompetitionTop3League_7");
            }
            else
            {
                    val_80.Add(key:  241, value:  "attr_CompetitionTop3League_7");
            }
            
            val_80.Add(key:  217, value:  "attr_CompetitionTop3League_8");
            if(val_80 != null)
            {
                    val_80.Add(key:  193, value:  "attr_FeatureLottery_TutorialComplete");
            }
            else
            {
                    val_80.Add(key:  193, value:  "attr_FeatureLottery_TutorialComplete");
            }
            
            val_80.Add(key:  169, value:  "attr_FeatureBattlePass_TutorialComplete");
            if(val_80 != null)
            {
                    val_80.Add(key:  145, value:  "attr_PlayerExp");
            }
            else
            {
                    val_80.Add(key:  145, value:  "attr_PlayerExp");
            }
            
            val_80.Add(key:  121, value:  "attr_Competition_League_Current");
            if(val_80 != null)
            {
                    val_80.Add(key:  97, value:  "attr_Competition_Score_Current");
            }
            else
            {
                    val_80.Add(key:  97, value:  "attr_Competition_Score_Current");
            }
            
            val_80.Add(key:  73, value:  "attr_Payment_GrossAvg_Total");
            if(val_80 != null)
            {
                    val_80.Add(key:  49, value:  "attr_Payment_GrossMedian_Total");
            }
            else
            {
                    val_80.Add(key:  49, value:  "attr_Payment_GrossMedian_Total");
            }
            
            val_80.Add(key:  25, value:  "attr_Payment_Count_Total");
            if(val_80 != null)
            {
                    val_80.Add(key:  1, value:  "attr_Payment_CountRefund_Total");
            }
            else
            {
                    val_80.Add(key:  1, value:  "attr_Payment_CountRefund_Total");
            }
            
            val_80.Add(key:  233, value:  "attr_Test_AB");
            if(val_80 != null)
            {
                    val_80.Add(key:  209, value:  "attr_Test_ABC");
            }
            else
            {
                    val_80.Add(key:  209, value:  "attr_Test_ABC");
            }
            
            val_80.Add(key:  185, value:  "attr_BattleCounter_1h");
            if(val_80 != null)
            {
                    val_80.Add(key:  161, value:  "attr_BattleCounter_1d");
            }
            else
            {
                    val_80.Add(key:  161, value:  "attr_BattleCounter_1d");
            }
            
            val_80.Add(key:  137, value:  "attr_BattleCounter_7d");
            if(val_80 != null)
            {
                    val_80.Add(key:  113, value:  "attr_BattleCounter_30d");
            }
            else
            {
                    val_80.Add(key:  113, value:  "attr_BattleCounter_30d");
            }
            
            val_80.Add(key:  89, value:  "attr_attr_LootBox_2170_Mech_OpenDelta");
            if(val_80 != null)
            {
                    val_80.Add(key:  65, value:  "attr_FeaturePixelPass_TutorialComplete");
            }
            else
            {
                    val_80.Add(key:  65, value:  "attr_FeaturePixelPass_TutorialComplete");
            }
            
            val_80.Add(key:  41, value:  "attr_TimeFromLastPixelPassStart_Sec");
            if(val_80 != null)
            {
                    val_80.Add(key:  17, value:  "attr_BattleCounter_Total");
            }
            else
            {
                    val_80.Add(key:  17, value:  "attr_BattleCounter_Total");
            }
            
            val_80.Add(key:  249, value:  "attr_WinRate_1h");
            if(val_80 != null)
            {
                    val_80.Add(key:  225, value:  "attr_WinRate_1d");
            }
            else
            {
                    val_80.Add(key:  225, value:  "attr_WinRate_1d");
            }
            
            val_80.Add(key:  201, value:  "attr_WinRate_7d");
            if(val_80 != null)
            {
                    val_80.Add(key:  177, value:  "attr_WinRate_30d");
            }
            else
            {
                    val_80.Add(key:  177, value:  "attr_WinRate_30d");
            }
            
            val_80.Add(key:  66201, value:  "attr_WinRate_Total");
            if(val_80 != null)
            {
                    val_80.Add(key:  67201, value:  "attr_Version_Client");
            }
            else
            {
                    val_80.Add(key:  67201, value:  "attr_Version_Client");
            }
            
            val_80.Add(key:  67201 + 1000, value:  "attr_Time_Since_Registration");
            if(val_80 != null)
            {
                    val_80.Add(key:  67201 + 2000, value:  "attr_Registration_Time");
            }
            else
            {
                    val_80.Add(key:  67201 + 2000, value:  "attr_Registration_Time");
            }
            
            val_80.Add(key:  67201 + 3000, value:  "attr_LastSession_Time");
            if(val_80 != null)
            {
                    val_80.Add(key:  71201, value:  "attr_Trigger_GemAbuser");
            }
            else
            {
                    val_80.Add(key:  71201, value:  "attr_Trigger_GemAbuser");
            }
            
            val_80.Add(key:  71201 + 1000, value:  "attr_CurrentPixelPassPemium_IsActive");
            if(val_80 != null)
            {
                    val_80.Add(key:  71201 + 2000, value:  "attr_LootBox_2180_Mutant_OpenDelta");
            }
            else
            {
                    val_80.Add(key:  71201 + 2000, value:  "attr_LootBox_2180_Mutant_OpenDelta");
            }
            
            val_80.Add(key:  71201 + 3000, value:  "attr_LootBox_13027_OpenCounter");
            val_80.Add(key:  71201 + 4000, value:  "Attr_Lotbox_ChristmasCombo_OpenCounter");
            PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈.丕七丘三丄丞三世上 = val_80;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_90 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_PlayerLevel", value:  177);
            }
            else
            {
                    val_90.Add(key:  "attr_PlayerLevel", value:  177);
            }
            
            val_90.Add(key:  "attr_Payment_GrossSum_Total", value:  153);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossGroup", value:  129);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossGroup", value:  129);
            }
            
            val_90.Add(key:  "attr_Payment_GrossMax_Total", value:  105);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_LootBoxLotterySuperSpin", value:  81);
            }
            else
            {
                    val_90.Add(key:  "attr_LootBoxLotterySuperSpin", value:  81);
            }
            
            val_90.Add(key:  "attr_LootBoxLotteryHardSpend", value:  57);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_PlayerRandomSeed_LootRate", value:  33);
            }
            else
            {
                    val_90.Add(key:  "attr_PlayerRandomSeed_LootRate", value:  33);
            }
            
            val_90.Add(key:  "attr_LootBoxLevelMax_OpenedTotal", value:  9);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_LootBoxLevelMax_OpenedDynamic", value:  241);
            }
            else
            {
                    val_90.Add(key:  "attr_LootBoxLevelMax_OpenedDynamic", value:  241);
            }
            
            val_90.Add(key:  "attr_CompetitionTop1League_1", value:  217);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_2", value:  193);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_2", value:  193);
            }
            
            val_90.Add(key:  "attr_CompetitionTop1League_3", value:  169);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_4", value:  145);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_4", value:  145);
            }
            
            val_90.Add(key:  "attr_CompetitionTop1League_5", value:  121);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_6", value:  97);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_6", value:  97);
            }
            
            val_90.Add(key:  "attr_CompetitionTop1League_7", value:  73);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_8", value:  49);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop1League_8", value:  49);
            }
            
            val_90.Add(key:  "attr_GameOfferStep", value:  25);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossMedian_7d", value:  1);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossMedian_7d", value:  1);
            }
            
            val_90.Add(key:  "attr_Payment_GrossMedian_15d", value:  233);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossMedian_30d", value:  209);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossMedian_30d", value:  209);
            }
            
            val_90.Add(key:  "attr_Payment_GrossMedian_90d", value:  185);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossAvg_7d", value:  161);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossAvg_7d", value:  161);
            }
            
            val_90.Add(key:  "attr_Payment_GrossAvg_15d", value:  137);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossAvg_30d", value:  113);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossAvg_30d", value:  113);
            }
            
            val_90.Add(key:  "attr_Payment_GrossAvg_90d", value:  89);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossMax_7d", value:  65);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossMax_7d", value:  65);
            }
            
            val_90.Add(key:  "attr_Payment_GrossMax_15d", value:  41);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossMax_30d", value:  17);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossMax_30d", value:  17);
            }
            
            val_90.Add(key:  "attr_Payment_GrossMax_90d", value:  249);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossSum_7d", value:  225);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossSum_7d", value:  225);
            }
            
            val_90.Add(key:  "attr_Payment_GrossSum_15d", value:  201);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossSum_30d", value:  177);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossSum_30d", value:  177);
            }
            
            val_90.Add(key:  "attr_Payment_GrossSum_90d", value:  153);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_1", value:  129);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_1", value:  129);
            }
            
            val_90.Add(key:  "attr_CompetitionTop3League_2", value:  105);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_3", value:  81);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_3", value:  81);
            }
            
            val_90.Add(key:  "attr_CompetitionTop3League_4", value:  57);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_5", value:  33);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_5", value:  33);
            }
            
            val_90.Add(key:  "attr_CompetitionTop3League_6", value:  9);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_7", value:  241);
            }
            else
            {
                    val_90.Add(key:  "attr_CompetitionTop3League_7", value:  241);
            }
            
            val_90.Add(key:  "attr_CompetitionTop3League_8", value:  217);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_FeatureLottery_TutorialComplete", value:  193);
            }
            else
            {
                    val_90.Add(key:  "attr_FeatureLottery_TutorialComplete", value:  193);
            }
            
            val_90.Add(key:  "attr_FeatureBattlePass_TutorialComplete", value:  169);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_PlayerExp", value:  145);
            }
            else
            {
                    val_90.Add(key:  "attr_PlayerExp", value:  145);
            }
            
            val_90.Add(key:  "attr_Competition_League_Current", value:  121);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Competition_Score_Current", value:  97);
            }
            else
            {
                    val_90.Add(key:  "attr_Competition_Score_Current", value:  97);
            }
            
            val_90.Add(key:  "attr_Payment_GrossAvg_Total", value:  73);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_GrossMedian_Total", value:  49);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_GrossMedian_Total", value:  49);
            }
            
            val_90.Add(key:  "attr_Payment_Count_Total", value:  25);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Payment_CountRefund_Total", value:  1);
            }
            else
            {
                    val_90.Add(key:  "attr_Payment_CountRefund_Total", value:  1);
            }
            
            val_90.Add(key:  "attr_Test_AB", value:  233);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Test_ABC", value:  209);
            }
            else
            {
                    val_90.Add(key:  "attr_Test_ABC", value:  209);
            }
            
            val_90.Add(key:  "attr_BattleCounter_1h", value:  185);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_BattleCounter_1d", value:  161);
            }
            else
            {
                    val_90.Add(key:  "attr_BattleCounter_1d", value:  161);
            }
            
            val_90.Add(key:  "attr_BattleCounter_7d", value:  137);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_BattleCounter_30d", value:  113);
            }
            else
            {
                    val_90.Add(key:  "attr_BattleCounter_30d", value:  113);
            }
            
            val_90.Add(key:  "attr_attr_LootBox_2170_Mech_OpenDelta", value:  89);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_FeaturePixelPass_TutorialComplete", value:  65);
            }
            else
            {
                    val_90.Add(key:  "attr_FeaturePixelPass_TutorialComplete", value:  65);
            }
            
            val_90.Add(key:  "attr_TimeFromLastPixelPassStart_Sec", value:  41);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_BattleCounter_Total", value:  17);
            }
            else
            {
                    val_90.Add(key:  "attr_BattleCounter_Total", value:  17);
            }
            
            val_90.Add(key:  "attr_WinRate_1h", value:  249);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_WinRate_1d", value:  225);
            }
            else
            {
                    val_90.Add(key:  "attr_WinRate_1d", value:  225);
            }
            
            val_90.Add(key:  "attr_WinRate_7d", value:  201);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_WinRate_30d", value:  177);
            }
            else
            {
                    val_90.Add(key:  "attr_WinRate_30d", value:  177);
            }
            
            val_90.Add(key:  "attr_WinRate_Total", value:  66201);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Version_Client", value:  67201);
            }
            else
            {
                    val_90.Add(key:  "attr_Version_Client", value:  67201);
            }
            
            val_90.Add(key:  "attr_Time_Since_Registration", value:  67201 + 1000);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Registration_Time", value:  67201 + 2000);
            }
            else
            {
                    val_90.Add(key:  "attr_Registration_Time", value:  67201 + 2000);
            }
            
            val_90.Add(key:  "attr_LastSession_Time", value:  67201 + 3000);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_Trigger_GemAbuser", value:  71201);
            }
            else
            {
                    val_90.Add(key:  "attr_Trigger_GemAbuser", value:  71201);
            }
            
            val_90.Add(key:  "attr_CurrentPixelPassPemium_IsActive", value:  71201 + 1000);
            if(val_90 != null)
            {
                    val_90.Add(key:  "attr_LootBox_2180_Mutant_OpenDelta", value:  71201 + 2000);
            }
            else
            {
                    val_90.Add(key:  "attr_LootBox_2180_Mutant_OpenDelta", value:  71201 + 2000);
            }
            
            val_90.Add(key:  "attr_LootBox_13027_OpenCounter", value:  71201 + 3000);
            val_90.Add(key:  "Attr_Lotbox_ChristmasCombo_OpenCounter", value:  71201 + 4000);
            PGCompany.AttributeSystem.丏丟丌丌丝丛丙丕丈.丙一世丕且丆万世丗 = val_90;
        }
    
    }

}
