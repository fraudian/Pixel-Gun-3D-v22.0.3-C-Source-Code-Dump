using UnityEngine;
private sealed class TurretController_MusicBox.东七丌上丂丁丐丄丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretController_MusicBox 丝且与丝丒丟万丁专;
    private UnityEngine.GameObject 万专不三业世丌丅专;
    private float 丟丕丈丁丄不世丌丆;
    private System.Collections.Generic.IEnumerator<UnityEngine.Transform> 丒与不丕东七丂上不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretController_MusicBox.东七丌上丂丁丐丄丙(int 丗丏丅丕丆世丁专丟)
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
        TurretController_MusicBox val_40;
        int val_41;
        var val_42;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_43;
        var val_44;
        var val_46;
        var val_47;
        var val_48;
        float val_49;
        float val_50;
        float val_51;
        float val_52;
        float val_53;
        var val_54;
        val_40 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                val_41 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                return (bool)val_41;
        }
        
            val_42 = this;
            val_43 = this.丒与不丕东七丂上不;
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            mem2[0] = 1;
            this.万专不三业世丌丅专 = 0;
            this.丟丕丈丁丄不世丌丆 = -1.175494E-38f;
            val_44 = null;
            val_44 = null;
            new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑() = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  true, 丆世上且丗与丕丂丘:  false, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true);
            val_43 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑().世且一丄且上丄不一();
            val_42 = this;
            this.丒与不丕东七丂上不 = val_43;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        var val_40 = 0;
        val_40 = val_40 + 1;
        if(val_43.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_43 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_19;
        }
        
        var val_41 = mem[val_2] + 176;
        var val_42 = 0;
        val_41 = val_41 + 8;
        label_18:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_17;
        }
        
        val_42 = val_42 + 1;
        val_41 = val_41 + 16;
        if(val_42 < (mem[val_2] + 286))
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
        
        val_47 = this.万专不三业世丌丅专.transform;
        if(val_40 != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_22:
        if(val_40 == null)
        {
            goto label_26;
        }
        
        val_48 = 0;
        label_24:
        mem2[0] = val_48;
        goto label_27;
        label_17:
        val_43 = val_43 + (((mem[val_2] + 176 + 8)) << 4);
        val_46 = val_43 + 296;
        label_19:
        T val_7 = this.丒与不丕东七丂上不.Current;
        UnityEngine.Vector3 val_8 = val_7.position;
        val_49 = val_8.z;
        UnityEngine.Vector3 val_10 = val_40.transform.position;
        val_50 = val_10.y;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_49}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_50, z = val_10.z});
        if((val_11.x >= 0) || (val_11.x >= 0))
        {
            goto label_62;
        }
        
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        val_51 = val_12.x;
        val_52 = val_12.y;
        val_53 = val_12.z;
        UnityEngine.BoxCollider val_13 = val_7.GetComponent<UnityEngine.BoxCollider>();
        if(val_13 != 0)
        {
                UnityEngine.Vector3 val_15 = val_13.center;
            val_51 = val_15.x;
            val_52 = val_15.y;
            val_53 = val_15.z;
        }
        
        UnityEngine.Vector3 val_16 = this.丝且与丝丒丟万丁专.tower.position;
        UnityEngine.Vector3 val_17 = val_7.position;
        val_50 = val_17.y;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_50, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_53});
        val_49 = val_18.y;
        UnityEngine.Vector3 val_19 = this.丝且与丝丒丟万丁专.tower.position;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_49, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_18.x, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())) == false)
        {
            goto label_62;
        }
        
        val_40 = 0.gameObject;
        if(val_40 != val_7.gameObject)
        {
            goto label_53;
        }
        
        label_73:
        this.丟丕丈丁丄不世丌丆 = val_11.x;
        this.万专不三业世丌丅专 = val_7.gameObject;
        goto label_62;
        label_26:
        val_54 = 0;
        label_25:
        mem2[0] = val_54;
        label_27:
        val_41 = 0;
        mem2[0] = 0;
        return (bool)val_41;
        label_53:
        val_40 = 0.gameObject.transform.parent;
        if(val_40 == 0)
        {
            goto label_62;
        }
        
        if((0.gameObject.transform.parent.Equals(other:  val_7)) == true)
        {
            goto label_73;
        }
        
        val_40 = 0.gameObject.transform.parent;
        if((val_40.Equals(other:  val_7.parent)) == true)
        {
            goto label_73;
        }
        
        label_62:
        val_41 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_41;
        return (bool)val_41;
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
