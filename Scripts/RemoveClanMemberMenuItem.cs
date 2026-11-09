using UnityEngine;
public class RemoveClanMemberMenuItem : ContextMenuItemBase
{
    // Fields
    private UIButton 下丒丘丅丌丏丛丗丆;
    
    // Methods
    private void Awake()
    {
        this.下丒丘丅丌丏丛丗丆 = this.GetComponent<UIButton>();
    }
    private void OnEnable()
    {
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.丆丕与三万三丐丐与(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void RemoveClanMemberMenuItem::丄丑七丘丁且丞丙专(string 万丘万丈与丆丗丂丄)));
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.丐世下世一丘万不下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RemoveClanMemberMenuItem::东丆且世丑上丕丕丙()));
    }
    private void OnDisable()
    {
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.万七东丐不丑丏专丝(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void RemoveClanMemberMenuItem::丄丑七丘丁且丞丙专(string 万丘万丈与丆丗丂丄)));
        PGCompany.Clans.Network.丑丄丕且一世丌丅下.七东上丒丈丂丑丌丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RemoveClanMemberMenuItem::东丆且世丑上丕丕丙()));
    }
    public override void Interact()
    {
        if(true == 0)
        {
                return;
        }
    
    }
    public override void UpdateSelf()
    {
        var val_9;
        var val_11;
        if((Rilisoft.Singleton<ClansController>.Instance.下丑上丌丐丑世丁丕()) == false)
        {
            goto label_2;
        }
        
        if(X21 != 0)
        {
                val_9 = null;
            val_11 = mem[X21 + 200];
            val_11 = X21 + 200;
        }
        
        val_9 = null;
        val_11 = mem[X21 + 200];
        val_11 = X21 + 200;
        var val_5 = (((X21 + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_9) ? (X21) : 0;
        if((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  (X21 + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_9 ? X21 : 0 + 88.业丐丐三丕一丗丛丁())) == false)
        {
            goto label_7;
        }
        
        label_2:
        this.gameObject.SetActive(value:  false);
        return;
        label_7:
        this.丄丑七丘丁且丞丙专(丝三丄专丗丞丄丄丌:  true);
    }
    private void 东丆且世丑上丕丕丙()
    {
        this.丄丑七丘丁且丞丙专(万丘万丈与丆丗丂丄:  System.String.alignConst);
    }
    private void 丄丑七丘丁且丞丙专(string 万丘万丈与丆丗丂丄)
    {
        var val_5;
        var val_7;
        if(!=0)
        {
                val_5 = null;
            val_7 = mem[mem[137105408] + 200];
            val_7 = mem[137105408] + 200;
        }
        
        val_5 = null;
        val_7 = mem[mem[137105408] + 200];
        val_7 = mem[137105408] + 200;
        var val_2 = (((mem[137105408] + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_5) ? 137105408 : 0;
        if((System.String.op_Inequality(a:  万丘万丈与丆丗丂丄, b:  (mem[137105408] + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_5 ? 137105408 : 0 + 88.业丐丐三丕一丗丛丁())) != false)
        {
                return;
        }
        
        this.丄丑七丘丁且丞丙专(丝三丄专丗丞丄丄丌:  true);
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
    public RemoveClanMemberMenuItem()
    {
    
    }
    private void 丝东丄丐丙丘丕丒丟()
    {
        var val_8;
        var val_10;
        var val_11;
        if(X21 != 0)
        {
                val_8 = null;
            val_10 = mem[X21 + 200];
            val_10 = X21 + 200;
        }
        
        val_8 = null;
        val_10 = mem[X21 + 200];
        val_10 = X21 + 200;
        var val_4 = (((X21 + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_8) ? (X21) : 0;
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丗丕丐七丝丈丟丗丟().丌一与丏丛丆不丐丗(丄丒且丙三丆丟与丏:  (X21 + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_8 ? X21 : 0 + 88.业丐丐三丕一丗丛丁());
        Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().UpdateMembersScroll();
        if(this != null)
        {
                val_11 = null;
            val_11 = null;
            var val_7 = (((RemoveClanMemberMenuItem.__il2cppRuntimeField_typeHierarchy + (ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_11) ? (this) : 0;
        }
        
        0.UpdateRoleChangingItems();
    }
    private void 丗丏专丌丌丒丄与丌()
    {
        goto typeof(RemoveClanMemberMenuItem).__il2cppRuntimeField_198;
    }

}
