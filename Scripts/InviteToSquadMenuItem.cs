using UnityEngine;
public class InviteToSquadMenuItem : ContextMenuItemBase
{
    // Fields
    private UIButton 下丒丘丅丌丏丛丗丆;
    private UILabel[] text;
    
    // Methods
    private void Awake()
    {
        this.下丒丘丅丌丏丛丗丆 = this.GetComponent<UIButton>();
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
        var val_16;
        var val_17;
        var val_18;
        var val_20;
        string val_21;
        if(!=0)
        {
                val_16 = null;
        }
        
        val_16 = null;
        var val_1 = (((mem[137146368] + 200 + (ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_16) ? 137146368 : 0;
        if((System.String.op_Equality(a:  (mem[137146368] + 200 + (ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_16 ? 137146368 : 0 + 88.业丐丐三丕一丗丛丁(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                this.gameObject.SetActive(value:  false);
            return;
        }
        
        val_17 = null;
        val_17 = null;
        if(X22 != 0)
        {
                val_18 = null;
            val_20 = mem[X22 + 200];
            val_20 = X22 + 200;
        }
        
        val_18 = null;
        val_20 = mem[X22 + 200];
        val_20 = X22 + 200;
        var val_7 = (((X22 + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_18) ? (X22) : 0;
        bool val_13 = FriendInviteInfoContainer.一且丕丙丆丟丙七丒.Contains(item:  (X22 + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_18 ? X22 : 0 + 88.业丐丐三丕一丗丛丁()((X22 + 200 + ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_18 ? X22 : 0 + 88.业丐丐三丕一丗丛丁()) + Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁()(Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁()));
        if(val_13 != false)
        {
                val_21 = "Key_3505";
        }
        else
        {
                val_21 = "Key_5814";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.text, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_21));
        this.丄丑七丘丁且丞丙专(丝三丄专丗丞丄丄丌:  (~val_13) & 1);
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
    public InviteToSquadMenuItem()
    {
    
    }

}
