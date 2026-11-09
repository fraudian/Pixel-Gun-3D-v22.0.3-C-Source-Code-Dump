using UnityEngine;
public class TeamDuelPlayerIcons : MonoBehaviour
{
    // Fields
    public TeamDuelPlayerIcon[] teamDuelRedPlayerIcons;
    public TeamDuelPlayerIcon[] teamDuelBluePlayerIcons;
    public UnityEngine.GameObject winningBlue;
    public UnityEngine.GameObject winningRed;
    public UnityEngine.GameObject mineBlue;
    
    // Methods
    private void Awake()
    {
    
    }
    private void Update()
    {
        var val_16;
        TeamDuelPlayerIcon[] val_17;
        var val_18;
        var val_19;
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        if(TeamDuelController.丅丌丛丏丞上万丛丕 != 0)
        {
                if(TeamDuelController.丅丌丛丏丞上万丛丕.duelUI != 0)
        {
                val_17 = this.teamDuelBluePlayerIcons;
            TeamDuelController.丅丌丛丏丞上万丛丕.duelUI.丕上丕丗丆丛东丏专(丌丏丅丕丗世专丝丛:  val_17, 上丆丐丘丘丗东丘丒:  this.teamDuelRedPlayerIcons);
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        int val_8 = 丒一不且丂下丅丗丂();
        this.mineBlue.SetActive(value:  (丘丑丅三丆丑丌且丝() > 0) ? 1 : 0);
        int val_11 = 丘丑丅三丆丑丌且丝();
        bool val_14 = (val_8 != 0) ? 1 : 0;
        this.winningBlue.SetActive(value:  val_14 & ((val_11 == val_8) ? 1 : 0));
        val_14 = val_14 & ((val_11 != val_8) ? 1 : 0);
        this.winningRed.SetActive(value:  val_14);
    }
    public TeamDuelPlayerIcons()
    {
    
    }

}
