using UnityEngine;
public class NewPrivateChatMessage : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject 丒丁丏丑丅三一丕丟;
    
    // Methods
    private void Start()
    {
        this.丒丁丏丑丅三一丕丟 = this.gameObject.transform.GetChild(index:  0).gameObject;
        this.丑丌丏世丂七世万丏();
    }
    private void 丑丌丏世丂七世万丏()
    {
        var val_4 = null;
        var val_2 = (ChatController.丑万丂世丛丙万丝丛 > 0) ? 1 : 0;
        val_2 = this.丒丁丏丑丅三一丕丟.activeSelf ^ val_2;
        if(val_2 == false)
        {
                return;
        }
        
        this.丒丁丏丑丅三一丕丟.SetActive(value:  (ChatController.丑万丂世丛丙万丝丛 > 0) ? 1 : 0);
    }
    private void Update()
    {
        this.丑丌丏世丂七世万丏();
    }
    public NewPrivateChatMessage()
    {
    
    }

}
