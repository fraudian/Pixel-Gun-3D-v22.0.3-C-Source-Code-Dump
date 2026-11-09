using UnityEngine;

namespace Rilisoft
{
    internal abstract class GameEventOpenChestBase : BannerWindowWithBack
    {
        // Fields
        private static System.Action 丞东丝丗丂丐与上丝;
        private Rilisoft.ThreeChestsGameEventView _spinView;
        private GEGuiObjectApplyer _chestApplyer;
        private Rilisoft.TextGroup _chestName;
        private Rilisoft.GameEventRewardView 丐丆丟东丈丞业东丛;
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private Rilisoft.上专业三丟丁丞专下 <丂世丕丝丕丛三世丒>k__BackingField;
        private bool 且丒丗丘丝且丄丙丄;
        private bool 丛丁丂上上下三与丟;
        private bool 一丐丒丕丙丙三丞丐;
        private bool 丘丌世下丌丕丒丂下;
        private bool 丒丌东专丌丂上丅丐;
        private bool 万丈丟七且丈世下世;
        private bool 东丙下上业丒世七丌;
        private bool 丌丈世丘与丘丆丌丗;
        internal static BannerWindowType 丏且且与三丙丘丒三;
        internal static int 丅丟丒下丕丄丆丁业;
        private UnityEngine.Color 世下丕东七丆丆专三;
        private bool 丁丝丌丞与丑丂三上;
        protected System.Nullable<float> 三丄丄业丟专丅丏下;
        private UnityEngine.Coroutine 世丟丈丐丘丟丈丝丙;
        
        // Properties
        internal Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        internal Rilisoft.上专业三丟丁丞专下 丌丈东专丟丟与世三 { get; set; }
        internal static bool 丅业东万丌丕上丌丄 { get; }
        internal static bool 丕丆三丆丕不三业丒 { get; }
        protected bool 三业专专丈丂丕丗与 { get; }
        
        // Methods
        internal static void 且丐三丅丁且万且下(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Rilisoft.GameEventOpenChestBase.丞东丝丗丂丐与上丝, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 不丒丅且上丗丂丗丛(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Rilisoft.GameEventOpenChestBase.丞东丝丗丂丐与上丝, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal Rilisoft.丛且世丐丆上七业丁 丄丌一七丈万万丌丐()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.上专业三丟丁丞专下 丈丂七世丙丑丝下丘()
        {
            return (Rilisoft.上专业三丟丁丞专下)this.<丂世丕丝丕丛三世丒>k__BackingField;
        }
        private void 丝丐七世下丕专且丄(Rilisoft.上专业三丟丁丞专下 丙业与丙丗丝不丈东)
        {
            this.<丂世丕丝丕丛三世丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丈丐丞丐上丑且丕万()
        {
            null = null;
            return (bool)(Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 != 1) ? 1 : 0;
        }
        internal static bool 丂东下不丆专丌丈丆()
        {
            var val_8;
            MainMenuController val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = null;
            val_8 = null;
            val_9 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_9 == 0)
            {
                    return (bool)0 & 1;
            }
            
            val_10 = null;
            val_10 = null;
            val_9 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
            val_9 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
            if(activeInHierarchy == false)
            {
                    return (bool)0 & 1;
            }
            
            val_11 = null;
            val_11 = null;
            val_9 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_9.丂丙丈与世专上丒上() == true)
            {
                    return (bool)0 & 1;
            }
            
            val_12 = null;
            val_12 = null;
            val_9 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 24];
            val_9 = MainMenuController.丄丞丁丈与业上丞丟 + 24;
            if(val_9.activeInHierarchy == true)
            {
                    return (bool)0 & 1;
            }
            
            val_13 = null;
            val_13 = null;
            val_9 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_9.IsOpeningFriends != false)
            {
                    return (bool)0 & 1;
            }
            
            bool val_8 = MainStoreView.丈丐丞丐上丑且丕万() ^ 1;
            return (bool)0 & 1;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.丗丛与丁万丙东三且();
            UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
            this.世下丕东七丆丆专三 = val_1;
            mem[1152921542729027196] = val_1.g;
            mem[1152921542729027200] = val_1.b;
            mem[1152921542729027204] = val_1.a;
            this.丁丝丌丞与丑丂三上 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
            CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventOpenChestBase::世与且业业丁专与丕()));
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.丁丝丌丞与丑丂三上);
            CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventOpenChestBase::专不丌万丗丟丒丐专()));
        }
        private void 世与且业业丁专与丕()
        {
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        }
        private void 专不丌万丗丟丒丐专()
        {
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
        }
        internal static void 下与丞三丅丛丄七丕(int 丐东业丕丕丂丗丅丙, BannerWindowType 世丁丌万丏丟丗世三)
        {
            null = null;
            Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 = 丐东业丕丕丂丗丅丙;
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  世丁丌万丏丟丗世三, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        internal static void 下与丞三丅丛丄七丕(Rilisoft.BankBannersHolder 七万上丐一丈丏丏专, int 丐东业丕丕丂丗丅丙, BannerWindowType 世丁丌万丏丟丗世三, PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
        {
            var val_2;
            var val_3;
            if(七万上丐一丈丏丏专 == 0)
            {
                    return;
            }
            
            val_2 = 1152921505451679744;
            val_3 = null;
            val_3 = null;
            Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 = 丐东业丕丕丂丗丅丙;
            七万上丐一丈丏丏专.ShowBanner(丌丅丕一丛丛丄一万:  世丁丌万丏丟丗世三, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        private void 丏且丐丅专七丞丒丕()
        {
            int val_5;
            var val_6;
            this.丌丈世丘与丘丆丌丗 = false;
            val_5 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  135);
            if(val_5 < 1)
            {
                    return;
            }
            
            this.丌丈世丘与丘丆丌丗 = true;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丒丗丄万东上丙丁丈(下上丐丆丝丟丝丒不:  135, 丙业与丙丗丝不丈东:  0);
            val_5 = System.Convert.ToInt32(value:  val_5);
            val_6 = null;
            val_6 = null;
            Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 = val_5;
        }
        public override void Show()
        {
            this.Show();
            this.丏且丐丅专七丞丒丕();
            this.丕东万丟丘与丙丐七();
            goto typeof(Rilisoft.GameEventOpenChestBase).__il2cppRuntimeField_238;
        }
        private void 丗丛与丁万丙东三且()
        {
            var val_6;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_8;
            this.<丂世丕丝丕丛三世丒>k__BackingField = 0;
            Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().万三丛丁丁下下七丝(丁丅丈丌丟世丗丗丟:  100);
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = val_2;
            if(val_2 == null)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = GameEventOpenChestBase.<>c.<>9__40_0;
            if(val_8 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_4 = null;
                val_8 = val_4;
                val_4 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  GameEventOpenChestBase.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameEventOpenChestBase.<>c::丄丘世丗丟一东丞丈(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
                GameEventOpenChestBase.<>c.<>9__40_0 = val_8;
            }
            
            this.<丂世丕丝丕丛三世丒>k__BackingField = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  val_2.丄三丐丟丗丄丟上丞(), predicate:  val_4);
        }
        protected virtual void 丘上丐世丆丑且丞丒()
        {
            var val_14;
            this.丗丛与丁万丙东三且();
            if((this.<丂世丕丝丕丛三世丒>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.丐丆丟东丈丞业东丛 == 0)
            {
                    UnityEngine.Transform val_2 = this.transform;
                Rilisoft.GameEventRewardView val_3 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventRewardView>(丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丒丘丏上丙丟丑丕丈:  "rewardview", 丈东丘丏与丌东东下:  val_2, 丛下丅丏丄且丁一业:  false);
                this.丐丆丟东丈丞业东丛 = val_3;
                丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_3.gameObject, 不东丛三丂丌丑专丆:  val_2.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            if(this._chestName != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(丟丅丘丂丆丘三丟丄:  this._chestName, 丕丗丘丑丛与丑业丒:  Rilisoft.上专业三丟丁丞专下.丄丅三丛丙万丆业业(丐东业丕丕丂丗丅丙:  this.<丂世丕丝丕丛三世丒>k__BackingField.业上丙丞丐丄丆丅七()));
            }
            
            mem2[0] = 1;
            if((this.<丂世丕丝丕丛三世丒>k__BackingField.业上丙丞丐丄丆丅七()) == 1000)
            {
                    val_14 = 4;
            }
            else
            {
                    val_14 = this.<丂世丕丝丕丛三世丒>k__BackingField;
            }
            
            mem2[0] = System.String.Format(format:  "chest_{0}", arg0:  val_14.业上丙丞丐丄丆丅七());
            this._spinView.丈且东丑丂且万丒丅(丌丄东丄丅丗丏一丘:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丐下丝丘丑丟丟丗丌:  this.<丂世丕丝丕丛三世丒>k__BackingField, 丅不东丒丒丅丒丄丁:  this._chestApplyer.GetComponentInChildren<UnityEngine.Animator>());
        }
        protected abstract void 业不下业与下丛一丂(); // 0
        protected virtual void 丌丟丆不丄专丐不丂(bool 万丄丟丅丌万丛七三)
        {
            var val_37;
            var val_39;
            int val_40;
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_41;
            丈丞丕丘丕丗与上一 val_42;
            int val_43;
            string val_44;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  26);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  66);
            丈丞丕丘丕丗与上一 val_6 = null;
            val_37 = 0;
            val_6 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  this.<丂世丕丝丕丛三世丒>k__BackingField.丟丂丞不专丆万丒世(), 丏丂不专上丘丂不丅:  Rilisoft.丛且世丐丆上七业丁.丕万丑且上七世丛不(丟丟丄专上丟丁丐丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七()));
            if((this.<丂世丕丝丕丛三世丒>k__BackingField.业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false)
            {
                goto label_9;
            }
            
            goto label_10;
            label_9:
            if((this.<丂世丕丝丕丛三世丒>k__BackingField.业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false)
            {
                goto label_12;
            }
            
            label_10:
            label_12:
            if((万丄丟丅丌万丛七三 == false) || (((-530793912) & 1) == 0))
            {
                goto label_21;
            }
            
            if((this.<丂世丕丝丕丛三世丒>k__BackingField.丐丏下丕三丒丗丅丛()) == false)
            {
                goto label_20;
            }
            
            if((this.<丂世丕丝丕丛三世丒>k__BackingField.丐丏下丕三丒丗丅丛()) == false)
            {
                goto label_21;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丕丒丙七丘丈丙且丂()) == false)
            {
                goto label_20;
            }
            
            goto label_21;
            label_20:
            val_37 = 0;
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().且下下丆丝丛丑丅丏(丐东业丕丕丂丗丅丙:  this.<丂世丕丝丕丛三世丒>k__BackingField.业上丙丞丐丄丆丅七(), 丁丅丈丌丟世丗丗丟:  0, 下丅三丈世丐丕丌丑:  0, 三丙世丒丙丘一丗上:  false);
            label_21:
            if(( & 1) != 0)
            {
                    var val_15 = (0.丙东专丂世丈丏丁丂() != 0) ? 1 : 0;
                val_15 = val_15 | (~1152921542730758720);
                val_39 = val_15 & 1;
            }
            else
            {
                    val_39 = 0;
            }
            
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_16 = Rilisoft.AbstractGameEventGui.丗丛七丂丁且丟专丕(下丅三丈世丐丕丌丑:  1, 丑万丌丂上业丏上世:  false, 丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丐下丝丘丑丟丟丗丌:  this.<丂世丕丝丕丛三世丒>k__BackingField, 丄丆丂下不丝东丂一:  true);
            List.Enumerator<T> val_17 = val_16.GetEnumerator();
            label_35:
            if(((-530793952) & 1) == 0)
            {
                goto label_29;
            }
            
            string val_19 = 0.丐丏七丌丕丗业且上();
            System.Collections.Generic.List<Rilisoft.GameEventItem> val_20 = new System.Collections.Generic.List<Rilisoft.GameEventItem>();
            null.Add(item:  val_19.丘丗下业东世万丂专());
            if(val_19 != null)
            {
                    val_40 = val_19.m_stringLength;
            }
            else
            {
                    val_40 = 11993091;
            }
            
            this.<丅丝丌丝丁丏丙东丞>k__BackingField.上丐上丐专丞丆丞丁(丑七不与丛丆一丂丞:  null, 丐东业丕丕丂丗丅丙:  11993091, 丄丆丂下不丝东丂一:  (val_19 != null) ? 1 : 0);
            goto label_35;
            label_29:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_42 = val_6;
            val_41 = val_16;
            Rilisoft.GameEventType val_24 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.不业丙丒丂丞下丆丙();
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().专且丈丒世丘丅丝下(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false}, 丑七不与丛丆一丂丞:  null);
            val_43 = System.String.alignConst;
            if((this.<丂世丕丝丕丛三世丒>k__BackingField.丐丏下丕三丒丗丅丛()) == false)
            {
                goto label_51;
            }
            
            val_44 = "Golden";
            goto label_59;
            label_51:
            int val_27 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞().IndexOf(item:  this.<丂世丕丝丕丛三世丒>k__BackingField);
            if(val_27 == 2)
            {
                goto label_55;
            }
            
            if(val_27 == 1)
            {
                goto label_56;
            }
            
            if(val_27 != 0)
            {
                goto label_57;
            }
            
            val_44 = "Little";
            goto label_59;
            label_55:
            val_44 = "Big";
            goto label_59;
            label_56:
            val_44 = "Normal";
            label_59:
            label_57:
            PGCompany.Analytics.一业丗丆世世上丁且.三丗丑丑且丕丌三丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丑七不与丛丆一丂丞:  null, 丐东业丕丕丂丗丅丙:  this.<丂世丕丝丕丛三世丒>k__BackingField.业上丙丞丐丄丆丅七(), 丏业丂七丈丆丛丏上:  val_6, 丄世不下专七丂丘丝:  true, 丌丈世丘与丘丆丌丗:  (this.丌丈世丘与丘丆丌丗 == true) ? 1 : 0);
            Rilisoft.一丟专且三万丞丁丂.下且丙一丂丏丗丌万(丕不丝丙三丕丗丅丌:  val_44, 下丅三丈世丐丕丌丑:  1);
            if(this.世丟丈丐丘丟丈丝丙 != null)
            {
                    this.StopCoroutine(routine:  this.世丟丈丐丘丟丈丝丙);
            }
            
            this.世丟丈丐丘丟丈丝丙 = this.StartCoroutine(routine:  this.世丛万丆丑丌不东丆());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().一业丝且丘丁专丆丕(丅丛下专丅丁一且东:  1, 丏业丂七丈丆丛丏上:  val_6, 丅东专与不三丂丁丝:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丌且丐专七丏与丟丌:  this.<丂世丕丝丕丛三世丒>k__BackingField, 丞七丂丐丂丈丞上丑:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        protected bool 丑丕下丕丕丟且丕丘()
        {
            return (bool)(this.世丟丈丐丘丟丈丝丙 != 0) ? 1 : 0;
        }
        private System.Collections.IEnumerator 世丛万丆丑丌不东丆()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventOpenChestBase.丑上丘业丛丗丏丛丕();
        }
        private void 世丟丞丆与丅丞东丙()
        {
            Rilisoft.GameEventType val_2 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.不业丙丒丂丞下丆丙();
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().专且丈丒世丘丅丝下(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false}, 丑七不与丛丆一丂丞:  0);
        }
        public override void Back()
        {
            null = null;
            Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 = 0;
            this.Back();
            this.HideSelf();
            if(Rilisoft.GameEventOpenChestBase.丞东丝丗丂丐与上丝 == null)
            {
                    return;
            }
            
            Rilisoft.GameEventOpenChestBase.丞东丝丗丂丐与上丝.Invoke();
        }
        public override void Hide()
        {
            this.Hide();
            this.丕上丙下丂丙丟上三();
        }
        private void 丕东万丟丘与丙丐七()
        {
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            val_49 = null;
            val_49 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_50 = null;
                val_50 = null;
                if(MainMenuController.丄丞丁丈与业上丞丟.uiCamera != 0)
            {
                    val_51 = null;
                val_51 = null;
                this.且丒丗丘丝且丄丙丄 = gameObject.activeSelf;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  MainMenuController.丄丞丁丈与业上丞丟.uiCamera, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            val_52 = null;
            val_52 = null;
            if(ExpView.丄丘七三上丕世丞业 != 0)
            {
                    val_53 = null;
                val_53 = null;
                if(ExpView.丄丘七三上丕世丞业.experienceCamera != 0)
            {
                    val_54 = null;
                val_54 = null;
                this.丛丁丂上上下三与丟 = gameObject.activeSelf;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.duelPanel != 0)
            {
                    this.一丐丒丕丙丙三丞丐 = gameObject.activeSelf;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.duelPanel, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.BankShopGUI != 0)
            {
                    this.丒丌东专丌丂上丅丐 = gameObject.activeSelf;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.BankShopGUI, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.BankShopGUI != 0)
            {
                    this.丒丌东专丌丂上丅丐 = gameObject.activeSelf;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.BankShopGUI, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo != 0)
            {
                    this.丘丌世下丌丕丒丂下 = gameObject.activeSelf;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    BattlePassRootUI val_34 = BattlePassRootUI.丑七不且上丗丁一世();
                if(val_34.Camera != 0)
            {
                    BattlePassRootUI val_36 = BattlePassRootUI.丑七不且上丗丁一世();
                this.万丈丟七且丈世下世 = val_36.Camera.gameObject.activeSelf;
                BattlePassRootUI val_40 = BattlePassRootUI.丑七不且上丗丁一世();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_40.Camera, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI val_43 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_43._commonUi == 0)
            {
                    return;
            }
            
            BattlePassRootUI val_45 = BattlePassRootUI.丑七不且上丗丁一世();
            this.东丙下上业丒世七丌 = val_45._commonUi.activeSelf;
            BattlePassRootUI val_48 = BattlePassRootUI.丑七不且上丗丁一世();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_48._commonUi, 丏业丟一东丂东丘丛:  false);
        }
        private void 丕上丙下丂丙丟上三()
        {
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_29 = null;
            val_29 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_30 = null;
                val_30 = null;
                if(MainMenuController.丄丞丁丈与业上丞丟.uiCamera != 0)
            {
                    val_31 = null;
                val_31 = null;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  MainMenuController.丄丞丁丈与业上丞丟.uiCamera, 丏业丟一东丂东丘丛:  (this.且丒丗丘丝且丄丙丄 == true) ? 1 : 0);
            }
            
            }
            
            val_32 = null;
            val_32 = null;
            if(ExpView.丄丘七三上丕世丞业 != 0)
            {
                    val_33 = null;
                val_33 = null;
                if(ExpView.丄丘七三上丕世丞业.experienceCamera != 0)
            {
                    val_34 = null;
                val_34 = null;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  (this.丛丁丂上上下三与丟 == true) ? 1 : 0);
            }
            
            }
            
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.duelPanel != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.duelPanel, 丏业丟一东丂东丘丛:  (this.一丐丒丕丙丙三丞丐 == true) ? 1 : 0);
            }
            
            }
            
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  (this.丘丌世下丌丕丒丂下 == true) ? 1 : 0);
            }
            
            }
            
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.shopAnchor != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.shopAnchor, 丏业丟一东丂东丘丛:  (this.丒丌东专丌丂上丅丐 == true) ? 1 : 0);
            }
            
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    BattlePassRootUI val_19 = BattlePassRootUI.丑七不且上丗丁一世();
                if(val_19.Camera != 0)
            {
                    BattlePassRootUI val_21 = BattlePassRootUI.丑七不且上丗丁一世();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21.Camera, 丏业丟一东丂东丘丛:  (this.万丈丟七且丈世下世 == true) ? 1 : 0);
            }
            
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI val_25 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_25._commonUi == 0)
            {
                    return;
            }
            
            BattlePassRootUI val_27 = BattlePassRootUI.丑七不且上丗丁一世();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_27._commonUi, 丏业丟一东丂东丘丛:  (this.东丙下上业丒世七丌 == true) ? 1 : 0);
        }
        protected GameEventOpenChestBase()
        {
        
        }
        private static GameEventOpenChestBase()
        {
            Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 = 0;
        }
    
    }

}
