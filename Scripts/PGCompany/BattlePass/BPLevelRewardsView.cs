using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPLevelRewardsView : MonoBehaviour, 七丌且丛万与丞世丁<System.Collections.Generic.List<PGCompany.BattlePass.BPReward>, int>, 万丟丞不世丛七一专<PGCompany.BattlePass.BPLevelRewardsView>
    {
        // Fields
        private const string 上不丑与丄丐下七七 = "NguiWindows/BattlePass/BPGetRewardAnimSimple";
        private const string 专下丑万丝世七丄丆 = "NguiWindows/BattlePass/BPGetRewardAnimPaid";
        private int 世丝丞七丅丝丄与三;
        public bool AvailableByLevel;
        public int wrapidx;
        private PGCompany.BattlePass.BPRewardView <丞丗一丙与丌世丐丏>k__BackingField;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPReward> <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Action<PGCompany.BattlePass.BPLevelRewardsView> 丅丕丌丛万丂丈七与;
        private PGCompany.BattlePass.BPRewardView _topCell;
        private PGCompany.BattlePass.BPRewardView _bottomCell;
        private UIBasicSprite _bottomTexture;
        
        // Properties
        public PGCompany.BattlePass.BPRewardView 万下不丐上丂且丑东 { get; set; }
        public PGCompany.BattlePass.BPReward 丁七丒七丕万丛丕丙 { get; set; }
        public PGCompany.BattlePass.BPRewardView 与丟不丐且一丐丅万 { get; set; }
        public System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 丄丄一丐东丐丝丗七 { get; set; }
        public int 丌且丝丘丌丕东丒与 { get; set; }
        
        // Methods
        public PGCompany.BattlePass.BPRewardView get_SelectedView()
        {
            var val_3;
            var val_4;
            val_3 = this;
            if(this._topCell.IsSelected == true)
            {
                    return (PGCompany.BattlePass.BPRewardView)val_4;
            }
            
            val_3 = 1152921560130182696;
            if(this._bottomCell.IsSelected != false)
            {
                    return (PGCompany.BattlePass.BPRewardView)val_4;
            }
            
            val_4 = 0;
            return (PGCompany.BattlePass.BPRewardView)val_4;
        }
        public void set_SelectedView(PGCompany.BattlePass.BPRewardView 丙业与丙丗丝不丈东)
        {
            PGCompany.BattlePass.BPRewardView val_3 = this._topCell;
            val_3 = UnityEngine.Object.op_Equality(x:  丙业与丙丗丝不丈东, y:  val_3);
            this._topCell.IsSelected = val_3;
            PGCompany.BattlePass.BPRewardView val_4 = this._bottomCell;
            val_4 = UnityEngine.Object.op_Equality(x:  丙业与丙丗丝不丈东, y:  val_4);
            this._bottomCell.IsSelected = val_4;
        }
        public PGCompany.BattlePass.BPReward get_SelectedViewWithReward()
        {
            PGCompany.BattlePass.BPReward val_3;
            if(this._topCell.IsSelected == false)
            {
                goto label_1;
            }
            
            if(this._topCell == null)
            {
                goto label_2;
            }
            
            label_6:
            val_3 = this._topCell.<丅丝丌丝丁丏丙东丞>k__BackingField;
            return (PGCompany.BattlePass.BPReward)val_3;
            label_1:
            if(this._bottomCell.IsSelected == false)
            {
                goto label_5;
            }
            
            if(this._bottomCell != null)
            {
                goto label_6;
            }
            
            label_2:
            label_5:
            val_3 = 0;
            return (PGCompany.BattlePass.BPReward)val_3;
        }
        public void set_SelectedViewWithReward(PGCompany.BattlePass.BPReward 丙业与丙丗丝不丈东)
        {
            PGCompany.BattlePass.BPReward val_3;
            PGCompany.BattlePass.BPReward val_4;
            if(this._topCell != null)
            {
                    val_3 = this._topCell.<丅丝丌丝丁丏丙东丞>k__BackingField;
            }
            else
            {
                    val_3 = 4194311;
            }
            
            this._topCell.IsSelected = (val_3 == 丙业与丙丗丝不丈东) ? 1 : 0;
            if(this._bottomCell != null)
            {
                    val_4 = this._bottomCell.<丅丝丌丝丁丏丙东丞>k__BackingField;
            }
            else
            {
                    val_4 = 4194311;
            }
            
            this._bottomCell.IsSelected = (val_4 == 丙业与丙丗丝不丈东) ? 1 : 0;
        }
        public PGCompany.BattlePass.BPRewardView get_LastClickedView()
        {
            return (PGCompany.BattlePass.BPRewardView)this.<丞丗一丙与丌世丐丏>k__BackingField;
        }
        private void 一上丁丏丂丏丗丛世(PGCompany.BattlePass.BPRewardView 丙业与丙丗丝不丈东)
        {
            this.<丞丗一丙与丌世丐丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.List<PGCompany.BattlePass.BPReward> get_Context()
        {
            return (System.Collections.Generic.List<PGCompany.BattlePass.BPReward>)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public int get_Parameter()
        {
            return (int)this.世丝丞七丅丝丄与三;
        }
        public void set_Parameter(int 丙业与丙丗丝不丈东)
        {
            this.世丝丞七丅丝丄与三 = 丙业与丙丗丝不丈东;
            this.丕丕业七丙七丅丈丄();
        }
        public void Setup(System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 与且专丈不万东一万, int 丆且丁丒丒丆丁三丆)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.世丝丞七丅丝丄与三 = 丆且丁丒丒丆丁三丆;
            this.丕丕业七丙七丅丈丄();
        }
        public void add_Clicked(System.Action<PGCompany.BattlePass.BPLevelRewardsView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560131582616);
        
        }
        public void remove_Clicked(System.Action<PGCompany.BattlePass.BPLevelRewardsView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560131719192);
        
        }
        public bool IsMySubView(PGCompany.BattlePass.BPRewardView 丏专丄东丝丝且丅上)
        {
            PGCompany.BattlePass.BPRewardView val_3;
            var val_4;
            if(丏专丄东丝丝且丅上 != 0)
            {
                    val_3 = this._topCell;
                if(val_3 != 丏专丄东丝丝且丅上)
            {
                    return UnityEngine.Object.op_Equality(x:  this._bottomCell, y:  丏专丄东丝丝且丅上);
            }
            
                val_4 = 1;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public bool IsMySubView(PGCompany.BattlePass.BPReward 丗七丟丈三不丕一三)
        {
            var val_2;
            if(丗七丟丈三不丕一三 == null)
            {
                goto label_0;
            }
            
            if((this._topCell.<丅丝丌丝丁丏丙东丞>k__BackingField) == 丗七丟丈三不丕一三)
            {
                goto label_2;
            }
            
            var val_1 = ((this._bottomCell.<丅丝丌丝丁丏丙东丞>k__BackingField) == 丗七丟丈三不丕一三) ? 1 : 0;
            return (bool)val_2;
            label_0:
            val_2 = 0;
            return (bool)val_2;
            label_2:
            val_2 = 1;
            return (bool)val_2;
        }
        private void Start()
        {
            this._topCell.RewardGettedPrefabPath = "NguiWindows/BattlePass/BPGetRewardAnimSimple";
            this._bottomCell.RewardGettedPrefabPath = "NguiWindows/BattlePass/BPGetRewardAnimPaid";
        }
        private void OnEnable()
        {
            this._bottomCell.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPLevelRewardsView::丟下丘专丂丘专丁七(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
            this._bottomCell.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPLevelRewardsView::丟下丘专丂丘专丁七(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
            this._topCell.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPLevelRewardsView::丟下丘专丂丘专丁七(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
            this._topCell.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPLevelRewardsView::丟下丘专丂丘专丁七(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)));
        }
        private void 丕丕业七丙七丅丈丄()
        {
            var val_22;
            PGCompany.BattlePass.BPReward val_23;
            PGCompany.BattlePass.BPReward val_24;
            int val_25;
            UIBasicSprite val_26;
            var val_27;
            System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_29;
            val_22 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count) >= 1)
            {
                    val_23 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Item[0];
            }
            else
            {
                    val_23 = 0;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count) >= 2)
            {
                    val_24 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Item[1];
            }
            else
            {
                    val_24 = 0;
            }
            
            this._topCell.<丅丝丌丝丁丏丙东丞>k__BackingField = val_23;
            this._topCell.丝一丅丆三东丂丞七();
            if(this.AvailableByLevel != false)
            {
                    val_25 = this.世丝丞七丅丝丄与三;
            }
            else
            {
                    val_25 = 0;
            }
            
            this._topCell.GroupSize = 0;
            this._bottomCell.<丅丝丌丝丁丏丙东丞>k__BackingField = val_24;
            this._bottomCell.丝一丅丆三东丂丞七();
            this._bottomCell.GroupSize = this.世丝丞七丅丝丄与三;
            val_26 = this._bottomTexture;
            if(val_26 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_9 = this._bottomTexture.gameObject;
            if(this.世丝丞七丅丝丄与三 > 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
                val_27 = null;
                val_27 = null;
                val_29 = BPLevelRewardsView.<>c.<>9__30_0;
                if(val_29 == null)
            {
                    System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_10 = null;
                val_29 = val_10;
                val_10 = new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  BPLevelRewardsView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPLevelRewardsView.<>c::丅丝不一三与丁丄下(PGCompany.BattlePass.BPReward 丁丂专业丁丅丅丈丙));
                BPLevelRewardsView.<>c.<>9__30_0 = val_29;
            }
            
                PGCompany.BattlePass.BPReward val_11 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPReward>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, predicate:  val_10);
                var val_12 = (val_11._forLevel > (Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().业丈丅丂且丁与丄丂())) ? 0.31f : 1f;
                val_22 = ???;
                val_26 = ???;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  false);
            }
        
        }
        private void 丟下丘专丂丘专丁七(PGCompany.BattlePass.BPRewardView 丁世丛业丟下丕三丟)
        {
            this.<丞丗一丙与丌世丐丏>k__BackingField = 丁世丛业丟下丕三丟;
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        public BPLevelRewardsView()
        {
        
        }
    
    }

}
