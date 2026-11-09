using UnityEngine;
private sealed class Rocket.下丐丄丙丞三三一不 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.下丐丄丙丞三三一不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rocket val_22;
        int val_23;
        float val_24;
        float val_25;
        val_22 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_23 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_23;
        }
        
        val_24 = this.丕丕世且下一与丝与;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_24 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_22 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  val_24);
        val_23 = 1;
        this.丒上七丌业七丟与丐 = val_22;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 != 0)
        {
                if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.droneRotator != 0)
        {
                this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.droneRotator.enabled = true;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 != 0)
        {
                if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.droneParticle != 0)
        {
                this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上.droneParticle.SetActive(value:  true);
        }
        
        }
        
        this.丝且与丝丒丟万丁专.万丂一万丙丌不丘一 = true;
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 != false)
        {
                val_22.丂丝不一丑下三七业().useGravity = false;
            UnityEngine.Rigidbody val_7 = val_22.丂丝不一丑下三七业();
            UnityEngine.Vector3 val_8 = val_7.velocity;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_7.velocity = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_12 = val_22.transform.position;
            this.丝且与丝丒丟万丁专.丛东丛丂丂业丐丘三 = val_12;
            mem2[0] = val_12.y;
            mem2[0] = val_12.z;
            UnityEngine.Vector3 val_14 = val_22.transform.position;
            val_24 = val_14.x;
            val_25 = val_14.z;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.down;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_24, y = val_14.y, z = val_25}, direction:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  10000f, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) != false)
        {
                float val_18 = 0.targetValue;
            if(val_18 < 0)
        {
                val_24 = val_18;
            val_25 = val_25;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  2.5f);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24, y = 4.5f, z = val_25}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_23 = 0;
            this.丝且与丝丒丟万丁专.丛东丛丂丂业丐丘三 = val_21;
            mem2[0] = val_21.y;
            mem2[0] = val_21.z;
            return (bool)val_23;
        }
        
        }
        
        }
        
        val_23 = 0;
        return (bool)val_23;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Rocket.下丐丄丙丞三三一不 val_2 = null;
            val_4 = val_2;
            val_2 = new Rocket.下丐丄丙丞三三一不();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
