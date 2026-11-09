using UnityEngine;
public class FriendPrevInChatItem : MonoBehaviour
{
    // Fields
    public UILabel nickLabel;
    public UITexture previewTexture;
    public UISprite rank;
    public string playerID;
    public UnityEngine.GameObject newMessageObj;
    public UILabel countNewMessageLabel;
    private int 上丒丑丏上丄东丂丘;
    public int myWrapIndex;
    internal bool 丌丅丘丏万丟上丕万;
    private UnityEngine.GameObject _crownGo;
    
    // Methods
    private void Awake()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._crownGo, 丏业丟一东丂东丘丛:  false);
    }
    private int 丆丞丛丝世丙丅丛丐()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = null;
        if(this.丌丅丘丏万丟上丕万 != false)
        {
                val_7 = null;
            val_8 = 1152921505047212112;
        }
        else
        {
                val_9 = null;
            val_8 = 1152921505047212096;
        }
        
        if((val_8.ContainsKey(key:  this.playerID)) == false)
        {
            goto label_8;
        }
        
        val_10 = 0;
        val_11 = 0;
        goto label_9;
        label_15:
        业丙丅世丘东丛丄丕 val_3 = val_8.Item[this.playerID].Item[0];
        bool val_6 = val_3.丑丈专丙丛专丁与一;
        val_10 = 1;
        val_6 = val_6 ^ 1;
        val_11 = val_11 + val_6;
        label_9:
        if(val_10 < val_8.Item[this.playerID].Count)
        {
            goto label_15;
        }
        
        return (int)val_11;
        label_8:
        val_11 = 0;
        return (int)val_11;
    }
    public void UpdateCountNewMessage()
    {
        int val_1 = this.丆丞丛丝世丙丅丛丐();
        this.上丒丑丏上丄东丂丘 = val_1;
        if(this.newMessageObj == null)
        {
            goto label_0;
        }
        
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        label_3:
        this.newMessageObj.SetActive(value:  true);
        this.countNewMessageLabel.text = this.上丒丑丏上丄东丂丘.ToString();
        return;
        label_0:
        if(val_1 != 0)
        {
            goto label_3;
        }
        
        label_1:
        this.newMessageObj.SetActive(value:  false);
    }
    public void SetActivePlayer()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if(this.丌丅丘丏万丟上丕万 != false)
        {
                if((System.String.op_Inequality(a:  PrivateClanChatController.丆丕丝丒不丙且丐丗.SelectedPlayerID, b:  this.playerID)) != false)
        {
                PrivateClanChatController.丆丕丝丒不丙且丐丗.SetSelectedPlayer(丈丆丆丂且丝东丏丂:  this.playerID, 丐世丐上丁与丌七丒:  false);
            return;
        }
        
            if(this.丌丅丘丏万丟上丕万 == true)
        {
                return;
        }
        
        }
        
        if((System.String.op_Inequality(a:  PrivateChatController.丄丞丁丈与业上丞丟.selectedPlayerID, b:  this.playerID)) == false)
        {
                return;
        }
        
        PrivateChatController.丄丞丁丈与业上丞丟.SetSelectedPlayer(丈丆丆丂且丝东丏丂:  this.playerID, 丐世丐上丁与丌七丒:  false);
    }
    internal void 上专丟丟丘上且丙丐(bool 东丅丞丁丗万且丁丗)
    {
        东丅丞丁丗万且丁丗 = 东丅丞丁丗万且丁丗;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._crownGo, 丏业丟一东丂东丘丛:  东丅丞丁丗万且丁丗);
    }
    public FriendPrevInChatItem()
    {
    
    }

}
