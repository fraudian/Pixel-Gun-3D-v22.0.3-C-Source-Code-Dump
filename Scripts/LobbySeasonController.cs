using UnityEngine;
internal sealed class LobbySeasonController : PGBehaviour
{
    // Fields
    private static string 三丂下丆丑东下丈一;
    public static LobbySeasonController instance;
    private Rilisoft.LobbyCraftController 丑丛世世丅丈丗丒丈;
    internal UnityEngine.Transform rootTransform;
    internal LobbySeasonFogController 丆丅丛丁业丌专上丁;
    private LobbySeasonLinks 丒业东丁一丈丘丙丁;
    private UnityEngine.GameObject 七丁丛丆与上丌丂丛;
    public string seasonNameEn;
    internal bool 与三丂与世丗丆丆丗;
    
    // Properties
    public LobbySeasonFogController 专一三丕专丌丒丂丄 { get; }
    internal LobbySeasonLinks 丂丄丂丈上业丈丆丒 { get; }
    
    // Methods
    public LobbySeasonFogController get_FogComponent()
    {
        return (LobbySeasonFogController)this.丆丅丛丁业丌专上丁;
    }
    internal LobbySeasonLinks 一丕且下世丆下丑上()
    {
        return (LobbySeasonLinks)this.丒业东丁一丈丘丙丁;
    }
    private void Awake()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(LobbySeasonController.instance == 0)
        {
                val_4 = null;
            val_4 = null;
            LobbySeasonController.instance = this;
        }
        
        PGCompany.TransitionController.丛东且丙一丆不丞丁(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void LobbySeasonController::丄世丕七下丘七丝丛(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
    }
    private void Start()
    {
        this.丑丛世世丅丈丗丒丈 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.东丗丗上丕一上下丄());
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LobbySeasonController::业丕丐丝与丄丏丆丂()));
    }
    private void 业丕丐丝与丄丏丆丂()
    {
        UnityEngine.Object val_7 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_7 == 0)
        {
                return;
        }
        
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
    }
    private void OnDisable()
    {
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LobbySeasonController::业丕丐丝与丄丏丆丂()));
    }
    private void OnDestroy()
    {
        PGCompany.TransitionController.上世丆丈七丒万丐丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丑且丆万丏丝丘丙丟>(object:  this, method:  System.Void LobbySeasonController::丄世丕七下丘七丝丛(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)));
    }
    private System.Collections.IEnumerator 东丗丗上丕一上下丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LobbySeasonController.不不丙丌丘丁丝丆丞();
    }
    private void 业丆丕丗丘东不专丌()
    {
        var val_6;
        if(this.七丁丛丆与上丌丂丛 != 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  LobbySeasonController.三丂下丆丑东下丈一), parent:  this.rootTransform);
        this.七丁丛丆与上丌丂丛 = val_3;
        this.丆丅丛丁业丌专上丁 = val_3.GetComponent<LobbySeasonFogController>();
        this.丒业东丁一丈丘丙丁 = this.七丁丛丆与上丌丂丛.GetComponent<LobbySeasonLinks>();
    }
    private void 丞丕丆业丆不七东丝()
    {
        if(this.七丁丛丆与上丌丂丛 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.七丁丛丆与上丌丂丛);
    }
    internal void 丄丟丑丒与丂丝七东(bool 丂丒丞七下与丛且专)
    {
        var val_9;
        if(丂丒丞七下与丛且专 != false)
        {
                this.业丆丕丗丘东不专丌();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.七丁丛丆与上丌丂丛, 丏业丟一东丂东丘丛:  true);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.七丁丛丆与上丌丂丛, 丏业丟一东丂东丘丛:  false);
            this.丞丕丆业丆不七东丝();
        }
        
        val_9 = 0;
        goto label_7;
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  CraftLobbyPlacePoints.instance.transform.GetChild(index:  0), 丏业丟一东丂东丘丛:  丂丒丞七下与丛且专 ^ 1);
        val_9 = 1;
        label_7:
        if(val_9 < CraftLobbyPlacePoints.instance.transform.childCount)
        {
            goto label_14;
        }
        
        if(丂丒丞七下与丛且专 == false)
        {
                return;
        }
        
        this.丆丅丛丁业丌专上丁.丏世与丅东三丆丛丂();
    }
    private void 丄世丕七下丘七丝丛(PGCompany.丑且丆万丏丝丘丙丟 不丌不世且丄不三丝)
    {
        if(PGCompany.TransitionController.丑七不且上丗丁一世().丟丁与与丘东丈世不() != false)
        {
                return;
        }
        
        this.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业());
    }
    public LobbySeasonController()
    {
        this.seasonNameEn = "NameOfSeasonOnEN";
    }
    private static LobbySeasonController()
    {
        LobbySeasonController.三丂下丆丑东下丈一 = "SeasonsLobby/Lobby_CurrentSeason";
    }

}
