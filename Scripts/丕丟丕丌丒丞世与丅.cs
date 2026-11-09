using UnityEngine;
private class BattlePassMainUI.丕丟丕丌丒丞世与丅
{
    // Fields
    public PGCompany.BattlePass.BPReward 且业丞七丂世丑丞丒;
    public int 丛下一丝丛丗与丄万;
    public bool 万下且丄丙丅世丒丒;
    public int 丙丘丒一下丝丞七世;
    public PGCompany.BattlePass.BPReward 丒上丄万世且丙且上;
    
    // Properties
    internal bool 丄丐丈东丝丒上丈专 { get; }
    internal bool 丘丂丛丐丏丞一东丕 { get; }
    internal bool 上丐世与丂丌丄万丈 { get; }
    
    // Methods
    internal bool 七丗上丁丕丟丅丄丘()
    {
        if(this.丌丌丌上丁丁丒专丟() == false)
        {
                return false;
        }
        
        return this.业丗丐丗丕专丟丝丘();
    }
    internal bool 丌丌丌上丁丁丒专丟()
    {
        if(this.丒上丄万世且丙且上 == null)
        {
                return false;
        }
        
        if(this.丒上丄万世且丙且上.Item == null)
        {
                return false;
        }
        
        Rilisoft.OfferItem val_2 = this.丒上丄万世且丙且上.Item;
        if(val_2 != null)
        {
                return val_2.IsKnownItem;
        }
        
        return val_2.IsKnownItem;
    }
    internal bool 业丗丐丗丕专丟丝丘()
    {
        if(this.且业丞七丂世丑丞丒 == null)
        {
                return false;
        }
        
        if(this.且业丞七丂世丑丞丒.Item == null)
        {
                return false;
        }
        
        Rilisoft.OfferItem val_2 = this.且业丞七丂世丑丞丒.Item;
        if(val_2 != null)
        {
                return val_2.IsKnownItem;
        }
        
        return val_2.IsKnownItem;
    }
    public BattlePassMainUI.丕丟丕丌丒丞世与丅()
    {
    
    }

}
