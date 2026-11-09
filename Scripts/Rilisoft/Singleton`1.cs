using UnityEngine;

namespace Rilisoft
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        // Fields
        private const string 丕丗丒一丙丟丒丙世 = "[Singleton] Something went really wrong - there should never be more than 1 singleton!";
        private const string 丌与丛丅丝丄丘丘丁 = "[Singleton] prefab not setted";
        private const string 丕丗不世丒丁丄丕丘 = "[Singleton] can not find singleton class in prefab";
        private static T 丝业丆丁业三丈丟东;
        
        // Properties
        protected static bool 丂下丅丛丒三丕丘丑 { get; }
        public static T 丆丕丝丒不丙且丐丗 { get; set; }
        
        // Methods
        protected static bool 丙丐丁七下七丈丈专()
        {
            return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 24 + 192 + 184, y:  0);
        }
        public static T get_Instance()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            UnityEngine.GameObject val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            object val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
            {
                goto label_67;
            }
            
            val_12 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_12 = __RuntimeMethodHiddenParam + 24 + 294;
            val_13 = __RuntimeMethodHiddenParam + 24;
            if((val_12 & 1) == 0)
            {
                    val_13 = mem[__RuntimeMethodHiddenParam + 24];
                val_13 = __RuntimeMethodHiddenParam + 24;
                val_12 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_12 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            val_14 = UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 24 + 192 + 184, y:  0);
            if(val_14 == false)
            {
                goto label_16;
            }
            
            __RuntimeMethodHiddenParam + 24 + 192 + 184.SendMessage(methodName:  "OnInstanceCreated", options:  1);
            goto label_67;
            label_16:
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
            {
                goto label_19;
            }
            
            var val_15 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_13 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_22:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (__RuntimeMethodHiddenParam + 24 + 192 + 184 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_19:
            UnityEngine.GameObject val_4 = null;
            val_16 = val_4;
            val_4 = new UnityEngine.GameObject(name:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 32}));
            val_17 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_17 = __RuntimeMethodHiddenParam + 24 + 294;
            val_18 = __RuntimeMethodHiddenParam + 24;
            if((val_17 & 1) == 0)
            {
                    val_18 = mem[__RuntimeMethodHiddenParam + 24];
                val_18 = __RuntimeMethodHiddenParam + 24;
                val_17 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_17 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if(((__RuntimeMethodHiddenParam + 24 + 294) & 1) != 0)
            {
                goto label_52;
            }
            
            label_51:
            label_52:
            mem2[0] = val_16;
            if(val_16 == null)
            {
                goto label_33;
            }
            
            val_19 = 0;
            goto label_34;
            label_21:
            val_15 = val_15 + (((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 176 + 8)) << 4);
            val_15 = val_15 + 296;
            label_23:
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184.丆一丌下丕业丆丘上()) == 0)
            {
                goto label_37;
            }
            
            var val_18 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 286) == 0)
            {
                goto label_41;
            }
            
            var val_16 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_40:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 176 + 8) + -8) == null)
            {
                goto label_39;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (__RuntimeMethodHiddenParam + 24 + 192 + 184 + 286))
            {
                goto label_40;
            }
            
            goto label_41;
            label_37:
            val_21 = "[Singleton] prefab not setted";
            goto label_44;
            label_39:
            val_18 = val_18 + (((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 176 + 8)) << 4);
            val_20 = val_18 + 296;
            label_41:
            val_22 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_22 = __RuntimeMethodHiddenParam + 24 + 294;
            val_23 = __RuntimeMethodHiddenParam + 24;
            if((val_22 & 1) == 0)
            {
                    val_23 = mem[__RuntimeMethodHiddenParam + 24];
                val_23 = __RuntimeMethodHiddenParam + 24;
                val_22 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_22 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if((UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  __RuntimeMethodHiddenParam + 24 + 192 + 184.丆一丌下丕业丆丘上())) == 0)
            {
                goto label_50;
            }
            
            if(((__RuntimeMethodHiddenParam + 24 + 294) & 1) == 0)
            {
                goto label_51;
            }
            
            goto label_52;
            label_50:
            val_21 = "[Singleton] can not find singleton class in prefab";
            label_44:
            UnityEngine.Debug.LogError(message:  val_21);
            val_16 = 0;
            label_33:
            val_19 = 1;
            label_34:
            val_16.name = val_16.name + " [Singleton]";
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  val_16);
            }
            
            __RuntimeMethodHiddenParam + 24 + 192 + 184.SendMessage(methodName:  "OnInstanceCreated", options:  1);
            val_24 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_24 = __RuntimeMethodHiddenParam + 24 + 294;
            val_25 = __RuntimeMethodHiddenParam + 24;
            if((val_24 & 1) == 0)
            {
                    val_25 = mem[__RuntimeMethodHiddenParam + 24];
                val_25 = __RuntimeMethodHiddenParam + 24;
                val_24 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_24 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 48 + 24) >= 2)
            {
                    UnityEngine.Debug.LogError(message:  "[Singleton] Something went really wrong - there should never be more than 1 singleton!");
            }
            
            label_67:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
            {
                    return (BattlePassController)__RuntimeMethodHiddenParam + 24 + 192 + 184;
            }
            
            return (BattlePassController)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        public static void set_Instance(T 丙业与丙丗丝不丈东)
        {
            var val_2;
            var val_3;
            mem2[0] = 丙业与丙丗丝不丈东;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 294;
            val_3 = __RuntimeMethodHiddenParam + 24;
            if((val_2 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24];
                val_3 = __RuntimeMethodHiddenParam + 24;
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 48 + 24) >= 2)
            {
                    UnityEngine.Debug.LogError(message:  "[Singleton] Something went really wrong - there should never be more than 1 singleton!");
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  __RuntimeMethodHiddenParam + 24 + 192 + 184.gameObject);
            __RuntimeMethodHiddenParam + 24 + 192 + 184.SendMessage(methodName:  "OnInstanceCreated", options:  1);
        }
        protected virtual void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        protected Singleton<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
