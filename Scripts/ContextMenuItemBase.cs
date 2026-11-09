using UnityEngine;
public class ContextMenuItemBase : MonoBehaviour, 丛丐丕丐丁专丒丌丐
{
    // Fields
    public ContextMenuBase ParentMenu;
    
    // Methods
    public virtual void Interact()
    {
        if(this.ParentMenu == null)
        {
            
        }
    
    }
    public virtual void UpdateSelf()
    {
    
    }
    public ContextMenuItemBase()
    {
    
    }

}
