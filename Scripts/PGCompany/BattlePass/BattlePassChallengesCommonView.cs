using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassChallengesCommonView : BattlePassChallengesView
    {
        // Fields
        private static PGCompany.BattlePass.BattlePassChallengesCommonView 丝业丆丁业三丈丟东;
        private System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丄丏世丒丛丘丑下丕;
        private int 东世专丈丘不丂丌丏;
        private System.Collections.Generic.List<PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞> 丆丛丁专丒丝东丏丄;
        private PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 丑业丁万三丌专三丞;
        private static PGCompany.BattlePass.BattlePassChallengesCommonView.Tab 丂丐与七丂丗丗下丙;
        private Rilisoft.BetterWrapContent _daysWrap;
        private System.Collections.Generic.List<PGCompany.BattlePass.BattlePassChallengeView> _сhallendgeViews;
        private UILabel _dayNumbLabel;
        private UnityEngine.GameObject _baseContentContainer;
        private UnityEngine.GameObject _challengesContainer;
        private UnityEngine.GameObject _servetNotAvailableContentContainer;
        private UnityEngine.GameObject _largeWrapContainer;
        private Rilisoft.BetterWrapContent _largeWrap;
        private UILabel _completeView;
        private UITable _challengesTable;
        private UnityEngine.GameObject _buyPremiumObject;
        private UnityEngine.GameObject _daysButton;
        private UnityEngine.GameObject _activeButton;
        private UnityEngine.GameObject _completeButton;
        private UnityEngine.Transform _targetBlockPointParticles;
        
        // Properties
        public static PGCompany.BattlePass.BattlePassChallengesCommonView.Tab 丁且丘下丘丑丌丞丂 { get; set; }
        protected override System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄 { get; }
        internal override PGCompany.BattlePass.三丛上丁丗丌丆丌东 丛丂三下东丐丌丝丗 { get; }
        internal UnityEngine.Transform 且业丙丈一丄丑且东 { get; }
        
        // Methods
        public static PGCompany.BattlePass.BattlePassChallengesCommonView.Tab get_CurrentTab()
        {
            return (Tab)PGCompany.BattlePass.BattlePassChallengesCommonView.丂丐与七丂丗丗下丙;
        }
        public static void set_CurrentTab(PGCompany.BattlePass.BattlePassChallengesCommonView.Tab 丙业与丙丗丝不丈东)
        {
            PGCompany.BattlePass.BattlePassChallengesCommonView val_8;
            PGCompany.BattlePass.BattlePassChallengesCommonView.丂丐与七丂丗丗下丙 = 丙业与丙丗丝不丈东;
            val_8 = PGCompany.BattlePass.BattlePassChallengesCommonView.丝业丆丁业三丈丟东;
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8 = PGCompany.BattlePass.BattlePassChallengesCommonView.丝业丆丁业三丈丟东.gameObject;
            if(val_8.activeInHierarchy == false)
            {
                    return;
            }
            
            val_8 = ???;
            goto typeof(PGCompany.BattlePass.BattlePassChallengesCommonView).__il2cppRuntimeField_1A8;
        }
        protected override System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丄丄丆东丑三丝专丂()
        {
            var val_5;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = BattlePassChallengesCommonView.<>c.<>9__11_0;
            if(val_7 != null)
            {
                    return System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_3 = null));
            }
            
            val_7 = val_3;
            val_3 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::与丘丈丒丙三丝丗丟(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            BattlePassChallengesCommonView.<>c.<>9__11_0 = val_7;
            return System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_3));
        }
        internal override PGCompany.BattlePass.三丛上丁丗丌丆丌东 业丂丏丑丝且一丑丞()
        {
            var val_8;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_10;
            var val_11;
            val_8 = null;
            val_8 = null;
            val_10 = BattlePassChallengesCommonView.<>c.<>9__13_0;
            if(val_10 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_3 = null;
                val_10 = val_3;
                val_3 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::专丛东与丟丘下丁业(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__13_0 = val_10;
            }
            
            System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_3));
            if(val_5.Count >= 2)
            {
                    PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_7 = val_5.Item[1];
                return (PGCompany.BattlePass.三丛上丁丗丌丆丌东)val_11;
            }
            
            val_11 = 0;
            return (PGCompany.BattlePass.三丛上丁丗丌丆丌东)val_11;
        }
        public override bool IsMyChallenge(int 且丂七下丙丆三丐三)
        {
            var val_4;
            System.Collections.Generic.IEnumerable<TSource> val_5;
            .且丂七下丙丆三丐三 = 且丂七下丙丆三丐三;
            if(this != null)
            {
                    val_4 = 0;
                if(this.业上丙丞丐丄丆丅七() == (BattlePassChallengesCommonView.丌丟丘丏丕丅七万丕)[1152921560043103120].且丂七下丙丆三丐三)
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
            
            return System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this, predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BattlePassChallengesCommonView.丌丟丘丏丕丅七万丕(), method:  System.Boolean BattlePassChallengesCommonView.丌丟丘丏丕丅七万丕::丑丝丗丘丆丌业丂丛(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙)));
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丝丏丈丏丑丑东丌丆(int 万且万且丑丗且丌丆)));
            BPChallengesController.丛丄丂与丄丈丟丂丒(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丝丏丈丏丑丑东丌丆(int 万且万且丑丗且丌丆)));
            PGCompany.BattlePass.BattlePassChallengesCommonView.丝业丆丁业三丈丟东 = this;
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丝丏丈丏丑丑东丌丆(int 万且万且丑丗且丌丆)));
            PGCompany.BattlePass.BattlePassChallengesCommonView.丝业丆丁业三丈丟东 = 0;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丝丏丈丏丑丑东丌丆(int 万且万且丑丗且丌丆)));
        }
        private void 丝丏丈丏丑丑东丌丆(int 万且万且丑丗且丌丆)
        {
        
        }
        public override void Setup()
        {
            this.Setup();
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassChallengesCommonView.丟下丘丁丂东丏丁丅();
        }
        public override void UpdateView()
        {
            object val_92;
            var val_93;
            var val_94;
            bool val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            var val_101;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_103;
            var val_104;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_106;
            var val_107;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_109;
            Rilisoft.BetterWrapContent val_110;
            IntPtr val_112;
            var val_113;
            var val_114;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_116;
            var val_117;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_119;
            var val_120;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Single> val_122;
            var val_123;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_125;
            var val_126;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_128;
            var val_129;
            var val_130;
            var val_131;
            var val_132;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_134;
            var val_135;
            var val_136;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄> val_138;
            var val_139;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_141;
            var val_142;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_144;
            var val_145;
            var val_146;
            System.Func<丆丐七丗丏丟不丞丞, System.Boolean> val_148;
            丆丐七丗丏丟不丞丞 val_149;
            var val_150;
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_151;
            var val_152;
            val_92 = this;
            this.UpdateView();
            if(FriendsController.丝丗专上三不丄丑丑() <= 0)
            {
                goto label_3;
            }
            
            label_71:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._challengesContainer, 丏业丟一东丂东丘丛:  true);
            val_93 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._servetNotAvailableContentContainer, 丏业丟一东丂东丘丛:  false);
            T[] val_2 = this._daysButton.GetComponents<UIButton>();
            if((val_2 != null) && (val_2.Length >= 1))
            {
                    val_95 = true;
                do
            {
                if(0 >= val_2.Length)
            {
                    val_96 = 0;
            }
            
                T val_94 = val_2[0];
                var val_3 = (PGCompany.BattlePass.BattlePassChallengesCommonView.丂丐与七丂丗丗下丙 != 0) ? 1 : 0;
                val_97 = mem[val_2[0x0][0] + 376 + 8];
                val_97 = val_2[0x0][0] + 376 + 8;
            }
            while((0 + 1) < val_2.Length);
            
            }
            
            T[] val_5 = this._activeButton.GetComponents<UIButton>();
            if((val_5 != null) && (val_5.Length >= 1))
            {
                    val_95 = true;
                do
            {
                if(0 >= val_5.Length)
            {
                    val_98 = 0;
            }
            
                T val_95 = val_5[0];
                var val_6 = (PGCompany.BattlePass.BattlePassChallengesCommonView.丂丐与七丂丗丗下丙 != 1) ? 1 : 0;
                val_99 = mem[val_5[0x0][0] + 376 + 8];
                val_99 = val_5[0x0][0] + 376 + 8;
            }
            while((0 + 1) < val_5.Length);
            
            }
            
            T[] val_8 = this._completeButton.GetComponents<UIButton>();
            if((val_8 != null) && (val_8.Length >= 1))
            {
                    val_94 = 1152921505680273408;
                do
            {
                val_95 = 0;
                if(0 >= val_8.Length)
            {
                    val_99 = 0;
            }
            
                T val_96 = val_8[val_95];
                var val_9 = (PGCompany.BattlePass.BattlePassChallengesCommonView.丂丐与七丂丗丗下丙 != 2) ? 1 : 0;
            }
            while((val_95 + 1) < val_8.Length);
            
            }
            
            if(PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 != 0)
            {
                    PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业.丆下丙丞丗丙丘一丄(丙业与丙丗丝不丈东:  this.业丆一丈丝丏丟三丈());
            }
            
            if(PGCompany.BattlePass.BattlePassChallengesCommonView.丂丐与七丂丗丗下丙 != 2)
            {
                goto label_32;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseContentContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._largeWrapContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._completeView, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6139"));
            val_100 = 1152921505680486400;
            val_101 = null;
            val_101 = null;
            val_103 = BattlePassChallengesCommonView.<>c.<>9__21_0;
            if(val_103 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_16 = null;
                val_103 = val_16;
                val_16 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::丑丗与丙丟三丁三丐(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_0 = val_103;
            }
            
            val_104 = null;
            val_104 = null;
            val_106 = BattlePassChallengesCommonView.<>c.<>9__21_1;
            if(val_106 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_18 = null;
                val_106 = val_18;
                val_18 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassChallengesCommonView.<>c::下丄丑七丆世丘丟专(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_1 = val_106;
            }
            
            val_107 = null;
            val_107 = null;
            val_109 = BattlePassChallengesCommonView.<>c.<>9__21_2;
            if(val_109 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_20 = null;
                val_109 = val_20;
                val_20 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassChallengesCommonView.<>c::丞丘丟丒丂丈一与下(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_2 = val_109;
            }
            
            this.丄丏世丒丛丘丑下丕 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.ThenBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_16), keySelector:  val_18), keySelector:  val_20));
            val_110 = this._largeWrap;
            val_112 = 1152921560044098480;
            goto label_55;
            label_3:
            val_113 = null;
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == true)
            {
                goto label_201;
            }
            
            val_114 = null;
            val_114 = null;
            val_116 = BattlePassChallengesCommonView.<>c.<>9__21_9;
            if(val_116 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_26 = null;
                val_116 = val_26;
                val_26 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::丅专世丏不且丈七不(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_9 = val_116;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_27 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_26);
            if(val_27 == null)
            {
                goto label_201;
            }
            
            val_116 = val_27.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万();
            if((val_116.世丑丐丅丆丂丘不丁() == false) || (val_27.丁丒业丐丞业丒丟丙() == true))
            {
                goto label_71;
            }
            
            label_201:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._challengesContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._servetNotAvailableContentContainer, 丏业丟一东丂东丘丛:  true);
            return;
            label_32:
            if(PGCompany.BattlePass.BattlePassChallengesCommonView.丂丐与七丂丗丗下丙 != 1)
            {
                goto label_75;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseContentContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._largeWrapContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._completeView, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6460"));
            val_100 = 1152921505680486400;
            val_117 = null;
            val_117 = null;
            val_119 = BattlePassChallengesCommonView.<>c.<>9__21_4;
            if(val_119 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_35 = null;
                val_119 = val_35;
                val_35 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::且丏丌丙丗专丆一丈(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_4 = val_119;
            }
            
            val_120 = null;
            val_120 = null;
            val_122 = BattlePassChallengesCommonView.<>c.<>9__21_5;
            if(val_122 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Single> val_37 = null;
                val_122 = val_37;
                val_37 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Single>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Single BattlePassChallengesCommonView.<>c::万东丐丒丆丅丒与丙(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_5 = val_122;
            }
            
            val_123 = null;
            val_123 = null;
            val_125 = BattlePassChallengesCommonView.<>c.<>9__21_6;
            if(val_125 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_39 = null;
                val_125 = val_39;
                val_39 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassChallengesCommonView.<>c::专且丏丛万不丙丒丟(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_6 = val_125;
            }
            
            val_126 = null;
            val_126 = null;
            val_128 = BattlePassChallengesCommonView.<>c.<>9__21_7;
            if(val_128 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_41 = null;
                val_128 = val_41;
                val_41 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassChallengesCommonView.<>c::与七一丄丐业丝不上(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_7 = val_128;
            }
            
            this.丄丏世丒丛丘丑下丕 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.ThenBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(source:  System.Linq.Enumerable.ThenByDescending<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Single>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_35), keySelector:  val_37), keySelector:  val_39), keySelector:  val_41));
            val_110 = this._largeWrap;
            System.Func<System.Int32> val_44 = null;
            val_112 = 1152921560044206096;
            label_55:
            val_116 = val_44;
            val_44 = new System.Func<System.Int32>(object:  this, method:  val_112);
            val_110.Initialize(下丛一丂不丕东万丐:  val_44, 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丘丗丟不丂七上丒丄(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)));
            val_92 = this._largeWrap;
            val_92.UpdateVisibleCells();
            return;
            label_75:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseContentContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._largeWrapContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._completeView, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6138"));
            this.丆丛丁专丒丝东丏丄.Clear();
            if(this == null)
            {
                    return;
            }
            
            if(FriendsController.丝丗专上三不丄丑丑() >= 1)
            {
                    this.东世专丈丘不丂丌丏 = BPChallengesController.丑七不且上丗丁一世().丒丑丅丑丕万丞丅丟();
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_51 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            val_129 = 1152921505136771072;
            val_130 = 1152921536371862448;
            val_131 = 0;
            goto label_123;
            label_149:
            System.DateTime val_52 = val_51.丟万丌丕丅下万丆七();
            System.DateTime val_53 = val_52.dateData.AddDays(value:  (double)val_96);
            System.DateTime val_54 = val_51.丒万丐不丆且丒与丒();
            val_131 = 0;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_53.dateData}, t2:  new System.DateTime() {dateData = val_54.dateData})) != true)
            {
                    System.Collections.Generic.IEnumerable<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_57 = BPChallengesController.丑七不且上丗丁一世().丁丐万丆丕下下专万(丈丆丕与丒丌丘丕且:  this, 三丈丏丑一丞下丄丂:  val_96);
                if((val_57 != null) && ((System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_57)) != false))
            {
                    val_132 = null;
                val_132 = null;
                val_134 = BattlePassChallengesCommonView.<>c.<>9__21_13;
                if(val_134 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_59 = null;
                val_134 = val_59;
                val_59 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::丝丂丁且与丅丛丁丈(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_13 = val_134;
            }
            
                if((System.Linq.Enumerable.All<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_57, predicate:  val_59)) != false)
            {
                    val_135 = 2;
            }
            
                val_136 = null;
                val_136 = null;
                val_138 = BattlePassChallengesCommonView.<>c.<>9__21_14;
                if(val_138 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄> val_62 = null;
                val_138 = val_62;
                val_62 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄 BattlePassChallengesCommonView.<>c::世丂且不一丆七丕不(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_14 = val_138;
            }
            
                val_139 = null;
                val_139 = null;
                val_141 = BattlePassChallengesCommonView.<>c.<>9__21_15;
                if(val_141 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_64 = null;
                val_141 = val_64;
                val_64 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassChallengesCommonView.<>c::丏丑丌东且丘丞丏丂(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_15 = val_141;
            }
            
                System.Collections.Generic.List<TSource> val_66 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.ThenBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(source:  System.Linq.Enumerable.OrderBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄>(source:  val_57, keySelector:  val_62), keySelector:  val_64));
                BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 val_67 = new BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞();
                if(val_67 != null)
            {
                    .丙丁丟丘丁丐与丕丝 = val_96;
                .万丛东丐丆丐丝万世 = val_66;
            }
            else
            {
                    mem[24] = val_96;
                mem[16] = val_66;
            }
            
                .丙丟与丐三丐万万丆 = (val_96 > this.东世专丈丘不丂丌丏) ? 3 : (0 + 1);
                this.丆丛丁专丒丝东丏丄.Add(item:  val_67);
                val_129 = 1152921505136771072;
                val_130 = 1152921536371862448;
            }
            
                val_131 = val_96 + 1;
            }
            
            label_123:
            if((val_131 & 2147483648) == 0)
            {
                goto label_149;
            }
            
            if(((System.Linq.Enumerable.FirstOrDefault<丆丐七丗丏丟不丞丞>(source:  this.丆丛丁专丒丝东丏丄)) != null) && (val_68.万丛东丐丆丐丝万世 != null))
            {
                    val_142 = null;
                val_142 = null;
                val_144 = BattlePassChallengesCommonView.<>c.<>9__21_16;
                if(val_144 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_69 = null;
                val_144 = val_69;
                val_69 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::与丑东丆丅丛丛业业(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__21_16 = val_144;
            }
            
                PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_70 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_68.万丛东丐丆丐丝万世, predicate:  val_69);
                if((val_70 != null) && (val_70.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() != false))
            {
                    if(val_70.丁丒业丐丞业丒丟丙() != true)
            {
                    bool val_75 = val_68.万丛东丐丆丐丝万世.Remove(item:  val_70);
            }
            
            }
            
            }
            
            val_145 = null;
            val_145 = null;
            if(PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 < 1)
            {
                goto label_165;
            }
            
            val_146 = null;
            val_146 = null;
            val_148 = BattlePassChallengesCommonView.<>c.<>9__21_10;
            if(val_148 == null)
            {
                    System.Func<丆丐七丗丏丟不丞丞, System.Boolean> val_76 = null;
                val_148 = val_76;
                val_76 = new System.Func<丆丐七丗丏丟不丞丞, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::丆丙丘业丘丑丘丂且(PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 丐丆丂丒丁万丈丛丅));
                BattlePassChallengesCommonView.<>c.<>9__21_10 = val_148;
            }
            
            val_149 = System.Linq.Enumerable.FirstOrDefault<丆丐七丗丏丟不丞丞>(source:  this.丆丛丁专丒丝东丏丄, predicate:  val_76);
            if(val_149 != null)
            {
                goto label_194;
            }
            
            goto label_177;
            label_165:
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_79 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
            if((val_79 == null) || (val_79.Count < 1))
            {
                goto label_177;
            }
            
            val_150 = 0;
            goto label_178;
            label_193:
            if(this.丆丛丁专丒丝东丏丄.Item[0] == null)
            {
                goto label_181;
            }
            
            val_151 = val_81.万丛东丐丆丐丝万世;
            if(val_151 == null)
            {
                goto label_181;
            }
            
            val_152 = 0;
            goto label_182;
            label_187:
            .不丛丙丝三丗丝七丟 = val_81.万丛东丐丆丐丝万世.Item[0];
            if((System.Linq.Enumerable.Any<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_79, predicate:  new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  new BattlePassChallengesCommonView.丈业丗丞丁七下一不(), method:  System.Boolean BattlePassChallengesCommonView.丈业丗丞丁七下一不::且丂七丑三世丘丂丟(PGCompany.BattlePass.BPChallengeRememberedReward 丁丂专业丁丅丅丈丙)))) == true)
            {
                goto label_194;
            }
            
            val_151 = val_81.万丛东丐丆丐丝万世;
            val_152 = 1;
            label_182:
            if(val_152 < val_151.Count)
            {
                goto label_187;
            }
            
            label_181:
            if(PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 != 0)
            {
                    null.丆下丙丞丗丙丘一丄(丙业与丙丗丝不丈东:  this._targetBlockPointParticles);
            }
            
            val_150 = 1;
            label_178:
            if(val_150 < this.丆丛丁专丒丝东丏丄.Count)
            {
                goto label_193;
            }
            
            label_177:
            val_149 = this.丑业丁万三丌专三丞;
            if(val_149 != null)
            {
                goto label_194;
            }
            
            val_149 = System.Linq.Enumerable.FirstOrDefault<丆丐七丗丏丟不丞丞>(source:  this.丆丛丁专丒丝东丏丄, predicate:  new System.Func<丆丐七丗丏丟不丞丞, System.Boolean>(object:  this, method:  System.Boolean PGCompany.BattlePass.BattlePassChallengesCommonView::一丗丞丘业东丛不丆(PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 丐丆丂丒丁万丈丛丅)));
            if(val_149 == null)
            {
                goto label_195;
            }
            
            label_194:
            this.丑业丁万三丌专三丞 = val_149;
            label_200:
            this._daysWrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this, method:  System.Int32 PGCompany.BattlePass.BattlePassChallengesCommonView::一丂丐与万三丞丘东()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丈东三丟上丁一三丛(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)));
            this._daysWrap.UpdateVisibleCells();
            this.丐丛三丌丁丄丗丝丗(丟丒业且万上丁三丆:  val_90.丙丁丟丘丁丐与丕丝, 丄丑三东丘丆丂丟丙:  true);
            return;
            label_195:
            丆丐七丗丏丟不丞丞 val_93 = System.Linq.Enumerable.FirstOrDefault<丆丐七丗丏丟不丞丞>(source:  this.丆丛丁专丒丝东丏丄);
            this.丑业丁万三丌专三丞 = val_93;
            if(val_93 != null)
            {
                goto label_200;
            }
            
            goto label_201;
        }
        private void 丘丗丟不丂七上丒丄(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            if((this.丄丏世丒丛丘丑下丕 == null) || (this.丄丏世丒丛丘丑下丕.Count <= 丘丒丌下丕专且七专))
            {
                goto label_2;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  true);
            PGCompany.BattlePass.BattlePassChallengeView val_3 = 丕一一丆丌丝丕业万.GetComponent<PGCompany.BattlePass.BattlePassChallengeView>();
            if(val_3 != 0)
            {
                goto label_9;
            }
            
            return;
            label_2:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  false);
            return;
            label_9:
            val_3.Setup(与且专丈不万东一万:  this.丄丏世丒丛丘丑下丕.Item[丘丒丌下丕专且七专]);
        }
        private void 丈东三丟上丁一三丛(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            int val_8;
            丆丐七丗丏丟不丞丞 val_9;
            val_8 = 丘丒丌下丕专且七专;
            if(this.丆丛丁专丒丝东丏丄 == null)
            {
                    return;
            }
            
            if(this.丆丛丁专丒丝东丏丄.Count <= val_8)
            {
                    return;
            }
            
            val_9 = this.丆丛丁专丒丝东丏丄.Item[val_8];
            PGCompany.BattlePass.BattlePassDayView val_3 = 丕一一丆丌丝丕业万.GetComponent<PGCompany.BattlePass.BattlePassDayView>();
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.Setup(与且专丈不万东一万:  val_9);
            if(val_9 != null)
            {
                    if(this.丑业丁万三丌专三丞 == null)
            {
                goto label_10;
            }
            
            }
            
            if(val_3 != null)
            {
                goto label_14;
            }
            
            label_15:
            label_14:
            val_3.IsSelected = (val_2.丙丁丟丘丁丐与丕丝 == this.丑业丁万三丌专三丞.丙丁丟丘丁丐与丕丝) ? 1 : 0;
            val_3.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassDayView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丄丄丘丏七三专丟丙(PGCompany.BattlePass.BattlePassDayView 丁世丛业丟下丕三丟)));
            val_3.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassDayView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesCommonView::丄丄丘丏七三专丟丙(PGCompany.BattlePass.BattlePassDayView 丁世丛业丟下丕三丟)));
            return;
            label_10:
            if(val_3 != null)
            {
                goto label_14;
            }
            
            goto label_15;
        }
        private void 丄丄丘丏七三专丟丙(PGCompany.BattlePass.BattlePassDayView 丁世丛业丟下丕三丟)
        {
            var val_13;
            丆丐七丗丏丟不丞丞 val_14;
            var val_15;
            if(丁世丛业丟下丕三丟 == 0)
            {
                    return;
            }
            
            if(丁世丛业丟下丕三丟.Context == null)
            {
                    return;
            }
            
            this.丑业丁万三丌专三丞 = 丁世丛业丟下丕三丟.Context;
            System.Collections.Generic.List<UnityEngine.GameObject> val_4 = this._daysWrap.GetAllCellsObjects();
            val_13 = 0;
            goto label_8;
            label_17:
            PGCompany.BattlePass.BattlePassDayView val_6 = val_4.Item[0].GetComponent<PGCompany.BattlePass.BattlePassDayView>();
            if(val_6 != 0)
            {
                    if(val_6 != null)
            {
                    val_14 = this.丑业丁万三丌专三丞;
                val_15 = val_6.Context;
            }
            else
            {
                    val_14 = this.丑业丁万三丌专三丞;
                val_15 = val_6.Context;
            }
            
                val_6.IsSelected = (val_15 == val_14) ? 1 : 0;
            }
            
            val_13 = 1;
            label_8:
            if(val_13 < val_4.Count)
            {
                goto label_17;
            }
            
            丆丐七丗丏丟不丞丞 val_12 = 丁世丛业丟下丕三丟.Context;
            this.丐丛三丌丁丄丗丝丗(丟丒业且万上丁三丆:  val_12.丙丁丟丘丁丐与丕丝, 丄丑三东丘丆丂丟丙:  false);
        }
        private void 丐丛三丌丁丄丗丝丗(int 丟丒业且万上丁三丆, bool 丄丑三东丘丆丂丟丙 = False)
        {
            int val_39;
            string val_40;
            System.Func<TSource, System.Boolean> val_41;
            丆丐七丗丏丟不丞丞 val_42;
            var val_43;
            var val_44;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_46;
            var val_47;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_49;
            var val_50;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_52;
            var val_53;
            val_39 = this;
            .丟丒业且万上丁三丆 = 丟丒业且万上丁三丆;
            if(this._dayNumbLabel != 0)
            {
                    if(((BattlePassChallengesCommonView.丄丆丌丌丕丈丆丆业)[1152921560045841712].丟丒业且万上丁三丆 & 2147483648) == 0)
            {
                    int val_39 = (BattlePassChallengesCommonView.丄丆丌丌丕丈丆丆业)[1152921560045841712].丟丒业且万上丁三丆;
                val_39 = val_39 + 1;
                val_40 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5974"), arg0:  val_39);
            }
            else
            {
                    val_40 = 0;
            }
            
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_40)) != false)
            {
                    val_40 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
            }
            
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._dayNumbLabel, 丕丗丘丑丛与丑业丒:  val_40);
            }
            
            System.Func<丆丐七丗丏丟不丞丞, System.Boolean> val_7 = null;
            val_41 = val_7;
            val_7 = new System.Func<丆丐七丗丏丟不丞丞, System.Boolean>(object:  new BattlePassChallengesCommonView.丄丆丌丌丕丈丆丆业(), method:  System.Boolean BattlePassChallengesCommonView.丄丆丌丌丕丈丆丆业::一丈且丞丐丄丄丁丗(PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 丐丆丂丒丁万丈丛丅));
            val_42 = System.Linq.Enumerable.FirstOrDefault<丆丐七丗丏丟不丞丞>(source:  this.丆丛丁专丒丝东丏丄, predicate:  val_7);
            if(val_42 == null)
            {
                    return;
            }
            
            val_43 = null;
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == true)
            {
                goto label_43;
            }
            
            val_44 = null;
            val_44 = null;
            val_46 = BattlePassChallengesCommonView.<>c.<>9__25_1;
            if(val_46 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_10 = null;
                val_46 = val_10;
                val_10 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::丛丟丕丂万丏上丕下(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__25_1 = val_46;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_11 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_8.万丛东丐丆丐丝万世, predicate:  val_10);
            if(val_11 == null)
            {
                goto label_25;
            }
            
            if((val_8.万丛东丐丆丐丝万世.IndexOf(item:  val_11)) == 0)
            {
                goto label_43;
            }
            
            丞东丑专丛丆丄丝世.下丏且一三丐一丐不<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(丝丘丑业丛万丞丌丝:  val_8.万丛东丐丆丐丝万世, 下丅丙一丂丗丅丝七:  val_11, 丘丒丌下丕专且七专:  0);
            goto label_43;
            label_25:
            val_47 = null;
            val_47 = null;
            val_49 = BattlePassChallengesCommonView.<>c.<>9__25_2;
            if(val_49 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_15 = null;
                val_49 = val_15;
                val_15 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::丟七丂丁丒丅丟专不(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__25_2 = val_49;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_16 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_15);
            if(val_16 != null)
            {
                    if(val_16.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() != false)
            {
                    if(val_16.丁丒业丐丞业丒丟丙() == false)
            {
                goto label_43;
            }
            
            }
            
                val_50 = null;
                val_50 = null;
                val_52 = BattlePassChallengesCommonView.<>c.<>9__25_3;
                if(val_52 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_21 = null;
                val_52 = val_21;
                val_21 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallengesCommonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallengesCommonView.<>c::丕且丟与七丟丝丒丑(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallengesCommonView.<>c.<>9__25_3 = val_52;
            }
            
                PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_22 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_8.万丛东丐丆丐丝万世, predicate:  val_21);
                if(val_22 != null)
            {
                    bool val_23 = val_8.万丛东丐丆丐丝万世.Remove(item:  val_22);
            }
            
                val_8.万丛东丐丆丐丝万世.Insert(index:  0, item:  val_16);
            }
            
            label_43:
            val_53 = 0;
            goto label_52;
            label_59:
            if(val_53 <= (this._сhallendgeViews.Count - 1))
            {
                    this._сhallendgeViews.Item[0].Setup(与且专丈不万东一万:  val_8.万丛东丐丆丐丝万世.Item[0]);
            }
            
            val_53 = 1;
            label_52:
            if(val_53 < val_8.万丛东丐丆丐丝万世.Count)
            {
                goto label_59;
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_30 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_30 != null)
            {
                    var val_32 = (val_30.专丟专一丒且丘与丌() == 0) ? 1 : 0;
            }
            else
            {
                    val_41 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyPremiumObject, 丏业丟一东丂东丘丛:  false);
            if(this._challengesTable != 0)
            {
                    this._challengesTable.repositionNow = true;
            }
            
            if(丄丑三东丘丆丂丟丙 == false)
            {
                    return;
            }
            
            val_42 = this.丆丛丁专丒丝东丏丄.Count;
            val_39 = UnityEngine.Mathf.Clamp(value:  (this.丆丛丁专丒丝东丏丄.IndexOf(item:  val_42)) - 2, min:  0, max:  val_42 - 1);
            this._daysWrap.ScrollTo(丘丒丌下丕专且七专:  val_39, 与丑丑丑丂丛一丝一:  false);
        }
        public void U_ShowDaysChallenges()
        {
            PGCompany.BattlePass.BattlePassChallengesCommonView.CurrentTab = 0;
        }
        public void U_ShowActiveChallenges()
        {
            PGCompany.BattlePass.BattlePassChallengesCommonView.CurrentTab = 1;
        }
        public void U_ShowCompletedChallenges()
        {
            PGCompany.BattlePass.BattlePassChallengesCommonView.CurrentTab = 2;
        }
        internal UnityEngine.Transform 业丆一丈丝丏丟三丈()
        {
            if(this._targetBlockPointParticles == 0)
            {
                    return this.transform;
            }
            
            return (UnityEngine.Transform)this._targetBlockPointParticles;
        }
        public BattlePassChallengesCommonView()
        {
            this.东世专丈丘不丂丌丏 = 0;
            this.丆丛丁专丒丝东丏丄 = new System.Collections.Generic.List<丆丐七丗丏丟不丞丞>();
        }
        private int 丏丏丂丏丈世丅丂与()
        {
            if(this.丄丏世丒丛丘丑下丕 != null)
            {
                    return this.丄丏世丒丛丘丑下丕.Count;
            }
            
            return this.丄丏世丒丛丘丑下丕.Count;
        }
        private int 世丞丘七下且丕专丅()
        {
            if(this.丄丏世丒丛丘丑下丕 != null)
            {
                    return this.丄丏世丒丛丘丑下丕.Count;
            }
            
            return this.丄丏世丒丛丘丑下丕.Count;
        }
        private bool 一丗丞丘业东丛不丆(PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 丐丆丂丒丁万丈丛丅)
        {
            return (bool)(丐丆丂丒丁万丈丛丅.丙丁丟丘丁丐与丕丝 == this.东世专丈丘不丂丌丏) ? 1 : 0;
        }
        private int 一丂丐与万三丞丘东()
        {
            int val_1 = this.丆丛丁专丒丝东丏丄.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
    
    }

}
