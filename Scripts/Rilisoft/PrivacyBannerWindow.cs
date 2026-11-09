using UnityEngine;

namespace Rilisoft
{
    internal sealed class PrivacyBannerWindow : BannerWindow
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UILabel _versionLabel;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static bool 丂丙上且不丟业丛丒()
        {
            string val_6;
            var val_7;
            var val_8;
            if(Rilisoft.世一丞三丈丂丄丌丆.七丂丑七丑世丂不丒() == false)
            {
                goto label_3;
            }
            
            label_15:
            val_7 = 0;
            return (bool)val_7;
            label_3:
            val_8 = null;
            val_8 = null;
            val_6 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐丕万七万丏一丅丟);
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true) || ((System.String.op_Inequality(a:  val_6, b:  "EU")) == false))
            {
                goto label_12;
            }
            
            Rilisoft.世一丞三丈丂丄丌丆.上且丁丛丙丞丌一丄();
            goto label_15;
            label_12:
            val_7 = (~AskNameManager.丟世丂且丝丞丄丗丂()) & 1;
            return (bool)val_7;
        }
        public override void Show()
        {
            var val_3;
            this.Show();
            val_3 = null;
            val_3 = null;
            this._versionLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5467"), arg0:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
        }
        public override void HideSelf()
        {
            Rilisoft.世一丞三丈丂丄丌丆.上且丁丛丙丞丌一丄();
            this.HideSelf();
        }
        public void U_ShowPrivatePolicy()
        {
            null = null;
            UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.不丝东丑丐与丂丙丆);
        }
        public void U_ShowTermsOfUse()
        {
            null = null;
            UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.丙且丛丄丈丗上丙丄);
        }
        public void U_Accept()
        {
            goto typeof(Rilisoft.PrivacyBannerWindow).__il2cppRuntimeField_208;
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
            if((PrivacyBannerWindow.<>c.<>9__9_0) == null)
            {
                goto label_10;
            }
            
            label_16:
            this.丐丆七且丞丏下三丙 = val_2.Register(业丏丈世世世丞丒世:  PrivacyBannerWindow.<>c.<>9__9_0, 与且专丈不万东一万:  0);
            return;
            label_10:
            PrivacyBannerWindow.<>c.<>9__9_0 = new System.Action(object:  PrivacyBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PrivacyBannerWindow.<>c::一业丛丕丟丘下丅丑());
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
        public PrivacyBannerWindow()
        {
        
        }
    
    }

}
