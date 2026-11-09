using UnityEngine;
public sealed class PurchasesMiniGameGuiController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject allInterafaceContainer;
    public PurchaseMiniGameView[] views;
    internal NetworkStartTableNGUIController nguiController;
    
    // Methods
    private void Awake()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterafaceContainer, 丏业丟一东丂东丘丛:  false);
    }
    public void HandleItemClicked(PurchaseMiniGameView 丁世丛业丟下丕三丟)
    {
        PurchaseMiniGameView val_4 = 丁世丛业丟下丕三丟;
        .丁世丛业丟下丕三丟 = val_4;
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
                return;
        }
        
        val_4 = (PurchasesMiniGameGuiController.世丞丒丅一专丌丐丏)[1152921536024650544].丁世丛业丟下丕三丟.<丝业三丑三上丆专不>k__BackingField.丒世丘丘上丆丝东丞;
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.nguiController.allInterfaceContainer, 丒世丘丘上丆丝东丞:  val_4, 七丒上且丝业业下七:  new System.Action(object:  new PurchasesMiniGameGuiController.世丞丒丅一专丌丐丏(), method:  System.Void PurchasesMiniGameGuiController.世丞丒丅一专丌丐丏::丛丈丏三下东三业丏()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  0);
    }
    private void Update()
    {
    
    }
    private void 丄不丕丛丌丞三东丁()
    {
    
    }
    public PurchasesMiniGameGuiController()
    {
    
    }

}
