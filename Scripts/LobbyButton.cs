using UnityEngine;
internal sealed class LobbyButton : PGBehaviour
{
    // Fields
    private static System.Action<LobbyButton.丈七丄丟丞丝丟丂丗> 丏丂不上丒丂丌丄下;
    private bool updateViewOnEnable;
    private UnityEngine.GameObject common_Holder;
    private UnityEngine.GameObject state_Active;
    private UnityEngine.GameObject state_NotActive;
    private UnityEngine.GameObject state_Locked;
    private UnityEngine.GameObject state_Disabled;
    private lockedOnProgressUI lockedUI;
    private LobbyButtonHint hintUI;
    private PGCompany.GuiNotification _adsChestGuiNotification;
    private UIBasicSprite additinalIcon;
    private LobbyButton.丈七丄丟丞丝丟丂丗 _buttonType;
    private UnityEngine.GameObject _rewardGameModeContainer;
    private LobbyButton.丕丌专丙世业业丑丝 丙丌丗丕丑丆与丈丁;
    private ExpOpenSystem.丒上丂丑丐不丂丐且 丑丛丟丞丘丄下丌一;
    
    // Properties
    internal LobbyButton.丈七丄丟丞丝丟丂丗 业丝丄不丞丝上丁与 { get; }
    internal LobbyButton.丕丌专丙世业业丑丝 丝下丐丁专丂丈业一 { get; }
    internal ExpOpenSystem.丒上丂丑丐不丂丐且 丒上丂丑丐不丂丐且 { get; }
    internal int 丈业东丛丂丟丝与丈 { get; }
    internal bool 专且丝丞丂丕丒丐七 { get; }
    
    // Methods
    internal static void 丗丒丛丗上丒丅丝丐(System.Action<LobbyButton.丈七丄丟丞丝丟丂丗> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  LobbyButton.丏丂不上丒丂丌丄下, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 下丌业丒业丌丁丘丄(System.Action<LobbyButton.丈七丄丟丞丝丟丂丗> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  LobbyButton.丏丂不上丒丂丌丄下, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal LobbyButton.丈七丄丟丞丝丟丂丗 丒丑丕丄丘与丗丕不()
    {
        return (丈七丄丟丞丝丟丂丗)this._buttonType;
    }
    internal LobbyButton.丕丌专丙世业业丑丝 东且丆丌世三丗丒丁()
    {
        return (丕丌专丙世业业丑丝)this.丙丌丗丕丑丆与丈丁;
    }
    internal ExpOpenSystem.丒上丂丑丐不丂丐且 丘丑丄专丗丙丅丏下()
    {
        if(this.丑丛丟丞丘丄下丌一 != null)
        {
                return val_3;
        }
        
        ExpOpenSystem.丒上丂丑丐不丂丐且 val_3 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丞丞丏丛丄不且业七(丆万一不丌且东丐丐:  上丞丟上丌丟丁不丗.丌丈丛丁世下丁丅丆(上且丁万丝世三丄丂:  this._buttonType));
        this.丑丛丟丞丘丄下丌一 = val_3;
        return val_3;
    }
    internal int 丝丞丅不七丒丅丛东()
    {
        return 上丞丟上丌丟丁不丗.世丟专丟丝七丅丐不(上且丁万丝世三丄丂:  this._buttonType);
    }
    internal bool 一丁丁丐下且丈丞丐()
    {
        return 上丞丟上丌丟丁不丗.专且丝丞丂丕丒丐七(上且丁万丝世三丄丂:  this._buttonType);
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rewardGameModeContainer, 丏业丟一东丂东丘丛:  PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丝丟不丄丅且专丄丈().丏丝丐丗丅丌专上下());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.hintUI, 丏业丟一东丂东丘丛:  false);
        if(LobbyButton.丏丂不上丒丂丌丄下 != null)
        {
                LobbyButton.丏丂不上丒丂丌丄下.Invoke(obj:  this._buttonType);
        }
        
        if(this.updateViewOnEnable == false)
        {
                return;
        }
        
        this.丕丕业七丙七丅丈丄();
        this.丏丄七与三丅丆丆专();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        this.丕丕业七丙七丅丈丄();
        this.丏丄七与三丅丆丆专();
    }
    private void 丕丕业七丙七丅丈丄()
    {
        this.丙丌丗丕丑丆与丈丁 = 上丞丟上丌丟丁不丗.丈丛七丐丏丘丕下丕(上且丁万丝世三丄丂:  this._buttonType);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.common_Holder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Active, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotActive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Locked, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedUI, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Disabled, 丏业丟一东丂东丘丛:  false);
        丕丌专丙世业业丑丝 val_12 = this.丙丌丗丕丑丆与丈丁;
        val_12 = val_12 - 1;
        if(val_12 > 3)
        {
                return;
        }
        
        var val_13 = 106041336 + ((this.丙丌丗丕丑丆与丈丁 - 1)) << 2;
        val_13 = val_13 + 106041336;
        goto (106041336 + ((this.丙丌丗丕丑丆与丈丁 - 1)) << 2 + 106041336);
    }
    private void 下东丟丈丘丞一丘丛()
    {
        if((上丞丟上丌丟丁不丗.专且丝丞丂丕丒丐七(上且丁万丝世三丄丂:  this._buttonType)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedUI, 丏业丟一东丂东丘丛:  true);
            if(this.lockedUI == null)
        {
                return;
        }
        
            this.lockedUI.丈且东丑丂且万丒丅(上丕丈丞丌丘丅不与:  上丞丟上丌丟丁不丗.世丟专丟丝七丅丐不(上且丁万丝世三丄丂:  this._buttonType));
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedUI, 丏业丟一东丂东丘丛:  false);
    }
    private void 丏丄七与三丅丆丆专()
    {
        UnityEngine.Object val_7;
        if(this._buttonType != 5)
        {
                return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌();
        }
        else
        {
                val_7 = 0;
        }
        
        UnityEngine.Object val_7 = 0;
        val_7 = UnityEngine.Object.op_Inequality(x:  val_7, y:  val_7);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.additinalIcon, 丏业丟一东丂东丘丛:  val_7);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.additinalIcon, 与万丆丛丒万丝丙丑:  val_7);
    }
    public void U_Click()
    {
        LobbyButtonHint val_3;
        if(this.丙丌丗丕丑丆与丈丁 == 4)
        {
                return;
        }
        
        if(this.丙丌丗丕丑丆与丈丁 != 3)
        {
            goto label_2;
        }
        
        if(this.丘丑丄专丗丙丅丏下() == null)
        {
                return;
        }
        
        if(this.hintUI == null)
        {
            goto label_4;
        }
        
        this.hintUI.丈且东丑丂且万丒丅(一丑不丞丟丑东丗丛:  this);
        val_3 = this.hintUI;
        goto label_5;
        label_2:
        NewLobbyUI.丑七不且上丗丁一世().LobbyButtonClicked(丟丒丞丐丐丘丒丄东:  this);
        return;
        label_4:
        val_3 = 0;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  true);
    }
    public LobbyButton()
    {
    
    }

}
