using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassConnectScene : ChallangeConnectSceneAbstract
    {
        // Fields
        private UnityEngine.GameObject 丆丑东丒丟丒下丑丄;
        private System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丘业业丒一丅东专丅;
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 丐三且丅七且丆世丐;
        private UnityEngine.Coroutine 专世下东东丛丁上丙;
        private Rilisoft.且丈丞一丞丟与上七 丈一丗丝丄业与丅丆;
        private string <丂丏万丆三一且世与>k__BackingField;
        private PGCompany.BattlePass.丟丗丝且丕业丑丄丗 丆世且上丂丙丂丛丆;
        private UnityEngine.GameObject _body;
        private UnityEngine.GameObject _paidObj;
        private UnityEngine.GameObject _freeObj;
        private UnityEngine.GameObject _challengeBody;
        private UnityEngine.GameObject _challengeMainBody;
        private UnityEngine.GameObject _challengeReadyBody;
        private UnityEngine.GameObject _buyPremBody;
        private PGCompany.BattlePass.BattlePassChallengeView _challengeView;
        private UILabel _rewardCountLabel;
        private UnityEngine.GameObject _beforeLevel3Obj;
        private UILabel _bpLevelRequiredLabel;
        private UnityEngine.GameObject _tutorialObj;
        private UnityEngine.GameObject _isNewMark;
        
        // Properties
        private System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄 { get; set; }
        public string 丕一七不东一丌不万 { get; set; }
        internal PGCompany.BattlePass.丟丗丝且丕业丑丄丗 丄专三丗丄七丂丌七 { set; }
        
        // Methods
        private System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丄丄丆东丑三丝专丂()
        {
            var val_4;
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_5;
            val_4 = this;
            if(this.丆世且上丂丙丂丛丆 == 1)
            {
                    if(Initializer.丑七不且上丗丁一世() != 0)
            {
                    val_4 = Initializer.丑七不且上丗丁一世();
                val_5 = val_3.丌与丄丑丄业丁丘丄;
                return (System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)this.丘业业丒一丅东专丅.SyncRoot;
            }
            
            }
            
            val_5 = this.丘业业丒一丅东专丅;
            return (System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)this.丘业业丒一丅东专丅.SyncRoot;
        }
        private void 丙丁万与一丒三下丞(System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丙业与丙丗丝不丈东)
        {
            UnityEngine.Object val_4;
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_5;
            if(this.丆世且上丂丙丂丛丆 != 1)
            {
                goto label_6;
            }
            
            val_4 = Initializer.丑七不且上丗丁一世();
            if(val_4 == 0)
            {
                goto label_6;
            }
            
            Initializer val_3 = Initializer.丑七不且上丗丁一世();
            val_5 = val_3.丌与丄丑丄业丁丘丄;
            goto label_10;
            label_6:
            val_5 = this.丘业业丒一丅东专丅;
            label_10:
            mem2[0] = 丙业与丙丗丝不丈东;
        }
        public string get_BpGuiType()
        {
            return (string)this.<丂丏万丆三一且世与>k__BackingField;
        }
        private void 丂丙丗丄世下世丐东(string 丙业与丙丗丝不丈东)
        {
            this.<丂丏万丆三一且世与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丞下丅不且不业丈丕(PGCompany.BattlePass.丟丗丝且丕业丑丄丗 丙业与丙丗丝不丈东)
        {
            this.丆世且上丂丙丂丛丆 = 丙业与丙丗丝不丈东;
        }
        private void OnEnable()
        {
            this._challengeView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::且丁专三丁丙丛下万(PGCompany.BattlePass.BattlePassChallengeView 丟下与专丝丝东且丅)));
            this._challengeView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::且丁专三丁丙丛下万(PGCompany.BattlePass.BattlePassChallengeView 丟下与专丝丝东且丅)));
            CoroutineRunner.丕丑不丗上丁丝丕专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
            CoroutineRunner.与万且丗丆下丁且丂(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
            GameConnect.万上与丑丁与丕丟一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丆丂东丕专万丆上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            GameConnect.丞且丛东不丈下且东(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丆丂东丕专万丆上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丞丒万丅丑一丂丆()));
            PGCompany.BattlePass.BPTutorialController.业丙丘丈丁一丛专丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丞丒万丅丑一丂丆()));
            if(this.专世下东东丛丁上丙 != null)
            {
                    this.StopCoroutine(routine:  this.专世下东东丛丁上丙);
            }
            
            this.专世下东东丛丁上丙 = this.StartCoroutine(routine:  this.七丘丂丏丟丐不一丕());
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_12 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_12 == null)
            {
                    return;
            }
            
            this.<丂丏万丆三一且世与>k__BackingField = val_12.丕世丝七世与三丞一();
        }
        private void 丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)
        {
            if(this.专世下东东丛丁上丙 != null)
            {
                    this.StopCoroutine(routine:  this.专世下东东丛丁上丙);
            }
            
            if(丆丕与三丝丙丑丛三 != false)
            {
                    return;
            }
            
            this.OnEnable();
        }
        private void OnDisable()
        {
            CoroutineRunner.丕丑不丗上丁丝丕专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
            GameConnect.万上与丑丁与丕丟一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丆丂东丕专万丆上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丞丒万丅丑一丂丆()));
            this.丐三且丅七且丆世丐 = 0;
            if(this.丆丑东丒丟丒下丑丄 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丆丑东丒丟丒下丑丄);
            this.丆丑东丒丟丒下丑丄 = 0;
        }
        private void OnDestroy()
        {
            CoroutineRunner.丕丑不丗上丁丝丕专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
            GameConnect.万上与丑丁与丕丟一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丆丂东丕专万丆上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassConnectScene::丝丞丒万丅丑一丂丆()));
        }
        private void 丝丆丂东丕专万丆上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.专世下东东丛丁上丙 != null)
            {
                    this.StopCoroutine(routine:  this.专世下东东丛丁上丙);
            }
            
            this.专世下东东丛丁上丙 = this.StartCoroutine(routine:  this.七丘丂丏丟丐不一丕());
        }
        private void 丝丞丒万丅丑一丂丆()
        {
            this.丕丕业七丙七丅丈丄();
        }
        private System.Collections.IEnumerator 七丘丂丏丟丐不一丕()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassConnectScene.丞丆且且丄丝业丘丅();
        }
        private void 丕丕业七丙七丅丈丄()
        {
            var val_33;
            var val_54;
            var val_72;
            var val_73;
            var val_74;
            System.Predicate<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_76;
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_86;
            var val_87;
            var val_88;
            var val_89;
            BattlePassConnectScene.丌丐丝丐下上三丛丌 val_1 = new BattlePassConnectScene.丌丐丝丐下上三丛丌();
            if(FriendsController.丝丗专上三不丄丑丑() > 0)
            {
                    PGCompany.BattlePass.上丕丁专三丗丝万丆 val_4 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
                if(val_4 != null)
            {
                    if(val_4.丗丄上丑丑丅丐丒丌() == false)
            {
                goto label_6;
            }
            
            }
            
            }
            
            label_124:
            label_140:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  false);
            return;
            label_6:
            val_72 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  true);
            if((PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != true) && (PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() != false))
            {
                    if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() == 1)
            {
                    if(this.丆世且上丂丙丂丛丆 != 1)
            {
                goto label_20;
            }
            
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialObj, 丏业丟一东丂东丘丛:  false);
            label_98:
            if(this.丆世且上丂丙丂丛丆 != 0)
            {
                    val_73 = null;
                val_73 = null;
                if((System.Linq.Enumerable.Contains<Rilisoft.七丕丟丏三丈一丄世>(source:  GameConnect.丘丗世专不丅与丗丒, value:  GameConnect.丑丌丛丈丅丅与不业())) != false)
            {
                    val_74 = null;
                val_74 = null;
                val_76 = BattlePassConnectScene.<>c.<>9__22_0;
                if(val_76 == null)
            {
                    System.Predicate<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_12 = null;
                val_76 = val_12;
                val_12 = new System.Predicate<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(object:  BattlePassConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassConnectScene.<>c::丂丟丌下丗东丛业下(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
                BattlePassConnectScene.<>c.<>9__22_0 = val_76;
            }
            
                int val_13 = this.丄丄丆东丑三丝专丂().RemoveAll(match:  val_12);
            }
            
            }
            
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_15 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
            .业丕丙且丝世且丆万 = val_15;
            if(this.丆世且上丂丙丂丛丆 == 0)
            {
                goto label_37;
            }
            
            label_58:
            val_77 = 0;
            label_109:
            if(this.丄丄丆东丑三丝专丂().Count < 1)
            {
                goto label_126;
            }
            
            var val_73 = 0;
            val_77 = this.丄丄丆东丑三丝专丂().Item[0];
            if(val_77.业上丙丞丐丄丆丅七() != 9999)
            {
                goto label_42;
            }
            
            val_78 = null;
            val_78 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_53;
            }
            
            val_79 = null;
            val_79 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟.下丑与丆三丝不丗一() == false) || (this.丈一丗丝丄业与丅丆.世三丞丅丑丌丈丈一() > 0))
            {
                goto label_53;
            }
            
            this.丈一丗丝丄业与丅丆.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  1);
            UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  this.与一丟丏丐丐上丐且());
            if(val_77 != null)
            {
                goto label_88;
            }
            
            goto label_56;
            label_37:
            if(val_15.Count < 1)
            {
                goto label_58;
            }
            
            val_77 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  val_1, method:  System.Boolean BattlePassConnectScene.丌丐丝丐下上三丛丌::丑丌丙丛丕丞丌丈丘(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙)));
            List.Enumerator<T> val_31 = (BattlePassConnectScene.丌丐丝丐下上三丛丌)[1152921560068828672].业丕丙且丝世且丆万.GetEnumerator();
            val_80 = 0;
            val_81 = 0;
            val_82 = 0;
            label_78:
            if(((-372637280) & 1) == 0)
            {
                goto label_63;
            }
            
            string val_34 = val_33.丐丏七丌丕丗业且上();
            if(0 == 0)
            {
                goto label_78;
            }
            
            List.Enumerator<T> val_35 = 0.GetEnumerator();
            goto label_68;
            label_69:
            string val_36 = val_33.丐丏七丌丕丗业且上();
            if(val_36 != null)
            {
                    if(val_36.Type == 1100)
            {
                    val_82 = 0;
            }
            
            }
            
            label_68:
            if(((-372637312) & 1) != 0)
            {
                goto label_69;
            }
            
            val_83 = val_81;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_72 = 1;
            if((val_72 == 1) || (387 != 387))
            {
                goto label_75;
            }
            
            val_72 = val_72 +  ^ 0;
            goto label_78;
            label_75:
            if( == 0)
            {
                goto label_78;
            }
            
            goto label_78;
            label_42:
            if(((this.丄丄丆东丑三丝专丂().Count >= 1) && (this.丐三且丅七且丆世丐 != null)) && (this.丐三且丅七且丆世丐 == val_77))
            {
                    bool val_44 = this.丄丄丆东丑三丝专丂().Remove(item:  val_77);
                this.丄丄丆东丑三丝专丂().Add(item:  val_77);
                val_77 = this.丄丄丆东丑三丝专丂().Item[0];
            }
            
            bool val_49 = this.丄丄丆东丑三丝专丂().Remove(item:  val_77);
            this.丄丄丆东丑三丝专丂().Add(item:  val_77);
            label_53:
            if(val_77 != null)
            {
                goto label_88;
            }
            
            label_56:
            label_88:
            List.Enumerator<T> val_52 = val_77.丈丏丁东上与东丙丕().GetEnumerator();
            goto label_92;
            label_93:
            string val_55 = val_54.丐丏七丌丕丗业且上();
            if(val_55 != null)
            {
                    if(val_55.Type == 1100)
            {
                    int val_58 = val_55.Count + (val_36.Count + 0);
            }
            
            }
            
            label_92:
            if(((-372637312) & 1) != 0)
            {
                goto label_93;
            }
            
            val_73 = val_73 + 1;
            val_86 = 0;
            mem2[0] = 695;
            goto label_94;
            label_63:
            val_87 = val_72 + 1;
            mem2[0] = 695;
            val_72 = 1152921505284374528;
            goto label_95;
            label_20:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialObj, 丏业丟一东丂东丘丛:  true);
            goto label_98;
            label_95:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if((1152921560068784432 + ((1 + (val_82 ^ 0))) << 2) == 695)
            {
                goto label_126;
            }
            
            }
            
            if( == null)
            {
                goto label_109;
            }
            
            goto label_109;
            label_94:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.丆世且上丂丙丂丛丆 == 1)
            {
                goto label_111;
            }
            
            if((null == null) || (mem[1152921558578284112] == 695))
            {
                goto label_126;
            }
            
            label_125:
            label_126:
            if(val_1 == null)
            {
                goto label_114;
            }
            
            this.丐三且丅七且丆世丐 = val_1;
            this._challengeView.丅与丟丄业三丅丁丞 = true;
            this._challengeView.Setup(与且专丈不万东一万:  val_1);
            if(this._isNewMark == 0)
            {
                goto label_119;
            }
            
            if(val_1.丏丂丁丗下七丕专丆() == false)
            {
                goto label_120;
            }
            
            var val_61 = (this.丆世且上丂丙丂丛丆 == 0) ? 1 : 0;
            goto label_121;
            label_114:
            if(val_4.专丟专一丒且丘与丌() != 0)
            {
                goto label_124;
            }
            
            if(this.丆世且上丂丙丂丛丆 == 0)
            {
                goto label_134;
            }
            
            goto label_124;
            label_111:
            if(null != null)
            {
                goto label_125;
            }
            
            goto label_126;
            label_120:
            val_88 = 0;
            label_121:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._isNewMark, 丏业丟一东丂东丘丛:  false);
            label_119:
            if(val_58 >= 1)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._rewardCountLabel, 丕丗丘丑丛与丑业丒:  val_58.ToString());
            }
            
            if(val_4.专丟专一丒且丘与丌() == 0)
            {
                    if(val_1.丏丐七上业丆与丘专() == 1)
            {
                    if(this.丆世且上丂丙丂丛丆 == 0)
            {
                goto label_134;
            }
            
            }
            
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._challengeBody, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._buyPremBody, 丏业丟一东丂东丘丛:  false);
            val_89 = 0;
            if(val_1.丁丒业丐丞业丒丟丙() != false)
            {
                    bool val_67 = (this.丆世且上丂丙丂丛丆 == 0) ? 1 : 0;
            }
            
            PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄 val_68 = val_1.丏丐七上业丆与丘专();
            var val_69 = (val_68 == 1) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._challengeReadyBody, 丏业丟一东丂东丘丛:  val_67);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._challengeMainBody, 丏业丟一东丂东丘丛:  (val_67 == 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeObj, 丏业丟一东丂东丘丛:  (val_68 != 1) ? 1 : 0);
            goto label_140;
            label_134:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._challengeBody, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._buyPremBody, 丏业丟一东丂东丘丛:  true);
        }
        private System.Collections.IEnumerator 与一丟丏丐丐上丐且()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassConnectScene.丒丕丛与丂丏丒三下();
        }
        public void U_NextChallnege()
        {
            this.丕丕业七丙七丅丈丄();
        }
        internal static System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 与业下丏丂上三丗丗(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, bool 不丌丒丆丞下丙专万 = True)
        {
            var val_23;
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_37;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_38;
            var val_39;
            var val_40;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_42;
            var val_43;
            var val_44;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_46;
            var val_47;
            val_37 = 不丌丒丆丞下丙专万;
            .丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_2 = new System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>();
            val_38 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_38 == null)
            {
                    return val_2;
            }
            
            if(val_38.丗丄上丑丑丅丐丒丌() == true)
            {
                    return val_2;
            }
            
            if(val_38.专丁丟丏丁丏不丗三() == false)
            {
                    return val_2;
            }
            
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return val_2;
            }
            
            val_39 = 1152921505136771072;
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_9 = BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂();
            if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() == false)
            {
                goto label_23;
            }
            
            val_40 = null;
            val_40 = null;
            val_42 = BattlePassConnectScene.<>c.<>9__25_1;
            if(val_42 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_13 = null;
                val_42 = val_13;
                val_13 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassConnectScene.<>c::丒丈丘不丕丆世丌业(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassConnectScene.<>c.<>9__25_1 = val_42;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_14 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_13);
            if(val_14 == null)
            {
                goto label_23;
            }
            
            val_43 = val_14.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万();
            if(val_43.世丑丐丅丆丂丘不丁() == false)
            {
                goto label_26;
            }
            
            label_23:
            if(val_37 == false)
            {
                goto label_49;
            }
            
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_19 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
            if(val_19.Count < 1)
            {
                goto label_49;
            }
            
            List.Enumerator<T> val_21 = val_19.GetEnumerator();
            val_43 = 1152921536721196464;
            val_39 = 1152921536721197488;
            label_36:
            if(((-371948000) & 1) == 0)
            {
                goto label_34;
            }
            
            new BattlePassConnectScene.一丛丕万丞丗丈上丒() = new System.Object();
            .东七上世万下丗丄丛 = val_23.丐丏七丌丕丗业且上();
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_26 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BattlePassConnectScene.一丛丕万丞丗丈上丒(), method:  System.Boolean BattlePassConnectScene.一丛丕万丞丗丈上丒::丟丁丅丟业丁且下上(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            val_37 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_9, predicate:  null);
            if(val_37 == null)
            {
                goto label_36;
            }
            
            val_2.Add(item:  val_37);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_2;
            label_26:
            val_2.Add(item:  val_14);
            return val_2;
            label_34:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_49:
            val_43 = 1152921504616005632;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_28 = null;
            val_37 = val_28;
            val_28 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BattlePassConnectScene.丄丆丌丌丕丈丆丆业(), method:  System.Boolean BattlePassConnectScene.丄丆丌丌丕丈丆丆业::不万专丑东丟世专丏(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            System.Collections.Generic.IEnumerable<TSource> val_29 = System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_9, predicate:  val_28);
            if((System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_29)) == false)
            {
                    return val_2;
            }
            
            if(val_38.专丟专一丒且丘与丌() == 100)
            {
                    val_44 = null;
                val_44 = null;
                val_46 = BattlePassConnectScene.<>c.<>9__25_4;
                if(val_46 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_32 = null;
                val_46 = val_32;
                val_32 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassConnectScene.<>c::丑丗与与丙丂丙丘且(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassConnectScene.<>c.<>9__25_4 = val_46;
            }
            
                val_2.AddRange(collection:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_29, predicate:  val_32));
            }
            
            val_37 = 1152921505681764352;
            val_47 = null;
            val_47 = null;
            val_38 = BattlePassConnectScene.<>c.<>9__25_3;
            if(val_38 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_34 = null;
                val_38 = val_34;
                val_34 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassConnectScene.<>c::丁丁三丄丙丗一与万(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassConnectScene.<>c.<>9__25_3 = val_38;
            }
            
            val_2.AddRange(collection:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_29, predicate:  val_34));
            return val_2;
        }
        public void PlayToBattleButtonAnimation()
        {
            var val_7;
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            val_7 = static_value_081DACA8;
            val_7 = static_value_081DACA8;
            val_8 = mem[static_value_081DACA8 + 184 + 16];
            val_8 = static_value_081DACA8 + 184 + 16;
            if(val_8 == 0)
            {
                    return;
            }
            
            val_9 = static_value_081DACA8;
            val_9 = static_value_081DACA8;
            val_8 = mem[static_value_081DACA8 + 184 + 16 + 64 + 24];
            val_8 = static_value_081DACA8 + 184 + 16 + 64 + 24;
            if(val_8 == 0)
            {
                    return;
            }
            
            val_10 = static_value_081DACA8;
            val_10 = static_value_081DACA8;
            UITweener val_3 = static_value_081DACA8 + 184 + 16 + 64 + 24.GetComponentInChildren<UITweener>();
            if(val_3 != 0)
            {
                    val_3.PlayForward();
            }
            
            InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
            PGCompany.BattlePass.BattlePassHelpBanner.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  val_5.infoWindowCamera.transform);
        }
        private void 且丁专三丁丙丛下万(PGCompany.BattlePass.BattlePassChallengeView 丟下与专丝丝东且丅)
        {
            var val_21;
            int val_22;
            if(this.丆世且上丂丙丂丛丆 != 0)
            {
                    return;
            }
            
            bool val_1 = UnityEngine.Object.op_Equality(x:  丟下与专丝丝东且丅, y:  0);
            if((val_1 == true) || (丟下与专丝丝东且丅.Context == null))
            {
                goto label_14;
            }
            
            if(丟下与专丝丝东且丅.Context.业上丙丞丐丄丆丅七() == 9999)
            {
                    if(丟下与专丝丝东且丅.Context.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == false)
            {
                goto label_14;
            }
            
            }
            
            if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
            {
                    if(BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() == true)
            {
                    return;
            }
            
            }
            
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  2);
            val_21 = null;
            val_21 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 = 丟下与专丝丝东且丅.Context.业上丙丞丐丄丆丅七();
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 2;
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  31, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            if(丟下与专丝丝东且丅.Context.三丝丄丈丆丂专丄东() != 20)
            {
                goto label_35;
            }
            
            val_22 = 1;
            goto label_36;
            label_14:
            val_1.PlayToBattleButtonAnimation();
            return;
            label_35:
            val_22 = ((丟下与专丝丝东且丅.Context.三丝丄丈丆丂专丄东() == 30) ? 1 : 0) << 1;
            label_36:
            PGCompany.BattlePass.BattlePassChallangesUI.丟丄丐一七东不丁且(丙业与丙丗丝不丈东:  val_22);
        }
        public void BuyPrem()
        {
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  1);
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 2;
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  31, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        public BattlePassConnectScene()
        {
            this.丘业业丒一丅东专丅 = new System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>();
            this.丈一丗丝丄业与丅丆 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "connectscene-_tutorialAnimationViewed");
        }
    
    }

}
