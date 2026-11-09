using UnityEngine;

namespace PGCompany.Analytics
{
    internal sealed class 上丒丞上丌丌丘丛一
    {
        // Fields
        internal const string 丈一丞专东丗丌丂下 = "Analytics.Inhouse.QueueList";
        private const string 丄丘丒丙丅且丘丂一 = "Analytics.Inhouse.NextId";
        private const string 丙丁丂七丐业丁丞丄 = "Analytics.Inhouse.CurrentLog";
        private const string 丝丆丈世丞丝丛且丗 = "Analytics.Inhouse.UniqDeviceId";
        private const string 万丄丌丄丐丂丒专丈 = "DevFlag";
        private static PGCompany.Analytics.上丒丞上丌丌丘丛一 世丒丞七专三与万丕;
        private int 万丒上丐丈一丑丏丙;
        private int 下东丈不丗丐丗下丝;
        private int 丏专专业丆丝丈上上;
        internal static string 与业上且丁一世三三;
        internal int 丂专丝专七丟专丑丌;
        internal int 且三丛与丄丈三东丞;
        internal System.Collections.Generic.HashSet<int> 业丌丝与与且七丌不;
        internal System.Collections.Generic.HashSet<int> 丆一丏七丑丟丟丐一;
        internal readonly 一丌丅丑上丄丞丒丈<System.Collections.Generic.IDictionary<string, object>> 万不七丄丝且丟丄丂;
        private bool 下不与丐丂丕万丄丒;
        private int 丁丝丟且丆丐丐丌东;
        private System.EventHandler 丝丕丆丛丟世万且丞;
        private const string 丅下丅丄丐丌丅丞丂 = "Analytics.Inhouse.Enabled-v2";
        private const string 万七丕且丐丑丌世万 = "Analytics.Inhouse.StorageLimit-v2";
        private const string 丝丆丌业且世万丂一 = "Analytics.Inhouse.MemoryLimit-v2";
        private const string 世一丐与七丂丗丁下 = "Analytics.Inhouse.QueueThreshold-v2";
        private static System.Nullable<bool> 与丒丕丁下世东丅丌;
        private System.Nullable<int> 东丒下且下丗丈三与;
        private System.Nullable<int> 东丛丛丌专下丁丘丒;
        private System.Nullable<int> 下丑丌丟丆与丕丞丞;
        internal static bool 万业与丕丂丆且东七;
        
        // Properties
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        internal int 丈丐三丄万丟丝丛丛 { get; }
        internal int 不丆丒丈上丈丑万专 { get; }
        internal static PGCompany.Analytics.上丒丞上丌丌丘丛一 丆丕丝丒不丙且丐丗 { get; }
        internal int 丂七丟丁东丗东业丁 { get; }
        internal static string 下丑下丄与丞丆丝且 { get; }
        internal int 丕丙丈丆东一丞一东 { get; set; }
        internal static bool 三不专丗七丄且丝业 { get; set; }
        internal int 且下上丌丄丂丏三且 { get; set; }
        private int 上丕丅与业万专东丅 { get; set; }
        private int 丆丐丑丂丘丝专上丛 { get; set; }
        private static int 丕丙丂丑丏丕上一丕 { get; }
        internal bool 万丂丆万丌丕业丐丏 { get; }
        
        // Methods
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        internal int 与且七丄丕下丕世丆()
        {
            if(this.下不与丐丂丕万丄丒 == true)
            {
                    return (int)this.丁丝丟且丆丐丐丌东;
            }
            
            int val_1 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.UniqDeviceId", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            if(val_1 > 0)
            {
                    this.丁丝丟且丆丐丐丌东 = val_1;
            }
            else
            {
                    this.丅与东丟丟不丈丒丈();
            }
            
            this.下不与丐丂丕万丄丒 = true;
            return (int)this.丁丝丟且丆丐丐丌东;
        }
        internal void 丅与东丟丟不丈丒丈()
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.UniqDeviceId", 下下丏一丙不丘丌丞:  UnityEngine.Random.Range(min:  1, max:  2147483647), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            this.丁丝丟且丆丐丐丌东 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.UniqDeviceId", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        internal int 丛不丕业丅下丛丙且()
        {
            int val_1 = this.下东丈不丗丐丗下丝;
            val_1 = val_1 + 1;
            this.下东丈不丗丐丗下丝 = val_1;
            this.三丘丈丒丞丝丅世丏();
            return (int)this.下东丈不丗丐丗下丝;
        }
        private 上丒丞上丌丌丘丛一()
        {
            this.万丒上丐丈一丑丏丙 = 0;
            this.丏专专业丆丝丈上上 = 0;
            this.业丌丝与与且七丌不 = new System.Collections.Generic.HashSet<System.Int32>();
            this.丆一丏七丑丟丟丐一 = new System.Collections.Generic.HashSet<System.Int32>();
            this.万不七丄丝且丟丄丂 = new 一丌丅丑上丄丞丒丈<System.Collections.Generic.IDictionary<System.String, System.Object>>();
            this.丁丝丟且丆丐丐丌东 = 0;
            this.下东丈不丗丐丗下丝 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.NextId", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        internal void 丒一专丑丌专丂丁丆(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丝丕丆丛丟世万且丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丕丆丛丟世万且丞 != 1152921560212526904);
        
        }
        internal void 丞丛下上世丝一丝丕(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丝丕丆丛丟世万且丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丕丆丛丟世万且丞 != 1152921560212663480);
        
        }
        internal static PGCompany.Analytics.上丒丞上丌丌丘丛一 丑七不且上丗丁一世()
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.东丕丝世丑丈丞丄丁();
            return (PGCompany.Analytics.上丒丞上丌丌丘丛一)PGCompany.Analytics.上丒丞上丌丌丘丛一.世一丐与七丂丗丁下;
        }
        internal int 丄丘丑专丙下世丕与()
        {
            if(this.万不七丄丝且丟丄丂 != null)
            {
                    return this.万不七丄丝且丟丄丂.Count;
            }
            
            return this.万不七丄丝且丟丄丂.Count;
        }
        internal static void 东丕丝世丑丈丞丄丁()
        {
            null = null;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世一丐与七丂丗丁下 != null)
            {
                    return;
            }
            
            PGCompany.Analytics.上丒丞上丌丌丘丛一.世一丐与七丂丗丁下 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丝丏业七下丕东业丕();
            PGCompany.Analytics.上丒丞上丌丌丘丛一.世一丐与七丂丗丁下.丑七万丑专丑丝丟丘();
        }
        internal static string 丗且丂丑丕丏丟且与()
        {
            string val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_5 = null;
            val_5 = null;
            if((System.String.IsNullOrEmpty(value:  PGCompany.Analytics.上丒丞上丌丌丘丛一.与业上且丁一世三三)) != false)
            {
                    val_6 = null;
                val_6 = null;
                val_7 = null;
                val_4 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丑丛丄且丛丈下三);
                val_7 = null;
                PGCompany.Analytics.上丒丞上丌丌丘丛一.与业上且丁一世三三 = val_4;
            }
            else
            {
                    val_7 = null;
            }
            
            val_7 = null;
            if((System.String.IsNullOrEmpty(value:  PGCompany.Analytics.上丒丞上丌丌丘丛一.与业上且丁一世三三)) != false)
            {
                    val_4 = 1152921505171275776;
                val_8 = null;
                val_8 = null;
                if(与丂丏丛丞丞丒丟丄.东丞丙上一不丈丝下 != false)
            {
                    val_9 = "NONE";
                return (string)val_9;
            }
            
            }
            
            val_10 = null;
            val_10 = null;
            val_9 = 1152921505690128392;
            return (string)val_9;
        }
        internal int 丂丅丆业丘不一丄丟()
        {
            int val_3 = this.丏专专业丆丝丈上上;
            if(val_3 != 1)
            {
                    return val_3;
            }
            
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "DevFlag")) != false)
            {
                    val_3 = "DevFlag";
                this.丏专专业丆丝丈上上 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_3, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
                return val_3;
            }
            
            this.丂丛业丒丏丞丝丅丑(丙业与丙丗丝不丈东:  0);
            val_3 = this.丏专专业丆丝丈上上;
            return val_3;
        }
        internal void 丂丛业丒丏丞丝丅丑(int 丙业与丙丗丝不丈东)
        {
            if(this.丏专专业丆丝丈上上 == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this.丏专专业丆丝丈上上 = 丙业与丙丗丝不丈东;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "DevFlag", 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal System.Collections.Generic.IDictionary<string, object> 丂世丝业丒与七丒与(int 丗丆业三丝丗丆丑丛, System.Collections.Generic.Dictionary<string, object> 丗丟上上丒丐丗丞丙)
        {
            var val_46;
            var val_47;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            string val_65;
            object val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            object val_73;
            var val_74;
            var val_75;
            var val_76;
            long val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            val_46 = 1152921505690177536;
            val_47 = null;
            val_47 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 != false)
            {
                    val_49 = 0;
                if(PGCompany.Analytics.InhouseAnalyticsController.__il2cppRuntimeField_static_fields != 0)
            {
                    val_50 = null;
                val_50 = null;
                val_49 = 0;
                PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  "CreateMessage name="("CreateMessage name=") + 丗丆业三丝丗丆丑丛);
            }
            
            }
            
            val_51 = null;
            val_51 = null;
            val_52 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
            if((System.Object.Equals(objA:  val_52.Comparer, objB:  System.StringComparer.Ordinal)) != true)
            {
                    PGCompany.七丑一上且三世丝三<K, V> val_9 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
                System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = null;
                val_52 = val_11;
                val_11 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  (((System.String.IsNullOrEmpty(value:  ABTestController.不丛丞世丈丗东丞七)) & true) != 0) ? (24 + 1) : 24, comparer:  System.StringComparer.Ordinal);
            }
            
            val_53 = null;
            val_53 = null;
            this.下东丈不丗丐丗下丝 = this.下东丈不丗丐丗下丝 + 1;
            this.三丘丈丒丞丝丅世丏();
            val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.七丟世世上丏万丐不, value:  this.下东丈不丗丐丗下丝);
            val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丌丛丒丏上业丟丞不, value:  丗丆业三丝丗丆丑丛);
            val_54 = null;
            val_54 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 != false)
            {
                    if(PGCompany.Analytics.InhouseAnalyticsController.__il2cppRuntimeField_static_fields != 0)
            {
                    val_56 = null;
                val_56 = null;
                val_57 = null;
                val_57 = null;
                PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  "CreateMessage CommandId="("CreateMessage CommandId=") + val_11.Item[PGCompany.Analytics.丂与丏丕一丒与丁丙.七丟世世上丏万丐不]);
            }
            
            }
            
            string val_16 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            if((System.String.IsNullOrEmpty(value:  val_16)) != false)
            {
                    val_58 = 1;
            }
            else
            {
                    val_59 = null;
                val_59 = null;
                val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丒丁丙丞丆丟丑业丈, value:  val_16);
                val_58 = 0;
            }
            
            val_60 = null;
            if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) >= 2)
            {
                goto label_51;
            }
            
            val_61 = null;
            if(FpsManager.上丘一丈下下丕丅丕() == false)
            {
                goto label_56;
            }
            
            val_62 = 1;
            goto label_57;
            label_51:
            val_63 = null;
            val_64 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_65 = PGCompany.Analytics.丂与丏丕一丒与丁丙.东不七七丌丝东丛一;
            val_66 = 2;
            goto label_61;
            label_56:
            val_62 = this;
            int val_20 = this.丂丅丆业丘不一丄丟();
            label_57:
            val_64 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_65 = PGCompany.Analytics.丂与丏丕一丒与丁丙.东不七七丌丝东丛一;
            val_66 = val_20;
            label_61:
            val_11.set_Item(key:  val_65, value:  val_20);
            string val_21 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丗且丂丑丕丏丟且与();
            if((System.String.IsNullOrEmpty(value:  val_21)) != false)
            {
                    val_58 = 1;
            }
            else
            {
                    val_67 = null;
                val_67 = null;
                val_64 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
                val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.下丑下丄与丞丆丝且, value:  val_21);
            }
            
            decimal val_24 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丌丅业专丑专专万丑();
            val_68 = null;
            val_68 = null;
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.mid}, d2:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.MinusOne, lo = System.Decimal.Powers10.__il2cppRuntimeField_30>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_30>>32&0x0})) != false)
            {
                    val_69 = null;
                val_69 = null;
                val_70 = 1152921516595668352;
                val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丛丞丘丟丅三丟专, value:  val_24);
            }
            else
            {
                    val_70 = 1152921516595668352;
                val_58 = 1;
            }
            
            val_71 = null;
            val_71 = null;
            val_72 = null;
            val_72 = null;
            val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.东丅丝丟丘上丄丒世, value:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
            val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三专丞丄东丂丟七与, value:  ExperienceController.丞丞丘业东丙丏七丌());
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                goto label_89;
            }
            
            val_73 = 1152921505128890368;
            if(val_52 != null)
            {
                goto label_108;
            }
            
            label_109:
            label_108:
            val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丄丌且丄东丟世丗丒, value:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁());
            val_74 = null;
            val_74 = null;
            if((System.String.IsNullOrEmpty(value:  ABTestController.不丛丞世丈丗东丞七)) != true)
            {
                    val_75 = null;
                val_75 = null;
                val_76 = null;
                val_76 = null;
                val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.专世丛世丁丞下且上, value:  ABTestController.不丛丞世丈丗东丞七);
            }
            
            val_77 = FriendsController.丝丗专上三不丄丑丑();
            if(val_77 < 1)
            {
                goto label_103;
            }
            
            val_78 = null;
            val_78 = null;
            val_77 = val_77;
            val_11.set_Item(key:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业万一丏丌上三丑丟, value:  val_77);
            goto label_107;
            label_89:
            if(val_52 != null)
            {
                goto label_108;
            }
            
            goto label_109;
            label_103:
            val_58 = 1;
            label_107:
            double val_34 = 业丂丏与世一丏业不.万丕且不与且丛丌丅();
            if(val_34 > 0f)
            {
                    val_79 = null;
                val_79 = null;
                val_77 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丁三丈上与丏丏丟丗;
                val_11.set_Item(key:  val_77, value:  val_34);
                if((val_58 & 1) == 0)
            {
                    val_80 = null;
                val_80 = null;
                val_77 = PGCompany.Analytics.丂与丏丕一丒与丁丙.且丏丁丆丐丐丈丝三;
                val_11.set_Item(key:  val_77, value:  ProtocolListGetter.丅三专丐丗丅与丆丑());
            }
            
            }
            
            if(丗丟上上丒丐丗丞丙 == null)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_52;
            }
            
            if(丗丟上上丒丐丗丞丙.Count < 1)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_52;
            }
            
            val_46 = 1152921516622697232;
            label_142:
            string val_38 = System.Linq.Enumerable.ElementAt<System.String>(source:  丗丟上上丒丐丗丞丙.Keys, index:  0);
            val_81 = null;
            val_81 = null;
            if((System.String.op_Inequality(a:  val_38, b:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业万一丏丌上三丑丟)) == false)
            {
                goto label_127;
            }
            
            val_82 = null;
            val_82 = null;
            if((System.String.op_Inequality(a:  val_38, b:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三专丞丄东丂丟七与)) == false)
            {
                goto label_127;
            }
            
            val_73 = 丗丟上上丒丐丗丞丙.Item[val_38];
            val_11.Add(key:  val_38, value:  val_73);
            goto label_138;
            label_127:
            val_83 = null;
            val_83 = null;
            val_84 = null;
            if((System.String.op_Equality(a:  val_38, b:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业万一丏丌上三丑丟)) == false)
            {
                goto label_132;
            }
            
            val_85 = null;
            val_73 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业万一丏丌上三丑丟;
            goto label_135;
            label_132:
            val_86 = null;
            if((System.String.op_Equality(a:  val_38, b:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三专丞丄东丂丟七与)) == false)
            {
                goto label_138;
            }
            
            val_87 = null;
            val_87 = null;
            val_73 = PGCompany.Analytics.丂与丏丕一丒与丁丙.三专丞丄东丂丟七与;
            label_135:
            val_11.set_Item(key:  val_73, value:  丗丟上上丒丐丗丞丙.Item[val_38]);
            label_138:
            val_77 = 0 + 1;
            if(val_77 < 丗丟上上丒丐丗丞丙.Count)
            {
                goto label_142;
            }
            
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_52;
        }
        internal void 丝丒丈丟万不丘丂丑(int 丗丆业三丝丗丆丑丛)
        {
            var val_3 = null;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            this.与万一丐丘七三丂三(丗丆业三丝丗丆丑丛:  丗丆业三丝丗丆丑丛, 丗丟上上丒丐丗丞丙:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
            this.丌丅下业丛丘三不七();
        }
        internal void 丝丒丈丟万不丘丂丑(int 丗丆业三丝丗丆丑丛, System.Collections.Generic.Dictionary<string, object> 丗丟上上丒丐丗丞丙)
        {
            var val_2 = null;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            this.与万一丐丘七三丂三(丗丆业三丝丗丆丑丛:  丗丆业三丝丗丆丑丛, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            this.丌丅下业丛丘三不七();
        }
        private void 与万一丐丘七三丂三(int 丗丆业三丝丗丆丑丛, System.Collections.Generic.Dictionary<string, object> 丗丟上上丒丐丗丞丙)
        {
            if(((丗丆业三丝丗丆丑丛 | 2) != 3) && ((this.丈专不丆丌上上丙丅(业下三丟丌世丏丄丏:  丗丆业三丝丗丆丑丛)) != true))
            {
                    bool val_4 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丒丛丐丐丑丈世专丑(丗丆业三丝丗丆丑丛:  丗丆业三丝丗丆丑丛, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            }
            
            if((this.丂丂丂东丌丐丕丙世(业下三丟丌世丏丄丏:  丗丆业三丝丗丆丑丛)) != false)
            {
                    return;
            }
            
            this.丟丒丛丝丏上一丈丏(丄丙下丝丛丒七丂丘:  this.丂世丝业丒与七丒与(丗丆业三丝丗丆丑丛:  丗丆业三丝丗丆丑丛, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙));
        }
        private bool 丈专不丆丌上上丙丅(int 业下三丟丌世丏丄丏)
        {
            if(this.业丌丝与与且七丌不 != null)
            {
                    return this.业丌丝与与且七丌不.Contains(item:  业下三丟丌世丏丄丏);
            }
            
            return this.业丌丝与与且七丌不.Contains(item:  业下三丟丌世丏丄丏);
        }
        private bool 丂丂丂东丌丐丕丙世(int 业下三丟丌世丏丄丏)
        {
            if(this.丆一丏七丑丟丟丐一 != null)
            {
                    return this.丆一丏七丑丟丟丐一.Contains(item:  业下三丟丌世丏丄丏);
            }
            
            return this.丆一丏七丑丟丟丐一.Contains(item:  业下三丟丌世丏丄丏);
        }
        internal void 丝丒丈丟万不丘丂丑(System.Collections.Generic.IDictionary<string, object> 丄丙下丝丛丒七丂丘)
        {
            var val_2 = null;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            this.丟丒丛丝丏上一丈丏(丄丙下丝丛丒七丂丘:  丄丙下丝丛丒七丂丘);
            this.丌丅下业丛丘三不七();
        }
        internal void 不丝丙专丐丛丂丟七()
        {
            var val_2 = null;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            this.丈丈不丒丄丟丗一丐();
        }
        private void 三丘丈丒丞丝丅世丏()
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.NextId", 下下丏一丙不丘丌丞:  this.下东丈不丗丐丗下丝, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private void 丈丈不丒丄丟丗一丐()
        {
            var val_8;
            var val_10;
            val_8 = null;
            val_8 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 != false)
            {
                    if(PGCompany.Analytics.InhouseAnalyticsController.__il2cppRuntimeField_static_fields != 0)
            {
                    val_10 = null;
                val_10 = null;
                PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  "DumpQueueNew count="("DumpQueueNew count=") + this.万不七丄丝且丟丄丂.Count.ToString());
            }
            
            }
            
            string val_5 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.万不七丄丝且丟丄丂);
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[" + "InhouseAnalytics.DumpQueueNew" + "] Queue was saved to prefs: "("] Queue was saved to prefs: ") + val_5);
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.QueueList", 下下丏一丙不丘丌丞:  val_5);
        }
        internal void 丑七万丑专丑丝丟丘()
        {
            var val_9;
            string val_15;
            var val_16;
            var val_18;
            var val_19;
            一丌丅丑上丄丞丒丈<System.Collections.Generic.IDictionary<System.String, System.Object>> val_20;
            System.Collections.Generic.IDictionary<System.String, System.Object> val_21;
            var val_23;
            var val_25;
            val_15 = this;
            val_16 = null;
            val_16 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 != false)
            {
                    if(PGCompany.Analytics.InhouseAnalyticsController.__il2cppRuntimeField_static_fields != 0)
            {
                    val_18 = null;
                val_18 = null;
                PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  "GetListFromPrefs start");
            }
            
            }
            
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.QueueList")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.QueueList", 下下丏一丙不丘丌丞:  UnityEngine.PlayerPrefs.GetString(key:  "Analytics.Inhouse.QueueList", defaultValue:  System.String.alignConst));
            }
            
            object val_5 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Analytics.Inhouse.QueueList"));
            val_19 = 0;
            val_20 = this.万不七丄丝且丟丄丂;
            val_20.Clear();
            List.Enumerator<T> val_7 = GetEnumerator();
            label_28:
            if(((-226407744) & 1) == 0)
            {
                goto label_24;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            if(val_10 == null)
            {
                goto label_25;
            }
            
            val_21 = val_10;
            if(val_21 != null)
            {
                goto label_26;
            }
            
            label_25:
            val_21 = 0;
            label_26:
            this.万不七丄丝且丟丄丂.Add(item:  val_21);
            goto label_28;
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_23 = null;
            val_23 = null;
            if(PGCompany.Analytics.InhouseAnalyticsController.且东世专丆七丞下与 == false)
            {
                    return;
            }
            
            if(PGCompany.Analytics.InhouseAnalyticsController.__il2cppRuntimeField_static_fields == 0)
            {
                    return;
            }
            
            val_25 = null;
            val_25 = null;
            val_15 = PGCompany.Analytics.InhouseAnalyticsController.丁一下丂丄丞丆丏丏;
            val_15.业丂丞丕丑下东丏丙(丕世且下万丅丝一丒:  "GetListFromPrefs count="("GetListFromPrefs count=") + this.万不七丄丝且丟丄丂.Count);
        }
        private static PGCompany.Analytics.上丒丞上丌丌丘丛一 丝丏业七下丕东业丕()
        {
            return (PGCompany.Analytics.上丒丞上丌丌丘丛一)new PGCompany.Analytics.上丒丞上丌丌丘丛一();
        }
        private void 丟丒丛丝丏上一丈丏(System.Collections.Generic.IDictionary<string, object> 丄丙下丝丛丒七丂丘)
        {
            var val_85;
            System.Object[] val_86;
            string val_87;
            var val_88;
            var val_89;
            var val_90;
            string val_92;
            string val_93;
            var val_94;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            string val_101;
            string val_102;
            var val_103;
            var val_105;
            var val_106;
            var val_107;
            var val_108;
            string val_110;
            string val_111;
            var val_112;
            var val_114;
            var val_115;
            var val_116;
            var val_117;
            string val_119;
            string val_120;
            var val_121;
            var val_123;
            var val_124;
            var val_125;
            var val_126;
            string val_128;
            string val_129;
            var val_130;
            var val_132;
            var val_133;
            var val_134;
            string val_136;
            val_85 = 1152921505690124288;
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丈且业丆丑丏丐一() == false)
            {
                goto label_3;
            }
            
            object[] val_2 = new object[14];
            val_2[0] = 丄丙下丝丛丒七丂丘;
            var val_6 = (丄丙下丝丛丒七丂丘 != 1) ? (val_2) : 0;
            if(((丄丙下丝丛丒七丂丘 & 1) & 1) == 0)
            {
                goto label_21;
            }
            
            goto label_28;
            label_21:
            val_87 = "[INHOUSE ANALYTICS] <color=orange> Event:{0}</color>\t[{1}{2}{3}{4}{5}{6}\t{7}{8}{9}{10}\t{11}{12}{13}]";
            val_86 = val_2;
            if(val_86 != null)
            {
                goto label_32;
            }
            
            goto label_30;
            label_28:
            if(val_6 != 0)
            {
                goto label_32;
            }
            
            label_30:
            label_32:
            var val_10 = val_6 + (((丄丙下丝丛丒七丂丘 & 1)) << 3);
            mem2[0] = "\"i1\":"("\"i1\":") + 丄丙下丝丛丒七丂丘 + ", ";
            var val_12 = (丄丙下丝丛丒七丂丘 != 1) ? ((丄丙下丝丛丒七丂丘 != 1) ? "[INHOUSE ANALYTICS] <color=orange> Event:{0}</color>\t[{1}{2}{3}{4}{5}{6}\t{7}{8}{9}{10}\t{11}{12}{13}]" : 0) : 0;
            var val_13 = (丄丙下丝丛丒七丂丘 != 1) ? (val_6) : 0;
            var val_14 = (丄丙下丝丛丒七丂丘 != 1) ? 2 : 0;
            if((丄丙下丝丛丒七丂丘 & 1) == 0)
            {
                goto label_43;
            }
            
            goto label_50;
            label_43:
            if(val_6 != 0)
            {
                goto label_54;
            }
            
            goto label_52;
            label_50:
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_54;
            }
            
            label_52:
            label_54:
            var val_17 = val_86 + ((丄丙下丝丛丒七丂丘 != 0x1 ? 2 : 0) << 3);
            mem2[0] = "\"i2\":"("\"i2\":") + 丄丙下丝丛丒七丂丘 + ", ";
            val_12 = (丄丙下丝丛丒七丂丘 != 1) ? (val_87) : 0;
            val_13 = (丄丙下丝丛丒七丂丘 != 1) ? (val_86) : 0;
            var val_19 = (丄丙下丝丛丒七丂丘 != 1) ? 3 : 0;
            if((丄丙下丝丛丒七丂丘 & 1) == 0)
            {
                goto label_65;
            }
            
            goto label_72;
            label_65:
            if(val_86 != 0)
            {
                goto label_76;
            }
            
            goto label_74;
            label_72:
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_76;
            }
            
            label_74:
            label_76:
            var val_22 = val_86 + ((丄丙下丝丛丒七丂丘 != 0x1 ? 3 : 0) << 3);
            mem2[0] = "\"i3\":"("\"i3\":") + 丄丙下丝丛丒七丂丘 + ", ";
            val_12 = (丄丙下丝丛丒七丂丘 != 1) ? (val_87) : 0;
            val_13 = (丄丙下丝丛丒七丂丘 != 1) ? (val_86) : 0;
            var val_24 = (丄丙下丝丛丒七丂丘 != 1) ? 4 : 0;
            if((丄丙下丝丛丒七丂丘 & 1) == 0)
            {
                goto label_87;
            }
            
            goto label_94;
            label_87:
            if(val_86 != 0)
            {
                goto label_98;
            }
            
            goto label_96;
            label_94:
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_98;
            }
            
            label_96:
            label_98:
            var val_27 = val_86 + ((丄丙下丝丛丒七丂丘 != 0x1 ? 4 : 0) << 3);
            mem2[0] = "\"i4\":"("\"i4\":") + 丄丙下丝丛丒七丂丘 + ", ";
            val_12 = (丄丙下丝丛丒七丂丘 != 1) ? (val_87) : 0;
            val_13 = (丄丙下丝丛丒七丂丘 != 1) ? (val_86) : 0;
            var val_29 = (丄丙下丝丛丒七丂丘 != 1) ? 5 : 0;
            if((丄丙下丝丛丒七丂丘 & 1) == 0)
            {
                goto label_109;
            }
            
            goto label_116;
            label_109:
            if(val_86 != 0)
            {
                goto label_120;
            }
            
            goto label_118;
            label_116:
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_120;
            }
            
            label_118:
            label_120:
            var val_32 = val_86 + ((丄丙下丝丛丒七丂丘 != 0x1 ? 5 : 0) << 3);
            mem2[0] = "\"i5\":"("\"i5\":") + 丄丙下丝丛丒七丂丘 + ", ";
            val_12 = (丄丙下丝丛丒七丂丘 != 1) ? (val_87) : 0;
            val_13 = (丄丙下丝丛丒七丂丘 != 1) ? (val_86) : 0;
            var val_34 = (丄丙下丝丛丒七丂丘 != 1) ? 6 : 0;
            if((丄丙下丝丛丒七丂丘 & 1) == 0)
            {
                goto label_131;
            }
            
            goto label_138;
            label_131:
            if(val_86 != 0)
            {
                goto label_142;
            }
            
            goto label_140;
            label_138:
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_142;
            }
            
            label_140:
            label_142:
            var val_37 = val_86 + ((丄丙下丝丛丒七丂丘 != 0x1 ? 6 : 0) << 3);
            mem2[0] = "\"i6\":"("\"i6\":") + 丄丙下丝丛丒七丂丘 + ", ";
            val_12 = (丄丙下丝丛丒七丂丘 != 1) ? (val_87) : 0;
            val_13 = (丄丙下丝丛丒七丂丘 != 1) ? (val_86) : 0;
            var val_39 = (丄丙下丝丛丒七丂丘 != 1) ? 7 : 0;
            if((丄丙下丝丛丒七丂丘 & 1) == 0)
            {
                goto label_153;
            }
            
            goto label_160;
            label_153:
            if(val_86 != 0)
            {
                goto label_164;
            }
            
            goto label_162;
            label_160:
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_164;
            }
            
            label_162:
            label_164:
            var val_42 = val_86 + ((丄丙下丝丛丒七丂丘 != 0x1 ? 7 : 0) << 3);
            mem2[0] = "\"s1\":"("\"s1\":") + 丄丙下丝丛丒七丂丘 + ", ";
            val_88 = 0;
            val_12 = (丄丙下丝丛丒七丂丘 != 1) ? (val_87) : 0;
            val_13 = (丄丙下丝丛丒七丂丘 != 1) ? (val_86) : 0;
            if((丄丙下丝丛丒七丂丘 & 1) == 0)
            {
                goto label_175;
            }
            
            var val_96 = 0;
            val_96 = val_96 + 1;
            val_90 = 0;
            goto label_182;
            label_175:
            val_89 = 8;
            val_92 = "";
            if(val_86 != 0)
            {
                goto label_186;
            }
            
            goto label_184;
            label_182:
            val_93 = ", ";
            val_92 = "\"s2\":"("\"s2\":") + 丄丙下丝丛丒七丂丘.Item[???](丄丙下丝丛丒七丂丘.Item[???]) + val_93;
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_186;
            }
            
            label_184:
            label_186:
            if((val_92 != null) && (val_92 == null))
            {
                    val_93 = 0;
            }
            
            if(((丄丙下丝丛丒七丂丘 != 1) ? 8 : 0) >= (丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? val_2 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 + 24))
            {
                    val_93 = 0;
            }
            
            var val_48 = val_86 + ((丄丙下丝丛丒七丂丘 != 0x1 ? 8 : 0) << 3);
            mem2[0] = val_92;
            val_94 = null;
            val_94 = null;
            var val_97 = 0;
            val_97 = val_97 + 1;
            val_93 = 4;
            val_96 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            bool val_50 = 丄丙下丝丛丒七丂丘.ContainsKey(key:  ???);
            val_12 = (val_50 != true) ? (val_87) : 0;
            val_13 = (val_50 != true) ? (val_86) : 0;
            if(val_50 == false)
            {
                goto label_197;
            }
            
            val_98 = null;
            val_98 = null;
            var val_98 = 0;
            val_98 = val_98 + 1;
            val_99 = 0;
            goto label_204;
            label_197:
            val_97 = 9;
            val_101 = "";
            if(val_86 != 0)
            {
                goto label_208;
            }
            
            goto label_206;
            label_204:
            val_102 = ", ";
            val_101 = "\"s3\":"("\"s3\":") + 丄丙下丝丛丒七丂丘.Item[???](丄丙下丝丛丒七丂丘.Item[???]) + val_102;
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_208;
            }
            
            label_206:
            label_208:
            if((val_101 != null) && (val_101 == null))
            {
                    val_102 = 0;
            }
            
            if(((val_50 != true) ? 9 : 0) >= (val_50 != true ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? val_2 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 + 24))
            {
                    val_102 = 0;
            }
            
            var val_55 = val_86 + ((val_50 != true ? 9 : 0) << 3);
            mem2[0] = val_101;
            val_103 = null;
            val_103 = null;
            var val_99 = 0;
            val_99 = val_99 + 1;
            val_102 = 4;
            val_105 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            bool val_57 = 丄丙下丝丛丒七丂丘.ContainsKey(key:  ???);
            val_12 = (val_57 != true) ? (val_87) : 0;
            val_13 = (val_57 != true) ? (val_86) : 0;
            if(val_57 == false)
            {
                goto label_219;
            }
            
            val_107 = null;
            val_107 = null;
            var val_100 = 0;
            val_100 = val_100 + 1;
            val_108 = 0;
            goto label_226;
            label_219:
            val_106 = 10;
            val_110 = "";
            if(val_86 != 0)
            {
                goto label_230;
            }
            
            goto label_228;
            label_226:
            val_111 = ", ";
            val_110 = "\"s4\":"("\"s4\":") + 丄丙下丝丛丒七丂丘.Item[???](丄丙下丝丛丒七丂丘.Item[???]) + val_111;
            val_87 = val_12;
            val_86 = val_13;
            if(val_86 != 0)
            {
                goto label_230;
            }
            
            label_228:
            label_230:
            if((val_110 != null) && (val_110 == null))
            {
                    val_111 = 0;
            }
            
            if(((val_57 != true) ? 10 : 0) >= (val_57 != true ? val_50 != true ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? val_2 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 + 24))
            {
                    val_111 = 0;
            }
            
            var val_62 = val_86 + ((val_57 != true ? 10 : 0) << 3);
            mem2[0] = val_110;
            val_112 = null;
            val_112 = null;
            var val_101 = 0;
            val_101 = val_101 + 1;
            val_111 = 4;
            val_114 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            bool val_64 = 丄丙下丝丛丒七丂丘.ContainsKey(key:  ???);
            val_12 = (val_64 != true) ? (val_87) : 0;
            val_13 = (val_64 != true) ? (val_86) : 0;
            if(val_64 == false)
            {
                goto label_241;
            }
            
            val_116 = null;
            val_116 = null;
            var val_102 = 0;
            val_102 = val_102 + 1;
            val_117 = 0;
            goto label_248;
            label_241:
            val_115 = 11;
            val_119 = "";
            if(val_86 != 0)
            {
                goto label_251;
            }
            
            goto label_250;
            label_248:
            val_120 = ", ";
            val_119 = "\"j1\":"("\"j1\":") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丄丙下丝丛丒七丂丘.Item[???])(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丄丙下丝丛丒七丂丘.Item[???])) + val_120;
            val_86 = val_13;
            val_87 = val_12;
            if(val_86 != 0)
            {
                goto label_251;
            }
            
            label_250:
            label_251:
            if((val_119 != null) && (val_119 == null))
            {
                    val_120 = 0;
            }
            
            if(((val_64 != true) ? 11 : 0) >= (val_64 != true ? val_57 != true ? val_50 != true ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? val_2 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 + 24))
            {
                    val_120 = 0;
            }
            
            var val_70 = val_86 + ((val_64 != true ? 11 : 0) << 3);
            mem2[0] = val_119;
            val_121 = null;
            val_121 = null;
            var val_103 = 0;
            val_103 = val_103 + 1;
            val_120 = 4;
            val_123 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            bool val_72 = 丄丙下丝丛丒七丂丘.ContainsKey(key:  ???);
            System.Object[] val_74 = (val_72 != true) ? (val_86) : 0;
            string val_75 = (val_72 != true) ? (val_87) : 0;
            if(val_72 == false)
            {
                goto label_262;
            }
            
            val_125 = null;
            val_125 = null;
            var val_104 = 0;
            val_104 = val_104 + 1;
            val_126 = 0;
            goto label_269;
            label_262:
            val_124 = 12;
            val_128 = "";
            if(val_86 != 0)
            {
                goto label_272;
            }
            
            goto label_271;
            label_269:
            val_129 = ", ";
            val_128 = "\"j2\":"("\"j2\":") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丄丙下丝丛丒七丂丘.Item[???])(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丄丙下丝丛丒七丂丘.Item[???])) + val_129;
            val_86 = val_74;
            val_87 = val_75;
            if(val_86 != 0)
            {
                goto label_272;
            }
            
            label_271:
            label_272:
            if((val_128 != null) && (val_128 == null))
            {
                    val_129 = 0;
            }
            
            if(((val_72 != true) ? 12 : 0) >= (val_72 != true ? val_64 != true ? val_57 != true ? val_50 != true ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? 丄丙下丝丛丒七丂丘 != 0x1 ? val_2 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 : 0 + 24))
            {
                    val_129 = 0;
            }
            
            var val_80 = val_86 + ((val_72 != true ? 12 : 0) << 3);
            mem2[0] = val_128;
            val_130 = null;
            val_130 = null;
            var val_105 = 0;
            val_105 = val_105 + 1;
            val_129 = 4;
            val_132 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
            bool val_82 = 丄丙下丝丛丒七丂丘.ContainsKey(key:  ???);
            var val_83 = (val_82 != true) ? 13 : 0;
            val_74 = (val_82 != true) ? (val_86) : 0;
            val_75 = (val_82 != true) ? (val_87) : 0;
            if(val_82 == false)
            {
                goto label_283;
            }
            
            val_134 = null;
            val_134 = null;
            val_85 = 1152921505690124288;
            var val_106 = 0;
            val_106 = val_106 + 1;
            val_132 = 0;
            goto label_290;
            label_283:
            val_133 = 13;
            val_136 = "";
            val_85 = 1152921505690124288;
            if(val_86 != 0)
            {
                goto label_293;
            }
            
            goto label_292;
            label_290:
            val_136 = "\"j3\":"("\"j3\":") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丄丙下丝丛丒七丂丘.Item[???])(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丄丙下丝丛丒七丂丘.Item[???]));
            val_86 = val_74;
            val_87 = val_75;
            if(val_86 != 0)
            {
                goto label_293;
            }
            
            label_292:
            label_293:
            var val_88 = val_86 + ((val_82 != true ? 13 : 0) << 3);
            mem2[0] = val_136;
            UnityEngine.Debug.LogFormat(format:  val_87, args:  val_86);
            label_3:
            this.万不七丄丝且丟丄丂.丝丒丈丟万不丘丂丑(下丅丙一丂丗丅丝七:  丄丙下丝丛丒七丂丘);
            if(this.万不七丄丝且丟丄丂.Count >= this.丆东下丁七专丞不万())
            {
                    if(this.万不七丄丝且丟丄丂.Count >= 1)
            {
                    System.Collections.Generic.IDictionary<System.String, System.Object> val_92 = this.万不七丄丝且丟丄丂.丆不丙丑丞丆丌东丅();
            }
            
            }
            
            if(PGCompany.Analytics.上丒丞上丌丌丘丛一.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "<color=white>[I_nhouseA_nalytics] [Check_SendAnalytics] Stack: "("<color=white>[I_nhouseA_nalytics] [Check_SendAnalytics] Stack: ") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.万不七丄丝且丟丄丂)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.万不七丄丝且丟丄丂)) + " </color>"(" </color>"));
            }
            
            this.不丝丙专丐丛丂丟七();
        }
        private void 丌丅下业丛丘三不七()
        {
            var val_1;
            if(this.丝丕丆丛丟世万且丞 == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.丝丕丆丛丟世万且丞.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        internal static bool 世丑三丆丒七丘丕丑()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = 1152921505690124288;
            val_11 = null;
            val_11 = null;
            val_12 = null;
            if((1152921505690128400 & 1) != 0)
            {
                    val_14 = null;
                val_13 = 1152921516780988800;
                val_10 = ???;
            }
            
            bool val_3 = System.Convert.ToBoolean(value:  UnityEngine.PlayerPrefs.GetInt(key:  "Analytics.Inhouse.Enabled-v2", defaultValue:  1));
            mem2[0] = 0;
            var val_4 = (val_10 + 184) + 16;
            val_4 = val_4 & 1;
            return (bool)val_4;
        }
        internal static void 丏丐丝上三丁丞丝丕(bool 丙业与丙丗丝不丈东)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = 丙业与丙丗丝不丈东;
            val_5 = null;
            val_5 = null;
            if((1152921505690128400 & 1) != 0)
            {
                    val_6 = null;
                val_6 = null;
                if((1152921505690128400 ^ val_4 & 1) == 0)
            {
                    return;
            }
            
            }
            
            bool val_2 = val_4;
            val_7 = null;
            val_7 = null;
            PGCompany.Analytics.上丒丞上丌丌丘丛一.与丒丕丁下世东丅丌 = 0;
            val_4 = 1152921505690128400;
            UnityEngine.PlayerPrefs.SetInt(key:  "Analytics.Inhouse.Enabled-v2", value:  System.Convert.ToInt32(value:  false));
        }
        internal int 丆东下丁七专丞不万()
        {
            return PGCompany.Analytics.上丒丞上丌丌丘丛一.不万丅不丁世丅丞丘(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = this.东丒下且下丗丈三与}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.StorageLimit-v2", 专不三上丏专丄且丞:  10);
        }
        internal void 丛一丐丑与丁丁业丝(int 丙业与丙丗丝不丈东)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丈丛丌专专丁丒不丙(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = this.东丒下且下丗丈三与}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.StorageLimit-v2", 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        private int 丘世东七一与丝丛丒()
        {
            return PGCompany.Analytics.上丒丞上丌丌丘丛一.不万丅不丁世丅丞丘(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = this.东丛丛丌专下丁丘丒}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.MemoryLimit-v2", 专不三上丏专丄且丞:  50);
        }
        internal void 一丏且丄丌丗万专不(int 丙业与丙丗丝不丈东)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丈丛丌专专丁丒不丙(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = this.东丛丛丌专下丁丘丒}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.MemoryLimit-v2", 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        private int 业丅一下丙丙三丆世()
        {
            return PGCompany.Analytics.上丒丞上丌丌丘丛一.不万丅不丁世丅丞丘(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = this.下丑丌丟丆与丕丞丞}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.QueueThreshold-v2", 专不三上丏专丄且丞:  30);
        }
        internal void 且上下丕世丟下丝丝(int 丙业与丙丗丝不丈东)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.丈丛丌专专丁丒不丙(丄丒丗丟世丘万丙丟: ref  new System.Nullable<System.Int32>() {HasValue = this.下丑丌丟丆与丕丞丞}, 下上丐丆丝丟丝丒不:  "Analytics.Inhouse.QueueThreshold-v2", 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        private static int 与丄丘丄丕万三与丛()
        {
            return 1;
        }
        internal bool 丝丗丕万丟且丁丁一()
        {
            return (bool)(this.丄丘丑专丙下世丕与() >= this.业丅一下丙丙三丆世()) ? 1 : 0;
        }
        internal static int 不万丅不丁世丅丞丘(ref System.Nullable<int> 丄丒丗丟世丘万丙丟, string 下上丐丆丝丟丝丒不, int 专不三上丏专丄且丞)
        {
            int val_10;
            string val_11;
            var val_12;
            val_10 = 专不三上丏专丄且丞;
            val_11 = 下上丐丆丝丟丝丒不;
            val_12 = 1152921560216911232;
            if((val_12 & 1) != 0)
            {
                    val_10 = ???;
                val_12 = ???;
                val_11 = ???;
            }
            
            if(val_11 != 0)
            {
                    int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  val_11, defaultValue:  val_10);
                mem2[0] = 0;
                return (int)val_12;
            }
            
            System.ArgumentNullException val_8 = new System.ArgumentNullException(paramName:  "key");
        }
        internal static void 丈丛丌专专丁丒不丙(ref System.Nullable<int> 丄丒丗丟世丘万丙丟, string 下上丐丆丝丟丝丒不, int 丙业与丙丗丝不丈东)
        {
            if((1152921560217048704 & 1) != 0)
            {
                    if(1152921560217048704 == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            }
            
            if(下上丐丆丝丟丝丒不 != null)
            {
                    丄丒丗丟世丘万丙丟.HasValue = false;
                mem[1152921560217048705] = 0;
                UnityEngine.PlayerPrefs.SetInt(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "key");
        }
        internal static string 丘三丄东丗丌丝东世(ref string 丄丒丗丟世丘万丙丟, string 下上丐丆丝丟丝丒不, string 专不三上丏专丄且丞)
        {
            string val_3;
            string val_5;
            val_3 = 丄丒丗丟世丘万丙丟;
            if(val_3 != null)
            {
                    return val_1;
            }
            
            if(下上丐丆丝丟丝丒不 == null)
            {
                goto label_2;
            }
            
            if(专不三上丏专丄且丞 == null)
            {
                goto label_3;
            }
            
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  下上丐丆丝丟丝丒不, defaultValue:  专不三上丏专丄且丞);
            丄丒丗丟世丘万丙丟 = val_1;
            return val_1;
            label_2:
            val_5 = "key";
            goto label_4;
            label_3:
            val_5 = "defaultValue";
            label_4:
            null = new System.ArgumentNullException(paramName:  val_5);
        }
        internal static void 丝上万丙与上三专丆(ref string 丄丒丗丟世丘万丙丟, string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            string val_4;
            if((System.String.Equals(a:  丄丒丗丟世丘万丙丟, b:  丙业与丙丗丝不丈东, comparisonType:  4)) != false)
            {
                    return;
            }
            
            if(下上丐丆丝丟丝丒不 == null)
            {
                goto label_2;
            }
            
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_3;
            }
            
            丄丒丗丟世丘万丙丟 = 丙业与丙丗丝不丈东;
            UnityEngine.PlayerPrefs.SetString(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
            return;
            label_2:
            val_4 = "key";
            goto label_4;
            label_3:
            val_4 = "value";
            label_4:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        private static 上丒丞上丌丌丘丛一()
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一.万业与丕丂丆且东七 = true;
        }
    
    }

}
