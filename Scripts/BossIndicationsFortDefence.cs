using UnityEngine;
internal sealed class BossIndicationsFortDefence : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Transform> 上丏丂丆丙丙丅不与;
    private System.Collections.Generic.List<float> 下丟丙一下丟丏上上;
    private int 万丆专下一丟不世与;
    private float 万丆丛丝丑世三丕一;
    private float 丐丏一下丘下丅丛万;
    
    // Properties
    public float 世丆东丝丒丒丘丗丐 { get; }
    
    // Methods
    internal void 丑丙丄丄丁丟三丙丝(System.Collections.Generic.List<UnityEngine.Transform> 丌丆一七丈丈丄下下)
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_9;
        var val_10;
        val_9 = 丌丆一七丈丈丄下下;
        this.上丏丂丆丙丙丅不与 = val_9;
        val_10 = 1;
        goto label_1;
        label_12:
        if(val_10 < this.上丏丂丆丙丙丅不与.Count)
        {
                UnityEngine.Vector3 val_3 = this.上丏丂丆丙丙丅不与.Item[W22].position;
            UnityEngine.Vector3 val_5 = this.上丏丂丆丙丙丅不与.Item[1].position;
            this.下丟丙一下丟丏上上.Add(item:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}));
        }
        
        val_9 = this.上丏丂丆丙丙丅不与;
        val_10 = 2;
        label_1:
        if(1 < val_9.Count)
        {
            goto label_12;
        }
        
        float val_9 = (float)this.下丟丙一下丟丏上上.Count;
        val_9 = 1f / val_9;
        this.丐丏一下丘下丅丛万 = val_9;
    }
    public float get_Percent()
    {
        return (float)this.万丆丛丝丑世三丕一;
    }
    private void Update()
    {
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        int val_20;
        float val_21;
        UnityEngine.Vector3 val_2 = this.上丏丂丆丙丙丅不与.Item[this.万丆专下一丟不世与].position;
        val_16 = val_2.z;
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().position;
        val_17 = val_4.y;
        val_18 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_16}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_17, z = val_4.z});
        val_19 = 15f;
        if(val_18 < 0)
        {
                if(this.万丆专下一丟不世与 < (this.上丏丂丆丙丙丅不与.Count - 1))
        {
                int val_8 = this.万丆专下一丟不世与 + 1;
            this.万丆专下一丟不世与 = val_8;
            UnityEngine.Vector3 val_10 = this.上丏丂丆丙丙丅不与.Item[val_8].position;
            val_16 = val_10.z;
            UnityEngine.Vector3 val_12 = this.丌丟丄业且三丛丕丄().position;
            val_17 = val_12.y;
            val_19 = val_10.x;
            val_18 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_19, y = val_10.y, z = val_16}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_17, z = val_12.z});
        }
        
        }
        
        val_20 = this.万丆专下一丟不世与;
        if((val_20 & 2147483648) != 0)
        {
            goto label_14;
        }
        
        if(val_20 >= this.下丟丙一下丟丏上上.Count)
        {
            goto label_16;
        }
        
        val_20 = this.万丆专下一丟不世与 - 1;
        float val_15 = this.下丟丙一下丟丏上上.Item[val_20];
        val_15 = val_18 / val_15;
        val_15 = 1f - val_15;
        val_15 = val_15 + (float)val_20;
        val_21 = this.丐丏一下丘下丅丛万 * val_15;
        goto label_19;
        label_14:
        val_21 = 0f;
        goto label_19;
        label_16:
        val_21 = 1f;
        label_19:
        this.万丆丛丝丑世三丕一 = val_21;
    }
    public BossIndicationsFortDefence()
    {
        this.上丏丂丆丙丙丅不与 = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.下丟丙一下丟丏上上 = new System.Collections.Generic.List<System.Single>();
    }

}
