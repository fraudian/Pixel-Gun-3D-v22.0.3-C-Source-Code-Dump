using UnityEngine;
internal sealed class BattlePassProgressView : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _holder;
    private UILabel _levelLabel;
    private UnityEngine.GameObject _lockContainer;
    private UnityEngine.GameObject _comingSoonContainer;
    private UnityEngine.GameObject _needLevelContainer;
    private UILabel _needLevelLabel;
    private lockedOnProgressUI lockedUI;
    private UnityEngine.GameObject _tutorialContainer;
    private UILabel _tutorialLabel;
    private UnityEngine.GameObject _unLockContainer;
    private UISprite _progressSprite;
    private UILabel _progressLabel;
    private UnityEngine.GameObject _silverShield;
    private UnityEngine.GameObject _goldShield;
    private PGCompany.TimerUI _timer;
    private UILabel _seasonEndLabel;
    private UnityEngine.GameObject _bgYellow;
    private UnityEngine.GameObject _bgGrey;
    private UnityEngine.GameObject _stateOnSeasonEnd;
    private LobbyButton _lobbyButton;
    private LobbyButtonHint _lobbyButtonHint;
    private PGCompany.丝专丝丝与一上三丅 丙丛下业丗专丝与丞;
    private PGCompany.BattlePass.上丕丁专三丗丝万丆 丘丞世丒世七丆且东;
    
    // Properties
    private PGCompany.丝专丝丝与一上三丅 丗丄丁与专专一丝万 { get; }
    
    // Methods
    private void OnEnable()
    {
        this.丈且东丑丂且万丒丅();
        PGCompany.丝专丝丝与一上三丅 val_1 = this.丞丐专丐且一丝丑三();
        this.丞丐专丐且一丝丑三().七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丘丘丙丒丛丈丟丕丛()));
        BattlePassController.万且丟丘丐丑丏且专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        BattlePassController.丙七一丄下专丏不丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void BattlePassProgressView::丒不丕丒丕一丈丄丕(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 丛丆东与丑丞丅丝专, object 不丁丌丐业丑丟且不)));
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        PGCompany.PixelPass.丘丏丅丆丑下业丙七.东丄与丘丏专七世与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
    }
    private void OnDestroy()
    {
        BattlePassController.下丟丐丙丌世丆丌丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        BattlePassController.业丏专与丝不东丁一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void BattlePassProgressView::丒不丕丒丕一丈丄丕(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 丛丆东与丑丞丅丝专, object 不丁丌丐业丑丟且不)));
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        PGCompany.PixelPass.丘丏丅丆丑下业丙七.丛丈丟丟世世上丞七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丈且东丑丂且万丒丅()));
        PGCompany.丝专丝丝与一上三丅 val_7 = this.丞丐专丐且一丝丑三();
        this.丞丐专丐且一丝丑三().与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BattlePassProgressView::丘丘丙丒丛丈丟丕丛()));
    }
    private PGCompany.丝专丝丝与一上三丅 丞丐专丐且一丝丑三()
    {
        PGCompany.丝专丝丝与一上三丅 val_6 = this.丙丛下业丗专丝与丞;
        if(val_6 != null)
        {
                return val_6;
        }
        
        if((PGCompany.世专三丑丘丗丂丅丞.丑七不且上丗丁一世().丝丒专丙世与三丌丞(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 10, 丏丟丑丙七东专丌丏 = false, 丒丂丌丑丟东东丒专 = false})) != null)
        {
                val_6 = 0;
        }
        
        this.丙丛下业丗专丝与丞 = val_6;
        return val_6;
    }
    private void 丈且东丑丂且万丒丅()
    {
        UnityEngine.GameObject val_26;
        UnityEngine.GameObject val_27;
        var val_28;
        var val_29;
        var val_30;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_32;
        UILabel val_33;
        object val_34;
        string val_35;
        Rilisoft.丝丑丂丛万丐丈丘且 val_36;
        val_26 = this;
        if(PixelTime.丝丗专上三不丄丑丑() >= 1)
        {
                if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏() == false)
        {
            goto label_5;
        }
        
        }
        
        label_55:
        val_26 = this._holder;
        val_27 = val_26;
        val_28 = 0;
        goto label_8;
        label_5:
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_5 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        this.丘丞世丒世七丆且东 = val_5;
        if(val_5 != null)
        {
                if(val_5.丌丈一丘上丕丏东丛() == false)
        {
            goto label_11;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unLockContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._needLevelContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialContainer, 丏业丟一东丂东丘丛:  false);
        val_27 = this._comingSoonContainer;
        val_28 = 1;
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  true);
        return;
        label_11:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
        if(val_5.专丁丟丏丁丏不丗三() == false)
        {
            goto label_16;
        }
        
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != true)
        {
                if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() <= 2)
        {
            goto label_22;
        }
        
        }
        
        label_33:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unLockContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  false);
        this.丅丞丛专丐三东世不(业三丒一丄丒丌丗且:  val_5);
        this.上不丕丌丄世丆丘丘(业三丒一丄丒丌丗且:  val_5);
        this.上丛业丙丙七丒丝丁(业三丒一丄丒丌丗且:  val_5);
        this.丘丘丙丒丛丈丟丕丛();
        return;
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unLockContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._needLevelContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._comingSoonContainer, 丏业丟一东丂东丘丛:  false);
        if(this.lockedUI == null)
        {
            goto label_28;
        }
        
        if(val_5.丐丟东专丒丈一丅丕() == null)
        {
            goto label_29;
        }
        
        val_29 = val_10.Progress;
        goto label_30;
        label_22:
        if(val_5.丗丄上丑丑丅丐丒丌() != false)
        {
                if(val_5.丌丈一丘上丕丏东丛() != true)
        {
                if(val_5.丄专世丈丄业专与业() == true)
        {
            goto label_33;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unLockContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._needLevelContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialContainer, 丏业丟一东丂东丘丛:  (~val_5.丗丄上丑丑丅丐丒丌()) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._comingSoonContainer, 丏业丟一东丂东丘丛:  false);
        val_30 = null;
        val_30 = null;
        val_32 = BattlePassProgressView.<>c.<>9__27_0;
        if(val_32 == null)
        {
                System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_18 = null;
            val_32 = val_18;
            val_18 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassProgressView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassProgressView.<>c::丒丛丄丛丈丅上万业(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            BattlePassProgressView.<>c.<>9__27_0 = val_32;
        }
        
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_19 = System.Linq.Enumerable.First<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_18);
        if(val_19 == null)
        {
            goto label_55;
        }
        
        val_33 = this._tutorialLabel;
        Rilisoft.丝丑丂丛万丐丈丘且 val_22 = val_19.丁专丗万三上丟三丆().PointsToCompleteContainer;
        val_34 = val_22.七丄不丐丗三丝丑一;
        val_35 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6443");
        goto label_48;
        label_29:
        val_29 = 0;
        label_30:
        this.lockedUI.丈且东丑丂且万丒丅(上丕丈丞丌丘丅不与:  0);
        label_28:
        val_33 = this._needLevelLabel;
        if(val_5.丐丟东专丒丈一丅丕() != null)
        {
                val_36 = val_24.Progress;
        }
        
        val_34 = val_36;
        val_35 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11673");
        label_48:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_33, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_35, arg0:  val_36));
    }
    private void 丅丞丛专丐三东世不(PGCompany.BattlePass.上丕丁专三丗丝万丆 业三丒一丄丒丌丗且)
    {
        if(业三丒一丄丒丌丗且 == null)
        {
                return;
        }
        
        PlayerPaymentState val_1 = 业三丒一丄丒丌丗且.专丟专一丒且丘与丌();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._silverShield, 丏业丟一东丂东丘丛:  (val_1 != 100) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._goldShield, 丏业丟一东丂东丘丛:  (val_1 == 100) ? 1 : 0);
    }
    private void 上不丕丌丄世丆丘丘(PGCompany.BattlePass.上丕丁专三丗丝万丆 业三丒一丄丒丌丗且)
    {
        int val_14;
        float val_16;
        if(业三丒一丄丒丌丗且 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  业三丒一丄丒丌丗且.业丈丅丂且丁与丄丂().ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}", arg0:  PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().不丑丒丟丘不且七万()));
        val_14 = 业三丒一丄丒丌丗且.丞专三世丑丗丘专丐();
        int val_7 = 业三丒一丄丒丌丗且.一不丁丏万丂丑三不();
        if(业三丒一丄丒丌丗且.丐丞上丒七丞丁丙丕() != false)
        {
                string val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2547");
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_14, arg1:  val_7));
        if(this._progressSprite == 0)
        {
                return;
        }
        
        if(业三丒一丄丒丌丗且.丐丞上丒七丞丁丙丕() == false)
        {
            goto label_16;
        }
        
        val_16 = 1f;
        if(this._progressSprite != null)
        {
            goto label_19;
        }
        
        goto label_18;
        label_16:
        val_16 = (float)val_14 / (float)val_7;
        if(this._progressSprite != null)
        {
            goto label_19;
        }
        
        label_18:
        label_19:
        this._progressSprite.fillAmount = val_16;
    }
    private void 上丛业丙丙七丒丝丁(PGCompany.BattlePass.上丕丁专三丗丝万丆 业三丒一丄丒丌丗且)
    {
        UILabel val_7;
        UILabel val_8;
        bool val_9;
        val_7 = this;
        if(业三丒一丄丒丌丗且 == null)
        {
                return;
        }
        
        if(this._timer == 0)
        {
                return;
        }
        
        System.Nullable<System.TimeSpan> val_2 = 业三丒一丄丒丌丗且.丙世丑丅丒丑业与不();
        if(((1700963312 & 1) != 0) && (val_2.HasValue.TotalSeconds > 0f))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timer, 丏业丟一东丂东丘丛:  true);
            this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  (int)val_2.HasValue.TotalSeconds, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_8 = this._seasonEndLabel;
            val_9 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timer, 丏业丟一东丂东丘丛:  false);
            val_7 = this._seasonEndLabel;
            val_9 = 业三丒一丄丒丌丗且.丗丄上丑丑丅丐丒丌();
            val_8 = val_7;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  val_9);
    }
    private void 丘丘丙丒丛丈丟丕丛()
    {
        UnityEngine.GameObject val_6;
        bool val_7;
        UnityEngine.GameObject val_8;
        val_6 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateOnSeasonEnd, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bgYellow, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bgGrey, 丏业丟一东丂东丘丛:  false);
        if(this.丘丞世丒世七丆且东 == null)
        {
                return;
        }
        
        if(this.丘丞世丒世七丆且东.丗丄上丑丑丅丐丒丌() != false)
        {
                val_6 = this._stateOnSeasonEnd;
            val_7 = 1;
            val_8 = val_6;
        }
        else
        {
                bool val_3 = this.丞丐专丐且一丝丑三().不丌丈专丟丒丕专丏();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bgYellow, 丏业丟一东丂东丘丛:  val_3);
            val_8 = this._bgGrey;
            val_7 = (~val_3) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  val_7);
    }
    private void 丒不丕丒丕一丈丄丕(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 丛丆东与丑丞丅丝专, object 不丁丌丐业丑丟且不)
    {
        this.丈且东丑丂且万丒丅();
    }
    public void U_OpenBattlePass()
    {
        UnityEngine.GameObject val_10;
        BannerWindowType val_11;
        var val_12;
        val_10 = this._holder;
        if(val_10.activeSelf == false)
        {
                return;
        }
        
        val_10 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_10 == null)
        {
                return;
        }
        
        if(val_10.丗丄上丑丑丅丐丒丌() != false)
        {
                if(val_10.丌丈一丘上丕丏东丛() == true)
        {
                return;
        }
        
            val_10 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_11 = 32;
            val_12;
        }
        else
        {
                val_10 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_10 != 0)
        {
                return;
        }
        
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  1);
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 1;
            val_10 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_11 = 31;
        }
        
        val_10.ForceShowBanner(丌丅丕一丛丛丄一万:  val_11, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public void U_LockedPressed()
    {
        LobbyButtonHint val_5;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_2 == null)
        {
                return;
        }
        
        if(this._lobbyButton == 0)
        {
                return;
        }
        
        if(val_2.专丁丟丏丁丏不丗三() != false)
        {
                return;
        }
        
        if(this._lobbyButtonHint != null)
        {
                this._lobbyButtonHint.丈且东丑丂且万丒丅(一丑不丞丟丑东丗丛:  this._lobbyButton);
            val_5 = this._lobbyButtonHint;
        }
        else
        {
                val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
    }
    public BattlePassProgressView()
    {
    
    }

}
