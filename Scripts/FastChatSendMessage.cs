using UnityEngine;
public class FastChatSendMessage : MonoBehaviour
{
    // Fields
    public string message;
    public UISprite iconSprite;
    
    // Methods
    private void Awake()
    {
    
    }
    private void OnClick()
    {
        ChatViewrController val_3;
        Player_move_c val_4;
        var val_5;
        var val_6;
        val_3 = this;
        val_4 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐.playerMoveC == 0)
        {
                return;
        }
        
        val_4 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
        val_4 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
        SendChat(丕丗丘丑丛与丑业丒:  this.message, 业上丏丏丑丂专丒世:  false, 丛丐丌丙丈七丛丛东:  System.String.alignConst);
        val_5 = null;
        val_5 = null;
        val_3 = ChatViewrController.丄丞丁丈与业上丞丟;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        ChatViewrController.丄丞丁丈与业上丞丟.CloseChat(丈丕丂丄下丘丗专丁:  false);
    }
    public FastChatSendMessage()
    {
        this.message = "-=GO!=-";
    }

}
