using UnityEngine;
public class GameInfo : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject openSprite;
    public UnityEngine.GameObject closeSprite;
    public SetHeadLabelText mapNameLabel;
    public UITexture mapTexture;
    public UILabel countPlayersLabel;
    public UILabel serverNameLabel;
    public UILabel SizeMapLabel;
    public 丞丘丒一上与丕丒且 roomInfo;
    public LANBroadcastService.丈丒世与万丘丈三专 roomInfoLocal;
    public int index;
    public UnityEngine.GameObject customizedIcon;
    
    // Methods
    internal void 丏丛与业丆丝世丒丗(SceneInfo 万丁世丗丒丐丙丄丆)
    {
        if(万丁世丗丒丐丙丄丆 == 0)
        {
                return;
        }
        
        if(this.SizeMapLabel == 0)
        {
                return;
        }
        
        this.SizeMapLabel.gameObject.SetActive(value:  true);
        if(万丁世丗丒丐丙丄丆.sizeMap > 3)
        {
                return;
        }
        
        var val_9 = 106024736 + (万丁世丗丒丐丙丄丆.sizeMap) << 2;
        val_9 = val_9 + 106024736;
        goto (106024736 + (万丁世丗丒丐丙丄丆.sizeMap) << 2 + 106024736);
    }
    public void SetCustomizedIconVision(bool 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        this.customizedIcon.SetActive(value:  三丟东丕丄丄下下丑);
    }
    private void OnClick()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_10 = this;
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 9)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 30)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 38)
        {
            goto label_13;
        }
        
        }
        
        }
        
        if(CustomMiniGameController.丂丞丛丙东丗丈业丑() == 0)
        {
                return;
        }
        
        CustomMiniGameController.丂丞丛丙东丗丈业丑().JoinToRoomPhoton(世东丈丙丘下丝丌三:  this.roomInfo);
        return;
        label_13:
        val_11 = static_value_081DACA8;
        val_11 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = static_value_081DACA8;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                val_14 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.JoinToRoomPhoton(世东丈丙丘下丝丌三:  this.roomInfo);
            return;
        }
        
        val_15 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.JoinToLocalRoom(世东丈丙丘下丝丌三:  new 丈丒世与万丘丈三专() {丐丅丐丐丌丅丒丛一 = this.roomInfoLocal, 丒丘丏上丙丟丑丕丈 = this.roomInfoLocal, 丞丁丑丏丄丏七丂不 = ???, 丙丕丁七丟丈丛丈专 = ???, 丞与一东丈世且丐丕 = ???, 丐丆丐七一上专三丑 = ???, 与且世三丙丈一丈万 = ???, 丒七世丈丌丑丏丄丏 = ???, 丁与丈业专三丐丞丒 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏});
    }
    public GameInfo()
    {
    
    }

}
