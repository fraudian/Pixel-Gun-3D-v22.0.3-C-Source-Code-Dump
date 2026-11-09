using UnityEngine;
public class ClanSearchWrapGridItem : DynamicWrapGridItem
{
    // Fields
    private bool 丐上不业丐丕丅丆与;
    private Rilisoft.ButtonHandler 丆丐丘丘世万丛万丁;
    private UILabel capacityLabelForClanMember;
    private UILabel capacityLabelForPlayer;
    private ClanMainSearchGui clanSearchGui;
    private LoadingButton joinButton;
    private UITexture logoTexure;
    private UILabel nameLabel;
    private UITable nameSloganTabel;
    private UIButton requestSendedButton;
    private UnityEngine.GameObject sendRequestDisabled;
    private UnityEngine.GameObject promotedBackground;
    private UIButton sendRequestButton;
    private UILabel sloganLabel;
    private ClanSearchGui.丑丏丄且丁且一专三 <七七丒丆丐丛丈丏丕>k__BackingField;
    
    // Properties
    internal ClanSearchGui.丑丏丄且丁且一专三 七丛专丙丝丛丗专七 { get; set; }
    public bool 丆丛丆丞下丅丂且丝 { get; set; }
    
    // Methods
    internal ClanSearchGui.丑丏丄且丁且一专三 丂与七丒丘丅三世一()
    {
        return (丑丏丄且丁且一专三)this.<七七丒丆丐丛丈丏丕>k__BackingField;
    }
    private void 丈丙丅世且三丞与丑(ClanSearchGui.丑丏丄且丁且一专三 丙业与丙丗丝不丈东)
    {
        this.<七七丒丆丐丛丈丏丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_isEnabled()
    {
        return (bool)this.丐上不业丐丕丅丆与;
    }
    public void set_isEnabled(bool 丙业与丙丗丝不丈东)
    {
        this.丐上不业丐丕丅丆与 = 丙业与丙丗丝不丈东;
        UIButton val_2 = this.joinButton.button;
        bool val_3 = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        this.joinButton.Pressed = false;
    }
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        UIButton val_36;
        ClanSearchGui.丑丏丄且丁且一专三 val_37;
        UnityEngine.GameObject val_38;
        var val_39;
        var val_40;
        val_37 = 三丏丑不业丏不丂丈;
        val_38 = this;
        if(val_37 != null)
        {
                this.<七七丒丆丐丛丈丏丕>k__BackingField = val_37;
        }
        else
        {
                val_37 = this.<七七丒丆丐丛丈丏丕>k__BackingField;
            if(val_37 == null)
        {
                return;
        }
        
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance) != 0)
        {
                var val_5 = ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != 0) ? 1 : 0;
        }
        else
        {
                val_36 = 0;
        }
        
        UnityEngine.Texture2D val_6 = this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.世丐专丂世丄世丂丌();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.东丙上东业丆不丟丘());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.sloganLabel, 丕丗丘丑丛与丑业丒:  "[03CDFF]" + this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丆不与丕世丏三丅一()(this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丆不与丕世丏三丅一()) + "[-]"("[-]"));
        int val_36 = System.String.alignConst;
        val_36 = System.String.op_Inequality(a:  this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丆不与丕世丏三丅一(), b:  val_36);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.sloganLabel, 丏业丟一东丂东丘丛:  val_36);
        string val_13 = System.String.Format(format:  "{0}/{1}", arg0:  this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丁丈丕丆下丙丏业世(), arg1:  this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丄丑丙万丌丂一丄丙);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.capacityLabelForPlayer, 丕丗丘丑丛与丑业丒:  val_13);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.capacityLabelForClanMember, 丕丗丘丑丛与丑业丒:  val_13);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.capacityLabelForPlayer, 丏业丟一东丂东丘丛:  (val_36 == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.capacityLabelForClanMember, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.sendRequestButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.requestSendedButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.joinButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sendRequestDisabled, 丏业丟一东丂东丘丛:  false);
        if(val_36 != 0)
        {
                return;
        }
        
        if((this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丟业丅世丟丗丄丞万()) > 1)
        {
                return;
        }
        
        if((this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.不业丙丒丂丞下丆丙()) != 2)
        {
            goto label_23;
        }
        
        val_36 = this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丘丗丏丁丂丑一丌丙();
        if(val_36 <= 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与())
        {
            goto label_26;
        }
        
        label_23:
        if((this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.不业丙丒丂丞下丆丙()) != 1)
        {
            goto label_30;
        }
        
        val_36 = this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丘丗丏丁丂丑一丌丙();
        if(val_36 <= 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与())
        {
            goto label_30;
        }
        
        label_26:
        val_39 = null;
        val_39 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_39;
        }
        
        PGCompany.Clans.Network.不不业三丒与一万丄 val_24 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丆三世丝且丏与万丌();
        if((val_24.业丑三丐丈世丄丛七.Contains(item:  this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁())) == false)
        {
            goto label_39;
        }
        
        val_40 = null;
        val_36 = this.requestSendedButton;
        goto label_43;
        label_39:
        val_40 = null;
        val_36 = this.sendRequestButton;
        label_43:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_36, 丏业丟一东丂东丘丛:  true);
        label_30:
        if((this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.不业丙丒丂丞下丆丙()) == 1)
        {
                val_36 = this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丘丗丏丁丂丑一丌丙();
            if(val_36 <= 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与())
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.joinButton, 丏业丟一东丂东丘丛:  true);
            val_36 = this.joinButton;
            val_36.Pressed = ((this.<七七丒丆丐丛丈丏丕>k__BackingField.下世丕丂上与上上丌) == true) ? 1 : 0;
        }
        
        }
        
        if((this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.不业丙丒丂丞下丆丙()) == 2)
        {
                val_36 = this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丘丗丏丁丂丑一丌丙();
            if(val_36 > 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与())
        {
                val_36 = this.sendRequestDisabled;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        val_38 = this.promotedBackground;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_38, 丏业丟一东丂东丘丛:  this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丗丅与三不万一丟丐());
    }
    public void U_SelfClick()
    {
        var val_9;
        .丝且与丝丒丟万丁专 = this;
        if(this.丐上不业丐丕丅丆与 == false)
        {
                return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance) == 0)
        {
                return;
        }
        
        if((this.<七七丒丆丐丛丈丏丕>k__BackingField) == null)
        {
                return;
        }
        
        if((this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世) != null)
        {
                if((this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.丟业丅世丟丗丄丞万()) > 1)
        {
                return;
        }
        
        }
        
        .丞丒业万东专上丒丛 = 0;
        .丞丒业万东专上丒丛 = new System.Action(object:  new ClanSearchWrapGridItem.丌丐丝丐下上三丛丌(), method:  System.Void ClanSearchWrapGridItem.丌丐丝丐下上三丛丌::丙丏丅下不业丅丌丁());
        val_9 = null;
        val_9 = null;
        int val_7 = ClansWindowInfoViewController.与且丂丐万丝丘三下(丕专上丁丅丅丏万丌:  ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject, 丞丌丐丞丞丘丏专下:  this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世, 丘丗不丁丘丒丅丌不:  (ClanSearchWrapGridItem.丌丐丝丐下上三丛丌)[1152921536661598960].丞丒业万东专上丒丛, 世丟七丕且丝丅不上:  true, 不丆丁且丕丅不丕七:  true);
        this.clanSearchGui.丅与丌专丟一丝业三().SetActive(value:  false);
    }
    public void U_JoinClick()
    {
        this.<七七丒丆丐丛丈丏丕>k__BackingField.下世丕丂上与上上丌 = true;
        string val_1 = this.<七七丒丆丐丛丈丏丕>k__BackingField.且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁();
        if(this.clanSearchGui == null)
        {
            
        }
    
    }
    public void U_SendRequestClick()
    {
        if(this.clanSearchGui == null)
        {
            
        }
    
    }
    public ClanSearchWrapGridItem()
    {
        this.丐上不业丐丕丅丆与 = true;
    }

}
