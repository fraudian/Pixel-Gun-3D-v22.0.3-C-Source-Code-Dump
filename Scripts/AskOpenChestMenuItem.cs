using UnityEngine;
public class AskOpenChestMenuItem : ContextMenuItemBase
{
    // Fields
    private UIButton 下丒丘丅丌丏丛丗丆;
    
    // Methods
    private void Awake()
    {
        this.下丒丘丅丌丏丛丗丆 = this.GetComponent<UIButton>();
    }
    public override void Interact()
    {
    
    }
    public override void UpdateSelf()
    {
        this.gameObject.SetActive(value:  false);
    }
    public AskOpenChestMenuItem()
    {
    
    }

}
