using UnityEngine;

namespace Infrastructure
{
    internal sealed class 丑不丅丘七与不丑三
    {
        // Fields
        private const string 丒丝丈丘丐丌业万丗 = "InAppReview.Requested";
        private static Infrastructure.丑不丅丘七与不丑三 世丒丞七专三与万丕;
        private readonly Google.Play.Review.ReviewManager 丙世不丌丕丙七丌一;
        
        // Properties
        internal static Infrastructure.丑不丅丘七与不丑三 丆丕丝丒不丙且丐丗 { get; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        private 丑不丅丘七与不丑三(Google.Play.Review.ReviewManager 丁万丝丛专丈且上东)
        {
            this.丙世不丌丕丙七丌一 = 丁万丝丛专丈且上东;
        }
        internal static Infrastructure.丑不丅丘七与不丑三 丑七不且上丗丁一世()
        {
            if(Infrastructure.丑不丅丘七与不丑三.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            Infrastructure.丑不丅丘七与不丑三 val_1 = Infrastructure.丑不丅丘七与不丑三.东丝七业丄丑丒世七();
            Infrastructure.丑不丅丘七与不丑三.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private static Infrastructure.丑不丅丘七与不丑三 东丝七业丄丑丒世七()
        {
            if(Infrastructure.丑不丅丘七与不丑三.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[InAppReviewFacade.Create]");
            }
            
            .丙世不丌丕丙七丌一 = new Google.Play.Review.ReviewManager();
            return (Infrastructure.丑不丅丘七与不丑三)new Infrastructure.丑不丅丘七与不丑三();
        }
        internal static void 东丕丝世丑丈丞丄丁()
        {
            if(Infrastructure.丑不丅丘七与不丑三.世丒丞七专三与万丕 != null)
            {
                    return;
            }
            
            Infrastructure.丑不丅丘七与不丑三.世丒丞七专三与万丕 = Infrastructure.丑不丅丘七与不丑三.东丝七业丄丑丒世七();
        }
        internal System.Collections.IEnumerator 世丑丆丗业丑万丗业()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丑不丅丘七与不丑三.丗丙丕且一丑丝丈七();
        }
        internal System.Collections.IEnumerator 一丏七丗丗丆丐丘业()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丑不丅丘七与不丑三.丙丅世与丁专丗丕专();
        }
        internal System.Collections.IEnumerator 丆丞丈万与世丝丛丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丑不丅丘七与不丑三.一丑一一丗丄世丙丈();
        }
        internal static bool 下上上业一且丑东丟()
        {
            long val_10;
            if((Infrastructure.丑不丅丘七与不丑三.丟世且丑丗丌上丝七(丑丙万一丏丅丁专丏: out  new System.DateTime())) == false)
            {
                goto label_1;
            }
            
            System.DateTime val_2 = System.DateTime.UtcNow;
            System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_2.dateData}, d2:  new System.DateTime());
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_6;
            }
            
            System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  28);
            goto label_9;
            label_1:
            val_10 = 1;
            return (bool)System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_10}, t2:  new System.TimeSpan() {_ticks = val_6._ticks});
            label_6:
            System.TimeSpan val_6 = System.TimeSpan.FromDays(value:  28);
            label_9:
            val_10 = val_3._ticks;
            return (bool)System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_10}, t2:  new System.TimeSpan() {_ticks = val_6._ticks});
        }
        private static bool 丟世且丑丗丌上丝七(out System.DateTime 丑丙万一丏丅丁专丏)
        {
            string val_6;
            丑丙万一丏丅丁专丏.dateData = 0;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  "InAppReview.Requested", defaultValue:  System.String.alignConst);
            if((System.String.IsNullOrWhiteSpace(value:  val_1)) != false)
            {
                    val_6 = 0;
                return (bool)System.DateTime.TryParse(s:  val_6 = val_1, provider:  Infrastructure.丑不丅丘七与不丑三.丙专丝世不业下丂丈(), styles:  128, result: out  new System.DateTime() {dateData = 丑丙万一丏丅丁专丏.dateData});
            }
            
            return (bool)System.DateTime.TryParse(s:  val_6, provider:  Infrastructure.丑不丅丘七与不丑三.丙专丝世不业下丂丈(), styles:  128, result: out  new System.DateTime() {dateData = 丑丙万一丏丅丁专丏.dateData});
        }
        private static void 专丘七丁上不丈丕不(System.DateTime 丑丙万一丏丅丁专丏)
        {
            System.Globalization.CultureInfo val_1 = Infrastructure.丑不丅丘七与不丑三.丙专丝世不业下丂丈();
            UnityEngine.PlayerPrefs.SetString(key:  "InAppReview.Requested", value:  丑丙万一丏丅丁专丏.dateData);
        }
    
    }

}
