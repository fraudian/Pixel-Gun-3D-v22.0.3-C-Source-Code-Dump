using UnityEngine;

namespace TapjoyUnity.Internal
{
    public sealed class TapjoyUnityInit : MonoBehaviour
    {
        // Fields
        private static bool 丝与丆丞东丘丈东丘;
        
        // Methods
        private void Awake()
        {
            TapjoyUnity.TapjoyFunc<T1, TResult> val_8;
            var val_9;
            var val_11;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_13;
            var val_14;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_16;
            var val_17;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_19;
            var val_20;
            TapjoyUnity.TapjoyFunc<System.Int32> val_22;
            var val_23;
            TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat> val_25;
            TapjoyUnity.TapjoyFunc<System.Int32, TapjoyUnity.Internal.UnityCompat.SceneCompat> val_27;
            val_8 = 1152921505344172032;
            val_9 = null;
            val_9 = null;
            if(TapjoyUnity.Internal.TapjoyUnityInit.丝与丆丞东丘丈东丘 == true)
            {
                    return;
            }
            
            TapjoyUnity.Internal.TapjoyUnityInit.丝与丆丞东丘丈东丘 = true;
            TapjoyUnity.Internal.ApiBindingAndroid.Install();
            val_11 = null;
            val_11 = null;
            val_13 = TapjoyUnityInit.<>c.<>9__1_0;
            if(val_13 == null)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = null;
                val_13 = val_1;
                val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TapjoyUnityInit.<>c::与丛专且一丙丑丄业(UnityEngine.SceneManagement.Scene 丂丟丞丈与一丛下丄, UnityEngine.SceneManagement.Scene 丘丄丒与一东丕业与));
                TapjoyUnityInit.<>c.<>9__1_0 = val_13;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  val_1);
            val_14 = null;
            val_14 = null;
            val_16 = TapjoyUnityInit.<>c.<>9__1_1;
            if(val_16 == null)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = null;
                val_16 = val_2;
                val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TapjoyUnityInit.<>c::丘丕丘丒三不丏丑丞(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丂丛丑东不丅丈一东));
                TapjoyUnityInit.<>c.<>9__1_1 = val_16;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  val_2);
            val_17 = null;
            val_17 = null;
            val_19 = TapjoyUnityInit.<>c.<>9__1_2;
            if(val_19 == null)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_3 = null;
                val_19 = val_3;
                val_3 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TapjoyUnityInit.<>c::丁丂丐专丝丈不丙丈(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅));
                TapjoyUnityInit.<>c.<>9__1_2 = val_19;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneUnloaded(value:  val_3);
            val_20 = null;
            val_20 = null;
            val_22 = TapjoyUnityInit.<>c.<>9__1_3;
            if(val_22 == null)
            {
                    TapjoyUnity.TapjoyFunc<System.Int32> val_4 = null;
                val_22 = val_4;
                val_4 = new TapjoyUnity.TapjoyFunc<System.Int32>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TapjoyUnityInit.<>c::世丕丌丝丂上东下万());
                TapjoyUnityInit.<>c.<>9__1_3 = val_22;
            }
            
            TapjoyUnity.Internal.UnityDependency.sceneCount = val_22;
            val_23 = null;
            val_23 = null;
            val_25 = TapjoyUnityInit.<>c.<>9__1_4;
            if(val_25 == null)
            {
                    TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat> val_5 = null;
                val_25 = val_5;
                val_5 = new TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  TapjoyUnity.Internal.UnityCompat.SceneCompat TapjoyUnityInit.<>c::丁丕一专下丐且丗一());
                val_23 = null;
                TapjoyUnityInit.<>c.<>9__1_4 = val_25;
            }
            
            TapjoyUnity.Internal.UnityDependency.GetActiveScene = val_25;
            val_23 = null;
            val_27 = TapjoyUnityInit.<>c.<>9__1_5;
            if(val_27 == null)
            {
                    TapjoyUnity.TapjoyFunc<System.Int32, TapjoyUnity.Internal.UnityCompat.SceneCompat> val_6 = null;
                val_27 = val_6;
                val_6 = new TapjoyUnity.TapjoyFunc<System.Int32, TapjoyUnity.Internal.UnityCompat.SceneCompat>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  TapjoyUnity.Internal.UnityCompat.SceneCompat TapjoyUnityInit.<>c::丒丐丛不丂丑丛丘丅(int 丞世不丒下上上丝丑));
                TapjoyUnityInit.<>c.<>9__1_5 = val_27;
            }
            
            TapjoyUnity.Internal.UnityDependency.GetSceneAt = val_27;
            TapjoyUnity.TapjoyFunc<System.Object, System.String> val_7 = null;
            val_8 = val_7;
            val_7 = new TapjoyUnity.TapjoyFunc<System.Object, System.String>(object:  0, method:  public static System.String UnityEngine.JsonUtility::ToJson(object obj));
            TapjoyUnity.Internal.UnityDependency.ToJson = val_8;
        }
        private static TapjoyUnity.Internal.UnityCompat.SceneCompat 万丞且丒丗丙丂世丝(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅)
        {
            TapjoyUnity.Internal.UnityCompat.SceneCompat val_0;
            int val_2 = 丏丈丗世丙万丆丐丅.m_Handle.buildIndex;
            string val_3 = 丏丈丗世丙万丆丐丅.m_Handle.name;
            string val_4 = 丏丈丗世丙万丆丐丅.m_Handle.path;
            bool val_5 = 丏丈丗世丙万丆丐丅.m_Handle.IsValid();
            val_0._path = 0;
            mem[1152921540779096808] = 0;
            val_0._hashCode = 0;
            val_0._valid = false;
            val_0._buildIndex.HasValue = false;
            mem[1152921540779096790] = 0;
            val_0._name = 0;
            return val_0;
        }
        public TapjoyUnityInit()
        {
        
        }
        private static TapjoyUnityInit()
        {
        
        }
    
    }

}
