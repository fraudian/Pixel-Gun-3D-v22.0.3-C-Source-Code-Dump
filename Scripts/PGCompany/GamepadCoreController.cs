using UnityEngine;

namespace PGCompany
{
    internal class GamepadCoreController : MonoBehaviour
    {
        // Fields
        private static PGCompany.GamepadCoreController 丝业丆丁业三丈丟东;
        public static bool GamePadEnabled;
        internal static float 专丛丈上丛且丟丌丞;
        internal static float 专丗丑世丅丂不丂丝;
        internal static float[] 三丏丅丐丏与下世丗;
        internal static float[] 丌丕丈三丞一丈丁东;
        internal static float[] 丟丕丛丅丌且下专丏;
        public PGCompany.业丐与丕丒下丑下丈 currentState;
        public PGCompany.业丐与丕丒下丑下丈 prevState;
        private System.Collections.Generic.Dictionary<PGCompany.业丐与丕丒下丑下丈, PGCompany.丘一丂七丄与一东丕> 下丛世丐三丛上丙丂;
        private System.Collections.Generic.List<PGCompany.业丐与丕丒下丑下丈> 丘丄三不丒七与不丈;
        private static System.Action<PGCompany.丆七丗丂世丞丗丙三, object> 且不丅万丕丙丕丆且;
        private PGCompany.丘一丂七丄与一东丕 世丗丆专丟丄丞丝丛;
        
        // Properties
        public static PGCompany.GamepadCoreController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        public static PGCompany.GamepadCoreController get_Instance()
        {
            var val_4;
            PGCompany.GamepadCoreController val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = PGCompany.GamepadCoreController.丝业丆丁业三丈丟东;
            if(val_5 == 0)
            {
                    val_5 = new UnityEngine.GameObject();
                val_5 = new UnityEngine.GameObject(name:  "GamepadCoreController");
                val_6 = null;
                val_6 = null;
                PGCompany.GamepadCoreController.丝业丆丁业三丈丟东 = new UnityEngine.GameObject().AddComponent<PGCompany.GamepadCoreController>();
                UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
            }
            
            val_7 = null;
            val_7 = null;
            return (PGCompany.GamepadCoreController)PGCompany.GamepadCoreController.丝业丆丁业三丈丟东;
        }
        internal static float 上丒丅丑万专三丛东(int 丄与丘不丘七业丗一)
        {
            var val_4;
            var val_5;
            System.Single[] val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = 丄与丘不丘七业丗一;
            val_5 = null;
            val_5 = null;
            val_6 = PGCompany.GamepadCoreController.三丏丅丐丏与下世丗;
            if(val_6 == null)
            {
                    return (float)(PGCompany.GamepadCoreController.三丏丅丐丏与下世丗 + ((long)(int)((PGCompany.GamepadCoreController.三丏丅丐丏与下世丗.Length - 1))) << 2) + 32;
            }
            
            val_6 = PGCompany.GamepadCoreController.三丏丅丐丏与下世丗;
            if(val_6 != null)
            {
                    int val_1 = val_4 - 1;
                if(val_1 < PGCompany.GamepadCoreController.三丏丅丐丏与下世丗.Length)
            {
                    val_7 = val_1 & (~(val_1 >> 31));
            }
            else
            {
                    val_8 = null;
                val_8 = null;
                val_7 = PGCompany.GamepadCoreController.三丏丅丐丏与下世丗.Length - 1;
            }
            
                val_9 = null;
                val_9 = null;
                val_4 = (long)val_7;
                System.Single[] val_2 = PGCompany.GamepadCoreController.三丏丅丐丏与下世丗 + (((long)(int)((PGCompany.GamepadCoreController.三丏丅丐丏与下世丗.Length - 1))) << 2);
                return (float)(PGCompany.GamepadCoreController.三丏丅丐丏与下世丗 + ((long)(int)((PGCompany.GamepadCoreController.三丏丅丐丏与下世丗.Length - 1))) << 2) + 32;
            }
        
        }
        internal static float 一丆上丐且且丄丒一(int 丄与丘不丘七业丗一)
        {
            var val_4;
            var val_5;
            System.Single[] val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = 丄与丘不丘七业丗一;
            val_5 = null;
            val_5 = null;
            val_6 = PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东;
            if(val_6 == null)
            {
                    return (float)(PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东 + ((long)(int)((PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东.Length - 1))) << 2) + 32;
            }
            
            val_6 = PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东;
            if(val_6 != null)
            {
                    int val_1 = val_4 - 1;
                if(val_1 < PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东.Length)
            {
                    val_7 = val_1 & (~(val_1 >> 31));
            }
            else
            {
                    val_8 = null;
                val_8 = null;
                val_7 = PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东.Length - 1;
            }
            
                val_9 = null;
                val_9 = null;
                val_4 = (long)val_7;
                System.Single[] val_2 = PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东 + (((long)(int)((PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东.Length - 1))) << 2);
                return (float)(PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东 + ((long)(int)((PGCompany.GamepadCoreController.丌丕丈三丞一丈丁东.Length - 1))) << 2) + 32;
            }
        
        }
        internal static float 且丑丙不且七东专丘(int 丄与丘不丘七业丗一)
        {
            var val_4;
            var val_5;
            System.Single[] val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = 丄与丘不丘七业丗一;
            val_5 = null;
            val_5 = null;
            val_6 = PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏;
            if(val_6 == null)
            {
                    return (float)(PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏 + ((long)(int)((PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏.Length - 1))) << 2) + 32;
            }
            
            val_6 = PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏;
            if(val_6 != null)
            {
                    int val_1 = val_4 - 1;
                if(val_1 < PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏.Length)
            {
                    val_7 = val_1 & (~(val_1 >> 31));
            }
            else
            {
                    val_8 = null;
                val_8 = null;
                val_7 = PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏.Length - 1;
            }
            
                val_9 = null;
                val_9 = null;
                val_4 = (long)val_7;
                System.Single[] val_2 = PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏 + (((long)(int)((PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏.Length - 1))) << 2);
                return (float)(PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏 + ((long)(int)((PGCompany.GamepadCoreController.丟丕丛丅丌且下专丏.Length - 1))) << 2) + 32;
            }
        
        }
        internal static float[] 世丄且丁与丌专万丅(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
        {
            var val_5;
            var val_21;
            var val_22;
            System.Collections.Generic.Dictionary<System.Int32, System.Single> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
            Dictionary.Enumerator<TKey, TValue> val_2 = 丏丂万业丙专丏丒丒.GetEnumerator();
            label_5:
            if(((-796997680) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            val_1.Add(key:  System.Int32.Parse(s:  val_6._value._obj.丐丏七丌丕丗业且上()), value:  System.Single.Parse(s:  val_6._value._obj));
            goto label_5;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Collections.Generic.List<System.Int32> val_10 = new System.Collections.Generic.List<System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_11 = val_1.GetEnumerator();
            val_21 = 1152921536415323312;
            label_18:
            if(((-796997728) & 1) == 0)
            {
                goto label_16;
            }
            
            val_10.Add(item:  val_5.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂());
            goto label_18;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_10.Sort();
            float[] val_14 = new float[65];
            val_22 = 0;
            goto label_26;
            label_35:
            int val_15 = val_10.Item[0];
            if(val_15 <= 65)
            {
                    int val_16 = val_15 - 1;
                var val_17 = 66 - (val_15 << );
                do
            {
                val_21 = (long)val_16;
                val_17 = val_17 - 1;
                val_16 = val_16 + 1;
                val_14[val_21] = val_1.Item[val_10.Item[0]];
            }
            while(val_17 != 0);
            
            }
            
            val_22 = 1;
            label_26:
            if(val_22 < val_10.Count)
            {
                goto label_35;
            }
            
            return (System.Single[])val_14;
        }
        public static void add_OnInput(System.Action<PGCompany.丆七丗丂世丞丗丙三, object> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.GamepadCoreController.且不丅万丕丙丕丆且, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.GamepadCoreController.且不丅万丕丙丕丆且 != 1152921505594495024);
        
        }
        public static void remove_OnInput(System.Action<PGCompany.丆七丗丂世丞丗丙三, object> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.GamepadCoreController.且不丅万丕丙丕丆且, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.GamepadCoreController.且不丅万丕丙丕丆且 != 1152921505594495024);
        
        }
        private void Awake()
        {
            var val_21;
            var val_22;
            val_21 = null;
            val_21 = null;
            if(PGCompany.GamepadCoreController.丝业丆丁业三丈丟东 == 0)
            {
                    val_22 = null;
                val_22 = null;
                PGCompany.GamepadCoreController.丝业丆丁业三丈丟东 = this;
            }
            
            System.Collections.Generic.Dictionary<PGCompany.业丐与丕丒下丑下丈, PGCompany.丘一丂七丄与一东丕> val_2 = new System.Collections.Generic.Dictionary<PGCompany.业丐与丕丒下丑下丈, PGCompany.丘一丂七丄与一东丕>();
            val_2.Add(key:  0, value:  new PGCompany.丟丝丟丕业且东丆丛());
            val_2.Add(key:  2, value:  new PGCompany.业丒丛七丑丆丅下丙());
            val_2.Add(key:  3, value:  new PGCompany.丌丕万丛丑丁下丞东());
            val_2.Add(key:  4, value:  new PGCompany.丄丂丘专一丂一丈丗());
            val_2.Add(key:  7, value:  new PGCompany.丌丑丌三丛东丞丈七());
            val_2.Add(key:  5, value:  new PGCompany.丞丐且丁丞丈万万丑());
            val_2.Add(key:  6, value:  new PGCompany.丂丛一东不七丑丆丞());
            val_2.Add(key:  24, value:  new PGCompany.丕丌丏丑与丟丘上七());
            val_2.Add(key:  8, value:  new PGCompany.丑丈七丆丂三丌丗丌());
            val_2.Add(key:  9, value:  new PGCompany.丐丌丕与丙与丂丛东());
            val_2.Add(key:  10, value:  new PGCompany.丄丏丈丟丑上丛丈丒());
            val_2.Add(key:  19, value:  new PGCompany.下丂丘且丅丟丒丛与());
            val_2.Add(key:  20, value:  new PGCompany.丁丆丞丟且丑丑世丒());
            val_2.Add(key:  21, value:  new PGCompany.丝丏丛丞丁丆丌丏与());
            val_2.Add(key:  22, value:  new PGCompany.万丞业丕世丝万丄丟());
            val_2.Add(key:  23, value:  new PGCompany.丐丘丘丈业丙丛丞不());
            val_2.Add(key:  25, value:  new PGCompany.丂下世东东七丑一丘());
            this.下丛世丐三丛上丙丂 = val_2;
            this.世丗丆专丟丄丞丝丛 = val_2.Item[this.currentState];
        }
        private void OnEnable()
        {
        
        }
        private void OnDisable()
        {
        
        }
        internal void 丆专下丁万丗丂丅丄(string 丒丘丏上丙丟丑丕丈)
        {
            string val_7;
            bool val_8;
            val_7 = 丒丘丏上丙丟丑丕丈;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[Gamepad_Core_Controller] On_ChangeCurrentGamepad: "("[Gamepad_Core_Controller] On_ChangeCurrentGamepad: ") + val_7);
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) != false)
            {
                    if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[Gamepad_Core_Controller] On_ChangeCurrentGamepad: name is null or empty then GamePadEnabled false");
            }
            
                val_8 = 0;
            }
            else
            {
                    if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_7 = "[Gamepad_Core_Controller] On_ChangeCurrentGamepad: "("[Gamepad_Core_Controller] On_ChangeCurrentGamepad: ") + val_7 + " is not null or empty then GamePadEnabled true";
                UnityEngine.Debug.Log(message:  val_7);
            }
            
                val_8 = true;
            }
            
            PGCompany.GamepadCoreController.GamePadEnabled = val_8;
        }
        internal void 丞不业丛专丅丛丛丗(丄丐世丆丛世丅上丛 专丒丌丆下丐丞丟丞)
        {
        
        }
        internal void 丄丑七丘丁且丞丙专(PGCompany.业丐与丕丒下丑下丈 丏业丟一东丂东丘丛)
        {
        
        }
        internal void 丞丅三不东且与丞丈()
        {
        
        }
        internal PGCompany.业丐与丕丒下丑下丈 三丝丂丏一世丛丌东()
        {
            return (PGCompany.业丐与丕丒下丑下丈)this.prevState;
        }
        internal PGCompany.业丐与丕丒下丑下丈 丈丛七丐丏丘丕下丕()
        {
            return (PGCompany.业丐与丕丒下丑下丈)this.currentState;
        }
        private void LateUpdate()
        {
        
        }
        public GamepadCoreController()
        {
            this.下丛世丐三丛上丙丂 = new System.Collections.Generic.Dictionary<PGCompany.业丐与丕丒下丑下丈, PGCompany.丘一丂七丄与一东丕>();
            this.丘丄三不丒七与不丈 = new System.Collections.Generic.List<PGCompany.业丐与丕丒下丑下丈>();
        }
        private static GamepadCoreController()
        {
            PGCompany.GamepadCoreController.丝业丆丁业三丈丟东 = 0;
            PGCompany.GamepadCoreController.GamePadEnabled = false;
            PGCompany.GamepadCoreController.专丛丈上丛且丟丌丞 = 20f;
            PGCompany.GamepadCoreController.专丗丑世丅丂不丂丝 = 1f;
        }
    
    }

}
