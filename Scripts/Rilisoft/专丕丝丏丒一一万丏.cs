using UnityEngine;

namespace Rilisoft
{
    public class 专丕丝丏丒一一万丏<T>
    {
        // Fields
        private readonly UnityEngine.GameObject 上丈七丏一一丅丈丗;
        private readonly string 且丐丐丁丁上丅上丄;
        private UnityEngine.GameObject 丕丗丒上万丄丗丏丐;
        private T 丆不丗三丄丕丛丈丏;
        
        // Properties
        private UnityEngine.GameObject 丗东与丝丞丕丘丁丌 { get; set; }
        public T 不丑一丙东丙丆丁七 { get; }
        public bool 丟丐下丐三一丄丞丑 { get; }
        public bool 丞丘万东三专丈万丝 { get; }
        public bool 上不丅世丒丅丒不丙 { get; }
        
        // Methods
        public 专丕丝丏丒一一万丏<T>(UnityEngine.GameObject 丑且不丕与专丄业丙, UnityEngine.GameObject 丆丏七丟不丒与七专)
        {
            if(this != null)
            {
                    val_1 = new System.Object();
            }
            else
            {
                    val_1 = new System.Object();
            }
            
            mem[1152921543009780704] = val_1;
        }
        public 专丕丝丏丒一一万丏<T>(string 丆万丕丏与丈与丒丗, UnityEngine.GameObject 丆丏七丟不丒与七专)
        {
            val_1 = new System.Object();
            mem[1152921543009909088] = val_1;
            mem[1152921543009909096] = 丆万丕丏与丈与丒丗;
        }
        private UnityEngine.GameObject 丌丏三丟万丝丛丆七()
        {
            if(137170944 != 0)
            {
                    return val_3;
            }
            
            bool val_2 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  137170944);
            if(val_2 == true)
            {
                    return val_3;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_2);
            mem[1152921543010033392] = val_3;
            return val_3;
        }
        private void 丅东业丝业一丅三丙(UnityEngine.GameObject 丙业与丙丗丝不丈东)
        {
            mem[1152921543010153584] = 丙业与丙丗丝不丈东;
        }
        public T 世三丞丅丑丌丈丈一()
        {
            if(137170944 != 0)
            {
                    return (ClanSecondVersionBanner)val_9;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this);
            mem[1152921543010294264] = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 24) == 0)
            {
                    return (ClanSecondVersionBanner)val_9;
            }
            
            UnityEngine.Transform val_5 = transform;
            val_2.transform.SetParent(p:  val_5);
            __RuntimeMethodHiddenParam = val_2.transform;
            UnityEngine.Vector3 val_8 = val_5.transform.localPosition;
            __RuntimeMethodHiddenParam.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Transform val_9 = val_2.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_9.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            return (ClanSecondVersionBanner)val_9;
        }
        public bool 丙三专丞丒丂万三丁()
        {
            return UnityEngine.Object.op_Inequality(x:  this, y:  0);
        }
        public bool 丙世万一不丒上专丏()
        {
            return UnityEngine.Object.op_Inequality(x:  this, y:  0);
        }
        public bool 丅专七丞东丐丒丒丗()
        {
            if((this & 1) == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeInHierarchy;
            }
            
            return val_1.activeInHierarchy;
        }
        public void 丙不丂丝丒丐专丝丆()
        {
            if(137170944 != 0)
            {
                    UnityEngine.GameObject val_2 = gameObject;
                UnityEngine.Object.Destroy(obj:  val_2);
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            mem[1152921543010779120] = 0;
        }
    
    }

}
