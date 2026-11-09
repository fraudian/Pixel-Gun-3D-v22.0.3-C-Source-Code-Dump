using UnityEngine;
public class ClanTankMainGunPoint : ClanTankGameObjectPoint
{
    // Fields
    private UnityEngine.Transform lobbyInstantiateParent;
    
    // Properties
    protected override string 世一三世丏丝丁丆丞 { get; }
    
    // Methods
    protected override string 丆丒丗丏东丏丒上丈()
    {
        return "unknown_item_maingun";
    }
    public override void Init(ClanTankBuildBase 丏丄万丆丞丂丙丑丙, int 世丟丄丅丛世丝丑丕)
    {
        mem[1152921536873329784] = 丏丄万丆丞丂丙丑丙;
        mem[1152921536873329824] = 世丟丄丅丛世丝丑丕;
        mem[1152921536873329792] = 5;
        mem[1152921536873329808] = "TankWeapons";
        mem[1152921536873329816] = "TankMainGun";
    }
    public override bool Setup(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        UnityEngine.Transform val_5;
        var val_6;
        val_5 = this;
        if((this.Setup(业世丟丐丘丐专与不:  业世丟丐丘丐专与不)) == false)
        {
            goto label_1;
        }
        
        if((业世丟丐丘丐专与不 == 0) || (this.lobbyInstantiateParent == 0))
        {
            goto label_7;
        }
        
        val_5 = this.lobbyInstantiateParent;
        val_6 = 1;
        this.lobbyInstantiateParent.transform.SetParent(parent:  val_5, worldPositionStays:  true);
        return (bool)val_6;
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        val_6 = 1;
        return (bool)val_6;
    }
    public ClanTankMainGunPoint()
    {
    
    }

}
