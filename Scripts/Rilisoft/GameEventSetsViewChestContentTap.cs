using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventSetsViewChestContentTap : GameEventSetsViewBase, 丏丗丞丙不丝三丕丟
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _chestNameLabels;
        private UILabel _detailsCountLabel;
        private UnityEngine.GameObject _rollViewsContainer;
        private Rilisoft.PriceView _spinButtonView;
        private Rilisoft.PriceView _resetButtonView;
        private UnityEngine.GameObject _touchBlocker;
        private Rilisoft.GameEventExcludeChestsView _excludeChestsView;
        private UnityEngine.GameObject _resetExcludesGameObject;
        private UnityEngine.GameObject _resetChestGameObject;
        private UnityEngine.GameObject _playerGotNotif;
        private Rilisoft.GameEventSetsChestCompleteView _chestCompleteView;
        private UnityEngine.AudioClip _spinClip;
        private Rilisoft.GameEventMostExpensiveItemsView _mostExpensiveView;
        private UnityEngine.AudioClip _shuffleToClip;
        private UnityEngine.AudioClip _shuffleFromClip;
        private UnityEngine.GameObject _spinButtonNotif;
        private Rilisoft.GameEventSetsViewChestContentTap.且世丈业丘丆不上丄 丗下丘世三七一专丕;
        private UnityEngine.Coroutine 丅丂丑丂不丛专世东;
        private int 且丐七丐专万丟丑丐;
        private System.Collections.Generic.List<Rilisoft.GameEventSetItemView> 且下万丐丞东丈万丈;
        private System.Collections.Generic.List<int> 专丟丄丟东一丆上且;
        private UnityEngine.Coroutine 丂丄丄丘丐一三丐丁;
        private System.Collections.Generic.List<UnityEngine.Vector3> 丑丗丂丙下丏丟丈丏;
        
        // Properties
        internal override string 丄丂丏世丛丏万三丆 { get; }
        private Rilisoft.GameEventSetsViewChestContentTap.且世丈业丘丆不上丄 上丅丑丌丑丏丏丙东 { get; set; }
        
        // Methods
        internal override string 丌三不七丌丗丞丌专()
        {
            return "tap";
        }
        private Rilisoft.GameEventSetsViewChestContentTap.且世丈业丘丆不上丄 万丘三丘下与与且业()
        {
            return (且世丈业丘丆不上丄)this.丗下丘世三七一专丕;
        }
        private void 丒丟丛丂丆三三丙丑(Rilisoft.GameEventSetsViewChestContentTap.且世丈业丘丆不上丄 丙业与丙丗丝不丈东)
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
            Rilisoft.GameEventSetsViewChestContentTap val_18;
            var val_19;
            Rilisoft.GameEventSetItemView val_20;
            Rilisoft.GameEventItem val_21;
            int val_22;
            val_18 = this;
            GameEventSetsViewChestContentTap.丐丐七丈丅丐三且丆 val_1 = new GameEventSetsViewChestContentTap.丐丐七丈丅丐三且丆();
            if(val_1 != null)
            {
                    val_19 = val_1;
                .不丐丐东东丁与且下 = 不丐丐东东丁与且下;
                mem[1152921542806353856] = val_18;
                mem[1152921542806353872] = 丛丙丅下世三与丟丟;
            }
            else
            {
                    mem[16] = val_18;
                val_19 = 24;
                mem[24] = 不丐丐东东丁与且下;
                mem[32] = 丛丙丅下世三与丟丟;
            }
            
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
            if(this.丅丂丑丂不丛专世东 != null)
            {
                    this.StopCoroutine(routine:  this.丅丂丑丂不丛专世东);
            }
            
            val_20 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventSetItemView>(source:  this.且下万丐丞东丈万丈, predicate:  new System.Func<Rilisoft.GameEventSetItemView, System.Boolean>(object:  val_1, method:  System.Boolean GameEventSetsViewChestContentTap.丐丐七丈丅丐三且丆::丝丗丛丟三丛丏丟丄(Rilisoft.GameEventSetItemView 业下丌下三丕丙丌下)));
            Rilisoft.GameEventSetItemView val_8 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventSetItemView>(source:  this.且下万丐丞东丈万丈, predicate:  new System.Func<Rilisoft.GameEventSetItemView, System.Boolean>(object:  val_1, method:  System.Boolean GameEventSetsViewChestContentTap.丐丐七丈丅丐三且丆::东丝丑万三丝丏丂丑(Rilisoft.GameEventSetItemView 业下丌下三丕丙丌下)));
            if(val_20 != null)
            {
                    val_21 = val_3.<丅丝丌丝丁丏丙东丞>k__BackingField;
                val_22 = this.且丐七丐专万丟丑丐;
            }
            else
            {
                    val_21 = 0;
                val_22 = this.且丐七丐专万丟丑丐;
            }
            
            Rilisoft.GameEventItem val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  this.Parameter, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  val_1, method:  System.Boolean GameEventSetsViewChestContentTap.丐丐七丈丅丐三且丆::丟丙丑丄不丑三专且(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙))).AllItems);
            this.Parameter.与丄一下一且下万且(丏丆丑丗七丄丙丝与:  this.且丐七丐专万丟丑丐, 丒丈丙丐丏丕丆万丗:  mem[24]);
            this.Parameter.丗丄丐万丏业丏丑万();
            .下丏丒丟丙且东丏丌 = val_20;
            if(val_20 == 0)
            {
                    object[] val_14 = new object[1];
                val_18 = val_14;
                val_18[0] = mem[24];
                UnityEngine.Debug.LogErrorFormat(format:  "drop fail, view for container \'{0}\' not found", args:  val_14);
                return;
            }
            
            System.Action val_15 = null;
            val_20 = val_15;
            val_15 = new System.Action(object:  val_1, method:  System.Void GameEventSetsViewChestContentTap.丐丐七丈丅丐三且丆::丟不与丗专丞丞丄七());
            this.丅丂丑丂不丛专世东 = this.StartCoroutine(routine:  this.丆丈专丁丆世上丑丏(丁世丛业丟下丕三丟:  (GameEventSetsViewChestContentTap.丐丐七丈丅丐三且丆)[1152921542806353840].下丏丒丟丙且东丏丌, 丟丘丙丄丅万丏与丗:  val_15));
        }
        public override void Setup(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            var val_23;
            var val_41;
            System.Func<Rilisoft.GameEventSetItemView, UnityEngine.Vector3> val_43;
            var val_44;
            System.Collections.Generic.List<System.Int32> val_45;
            this.Setup(丅东专与不三丂丁丝:  丅东专与不三丂丁丝, 丆且丁丒丒丆丁三丆:  丆且丁丒丒丆丁三丆);
            if(this.且下万丐丞东丈万丈 == null)
            {
                    System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<Rilisoft.GameEventSetItemView>(source:  this._rollViewsContainer.GetComponentsInChildren<Rilisoft.GameEventSetItemView>(includeInactive:  true));
                this.且下万丐丞东丈万丈 = val_2;
                val_41 = null;
                val_41 = null;
                val_43 = GameEventSetsViewChestContentTap.<>c.<>9__29_0;
                if(val_43 == null)
            {
                    System.Func<Rilisoft.GameEventSetItemView, UnityEngine.Vector3> val_3 = null;
                val_43 = val_3;
                val_3 = new System.Func<Rilisoft.GameEventSetItemView, UnityEngine.Vector3>(object:  GameEventSetsViewChestContentTap.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Vector3 GameEventSetsViewChestContentTap.<>c::丂丝一丞万且丞丙丝(Rilisoft.GameEventSetItemView 业下丌下三丕丙丌下));
                GameEventSetsViewChestContentTap.<>c.<>9__29_0 = val_43;
            }
            
                this.丑丗丂丙下丏丟丈丏 = System.Linq.Enumerable.ToList<UnityEngine.Vector3>(source:  System.Linq.Enumerable.Select<Rilisoft.GameEventSetItemView, UnityEngine.Vector3>(source:  val_2, selector:  val_3));
            }
            
            val_2.Hide();
            val_45 = this.专丟丄丟东一丆上且;
            val_45.Clear();
            if(this.Parameter == null)
            {
                    return;
            }
            
            if(this._chestNameLabels != null)
            {
                    .丕不丝丙三丕丗丅丌 = this.Parameter;
                this._chestNameLabels.ForEach(action:  new System.Action<UILabel>(object:  new GameEventSetsViewChestContentTap.世丘丛上丞丆丟丟丐(), method:  System.Void GameEventSetsViewChestContentTap.世丘丛上丞丆丟丟丐::一丄业丐丄丒下丏丞(UILabel 丐三丞七丝丅不万丛)));
            }
            
            System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<Rilisoft.GameEventSetItemTwoSidedView>(source:  System.Linq.Enumerable.Cast<Rilisoft.GameEventSetItemTwoSidedView>(source:  this.且下万丐丞东丈万丈));
            this.丗下丘世三七一专丕 = 0;
            if(this.Parameter.万丐丘丟丂丛丂丈万() == null)
            {
                goto label_16;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_15 = this.Parameter.万丝世丘丞东万丟万();
            if((-454829808) < 1)
            {
                goto label_30;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_20 = this.Parameter.万丝世丘丞东万丟万();
            if(this.Parameter.万丐丘丟丂丛丂丈万().Count >= (-454829808))
            {
                goto label_30;
            }
            
            label_16:
            if(this.丗下丘世三七一专丕 != 1)
            {
                    this.丗下丘世三七一专丕 = 1;
                this.丕丕业七丙七丅丈丄();
            }
            
            List.Enumerator<T> val_21 = val_11.GetEnumerator();
            label_27:
            if(((-454829840) & 1) == 0)
            {
                goto label_42;
            }
            
            val_23.丐丏七丌丕丗业且上().SetFrontActive(丏业丟一东丂东丘丛:  true, 丛丆与丆丞丏丅万丅:  true);
            goto label_27;
            label_30:
            if((this.Parameter.丒世业三丘丝不下丕() == true) || ((this.Parameter.丁且且丐不丝丐下丘().Count + this.Parameter.万丐丘丟丂丛丂丈万().Count) >= this.Parameter.Count))
            {
                goto label_39;
            }
            
            if(this.丗下丘世三七一专丕 != 2)
            {
                    this.丗下丘世三七一专丕 = 2;
                this.丕丕业七丙七丅丈丄();
            }
            
            List.Enumerator<T> val_36 = val_11.GetEnumerator();
            label_48:
            if(((-454829840) & 1) == 0)
            {
                goto label_42;
            }
            
            string val_37 = val_23.丐丏七丌丕丗业且上();
            val_37.SetBack(丏专丒丙丟且丈万七:  丆且丁丒丒丆丁三丆);
            if(val_37 == null)
            {
                goto label_46;
            }
            
            val_37.SetHiddenBackVisible(下下东且万业丞丅丒:  false, 丛丆与丆丞丏丅万丅:  true);
            val_37.SetFrontActive(丏业丟一东丂东丘丛:  true, 丛丆与丆丞丏丅万丅:  true);
            goto label_48;
            label_46:
            val_37.SetHiddenBackVisible(下下东且万业丞丅丒:  true, 丛丆与丆丞丏丅万丅:  true);
            val_37.SetFrontActive(丏业丟一东丂东丘丛:  false, 丛丆与丆丞丏丅万丅:  true);
            goto label_48;
            label_39:
            if(this.丗下丘世三七一专丕 == 4)
            {
                goto label_60;
            }
            
            this.丗下丘世三七一专丕 = 4;
            this.丕丕业七丙七丅丈丄();
            goto label_60;
            label_42:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_60:
            System.Action<Rilisoft.GameEventItemData> val_38 = null;
            val_44 = 1152921542806700672;
            val_38 = new System.Action<Rilisoft.GameEventItemData>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentTap::丟下丙世丙丟丙丄专(Rilisoft.GameEventItemData 丏专丕万丘丝与万三));
            this._mostExpensiveView.remove_OnItemClicked(丙业与丙丗丝不丈东:  val_38);
            System.Action<Rilisoft.GameEventItemData> val_39 = null;
            val_45 = val_39;
            val_39 = new System.Action<Rilisoft.GameEventItemData>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentTap::丟下丙世丙丟丙丄专(Rilisoft.GameEventItemData 丏专丕万丘丝与万三));
            this._mostExpensiveView.add_OnItemClicked(丙业与丙丗丝不丈东:  val_39);
        }
        private void 丟下丙世丙丟丙丄专(Rilisoft.GameEventItemData 丏专丕万丘丝与万三)
        {
            if(this.__InterfaceEnabled == false)
            {
                    return;
            }
            
            this.ShowAsInfo(一丐丗丁丞丆丅丟丄:  丏专丕万丘丝与万三);
        }
        public override void ShowWindow()
        {
            this.ShowWindow();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._touchBlocker, 丏业丟一东丂东丘丛:  false);
            this._chestCompleteView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentTap::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
            this._chestCompleteView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentTap::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
        }
        public override void HideWindow()
        {
            this.丗下丘世三七一专丕 = 0;
            this.HideWindow();
            this._chestCompleteView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetsChestCompleteView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentTap::七丝专丝与上丄丁东(Rilisoft.GameEventSetsChestCompleteView 万且万且丑丗且丌丆)));
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
            
            System.Nullable<System.DateTime> val_3 = this.Parameter.丐丈丅丅世三七七丝();
            if(((-453941072) & 1) != 0)
            {
                    return;
            }
            
            System.TimeSpan val_5 = this.Parameter.世丙不业丛丂东万丈();
            if(val_5._ticks.TotalSeconds <= 0f)
            {
                    return;
            }
            
            System.Nullable<System.TimeSpan> val_8 = this.Parameter.七丆丄丟丟丕三上上();
            if(((-453941096) & 1) == 0)
            {
                    return;
            }
            
            System.Nullable<System.TimeSpan> val_10 = this.Parameter.七丆丄丟丟丕三上上();
            if(val_10.HasValue.TotalSeconds >= 0)
            {
                    return;
            }
            
            if(this.丅丂丑丂不丛专世东 != null)
            {
                    return;
            }
            
            if(Rilisoft.GameEventGuiSets.东东丒不下丆世业不() == true)
            {
                    return;
            }
            
            Rilisoft.与专丒丞丐一丒丂东 val_13 = this.Parameter;
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
                goto typeof(Rilisoft.GameEventSetsViewChestContentTap).__il2cppRuntimeField_258;
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
            var val_39;
            var val_40;
            var val_43;
            if(this.且下万丐丞东丈万丈 == null)
            {
                    return;
            }
            
            if(this.Parameter == null)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.Int32> val_3 = this.Parameter.丗七丂不丈丈丂丟丑();
            Rilisoft.与专丒丞丐一丒丂东 val_4 = this.Parameter;
            if(val_4 == null)
            {
                    return;
            }
            
            if(val_4.Count != this.且下万丐丞东丈万丈.Count)
            {
                    object[] val_7 = new object[3];
                val_7[0] = this.且下万丐丞东丈万丈.Count;
                val_7[1] = this.Parameter.丅丙丛丑丌丆丌丕丒();
                val_7[2] = val_4.Count;
                UnityEngine.Debug.LogErrorFormat(format:  "slots in roll: {0}, containers in chest \'{1}\': {2}", args:  val_7);
            }
            
            val_39 = 1152921542788134336;
            val_40 = 0;
            goto label_22;
            label_60:
            Rilisoft.GameEventSetItemView val_12 = this.且下万丐丞东丈万丈.Item[0];
            if(val_40 > (val_4.Count - 1))
            {
                goto label_24;
            }
            
            Rilisoft.GameEventItemContainer val_15 = val_4.Item[0];
            if(val_15.AvailableToDropItems.Count != 0)
            {
                    if((this.Parameter.丁且且丐不丝丐下丘().Contains(item:  val_15.Id)) == false)
            {
                goto label_31;
            }
            
            }
            
            if(val_12 != null)
            {
                goto label_57;
            }
            
            label_58:
            label_57:
            UnityEngine.Vector3 val_24 = this.丑丗丂丙下丏丟丈丏.Item[0];
            val_12.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            Rilisoft.GameEventItem val_26 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_15.AllItems);
            int val_27 = val_15.Id;
            if((val_12 == null) || (3 != 0))
            {
                goto label_42;
            }
            
            val_43 = null;
            val_43 = null;
            goto label_47;
            label_31:
            if((this.丗下丘世三七一专丕 != 1) || ((this.专丟丄丟东一丆上且.Contains(item:  val_15.Id)) == false))
            {
                goto label_51;
            }
            
            if(val_12 != null)
            {
                goto label_57;
            }
            
            goto label_58;
            label_51:
            System.Collections.Generic.List<System.Int32> val_39 = this.Parameter.万丐丘丟丂丛丂丈万();
            val_39 = val_39.Contains(item:  val_15.Id);
            if(val_12 != null)
            {
                goto label_57;
            }
            
            goto label_58;
            label_47:
            SetBack(丏专丒丙丟且丈万七:  this.Parameter);
            label_42:
            val_12.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentTap::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)));
            val_12.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewChestContentTap::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)));
            val_39 = 1152921542788134336;
            label_24:
            val_40 = 1;
            label_22:
            if(val_40 < this.且下万丐丞东丈万丈.Count)
            {
                goto label_60;
            }
        
        }
        private void 丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)
        {
            Rilisoft.GameEventSetItemView val_14;
            UnityEngine.Object val_15;
            val_14 = 丁世丛业丟下丕三丟;
            val_15 = this;
            .丁世丛业丟下丕三丟 = val_14;
            if(this.Parameter == null)
            {
                    return;
            }
            
            val_14 = this.Parameter;
            ButtonClickSound.丁业上丏不丕三丗不();
            if(this.丗下丘世三七一专丕 != 1)
            {
                goto label_4;
            }
            
            if((System.Linq.Enumerable.All<Rilisoft.GameEventItemContainer>(source:  val_14, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  new GameEventSetsViewChestContentTap.且不丘丝丕业下万一(), method:  System.Boolean GameEventSetsViewChestContentTap.且不丘丝丕业下万一::丄万且与丅丕专丛东(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)))) == true)
            {
                    return;
            }
            
            val_14 = this.专丟丄丟东一丆上且;
            if((this.专丟丄丟东一丆上且.Contains(item:  (GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟._containerId)) == false)
            {
                goto label_8;
            }
            
            bool val_7 = val_14.Remove(item:  (GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟._containerId);
            goto label_24;
            label_4:
            val_14 = (GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟;
            if(val_14 == null)
            {
                goto label_13;
            }
            
            if((GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟 == null)
            {
                goto label_14;
            }
            
            label_16:
            this.与丈不丟丄三七丗上(丝丑丏七业上且三丈:  (GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟.<丅丝丌丝丁丏丙东丞>k__BackingField);
            return;
            label_13:
            if((GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟 != null)
            {
                goto label_16;
            }
            
            label_14:
            this.且丐七丐专万丟丑丐 = (GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟._containerId;
            val_15 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_15 == 0)
            {
                    return;
            }
            
            val_15 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_15 != null)
            {
                    return;
            }
            
            return;
            label_8:
            val_14 = val_14.Count;
            Rilisoft.丝丑丂丛万丐丈丘且 val_13 = this.Parameter.万丝世丘丞东万丟万();
            if(val_14 < )
            {
                    val_14 = (GameEventSetsViewChestContentTap.且不丘丝丕业下万一)[1152921542808737920].丁世丛业丟下丕三丟._containerId;
                this.专丟丄丟东一丆上且.Add(item:  val_14);
            }
            
            label_24:
            this.丕丕业七丙七丅丈丄();
        }
        private System.Collections.IEnumerator 丆丈专丁丆世上丑丏(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟, System.Action 丟丘丙丄丅万丏与丗)
        {
            GameEventSetsViewChestContentTap.丛丁丝丄丕专与丘专 val_1 = new GameEventSetsViewChestContentTap.丛丁丝丄丕专与丘专(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 丁世丛业丟下丕三丟;
            }
            
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
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
            this.丅丂丑丂不丛专世东 = 0;
        }
        private void 且七三丏不专一丙丐()
        {
            var val_18;
            System.Collections.Generic.List<System.Int32> val_36;
            var val_37;
            System.Action val_39;
            if(this.Parameter == null)
            {
                    return;
            }
            
            val_36 = this.Parameter;
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = val_36.万丝世丘丞东万丟万();
            if(this.专丟丄丟东一丆上且.Count < (-452175312))
            {
                    return;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = this.Parameter.万丝世丘丞东万丟万();
            if(this.专丟丄丟东一丆上且.Count > (-452175312))
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_9 = this.Parameter.万丝世丘丞东万丟万();
                this.专丟丄丟东一丆上且 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Take<System.Int32>(source:  this.专丟丄丟东一丆上且, count:  -452175312));
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丙东丗丏丏丑丗丄丁(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丒业七丒丞丁万丝丐:  this.专丟丄丟东一丆上且);
            val_36 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.专丟丄丟东一丆上且);
            this.Parameter.丄三丏丏丆专丟上丛(丄丗丙东丌且不丕丘:  val_36);
            this.Parameter.丗丄丐万丏业丏丑万();
            List.Enumerator<T> val_16 = this.专丟丄丟东一丆上且.GetEnumerator();
            label_26:
            if(((-452175344) & 1) == 0)
            {
                goto label_16;
            }
            
            new GameEventSetsViewChestContentTap.丆世丒一丈专丆丆七() = new System.Object();
            .丒丁东世世丗丅丅丄 = val_18.丙东专丂世丈丏丁丂();
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_22 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  new GameEventSetsViewChestContentTap.丆世丒一丈专丆丆七(), method:  System.Boolean GameEventSetsViewChestContentTap.丆世丒一丈专丆丆七::丛丝上万丁丝丒与丅(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
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
            Rilisoft.一丟专且三万丞丁丂.与三丒东且与丏丘三(且丆丂丂丞不下七丘:  this.Parameter.丅三专且丈一丝丂丏(), 丞一丁业丄一一业且:  val_25.Data.Id, 丌丒丝东丌下丕丁丅:  -452175312);
            goto label_26;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.丗下丘世三七一专丕 != 2)
            {
                    this.丗下丘世三七一专丕 = 2;
                this.丕丕业七丙七丅丈丄();
            }
            
            val_37 = null;
            val_37 = null;
            val_39 = GameEventSetsViewChestContentTap.<>c.<>9__43_0;
            if(val_39 == null)
            {
                    System.Action val_32 = null;
                val_39 = val_32;
                val_32 = new System.Action(object:  GameEventSetsViewChestContentTap.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventSetsViewChestContentTap.<>c::丗丞丒三与下丆丘丙());
                GameEventSetsViewChestContentTap.<>c.<>9__43_0 = val_39;
            }
            
            if(this.丂丄丄丘丐一三丐丁 != null)
            {
                    this.StopCoroutine(routine:  this.丂丄丄丘丐一三丐丁);
            }
            
            this.丂丄丄丘丐一三丐丁 = this.StartCoroutine(routine:  this.丟世丗丙丆丞且万万(丟丘丙丄丅万丏与丗:  val_32));
        }
        private System.Collections.IEnumerator 丟世丗丙丆丞且万万(System.Action 丟丘丙丄丅万丏与丗)
        {
            GameEventSetsViewChestContentTap.丈一业下专丌丕七专 val_1 = new GameEventSetsViewChestContentTap.丈一业下专丌丕七专();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
            return (System.Collections.IEnumerator)val_1;
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
            GameEventSetsViewChestContentTap.丈丞丕丘丄丐且丈丂 val_1 = null;
            val_19 = val_1;
            val_1 = new GameEventSetsViewChestContentTap.丈丞丕丘丄丐且丈丂();
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
            
            if((GameEventSetsViewChestContentTap.丈丞丕丘丄丐且丈丂)[1152921542809860480].丑丆丕七丂不丙丞丂 != false)
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
            val_7 = new System.Action(object:  val_1, method:  System.Void GameEventSetsViewChestContentTap.丈丞丕丘丄丐且丈丂::丘东丂不丑一东不三());
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() == false)
            {
                goto label_10;
            }
            
            val_22 = (GameEventSetsViewChestContentTap.丈丞丕丘丄丐且丈丂)[1152921542809860480].三丝专与万丟上丘下.与丒上与丄丒丝三七();
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_22, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                goto label_13;
            }
            
            label_10:
            val_19 = (GameEventSetsViewChestContentTap.丈丞丕丘丄丐且丈丂)[1152921542809860480].三丝专与万丟上丘下;
            val_23 = null;
            val_23 = null;
            val_25 = GameEventSetsViewChestContentTap.<>c.<>9__45_1;
            if(val_25 == null)
            {
                    System.Action val_14 = null;
                val_25 = val_14;
                val_14 = new System.Action(object:  GameEventSetsViewChestContentTap.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventSetsViewChestContentTap.<>c::上丟七丏七一丅丑丅());
                GameEventSetsViewChestContentTap.<>c.<>9__45_1 = val_25;
            }
            
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_19, 七丒上且丝业业下七:  val_7, 丝丏丗丄丗与丐丌三:  val_14, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  86);
            return;
            label_13:
            UnityEngine.Debug.LogError(message:  "GameEvents Reset (not enough currency) -> GoToMainStore");
            val_19 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
            val_19.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  (GameEventSetsViewChestContentTap.丈丞丕丘丄丐且丈丂)[1152921542809860480].三丝专与万丟上丘下.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
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
            var val_9;
            UnityEngine.GameObject val_32;
            且世丈业丘丆不上丄 val_33;
            var val_34;
            UnityEngine.GameObject val_35;
            float val_36;
            var val_37;
            val_32 = this;
            if(true == 0)
            {
                    return;
            }
            
            if(this.Parameter == null)
            {
                    return;
            }
            
            this._excludeChestsView.HideWindow();
            this._mostExpensiveView.HideWindow();
            if(this._spinButtonView != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._spinButtonView.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._resetExcludesGameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._resetChestGameObject, 丏业丟一东丂东丘丛:  false);
            this._chestCompleteView.HideWindow();
            val_33 = this.丗下丘世三七一专丕;
            if(val_33 != 1)
            {
                goto label_14;
            }
            
            this._excludeChestsView.Setup(与且专丈不万东一万:  this.Parameter, 丆且丁丒丒丆丁三丆:  this.专丟丄丟东一丆上且);
            this._excludeChestsView.ShowWindow();
            List.Enumerator<T> val_7 = System.Linq.Enumerable.ToList<Rilisoft.GameEventSetItemTwoSidedView>(source:  System.Linq.Enumerable.Cast<Rilisoft.GameEventSetItemTwoSidedView>(source:  this.且下万丐丞东丈万丈)).GetEnumerator();
            goto label_18;
            label_21:
            string val_10 = val_9.丐丏七丌丕丗业且上();
            mem2[0] = 257;
            label_18:
            if(((-450769392) & 1) != 0)
            {
                goto label_21;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_48;
            label_14:
            if( == 4)
            {
                goto label_26;
            }
            
            if( == 3)
            {
                goto label_43;
            }
            
            if( != 2)
            {
                goto label_48;
            }
            
            if(this._spinButtonView != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._spinButtonView.gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this.Parameter.丟丝与丙东世丗丞与() == 0)
            {
                goto label_36;
            }
            
            val_34 = null;
            val_35 = this._resetChestGameObject;
            goto label_45;
            label_26:
            this._chestCompleteView.Setup(与且专丈不万东一万:  this.Parameter);
            this._chestCompleteView.ShowWindow();
            goto label_48;
            label_36:
            Rilisoft.丝丑丂丛万丐丈丘且 val_17 = this.Parameter.万丝世丘丞东万丟万();
            if((-450769408) < 1)
            {
                goto label_43;
            }
            
            val_34 = null;
            val_35 = this._resetExcludesGameObject;
            label_45:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_35, 丏业丟一东丂东丘丛:  true);
            label_43:
            if(this._mostExpensiveView != 0)
            {
                    this._mostExpensiveView.ShowWindow();
                this._mostExpensiveView.Setup(与且专丈不万东一万:  this._mostExpensiveView, 丆且丁丒丒丆丁三丆:  this.Parameter);
            }
            
            label_48:
            if(this._resetExcludesGameObject.activeSelf != false)
            {
                    val_36 = -274f;
            }
            else
            {
                    var val_22 = (this._resetChestGameObject.activeSelf != true) ? -274f : -362f;
            }
            
            UnityEngine.Vector3 val_25 = this._playerGotNotif.transform.localPosition;
            UnityEngine.Vector3 val_27 = this._playerGotNotif.transform.localPosition;
            val_9 = 0;
            this._playerGotNotif.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丗七万世万丙万丅丒();
            this.不丝丗东丌丁丅丗丒();
            this.丑丌丅丗世丏丄丆万();
            if(this._spinButtonNotif == 0)
            {
                    return;
            }
            
            Rilisoft.与专丒丞丐一丒丂东 val_29 = this.Parameter;
            if(val_29 != null)
            {
                    val_37 = val_29.丐七丒丏下上丂丁丗();
            }
            else
            {
                    val_37 = 0;
            }
            
            val_32 = this._spinButtonNotif;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32, 丏业丟一东丂东丘丛:  val_37 & 1);
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
            if(((-450415648) & 1) == 0)
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
            if(((-450415648) & 1) == 0)
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
        public GameEventSetsViewChestContentTap()
        {
            this.专丟丄丟东一丆上且 = new System.Collections.Generic.List<System.Int32>();
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
