using UnityEngine;

namespace Rilisoft
{
    public class AutofireWelcomeWindow : BannerWindow
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static bool 丂丙上且不丟业丛丒()
        {
            return false;
        }
        public void EnableAutofire()
        {
            bool val_1 = 与丂丏丛丞丞丒丟丄.三上丕丟丛世世专丁();
            val_1 = (~val_1) & 1;
            与丂丏丛丞丞丒丟丄.与丟丂三丄丄丒下三(丙业与丙丗丝不丈东:  val_1);
            PGCompany.Analytics.一业丗丆世世上丁且.丒专丕东万业丆专东(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丝三丄专丗丞丄丄丌:  与丂丏丛丞丞丒丟丄.三上丕丟丛世世专丁(), 丁丅丈丌丟世丗丗丟:  "Autofire", 丑东与丅丐丅丂丞业:  "Banner");
        }
        public void EnableTargetting()
        {
            bool val_1 = 与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且();
            val_1 = (~val_1) & 1;
            与丂丏丛丞丞丒丟丄.且丒丅丘丝上丏丒丏(丙业与丙丗丝不丈东:  val_1);
            PGCompany.Analytics.一业丗丆世世上丁且.丒专丕东万业丆专东(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丝三丄专丗丞丄丄丌:  与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且(), 丁丅丈丌丟世丗丗丟:  "Autoaim", 丑东与丅丐丅丂丞业:  "Banner");
        }
        public override void Show()
        {
            this.Show();
            与丂丏丛丞丞丒丟丄.与丟丂三丄丄丒下三(丙业与丙丗丝不丈东:  true);
            与丂丏丛丞丞丒丟丄.且丒丅丘丝上丏丒丏(丙业与丙丗丝不丈东:  true);
        }
        public void HideWindow()
        {
            goto typeof(Rilisoft.AutofireWelcomeWindow).__il2cppRuntimeField_208;
        }
        public override void HideSelf()
        {
            this.HideSelf();
            与丂丏丛丞丞丒丟丄.东上丕专丟业丑丅上(丙业与丙丗丝不丈东:  true);
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
            if((AutofireWelcomeWindow.<>c.<>9__8_0) == null)
            {
                goto label_10;
            }
            
            label_16:
            this.丐丆七且丞丏下三丙 = val_2.Register(业丏丈世世世丞丒世:  AutofireWelcomeWindow.<>c.<>9__8_0, 与且专丈不万东一万:  0);
            return;
            label_10:
            AutofireWelcomeWindow.<>c.<>9__8_0 = new System.Action(object:  AutofireWelcomeWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AutofireWelcomeWindow.<>c::丕丐不一不三业东万());
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
        public AutofireWelcomeWindow()
        {
        
        }
    
    }

}
