using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPNextLevelRewardView : MonoBehaviour
    {
        // Fields
        private float _rotateTSeconds;
        private UnityEngine.GameObject _mainContainer;
        private UnityEngine.GameObject _nextRewardContainer;
        private UnityEngine.GameObject _dailyRewardContainer;
        private UnityEngine.GameObject _singleReward;
        private UnityEngine.GameObject _doubleRewards;
        private UICenterOnChild _centerOnChild;
        private UILabel _countDailyExpLabel;
        private PGCompany.BattlePass.BPRewardView 丈丄丏丆丕不丛丕丅;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPRewardView> 丗上与丑丙上专东世;
        private System.Collections.Generic.List<UnityEngine.GameObject> 丄七丗业丐万丁丆丄;
        private UnityEngine.Coroutine 丌东丛且丂丙世丅丆;
        
        // Methods
        private void Awake()
        {
            this.丈丄丏丆丕不丛丕丅 = this._singleReward.GetComponentInChildren<PGCompany.BattlePass.BPRewardView>();
            this.丗上与丑丙上专东世 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPRewardView>(source:  this._doubleRewards.GetComponentsInChildren<PGCompany.BattlePass.BPRewardView>(includeInactive:  true));
        }
        private void OnEnable()
        {
            if(this.丌东丛且丂丙世丅丆 != null)
            {
                    this.StopCoroutine(routine:  this.丌东丛且丂丙世丅丆);
                this.丌东丛且丂丙世丅丆 = 0;
            }
            
            this.丆丒专七丌业丂丙丗();
            PGCompany.BattlePass.上丕丁专三丗丝万丆.丄丁丁丟万不丄七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPNextLevelRewardView::丆丒专七丌业丂丙丗()));
        }
        private void 丆丒专七丌业丂丙丗()
        {
            var val_31;
            var val_32;
            var val_33;
            UnityEngine.GameObject val_34;
            bool val_35;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                goto label_2;
            }
            
            this.丄七丗业丐万丁丆丄.Clear();
            val_31 = 1152921519068975536;
            this.丄七丗业丐万丁丆丄.Add(item:  this._mainContainer);
            int val_4 = val_2.业丈丅丂且丁与丄丂() + 1;
            System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  val_2.业下丈丕丙丁东世丙(上丌丆丁丟上下专丁:  new System.Nullable<PlayerPaymentState>() {HasValue = false}, 丈丘丝一丗下丈丐不:  new System.Nullable<System.Int32>() {HasValue = false}, 不丝丟与丟丈一三与:  false));
            if(val_6.Count < 1)
            {
                goto label_6;
            }
            
            val_32 = (~val_2.丗丄上丑丑丅丐丒丌()) & 1;
            goto label_7;
            label_2:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nextRewardContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._dailyRewardContainer, 丏业丟一东丂东丘丛:  false);
            return;
            label_6:
            val_32 = 0;
            label_7:
            val_33 = 1152921505284374528;
            val_34 = this._nextRewardContainer;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_34, 丏业丟一东丂东丘丛:  false);
            if(val_32 == 0)
            {
                goto label_32;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._singleReward, 丏业丟一东丂东丘丛:  (val_6.Count == 1) ? 1 : 0);
            if(val_6 != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._doubleRewards, 丏业丟一东丂东丘丛:  (val_6.Count > 1) ? 1 : 0);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._doubleRewards, 丏业丟一东丂东丘丛:  (0.Count > 1) ? 1 : 0);
            }
            
            if(val_6.Count != 1)
            {
                goto label_18;
            }
            
            val_34 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPReward>(source:  val_6);
            this.丈丄丏丆丕不丛丕丅.<丅丝丌丝丁丏丙东丞>k__BackingField = val_34;
            this.丈丄丏丆丕不丛丕丅.丝一丅丆三东丂丞七();
            if(val_6 != null)
            {
                goto label_31;
            }
            
            goto label_21;
            label_18:
            val_34 = this.丗上与丑丙上专东世.Count;
            int val_19 = UnityEngine.Mathf.Min(a:  val_6.Count, b:  val_34);
            if(val_19 >= 1)
            {
                    do
            {
                val_20.<丅丝丌丝丁丏丙东丞>k__BackingField = val_6.Item[0];
                this.丗上与丑丙上专东世.Item[0].丝一丅丆三东丂丞七();
                val_34 = 0 + 1;
            }
            while(val_19 != val_34);
            
            }
            
            if(val_6 != null)
            {
                goto label_31;
            }
            
            label_21:
            label_31:
            val_31 = 1152921519068975536;
            val_33 = 1152921505284374528;
            if(val_6.Count >= 1)
            {
                    this.丄七丗业丐万丁丆丄.Add(item:  this._nextRewardContainer);
            }
            
            label_32:
            val_35 = val_2.丐七丝丝丌丛上丑丑();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._dailyRewardContainer, 丏业丟一东丂东丘丛:  val_35);
            if(val_35 != false)
            {
                    val_35 = this._dailyRewardContainer;
                if(val_35 != 0)
            {
                    PGCompany.BattlePass.BPData val_26 = val_2.丁专丗万三上丟三丆();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._countDailyExpLabel, 丕丗丘丑丛与丑业丒:  val_26._dailyExp);
                val_35 = this._dailyRewardContainer;
                this.丄七丗业丐万丁丆丄.Add(item:  val_35);
            }
            
            }
            
            if(this.丄七丗业丐万丁丆丄.Count < 2)
            {
                    return;
            }
            
            this.丌东丛且丂丙世丅丆 = this.StartCoroutine(routine:  this.丕不丄不一不上丛下());
        }
        private System.Collections.IEnumerator 丕不丄不一不上丛下()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BPNextLevelRewardView.专丐丂丑丕一且且三();
        }
        private void OnDisable()
        {
            if(this.丌东丛且丂丙世丅丆 != null)
            {
                    this.StopCoroutine(routine:  this.丌东丛且丂丙世丅丆);
                this.丌东丛且丂丙世丅丆 = 0;
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆.丐丑丑丐丅丈丝丄世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPNextLevelRewardView::丆丒专七丌业丂丙丗()));
        }
        private void 丆七丌丗丈专丘丐丆()
        {
            if(this.丌东丛且丂丙世丅丆 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丌东丛且丂丙世丅丆);
            this.丌东丛且丂丙世丅丆 = 0;
        }
        public BPNextLevelRewardView()
        {
            this._rotateTSeconds = 4f;
            this.丄七丗业丐万丁丆丄 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
    
    }

}
