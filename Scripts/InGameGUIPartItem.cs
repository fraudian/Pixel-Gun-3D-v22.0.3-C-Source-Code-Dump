using UnityEngine;
public class InGameGUIPartItem : MonoBehaviour
{
    // Fields
    internal InGameGUIPartItem.丑业专丄七与与丕上 itemType;
    private UIPanel 丛丘下丗业丂一且业;
    private UnityEngine.Coroutine 丈三丅丞东丞丒丘丘;
    
    // Methods
    private void Awake()
    {
        this.丛丘下丗业丂一且业 = this.GetComponent<UIPanel>();
    }
    private void OnEnable()
    {
        if(this.丈三丅丞东丞丒丘丘 != null)
        {
                return;
        }
        
        this.丈三丅丞东丞丒丘丘 = this.StartCoroutine(routine:  this.丅一丐丞丑丈三丝丙());
    }
    private System.Collections.IEnumerator 丅一丐丞丑丈三丝丙()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new InGameGUIPartItem.上丞丟丒丄且世丈七();
    }
    public InGameGUIPartItem()
    {
    
    }

}
