using UnityEngine;

namespace PGCompany
{
    internal class 丅丗且下丈业丌与丞
    {
        // Fields
        private static PGCompany.丅丗且下丈业丌与丞 丝业丆丁业三丈丟东;
        internal static bool 丝东三丂丗一专与丗;
        internal static string 丝丘丏丄上丝与丅丆;
        internal bool 业上万不上丂不世万;
        internal int 丗丒丂丐丟不世丄丄;
        internal int 业三丁且丝下丈丈丗;
        internal System.Version 丆丌专丟业丁专丟丌;
        private bool 丙丘不丏丘丈丏与丞;
        private System.Version 丕丈丏下上三丛丛丏;
        
        // Properties
        internal static PGCompany.丅丗且下丈业丌与丞 丆丕丝丒不丙且丐丗 { get; }
        private string 世丛丞下丞丙丄七专 { get; }
        private string 专丛丌丙丏上丄丗丆 { get; }
        private string 丞丈七丅上丅丅丝丏 { get; }
        
        // Methods
        internal static PGCompany.丅丗且下丈业丌与丞 丑七不且上丗丁一世()
        {
            var val_2;
            PGCompany.丅丗且下丈业丌与丞 val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.丅丗且下丈业丌与丞.丝业丆丁业三丈丟东;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.丅丗且下丈业丌与丞 val_1 = null;
            val_3 = val_1;
            val_1 = new PGCompany.丅丗且下丈业丌与丞();
            val_4 = null;
            val_4 = null;
            PGCompany.丅丗且下丈业丌与丞.丝业丆丁业三丈丟东 = val_3;
            return val_3;
        }
        internal 丅丗且下丈业丌与丞()
        {
            this.不丈上丘七上丄丌丌();
            IDFAPermissionsPlugin.add_ClosedIdfaBanner(value:  new System.Action<IdfaBannerResult>(object:  this, method:  System.Void PGCompany.丅丗且下丈业丌与丞::丄与专丁丄丁丘丆丑(IdfaBannerResult 丘丘丌七业丆七七丂)));
        }
        private string 七丗三与业万三东丁()
        {
            return "IosIdfaBannerController.shown-at-start";
        }
        private string 下丐丑万东丞丈丁丘()
        {
            return "IosIdfaBannerController.rejects-count";
        }
        private string 丏丝上丘下三丒不万()
        {
            return "IosIdfaBannerController.cooldown-end";
        }
        internal bool 三专丆上丞万上丒丑()
        {
            var val_7;
            if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == false)
            {
                goto label_3;
            }
            
            if(IDFAPermissionsPlugin.CanShowIDFADialog() == true)
            {
                goto label_6;
            }
            
            goto label_11;
            label_3:
            if((IDFAPermissionsPlugin.CanShowIDFADialog() == false) || (this.丒丆丛下丒与丆丝专() == false))
            {
                goto label_11;
            }
            
            val_7 = 0;
            if((UnityEngine.PlayerPrefs.GetInt(key:  "IosIdfaBannerController.shown-at-start", defaultValue:  0)) == 1)
            {
                    return (bool)val_7;
            }
            
            label_6:
            var val_6 = (this.丙丘不丏丘丈丏与丞 == false) ? 1 : 0;
            return (bool)val_7;
            label_11:
            val_7 = 0;
            return (bool)val_7;
        }
        internal void 专业丒且专丗万上丈()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "IosIdfaBannerController.shown-at-start", value:  1);
            this.丙丘不丏丘丈丏与丞 = true;
        }
        internal void 业上三丞丕丂上业东()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            UnityEngine.PlayerPrefs.SetInt(key:  "IosIdfaBannerController.cooldown-end", value:  (丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_1.dateData})) + this.丗丒丂丐丟不世丄丄);
        }
        internal void 丈丏丟下丄七丂专丁()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  "IosIdfaBannerController.rejects-count", value:  (UnityEngine.PlayerPrefs.GetInt(key:  "IosIdfaBannerController.rejects-count", defaultValue:  0)) + 1);
        }
        private int 世万丁且丟丈且丛世()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  "IosIdfaBannerController.cooldown-end", defaultValue:  0);
        }
        private int 三丟丞不丙丆三业丌()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  "IosIdfaBannerController.rejects-count", defaultValue:  0);
        }
        private void 丄上三世下丞丐丈丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丒专一丄七丒丝与专(丘丒丅三丞丞丛丛丌:  0);
        }
        private void 丁丙下丄上业丘不丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丒专一丄七丒丝与专(丘丒丅三丞丞丛丛丌:  0);
        }
        internal void 丒专一丄七丒丝与专(Rilisoft.BankBannersHolder 丘丒丅三丞丞丛丛丌)
        {
            UnityEngine.Object val_15;
            var val_16;
            var val_17;
            if(MainStoreView.丈丐丞丐上丑且丕万() == true)
            {
                    return;
            }
            
            val_15 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_15 != 0)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
            {
                    return;
            }
            
            val_15 = 1152921505205194752;
            val_16 = null;
            val_16 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 != null)
            {
                    if(GiftController.丆丕丝丒不丙且丐丗.丑丈丑丘下丟丐与万() != false)
            {
                    return;
            }
            
            }
            
            if(IDFAPermissionsPlugin.CanShowIDFADialog() == false)
            {
                goto label_19;
            }
            
            val_17 = 0;
            if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == true)
            {
                goto label_17;
            }
            
            val_17 = this;
            bool val_8 = this.丒丆丛下丒与丆丝专();
            if(val_8 == false)
            {
                goto label_19;
            }
            
            label_17:
            int val_9 = val_8.三丟丞不丙丆三业丌();
            if(val_9 >= this.业三丁且丝下丈丈丗)
            {
                goto label_19;
            }
            
            System.DateTime val_11 = System.DateTime.UtcNow;
            if((丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_11.dateData})) < (val_9.世万丁且丟丈且丛世() << ))
            {
                    return;
            }
            
            if(丘丒丅三丞丞丛丛丌 == 0)
            {
                goto label_27;
            }
            
            丘丒丅三丞丞丛丛丌.ShowBanner(丌丅丕一丛丛丄一万:  0, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return;
            label_19:
            this.万七丟不世丆丈丏下();
            return;
            label_27:
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        private bool 丒丆丛下丒与丆丝专()
        {
            if(UnityEngine.Application.platform != 8)
            {
                    return false;
            }
            
            if((System.Version.op_Equality(v1:  this.丆丌专丟业丁专丟丌, v2:  0)) != false)
            {
                    return false;
            }
            
            this.丆丅一丛丕丐七丛丗();
            if((System.Version.op_Equality(v1:  this.丕丈丏下上三丛丛丏, v2:  0)) == false)
            {
                    return System.Version.op_GreaterThanOrEqual(v1:  this.丕丈丏下上三丛丛丏, v2:  this.丆丌专丟业丁专丟丌);
            }
            
            return false;
        }
        private void 丆丅一丛丕丐七丛丗()
        {
            bool val_1 = System.Version.op_Inequality(v1:  this.丕丈丏下上三丛丛丏, v2:  0);
        }
        private void 不丈上丘七上丄丌丌()
        {
            PGCompany.Ads.丒三丕三上丟与丈丆.丑七不且上丗丁一世().业丟丈下且东业不不(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.丅丗且下丈业丌与丞::丁丙下丄上业丘不丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            PGCompany.Ads.丒三丕三上丟与丈丆.丑七不且上丗丁一世().世丟丂丅下上丞一且(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.丅丗且下丈业丌与丞::丄上三世下丞丐丈丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 万七丟不世丆丈丏下()
        {
            PGCompany.Ads.丒三丕三上丟与丈丆.丑七不且上丗丁一世().专东丙丗七丁丄丛丂(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.丅丗且下丈业丌与丞::丁丙下丄上业丘不丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            PGCompany.Ads.丒三丕三上丟与丈丆.丑七不且上丗丁一世().丟丌专上丑丅丆丝丁(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.丅丗且下丈业丌与丞::丄上三世下丞丐丈丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 丄与专丁丄丁丘丆丑(IdfaBannerResult 丘丘丌七业丆七七丂)
        {
            this.丐丑且上下与丆丂与(丗丞丁业丌与丐丛一:  1, 世丞丆丙丁丁丑丅丏:  丘丘丌七业丆七七丂);
        }
        internal void 丐丑且上下与丆丂与(int 丗丞丁业丌与丐丛一, int 世丞丆丙丁丁丑丅丏)
        {
            null = null;
            PGCompany.Analytics.一业丗丆世世上丁且.下丑七不丝下七不上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丅丁且丕丕丁丅下丁:  (PGCompany.丅丗且下丈业丌与丞.丝东三丂丗一专与丗 == true) ? 0 : 丗丞丁业丌与丐丛一, 万丛丅丝丂三丆丏下:  世丞丆丙丁丁丑丅丏, 业万丐丒且丈丙一专:  "");
        }
        private static 丅丗且下丈业丌与丞()
        {
            PGCompany.丅丗且下丈业丌与丞.丝东三丂丗一专与丗 = true;
            PGCompany.丅丗且下丈业丌与丞.丝丘丏丄上丝与丅丆 = "Key_10505";
        }
    
    }

}
