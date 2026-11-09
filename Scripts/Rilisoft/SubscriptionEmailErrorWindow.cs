using UnityEngine;

namespace Rilisoft
{
    public class SubscriptionEmailErrorWindow : BannerWindow
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        internal static string 三丈不丑丑丒丑专丅;
        private static bool 丕丄丆丄专丆丈丅丄;
        private static bool 一丟丁丅丌且丒丛上;
        
        // Properties
        internal static bool 丕世一与业丅万专丑 { get; set; }
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static bool 丌七丘七丗下丐七丞()
        {
            null = null;
            return (bool)Rilisoft.SubscriptionEmailErrorWindow.一丟丁丅丌且丒丛上;
        }
        internal static void 丈业丙丈丆丈丛丆专(bool 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.SubscriptionEmailErrorWindow.一丟丁丅丌且丒丛上 = 丙业与丙丗丝不丈东;
        }
        internal static bool 丂丙上且不丟业丛丒()
        {
            var val_5;
            var val_6;
            val_5 = null;
            if(Rilisoft.SubscriptionEmailErrorWindow.丌七丘七丗下丐七丞() != false)
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
            Rilisoft.SubscriptionEmailErrorWindow.丈业丙丈丆丈丛丆专(丙业与丙丗丝不丈东:  false);
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            var val_6;
            this.OnEnable();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            Rilisoft.BackSystem val_2 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            val_6 = null;
            val_6 = null;
            if((SubscriptionEmailErrorWindow.<>c.<>9__10_0) == null)
            {
                goto label_10;
            }
            
            label_16:
            this.丐丆七且丞丏下三丙 = val_2.Register(业丏丈世世世丞丒世:  SubscriptionEmailErrorWindow.<>c.<>9__10_0, 与且专丈不万东一万:  0);
            return;
            label_10:
            SubscriptionEmailErrorWindow.<>c.<>9__10_0 = new System.Action(object:  SubscriptionEmailErrorWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SubscriptionEmailErrorWindow.<>c::丁丄专丛不不丟一东());
            if(val_2 != null)
            {
                goto label_16;
            }
            
            goto label_16;
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
        public SubscriptionEmailErrorWindow()
        {
        
        }
        private static SubscriptionEmailErrorWindow()
        {
            Rilisoft.SubscriptionEmailErrorWindow.三丈不丑丑丒丑专丅 = "SubscriptionEmailWindowKey";
            Rilisoft.SubscriptionEmailErrorWindow.丕丄丆丄专丆丈丅丄 = false;
        }
    
    }

}
