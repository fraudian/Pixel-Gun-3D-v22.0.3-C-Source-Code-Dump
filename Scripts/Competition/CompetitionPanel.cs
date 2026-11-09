using UnityEngine;

namespace Competition
{
    internal sealed class CompetitionPanel : PGBehaviour
    {
        // Fields
        internal static Competition.CompetitionPanel 丆丕丝丒不丙且丐丗;
        private UnityEngine.GameObject _holder;
        private UnityEngine.GameObject _holderDisabledState;
        private PGCompany.TimerUI _disableStateTimer;
        private EndlessScrollDynamic _endlessScroll;
        private System.Collections.Generic.List<Competition.东丟丕与丁不丐丕丐> 三丗且与丕业丈丁丒;
        private Competition.丘丏丑丂世丈世丌且 不丏丏丙七下业丒且;
        private Competition.CompetitionCell 丞丌一丂专丒丄万丐;
        private System.Collections.Generic.List<UIWidget> 上丂万一丞丕丐上丘;
        private System.Collections.Generic.List<Competition.CompetitionGroupPlayersCell> 丕丙丘下丁丏丐丕丛;
        private Competition.CompetitionRewardGluedCell _topGluedGameObject;
        private UIPanel _scrollPanel;
        private UnityEngine.Vector3[] 丅丑丗丗丑业不丝三;
        
        // Methods
        private void Awake()
        {
            if(Competition.CompetitionPanel.丆丕丝丒不丙且丐丗 != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this);
                return;
            }
            
            Competition.CompetitionPanel.丆丕丝丒不丙且丐丗 = this;
            this.丘上丐世丆丑且丞丒();
        }
        private void 丘上丐世丆丑且丞丒()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holderDisabledState, 丏业丟一东丂东丘丛:  false);
            this.丛且丐下世与丘丆丗();
        }
        private void 丂丌丑丒丐丁丐丈丅()
        {
            this.丅丑丗丗丑业不丝三 = System.Linq.Enumerable.ToArray<UnityEngine.Vector3>(source:  this._scrollPanel);
        }
        private void OnDestroy()
        {
            this.万与七三丄丁丏世丘();
        }
        private void 丛且丐下世与丘丆丗()
        {
            this._endlessScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void Competition.CompetitionPanel::不丟一丙上万东专丏(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
            this._endlessScroll.add_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Competition.CompetitionPanel::与三丆丛丗丑业万世()));
        }
        private void 万与七三丄丁丏世丘()
        {
            this._endlessScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void Competition.CompetitionPanel::不丟一丙上万东专丏(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
            this._endlessScroll.remove_onPanelMoving(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Competition.CompetitionPanel::与三丆丛丗丑业万世()));
        }
        private void 与三丆丛丗丑业万世()
        {
            this.东下三丅丁不丙不丏();
        }
        private void 东下三丅丁不丙不丏()
        {
            Competition.CompetitionGroupPlayersCell val_1 = this.三与丒丛丐且丁丏丗();
            this.丞业丕丟业万七与丘(丁丞丁丞丗丐丘丌丟:  val_1);
            this.不东丘专丄七丌丗七(丁丞丁丞丗丐丘丌丟:  val_1);
            this.丁丙丞东专丅与上丈(东下世丄丏丂丛下丄:  this.丒与丘与丞丙丏丁专(丙万丏丄丅与丒不丟:  val_1));
            this.七七丐丝且与丒丛丁(丁丞丁丞丗丐丘丌丟:  val_1);
        }
        private void 七七丐丝且与丒丛丁(Competition.CompetitionGroupPlayersCell 丁丞丁丞丗丐丘丌丟)
        {
            var val_4 = null;
            if((CompetitionPanel.<>c.<>9__21_0) == null)
            {
                goto label_3;
            }
            
            label_14:
            this.丕丙丘下丁丏丐丕丛.ForEach(action:  CompetitionPanel.<>c.<>9__21_0);
            if(丁丞丁丞丗丐丘丌丟 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丁丞丁丞丗丐丘丌丟._rewardContainerWidget, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UIWidget>(不丗上三丛丒上东丑:  丁丞丁丞丗丐丘丌丟.不丅丑丕丂丘东丌丑(), 丏业丟一东丂东丘丛:  false);
            return;
            label_3:
            CompetitionPanel.<>c.<>9__21_0 = new System.Action<Competition.CompetitionGroupPlayersCell>(object:  CompetitionPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CompetitionPanel.<>c::丙丒业丁与世且丞七(Competition.CompetitionGroupPlayersCell 三丟东丕丄丄下下丑));
            if(this.丕丙丘下丁丏丐丕丛 != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        private void 丁丙丞东专丅与上丈(Competition.CompetitionGroupPlayersCell 东下世丄丏丂丛下丄)
        {
            UnityEngine.Object val_25;
            var val_26;
            float val_27;
            float val_28;
            float val_29;
            var val_30;
            UnityEngine.Vector3[] val_31;
            val_25 = 0;
            if(东下世丄丏丂丛下丄 != val_25)
            {
                    if(null <= 1)
            {
                    val_26 = 0;
            }
            
                UnityEngine.Transform val_2 = this._topGluedGameObject.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_4 = val_2.position;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  S8 - S9);
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_2.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                UnityEngine.Transform val_8 = this._topGluedGameObject.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_9 = val_8.localPosition;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  (float)this._topGluedGameObject.widget.height);
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                val_27 = val_13.z;
                val_28 = val_13.y;
                val_29 = val_27;
                val_30 = 0;
                val_8.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_28, z = val_29};
                val_31 = this.丅丑丗丗丑业不丝三;
            }
            else
            {
                    val_31 = this;
                if(this.丅丑丗丗丑业不丝三.Length <= 1)
            {
                    val_25 = 0;
            }
            
                UnityEngine.Transform val_14 = this._topGluedGameObject.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_16 = val_14.position;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  this.丅丑丗丗丑业不丝三[1] - S9);
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                val_27 = val_19.z;
                val_28 = val_19.y;
                val_29 = val_27;
                val_30 = 0;
                val_14.position = new UnityEngine.Vector3() {x = val_19.x, y = val_28, z = val_29};
            }
            
            if(this.丅丑丗丗丑业不丝三.Length <= 1)
            {
                    val_30 = 0;
            }
            
            float val_26 = mem[this.丅丑丗丗丑业不丝三 + 48];
            val_26 = val_26 - val_19.x;
            if(val_26 <= 0f)
            {
                    return;
            }
            
            UnityEngine.Transform val_20 = this._topGluedGameObject.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_21 = val_20.position;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  val_26);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            val_20.position = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
        }
        private void 不东丘专丄七丌丗七(Competition.CompetitionGroupPlayersCell 丁丞丁丞丗丐丘丌丟)
        {
            var val_2;
            Competition.CompetitionRewardGluedCell val_3;
            if(丁丞丁丞丗丐丘丌丟 == 0)
            {
                    val_2 = 1152921505284374528;
                val_3 = this._topGluedGameObject;
            }
            else
            {
                    val_3 = this._topGluedGameObject;
                if(丁丞丁丞丗丐丘丌丟.专业丘丅一与丙七丂 != null)
            {
                    val_3.丈且东丑丂且万丒丅(丙丁丅丆万丟上东三:  丁丞丁丞丗丐丘丌丟.专业丘丅一与丙七丂);
                return;
            }
            
                val_2 = 1152921505284374528;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  false);
        }
        private void 丞业丕丟业万七与丘(Competition.CompetitionGroupPlayersCell 丁丞丁丞丗丐丘丌丟)
        {
            UnityEngine.Object val_2 = 0;
            val_2 = UnityEngine.Object.op_Inequality(x:  丁丞丁丞丗丐丘丌丟, y:  val_2);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._topGluedGameObject, 丏业丟一东丂东丘丛:  val_2);
        }
        private Competition.CompetitionGroupPlayersCell 丒与丘与丞丙丏丁专(Competition.CompetitionGroupPlayersCell 丙万丏丄丅与丒不丟)
        {
            var val_15;
            var val_16;
            System.Collections.Generic.List<UIWidget> val_17;
            var val_18;
            val_16 = this;
            val_17 = 0;
            if(丙万丏丄丅与丒不丟 == 0)
            {
                    return (Competition.CompetitionGroupPlayersCell)val_17;
            }
            
            val_17 = this.上丂万一丞丕丐上丘;
            if(val_17 == null)
            {
                    return (Competition.CompetitionGroupPlayersCell)val_17;
            }
            
            if((val_17.Count == 0) || (this.丅丑丗丗丑业不丝三 == null))
            {
                goto label_18;
            }
            
            val_18 = 0;
            val_15 = 0;
            goto label_7;
            label_17:
            UnityEngine.Transform val_4 = this.上丂万一丞丕丐上丘.Item[0].cachedTransform;
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            float val_15 = val_5.y;
            UnityEngine.Vector3 val_7 = val_4.cachedTransform.localPosition;
            val_15 = val_15 - val_7.y;
            float val_16 = System.Math.Abs(val_15);
            var val_8 = (val_15 < 0) ? 1 : 0;
            var val_9 = (val_16 < 0) ? 1 : 0;
            int val_10 = (val_8 != val_9) ? (val_18) : (val_15);
            var val_11 = (val_8 != val_9) ? (val_16) : 3.402823E+38f;
            val_18 = 1;
            label_7:
            if(val_18 < this.上丂万一丞丕丐上丘.Count)
            {
                goto label_17;
            }
            
            if(val_10 != 1)
            {
                    val_16 = this.上丂万一丞丕丐上丘.Item[val_10];
                Competition.CompetitionGroupPlayersCell val_14 = val_16.GetComponent<Competition.CompetitionGroupPlayersCell>();
                return (Competition.CompetitionGroupPlayersCell)val_17;
            }
            
            label_18:
            val_17 = 0;
            return (Competition.CompetitionGroupPlayersCell)val_17;
        }
        private Competition.CompetitionGroupPlayersCell 三与丒丛丐且丁丏丗()
        {
            var val_10;
            System.Collections.Generic.List<UIWidget> val_11;
            float val_12;
            var val_13;
            var val_14;
            val_10 = this;
            val_11 = this.上丂万一丞丕丐上丘;
            if(val_11 == null)
            {
                    return (Competition.CompetitionGroupPlayersCell)val_11;
            }
            
            if((val_11.Count == 0) || (this.丅丑丗丗丑业不丝三 == null))
            {
                goto label_13;
            }
            
            val_12 = 3.402823E+38f;
            val_13 = 0;
            val_14 = 0;
            goto label_4;
            label_12:
            UIWidget val_2 = this.上丂万一丞丕丐上丘.Item[0];
            UnityEngine.Vector3 val_10 = this.丅丑丗丗丑业不丝三[1];
            val_10 = S9 - val_10;
            var val_3 = (val_10 > 0f) ? 1 : 0;
            var val_4 = (val_10 < 0) ? 1 : 0;
            int val_5 = (val_3 != val_4) ? (val_13) : (val_14);
            var val_6 = (val_3 != val_4) ? (val_10) : (val_12);
            val_13 = 1;
            label_4:
            if(val_13 < this.上丂万一丞丕丐上丘.Count)
            {
                goto label_12;
            }
            
            if(val_5 != 1)
            {
                    val_10 = this.上丂万一丞丕丐上丘.Item[val_5];
                Competition.CompetitionGroupPlayersCell val_9 = val_10.GetComponent<Competition.CompetitionGroupPlayersCell>();
                return (Competition.CompetitionGroupPlayersCell)val_11;
            }
            
            label_13:
            val_11 = 0;
            return (Competition.CompetitionGroupPlayersCell)val_11;
        }
        private void OnEnable()
        {
            this.丟不丒丗丞一丙七丙();
            this.丂丌丑丒丐丁丐丈丅();
        }
        private void 丟不丒丗丞一丙七丙()
        {
            if(this.丞丌一丂专丒丄万丐 == 0)
            {
                    return;
            }
            
            this.丞丌一丂专丒丄万丐.SetAsPlayer();
            this.丞丌一丂专丒丄万丐.competitionPlayerCell.丂下不丘丑与业东与(不丆业丏上丐与丌业:  ProfileController.丆三丂丂丆上丆丕专());
        }
        internal void 与丌丑一丅世丈丄丏(int 丆丈丒与丄不丙丌与)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holderDisabledState, 丏业丟一东丂东丘丛:  true);
            this._disableStateTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  UnityEngine.Mathf.Clamp(value:  丆丈丒与丄不丙丌与 - PixelTime.丙丅丅业丟丁世丁丗(), min:  0, max:  2147483647), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        internal void 下与丞三丅丛丄七丕(System.Collections.Generic.List<Competition.东丟丕与丁不丐丕丐> 丐七且丕三世下丄丕)
        {
            UnityEngine.Object val_9;
            System.Collections.Generic.IEnumerable<T> val_10;
            var val_11;
            System.Func<EndlessScrollCellDynamic, UIWidget> val_13;
            val_9 = this;
            this.三丗且与丕业丈丁丒 = 丐七且丕三世下丄丕;
            val_10 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holderDisabledState, 丏业丟一东丂东丘丛:  false);
            if(this.三丗且与丕业丈丁丒 == null)
            {
                    return;
            }
            
            if(this.三丗且与丕业丈丁丒.Count == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
            this.一丗万丝不丛丅丐丒();
            this._endlessScroll.cellsCount = this.三丗且与丕业丈丁丒.Count;
            this._endlessScroll.Init(上专丅业三丏丈丈丗:  this.三丗且与丕业丈丁丒.Count, 丏丑丝万下与丁丞业:  0);
            this.上丂万一丞丕丐上丘.Clear();
            val_11 = null;
            val_11 = null;
            val_13 = CompetitionPanel.<>c.<>9__30_0;
            if(val_13 == null)
            {
                    System.Func<EndlessScrollCellDynamic, UIWidget> val_4 = null;
                val_13 = val_4;
                val_4 = new System.Func<EndlessScrollCellDynamic, UIWidget>(object:  CompetitionPanel.<>c.__il2cppRuntimeField_static_fields, method:  UIWidget CompetitionPanel.<>c::丞丘万丘专丁三上丈(EndlessScrollCellDynamic 三丟东丕丄丄下下丑));
                CompetitionPanel.<>c.<>9__30_0 = val_13;
            }
            
            this.上丂万一丞丕丐上丘.AddRange(collection:  System.Linq.Enumerable.Select<EndlessScrollCellDynamic, UIWidget>(source:  this._endlessScroll.cellsList, selector:  val_4));
            this.丕丙丘下丁丏丐丕丛.Clear();
            val_10 = System.Linq.Enumerable.OfType<Competition.CompetitionGroupPlayersCell>(source:  this._endlessScroll.cellsList);
            this.丕丙丘下丁丏丐丕丛.AddRange(collection:  val_10);
            this.丆丑丝丗一专丝丄丞();
            this._scrollPanel.Refresh();
            val_9 = this.GetComponent<UIPanel>();
            if(val_9 == 0)
            {
                    return;
            }
            
            val_9.Refresh();
        }
        private void 丆丑丝丗一专丝丄丞()
        {
            this._endlessScroll.scroll.ResetPosition();
            UnityEngine.Vector3 val_3 = this.丞丌一丂专丒丄万丐.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_4 = this._endlessScroll.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            float val_7 = System.Math.Abs(val_4.y);
            float val_6 = this._endlessScroll.scroll.panel.height;
            val_6 = val_6 * (-0.5f);
            val_7 = val_7 + val_6;
            this._endlessScroll.scroll.Restrict();
        }
        private void 一丗万丝不丛丅丐丒()
        {
            var val_5;
            var val_11;
            var val_12;
            val_11 = 0;
            val_12 = 0;
            goto label_1;
            label_23:
            if(this.三丗且与丕业丈丁丒.Item[0] == null)
            {
                goto label_3;
            }
            
            Competition.东丟丕与丁不丐丕丐 val_2 = this.三丗且与丕业丈丁丒.Item[0];
            List.Enumerator<T> val_3 = val_2.丏丕丏万丂丅丒丁丆.GetEnumerator();
            label_12:
            if((1957913424 & 1) == 0)
            {
                goto label_7;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if(((val_6 == null) || (null != null)) || ((System.String.op_Inequality(a:  val_6.m_stringLength, b:  FriendsController.不丝丕丒丂丆丘丙丙())) == true))
            {
                goto label_12;
            }
            
            this.不丏丏丙七下业丒且 = val_6;
            label_7:
            var val_11 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_11 != 1) && (111 == 111))
            {
                    var val_10 = 0;
                val_10 = val_10 ^ 0;
                val_11 = val_11 + val_10;
            }
            else
            {
                    if( != false)
            {
                    val_11 = 0;
            }
            
            }
            
            if(this.不丏丏丙七下业丒且 != null)
            {
                    return;
            }
            
            label_3:
            val_12 = 1;
            label_1:
            if(val_12 < this.三丗且与丕业丈丁丒.Count)
            {
                goto label_23;
            }
        
        }
        internal void 丗丟万丂丘丈专丄丂()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holderDisabledState, 丏业丟一东丂东丘丛:  false);
        }
        private void 不丟一丙上万东专丏(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
        {
            UnityEngine.Object val_5;
            if(丌丝万上丅丒一丈丘 != null)
            {
                    var val_1 = (null == null) ? 丌丝万上丅丒一丈丘 : 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5.丈且东丑丂且万丒丅(丙丁丅丆万丟上东三:  this.一丑且丙丗丁丈与不(丞世不丒下上上丝丑:  丌丝万上丅丒一丈丘.Index));
        }
        internal void 三丛七下业东丏丘丈(Competition.CompetitionCell 上丑丄丂丗丄一丙丁)
        {
            this.丞丌一丂专丒丄万丐 = 上丑丄丂丗丄一丙丁;
        }
        private Competition.东丟丕与丁不丐丕丐 一丑且丙丗丁丈与不(int 丞世不丒下上上丝丑)
        {
            System.Collections.Generic.List<Competition.东丟丕与丁不丐丕丐> val_4;
            var val_5;
            val_4 = this.三丗且与丕业丈丁丒;
            val_5 = 0;
            if((丞世不丒下上上丝丑 & 2147483648) != 0)
            {
                    return (Competition.东丟丕与丁不丐丕丐)val_5;
            }
            
            if(val_4.Count == 0)
            {
                    return (Competition.东丟丕与丁不丐丕丐)val_5;
            }
            
            val_4 = this.三丗且与丕业丈丁丒;
            if(val_4.Count > 丞世不丒下上上丝丑)
            {
                    Competition.东丟丕与丁不丐丕丐 val_3 = this.三丗且与丕业丈丁丒.Item[丞世不丒下上上丝丑];
                return (Competition.东丟丕与丁不丐丕丐)val_5;
            }
            
            val_5 = 0;
            return (Competition.东丟丕与丁不丐丕丐)val_5;
        }
        public CompetitionPanel()
        {
            this.上丂万一丞丕丐上丘 = new System.Collections.Generic.List<UIWidget>();
            this.丕丙丘下丁丏丐丕丛 = new System.Collections.Generic.List<Competition.CompetitionGroupPlayersCell>();
        }
    
    }

}
