using UnityEngine;

namespace PGCompany
{
    public class MobileOperatorBillingWindow : BannerWindow
    {
        // Fields
        internal static readonly string 丒丏丞专七丕专业丈;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static bool 丂丙上且不丟业丛丒()
        {
            var val_20;
            var val_21;
            string val_22;
            if(UnityEngine.Application.isEditor != true)
            {
                    if(UnityEngine.Application.platform != 8)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(BalanceController.七专丑万专丗七东上() == false)
            {
                    return (bool)0 & 1;
            }
            
            val_20 = ExperienceController.丞丞丘业东丙丏七丌();
            if(val_20 >= BalanceController.丄下丛丅丒丙丞不丙())
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_13;
            }
            
            }
            
            return (bool)0 & 1;
            label_13:
            if(BalanceController.丂上丕丞世三丂且专() == 0)
            {
                goto label_16;
            }
            
            label_39:
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  80)) == 0)
            {
                    return (bool)0 & 1;
            }
            
            东下丙丆业与万丂丐 val_11 = BalanceController.丟丑业万一一专丕丝();
            bool val_12 = 与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专();
            var val_13 = (val_11 == 0) ? 1 : 0;
            var val_14 = (val_11 != 1) ? 1 : 0;
            val_13 = val_13 & val_12;
            val_14 = val_14 | val_12;
            val_13 = val_13 ^ val_14;
            if(val_13 == false)
            {
                    return (bool)0 & 1;
            }
            
            val_21 = null;
            bool val_16 = PGCompany.MobileOperatorBillingWindow.丑丘一丌丄丅丝下丆() ^ 1;
            return (bool)0 & 1;
            label_16:
            System.String[] val_17 = 上三丗丒与一丆丌丏.丆丒世丛丁下丁上丄();
            if(val_17 == null)
            {
                    return (bool)0 & 1;
            }
            
            System.Collections.Generic.List<System.String> val_18 = BalanceController.丈一七且丗丈丄丕不();
            if((val_18 == null) || (val_17.Length < 1))
            {
                    return (bool)0 & 1;
            }
            
            label_40:
            long val_21 = 0;
            val_22 = val_17[val_21];
            if(val_22 == null)
            {
                goto label_37;
            }
            
            if(val_21 >= val_17.Length)
            {
                    val_22 = mem[val_17[0x0] + 32];
                val_22 = val_17[0x0] + 32;
            }
            
            if((val_18.Contains(item:  val_22)) == true)
            {
                goto label_39;
            }
            
            label_37:
            val_21 = val_21 + 1;
            if(val_21 < val_17.Length)
            {
                goto label_40;
            }
            
            return (bool)0 & 1;
        }
        private static bool 丑丘一丌丄丅丝下丆()
        {
            return (bool)((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  79)) == 1) ? 1 : 0;
        }
        public void HandleGoToBillingSettings()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            UnityEngine.Application.OpenURL(url:  "https://apps.apple.com/account/billing");
            this.HideSelf();
        }
        public void HideWindow()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.丑丂丒上东丙丟丕三();
            new System.Action() = new System.Action(object:  this, method:  public System.Void BannerWindow::HideSelf());
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                    return;
            }
            
            this = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            this.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  79, 丙业与丙丗丝不丈东:  1);
        }
        protected override void OnDisable()
        {
            this.丑丂丒上东丙丟丕三();
            this.OnDisable();
        }
        private void 丑丂丒上东丙丟丕三()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        public MobileOperatorBillingWindow()
        {
        
        }
        private static MobileOperatorBillingWindow()
        {
            PGCompany.MobileOperatorBillingWindow.丒丏丞专七丕专业丈 = "MobileOperatorBillingWindow.BankShownKey";
        }
    
    }

}
