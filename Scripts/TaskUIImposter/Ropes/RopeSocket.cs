using UnityEngine;

namespace TaskUIImposter.Ropes
{
    internal class RopeSocket : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UIBasicSprite> _colorSprites;
        private string <丄丟丒丁丒不丗与不>k__BackingField;
        
        // Properties
        internal string SocketName { get; set; }
        
        // Methods
        internal string 丞丘丁不东上丁丕七()
        {
            return (string)this.<丄丟丒丁丒不丗与不>k__BackingField;
        }
        private void 丑丝丒丄七业丛丗东(string 丙业与丙丗丝不丈东)
        {
            this.<丄丟丒丁丒不丗与不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
        {
            List.Enumerator<T> val_1 = this._colorSprites.GetEnumerator();
            label_7:
            if((1924662776 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.<丄丟丒丁丒不丗与不>k__BackingField = 丑丞丈丗丄丙丟万丄.r;
        }
        public RopeSocket()
        {
        
        }
    
    }

}
