using UnityEngine;
public class ClanTankGameObjectPoint : ClanTankPlaceableItemPoint
{
    // Fields
    private readonly string 丏丐丘不丗丙丗与丂;
    public UnityEngine.GameObject itemGameObject;
    private UnityEngine.Renderer rarityColor;
    
    // Properties
    protected virtual string 世一三世丏丝丁丆丞 { get; }
    
    // Methods
    protected virtual string 丆丒丗丏东丏丒上丈()
    {
        return "unknown_item";
    }
    public override void Init(ClanTankBuildBase 丏丄万丆丞丂丙丑丙, int 世丟丄丅丛世丝丑丕)
    {
        mem[1152921536872234248] = 丏丄万丆丞丂丙丑丙;
        mem[1152921536872234288] = 世丟丄丅丛世丝丑丕;
        mem[1152921536872234256] = 6;
        mem[1152921536872234272] = "TankWeapons";
        mem[1152921536872234280] = "TankTurrets";
    }
    public override bool Setup(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        UnityEngine.GameObject val_21;
        UnityEngine.Object val_22;
        var val_23;
        if(true != 业世丟丐丘丐专与不)
        {
                mem[1152921536872432280] = 业世丟丐丘丐专与不;
            this.丞与一东三丞丕三上();
            val_21 = this.itemGameObject;
            UnityEngine.Object.Destroy(obj:  val_21);
            if(业世丟丐丘丐专与不 != null)
        {
                val_21 = 业世丟丐丘丐专与不.uploadItemNames;
            if(val_21.Count >= 1)
        {
                val_21 = 1152921524279436720;
            val_22 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丏丐丘不丗丙丗与丂 + 业世丟丐丘丐专与不.uploadItemNames.Item[0]);
            if(val_22 == 0)
        {
                val_22 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丏丐丘不丗丙丗与丂 + this);
        }
        
            if(val_22 != 0)
        {
                UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_22, parent:  transform.parent);
            UnityEngine.Vector3 val_14 = this.丌丟丄业且三丛丕丄().position;
            val_11.transform.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            UnityEngine.Transform val_16 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Quaternion val_17 = val_16.rotation;
            val_11.transform.rotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
            val_21 = val_11.transform;
            UnityEngine.Vector3 val_20 = val_16.丌丟丄业且三丛丕丄().localScale;
            val_21.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            this.itemGameObject = val_11;
        }
        
        }
        
        }
        
            this.世丏上业丗且丅丐东();
            val_23 = 1;
            return (bool)val_23;
        }
        
        val_23 = 0;
        return (bool)val_23;
    }
    protected void 世丏上业丗且丅丐东()
    {
        if(this.rarityColor == 0)
        {
                return;
        }
        
        this.东与东丆丛东丂丁三();
    }
    private void 不丞丕业上且丏丆三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rarityColor.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 东与东丆丛东丂丁三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rarityColor.gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Color val_4 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  X21.ItemRarity);
        this.rarityColor.materials[0].color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
    }
    public ClanTankGameObjectPoint()
    {
        mem[1152921536873101648] = 1;
        mem[1152921536873101656] = 1051931443;
        this.丏丐丘不丗丙丗与丂 = "FortField\\TankItemsContent\\";
        this = new PGBehaviour();
    }

}
