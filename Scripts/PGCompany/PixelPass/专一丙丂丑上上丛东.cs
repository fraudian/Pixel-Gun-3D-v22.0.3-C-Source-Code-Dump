using UnityEngine;

namespace PGCompany.PixelPass
{
    internal abstract class 专一丙丂丑上上丛东
    {
        // Fields
        private static System.Action 丄且不丏不万世丝万;
        protected System.Collections.Generic.List<string> 丁世丈七丌丂丛下业;
        protected PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
        
        // Methods
        internal static void 万丘丑丙丈丛与丝丞(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.PixelPass.专一丙丂丑上上丛东.丄且不丏不万世丝万, b:  丙业与丙丗丝不丈东);
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
        internal static void 丆万丛万丙七世万业(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.PixelPass.专一丙丂丑上上丛东.丄且不丏不万世丝万, value:  丙业与丙丗丝不丈东);
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
        internal 专一丙丂丑上上丛东(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            this.丁世丈七丌丂丛下业 = new System.Collections.Generic.List<System.String>();
            this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        }
        internal abstract string 七业丑不七丐业丟丂(); // 0
        internal abstract System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 万丞万丘丈下东上丘(); // 0
        internal abstract bool 丌丝丕丕丒专专丏专(); // 0
        internal abstract string 丛丗丈丙上业丟与丞(); // 0
        internal abstract PGCompany.三东丏不丗世丅丌丄 丂一丆丂且三丟丗一(); // 0
        internal abstract PGCompany.三东丏不丗世丅丌丄 丘一丒业下丈丐丝丈(); // 0
        internal abstract string 丄与与丕万丆丄上丟(int 丑丅世丐丒丏丐三丅); // 0
        internal abstract bool 不专丞丐一丁上下丁(); // 0
        protected abstract bool 丄世丆丄丛世丐与不(); // 0
        internal bool 三不丘下且丞三丆丙()
        {
            var val_1;
            if((this & 1) != 0)
            {
                    if(PGCompany.PixelPass.专一丙丂丑上上丛东.丄且不丏不万世丝万 != null)
            {
                    PGCompany.PixelPass.专一丙丂丑上上丛东.丄且不丏不万世丝万.Invoke();
            }
            
                val_1 = 1;
                return (bool)val_1;
            }
            
            val_1 = 0;
            return (bool)val_1;
        }
    
    }

}
