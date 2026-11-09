using UnityEngine;
public class RanksTapReceiver : MonoBehaviour
{
    // Fields
    private static System.Action 丘丂万丏丌三丕丙世;
    
    // Methods
    internal static void 丁上三丅丏一丄丏世(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  RanksTapReceiver.丘丂万丏丌三丕丙世, b:  丙业与丙丗丝不丈东);
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
    internal static void 丒万丕丗东上丝丁世(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  RanksTapReceiver.丘丂万丏丌三丕丙世, value:  丙业与丙丗丝不丈东);
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
    private void Start()
    {
        var val_3 = null;
        this.gameObject.SetActive(value:  (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true) ? 1 : 0);
    }
    private void OnClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(RanksTapReceiver.丘丂万丏丌三丕丙世 == null)
        {
                return;
        }
        
        RanksTapReceiver.丘丂万丏丌三丕丙世.Invoke();
    }
    public RanksTapReceiver()
    {
    
    }

}
