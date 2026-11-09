using UnityEngine;
public class OpenProfileMenuItem : ContextMenuItemBase
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
        this.Interact();
        if(true == 0)
        {
                return;
        }
    
    }
    private void 丄丑七丘丁且丞丙专(bool 丝三丄专丗丞丄丄丌)
    {
        if(this.下丒丘丅丌丏丛丗丆 == 0)
        {
                return;
        }
        
        bool val_2 = 丝三丄专丗丞丄丄丌;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public OpenProfileMenuItem()
    {
    
    }
    private void 与丅丏丘一丞东下丅(bool 丕丁丗丘丟丆一丟丆)
    {
        var val_5;
        if(ClanLobbyItemController.丄丘七三上丕世丞业 != 0)
        {
                ClanLobbyItemController.丄丘七三上丕世丞业.ShowClanLobbyItems();
        }
        
        if(this != null)
        {
                val_5 = null;
        }
        
        val_5 = null;
        var val_3 = (((OpenProfileMenuItem.__il2cppRuntimeField_typeHierarchy + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_5) ? (this) : 0;
        (OpenProfileMenuItem.__il2cppRuntimeField_typeHierarchy + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_5 ? this : 0 + 96.ParentPanel.SetActive(value:  true);
    }

}
