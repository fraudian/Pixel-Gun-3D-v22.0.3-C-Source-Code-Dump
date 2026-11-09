using UnityEngine;
internal class MessageNewCampaign : MonoBehaviour
{
    // Fields
    private string 世三丁一丌丂业丘万;
    public UnityEngine.GameObject newMessage;
    public MiniGameCell cell;
    public UnityEngine.GameObject myUnlockIndicator;
    
    // Methods
    private void OnEnable()
    {
        if((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  this.世三丁一丌丂业丘万, 丞丌丑丛上丕丙丕下:  0)) == 0)
        {
            goto label_3;
        }
        
        if(this.newMessage != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        this.newMessage.SetActive(value:  false);
        return;
        label_3:
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  "box4")) == null)
        {
            goto label_8;
        }
        
        不丛专丁世三专三丒 val_5 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  "box4");
        var val_7 = (val_5.上三丆丞丝丛丟丐不.Count == 0) ? 1 : 0;
        if(this.newMessage != null)
        {
            goto label_16;
        }
        
        goto label_17;
        label_8:
        if(this.newMessage != null)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    public void SaveClickCampaign()
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.世三丁一丌丂业丘万, 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void Update()
    {
        null = null;
        if((MainMenuController.丄丞丁丈与业上丞丟.丞丅东丄丁丝丕丘三().Contains(item:  this.cell.type)) == false)
        {
                return;
        }
        
        this.cell.newModeIndicator.SetActive(value:  false);
        this.myUnlockIndicator.SetActive(value:  true);
    }
    public MessageNewCampaign()
    {
        this.世三丁一丌丂业丘万 = "KEY_MESSAGE_NEW_CAMPAIGN";
    }

}
