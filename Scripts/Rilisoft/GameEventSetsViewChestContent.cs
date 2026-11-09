using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventSetsViewChestContent : GameEventSetsViewBase, 丏丗丞丙不丝三丕丟
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _chestNameLabels;
        private UILabel _detailsCountLabel;
        private UnityEngine.Transform _rollViewsContainer;
        private Rilisoft.PriceView _spinButtonView;
        private Rilisoft.PriceView _resetButtonView;
        private UnityEngine.GameObject _touchBlocker;
        private Rilisoft.GameEventExcludeChestsView _excludeChestsView;
        private UnityEngine.GameObject _resetExcludesGameObject;
        private UnityEngine.GameObject _resetChestGameObject;
        private UnityEngine.GameObject _playerGotNotif;
        private Rilisoft.GameEventSetsChestCompleteView _chestCompleteView;
        private UnityEngine.AudioClip _spinClip;
        private UnityEngine.GameObject _spinButtonNotif;
        private Rilisoft.GameEventSetsViewChestContent.且世丈业丘丆不上丄 丗下丘世三七一专丕;
        private System.Collections.Generic.List<Rilisoft.GameEventSetItemView> 且下万丐丞东丈万丈;
        private System.Collections.Generic.List<int> 专丟丄丟东一丆上且;
        private UnityEngine.Coroutine 且丛丐与丞上丌不丒;
        
        // Properties
        private System.Collections.Generic.List<Rilisoft.GameEventSetItemView> 业丏丈丛丄不丘丛万 { get; }
        internal override string 丄丂丏世丛丏万三丆 { get; }
        private Rilisoft.GameEventSetsViewChestContent.且世丈业丘丆不上丄 上丅丑丌丑丏丏丙东 { get; set; }
        
        // Methods
        private System.Collections.Generic.List<Rilisoft.GameEventSetItemView> 丂丄丘专丈业三且丛()
        {
            var val_8;
            if(this.且下万丐丞东丈万丈 != null)
            {
                    return (System.Collections.Generic.List<Rilisoft.GameEventSetItemView>)this.且下万丐丞东丈万丈;
            }
            
            if(this._rollViewsContainer == 0)
            {
                    return (System.Collections.Generic.List<Rilisoft.GameEventSetItemView>)this.且下万丐丞东丈万丈;
            }
            
            this.且下万丐丞东丈万丈 = new System.Collections.Generic.List<Rilisoft.GameEventSetItemView>();
            val_8 = 0;
            goto label_5;
            label_16:
            UnityEngine.Transform val_3 = this._rollViewsContainer.GetChild(index:  0);
            if(val_3 != 0)
            {
                    Rilisoft.GameEventSetItemView val_5 = val_3.GetComponent<Rilisoft.GameEventSetItemView>();
                if(val_5 != 0)
            {
                    this.且下万丐丞东丈万丈.Add(item:  val_5);
            }
            
            }
            
            val_8 = 1;
            label_5:
            if(val_8 < this._rollViewsContainer.childCount)
            {
                goto label_16;
            }
            
            return (System.Collections.Generic.List<Rilisoft.GameEventSetItemView>)this.且下万丐丞东丈万丈;
        }
        internal override string 丌三不七丌丗丞丌专()
        {
            return "spin";
        }
        private Rilisoft.GameEventSetsViewChestContent.且世丈业丘丆不上丄 万丘三丘下与与且业()
        {
            return (且世丈业丘丆不上丄)this.丗下丘世三七一专丕;
        }
        private void 丒丟丛丂丆三三丙丑(Rilisoft.GameEventSetsViewChestContent.且世丈业丘丆不上丄 丙业与丙丗丝不丈东)
        {
            if(this.丗下丘世三七一专丕 != 0)
            {
                    if(this.丗下丘世三七一专丕 == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            }
            
            this.丗下丘世三七一专丕 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == 0)
            {
                    return;
            }
            
            this.丕丕业七丙七丅丈丄();
        }
        public void Spin(int 不丐丐东东丁与且下, System.Action 丛丙丅下世三与丟丟, System.Action 丟丘丙丄丅万丏与丗)
        {
            int val_17;
            Rilisoft.GameEventSetsViewChestContent val_18;
            int val_19;
            Rilisoft.GameEventSetItemView val_20;
            int val_21;
            val_17 = 不丐丐东东丁与且下;
            val_18 = this;
            GameEventSetsViewChestContent.丛东丟丅丙丗世丗不 val_1 = new GameEventSetsViewChestContent.丛东丟丅丙丗世丗不();
            if(val_1 != null)
            {
                    val_19 = val_1;
                .不丐丐东东丁与且下 = val_17;
                mem[1152921542786592312] = 丛丙丅下世三与丟丟;
                mem[1152921542786592320] = val_18;
            }
            else
            {
                    val_19 = 16;
                mem[16] = val_17;
                mem[24] = 丛丙丅下世三与丟丟;
                mem[32] = val_18;
            }
            
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
            if(this.且丛丐与丞上丌不丒 != null)
            {
                    this.StopCoroutine(routine:  this.且丛丐与丞上丌不丒);
            }
            
            val_20 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventSetItemView>(source:  this.丂丄丘专丈业三且丛(), predicate:  new System.Func<Rilisoft.GameEventSetItemView, System.Boolean>(object:  val_1, method:  System.Boolean GameEventSetsViewChestContent.丛东丟丅丙丗世丗不::丝丗丛丟三丛丏丟丄(Rilisoft.GameEventSetItemView 业下丌下三丕丙丌下)));
            .下丏丒丟丙且东丏丌 = val_20;
            if(val_20 == 0)
            {
                    object[] val_6 = new object[1];
                val_18 = val_6;
                val_18[0] = val_19;
                UnityEngine.Debug.LogErrorFormat(format:  "spin fail, view for container \'{0}\' not found", args:  val_6);
                return;
            }
            
            System.Action val_7 = null;
            val_20 = val_7;
            val_7 = new System.Action(object:  val_1, method:  System.Void GameEventSetsViewChestContent.丛东丟丅丙丗世丗不::丟丙丑丄不丑三专且());
            int val_9 = this.Parameter.Count;
            if(val_9 < 2)
            {
                    val_21 = 1;
            }
            else
            {
                    val_17 = this.Parameter.Count;
                val_21 = UnityEngine.Mathf.Max(a:  1, b:  UnityEngine.Mathf.RoundToInt(f:  (float)val_17 / val_9));
            }
            
            this.且丛丐与丞上丌不丒 = this.StartCoroutine(routine:  this.丌丁丘丕专丞上丅且(丑丒丞丑丝丒丂丏丛:  (GameEventSetsViewChestContent.丛东丟丅丙丗世丗不)[1152921542786592288].下丏丒丟丙且东丏丌, 丅专丑丄不东丈七丂:  val_21, 丟丘丙丄丅万丏与丗:  val_7));
        }
        public override void Setup(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            Rilisoft.丛且世丐丆上七业丁 val_23;
            且世丈业丘丆不上丄 val_24;
            val_23 = 丅东专与不三丂丁丝;
            this.Setup(丅东专与不三丂丁丝:  val_23, 丆且丁丒丒丆丁三丆:  丆且丁丒丒丆丁三丆);
            丆且丁丒丒丆丁三丆.Hide();
            this.专丟丄丟东一丆上且.Clear();
            if(this.Parameter == null)
            {
                    return;
            }
            
            if(this._chestNameLabels != null)
            {
                    .丕不丝丙三丕丗丅丌 = this.Parameter;
                val_23 = this._chestNameLabels;
                val_23.ForEach(action:  new System.Action<UILabel>(object:  new GameEventSetsViewChestContent.丄丆丌丌丕丈丆丆业(), method:  System.Void GameEventSetsViewChestContent.丄丆丌丌丕丈丆丆业::丆一且世上丗上一丗(UILabel 丐三丞七丝丅不万丛)));
            }
            
            this.丗下丘世三七一专丕 = 0;
            if(this.Parameter.万丐丘丟丂丛丂丈万() == null)
            {
                goto label_9;
            }
            
            val_23 = this.Parameter;
            Rilisoft.丝丑丂丛万丐丈丘且 val_11 = val_23.万丝世丘丞东万丟万();
            if(this.Parameter.万丐丘丟丂丛丂丈万().Count >= )
            {
                goto label_13;
            }
            
            label_9:
            if(this.丗下丘世三七一专丕 == 1)
            {
                    return;
            }
            
            val_24 = 1;
            goto label_26;
            label_13:
            if(this.Parameter.丒世业三丘丝不下丕() == true)
            {
                goto label_24;
            }
            
            val_23 = this.Parameter.丁且且丐不丝丐下丘().Count;
            if((val_23 + this.Parameter.万丐丘丟丂丛丂丈万().Count) >= this.Parameter.Count)
            {
                goto label_24;
            }
            
            if(this.丗下丘世三七一专丕 == 2)
            {
                    return;
            }
            
            val_24 = 2;
            goto label_26;
            label_24:
            if(this.丗下丘世三七一专丕 == 4)
            {
                    return;
            }
            
            val_24 = 4;
            label_26:
            this.丗下丘世三七一专丕 = val_24;
            this.丕丕业七丙七丅丈丄();
        }
        public override void ShowWindow()
        {
            this.ShowWindow();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._touchBlocker, 丏业丟一东丂东丘丛:  false);
            this._chestCompleteView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContent::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
            this._chestCompleteView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContent::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
        }
        public override void HideWindow()
        {
            this.丗下丘世三七一专丕 = 0;
            this.HideWindow();
            this._chestCompleteView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContent::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
        }
        private void 七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)
        {
            UnityEngine.Object val_8;
            this.丄丄三三万丗丂丁下(丑丆丕七丂不丙丞丂:  true);
            val_8 = this.Parameter;
            if(val_8.丒世业三丘丝不下丕() == false)
            {
                    return;
            }
            
            val_8 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_8 == 0)
            {
                    return;
            }
            
            Rilisoft.AbstractGameEventGui val_5 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_5 != null)
            {
                    var val_6 = (null == null) ? (val_5) : 0;
            }
            else
            {
                    val_8 = 0;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8.ShowSelectedChestBindedItemInShop(三下丞一业丄世不上:  true);
        }
        protected override void 丗丌丂丙丈丆不丂七()
        {
            this.丗丌丂丙丈丆不丂七();
            if(this.Parameter == null)
            {
                    return;
            }
            
            System.TimeSpan val_3 = this.Parameter.世丙不业丛丂东万丈();
            if(val_3._ticks.TotalSeconds <= 0f)
            {
                    return;
            }
            
            System.Nullable<System.TimeSpan> val_6 = this.Parameter.七丆丄丟丟丕三上上();
            if(((-474080872) & 1) == 0)
            {
                    return;
            }
            
            System.Nullable<System.TimeSpan> val_8 = this.Parameter.七丆丄丟丟丕三上上();
            if(val_8.HasValue.TotalSeconds >= 0)
            {
                    return;
            }
            
            if(this.且丛丐与丞上丌不丒 != null)
            {
                    return;
            }
            
            if(Rilisoft.GameEventGuiSets.东东丒不下丆世业不() == true)
            {
                    return;
            }
            
            Rilisoft.与专丒丞丐一丒丂东 val_11 = this.Parameter;
            if(this.丗下丘世三七一专丕 == 1)
            {
                    return;
            }
            
            this.丗下丘世三七一专丕 = 1;
            this.丕丕业七丙七丅丈丄();
        }
        protected override void 丝东丐丝东三丈世丝()
        {
            if(this._touchBlocker.gameObject.activeSelf == false)
            {
                goto typeof(Rilisoft.GameEventSetsViewChestContent).__il2cppRuntimeField_258;
            }
        
        }
        private void 不丝丗东丌丁丅丗丒()
        {
            if(this.Parameter == null)
            {
                    return;
            }
            
            if(this._spinButtonView != 0)
            {
                    this._spinButtonView.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  this.Parameter, 万丐丁三且下丞丈丌:  0);
            }
            
            if(this._resetButtonView == 0)
            {
                    return;
            }
            
            this._resetButtonView.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  this.Parameter.东不七丏上丑丈专下(), 万丐丁三且下丞丈丌:  0);
        }
        private void 丗七万世万丙万丅丒()
        {
            if(this._detailsCountLabel == 0)
            {
                    return;
            }
            
            this = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4547"), arg0:  System.String.Format(format:  "{0}/{1}", arg0:  this.Parameter.丑专丐丐丏丆东丘万(), arg1:  this.Parameter.东丂七不丄丑丄丆七()));
            this._detailsCountLabel.text = this;
        }
        private void 丑丌丅丗世丏丄丆万()
        {
            var val_37;
            System.Action<Rilisoft.GameEventSetItemView> val_38;
            var val_39;
            if(this.丂丄丘专丈业三且丛() == null)
            {
                    return;
            }
            
            if(this.Parameter == null)
            {
                    return;
            }
            
            Rilisoft.与专丒丞丐一丒丂东 val_3 = this.Parameter;
            if(val_3 == null)
            {
                    return;
            }
            
            val_37 = 1152921542788108528;
            if(val_3.Count != this.丂丄丘专丈业三且丛().Count)
            {
                    object[] val_7 = new object[3];
                val_38 = 1152921504622075904;
                val_7[0] = this.丂丄丘专丈业三且丛().Count;
                val_7[1] = this.Parameter.丅丙丛丑丌丆丌丕丒();
                val_7[2] = val_3.Count;
                UnityEngine.Debug.LogErrorFormat(format:  "slots in roll: {0}, containers in chest \'{1}\': {2}", args:  val_7);
            }
            
            val_39 = 0;
            goto label_36;
            label_49:
            Rilisoft.GameEventSetItemView val_14 = this.丂丄丘专丈业三且丛().Item[0];
            if(val_39 > (val_3.Count - 1))
            {
                goto label_23;
            }
            
            Rilisoft.GameEventItemContainer val_17 = val_3.Item[0];
            if(val_17.AvailableToDropItems.Count != 0)
            {
                    if((this.Parameter.丁且且丐不丝丐下丘().Contains(item:  val_17.Id)) == false)
            {
                goto label_30;
            }
            
            }
            
            if(val_17 != null)
            {
                goto label_46;
            }
            
            label_47:
            label_46:
            Rilisoft.GameEventItem val_25 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_17.AllItems);
            int val_26 = val_17.Id;
            val_14.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContent::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)));
            System.Action<Rilisoft.GameEventSetItemView> val_28 = null;
            val_38 = val_28;
            val_28 = new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContent::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟));
            val_14.add_Clicked(丙业与丙丗丝不丈东:  val_28);
            val_37 = 1152921542788108528;
            label_23:
            val_39 = 1;
            goto label_36;
            label_30:
            if((this.丗下丘世三七一专丕 != 1) || ((this.专丟丄丟东一丆上且.Contains(item:  val_17.Id)) == false))
            {
                goto label_40;
            }
            
            if(val_17 != null)
            {
                goto label_46;
            }
            
            goto label_47;
            label_40:
            System.Collections.Generic.List<System.Int32> val_37 = this.Parameter.万丐丘丟丂丛丂丈万();
            val_37 = val_37.Contains(item:  val_17.Id);
            if(val_17 != null)
            {
                goto label_46;
            }
            
            goto label_47;
            label_36:
            if(val_39 < this.丂丄丘专丈业三且丛().Count)
            {
                goto label_49;
            }
        
        }
        private void 丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)
        {
            Rilisoft.GameEventSetItemView val_11;
            ButtonClickSound val_12;
            val_11 = 丁世丛业丟下丕三丟;
            val_12 = this;
            .丁世丛业丟下丕三丟 = val_11;
            if(this.Parameter == null)
            {
                    return;
            }
            
            val_11 = this.Parameter;
            if(this.丗下丘世三七一专丕 != 1)
            {
                goto label_4;
            }
            
            if((System.Linq.Enumerable.All<Rilisoft.GameEventItemContainer>(source:  val_11, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  new GameEventSetsViewChestContent.下丏丌丑七丗丕丅世(), method:  System.Boolean GameEventSetsViewChestContent.下丏丌丑七丗丕丅世::丄万且与丅丕专丛东(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)))) == true)
            {
                    return;
            }
            
            val_11 = this.专丟丄丟东一丆上且;
            if((this.专丟丄丟东一丆上且.Contains(item:  (GameEventSetsViewChestContent.下丏丌丑七丗丕丅世)[1152921542788536864].丁世丛业丟下丕三丟._containerId)) == false)
            {
                goto label_8;
            }
            
            bool val_7 = val_11.Remove(item:  (GameEventSetsViewChestContent.下丏丌丑七丗丕丅世)[1152921542788536864].丁世丛业丟下丕三丟._containerId);
            goto label_16;
            label_4:
            this.与丈不丟丄三七丗上(丝丑丏七业上且三丈:  (GameEventSetsViewChestContent.下丏丌丑七丗丕丅世)[1152921542788536864].丁世丛业丟下丕三丟.<丅丝丌丝丁丏丙东丞>k__BackingField);
            goto label_13;
            label_8:
            val_11 = val_11.Count;
            Rilisoft.丝丑丂丛万丐丈丘且 val_10 = this.Parameter.万丝世丘丞东万丟万();
            if(val_11 < )
            {
                    val_11 = (GameEventSetsViewChestContent.下丏丌丑七丗丕丅世)[1152921542788536864].丁世丛业丟下丕三丟._containerId;
                this.专丟丄丟东一丆上且.Add(item:  val_11);
            }
            
            label_16:
            this.丕丕业七丙七丅丈丄();
            label_13:
            val_12 = ButtonClickSound.丆丕丝丒不丙且丐丗;
            val_12.PlayClick();
        }
        private System.Collections.IEnumerator 丌丁丘丕专丞上丅且(Rilisoft.GameEventSetItemView 丑丒丞丑丝丒丂丏丛, int 丅专丑丄不东丈七丂, System.Action 丟丘丙丄丅万丏与丗)
        {
            GameEventSetsViewChestContent.丁丕丂丄丕专三丒丂 val_1 = new GameEventSetsViewChestContent.丁丕丂丄丕专三丒丂();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丑丒丞丑丝丒丂丏丛 = 丑丒丞丑丝丒丂丏丛;
                .丅专丑丄不东丈七丂 = 丅专丑丄不东丈七丂;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 丑丒丞丑丝丒丂丏丛;
                mem[48] = 丅专丑丄不东丈七丂;
            }
            
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
            return (System.Collections.IEnumerator)val_1;
        }
        internal void 丂丗丕丞万丐丝丞丛(System.Action 丟丘丙丄丅万丏与丗)
        {
            if(丟丘丙丄丅万丏与丗 == null)
            {
                    return;
            }
            
            丟丘丙丄丅万丏与丗.Invoke();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            this.且丛丐与丞上丌不丒 = 0;
        }
        private void 且七三丏不专一丙丐()
        {
            var val_18;
            System.Collections.Generic.List<System.Int32> val_33;
            if(this.Parameter == null)
            {
                    return;
            }
            
            val_33 = this.Parameter;
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = val_33.万丝世丘丞东万丟万();
            if(this.专丟丄丟东一丆上且.Count < (-472405040))
            {
                    return;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = this.Parameter.万丝世丘丞东万丟万();
            if(this.专丟丄丟东一丆上且.Count > (-472405040))
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_9 = this.Parameter.万丝世丘丞东万丟万();
                this.专丟丄丟东一丆上且 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Take<System.Int32>(source:  this.专丟丄丟东一丆上且, count:  -472405040));
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丙东丗丏丏丑丗丄丁(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丒业七丒丞丁万丝丐:  this.专丟丄丟东一丆上且);
            val_33 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.专丟丄丟东一丆上且);
            this.Parameter.丄三丏丏丆专丟上丛(丄丗丙东丌且不丕丘:  val_33);
            this.Parameter.丗丄丐万丏业丏丑万();
            List.Enumerator<T> val_16 = this.专丟丄丟东一丆上且.GetEnumerator();
            label_26:
            if(((-472405072) & 1) == 0)
            {
                goto label_16;
            }
            
            new GameEventSetsViewChestContent.与丙丌丟一七下丏与() = new System.Object();
            .丒丁东世世丗丅丅丄 = val_18.丙东专丂世丈丏丁丂();
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_22 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  new GameEventSetsViewChestContent.与丙丌丟一七下丏与(), method:  System.Boolean GameEventSetsViewChestContent.与丙丌丟一七下丏与::东且业丅丆丟不丈不(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
            Rilisoft.GameEventItemContainer val_23 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  this.Parameter, predicate:  null);
            if(val_23 == null)
            {
                goto label_26;
            }
            
            Rilisoft.GameEventItem val_25 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_23.AvailableToDropItems);
            if(val_25 == null)
            {
                goto label_26;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_31 = val_25.Data.BaseCount;
            Rilisoft.一丟专且三万丞丁丂.与三丒东且与丏丘三(且丆丂丂丞不下七丘:  this.Parameter.丅三专且丈一丝丂丏(), 丞一丁业丄一一业且:  val_25.Data.Id, 丌丒丝东丌下丕丁丅:  -472405040);
            goto label_26;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.丗下丘世三七一专丕 == 2)
            {
                    return;
            }
            
            this.丗下丘世三七一专丕 = 2;
            this.丕丕业七丙七丅丈丄();
        }
        private void 丄丄三三万丗丂丁下(bool 丑丆丕七丂不丙丞丂)
        {
            bool val_18;
            object val_19;
            var val_20;
            丈丞丕丘丕丗与上一 val_21;
            PGCompany.三东丏不丗世丅丌丄 val_22;
            var val_23;
            System.Action val_25;
            val_18 = 丑丆丕七丂不丙丞丂;
            GameEventSetsViewChestContent.且不丘丝丕业下万一 val_1 = null;
            val_19 = val_1;
            val_1 = new GameEventSetsViewChestContent.且不丘丝丕业下万一();
            if(val_19 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .丑丆丕七丂不丙丞丂 = val_18;
            if(this.Parameter == null)
            {
                    return;
            }
            
            if((GameEventSetsViewChestContent.且不丘丝丕业下万一)[1152921542789486176].丑丆丕七丂不丙丞丂 != false)
            {
                    val_20 = null;
                val_20 = null;
                丈丞丕丘丕丗与上一 val_4 = null;
                val_21 = val_4;
                val_4 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
            }
            else
            {
                    val_21 = this.Parameter.东不七丏上丑丈专下();
            }
            
            .三丝专与万丟上丘下 = val_21;
            System.Action val_7 = null;
            val_18 = val_7;
            val_7 = new System.Action(object:  val_1, method:  System.Void GameEventSetsViewChestContent.且不丘丝丕业下万一::丘东丂不丑一东不三());
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() == false)
            {
                goto label_10;
            }
            
            val_22 = (GameEventSetsViewChestContent.且不丘丝丕业下万一)[1152921542789486176].三丝专与万丟上丘下.与丒上与丄丒丝三七();
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_22, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = false})) == false)
            {
                goto label_13;
            }
            
            label_10:
            val_19 = (GameEventSetsViewChestContent.且不丘丝丕业下万一)[1152921542789486176].三丝专与万丟上丘下;
            val_23 = null;
            val_23 = null;
            val_25 = GameEventSetsViewChestContent.<>c.<>9__39_1;
            if(val_25 == null)
            {
                    System.Action val_14 = null;
                val_25 = val_14;
                val_14 = new System.Action(object:  GameEventSetsViewChestContent.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventSetsViewChestContent.<>c::丐丌丒丛上世丗下一());
                GameEventSetsViewChestContent.<>c.<>9__39_1 = val_25;
            }
            
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_19, 七丒上且丝业业下七:  val_7, 丝丏丗丄丗与丐丌三:  val_14, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  86);
            return;
            label_13:
            UnityEngine.Debug.LogError(message:  "GameEvents Reset (not enough currency) -> GoToMainStore");
            val_19 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
            val_19.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  (GameEventSetsViewChestContent.且不丘丝丕业下万一)[1152921542789486176].三丝专与万丟上丘下.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
        }
        private void 不丕一丌一丝丂一世()
        {
            if(this.Parameter == null)
            {
                    return;
            }
            
            if(this.Parameter.丟丝与丙东世丗丞与() > 0)
            {
                    return;
            }
            
            this.Parameter.丄三丏丏丆专丟上丛(丄丗丙东丌且不丕丘:  0);
            this.Parameter.丗丄丐万丏业丏丑万();
            if(this.丗下丘世三七一专丕 == 1)
            {
                    return;
            }
            
            this.丗下丘世三七一专丕 = 1;
            this.丕丕业七丙七丅丈丄();
        }
        public void U_SaveExcludedItems()
        {
            this.且七三丏不专一丙丐();
        }
        public void U_ResetChestState()
        {
            this.丄丄三三万丗丂丁下(丑丆丕七丂不丙丞丂:  false);
        }
        public void U_ResetChestStateFree()
        {
            this.丄丄三三万丗丂丁下(丑丆丕七丂不丙丞丂:  true);
        }
        public void U_ResetExcludedItems()
        {
            this.不丕一丌一丝丂一世();
        }
        private void 丕丕业七丙七丅丈丄()
        {
            UnityEngine.GameObject val_19;
            var val_20;
            UnityEngine.GameObject val_21;
            float val_22;
            var val_23;
            val_19 = this;
            if(true == 0)
            {
                    return;
            }
            
            if(this.Parameter == null)
            {
                    return;
            }
            
            this._excludeChestsView.HideWindow();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._spinButtonView.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._resetExcludesGameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._resetChestGameObject, 丏业丟一东丂东丘丛:  false);
            this._chestCompleteView.HideWindow();
            if(this.丗下丘世三七一专丕 == 4)
            {
                goto label_8;
            }
            
            if(this.丗下丘世三七一专丕 == 2)
            {
                goto label_9;
            }
            
            if(this.丗下丘世三七一专丕 != 1)
            {
                goto label_16;
            }
            
            this._excludeChestsView.Setup(与且专丈不万东一万:  this.Parameter, 丆且丁丒丒丆丁三丆:  this.专丟丄丟东一丆上且);
            this._excludeChestsView.ShowWindow();
            goto label_16;
            label_8:
            this._chestCompleteView.Setup(与且专丈不万东一万:  this.Parameter);
            this._chestCompleteView.ShowWindow();
            goto label_16;
            label_9:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._spinButtonView.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this.Parameter.丟丝与丙东世丗丞与() != 0)
            {
                    val_20 = null;
                val_21 = this._resetChestGameObject;
            }
            else
            {
                    val_20 = null;
                val_21 = this._resetExcludesGameObject;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  true);
            label_16:
            if(this._resetExcludesGameObject.activeSelf != false)
            {
                    val_22 = -274f;
            }
            else
            {
                    var val_10 = (this._resetChestGameObject.activeSelf != true) ? -274f : -362f;
            }
            
            UnityEngine.Vector3 val_13 = this._playerGotNotif.transform.localPosition;
            UnityEngine.Vector3 val_15 = this._playerGotNotif.transform.localPosition;
            this._playerGotNotif.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丗七万世万丙万丅丒();
            this.不丝丗东丌丁丅丗丒();
            this.丑丌丅丗世丏丄丆万();
            if(this._spinButtonNotif == 0)
            {
                    return;
            }
            
            Rilisoft.与专丒丞丐一丒丂东 val_17 = this.Parameter;
            if(val_17 != null)
            {
                    val_23 = val_17.丐七丒丏下上丂丁丗();
            }
            else
            {
                    val_23 = 0;
            }
            
            val_19 = this._spinButtonNotif;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_19, 丏业丟一东丂东丘丛:  val_23 & 1);
        }
        protected override string 丅丅业丏丒丙丒丁丘()
        {
            object val_25;
            string val_26;
            int val_27;
            string val_28;
            val_25 = this;
            if(this.Parameter == null)
            {
                goto label_3;
            }
            
            System.Nullable<System.TimeSpan> val_3 = this.Parameter.丙世丑丅丒丑业与不();
            if(((-470904640) & 1) == 0)
            {
                goto label_3;
            }
            
            System.Nullable<System.TimeSpan> val_5 = this.Parameter.丙世丑丅丒丑业与不();
            if(val_5.HasValue.TotalSeconds <= 0f)
            {
                goto label_5;
            }
            
            System.Nullable<System.TimeSpan> val_8 = this.Parameter.丙世丑丅丒丑业与不();
            val_25 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            val_26 = "Key_4959";
            goto label_11;
            label_3:
            if(this.Parameter == null)
            {
                goto label_14;
            }
            
            System.Nullable<System.TimeSpan> val_12 = this.Parameter.七丆丄丟丟丕三上上();
            if(((-470904640) & 1) == 0)
            {
                goto label_14;
            }
            
            System.Nullable<System.TimeSpan> val_14 = this.Parameter.七丆丄丟丟丕三上上();
            if(val_14.HasValue.TotalSeconds <= 0f)
            {
                goto label_21;
            }
            
            if(this.Parameter != null)
            {
                    if(this.Parameter.丟丂丞不专丆万丒世() < 1)
            {
                goto label_21;
            }
            
            }
            
            System.Nullable<System.TimeSpan> val_20 = this.Parameter.七丆丄丟丟丕三上上();
            val_25 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            val_26 = "Key_4734";
            label_11:
            string val_23 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_26), arg0:  val_25);
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_28 = "Key_4735");
            label_14:
            val_28 = "Key_4453";
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_28);
            label_5:
            val_27 = System.String.alignConst;
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_28);
            label_21:
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_28);
        }
        public GameEventSetsViewChestContent()
        {
            this.专丟丄丟东一丆上且 = new System.Collections.Generic.List<System.Int32>();
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
