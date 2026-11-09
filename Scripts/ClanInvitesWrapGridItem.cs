using UnityEngine;
public class ClanInvitesWrapGridItem : DynamicWrapGridItem
{
    // Fields
    private LoadingButton acceptButton;
    private UILabel capacityLabel;
    private 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世;
    private UnityEngine.GameObject clanSearchObject;
    private UITexture logoTexture;
    private UILabel nameLabel;
    
    // Methods
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        string val_7;
        if(三丏丑不业丏不丂丈 == null)
        {
                return;
        }
        
        this.且丟丅丄丒丑丂丁世 = 三丏丑不业丏不丂丈;
        UnityEngine.Texture2D val_1 = 三丏丑不业丏不丂丈.世丐专丂世丄世丂丌();
        this.nameLabel.text = this.且丟丅丄丒丑丂丁世.东丙上东业丆不丟丘();
        val_7 = System.String.Format(format:  "{0}/{1}", arg0:  this.且丟丅丄丒丑丂丁世.丁丈丕丆下丙丏业世(), arg1:  this.且丟丅丄丒丑丂丁世.丄丑丙万丌丂一丄丙);
        this.capacityLabel.text = val_7;
        this = this.acceptButton;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  (this.且丟丅丄丒丑丂丁世.丟业丅世丟丗丄丞万() < 2) ? 1 : 0);
    }
    public void U_SelfClick()
    {
        var val_8;
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
        .丞丒业万东专上丒丛 = new System.Action(object:  new ClanInvitesWrapGridItem.丒丑万一丁丕东一丗(), method:  System.Void ClanInvitesWrapGridItem.丒丑万一丁丕东一丗::丙丏丅下不业丅丌丁());
        val_8 = null;
        val_8 = null;
        int val_7 = ClansWindowInfoViewController.与且丂丐万丝丘三下(丕专上丁丅丅丏万丌:  ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject, 丞丌丐丞丞丘丏专下:  this.且丟丅丄丒丑丂丁世, 丘丗不丁丘丒丅丌不:  (ClanInvitesWrapGridItem.丒丑万一丁丕东一丗)[1152921536608059088].丞丒业万东专上丒丛, 世丟七丕且丝丅不上:  true, 不丆丁且丕丅不丕七:  false);
        this.clanSearchObject.SetActive(value:  false);
    }
    public void U_AcceptCLick()
    {
        if(this.且丟丅丄丒丑丂丁世 == null)
        {
                return;
        }
        
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().丌丑东世丙东一万丒(丄丒下业一不丈丝丘:  this.且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁());
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丌世不下丑丏丙丛三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanInvitesWrapGridItem::上业三丝丑世丄丞上()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丐丝七七上专丘万丅(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanInvitesWrapGridItem::丅丆丘丘丞七丟与东(int 丞丐丟三丌与丞上一, string 一丞丟丌世丁下丈世)));
    }
    private void 上业三丝丑世丄丞上()
    {
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丁丙丑世世丆丙上丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanInvitesWrapGridItem::上业三丝丑世丄丞上()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丛丘丏丙一一七丗丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanInvitesWrapGridItem::丅丆丘丘丞七丟与东(int 丞丐丟三丌与丞上一, string 一丞丟丌世丁下丈世)));
        this.acceptButton.Pressed = false;
    }
    private void 丅丆丘丘丞七丟与东(int 丞丐丟三丌与丞上一, string 一丞丟丌世丁下丈世)
    {
        var val_8;
        ClansWindowGUI val_9;
        string val_10;
        var val_11;
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丁丙丑世世丆丙上丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanInvitesWrapGridItem::上业三丝丑世丄丞上()));
        PGCompany.Clans.Network.与丗丐上丞丞丂丛丐.丛丘丏丙一一七丗丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.String>(object:  this, method:  System.Void ClanInvitesWrapGridItem::丅丆丘丘丞七丟与东(int 丞丐丟三丌与丞上一, string 一丞丟丌世丁下丈世)));
        this.acceptButton.Pressed = false;
        if(丞丐丟三丌与丞上一 == 1710)
        {
            goto label_2;
        }
        
        if(丞丐丟三丌与丞上一 != 1702)
        {
            goto label_3;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        val_10 = "Key_4361";
        goto label_8;
        label_2:
        val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5938");
        InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  val_9, 丂三丟丂丈丐丆丗丟:  ((System.Int32.TryParse(s:  一丞丟丌世丁下丈世, result: out  0)) != true) ? 0f : 1200f);
        return;
        label_3:
        val_11 = null;
        val_11 = null;
        val_9 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        val_10 = "Key_1528";
        label_8:
        val_9.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_10), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
    }
    public void U_RejectClick()
    {
        if(this.且丟丅丄丒丑丂丁世 == null)
        {
                return;
        }
        
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().东业一东三丂丙丏且(丄丒下业一不丈丝丘:  this.且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁());
    }
    public ClanInvitesWrapGridItem()
    {
    
    }

}
