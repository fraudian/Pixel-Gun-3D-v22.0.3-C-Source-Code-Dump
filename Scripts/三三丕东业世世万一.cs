using UnityEngine;
private sealed class 上丕丁专三丗丝万丆.三三丕东业世世万一
{
    // Fields
    public PGCompany.BattlePass.三专下业丒七丑丒丅 不一丛丝与丈七丒丟;
    public PGCompany.BattlePass.上丕丁专三丗丝万丆.万业丙下丈一丛丈丄 东丟且丗且三专丙丁;
    
    // Methods
    public 上丕丁专三丗丝万丆.三三丕东业世世万一()
    {
    
    }
    internal bool 下丄世下丐七丌丘专(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛)
    {
        PGCompany.BattlePass.BPReward val_7;
        var val_8;
        val_7 = 东七上世万下丗丄丛;
        if((val_7.ForLevel <= this.东丟且丗且三专丙丁.丈丘丝一丗下丈丐不) && ((this.不一丛丝与丈七丒丟.丙下万丝丁丅不且丂(丗七丟丈三不丕一三:  val_7)) != true))
        {
                if(val_7.Item != null)
        {
                val_7 = val_7.Item;
            val_8 = val_7.IsUniqueTypeItem ^ 1;
            return (bool)val_8 & 1;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8 & 1;
    }

}
