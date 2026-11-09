using UnityEngine;

namespace Rilisoft
{
    public class OneChestGameEventView : AbstractGameEventView
    {
        // Fields
        private const string 不丏丅丙丅丌丘丛丌 = "HandleOpen";
        private const string 上万丝丄上丑丆丗丕 = "OnRewardShown";
        private const string 丝丙丝丞业丛丁业丏 = "NewChest";
        private const string 一丂丅丏丂与丝丛丄 = "NewChestShown";
        private const string 丆不与下业万七下世 = "FillProgress";
        private Rilisoft.丛且世丐丆上七业丁 丝业世丈世不丈丈丞;
        private UILabel _spinPriceLabel;
        private UnityEngine.GameObject _parentEventSpinButton;
        private UnityEngine.GameObject _childEventSpinButton;
        private UnityEngine.Animator _animator;
        private UnityEngine.Animator _baseChestAnimator;
        private UnityEngine.Animator _superChestAnimator;
        private float _animationNewChestTime;
        private float _animationHideChestTime;
        private float _animationShowChestTime;
        private bool <丞丐业万丏世丙丗丁>k__BackingField;
        private bool <且专丈丏不丟丐丅丌>k__BackingField;
        
        // Properties
        public override bool 丝专与丄万丈丟丐丞 { get; set; }
        public override bool 三业专专丈丂丕丗与 { get; set; }
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            UIPanel val_1 = GetComponent<UIPanel>();
            if(this.上丕丌丕丂丘丁丙万() == null)
            {
                    return;
            }
            
            this.UpdateSpinButtonsAndChests();
        }
        private System.Collections.IEnumerator 丄与丞丈丁东丂下专(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, bool 东丆丛东七七丘丐丘 = False)
        {
            OneChestGameEventView.丟丄三丐丝且丁丄上 val_1 = new OneChestGameEventView.丟丄三丐丝且丁丄上();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丅东专与不三丂丁丝 = 丅东专与不三丂丁丝;
                .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
                mem[32] = 丅东专与不三丂丁丝;
            }
            
            .东丆丛东七七丘丐丘 = 东丆丛东七七丘丐丘;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丞三丝丒丂专不丁专(bool 丈丄丂丈丆丑丞专丌)
        {
            OneChestGameEventView.丙丏东丈与一丐丙万 val_1 = new OneChestGameEventView.丙丏东丈与一丐丙万();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丈丄丂丈丆丑丞专丌 = 丈丄丂丈丆丑丞专丌;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 下与丞三丅丛丄七丕()
        {
            this.gameObject.SetActive(value:  true);
            Rilisoft.丛且世丐丆上七业丁 val_2 = this.上丕丌丕丂丘丁丙万();
            this.业丑丈丁丙丁世丂丁(丐下丝丘丑丟丟丗丌:  val_2.且丌三丙丙与与丝世());
            val_2.UpdateView(丅东专与不三丂丁丝:  this.上丕丌丕丂丘丁丙万(), 七丆丟丗世丟且丒丆:  false);
        }
        public void UpdateSpinButtonsAndChests()
        {
            if((this & 1) != 0)
            {
                    return;
            }
            
            if((this._parentEventSpinButton == 0) || (this._childEventSpinButton == 0))
            {
                goto label_23;
            }
            
            Rilisoft.GameEventChestData val_5 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆().FirstChest;
            if(val_5.OpenPrice == null)
            {
                goto label_16;
            }
            
            Rilisoft.GameEventChestData val_8 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆().FirstChest;
            if(val_8.OpenPrice.丟丂丞不专丆万丒世() < 1)
            {
                goto label_16;
            }
            
            this._parentEventSpinButton.SetActive(value:  true);
            this._childEventSpinButton.SetActive(value:  false);
            this._spinPriceLabel.text = this.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().ToString();
            goto label_23;
            label_16:
            this._parentEventSpinButton.SetActive(value:  false);
            this._childEventSpinButton.SetActive(value:  true);
            label_23:
            this._baseChestAnimator.gameObject.SetActive(value:  this.上丕丌丕丂丘丁丙万().下一三万丝丟丐丒丆());
            UnityEngine.GameObject val_17 = this._superChestAnimator.gameObject;
            val_17.SetActive(value:  (~this.上丕丌丕丂丘丁丙万().下一三万丝丟丐丒丆()) & 1);
            if(val_17 != 0)
            {
                    UnityEngine.GameObject val_22 = val_17.gameObject;
                val_22.SetActive(value:  true);
            }
            
            val_22.gameObject.SetActive(value:  true);
            this.SetActive(value:  true);
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        private System.Collections.IEnumerator 丆丗万丙业一三三上(int 丒丁东世世丗丅丅丄)
        {
            OneChestGameEventView.万世丕丑与七丗下丄 val_1 = new OneChestGameEventView.万世丕丑与七丗下丄();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丒丁东世世丗丅丅丄 = 丒丁东世世丗丅丅丄;
            return (System.Collections.IEnumerator)val_1;
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
        public override void CloseChests(System.Action 丗丌世七丅专丝七与, bool 丁下丛丗三丙丙丄下 = False)
        {
            OneChestGameEventView.三丕业丁丗东丂七丝 val_1 = new OneChestGameEventView.三丕业丁丗东丂七丝();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丁下丛丗三丙丙丄下 = 丁下丛丗三丙丙丄下;
            }
            else
            {
                    mem[16] = this;
                mem[24] = 丁下丛丗三丙丙丄下;
            }
            
            .丗丌世七丅专丝七与 = 丗丌世七丅专丝七与;
            if(丗丌世七丅专丝七与 != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  丗丌世七丅专丝七与);
            }
            
            }
            
            .一下业万丏且七三上 = new System.Action(object:  val_1, method:  System.Void OneChestGameEventView.三丕业丁丗东丂七丝::丂且不丕丁丏丒且世());
            bool val_9 = this.上丕丌丕丂丘丁丙万().下一三万丝丟丐丒丆();
            if(this._animator == null)
            {
                goto label_12;
            }
            
            if(val_9 == false)
            {
                goto label_13;
            }
            
            label_15:
            this._animator.SetTrigger(name:  "FillProgress");
            this.UpdateFill(丞与与丝不业丐一丆:  new System.Action(object:  val_1, method:  System.Void OneChestGameEventView.三丕业丁丗东丂七丝::丆丅下丑丂丕丐丙丈()));
            return;
            label_12:
            if(val_9 == true)
            {
                goto label_15;
            }
            
            label_13:
            this._animator.SetTrigger(name:  "OnRewardShown");
            (OneChestGameEventView.三丕业丁丗东丂七丝)[1152921542855954384].一下业万丏且七三上.Invoke();
        }
        public override void Show(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, bool 东丆丛东七七丘丐丘 = False)
        {
            if(this.上丕丌丕丂丘丁丙万() != null)
            {
                    Rilisoft.GameEventData val_3 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                if(val_3.StartCurrency >= 1)
            {
                    Rilisoft.GameEventData val_5 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                if((Rilisoft.三一丈七且丄与丝东.丁上丁上丞业世一丁(丟丟丄专上丟丁丐丝:  val_5.EventId)) != true)
            {
                    Rilisoft.GameEventData val_8 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                Rilisoft.GameEventData val_10 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                bool val_11 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  val_8.StartCurrency, 丛丞万三下丘七丌丅:  false, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  val_10.EventId);
                Rilisoft.GameEventData val_13 = this.上丕丌丕丂丘丁丙万().丁专丗万三上丟三丆();
                Rilisoft.三一丈七且丄与丝东.七与丝丛丄丛专丐三(丟丟丄专上丟丁丐丝:  val_13.EventId, 不丂丙丛丈不上七且:  true);
            }
            
            }
            
            }
            
            UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.丄与丞丈丁东丂下专(丅东专与不三丂丁丝:  丅东专与不三丂丁丝, 东丆丛东七七丘丐丘:  东丆丛东七七丘丐丘));
        }
        public override void Shutdown()
        {
            this.StopAllCoroutines();
            mem[1152921542856318464] = 0;
            X20.StopAllCoroutines();
            this.gameObject.SetActive(value:  false);
        }
        public override void SpinTo(int 丒丁东世世丗丅丅丄, System.Collections.Generic.List<Rilisoft.GameEventItemData> 丈万丏丌丘丂丄不丏)
        {
            if((this & 1) != 0)
            {
                    return;
            }
            
            if(this._parentEventSpinButton != 0)
            {
                    this._parentEventSpinButton.gameObject.SetActive(value:  false);
            }
            
            if(this._childEventSpinButton != 0)
            {
                    UnityEngine.GameObject val_4 = this._childEventSpinButton.gameObject;
                val_4.SetActive(value:  false);
            }
            
            if(val_4 != 0)
            {
                    UnityEngine.GameObject val_6 = val_4.gameObject;
                val_6.SetActive(value:  false);
            }
            
            UnityEngine.GameObject val_7 = val_6.gameObject;
            val_7.SetActive(value:  false);
            val_7.SetActive(value:  false);
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丆丗万丙业一三三上(丒丁东世世丗丅丅丄:  丒丁东世世丗丅丅丄));
        }
        public OneChestGameEventView()
        {
            this._animationNewChestTime = 1f;
            this._animationHideChestTime = 1f;
            this._animationShowChestTime = 1f;
        }
        private void 世专不专丘丁丙丁丆()
        {
            this.东丟万下不七丙且东(丙业与丙丗丝不丈东:  this.丝业世丈世不丈丈丞);
            this.丝业世丈世不丈丈丞 = 0;
            Rilisoft.丛且世丐丆上七业丁 val_1 = this.上丕丌丕丂丘丁丙万();
            this.业丑丈丁丙丁世丂丁(丐下丝丘丑丟丟丗丌:  val_1.且丌三丙丙与与丝世());
            val_1.UpdateView(丅东专与不三丂丁丝:  this.上丕丌丕丂丘丁丙万(), 七丆丟丗世丟且丒丆:  false);
        }
    
    }

}
