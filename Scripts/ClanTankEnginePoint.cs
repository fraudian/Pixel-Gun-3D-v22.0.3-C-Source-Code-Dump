using UnityEngine;
public class ClanTankEnginePoint : ClanTankPlaceableItemPoint
{
    // Methods
    public override void Init(ClanTankBuildBase 丏丄万丆丞丂丙丑丙, int 世丟丄丅丛世丝丑丕)
    {
        mem[1152921536871152328] = 丏丄万丆丞丂丙丑丙;
        mem[1152921536871152368] = 世丟丄丅丛世丝丑丕;
        mem[1152921536871152336] = 4;
        mem[1152921536871152352] = "TankParts";
        mem[1152921536871152360] = "TankEngine";
    }
    public override bool Setup(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        if(X8 == 业世丟丐丘丐专与不)
        {
                return false;
        }
        
        mem[1152921536871272536] = 业世丟丐丘丐专与不;
        this.丞与一东三丞丕三上();
        return true;
    }
    public ClanTankEnginePoint()
    {
        mem[1152921536871388688] = 1;
        mem[1152921536871388696] = 1051931443;
        val_1 = new PGBehaviour();
    }

}
