using UnityEngine;
public class ClanTankMaterialChangePoint : ClanTankPlaceableItemPoint
{
    // Fields
    private readonly string 丏丐丘不丗丙丗与丂;
    public System.Collections.Generic.List<UnityEngine.Renderer> materialRessivers;
    
    // Methods
    public override bool Setup(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        System.Collections.Generic.List<System.String> val_12;
        System.Collections.Generic.List<UnityEngine.Renderer> val_13;
        UnityEngine.Object val_14;
        var val_15;
        val_13 = this;
        if(true == 业世丟丐丘丐专与不)
        {
            goto label_1;
        }
        
        mem[1152921536873751816] = 业世丟丐丘丐专与不;
        this.丞与一东三丞丕三上();
        if(业世丟丐丘丐专与不 == null)
        {
            goto label_24;
        }
        
        val_12 = 业世丟丐丘丐专与不.uploadItemNames;
        if(val_12.Count < 1)
        {
            goto label_24;
        }
        
        val_12 = 1152921504848912384;
        val_14 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  this.丏丐丘不丗丙丗与丂 + 业世丟丐丘丐专与不.uploadItemNames.Item[0]);
        if(val_14 == 0)
        {
                val_14 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  this.丏丐丘不丗丙丗与丂 + "unknown_item");
        }
        
        if(val_14 == 0)
        {
            goto label_24;
        }
        
        val_13 = this.materialRessivers;
        List.Enumerator<T> val_9 = val_13.GetEnumerator();
        label_18:
        if(((-2092845704) & 1) == 0)
        {
            goto label_13;
        }
        
        string val_10 = 0.丐丏七丌丕丗业且上();
        if(val_10 == 0)
        {
            goto label_18;
        }
        
        val_10.material = val_14;
        goto label_18;
        label_1:
        val_15 = 0;
        return (bool)val_15;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_24:
        val_15 = 1;
        return (bool)val_15;
    }
    public ClanTankMaterialChangePoint()
    {
        mem[1152921536873913184] = 1;
        mem[1152921536873913192] = 1051931443;
        this.丏丐丘不丗丙丗与丂 = "FortField\\TankItemsContent\\Materials\\";
        this = new PGBehaviour();
    }

}
