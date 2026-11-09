using UnityEngine;
internal sealed class InGameGUIPart_HoldPositions : InGameGUIPartContainer
{
    // Fields
    public UnityEngine.GameObject pointCaptureBar;
    public UISprite teamColorSprite;
    public UISprite captureBarSprite;
    public UILabel pointCaptureName;
    public UnityEngine.GameObject message_wait;
    public HoldPositions_TimerUI HoldPositions_TimerUI;
    public UnityEngine.GameObject NotificationContainer;
    public UILabel NotificationLabel;
    private DisableObjectFromTimer 丞丅丁丅丕丅丒东丗;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丄丑上且下丟世丏丐 = this;
        if(this.NotificationContainer == 0)
        {
                return;
        }
        
        this.丞丅丁丅丕丅丒东丗 = this.NotificationContainer.GetComponent<DisableObjectFromTimer>();
    }
    internal void 丑丅丝三丝丞三丏丄()
    {
        if(this.NotificationLabel != 0)
        {
                this.NotificationLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11510");
        }
        
        this.丒东丟丒丈上专丁丗();
    }
    internal void 丟不丘丝丆上且丛且()
    {
        if(this.NotificationLabel != 0)
        {
                this.NotificationLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11511");
        }
        
        this.丒东丟丒丈上专丁丗();
    }
    private void 丒东丟丒丈上专丁丗()
    {
        if(this.丞丅丁丅丕丅丒东丗 != 0)
        {
                this.丞丅丁丅丕丅丒东丗.timer = 3f;
        }
        
        if(this.NotificationContainer.transform.parent == 0)
        {
                return;
        }
        
        if(this.NotificationContainer.transform.parent.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.NotificationContainer.SetActive(value:  true);
    }
    public InGameGUIPart_HoldPositions()
    {
    
    }

}
