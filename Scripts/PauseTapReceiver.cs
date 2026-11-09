using UnityEngine;
public class PauseTapReceiver : MonoBehaviour
{
    // Fields
    private static System.Action 丗与丐东丕万丆东不;
    
    // Methods
    internal static void 七丝丗丁丛丌东万且(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  PauseTapReceiver.丗与丐东丕万丆东不, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丒丈一丂丐丛一不丅(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  PauseTapReceiver.丗与丐东丕万丆东不, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void OnClick()
    {
        InGameGUI val_6;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_6 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_6.ExitingInCampaign == true)
        {
                return;
        }
        
        }
        
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        val_6 = Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗();
        if((val_6.Equals(value:  "New_tutor")) == true)
        {
                return;
        }
        
        if(PauseTapReceiver.丗与丐东丕万丆东不 == null)
        {
                return;
        }
        
        PauseTapReceiver.丗与丐东丕万丆东不.Invoke();
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        var val_1;
        var val_2;
        val_1 = 东丗七丕丄不丐专丒;
        if(val_1 == false)
        {
                return;
        }
        
        val_1 = 1152921505171275776;
        val_2 = null;
        val_2 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                return;
        }
        
        OnClick();
    }
    public PauseTapReceiver()
    {
    
    }

}
