using UnityEngine;

namespace Rilisoft
{
    public class SubscriptionEmailWindow : BannerWindow
    {
        // Fields
        public UILabel rewardEmailLabel;
        private System.IDisposable 丐丆七且丞丏下三丙;
        internal static string 三丈不丑丑丒丑专丅;
        private static bool 丕丄丆丄专丆丈丅丄;
        private static bool 一丟丁丅丌且丒丛上;
        
        // Properties
        internal static bool 丆不专丑丌与丒丂三 { get; set; }
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static bool 不七丘丁上不业丐专()
        {
            var val_4 = null;
            if(Rilisoft.SubscriptionEmailWindow.丕丄丆丄专丆丈丅丄 != true)
            {
                    val_4 = null;
                Rilisoft.SubscriptionEmailWindow.一丟丁丅丌且丒丛上 = ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  Rilisoft.SubscriptionEmailWindow.__il2cppRuntimeField_static_fields, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1) ? 1 : 0;
                Rilisoft.SubscriptionEmailWindow.丕丄丆丄专丆丈丅丄 = true;
            }
            
            val_4 = null;
            return (bool)Rilisoft.SubscriptionEmailWindow.一丟丁丅丌且丒丛上;
        }
        internal static void 与丒丛东七丈专且丒(bool 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  Rilisoft.SubscriptionEmailWindow.三丈不丑丑丒丑专丅, 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_4 = null;
            val_4 = null;
            Rilisoft.SubscriptionEmailWindow.丕丄丆丄专丆丈丅丄 = true;
            Rilisoft.SubscriptionEmailWindow.一丟丁丅丌且丒丛上 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == false)
            {
                    return;
            }
            
            Rilisoft.SubscriptionEmailErrorWindow.丈业丙丈丆丈丛丆专(丙业与丙丗丝不丈东:  false);
        }
        internal static bool 丂丙上且不丟业丛丒()
        {
            var val_5;
            var val_6;
            val_5 = null;
            if(Rilisoft.SubscriptionEmailWindow.不七丘丁上不业丐专() != false)
            {
                    if(AskNameManager.丟世丂且丝丞丄丗丂() == false)
            {
                goto label_6;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6;
            label_6:
            val_6 = (~(Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  33))) & 1;
            return (bool)val_6;
        }
        public void U_Accept()
        {
            丆与丞丈下丄丐专丛.丑七不且上丗丁一世().丌丑丈丟丝丙万丙丗();
            Rilisoft.SubscriptionEmailWindow.与丒丛东七丈专且丒(丙业与丙丗丝不丈东:  false);
            this.HideSelf();
            Rilisoft.一丟专且三万丞丁丂.专丕丒万业一丑丗丙(丝丏业丅丈东业丝丒:  "Get Reward");
        }
        protected override void OnEnable()
        {
            var val_7;
            var val_9;
            this.OnEnable();
            val_7 = null;
            val_7 = null;
            this.rewardEmailLabel.text = BalanceController.丟不丌七丝七东丞业.丟丂丞不专丆万丒世().ToString();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            Rilisoft.BackSystem val_4 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            val_9 = null;
            val_9 = null;
            if((SubscriptionEmailWindow.<>c.<>9__11_0) == null)
            {
                goto label_14;
            }
            
            label_20:
            this.丐丆七且丞丏下三丙 = val_4.Register(业丏丈世世世丞丒世:  SubscriptionEmailWindow.<>c.<>9__11_0, 与且专丈不万东一万:  0);
            return;
            label_14:
            SubscriptionEmailWindow.<>c.<>9__11_0 = new System.Action(object:  SubscriptionEmailWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SubscriptionEmailWindow.<>c::丈丆丄三与丁丟丟丞());
            if(val_4 != null)
            {
                goto label_20;
            }
            
            goto label_20;
        }
        protected override void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.OnDisable();
        }
        public SubscriptionEmailWindow()
        {
        
        }
        private static SubscriptionEmailWindow()
        {
            Rilisoft.SubscriptionEmailWindow.三丈不丑丑丒丑专丅 = "SubscriptionEmailWindowKey";
            Rilisoft.SubscriptionEmailWindow.丕丄丆丄专丆丈丅丄 = false;
        }
    
    }

}
