using UnityEngine;
internal sealed class ClanWarCellFlag : PGBehaviour
{
    // Fields
    private 不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘;
    private System.Collections.Generic.List<UnityEngine.Renderer> renderers;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        var val_15;
        System.Collections.Generic.List<UnityEngine.Renderer> val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        val_16 = this;
        this.丌丝万上丅丒一丈丘 = 丌丝万上丅丒一丈丘;
        if(丌丝万上丅丒一丈丘 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = 丌丝万上丅丒一丈丘.丄丒丕万七丂万世一();
        val_17 = val_1.x;
        val_18 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_19 = val_2.x;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_17, y = val_1.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = val_19, y = val_2.y, z = val_2.z})) == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = 丌丝万上丅丒一丈丘.丄丒丕万七丂万世一();
        val_17 = val_5.x;
        val_18 = val_5.z;
        val_20 = val_17;
        val_21 = val_5.y;
        val_22 = val_18;
        this.transform.position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        if((ClanWarUI.丑七不且上丗丁一世().GetCameraSettings(丄丝丏上丄丛丘丟丆:  PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂())) != null)
        {
                UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_17, z:  0f);
            val_17 = val_10.x;
            val_18 = val_10.z;
            val_20 = val_17;
            val_21 = val_10.y;
            val_22 = val_18;
            val_19 = val_10.w;
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_20, y = val_21, z = val_22, w = val_19};
        }
        
        val_16 = this.renderers;
        List.Enumerator<T> val_11 = val_16.GetEnumerator();
        val_15 = 1152921525724388416;
        label_21:
        if((2134113320 & 1) == 0)
        {
            goto label_16;
        }
        
        UnityEngine.Color val_14 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
        0.丐丏七丌丕丗业且上().material.color = new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a};
        goto label_21;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ClanWarCellFlag()
    {
    
    }

}
