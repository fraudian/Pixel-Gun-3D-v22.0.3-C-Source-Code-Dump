using UnityEngine;

namespace PGCompany.Offerwall
{
    internal sealed class 丙不三丁一丏丐丆与
    {
        // Fields
        private static PGCompany.Offerwall.丙不三丁一丏丐丆与 世丒丞七专三与万丕;
        
        // Properties
        internal static PGCompany.Offerwall.丙不三丁一丏丐丆与 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        private 丙不三丁一丏丐丆与()
        {
        
        }
        internal static PGCompany.Offerwall.丙不三丁一丏丐丆与 丑七不且上丗丁一世()
        {
            if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            PGCompany.Offerwall.丙不三丁一丏丐丆与 val_1 = PGCompany.Offerwall.丙不三丁一丏丐丆与.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "Instance");
            PGCompany.Offerwall.丙不三丁一丏丐丆与.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private static PGCompany.Offerwall.丙不三丁一丏丐丆与 东丝七业丄丑丒世七(string 与丗丆丏丙丟与丒业 = "")
        {
            if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallFacade.Create] caller: "("[OfferwallFacade.Create] caller: ") + 与丗丆丏丙丟与丒业);
            }
            
            PGCompany.Offerwall.丙不三丁一丏丐丆与 val_3 = new PGCompany.Offerwall.丙不三丁一丏丐丆与();
            IronSourceEvents.add_onOfferwallOpenedEvent(丙业与丙丗丝不丈东:  new System.Action(object:  val_3, method:  System.Void PGCompany.Offerwall.丙不三丁一丏丐丆与::丁丐丁丈丒丗一东丄()));
            IronSourceEvents.add_onOfferwallClosedEvent(丙业与丙丗丝不丈东:  new System.Action(object:  val_3, method:  System.Void PGCompany.Offerwall.丙不三丁一丏丐丆与::万丅丘丒丈上下东丆()));
            IronSourceEvents.add_onOfferwallShowFailedEvent(丙业与丙丗丝不丈东:  new System.Action<丒丁丐丆丁丐丙且上>(object:  val_3, method:  System.Void PGCompany.Offerwall.丙不三丁一丏丐丆与::丟一丁丞丈东万不业(丒丁丐丆丁丐丙且上 丂七东不不丈一丐不)));
            return val_3;
        }
        internal static void 东丕丝世丑丈丞丄丁()
        {
            if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丒丞七专三与万丕 != null)
            {
                    return;
            }
            
            PGCompany.Offerwall.丙不三丁一丏丐丆与.世丒丞七专三与万丕 = PGCompany.Offerwall.丙不三丁一丏丐丆与.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "EnsureInitialized");
        }
        internal bool 丝丂专上且丄专丏且(out string 丏丞专丏业丗丝七丝)
        {
            if(PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丝丂专上且丄专丏且() == false)
            {
                    return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "IsOfferwallAvailable: false", 丄丙下丝丛丒七丂丘: out  string val_3 = 丏丞专丏业丗丝七丝);
            }
            
            return PGCompany.丙丁东丅丒上世与东.丏丙丑丑丘丛丏丗丛(丞丅上丏丂且下丅与: out  val_3);
        }
        internal bool 丗丏世丕丌三上丝丅(out string 丏丞专丏业丗丝七丝)
        {
            string val_13;
            string val_4 = 0;
            string val_1 = 0;
            if((PGCompany.丙丁东丅丒上世与东.丏丙丑丑丘丛丏丗丛(丞丅上丏丂且下丅与: out  val_1)) == false)
            {
                goto label_1;
            }
            
            if((PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丌丂丄丑丞丆上丐丘(丐丟一丗丒丟且丂上: out  val_4)) == false)
            {
                goto label_3;
            }
            
            if((System.String.op_Inequality(a:  val_1, b:  val_4)) == false)
            {
                goto label_4;
            }
            
            val_13 = "userId != initialUserId";
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_13 = "TryGetInitialUserId: false", 丄丙下丝丛丒七丂丘: out  string val_7 = 丏丞专丏业丗丝七丝);
            label_1:
            val_13 = "TryGetId: false";
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_13, 丄丙下丝丛丒七丂丘: out  val_7);
            label_3:
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_13, 丄丙下丝丛丒七丂丘: out  val_7);
            label_4:
            丄丞业丛丛业丝丅丒 val_10 = 丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒.东丝七业丄丑丒世七(万丄丅丝三丈丆世丟:  val_1, 与丗丆丏丙丟与丒业:  "TryGetOfferwallCredits");
            PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丟丝丗丞丑上三丌上();
            bool val_12 = PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_1, 丄丙下丝丛丒七丂丘: out  val_7);
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_13, 丄丙下丝丛丒七丂丘: out  val_7);
        }
        internal bool 丆一东万丞丗丐丗丆(string 三七一丁上且丐丝丌, out string 丏丞专丏业丗丝七丝)
        {
            string val_16;
            string val_17;
            string val_1 = 0;
            string val_4 = 0;
            if(三七一丁上且丐丝丌 == null)
            {
                goto label_1;
            }
            
            if((PGCompany.丙丁东丅丒上世与东.丏丙丑丑丘丛丏丗丛(丞丅上丏丂且下丅与: out  val_1)) == false)
            {
                goto label_2;
            }
            
            if((PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丌丂丄丑丞丆上丐丘(丐丟一丗丒丟且丂上: out  val_4)) == false)
            {
                goto label_4;
            }
            
            if((System.String.op_Inequality(a:  val_1, b:  val_4)) == false)
            {
                goto label_5;
            }
            
            val_16 = "userId != initialUserId";
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16 = "IsOfferwallAvailable: false", 丄丙下丝丛丒七丂丘: out  string val_11 = 丏丞专丏业丗丝七丝);
            label_2:
            val_16 = "TryGetId: false";
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
            label_4:
            val_16 = "TryGetInitialUserId: false";
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
            label_5:
            if(PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丝丂专上且丄专丏且() != false)
            {
                    丄丞业丛丛业丝丅丒 val_9 = 丙不三丁一丏丐丆与.丄丞业丛丛业丝丅丒.东丝七业丄丑丒世七(万丄丅丝三丈丆世丟:  val_1, 与丗丆丏丙丟与丒业:  "TryShowOfferwall");
                PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丐东丈一丈丕且丂东(三七一丁上且丐丝丌:  三七一丁上且丐丝丌);
                val_17 = val_1;
                bool val_12 = PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_17, 丄丙下丝丛丒七丂丘: out  val_11);
                return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
            }
            
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_16, 丄丙下丝丛丒七丂丘: out  val_11);
            label_1:
            System.ArgumentNullException val_15 = new System.ArgumentNullException(paramName:  "placementName");
        }
        private void 丁丐丁丈丒丗一东丄()
        {
            var val_3;
            var val_4;
            if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallFacade.OnOfferwallOpenedEvent]");
            }
            
            val_3 = null;
            val_3 = null;
            if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
            {
                    val_4 = null;
                val_4 = null;
                MenuBackgroundMusic.丌丂一丛下丒丞丛东.丌丄丏下七丁专丂世();
            }
            
            与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  false);
            if(PGCompany.OfferwallController.世丒丞七专三与万丕 == null)
            {
                    return;
            }
            
            PGCompany.OfferwallController.世丒丞七专三与万丕.SetShown();
        }
        private void 万丅丘丒丈上下东丆()
        {
            var val_7;
            var val_8;
            if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallFacade.OnOfferwallClosedEvent]");
            }
            
            val_7 = null;
            val_7 = null;
            if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
            {
                    val_8 = null;
                val_8 = null;
                MenuBackgroundMusic.丌丂一丛下丒丞丛东.三且世三丂七丐一丟();
            }
            
            与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  丛丌丙丂丑丞丂丏丟.丑上万丌丏上丌下三(丒丘丏上丙丟丑丕丈:  丛丌丙丂丑丞丂丏丟.丏丏丌丆丞丂丆不丗(), 专不三上丏专丄且丞:  true));
            InfoWindowController.万丝一丒丌且丛丌七(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4957"));
        }
        private void 丟一丁丞丈东万不业(丒丁丐丆丁丐丙且上 丂七东不不丈一丐不)
        {
            if(PGCompany.Offerwall.丙不三丁一丏丐丆与.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "OfferwallFacade.OnOfferwallShowFailedEvent", arg1:  "error", arg2:  丂七东不不丈一丐不));
        }
    
    }

}
