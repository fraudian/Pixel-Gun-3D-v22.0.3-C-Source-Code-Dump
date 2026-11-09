using UnityEngine;

namespace PGCompany
{
    public class IosIdfaPermission : BannerWindow
    {
        // Fields
        internal static bool 丅业东万丌丕上丌丄;
        private UILabel bannerTxtLabel;
        
        // Methods
        protected override void OnEnable()
        {
            var val_1;
            this.OnEnable();
            val_1 = null;
            val_1 = null;
            PGCompany.IosIdfaPermission.丅业东万丌丕上丌丄 = true;
        }
        protected override void OnDisable()
        {
            var val_1;
            this.OnDisable();
            val_1 = null;
            val_1 = null;
            PGCompany.IosIdfaPermission.丅业东万丌丕上丌丄 = false;
        }
        public override void Show()
        {
            this.Show();
            PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世().专业丒且专丗万上丈();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.bannerTxtLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  PGCompany.丅丗且下丈业丌与丞.丝丘丏丄上丝与丅丆));
            if(PGCompany.丅丗且下丈业丌与丞.丝东三丂丗一专与丗 == false)
            {
                    return;
            }
            
            this.HideSelf();
            IDFAPermissionsPlugin.RequestPermissionForIDFA();
        }
        public void U_No()
        {
            var val_2;
            PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
            if(val_2 != false)
            {
                    PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世().业上三丞丕丂上业东();
                PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世().丈丏丟下丄七丂专丁();
            }
            
            PGCompany.丅丗且下丈业丌与丞.丑七不且上丗丁一世().丐丑且上下与丆丂与(丗丞丁业丌与丐丛一:  0, 世丞丆丙丁丁丑丅丏:  0);
            this.HideSelf();
        }
        public void U_Yes()
        {
            IDFAPermissionsPlugin.RequestPermissionForIDFA();
            this.HideSelf();
        }
        public IosIdfaPermission()
        {
        
        }
        private static IosIdfaPermission()
        {
        
        }
    
    }

}
