using UnityEngine;

namespace Rilisoft
{
    internal sealed class PersistentCacheManager : MonoBehaviour
    {
        // Fields
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.PersistentCacheManager> 丝业丆丁业三丈丟东;
        private readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛丞丛丑丑万世丛万> 丂万不丙上丄丐丑丞;
        private readonly System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<string, string>> 万与且丗丈一丏丝丑;
        private readonly System.Collections.Generic.Dictionary<string, string> 不丙与丂丒丑丒与万;
        private System.Threading.CancellationTokenSource 丌丛丆世东丙三丈与;
        
        // Properties
        internal bool 丐丅且丗东丘上与丏 { get; }
        internal System.Threading.Tasks.Task 丏丕上丂且三丏丒丝 { get; }
        internal static Rilisoft.PersistentCacheManager 丆丕丝丒不丙且丐丗 { get; }
        private Rilisoft.丛丞丛丑丑万世丛万 丛丞丛丑丑万世丛万 { get; }
        
        // Methods
        private PersistentCacheManager()
        {
            this.万与且丗丈一丏丝丑 = new System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<System.String, System.String>>();
            this.不丙与丂丒丑丒与万 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.丌丛丆世东丙三丈与 = new System.Threading.CancellationTokenSource();
            this.丂万不丙上丄丐丑丞 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛丞丛丑丑万世丛万>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.丛丞丛丑丑万世丛万>(object:  this, method:  Rilisoft.丛丞丛丑丑万世丛万 Rilisoft.PersistentCacheManager::七业丁东七丘东丒上()));
        }
        internal bool 丌丄一丒且下丅丁丏()
        {
            return (bool)(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19) ? 1 : 0;
        }
        internal System.Threading.Tasks.Task 丐丝丟东丁丘与东世()
        {
            if(this.万与且丗丈一丏丝丑 != null)
            {
                    return this.万与且丗丈一丏丝丑.Task;
            }
            
            return this.万与且丗丈一丏丝丑.Task;
        }
        internal static Rilisoft.PersistentCacheManager 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.PersistentCacheManager.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.PersistentCacheManager.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.PersistentCacheManager.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        private Rilisoft.丛丞丛丑丑万世丛万 丌丁丐丒业丅丙丝丁()
        {
            if(this.丂万不丙上丄丐丑丞 != null)
            {
                    return this.丂万不丙上丄丐丑丞.世三丞丅丑丌丈丈一();
            }
            
            return this.丂万不丙上丄丐丑丞.世三丞丅丑丌丈丈一();
        }
        internal System.Threading.Tasks.Task 丑丌丑七丑丝上丗上()
        {
            float val_15;
            float val_16;
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
            {
                goto label_1;
            }
            
            System.NotSupportedException val_2 = new System.NotSupportedException();
            if(this.万与且丗丈一丏丝丑 == null)
            {
                goto label_2;
            }
            
            bool val_3 = this.万与且丗丈一丏丝丑.TrySetException(exception:  val_2);
            return this.万与且丗丈一丏丝丑.Task;
            label_1:
            this.丌丛丆世东丙三丈与.Cancel();
            this.丌丛丆世东丙三丈与 = new System.Threading.CancellationTokenSource();
            if(UnityEngine.Application.isEditor != false)
            {
                    val_15 = 30f;
            }
            
            if(UnityEngine.Application.isEditor != false)
            {
                    val_16 = 3f;
            }
            
            System.Threading.CancellationToken val_11 = this.丌丛丆世东丙三丈与.Token;
            UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.丟丛丝东万丅丁丁丘(且丛丄丌下丑丁七与:  (与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true) ? 60f : 600f, 丘三丅丒三世丄下且:  (与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true) ? 6f : 60f, 业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_11.m_source}, 世丅丒丆三下专丘丆:  this.万与且丗丈一丏丝丑));
            if(this.万与且丗丈一丏丝丑 != null)
            {
                    return this.万与且丗丈一丏丝丑.Task;
            }
            
            return this.万与且丗丈一丏丝丑.Task;
            label_2:
            bool val_14 = 0.TrySetException(exception:  val_2);
            return this.万与且丗丈一丏丝丑.Task;
        }
        internal string 东且丛且业丗丑丙丗(string 丁丈与业七上不丞丘)
        {
            string val_19;
            string val_20;
            int val_21;
            string val_22;
            var val_23;
            val_20 = 丁丈与业七上不丞丘;
            if(val_20 == null)
            {
                goto label_1;
            }
            
            val_21 = 0;
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
            {
                    return (string)val_21;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_20)) == true)
            {
                goto label_20;
            }
            
            val_19 = 1152921505478782976;
            string val_3 = Rilisoft.PersistentCacheManager.丗东丅不丛七下丄丌(七丙不丅丛丘丗万与:  val_20);
            val_22 = val_3;
            if((System.String.IsNullOrEmpty(value:  val_3)) == true)
            {
                goto label_20;
            }
            
            val_19 = Rilisoft.PersistentCacheManager.丄丑丈丏上丝丆丂丐(东与专丗且丏不与丐:  val_22);
            string val_7 = this.丌丁丐丒业丅丙丝丁().丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  val_19);
            val_20 = val_7;
            if((System.String.IsNullOrEmpty(value:  val_7)) == true)
            {
                goto label_20;
            }
            
            CacheEntry val_9 = UnityEngine.JsonUtility.FromJson<CacheEntry>(json:  val_20);
            val_21 = val_9.payload;
            if((this.不丙与丂丒丑丒与万.TryGetValue(key:  val_22, value: out  0)) == false)
            {
                goto label_16;
            }
            
            val_22 = System.StringComparer.Ordinal;
            if((val_22 & 1) == 0)
            {
                goto label_16;
            }
            
            if(val_21 != null)
            {
                    return (string)val_21;
            }
            
            goto label_20;
            label_16:
            if((this.丌丁丐丒业丅丙丝丁().丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  val_19)) != false)
            {
                    this.丌丁丐丒业丅丙丝丁().丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  val_19, 丙业与丙丗丝不丈东:  System.String.alignConst);
            }
            
            label_20:
            val_21 = System.String.alignConst;
            return (string)val_21;
            label_1:
            System.ArgumentNullException val_16 = new System.ArgumentNullException(paramName:  "keyUrl");
            val_23 = val_16;
            if(0 == 1)
            {
                    if((null & 1) != 0)
            {
                    object[] val_17 = new object[2];
                val_17[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                val_17[1] = val_16;
                UnityEngine.Debug.LogErrorFormat(format:  "Failed to deserialize {0}: \"{1}\"", args:  val_17);
                UnityEngine.Debug.LogException(exception:  1152921504617017344);
                return (string)val_21;
            }
            
                mem[8] = null;
                val_23 = 8;
            }
        
        }
        internal bool 丂上丆且丘三不丟业(string 丁丈与业七上不丞丘, string 丙业与丙丗丝不丈东)
        {
            string val_10;
            var val_11;
            var val_12;
            string val_14;
            val_10 = 丁丈与业七上不丞丘;
            val_11 = this;
            string val_4 = 0;
            if(val_10 == null)
            {
                goto label_1;
            }
            
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_2;
            }
            
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
            {
                    string val_2 = Rilisoft.PersistentCacheManager.丗东丅不丛七下丄丌(七丙不丅丛丘丗万与:  val_10);
                val_10 = val_2;
                if((System.String.IsNullOrEmpty(value:  val_2)) != true)
            {
                    if((this.不丙与丂丒丑丒与万.TryGetValue(key:  val_10, value: out  val_4)) != false)
            {
                    val_10 = Rilisoft.PersistentCacheManager.丄丑丈丏上丝丆丂丐(东与专丗且丏不与丐:  val_10);
                val_11 = this.丌丁丐丒业丅丙丝丁();
                val_11.丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  val_10, 丙业与丙丗丝不丈东:  UnityEngine.JsonUtility.ToJson(obj:  val_4));
                val_12 = 1;
                return (bool)val_12;
            }
            
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
            label_1:
            val_14 = "keyUrl";
            goto label_13;
            label_2:
            val_14 = "value";
            label_13:
            null = new System.ArgumentNullException(paramName:  val_14);
        }
        internal static void 丁东丆上与三丘丏东(string 七丙不丅丛丘丗万与)
        {
            string val_5 = 七丙不丅丛丘丗万与;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            if(val_5 == null)
            {
                    val_5 = System.String.alignConst;
            }
            
            string val_2 = System.String.Format(format:  "Cache hit: {0}", arg0:  val_5);
            if(UnityEngine.Application.isEditor != false)
            {
                    object[] val_4 = new object[1];
                val_4[0] = val_2;
                UnityEngine.Debug.LogFormat(format:  "<color=green><b>{0}</b></color>", args:  val_4);
                return;
            }
            
            UnityEngine.Debug.Log(message:  val_2);
        }
        internal static void 丅丒上丘丌世丏世丈(string 七丙不丅丛丘丗万与)
        {
            string val_5 = 七丙不丅丛丘丗万与;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            if(val_5 == null)
            {
                    val_5 = System.String.alignConst;
            }
            
            string val_2 = System.String.Format(format:  "Cache miss: {0}", arg0:  val_5);
            if(UnityEngine.Application.isEditor != false)
            {
                    object[] val_4 = new object[1];
                val_4[0] = val_2;
                UnityEngine.Debug.LogFormat(format:  "<color=orange><b>{0}</b></color>", args:  val_4);
                return;
            }
            
            UnityEngine.Debug.Log(message:  val_2);
        }
        private System.Collections.IEnumerator 丟丛丝东万丅丁丁丘(float 且丛丄丌下丑丁七与, float 丘三丅丒三世丄下且, System.Threading.CancellationToken 业丘丝业丛丆丄一上, System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<string, string>> 世丅丒丆三下专丘丆)
        {
            PersistentCacheManager.丗丐丏不丄一丐丙丆 val_1 = new PersistentCacheManager.丗丐丏不丄一丐丙丆();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .且丛丄丌下丑丁七与 = 且丛丄丌下丑丁七与;
                .丘三丅丒三世丄下且 = 丘三丅丒三世丄下且;
                .丝且与丝丒丟万丁专 = this;
                .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
            }
            else
            {
                    mem[40] = this;
                mem[64] = 且丛丄丌下丑丁七与;
                .丘三丅丒三世丄下且 = 丘三丅丒三世丄下且;
                mem[48] = 业丘丝业丛丆丄一上.m_source;
            }
            
            .世丅丒丆三下专丘丆 = 世丅丒丆三下专丘丆;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丑一不丘丟不三丑丟(System.Threading.CancellationToken 业丘丝业丛丆丄一上, System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<string, string>> 世丅丒丆三下专丘丆, int 与且专丈不万东一万 = 0)
        {
            PersistentCacheManager.七丛丆丏七三丘业丌 val_1 = new PersistentCacheManager.七丛丆丏七三丘业丌();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
                .世丅丒丆三下专丘丆 = 世丅丒丆三下专丘丆;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 业丘丝业丛丆丄一上.m_source;
                mem[48] = 世丅丒丆三下专丘丆;
            }
            
            .与且专丈不万东一万 = 与且专丈不万东一万;
            return (System.Collections.IEnumerator)val_1;
        }
        private static System.Collections.IEnumerator 万上丕丆丛一丅万丆(System.Threading.Tasks.Task<string> 专一与丘且上丟上且, System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.Dictionary<string, string>> 世丅丒丆三下专丘丆)
        {
            PersistentCacheManager.七不一丞丙三七东丌 val_1 = new PersistentCacheManager.七不一丞丙三七东丌();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .专一与丘且上丟上且 = 专一与丘且上丟上且;
            }
            else
            {
                    mem[32] = 专一与丘且上丟上且;
            }
            
            .世丅丒丆三下专丘丆 = 世丅丒丆三下专丘丆;
            return (System.Collections.IEnumerator)val_1;
        }
        private static System.Collections.IEnumerator 丗下丈下丘七丆丐丘(string[] 丅万丛丄丅七一丟丘, System.Threading.CancellationToken 业丘丝业丛丆丄一上, System.Threading.Tasks.TaskCompletionSource<string> 世丅丒丆三下专丘丆)
        {
            PersistentCacheManager.三丂丙上世丙丌丒丆 val_1 = new PersistentCacheManager.三丂丙上世丙丌丒丆();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丅万丛丄丅七一丟丘 = 丅万丛丄丅七一丟丘;
                .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
            }
            else
            {
                    mem[32] = 丅万丛丄丅七一丟丘;
                mem[48] = 业丘丝业丛丆丄一上.m_source;
            }
            
            .世丅丒丆三下专丘丆 = 世丅丒丆三下专丘丆;
            return (System.Collections.IEnumerator)val_1;
        }
        private static string 丄丑丈丏上丝丆丂丐(string 东与专丗且丏不与丐)
        {
            return System.String.Format(format:  "Cache:{0}", arg0:  东与专丗且丏不与丐);
        }
        private static string 丗东丅不丛七下丄丌(string 七丙不丅丛丘丗万与)
        {
            int val_5;
            if((System.String.IsNullOrEmpty(value:  七丙不丅丛丘丗万与)) != false)
            {
                    val_5 = System.String.alignConst;
                return (string)val_5;
            }
            
            val_5 = Rilisoft.PersistentCacheManager.不业三万且且丁丛专(七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与);
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return (string)val_5;
            }
            
            string val_4 = Rilisoft.PersistentCacheManager.丗业丐专丘丁一丒丆(七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与);
            return (string)val_5;
        }
        private static string 不业三万且且丁丛专(string 七丙不丅丛丘丗万与)
        {
            int val_7;
            var val_8;
            int val_1 = 七丙不丅丛丘丗万与.IndexOf(value:  "//");
            int val_3 = (val_1 + 2) & (~(val_1 >> 31));
            int val_4 = 七丙不丅丛丘丗万与.IndexOf(value:  "/", startIndex:  val_3);
            val_3 = (val_4 < 0) ? (val_3) : (val_4 + 1);
            int val_5 = 七丙不丅丛丘丗万与.IndexOf(value:  "pixelgun3d-config/", startIndex:  val_3);
            if((val_5 & 2147483648) == 0)
            {
                    val_8 = "pixelgun3d-config/";
                if(("pixelgun3d-config/") == null)
            {
                    val_8 = "pixelgun3d-config/";
            }
            
                val_7 = Length + val_5;
            }
            
            if(七丙不丅丛丘丗万与 != null)
            {
                    return 七丙不丅丛丘丗万与.Substring(startIndex:  val_7);
            }
            
            return 七丙不丅丛丘丗万与.Substring(startIndex:  val_7);
        }
        private static string 丗业丐专丘丁一丒丆(string 七丙不丅丛丘丗万与)
        {
            var val_10;
            System.Func<System.String, System.Int32, System.Boolean> val_12;
            var val_14;
            System.Func<System.String, System.Int32, System.Boolean> val_16;
            if(val_2.Length == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            val_10 = null;
            val_10 = null;
            val_12 = PersistentCacheManager.<>c.<>9__26_0;
            if(val_12 == null)
            {
                    System.Func<System.String, System.Int32, System.Boolean> val_3 = null;
                val_12 = val_3;
                val_3 = new System.Func<System.String, System.Int32, System.Boolean>(object:  PersistentCacheManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PersistentCacheManager.<>c::丐丏七一下丌且丆丒(string 丏丛与丅丛丌万专丌, int 七丞丙丒三丕且丌丟));
                PersistentCacheManager.<>c.<>9__26_0 = val_12;
            }
            
            val_14 = null;
            val_14 = null;
            val_16 = PersistentCacheManager.<>c.<>9__26_1;
            if(val_16 == null)
            {
                    System.Func<System.String, System.Int32, System.Boolean> val_5 = null;
                val_16 = val_5;
                val_5 = new System.Func<System.String, System.Int32, System.Boolean>(object:  PersistentCacheManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PersistentCacheManager.<>c::丗且丁上丂与丁丂世(string 丏丛与丅丛丌万专丌, int 七丞丙丒三丕且丌丟));
                PersistentCacheManager.<>c.<>9__26_1 = val_16;
            }
            
            string val_8 = +System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.SkipWhile<System.String>(source:  System.Linq.Enumerable.SkipWhile<System.String>(source:  new System.Uri(uriString:  七丙不丅丛丘丗万与).Segments, predicate:  val_3), predicate:  val_5))(System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.SkipWhile<System.String>(source:  System.Linq.Enumerable.SkipWhile<System.String>(source:  new System.Uri(uriString:  七丙不丅丛丘丗万与).Segments, predicate:  val_3), predicate:  val_5)));
            char[] val_9 = new char[1];
            val_9[0] = '/';
            if(val_8 != null)
            {
                    return val_8.TrimStart(trimChars:  val_9);
            }
            
            return val_8.TrimStart(trimChars:  val_9);
        }
        private static Rilisoft.PersistentCacheManager 东丝七业丄丑丒世七()
        {
            Rilisoft.PersistentCacheManager val_1 = UnityEngine.Object.FindObjectOfType<Rilisoft.PersistentCacheManager>();
            if(val_1 != 0)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  val_1.gameObject);
                return val_1;
            }
            
            UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "Rilisoft.PersistentCacheManager");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_4);
            if(val_4 != null)
            {
                    return val_4.AddComponent<Rilisoft.PersistentCacheManager>();
            }
            
            return val_4.AddComponent<Rilisoft.PersistentCacheManager>();
        }
        private Rilisoft.丛丞丛丑丑万世丛万 七业丁东七丘东丒上()
        {
            HiddenSettings val_7;
            System.Byte[] val_8;
            if(MiscAppsMenu.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_7 = mem[MiscAppsMenu.丆丕丝丒不丙且丐丗 + 24];
                val_7 = MiscAppsMenu.丆丕丝丒不丙且丐丗.misc;
            }
            else
            {
                    val_7 = 0;
            }
            
            if(val_7 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "CreateEncryptedPlayerPrefs(): settings are null.");
                val_8 = new byte[40];
                return (Rilisoft.丛丞丛丑丑万世丛万)new Rilisoft.丛丞丛丑丑万世丛万(丅丄三丅丑丑丞且万:  val_8 = System.Convert.FromBase64String(s:  val_7.PersistentCacheManagerKey));
            }
            
            return (Rilisoft.丛丞丛丑丑万世丛万)new Rilisoft.丛丞丛丑丑万世丛万(丅丄三丅丑丑丞且万:  val_8);
        }
        private static PersistentCacheManager()
        {
            Rilisoft.PersistentCacheManager.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.PersistentCacheManager>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.PersistentCacheManager>(object:  0, method:  static Rilisoft.PersistentCacheManager Rilisoft.PersistentCacheManager::东丝七业丄丑丒世七()));
        }
    
    }

}
