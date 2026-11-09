using UnityEngine;
internal sealed class PlaneIsInside : BaseIsInside
{
    // Fields
    private UnityEngine.BoxCollider _boxCollider;
    private System.Collections.Generic.List<UnityEngine.BoxCollider> _listCollider;
    
    // Methods
    private void Awake()
    {
        System.Collections.Generic.List<UnityEngine.BoxCollider> val_4;
        if(this._boxCollider != 0)
        {
                this._boxCollider.enabled = false;
        }
        
        val_4 = this._listCollider;
        List.Enumerator<T> val_2 = val_4.GetEnumerator();
        label_8:
        if((1217618392 & 1) == 0)
        {
            goto label_6;
        }
        
        0.丐丏七丌丕丗业且上().enabled = false;
        goto label_8;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public override bool IsInside(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        var val_6;
        List.Enumerator<T> val_1 = this._listCollider.GetEnumerator();
        label_3:
        if((1217763144 & 1) == 0)
        {
            goto label_2;
        }
        
        if((this.IsInsideBox(且丙与丏下丅丐世丑:  0.丐丏七丌丕丗业且上(), 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y, z = 丅专与丒丈丗丒丘丌.z})) == false)
        {
            goto label_3;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_6 = 1;
        goto label_12;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this._boxCollider != 0)
        {
                val_6 = this;
            bool val_5 = this.IsInsideBox(且丙与丏下丅丐世丑:  this._boxCollider, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y, z = 丅专与丒丈丗丒丘丌.z});
        }
        else
        {
                val_6 = 0;
        }
        
        label_12:
        val_6 = val_6 & 1;
        return (bool)val_6;
    }
    public bool IsInsideBox(UnityEngine.BoxCollider 且丙与丏下丅丐世丑, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_24;
        var val_25;
        float val_26;
        UnityEngine.Vector3 val_1 = 且丙与丏下丅丐世丑.center;
        val_24 = val_1.x;
        val_25 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_3 = val_25.position;
        UnityEngine.Vector3 val_4 = 且丙与丏下丅丐世丑.size;
        val_26 = val_4.x;
        val_4.x = val_26 * 0.5f;
        float val_24 = System.Math.Abs(val_4.x);
        val_24 = (val_24 + val_3.x) - val_24;
        if(val_24 > 丅专与丒丈丗丒丘丌.x)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_6 = 且丙与丏下丅丐世丑.center;
        val_24 = val_6.x;
        val_25 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_8 = val_25.position;
        UnityEngine.Vector3 val_9 = 且丙与丏下丅丐世丑.size;
        val_26 = val_9.x;
        val_9.x = val_26 * 0.5f;
        float val_25 = System.Math.Abs(val_9.x);
        val_25 = (val_24 + val_8.x) + val_25;
        if(丅专与丒丈丗丒丘丌.x > val_25)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_11 = 且丙与丏下丅丐世丑.center;
        val_25 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_13 = val_25.position;
        val_24 = val_13.z;
        UnityEngine.Vector3 val_14 = 且丙与丏下丅丐世丑.size;
        float val_26 = System.Math.Abs(val_14.z * 0.5f);
        val_26 = (val_11.z + val_24) - val_26;
        if(val_26 > 丅专与丒丈丗丒丘丌.z)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_17 = 且丙与丏下丅丐世丑.center;
        UnityEngine.Vector3 val_19 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_20 = 且丙与丏下丅丐世丑.size;
        float val_27 = System.Math.Abs(val_20.z * 0.5f);
        val_27 = (val_17.z + val_19.z) + val_27;
        var val_23 = (丅专与丒丈丗丒丘丌.z <= val_27) ? 1 : 0;
        return false;
    }
    public PlaneIsInside()
    {
    
    }

}
