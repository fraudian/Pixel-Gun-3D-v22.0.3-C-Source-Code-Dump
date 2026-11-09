using UnityEngine;

namespace Rilisoft
{
    public class Nest : MonoBehaviour
    {
        // Fields
        private static System.Action 不丑世丟业且丛丒丅;
        private static System.Action 下丐丗七且世与丞丟;
        private const string 与丘丑不丕业丙丈丑 = "IsEnabled";
        private const string 世丕丑七丗不上丙七 = "IsOpen";
        private const string 业丆丈丂丂丏丐丛丄 = "drop_eggs";
        internal const string 丝丑专万下丘丙丙万 = "NestHintShowed";
        internal static System.Collections.Generic.List<long> 丆丏东丞丝一丈与上;
        private Rilisoft.AnimationHandler _animationHandler;
        private UnityEngine.Animator _animator;
        private Rilisoft.丝丑丂丛万丐丈丘且 业一丞丏丏丏丑丌下;
        private Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 七丟丞东万丛丌万丙;
        private bool 东上不丄丂丅丒丄专;
        private Rilisoft.NestLobbyHeader _header;
        private UnityEngine.GameObject NestGO;
        private static Rilisoft.Nest <不丁丄七丛不丆丁丕>k__BackingField;
        private System.Func<bool> 丙下丟上丅丙丘丁专;
        private Rilisoft.Nest.不专与丏下丒不丙丁 丄三丈万丙丟丆丈不;
        
        // Properties
        private int 一三且丑不东丆一丑 { get; set; }
        private bool 东丆三七丄丄专丄专 { get; set; }
        internal static bool 专丏世丆且丗丆丛丝 { get; }
        private Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 下专丛丐不丏下世不 { get; }
        private float 业丗不丗丞丘世丙且 { get; }
        internal static Rilisoft.Nest 丆丕丝丒不丙且丐丗 { get; set; }
        private long 丌丂三丛丈上万七丅 { get; }
        private int 与与七上与丛丌万丅 { get; set; }
        public UnityEngine.GameObject 丄七三丘丛丒丏丟业 { get; }
        public bool 丘且东丐下丄丂万专 { get; }
        internal bool 不丘专三且丅上丙七 { get; }
        public System.Nullable<long> 丌与丁不下丅丆丘丞 { get; }
        private static int 丅丛丌丐丁业世丌丕 { get; set; }
        
        // Methods
        internal static void 丈世与丛丆丌且丛且(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Rilisoft.Nest.丝丑专万下丘丙丙万, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丒一丈上东丟不丕与(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Rilisoft.Nest.丝丑专万下丘丙丙万, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 七丑丝不七丗业丞丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.Nest.下丐丗七且世与丞丟, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.Nest.下丐丗七且世与丞丟 != 1152921505443749896);
        
        }
        internal static void 且丌七七丟业与丄三(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.Nest.下丐丗七且世与丞丟, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.Nest.下丐丗七且世与丞丟 != 1152921505443749896);
        
        }
        private int 丌丁丙且丑丌丑丞世()
        {
            object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  48);
            if(val_2 == null)
            {
                    return (int)val_2;
            }
            
            return System.Convert.ToInt32(value:  val_2);
        }
        private void 三丄丑世世丂丝丒万(int 丙业与丙丗丝不丈东)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  48, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        private bool 丘丏七且丏业丂丘丈()
        {
            object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  49);
            if(val_2 == null)
            {
                    return (bool)val_2;
            }
            
            return System.Convert.ToBoolean(value:  val_2);
        }
        private void 下丝丁丝丕与丝专丝(bool 丙业与丙丗丝不丈东)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  49, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        internal static bool 丆丈一丌丒丅丌丌丝()
        {
            var val_12;
            var val_13;
            MainMenuController val_14;
            var val_15;
            var val_16;
            var val_17;
            val_12 = null;
            val_12 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_5;
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_14.丂丙丈与世专上丒上() == true)
            {
                goto label_19;
            }
            
            label_5:
            val_15 = null;
            val_15 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_14;
            }
            
            val_16 = null;
            val_16 = null;
            val_14 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
            val_14 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
            if(activeInHierarchy == false)
            {
                goto label_19;
            }
            
            label_14:
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                goto label_24;
            }
            
            val_14 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            if(val_14.上丙丆不丂丂丄一丂() == false)
            {
                goto label_24;
            }
            
            label_19:
            val_17 = 0;
            goto label_31;
            label_24:
            val_14 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_14 == 0)
            {
                    val_17 = 1;
            }
            else
            {
                    val_14 = BannerWindowController.与丅与丒丅专丙丐丗();
                bool val_10 = val_14.丄丄丁丗且丐丘丟丅();
                val_17 = val_10 ^ 1;
            }
            
            label_31:
            val_10 = val_17;
            return (bool)val_10;
        }
        private Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 与一丂丕业三丙丘三()
        {
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_6 = this.七丟丞东万丛丌万丙;
            if(val_6 != null)
            {
                    return val_6;
            }
            
            if((Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丒且万与一丌丆且丙(丞丅上丏丂且下丅与:  "drop_eggs")) != false)
            {
                    val_6 = Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.下丗丆世丙丛丐丒七<Rilisoft.TimeManagment.专一丈七丏丟丑丗丞>(丞丅上丏丂且下丅与:  "drop_eggs");
            }
            else
            {
                    long val_3 = this.丞丈丟专业丅世世与();
                Rilisoft.TimeManagment.专一丈七丏丟丑丗丞 val_5 = null;
                val_6 = val_5;
                val_5 = new Rilisoft.TimeManagment.专一丈七丏丟丑丗丞(丞丅上丏丂且下丅与:  "drop_eggs", 与丈业丛丝丒丙一丏:  (float)val_3, 丟七丒丟一上丏世丄:  val_3.丐七七且丐丏一七一());
            }
            
            this.七丟丞东万丛丌万丙 = val_6;
            return val_6;
        }
        private float 丐七七且丐丏一七一()
        {
            return UnityEngine.Mathf.Max(a:  1f, b:  Rilisoft.LobbyItemsController.丒丈东丟丁七丏万下(丏丟丌丙丏丏丒三丆:  5));
        }
        internal static Rilisoft.Nest 丑七不且上丗丁一世()
        {
            null = null;
            return (Rilisoft.Nest)Rilisoft.Nest.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.Nest 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.Nest.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private long 丞丈丟专业丅世世与()
        {
            var val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.List<System.Int64> val_10;
            var val_11;
            int val_12;
            var val_13;
            var val_14;
            val_7 = null;
            val_7 = null;
            val_8 = null;
            if(Rilisoft.Nest.丆丏东丞丝一丈与上.Count > this.丐丈丏丙且丈丘不丂())
            {
                    val_9 = null;
                val_10 = this.丐丈丏丙且丈丘不丂();
                val_11 = 1152921516387671696;
                val_12 = val_10;
                return val_10.Item[val_12];
            }
            
            val_13 = null;
            val_10 = Rilisoft.Nest.丆丏东丞丝一丈与上;
            if(val_10 != null)
            {
                    val_14 = val_10.Count;
            }
            else
            {
                    val_14 = 0.Count;
            }
            
            val_11 = 1152921516387671696;
            val_12 = val_14 - 1;
            return val_10.Item[val_12];
        }
        private int 丐丈丏丙且丈丘不丂()
        {
            var val_7;
            Rilisoft.丝丑丂丛万丐丈丘且 val_8;
            var val_9;
            val_7 = null;
            val_7 = null;
            if(this.丌丁丙且丑丌丑丞世() < Rilisoft.Nest.丆丏东丞丝一丈与上.Count)
            {
                    val_8 = this.业一丞丏丏丏丑丌下;
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                int val_3 = Rilisoft.Nest.丆丏东丞丝一丈与上.Count;
                val_3 = val_3 - 1;
                Rilisoft.丝丑丂丛万丐丈丘且 val_4 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_3);
                val_8 = this;
                this.业一丞丏丏丏丑丌下 = val_4;
                mem[1152921542568743984] = val_4.上万三丆专丏丒丗业;
                new Rilisoft.丝丑丂丛万丐丈丘且().三丄丑世世丂丝丒万(丙业与丙丗丝不丈东:  -692808664);
            }
            
            if((1152921542568743976 & 2147483648) != 0)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  new Rilisoft.丝丑丂丛万丐丈丘且().丌丁丙且丑丌丑丞世());
                this.业一丞丏丏丏丑丌下 = val_6.七丄不丐丗三丝丑一;
                mem[1152921542568743980] = val_6.丑丒丄下丁丐专丄丞;
                mem[1152921542568743984] = val_6.上万三丆专丏丒丗业;
            }
        
        }
        private void 三丑丙丈丏丗丞丐东(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丙业与丙丗丝不丈东);
            this.业一丞丏丏丏丑丌下 = val_1;
            mem[1152921542568855984] = val_1.上万三丆专丏丒丗业;
            val_1.七丄不丐丗三丝丑一.三丄丑世世丂丝丒万(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        public UnityEngine.GameObject get_NestGameObject()
        {
            return (UnityEngine.GameObject)this.NestGO;
        }
        public bool get_BannerIsVisible()
        {
            return HatchEggUIBanner.丈丐丞丐上丑且丕万();
        }
        internal bool 专丟丒世丈上丞下与()
        {
            return this.丘丏七且丏业丂丘丈();
        }
        internal static void 一不七丙世下丕丄丅()
        {
            if(Rilisoft.Nest.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            Rilisoft.Nest.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
            UnityEngine.Object.Destroy(obj:  Rilisoft.Nest.丑七不且上丗丁一世().gameObject);
        }
        public System.Nullable<long> get_TimeLeft()
        {
            if(FriendsController.丝丗专上三不丄丑丑() <= 0)
            {
                    return 0;
            }
            
            this = this.与一丂丕业三丙丘三();
            float val_3 = this.丄下不一专丑丄丄三();
            return 0;
        }
        private void 一丁丁丆丞三七丅且(System.Func<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丙下丟上丅丙丘丁专, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙下丟上丅丙丘丁专 != 1152921542569581272);
        
        }
        private void 丑丄丌上丗丘不与世(System.Func<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丙下丟上丅丙丘丁专, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙下丟上丅丙丘丁专 != 1152921542569717848);
        
        }
        public static bool NestCanShow()
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return (bool)0 & 1;
            }
            
            if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.eggsdelivery")) == false)
            {
                    return (bool)0 & 1;
            }
            
            val_14 = 1152921505204396032;
            val_15 = null;
            val_15 = null;
            if(GiftBannerWindow.丘丆且七丑丘且专丟 != false)
            {
                    return (bool)0 & 1;
            }
            
            val_16 = null;
            val_16 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_17 = null;
                val_17 = null;
                if((MainMenuController.丄丞丁丈与业上丞丟 + 40.activeInHierarchy) == true)
            {
                    return (bool)0 & 1;
            }
            
                val_18 = null;
                val_18 = null;
                if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) == true)
            {
                    return (bool)0 & 1;
            }
            
                val_19 = null;
                val_19 = null;
                if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == true)
            {
                    return (bool)0 & 1;
            }
            
                val_20 = null;
                val_20 = null;
                if(MainMenuController.丄丞丁丈与业上丞丟.一丑丟世丛丌丁下不() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(FeedbackMenuController.丑七不且上丗丁一世() == 0)
            {
                    return (bool)0 & 1;
            }
            
            bool val_14 = FeedbackMenuController.丑七不且上丗丁一世().gameObject.activeInHierarchy ^ 1;
            return (bool)0 & 1;
        }
        private void Awake()
        {
            System.Action<System.Int32> val_10;
            Rilisoft.Nest.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
            if(this.丘丏七且丏业丂丘丈() != true)
            {
                    Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_2 = this.与一丂丕业三丙丘三();
            }
            
            val_10 = System.Delegate.Combine(a:  val_3.专一且世世世丏上东, b:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.Nest::不丙丝丘丝丝万专丗(int 丝丛丒不丈丛丘丂丅)));
            if(this.与一丂丕业三丙丘三() == null)
            {
                goto label_6;
            }
            
            if(val_10 != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_10 == null)
            {
                goto label_10;
            }
            
            label_7:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_10:
            val_3.专一且世世世丏上东 = val_10;
            this._animationHandler.add_OnAnimationEvent(丙业与丙丗丝不丈东:  new System.Action<System.String, 丂丌丞七丝上业丅万>(object:  this, method:  System.Void Rilisoft.Nest::丟丟一丙专一丛与丙(string 东丐丛丁一东丑丒专, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 世业丁丒一丒丌丞下)));
            this.丑丄丌上丗丘不与世(丙业与丙丗丝不丈东:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.Nest::上上与丄丈丟丑丟万()));
            this.一丁丁丆丞三七丅且(丙业与丙丗丝不丈东:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.Nest::上上与丄丈丟丑丟万()));
        }
        private void OnDestroy()
        {
            System.Action val_9;
            System.Delegate val_10;
            System.Action<System.Int32> val_11;
            val_9 = 1152921505069785088;
            if(HatchEggUIBanner.丑七不且上丗丁一世() != 0)
            {
                    System.Action val_4 = null;
                val_9 = val_4;
                val_4 = new System.Action(object:  this, method:  System.Void Rilisoft.Nest::丕丝丅专丁一丏七万());
                HatchEggUIBanner.丑七不且上丗丁一世().丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  val_4);
            }
            
            if(this.七丟丞东万丛丌万丙 == null)
            {
                    return;
            }
            
            System.Action<System.Int32> val_5 = null;
            val_9 = val_5;
            val_5 = new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.Nest::不丙丝丘丝丝万专丗(int 丝丛丒不丈丛丘丂丅));
            val_10 = val_9;
            if((System.Delegate.Remove(source:  this.七丟丞东万丛丌万丙.专一且世世世丏上东, value:  val_5)) != null)
            {
                    val_10 = null;
                if(null != val_10)
            {
                    val_10 = 0;
                val_11 = 0;
            }
            
            }
            
            this.七丟丞东万丛丌万丙.专一且世世世丏上东 = val_11;
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_8 = this.与一丂丕业三丙丘三();
            this.七丟丞东万丛丌万丙 = 0;
        }
        private bool 上上与丄丈丟丑丟万()
        {
            Rilisoft.LobbyCraftController val_4;
            var val_5;
            val_4 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            if(val_4 == 0)
            {
                    val_5 = 1;
            }
            else
            {
                    val_4 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
                bool val_2 = val_4.上丙丆不丂丂丄一丂();
                val_5 = val_2 ^ 1;
            }
            
            val_2 = val_5;
            return (bool)val_2;
        }
        private void Update()
        {
            var val_10;
            UnityEngine.GameObject val_11;
            var val_12;
            不专与丏下丒不丙丁 val_13;
            var val_14;
            var val_15;
            long val_16;
            val_10 = null;
            val_11 = this.NestGO;
            if(Rilisoft.Nest.NestCanShow() == false)
            {
                goto label_3;
            }
            
            val_12 = 1;
            val_13 = 1;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
            if(this.丄三丈万丙丟丆丈不 == 0)
            {
                    val_14 = null;
                val_14 = null;
                if(Rilisoft.Nest.丝丑专万下丘丙丙万 != null)
            {
                    val_12 = 0;
                Rilisoft.Nest.丝丑专万下丘丙丙万.Invoke();
            }
            
            }
            
            this.丄三丈万丙丟丆丈不 = val_13;
            if(this.丙下丟上丅丙丘丁专 != null)
            {
                    val_12 = public System.Boolean System.Func<System.Boolean>::Invoke();
                val_13 = this.丙下丟上丅丙丘丁专.Invoke();
            }
            
            val_15 = this;
            if(this.丐丈丏丙且丈丘不丂() >= 1)
            {
                    Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_4 = this.与一丂丕业三丙丘三();
                val_11 = val_4;
                val_15 = val_11;
                val_12 = 0;
                val_15.丄丛丂丈业下且丌丕(丙业与丙丗丝不丈东:  val_4.丐七七且丐丏一七一());
            }
            
            if(val_15.丘丏七且丏业丂丘丈() == true)
            {
                goto label_14;
            }
            
            System.Nullable<System.Int64> val_7 = this.TimeLeft;
            if(( & 1) == 0)
            {
                goto label_14;
            }
            
            System.Nullable<System.Int64> val_8 = this.TimeLeft;
            val_16 = ;
            goto label_15;
            label_3:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
            this.丑丗且丆专丒与丟丄(下下东且万业丞丅丒:  false, 丄专万丏丘上丑与一:  0);
            this.丄三丈万丙丟丆丈不 = 0;
            return;
            label_14:
            val_16 = 0;
            label_15:
            this.丑丗且丆专丒与丟丄(下下东且万业丞丅丒:  val_13, 丄专万丏丘上丑与一:  val_16);
        }
        private void 不丙丝丘丝丝万专丗(int 丝丛丒不丈丛丘丂丅)
        {
            this.下丝丁丝丕与丝专丝(丙业与丙丗丝不丈东:  true);
            if(this.与一丂丕业三丙丘三() == null)
            {
                
            }
        
        }
        public int TryGetEgg()
        {
            return this.丆丙丆不丟且三丗丕();
        }
        private int 丆丙丆不丟且三丗丕()
        {
            if(this.丘丏七且丏业丂丘丈() == false)
            {
                    return 0;
            }
            
            bool val_2 = this.NestGO.activeInHierarchy;
            if(val_2 == false)
            {
                    return 0;
            }
            
            if(this.东上不丄丂丅丒丄专 != false)
            {
                    return 0;
            }
            
            this.东上不丄丂丅丒丄专 = true;
            val_2.丐丝丈丛丒下丆丈上(丝三丄专丗丞丄丄丌:  false);
            return 0;
        }
        private void 丟丟一丙专一丛与丙(string 东丐丛丁一东丑丒专, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 世业丁丒一丒丌丞下)
        {
            var val_3;
            var val_4;
            val_3 = 世业丁丒一丒丌丞下;
            if(((val_3 == 1) && ((System.String.op_Equality(a:  东丐丛丁一东丑丒专, b:  "Open")) != false)) && (this.东上不丄丂丅丒丄专 != false))
            {
                    this.丈且丂丞丒丘丄不丅(丘丒丅三丞丞丛丛丌:  0);
                return;
            }
            
            if(val_3 != 1)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  东丐丛丁一东丑丒专, b:  "Appearing")) == false)
            {
                    return;
            }
            
            val_3 = 1152921505443745792;
            val_4 = null;
            val_4 = null;
            if(Rilisoft.Nest.下丐丗七且世与丞丟 == null)
            {
                    return;
            }
            
            Rilisoft.Nest.下丐丗七且世与丞丟.Invoke();
        }
        internal void 丈且丂丞丒丘丄不丅(Rilisoft.BankBannersHolder 丘丒丅三丞丞丛丛丌)
        {
            if(this.丘丏七且丏业丂丘丈() != false)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  47);
                PGCompany.EggIncubatorProgress val_5 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.万上丞上丗丏东丈不(丘丛丆七与丒世下丛:  Rilisoft.Nest.上丅丄丈丕上东不丁());
                int val_6 = Rilisoft.Nest.上丅丄丈丕上东不丁();
                val_6 = val_6 + 1;
                Rilisoft.Nest.丏业丅万丈丘丘丞下(丙业与丙丗丝不丈东:  val_6);
                Rilisoft.一丟专且三万丞丁丂.丈丟丂丘丕丗丑下丌(丈丕丁丘七丙丞不丙:  val_5.DataId);
                Rilisoft.一丟专且三万丞丁丂.丘丏丌丝万丂业三丛(丑东与丅丐丅丂丞业:  "delivery", 丈丕丁丘七丙丞不丙:  val_5.DataId);
                this.上世且丗万业一丙丅();
                HatchEggUIBanner.丅下三丂不万世丗上(世丕丘丈丙世业东丕:  new PGCompany.丕下丆丑万世业丈丟(三万万丒丏丒不丐丙:  val_5), 丘丒丅三丞丞丛丛丌:  丘丒丅三丞丞丛丛丌);
                HatchEggUIBanner.丑七不且上丗丁一世().丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.Nest::丕丝丅专丁一丏七万()));
                PGCompany.Analytics.一业丗丆世世上丁且.丒丏丈丟丗与丈丗丗(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 三万万丒丏丒不丐丙:  val_5);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                return;
            }
            
            this.丕丝丅专丁一丏七万();
        }
        private void 丕丝丅专丁一丏七万()
        {
            HatchEggUIBanner val_1 = HatchEggUIBanner.丑七不且上丗丁一世();
            val_1.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.Nest::丕丝丅专丁一丏七万()));
            val_1.丐丝丈丛丒下丆丈上(丝三丄专丗丞丄丄丌:  true);
            this.东上不丄丂丅丒丄专 = false;
        }
        private static int 上丅丄丈丕上东不丁()
        {
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  115)) == false)
            {
                    return 0;
            }
            
            Progress.丘东丅丌东丒上七丁 val_3 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
            if(val_3 != null)
            {
                    return val_3.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  115);
            }
            
            return val_3.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  115);
        }
        private static void 丏业丅万丈丘丘丞下(int 丙业与丙丗丝不丈东)
        {
            int val_3;
            var val_4;
            val_3 = 丙业与丙丗丝不丈东;
            val_4 = null;
            if(Rilisoft.Nest.上丅丄丈丕上东不丁() == val_3)
            {
                    return;
            }
            
            val_3 = val_3;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  115, 丙业与丙丗丝不丈东:  val_3);
        }
        private void 上世且丗万业一丙丅()
        {
            long val_1 = FriendsController.丝丗专上三不丄丑丑();
            if(val_1 < 1)
            {
                    return;
            }
            
            val_1.下丝丁丝丕与丝专丝(丙业与丙丗丝不丈东:  false);
            int val_3 = this.丐丈丏丙且丈丘不丂() + 1;
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_3);
            this.业一丞丏丏丏丑丌下 = val_4;
            mem[1152921542571699808] = val_4.上万三丆专丏丒丗业;
            val_4.七丄不丐丗三丝丑一.三丄丑世世丂丝丒万(丙业与丙丗丝不丈东:  val_3);
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_5 = this.与一丂丕业三丙丘三();
            this.与一丂丕业三丙丘三().丈丟丛七丂一丐一下(丙业与丙丗丝不丈东:  (float)this.丞丈丟专业丅世世与());
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_8 = this.与一丂丕业三丙丘三();
            val_8.丄丛丂丈业下且丌丕(丙业与丙丗丝不丈东:  val_8.丐七七且丐丏一七一());
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_10 = this.与一丂丕业三丙丘三();
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_11 = this.与一丂丕业三丙丘三();
            this = ???;
            goto typeof(Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟).__il2cppRuntimeField_198;
        }
        private void 丐丝丈丛丒下丆丈上(bool 丝三丄专丗丞丄丄丌)
        {
            var val_19;
            UnityEngine.Object val_20;
            if(丝三丄专丗丞丄丄丌 != false)
            {
                    val_19 = 1152921504848912384;
                if((BannerWindowController.与丅与丒丅专丙丐丗() != 0) && (BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner != 0))
            {
                    if(BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner.type == 78)
            {
                    BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
            }
            
            }
            
                val_20 = FreeAwardShowHandler.丑七不且上丗丁一世();
                if(val_20 == 0)
            {
                    return;
            }
            
                FreeAwardShowHandler.丑七不且上丗丁一世().IsInteractable = true;
                return;
            }
            
            val_19 = 1152921504848912384;
            if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
            {
                    BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  78, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            }
            
            val_20 = FreeAwardShowHandler.丑七不且上丗丁一世();
            if(val_20 == 0)
            {
                    return;
            }
            
            val_20 = FreeAwardShowHandler.丑七不且上丗丁一世();
            val_20.IsInteractable = false;
        }
        private void 丑丗且丆专丒与丟丄(bool 下下东且万业丞丅丒, long 丄专万丏丘上丑与一 = 0)
        {
            this._header.Set(下下东且万业丞丅丒:  ((this.东上不丄丂丅丒丄专 == false) ? 1 : 0) & 下下东且万业丞丅丒, 丄专万丏丘上丑与一:  丄专万丏丘上丑与一);
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            this.丐丝丈丛丒下丆丈上(丝三丄专丗丞丄丄丌:  true);
            this.东上不丄丂丅丒丄专 = false;
        }
        public Nest()
        {
            this.业一丞丏丏丏丑丌下 = 0;
            mem[1152921542572282976] = 0;
        }
        private static Nest()
        {
            System.Collections.Generic.List<System.Int64> val_1 = new System.Collections.Generic.List<System.Int64>();
            if(val_1 != null)
            {
                    val_1.Add(item:  0);
            }
            else
            {
                    val_1.Add(item:  0);
            }
            
            val_1.Add(item:  16);
            Rilisoft.Nest.丆丏东丞丝一丈与上 = val_1;
        }
    
    }

}
