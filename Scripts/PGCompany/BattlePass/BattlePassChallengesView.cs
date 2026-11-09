using UnityEngine;

namespace PGCompany.BattlePass
{
    public abstract class BattlePassChallengesView : MonoBehaviour
    {
        // Fields
        private UnityEngine.Coroutine 丒与丅上业业丟丐七;
        private PGCompany.BattlePass.BattlePassChallengeView _topChallendgeView;
        private Rilisoft.CharacterHelper _characterHelper;
        
        // Properties
        internal abstract PGCompany.BattlePass.三丛上丁丗丌丆丌东 丛丂三下东丐丌丝丗 { get; }
        protected abstract System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄 { get; }
        public int 一丆业上一一丛七万 { get; }
        
        // Methods
        internal abstract PGCompany.BattlePass.三丛上丁丗丌丆丌东 业丂丏丑丝且一丑丞(); // 0
        protected abstract System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丄丄丆东丑三丝专丂(); // 0
        public int get_UngivenChallengesCount()
        {
            object val_14;
            System.Func<TSource, System.Boolean> val_15;
            var val_16;
            val_14 = this;
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_2 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
            if((val_2 == null) || (val_2.Count == 0))
            {
                goto label_5;
            }
            
            if(this == null)
            {
                goto label_6;
            }
            
            System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean> val_4 = new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  this, method:  System.Boolean PGCompany.BattlePass.BattlePassChallengesView::丁丑与丕丅丟丞不七(PGCompany.BattlePass.BPChallengeRememberedReward 东七上世万下丗丄丛));
            val_15 = val_4;
            val_16 = System.Linq.Enumerable.Any<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_2, predicate:  val_4);
            goto label_7;
            label_5:
            val_16 = 0;
            return (int)val_16;
            label_6:
            val_16 = 0;
            label_7:
            val_14 = val_14;
            if(this == null)
            {
                    return (int)val_16;
            }
            
            if(this.Count < 1)
            {
                    return (int)val_16;
            }
            
            var val_13 = 0;
            do
            {
                .丁丂专业丁丅丅丈丙 = this.Item[0];
                val_13 = val_13 + 1;
                val_16 = val_16 + (System.Linq.Enumerable.Any<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_2, predicate:  new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  new BattlePassChallengesView.丘丞上世丗丘丏丐东(), method:  System.Boolean BattlePassChallengesView.丘丞上世丗丘丏丐东::丕专丌丞上丘丒七业(PGCompany.BattlePass.BPChallengeRememberedReward 东七上世万下丗丄丛))));
            }
            while(val_13 < this.Count);
            
            return (int)val_16;
        }
        public abstract bool IsMyChallenge(int 且丂七下丙丆三丐三); // 0
        public virtual void Setup()
        {
            goto typeof(PGCompany.BattlePass.BattlePassChallengesView).__il2cppRuntimeField_1A8;
        }
        public virtual void UpdateView()
        {
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_8;
            if(this == null)
            {
                    return;
            }
            
            if(this._topChallendgeView != 0)
            {
                    val_8 = this;
                if(this != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._topChallendgeView, 丏业丟一东丂东丘丛:  true);
                this._topChallendgeView.Setup(与且专丈不万东一万:  this);
                this._topChallendgeView.remove_OnRewardClicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesView::丆丁下不丕丝丞丈丙(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)));
                System.Action<PGCompany.BattlePass.BattlePassChallengeView> val_3 = null;
                val_8 = val_3;
                val_3 = new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesView::丆丁下不丕丝丞丈丙(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟));
                this._topChallendgeView.add_OnRewardClicked(丙业与丙丗丝不丈东:  val_3);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._topChallendgeView, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            if(this.丒与丅上业业丟丐七 != null)
            {
                    this.StopCoroutine(routine:  this.丒与丅上业业丟丐七);
                this.丒与丅上业业丟丐七 = 0;
            }
            
            if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
            {
                    return;
            }
            
            System.Action val_5 = new System.Action(object:  this, method:  typeof(PGCompany.BattlePass.BattlePassChallengesView).__il2cppRuntimeField_1B0);
            this.丒与丅上业业丟丐七 = this.StartCoroutine(routine:  val_5.丌不三万且丂丟丐丆(七丘丂一丄不丅上丐:  val_5));
        }
        internal void 下万丑且东丑丅丟专()
        {
            var val_7;
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BattlePassChallengeView>(source:  this.gameObject.GetComponentsInChildren<PGCompany.BattlePass.BattlePassChallengeView>());
            val_7 = null;
            val_7 = null;
            if((BattlePassChallengesView.<>c.<>9__10_0) == null)
            {
                goto label_4;
            }
            
            label_13:
            PGCompany.BattlePass.BattlePassChallengeView val_4 = val_3.Find(match:  BattlePassChallengesView.<>c.<>9__10_0);
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4.下万丑且东丑丅丟专();
            return;
            label_4:
            BattlePassChallengesView.<>c.<>9__10_0 = new System.Predicate<PGCompany.BattlePass.BattlePassChallengeView>(object:  BattlePassChallengesView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesView.<>c::七丂丛丗业一与上东(PGCompany.BattlePass.BattlePassChallengeView 三丟东丕丄丄下下丑));
            if(val_3 != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        private void 丆丁下不丕丝丞丈丙(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)
        {
            PGCompany.BattlePass.BattlePassChallengeView val_10 = 丁世丛业丟下丕三丟;
            if(val_10 == 0)
            {
                    return;
            }
            
            if(val_10.LastClickedReward == null)
            {
                    return;
            }
            
            val_10 = val_10.LastClickedReward.Count;
            Rilisoft.ItemViewer val_9 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewBattlePass", 丆丏七丟不丒与七专:  BattlePassRootUI.丑七不且上丗丁一世().transform, 丕丁下丌不万丅丞丛:  val_10.LastClickedReward.Id, 丅三丟世下丞丝丙万:  val_10, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        }
        protected virtual void OnEnable()
        {
            PGCompany.BattlePass.丘丄上丏不丝不丐丐.专丒七世一丘丌万七(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesView::丘丙不丒丌且世丗三(丘上上万专丙万丟丑 万且万且丑丗且丌丆)));
            PGCompany.BattlePass.丘丄上丏不丝不丐丐.丅万七世东丂下丙世(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesView::丘丙不丒丌且世丗三(丘上上万专丙万丟丑 万且万且丑丗且丌丆)));
        }
        protected virtual void OnDisable()
        {
            PGCompany.BattlePass.丘丄上丏不丝不丐丐.专丒七世一丘丌万七(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesView::丘丙不丒丌且世丗三(丘上上万专丙万丟丑 万且万且丑丗且丌丆)));
        }
        protected virtual void OnDestroy()
        {
            PGCompany.BattlePass.丘丄上丏不丝不丐丐.专丒七世一丘丌万七(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesView::丘丙不丒丌且世丗三(丘上上万专丙万丟丑 万且万且丑丗且丌丆)));
        }
        private void 丘丙不丒丌且世丗三(丘上上万专丙万丟丑 万且万且丑丗且丌丆)
        {
            goto typeof(PGCompany.BattlePass.BattlePassChallengesView).__il2cppRuntimeField_1A8;
        }
        private System.Collections.IEnumerator 丌不三万且丂丟丐丆(System.Action 七丘丂一丄不丅上丐)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .七丘丂一丄不丅上丐 = 七丘丂一丄不丅上丐;
            return (System.Collections.IEnumerator)new BattlePassChallengesView.与丗丆丗专丁丄丝不();
        }
        protected BattlePassChallengesView()
        {
        
        }
        private bool 丁丑与丕丅丟丞不七(PGCompany.BattlePass.BPChallengeRememberedReward 东七上世万下丗丄丛)
        {
            return (bool)(东七上世万下丗丄丛.Id == this.业上丙丞丐丄丆丅七()) ? 1 : 0;
        }
    
    }

}
