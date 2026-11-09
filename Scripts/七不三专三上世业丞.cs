using UnityEngine;
private sealed class DroneController.七不三专三上世业丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public DroneController 丝且与丝丒丟万丁专;
    private UnityEngine.GameObject 万专不三业世丌丅专;
    private float 丟丕丈丁丄不世丌丆;
    private System.Collections.Generic.IEnumerator<UnityEngine.Transform> 丒与不丕东七丂上不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DroneController.七不三专三上世业丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_23;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        UnityEngine.Transform val_29;
        float val_30;
        float val_31;
        var val_32;
        float val_33;
        float val_34;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                val_23 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                return (bool);
        }
        
            val_24 = this.丒与不丕东七丂上不;
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            this.丝且与丝丒丟万丁专.丆丕丛丞丑丞丄丟三 = true;
            this.万专不三业世丌丅专 = 0;
            this.丟丕丈丁丄不世丌丆 = -1.175494E-38f;
            val_25 = null;
            val_25 = null;
            new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑() = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  false, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  false);
            val_24 = this;
            this.丒与不丕东七丂上不 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑().世且一丄且上丄不一();
        }
        
        val_26 = 1152921504686346240;
        this.丗丏丅丕丆世丁专丟 = -3;
        label_26:
        var val_24 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_13;
        }
        
        var val_22 = mem[val_2] + 176;
        var val_23 = 0;
        val_22 = val_22 + 8;
        label_12:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_11;
        }
        
        val_23 = val_23 + 1;
        val_22 = val_22 + 16;
        if(val_23 < (mem[val_2] + 286))
        {
            goto label_12;
        }
        
        goto label_13;
        label_11:
        val_24 = val_24 + (((mem[val_2] + 176 + 8)) << 4);
        val_27 = val_24 + 296;
        label_13:
        if(this.丒与不丕东七丂上不.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_27 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_19;
        }
        
        var val_25 = mem[val_2] + 176;
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_18:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_17;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < (mem[val_2] + 286))
        {
            goto label_18;
        }
        
        goto label_19;
        label_17:
        val_27 = val_27 + (((mem[val_2] + 176 + 8)) << 4);
        val_28 = val_27 + 296;
        label_19:
        val_29 = this.丒与不丕东七丂上不.Current;
        丅丙上七上一丐不下 val_5 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_29);
        if(val_5 != null)
        {
                if((X28 + 1390) != 0)
        {
            goto label_26;
        }
        
        }
        
        UnityEngine.Vector3 val_6 = val_29.position;
        val_30 = val_6.z;
        val_24 = this.丝且与丝丒丟万丁专.transform;
        UnityEngine.Vector3 val_8 = val_24.position;
        val_31 = val_8.y;
        val_26 = 1152921504838316032;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_30}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_31, z = val_8.z});
        if(val_9.x >= 0)
        {
            goto label_52;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_33;
        }
        
        val_32 = this.丝且与丝丒丟万丁专;
        val_33 = this.丝且与丝丒丟万丁专.maxRadiusScanTarget;
        val_34 = val_33;
        goto label_34;
        label_14:
        this.一世丕丕业且且丅丌();
        this.丒与不丕东七丂上不 = 0;
        if(this.万专不三业世丌丅专 == 0)
        {
            goto label_37;
        }
        
        val_29 = this.万专不三业世丌丅专.transform;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_33:
        val_34 = 0f;
        val_32 = 108;
        val_33 = 0f;
        label_34:
        val_33 = val_34 * val_33;
        if(val_9.x < 0)
        {
                UnityEngine.Vector3 val_13 = this.丝且与丝丒丟万丁专.transform.position;
            UnityEngine.Vector3 val_14 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  val_29);
            val_31 = val_14.x;
            val_24 = this.丝且与丝丒丟万丁专.transform;
            UnityEngine.Vector3 val_16 = val_24.position;
            val_30 = val_16.z;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_30});
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  0f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丒丑丗一东丈万丅下())) != false)
        {
                if((HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0)) == val_5)
        {
                this.丟丕丈丁丄不世丌丆 = val_9.x;
            this.万专不三业世丌丅专 = val_29.gameObject;
        }
        
        }
        
        }
        
        label_52:
        val_23 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool);
        label_37:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_55;
        }
        
        val_29 = 0;
        label_39:
        this.丝且与丝丒丟万丁专.target = val_29;
        goto label_56;
        label_55:
        val_29 = 0;
        label_40:
        this.丝且与丝丒丟万丁专.target = val_29;
        label_56:
        val_23 = 0;
        this.丝且与丝丒丟万丁专.丆丕丛丞丑丞丄丟三 = false;
        return (bool);
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丒与不丕东七丂上不 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丒与不丕东七丂上不.Dispose();
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
