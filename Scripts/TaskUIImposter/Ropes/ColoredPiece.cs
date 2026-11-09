using UnityEngine;

namespace TaskUIImposter.Ropes
{
    internal abstract class ColoredPiece : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UIBasicSprite> _sprites;
        private UnityEngine.Color <丞丘且丁丙丑丐丞东>k__BackingField;
        
        // Properties
        internal UnityEngine.Color 丐丑不丝专七丞专丗 { get; set; }
        
        // Methods
        internal UnityEngine.Color 丂丈丙专丌丑一丐世()
        {
            return new UnityEngine.Color() {r = this.<丞丘且丁丙丑丐丞东>k__BackingField};
        }
        private void 丆专丒丕丟丞丅不丞(UnityEngine.Color 丙业与丙丗丝不丈东)
        {
            this.<丞丘且丁丙丑丐丞东>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921540890659332] = 丙业与丙丗丝不丈东.g;
            mem[1152921540890659336] = 丙业与丙丗丝不丈东.b;
            mem[1152921540890659340] = 丙业与丙丗丝不丈东.a;
        }
        internal void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
        {
            List.Enumerator<T> val_1 = this._sprites.GetEnumerator();
            label_7:
            if((1924182024 & 1) == 0)
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
            this.<丞丘且丁丙丑丐丞东>k__BackingField = 丑丞丈丗丄丙丟万丄;
            mem[1152921540890779524] = 丑丞丈丗丄丙丟万丄.g;
            mem[1152921540890779528] = 丑丞丈丗丄丙丟万丄.b;
            mem[1152921540890779532] = 丑丞丈丗丄丙丟万丄.a;
        }
        protected ColoredPiece()
        {
        
        }
    
    }

}
