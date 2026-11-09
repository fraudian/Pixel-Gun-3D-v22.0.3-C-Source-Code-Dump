using UnityEngine;
public class SendSmileButtonHundler : MonoBehaviour
{
    // Fields
    private string 丗丕万丕丌丈丈丒丕;
    public SmilesPanelUi smilesPanelUi;
    
    // Methods
    private void Awake()
    {
        this.丗丕万丕丌丈丈丒丕 = this.GetComponent<UISprite>().spriteName;
    }
    private void OnClick()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        string val_23;
        var val_24;
        var val_25;
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if(this.smilesPanelUi != 0)
        {
                this.smilesPanelUi.HandleClickSmile(丗丕万丕丌丈丈丒丕:  this.丗丕万丕丌丈丈丒丕);
        }
        
        val_16 = null;
        val_16 = null;
        if(SquadPanelGUI.丄丘七三上丕世丞业 != 0)
        {
                val_17 = null;
            val_17 = null;
            if(SquadPanelGUI.丄丘七三上丕世丞业.gameObject.activeSelf != false)
        {
                val_18 = null;
            val_18 = null;
            if(SquadPanelGUI.丄丘七三上丕世丞业.gameObject.activeInHierarchy != false)
        {
                val_19 = null;
            val_19 = null;
            SquadPanelGUI.丄丘七三上丕世丞业.SendSmile(丗丕万丕丌丈丈丒丕:  this.丗丕万丕丌丈丈丒丕);
            return;
        }
        
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        if(ClanChatController.丄丞丁丈与业上丞丟 != 0)
        {
                val_21 = null;
            val_21 = null;
            if(ClanChatController.丄丞丁丈与业上丞丟.丏一丅丄丂丌且且丁() != false)
        {
                val_22 = null;
            val_22 = null;
            ClanChatController.丄丞丁丈与业上丞丟.SendSmile(丗丕万丕丌丈丈丒丕:  this.丗丕万丕丌丈丈丒丕);
            return;
        }
        
        }
        
        if(PrivateChatController.丄丞丁丈与业上丞丟 != 0)
        {
                if(PrivateChatController.丄丞丁丈与业上丞丟.东丒丝丘万一丆世专() != false)
        {
                PrivateChatController.丄丞丁丈与业上丞丟.SendSmile(七不丌丆丕一丝不丁:  this.丗丕万丕丌丈丈丒丕);
        }
        
        }
        
        val_23 = 1152921505145610240;
        if(PrivateClanChatController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(PrivateClanChatController.丆丕丝丒不丙且丐丗.东丒丝丘万一丆世专() != false)
        {
                val_23 = this.丗丕万丕丌丈丈丒丕;
            PrivateClanChatController.丆丕丝丒不丙且丐丗.SendSmile(七不丌丆丕一丝不丁:  val_23);
        }
        
        }
        
        val_24 = null;
        val_24 = null;
        if(ChatViewrController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_23 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐.playerMoveC == 0)
        {
                return;
        }
        
        SendChat(丕丗丘丑丛与丑业丒:  System.String.alignConst, 业上丏丏丑丂专丒世:  false, 丛丐丌丙丈七丛丛东:  this.丗丕万丕丌丈丈丒丕);
        val_25 = null;
        val_25 = null;
        ChatViewrController.丄丞丁丈与业上丞丟.HideSmilePannelOnClick();
    }
    public SendSmileButtonHundler()
    {
        this.丗丕万丕丌丈丈丒丕 = System.String.alignConst;
    }

}
