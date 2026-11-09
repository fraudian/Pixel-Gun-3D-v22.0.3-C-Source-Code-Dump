using UnityEngine;
public class TeamDuelEmojiController : EmojiController
{
    // Fields
    public TeamDuelUI teamDuelUI;
    
    // Methods
    internal override bool 丟东丗丂东专丅丑丑(NetworkStartTable 不且上一上丐三万丛)
    {
        if(this.teamDuelUI.stickersInterface.activeInHierarchy == false)
        {
                return false;
        }
        
        return this.丁丅丒丛丌丙丕与丘(不且上一上丐三万丛:  不且上一上丐三万丛);
    }
    protected override void Update()
    {
        var val_3;
        this.Update();
        val_3 = 0;
        goto label_1;
        label_4:
        EmojiChat val_1 = X21.Item[0];
        val_3 = 1;
        label_1:
        if(val_3 < X21.Count)
        {
            goto label_4;
        }
    
    }
    private bool 丁丅丒丛丌丙丕与丘(NetworkStartTable 不且上一上丐三万丛)
    {
        var val_9;
        RanksTable val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_9 = 1152921504848912384;
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_10 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 88];
            val_10 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ranksTable;
        }
        else
        {
                val_10 = 0;
        }
        
        if((val_10 == 0) || (this.teamDuelUI.endInterface.activeInHierarchy == false))
        {
            goto label_11;
        }
        
        val_9 = 0;
        label_20:
        if(val_9 >= mem[25769803802])
        {
            goto label_14;
        }
        
        var val_4 = 2 + 0;
        val_9 = val_9 + 1;
        if(((2 + 0) + 32 + 184.Equals(value:  不且上一上丐三万丛.丈三世丞丕万丄七丂)) == false)
        {
            goto label_20;
        }
        
        goto label_52;
        label_11:
        val_11 = 0;
        goto label_22;
        label_38:
        TeamDuelPlayerInfo val_10 = this.teamDuelUI.blueTeamInfo[0];
        val_12 = 0;
        if(this.teamDuelUI.blueTeamInfo[0x0][0].owner == 0)
        {
            goto label_29;
        }
        
        if(val_11 >= this.teamDuelUI.blueTeamInfo.Length)
        {
                val_12 = 0;
        }
        
        TeamDuelPlayerInfo val_11 = this.teamDuelUI.blueTeamInfo[0];
        val_10 = this.teamDuelUI.blueTeamInfo[0x0][0].owner;
        if((val_10.Equals(other:  不且上一上丐三万丛)) == true)
        {
            goto label_52;
        }
        
        label_29:
        val_11 = 1;
        label_22:
        if(val_11 < this.teamDuelUI.blueTeamInfo.Length)
        {
            goto label_38;
        }
        
        val_13 = 0;
        goto label_39;
        label_55:
        TeamDuelPlayerInfo val_12 = this.teamDuelUI.redTeamInfo[0];
        val_14 = 0;
        if(this.teamDuelUI.redTeamInfo[0x0][0].owner == 0)
        {
            goto label_46;
        }
        
        if(val_13 >= this.teamDuelUI.redTeamInfo.Length)
        {
                val_14 = 0;
        }
        
        TeamDuelPlayerInfo val_13 = this.teamDuelUI.redTeamInfo[0];
        val_10 = this.teamDuelUI.redTeamInfo[0x0][0].owner;
        if((val_10.Equals(other:  不且上一上丐三万丛)) == true)
        {
            goto label_52;
        }
        
        label_46:
        val_13 = 1;
        label_39:
        val_10 = this.teamDuelUI.redTeamInfo;
        if(val_13 < this.teamDuelUI.redTeamInfo.Length)
        {
            goto label_55;
        }
        
        label_14:
        val_15 = 0;
        return (bool)val_15;
        label_52:
        val_15 = 1;
        return (bool)val_15;
    }
    protected override void 丘丌丘一不丛东丝丒(EmojiChat 丟丗丙万丙且丐丏丗)
    {
        var val_23;
        RanksTable val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        UnityEngine.Transform val_29;
        float val_30;
        float val_31;
        bool val_32;
        val_23 = 1152921504848912384;
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_24 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 88];
            val_24 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ranksTable;
        }
        else
        {
                val_24 = 0;
        }
        
        if((val_24 == 0) || (this.teamDuelUI.endInterface.activeInHierarchy == false))
        {
            goto label_11;
        }
        
        val_23 = 0;
        goto label_12;
        label_22:
        var val_4 = 2 + 0;
        if(((2 + 0) + 32 + 184.Equals(value:  丟丗丙万丙且丐丏丗.owner.丈三世丞丕万丄七丂)) == true)
        {
            goto label_19;
        }
        
        val_23 = 1;
        label_12:
        if(val_23 < mem[25769803802])
        {
            goto label_22;
        }
        
        return;
        label_11:
        val_25 = 0;
        goto label_24;
        label_41:
        TeamDuelPlayerInfo val_25 = this.teamDuelUI.blueTeamInfo[0];
        val_26 = 0;
        if(this.teamDuelUI.blueTeamInfo[0x0][0].owner == 0)
        {
            goto label_31;
        }
        
        if(val_25 >= this.teamDuelUI.blueTeamInfo.Length)
        {
                val_26 = 0;
        }
        
        TeamDuelPlayerInfo val_26 = this.teamDuelUI.blueTeamInfo[0];
        if((this.teamDuelUI.blueTeamInfo[0x0][0].owner.Equals(other:  丟丗丙万丙且丐丏丗.owner)) == true)
        {
            goto label_38;
        }
        
        label_31:
        val_25 = 1;
        label_24:
        if(val_25 < this.teamDuelUI.blueTeamInfo.Length)
        {
            goto label_41;
        }
        
        val_27 = 0;
        goto label_42;
        label_59:
        TeamDuelPlayerInfo val_27 = this.teamDuelUI.redTeamInfo[0];
        val_28 = 0;
        if(this.teamDuelUI.redTeamInfo[0x0][0].owner == 0)
        {
            goto label_49;
        }
        
        if(val_27 >= this.teamDuelUI.redTeamInfo.Length)
        {
                val_28 = 0;
        }
        
        TeamDuelPlayerInfo val_28 = this.teamDuelUI.redTeamInfo[0];
        if((this.teamDuelUI.redTeamInfo[0x0][0].owner.Equals(other:  丟丗丙万丙且丐丏丗.owner)) == true)
        {
            goto label_56;
        }
        
        label_49:
        val_27 = 1;
        label_42:
        val_24 = this.teamDuelUI.redTeamInfo;
        if(val_27 < this.teamDuelUI.redTeamInfo.Length)
        {
            goto label_59;
        }
        
        return;
        label_38:
        TeamDuelPlayerInfo val_29 = this.teamDuelUI.blueTeamInfo[0];
        val_29 = this.teamDuelUI.blueTeamInfo[0x0][0].emojiPoint;
        UnityEngine.Vector3 val_11 = val_29.position;
        val_30 = val_11.x;
        val_31 = val_11.z;
        丟丗丙万丙且丐丏丗.transform.position = new UnityEngine.Vector3() {x = val_30, y = val_11.y, z = val_31};
        val_32 = 1;
        goto label_73;
        label_56:
        TeamDuelPlayerInfo val_30 = this.teamDuelUI.redTeamInfo[0];
        val_29 = this.teamDuelUI.redTeamInfo[0x0][0].emojiPoint;
        UnityEngine.Vector3 val_13 = val_29.position;
        val_30 = val_13.x;
        val_31 = val_13.z;
        丟丗丙万丙且丐丏丗.transform.position = new UnityEngine.Vector3() {x = val_30, y = val_13.y, z = val_31};
        val_32 = 0;
        goto label_73;
        label_19:
        var val_15 = 2 + 0;
        UnityEngine.Vector3 val_17 = (2 + 0) + 32.transform.position;
        丟丗丙万丙且丐丏丗.transform.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Transform val_18 = 丟丗丙万丙且丐丏丗.transform;
        UnityEngine.Vector3 val_19 = val_18.localPosition;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.right;
        var val_21 = (val_23 < 3) ? 1 : 0;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  106023032 + val_23 < 0x3 ? 1 : 0);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        val_30 = val_23.x;
        val_31 = val_23.z;
        val_18.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_23.y, z = val_31};
        val_32 = (val_23 < 3) ? 1 : 0;
        label_73:
        丟丗丙万丙且丐丏丗.SetEmojiAlign(专世丌丆丝丈丟丛丁:  val_32);
    }
    public TeamDuelEmojiController()
    {
    
    }

}
