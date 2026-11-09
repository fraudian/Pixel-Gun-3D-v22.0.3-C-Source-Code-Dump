using UnityEngine;
internal sealed class LobbyItemSeason : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject itemPlacedLabel;
    private UnityEngine.GameObject buttonPlace;
    private UnityEngine.GameObject seletedBorder;
    private UnityEngine.GameObject buffDescription;
    
    // Methods
    private void Awake()
    {
        Rilisoft.ButtonEventsHandler val_2 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.ButtonEventsHandler>(丝三丁东丈丒世丅业:  this.gameObject);
        val_2.OnClickEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LobbyItemSeason::丌不丂丌丁丛丆丟与()));
        val_2.OnClickEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LobbyItemSeason::丌不丂丌丁丛丆丟与()));
    }
    private void OnEnable()
    {
        this.一丟上丟且业下丐业(丙业与丙丗丝不丈东:  false);
        this.SetSelectedState(丙业与丙丗丝不丈东:  false);
    }
    private void 丌不丂丌丁丛丆丟与()
    {
        this.SetSelectedState(丙业与丙丗丝不丈东:  true);
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丕且与万一丐丞下丁(丂三七下丗且丌上一:  0, 丗业三丝丁万世丄丐:  true);
    }
    public void U_PlaceHandle()
    {
        var val_3;
        System.Action val_5;
        val_3 = null;
        val_3 = null;
        val_5 = LobbyItemSeason.<>c.<>9__7_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  LobbyItemSeason.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LobbyItemSeason.<>c::丛一三丁不万丏丆丐());
            val_3 = null;
            LobbyItemSeason.<>c.<>9__7_0 = val_5;
        }
        
        val_3 = null;
        if((LobbyItemSeason.<>c.<>9__7_1) == null)
        {
            goto label_8;
        }
        
        label_13:
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丝业业丝丕丁丅丅丘(丘万且丑丂丈丈业丑:  true, 下丕下丅丙丞丐东丗:  val_1, 丝丆丗一上且三丒丄:  LobbyItemSeason.<>c.<>9__7_1);
        return;
        label_8:
        LobbyItemSeason.<>c.<>9__7_1 = new System.Action(object:  LobbyItemSeason.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LobbyItemSeason.<>c::丘与不丁丅七丘丂丗());
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    public void SetSelectedState(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.seletedBorder, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buffDescription, 丏业丟一东丂东丘丛:  val_1);
    }
    internal void 一丟上丟且业下丐业(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        this.SetSelectedState(丙业与丙丗丝不丈东:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemPlacedLabel, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonPlace, 丏业丟一东丂东丘丛:  (~丙业与丙丗丝不丈东) & 1);
    }
    public LobbyItemSeason()
    {
    
    }

}
