using UnityEngine;
public class EnterPasswordInFriensJoinButton : MonoBehaviour
{
    // Fields
    public UILabel passwordLabel;
    public JoinRoomFromFrends joinRoomFromFrends;
    
    // Methods
    private void Start()
    {
    
    }
    private void OnClick()
    {
        var val_4;
        JoinRoomFromFrends val_5;
        if(this.joinRoomFromFrends == 0)
        {
                val_4 = null;
            val_4 = null;
            val_5 = JoinRoomFromFrends.丞丗丞丂三下丏丈丛;
            this.joinRoomFromFrends = val_5;
        }
        else
        {
                val_5 = this.joinRoomFromFrends;
        }
        
        if(val_5 == 0)
        {
                return;
        }
        
        this.joinRoomFromFrends.EnterPassword(丙七一丒丛丈丁丏专:  this.passwordLabel.text);
    }
    public EnterPasswordInFriensJoinButton()
    {
    
    }

}
