using UnityEngine;
public class ClanWarConnectScene : ChallangeConnectSceneAbstract
{
    // Fields
    private UnityEngine.GameObject 丆丑东丒丟丒下丑丄;
    private PGCompany.世丐下丕专东丘丏且 丝丛下丝一丆丙七七;
    internal bool 且丄丒与上丑丅丈下;
    private PGCompany.BattlePass.三丛上丁丗丌丆丌东 丐三且丅七且丆世丐;
    private UnityEngine.Coroutine 专世下东东丛丁上丙;
    private Rilisoft.且丈丞一丞丟与上七 丈一丗丝丄业与丅丆;
    private string <丂丏万丆三一且世与>k__BackingField;
    private PGCompany.BattlePass.丟丗丝且丕业丑丄丗 丆世且上丂丙丂丛丆;
    private UnityEngine.GameObject _body;
    private UnityEngine.GameObject _challengeBody;
    private UnityEngine.GameObject _challengeMainBody;
    private UnityEngine.GameObject _challengeReadyBody;
    internal ClanWarChallangeView _challengeView;
    private UILabel _currentTaskIdLabel;
    private UnityEngine.GameObject _isNewMark;
    
    // Properties
    public string 丕一七不东一丌不万 { get; set; }
    internal PGCompany.BattlePass.丟丗丝且丕业丑丄丗 丄专三丗丄七丂丌七 { set; }
    
    // Methods
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
        this._challengeView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<ClanWarChallangeView>(object:  this, method:  System.Void ClanWarConnectScene::且丁专三丁丙丛下万(ClanWarChallangeView 丟下与专丝丝东且丅)));
        this._challengeView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<ClanWarChallangeView>(object:  this, method:  System.Void ClanWarConnectScene::且丁专三丁丙丛下万(ClanWarChallangeView 丟下与专丝丝东且丅)));
        CoroutineRunner.丕丑不丗上丁丝丕专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanWarConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
        CoroutineRunner.与万且丗丆下丁且丂(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanWarConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
        PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarConnectScene::丝丞丒万丅丑一丂丆()));
        PGCompany.BattlePass.BPTutorialController.业丙丘丈丁一丛专丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarConnectScene::丝丞丒万丅丑一丂丆()));
        if(this.专世下东东丛丁上丙 != null)
        {
                this.StopCoroutine(routine:  this.专世下东东丛丁上丙);
        }
        
        this.专世下东东丛丁上丙 = this.StartCoroutine(routine:  this.七丘丂丏丟丐不一丕());
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_10 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_10 == null)
        {
                return;
        }
        
        this.<丂丏万丆三一且世与>k__BackingField = val_10.丕世丝七世与三丞一();
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
        CoroutineRunner.丕丑不丗上丁丝丕专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanWarConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
        PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarConnectScene::丝丞丒万丅丑一丂丆()));
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
        CoroutineRunner.丕丑不丗上丁丝丕专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanWarConnectScene::丆专丅丐丌三丑上三(bool 丆丕与三丝丙丑丛三)));
        PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarConnectScene::丝丞丒万丅丑一丂丆()));
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
        return (System.Collections.IEnumerator)new ClanWarConnectScene.东丞丌业丅丑专下三();
    }
    private void 丕丕业七丙七丅丈丄()
    {
        if(FriendsController.丝丗专上三不丄丑丑() > 0)
        {
                PGCompany.ClanWarController val_2 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_2 != 0)
        {
                if(val_2.丝且丗丌丟丈世上万() != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  true);
            if((val_2.丝且丗丌丟丈世上万() == null) || (val_2.万丅一丟丑丆世丞且 == null))
        {
            goto label_22;
        }
        
            this._challengeView.丟丗丘丄丘丝丌上丞 = this.且丄丒与上丑丅丈下;
            this._challengeView.Setup(与且专丈不万东一万:  val_2.万丅一丟丑丆世丞且);
            PGCompany.丟丒丅丐万丈七且万 val_6 = val_2.万丅一丟丑丆世丞且.世丈丁业丛上丘丗丐();
            this._currentTaskIdLabel.text = val_6.三丘丛三丂丙七东一;
            return;
        }
        
        }
        
        }
        
        label_22:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.IEnumerator 与一丟丏丐丐上丐且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanWarConnectScene.丅丟三东专丆丏不丏();
    }
    public void U_NextChallnege()
    {
        this.丕丕业七丙七丅丈丄();
    }
    internal static System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 与业下丏丂上三丗丗(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东, bool 不丌丒丆丞下丙专万 = True)
    {
        var val_23;
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_45;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_46;
        var val_47;
        var val_48;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_56;
        var val_57;
        var val_58;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_60;
        var val_61;
        var val_62;
        var val_63;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_65;
        var val_66;
        val_45 = 不丌丒丆丞下丙专万;
        ClanWarConnectScene.上三且上丁业与与丑 val_1 = new ClanWarConnectScene.上三且上丁业与与丑();
        .丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_2 = new System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>();
        val_46 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_46 == null)
        {
                return val_2;
        }
        
        if(val_46.丗丄上丑丑丅丐丒丌() == true)
        {
                return val_2;
        }
        
        if(val_46.专丁丟丏丁丏不丗三() == false)
        {
                return val_2;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
                return val_2;
        }
        
        val_47 = 1152921505136771072;
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_9 = BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂();
        if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() == false)
        {
            goto label_23;
        }
        
        val_48 = null;
        val_48 = null;
        val_50 = ClanWarConnectScene.<>c.<>9__23_2;
        if(val_50 == null)
        {
                System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_13 = null;
            val_50 = val_13;
            val_13 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  ClanWarConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarConnectScene.<>c::不业专上且丂不丁东(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            ClanWarConnectScene.<>c.<>9__23_2 = val_50;
        }
        
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_14 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_13);
        if(val_14 == null)
        {
            goto label_23;
        }
        
        val_51 = val_14.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万();
        if(val_51.世丑丐丅丆丂丘不丁() == false)
        {
            goto label_26;
        }
        
        label_23:
        if(val_45 == false)
        {
            goto label_49;
        }
        
        System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_19 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
        if(val_19.Count < 1)
        {
            goto label_49;
        }
        
        List.Enumerator<T> val_21 = val_19.GetEnumerator();
        val_51 = 1152921536721196464;
        val_47 = 1152921536721197488;
        label_36:
        if((2049676304 & 1) == 0)
        {
            goto label_34;
        }
        
        new ClanWarConnectScene.丑丛丑万与丆丝丞丐() = new System.Object();
        .东七上世万下丗丄丛 = val_23.丐丏七丌丕丗业且上();
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_26 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new ClanWarConnectScene.丑丛丑万与丆丝丞丐(), method:  System.Boolean ClanWarConnectScene.丑丛丑万与丆丝丞丐::丑丗不不丅下丟丆丆(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
        val_45 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_9, predicate:  null);
        if(val_45 == null)
        {
            goto label_36;
        }
        
        val_2.Add(item:  val_45);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_2;
        label_26:
        val_2.Add(item:  val_14);
        return val_2;
        label_34:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_49:
        val_51 = 1152921504616005632;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_28 = null;
        val_52 = 1152921536371862448;
        val_28 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  val_1, method:  System.Boolean ClanWarConnectScene.上三且上丁业与与丑::不万专丑东丟世专丏(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
        val_53 = 1152921536375919216;
        System.Collections.Generic.IEnumerable<TSource> val_29 = System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_9, predicate:  val_28);
        val_47 = 1152921536721226160;
        if((System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_29)) != false)
        {
                if(val_46.专丟专一丒且丘与丌() == 100)
        {
                val_54 = null;
            val_54 = null;
            val_56 = ClanWarConnectScene.<>c.<>9__23_5;
            if(val_56 == null)
        {
                val_57 = val_51;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_32 = null;
            val_56 = val_32;
            val_51 = ;
            val_32 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  ClanWarConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarConnectScene.<>c::下丁丘且七专丅不丛(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            ClanWarConnectScene.<>c.<>9__23_5 = val_56;
        }
        
            val_2.AddRange(collection:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_29, predicate:  val_32));
        }
        
            val_58 = null;
            val_58 = null;
            val_60 = ClanWarConnectScene.<>c.<>9__23_4;
            if(val_60 == null)
        {
                val_61 = val_52;
            val_62 = val_51;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_34 = null;
            val_60 = val_34;
            val_51 = ;
            val_52 = ;
            val_34 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  ClanWarConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarConnectScene.<>c::世与丕丌丑丈丞上丒(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            ClanWarConnectScene.<>c.<>9__23_4 = val_60;
            val_53 = 1152921536375919216;
        }
        
            val_2.AddRange(collection:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_29, predicate:  val_34));
        }
        
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_36 = null;
        val_45 = val_36;
        val_36 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  val_1, method:  System.Boolean ClanWarConnectScene.上三且上丁业与与丑::与丅丝丝丈丁丄丟丗(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
        System.Collections.Generic.IEnumerable<TSource> val_37 = System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_9, predicate:  val_36);
        if((System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_37)) == false)
        {
                return val_2;
        }
        
        if(val_46.专丟专一丒且丘与丌() == 100)
        {
                val_63 = null;
            val_63 = null;
            val_65 = ClanWarConnectScene.<>c.<>9__23_7;
            if(val_65 == null)
        {
                System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_40 = null;
            val_65 = val_40;
            val_40 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  ClanWarConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarConnectScene.<>c::三丈丕丂丙丆与丙丕(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            ClanWarConnectScene.<>c.<>9__23_7 = val_65;
        }
        
            val_2.AddRange(collection:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_37, predicate:  val_40));
        }
        
        val_45 = 1152921505153916928;
        val_66 = null;
        val_66 = null;
        val_46 = ClanWarConnectScene.<>c.<>9__23_6;
        if(val_46 == null)
        {
                System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_42 = null;
            val_46 = val_42;
            val_42 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  ClanWarConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanWarConnectScene.<>c::丞丂与丘丐丌三丑丈(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            ClanWarConnectScene.<>c.<>9__23_6 = val_46;
        }
        
        val_2.AddRange(collection:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_37, predicate:  val_42));
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
    private void 且丁专三丁丙丛下万(ClanWarChallangeView 丟下与专丝丝东且丅)
    {
    
    }
    public ClanWarConnectScene()
    {
        this.丈一丗丝丄业与丅丆 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "connectscene-_tutorialAnimationViewed");
    }

}
