using UnityEngine;

namespace PGCompany
{
    internal sealed class LabelColorSelector : MonoBehaviour
    {
        // Fields
        private UILabel text;
        private UISprite background;
        private UnityEngine.Color32 primaryTextColor;
        private UnityEngine.Color32 primaryBackgroundColor;
        private UnityEngine.Color32 secondaryTextColor;
        private UnityEngine.Color32 secondaryBackgroundColor;
        
        // Methods
        internal void 三丑东上三不丑七业(UnityEngine.Color32 丏与丐且丏丘下东上, UnityEngine.Color32 丁丙丏丙上丌丄丗丈)
        {
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 丏与丐且丏丘下东上.r & 4294967295, g = 丏与丐且丏丘下东上.r & 4294967295, b = 丏与丐且丏丘下东上.r & 4294967295, a = 丏与丐且丏丘下东上.r & 4294967295});
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.text, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 丁丙丏丙上丌丄丗丈.r & 4294967295, g = 丁丙丏丙上丌丄丗丈.r & 4294967295, b = 丁丙丏丙上丌丄丗丈.r & 4294967295, a = 丁丙丏丙上丌丄丗丈.r & 4294967295});
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.background, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        }
        internal void 三丑东上三不丑七业(int 与不丘丗东丆世丌丛)
        {
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryTextColor : this.secondaryTextColor, g = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryTextColor : this.secondaryTextColor, b = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryTextColor : this.secondaryTextColor, a = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryTextColor : this.secondaryTextColor});
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.text, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryBackgroundColor : this.secondaryBackgroundColor, g = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryBackgroundColor : this.secondaryBackgroundColor, b = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryBackgroundColor : this.secondaryBackgroundColor, a = ((与不丘丗东丆世丌丛 & 1) != 0) ? this.primaryBackgroundColor : this.secondaryBackgroundColor});
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.background, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        }
        public LabelColorSelector()
        {
        
        }
    
    }

}
