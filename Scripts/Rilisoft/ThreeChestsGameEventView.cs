using UnityEngine;

namespace Rilisoft
{
    public class ThreeChestsGameEventView : AbstractGameEventView
    {
        // Fields
        internal bool 下专丞丅丟丏丐丆丙;
        private static Rilisoft.七丒丛丑丙丑丞丁丘 丝不丛丑上丏与丁丄;
        private bool 业世丟丏丂丌丒丆丏;
        private UnityEngine.Animator 万丅丟下与丛丅丄丑;
        private System.Collections.Generic.List<Rilisoft.GameEventChestOpenButtonView> _chestButtons;
        private Rilisoft.GameEventCurrencyView _superChestButton;
        private System.Collections.Generic.List<UnityEngine.GameObject> _chestHints;
        private UnityEngine.Animator _viewAnimator;
        private System.Collections.Generic.List<GEGuiObjectApplyer> chestApplyers;
        private UnityEngine.Transform chestsAnimatorsHolder;
        private System.Collections.Generic.List<UnityEngine.Animator> _commonChestsAnimatorsActual;
        private System.Collections.Generic.List<UnityEngine.GameObject> _disableIfSpinActive;
        private float _selectChestTime;
        private Rilisoft.GameEventOpenChestButtonsView _chestButtonsView;
        private Rilisoft.GameEventMultyDrop _fakeDropView;
        private UnityEngine.GameObject _prizeLogButtonObj;
        private UnityEngine.GameObject _superChestFreeSpinsObject;
        private UILabel _superChestFreeSpinsLabel;
        private float _hintsShowDelayInSeconds;
        private bool <丞丐业万丏世丙丗丁>k__BackingField;
        private bool <且专丈丏不丟丐丅丌>k__BackingField;
        private Rilisoft.上专业三丟丁丞专下 七丅专丏丅丌不七丞;
        private bool 丟丟丁丏丞专下丙专;
        private bool 丞世东丐业一丟东丄;
        
        // Properties
        private System.Collections.Generic.List<UnityEngine.Animator> _commonChestsAnimators { get; }
        private UnityEngine.Animator _goldChestAnimator { get; }
        public override bool 丝专与丄万丈丟丐丞 { get; set; }
        public override bool 三业专专丈丂丕丗与 { get; set; }
        
        // Methods
        private UnityEngine.Animator 丁丘丈业丙丑万丏丑()
        {
            var val_12;
            UnityEngine.Animator val_13;
            val_12 = this;
            if(this.万丅丟下与丛丅丄丑 != 0)
            {
                    val_13 = this.万丅丟下与丛丅丄丑;
                return (UnityEngine.Animator)val_12.Item[this.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().IndexOf(item:  this.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世())];
            }
            
            Rilisoft.上专业三丟丁丞专下 val_3 = this.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世();
            if(val_3 == null)
            {
                    return (UnityEngine.Animator)val_12.Item[this.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().IndexOf(item:  this.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世())];
            }
            
            if(val_3.丐丏下丕三丒丗丅丛() != false)
            {
                    return this.丈不丛丆丘上丛丟丐();
            }
            
            val_12 = this.丘丆且上七业三丆不();
            return (UnityEngine.Animator)val_12.Item[this.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().IndexOf(item:  this.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世())];
        }
        private string 丒东三下丐一丝丈丌(int 丏丌业丐丅上上丂丞)
        {
            var val_1;
            var val_2;
            if(丏丌业丐丅上上丂丞 == 2)
            {
                goto label_1;
            }
            
            if(丏丌业丐丅上上丂丞 == 1)
            {
                goto label_2;
            }
            
            if(丏丌业丐丅上上丂丞 != 0)
            {
                goto label_3;
            }
            
            val_1 = "First";
            return (string)val_2;
            label_1:
            val_1 = "Third";
            return (string)val_2;
            label_2:
            val_1 = "Second";
            return (string)val_2;
            label_3:
            val_2 = 0;
            return (string)val_2;
        }
        public void SelectChest(int 丏丌业丐丅上上丂丞)
        {
            var val_31;
            Rilisoft.上专业三丟丁丞专下 val_32;
            object val_33;
            var val_34;
            if(this.上丕丌丕丂丘丁丙万() == null)
            {
                goto label_1;
            }
            
            val_31 = this.上丕丌丕丂丘丁丙万();
            if(val_31.丄三丐丟丗丄丟上丞() == null)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> val_8 = this.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞();
            if(this.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().Count <= 丏丌业丐丅上上丂丞)
            {
                goto label_8;
            }
            
            val_32 = val_8.Item[丏丌业丐丅上上丂丞];
            if(val_32 == null)
            {
                goto label_9;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() != 0)
            {
                goto label_12;
            }
            
            val_33 = "cant open chest, nullable AbstractGameEventGui.Instance";
            goto label_18;
            label_1:
            val_33 = "cant open chest, nullable game event";
            goto label_18;
            label_3:
            val_33 = "cant open chest, nullable _gameEvent.Chests";
            label_18:
            label_30:
            UnityEngine.Debug.LogError(message:  val_33);
            return;
            label_8:
            val_34 = 1152921504622075904;
            string val_13 = System.String.Format(format:  "cant open chest, _gameEvent.Chests.Count <= chestIdx ({0} {1})", arg0:  val_8.Count, arg1:  丏丌业丐丅上上丂丞);
            goto label_21;
            label_9:
            label_21:
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "cant open chest, nullable chest with id \'{0}\'", arg0:  丏丌业丐丅上上丂丞));
            return;
            label_12:
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() != null)
            {
                    if(null == null)
            {
                goto label_25;
            }
            
            }
            
            string val_18 = "cant open chest, AbstractGameEventGui.Instance type is " + Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().GetType();
            goto label_30;
            label_25:
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().一丄丞丁丄丁丏丟丄(丌丄东丄丅丗丏一丘:  this.上丕丌丕丂丘丁丙万(), 丐下丝丘丑丟丟丗丌:  val_32, 丅丛下专丅丁一且东:  1, 丈丝丒丐丟丟丐东丐:  false)) != false)
            {
                    this.上丕丌丕丂丘丁丙万().不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  val_32);
                this.七丅专丏丅丌不七丞 = this.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世();
                this.业丑丈丁丙丁世丂丁(丐下丝丘丑丟丟丗丌:  this.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世());
                this.丌与丞一丂与专丁丘();
                UnityEngine.Coroutine val_28 = this.StartCoroutine(routine:  this.丘丌丟丟丌丅一下丆());
                return;
            }
            
            string val_30 = val_32.东与三丌丅三丒丏业();
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
            {
                
            }
        
        }
        internal void 丈且东丑丂且万丒丅(Rilisoft.丛且世丐丆上七业丁 丌丄东丄丅丗丏一丘, Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, UnityEngine.Animator 丅不东丒丒丅丒丄丁)
        {
            this.东丟万下不七丙且东(丙业与丙丗丝不丈东:  丌丄东丄丅丗丏一丘);
            this.万丅丟下与丛丅丄丑 = 丅不东丒丒丅丒丄丁;
            this.业丑丈丁丙丁世丂丁(丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌);
        }
        public void ShowRewardVideo()
        {
            if(Rilisoft.FreeChestController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            bool val_8 = Rilisoft.FreeChestController.丑七不且上丗丁一世().三丙丆丕丗专丐丆丗(丐东业丕丕丂丗丅丙:  this.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().Item[0].业上丙丞丐丄丆丅七());
        }
        private System.Collections.IEnumerator 丘丌丟丟丌丅一下丆()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ThreeChestsGameEventView.丅丁丙丅三丕七上一();
        }
        public void U_BackRequest()
        {
            if((this & 1) != 0)
            {
                    UnityEngine.Debug.LogError(message:  "cant back, AnyAnimationsPlaying");
            }
        
        }
        private System.Collections.IEnumerator 丆丗万丙业一三三上(int 丒丁东世世丗丅丅丄, int 丝丒丏丒万丂万万东)
        {
            ThreeChestsGameEventView.不丐丘丕且七丙不丏 val_1 = new ThreeChestsGameEventView.不丐丘丕且七丙不丏();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丒丁东世世丗丅丅丄 = 丒丁东世世丗丅丅丄;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 丒丁东世世丗丅丅丄;
            }
            
            .丝丒丏丒万丂万万东 = 丝丒丏丒万丂万万东;
            return (System.Collections.IEnumerator)val_1;
        }
        public void UpdateSpinButtonsAndChests()
        {
            UnityEngine.Object val_3;
            if((this & 1) != 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this._disableIfSpinActive.GetEnumerator();
            label_9:
            if(((-399812688) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4 == 0)
            {
                goto label_9;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
            goto label_9;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_3 != 0)
            {
                    UnityEngine.GameObject val_7 = val_3.gameObject;
                val_7.SetActive(value:  true);
            }
            
            if(val_7 != 0)
            {
                    val_7.SetActive(value:  true);
            }
            
            this.丝万且丁丑丁丞下丕();
        }
        private System.Collections.Generic.List<UnityEngine.Animator> 丘丆且上七业三丆不()
        {
            var val_2;
            var val_3;
            var val_12;
            System.Collections.Generic.List<UnityEngine.Animator> val_13;
            List.Enumerator<T> val_1 = this.chestApplyers.GetEnumerator();
            label_5:
            if(((-399607504) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_2 != 0)
            {
                goto label_5;
            }
            
            goto label_5;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_7 = this._commonChestsAnimatorsActual.GetEnumerator();
            goto label_13;
            label_16:
            val_12 = ((this._commonChestsAnimatorsActual.Count == 0) ? 1 : 0) | (UnityEngine.Object.op_Equality(x:  0.丐丏七丌丕丗业且上(), y:  0));
            label_13:
            if(((-399607528) & 1) != 0)
            {
                goto label_16;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_12 != true)
            {
                
            }
            else
            {
                    this._commonChestsAnimatorsActual = System.Linq.Enumerable.ToList<UnityEngine.Animator>(source:  this.chestsAnimatorsHolder.GetComponentsInChildren<UnityEngine.Animator>(includeInactive:  true));
                return val_13;
            }
            
            val_13 = this._commonChestsAnimatorsActual;
            return val_13;
        }
        private UnityEngine.Animator 丈不丛丆丘上丛丟丐()
        {
            System.Collections.Generic.List<UnityEngine.Animator> val_1 = this.丘丆且上七业三丆不();
            if(val_1 != null)
            {
                    return val_1.Item[3];
            }
            
            return val_1.Item[3];
        }
        public override bool get_AnyAnimationsPlaying()
        {
            return (bool)this.<丞丐业万丏世丙丗丁>k__BackingField;
        }
        protected override void 业东且丞丁丌业丂丈(bool 丙业与丙丗丝不丈东)
        {
            this.<丞丐业万丏世丙丗丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override bool get_SpinActive()
        {
            return (bool)this.<且专丈丏不丟丐丅丌>k__BackingField;
        }
        protected override void 丕丏一三丒丐世与丟(bool 丙业与丙丗丝不丈东)
        {
            this.<且专丈丏不丟丐丅丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override void Show(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, bool 东丆丛东七七丘丐丘 = False)
        {
            var val_24;
            UnityEngine.GameObject val_25;
            this.丞世东丐业一丟东丄 = true;
            this.东丟万下不七丙且东(丙业与丙丗丝不丈东:  丅东专与不三丂丁丝);
            this.丟丟丁丏丞专下丙专 = 东丆丛东七七丘丐丘;
            this._chestButtonsView.Setup(丅东专与不三丂丁丝:  this.上丕丌丕丂丘丁丙万());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            System.Collections.Generic.List<Rilisoft.GameEventItemData> val_6 = this.上丕丌丕丂丘丁丙万().丝丁丅丆丌丗丌丛丌().丒丄下丏专且丙丄丒();
            if(val_6 != null)
            {
                    var val_8 = (val_6.Count > 0) ? 1 : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            val_25 = this._prizeLogButtonObj;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  false);
            if(this.上丕丌丕丂丘丁丙万() != null)
            {
                    Rilisoft.GameEventData val_11 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                if(val_11.StartCurrency >= 1)
            {
                    Rilisoft.GameEventData val_13 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                if((Rilisoft.三一丈七且丄与丝东.丁上丁上丞业世一丁(丟丟丄专上丟丁丐丝:  val_13.EventId)) != true)
            {
                    Rilisoft.GameEventData val_16 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                Rilisoft.GameEventData val_18 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                val_25 = val_18.EventId;
                bool val_19 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  val_16.StartCurrency, 丛丞万三下丘七丌丅:  false, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  val_25);
                Rilisoft.GameEventData val_21 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                Rilisoft.三一丈七且丄与丝东.七与丝丛丄丛专丐三(丟丟丄专上丟丁丐丝:  val_21.EventId, 不丂丙丛丈不上七且:  true);
            }
            
            }
            
            }
            
            this.丝万且丁丑丁丞下丕();
            UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.丄与丞丈丁东丂下专());
        }
        public override void ShowChest(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
            if(丐下丝丘丑丟丟丗丌 == null)
            {
                    return;
            }
            
            if(丐下丝丘丑丟丟丗丌.丐丏下丕三丒丗丅丛() == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丕丙丆丏上丌丙丏丕(丐下丝丘丑丟丟丗丌:  0));
        }
        private void 丝万且丁丑丁丞下丕()
        {
            if(this._superChestFreeSpinsObject != 0)
            {
                    if(this._superChestFreeSpinsLabel != 0)
            {
                goto label_6;
            }
            
            }
            
            label_19:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  true);
            return;
            label_6:
            if(this.上丕丌丕丂丘丁丙万().下一三万丝丟丐丒丆() == false)
            {
                    return;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_6 = this.上丕丌丕丂丘丁丙万().不七丘丙不三丗业上();
            if((val_6.丞上丌丌丕丘专丒丕(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) < 1)
            {
                goto label_13;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
            goto label_19;
            label_13:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
            goto label_19;
        }
        private void Update()
        {
        
        }
        private System.Collections.IEnumerator 丕丙丆丏上丌丙丏丕(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ThreeChestsGameEventView.万一不丛丂不丈业丏();
        }
        private System.Collections.IEnumerator 丄与丞丈丁东丂下专()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ThreeChestsGameEventView.一下丝丌一丕丁丟丕();
        }
        private void 丐上丛丞丑且丅世丄()
        {
            Rilisoft.GameEventCurrencyView val_11;
            var val_12;
            var val_13;
            val_11 = this._superChestButton;
            if(val_11 == 0)
            {
                    return;
            }
            
            val_11 = this.上丕丌丕丂丘丁丙万();
            if(val_11.下一三万丝丟丐丒丆() == false)
            {
                    return;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_5 = this.上丕丌丕丂丘丁丙万().不七丘丙不三丗业上();
            val_12 = 0;
            if((val_5.丞上丌丌丕丘专丒丕(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) < 1)
            {
                goto label_8;
            }
            
            val_12 = 0;
            if(this.上丕丌丕丂丘丁丙万().丕丒丙七丘丈丙且丂() == false)
            {
                goto label_10;
            }
            
            label_8:
            val_13 = null;
            val_13 = null;
            this._superChestButton.Set(一下世丆丙万丞东丆:  new Rilisoft.GameCurrencyData(丑丏万丈丟丝丝丌丗:  val_5.丟丂丞不专丆万丒世(), 丏丂不专上丘丂不丅:  "EventCurrency", 丒世丘丘上丆丝东丞:  0, 丕丐丗世丌三上丌世:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄));
            return;
            label_10:
            this._superChestButton.SetAsFreeNoCount();
        }
        private void 丕丂丐丑丄丁上丈丞()
        {
            goto label_1;
            label_8:
            this._chestButtons.Item[0].Setup(与且专丈不万东一万:  this.上丕丌丕丂丘丁丙万().丄与丟丅丐不丂专业().Item[0]);
            0 = 1;
            label_1:
            if(0 < this.上丕丌丕丂丘丁丙万().丄与丟丅丐不丂专业().Count)
            {
                goto label_8;
            }
            
            this.丌与丞一丂与专丁丘();
        }
        private void 丌与丞一丂与专丁丘()
        {
            var val_22;
            var val_23;
            bool val_24;
            var val_25;
            UnityEngine.GameObject val_26;
            var val_27;
            var val_28;
            val_22 = null;
            val_22 = null;
            if(Rilisoft.ThreeChestsGameEventView.丝不丛丑上丏与丁丄.世三丞丅丑丌丈丈一() >= 1)
            {
                    val_23 = null;
                val_23 = null;
                float val_22 = this._hintsShowDelayInSeconds;
                val_22 = val_22 + (float)Rilisoft.ThreeChestsGameEventView.丝不丛丑上丏与丁丄.世三丞丅丑丌丈丈一();
                var val_4 = (val_22 <= (float)专七专下且专三一且.上且一丈丐三丄一丆()) ? 1 : 0;
            }
            else
            {
                    val_24 = true;
            }
            
            this.业世丟丏丂丌丒丆丏 = val_24;
            val_25 = 0;
            goto label_14;
            label_34:
            var val_14 = (this.业世丟丏丂丌丒丆丏 == false) ? 1 : 0;
            val_14 = 0 | val_14;
            if((val_14 & 1) == 0)
            {
                    if(this.上丕丌丕丂丘丁丙万().丄与丟丅丐不丂专业().Item[0].丁丒丝世下丟丑七丐() >= (this.上丕丌丕丂丘丁丙万().不七丘丙不三丗业上().丂丙丐丆丝上万业世() - this.上丕丌丕丂丘丁丙万().丂世上东丞且丏丝丗()))
            {
                goto label_19;
            }
            
            }
            
            val_26 = this._chestHints.Item[0];
            val_27 = 0;
            goto label_23;
            label_19:
            val_28 = null;
            val_28 = null;
            Rilisoft.ThreeChestsGameEventView.丝不丛丑上丏与丁丄.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  专七专下且专三一且.上且一丈丐三丄一丆());
            val_27 = 1;
            val_26 = this._chestHints.Item[0];
            label_23:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_26, 丏业丟一东丂东丘丛:  true);
            val_25 = 1;
            label_14:
            if(val_25 < this.上丕丌丕丂丘丁丙万().丄与丟丅丐不丂专业().Count)
            {
                goto label_34;
            }
        
        }
        public override void SpinTo(int 丒丁东世世丗丅丅丄, System.Collections.Generic.List<Rilisoft.GameEventItemData> 丈万丏丌丘丂丄不丏)
        {
            var val_3;
            UnityEngine.Object val_22;
            UnityEngine.Object val_23;
            var val_24;
            if((this & 1) != 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this._disableIfSpinActive.GetEnumerator();
            label_9:
            if(((-397283424) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4 == 0)
            {
                goto label_9;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
            goto label_9;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_3 != 0)
            {
                    val_22 = val_3.gameObject;
            }
            else
            {
                    val_22 = 0;
            }
            
            if(val_22 != 0)
            {
                    UnityEngine.GameObject val_8 = val_22.gameObject;
                val_8.SetActive(value:  false);
            }
            
            if(val_8 != null)
            {
                    val_23 = val_8.gameObject;
            }
            else
            {
                    val_23 = 0;
            }
            
            if(val_23 != 0)
            {
                    val_23.gameObject.SetActive(value:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._superChestFreeSpinsObject, 丏业丟一东丂东丘丛:  false);
            if(this._superChestFreeSpinsObject != 0)
            {
                    this._superChestFreeSpinsObject.SetActive(value:  false);
            }
            
            if((丈万丏丌丘丂丄不丏 != null) && (丈万丏丌丘丂丄不丏.Count >= 1))
            {
                    val_24 = 丈万丏丌丘丂丄不丏.Count + 1;
            }
            else
            {
                    val_24 = 1;
            }
            
            UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.丆丗万丙业一三三上(丒丁东世世丗丅丅丄:  丒丁东世世丗丅丅丄, 丝丒丏丒万丂万万东:  1));
            if(丈万丏丌丘丂丄不丏 == null)
            {
                    return;
            }
            
            if(丈万丏丌丘丂丄不丏.Count < 1)
            {
                    return;
            }
            
            this.丞世东丐业一丟东丄 = false;
            UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  this.丙丕丏丟丒与丆丂七(丈万丏丌丘丂丄不丏:  丈万丏丌丘丂丄不丏));
        }
        private System.Collections.IEnumerator 丙丕丏丟丒与丆丂七(System.Collections.Generic.List<Rilisoft.GameEventItemData> 丈万丏丌丘丂丄不丏)
        {
            ThreeChestsGameEventView.丄上丏丞丄丑一七丝 val_1 = new ThreeChestsGameEventView.丄上丏丞丄丑一七丝();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丈万丏丌丘丂丄不丏 = 丈万丏丌丘丂丄不丏;
            return (System.Collections.IEnumerator)val_1;
        }
        public override void CloseChests(System.Action 丗丌世七丅专丝七与, bool 丁下丛丗三丙丙丄下 = False)
        {
            bool val_10 = 丁下丛丗三丙丙丄下;
            if(137138176 != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  137138176);
            }
            
            }
            
            UnityEngine.Animator val_4 = this.丁丘丈业丙丑万丏丑();
            val_4.SetTrigger(name:  "OnRewardShown");
            if(val_4 != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_7 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_4);
            }
            
            }
            
            if(val_10 == false)
            {
                goto label_18;
            }
            
            System.Action val_8 = null;
            val_10 = val_8;
            val_8 = new System.Action(object:  this, method:  System.Void Rilisoft.ThreeChestsGameEventView::丐丅丁丗三七丟不丈());
            UnityEngine.Coroutine val_9 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  1.5f, 丌专业且丛丏丞丝且:  val_8);
            if(丗丌世七丅专丝七与 == null)
            {
                    return;
            }
            
            label_22:
            丗丌世七丅专丝七与.Invoke();
            return;
            label_18:
            this.UpdateSpinButtonsAndChests();
            if(丗丌世七丅专丝七与 != null)
            {
                goto label_22;
            }
        
        }
        public override void Shutdown()
        {
            this.StopAllCoroutines();
            X20.StopAllCoroutines();
            this.gameObject.SetActive(value:  false);
        }
        protected override void 七丕东丘丑丞三丏丑()
        {
            object val_6;
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() != 0)
            {
                goto label_3;
            }
            
            label_18:
            val_6 = "cant back, AnyAnimationsPlaying";
            goto label_17;
            label_3:
            Rilisoft.AbstractGameEventGui val_3 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if((val_3 != null) && (null == null))
            {
                    if(val_3 != 0)
            {
                goto label_11;
            }
            
            }
            
            val_6 = "cant back, geg == null";
            label_17:
            UnityEngine.Debug.LogError(message:  val_6);
            return;
            label_11:
            if(val_3.与丅七丏万丈丝丞丅() == false)
            {
                goto label_14;
            }
            
            goto label_17;
            label_14:
            if((this & 1) != 0)
            {
                goto label_18;
            }
            
            this.丏丞三丏与丂丟且丁();
        }
        private void 丏丞三丏与丂丟且丁()
        {
            var val_22;
            var val_23;
            var val_24;
            val_22 = this;
            if(this.上丕丌丕丂丘丁丙万() == null)
            {
                goto label_11;
            }
            
            if(this.上丕丌丕丂丘丁丙万().丕丒丙七丘丈丙且丂() == false)
            {
                goto label_3;
            }
            
            label_9:
            label_11:
            Rilisoft.AbstractGameEventGui val_4 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            val_22 = ???;
            goto typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_288;
            label_3:
            if(val_22.上丕丌丕丂丘丁丙万().下一三万丝丟丐丒丆() != false)
            {
                    if((val_22.上丕丌丕丂丘丁丙万().不七丘丙不三丗业上().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == true)
            {
                goto label_9;
            }
            
            }
            
            if(val_22.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世() == null)
            {
                goto label_11;
            }
            
            val_22.上丕丌丕丂丘丁丙万().不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  0);
            mem2[0] = 0;
            if((Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null) || (null != null))
            {
                goto label_14;
            }
            
            val_23 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_23 == null)
            {
                goto label_15;
            }
            
            if(null == null)
            {
                goto label_18;
            }
            
            val_23 = 0;
            goto label_18;
            label_15:
            label_18:
            val_23.一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  true);
            val_24 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_24 == null)
            {
                goto label_19;
            }
            
            if(null == null)
            {
                goto label_22;
            }
            
            val_24 = 0;
            goto label_22;
            label_19:
            label_22:
            val_24.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  true);
            label_14:
            val_22 + 248.SetTrigger(name:  "Back");
            val_22.丕丂丐丑丄丁上丈丞();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this._fakeDropView == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._fakeDropView.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.上丕丌丕丂丘丁丙万() == null)
            {
                    return;
            }
            
            this.上丕丌丕丂丘丁丙万().不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  0);
        }
        public ThreeChestsGameEventView()
        {
            this.业世丟丏丂丌丒丆丏 = true;
            this._commonChestsAnimatorsActual = new System.Collections.Generic.List<UnityEngine.Animator>();
            this._selectChestTime = 1f;
            this._hintsShowDelayInSeconds = 300f;
        }
        private static ThreeChestsGameEventView()
        {
            Rilisoft.ThreeChestsGameEventView.丝不丛丑上丏与丁丄 = new Rilisoft.七丒丛丑丙丑丞丁丘(丟东丟丑丕丄丂丟丙:  "game-event-three-chest-hint-last-show-time");
        }
        private void 丐丅丁丗三七丟不丈()
        {
            this.UpdateSpinButtonsAndChests();
        }
    
    }

}
