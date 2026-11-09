using UnityEngine;
public class OpenProfileMatchHistoryMenuItem : ContextMenuItemBase
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
        var val_5;
        var val_6;
        this.Interact();
        val_5 = 0;
        if( == 0)
        {
                return;
        }
        
        ProfileController.丑七不且上丗丁一世().InterfaceEnabled = false;
        val_6 = null;
        val_6 = null;
        FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  (mem[1103844756749] + (MatchHistoryPlayerContextMenu.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? true : 0 + 80, 丁丅丈丌丟世丗丗丟:  1, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  OpenProfileMatchHistoryMenuItem.<>c.<>9, method:  System.Void OpenProfileMatchHistoryMenuItem.<>c::丒万世丕业丞丒丗专(bool 且丆丏丛东下上丄丟)));
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
    public OpenProfileMatchHistoryMenuItem()
    {
    
    }

}
