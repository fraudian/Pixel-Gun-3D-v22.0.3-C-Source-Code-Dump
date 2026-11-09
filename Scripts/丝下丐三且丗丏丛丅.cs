using UnityEngine;
private sealed class BPParticles.丝下丐三且丗丏丛丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPParticles 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPParticles.丝下丐三且丗丏丛丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.BattlePass.BPParticles val_12;
        int val_13;
        UnityEngine.GameObject val_14;
        val_12 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_2 = UnityEngine.Resources.LoadAsync(path:  System.String.Format(format:  "BattlePass/BP{0}Particles", arg0:  this.丝且与丝丒丟万丁专._type));
        this.丅丒丑丄丞丑下丈丕 = val_2;
        this.丒上七丌业七丟与丐 = val_2;
        val_13 = 1;
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone == false)
        {
            goto label_6;
        }
        
        val_14 = this.丅丒丑丄丞丑下丈丕.asset;
        if((val_14 != null) && (null != null))
        {
                val_14 = 0;
        }
        
        UnityEngine.GameObject val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_14, parent:  val_12.transform);
        if(val_12 == null)
        {
            goto label_13;
        }
        
        this.丝且与丝丒丟万丁专.丘下且世业三丄丒三 = val_7;
        if(val_7 != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        UnityEngine.Transform val_8 = val_7.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_8.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        val_8.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        ParticleAtraktor val_11 = this.丝且与丝丒丟万丁专 + 48.GetComponentInChildren<ParticleAtraktor>();
        if(val_12 == null)
        {
            goto label_21;
        }
        
        this.丝且与丝丒丟万丁专.丐丟业丕且且三且丁 = val_11;
        goto label_22;
        label_13:
        mem[48] = val_7;
        if(mem[48] != 0)
        {
            goto label_23;
        }
        
        goto label_24;
        label_21:
        mem[40] = val_11;
        label_22:
        val_12 = mem[this.丝且与丝丒丟万丁专 + 48];
        val_12 = this.丝且与丝丒丟万丁专 + 48;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  false);
        label_6:
        val_13 = 0;
        return (bool)val_13;
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
