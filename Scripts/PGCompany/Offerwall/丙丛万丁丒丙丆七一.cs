using UnityEngine;

namespace PGCompany.Offerwall
{
    internal sealed class 丙丛万丁丒丙丆七一
    {
        // Fields
        private static PGCompany.Offerwall.丙丛万丁丒丙丆七一 世丒丞七专三与万丕;
        private PGCompany.Offerwall.丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒 丐丒丈东世丕丗与丆;
        
        // Properties
        internal static PGCompany.Offerwall.丙丛万丁丒丙丆七一 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        private 丙丛万丁丒丙丆七一()
        {
        
        }
        internal static PGCompany.Offerwall.丙丛万丁丒丙丆七一 丑七不且上丗丁一世()
        {
            if(PGCompany.Offerwall.丙丛万丁丒丙丆七一.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            PGCompany.Offerwall.丙丛万丁丒丙丆七一 val_1 = PGCompany.Offerwall.丙丛万丁丒丙丆七一.东丝七业丄丑丒世七();
            PGCompany.Offerwall.丙丛万丁丒丙丆七一.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        internal void 丆业不丐丟上下丁丞(PGCompany.Offerwall.丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒 与丙丛丁三丞丆丟丐)
        {
            var val_1 = (与丙丛丁三丞丆丟丐 == 0) ? 0 : (this);
            if(与丙丛丁三丞丆丟丐 != null)
            {
                    mem2[0] = 与丙丛丁三丞丆丟丐;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "creditsListener");
        }
        internal void 一上不丏丕丄丏丞不()
        {
            this.丐丒丈东世丕丗与丆 = 0;
        }
        private static PGCompany.Offerwall.丙丛万丁丒丙丆七一 东丝七业丄丑丒世七()
        {
            PGCompany.Offerwall.丙丛万丁丒丙丆七一 val_1 = new PGCompany.Offerwall.丙丛万丁丒丙丆七一();
            IronSourceEvents.add_onOfferwallAdCreditedEvent(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  val_1, method:  System.Void PGCompany.Offerwall.丙丛万丁丒丙丆七一::丑丟丘与丞丙丝丟七(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)));
            IronSourceEvents.add_onGetOfferwallCreditsFailedEvent(丙业与丙丗丝不丈东:  new System.Action<丒丁丐丆丁丐丙且上>(object:  val_1, method:  System.Void PGCompany.Offerwall.丙丛万丁丒丙丆七一::不丂丝丏三丛丛万丂(丒丁丐丆丁丐丙且上 丂七东不不丈一丐不)));
            return val_1;
        }
        private void 丑丟丘与丞丙丝丟七(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)
        {
            object val_5;
            if(PGCompany.Offerwall.丙丛万丁丒丙丆七一.世丈且业丆丑丏丐一() != false)
            {
                    object[] val_3 = new object[5];
                val_3[0] = "OfferwallEventProxy.OnOfferwallAdCredited";
                val_3[1] = "_creditsListener";
                val_3[2] = this.丐丒丈东世丕丗与丆;
                val_3[3] = "dictionary";
                val_3[4] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  万丝且丘不丑丝下丑);
                val_5 = System.String.Format(format:  "[{0}] {1}: {2}, {3}: {4}", args:  val_3);
                UnityEngine.Debug.Log(message:  val_5);
            }
            else
            {
                    this = this.丐丒丈东世丕丗与丆;
            }
            
            if(mem[this.丐丒丈东世丕丗与丆] == 0)
            {
                    return;
            }
            
            mem[this.丐丒丈东世丕丗与丆].丑丟丘与丞丙丝丟七(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑);
        }
        private void 不丂丝丏三丛丛万丂(丒丁丐丆丁丐丙且上 丂七东不不丈一丐不)
        {
            object val_4;
            if(PGCompany.Offerwall.丙丛万丁丒丙丆七一.世丈且业丆丑丏丐一() != false)
            {
                    object[] val_2 = new object[5];
                val_2[0] = "OfferwallEventProxy.OnGetOfferwallCreditsFailed";
                val_2[1] = "_creditsListener";
                val_2[2] = this.丐丒丈东世丕丗与丆;
                val_2[3] = "error";
                val_2[4] = 丂七东不不丈一丐不;
                val_4 = System.String.Format(format:  "[{0}] {1}: {2}, {3}: {4}", args:  val_2);
                UnityEngine.Debug.Log(message:  val_4);
            }
            else
            {
                    this = this.丐丒丈东世丕丗与丆;
            }
            
            if(mem[this.丐丒丈东世丕丗与丆] == 0)
            {
                    return;
            }
            
            mem[this.丐丒丈东世丕丗与丆].不丂丝丏三丛丛万丂(丂七东不不丈一丐不:  丂七东不不丈一丐不);
        }
    
    }

}
