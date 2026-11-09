using UnityEngine;
internal sealed class ClanLobbyItemController : PGBehaviour
{
    // Fields
    internal static ClanLobbyItemController 丄丘七三上丕世丞业;
    internal UnityEngine.GameObject allLobbyItems;
    private UnityEngine.GameObject lobbyTributeChests;
    private UnityEngine.GameObject _goblinHelper;
    internal bool 丌业丞世且三三丕东;
    
    // Methods
    private void Awake()
    {
        ClanLobbyItemController.丄丘七三上丕世丞业 = this;
    }
    private void Start()
    {
        ClanTankBuildBase.instance.丄丅丙一上丝丐丒丝(一丐丗丁丞丆丅丟丄:  ClanTankBuildController.丅丁七丐丕丆七丐上());
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanLobbyItemController::HideClanLobbyItems()));
    }
    private void OnDestroy()
    {
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanLobbyItemController::HideClanLobbyItems()));
    }
    public void ShowClanLobbyItems()
    {
        var val_24;
        var val_25;
        if((UnityEngine.Object.op_Implicit(exists:  Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗)) != false)
        {
                Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  false, 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
        }
        
        System.Collections.IEnumerator val_4 = CraftLobbyPlacePoints.instance.transform.GetEnumerator();
        goto label_23;
        label_30:
        var val_24 = 0;
        val_24 = val_24 + 1;
        object val_6 = val_4.Current;
        if((System.String.op_Equality(a:  0.name, b:  "skybox")) != true)
        {
                if((System.String.op_Equality(a:  0.name, b:  "background_1")) != true)
        {
                if((System.String.op_Equality(a:  0.name, b:  "background_2")) == false)
        {
            goto label_23;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  0, 丏业丟一东丂东丘丛:  false);
        label_23:
        var val_25 = 0;
        val_25 = val_25 + 1;
        if(val_4.MoveNext() == true)
        {
            goto label_30;
        }
        
        val_24 = 0;
        val_25 = 0;
        if(val_4 != null)
        {
                var val_26 = 0;
            val_26 = val_26 + 1;
            val_4.Dispose();
        }
        
        this.丌业丞世且三三丕东 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allLobbyItems, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allLobbyItems, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lobbyTributeChests, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._goblinHelper, 丏业丟一东丂东丘丛:  true);
        丞丂丘丒丟丞丑下丄 val_19 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_19 == null)
        {
            goto label_54;
        }
        
        if(FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂 != null)
        {
            goto label_59;
        }
        
        label_60:
        label_59:
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.万丞丈丌万丟丐丆丘(三丅丁一东丟专丌三:  val_19.丟与且丙七丙丞下丏());
        丞丂丘丒丟丞丑下丄 val_22 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_22 == null)
        {
            goto label_57;
        }
        
        if(ClanTankBuildBase.instance != null)
        {
            goto label_61;
        }
        
        label_62:
        label_61:
        ClanTankBuildBase.instance.丄丅丙一上丝丐丒丝(一丐丗丁丞丆丅丟丄:  val_22.丒丗不丙业丟丄丏丂());
        return;
        label_54:
        if(FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂 != null)
        {
            goto label_59;
        }
        
        goto label_60;
        label_57:
        if(ClanTankBuildBase.instance != null)
        {
            goto label_61;
        }
        
        goto label_62;
    }
    public void HideClanLobbyItems()
    {
        var val_26;
        var val_27;
        bool val_31;
        this.allLobbyItems.SetActive(value:  false);
        this.lobbyTributeChests.SetActive(value:  false);
        this.丌业丞世且三三丕东 = false;
        System.Collections.IEnumerator val_3 = CraftLobbyPlacePoints.instance.transform.GetEnumerator();
        goto label_22;
        label_29:
        var val_26 = 0;
        val_26 = val_26 + 1;
        object val_5 = val_3.Current;
        if((System.String.op_Equality(a:  0.name, b:  "skybox")) != true)
        {
                if((System.String.op_Equality(a:  0.name, b:  "background_1")) != true)
        {
                if((System.String.op_Equality(a:  0.name, b:  "background_2")) == false)
        {
            goto label_22;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  0, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  0, 丏业丟一东丂东丘丛:  (~(Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业())) & 1);
        label_22:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_29;
        }
        
        val_26 = 0;
        val_27 = 0;
        if(val_3 != null)
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_3.Dispose();
        }
        
        val_31 = 1152921505471328256;
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) != 0)
        {
                val_31 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业();
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  val_31, 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  false);
        }
        
        }
        
        this._goblinHelper.SetActive(value:  false);
    }
    public ClanLobbyItemController()
    {
    
    }

}
