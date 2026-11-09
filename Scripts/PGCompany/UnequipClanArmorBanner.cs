using UnityEngine;

namespace PGCompany
{
    public class UnequipClanArmorBanner : BannerWindow
    {
        // Fields
        private static System.Action 丈一世三与专三专丛;
        private UITextureMasked oldArmor;
        private UITextureMasked newArmor;
        private UILabel reason;
        private UILabel equippedArmorText;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        internal static void 丑丗专丄丄丁丆丝丁(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.UnequipClanArmorBanner.丈一世三与专三专丛, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丛丌丞丑东丌丁上万(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.UnequipClanArmorBanner.丈一世三与专三专丛, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static bool 丂丙上且不丟业丛丒()
        {
            var val_5;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                    return (bool)(东不丞丄三世丟一丂.丑七不且上丗丁一世().专丑丑丙业下丑且下() != 0) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)(东不丞丄三世丟一丂.丑七不且上丗丁一世().专丑丑丙业下丑且下() != 0) ? 1 : 0;
        }
        public void HideWindow()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(东不丞丄三世丟一丂.丑七不且上丗丁一世().专丑丑丙业下丑且下() == null)
            {
                    UnityEngine.Debug.LogErrorFormat(format:  "bannerParams == null on show", args:  System.Array.Empty<System.Object>());
                this.HideSelf();
            }
            
            string val_4 = 七丌丞万七万丁丐丙.一丌且丑丕丅丝上丆(丕下三丗三丗丘丆丘:  val_2.不上丛丁三与上专与);
            string val_5 = 七丌丞万七万丁丐丙.一丌且丑丕丅丝上丆(丕下三丗三丗丘丆丘:  val_2.与不丁丂丙七丏丌七);
            UnityEngine.Texture val_6 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_4, 七丆丒与丗丌丄且丂:  7, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            UnityEngine.Texture val_7 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_5, 七丆丒与丗丌丄且丂:  7, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            if(val_2.专专丐丏万丄上丆丌 != 1)
            {
                    string val_11 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9152"), arg0:  丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_2.丒丙下丂丕丞万万丕), arg1:  丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_4, 七丆丒与丗丌丄且丂:  7));
            }
            
            this.reason.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9150");
            this.equippedArmorText.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9151"), arg0:  丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_5, 七丆丒与丗丌丄且丂:  7));
            if(PGCompany.UnequipClanArmorBanner.丈一世三与专三专丛 == null)
            {
                    return;
            }
            
            PGCompany.UnequipClanArmorBanner.丈一世三与专三专丛.Invoke();
        }
        public UnequipClanArmorBanner()
        {
        
        }
    
    }

}
