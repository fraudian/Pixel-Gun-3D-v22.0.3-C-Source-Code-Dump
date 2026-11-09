using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassChallengesPhoenixView : BattlePassChallengesView
    {
        // Fields
        private UnityEngine.Coroutine 上万丕丆专丌业与丁;
        private bool 三丟七丑世丆且且万;
        private Rilisoft.BetterWrapContent _wrap;
        private UnityEngine.GameObject _buyPremiumObject;
        private UnityEngine.GameObject _premAvailable;
        private UnityEngine.GameObject _premNotAvailable;
        private UILabel _labelChellengeDescription;
        
        // Properties
        protected override System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄 { get; }
        internal override PGCompany.BattlePass.三丛上丁丗丌丆丌东 丛丂三下东丐丌丝丗 { get; }
        
        // Methods
        protected override System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丄丄丆东丑三丝专丂()
        {
            var val_5;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = BattlePassChallengesPhoenixView.<>c.<>9__3_0;
            if(val_7 != null)
            {
                    return System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_3 = null));
            }
            
            val_7 = val_3;
            val_3 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesPhoenixView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesPhoenixView.<>c::丑专一丞丂一丑丞万(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            BattlePassChallengesPhoenixView.<>c.<>9__3_0 = val_7;
            return System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_3));
        }
        internal override PGCompany.BattlePass.三丛上丁丗丌丆丌东 业丂丏丑丝且一丑丞()
        {
            return PGCompany.BattlePass.万丈上下三丅丘丛丒.丌丐与丂丗丒丙三七(丞世不丒下上上丝丑:  2);
        }
        public override bool IsMyChallenge(int 且丂七下丙丆三丐三)
        {
            var val_4;
            System.Collections.Generic.IEnumerable<TSource> val_5;
            .且丂七下丙丆三丐三 = 且丂七下丙丆三丐三;
            if(this != null)
            {
                    val_4 = 0;
                if(this.业上丙丞丐丄丆丅七() == (BattlePassChallengesPhoenixView.丘丞上世丗丘丏丐东)[1152921560055290000].且丂七下丙丆三丐三)
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
            
            return System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this, predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BattlePassChallengesPhoenixView.丘丞上世丗丘丏丐东(), method:  System.Boolean BattlePassChallengesPhoenixView.丘丞上世丗丘丏丐东::丑丝丗丘丆丌业丂丛(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙)));
        }
        public override void Setup()
        {
            this.Setup();
        }
        public override void UpdateView()
        {
            var val_9;
            UnityEngine.GameObject val_10;
            var val_11;
            this.UpdateView();
            if(this == null)
            {
                    return;
            }
            
            if(this.上万丕丆专丌业与丁 != null)
            {
                    this.StopCoroutine(routine:  this.上万丕丆专丌业与丁);
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 != null)
            {
                    var val_4 = (val_2.专丟专一丒且丘与丌() != 100) ? 1 : 0;
            }
            else
            {
                    val_9 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyPremiumObject, 丏业丟一东丂东丘丛:  true);
            this.上万丕丆专丌业与丁 = this.StartCoroutine(routine:  this.丈东七与丞东上丗丗());
            object[] val_7 = new object[1];
            val_7[0] = this.Count;
            PGCompany.BattlePass.万丈上下三丅丘丛丒.丗三丗丒丏丐且丞丗(七丐丞丑丑丕世丙七:  this._labelChellengeDescription, 业东丘与与业丏丛丈:  "bp_challenge_perform", 专丒丌丆下丐丞丟丞:  val_7);
            if((val_9 & 1) != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._premAvailable, 丏业丟一东丂东丘丛:  false);
                val_10 = this._premNotAvailable;
                val_11 = 1;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._premAvailable, 丏业丟一东丂东丘丛:  true);
                val_10 = this._premNotAvailable;
                val_11 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  false);
        }
        private System.Collections.IEnumerator 丈东七与丞东上丗丗()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassChallengesPhoenixView.专业七三与丐丕丟丌(丗丏丅丕丆世丁专丟:  0);
        }
        private void 丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            if((this == null) || (this.Count <= 丘丒丌下丕专且七专))
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  true);
            PGCompany.BattlePass.BattlePassDoubleStateChallengeView val_3 = 丕一一丆丌丝丕业万.GetComponent<PGCompany.BattlePass.BattlePassDoubleStateChallengeView>();
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
        public BattlePassChallengesPhoenixView()
        {
            this.三丟七丑世丆且且万 = true;
        }
        private int 丐丏专不丗世丝丂丙()
        {
            int val_1 = this.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
    
    }

}
