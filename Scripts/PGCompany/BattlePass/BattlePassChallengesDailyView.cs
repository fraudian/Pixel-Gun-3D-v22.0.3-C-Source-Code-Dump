using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassChallengesDailyView : BattlePassChallengesView
    {
        // Fields
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 丛丂不一丄丘丏业万;
        private int 丐七丈丄丒世上专丏;
        protected Rilisoft.BetterWrapContent _wrap;
        private UILabel _timeLeftLabel;
        private UnityEngine.GameObject _debugInterface;
        private UnityEngine.Transform _targetBlockPointParticles;
        
        // Properties
        protected override System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄 { get; }
        internal override PGCompany.BattlePass.三丛上丁丗丌丆丌东 丛丂三下东丐丌丝丗 { get; }
        internal UnityEngine.Transform 且业丙丈一丄丑且东 { get; }
        
        // Methods
        protected override System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丄丄丆东丑三丝专丂()
        {
            var val_25;
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_33;
            var val_34;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_36;
            var val_37;
            var val_38;
            var val_39;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_41;
            var val_42;
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
            {
                    val_33 = 0;
            }
            else
            {
                    val_34 = null;
                val_34 = null;
                val_36 = BattlePassChallengesDailyView.<>c.<>9__3_0;
                if(val_36 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_6 = null;
                val_36 = val_6;
                val_6 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesDailyView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesDailyView.<>c::丑专一丞丂一丑丞万(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesDailyView.<>c.<>9__3_0 = val_36;
            }
            
                val_33 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_6);
            }
            
            val_38 = 1152921505680859136;
            val_39 = null;
            val_39 = null;
            val_41 = BattlePassChallengesDailyView.<>c.<>9__3_1;
            if(val_41 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_8 = null;
                val_41 = val_8;
                val_8 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesDailyView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesDailyView.<>c::世丒专丘丆丛丟丑丄(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesDailyView.<>c.<>9__3_1 = val_41;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_9 = System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_8);
            if(FriendsController.丝丗专上三不丄丑丑() >= 1)
            {
                    this.丐七丈丄丒世上专丏 = BPChallengesController.丑七不且上丗丁一世().丒丑丅丑丕万丞丅丟();
            }
            
            System.Collections.Generic.List<TSource> val_15 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丁丐万丆丕下下专万(丈丆丕与丒丌丘丕且:  val_9, 三丈丏丑一丞下丄丂:  this.丐七丈丄丒世上专丏));
            if(val_33 != null)
            {
                    if(val_33.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() != true)
            {
                    val_15.Insert(index:  0, item:  val_33);
            }
            
            }
            
            val_42 = BPChallengesController.丑七不且上丗丁一世();
            if(val_42.丄三丞丟丝东业业丌() == false)
            {
                    return (System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)val_15;
            }
            
            val_42 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
            List.Enumerator<T> val_23 = val_42.GetEnumerator();
            val_37 = 1152921536721196464;
            val_38 = 1152921536721197488;
            label_49:
            if(((-389996848) & 1) == 0)
            {
                goto label_43;
            }
            
            new BattlePassChallengesDailyView.上丌专丄丘丂东且丒() = new System.Object();
            .丗七丟丈三不丕一三 = val_25.丐丏七丌丕丗业且上();
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_28 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BattlePassChallengesDailyView.上丌专丄丘丂东且丒(), method:  System.Boolean BattlePassChallengesDailyView.上丌专丄丘丂东且丒::丁丝丛丏丝一三三丛(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_29 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_9, predicate:  null);
            if((val_29 == null) || ((val_15.Contains(item:  val_29)) == true))
            {
                goto label_49;
            }
            
            val_15.Insert(index:  0, item:  val_29);
            goto label_49;
            label_43:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)val_15;
        }
        internal override PGCompany.BattlePass.三丛上丁丗丌丆丌东 业丂丏丑丝且一丑丞()
        {
            return PGCompany.BattlePass.万丈上下三丅丘丛丒.丌丐与丂丗丒丙三七(丞世不丒下上上丝丑:  0);
        }
        public override bool IsMyChallenge(int 且丂七下丙丆三丐三)
        {
            var val_4;
            System.Collections.Generic.IEnumerable<TSource> val_5;
            .且丂七下丙丆三丐三 = 且丂七下丙丆三丐三;
            if(this != null)
            {
                    val_4 = 0;
                if(this.业上丙丞丐丄丆丅七() == (BattlePassChallengesDailyView.丘丞上世丗丘丏丐东)[1152921560051788336].且丂七下丙丆三丐三)
            {
                    val_5 = 1;
                return (bool)val_5;
            }
            
            }
            
            val_5 = this;
            if(this == null)
            {
                    return (bool)val_5;
            }
            
            return System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this, predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BattlePassChallengesDailyView.丘丞上世丗丘丏丐东(), method:  System.Boolean BattlePassChallengesDailyView.丘丞上世丗丘丏丐东::丑丝丗丘丆丌业丂丛(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙)));
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
            if(PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业.丆下丙丞丗丙丘一丄(丙业与丙丗丝不丈东:  this.业丆一丈丝丏丟三丈());
        }
        private void Start()
        {
            if(PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业.丆下丙丞丗丙丘一丄(丙业与丙丗丝不丈东:  this.业丆一丈丝丏丟三丈());
        }
        public override void Setup()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._debugInterface, 丏业丟一东丂东丘丛:  false);
            this.Setup();
        }
        public override void UpdateView()
        {
            this.UpdateView();
            if(this == null)
            {
                    return;
            }
            
            if(this._wrap == 0)
            {
                    return;
            }
            
            this._wrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this, method:  System.Int32 PGCompany.BattlePass.BattlePassChallengesDailyView::丏丂与丒三丞且世丅()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesDailyView::丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)));
            this._wrap.UpdateVisibleCells();
        }
        private void 丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            if((this == null) || (this.Count <= 丘丒丌下丕专且七专))
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  true);
            PGCompany.BattlePass.BattlePassChallengeView val_3 = 丕一一丆丌丝丕业万.GetComponent<PGCompany.BattlePass.BattlePassChallengeView>();
            if(val_3 != 0)
            {
                goto label_10;
            }
            
            return;
            label_3:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  false);
            return;
            label_10:
            val_3.Setup(与且专丈不万东一万:  this.Item[丘丒丌下丕专且七专]);
        }
        private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassChallengesDailyView.丈丛丕专丙与东丂丒();
        }
        public void U_NextDay()
        {
        
        }
        public void U_PreviousDay()
        {
        
        }
        internal UnityEngine.Transform 业丆一丈丝丏丟三丈()
        {
            if(this._targetBlockPointParticles == 0)
            {
                    return this.transform;
            }
            
            return (UnityEngine.Transform)this._targetBlockPointParticles;
        }
        public BattlePassChallengesDailyView()
        {
            this.丐七丈丄丒世上专丏 = 0;
        }
        private int 丏丂与丒三丞且世丅()
        {
            int val_1 = this.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
    
    }

}
