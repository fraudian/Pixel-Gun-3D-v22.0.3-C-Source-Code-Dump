using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventSetsViewChestContentField : GameEventSetsViewBase, 丏丗丞丙不丝三丕丟
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
        private Rilisoft.GameEventDiceView _diceView;
        private Rilisoft.GameEventChestLapsView _lapsView;
        private UnityEngine.GameObject _spinButtonNotif;
        private UnityEngine.Coroutine 丌专丑东丙丕丟丌丗;
        private Rilisoft.GameEventSetsViewChestContentField.且世丈业丘丆不上丄 丗下丘世三七一专丕;
        private System.Collections.Generic.List<Rilisoft.GameEventSetItemView> 且下万丐丞东丈万丈;
        private System.Collections.Generic.List<int> 专丟丄丟东一丆上且;
        private UnityEngine.Coroutine 且丛丐与丞上丌不丒;
        private System.Action 万专下专丆且丙三上;
        
        // Properties
        private System.Collections.Generic.List<Rilisoft.GameEventSetItemView> 业丏丈丛丄不丘丛万 { get; }
        internal override string 丄丂丏世丛丏万三丆 { get; }
        private Rilisoft.GameEventSetsViewChestContentField.且世丈业丘丆不上丄 上丅丑丌丑丏丏丙东 { get; set; }
        
        // Methods
        private void 丛下丑丟丏下丟丄万(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.万专下专丆且丙三上, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万专下专丆且丙三上 != this.万专下专丆且丙三上);
        
        }
        private void 上丅且丏丂丒丁丏一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.万专下专丆且丙三上, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万专下专丆且丙三上 != this.万专下专丆且丙三上);
        
        }
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
            return "dice";
        }
        private Rilisoft.GameEventSetsViewChestContentField.且世丈业丘丆不上丄 万丘三丘下与与且业()
        {
            return (且世丈业丘丆不上丄)this.丗下丘世三七一专丕;
        }
        private void 丒丟丛丂丆三三丙丑(Rilisoft.GameEventSetsViewChestContentField.且世丈业丘丆不上丄 丙业与丙丗丝不丈东)
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
            GameEventSetsViewChestContentField.三丕业丁丗东丂七丝 val_1 = new GameEventSetsViewChestContentField.三丕业丁丗东丂七丝();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
            if(this.且丛丐与丞上丌不丒 != null)
            {
                    this.StopCoroutine(routine:  this.且丛丐与丞上丌不丒);
            }
            
            this.万专下专丆且丙三上 = 丛丙丅下世三与丟丟;
            this.且丛丐与丞上丌不丒 = this.StartCoroutine(routine:  this.丌丁丘丕专丞上丅且(不丐丐东东丁与且下:  不丐丐东东丁与且下, 丟丘丙丄丅万丏与丗:  new System.Action(object:  val_1, method:  System.Void GameEventSetsViewChestContentField.三丕业丁丗东丂七丝::丝丗丛丟三丛丏丟丄())));
        }
        public override void Setup(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            Rilisoft.丛且世丐丆上七业丁 val_36;
            且世丈业丘丆不上丄 val_37;
            val_36 = 丅东专与不三丂丁丝;
            this.Setup(丅东专与不三丂丁丝:  val_36, 丆且丁丒丒丆丁三丆:  丆且丁丒丒丆丁三丆);
            丆且丁丒丒丆丁三丆.Hide();
            this.专丟丄丟东一丆上且.Clear();
            if(this.Parameter == null)
            {
                    return;
            }
            
            if(this._chestNameLabels != null)
            {
                    .丕不丝丙三丕丗丅丌 = this.Parameter;
                val_36 = this._chestNameLabels;
                val_36.ForEach(action:  new System.Action<UILabel>(object:  new GameEventSetsViewChestContentField.与三丆丞业丝丙丄丏(), method:  System.Void GameEventSetsViewChestContentField.与三丆丞业丝丙丄丏::丆一且世上丗上一丗(UILabel 丐三丞七丝丅不万丛)));
            }
            
            this.丗下丘世三七一专丕 = 0;
            if(this.Parameter.万丐丘丟丂丛丂丈万() == null)
            {
                goto label_9;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_8 = this.Parameter.万丝世丘丞东万丟万();
            if( < 1)
            {
                goto label_15;
            }
            
            val_36 = this.Parameter;
            Rilisoft.丝丑丂丛万丐丈丘且 val_13 = val_36.万丝世丘丞东万丟万();
            if(this.Parameter.万丐丘丟丂丛丂丈万().Count >= )
            {
                goto label_15;
            }
            
            label_9:
            if(this.丗下丘世三七一专丕 == 1)
            {
                    return;
            }
            
            val_37 = 1;
            goto label_40;
            label_15:
            if(this.Parameter.丒世业三丘丝不下丕() == true)
            {
                goto label_26;
            }
            
            val_36 = this.Parameter.丁且且丐不丝丐下丘().Count;
            if((val_36 + this.Parameter.万丐丘丟丂丛丂丈万().Count) >= this.Parameter.Count)
            {
                goto label_26;
            }
            
            if((this.Parameter.丐世丑丗且丙万上上() != 1) || ((this.Parameter.丂丄七丒与丐下且丘(且丟丑世丆万丏不世:  0)) == null))
            {
                goto label_36;
            }
            
            val_36 = this.Parameter;
            if((this.Parameter.IndexOf(item:  this.Parameter.丂丄七丒与丐下且丘(且丟丑世丆万丏不世:  0))) != (val_36.Count - 1))
            {
                goto label_36;
            }
            
            if(this.丗下丘世三七一专丕 == 5)
            {
                    return;
            }
            
            val_37 = 5;
            goto label_40;
            label_26:
            if(this.丗下丘世三七一专丕 == 4)
            {
                    return;
            }
            
            val_37 = 4;
            goto label_40;
            label_36:
            if(this.丗下丘世三七一专丕 == 2)
            {
                    return;
            }
            
            val_37 = 2;
            label_40:
            this.丗下丘世三七一专丕 = val_37;
            this.丕丕业七丙七丅丈丄();
        }
        public override void ShowWindow()
        {
            this.ShowWindow();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._touchBlocker, 丏业丟一东丂东丘丛:  false);
            this._chestCompleteView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentField::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
            this._chestCompleteView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentField::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
        }
        public override void HideWindow()
        {
            this.丗下丘世三七一专丕 = 0;
            this.HideWindow();
            this._chestCompleteView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentField::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
        }
        private void 七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)
        {
            UnityEngine.Object val_8;
            if(this.Parameter.丒世业三丘丝不下丕() == false)
            {
                goto label_2;
            }
            
            val_8 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_8 == 0)
            {
                    return;
            }
            
            Rilisoft.AbstractGameEventGui val_5 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_5 == null)
            {
                goto label_6;
            }
            
            var val_6 = (null == null) ? (val_5) : 0;
            goto label_7;
            label_2:
            this.丄丄三三万丗丂丁下(丑丆丕七丂不丙丞丂:  true);
            return;
            label_6:
            val_8 = 0;
            label_7:
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
            if(((-465932648) & 1) == 0)
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
                goto typeof(Rilisoft.GameEventSetsViewChestContentField).__il2cppRuntimeField_258;
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
            object val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            val_52 = this;
            if(this.丂丄丘专丈业三且丛() == null)
            {
                    return;
            }
            
            if(this.Parameter == null)
            {
                    return;
            }
            
            val_53 = this.Parameter.丈丒三丏专且丆万丙();
            if(val_53 == null)
            {
                    return;
            }
            
            val_54 = 1152921542788108528;
            if(val_53.Count != this.丂丄丘专丈业三且丛().Count)
            {
                    object[] val_8 = new object[3];
                val_8[0] = this.丂丄丘专丈业三且丛().Count;
                val_8[1] = this.Parameter.丅丙丛丑丌丆丌丕丒();
                val_8[2] = val_53.Count;
                UnityEngine.Debug.LogErrorFormat(format:  "slots in roll: {0}, containers in chest \'{1}\': {2}", args:  val_8);
            }
            
            val_55 = this.Parameter;
            val_56 = 0;
            goto label_22;
            label_60:
            Rilisoft.GameEventSetItemView val_17 = this.丂丄丘专丈业三且丛().Item[0];
            if(val_56 > (val_53.Count - 1))
            {
                goto label_24;
            }
            
            Rilisoft.GameEventItemContainer val_20 = val_53.Item[0];
            if(val_20.AvailableToDropItems.Count != 0)
            {
                    if((this.Parameter.丁且且丐不丝丐下丘().Contains(item:  val_20.Id)) == false)
            {
                goto label_31;
            }
            
            }
            
            label_45:
            if(val_20 != null)
            {
                goto label_55;
            }
            
            label_56:
            label_55:
            Rilisoft.GameEventItem val_28 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_20.AllItems);
            int val_29 = val_20.Id;
            if((val_55.丂丄七丒与丐下且丘(且丟丑世丆万丏不世:  0)) == val_20)
            {
                goto label_35;
            }
            
            val_53 = val_53;
            if(val_20.ContentType != 3)
            {
                goto label_41;
            }
            
            if(this.Parameter.专且丌丁丙丂上丘丄() == 0)
            {
                goto label_39;
            }
            
            goto label_41;
            label_35:
            val_53 = val_53;
            goto label_41;
            label_31:
            if(val_20.ContentType == 3)
            {
                    if(this.Parameter.专且丌丁丙丂上丘丄() == 0)
            {
                goto label_45;
            }
            
            }
            
            if((this.丗下丘世三七一专丕 != 1) || ((this.专丟丄丟东一丆上且.Contains(item:  val_20.Id)) == false))
            {
                goto label_49;
            }
            
            if(val_20 != null)
            {
                goto label_55;
            }
            
            goto label_56;
            label_49:
            System.Collections.Generic.List<System.Int32> val_52 = this.Parameter.万丐丘丟丂丛丂丈万();
            val_52 = val_52.Contains(item:  val_20.Id);
            if(val_20 != null)
            {
                goto label_55;
            }
            
            goto label_56;
            label_39:
            var val_45 = (this.Parameter.丁且且丐不丝丐下丘().Count == 0) ? 1 : 0;
            label_41:
            val_55 = 1152921504615686144;
            val_17.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentField::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)));
            val_17.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentField::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)));
            val_54 = val_54;
            label_24:
            val_56 = 1;
            label_22:
            if(val_56 < this.丂丄丘专丈业三且丛().Count)
            {
                goto label_60;
            }
            
            if(this._lapsView == 0)
            {
                    return;
            }
            
            val_52 = this.Parameter;
            this._lapsView.Setup(与且专丈不万东一万:  val_52);
        }
        private void 丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)
        {
            System.Collections.Generic.List<System.Int32> val_10;
            if(this.Parameter == null)
            {
                    return;
            }
            
            val_10 = this.Parameter;
            Rilisoft.GameEventItemContainer val_3 = val_10.三丞丅业丟丐丝三丆(丒丁东世世丗丅丅丄:  丁世丛业丟下丕三丟._containerId);
            if(this.丗下丘世三七一专丕 != 1)
            {
                goto label_4;
            }
            
            if(val_3 == null)
            {
                    return;
            }
            
            val_10 = this.专丟丄丟东一丆上且;
            if((this.专丟丄丟东一丆上且.Contains(item:  丁世丛业丟下丕三丟._containerId)) == false)
            {
                goto label_7;
            }
            
            bool val_5 = val_10.Remove(item:  丁世丛业丟下丕三丟._containerId);
            goto label_15;
            label_4:
            if(val_3 == null)
            {
                    return;
            }
            
            if(val_3.ContentType == 3)
            {
                    return;
            }
            
            this.与丈不丟丄三七丗上(丝丑丏七业上且三丈:  丁世丛业丟下丕三丟.<丅丝丌丝丁丏丙东丞>k__BackingField);
            return;
            label_7:
            val_10 = val_10.Count;
            Rilisoft.丝丑丂丛万丐丈丘且 val_9 = this.Parameter.万丝世丘丞东万丟万();
            if(val_10 < )
            {
                    val_10 = this.专丟丄丟东一丆上且;
                val_10.Add(item:  丁世丛业丟下丕三丟._containerId);
            }
            
            label_15:
            this.丕丕业七丙七丅丈丄();
        }
        private System.Collections.IEnumerator 丌丁丘丕专丞上丅且(int 不丐丐东东丁与且下, System.Action 丟丘丙丄丅万丏与丗)
        {
            GameEventSetsViewChestContentField.丒丆业且下七不丅丑 val_1 = new GameEventSetsViewChestContentField.丒丆业且下七不丅丑();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .不丐丐东东丁与且下 = 不丐丐东东丁与且下;
            }
            else
            {
                    mem[40] = this;
                mem[32] = 不丐丐东东丁与且下;
            }
            
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丛丒丝下业丐丝上七(int 丗丏丑丁万东丆丝丝, int 专丌丏世丐丛丗丝丂, bool 丅与丅丝丈世丑丐丗)
        {
            GameEventSetsViewChestContentField.丝与丄丗一丆丆丝丅 val_1 = new GameEventSetsViewChestContentField.丝与丄丗一丆丆丝丅();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .专丌丏世丐丛丗丝丂 = 专丌丏世丐丛丗丝丂;
                .丗丏丑丁万东丆丝丝 = 丗丏丑丁万东丆丝丝;
            }
            else
            {
                    mem[40] = this;
                .丗丏丑丁万东丆丝丝 = 丗丏丑丁万东丆丝丝;
                mem[32] = 专丌丏世丐丛丗丝丂;
            }
            
            .丅与丅丝丈世丑丐丗 = 丅与丅丝丈世丑丐丗;
            return (System.Collections.IEnumerator)val_1;
        }
        public void PrepareForSpin(System.Action 丟丘丙丄丅万丏与丗)
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
            var val_17;
            var val_32;
            if(this.Parameter == null)
            {
                    return;
            }
            
            val_32 = this.Parameter;
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = val_32.万丝世丘丞东万丟万();
            if(this.专丟丄丟东一丆上且.Count < (-464089696))
            {
                    return;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = this.Parameter.万丝世丘丞东万丟万();
            if(this.专丟丄丟东一丆上且.Count > (-464089696))
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_9 = this.Parameter.万丝世丘丞东万丟万();
                this.专丟丄丟东一丆上且 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Take<System.Int32>(source:  this.专丟丄丟东一丆上且, count:  -464089696));
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丙东丗丏丏丑丗丄丁(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丒业七丒丞丁万丝丐:  this.专丟丄丟东一丆上且);
            val_32 = this.Parameter;
            val_32.丄三丏丏丆专丟上丛(丄丗丙东丌且不丕丘:  this.专丟丄丟东一丆上且);
            this.Parameter.丗丄丐万丏业丏丑万();
            List.Enumerator<T> val_15 = this.专丟丄丟东一丆上且.GetEnumerator();
            label_26:
            if(((-464089728) & 1) == 0)
            {
                goto label_16;
            }
            
            new GameEventSetsViewChestContentField.丈丞丕丘丄丐且丈丂() = new System.Object();
            .丒丁东世世丗丅丅丄 = val_17.丙东专丂世丈丏丁丂();
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_21 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  new GameEventSetsViewChestContentField.丈丞丕丘丄丐且丈丂(), method:  System.Boolean GameEventSetsViewChestContentField.丈丞丕丘丄丐且丈丂::东且业丅丆丟不丈不(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
            Rilisoft.GameEventItemContainer val_22 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  this.Parameter, predicate:  null);
            if(val_22 == null)
            {
                goto label_26;
            }
            
            Rilisoft.GameEventItem val_24 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_22.AvailableToDropItems);
            if(val_24 == null)
            {
                goto label_26;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_30 = val_24.Data.BaseCount;
            Rilisoft.一丟专且三万丞丁丂.与三丒东且与丏丘三(且丆丂丂丞不下七丘:  this.Parameter.丅三专且丈一丝丂丏(), 丞一丁业丄一一业且:  val_24.Data.Id, 丌丒丝东丌下丕丁丅:  -464089696);
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
            var val_26;
            var val_27;
            val_18 = 丑丆丕七丂不丙丞丂;
            GameEventSetsViewChestContentField.上丏三丌丂丙丅且丘 val_1 = null;
            val_19 = val_1;
            val_1 = new GameEventSetsViewChestContentField.上丏三丌丂丙丅且丘();
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
            
            if((GameEventSetsViewChestContentField.上丏三丌丂丙丅且丘)[1152921542797797232].丑丆丕七丂不丙丞丂 != false)
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
            val_7 = new System.Action(object:  val_1, method:  System.Void GameEventSetsViewChestContentField.上丏三丌丂丙丅且丘::丘东丂不丑一东不三());
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() == false)
            {
                goto label_10;
            }
            
            val_22 = (GameEventSetsViewChestContentField.上丏三丌丂丙丅且丘)[1152921542797797232].三丝专与万丟上丘下.与丒上与丄丒丝三七();
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_22, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                goto label_13;
            }
            
            label_10:
            val_19 = (GameEventSetsViewChestContentField.上丏三丌丂丙丅且丘)[1152921542797797232].三丝专与万丟上丘下;
            val_23 = null;
            val_23 = null;
            val_25 = GameEventSetsViewChestContentField.<>c.<>9__46_1;
            if(val_25 == null)
            {
                    System.Action val_14 = null;
                val_25 = val_14;
                val_14 = new System.Action(object:  GameEventSetsViewChestContentField.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventSetsViewChestContentField.<>c::丏下业丐丗丝不丞丄());
                GameEventSetsViewChestContentField.<>c.<>9__46_1 = val_25;
            }
            
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_19, 七丒上且丝业业下七:  val_7, 丝丏丗丄丗与丐丌三:  val_14, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  86);
            return;
            label_13:
            UnityEngine.Debug.LogError(message:  "GameEvents Reset (not enough currency) -> GoToMainStore");
            val_26 = null;
            val_26 = null;
            val_27 = null;
            val_27 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.三丄东丅丁不丒丐丑;
            val_19 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
            val_18 = (GameEventSetsViewChestContentField.上丏三丌丂丙丅且丘)[1152921542797797232].三丝专与万丟上丘下.东与三丌丅三丒丏业();
            val_19.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_18, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丄东丅丁不丒丐丑, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
        }
        private Rilisoft.GameEventSetItemView 三且丞丞且世三丗上()
        {
            System.Collections.Generic.List<Rilisoft.GameEventSetItemView> val_1 = this.丂丄丘专丈业三且丛();
            if(val_1 != null)
            {
                    return val_1.Item[0];
            }
            
            return val_1.Item[0];
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
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = this.Parameter.万丝世丘丞东万丟万();
            且世丈业丘丆不上丄 val_8 = ( <= 0) ? (1 + 1) : 1;
            if(this.丗下丘世三七一专丕 != 0)
            {
                    if(this.丗下丘世三七一专丕 == val_8)
            {
                goto label_7;
            }
            
            }
            
            this.丗下丘世三七一专丕 = val_8;
            this.丕丕业七丙七丅丈丄();
            label_7:
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
            UnityEngine.GameObject val_23;
            float val_26;
            var val_27;
            val_23 = this;
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
            且世丈业丘丆不上丄 val_24 = this.丗下丘世三七一专丕;
            val_24 = val_24 - 1;
            if(val_24 <= 4)
            {
                    var val_25 = 106048404 + ((this.丗下丘世三七一专丕 - 1)) << 2;
                val_25 = val_25 + 106048404;
            }
            else
            {
                    if(this._resetExcludesGameObject.activeSelf != false)
            {
                    val_26 = -274f;
            }
            else
            {
                    var val_14 = (this._resetChestGameObject.activeSelf != true) ? -274f : -362f;
            }
            
                UnityEngine.Vector3 val_17 = this._playerGotNotif.transform.localPosition;
                UnityEngine.Vector3 val_19 = this._playerGotNotif.transform.localPosition;
                this._playerGotNotif.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.丗七万世万丙万丅丒();
                this.不丝丗东丌丁丅丗丒();
                this.丑丌丅丗世丏丄丆万();
                if(this._spinButtonNotif == 0)
            {
                    return;
            }
            
                Rilisoft.与专丒丞丐一丒丂东 val_21 = this.Parameter;
                if(val_21 != null)
            {
                    val_27 = val_21.丐七丒丏下上丂丁丗();
            }
            else
            {
                    val_27 = 0;
            }
            
                val_23 = this._spinButtonNotif;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23, 丏业丟一东丂东丘丛:  val_27 & 1);
            }
        
        }
        private System.Collections.IEnumerator 丂丅丛丕不世三丏丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventSetsViewChestContentField.上丐东丛专丝万丗东();
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
            if(((-462312240) & 1) == 0)
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
            if(((-462312240) & 1) == 0)
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
        public GameEventSetsViewChestContentField()
        {
            this.专丟丄丟东一丆上且 = new System.Collections.Generic.List<System.Int32>();
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
