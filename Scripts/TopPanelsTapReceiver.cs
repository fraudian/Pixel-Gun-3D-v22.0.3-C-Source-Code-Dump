using UnityEngine;
public class TopPanelsTapReceiver : MonoBehaviour
{
    // Fields
    private static System.Action 丌不丂丌丁丛丆丟与;
    
    // Methods
    internal static void 万万且丞与万业丈丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  TopPanelsTapReceiver.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丂东东丌世与与上丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  TopPanelsTapReceiver.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    private void Start()
    {
        var val_3 = null;
        this.gameObject.SetActive(value:  (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true) ? 1 : 0);
    }
    private void OnClick()
    {
        var val_1;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_1 = null;
        val_1 = null;
        TopPanelsTapReceiver.丌不丂丌丁丛丆丟与.Invoke();
    }
    public TopPanelsTapReceiver()
    {
    
    }
    private static TopPanelsTapReceiver()
    {
        null = null;
        TopPanelsTapReceiver.丌不丂丌丁丛丆丟与 = new System.Action(object:  TopPanelsTapReceiver.<>c.<>9, method:  System.Void TopPanelsTapReceiver.<>c::专且丑世万一丟丁万());
    }

}
