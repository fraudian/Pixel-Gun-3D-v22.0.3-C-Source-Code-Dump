using UnityEngine;

namespace PGCompany
{
    internal class GameTaskView : MonoBehaviour
    {
        // Fields
        private int _devPercentForIncrementProgress;
        internal Rilisoft.OfferItemType rewardTypeToShow;
        private PGCompany.世丐下丕专东丘丏且 与世七丑丂专专丌丙;
        private System.Collections.Generic.List<PGCompany.InventoryItemView> 与丘丆丑且丛丒丞丁;
        private System.Nullable<UnityEngine.Color> 丂万丆七丁且丏丗丂;
        private UILabel _descriptionLabel;
        private UIButton _rewardButton;
        private UnityEngine.GameObject _mark;
        private UIGrid _gridRewards;
        private PGCompany.InventoryItemView _rewardViewExapmle;
        private PGCompany.ProgressBarView _progressBarView;
        
        // Methods
        internal void 业不丝丄丙丌丌丈丄(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, System.Nullable<UnityEngine.Color> 丂万丆七丁且丏丗丂)
        {
            this.与世七丑丂专专丌丙 = 万不且且丛丆东丒业;
            mem[1152921555463822720] = 丂万丆七丁且丏丗丂.HasValue + 16;
            this.丂万丆七丁且丏丗丂 = 丂万丆七丁且丏丗丂;
        }
        internal void 丝一丅丆三东丂丞七()
        {
            uint32_t val_17;
            System.Nullable<UnityEngine.Color> val_18;
            object val_26;
            var val_27;
            var val_28;
            System.Action<PGCompany.InventoryItemView> val_30;
            val_26 = this;
            if(this.与世七丑丂专专丌丙 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._descriptionLabel, 丕丗丘丑丛与丑业丒:  this.与世七丑丂专专丌丙);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rewardButton, 丏业丟一东丂东丘丛:  this.与世七丑丂专专丌丙.不一丅丂上丁丈三下());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mark, 丏业丟一东丂东丘丛:  this.与世七丑丂专专丌丙.丞专丅丁丁三丄上专());
            val_27 = 1152921505604022272;
            val_28 = null;
            val_28 = null;
            val_30 = GameTaskView.<>c.<>9__6_0;
            if(val_30 == null)
            {
                goto label_8;
            }
            
            label_31:
            this.与丘丆丑且丛丒丞丁.ForEach(action:  val_30);
            if(this._rewardViewExapmle == 0)
            {
                goto label_46;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rewardViewExapmle, 丏业丟一东丂东丘丛:  false);
            val_27 = this.与世七丑丂专专丌丙.丈丏丁东上与东丙丕();
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.InventoryItemView>(专下丐丒丈万丗丟丝:  this.与丘丆丑且丛丒丞丁, 专丑业丁丗丏丌不丛:  this._rewardViewExapmle.gameObject, 丈东丘丏与丌东东下:  this._gridRewards.transform, 与业丄丂丂丆下上丞:  val_27.Count, 丏东下下一丗专下丏:  0);
            val_30 = this.rewardTypeToShow;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_10 = this.与世七丑丂专专丌丙.丈丏丁东上与东丙丕();
            if(val_30 == 0)
            {
                goto label_20;
            }
            
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_11 = null;
            val_30 = val_11;
            val_11 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  this, method:  System.Boolean PGCompany.GameTaskView::一丄丒丞丒丟一丆万(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            PGCompany.三东丏不丗世丅丌丄 val_12 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_10, predicate:  val_11);
            if(val_12 == null)
            {
                goto label_46;
            }
            
            val_30 = this.与丘丆丑且丛丒丞丁.Item[0];
            val_30.Setup(丈丄不七三万丄丁不:  val_12);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.与丘丆丑且丛丒丞丁.Item[0], 丏业丟一东丂东丘丛:  true);
            goto label_46;
            label_8:
            GameTaskView.<>c.<>9__6_0 = new System.Action<PGCompany.InventoryItemView>(object:  GameTaskView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameTaskView.<>c::丕丝丞东业丕东且丟(PGCompany.InventoryItemView 三丟东丕丄丄下下丑));
            if(this.与丘丆丑且丛丒丞丁 != null)
            {
                goto label_31;
            }
            
            goto label_31;
            label_20:
            List.Enumerator<T> val_16 = val_10.GetEnumerator();
            val_27 = 1152921525631263872;
            goto label_33;
            label_39:
            this.与丘丆丑且丛丒丞丁.Item[0].Setup(丈丄不七三万丄丁不:  val_18.丐丏七丌丕丗业且上());
            val_30 = this.与丘丆丑且丛丒丞丁.Item[0];
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_30, 丏业丟一东丂东丘丛:  true);
            label_33:
            if(((-682382496) & 1) != 0)
            {
                goto label_39;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_46:
            if(this._progressBarView == 0)
            {
                    return;
            }
            
            val_30 = this.与世七丑丂专专丌丙.且丆丟业丞丕丑上且();
            val_17 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            val_18 = this.丂万丆七丁且丏丗丂;
            this._progressBarView.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)val_30, 七丝东丛东丝且丆不:  (float)this.与世七丑丂专专丌丙.丁丝丞与丟与丟丌三(), 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
        }
        public void U_GiveReward()
        {
            this.三丛丁丆东世丁丏三();
        }
        private void 三丛丁丆东世丁丏三()
        {
            if(this.与世七丑丂专专丌丙 == null)
            {
                    return;
            }
            
            if(this.与世七丑丂专专丌丙.不一丅丂上丁丈三下() == false)
            {
                    return;
            }
            
            this.与世七丑丂专专丌丙.三丛丁丆东世丁丏三();
        }
        public void U_DevComplete()
        {
        
        }
        public void U_DevIncrement()
        {
        
        }
        public GameTaskView()
        {
            this._devPercentForIncrementProgress = 50;
            this.与丘丆丑且丛丒丞丁 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
        }
        private bool 一丄丒丞丒丟一丆万(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑)
        {
            return (bool)(三丟东丕丄丄下下丑.不业丙丒丂丞下丆丙() == this.rewardTypeToShow) ? 1 : 0;
        }
    
    }

}
