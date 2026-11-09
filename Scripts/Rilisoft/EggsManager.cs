using UnityEngine;

namespace Rilisoft
{
    public class EggsManager : Singleton<Rilisoft.EggsManager>
    {
        // Fields
        internal static readonly int 七丄三丆丅丆下与丆;
        private const float 下一丌业丘丄丙丟丟 = 1;
        private static System.Action<PGCompany.EggIncubatorProgress> 丘丈丝丗丕丆一丁丄;
        private static System.Action<PGCompany.EggIncubatorProgress> 万丄专与万丝下丞丅;
        private static System.Action<PGCompany.EggIncubatorProgress> 万专业一丑丌一业世;
        private static System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<string, int>, PGCompany.丝不丅丗丄丄与丌丘> 丂丘丙丏下下丗且世;
        private static string[] 丗丘丏万一万丕丂丟;
        private static System.Collections.Generic.List<string> 专丛丞丙上丂七丐上;
        
        // Properties
        internal static long 丏一丛丗丝丘丆丌专 { get; }
        
        // Methods
        internal void 丌丘丞上丑丈丂丞丄(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, System.Action 丑万丞丟丂丐丁三丛, System.Action 丘丐东丄丁万丞丅丟)
        {
            System.Action val_6 = 丘丐东丄丁万丞丅丟;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  1);
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                goto label_5;
            }
            
            val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_6.下且上丛丞一东不不(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞, 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
            if(丑万丞丟丂丐丁三丛 == null)
            {
                goto label_9;
            }
            
            goto label_8;
            label_5:
            if(val_6 == null)
            {
                goto label_9;
            }
            
            label_8:
            val_6.Invoke();
            label_9:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal void 世业丟丆丞丗丆万丅(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, System.Action 丑万丞丟丂丐丁三丛, System.Action 丘丐东丄丁万丞丅丟)
        {
            System.Action val_6 = 丘丐东丄丁万丞丅丟;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  2);
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                goto label_5;
            }
            
            val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_6.下且上丛丞一东不不(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞, 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
            if(丑万丞丟丂丐丁三丛 == null)
            {
                goto label_9;
            }
            
            goto label_8;
            label_5:
            if(val_6 == null)
            {
                goto label_9;
            }
            
            label_8:
            val_6.Invoke();
            label_9:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal static long 丅丘七世上丘且丗不()
        {
            return FriendsController.丝丗专上三不丄丑丑();
        }
        internal static void 下丗七且上三丑丄业(System.Action<PGCompany.EggIncubatorProgress> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.EggsManager.丘丈丝丗丕丆一丁丄, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.丘丈丝丗丕丆一丁丄 != 1152921505443483656);
        
        }
        internal static void 丟三万丐丛丏丑丝丝(System.Action<PGCompany.EggIncubatorProgress> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.EggsManager.丘丈丝丗丕丆一丁丄, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.丘丈丝丗丕丆一丁丄 != 1152921505443483656);
        
        }
        internal static void 丞丈丅世丆丐丛丕丌(System.Action<PGCompany.EggIncubatorProgress> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.EggsManager.万丄专与万丝下丞丅, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.万丄专与万丝下丞丅 != 1152921505443483664);
        
        }
        internal static void 专七丕三业丗丑丞丌(System.Action<PGCompany.EggIncubatorProgress> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.EggsManager.万丄专与万丝下丞丅, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.万丄专与万丝下丞丅 != 1152921505443483664);
        
        }
        internal static void 丟丁丞丈丕丏东丅丅(System.Action<PGCompany.EggIncubatorProgress> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.EggsManager.万专业一丑丌一业世, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.万专业一丑丌一业世 != 1152921505443483672);
        
        }
        internal static void 一下丗丒丛下丘丞丗(System.Action<PGCompany.EggIncubatorProgress> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.EggsManager.万专业一丑丌一业世, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.万专业一丑丌一业世 != 1152921505443483672);
        
        }
        internal static void 七丙丏丏东业丄丝专(System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<string, int>, PGCompany.丝不丅丗丄丄与丌丘> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.EggsManager.丂丘丙丏下下丗且世, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.丂丘丙丏下下丗且世 != 1152921505443483680);
        
        }
        internal static void 丅不七不三丞丈丝七(System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<string, int>, PGCompany.丝不丅丗丄丄与丌丘> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.EggsManager.丂丘丙丏下下丗且世, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.EggsManager.丂丘丙丏下下丗且世 != 1152921505443483680);
        
        }
        private void OnInstanceCreated()
        {
        
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丆丂上世万不丞上世());
        }
        internal bool 丄丞丂丟丗三丗丙丝(string 丈丕丁丘七丙丞不丙)
        {
            System.Collections.Generic.Dictionary<System.String, PGCompany.丑丝丟与丘丐丏上三> val_1 = PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑();
            if(val_1 != null)
            {
                    return val_1.ContainsKey(key:  丈丕丁丘七丙丞不丙);
            }
            
            return val_1.ContainsKey(key:  丈丕丁丘七丙丞不丙);
        }
        internal PGCompany.EggIncubatorProgress 丆丙丆不丟且三丗丕(string 丞丅上丏丂且下丅与)
        {
            var val_11;
            var val_12;
            System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_2 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄();
            if(val_2 == null)
            {
                    return (PGCompany.EggIncubatorProgress)val_2.Item[0];
            }
            
            val_11 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丅上丏丂且下丅与)) == true)
            {
                    return (PGCompany.EggIncubatorProgress)val_2.Item[0];
            }
            
            if(val_2.Count >= 1)
            {
                    val_12 = 0;
                do
            {
                PGCompany.EggIncubatorProgress val_5 = val_2.Item[0];
                if((System.String.op_Equality(a:  val_5.Id.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture), b:  丞丅上丏丂且下丅与)) == true)
            {
                    return (PGCompany.EggIncubatorProgress)val_2.Item[0];
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < val_2.Count);
            
            }
            
            val_11 = 0;
            return (PGCompany.EggIncubatorProgress)val_2.Item[0];
        }
        internal PGCompany.丕下丆丑万世业丈丟 丁世丌丝丙丞丑丄世()
        {
            System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_8 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄();
            if(val_8 == null)
            {
                    return (PGCompany.丕下丆丑万世业丈丟)val_8;
            }
            
            if(val_8.Count >= 1)
            {
                    var val_8 = 0;
                do
            {
                if(val_8.Item[0] != null)
            {
                    if((val_4.IncubationStart & 9223372036854775808) == 0)
            {
                goto label_7;
            }
            
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_8.Count);
            
            }
            
            val_8 = 0;
            return (PGCompany.丕下丆丑万世业丈丟)val_8;
            label_7:
            PGCompany.丕下丆丑万世业丈丟 val_7 = null;
            val_8 = val_7;
            val_7 = new PGCompany.丕下丆丑万世业丈丟(三万万丒丏丒不丐丙:  val_8.Item[0]);
            return (PGCompany.丕下丆丑万世业丈丟)val_8;
        }
        internal System.Collections.Generic.List<PGCompany.EggIncubatorProgress> 丘七上丈丘丙不丈丆()
        {
            return System.Linq.Enumerable.ToList<PGCompany.EggIncubatorProgress>(source:  System.Linq.Enumerable.Where<PGCompany.EggIncubatorProgress>(source:  Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄(), predicate:  new System.Func<PGCompany.EggIncubatorProgress, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.EggsManager::丅与丛丈不业丅上丄(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且))));
        }
        internal int 一且丂不丈丝丗一丆()
        {
            var val_10;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
            {
                    System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_3 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄();
                if((val_3 != null) && (val_3.Count >= 1))
            {
                    val_10 = 0;
                var val_10 = 0;
                do
            {
                if(val_3.Item[0] != null)
            {
                    val_10 = val_10 + (this.丒丆丁丘丈丏丆丌丘(上丕丈丞丌丘丅不与:  val_3.Item[0]));
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < val_3.Count);
            
                return (int)val_10;
            }
            
            }
            
            val_10 = 0;
            return (int)val_10;
        }
        internal PGCompany.EggIncubatorProgress 万丅业丛丄丟丙丟丗()
        {
            var val_9;
            var val_10;
            System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_2 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄();
            if(val_2 == null)
            {
                    return (PGCompany.EggIncubatorProgress)val_2.Item[0];
            }
            
            if(val_2.Count >= 1)
            {
                    val_10 = 0;
                do
            {
                if(val_2.Item[0] != null)
            {
                    if((this.丒丆丁丘丈丏丆丌丘(上丕丈丞丌丘丅不与:  val_2.Item[0])) == true)
            {
                    return (PGCompany.EggIncubatorProgress)val_2.Item[0];
            }
            
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < val_2.Count);
            
            }
            
            val_9 = 0;
            return (PGCompany.EggIncubatorProgress)val_2.Item[0];
        }
        internal System.Collections.Generic.List<PGCompany.EggIncubatorProgress> 丐丙丛丏专世丛不丄()
        {
            Progress.丑专三下三丈丟三丂 val_1 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑();
            if(val_1 != null)
            {
                    return val_1.丐丙丛丏专世丛不丄();
            }
            
            return val_1.丐丙丛丏专世丛不丄();
        }
        internal System.Collections.Generic.List<PGCompany.EggIncubatorProgress> 丏丏且丛丘三且东丕(bool 东万丛丆丐丌丝丞不)
        {
            EggsManager.丘丞三且东万丕丙丂 val_1 = new EggsManager.丘丞三且东万丕丙丂();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .东万丛丆丐丌丝丞不 = 东万丛丆丐丌丝丞不;
            return System.Linq.Enumerable.ToList<PGCompany.EggIncubatorProgress>(source:  System.Linq.Enumerable.Where<PGCompany.EggIncubatorProgress>(source:  Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄(), predicate:  new System.Func<PGCompany.EggIncubatorProgress, System.Boolean>(object:  val_1, method:  System.Boolean EggsManager.丘丞三且东万丕丙丂::不丙丒丂不丂七丄丟(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且))));
        }
        internal static PGCompany.丑丝丟与丘丐丏上三 万万丛世丅下丟丟丅(string 丈丕丁丘七丙丞不丙)
        {
            string val_7;
            var val_8;
            val_7 = 丈丕丁丘七丙丞不丙;
            PGCompany.丑丝丟与丘丐丏上三 val_4 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) != false)
            {
                    val_7 = System.Array.Empty<System.Object>();
                UnityEngine.Debug.LogErrorFormat(format:  "get egg data id null or empty {0}", args:  val_7);
                val_8 = 0;
                return (PGCompany.丑丝丟与丘丐丏上三)val_8;
            }
            
            bool val_5 = PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑().TryGetValue(key:  val_7, value: out  val_4);
            val_8 = val_4;
            if(val_8 != 0)
            {
                    return (PGCompany.丑丝丟与丘丐丏上三)val_8;
            }
            
            object[] val_6 = new object[1];
            val_6[0] = val_7;
            UnityEngine.Debug.LogFormat(format:  "data not found id: \'{0}\'", args:  val_6);
            val_8 = val_4;
            return (PGCompany.丑丝丟与丘丐丏上三)val_8;
        }
        internal void 丞丝下丄丆且丌丈丐(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕)
        {
            if(世丕丘丈丙世业东丕 == null)
            {
                    return;
            }
            
            this.丞丝下丄丆且丌丈丐(丈丕丁丘七丙丞不丙:  世丕丘丈丙世业东丕.丅丙丛丑丌丆丌丕丒().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
        }
        internal void 丞丝下丄丆且丌丈丐(string 丈丕丁丘七丙丞不丙)
        {
            int val_7;
            bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丈丕丁丘七丙丞不丙);
            if(val_1 != false)
            {
                    return;
            }
            
            PGCompany.EggIncubatorProgress val_2 = val_1.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  丈丕丁丘七丙丞不丙);
            if(val_2 != null)
            {
                    NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  2);
                val_7 = 60;
                if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  val_2.DataId)) != null)
            {
                    val_7 = val_3.与丐丄丑上丌丑丅丘 * val_7;
            }
            
                Progress.下丁下丂七丆丙七一 val_4 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_4.丈丌丁业丟丐丑下世(三万万丒丏丒不丐丙:  val_2, 与丕丌丒丗丄丘丙东:  Rilisoft.EggsManager.丅丘七世上丘且丗不(), 三丗丞且丛上东丛丗:  val_7);
                val_4.丅丟丈下丁丌三丛丟(三万万丒丏丒不丐丙:  val_2);
                return;
            }
            
            object[] val_6 = new object[1];
            val_6[0] = 丈丕丁丘七丙丞不丙;
            UnityEngine.Debug.LogErrorFormat(format:  "start egg: no egg {0}", args:  val_6);
        }
        private void 丅丟丈下丁丌三丛丟(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
            var val_1;
            System.Action<PGCompany.EggIncubatorProgress> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Rilisoft.EggsManager.万丄专与万丝下丞丅;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Rilisoft.EggsManager.万丄专与万丝下丞丅;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  三万万丒丏丒不丐丙);
        }
        internal PGCompany.EggIncubatorProgress 丙丙万丒世丏世下丟(string 丈丕丁丘七丙丞不丙)
        {
            return this.丙丙万丒世丏世下丟(一丐丗丁丞丆丅丟丄:  Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  丈丕丁丘七丙丞不丙));
        }
        internal PGCompany.EggIncubatorProgress 丙丙万丒世丏世下丟(PGCompany.丑丝丟与丘丐丏上三 一丐丗丁丞丆丅丟丄)
        {
            var val_13;
            System.Func<PGCompany.EggIncubatorProgress, System.Int32> val_15;
            var val_16;
            PGCompany.EggIncubatorProgress val_17;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                goto label_1;
            }
            
            if(Rilisoft.EggsManager.丅丘七世上丘且丗不() <= 0)
            {
                    if(一丐丗丁丞丆丅丟丄.丘不丘丏丟丕七专丒() == 0)
            {
                goto label_5;
            }
            
            }
            
            System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_4 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄();
            if(val_4.Count < 1)
            {
                goto label_10;
            }
            
            val_13 = null;
            val_13 = null;
            val_15 = EggsManager.<>c.<>9__33_0;
            if(val_15 == null)
            {
                    System.Func<PGCompany.EggIncubatorProgress, System.Int32> val_6 = null;
                val_15 = val_6;
                val_6 = new System.Func<PGCompany.EggIncubatorProgress, System.Int32>(object:  EggsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 EggsManager.<>c::丏不丕丁丈丁丟丗丑(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且));
                EggsManager.<>c.<>9__33_0 = val_15;
            }
            
            val_16 = (System.Linq.Enumerable.Max<PGCompany.EggIncubatorProgress>(source:  val_4, selector:  val_6)) + 1;
            goto label_16;
            label_1:
            label_25:
            UnityEngine.Debug.LogErrorFormat(format:  "egg data is null", args:  System.Array.Empty<System.Object>());
            val_17 = 0;
            return val_17;
            label_10:
            val_16 = 1;
            label_16:
            PGCompany.EggIncubatorProgress val_10 = null;
            val_17 = val_10;
            val_10 = new PGCompany.EggIncubatorProgress(专上丗丐万七一丟丕:  一丐丗丁丞丆丅丟丄.业上丙丞丐丄丆丅七(), 丙下不丏丅丅专丂丗:  1);
            Progress.下丁下丂七丆丙七一 val_11 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_11.丙丙万丒世丏世下丟(三万万丒丏丒不丐丙:  val_10);
            val_11.上不下世一下且丘丟(三万万丒丏丒不丐丙:  val_10);
            return val_17;
            label_5:
            T[] val_12 = System.Array.Empty<System.Object>();
            goto label_25;
        }
        private void 上不下世一下且丘丟(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
            null = null;
            if(Rilisoft.EggsManager.丘丈丝丗丕丆一丁丄 == null)
            {
                    return;
            }
            
            Rilisoft.EggsManager.丘丈丝丗丕丆一丁丄.Invoke(obj:  三万万丒丏丒不丐丙);
        }
        internal PGCompany.EggIncubatorProgress 万上丞上丗丏东丈不(int 丘丛丆七与丒世下丛)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_10 = null;
            val_10 = null;
            val_11 = BalanceController.丄丞丁丈与业上丞丟.东丙一丏三一丛丆三();
            if(val_11 != null)
            {
                    if(val_11.Count != 0)
            {
                goto label_5;
            }
            
            }
            
            System.Collections.Generic.List<System.Int32> val_3 = null;
            val_11 = val_3;
            val_3 = new System.Collections.Generic.List<System.Int32>();
            val_3.Add(item:  1);
            label_5:
            int val_4 = UnityEngine.Mathf.Abs(value:  丘丛丆七与丒世下丛);
            if(val_11 != null)
            {
                    val_12 = val_3.Count;
            }
            else
            {
                    val_12 = 0.Count;
            }
            
            val_13 = (val_3.Item[val_4 - ((val_4 / val_12) * val_12)]) - 1;
            if((val_13 & 2147483648) != 0)
            {
                goto label_11;
            }
            
            val_14 = null;
            val_14 = null;
            int val_10 = Rilisoft.EggsManager.丗丘丏万一万丕丂丟.Length;
            val_10 = val_10 - 1;
            if(val_13 <= val_10)
            {
                goto label_15;
            }
            
            label_11:
            val_13 = 0;
            label_15:
            val_15 = null;
            val_15 = null;
            if(val_13 < Rilisoft.EggsManager.丗丘丏万一万丕丂丟.Length)
            {
                    return this.丙丙万丒世丏世下丟(丈丕丁丘七丙丞不丙:  Rilisoft.EggsManager.丗丘丏万一万丕丂丟.Length + 32);
            }
            
            return this.丙丙万丒世丏世下丟(丈丕丁丘七丙丞不丙:  Rilisoft.EggsManager.丗丘丏万一万丕丂丟.Length + 32);
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 业专丌业七丐丞一专(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕, PGCompany.丝不丅丗丄丄与丌丘 世不丈万丛世且下三)
        {
            var val_7;
            System.Object[] val_8;
            string val_9;
            if(世丕丘丈丙世业东丕 == null)
            {
                goto label_1;
            }
            
            val_7 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑();
            PGCompany.EggIncubatorProgress val_3 = val_7.专不丅丌丛且七丕丘(丅世丄下丌与万丛丄:  世丕丘丈丙世业东丕.丅丙丛丑丌丆丌丕丒());
            if(val_3 == null)
            {
                goto label_5;
            }
            
            return this.业专丌业七丐丞一专(三万万丒丏丒不丐丙:  val_3, 世不丈万丛世且下三:  new PGCompany.丝不丅丗丄丄与丌丘() {丌万丑丟上七丐丐丕 = 世不丈万丛世且下三.丌万丑丟上七丐丐丕, 专丈丟上丈丁丛七丒 = 世不丈万丛世且下三.专丈丟上丈丁丛七丒});
            label_1:
            val_8 = System.Array.Empty<System.Object>();
            val_9 = "itemEgg is null";
            goto label_8;
            label_5:
            object[] val_5 = new object[1];
            val_8 = val_5;
            val_8[0] = 世丕丘丈丙世业东丕.丅丙丛丑丌丆丌丕丒();
            val_9 = "unknown egg \'{0}\'";
            label_8:
            UnityEngine.Debug.LogErrorFormat(format:  val_9, args:  val_5);
            return 0;
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 业专丌业七丐丞一专(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙, PGCompany.丝不丅丗丄丄与丌丘 世不丈万丛世且下三)
        {
            var val_11;
            int val_24;
            PGCompany.EggIncubatorProgress val_25;
            var val_26;
            System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<System.String, System.Int32>, PGCompany.丝不丅丗丄丄与丌丘> val_27;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  256);
            int val_4 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Count;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_5 = val_4.七丒万丌专一丝丝丏(专东丘丆丞丛丅丄丆:  三万万丒丏丒不丐丙);
            val_24 = val_5.Count;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_7 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>(capacity:  val_24);
            Dictionary.Enumerator<TKey, TValue> val_8 = val_5.GetEnumerator();
            label_12:
            if(((-699109360) & 1) == 0)
            {
                goto label_8;
            }
            
            ConfiguredValueTaskAwaiter val_12 = val_11.GetAwaiter();
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  val_12._value._obj.丐丏七丌丕丗业且上());
            new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  -699109376);
            val_7.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            bool val_17 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丏专丟丒万丑丐不丞(世丐丗专丅三丝丑丆:  val_12._value._obj.丐丏七丌丕丗业且上(), 丒七且一东丂丐丛丒:  -699109376);
            goto label_12;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_25 = 三万万丒丏丒不丐丙;
            if(val_4 == 0)
            {
                    if(val_5.Count >= 1)
            {
                    System.Collections.Generic.KeyValuePair<System.String, System.Int32> val_20 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>(source:  val_5);
                val_24 = val_20.Value.丐丏七丌丕丗业且上();
                Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛东丗丈丏下丒业丒(世丐丗专丅三丝丑丆:  val_24, 丘专丑丕且且丄专丁:  true);
            }
            
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丆丅世一丅丒丈丝不(三万万丒丏丒不丐丙:  null);
            val_26 = null;
            val_26 = null;
            val_27 = Rilisoft.EggsManager.丂丘丙丏下下丗且世;
            if(val_27 != null)
            {
                    val_27 = Rilisoft.EggsManager.丂丘丙丏下下丗且世;
                if(val_27 == null)
            {
                    val_27 = 0;
            }
            
                val_27.Invoke(arg1:  null, arg2:  val_5, arg3:  new PGCompany.丝不丅丗丄丄与丌丘() {丌万丑丟上七丐丐丕 = 世不丈万丛世且下三.丌万丑丟上七丐丐丕, 专丈丟上丈丁丛七丒 = 世不丈万丛世且下三.专丈丟上丈丁丛七丒});
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return val_7;
        }
        internal void 丒专丏丈万丈丒丒丁(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕, int 丏专且丟丗丘丂丌丘)
        {
            int val_10;
            var val_11;
            val_10 = 丏专且丟丗丘丂丌丘;
            val_11 = this;
            bool val_6 = false;
            if(世丕丘丈丙世业东丕 == null)
            {
                    return;
            }
            
            string val_3 = 世丕丘丈丙世业东丕.丅丙丛丑丌丆丌丕丒().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            PGCompany.EggIncubatorProgress val_4 = val_3.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  val_3);
            if(val_4 == null)
            {
                    return;
            }
            
            bool val_5 = this.丒丆丁丘丈丏丆丌丘(上丕丈丞丌丘丅不与:  val_4);
            if(val_5 == true)
            {
                    return;
            }
            
            if(val_6 != 0)
            {
                    val_10 = UnityEngine.Mathf.Min(a:  val_10, b:  val_5.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  val_4, 丕且七业丙万丕丛丞: out  val_6));
            }
            
            val_11 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_11.不丈万三丞丕丘丅丞(三万万丒丏丒不丐丙:  val_4, 下丌丏且世丏丁丁丌:  val_10);
        }
        private System.Collections.IEnumerator 丆丂上世万不丞上世()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new EggsManager.七丐下丌丄一东丝丕();
        }
        private void 世丄丟三丟丅丒丄丏(PGCompany.EggIncubatorProgress 上丕丈丞丌丘丅不与)
        {
            var val_1;
            System.Action<PGCompany.EggIncubatorProgress> val_2;
            上丕丈丞丌丘丅不与.IsReady = true;
            val_1 = null;
            val_1 = null;
            val_2 = Rilisoft.EggsManager.万专业一丑丌一业世;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Rilisoft.EggsManager.万专业一丑丌一业世;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  上丕丈丞丌丘丅不与);
        }
        internal bool 丒丆丁丘丈丏丆丌丘(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕)
        {
            string val_3 = 世丕丘丈丙世业东丕.丅丙丛丑丌丆丌丕丒().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            return (bool)this.丒丆丁丘丈丏丆丌丘(上丕丈丞丌丘丅不与:  val_3.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  val_3));
        }
        internal bool 丒丆丁丘丈丏丆丌丘(PGCompany.EggIncubatorProgress 上丕丈丞丌丘丅不与)
        {
            var val_3;
            var val_4;
            bool val_1 = false;
            if(上丕丈丞丌丘丅不与 != null)
            {
                    bool val_3 = 上丕丈丞丌丘丅不与.IsReady;
                val_3 = val_3 + 3;
                var val_4 = ~val_3;
                val_4 = val_4 & 3;
                if(val_4 != 0)
            {
                    label_8:
                val_3 = 1;
                return (bool)val_3;
            }
            
                val_4 = null;
                if((上丕丈丞丌丘丅不与.IncubationStart & 9223372036854775808) == 0)
            {
                    if((null.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与, 丕且七业丙万丕丛丞: out  val_1)) <= 0)
            {
                    if(val_1 != 0)
            {
                goto label_8;
            }
            
            }
            
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        internal static PGCompany.东一业丛丑丂丝七丁 丘丞业丈上三丑丘东(PGCompany.EggIncubatorProgress 上丕丈丞丌丘丅不与)
        {
            return 0;
        }
        internal System.Collections.Generic.Dictionary<string, int> 七丒万丌专一丝丝丏(PGCompany.EggIncubatorProgress 专东丘丆丞丛丅丄丆)
        {
            var val_15;
            var val_40;
            var val_41;
            丒七丑与丟丆上丄丐 val_42;
            var val_43;
            System.Collections.Generic.List<System.String> val_44;
            var val_45;
            var val_46;
            var val_47;
            System.Collections.Generic.List<System.String> val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = null;
            val_40 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_41 = 1152921542563395648;
            val_42 = BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  专东丘丆丞丛丅丄丆.DataId);
            val_43 = 0;
            goto label_4;
            label_93:
            if((System.String.op_Equality(a:  专东丘丆丞丛丅丄丆.DataId, b:  "egg_Training")) != false)
            {
                    if(val_1.Count > 0)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Int32>)val_40;
            }
            
            }
            
            val_44 = UnityEngine.Random.Range(min:  0, max:  100);
            if(val_44 < (UnityEngine.Mathf.Clamp(value:  val_5.且世东丝七不丞丐丌, min:  1, max:  100)))
            {
                goto label_90;
            }
            
            int val_8 = UnityEngine.Mathf.Max(a:  0, b:  val_5.上专丝万丏且丕三丈);
            Rilisoft.丝丑丂丛万丐丈丘且 val_39 = val_5.业丑专丒上一专丄丝;
            val_39 = (UnityEngine.Mathf.Max(a:  0, b:  val_39)) + val_8;
            int val_10 = UnityEngine.Random.Range(min:  0, max:  val_39);
            val_45 = null;
            val_45 = null;
            Rilisoft.EggsManager.专丛丞丙上丂七丐上.Clear();
            Dictionary.Enumerator<TKey, TValue> val_12 = 丟下七丘下下丙丗丅.一三专丞丒丅上业上().GetEnumerator();
            label_32:
            if(((-698087696) & 1) == 0)
            {
                goto label_24;
            }
            
            ConfiguredValueTaskAwaiter val_16 = val_15.GetAwaiter();
            if((Rilisoft.EggsManager.丟七丗丄丝业一丈一(丆万丂专丂且专三丅:  val_16._value._obj, 丆下丝三东业丗一丗:  (val_10 < val_8) ? 1 : 0, 丈下丑丆上丏丗丈专:  val_5.丈下丑丆上丏丗丈专)) == false)
            {
                goto label_32;
            }
            
            val_46 = null;
            val_46 = null;
            Rilisoft.EggsManager.专丛丞丙上丂七丐上.Add(item:  val_16._value._obj.丐丏七丌丕丗业且上());
            goto label_32;
            label_24:
            var val_40 = 0;
            val_40 = val_40 + 1;
            mem2[0] = 257;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_42 = val_40;
            if((val_42 != 1) && ((-698087824 + ((0 + 1)) << 2) == 257))
            {
                    var val_41 = 0;
                val_41 = val_41 ^ (val_42 >> 31);
                val_42 = val_42 + val_41;
                val_41 = val_41;
            }
            else
            {
                    val_41 = val_41;
            }
            
            val_47 = null;
            val_40 = val_40;
            val_42 = val_42;
            val_47 = null;
            val_48 = Rilisoft.EggsManager.专丛丞丙上丂七丐上;
            if(val_48.Count >= 1)
            {
                goto label_47;
            }
            
            val_48 = 丟下七丘下下丙丗丅.一三专丞丒丅上业上();
            Dictionary.Enumerator<TKey, TValue> val_23 = val_48.GetEnumerator();
            label_59:
            if(((-698087696) & 1) == 0)
            {
                goto label_51;
            }
            
            ConfiguredValueTaskAwaiter val_24 = val_15.GetAwaiter();
            if((Rilisoft.EggsManager.丟七丗丄丝业一丈一(丆万丂专丂且专三丅:  val_24._value._obj, 丆下丝三东业丗一丗:  (val_10 >= val_8) ? 1 : 0, 丈下丑丆上丏丗丈专:  val_5.丈下丑丆上丏丗丈专)) == false)
            {
                goto label_59;
            }
            
            val_49 = null;
            val_49 = null;
            Rilisoft.EggsManager.专丛丞丙上丂七丐上.Add(item:  val_24._value._obj.丐丏七丌丕丗业且上());
            goto label_59;
            label_51:
            var val_43 = val_42;
            val_43 = val_43 + 1;
            mem2[0] = 474;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_45 = val_43;
            if((val_45 != 1) && ((-698087824 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) == 474))
            {
                    var val_44 = 0;
                val_44 = val_44 ^ (val_45 >> 31);
                val_45 = val_45 + val_44;
            }
            
            val_50 = null;
            val_50 = null;
            val_44 = Rilisoft.EggsManager.专丛丞丙上丂七丐上;
            if(val_44.Count < 1)
            {
                goto label_90;
            }
            
            label_47:
            val_51 = null;
            val_51 = null;
            int val_29 = UnityEngine.Random.Range(min:  0, max:  Rilisoft.EggsManager.专丛丞丙上丂七丐上.Count);
            int val_30 = Rilisoft.EggsManager.丂东一丕丛丐专与万(专不丟丕丞丗三世丂:  val_2.丂丅丘丕一世丐丑丆.Item[0]);
            val_52 = null;
            if((val_1.ContainsKey(key:  Rilisoft.EggsManager.专丛丞丙上丂七丐上.Item[val_29])) == false)
            {
                goto label_80;
            }
            
            val_53 = null;
            val_44 = Rilisoft.EggsManager.专丛丞丙上丂七丐上.Item[val_29];
            if(val_40 == null)
            {
                goto label_84;
            }
            
            val_54 = val_1.Item[val_44];
            goto label_85;
            label_80:
            val_55 = null;
            val_44 = Rilisoft.EggsManager.专丛丞丙上丂七丐上.Item[val_29];
            val_1.Add(key:  val_44, value:  val_30);
            goto label_90;
            label_84:
            val_54 = val_1.Item[val_44];
            label_85:
            val_1.set_Item(key:  val_44, value:  val_54 + val_30);
            label_90:
            val_43 = 1;
            label_4:
            if(val_43 < (val_2 + 56.Count))
            {
                goto label_93;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)val_40;
        }
        private static int 丂东一丕丛丐专与万(丑丛丗丗丕不丘三丆 专不丟丕丞丗三世丂)
        {
            int val_4 = 专不丟丕丞丗三世丂 + 40;
            val_4 = (UnityEngine.Mathf.Max(a:  0, b:  val_4)) + 1;
            return UnityEngine.Random.Range(min:  UnityEngine.Mathf.Max(a:  0, b:  专不丟丕丞丗三世丂.丛下三上丟丘丌业丑), max:  val_4);
        }
        private static bool 丟七丗丄丝业一丈一(PetInfo 丆万丂专丂且专三丅, bool 丆下丝三东业丗一丗, ItemRarity 丈下丑丆上丏丗丈专)
        {
            ItemRarity val_6 = 丈下丑丆上丏丗丈专;
            if((丆万丂专丂且专三丅.Rarity != val_6) || (丆万丂专丂且专三丅.DoNotDropFromEgg == true))
            {
                    return (bool)0 & 1;
            }
            
            val_6 = ExperienceController.丞丞丘业东丙丏七丌();
            if(val_6 < (BalanceController.丟丛丒丞业丂丘东世(世丐丗专丅三丝丑丆:  丆万丂专丂且专三丅.Id)))
            {
                    return (bool)0 & 1;
            }
            
            bool val_6 = (Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.七丗世且东丞丙丏丟(世丐丗专丅三丝丑丆:  丆万丂专丂且专三丅.Id)) ^ 丆下丝三东业丗一丗;
            val_6 = val_6 ^ 1;
            return (bool)0 & 1;
        }
        internal bool 丞丕丞丛丁万丒丏丛(PGCompany.EggIncubatorProgress 上丕丈丞丌丘丅不与)
        {
            if(上丕丈丞丌丘丅不与 == null)
            {
                    return false;
            }
            
            long val_2 = 上丕丈丞丌丘丅不与.IncubationStart;
            val_2 = val_2 >> 63;
            return (bool)val_2 ^ 1;
        }
        internal int 丁业丐丐丆一丙丕丙(PGCompany.EggIncubatorProgress 上丕丈丞丌丘丅不与)
        {
            return (int)this.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与, 丕且七业丙万丕丛丞: out  false);
        }
        internal int 丁业丐丐丆一丙丕丙(PGCompany.EggIncubatorProgress 上丕丈丞丌丘丅不与, out bool 丕且七业丙万丕丛丞)
        {
            丕且七业丙万丕丛丞 = false;
            if(上丕丈丞丌丘丅不与 == null)
            {
                    return 0;
            }
            
            if((上丕丈丞丌丘丅不与.IncubationStart & 9223372036854775808) != 0)
            {
                    return 0;
            }
            
            if((Rilisoft.EggsManager.丅丘七世上丘且丗不() & 9223372036854775808) != 0)
            {
                    return 0;
            }
            
            丕且七业丙万丕丛丞 = true;
            return UnityEngine.Mathf.Max(a:  (上丕丈丞丌丘丅不与.IncubationStart + 上丕丈丞丌丘丅不与.IncubationTime) - Rilisoft.EggsManager.丅丘七世上丘且丗不(), b:  0);
        }
        internal static string 与不丛丛业丁七丏丛(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
            if(三万万丒丏丒不丐丙 != null)
            {
                    return System.String.Format(format:  "Eggs/Textures/{0}_texture", arg0:  三万万丒丏丒不丐丙.DataId);
            }
            
            return System.String.Format(format:  "Eggs/Textures/{0}_texture", arg0:  三万万丒丏丒不丐丙.DataId);
        }
        public EggsManager()
        {
        
        }
        private static EggsManager()
        {
            Rilisoft.EggsManager.下一丌业丘丄丙丟丟 = 2.522337E-42f;
            string[] val_1 = new string[4];
            val_1[0] = "egg_new_simple_time";
            val_1[1] = "egg_new_ancient_time";
            val_1[2] = "egg_new_magical_time";
            val_1[3] = "egg_new_unique_time";
            Rilisoft.EggsManager.丗丘丏万一万丕丂丟 = val_1;
            Rilisoft.EggsManager.专丛丞丙上丂七丐上 = new System.Collections.Generic.List<System.String>(capacity:  丟下七丘下下丙丗丅.一三专丞丒丅上业上().Count);
        }
        private bool 丅与丛丈不业丅上丄(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且)
        {
            var val_3;
            if((丗丛不丁丑专专丂且.IncubationStart & 9223372036854775808) == 0)
            {
                    val_3 = (this.丒丆丁丘丈丏丆丌丘(上丕丈丞丌丘丅不与:  丗丛不丁丑专专丂且)) ^ 1;
                return (bool)val_3 & 1;
            }
            
            val_3 = 0;
            return (bool)val_3 & 1;
        }
    
    }

}
