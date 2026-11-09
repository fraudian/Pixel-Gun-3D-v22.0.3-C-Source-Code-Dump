using UnityEngine;
private sealed class RespawnWindow.丄七东丂三丂世丁东
{
    // Fields
    public PGCompany.丟丝东丈丐丙三下丛 丌丝下丄业一丄不三;
    public 丕丑丙丑丙东丌丘丕 丈三丘丌丈且万东丗;
    public RespawnWindow.丘丒丘世万丁且下丈 东丟且丗且三专丙丁;
    
    // Methods
    public RespawnWindow.丄七东丂三丂世丁东()
    {
    
    }
    internal void 丄丌万且且一丈不丘()
    {
        丕丑丙丑丙东丌丘丕 val_11;
        RespawnWindow.丘丒丘世万丁且下丈 val_12;
        float val_13;
        var val_14;
        专丟丗丛上丕丐丒丏 val_15;
        if(this.丌丝下丄业一丄不三 != null)
        {
                val_11 = this.丌丝下丄业一丄不三.丐上下三丑丈丑丄丟().七丑丌专丒上丒丙七();
            if(val_11 == null)
        {
                丕丑丙丑丙东丌丘丕 val_5 = null;
            val_11 = val_5;
            val_5 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  this.丌丝下丄业一丄不三.丐上下三丑丈丑丄丟().七丙丛与万且专三三(), 丏丆丐丑专与丄丘丞:  this.丌丝下丄业一丄不三);
        }
        
            val_12 = this;
            mem[1152921540261443016] = val_11;
            val_13 = BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  val_5, 专东丑丑丁丞丛三丗:  false);
            this.东丟且丗且三专丙丁.丝七丆且丝丐七一丆 = val_13;
            if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                三一业三世丛业三东(七丆丒与丗丌丄且丂:  this.丌丝下丄业一丄不三 + 1, 丒丏丗三三万丝丛丕:  true);
        }
        
            this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.yourWeapon.promoUpgrade.不丞三丁丘丐一丘丆(丑丒业丘丑东丕世丅:  true);
        }
        else
        {
                val_12 = this.东丟且丗且三专丙丁;
        }
        
        mem2[0] = mem[this.东丟且丗且三专丙丁] + 24 + 552.业上丙丞丐丄丆丅七();
        if(GameConnect.东丒七专丂世丝丏丗() != false)
        {
                if((mem[this.东丟且丗且三专丙丁] + 40 + 17) != 0)
        {
            goto label_29;
        }
        
        }
        
        val_14 = mem[this.东丟且丗且三专丙丁];
        if(val_14 == 0)
        {
            goto label_32;
        }
        
        val_15 = mem[mem[this.东丟且丗且三专丙丁] + 40];
        val_15 = mem[this.东丟且丗且三专丙丁] + 40;
        goto label_33;
        label_32:
        val_15 = mem[mem[this.东丟且丗且三专丙丁] + 40];
        val_15 = mem[this.东丟且丗且三专丙丁] + 40;
        if(mem[this.东丟且丗且三专丙丁] == 0)
        {
            goto label_34;
        }
        
        val_14 = mem[this.东丟且丗且三专丙丁];
        label_33:
        val_13 = mem[mem[this.东丟且丗且三专丙丁] + 48];
        val_13 = mem[this.东丟且丗且三专丙丁] + 48;
        label_44:
        label_45:
        mem[this.东丟且丗且三专丙丁] + 24 + 328.丁业丑丂丘不丏世丑(丝丞丛七且一丅丐丄:  val_15, 专丘专丟丏丏丁丝丁:  val_13, 且东业丆丁业万七与:  mem[this.东丟且丗且三专丙丁] + 16, 丕丗丆丒丄丂丁丈丞:  mem[this.东丟且丗且三专丙丁] + 52);
        label_29:
        if((mem[this.东丟且丗且三专丙丁] + 56) == 0)
        {
                return;
        }
        
        mem[this.东丟且丗且三专丙丁] + 24 + 336.丕东丑丞与丆上与丈(下丅丙一丂丗丅丝七:  mem[this.东丟且丗且三专丙丁] + 24 + 552, 且东业丆丁业万七与:  mem[this.东丟且丗且三专丙丁] + 48, 上一丁丑上丈丕丏丑:  false, 丟丕丙丙丕丄下丄丐:  false, 万丒丐丛丝丐丞丄丐:  false);
        return;
        label_34:
        if(mem[this.东丟且丗且三专丙丁] != 0)
        {
            goto label_44;
        }
        
        if(mem[this.东丟且丗且三专丙丁] != 0)
        {
            goto label_45;
        }
    
    }

}
