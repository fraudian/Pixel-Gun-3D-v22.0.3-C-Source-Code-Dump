using UnityEngine;
internal sealed class LootBoxRewardsViewOneByOneSingle : LootBoxRewardsView
{
    // Fields
    private System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 三业不不丘丐业丝下;
    public float startDelay;
    public float timeStep;
    public float finishDelay;
    private LootBoxRewardView droppedRewardView;
    private float 丅丆丁丅丈不与丒丕;
    
    // Methods
    internal void 丁丒丏专且丌三丞丗(System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三业不不丘丐业丝下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三业不不丘丐业丝下 != this.三业不不丘丐业丝下);
    
    }
    internal void 丒丆丐丝丝丝专七丈(System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三业不不丘丐业丝下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三业不不丘丐业丝下 != this.三业不不丘丐业丝下);
    
    }
    internal override void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.droppedRewardView, 丏业丟一东丂东丘丛:  false);
        this.世业丒万丘丆专丘丐();
    }
    protected override System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LootBoxRewardsViewOneByOneSingle.丝世丏丑上丌丒与专();
    }
    public void U_ShowNext()
    {
        this.丅丆丁丅丈不与丒丕 = 0f;
    }
    public LootBoxRewardsViewOneByOneSingle()
    {
        this.timeStep = 1.5f;
    }

}
