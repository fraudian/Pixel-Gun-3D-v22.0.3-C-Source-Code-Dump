using UnityEngine;

namespace Rilisoft
{
    internal sealed class PetsManager : Singleton<Rilisoft.PetsManager>
    {
        // Fields
        private static System.Action<PGCompany.世丒丗丅丛丕不万丂, PGCompany.三东丏不丗世丅丌丄> 专丟下东丏丕丒且丂;
        private const string 不上丈丛丏丅丑丟丆 = "pets";
        internal const string 丅七丗丁丆丂丑丂丕 = "_empty_slot";
        internal static readonly System.Collections.Generic.List<string> 上丆丐万丘丘下丑丗;
        internal static string[] 上七专丗下下丛三七;
        private static System.Action 与且丏专三丙丈丑业;
        private static System.Action<string, string> 丂丒世丘丌丈世世丐;
        private static System.Action 一丁三丏丗丘与丆丌;
        private static System.Action 丈东丆且丂丑丗世丅;
        private static System.Action<string> 丄丞丞丕丘一业丞丕;
        
        // Properties
        internal static System.Collections.Generic.Dictionary<string, PetInfo> 三专丝一丂与七三丅 { get; }
        internal System.Collections.Generic.Dictionary<int, 七下下业三丞专丈丛> 丁丙且七不丞丏丕丑 { get; }
        
        // Methods
        internal static void 与专丗下七丑且丄丅(System.Action<PGCompany.世丒丗丅丛丕不万丂, PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Rilisoft.PetsManager.丅七丗丁丆丂丑丂丕, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丞丐丟丗丐三丒丂且(System.Action<PGCompany.世丒丗丅丛丕不万丂, PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Rilisoft.PetsManager.丅七丗丁丆丂丑丂丕, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal void 专业丘丘且丌丕丐上(PGCompany.世丒丗丅丛丕不万丂 业丟丙丝丗万丗七上, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
        {
            int val_14;
            int val_15;
            PGCompany.丗丟丄丈东丝丕丄世 val_16;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  3);
            val_14 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_14.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
            {
                    if(业丟丙丝丗万丗七上 != null)
            {
                    val_15 = 业丟丙丝丗万丗七上.业东丅东丌上丗丑不();
                val_16 = 业丟丙丝丗万丗七上;
            }
            else
            {
                    val_15 = 0.业东丅东丌上丗丑不();
                val_16 = 0;
            }
            
                PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().下且上丛丞一东不不(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞, 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
                bool val_10 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  val_16, 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = false});
                Progress.下丁下丂七丆丙七一 val_11 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_14 = val_16.业东丅东丌上丗丑不();
                val_11.丘丈丅丞丅业丅东丅(丄丈丞丒且东丝下一:  val_14, 丙业一且丞不丞丂不:  BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_15, 且万丛丒丁丏七丅东:  业丟丙丝丗万丗七上.丁丕丁三丁丗不三丟(), 丐丏上业丈丂与万丞:  false), 丁丒且专丗丂丕不业:  0);
                val_11.丂专东丅丐丞丗丒不(业丟丙丝丗万丗七上:  业丟丙丝丗万丗七上, 丒世丘丘上丆丝东丞:  丒世丘丘上丆丝东丞);
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private void 丂专东丅丐丞丗丒不(PGCompany.世丒丗丅丛丕不万丂 业丟丙丝丗万丗七上, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
        {
            null = null;
            if(Rilisoft.PetsManager.丅七丗丁丆丂丑丂丕 == null)
            {
                    return;
            }
            
            Rilisoft.PetsManager.丅七丗丁丆丂丑丂丕.Invoke(arg1:  业丟丙丝丗万丗七上, arg2:  丒世丘丘上丆丝东丞);
        }
        internal static System.Collections.Generic.Dictionary<string, PetInfo> 专丘丞下万丅丒丐丒()
        {
            return 丟下七丘下下丙丗丅.一三专丞丒丅上业上();
        }
        internal System.Collections.Generic.Dictionary<int, 七下下业三丞专丈丛> 世且丞丑专丞与丐丈()
        {
            Progress.丑专三下三丈丟三丂 val_1 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑();
            if(val_1 != null)
            {
                    return val_1.丏丅丁丟丑与下丝专();
            }
            
            return val_1.丏丅丁丟丑与下丝专();
        }
        internal static void 丁丂丕丒丗一丗丅下(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.PetsManager.与且丏专三丙丈丑业, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.与且丏专三丙丈丑业 != 1152921505481662488);
        
        }
        internal static void 与丄丐东丈丘下丐三(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.PetsManager.与且丏专三丙丈丑业, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.与且丏专三丙丈丑业 != 1152921505481662488);
        
        }
        internal static void 且丛七丟丄丈丑丏丐(System.Action<string, string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.PetsManager.丂丒世丘丌丈世世丐, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.丂丒世丘丌丈世世丐 != 1152921505481662496);
        
        }
        internal static void 丝丅丑丆三与丛丟丞(System.Action<string, string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.PetsManager.丂丒世丘丌丈世世丐, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.丂丒世丘丌丈世世丐 != 1152921505481662496);
        
        }
        internal static void 东丘三与丙下一丐丂(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.PetsManager.一丁三丏丗丘与丆丌, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.一丁三丏丗丘与丆丌 != 1152921505481662504);
        
        }
        internal static void 上丈专业丐丅世上丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.PetsManager.一丁三丏丗丘与丆丌, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.一丁三丏丗丘与丆丌 != 1152921505481662504);
        
        }
        internal static void 丝一一丘世丈丕丒七(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.PetsManager.丈东丆且丂丑丗世丅, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.丈东丆且丂丑丗世丅 != 1152921505481662512);
        
        }
        internal static void 下丈丒七丟业丙丟丄(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.PetsManager.丈东丆且丂丑丗世丅, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.丈东丆且丂丑丗世丅 != 1152921505481662512);
        
        }
        internal static void 丂丅丌一万丞丕不东(System.Action<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.PetsManager.丄丞丞丕丘一业丞丕, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.丄丞丞丕丘一业丞丕 != 1152921505481662520);
        
        }
        internal static void 丗丞七上专三丟丘丐(System.Action<string> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.PetsManager.丄丞丞丕丘一业丞丕, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.PetsManager.丄丞丞丕丘一业丞丕 != 1152921505481662520);
        
        }
        private void OnInstanceCreated()
        {
        
        }
        internal static bool 东与三丘东丑丈丄下(string 世丐丗专丅三丝丑丆)
        {
            null = null;
            return System.Linq.Enumerable.Contains<System.String>(source:  Rilisoft.PetsManager.上七专丗下下丛三七, value:  世丐丗专丅三丝丑丆);
        }
        internal static bool 丕东丗下与丝丏丟一(string 世丐丗专丅三丝丑丆)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  世丐丗专丅三丝丑丆)) != false)
            {
                    UnityEngine.Debug.LogErrorFormat(format:  "PetsM_anager.IsEmpt_ySlotId: petId.IsNull_OrEmpty()", args:  System.Array.Empty<System.Object>());
                return false;
            }
            
            if(世丐丗专丅三丝丑丆 != null)
            {
                    return 世丐丗专丅三丝丑丆.Contains(value:  "_empty_slot");
            }
            
            return 世丐丗专丅三丝丑丆.Contains(value:  "_empty_slot");
        }
        internal System.Collections.Generic.IEnumerable<string> 业丂且下与上丂丘丁()
        {
            var val_12;
            System.Func<System.Int32, System.String> val_14;
            var val_15;
            System.Func<System.Int32, System.String> val_17;
            var val_18;
            System.Func<System.String, System.Int32> val_20;
            Dictionary.KeyCollection<TKey, TValue> val_2 = this.世且丞丑专丞与丐丈().Keys;
            val_12 = null;
            val_12 = null;
            val_14 = PetsManager.<>c.<>9__31_0;
            if(val_14 == null)
            {
                    System.Func<System.Int32, System.String> val_6 = null;
                val_14 = val_6;
                val_6 = new System.Func<System.Int32, System.String>(object:  PetsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String PetsManager.<>c::丆上万丐上丏丏丛东(int 世丐丗专丅三丝丑丆));
                PetsManager.<>c.<>9__31_0 = val_14;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = PetsManager.<>c.<>9__31_1;
            if(val_17 == null)
            {
                    System.Func<System.Int32, System.String> val_8 = null;
                val_17 = val_8;
                val_8 = new System.Func<System.Int32, System.String>(object:  PetsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String PetsManager.<>c::三与七世三业下丌不(int 三丟东丕丄丄下下丑));
                PetsManager.<>c.<>9__31_1 = val_17;
            }
            
            val_18 = null;
            val_18 = null;
            val_20 = PetsManager.<>c.<>9__31_2;
            if(val_20 != null)
            {
                    return System.Linq.Enumerable.OrderBy<System.String, System.Int32>(source:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  val_2, selector:  val_8), second:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  System.Linq.Enumerable.Except<System.Int32>(first:  丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Keys, second:  val_2), selector:  val_6)), keySelector:  System.Func<System.String, System.Int32> val_11 = null);
            }
            
            val_20 = val_11;
            val_11 = new System.Func<System.String, System.Int32>(object:  PetsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PetsManager.<>c::丌丆上下业丂丞丝七(string 世丐丗专丅三丝丑丆));
            PetsManager.<>c.<>9__31_2 = val_20;
            return System.Linq.Enumerable.OrderBy<System.String, System.Int32>(source:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  val_2, selector:  val_8), second:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  System.Linq.Enumerable.Except<System.Int32>(first:  丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Keys, second:  val_2), selector:  val_6)), keySelector:  val_11);
        }
        internal static string 丝丂万丙丑万且丛七(string 世丐丗专丅三丝丑丆)
        {
            string val_7 = 世丐丗专丅三丝丑丆;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7 = 世丐丗专丅三丝丑丆)) != false)
            {
                    UnityEngine.Debug.LogErrorFormat(format:  "PetIdWithou_tSuffixes: petId.IsNullOrEmpty()", args:  System.Array.Empty<System.Object>());
                val_7 = System.String.alignConst;
                return (string)val_7;
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance) == 0)
            {
                    object[] val_5 = new object[1];
                val_5[0] = val_7;
                UnityEngine.Debug.LogErrorFormat(format:  "PetIdWithou_tSuffixes: Instance == null, petId = {0}", args:  val_5);
                return (string)val_7;
            }
            
            int val_6 = val_7.IndexOf(value:  "_empty_slot");
            if(val_6 == 1)
            {
                    return (string)val_7;
            }
            
            if(val_7 != null)
            {
                    return val_7.Substring(startIndex:  0, length:  val_6);
            }
            
            return val_7.Substring(startIndex:  0, length:  val_6);
        }
        internal static void 丄丒丕丐且专丐与东()
        {
            null = null;
            if(Rilisoft.PetsManager.与且丏专三丙丈丑业 == null)
            {
                    return;
            }
            
            Rilisoft.PetsManager.与且丏专三丙丈丑业.Invoke();
        }
        internal string 与丁万丛丏下丞丝丛(System.Collections.Generic.List<string> 与七专丌一世丘丆业)
        {
            var val_26;
            var val_27;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>, System.Boolean> val_29;
            PetsManager.下丏丌丑七丗丕丅世 val_1 = new PetsManager.下丏丌丑七丗丕丅世();
            if(与七专丌一世丘丆业 == null)
            {
                    return (string)System.String.alignConst;
            }
            
            if(与七专丌一世丘丆业.Count == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            .东一丞丌丏三丞丑七 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  与七专丌一世丘丆业));
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>, System.Int32>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>>(source:  this.世且丞丑专丞与丐丈(), predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>, System.Boolean>(object:  val_1, method:  System.Boolean PetsManager.下丏丌丑七丗丕丅世::丙与上专丛丗丁且与(System.Collections.Generic.KeyValuePair<int, 七下下业三丞专丈丛> 不下丗丙七丈丐丘万))), keySelector:  new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>, System.Int32>(object:  val_1, method:  System.Int32 PetsManager.下丏丌丑七丗丕丅世::三上丂丘万下不丌不(System.Collections.Generic.KeyValuePair<int, 七下下业三丞专丈丛> 不下丗丙七丈丐丘万))));
            if(val_1 != null)
            {
                    val_26 = val_1;
                .丏丒丌丛丙万三丑丁 = val_10;
            }
            else
            {
                    val_26 = 24;
                mem[24] = val_10;
            }
            
            int val_11 = val_26.Count;
            if(val_1 == null)
            {
                goto label_7;
            }
            
            if(val_11 == 0)
            {
                goto label_8;
            }
            
            label_16:
            val_27 = null;
            val_27 = null;
            val_29 = PetsManager.<>c.<>9__34_2;
            if(val_29 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>, System.Boolean> val_12 = null;
                val_29 = val_12;
                val_12 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>, System.Boolean>(object:  PetsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PetsManager.<>c::丝丆且业三丗丛万不(System.Collections.Generic.KeyValuePair<int, 七下下业三丞专丈丛> 七丏丄丅丌业与且丙));
                PetsManager.<>c.<>9__34_2 = val_29;
            }
            
            if((System.Linq.Enumerable.All<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>>(source:  mem[24], predicate:  val_12)) == false)
            {
                goto label_14;
            }
            
            return (string)System.String.alignConst;
            label_7:
            if(val_11 != 0)
            {
                goto label_16;
            }
            
            label_8:
            string val_14 = (PetsManager.下丏丌丑七丗丕丅世)[1152921543378587904].东一丞丌丏三丞丑七.Item[0];
            return (string)System.String.alignConst;
            label_14:
            if(mem[24].Count < (PetsManager.下丏丌丑七丗丕丅世)[1152921543378587904].东一丞丌丏三丞丑七.Count)
            {
                    string val_18 = System.Linq.Enumerable.First<System.String>(source:  (PetsManager.下丏丌丑七丗丕丅世)[1152921543378587904].东一丞丌丏三丞丑七, predicate:  new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean PetsManager.下丏丌丑七丗丕丅世::下东丂丞一七丝万东(string 七丏丄丅丌业与且丙)));
                return (string)System.String.alignConst;
            }
            
            System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛> val_19 = mem[24].Item[0];
            List.Enumerator<T> val_20 = mem[24].GetEnumerator();
            goto label_30;
            label_31:
            ConfiguredValueTaskAwaiter val_21 = 0.GetAwaiter();
            label_30:
            if((116987024 & 1) != 0)
            {
                goto label_31;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_24 = 丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Item[val_21._value._obj.丙东专丂世丈丏丁丂()];
            return (string)System.String.alignConst;
        }
        internal string 丘丕丂万丝丁丌丞业(string 世丐丗专丅三丝丑丆)
        {
            if((Rilisoft.PetsManager.专丘丞下万丅丒丐丒().ContainsKey(key:  世丐丗专丅三丝丑丆)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            PetInfo val_4 = Rilisoft.PetsManager.专丘丞下万丅丒丐丒().Item[世丐丗专丅三丝丑丆];
            if(val_4 != null)
            {
                    return val_4.丘丕丂万丝丁丌丞业();
            }
            
            return val_4.丘丕丂万丝丁丌丞业();
        }
        internal PetInfo 丛丐不丐丘丘万丒丂(string 世丐丗专丅三丝丑丆)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  世丐丗专丅三丝丑丆)) == true)
            {
                    return (PetInfo)0;
            }
            
            if((Rilisoft.PetsManager.专丘丞下万丅丒丐丒().ContainsKey(key:  世丐丗专丅三丝丑丆)) != false)
            {
                    PetInfo val_5 = Rilisoft.PetsManager.专丘丞下万丅丒丐丒().Item[世丐丗专丅三丝丑丆];
                return (PetInfo)0;
            }
            
            0 = 0;
            return (PetInfo)0;
        }
        internal static bool 丌丈万丆一丒不世三(string 世丐丗专丅三丝丑丆)
        {
            System.Collections.Generic.Dictionary<System.String, PetInfo> val_1 = Rilisoft.PetsManager.专丘丞下万丅丒丐丒();
            if(val_1 != null)
            {
                    return val_1.ContainsKey(key:  世丐丗专丅三丝丑丆);
            }
            
            return val_1.ContainsKey(key:  世丐丗专丅三丝丑丆);
        }
        internal string 东丏丌丕丑丝下丙丏()
        {
            Progress.丏丘丄丆丂丆丛丐丝 val_1 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三();
            if(val_1 != null)
            {
                    return val_1.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  6, 下上丐丆丝丟丝丒不:  "EquppedPetSN");
            }
            
            return val_1.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  6, 下上丐丆丝丟丝丒不:  "EquppedPetSN");
        }
        internal void 丛东丗丈丏下丒业丒(string 世丐丗专丅三丝丑丆, bool 丘专丑丕且且丄专丁 = True)
        {
            var val_12;
            System.Action<System.String, System.String> val_13;
            bool val_2 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  世丐丗专丅三丝丑丆);
            if(val_2 != true)
            {
                    if((val_2.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆, 丞世不丒下上上丝丑: out  0)) == null)
            {
                goto label_4;
            }
            
            }
            
            if(丘专丑丕且且丄专丁 != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  6, 下上丐丆丝丟丝丒不:  "EquppedPetSN", 下下丏一丙不丘丌丞:  世丐丗专丅三丝丑丆);
            }
            else
            {
                    if((System.String.op_Inequality(a:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  6, 下上丐丆丝丟丝丒不:  "EquppedPetSN"), b:  世丐丗专丅三丝丑丆)) != false)
            {
                    Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().上东丌丟丁丑丅丟丛(丙一丗丂三丕专七丏:  6, 下上丐丆丝丟丝丒不:  "EquppedPetSN", 丙业与丙丗丝不丈东:  世丐丗专丅三丝丑丆);
                Progress.丏丘丄丆丂丆丛丐丝 val_10 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三();
            }
            
            }
            
            val_12 = null;
            val_12 = null;
            val_13 = Rilisoft.PetsManager.丂丒世丘丌丈世世丐;
            if(val_13 == null)
            {
                    return;
            }
            
            val_13 = Rilisoft.PetsManager.丂丒世丘丌丈世世丐;
            if(val_13 == null)
            {
                    val_13 = 0;
            }
            
            val_13.Invoke(arg1:  世丐丗专丅三丝丑丆, arg2:  this.东丏丌丕丑丝下丙丏());
            return;
            label_4:
            object[] val_11 = new object[1];
            val_11[0] = 世丐丗专丅三丝丑丆;
            UnityEngine.Debug.LogErrorFormat(format:  "[PETS] pet \'{0}\' not found", args:  val_11);
        }
        internal bool 七丗世且东丞丙丏丟(string 世丐丗专丅三丝丑丆)
        {
            return (bool)((this.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆, 丞世不丒下上上丝丑: out  0)) != 0) ? 1 : 0;
        }
        internal 七下下业三丞专丈丛 丆万一与世丒丙丌丝(string 世丐丗专丅三丝丑丆)
        {
            return (七下下业三丞专丈丛)this.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆, 丞世不丒下上上丝丑: out  0);
        }
        internal 七下下业三丞专丈丛 丆万一与世丒丙丌丝(string 世丐丗专丅三丝丑丆, out int 丞世不丒下上上丝丑)
        {
            var val_7;
            var val_8;
            val_7 = 1152921543379778896;
            int val_3 = 0;
            丞世不丒下上上丝丑 = 0;
            val_8 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  世丐丗专丅三丝丑丆)) == true)
            {
                    return (七下下业三丞专丈丛)val_8;
            }
            
            if((丟下七丘下下丙丗丅.丗丁七东丂丌丙与丕().TryGetValue(key:  世丐丗专丅三丝丑丆, value: out  val_3)) != false)
            {
                    丞世不丒下上上丝丑 = 0;
                val_7 = val_3;
                七下下业三丞专丈丛 val_6 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().且丒丑丙万东业丟丕(丄丈丞丒且东丝下一:  0);
                return (七下下业三丞专丈丛)val_8;
            }
            
            val_8 = 0;
            return (七下下业三丞专丈丛)val_8;
        }
        internal void 下丘丞丙丛丙丙丄与(string 世丐丗专丅三丝丑丆, string 专丐下丙丐七丑丑丂)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专丐下丙丐七丑丑丂)) == true)
            {
                    return;
            }
            
            bool val_3 = System.String.op_Equality(a:  专丐下丙丐七丑丑丂.Trim(), b:  System.String.alignConst);
            if(val_3 == true)
            {
                    return;
            }
            
            if((val_3.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆, 丞世不丒下上上丝丑: out  0)) == null)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  val_5.专丕与丒丗丁丘专丟, b:  专丐下丙丐七丑丑丂)) != false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三且丆专丅万丗丈丌(丄丈丞丒且东丝下一:  val_5.丐丒且丝丛丁丕丟丅, 专丐下丙丐七丑丑丂:  丞东丑专丛丆丄丝世.丁丈丛且丟丘丂丙万(丙业与丙丗丝不丈东:  专丐下丙丐七丑丑丂), 丁丒且专丗丂丕不业:  2);
        }
        internal bool 丏专丟丒万丑丐不丞(string 世丐丗专丅三丝丑丆, int 丒七且一东丂丐丛丒)
        {
            int val_20;
            string val_21;
            int val_22;
            var val_23;
            var val_24;
            val_20 = 丒七且一东丂丐丛丒;
            val_21 = 世丐丗专丅三丝丑丆;
            val_22 = this.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_21);
            if(val_22 == null)
            {
                goto label_1;
            }
            
            if(val_20 <= 0)
            {
                    object[] val_2 = new object[1];
                val_2[0] = val_20;
                UnityEngine.Debug.LogErrorFormat(format:  "incorrect cards add or update pet {0}", args:  val_2);
                val_20 = 1;
            }
            
            Progress.下丁下丂七丆丙七一 val_3 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_3.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  254);
            if((val_3.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_21, 丞世不丒下上上丝丑: out  0)) == null)
            {
                goto label_12;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丘丑东丆丝万丆七丌(丄丈丞丒且东丝下一:  val_5.丐丒且丝丛丁丕丟丅, 丌世丄七丐一上丒丂:  1, 丁丒且专丗丂丕不业:  0);
            val_22 = 1152921505481658368;
            Rilisoft.PetsManager.丐丐且上丒丒丑丄丆(世丐丗专丅三丝丑丆:  val_21);
            if((Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  val_21)) == false)
            {
                goto label_26;
            }
            
            val_22 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_23 = null;
            val_23 = null;
            val_22.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丗世丈丂丒丞专上丟:  (Rilisoft.PetsManager.丑丑专丕上七丑丕丐(世丐丗专丅三丝丑丆:  val_21)) * val_20, 世丁丙世丄一万丆三:  7, 丛丞万三下丘七丌丅:  true);
            goto label_26;
            label_1:
            object[] val_11 = new object[1];
            val_11[0] = val_21;
            UnityEngine.Debug.LogErrorFormat(format:  "[PETS] pet data \'{0}\' not found", args:  val_11);
            val_24 = 0;
            return (bool)val_24;
            label_12:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄丘与丅丆万丟丈丆(丄丈丞丒且东丝下一:  val_22.Index, 丏丆三丐且丟丁东丙:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丘丑东丆丝万丆七丌(丄丈丞丒且东丝下一:  val_22.Index, 丌世丄七丐一上丒丂:  1, 丁丒且专丗丂丕不业:  0);
            val_22 = val_22.Index;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三且丆专丅万丗丈丌(丄丈丞丒且东丝下一:  val_22, 专丐下丙丐七丑丑丂:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1.Lkey), 丁丒且专丗丂丕不业:  0);
            Rilisoft.PetsManager.丐丐且上丒丒丑丄丆(世丐丗专丅三丝丑丆:  val_21);
            label_26:
            Rilisoft.PetsManager.丅业下三丂业丘丌丕();
            val_21 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_21.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            val_24 = 1;
            return (bool)val_24;
        }
        private static void 丅业下三丂业丘丌丕()
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Rilisoft.PetsManager.一丁三丏丗丘与丆丌;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Rilisoft.PetsManager.一丁三丏丗丘与丆丌;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        private static void 丐丐且上丒丒丑丄丆(string 世丐丗专丅三丝丑丆)
        {
            var val_1;
            System.Action<System.String> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Rilisoft.PetsManager.丄丞丞丕丘一业丞丕;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Rilisoft.PetsManager.丄丞丞丕丘一业丞丕;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  世丐丗专丅三丝丑丆);
        }
        internal bool 丌上七丕专一东丝丏(string 世丐丗专丅三丝丑丆)
        {
            System.Object[] val_6;
            string val_7;
            var val_8;
            if((this.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆, 丞世不丒下上上丝丑: out  0)) == null)
            {
                goto label_1;
            }
            
            int val_3 = BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  0, 且万丛丒丁丏七丅东:  val_2.万丄丅丛下丐丒丞上, 丐丏上业丈丂与万丞:  false);
            if(val_2.专下与丑三丏丂不丆 >= val_3)
            {
                goto label_4;
            }
            
            val_6 = new object[1];
            val_6[0] = 世丐丗专丅三丝丑丆;
            val_7 = "[PETS] pet \'{0}\' buy error: lacks points";
            goto label_11;
            label_1:
            object[] val_5 = new object[1];
            val_6 = val_5;
            val_6[0] = 世丐丗专丅三丝丑丆;
            val_7 = "[PETS] pet \'{0}\' not found";
            label_11:
            UnityEngine.Debug.LogErrorFormat(format:  val_7, args:  val_5);
            val_8 = 0;
            return (bool)val_8;
            label_4:
            val_3.丑丘丏丏丐下丄丂不(丞世不丒下上上丝丑:  0, 丒丆不丏丑丞丛东丐:  val_2.万丄丅丛下丐丒丞上, 丕丛七丏丝丒丟丏丘:  val_3);
            val_8 = 1;
            return (bool)val_8;
        }
        internal void 丑丘丏丏丐下丄丂不(int 丞世不丒下上上丝丑, int 丒丆不丏丑丞丛东丐, int 丕丛七丏丝丒丟丏丘)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  17);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().不丛七丛且上下东丟(丄丈丞丒且东丝下一:  丞世不丒下上上丝丑, 丝丈三丐丏丐且一三:  BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  丞世不丒下上上丝丑, 且万丛丒丁丏七丅东:  丒丆不丏丑丞丛东丐, 丐丏上业丈丂与万丞:  false), 丁丒且专丗丂丕不业:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丘丈丅丞丅业丅东丅(丄丈丞丒且东丝下一:  丞世不丒下上上丝丑, 丙业一且丞不丞丂不:  丕丛七丏丝丒丟丏丘, 丁丒且专丗丂丕不业:  0);
            Rilisoft.PetsManager.丅业下三丂业丘丌丕();
            Rilisoft.PetsManager.下且世丐上丈丙丐丞();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private static void 下且世丐上丈丙丐丞()
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Rilisoft.PetsManager.丈东丆且丂丑丗世丅;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Rilisoft.PetsManager.丈东丆且丂丑丗世丅;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        internal bool 丞世丟丙下丆丛丑世(string 世丐丗专丅三丝丑丆)
        {
            string val_8 = 世丐丗专丅三丝丑丆;
            PetInfo val_1 = this.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_8 = 世丐丗专丅三丝丑丆);
            if(val_1 == null)
            {
                    return (bool)((BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_1.Index, 且万丛丒丁丏七丅东:  val_1.CurrentLevel, 丐丏上业丈丂与万丞:  false)) <= val_3.专下与丑三丏丂不丆) ? 1 : 0;
            }
            
            val_8 = val_1.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_8, 丞世不丒下上上丝丑: out  0);
            if(val_8 == null)
            {
                    return (bool)((BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_1.Index, 且万丛丒丁丏七丅东:  val_1.CurrentLevel, 丐丏上业丈丂与万丞:  false)) <= val_3.专下与丑三丏丂不丆) ? 1 : 0;
            }
            
            return (bool)((BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_1.Index, 且万丛丒丁丏七丅东:  val_1.CurrentLevel, 丐丏上业丈丂与万丞:  false)) <= val_3.专下与丑三丏丂不丆) ? 1 : 0;
        }
        internal int 丝丑专不丝丌下丘丄(string 世丐丗专丅三丝丑丆)
        {
            string val_14;
            int val_15;
            int val_16;
            val_14 = 世丐丗专丅三丝丑丆;
            PetInfo val_1 = this.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_14);
            if(val_1 == null)
            {
                    return 0;
            }
            
            if((Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  val_14)) != false)
            {
                    return 0;
            }
            
            val_15 = val_1.CurrentLevel;
            val_16 = 0;
            goto label_5;
            label_10:
            val_16 = (BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_1.Index, 且万丛丒丁丏七丅东:  val_15, 丐丏上业丈丂与万丞:  false)) + val_16;
            val_15 = BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  val_1.Index, 且万丛丒丁丏七丅东:  val_15, 丐丏上业丈丂与万丞:  false);
            label_5:
            int val_9 = BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  val_1.Index);
            if(val_15 < val_9)
            {
                goto label_10;
            }
            
            if((val_9.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_14, 丞世不丒下上上丝丑: out  0)) == null)
            {
                    return UnityEngine.Mathf.Max(a:  0, b:  val_16 = UnityEngine.Mathf.Max(a:  0, b:  val_16 - val_14));
            }
            
            val_14 = val_11.专下与丑三丏丂不丆;
            return UnityEngine.Mathf.Max(a:  0, b:  val_16);
        }
        internal int 丛七七专丞且丅丄万(string 世丐丗专丅三丝丑丆, int 丒七且一东丂丐丛丒)
        {
            var val_8;
            int val_9;
            val_8 = 丒七且一东丂丐丛丒;
            if((this.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆)) != null)
            {
                    bool val_2 = Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆);
                if(val_2 != true)
            {
                    if((val_2.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆, 丞世不丒下上上丝丑: out  0)) != null)
            {
                    val_9 = val_4.万丄丅丛下丐丒丞上;
                int val_5 = BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  0);
                if(val_9 >= val_5)
            {
                    return (int)val_9;
            }
            
                val_8 = val_4.专下与丑三丏丂不丆 + val_8;
                do
            {
                val_8 = val_8 - (BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  0, 且万丛丒丁丏七丅东:  val_9, 丐丏上业丈丂与万丞:  false));
                if(val_9 < val_5)
            {
                    return (int)val_9;
            }
            
                val_9 = BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  0, 且万丛丒丁丏七丅东:  val_9, 丐丏上业丈丂与万丞:  false);
            }
            while(val_9 < val_5);
            
                return (int)val_9;
            }
            
            }
            
            }
            
            val_9 = 0;
            return (int)val_9;
        }
        internal bool 丑专上丌专业丁丌三(string 世丐丗专丅三丝丑丆)
        {
            var val_9;
            PetInfo val_10 = this.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆);
            if(val_10 == null)
            {
                    return (bool)(val_6.Count > 0) ? 1 : 0;
            }
            
            val_10 = val_10.CurrentLevel;
            if((BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  val_10.Index, 且万丛丒丁丏七丅东:  val_10, 丐丏上业丈丂与万丞:  false)) > ExperienceController.丞丞丘业东丙丏七丌())
            {
                    val_9 = 0;
                return (bool)(val_6.Count > 0) ? 1 : 0;
            }
            
            System.Collections.Generic.List<Rilisoft.GameCurrencyData> val_6 = BalanceController.丕丙丛且丏三上不丛(丆万一不丌且东丐丐:  世丐丗专丅三丝丑丆, 万业丁七与丟丁东与:  true);
            if(val_6 == null)
            {
                    return (bool)(val_6.Count > 0) ? 1 : 0;
            }
            
            return (bool)(val_6.Count > 0) ? 1 : 0;
        }
        internal static bool 丌丝丄丟丅业且丗丂(string 世丐丗专丅三丝丑丆)
        {
            string val_9;
            var val_10;
            val_9 = 世丐丗专丅三丝丑丆;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != true)
            {
                    if((Rilisoft.PetsManager.专丘丞下万丅丒丐丒().TryGetValue(key:  val_9, value: out  0)) != false)
            {
                    val_9 = val_3.CurrentLevel;
                var val_8 = (val_9 == (BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  val_3.Index))) ? 1 : 0;
                return (bool)val_10;
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        internal static int 丑丑专丕上七丑丕丐(string 世丐丗专丅三丝丑丆)
        {
            return BalanceController.丒专丝丗三上丝丌丞(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆);
        }
        public PetsManager()
        {
        
        }
        private static PetsManager()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_cat");
            }
            else
            {
                    val_1.Add(item:  "pet_cat");
            }
            
            val_1.Add(item:  "pet_dog");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_parrot");
            }
            else
            {
                    val_1.Add(item:  "pet_parrot");
            }
            
            val_1.Add(item:  "pet_rabbit");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_cat_2");
            }
            else
            {
                    val_1.Add(item:  "pet_cat_2");
            }
            
            val_1.Add(item:  "pet_dachshund");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_goat");
            }
            else
            {
                    val_1.Add(item:  "pet_goat");
            }
            
            val_1.Add(item:  "pet_cat_3");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_bat");
            }
            else
            {
                    val_1.Add(item:  "pet_bat");
            }
            
            val_1.Add(item:  "pet_fox");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_penguin");
            }
            else
            {
                    val_1.Add(item:  "pet_penguin");
            }
            
            val_1.Add(item:  "pet_wolf");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_sheep");
            }
            else
            {
                    val_1.Add(item:  "pet_sheep");
            }
            
            val_1.Add(item:  "pet_raccoon");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_husky");
            }
            else
            {
                    val_1.Add(item:  "pet_husky");
            }
            
            val_1.Add(item:  "pet_boar");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_ram");
            }
            else
            {
                    val_1.Add(item:  "pet_ram");
            }
            
            val_1.Add(item:  "pet_crab");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_owl");
            }
            else
            {
                    val_1.Add(item:  "pet_owl");
            }
            
            val_1.Add(item:  "pet_snake");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_lion");
            }
            else
            {
                    val_1.Add(item:  "pet_lion");
            }
            
            val_1.Add(item:  "pet_panda");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_red_panda");
            }
            else
            {
                    val_1.Add(item:  "pet_red_panda");
            }
            
            val_1.Add(item:  "pet_tukan");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_meerkat");
            }
            else
            {
                    val_1.Add(item:  "pet_meerkat");
            }
            
            val_1.Add(item:  "pet_robo_dog");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_porcupine");
            }
            else
            {
                    val_1.Add(item:  "pet_porcupine");
            }
            
            val_1.Add(item:  "pet_zombiecat");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_eagle");
            }
            else
            {
                    val_1.Add(item:  "pet_eagle");
            }
            
            val_1.Add(item:  "pet_deer");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_polarbear");
            }
            else
            {
                    val_1.Add(item:  "pet_polarbear");
            }
            
            val_1.Add(item:  "pet_monkey");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_alien_cat");
            }
            else
            {
                    val_1.Add(item:  "pet_alien_cat");
            }
            
            val_1.Add(item:  "pet_bear");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_hyena");
            }
            else
            {
                    val_1.Add(item:  "pet_hyena");
            }
            
            val_1.Add(item:  "pet_kangaroo");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_skunk");
            }
            else
            {
                    val_1.Add(item:  "pet_skunk");
            }
            
            val_1.Add(item:  "pet_ostrich");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_pterodactyl");
            }
            else
            {
                    val_1.Add(item:  "pet_pterodactyl");
            }
            
            val_1.Add(item:  "pet_dinosaur");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_arnold_3000");
            }
            else
            {
                    val_1.Add(item:  "pet_arnold_3000");
            }
            
            val_1.Add(item:  "pet_chicken");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_paradehorse");
            }
            else
            {
                    val_1.Add(item:  "pet_paradehorse");
            }
            
            val_1.Add(item:  "pet_rhino");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_tiger");
            }
            else
            {
                    val_1.Add(item:  "pet_tiger");
            }
            
            val_1.Add(item:  "pet_panther");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_horse");
            }
            else
            {
                    val_1.Add(item:  "pet_horse");
            }
            
            val_1.Add(item:  "pet_unicorn");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_phoenix");
            }
            else
            {
                    val_1.Add(item:  "pet_phoenix");
            }
            
            val_1.Add(item:  "pet_magical_dragon");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_griffin");
            }
            else
            {
                    val_1.Add(item:  "pet_griffin");
            }
            
            val_1.Add(item:  "pet_eaglespirit");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_mammoth");
            }
            else
            {
                    val_1.Add(item:  "pet_mammoth");
            }
            
            val_1.Add(item:  "pet_sabertooth_tiger");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_raven");
            }
            else
            {
                    val_1.Add(item:  "pet_raven");
            }
            
            val_1.Add(item:  "pet_trex");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_cyberphoenix");
            }
            else
            {
                    val_1.Add(item:  "pet_cyberphoenix");
            }
            
            val_1.Add(item:  "pet_blocston_dogmatics");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_turkey");
            }
            else
            {
                    val_1.Add(item:  "pet_turkey");
            }
            
            val_1.Add(item:  "pet_armadillo");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_griffin_owl");
            }
            else
            {
                    val_1.Add(item:  "pet_griffin_owl");
            }
            
            val_1.Add(item:  "pet_squirrel");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_tactical_ferret");
            }
            else
            {
                    val_1.Add(item:  "pet_tactical_ferret");
            }
            
            val_1.Add(item:  "pet_stone_elemental");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_fighting_turtle");
            }
            else
            {
                    val_1.Add(item:  "pet_fighting_turtle");
            }
            
            val_1.Add(item:  "pet_knitted_pony");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_stone");
            }
            else
            {
                    val_1.Add(item:  "pet_stone");
            }
            
            val_1.Add(item:  "pet_horse_figure");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_lucky_duck");
            }
            else
            {
                    val_1.Add(item:  "pet_lucky_duck");
            }
            
            val_1.Add(item:  "pet_green_novice");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_headbug");
            }
            else
            {
                    val_1.Add(item:  "pet_headbug");
            }
            
            val_1.Add(item:  "pet_chick01");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_pocket_demon");
            }
            else
            {
                    val_1.Add(item:  "pet_pocket_demon");
            }
            
            val_1.Add(item:  "pet_flappy_fish");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_zazou");
            }
            else
            {
                    val_1.Add(item:  "pet_zazou");
            }
            
            val_1.Add(item:  "pet_pga_statue");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_vacuum_helpbro_2000");
            }
            else
            {
                    val_1.Add(item:  "pet_vacuum_helpbro_2000");
            }
            
            val_1.Add(item:  "pet_ice_dragon_egg");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_combat_robb_e");
            }
            else
            {
                    val_1.Add(item:  "pet_combat_robb_e");
            }
            
            val_1.Add(item:  "pet_small_floppa");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_sacred_scarab");
            }
            else
            {
                    val_1.Add(item:  "pet_sacred_scarab");
            }
            
            val_1.Add(item:  "pet_mecha_cat");
            if(val_1 != null)
            {
                    val_1.Add(item:  "pet_zombie_head");
            }
            else
            {
                    val_1.Add(item:  "pet_zombie_head");
            }
            
            val_1.Add(item:  "pet_support_piglet");
            val_1.Add(item:  "pet_firefly_cat");
            Rilisoft.PetsManager.上丆丐万丘丘下丑丗 = val_1;
            Rilisoft.PetsManager.上七专丗下下丛三七 = new string[0];
        }
    
    }

}
