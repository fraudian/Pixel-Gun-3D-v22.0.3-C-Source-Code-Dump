using UnityEngine;
internal sealed class MenuScript : PGBehaviour
{
    // Fields
    public UnityEngine.GameObject openMenu;
    public UnityEngine.GameObject closeMenu;
    
    // Methods
    public void OnClick()
    {
        var val_9;
        var val_10;
        if(this.openMenu != 0)
        {
                if(this.openMenu != null)
        {
                val_9 = this.openMenu.activeSelf;
        }
        else
        {
                val_9 = 0.activeSelf;
        }
        
            this.openMenu.SetActive(value:  (~val_9) & 1);
        }
        
        if(this.closeMenu == 0)
        {
                return;
        }
        
        if(this.closeMenu != null)
        {
                val_10 = this.closeMenu.activeSelf;
        }
        else
        {
                val_10 = 0.activeSelf;
        }
        
        this.closeMenu.SetActive(value:  (~val_10) & 1);
    }
    public MenuScript()
    {
    
    }

}
