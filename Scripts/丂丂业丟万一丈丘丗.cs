using UnityEngine;
private sealed class Player_move_c.丂丂业丟万一丈丘丗
{
    // Fields
    public bool 丅丄与世丗不专丛一;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Methods
    public Player_move_c.丂丂业丟万一丈丘丗()
    {
    
    }
    internal void 丌丒丅下三一七不丄()
    {
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专.mySkinName.transform.position;
        UnityEngine.Vector3 val_5 = this.丝且与丝丒丟万丁专.mySkinName.transform.position;
        this.丝且与丝丒丟万丁专.mySkinName.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(this.丝且与丝丒丟万丁专.丛丛丕丌一丗专丏上 == false)
        {
            goto label_11;
        }
        
        this.丝且与丝丒丟万丁专.丙丒不与丏丙下丕东();
        label_42:
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.fadingPanel.SetFadeKill(与七业万丌三丟不一:  false);
        label_25:
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.blockedCollider.SetActive(value:  false);
        return;
        label_11:
        val_14 = null;
        val_14 = null;
        与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 = false;
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_23;
        }
        
        this.丝且与丝丒丟万丁专.上东七丆不丏丐业下();
        goto label_25;
        label_23:
        val_15 = 0;
        if((GameConnect.丄丏丒丏上东业丒一() != false) && (this.丅丄与世丗不专丛一 != false))
        {
                val_16 = null;
            val_16 = null;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(((((MutationController.丆丕丝丒不丙且丐丗.世业丗丄丁丝丒一丁() & 255) != 3) ? 1 : 0) | GameConnect.与不丗丏万丙丞丌丑()) == false)
        {
            goto label_38;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.业丄东丞万下丙丆且 = true;
        goto label_42;
        label_38:
        this.丝且与丝丒丟万丁专.丝丟丑丐专丁丁七丑();
        goto label_42;
    }

}
