using UnityEngine;

namespace PGCompany
{
    internal sealed class PiggyOffersAnalyticsController : PGBehaviour
    {
        // Fields
        private static readonly System.Lazy<PGCompany.PiggyOffersAnalyticsController> 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.PiggyOffersAnalyticsController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.PiggyOffersAnalyticsController 丑七不且上丗丁一世()
        {
            null = null;
            if(PGCompany.PiggyOffersAnalyticsController.丝业丆丁业三丈丟东 != null)
            {
                    return PGCompany.PiggyOffersAnalyticsController.丝业丆丁业三丈丟东.Value;
            }
            
            return PGCompany.PiggyOffersAnalyticsController.丝业丆丁业三丈丟东.Value;
        }
        internal void 下丌业业丐丘丐丘三()
        {
        
        }
        internal void 丟业丈世万丙专世丌()
        {
            bool val_1 = PiggyPromotionBanner.丒丘丕且专丒丐东业();
            val_1.丂丙丟世专丗且七业(世丁丙世丄一万丆三:  (val_1 != true) ? "time_banner_purchase" : "first_purchase");
        }
        internal void 与丞一丒业且上丝丌()
        {
            bool val_1 = PiggyPromotionBanner.丒丘丕且专丒丐东业();
            val_1.丂丙丟世专丗且七业(世丁丙世丄一万丆三:  (val_1 != true) ? "time_banner_reward" : "get_reward");
        }
        internal void 丁业七丅丛丗丄丌七()
        {
            bool val_2 = Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().丂与万丘丘丂下与丌();
            if(val_2 != false)
            {
                    return;
            }
            
            val_2.丂丙丟世专丗且七业(世丁丙世丄一万丆三:  "time_banner_decline");
        }
        private void 丂丙丟世专丗且七业(string 世丁丙世丄一万丆三)
        {
            if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丈一下下丞世三丑丄() != PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丄且东且丕丛与丆丒())
            {
                    0f = (float)PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().且丆丟业丞丕丑上且() / (float)PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().上丄丈丛与丛丕丂丐();
            }
            
            float val_9 = UnityEngine.Mathf.Clamp(value:  0f, min:  0f, max:  1f);
            val_9 = val_9 * 100f;
            PGCompany.Analytics.一业丗丆世世上丁且.丕万万丁专万丞世且(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丈丘丝一丗下丈丐不:  PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丈一下下丞世三丑丄(), 丗与丘不且万丟丙丑:  UnityEngine.Mathf.FloorToInt(f:  val_9), 世丁丙世丄一万丆三:  世丁丙世丄一万丆三);
        }
        internal void 下丅与且丟世丗万丛()
        {
            string val_14;
            PGCompany.StorePromotionConfig val_2 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丛下丆且丟丙与万丗();
            if(val_2 == null)
            {
                    return;
            }
            
            val_14 = "FirstTime";
            if(Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().一且丄丄丏丛丁丗东() >= 1)
            {
                    val_14 = mem[val_6 == val_8 ? "ByUser" : "ByLevel"];
                val_14 = (PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丈一下下丞世三丑丄() == Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().丆丆下丛丈丂与丕丟()) ? "ByUser" : "ByLevel";
            }
            
            PGCompany.StorePromotionSettings val_11 = val_2.Settings;
            PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丗下一不丘丑丅业且:  val_11.PurchaseSettings.与丂三丟业丘与丅三().丂丁丏一丙丛业且丌(), 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  "piggy", 一丑丑丝丏且丂丏丘:  val_14);
        }
        public PiggyOffersAnalyticsController()
        {
        
        }
        private static PiggyOffersAnalyticsController()
        {
            null = null;
            PGCompany.PiggyOffersAnalyticsController.丝业丆丁业三丈丟东 = new System.Lazy<PGCompany.PiggyOffersAnalyticsController>(valueFactory:  new System.Func<PGCompany.PiggyOffersAnalyticsController>(object:  PiggyOffersAnalyticsController.<>c.<>9, method:  PGCompany.PiggyOffersAnalyticsController PiggyOffersAnalyticsController.<>c::丗丅七与不丂东丆东()));
        }
    
    }

}
