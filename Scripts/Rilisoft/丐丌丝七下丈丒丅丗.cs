using UnityEngine;

namespace Rilisoft
{
    public class 丐丌丝七下丈丒丅丗
    {
        // Fields
        internal static bool 丐丆三丑上丝丁丗丅;
        public const string 业七丈万丏丑丅丟且 = "CloudSyncController.ALLOW_EDITOR_CLOUD_KEY";
        private static Rilisoft.丐丌丝七下丈丒丅丗 世丒丞七专三与万丕;
        internal static bool 三业与一丆与下丐丕;
        private float 万一丅丘一且丝三丌;
        private System.Collections.Generic.Dictionary<string, Rilisoft.丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏> 丒不丛世丄丑三上丟;
        private static bool <丂丂业万丞丁丞东七>k__BackingField;
        private static System.Action 丑东丁丆万不丙万七;
        private static System.Action 丌丈三七万下丐丑丒;
        private static bool <丒丕万丐三丅丛东且>k__BackingField;
        
        // Properties
        internal System.Collections.Generic.Dictionary<string, Rilisoft.丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏> 丛丟丅丛一丐丅丛且 { get; }
        internal static Rilisoft.丐丌丝七下丈丒丅丗 丆丕丝丒不丙且丐丗 { get; }
        internal static bool 丈丐丅丗不丁丗丑一 { get; set; }
        private float 万丒丟丆丛丟与丘七 { get; }
        internal static bool 且丒世丞丟丆丙一丌 { get; set; }
        internal static bool 丅三丅下丅丘丈丟七 { get; set; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<string, Rilisoft.丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏> 丕且三万丑丙丟丑上()
        {
            return (System.Collections.Generic.Dictionary<System.String, 丞丁丙与丝丁不三丏>)this.丒不丛世丄丑三上丟;
        }
        protected 丐丌丝七下丈丒丅丗()
        {
            this.万一丅丘一且丝三丌 = -3.402823E+38f;
            this.丒不丛世丄丑三上丟 = new System.Collections.Generic.Dictionary<System.String, 丞丁丙与丝丁不三丏>();
            Rilisoft.丆专且丆世丟丄与丂 val_2 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.PURCHASES_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_2;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.丟丂丗丁丝丞一且业(丌万且丕丕业上丈丞:  val_2);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.PURCHASES_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_5 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.CAMPAIGN_PROGRESS_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_5;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.丈丆丈东丟丐七丂丞(丌万且丕丕业上丈丞:  val_5);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.CAMPAIGN_PROGRESS_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_8 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.CAMPAIGN_SECRETS_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_8;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.丛丑三丄与丏且丝下(丌万且丕丕业上丈丞:  val_8);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.CAMPAIGN_SECRETS_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_11 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.TROPHIES_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_11;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.不专东与丝丞与且丟(丌万且丕丕业上丈丞:  val_11);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.TROPHIES_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_14 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.ACHIEVEMENTS_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_14;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.一专丑丂丛丄与上丁(丌万且丕丕业上丈丞:  val_14);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.ACHIEVEMENTS_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_17 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.SKINS_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_17;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.丁丟三丝丕丌东丝业(丌万且丕丕业上丈丞:  val_17);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.SKINS_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_20 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.PETS_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_20;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.业丞专世丌下丈专丐(丌万且丕丕业上丈丞:  val_20);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.PETS_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_23 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.TECHNICAL_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_23;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.与与丟丟世万丙世上(丌万且丕丕业上丈丞:  val_23);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.TECHNICAL_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_26 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.LOBBY_ITEMS_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_26;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.丕丏专丛下七七丄东(丌万且丕丕业上丈丞:  val_26);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.LOBBY_ITEMS_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_29 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.DETAILS_SHCRAFT_V2_SYNC_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_29;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.丗丏七万丙专万不丌(丌万且丕丕业上丈丞:  val_29);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.DETAILS_SHCRAFT_V2_SYNC_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_32 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.WEAPONS_LEVELS_SYNCHRONIZATION_SLOT");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_32;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.丗丄丙丁丌业丅丒丕(丌万且丕丕业上丈丞:  val_32);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.WEAPONS_LEVELS_SYNCHRONIZATION_SLOT", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
            Rilisoft.丆专且丆世丟丄与丂 val_35 = Rilisoft.不丞丕三一三上丝丏.东丝七业丄丑丒世七(丝丏丅丄丕世万三丑:  "CloudSynchronizationConstants.craftdetailssyncslot");
            .<七东丅丗丙下丐丘丈>k__BackingField = val_35;
            .<丝专丞丑丞丏业丆丈>k__BackingField = new Rilisoft.一丘丐丑丞三丌丒丞(丌万且丕丕业上丈丞:  val_35);
            this.丒不丛世丄丑三上丟.Add(key:  "CloudSynchronizationConstants.craftdetailssyncslot", value:  new 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏());
        }
        internal static Rilisoft.丐丌丝七下丈丒丅丗 丑七不且上丗丁一世()
        {
            Rilisoft.丐丌丝七下丈丒丅丗 val_2;
            var val_3 = null;
            if(Rilisoft.丐丌丝七下丈丒丅丗.世丒丞七专三与万丕 == null)
            {
                    Rilisoft.丐丌丝七下丈丒丅丗 val_1 = null;
                val_2 = val_1;
                val_1 = new Rilisoft.丐丌丝七下丈丒丅丗();
                val_3 = null;
                val_3 = null;
                Rilisoft.丐丌丝七下丈丒丅丗.世丒丞七专三与万丕 = val_2;
            }
            
            val_3 = null;
            return (Rilisoft.丐丌丝七下丈丒丅丗)Rilisoft.丐丌丝七下丈丒丅丗.世丒丞七专三与万丕;
        }
        internal static bool 丗不丛七丘丞上丕丒()
        {
            null = null;
            return (bool)Rilisoft.丐丌丝七下丈丒丅丗.<丂丂业万丞丁丞东七>k__BackingField;
        }
        private static void 一上丂丑一丘丟上丁(bool 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.丐丌丝七下丈丒丅丗.<丂丂业万丞丁丞东七>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private float 丛丘丘丅丄世丕与丝()
        {
            return 300f;
        }
        internal static bool 丏与上不丛且业与丘()
        {
            return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "CloudSyncController.ALLOW_EDITOR_CLOUD_KEY", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1) ? 1 : 0;
        }
        internal static void 丒一丆丑丌丟丘丗丘(bool 丙业与丙丗丝不丈东)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "CloudSyncController.ALLOW_EDITOR_CLOUD_KEY", 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal static void 丛丑丌丅东上丘丌与(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.丐丌丝七下丈丒丅丗.丑东丁丆万不丙万七, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.丐丌丝七下丈丒丅丗.丑东丁丆万不丙万七 != 1152921505438212120);
        
        }
        internal static void 丅丗丟丟丘丆专一东(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.丐丌丝七下丈丒丅丗.丑东丁丆万不丙万七, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.丐丌丝七下丈丒丅丗.丑东丁丆万不丙万七 != 1152921505438212120);
        
        }
        internal static void 丅丞丌业丏东丁丙丟(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.丐丌丝七下丈丒丅丗.丌丈三七万下丐丑丒, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.丐丌丝七下丈丒丅丗.丌丈三七万下丐丑丒 != 1152921505438212128);
        
        }
        internal static void 丆丅丛与世世与丂丝(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.丐丌丝七下丈丒丅丗.丌丈三七万下丐丑丒, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.丐丌丝七下丈丒丅丗.丌丈三七万下丐丑丒 != 1152921505438212128);
        
        }
        private void 丞世丟丟东一下丟丄()
        {
            null = null;
            if(Rilisoft.丐丌丝七下丈丒丅丗.丌丈三七万下丐丑丒 == null)
            {
                    return;
            }
            
            Rilisoft.丐丌丝七下丈丒丅丗.丌丈三七万下丐丑丒.Invoke();
        }
        public bool 三丗丟丆丕丆丌丙万()
        {
            object val_14;
            var val_15;
            if(UnityEngine.Application.platform != 8)
            {
                goto label_1;
            }
            
            val_15 = 1;
            goto label_29;
            label_1:
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                goto label_16;
            }
            
            val_14 = 1152921505171275776;
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
            {
                goto label_6;
            }
            
            val_14 = 1152921505461956608;
            if(Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世() == null)
            {
                goto label_29;
            }
            
            val_14 = Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世();
            val_15 = val_14;
            bool val_6 = val_15.下丏丗与七丑丅与丅();
            goto label_29;
            label_6:
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
            {
                goto label_16;
            }
            
            val_14 = GameCircleSocial.Instance;
            if(val_14.localUser == null)
            {
                goto label_29;
            }
            
            val_14 = GameCircleSocial.Instance.localUser;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = val_14;
            goto label_29;
            label_16:
            val_15 = 0;
            label_29:
            val_15 = val_15 & 1;
            return (bool)val_15;
        }
        internal string 丏七丆下一业丙世丆()
        {
            object val_5;
            int val_6;
            val_5 = this;
            丞丁丙与丝丁不三丏 val_1 = 0;
            if(((this.丒不丛世丄丑三上丟 != null) && (val_1 != 0)) && (((this.丒不丛世丄丑三上丟.TryGetValue(key:  "CloudSynchronizationConstants.WEAPONS_LEVELS_SYNCHRONIZATION_SLOT", value: out  val_1)) ^ 1) != true))
            {
                    val_6 = 11993091;
                if(val_6 != 0)
            {
                    return (string)val_6;
            }
            
            }
            
            val_6 = System.String.alignConst;
            return (string)val_6;
        }
        private string 丏丐上丈丑丞丁世丘()
        {
            object val_9;
            string val_10;
            int val_11;
            val_9 = this;
            丞丁丙与丝丁不三丏 val_1 = 0;
            if(this.丒不丛世丄丑三上丟 != null)
            {
                    val_10 = "CloudSynchronizationConstants.PURCHASES_SYNCHRONIZATION_SLOT";
                if((val_1 != 0) && ((((this.丒不丛世丄丑三上丟.TryGetValue(key:  val_10, value: out  val_1)) ^ 1) != true) && (11993091 != 0)))
            {
                    if(UnityEngine.Application.platform == 8)
            {
                    label_10:
                val_10 = 1;
                System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> val_5 = this.专业丛丂丅与世上丙(与且专丏丅世丐丐丑:  true, 丙丈丄丟业丗上丒丛:  false);
            }
            else
            {
                    if(UnityEngine.Application.isEditor != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                goto label_10;
            }
            
            }
            
            }
            
                val_9 = 11993091;
                val_11 = val_9;
                return (string)val_11;
            }
            
            }
            
            val_11 = System.String.alignConst;
            return (string)val_11;
        }
        private string 与丌丙万与丂丐丘丒()
        {
            object val_9;
            string val_10;
            int val_11;
            val_9 = this;
            丞丁丙与丝丁不三丏 val_1 = 0;
            if(this.丒不丛世丄丑三上丟 != null)
            {
                    val_10 = "CloudSynchronizationConstants.WEAPONS_LEVELS_SYNCHRONIZATION_SLOT";
                if((val_1 != 0) && ((((this.丒不丛世丄丑三上丟.TryGetValue(key:  val_10, value: out  val_1)) ^ 1) != true) && (11993091 != 0)))
            {
                    if(UnityEngine.Application.platform == 8)
            {
                    label_10:
                val_10 = 1;
                System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> val_5 = this.专业丛丂丅与世上丙(与且专丏丅世丐丐丑:  true, 丙丈丄丟业丗上丒丛:  false);
            }
            else
            {
                    if(UnityEngine.Application.isEditor != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                goto label_10;
            }
            
            }
            
            }
            
                val_9 = 11993091;
                val_11 = val_9;
                return (string)val_11;
            }
            
            }
            
            val_11 = System.String.alignConst;
            return (string)val_11;
        }
        public System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> 专业丛丂丅与世上丙(bool 与且专丏丅世丐丐丑, bool 丙丈丄丟业丗上丒丛 = False)
        {
            System.Collections.Generic.List<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> val_1 = new System.Collections.Generic.List<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this.丒不丛世丄丑三上丟.Values.GetEnumerator();
            bool val_4 = 与且专丏丅世丐丐丑;
            label_12:
            if(((-791660648) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_5 = 0.丐丏七丌丕丗业且上();
            if(丙丈丄丟业丗上丒丛 == false)
            {
                goto label_4;
            }
            
            if((val_5.m_stringLength & 1) != 0)
            {
                goto label_12;
            }
            
            goto label_9;
            label_4:
            label_9:
            val_1.Add(item:  val_5.m_stringLength);
            goto label_12;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>)val_1;
        }
        public System.Collections.IEnumerator 丂丗丞丞且万丛万不(bool 丟东丈丗丏丛世万一, bool 且丏下一下上丟与丐)
        {
            丐丌丝七下丈丒丅丗.万丙专丐七丗丛东丙 val_1 = new 丐丌丝七下丈丒丅丗.万丙专丐七丗丛东丙();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丟东丈丗丏丛世万一 = 丟东丈丗丏丛世万一;
            }
            else
            {
                    mem[40] = this;
                mem[48] = 丟东丈丗丏丛世万一;
            }
            
            .且丏下一下上丟与丐 = 且丏下一下上丟与丐;
            return (System.Collections.IEnumerator)val_1;
        }
        private static System.Collections.IEnumerator 丝万丗丐世万上丛丆(int 上丟专下不一丗丙丆, bool 七万东下丛万丁且丘, bool 丝丌丆一上丙丏丁业)
        {
            丐丌丝七下丈丒丅丗.丕丞丅上丛丁七且丑 val_1 = new 丐丌丝七下丈丒丅丗.丕丞丅上丛丁七且丑();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .上丟专下不一丗丙丆 = 上丟专下不一丗丙丆;
                .七万东下丛万丁且丘 = 七万东下丛万丁且丘;
            }
            else
            {
                    mem[32] = 上丟专下不一丗丙丆;
                .七万东下丛万丁且丘 = 七万东下丛万丁且丘;
            }
            
            .丝丌丆一上丙丏丁业 = 丝丌丆一上丙丏丁业;
            return (System.Collections.IEnumerator)val_1;
        }
        private static System.Collections.IEnumerator 丙丑丘不丙丆丏丂万()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.丟丛不丗万丂与丈丁();
        }
        private static void 七丞丌下专且丁一丅()
        {
            null = null;
            if(Rilisoft.丐丌丝七下丈丒丅丗.丑东丁丆万不丙万七 == null)
            {
                    return;
            }
            
            Rilisoft.丐丌丝七下丈丒丅丗.丑东丁丆万不丙万七.Invoke();
        }
        private static void 丆且业丈丆丘七且上(bool 七万东下丛万丁且丘, bool 丝丌丆一上丙丏丁业)
        {
            Rilisoft.丐丌丝七下丈丒丅丗.七丞丌下专且丁一丅();
            BalanceController.丙丏丂下丂上七不一();
            if((PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() | 丝丌丆一上丙丏丁业) == true)
            {
                    return;
            }
            
            if(七万东下丛万丁且丘 == false)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPTutorialController.SkipTutorial();
        }
        public System.Collections.IEnumerator 丆丛下不丄上丄专一()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.下世丗丂丒丐丒不丐();
        }
        public static void 丑与丈丘丁丄丌丁丌()
        {
        
        }
        internal static bool 丁丟丗与万丆丝丈丞()
        {
            null = null;
            return (bool)Rilisoft.丐丌丝七下丈丒丅丗.<丒丕万丐三丅丛东且>k__BackingField;
        }
        private static void 丂上且丞丘丗下一丐(bool 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.丐丌丝七下丈丒丅丗.<丒丕万丐三丅丛东且>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static System.Collections.IEnumerator 丈世丏丟不丗丏丛三()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.丄丒七丐与丛上上丑();
        }
        internal static System.Collections.IEnumerator 世丐不丗不业七丘丐(bool 与下丛丂丒丘丛三丆, bool 丄丌丟丛丆丝东世一, bool 丙丛丐东与丒且丂上 = False, bool 且丏下一下上丟与丐 = False)
        {
            丐丌丝七下丈丒丅丗.丂世丆丈丐丟丐丏不 val_1 = new 丐丌丝七下丈丒丅丗.丂世丆丈丐丟丐丏不();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .与下丛丂丒丘丛三丆 = 与下丛丂丒丘丛三丆;
                .丙丛丐东与丒且丂上 = 丙丛丐东与丒且丂上;
            }
            else
            {
                    mem[48] = 与下丛丂丒丘丛三丆;
                .丙丛丐东与丒且丂上 = 丙丛丐东与丒且丂上;
            }
            
            .且丏下一下上丟与丐 = 且丏下一下上丟与丐;
            return (System.Collections.IEnumerator)val_1;
        }
        internal static System.Collections.IEnumerator 业丄与丅丂丙丕丒专(bool 且丏下一下上丟与丐)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .且丏下一下上丟与丐 = 且丏下一下上丟与丐;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.丙上丗业丑丗丌丈丁();
        }
        internal static System.Collections.IEnumerator 丈丈东专丟丙万丅东(bool 且丏下一下上丟与丐)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .且丏下一下上丟与丐 = 且丏下一下上丟与丐;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.丕丅七丝丟下丝上丆();
        }
        internal static bool 丕万世丄丄七丐丘丈()
        {
            return (bool)(Rilisoft.丐丌丝七下丈丒丅丗.丐丌三丗丒丙丒不上() == 1) ? 1 : 0;
        }
        internal static Rilisoft.丐丌丝七下丈丒丅丗.一与丆七七丁丈东丗 丐丌三丗丒丙丒不上()
        {
            System.Object[] val_22;
            var val_23;
            int val_7 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = 0;
            string val_9 = 0;
            val_22 = 1152921505438208000;
            int val_16 = 0;
            if(Rilisoft.丐丌丝七下丈丒丅丗.丂丂丌丈丑丙丏丒丝() == 2)
            {
                    return (一与丆七七丁丈东丗)val_23;
            }
            
            val_22 = Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世();
            string val_3 = val_22.与丌丙万与丂丐丘丒();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) != true)
            {
                    val_22 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_3);
                if(val_22 != null)
            {
                    object[] val_6 = new object[1];
                val_22 = val_6;
                val_22[0] = val_3;
                UnityEngine.Debug.LogErrorFormat(format:  "AreProgressInCurrentPullResult: currentWeaponLevelsResult not a Dictionary<string, object>: {0}", args:  val_6);
            }
            
            }
            
            val_23 = 0;
            return (一与丆七七丁丈东丗)val_23;
        }
        private static Rilisoft.丐丌丝七下丈丒丅丗.一与丆七七丁丈东丗 丂丂丌丈丑丙丏丒丝()
        {
            var val_14;
            string val_2 = Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丏丐上丈丑丞丁世丘();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) != true)
            {
                    if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_2)) == null)
            {
                    return (一与丆七七丁丈东丗)val_14;
            }
            
                object[] val_5 = new object[1];
                val_5[0] = val_2;
                UnityEngine.Debug.LogErrorFormat(format:  "AreProgressInCurrentPullResult: not a json list: {0}", args:  val_5);
            }
            
            val_14 = 0;
            return (一与丆七七丁丈东丗)val_14;
        }
        internal static System.Collections.IEnumerator 下丟不上丏丝丞丒丟(System.Threading.Tasks.TaskCompletionSource<bool> 丕丝专丙丗丙丝丌丗, bool 丑丗业丝丙丁且下七, bool 丙丈丄丟业丗上丒丛 = False)
        {
            丐丌丝七下丈丒丅丗.丙业丘丐丈专丘丈业 val_1 = new 丐丌丝七下丈丒丅丗.丙业丘丐丈专丘丈业();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丕丝专丙丗丙丝丌丗 = 丕丝专丙丗丙丝丌丗;
                .丑丗业丝丙丁且下七 = 丑丗业丝丙丁且下七;
            }
            else
            {
                    mem[40] = 丕丝专丙丗丙丝丌丗;
                mem[56] = 丑丗业丝丙丁且下七;
            }
            
            .丙丈丄丟业丗上丒丛 = 丙丈丄丟业丗上丒丛;
            return (System.Collections.IEnumerator)val_1;
        }
        private static System.Collections.IEnumerator 一丈丈丐丆丙丛丝丌()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.丈丟丈不丗丈丅丞丕();
        }
        private static System.Collections.IEnumerator 丒丙且一三三丏且丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.丞专万上丟丗丘专专();
        }
        private static void 丁丘丘丙下东丟万丞(bool 丄丌丟丛丆丝东世一)
        {
            Rilisoft.丐丌丝七下丈丒丅丗.七丅丅丏业丅丈丏与();
            if(丄丌丟丛丆丝东世一 != false)
            {
                    Rilisoft.丐丌丝七下丈丒丅丗.丈专丝丙丕世不丙丐();
            }
            
            Rilisoft.丐丌丝七下丈丒丅丗.丁专丙业三且丁东万();
            if(ExpController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  (~ExpController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂()) & 1);
            ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  (~ExpController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂()) & 1);
        }
        private static System.Collections.IEnumerator 丗丏七丈丅东下业东(System.Threading.Tasks.TaskCompletionSource<bool> 世丅丒丆三下专丘丆)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .世丅丒丆三下专丘丆 = 世丅丒丆三下专丘丆;
            return (System.Collections.IEnumerator)new 丐丌丝七下丈丒丅丗.丁且丝下丐丁下丅丒();
        }
        private static void 丈专丝丙丕世不丙丐()
        {
            var val_3;
            var val_4;
            var val_5;
            GiftController val_6;
            var val_7;
            WeaponManager.丌丐东业世上丗丅丅();
            val_3 = null;
            val_3 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_4 = null;
                val_4 = null;
                MainMenuController.丄丞丁丈与业上丞丟.RefreshSettingsButton();
            }
            
            val_5 = null;
            val_5 = null;
            val_6 = GiftController.丆丕丝丒不丙且丐丗;
            if((UnityEngine.Object.op_Implicit(exists:  val_6)) == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_6 = GiftController.丆丕丝丒不丙且丐丗;
            val_6.ReCreateSlotsIfPossible();
        }
        private static void 七丅丅丏业丅丈丏与()
        {
            var val_2;
            PlayerPanel val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PlayerPanel.丄丘七三上丕世丞业;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            PlayerPanel.丄丘七三上丕世丞业.UpdateNickPlayer();
            PlayerPanel.丄丘七三上丕世丞业.UpdateExp();
            val_3 = PlayerPanel.丄丘七三上丕世丞业;
            val_3.UpdateRating();
        }
        private static void 丁专丙业三且丁东万()
        {
            GameServicesController val_5 = UnityEngine.Object.FindObjectOfType<GameServicesController>();
            if(val_5 == 0)
            {
                    new UnityEngine.GameObject() = new UnityEngine.GameObject(name:  "Rilisoft.GameServicesController");
                val_5 = new UnityEngine.GameObject().AddComponent<GameServicesController>();
            }
            
            val_5.WaitAuthenticationAndIncrementBeginnerAchievement();
        }
        private static 丐丌丝七下丈丒丅丗()
        {
        
        }
    
    }

}
