using UnityEngine;
private sealed class UIScrollMover.业丈丄上东丙东丌丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.UIScrollMover 丝且与丝丒丟万丁专;
    public float 丛上丙丄丄七丈且丅;
    public float 东丗上东丘丄东丘世;
    public System.Action 丙丒丝丂丛丗东丄一;
    public bool 东丛丌丆丅世丐不丒;
    public bool 丏丈三丛业不专丑业;
    private UnityEngine.Transform 世丝丛一丅丆丝丗丝;
    private float 丑丘万万与丒一三东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIScrollMover.业丈丄上东丙东丌丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_42;
        float val_43;
        float val_44;
        UIScrollView val_45;
        float val_46;
        float val_47;
        float val_48;
        float val_49;
        float val_54;
        float val_55;
        var val_56;
        float val_57;
        float val_58;
        System.Action val_59;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_4;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.下丒且丐丈三丑丒丗 == true)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.下丒且丐丈三丑丒丗 = true;
        this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.enabled = false;
        this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.restrictWithinPanel = false;
        SpringPanel val_2 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.gameObject.GetComponent<SpringPanel>();
        if((val_2 == 0) || (val_2.enabled == false))
        {
            goto label_13;
        }
        
        if(val_2 == null)
        {
            goto label_14;
        }
        
        val_2.enabled = false;
        goto label_15;
        label_1:
        val_42 = this;
        val_43 = this.丑丘万万与丒一三东;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_43 > 0f)
        {
            goto label_17;
        }
        
        goto label_33;
        label_14:
        val_2.enabled = false;
        label_15:
        UnityEngine.Vector3 val_6 = val_2.transform.localPosition;
        val_44 = val_6.z;
        val_2.target = val_6;
        mem2[0] = val_6.y;
        mem2[0] = val_44;
        label_13:
        val_45 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel;
        this.世丝丛一丅丆丝丗丝 = val_45.cachedTransform;
        val_43 = this.丛上丙丄丄七丈且丅;
        float val_41 = System.Math.Abs(val_43);
        val_42 = this;
        this.丑丘万万与丒一三东 = val_41;
        if(val_41 <= 0f)
        {
            goto label_33;
        }
        
        label_17:
        val_43 = this.丛上丙丄丄七丈且丅;
        if(this.丝且与丝丒丟万丁专.InstantMoving != true)
        {
                float val_9 = UnityEngine.Time.unscaledDeltaTime;
            val_46 = 0.1f;
            val_47 = val_43 * this.东丗上东丘丄东丘世;
            val_9 = val_47 * val_9;
            val_43 = val_9 * val_46;
        }
        
        val_44 = this.丑丘万万与丒一三东;
        float val_42 = System.Math.Abs(val_43);
        val_48 = val_44 - val_42;
        if(val_48 < 0)
        {
                val_44 = this.丑丘万万与丒一三东;
            val_48 = val_44 - (val_43 * val_42);
            val_46 = -1f;
            val_47 = 1f;
            float val_11 = (val_48 > 0f) ? (val_47) : (val_46);
            this.丑丘万万与丒一三东 = -1f;
        }
        
        val_45 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙;
        if((val_45 & 1) == 0)
        {
            goto label_33;
        }
        
        UnityEngine.Vector3 val_12 = this.世丝丛一丅丆丝丗丝.localPosition;
        if(this.东丛丌丆丅世丐不丒 == false)
        {
            goto label_35;
        }
        
        val_49 = 0f;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_49, z = 0f});
        this.世丝丛一丅丆丝丗丝.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.Vector2 val_15 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel.clipOffset;
        UnityEngine.Vector4 val_16 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
        val_54 = val_16.z;
        val_55 = val_16.w;
        val_56 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel;
        val_57 = val_11 + val_16.x;
        val_58 = val_16.y;
        goto label_44;
        label_33:
        this.丝且与丝丒丟万丁专.丙丘七丅且丆东与世();
        val_59 = this.丙丒丝丂丛丗东丄一;
        if(val_59 == null)
        {
                return (bool)val_59;
        }
        
        val_59.Invoke();
        label_4:
        val_59 = 0;
        return (bool)val_59;
        label_35:
        val_49 = 0f;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_49, z = 0f});
        this.世丝丛一丅丆丝丗丝.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        UnityEngine.Vector2 val_21 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel.clipOffset;
        UnityEngine.Vector4 val_22 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        val_54 = val_22.z;
        val_55 = val_22.w;
        val_56 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel;
        val_57 = val_22.x;
        val_58 = val_11 + val_22.y;
        label_44:
        UnityEngine.Vector2 val_25 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_57, y = val_58, z = val_54, w = val_55});
        val_56.clipOffset = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
        float val_43 = System.Math.Abs(val_11);
        val_43 = this.丑丘万万与丒一三东 - val_43;
        this.丑丘万万与丒一三东 = val_43;
        if(this.丏丈三丛业不专丑业 == false)
        {
            goto label_66;
        }
        
        UIPanel val_27 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel;
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = val_25.y, z = val_54});
        UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_54});
        float val_44 = val_28.x;
        float val_45 = val_28.y;
        if((val_44 == 0f) || (val_44 > _TYPE_MAX_))
        {
            goto label_66;
        }
        
        UnityEngine.Vector3 val_30 = this.世丝丛一丅丆丝丗丝.localPosition;
        if(this.东丛丌丆丅世丐不丒 == false)
        {
            goto label_69;
        }
        
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.世丝丛一丅丆丝丗丝.localPosition = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
        UnityEngine.Vector2 val_33 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel.clipOffset;
        UnityEngine.Vector4 val_34 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_33.x, y = val_33.y});
        val_44 = val_34.x - val_44;
        if(this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙 != null)
        {
            goto label_87;
        }
        
        label_88:
        label_87:
        UnityEngine.Vector2 val_36 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_44, y = val_34.y, z = val_34.z, w = val_34.w});
        this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel.clipOffset = new UnityEngine.Vector2() {x = val_36.x, y = val_36.y};
        this.丑丘万万与丒一三东 = -1f;
        label_66:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_59;
        label_69:
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.世丝丛一丅丆丝丗丝.localPosition = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
        UnityEngine.Vector2 val_39 = this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙.panel.clipOffset;
        UnityEngine.Vector4 val_40 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
        val_45 = val_40.y - val_45;
        if(this.丝且与丝丒丟万丁专.业丘丘丕专丞丅丈丙 != null)
        {
            goto label_87;
        }
        
        goto label_88;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
