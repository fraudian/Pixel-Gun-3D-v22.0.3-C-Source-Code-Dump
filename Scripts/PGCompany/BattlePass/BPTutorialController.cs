using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPTutorialController : MonoBehaviour
    {
        // Fields
        internal const int 丑丞丑不丂七丅与丒 = 7;
        private static Rilisoft.且丈丞一丞丟与上七 丗丌下业上丕丝丑丘;
        private static Rilisoft.且丈丞一丞丟与上七 丟丛丁丄丕上丆一东;
        private static PGCompany.BattlePass.BPTutorialController <不丁丄七丛不丆丁丕>k__BackingField;
        private static System.Action 且丗丟丄丑丞丈丒丂;
        private static System.Action 专丟丒万丒且丐丆丑;
        private static System.Action<int, bool> 一上丕一丘且丆且三;
        private UnityEngine.GameObject _stepsContainer;
        private UnityEngine.GameObject _body;
        
        // Properties
        internal static PGCompany.BattlePass.BPTutorialController 丆丕丝丒不丙且丐丗 { get; set; }
        internal static int 且东丈丄世万丒丘丏 { get; set; }
        internal static bool 丛丑丝上一上与丆世 { get; }
        internal static bool 丌与丝丘丛丅丈丘丗 { get; }
        
        // Methods
        internal static PGCompany.BattlePass.BPTutorialController 丑七不且上丗丁一世()
        {
            null = null;
            return (PGCompany.BattlePass.BPTutorialController)PGCompany.BattlePass.BPTutorialController.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.BattlePass.BPTutorialController 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.BattlePass.BPTutorialController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static int 丝丛三七世丙丂专丈()
        {
            Progress.丅丆不三丄不丝丒一 val_1 = Progress.七七世万专丕丁上业.上业丑丅业不东丛业();
            if(val_1 != null)
            {
                    return val_1.与一丘丂下三丞七丙();
            }
            
            return val_1.与一丘丂下三丞七丙();
        }
        private static void 丛丛七丏下丗丏丐丐(int 丙业与丙丗丝不丈东)
        {
            Progress.七七世万专丕丁上业.上业丑丅业不东丛业().丟专丛丒丐上丙东丙(丂丑丁丅丙丙且丝丁:  丙业与丙丗丝不丈东);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  53);
        }
        internal static bool 世丑丐丅丆丂丘不丁()
        {
            var val_5;
            var val_6;
            if(Progress.七七世万专丕丁上业.上业丑丅业不东丛业().丑丆丏丟丗丌丄丟丝() != false)
            {
                    val_5 = 1;
                return (bool)(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() > 6) ? 1 : 0;
            }
            
            val_6 = null;
            return (bool)(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() > 6) ? 1 : 0;
        }
        internal static bool 丌丆丛专东丒与丟丞()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_19;
            val_14 = Progress.七七世万专丕丁上业.上业丑丅业不东丛业();
            if(val_14.丑丆丏丟丗丌丄丟丝() != true)
            {
                    val_14 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
                if(val_14 == null)
            {
                    return (bool)val_15;
            }
            
                if(val_14.专丁丟丏丁丏不丗三() != false)
            {
                    if(val_14.丗丄上丑丑丅丐丒丌() == false)
            {
                goto label_8;
            }
            
            }
            
            }
            
            label_24:
            val_15 = 0;
            return (bool)val_15;
            label_8:
            if(val_14.业丈丅丂且丁与丄丂() < 2)
            {
                goto label_9;
            }
            
            val_16 = null;
            if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() <= 1)
            {
                goto label_12;
            }
            
            label_9:
            val_17 = null;
            val_17 = null;
            val_19 = BPTutorialController.<>c.<>9__13_0;
            if(val_19 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_11 = null;
                val_19 = val_11;
                val_11 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BPTutorialController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPTutorialController.<>c::丈丝丕丒丟东上丅七(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BPTutorialController.<>c.<>9__13_0 = val_19;
            }
            
            var val_13 = ((System.Linq.Enumerable.First<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_11)) != 0) ? 1 : 0;
            return (bool)val_15;
            label_12:
            PGCompany.BattlePass.BPTutorialController.三七万不七下不丏万();
            PGCompany.BattlePass.BPTutorialController.上一上世下丐与丗与();
            goto label_24;
        }
        internal static void 丝丑丄不丄丏丞丂丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.BattlePass.BPTutorialController.且丗丟丄丑丞丈丒丂, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BPTutorialController.且丗丟丄丑丞丈丒丂 != 1152921505676283928);
        
        }
        internal static void 不一丁丐万丏丑丆东(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.BattlePass.BPTutorialController.且丗丟丄丑丞丈丒丂, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BPTutorialController.且丗丟丄丑丞丈丒丂 != 1152921505676283928);
        
        }
        internal static void 业丙丘丈丁一丛专丑(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.BattlePass.BPTutorialController.专丟丒万丒且丐丆丑, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BPTutorialController.专丟丒万丒且丐丆丑 != 1152921505676283936);
        
        }
        internal static void 丙丌下丈下丅丕不丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.BattlePass.BPTutorialController.专丟丒万丒且丐丆丑, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BPTutorialController.专丟丒万丒且丐丆丑 != 1152921505676283936);
        
        }
        internal static void 世与不丗丛丙丘丝丒(System.Action<int, bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三 != 1152921505676283944);
        
        }
        internal static void 东世不丁丐丗下上丈(System.Action<int, bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三 != 1152921505676283944);
        
        }
        private static void 三七万不七下不丏万()
        {
            var val_3;
            Progress.七七世万专丕丁上业.上业丑丅业不东丛业().三业丛丁丌与丆上丄(丕丞丌万丞丄丘且丘:  true);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  53);
            Rilisoft.一丟专且三万丞丁丂.上丕丁专三丗丝万丆(丞丙丕不丕丆丁下万:  false, 丆且丁丒丒丆丁三丆:  "Levels Earned", 丙业与丙丗丝不丈东:  "level_earned_1");
            val_3 = null;
            val_3 = null;
            if(PGCompany.BattlePass.BPTutorialController.且丗丟丄丑丞丈丒丂 == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPTutorialController.且丗丟丄丑丞丈丒丂.Invoke();
        }
        internal static bool 不上且丈下丘丁丝七()
        {
            var val_8;
            var val_9;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_11;
            val_8 = null;
            if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() != 0)
            {
                    return false;
            }
            
            val_9 = null;
            val_9 = null;
            val_11 = BPTutorialController.<>c.<>9__24_0;
            if(val_11 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_4 = null;
                val_11 = val_4;
                val_4 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BPTutorialController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPTutorialController.<>c::丙下业丏丙三一丙下(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BPTutorialController.<>c.<>9__24_0 = val_11;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_5 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_4);
            if(val_5 == null)
            {
                    return false;
            }
            
            丘上上万专丙万丟丑 val_7 = val_5.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万();
            if(val_7 != null)
            {
                    return val_7.世丑丐丅丆丂丘不丁();
            }
            
            return val_7.世丑丐丅丆丂丘不丁();
        }
        internal static void 丟丝丞丘不丈丆上东()
        {
            var val_3 = null;
            int val_1 = PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈();
            val_1 = val_1 + 1;
            PGCompany.BattlePass.BPTutorialController.丛丛七丏下丗丏丐丐(丙业与丙丗丝不丈东:  val_1);
            if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() >= 7)
            {
                    PGCompany.BattlePass.BPTutorialController.三七万不七下不丏万();
            }
            
            PGCompany.BattlePass.BPTutorialController.上一上世下丐与丗与();
        }
        internal static void 丅上丛丝丄丐丁丌丒(int 丒且丆丘丞丑业丅不)
        {
            PGCompany.BattlePass.BPTutorialController.丛丛七丏下丗丏丐丐(丙业与丙丗丝不丈东:  丒且丆丘丞丑业丅不);
            if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() >= 7)
            {
                    PGCompany.BattlePass.BPTutorialController.三七万不七下不丏万();
            }
            
            PGCompany.BattlePass.BPTutorialController.上一上世下丐与丗与();
        }
        internal static bool 丟丛丕不丟七三上丝(int 丛东与丑丌丗东丕丗)
        {
            var val_5;
            var val_6;
            if(Progress.七七世万专丕丁上业.上业丑丅业不东丛业().丑丆丏丟丗丌丄丟丝() != false)
            {
                    val_5 = 1;
                return (bool)(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() > 丛东与丑丌丗东丕丗) ? 1 : 0;
            }
            
            val_6 = null;
            return (bool)(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() > 丛东与丑丌丗东丕丗) ? 1 : 0;
        }
        internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            var val_2 = null;
            PGCompany.BattlePass.BPTutorialController.丐丗丐丄七丐丙上一(丒且丆丘丞丑业丅不:  PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈(), 丆丏七丟不丒与七专:  丆丏七丟不丒与七专);
        }
        internal static void 丐丗丐丄七丐丙上一(int 丒且丆丘丞丑业丅不, UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            PGCompany.BattlePass.BPTutorialController val_26 = PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世();
            if(val_26 == 0)
            {
                    string val_3 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPTutorial");
                if(val_3 == null)
            {
                    return;
            }
            
                val_26 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_3);
                if(val_26 == 0)
            {
                    return;
            }
            
                int val_6 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
                PGCompany.BattlePass.BPTutorialController.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_26, 丈东丘丏与丌东东下:  丆丏七丟不丒与七专, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<PGCompany.BattlePass.BPTutorialController>());
            }
            else
            {
                    val_26 = PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().transform;
                if(val_26.parent != 0)
            {
                    if(val_26.parent != 丆丏七丟不丒与七专)
            {
                    val_26.SetParent(p:  丆丏七丟不丒与七专);
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
                val_26.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
                val_26.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
                UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.identity;
                val_26.localRotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
                val_26 = PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().gameObject;
                int val_22 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
                丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_26, 不东丛三丂丌丑专丆:  丆丏七丟不丒与七专.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            }
            
            }
            
            if(PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().丐丗丐丄七丐丙上一(丒且丆丘丞丑业丅不:  丒且丆丘丞丑业丅不);
        }
        public static void SkipTutorial()
        {
            UnityEngine.Object val_6;
            PGCompany.BattlePass.BPTutorialController.三七万不七下不丏万();
            PGCompany.BattlePass.BPTutorialController.丛丛七丏下丗丏丐丐(丙业与丙丗丝不丈东:  7);
            PGCompany.BattlePass.BPTutorialController.上一上世下丐与丗与();
            val_6 = PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世();
            if(val_6 == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPTutorialController val_3 = PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世();
            val_6 = val_3._body;
            if(val_6.activeSelf == false)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPTutorialController.丑七不且上丗丁一世().U_SkipStep();
        }
        private void 丐丗丐丄七丐丙上一(int 丒且丆丘丞丑业丅不)
        {
            var val_10;
            int val_11;
            var val_12;
            this._body.SetActive(value:  true);
            UnityEngine.Transform val_3 = this._stepsContainer.transform;
            val_10 = 0;
            goto label_3;
            label_11:
            UnityEngine.GameObject val_5 = val_3.GetChild(index:  0).gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  ((val_5.name.IndexOf(value:  System.String.Format(format:  "Step_{0}", arg0:  丒且丆丘丞丑业丅不.ToString(format:  "D2")))) == 0) ? 1 : 0);
            val_10 = 1;
            label_3:
            if(val_10 < val_3.childCount)
            {
                goto label_11;
            }
            
            val_11 = 1152921505676279808;
            val_12 = null;
            val_12 = null;
            if(PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三 == null)
            {
                    return;
            }
            
            val_11 = 丒且丆丘丞丑业丅不;
            PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三.Invoke(arg1:  val_11, arg2:  true);
        }
        public void U_SkipStep()
        {
            var val_2;
            var val_3;
            System.Action<System.Int32, System.Boolean> val_4;
            this._body.SetActive(value:  false);
            val_2 = null;
            val_3 = null;
            val_4 = PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三;
            if(val_4 != null)
            {
                    val_4 = PGCompany.BattlePass.BPTutorialController.一上丕一丘且丆且三;
                if(val_4 == null)
            {
                    val_4 = 0;
            }
            
                val_4.Invoke(arg1:  PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈(), arg2:  false);
                val_3 = null;
            }
            
            PGCompany.BattlePass.BPTutorialController.丟丝丞丘不丈丆上东();
        }
        private static void 上一上世下丐与丗与()
        {
            var val_3;
            System.Action val_4;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  39);
            val_3 = null;
            val_3 = null;
            val_4 = PGCompany.BattlePass.BPTutorialController.专丟丒万丒且丐丆丑;
            if(val_4 != null)
            {
                    val_4 = PGCompany.BattlePass.BPTutorialController.专丟丒万丒且丐丆丑;
                if(val_4 == null)
            {
                    val_4 = 0;
            }
            
                val_4.Invoke();
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public BPTutorialController()
        {
        
        }
        private static BPTutorialController()
        {
            PGCompany.BattlePass.BPTutorialController.丗丌下业上丕丝丑丘 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "bp-tutorial-completed-v2");
            PGCompany.BattlePass.BPTutorialController.丟丛丁丄丕上丆一东 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "bp-tutorial-step-v2");
        }
    
    }

}
