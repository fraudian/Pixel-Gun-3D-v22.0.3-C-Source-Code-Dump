using UnityEngine;
public class ClanRequestsWrapGridItem : DynamicWrapGridItem
{
    // Fields
    private bool 且三丑东丘丞丆丏丁;
    private UILabel levelLabel;
    private UILabel messageLabel;
    private UILabel nameLabel;
    protected UnityEngine.GameObject parentPanel;
    private ClansInviteGuiController.丗丐丅丂不不丁三丙 东丛下丗且东丄业下;
    private UILabel rateLabel;
    private UITable table;
    private UISprite clanRankSprite;
    
    // Methods
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        if(三丏丑不业丏不丂丈 == null)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "Wrong type");
    }
    private void OnEnable()
    {
        this.且三丑东丘丞丆丏丁 = false;
    }
    private void OnDisable()
    {
    
    }
    private void 上丝不丛丗业下丂与(string 丄丒且丙三丆丟与丏)
    {
        this.且三丑东丘丞丆丏丁 = false;
        this.东丛下丗且东丄业下 = 0;
        PGCompany.Clans.Network.不不业三丒与一万丄.丑丛丒丑丄三丗丐一(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanRequestsWrapGridItem::上丝不丛丗业下丂与(string 丄丒且丙三丆丟与丏)));
        PGCompany.Clans.Network.不不业三丒与一万丄.丗丟不专丞丄丄业丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanRequestsWrapGridItem::丕业丑丆丗丘与丕东(int 丞丐丟三丌与丞上一)));
    }
    private void 丕业丑丆丗丘与丕东(int 丞丐丟三丌与丞上一)
    {
        var val_4;
        ClansWindowGUI val_5;
        string val_6;
        var val_7;
        var val_8;
        var val_9;
        this.且三丑东丘丞丆丏丁 = false;
        PGCompany.Clans.Network.不不业三丒与一万丄.丑丛丒丑丄三丗丐一(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanRequestsWrapGridItem::上丝不丛丗业下丂与(string 丄丒且丙三丆丟与丏)));
        PGCompany.Clans.Network.不不业三丒与一万丄.丗丟不专丞丄丄业丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanRequestsWrapGridItem::丕业丑丆丗丘与丕东(int 丞丐丟三丌与丞上一)));
        if(丞丐丟三丌与丞上一 == 1705)
        {
                val_4 = null;
            val_4 = null;
            val_5 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            val_6 = "Key_4253";
        }
        else
        {
                val_7 = null;
            if(丞丐丟三丌与丞上一 == 1702)
        {
                val_8 = null;
            val_5 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            val_6 = "Key_4361";
        }
        else
        {
                val_9 = null;
            val_5 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            val_6 = "Key_1528";
        }
        
        }
        
        val_5.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
    }
    private void OnClick()
    {
        null = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(this.东丛下丗且东丄业下 != null)
        {
                this.parentPanel.SetActive(value:  false);
            FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  this.东丛下丗且东丄业下.丞业丅万七万且丏丏(), 丁丅丈丌丟世丗丗丟:  1, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClanRequestsWrapGridItem::东丄专且丅丄丏丛丅(bool 丕丁丗丘丟丆一丟丆)));
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public void U_AcceptCLick()
    {
        if(this.且三丑东丘丞丆丏丁 != false)
        {
                return;
        }
        
        if(this.东丛下丗且东丄业下 != null)
        {
                this.且三丑东丘丞丆丏丁 = true;
            PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丆三世丝且丏与万丌().丑丟下东万万丝丑丛(丄丒且丙三丆丟与丏:  this.东丛下丗且东丄业下.丞业丅万七万且丏丏(), 且丟丅丄丒丑丂丁世:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟());
            this.gameObject.SetActive(value:  false);
            this.parentPanel.GetComponent<ClansInviteGuiController>().OpenTab_Requests();
            PGCompany.Clans.Network.不不业三丒与一万丄.丌一与丌丆七丑丏专(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ClanRequestsWrapGridItem::上丝不丛丗业下丂与(string 丄丒且丙三丆丟与丏)));
            PGCompany.Clans.Network.不不业三丒与一万丄.丂三世万丁丁丂丕丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanRequestsWrapGridItem::丕业丑丆丗丘与丕东(int 丞丐丟三丌与丞上一)));
            return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public void U_RejectClick()
    {
        if(this.东丛下丗且东丄业下 == null)
        {
                return;
        }
        
        this.且三丑东丘丞丆丏丁 = true;
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丆三世丝且丏与万丌().丏丗三丌丐业东与业(丄丒且丙三丆丟与丏:  this.东丛下丗且东丄业下.丞业丅万七万且丏丏());
        this.gameObject.SetActive(value:  false);
        this.parentPanel.GetComponent<ClansInviteGuiController>().OpenTab_Requests();
    }
    public ClanRequestsWrapGridItem()
    {
    
    }
    private void 东丄专且丅丄丏丛丅(bool 丕丁丗丘丟丆一丟丆)
    {
        this.parentPanel.SetActive(value:  true);
    }

}
