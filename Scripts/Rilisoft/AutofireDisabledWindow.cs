using UnityEngine;

namespace Rilisoft
{
    public class AutofireDisabledWindow : BannerWindow
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static bool 丂丙上且不丟业丛丒()
        {
            var val_4;
            if(与丂丏丛丞丞丒丟丄.世丒丗丘专七不丗丂() != false)
            {
                    val_4 = 0;
            }
            else
            {
                    bool val_2 = 与丂丏丛丞丞丒丟丄.东且丙七与丒丒万丘();
                val_4 = val_2 ^ 1;
            }
            
            val_2 = val_4;
            return (bool)val_2;
        }
        public override void Show()
        {
            this.Show();
        }
        public void HideWindow()
        {
            goto typeof(Rilisoft.AutofireDisabledWindow).__il2cppRuntimeField_208;
        }
        public override void HideSelf()
        {
            this.HideSelf();
            与丂丏丛丞丞丒丟丄.丁万三七丆丐上丏丑(丙业与丙丗丝不丈东:  true);
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
            if((AutofireDisabledWindow.<>c.<>9__6_0) == null)
            {
                goto label_10;
            }
            
            label_16:
            this.丐丆七且丞丏下三丙 = val_2.Register(业丏丈世世世丞丒世:  AutofireDisabledWindow.<>c.<>9__6_0, 与且专丈不万东一万:  0);
            return;
            label_10:
            AutofireDisabledWindow.<>c.<>9__6_0 = new System.Action(object:  AutofireDisabledWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AutofireDisabledWindow.<>c::丞丐丙丄三丐不丂上());
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
        public AutofireDisabledWindow()
        {
        
        }
    
    }

}
