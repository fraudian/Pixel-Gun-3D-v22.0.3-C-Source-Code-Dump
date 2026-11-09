using UnityEngine;
public class InGameGUIPart_FlagCapture : InGameGUIPartContainer
{
    // Fields
    public UnityEngine.GameObject message_draw;
    public UnityEngine.GameObject message_now;
    public UnityEngine.GameObject message_wait;
    public UnityEngine.GameObject message_returnFlag;
    private UnityEngine.GameObject flagRedCaptureTexture;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.专专丛丟丆丂且丄丒 = this;
    }
    internal void 丛上七丈与丞上丘丄(bool 上丙万丛万丑丘下丛)
    {
        上丙万丛万丑丘下丛 = 上丙万丛万丑丘下丛;
        this.flagRedCaptureTexture.SetActive(value:  上丙万丛万丑丘下丛);
    }
    public InGameGUIPart_FlagCapture()
    {
    
    }

}
