using UnityEngine;
public class LeaderboardsTopClansWrapGridItem : DynamicWrapGridItem
{
    // Fields
    private Rilisoft.ButtonHandler 丆丐丘丘世万丛万丁;
    private UILabel capacityLabel;
    private 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世;
    private UILabel currencyLabel;
    private UnityEngine.GameObject firstPlaceObj;
    private UITexture logoTexure;
    private UnityEngine.GameObject medalSpriteObj;
    private UnityEngine.GameObject myClanHightlightObj;
    private UILabel nameLabel;
    private UnityEngine.GameObject parentWindowObj;
    private UILabel placeLabel;
    private UnityEngine.GameObject secondPlaceObj;
    private UnityEngine.GameObject siegeSpriteObj;
    private UnityEngine.GameObject thirdPlaceObj;
    internal bool infoParentWillBeMainMenu;
    internal bool infoParentWillBeClansGuiWindow;
    
    // Methods
    protected override void Awake()
    {
        this.Awake();
        if(this.myClanHightlightObj != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.myClanHightlightObj, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.firstPlaceObj != 0)
        {
                this.firstPlaceObj.SetActive(value:  true);
        }
        
        if(this.secondPlaceObj != 0)
        {
                this.secondPlaceObj.SetActive(value:  true);
        }
        
        if(this.thirdPlaceObj == 0)
        {
                return;
        }
        
        this.thirdPlaceObj.SetActive(value:  true);
    }
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        string val_30;
        UnityEngine.GameObject val_31;
        var val_33;
        UnityEngine.GameObject val_34;
        UnityEngine.GameObject val_35;
        var val_36;
        val_31 = this;
        if(三丏丑不业丏不丂丈 == null)
        {
                return;
        }
        
        if(this.placeLabel != 0)
        {
                this.placeLabel.text = System.String.alignConst;
        }
        
        if(System.String.alignConst != 0)
        {
            goto label_8;
        }
        
        if(this.firstPlaceObj == 0)
        {
            goto label_11;
        }
        
        val_33 = 1;
        goto label_13;
        label_11:
        label_8:
        if(this.secondPlaceObj == 0)
        {
            goto label_17;
        }
        
        this.secondPlaceObj.SetActive(value:  true);
        if(this.firstPlaceObj == 0)
        {
            goto label_48;
        }
        
        val_34 = this.firstPlaceObj;
        if(val_34 != null)
        {
            goto label_49;
        }
        
        goto label_23;
        label_17:
        if(this.thirdPlaceObj == 0)
        {
            goto label_27;
        }
        
        this.thirdPlaceObj.SetActive(value:  true);
        if(this.firstPlaceObj != 0)
        {
                this.firstPlaceObj.SetActive(value:  false);
        }
        
        if(this.secondPlaceObj == 0)
        {
            goto label_52;
        }
        
        val_35 = this.secondPlaceObj;
        if(val_35 != null)
        {
            goto label_53;
        }
        
        goto label_37;
        label_27:
        if(this.placeLabel != 0)
        {
                this.placeLabel.text = (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 1).ToString();
        }
        
        if(this.firstPlaceObj == 0)
        {
            goto label_44;
        }
        
        val_33 = 0;
        label_13:
        this.firstPlaceObj.SetActive(value:  false);
        label_44:
        if(this.secondPlaceObj == 0)
        {
            goto label_48;
        }
        
        val_34 = this.secondPlaceObj;
        if(val_34 != null)
        {
            goto label_49;
        }
        
        label_23:
        label_49:
        val_34.SetActive(value:  false);
        label_48:
        if(this.thirdPlaceObj == 0)
        {
            goto label_52;
        }
        
        val_35 = this.thirdPlaceObj;
        if(val_35 != null)
        {
            goto label_53;
        }
        
        label_37:
        label_53:
        val_35.SetActive(value:  false);
        label_52:
        this.且丟丅丄丒丑丂丁世 = 0;
        UnityEngine.Texture2D val_15 = 0.世丐专丂世丄世丂丌();
        this.nameLabel.text = this.且丟丅丄丒丑丂丁世.东丙上东业丆不丟丘();
        val_30 = this.且丟丅丄丒丑丂丁世.丁丈丕丆下丙丏业世().ToString();
        this.capacityLabel.text = val_30;
        if(this.currencyLabel != 0)
        {
                val_30 = this.且丟丅丄丒丑丂丁世.业不且丟丆下丏丌丒().ToString();
            this.currencyLabel.text = val_30;
        }
        
        if(this.myClanHightlightObj == 0)
        {
                return;
        }
        
        val_31 = this.myClanHightlightObj;
        val_30 = 1152921524404748272;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                val_30 = this.且丟丅丄丒丑丂丁世;
            val_36 = System.String.op_Equality(a:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁(), b:  val_30.业丐丐三丕一丗丛丁());
        }
        else
        {
                val_36 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  false);
    }
    public void U_SelfClick()
    {
        .丝且与丝丒丟万丁专 = this;
        if((Rilisoft.Singleton<ClansController>.Instance) == 0)
        {
                return;
        }
        
        if(this.且丟丅丄丒丑丂丁世 == null)
        {
                return;
        }
        
        if(this.且丟丅丄丒丑丂丁世.丟业丅世丟丗丄丞万() > 1)
        {
                return;
        }
        
        .丞丒业万东专上丒丛 = 0;
        .丞丒业万东专上丒丛 = new System.Action(object:  new LeaderboardsTopClansWrapGridItem.与丟业一丈上丅上不(), method:  System.Void LeaderboardsTopClansWrapGridItem.与丟业一丈上丅上不::丙丏丅下不业丅丌丁());
        int val_7 = ClansWindowInfoViewController.与且丂丐万丝丘三下(丕专上丁丅丅丏万丌:  this.丛丌下业丗丄丙丙丁(), 丞丌丐丞丞丘丏专下:  this.且丟丅丄丒丑丂丁世, 丘丗不丁丘丒丅丌不:  (LeaderboardsTopClansWrapGridItem.与丟业一丈上丅上不)[1152921538249212496].丞丒业万东专上丒丛, 世丟七丕且丝丅不上:  true, 不丆丁且丕丅不丕七:  false);
        this.parentWindowObj.SetActive(value:  false);
    }
    private UnityEngine.GameObject 丛丌下业丗丄丙丙丁()
    {
        var val_1;
        var val_2;
        if(this.infoParentWillBeMainMenu == false)
        {
            goto label_1;
        }
        
        label_5:
        val_1 = null;
        val_1 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != null)
        {
                return MainMenuController.丄丞丁丈与业上丞丟.gameObject;
        }
        
        return MainMenuController.丄丞丁丈与业上丞丟.gameObject;
        label_1:
        if(this.infoParentWillBeClansGuiWindow == false)
        {
            goto label_5;
        }
        
        val_2 = null;
        val_2 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != null)
        {
                return MainMenuController.丄丞丁丈与业上丞丟.gameObject;
        }
        
        return MainMenuController.丄丞丁丈与业上丞丟.gameObject;
    }
    public LeaderboardsTopClansWrapGridItem()
    {
    
    }

}
