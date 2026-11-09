using UnityEngine;
public sealed class HideSaleLabelInShop : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject needTier;
    
    // Methods
    private void Update()
    {
        if(this.needTier.activeSelf == false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public HideSaleLabelInShop()
    {
    
    }

}
