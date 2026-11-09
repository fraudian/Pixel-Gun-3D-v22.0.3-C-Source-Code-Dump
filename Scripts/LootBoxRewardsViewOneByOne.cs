using UnityEngine;
internal sealed class LootBoxRewardsViewOneByOne : LootBoxRewardsView
{
    // Fields
    private WidgetLayout rewardsLayout;
    public float startDelay;
    public float timeStep;
    public float finishDelay;
    
    // Methods
    internal override void 世业丒万丘丆专丘丐()
    {
        this.rewardsLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.世业丒万丘丆专丘丐();
    }
    protected override System.Collections.IEnumerator 下丗不丞丄业与世下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LootBoxRewardsViewOneByOne.专与丄丒世丝丙丟丂();
    }
    public LootBoxRewardsViewOneByOne()
    {
        this.timeStep = 1.5f;
    }

}
