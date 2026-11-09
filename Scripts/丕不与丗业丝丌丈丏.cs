using UnityEngine;
private sealed class TurretController_Tower.丕不与丗业丝丌丈丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretController_Tower 丝且与丝丒丟万丁专;
    private UnityEngine.GameObject 万专不三业世丌丅专;
    private float 丟丕丈丁丄不世丌丆;
    private System.Collections.Generic.IEnumerator<UnityEngine.Transform> 丒与不丕东七丂上不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretController_Tower.丕不与丗业丝丌丈丏(int 丗丏丅丕丆世丁专丟)
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
        var val_24;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_25;
        var val_26;
        var val_28;
        UnityEngine.Transform val_29;
        float val_30;
        float val_31;
        float val_32;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                val_23 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                return (bool)val_23;
        }
        
            val_24 = this;
            val_25 = this.丒与不丕东七丂上不;
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            mem2[0] = 1;
            this.万专不三业世丌丅专 = 0;
            this.丟丕丈丁丄不世丌丆 = -1.175494E-38f;
            val_26 = null;
            val_26 = null;
            new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑() = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  false, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  false);
            val_25 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑().世且一丄且上丄不一();
            val_24 = this;
            this.丒与不丕东七丂上不 = val_25;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(val_25.MoveNext() == false)
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
        label_14:
        this.一世丕丕业且且丅丌();
        this.丒与不丕东七丂上不 = 0;
        if(this.万专不三业世丌丅专 == 0)
        {
            goto label_22;
        }
        
        val_29 = this.万专不三业世丌丅专.transform;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_22:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_26;
        }
        
        val_29 = 0;
        label_24:
        mem2[0] = val_29;
        goto label_27;
        label_17:
        val_27 = val_27 + (((mem[val_2] + 176 + 8)) << 4);
        val_28 = val_27 + 296;
        label_19:
        val_29 = this.丒与不丕东七丂上不.Current;
        UnityEngine.Vector3 val_8 = val_29.position;
        val_30 = val_8.z;
        UnityEngine.Vector3 val_10 = this.丝且与丝丒丟万丁专.transform.position;
        val_31 = val_10.y;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_30}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_31, z = val_10.z});
        if((val_11.x >= 0) || (val_11.x >= 0))
        {
            goto label_54;
        }
        
        val_30 = 0f;
        val_32 = 0f;
        val_31 = val_11.z;
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = 0f, y = val_30, z = val_32}, to:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_31})) >= 0)
        {
            goto label_54;
        }
        
        UnityEngine.Vector3 val_13 = this.丝且与丝丒丟万丁专.tower.position;
        UnityEngine.Vector3 val_14 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  val_29);
        val_31 = val_14.x;
        val_32 = val_14.z;
        UnityEngine.Vector3 val_15 = this.丝且与丝丒丟万丁专.tower.position;
        val_30 = val_15.z;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31, y = val_14.y, z = val_32}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_30});
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_15.y, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())) == false)
        {
            goto label_54;
        }
        
        丅丙上七上一丐不下 val_19 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(val_19 == null)
        {
            goto label_54;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        goto label_50;
        label_26:
        val_29 = 0;
        label_25:
        mem2[0] = val_29;
        label_27:
        val_23 = 0;
        mem2[0] = 0;
        return (bool)val_23;
        label_50:
        if(val_19.transform == val_29)
        {
                this.丟丕丈丁丄不世丌丆 = val_11.x;
            this.万专不三业世丌丅专 = val_29.gameObject;
        }
        
        label_54:
        val_23 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
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
