using UnityEngine;
internal sealed class BoxIsInside : BaseIsInside
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
        if((1216902744 & 1) == 0)
        {
            goto label_6;
        }
        
        0.丐丏七丌丕丗业且上().enabled = false;
        goto label_8;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void SetRadius(float 且丛上丕业丂丒与一)
    {
        System.Collections.Generic.List<UnityEngine.BoxCollider> val_5;
        UnityEngine.Vector3 val_1 = this._boxCollider.size;
        this._boxCollider.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_5 = this._listCollider;
        List.Enumerator<T> val_2 = val_5.GetEnumerator();
        label_7:
        if((1217043416 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_4 = val_3.size;
        val_3.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_7;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public override bool IsInside(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        var val_6;
        List.Enumerator<T> val_1 = this._listCollider.GetEnumerator();
        label_3:
        if((1217184072 & 1) == 0)
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
        float val_36;
        var val_37;
        float val_38;
        val_36 = 丅专与丒丈丗丒丘丌.x;
        UnityEngine.Vector3 val_1 = 且丙与丏下丅丐世丑.center;
        val_37 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_3 = val_37.position;
        val_38 = val_3.x;
        UnityEngine.Vector3 val_4 = 且丙与丏下丅丐世丑.size;
        val_4.x = val_4.x * 0.5f;
        float val_36 = System.Math.Abs(val_4.x);
        val_36 = (val_1.x + val_38) - val_36;
        if(val_36 > val_36)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_6 = 且丙与丏下丅丐世丑.center;
        val_37 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_8 = val_37.position;
        val_38 = val_8.x;
        UnityEngine.Vector3 val_9 = 且丙与丏下丅丐世丑.size;
        val_9.x = val_9.x * 0.5f;
        float val_37 = System.Math.Abs(val_9.x);
        val_37 = (val_6.x + val_38) + val_37;
        if(val_36 > val_37)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_11 = 且丙与丏下丅丐世丑.center;
        val_36 = val_11.y;
        val_37 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_13 = val_37.position;
        UnityEngine.Vector3 val_14 = 且丙与丏下丅丐世丑.size;
        val_38 = val_14.y;
        float val_38 = System.Math.Abs(val_38 * 0.5f);
        val_38 = (val_36 + val_13.y) - val_38;
        if(val_38 > 丅专与丒丈丗丒丘丌.y)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_17 = 且丙与丏下丅丐世丑.center;
        val_36 = val_17.y;
        val_37 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_19 = val_37.position;
        UnityEngine.Vector3 val_20 = 且丙与丏下丅丐世丑.size;
        val_38 = val_20.y;
        float val_39 = System.Math.Abs(val_38 * 0.5f);
        val_39 = (val_36 + val_19.y) + val_39;
        if(丅专与丒丈丗丒丘丌.y > val_39)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_23 = 且丙与丏下丅丐世丑.center;
        val_37 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_25 = val_37.position;
        val_36 = val_25.z;
        UnityEngine.Vector3 val_26 = 且丙与丏下丅丐世丑.size;
        float val_40 = System.Math.Abs(val_26.z * 0.5f);
        val_40 = (val_23.z + val_36) - val_40;
        if(val_40 > 丅专与丒丈丗丒丘丌.z)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_29 = 且丙与丏下丅丐世丑.center;
        UnityEngine.Vector3 val_31 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_32 = 且丙与丏下丅丐世丑.size;
        float val_41 = System.Math.Abs(val_32.z * 0.5f);
        val_41 = (val_29.z + val_31.z) + val_41;
        var val_35 = (丅专与丒丈丗丒丘丌.z <= val_41) ? 1 : 0;
        return false;
    }
    public BoxIsInside()
    {
        this._listCollider = new System.Collections.Generic.List<UnityEngine.BoxCollider>();
    }

}
