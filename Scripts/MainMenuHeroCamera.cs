using UnityEngine;
internal sealed class MainMenuHeroCamera : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator 丐七七丏丁一丄丆丞;
    private Rilisoft.业业丛上世丄业上丐<MainMenuHeroCamera.业丟丝丗且丌丌东且> 业不三丛丄下业丄丑;
    private MainMenuHeroCamera.业丟丝丗且丌丌东且 _currentCameraPreset;
    private FortCameraAnimator 丑专丟且丐丙三东丕;
    private UnityEngine.Camera 与丟丏丒丟丏上丒丈;
    private UICamera 丂丏丕丕丑丑丄丗三;
    private static MainMenuHeroCamera <不丁丄七丛不丆丁丕>k__BackingField;
    private bool <与万下丁三且丝丁丅>k__BackingField;
    private static PGCompany.丝丆业不一丌东万世 东丐丅丞丄丙一与丄;
    private bool 三丐上丗丂一丑世丒;
    private UnityEngine.Coroutine 丝丈万业下丗上丟丌;
    private bool 世丞丌与丈丆丐万丌;
    private System.Collections.Generic.List<MainMenuHeroCamera.TasksGSMoveCameraItemsOverrideController> _tasksGSMoveCameraItemsOverrideControllers;
    private System.Collections.Generic.List<MainMenuHeroCamera.LobbyItemsOverrideController> _lobbyItemsOverrideControllers;
    private System.Collections.Generic.List<MainMenuHeroCamera.FortItemsOverrideController> _fortItemsOverrideControllers;
    private UnityEngine.Vector3 一丝一丘丘且专丒东;
    private UnityEngine.Quaternion 七丒东丂上丘丒丟丟;
    private float 东丗丐世丒丕丐丞丐;
    private float 世与丞丛丁丐一业七;
    private float _changePresetTime;
    private float _mixTimeSecs;
    private float 丅丟丛丄丆业丞丈丕;
    private MainMenuHeroCamera.业丟丝丗且丌丌东且 丂丈世丏下丕七丆丕;
    private UnityEngine.Vector3 _overridePositionIncrement;
    private UnityEngine.Vector3 _overrideRotationIncrement;
    private UnityEngine.Vector3 _lowPositionPreset;
    private UnityEngine.Vector3 _lowRotationPreset;
    private UnityEngine.Vector3 _hightPositionPreset;
    private UnityEngine.Vector3 _hightRotationPreset;
    private UnityEngine.Transform 丆东丙且下丁丗丆七;
    private bool 丙丞丆丑万一七万丂;
    private bool 与丙不专丁丗丒丂丄;
    
    // Properties
    internal static MainMenuHeroCamera 丆丕丝丒不丙且丐丗 { get; set; }
    private UnityEngine.Animator 丒上下丘丈万丛三丘 { get; }
    private FortCameraAnimator 专丁丘丑与丅东且万 { get; }
    internal UnityEngine.Camera 上万丗丘丌东丟丌与 { get; }
    internal UICamera 丆丏一专不丝丈丗上 { get; }
    internal bool 世东丕与东丅丒三万 { get; set; }
    internal static PGCompany.丝丆业不一丌东万世 业丟丂丙丅丒丟丌丞 { get; }
    private UnityEngine.Transform 丒丌丞丕丐丁丛专东 { get; }
    private bool 丐丞丐专一丙与万丕 { get; }
    
    // Methods
    internal static MainMenuHeroCamera 丑七不且上丗丁一世()
    {
        return (MainMenuHeroCamera)MainMenuHeroCamera.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(MainMenuHeroCamera 丙业与丙丗丝不丈东)
    {
        MainMenuHeroCamera.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private UnityEngine.Animator 且丙丏丘丒不丌丒下()
    {
        UnityEngine.Animator val_3;
        if(this.丐七七丏丁一丄丆丞 == 0)
        {
                this.丐七七丏丁一丄丆丞 = this.GetComponentInChildren<UnityEngine.Animator>();
            return val_3;
        }
        
        val_3 = this.丐七七丏丁一丄丆丞;
        return val_3;
    }
    private FortCameraAnimator 业七丟丝万丄丟丄丙()
    {
        FortCameraAnimator val_3;
        if(this.丑专丟且丐丙三东丕 == 0)
        {
                this.丑专丟且丐丙三东丕 = this.GetComponentInChildren<FortCameraAnimator>();
            return val_3;
        }
        
        val_3 = this.丑专丟且丐丙三东丕;
        return val_3;
    }
    internal UnityEngine.Camera 丝专丅业丗丁业世三()
    {
        UnityEngine.Camera val_3;
        if(this.与丟丏丒丟丏上丒丈 == 0)
        {
                this.与丟丏丒丟丏上丒丈 = this.GetComponentInChildren<UnityEngine.Camera>();
            return val_3;
        }
        
        val_3 = this.与丟丏丒丟丏上丒丈;
        return val_3;
    }
    internal UICamera 丑丏丘丛丑丆与三丟()
    {
        UICamera val_5;
        if(this.丂丏丕丕丑丑丄丗三 == 0)
        {
                this.丂丏丕丕丑丑丄丗三 = this.丝专丅业丗丁业世三().gameObject.GetComponent<UICamera>();
            return val_5;
        }
        
        val_5 = this.丂丏丕丕丑丑丄丗三;
        return val_5;
    }
    internal bool 丘丈丙专上上三上丒()
    {
        return (bool)this.<与万下丁三且丝丁丅>k__BackingField;
    }
    private void 东丕丂丒不丙丌丅丄(bool 丙业与丙丗丝不丈东)
    {
        this.<与万下丁三且丝丁丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static PGCompany.丝丆业不一丌东万世 丈丌世世丆丆丁丗下()
    {
        return (PGCompany.丝丆业不一丌东万世)MainMenuHeroCamera.东丐丅丞丄丙一与丄;
    }
    private void Awake()
    {
        CameraCallback val_12;
        this.丏且丑丕丈丗丂丐丘(丟丕上丂丏一丄丁专:  this.业不三丛丄下业丄丑.世三丞丅丑丌丈丈一(), 丘丕丑一丅丆丝与丁:  false, 丈上不丆丑丑三专丗:  true);
        MainMenuHeroCamera.<不丁丄七丛不丆丁丕>k__BackingField = this;
        MainMenuHeroCamera.东丐丅丞丄丙一与丄 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
        PGCompany.TransitionController.丒专丈丁丗丄世丅不(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void MainMenuHeroCamera::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
        PGCompany.TransitionController.丛东且丙一丆不丞丁(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void MainMenuHeroCamera::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
        PGCompany.TransitionController.丕丐丘丆且丌丒丌不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuHeroCamera::丗丁丏一专丁七丝丞()));
        if(((System.Delegate.Combine(a:  UnityEngine.Camera.onPostRender, b:  new Camera.CameraCallback(object:  this, method:  System.Void MainMenuHeroCamera::丛丝三丑丙丛丘丕丝(UnityEngine.Camera 业丆丆东丂与万丅不)))) != null) && (null != null))
        {
                val_12 = 0;
        }
        
        UnityEngine.Camera.onPostRender = val_12;
        UnityEngine.Coroutine val_11 = CoroutineRunner.Instance.StartCoroutine(routine:  this.专丛丄东丆下丛下世());
    }
    private void 丛丝三丑丙丛丘丕丝(UnityEngine.Camera 业丆丆东丂与万丅不)
    {
        object val_6;
        UnityEngine.Object val_7;
        CameraCallback val_8;
        val_6 = this;
        val_7 = this.丝专丅业丗丁业世三();
        if(业丆丆东丂与万丅不 != val_7)
        {
                return;
        }
        
        this.三丐上丗丂一丑世丒 = true;
        if(UnityEngine.Camera.onPostRender == null)
        {
                return;
        }
        
        Camera.CameraCallback val_3 = null;
        val_7 = val_3;
        val_3 = new Camera.CameraCallback(object:  this, method:  System.Void MainMenuHeroCamera::丛丝三丑丙丛丘丕丝(UnityEngine.Camera 业丆丆东丂与万丅不));
        if(((System.Delegate.Remove(source:  UnityEngine.Camera.onPostRender, value:  val_3)) != null) && (null != null))
        {
                val_8 = 0;
        }
        
        UnityEngine.Camera.onPostRender = val_8;
    }
    private void OnDestroy()
    {
        object val_7;
        System.Delegate val_8;
        CameraCallback val_9;
        val_7 = this;
        val_8 = 1152921504615686144;
        PGCompany.TransitionController.丕丆专不丐东不丌丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void MainMenuHeroCamera::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
        PGCompany.TransitionController.上世丆丈七丒万丐丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void MainMenuHeroCamera::下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
        PGCompany.TransitionController.与丄丟上丛且上万丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuHeroCamera::丗丁丏一专丁七丝丞()));
        if(UnityEngine.Camera.onPostRender == null)
        {
                return;
        }
        
        Camera.CameraCallback val_4 = null;
        val_8 = val_4;
        val_4 = new Camera.CameraCallback(object:  this, method:  System.Void MainMenuHeroCamera::丛丝三丑丙丛丘丕丝(UnityEngine.Camera 业丆丆东丂与万丅不));
        if(((System.Delegate.Remove(source:  UnityEngine.Camera.onPostRender, value:  val_4)) != null) && (null != null))
        {
                val_9 = 0;
        }
        
        UnityEngine.Camera.onPostRender = val_9;
    }
    private System.Collections.IEnumerator 专丛丄东丆下丛下世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuHeroCamera.七世七丄专且丐万丗();
    }
    private void 丕丕业七丙七丅丈丄()
    {
        this.丏且丑丕丈丗丂丐丘(丟丕上丂丏一丄丁专:  this._currentCameraPreset, 丘丕丑一丅丆丝与丁:  true, 丈上不丆丑丑三专丗:  false);
    }
    internal MainMenuHeroCamera.业丟丝丗且丌丌东且 丈丁丕丑丟下丟丑丏()
    {
        if(this.业不三丛丄下业丄丑 != null)
        {
                return this.业不三丛丄下业丄丑.世三丞丅丑丌丈丈一();
        }
        
        return this.业不三丛丄下业丄丑.世三丞丅丑丌丈丈一();
    }
    internal void 丏且丑丕丈丗丂丐丘(MainMenuHeroCamera.业丟丝丗且丌丌东且 丟丕上丂丏一丄丁专, bool 丘丕丑一丅丆丝与丁 = True, bool 丈上不丆丑丑三专丗 = False)
    {
        UnityEngine.Vector3 val_5;
        UnityEngine.Vector3 val_7;
        if(丈上不丆丑丑三专丗 != true)
        {
                if(this.业不三丛丄下业丄丑.世三丞丅丑丌丈丈一() == 丟丕上丂丏一丄丁专)
        {
                return;
        }
        
        }
        
        if(丟丕上丂丏一丄丁专 == 2)
        {
            goto label_4;
        }
        
        if(丟丕上丂丏一丄丁专 == 1)
        {
            goto label_5;
        }
        
        if(丟丕上丂丏一丄丁专 != 0)
        {
            goto label_6;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this._overridePositionIncrement = val_2;
        mem[1152921540213664880] = val_2.y;
        mem[1152921540213664884] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        goto label_9;
        label_4:
        val_5 = this._hightPositionPreset;
        val_7 = this._hightRotationPreset;
        goto label_10;
        label_5:
        val_5 = this._lowPositionPreset;
        val_7 = this._lowRotationPreset;
        label_10:
        this._overridePositionIncrement = val_5;
        mem[1152921540213664884] = ???;
        label_9:
        this._overrideRotationIncrement = val_7;
        mem[1152921540213664892] = ???;
        mem[1152921540213664896] = ???;
        label_6:
        this._currentCameraPreset = 丟丕上丂丏一丄丁专;
        this.丂丈世丏下丕七丆丕 = this.业不三丛丄下业丄丑.世三丞丅丑丌丈丈一();
        this.业不三丛丄下业丄丑.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丟丕上丂丏一丄丁专);
        if(丘丕丑一丅丆丝与丁 == false)
        {
                return;
        }
        
        this.丅丟丛丄丆业丞丈丕 = 0f;
        this.丙丞丆丑万一七万丂 = false;
    }
    private void OnEnable()
    {
        BankController.东丂下丞世丒丆丝丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuHeroCamera::与丏丗丆不丈丑丘丄()));
        BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuHeroCamera::世丗丄七丑三丄与不()));
        if(FriendProfileView.丆三丅上丏下三丘丑() == true)
        {
                return;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  MainMenuHeroCamera.东丐丅丞丄丙一与丄);
        this.世丞丌与丈丆丐万丌 = false;
    }
    private void OnDisable()
    {
        BankController.且丆专丗与下专丞丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuHeroCamera::与丏丗丆不丈丑丘丄()));
        BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuHeroCamera::世丗丄七丑三丄与不()));
        this.丗三丘丑与丞丐丛上();
    }
    private void 丗丁丏一专丁七丝丞()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
    }
    private void 下不丈丕丒业丙一不(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)
    {
        var val_13;
        var val_14;
        UnityEngine.MonoBehaviour val_15;
        PGCompany.丑且丆万丏丝丘丙丟 val_2 = PGCompany.TransitionController.丑七不且上丗丁一世().丘丁丒东丒丏上丛丝();
        if(val_2 == null)
        {
            goto label_2;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        goto label_6;
        label_2:
        val_13 = 1;
        goto label_7;
        label_6:
        val_13 = val_2.IsEnabledLobbyCamera();
        label_7:
        if(this.丝丈万业下丗上丟丌 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丝丈万业下丗上丟丌);
        }
        
        if((val_13 | (~this.isActiveAndEnabled)) != false)
        {
                val_14 = val_13;
            val_15 = this;
        }
        else
        {
                if(不丌不世且丄不三丝 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            float val_9 = 不丌不世且丄不三丝.GetDelayTurnOff();
            if(val_9 > 0f)
        {
                this.丝丈万业下丗上丟丌 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丌丄不七三丘丏丆与(丕丕世且下一与丝与:  val_9));
            return;
        }
        
        }
        
            val_15 = this;
            val_14 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.IEnumerator 丌丄不七三丘丏丆与(float 丕丕世且下一与丝与)
    {
        MainMenuHeroCamera.世下一七丞丌丈丐丁 val_1 = new MainMenuHeroCamera.世下一七丞丌丈丐丁();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丗三丘丑与丞丐丛上()
    {
        if(this.世丞丌与丈丆丐万丌 == true)
        {
                return;
        }
        
        if(FriendProfileView.丆三丅上丏下三丘丑() == true)
        {
                return;
        }
        
        MainMenuHeroCamera.东丐丅丞丄丙一与丄 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
        this.世丞丌与丈丆丐万丌 = true;
    }
    private void 与丏丗丆不丈丑丘丄()
    {
        this.东与丘丂丞与专丂丗(丂丛丑东不丅丈一东:  false);
    }
    private void 世丗丄七丑三丄与不()
    {
        this.东与丘丂丞与专丂丗(丂丛丑东不丅丈一东:  true);
    }
    private void 东与丘丂丞与专丂丗(bool 丂丛丑东不丅丈一东)
    {
        bool val_2 = 丂丛丑东不丅丈一东;
        this.丝专丅业丗丁业世三().enabled = val_2;
        this.丑丏丘丛丑丆与三丟().enabled = val_2;
    }
    public void PlayOpenSocial()
    {
        this.PlayAnimation(丁丛东丛丆专业丏不:  2);
    }
    public void PlayOpenCharacters()
    {
        this.PlayAnimation(丁丛东丛丆专业丏不:  7);
    }
    public void PlayCloseCharacters()
    {
        this.PlayAnimation(丁丛东丛丆专业丏不:  0);
    }
    public void PlayOpenOptions()
    {
        if((this.且丙丏丘丒不丌丒下().GetBool(name:  "ToSettings")) != false)
        {
                return;
        }
        
        this.PlayAnimation(丁丛东丛丆专业丏不:  1);
    }
    public void PlayCloseOptions()
    {
        if((this.且丙丏丘丒不丌丒下().GetBool(name:  "ToSettings")) != false)
        {
                this.且丙丏丘丒不丌丒下().SetBool(name:  "ToSettings", value:  false);
        }
        
        if((this.且丙丏丘丒不丌丒下().GetBool(name:  "ToIdle")) != false)
        {
                return;
        }
        
        this.PlayAnimation(丁丛东丛丆专业丏不:  0);
    }
    internal bool 一丈下丕丕一丛且丝()
    {
        var val_10;
        var val_11;
        var val_12;
        val_10 = this;
        val_11 = 4;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((this.且丙丏丘丒不丌丒下().GetBool(name:  4.ToString())) == true)
        {
            goto label_4;
        }
        
        val_11 = 4;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((this.且丙丏丘丒不丌丒下().GetBool(name:  4.ToString())) == false)
        {
            goto label_8;
        }
        
        label_4:
        val_12 = 1;
        return (bool)val_12.GetBool(name:  "INTERNAL_InGachaSM");
        label_8:
        val_10 = this.且丙丏丘丒不丌丒下();
        val_12 = val_10;
        return (bool)val_12.GetBool(name:  "INTERNAL_InGachaSM");
    }
    public void PlayShowGift()
    {
        if(this.一丈下丕丕一丛且丝() != false)
        {
                return;
        }
        
        this.PlayAnimation(丁丛东丛丆专业丏不:  4);
    }
    public void PlayCloseGift()
    {
        this.PlayAnimation(丁丛东丛丆专业丏不:  0);
    }
    public void PlayTaskGSMoveAnimation(string 东一七丟与丗三丐不)
    {
        string val_8;
        object val_9;
        val_8 = 东一七丟与丗三丐不;
        MainMenuHeroCamera.丛丄丁业且世丝丂丅 val_1 = new MainMenuHeroCamera.丛丄丁业且世丝丂丅();
        if(val_1 != null)
        {
                val_9 = val_1;
            .东一七丟与丗三丐不 = val_8;
        }
        else
        {
                val_9 = 16;
            mem[16] = val_8;
            val_8 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != false)
        {
                UnityEngine.Debug.LogError(message:  "MainMenuHeroCamera.PlayTaskGSMoveAnimation error: taskId.IsNullOrEmpty()");
            return;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<TasksGSMoveCameraItemsOverrideController>(source:  this._tasksGSMoveCameraItemsOverrideControllers, predicate:  new System.Func<TasksGSMoveCameraItemsOverrideController, System.Boolean>(object:  val_1, method:  System.Boolean MainMenuHeroCamera.丛丄丁业且世丝丂丅::世丐东万丁世丌业丕(MainMenuHeroCamera.TasksGSMoveCameraItemsOverrideController 下下丏一丙不丘丌丞)))) != null)
        {
                if(val_4.OverrideController != 0)
        {
            goto label_11;
        }
        
        }
        
        object[] val_6 = new object[1];
        val_6[0] = val_9;
        UnityEngine.Debug.LogErrorFormat(format:  "override controller for taskId \'{0}\' not found", args:  val_6);
        return;
        label_11:
        this.且丙丏丘丒不丌丒下().runtimeAnimatorController = val_4.OverrideController;
        this.PlayAnimation(丁丛东丛丆专业丏不:  5);
    }
    public bool CanZoomTo(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
    {
        Rilisoft.丏丘七丞丄丙丌丞丁 val_6;
        System.Collections.Generic.List<LobbyItemsOverrideController> val_7;
        System.Collections.Generic.List<LobbyItemsOverrideController> val_8;
        System.Func<TSource, System.Boolean> val_10;
        val_6 = 下丅丙一丂丗丅丝七;
        val_7 = this;
        MainMenuHeroCamera.丙丟与业不万丈丄丈 val_1 = new MainMenuHeroCamera.丙丟与业不万丈丄丈();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .下丅丙一丂丗丅丝七 = val_6;
        if(val_6 != null)
        {
            goto label_2;
        }
        
        return false;
        label_1:
        mem[16] = val_6;
        val_6 = mem[16];
        if(val_6 == 0)
        {
                return false;
        }
        
        label_2:
        val_8 = this._lobbyItemsOverrideControllers;
        if((System.Linq.Enumerable.FirstOrDefault<LobbyItemsOverrideController>(source:  val_8, predicate:  new System.Func<LobbyItemsOverrideController, System.Boolean>(object:  val_1, method:  System.Boolean MainMenuHeroCamera.丙丟与业不万丈丄丈::丘丞上世丝业丅一上(MainMenuHeroCamera.LobbyItemsOverrideController 下下丏一丙不丘丌丞)))) != null)
        {
                return UnityEngine.Object.op_Inequality(x:  val_5.OverrideController, y:  0);
        }
        
        val_7 = this._lobbyItemsOverrideControllers;
        System.Func<LobbyItemsOverrideController, System.Boolean> val_4 = null;
        val_10 = val_4;
        val_4 = new System.Func<LobbyItemsOverrideController, System.Boolean>(object:  val_1, method:  System.Boolean MainMenuHeroCamera.丙丟与业不万丈丄丈::丏丕丑丏丆丌丁丑丄(MainMenuHeroCamera.LobbyItemsOverrideController 下下丏一丙不丘丌丞));
        if((System.Linq.Enumerable.FirstOrDefault<LobbyItemsOverrideController>(source:  val_7, predicate:  val_4)) == null)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  val_5.OverrideController, y:  0);
    }
    public void PlayLobbyItemZoom(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
    {
        Rilisoft.丏丘七丞丄丙丌丞丁 val_11;
        var val_12;
        var val_13;
        val_11 = 下丅丙一丂丗丅丝七;
        MainMenuHeroCamera.不丄业上万丝丒专丂 val_1 = new MainMenuHeroCamera.不丄业上万丝丒专丂();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_12 = val_1;
        .下丅丙一丂丗丅丝七 = val_11;
        if(val_11 == null)
        {
            goto label_2;
        }
        
        label_17:
        val_13 = System.Linq.Enumerable.FirstOrDefault<LobbyItemsOverrideController>(source:  this._lobbyItemsOverrideControllers, predicate:  new System.Func<LobbyItemsOverrideController, System.Boolean>(object:  val_1, method:  System.Boolean MainMenuHeroCamera.不丄业上万丝丒专丂::丞丟世专下丂丐世且(MainMenuHeroCamera.LobbyItemsOverrideController 下下丏一丙不丘丌丞)));
        if(val_13 != null)
        {
            goto label_3;
        }
        
        val_13 = System.Linq.Enumerable.FirstOrDefault<LobbyItemsOverrideController>(source:  this._lobbyItemsOverrideControllers, predicate:  new System.Func<LobbyItemsOverrideController, System.Boolean>(object:  val_1, method:  System.Boolean MainMenuHeroCamera.不丄业上万丝丒专丂::丗丂业丂一丕不七业(MainMenuHeroCamera.LobbyItemsOverrideController 下下丏一丙不丘丌丞)));
        if(val_13 == null)
        {
            goto label_4;
        }
        
        label_3:
        if(val_5.OverrideController != 0)
        {
            goto label_7;
        }
        
        label_4:
        object[] val_7 = new object[1];
        val_7[0] = .下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
        UnityEngine.Debug.LogErrorFormat(format:  "override controller for item \'{0}\' not found", args:  val_7);
        return;
        label_1:
        val_12 = 16;
        mem[16] = val_11;
        val_11 = mem[16];
        if(val_11 != 0)
        {
            goto label_17;
        }
        
        label_2:
        UnityEngine.Debug.LogError(message:  "MainMenuHeroCamera.PlayLobbyItemZoom error: item is null");
        return;
        label_7:
        this.且丙丏丘丒不丌丒下().runtimeAnimatorController = val_5.OverrideController;
        this.PlayAnimation(丁丛东丛丆专业丏不:  5);
    }
    public void ToFort()
    {
        if(this.gameObject.activeInHierarchy != true)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        this.丝专丅业丗丁业世三().enabled = true;
        this.PlayFortSlotZoom(不丝丄丒丌丐一一与:  0);
    }
    public void ToLobby()
    {
        if(this.业七丟丝万丄丟丄丙() != 0)
        {
                if(this.业七丟丝万丄丟丄丙().isActiveAndEnabled != false)
        {
                this.业七丟丝万丄丟丄丙().enabled = false;
        }
        
        }
        
        if(this.丐七七丏丁一丄丆丞 != 0)
        {
                if(this.丐七七丏丁一丄丆丞.isActiveAndEnabled != true)
        {
                this.丐七七丏丁一丄丆丞.enabled = true;
        }
        
        }
        
        if(this.gameObject.activeInHierarchy != true)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        this.PlayAnimation(丁丛东丛丆专业丏不:  0);
    }
    public bool CanZoomTo(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)
    {
        Rilisoft.东且东丒丐世丐丞丒 val_6;
        System.Collections.Generic.List<FortItemsOverrideController> val_7;
        System.Collections.Generic.List<FortItemsOverrideController> val_8;
        System.Func<TSource, System.Boolean> val_10;
        val_6 = 下丅丙一丂丗丅丝七;
        val_7 = this;
        MainMenuHeroCamera.下世丗丈丞丂丐丐丘 val_1 = new MainMenuHeroCamera.下世丗丈丞丂丐丐丘();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .下丅丙一丂丗丅丝七 = val_6;
        if(val_6 != null)
        {
            goto label_2;
        }
        
        return false;
        label_1:
        mem[16] = val_6;
        val_6 = mem[16];
        if(val_6 == 0)
        {
                return false;
        }
        
        label_2:
        val_8 = this._fortItemsOverrideControllers;
        if((System.Linq.Enumerable.FirstOrDefault<FortItemsOverrideController>(source:  val_8, predicate:  new System.Func<FortItemsOverrideController, System.Boolean>(object:  val_1, method:  System.Boolean MainMenuHeroCamera.下世丗丈丞丂丐丐丘::丘丞上世丝业丅一上(MainMenuHeroCamera.FortItemsOverrideController 下下丏一丙不丘丌丞)))) != null)
        {
                return UnityEngine.Object.op_Inequality(x:  val_5.OverrideController, y:  0);
        }
        
        val_7 = this._fortItemsOverrideControllers;
        System.Func<FortItemsOverrideController, System.Boolean> val_4 = null;
        val_10 = val_4;
        val_4 = new System.Func<FortItemsOverrideController, System.Boolean>(object:  val_1, method:  System.Boolean MainMenuHeroCamera.下世丗丈丞丂丐丐丘::丏丕丑丏丆丌丁丑丄(MainMenuHeroCamera.FortItemsOverrideController 下下丏一丙不丘丌丞));
        if((System.Linq.Enumerable.FirstOrDefault<FortItemsOverrideController>(source:  val_7, predicate:  val_4)) == null)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  val_5.OverrideController, y:  0);
    }
    public void PlayFortItemZoom(Rilisoft.FortItemGroupType 不丝丄丒丌丐一一与, string 丞一丁业丄一一业且 = "")
    {
        var val_7;
        var val_8;
        if(this.业七丟丝万丄丟丄丙().isActiveAndEnabled != true)
        {
                this.业七丟丝万丄丟丄丙().enabled = true;
        }
        
        if(this.丐七七丏丁一丄丆丞.isActiveAndEnabled != false)
        {
                this.丐七七丏丁一丄丆丞.enabled = false;
        }
        
        val_7 = null;
        val_7 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_8 = null;
            val_8 = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.OnZoomIn();
        }
        
        this.业七丟丝万丄丟丄丙().GoTo(与丄不丌一世东丁丙:  不丝丄丒丌丐一一与, 丟下丟丈万一丙东丄:  丞一丁业丄一一业且);
    }
    public void PlayFortSlotZoom(Rilisoft.FortItemGroupType 不丝丄丒丌丐一一与)
    {
        Rilisoft.FortItemGroupType val_8 = 不丝丄丒丌丐一一与;
        if(this.业七丟丝万丄丟丄丙().isActiveAndEnabled != true)
        {
                this.业七丟丝万丄丟丄丙().enabled = true;
        }
        
        if(this.且丙丏丘丒不丌丒下().isActiveAndEnabled != false)
        {
                this.且丙丏丘丒不丌丒下().enabled = false;
        }
        
        if(val_8 != 30)
        {
                if(val_8 != 3)
        {
            goto label_8;
        }
        
        }
        
        val_8 = 0;
        label_8:
        this.业七丟丝万丄丟丄丙().GoTo(与丄不丌一世东丁丙:  val_8, 丟下丟丈万一丙东丄:  "");
    }
    public void PlayFromItem()
    {
        this.PlayAnimation(丁丛东丛丆专业丏不:  0);
    }
    public void OnOpenSingleModePanel()
    {
        this.StopAllCoroutines();
    }
    public void OnCloseMinigamesGui()
    {
    
    }
    public void PlayAnimation(MainMenuHeroCamera.丟三丆下丗且丝东世 丁丛东丛丆专业丏不)
    {
        string val_11;
        丟三丆下丗且丝东世 val_12;
        var val_13;
        var val_14;
        val_12 = 丁丛东丛丆专业丏不;
        val_13 = this;
        if(val_12 != 0)
        {
                val_14 = 1;
            val_12 = 1;
        }
        else
        {
                val_14 = 0;
        }
        
        this.MixPosition(丙专丗万丁丐丏万一:  this._mixTimeSecs, 且丒且丐丌东专三丁:  false);
        this.丙丞丆丑万一七万丂 = val_12;
        if(this.且丙丏丘丒不丌丒下() == 0)
        {
                return;
        }
        
        val_11 = val_12;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((this.且丙丏丘丒不丌丒下().GetBool(name:  val_12.ToString())) == true)
        {
                return;
        }
        
        if(null == 7)
        {
            
        }
        
        this.且丙丏丘丒不丌丒下().SetLayerWeight(layerIndex:  this.且丙丏丘丒不丌丒下().GetLayerIndex(layerName:  "Additive"), weight:  0.5f);
        val_13 = this.且丙丏丘丒不丌丒下();
        val_11 = null.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_13.SetTrigger(name:  val_11);
    }
    private UnityEngine.Transform 一丗与上丅东丏丙丑()
    {
        UnityEngine.Transform val_4;
        if(this.丆东丙且下丁丗丆七 == 0)
        {
                this.丆东丙且下丁丗丆七 = this.丝专丅业丗丁业世三().transform;
            return val_4;
        }
        
        val_4 = this.丆东丙且下丁丗丆七;
        return val_4;
    }
    private bool 不丂丒丐丒丝丆一丁()
    {
        return (bool)(this.世与丞丛丁丐一业七 < 0) ? 1 : 0;
    }
    public void MixPosition(float 丙专丗万丁丐丏万一, bool 且丒且丐丌东专三丁)
    {
        UnityEngine.Vector3 val_2 = this.一丗与上丅东丏丙丑().localPosition;
        this.一丝一丘丘且专丒东 = val_2;
        mem[1152921540218174764] = val_2.y;
        mem[1152921540218174768] = val_2.z;
        UnityEngine.Quaternion val_4 = this.一丗与上丅东丏丙丑().localRotation;
        this.七丒东丂上丘丒丟丟 = val_4;
        mem[1152921540218174776] = val_4.y;
        mem[1152921540218174780] = val_4.z;
        mem[1152921540218174784] = val_4.w;
        this.东丗丐世丒丕丐丞丐 = 丙专丗万丁丐丏万一;
        this.世与丞丛丁丐一业七 = 0f;
        this.与丙不专丁丗丒丂丄 = 且丒且丐丌东专三丁;
    }
    private void LateUpdate()
    {
        if(this.丅丟丛丄丆业丞丈丕 < 0)
        {
                this.上世下业丌丆丛丒丟();
            return;
        }
        
        if((this.丙丞丆丑万一七万丂 != true) && (this.世与丞丛丁丐一业七 >= 0))
        {
                this.一丐丆业丁万七三丆();
            return;
        }
        
        if(this.世与丞丛丁丐一业七 >= 0)
        {
                return;
        }
        
        if(this.与丙不专丁丗丒丂丄 != false)
        {
                this.丂一与丞万丁丁三且();
            return;
        }
        
        this.专万丕丙丛世丛丏东();
    }
    private void 上世下业丌丆丛丒丟()
    {
        UnityEngine.Vector3 val_45;
        float val_46;
        float val_47;
        float val_48;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_45 = val_1.x;
        val_46 = val_1.y;
        val_47 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_48 = val_2.z;
        if(this.丂丈世丏下丕七丆丕 == 2)
        {
            goto label_3;
        }
        
        if(this.丂丈世丏下丕七丆丕 == 1)
        {
            goto label_4;
        }
        
        if(this.丂丈世丏下丕七丆丕 != 0)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_45 = val_3.x;
        val_46 = val_3.y;
        val_47 = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_48 = val_4.z;
        goto label_10;
        label_3:
        val_45 = this._hightPositionPreset;
        goto label_10;
        label_4:
        val_45 = this._lowPositionPreset;
        goto label_10;
        label_5:
        label_10:
        UnityEngine.Vector3 val_6 = this.一丗与上丅东丏丙丑().localPosition;
        UnityEngine.Vector3 val_8 = this.一丗与上丅东丏丙丑().localPosition;
        UnityEngine.Vector3 val_10 = this.一丗与上丅东丏丙丑().localPosition;
        float val_11 = val_45 + val_6.x;
        float val_12 = val_46 + val_8.y;
        val_10.z = val_47 + val_10.z;
        UnityEngine.Vector3 val_14 = this.一丗与上丅东丏丙丑().localPosition;
        UnityEngine.Vector3 val_16 = this.一丗与上丅东丏丙丑().localPosition;
        float val_18 = this.丅丟丛丄丆业丞丈丕 / this._changePresetTime;
        UnityEngine.Vector3 val_19 = this.一丗与上丅东丏丙丑().localPosition;
        float val_20 = val_14.x + this._overridePositionIncrement;
        float val_21 = val_16.y + val_8.y;
        val_19.z = val_19.z + S3;
        float val_22 = UnityEngine.Mathf.Lerp(a:  0f, b:  0f, t:  val_18);
        float val_23 = UnityEngine.Mathf.Lerp(a:  0f, b:  0f, t:  val_18);
        float val_24 = UnityEngine.Mathf.Lerp(a:  0f, b:  0f, t:  val_18);
        this.一丗与上丅东丏丙丑().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_27 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_29 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_31 = this.一丗与上丅东丏丙丑().localRotation;
        float val_46 = val_2.y;
        float val_45 = val_2.x;
        val_31.z = val_48 + val_31.z;
        val_45 = val_45 + val_27.x;
        val_46 = val_46 + val_29.y;
        UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.Euler(x:  val_45, y:  val_46, z:  val_31.z);
        UnityEngine.Quaternion val_34 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_36 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_38 = this.一丗与上丅东丏丙丑().localRotation;
        val_38.z = val_38.z + val_38.w;
        UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.Euler(x:  val_34.x + this._overrideRotationIncrement, y:  val_36.y + val_8.y, z:  val_38.z);
        UnityEngine.Quaternion val_43 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w}, b:  new UnityEngine.Quaternion() {x = val_41.x, y = val_41.y, z = val_41.z, w = val_41.w}, t:  val_18);
        this.一丗与上丅东丏丙丑().localRotation = new UnityEngine.Quaternion() {x = val_43.x, y = val_43.y, z = val_43.z, w = val_43.w};
        float val_44 = UnityEngine.Time.deltaTime;
        val_44 = this.丅丟丛丄丆业丞丈丕 + val_44;
        this.丅丟丛丄丆业丞丈丕 = val_44;
    }
    private void 丂一与丞万丁丁三且()
    {
        float val_2 = this.世与丞丛丁丐一业七 / this.东丗丐世丒丕丐丞丐;
        UnityEngine.Vector3 val_3 = this.一丗与上丅东丏丙丑().localPosition;
        float val_4 = UnityEngine.Mathf.Lerp(a:  this.一丝一丘丘且专丒东, b:  val_3.x, t:  val_2);
        UnityEngine.Vector3 val_6 = this.一丗与上丅东丏丙丑().localPosition;
        float val_7 = UnityEngine.Mathf.Lerp(a:  this.世与丞丛丁丐一业七, b:  val_6.y, t:  val_2);
        UnityEngine.Vector3 val_9 = this.一丗与上丅东丏丙丑().localPosition;
        float val_10 = UnityEngine.Mathf.Lerp(a:  val_3.x, b:  val_9.z, t:  val_2);
        this.一丗与上丅东丏丙丑().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_14 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.七丒东丂上丘丒丟丟, y = 0f, z = val_2, w = V12.16B}, b:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, t:  val_2);
        this.一丗与上丅东丏丙丑().localRotation = new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w};
        float val_16 = UnityEngine.Time.deltaTime;
        val_16 = this.世与丞丛丁丐一业七 + val_16;
        this.世与丞丛丁丐一业七 = val_16;
    }
    private void 专万丕丙丛世丛丏东()
    {
        float val_2 = this.世与丞丛丁丐一业七 / this.东丗丐世丒丕丐丞丐;
        UnityEngine.Vector3 val_3 = this.一丗与上丅东丏丙丑().localPosition;
        float val_4 = UnityEngine.Mathf.Lerp(a:  this.一丝一丘丘且专丒东, b:  val_3.x, t:  val_2);
        UnityEngine.Vector3 val_6 = this.一丗与上丅东丏丙丑().localPosition;
        float val_7 = UnityEngine.Mathf.Lerp(a:  this.世与丞丛丁丐一业七, b:  val_6.y, t:  val_2);
        UnityEngine.Vector3 val_9 = this.一丗与上丅东丏丙丑().localPosition;
        float val_10 = UnityEngine.Mathf.Lerp(a:  val_3.x, b:  val_9.z, t:  val_2);
        this.一丗与上丅东丏丙丑().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_14 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.七丒东丂上丘丒丟丟, y = 0f, z = val_2, w = 0f}, b:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, t:  val_2);
        this.一丗与上丅东丏丙丑().localRotation = new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w};
        this.七一与丈丙万丁丞万(丗丛七丏丙业丑丏万:  val_2, 下业丕七东丌丝下且: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丙丆与丅丈丑一且丏: out  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.一丗与上丅东丏丙丑().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.一丗与上丅东丏丙丑().localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        float val_18 = UnityEngine.Time.deltaTime;
        val_18 = this.世与丞丛丁丐一业七 + val_18;
        this.世与丞丛丁丐一业七 = val_18;
    }
    private void 一丐丆业丁万七三丆()
    {
        this.七一与丈丙万丁丞万(丗丛七丏丙业丑丏万:  1f, 下业丕七东丌丝下且: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丙丆与丅丈丑一且丏: out  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.一丗与上丅东丏丙丑().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.一丗与上丅东丏丙丑().localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    private void 七一与丈丙万丁丞万(float 丗丛七丏丙业丑丏万, out UnityEngine.Vector3 下业丕七东丌丝下且, out UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        下业丕七东丌丝下且.x = val_1.x;
        下业丕七东丌丝下且.y = val_1.y;
        下业丕七东丌丝下且.z = val_1.z;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        丙丆与丅丈丑一且丏.x = val_2.x;
        丙丆与丅丈丑一且丏.y = val_2.y;
        丙丆与丅丈丑一且丏.z = val_2.z;
        丙丆与丅丈丑一且丏.w = val_2.w;
        UnityEngine.Vector3 val_4 = this.一丗与上丅东丏丙丑().localPosition;
        UnityEngine.Vector3 val_6 = this.一丗与上丅东丏丙丑().localPosition;
        float val_8 = UnityEngine.Mathf.Lerp(a:  val_4.x, b:  val_6.x + this._overridePositionIncrement, t:  丗丛七丏丙业丑丏万);
        UnityEngine.Vector3 val_10 = this.一丗与上丅东丏丙丑().localPosition;
        UnityEngine.Vector3 val_12 = this.一丗与上丅东丏丙丑().localPosition;
        val_12.y = val_12.y + val_12.x;
        float val_13 = UnityEngine.Mathf.Lerp(a:  val_10.y, b:  val_12.y, t:  丗丛七丏丙业丑丏万);
        UnityEngine.Vector3 val_15 = this.一丗与上丅东丏丙丑().localPosition;
        UnityEngine.Vector3 val_17 = this.一丗与上丅东丏丙丑().localPosition;
        float val_19 = UnityEngine.Mathf.Lerp(a:  val_15.z, b:  val_17.z + val_17.x, t:  丗丛七丏丙业丑丏万);
        下业丕七东丌丝下且.z = 0f;
        下业丕七东丌丝下且.x = 0f;
        下业丕七东丌丝下且.y = 0f;
        UnityEngine.Quaternion val_21 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_23 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_25 = this.一丗与上丅东丏丙丑().localRotation;
        float val_26 = val_21.x + this._overrideRotationIncrement;
        float val_27 = val_23.y + S12;
        val_25.z = val_25.z + val_25.w;
        UnityEngine.Quaternion val_29 = this.一丗与上丅东丏丙丑().localRotation;
        UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Quaternion val_31 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w}, b:  new UnityEngine.Quaternion() {x = val_30.x, y = val_30.y, z = val_30.z, w = val_30.w}, t:  丗丛七丏丙业丑丏万);
        丙丆与丅丈丑一且丏.x = val_31.x;
        丙丆与丅丈丑一且丏.y = val_31.y;
        丙丆与丅丈丑一且丏.z = val_31.z;
        丙丆与丅丈丑一且丏.w = val_31.w;
    }
    public MainMenuHeroCamera()
    {
        this.业不三丛丄下业丄丑 = new Rilisoft.业业丛上世丄业上丐<业丟丝丗且丌丌东且>(丟东丟丑丕丄丂丟丙:  "camera_preset");
        this._changePresetTime = 0.5f;
        this._mixTimeSecs = 0.75f;
    }

}
