using UnityEngine;

namespace Rilisoft
{
    internal static class 丗万且下与专业丏丝
    {
        // Fields
        internal const string 丅丁丑丘东丗丑丄丙 = "recommend-clan";
        private const string 与丌丞丝下上业丁丑 = "ClansRecommender.FIRST_SHOW_PLASHKA_TIME";
        private static int 丒丘世世不丂下七上;
        
        // Methods
        internal static void 丝上上丞丄丅丘丙专()
        {
            string val_4 = Rilisoft.丗万且下与专业丏丝.世丟七丞丙东专丌丅();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4 = Rilisoft.丗万且下与专业丏丝.世丟七丞丙东专丌丅())) == false)
            {
                    return;
            }
            
            System.DateTime val_3 = System.DateTime.UtcNow;
            val_4;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ClansRecommender.FIRST_SHOW_PLASHKA_TIME", 下下丏一丙不丘丌丞:  val_3.dateData);
        }
        internal static bool 一丈且丞丏七上丝上(bool 丛专下丞丒丛下下与)
        {
            var val_16;
            var val_17;
            if((Rilisoft.Singleton<ClansController>.Instance) != 0)
            {
                    if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
            {
                goto label_25;
            }
            
            }
            
            if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) == false)
            {
                goto label_25;
            }
            
            val_16 = 0;
            int val_6 = BalanceController.万且东丄下丕七东丈();
            if(val_6 == 0)
            {
                    return (bool)val_16;
            }
            
            val_17 = null;
            val_17 = null;
            int val_16 = Rilisoft.丗万且下与专业丏丝.丒丘世世不丂下七上;
            val_16 = val_16 - ((val_16 / val_6) * val_6);
            if(val_16 == 0)
            {
                goto label_12;
            }
            
            label_25:
            val_16 = 0;
            return (bool)val_16;
            label_12:
            string val_8 = Rilisoft.丗万且下与专业丏丝.世丟七丞丙东专丌丅();
            if(丛专下丞丒丛下下与 == false)
            {
                    return (bool)val_16;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) == true)
            {
                    return (bool)val_16;
            }
            
            if((System.DateTime.TryParse(s:  val_8, result: out  new System.DateTime())) == false)
            {
                    return (bool)val_16;
            }
            
            System.DateTime val_11 = System.DateTime.UtcNow;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_11.dateData}, t2:  new System.DateTime())) == false)
            {
                    return (bool)val_16;
            }
            
            System.TimeSpan val_13 = val_11.dateData.Subtract(value:  new System.DateTime());
            if(val_13._ticks.TotalDays >= 1)
            {
                goto label_25;
            }
            
            return (bool)val_16;
        }
        internal static void 丞世业丈丏丑丏世丕()
        {
            null = null;
            int val_1 = Rilisoft.丗万且下与专业丏丝.丒丘世世不丂下七上;
            val_1 = val_1 + 1;
            Rilisoft.丗万且下与专业丏丝.丒丘世世不丂下七上 = val_1;
        }
        private static string 世丟七丞丙东专丌丅()
        {
            int val_3;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "ClansRecommender.FIRST_SHOW_PLASHKA_TIME")) == true)
            {
                    return (string)丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "ClansRecommender.FIRST_SHOW_PLASHKA_TIME");
            }
            
            val_3 = System.String.alignConst;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ClansRecommender.FIRST_SHOW_PLASHKA_TIME", 下下丏一丙不丘丌丞:  val_3);
            return (string)丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "ClansRecommender.FIRST_SHOW_PLASHKA_TIME");
        }
        private static 丗万且下与专业丏丝()
        {
            Rilisoft.丗万且下与专业丏丝.丒丘世世不丂下七上 = 0;
        }
    
    }

}
