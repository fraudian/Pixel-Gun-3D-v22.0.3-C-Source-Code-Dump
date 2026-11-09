using UnityEngine;
internal sealed class RedLightButtonInLobby : MonoBehaviour
{
    // Fields
    private static RedLightButtonInLobby 丝业丆丁业三丈丟东;
    private UnityEngine.GameObject holder;
    
    // Methods
    internal static void 丑上丞不与丄丗丌一()
    {
        if(RedLightButtonInLobby.丝业丆丁业三丈丟东 == 0)
        {
                return;
        }
        
        RedLightButtonInLobby.丝业丆丁业三丈丟东.丕丕业七丙七丅丈丄();
    }
    private void Awake()
    {
        RedLightButtonInLobby.丝业丆丁业三丈丟东 = this;
    }
    private void OnDestroy()
    {
        RedLightButtonInLobby.丝业丆丁业三丈丟东 = 0;
    }
    private void OnEnable()
    {
        this.丕丕业七丙七丅丈丄();
    }
    private void 丕丕业七丙七丅丈丄()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        long val_1 = PixelTime.丝丗专上三不丄丑丑();
        if((val_1 < 1) || (val_1.丂万丆丆丌丗丏丅不() == false))
        {
            goto label_14;
        }
        
        val_9 = null;
        val_9 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_9;
        }
        
        val_10 = null;
        val_10 = null;
        if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeSelf) == true)
        {
            goto label_14;
        }
        
        label_9:
        if((Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0) || (Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == false))
        {
            goto label_19;
        }
        
        label_14:
        label_31:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        return;
        label_19:
        val_11 = null;
        val_11 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 != 0)
        {
            goto label_26;
        }
        
        goto label_31;
        label_26:
        val_12 = null;
        val_12 = null;
        var val_8 = (FriendProfileView.丐丕丝上丅丈丐丞专.isSeeLobbyEnable == false) ? 1 : 0;
        goto label_31;
    }
    private bool 丂万丆丆丌丗丏丅不()
    {
        bool val_2 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  38);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    public RedLightButtonInLobby()
    {
    
    }

}
