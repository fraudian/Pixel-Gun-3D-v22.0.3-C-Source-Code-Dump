using UnityEngine;
public class BackButtonShow : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject backButton;
    public UnityEngine.GameObject squadBackButton;
    public UnityEngine.GameObject clanSquadBackButton;
    public UnityEngine.GameObject partySquadBackButton;
    
    // Methods
    private void Awake()
    {
        var val_6;
        var val_7;
        UnityEngine.GameObject val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_13;
        var val_14;
        var val_15;
        bool val_17;
        val_6 = 1152921505189646336;
        val_7 = null;
        val_7 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false)
        {
            goto label_4;
        }
        
        val_8 = this.backButton;
        val_9 = 0;
        goto label_6;
        label_4:
        val_10 = null;
        val_10 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑 == false)
        {
            goto label_10;
        }
        
        val_11 = null;
        val_11 = null;
        if(SquadController.丘业不丅万不丐东丝 == false)
        {
            goto label_13;
        }
        
        label_10:
        val_13 = 0;
        goto label_14;
        label_13:
        bool val_1 = (SquadController.丁丛专丂业丞丑丐专 == false) ? 1 : 0;
        label_14:
        val_14 = null;
        val_14 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑 == false)
        {
            goto label_23;
        }
        
        val_15 = null;
        val_15 = null;
        if(SquadController.丘业不丅万不丐东丝 == false)
        {
            goto label_23;
        }
        
        var val_2 = (SquadController.丁丛专丂业丞丑丐专 == false) ? 1 : 0;
        goto label_26;
        label_23:
        val_6 = 0;
        label_26:
        if(((val_1 | val_6) & 1) == 0)
        {
            goto label_27;
        }
        
        val_17 = 0;
        if(this.backButton != null)
        {
            goto label_32;
        }
        
        goto label_29;
        label_27:
        val_17 = PGCompany.丁东丌世与丕东丆上.且丏下丂专丞不丂丞();
        if(this.backButton != null)
        {
            goto label_32;
        }
        
        label_29:
        label_32:
        this.backButton.SetActive(value:  val_17);
        this.squadBackButton.SetActive(value:  val_1);
        val_8 = this.clanSquadBackButton;
        val_9 = val_6;
        label_6:
        val_8.SetActive(value:  false);
    }
    public BackButtonShow()
    {
    
    }

}
