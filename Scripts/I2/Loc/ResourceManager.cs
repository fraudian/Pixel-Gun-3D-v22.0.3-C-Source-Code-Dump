using UnityEngine;

namespace I2.Loc
{
    public class ResourceManager : MonoBehaviour
    {
        // Fields
        private static I2.Loc.ResourceManager 丂丙万丘三丙丒且丛;
        public UnityEngine.Object[] Assets;
        private System.Collections.Generic.Dictionary<string, UnityEngine.Object> 专丟不丈丅丆丟业与;
        private bool 上丕一丝七世万东世;
        
        // Properties
        public static I2.Loc.ResourceManager 专世丌业丏丞且丕丝 { get; }
        
        // Methods
        public static I2.Loc.ResourceManager get_pInstance()
        {
            I2.Loc.ResourceManager val_17;
            I2.Loc.ResourceManager val_18;
            if(I2.Loc.ResourceManager.丂丙万丘三丙丒且丛 == 0)
            {
                    if((UnityEngine.Object.FindObjectOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null)
            {
                    val_17 = 0;
            }
            
                I2.Loc.ResourceManager.丂丙万丘三丙丒且丛 = val_17;
            }
            
            val_18 = I2.Loc.ResourceManager.丂丙万丘三丙丒且丛;
            if(val_18 == 0)
            {
                    System.Type[] val_7 = new System.Type[1];
                val_18 = val_7;
                val_18[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                UnityEngine.GameObject val_9 = new UnityEngine.GameObject(name:  "I2ResourceManager", components:  val_7);
                if(val_9 != null)
            {
                    val_9.hideFlags = val_9.hideFlags | 61;
            }
            else
            {
                    val_18 = 0.hideFlags;
                0.hideFlags = val_18 | 61;
            }
            
                I2.Loc.ResourceManager.丂丙万丘三丙丒且丛 = val_9.GetComponent<I2.Loc.ResourceManager>();
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.丂丙万丘三丙丒且丛;
            }
            
            val_18 = I2.Loc.ResourceManager.丂丙万丘三丙丒且丛.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_18);
            return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.丂丙万丘三丙丒且丛;
        }
        public T GetAsset<T>(string 专丕与丒丗丁丘专丟)
        {
            UnityEngine.Object val_4;
            UnityEngine.Object val_1 = this.业丛丟万东丘丏丗东(专丕与丒丗丁丘专丟:  专丕与丒丗丁丘专丟);
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_4 = val_1;
            if(val_4 != null)
            {
                goto label_5;
            }
            
            label_4:
            val_4 = 0;
            label_5:
            if(val_4 != 0)
            {
                    return (object)val_4;
            }
            
            val_4 = this;
            return (object)val_4;
        }
        private UnityEngine.Object 业丛丟万东丘丏丗东(string 专丕与丒丗丁丘专丟)
        {
            UnityEngine.Object[] val_4;
            var val_5;
            UnityEngine.Object[] val_6;
            UnityEngine.Object val_7;
            val_4 = this.Assets;
            if((val_4 == null) || (this.Assets.Length < 1))
            {
                    return 0;
            }
            
            val_5 = 4;
            goto label_3;
            label_13:
            val_6 = this.Assets;
            val_5 = 5;
            label_3:
            val_7 = val_6[1];
            if(val_7 == 0)
            {
                goto label_8;
            }
            
            val_7 = this.Assets[1];
            if((System.String.op_Equality(a:  val_7.name, b:  专丕与丒丗丁丘专丟)) == true)
            {
                goto label_12;
            }
            
            label_8:
            if((val_5 - 3) < (long)this.Assets.Length)
            {
                goto label_13;
            }
            
            return 0;
            label_12:
            UnityEngine.Object val_5 = this.Assets[1];
            return 0;
        }
        public bool HasAsset(UnityEngine.Object 世丂丑下下下丕业专)
        {
            UnityEngine.Object[] val_3 = this.Assets;
            if(val_3 == null)
            {
                    return (bool)val_3;
            }
            
            val_3 = ((System.Array.IndexOf<UnityEngine.Object>(array:  val_3 = this.Assets, value:  世丂丑下下下丕业专)) >> 31) ^ 1;
            return (bool)val_3;
        }
        public T LoadFromResources<T>(string 世丒业丂一上丆一东)
        {
            var val_5;
            UnityEngine.Object val_6;
            val_5 = this;
            UnityEngine.Object val_1 = 0;
            if(((this.专丟不丈丅丆丟业与.TryGetValue(key:  世丒业丂一上丆一东, value: out  val_1)) != false) && (val_1 != 0))
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 48];
                val_5 = __RuntimeMethodHiddenParam + 48;
                if(val_1 != 0)
            {
                    val_6 = val_1;
                if(val_6 != 0)
            {
                    return (object)val_6;
            }
            
            }
            
                val_6 = 0;
                return (object)val_6;
            }
            
            val_6 = 世丒业丂一上丆一东;
            this.专丟不丈丅丆丟业与.set_Item(key:  世丒业丂一上丆一东, value:  val_6);
            if(this.上丕一丝七世万东世 == true)
            {
                    return (object)val_6;
            }
            
            this.Invoke(methodName:  "CleanResourceCache", time:  0.1f);
            this.上丕一丝七世万东世 = true;
            return (object)val_6;
        }
        public void CleanResourceCache()
        {
            this.专丟不丈丅丆丟业与.Clear();
            this.CancelInvoke();
            this.上丕一丝七世万东世 = false;
        }
        public ResourceManager()
        {
            this.专丟不丈丅丆丟业与 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>();
        }
    
    }

}
