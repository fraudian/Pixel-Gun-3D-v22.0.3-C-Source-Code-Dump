using UnityEngine;

namespace PGCompany.Analytics
{
    internal sealed class InhouseAnalyticsController : MonoBehaviour
    {
        // Fields
        internal static PGCompany.Analytics.InhouseAnalyticsController 丆丕丝丒不丙且丐丗;
        private const string 下丄丏丏丝东下丌丄 = "Analytics.Inhouse.DelayInSeconds-v2";
        private const string 专世丄丞与丏专不丅 = "Analytics.Inhouse.IntervalInSeconds-v2";
        private const string 丌丘与丒东业下七不 = "Analytics.Inhouse.MinIntervalInSeconds-v2";
        private const string 世丈丏丙丛丒丗七丂 = "Analytics.Inhouse.Url";
        private const string 丆丏丅丑专丒丛丂丝 = "InhouseAnalytics.logout";
        private const string 丌丛丑丏且丗丅上丄 = "InhouseAnalytics.logout.InternalTime";
        private const string 丕世丘丁三一丛丌丙 = "InhouseAnalytics.logout.SessionDuration";
        private const string 丁一下丂丄丞丆丏丏 = "events";
        private static System.Collections.Generic.Dictionary<string, string> 七丈丄丌丌丟丂丅下;
        private static System.Nullable<int> 丈且东丄丆业丂与万;
        private static System.Nullable<int> 丏丟丐丏与且三丝丐;
        private static System.Nullable<int> 三上丏丁丟一丑上万;
        private static string 丑丗一丈业丞东丙丞;
        private static object 不丒丂丅业丄下丄丒;
        internal static System.DateTime 与丈业丐丏一丞下丟;
        private static bool 与丘丁东丘下丈丘丆;
        private System.Threading.CancellationTokenSource 丛世七世且丗丌丌丒;
        internal static bool 且东世专丆七丞下与;
        private string 业且一丂丁丑丑与三;
        private string 丗丝七丛丏下丗且丛;
        private static float 丝万不丐万丕丂丝丛;
        private static string 七丙不丅丛丘丗万与;
        private bool 业丙丒丑丅丞不丄丏;
        private float 丌丈世丙丁一三七丄;
        internal static bool 丝丈七丏下丕专丐不;
        
        // Properties
        private static System.Collections.Generic.Dictionary<string, string> 东丙业丌上丈且与上 { get; }
        private static float 不万丈丐丐丝丟丑专 { get; }
        private static float 东丏东丗东丕丙东丌 { get; }
        private static float 丗丏不丟丑七一丏丌 { get; }
        private static float 不且丈专上世丘丒业 { get; }
        private static string 丌丆三万七且东三万 { get; }
        private static object 与东三三丄专一丑丌 { get; }
        internal static bool 丗世丄且丂且万业丄 { get; }
        
        // Methods
        private static System.Collections.Generic.Dictionary<string, string> 丁下一丌且三丕丆丟()
        {
            var val_2;
            System.Collections.Generic.Dictionary<System.String, System.String> val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.Analytics.InhouseAnalyticsController.七丈丄丌丌丟丂丅下;
            if(val_3 != null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)val_3;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = null;
            val_3 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>(capacity:  2);
            if(val_3 != null)
            {
                    val_1.Add(key:  "Content-Type", value:  "application/json");
            }
            else
            {
                    val_1.Add(key:  "Content-Type", value:  "application/json");
            }
            
            val_1.Add(key:  "Authorization", value:  "Basic bGlnaHRtYXA6QVdIc1lNYUNIcGRadnBDd1hWWUZybnMzQyt0cEFVRlE=");
            val_4 = null;
            val_4 = null;
            PGCompany.Analytics.InhouseAnalyticsController.七丈丄丌丌丟丂丅下 = val_3;
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_3;
        }
        internal void 业丂丞丕丑下东丏丙(string 丕世且下万丅丝一丒)
        {
            var val_20;
            var val_21;
            var val_22;
            val_21 = this;
            val_22 = null;
            val_22 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 == false)
            {
                    return;
            }
            
            object[] val_1 = new object[4];
            val_1[0] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            val_1[1] = FriendsController.丝丗专上三不丄丑丑().ToString();
            val_1[2] = 专七专下且专三一且.上且一丈丐三丄一丆().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            val_1[3] = 丕世且下万丅丝一丒;
            string val_8 = System.String.Format(format:  "{0}\t{1}\t{2}\t{3}\n", args:  val_1);
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  System.String.Format(format:  "InhouseAnaliticsLog: {0}", arg0:  val_8));
            }
            
            UnityEngine.Coroutine val_13 = CoroutineRunner.Instance.StartCoroutine(routine:  PGCompany.Analytics.InhouseAnalyticsController.丟七上丂丙三业丁丆(丑丁丒一丘丞业丗七:  val_8));
            CoroutineRunner val_14 = CoroutineRunner.Instance;
            val_20 = val_14;
            UnityEngine.Coroutine val_16 = val_20.StartCoroutine(routine:  val_14.丅丄丈丟且丛三与丛(七丙不丅丛丘丗万与:  this.业且一丂丁丑丑与三, 丑丁丒一丘丞业丗七:  val_8));
            CoroutineRunner val_17 = CoroutineRunner.Instance;
            val_21 = val_17;
            UnityEngine.Coroutine val_19 = val_21.StartCoroutine(routine:  val_17.丅丄丈丟且丛三与丛(七丙不丅丛丘丗万与:  this.丗丝七丛丏下丗且丛, 丑丁丒一丘丞业丗七:  val_8));
        }
        private static System.Collections.IEnumerator 丟七上丂丙三业丁丆(string 丑丁丒一丘丞业丗七)
        {
            .丑丁丒一丘丞业丗七 = 丑丁丒一丘丞业丗七;
            return (System.Collections.IEnumerator)new InhouseAnalyticsController.丙丘丞丅丟丅万丈丌(丗丏丅丕丆世丁专丟:  0);
        }
        private System.Collections.IEnumerator 丅丄丈丟且丛三与丛(string 七丙不丅丛丘丗万与, string 丑丁丒一丘丞业丗七)
        {
            InhouseAnalyticsController.七丅且丏万丄丈三丌 val_1 = new InhouseAnalyticsController.七丅且丏万丄丈三丌(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .七丙不丅丛丘丗万与 = 七丙不丅丛丘丗万与;
            }
            else
            {
                    mem[40] = 七丙不丅丛丘丗万与;
            }
            
            .丑丁丒一丘丞业丗七 = 丑丁丒一丘丞业丗七;
            return (System.Collections.IEnumerator)val_1;
        }
        private static float 万丛丟世万丒七丟丑()
        {
            return (float)(float)PGCompany.Analytics.上丒丞上丌丌丘丛一.不万丅不丁世丅丞丘(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = false}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.DelayInSeconds-v2", 专不三上丏专丄且丞:  30);
        }
        private static float 不丆一上丘丕丗丝丒()
        {
            return (float)(float)PGCompany.Analytics.上丒丞上丌丌丘丛一.不万丅不丁世丅丞丘(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = false}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.IntervalInSeconds-v2", 专不三上丏专丄且丞:  30);
        }
        private static float 丌上丘东丙丄丌丄丝()
        {
            null = null;
            return (float)PGCompany.Analytics.InhouseAnalyticsController.丝万不丐万丕丂丝丛;
        }
        private static float 丟丒丞丅且丐专丛丕()
        {
            return (float)(float)PGCompany.Analytics.上丒丞上丌丌丘丛一.不万丅不丁世丅丞丘(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = false}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.MinIntervalInSeconds-v2", 专不三上丏专丄且丞:  5);
        }
        private static string 七丆丘丘下丝丞丒丁()
        {
            var val_2 = null;
            return PGCompany.Analytics.上丒丞上丌丌丘丛一.丘三丄东丗丌丝东世(丄丒丗丟世丘万丙丟: ref  1152921505690181672, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.Url", 专不三上丏专丄且丞:  PGCompany.Analytics.InhouseAnalyticsController.七丙不丅丛丘丗万与);
        }
        private static object 专丝丆业上下且三丙()
        {
            var val_2;
            object val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.Analytics.InhouseAnalyticsController.不丒丂丅业丄下丄丒;
            if(val_3 != null)
            {
                    return (object)val_3;
            }
            
            val_4 = null;
            val_3 = ProtocolListGetter.丅三专丐丗丅与丆丑();
            val_4 = null;
            PGCompany.Analytics.InhouseAnalyticsController.不丒丂丅业丄下丄丒 = val_3;
            PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏.__il2cppRuntimeField_34 = 268435468;
            return (object)val_3;
        }
        internal static void 丈三丝上丘丏丗丐丆(int 不丕丂丒丙丂丈丅且)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丈丛丌专专丁丒不丙(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = false}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.DelayInSeconds-v2", 丙业与丙丗丝不丈东:  不丕丂丒丙丂丈丅且);
        }
        internal static void 丁三丞丑不丗丙世丂(int 丗下不丕业丅丕丛下)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丈丛丌专专丁丒不丙(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = false}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.IntervalInSeconds-v2", 丙业与丙丗丝不丈东:  丗下不丕业丅丕丛下);
        }
        internal static void 业万丆丗丘丂丒丗丁(int 丘世世万丗丐下丘东)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丈丛丌专专丁丒不丙(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = false}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.MinIntervalInSeconds-v2", 丙业与丙丗丝不丈东:  丘世世万丗丐下丘东);
        }
        internal static void 与丅丝丈丟业上专丟(string 七丙不丅丛丘丗万与)
        {
            if(七丙不丅丛丘丗万与 == null)
            {
                    return;
            }
            
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丝上万丙与上三专丆(丄丒丗丟世丘万丙丟: ref  1152921505690181672, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.Url", 丙业与丙丗丝不丈东:  七丙不丅丛丘丗万与);
        }
        private void Awake()
        {
            System.Object[] val_8;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_2 = new object[4];
                val_8 = val_2;
                val_8[0] = "InhouseAnalyticsController.Awake";
                val_8[1] = System.IntPtr.Size;
                val_8[2] = System.Environment.Is64BitOperatingSystem;
                val_8[3] = System.Environment.Is64BitProcess;
                UnityEngine.Debug.LogFormat(format:  "[{0}] IntPtr.Size: {1}, Is64BitOperatingSystem: {2}, Is64BitProcess: {3}", args:  val_2);
            }
            
            PGCompany.Analytics.上丒丞上丌丌丘丛一.东丕丝世丑丈丞丄丁();
        }
        private void Start()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏 = this;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 != false)
            {
                    this.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  "StartInhouseAnalytics");
            }
            
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.Analytics.InhouseAnalyticsController::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            this.丟丈上丛丙丕业丁丐();
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世().丒一专丑丌专丂丁丆(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Analytics.InhouseAnalyticsController::上万丟世万丏丆与万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            val_6 = null;
            val_6 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 == false)
            {
                    return;
            }
            
            this.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  "StartInhouseAnalytics");
        }
        private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 54)
            {
                    return;
            }
            
            this.丟丈上丛丙丕业丁丐();
        }
        private void OnEnable()
        {
            var val_9;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[I_nhouseA_nalyticsC_ontroller] OnEnable => S_tarting main coroutine");
            }
            
            System.DateTime val_2 = System.DateTime.Now;
            val_9 = null;
            val_9 = null;
            PGCompany.Analytics.InhouseAnalyticsController.与丈业丐丏一丞下丟 = val_2.dateData;
            if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
            {
                    this.丆丕丙世丄丂丕丑丆();
            }
            else
            {
                    AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Analytics.InhouseAnalyticsController::丆丕丙世丄丂丕丑丆()));
            }
            
            System.Threading.CancellationToken val_6 = this.丕丑丈丙丗丝且丅丂();
            UnityEngine.Coroutine val_8 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丁丗七丐丄业一丅世(业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_6.m_source}));
        }
        private void OnDisable()
        {
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[I_nhouseA_nalyticsC_ontroller] OnDisable => S_topping main coroutine");
            }
            
            AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Analytics.InhouseAnalyticsController::丆丕丙世丄丂丕丑丆()));
            if(this.丛世七世且丗丌丌丒 == null)
            {
                    return;
            }
            
            this.丛世七世且丗丌丌丒.Cancel();
        }
        private void OnDestroy()
        {
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.Analytics.InhouseAnalyticsController::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世().丞丛下上世丝一丝丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.Analytics.InhouseAnalyticsController::上万丟世万丏丆与万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_6 = new object[1];
                val_6[0] = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世().丄丘丑专丙下世丕与();
                UnityEngine.Debug.LogFormat(format:  "[I_nhouseA_nalyticsC_ontroller] OnDestroy => D_umping {0} messages...", args:  val_6);
            }
            
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世().不丝丙专丐丛丂丟七();
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            var val_17;
            var val_18;
            string val_19;
            val_17 = 丁与丟万丄丒丗专丌;
            if(val_17 == false)
            {
                goto label_1;
            }
            
            long val_1 = FriendsController.丝丗专上三不丄丑丑();
            System.DateTime val_2 = System.DateTime.Now;
            val_18 = null;
            val_18 = null;
            System.TimeSpan val_3 = val_2.dateData.Subtract(value:  new System.DateTime() {dateData = PGCompany.Analytics.InhouseAnalyticsController.与丈业丐丏一丞下丟});
            if(val_1 <= 0)
            {
                goto label_8;
            }
            
            val_19 = val_1.ToString();
            goto label_9;
            label_1:
            this.丂与丒七七一丙丂丆(不万不丕丆上且丏丗:  true);
            return;
            label_8:
            val_19 = "0";
            label_9:
            UnityEngine.PlayerPrefs.SetString(key:  "InhouseAnalytics.logout", value:  val_19);
            System.DateTime val_5 = System.DateTime.Now;
            UnityEngine.PlayerPrefs.SetString(key:  "InhouseAnalytics.logout.InternalTime", value:  val_5.dateData);
            object[] val_6 = new object[4];
            val_6[0] = val_3._ticks.Days;
            val_6[1] = val_3._ticks.Hours;
            val_6[2] = val_3._ticks.Minutes;
            val_6[3] = val_3._ticks.Seconds;
            UnityEngine.PlayerPrefs.SetString(key:  "InhouseAnalytics.logout.SessionDuration", value:  System.String.Format(format:  "{0} {1}:{2}:{3}", args:  val_6));
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_13 = new object[1];
                val_13[0] = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世().丄丘丑专丙下世丕与();
                UnityEngine.Debug.LogFormat(format:  "[I_nhouseA_nalyticsC_ontroller] OnApplicationPause(true) => D_umping {0} messages...", args:  val_13);
            }
            
            val_17 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_17.不丝丙专丐丛丂丟七();
        }
        private void 丟丈上丛丙丕业丁丐()
        {
            int val_31;
            var val_32;
            var val_33;
            object val_4 = 0;
            object val_11 = 0;
            object val_7 = 0;
            object val_18 = 0;
            object val_15 = 0;
            object val_24 = 0;
            object val_20 = 0;
            PGCompany.丒丒丛丙不万专三丆 val_31 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_31.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  54));
            if(val_3 == null)
            {
                    return;
            }
            
            val_31 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            if((val_31.TryGetValue(key:  "minDelayAfterError", value: out  val_4)) != false)
            {
                    val_31 = 1152921505690177536;
                val_32 = null;
                val_32 = null;
                PGCompany.Analytics.InhouseAnalyticsController.丝万不丐万丕丂丝丛 = System.Convert.ToSingle(value:  val_4);
            }
            
            if((val_31.TryGetValue(key:  "enable", value: out  val_7)) != false)
            {
                    val_31 = System.Convert.ToInt32(value:  val_7);
                PGCompany.Analytics.上丒丞上丌丌丘丛一.丏丐丝上三丁丞丝丕(丙业与丙丗丝不丈东:  (val_31 == 1) ? 1 : 0);
            }
            
            if((val_31.TryGetValue(key:  "maxStorage", value: out  val_11)) != false)
            {
                    val_31 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
                val_31.丛一丐丑与丁丁业丝(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_11));
            }
            
            if((val_31.TryGetValue(key:  "minPeriodSend", value: out  val_15)) != false)
            {
                    val_31 = System.Convert.ToInt32(value:  val_15);
                PGCompany.Analytics.InhouseAnalyticsController.丈三丝上丘丏丗丐丆(不丕丂丒丙丂丈丅且:  val_31);
            }
            
            if((val_31.TryGetValue(key:  "url_v2", value: out  val_18)) != false)
            {
                    val_31 = val_18;
                PGCompany.Analytics.InhouseAnalyticsController.与丅丝丈丟业上专丟(七丙不丅丛丘丗万与:  val_31);
            }
            
            if((val_31.TryGetValue(key:  "ignoreEventOnSocket", value: out  val_20)) != false)
            {
                    val_31 = val_20;
                if(val_31 != 0)
            {
                    val_31 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世().丙万丕丂丞丐上与上(丈丑丕丙与丘七下丘:  val_31);
                val_22.业丌丝与与且七丌不 = val_31;
            }
            
            }
            
            if(((val_31.TryGetValue(key:  "ignoreEventOnHttp", value: out  val_24)) != false) && (val_24 != 0))
            {
                    PGCompany.Analytics.上丒丞上丌丌丘丛一 val_26 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
                val_31 = val_26;
                val_26.丆一丏七丑丟丟丐一 = val_26.丙万丕丂丞丐上与上(丈丑丕丙与丘七下丘:  val_24);
            }
            
            val_33 = null;
            val_33 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 == false)
            {
                    return;
            }
            
            this.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  System.String.Format(format:  "ParseConfig enable={0}", arg0:  PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑()));
        }
        private System.Collections.Generic.HashSet<int> 丙万丕丂丞丐上与上(System.Collections.Generic.Dictionary<string, object> 丈丑丕丙与丘七下丘)
        {
            var val_17;
            string val_18;
            var val_19;
            string val_20;
            object val_2 = 0;
            int val_6 = 0;
            object val_10 = 0;
            System.Collections.Generic.HashSet<System.Int32> val_1 = new System.Collections.Generic.HashSet<System.Int32>();
            if(((丈丑丕丙与丘七下丘.TryGetValue(key:  "all", value: out  val_2)) != false) && (val_2 != 0))
            {
                    val_17 = 1152921516473664400;
                if(val_2.Count >= 1)
            {
                    var val_17 = 0;
                do
            {
                val_18 = val_2.Item[0];
                if((System.Int32.TryParse(s:  val_18, result: out  val_6)) != false)
            {
                    val_18 = 0;
                bool val_8 = val_1.Add(item:  0);
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 < val_2.Count);
            
            }
            
            }
            
            val_19 = null;
            val_19 = null;
            val_20 = 丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒;
            if((丈丑丕丙与丘七下丘.TryGetValue(key:  val_20, value: out  val_10)) == false)
            {
                    return val_1;
            }
            
            if(val_10 == 0)
            {
                    return val_1;
            }
            
            var val_12 = (((mem[282584257676871] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_10) : 0;
            val_18 = 1152921516473664400;
            val_17 = 1152921523913241648;
            val_20 = 0;
            goto label_18;
            label_24:
            if((System.Int32.TryParse(s:  val_12.Item[0], result: out  val_6)) != false)
            {
                    bool val_15 = val_1.Add(item:  0);
            }
            
            val_20 = 1;
            label_18:
            if(val_20 < val_12.Count)
            {
                goto label_24;
            }
            
            return val_1;
        }
        private void 丂与丒七七一丙丂丆(bool 不万不丕丆上且丏丗 = False)
        {
            UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  PGCompany.Analytics.InhouseAnalyticsController.丈丑一丘与丄丘丐丕(不万不丕丆上且丏丗:  不万不丕丆上且丏丗));
        }
        private static System.Collections.IEnumerator 丈丑一丘与丄丘丐丕(bool 不万不丕丆上且丏丗)
        {
            .不万不丕丆上且丏丗 = 不万不丕丆上且丏丗;
            return (System.Collections.IEnumerator)new InhouseAnalyticsController.丒丘丟丘丞丒与三丟(丗丏丅丕丆世丁专丟:  0);
        }
        private void 丆丕丙世丄丂丕丑丆()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.与丘丁东丘下丈丘丆 != false)
            {
                    return;
            }
            
            System.DateTime val_1 = System.DateTime.Now;
            val_5 = null;
            val_5 = null;
            PGCompany.Analytics.InhouseAnalyticsController.与丈业丐丏一丞下丟 = val_1.dateData;
            上丆与下丌丅丅丈丙 val_2 = 丅丛丟上丁丆上丛专.不七不丙丏上与三一();
            if(val_2 == null)
            {
                    return;
            }
            
            string val_3 = val_2.业一丆万丂且不上世();
            if(val_3 == null)
            {
                    return;
            }
            
            val_3.丂与丒七七一丙丂丆(不万不丕丆上且丏丗:  false);
            val_6 = null;
            val_6 = null;
            PGCompany.Analytics.InhouseAnalyticsController.与丘丁东丘下丈丘丆 = true;
        }
        private void 一丟丂丄丏丈且丕丟()
        {
            var val_17 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 == false)
            {
                    return;
            }
            
            object[] val_1 = new object[6];
            if((System.String.IsNullOrEmpty(value:  丅丛丟上丁丆上丛专.不七不丙丏上与三一().业一丆万丂且不上世())) == false)
            {
                goto label_7;
            }
            
            if(val_1 != null)
            {
                goto label_41;
            }
            
            label_42:
            label_41:
            val_1[0] = "null";
            val_1[1] = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            val_1[2] = PGCompany.Analytics.上丒丞上丌丌丘丛一.丗且丂丑丕丏丟且与();
            val_1[3] = FriendsController.丝丗专上三不丄丑丑().ToString();
            val_1[4] = 业丂丏与世一丏业不.万丕且不与且丛丌丅().ToString();
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_11 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_1[5] = val_11.万不七丄丝且丟丄丂.Count.ToString();
            this.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  System.String.Format(format:  "SendInfoByBlockParams muid = {0} uid={1} country = {2} servertime = {3} reg = {4} count = {5}", args:  val_1));
            return;
            label_7:
            上丆与下丌丅丅丈丙 val_15 = 丅丛丟上丁丆上丛专.不七不丙丏上与三一();
            if(val_15 == null)
            {
                goto label_38;
            }
            
            string val_16 = val_15.业一丆万丂且不上世();
            if(val_1 != null)
            {
                goto label_41;
            }
            
            goto label_42;
            label_38:
            if(val_1 != null)
            {
                goto label_41;
            }
            
            goto label_42;
        }
        internal static bool 业丛丌不丙万业丟一()
        {
            WeaponManager val_13;
            var val_14;
            var val_15;
            var val_16;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                goto label_27;
            }
            
            val_14 = null;
            val_14 = null;
            val_13 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_13 == 0)
            {
                goto label_8;
            }
            
            val_15 = null;
            val_15 = null;
            val_13 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_13 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_13 != 0)
            {
                goto label_27;
            }
            
            label_8:
            if(((((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0) && ((System.String.IsNullOrEmpty(value:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丗且丂丑丕丏丟且与())) != true)) && ((System.String.IsNullOrEmpty(value:  PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三())) != true)) && (业丂丏与世一丏业不.万丕且不与且丛丌丅() >= 0))
            {
                    if(丅丛丟上丁丆上丛专.不七不丙丏上与三一() != null)
            {
                    return (bool)val_16;
            }
            
            }
            
            label_27:
            val_16 = 1;
            return (bool)val_16;
        }
        private System.Collections.IEnumerator 丁丗七丐丄业一丅世(System.Threading.CancellationToken 业丘丝业丛丆丄一上)
        {
            InhouseAnalyticsController.与丁业丐下七专丟丅 val_1 = new InhouseAnalyticsController.与丁业丐下七专丟丅(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丈丒与丞丏丈业丌丈()
        {
            if(this.丛世七世且丗丌丌丒 == null)
            {
                    return;
            }
            
            this.丛世七世且丗丌丌丒.Cancel();
        }
        private System.Threading.CancellationToken 丕丑丈丙丗丝且丅丂()
        {
            if(this.丛世七世且丗丌丌丒 != null)
            {
                    this.丛世七世且丗丌丌丒.Cancel();
            }
            
            System.Threading.CancellationTokenSource val_1 = new System.Threading.CancellationTokenSource();
            this.丛世七世且丗丌丌丒 = val_1;
            if(val_1 != null)
            {
                    return val_1.Token;
            }
            
            return val_1.Token;
        }
        private void 上万丟世万丏丆与万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
        
        }
        private string 专丈下丗丟丞丐丄丐()
        {
            return "Unknown";
        }
        public InhouseAnalyticsController()
        {
            this.业且一丂丁丑丑与三 = "https://events-stat-1.lightmap.ru/log_stat_event.php";
            this.丗丝七丛丏下丗且丛 = "https://events-stat-2.lightmap.ru/log_stat_event.php";
        }
        private static InhouseAnalyticsController()
        {
            PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏 = 0;
            PGCompany.Analytics.InhouseAnalyticsController.与丘丁东丘下丈丘丆 = false;
            PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 = false;
            PGCompany.Analytics.InhouseAnalyticsController.七丙不丅丛丘丗万与 = "https://pixelgun-cl-stat.lightmap.ru/event_stat_add_pl.php";
            PGCompany.Analytics.InhouseAnalyticsController.丝丈七丏下丕专丐不 = true;
        }
    
    }

}
