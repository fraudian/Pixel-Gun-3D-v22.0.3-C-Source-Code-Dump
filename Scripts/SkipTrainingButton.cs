using UnityEngine;
public class SkipTrainingButton : MonoBehaviour
{
    // Fields
    private static System.Action 丛丂丆世丟丟丁丘丌;
    
    // Methods
    internal static void 与一丏丂丒丙丟与丆(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  SkipTrainingButton.丛丂丆世丟丟丁丘丌, b:  丙业与丙丗丝不丈东);
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
    internal static void 东丟一丂世下东丛丒(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  SkipTrainingButton.丛丂丆世丟丟丁丘丌, value:  丙业与丙丗丝不丈东);
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
    protected virtual void OnClick()
    {
        if(SkipTrainingButton.丛丂丆世丟丟丁丘丌 != null)
        {
                SkipTrainingButton.丛丂丆世丟丟丁丘丌.Invoke();
        }
        
        UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
    }
    public SkipTrainingButton()
    {
    
    }

}
