using UnityEngine;

namespace Rilisoft
{
    public class AchievementsManager : MonoBehaviour
    {
        // Fields
        private static Rilisoft.AchievementsManager 丝业丆丁业三丈丟东;
        private const string 世东丅丆丄丞丏与丁 = "achievementsProgress";
        internal static Rilisoft.丁丄与下丄丌丈下丟 丁丄与下丄丌丈下丟;
        private readonly Rilisoft.丝丘万业丟不丐东丝<Rilisoft.丞专七丛丛丌世丈丕> 世上丞丙且丘丄且七;
        private readonly System.Collections.Generic.List<Rilisoft.丞专七丛丛丌世丈丕> 东上三三丝丆丁丛东;
        private bool <世丌万丈三丐丑丗丅>k__BackingField;
        private static System.Action 丈且丟丏丈丁不专丙;
        
        // Properties
        public static Rilisoft.AchievementsManager 丆丕丝丒不丙且丐丗 { get; }
        public bool 丒丆丁丘丈丏丆丌丘 { get; set; }
        public Rilisoft.丝丘万业丟不丐东丝<Rilisoft.丞专七丛丛丌世丈丕> 上万与丟丏业丄丑东 { get; }
        
        // Methods
        public static Rilisoft.AchievementsManager get_Instance()
        {
            var val_6;
            string val_7;
            var val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            val_7 = Rilisoft.AchievementsManager.世东丅丆丄丞丏与丁;
            if(val_7 == 0)
            {
                    System.Type[] val_2 = new System.Type[1];
                val_2[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "AchievementsManager", components:  val_2);
                val_8 = null;
                val_7 = val_4.GetComponent<Rilisoft.AchievementsManager>();
                val_8 = null;
                Rilisoft.AchievementsManager.世东丅丆丄丞丏与丁 = val_7;
                UnityEngine.Object.DontDestroyOnLoad(target:  val_4);
            }
            
            val_9 = null;
            val_9 = null;
            return (Rilisoft.AchievementsManager)Rilisoft.AchievementsManager.世东丅丆丄丞丏与丁;
        }
        public bool get_IsReady()
        {
            return (bool)this.<世丌万丈三丐丑丗丅>k__BackingField;
        }
        private void 丝专丞丈丂东丝丈丌(bool 丙业与丙丗丝不丈东)
        {
            this.<世丌万丈三丐丑丗丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.丝丘万业丟不丐东丝<Rilisoft.丞专七丛丛丌世丈丕> get_AvailableAchiements()
        {
            return (Rilisoft.丝丘万业丟不丐东丝<Rilisoft.丞专七丛丛丌世丈丕>)this.世上丞丙且丘丄且七;
        }
        internal static System.Collections.Generic.List<Rilisoft.AchievementProgressData> 丏三不丐丛丕丛丝丝()
        {
            var val_5;
            var val_13;
            var val_14;
            System.Collections.Generic.List<Rilisoft.AchievementProgressData> val_1 = new System.Collections.Generic.List<Rilisoft.AchievementProgressData>();
            Progress.丛丂丅丄丘丞丕丅丂 val_2 = Progress.七七世万专丕丁上业.万东下东一丄三丝且();
            List.Enumerator<T> val_3 = val_2.丂专丌下丈与丕三丘.GetEnumerator();
            val_13 = 0;
            val_14 = 0;
            var val_13 = 0;
            label_26:
            if(((-1055528848) & 1) == 0)
            {
                goto label_5;
            }
            
            new Rilisoft.AchievementProgressData() = new Rilisoft.AchievementProgressData();
            if(new Rilisoft.AchievementProgressData() != null)
            {
                    .AchievementId = val_6.m_stringLength;
                .Points = 1152921505425375232;
            }
            else
            {
                    mem[16] = val_6.m_stringLength;
                mem[32] = val_6.m_stringLength;
            }
            
            .Stage = val_6.m_stringLength;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            .CustomData = null;
            Dictionary.Enumerator<TKey, TValue> val_9 = val_5.丐丏七丌丕丗业且上().GetEnumerator();
            label_12:
            if(((-1055528896) & 1) == 0)
            {
                goto label_10;
            }
            
            ConfiguredValueTaskAwaiter val_11 = val_5.GetAwaiter();
            (Rilisoft.AchievementProgressData)[1152921542206084304].CustomData.set_Item(key:  val_11._value._obj.丐丏七丌丕丗业且上(), value:  val_11._value._obj);
            goto label_12;
            label_10:
            val_13 = val_13 + 1;
            mem2[0] = 162;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_13 == 1) || ((-1055528976 + ((0 + 1)) << 2) != 162))
            {
                goto label_19;
            }
            
            var val_14 = 0;
            val_14 = val_14 ^ (val_13 >> 31);
            val_13 = val_13 + val_14;
            if(val_1 != null)
            {
                goto label_25;
            }
            
            goto label_24;
            label_19:
            if( == 0)
            {
                goto label_22;
            }
            
            if(val_1 != null)
            {
                goto label_25;
            }
            
            goto label_24;
            label_22:
            if(val_1 != null)
            {
                goto label_25;
            }
            
            label_24:
            label_25:
            val_1.Add(item:  new Rilisoft.AchievementProgressData());
            goto label_26;
            label_5:
            val_13 = val_13 + 1;
            mem2[0] = 197;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_13 != 1)
            {
                    if( == 0)
            {
                    return val_1;
            }
            
                if((-1055528976 + ((0 + 1)) << 2) == 197)
            {
                    return val_1;
            }
            
                return val_1;
            }
            
            if( != 0)
            {
                    return val_1;
            }
            
            return val_1;
        }
        private void 丕三丂丞丈不不丌专()
        {
            if((this.<世丌万丈三丐丑丗丅>k__BackingField) == false)
            {
                    return;
            }
            
            this.丒丟丛丅丈不一业三();
        }
        private void Awake()
        {
            AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.AchievementsManager::丕三丂丞丈不不丌专()));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.AchievementsManager::丕三丂丞丈不不丌专()));
            this.丒丟丛丅丈不一业三();
            this.<世丌万丈三丐丑丗丅>k__BackingField = true;
        }
        internal static void 丆丘丞丏丈上丏丗丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.AchievementsManager.丈且丟丏丈丁不专丙, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.AchievementsManager.丈且丟丏丈丁不专丙 != 1152921505426018320);
        
        }
        internal static void 丅丈丂东上不丛下丆(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.AchievementsManager.丈且丟丏丈丁不专丙, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.AchievementsManager.丈且丟丏丈丁不专丙 != 1152921505426018320);
        
        }
        internal void 丒丟丛丅丈不一业三()
        {
            var val_31;
            object val_35;
            Rilisoft.AchievementProgressData val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            string val_42;
            var val_43;
            var val_44;
            System.Action val_45;
            var val_46;
            val_31 = 0;
            goto label_1;
            label_6:
            Rilisoft.丞专七丛丛丌世丈丕 val_1 = this.东上三三丝丆丁丛东.Item[0];
            this.东上三三丝丆丁丛东.set_Item(index:  0, value:  0);
            val_31 = 1;
            label_1:
            if(val_31 < this.东上三三丝丆丁丛东.Count)
            {
                goto label_6;
            }
            
            System.GC.Collect();
            this.东上三三丝丆丁丛东.Clear();
            UnityEngine.TextAsset val_3 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "Achievements/achievements_data");
            bool val_4 = UnityEngine.Object.op_Equality(x:  val_3, y:  0);
            var val_5 = (val_4 != true) ? 0 : (val_3);
            if(val_4 == true)
            {
                goto label_12;
            }
            
            bool val_6 = UnityEngine.Debug.isDebugBuild;
            bool val_9 = UnityEngine.Debug.isDebugBuild;
            var val_33 = 0;
            val_33 = val_33 + 1;
            System.Collections.Generic.IEnumerator<T> val_12 = Rilisoft.七上丄万丟丈丏丁与.丄七专专丝专丏丘丝(丛七丅东丒丅丘不业:  val_5.text).GetEnumerator();
            label_63:
            var val_34 = 0;
            val_34 = val_34 + 1;
            if(val_12.MoveNext() == false)
            {
                goto label_30;
            }
            
            new AchievementsManager.业丂七丏丟丕丌丂世() = new System.Object();
            .丝且与丝丒丟万丁专 = this;
            var val_35 = 0;
            val_35 = val_35 + 1;
            .一丐丗丁丞丆丅丟丄 = val_12.Current;
            new AchievementsManager.世万丌丑丂世不丕丈() = new System.Object();
            if(new AchievementsManager.世万丌丑丂世不丕丈() != null)
            {
                    val_35 = new AchievementsManager.世万丌丑丂世不丕丈();
                .东丟且丗且三专丙丁 = new AchievementsManager.业丂七丏丟丕丌丂世();
            }
            else
            {
                    mem[24] = new AchievementsManager.业丂七丏丟丕丌丂世();
                val_35 = 24;
            }
            
            System.Func<Rilisoft.AchievementProgressData, System.Boolean> val_19 = new System.Func<Rilisoft.AchievementProgressData, System.Boolean>(object:  new AchievementsManager.业丂七丏丟丕丌丂世(), method:  System.Boolean AchievementsManager.业丂七丏丟丕丌丂世::丝上丝世丌三业丘且(Rilisoft.AchievementProgressData 七丏丄丅丌业与且丙));
            val_36 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.AchievementProgressData>(source:  Rilisoft.AchievementsManager.丏三不丐丛丕丛丝丝(), predicate:  null);
            if(val_36 == null)
            {
                    val_36 = new Rilisoft.AchievementProgressData();
                val_36 = new Rilisoft.AchievementProgressData();
                .AchievementId = .一丐丗丁丞丆丅丟丄.业上丙丞丐丄丆丅七();
            }
            
            bool val_23 = UnityEngine.Debug.isDebugBuild;
            .世丞丞万丞丙一丟专 = this.东与丘丐丘丁丛丟下(一丐丗丁丞丆丅丟丄:  .一丐丗丁丞丆丅丟丄, 上丕丈丞丌丘丅不与:  new Rilisoft.AchievementProgressData());
            bool val_25 = UnityEngine.Debug.isDebugBuild;
            if((AchievementsManager.世万丌丑丂世不丕丈)[1152921542206886688].世丞丞万丞丙一丟专 == null)
            {
                goto label_63;
            }
            
            if((this.东上三三丝丆丁丛东.Contains(item:  (AchievementsManager.世万丌丑丂世不丕丈)[1152921542206886688].世丞丞万丞丙一丟专)) == false)
            {
                goto label_52;
            }
            
            object[] val_27 = new object[1];
            val_27[0] = (AchievementsManager.世万丌丑丂世不丕丈)[1152921542206886688].世丞丞万丞丙一丟专.业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "achievement instancing error, DUPLICATE Id: \'{0}\'", args:  val_27);
            goto label_63;
            label_52:
            this.东上三三丝丆丁丛东.Add(item:  (AchievementsManager.世万丌丑丂世不丕丈)[1152921542206886688].世丞丞万丞丙一丟专);
            System.Action<System.Boolean, System.Boolean> val_29 = new System.Action<System.Boolean, System.Boolean>(object:  new AchievementsManager.世万丌丑丂世不丕丈(), method:  System.Void AchievementsManager.世万丌丑丂世不丕丈::一丛三丛丕丏丈丞东(bool 七丏丄丅丌业与且丙, bool 丏丛与丅丛丌万专丌));
            (AchievementsManager.世万丌丑丂世不丕丈)[1152921542206886688].世丞丞万丞丙一丟专.专丝丕专丆丛丂丄专(丙业与丙丗丝不丈东:  null);
            goto label_63;
            label_30:
            val_37 = 0;
            val_38 = 0;
            if(val_12 != null)
            {
                goto label_64;
            }
            
            goto label_99;
            label_12:
            new System.Exception() = new System.Exception(message:  "Achievements cfg not found");
            goto label_126;
            label_64:
            var val_38 = val_5;
            if((val_4 != true ? 0 : val_3 + 286) == 0)
            {
                goto label_103;
            }
            
            var val_36 = val_4 != true ? 0 : val_3 + 176;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_102:
            if(((val_4 != true ? 0 : val_3 + 176 + 8) + -8) == null)
            {
                goto label_101;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (val_4 != true ? 0 : val_3 + 286))
            {
                goto label_102;
            }
            
            goto label_103;
            label_101:
            val_38 = val_38 + (((val_4 != true ? 0 : val_3 + 176 + 8)) << 4);
            val_41 = val_38 + 296;
            label_103:
            val_5.Dispose();
            label_99:
            if( == 1)
            {
                goto label_104;
            }
            
            if(null == null)
            {
                goto label_108;
            }
            
            if(414 != 414)
            {
                goto label_106;
            }
            
            goto label_108;
            label_104:
            if(null == null)
            {
                goto label_108;
            }
            
            label_106:
            label_108:
            (System.Exception)[1152921542206944048]._message.Clear();
            val_42 = (System.Exception)[1152921542206944048]._message;
            val_43 = 1152921505426014208;
            val_42.丝丐丝丛上丙丕丟一(丈丆丕与丒丌丘丕且:  new System.Exception().下且丟丗七丅丘丁不(), 与且专丏丅世丐丐丑:  false);
            val_44 = null;
            val_44 = null;
            val_45 = Rilisoft.AchievementsManager.丈且丟丏丈丁不专丙;
            if(val_45 == null)
            {
                    return;
            }
            
            val_45 = Rilisoft.AchievementsManager.丈且丟丏丈丁不专丙;
            if(val_45 == null)
            {
                    val_45 = 0;
            }
            
            val_45.Invoke();
            return;
            label_126:
            val_39 = 0;
            val_40 = new System.Exception();
            if(val_39 == 1)
            {
                    if((null & 1) != 0)
            {
                    object[] val_32 = new object[1];
                val_42 = val_32;
                val_42[0] = 1152921504619732992;
                UnityEngine.Debug.LogErrorFormat(format:  "AchievementsManager init eror: {0}", args:  val_32);
                return;
            }
            
                mem[8] = null;
                val_46 = 8;
            }
        
        }
        private void Update()
        {
            null = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.丛丙世丞丌丄业丙丅();
        }
        private Rilisoft.丞专七丛丛丌世丈丕 东与丘丐丘丁丛丟下(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 上丕丈丞丌丘丅不与)
        {
            Rilisoft.AchievementProgressData val_34;
            var val_35;
            val_34 = 上丕丈丞丌丘丅不与;
            Rilisoft.AchievementClassType val_1 = 一丐丗丁丞丆丅丟丄.丒丁丈丆一丘丟三世();
            if(val_1 <= 32)
            {
                    var val_34 = 106025244 + (val_1) << 2;
                val_34 = val_34 + 106025244;
            }
            else
            {
                    val_34 = val_1;
                mem2[0] = 一丐丗丁丞丆丅丟丄.丒丁丈丆一丘丟三世();
                UnityEngine.Debug.LogErrorFormat(format:  "unsupported AchievementClassType : \'{0}\'", args:  val_34);
                val_35 = 0;
                return (Rilisoft.丞专七丛丛丌世丈丕);
            }
        
        }
        private void 专丂丕七丐丂丙三不(Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专, bool 丟丞上万丄万丛专不, bool 丝丑丂万且丁且丐上)
        {
            string val_34;
            object val_35;
            System.Collections.Generic.List<Rilisoft.丞专七丛丛丌世丈丕> val_36;
            var val_37;
            val_34 = 丝丑丂万且丁且丐上;
            AchievementsManager.丌丐丝丐下上三丛丌 val_1 = null;
            val_35 = val_1;
            val_1 = new AchievementsManager.丌丐丝丐下上三丛丌();
            if(val_35 == null)
            {
                goto label_1;
            }
            
            .世丞丞万丞丙一丟专 = 世丞丞万丞丙一丟专;
            val_36 = this.东上三三丝丆丁丛东;
            if(val_36 != null)
            {
                goto label_78;
            }
            
            label_79:
            label_78:
            if((val_36.Contains(item:  世丞丞万丞丙一丟专)) == true)
            {
                goto label_3;
            }
            
            object[] val_3 = new object[2];
            int val_4 = .世丞丞万丞丙一丟专.业上丙丞丐丄丆丅七();
            if((val_4 != 0) && (val_4 == 0))
            {
                    val_37 = 0;
            }
            
            if(val_3.Length == 0)
            {
                    val_37 = 0;
            }
            
            val_3[0] = val_4;
            val_3[1] = .世丞丞万丞丙一丟专;
            UnityEngine.Debug.LogErrorFormat(format:  "HASH CODE ACH ID: {0} = {1}", args:  val_3);
            System.Predicate<Rilisoft.丞专七丛丛丌世丈丕> val_5 = null;
            val_36 = val_5;
            val_5 = new System.Predicate<Rilisoft.丞专七丛丛丌世丈丕>(object:  val_1, method:  System.Boolean AchievementsManager.丌丐丝丐下上三丛丌::丆三丗丈七七丑丟丂(Rilisoft.丞专七丛丛丌世丈丕 三丟东丕丄丄下下丑));
            int val_6 = val_36.FindIndex(match:  val_5);
            if((val_6 & 2147483648) != 0)
            {
                goto label_18;
            }
            
            val_36 = val_36;
            val_36.set_Item(index:  val_6, value:  .世丞丞万丞丙一丟专);
            label_3:
            if(val_34 == false)
            {
                goto label_21;
            }
            
            if((this.世上丞丙且丘丄且七.Contains(item:  .世丞丞万丞丙一丟专)) == true)
            {
                goto label_24;
            }
            
            int val_9 = this.世上丞丙且丘丄且七.FindIndex(match:  new System.Predicate<Rilisoft.丞专七丛丛丌世丈丕>(object:  val_1, method:  System.Boolean AchievementsManager.丌丐丝丐下上三丛丌::丞丐丁与与七丗东不(Rilisoft.丞专七丛丛丌世丈丕 三丟东丕丄丄下下丑)));
            if((val_9 & 2147483648) != 0)
            {
                goto label_26;
            }
            
            val_36.set_Item(index:  val_9, value:  .世丞丞万丞丙一丟专);
            label_24:
            if(val_35 != null)
            {
                goto label_90;
            }
            
            label_91:
            label_90:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  32);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丐丞专专且丒七与();
            InfoWindowController.丆七下与丁丟丌且丑(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  .世丞丞万丞丙一丟专.丁专丗万三上丟三丆().丄专丟不万丕丒丝丙()), 业东丗东不丟业丁丆:  Rilisoft.AchievementView.丑一东丏专丙丟丌丝(世丞丞万丞丙一丟专:  .世丞丞万丞丙一丟专), 不上丏上丝丆一丛丑:  .世丞丞万丞丙一丟专.丁专丗万三上丟三丆().丑一丆丑且丟上业丛(), 丂丕丄丏丙与丄丐一:  false);
            Rilisoft.一丟专且三万丞丁丂.丑丒万万丆丟丂专丂(专丅且丌一万且上七:  .世丞丞万丞丙一丟专.业上丙丞丐丄丆丅七(), 与下且下一丕丕且上:  .世丞丞万丞丙一丟专.丙万丙丂一丝丁丂下());
            val_34 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  .世丞丞万丞丙一丟专.丁专丗万三上丟三丆().丄专丟不万丕丒丝丙());
            PGCompany.Analytics.一业丗丆世世上丁且.丌丂一万业丌丘专丛(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丏丈丕世丝丆东丆丑:  val_34, 丈丘丝一丗下丈丐不:  .世丞丞万丞丙一丟专.丙万丙丂一丝丁丂下());
            val_35 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_35.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
            label_21:
            val_34 = .世丞丞万丞丙一丟专;
            if(val_34.且专丂丐丟一不丌丟() < 1)
            {
                    return;
            }
            
            val_34 = this.世上丞丙且丘丄且七;
            if((val_34.Contains(item:  .世丞丞万丞丙一丟专)) == true)
            {
                    return;
            }
            
            val_34 = .世丞丞万丞丙一丟专;
            if(val_34.不业丙丒丂丞下丆丙() == 2)
            {
                    return;
            }
            
            val_34 = System.Linq.Enumerable.ToList<Rilisoft.丞专七丛丛丌世丈丕>(source:  this.下且丟丗七丅丘丁不()).IndexOf(item:  .世丞丞万丞丙一丟专);
            if((val_34 & 2147483648) != 0)
            {
                    return;
            }
            
            val_35 = .世丞丞万丞丙一丟专;
            this.世上丞丙且丘丄且七.丁丌丒七丐丂且下丞(丞世不丒下上上丝丑:  val_34, 下丅丙一丂丗丅丝七:  val_35, 与且专丏丅世丐丐丑:  false);
            return;
            label_1:
            mem[16] = 世丞丞万丞丙一丟专;
            if(this.东上三三丝丆丁丛东 != null)
            {
                goto label_78;
            }
            
            goto label_79;
            label_18:
            object[] val_32 = new object[1];
            val_35 = .世丞丞万丞丙一丟专.业上丙丞丐丄丆丅七();
            val_32[0] = val_35;
            UnityEngine.Debug.LogErrorFormat(format:  "[Achievement] Unknown achievement: \'{0}\'", args:  val_32);
            return;
            label_26:
            this.世上丞丙且丘丄且七.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  .世丞丞万丞丙一丟专, 与且专丏丅世丐丐丑:  false);
            if(val_35 != null)
            {
                goto label_90;
            }
            
            goto label_91;
        }
        private System.Collections.Generic.IEnumerable<Rilisoft.丞专七丛丛丌世丈丕> 下且丟丗七丅丘丁不()
        {
            var val_8;
            System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Boolean> val_10;
            var val_12;
            System.Func<Rilisoft.丞专七丛丛丌世丈丕, Rilisoft.AchievementType> val_14;
            var val_15;
            System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Int32> val_17;
            var val_18;
            System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Int32> val_20;
            val_8 = null;
            val_8 = null;
            val_10 = AchievementsManager.<>c.<>9__23_0;
            if(val_10 == null)
            {
                    System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Boolean> val_1 = null;
                val_10 = val_1;
                val_1 = new System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Boolean>(object:  AchievementsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AchievementsManager.<>c::丕万七丛丐上丑丞丙(Rilisoft.丞专七丛丛丌世丈丕 丆丛丑世下一丐且丕));
                AchievementsManager.<>c.<>9__23_0 = val_10;
            }
            
            val_12 = null;
            val_12 = null;
            val_14 = AchievementsManager.<>c.<>9__23_1;
            if(val_14 == null)
            {
                    System.Func<Rilisoft.丞专七丛丛丌世丈丕, Rilisoft.AchievementType> val_3 = null;
                val_14 = val_3;
                val_3 = new System.Func<Rilisoft.丞专七丛丛丌世丈丕, Rilisoft.AchievementType>(object:  AchievementsManager.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.AchievementType AchievementsManager.<>c::七世与且丈丐专丕丁(Rilisoft.丞专七丛丛丌世丈丕 丆丛丑世下一丐且丕));
                AchievementsManager.<>c.<>9__23_1 = val_14;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = AchievementsManager.<>c.<>9__23_2;
            if(val_17 == null)
            {
                    System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Int32> val_5 = null;
                val_17 = val_5;
                val_5 = new System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Int32>(object:  AchievementsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AchievementsManager.<>c::东丕丝世丅丝三丝万(Rilisoft.丞专七丛丛丌世丈丕 丆丛丑世下一丐且丕));
                AchievementsManager.<>c.<>9__23_2 = val_17;
            }
            
            val_18 = null;
            val_18 = null;
            val_20 = AchievementsManager.<>c.<>9__23_3;
            if(val_20 != null)
            {
                    return System.Linq.Enumerable.ThenBy<Rilisoft.丞专七丛丛丌世丈丕, System.Int32>(source:  System.Linq.Enumerable.ThenBy<Rilisoft.丞专七丛丛丌世丈丕, System.Int32>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.丞专七丛丛丌世丈丕, Rilisoft.AchievementType>(source:  System.Linq.Enumerable.Where<Rilisoft.丞专七丛丛丌世丈丕>(source:  this.东上三三丝丆丁丛东, predicate:  val_1), keySelector:  val_3), keySelector:  val_5), keySelector:  System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Int32> val_7 = null);
            }
            
            val_20 = val_7;
            val_7 = new System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Int32>(object:  AchievementsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AchievementsManager.<>c::一七专业不丕业丟丛(Rilisoft.丞专七丛丛丌世丈丕 丆丛丑世下一丐且丕));
            AchievementsManager.<>c.<>9__23_3 = val_20;
            return System.Linq.Enumerable.ThenBy<Rilisoft.丞专七丛丛丌世丈丕, System.Int32>(source:  System.Linq.Enumerable.ThenBy<Rilisoft.丞专七丛丛丌世丈丕, System.Int32>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.丞专七丛丛丌世丈丕, Rilisoft.AchievementType>(source:  System.Linq.Enumerable.Where<Rilisoft.丞专七丛丛丌世丈丕>(source:  this.东上三三丝丆丁丛东, predicate:  val_1), keySelector:  val_3), keySelector:  val_5), keySelector:  val_7);
        }
        public void SetProgress(Rilisoft.AchievementProgressData 丏东业业丄东丄丐丗)
        {
            .丏东业业丄东丄丐丗 = 丏东业业丄东丄丐丗;
            Rilisoft.丞专七丛丛丌世丈丕 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丞专七丛丛丌世丈丕>(source:  this.东上三三丝丆丁丛东, predicate:  new System.Func<Rilisoft.丞专七丛丛丌世丈丕, System.Boolean>(object:  new AchievementsManager.丛东丟丅丙丗世丗不(), method:  System.Boolean AchievementsManager.丛东丟丅丙丗世丗不::世万丑丅丛一丂丆专(Rilisoft.丞专七丛丛丌世丈丕 丆丛丑世下一丐且丕)));
            if(val_3 == null)
            {
                    return;
            }
            
            val_3.东丅三一丅不一七丟(丙业与丙丗丝不丈东:  (AchievementsManager.丛东丟丅丙丗世丗不)[1152921542208205184].丏东业业丄东丄丐丗);
        }
        public AchievementsManager()
        {
            this.世上丞丙且丘丄且七 = new Rilisoft.丝丘万业丟不丐东丝<Rilisoft.丞专七丛丛丌世丈丕>();
            this.东上三三丝丆丁丛东 = new System.Collections.Generic.List<Rilisoft.丞专七丛丛丌世丈丕>();
        }
        private static AchievementsManager()
        {
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟 = new Rilisoft.丁丄与下丄丌丈下丟();
        }
    
    }

}
