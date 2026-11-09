using UnityEngine;
public class InGameGUIPart_Dungeons : InGameGUIPartContainer
{
    // Fields
    private ProgressBarUI _progressBar;
    
    // Properties
    internal ProgressBarUI 且丟专万不世丆下丄 { get; }
    
    // Methods
    internal ProgressBarUI 丐七丆丐丏丁东丅专()
    {
        return (ProgressBarUI)this._progressBar;
    }
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丙丏专与一三万丌下 = this;
    }
    public InGameGUIPart_Dungeons()
    {
    
    }

}
