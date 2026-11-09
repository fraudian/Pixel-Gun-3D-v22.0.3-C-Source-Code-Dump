using UnityEngine;
public class ParticleAtraktor : MonoBehaviour
{
    // Fields
    private System.Action 丗丗世丘丙不世丁丅;
    public UnityEngine.Transform target;
    public float speed;
    public float Delay;
    public float distanceToKill;
    private UnityEngine.ParticleSystem.Particle[] 一丞丛丗万丝东一丌;
    private UnityEngine.ParticleSystem 丘丕丝上下丄丈丏丒;
    
    // Properties
    internal UnityEngine.ParticleSystem 与一丐业丝上丕丘东 { get; }
    
    // Methods
    internal void 丛丐丐丄七上七丝与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗丗世丘丙不世丁丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗丗世丘丙不世丁丅 != 1152921526359737064);
    
    }
    internal void 丏丏丝丅东专丏三丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗丗世丘丙不世丁丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗丗世丘丙不世丁丅 != 1152921526359873640);
    
    }
    internal UnityEngine.ParticleSystem 七万丅下丘丂丒丟一()
    {
        if(this.丘丕丝上下丄丈丏丒 != 0)
        {
                return (UnityEngine.ParticleSystem)this.丘丕丝上下丄丈丏丒;
        }
        
        UnityEngine.ParticleSystem val_2 = this.GetComponent<UnityEngine.ParticleSystem>();
        this.丘丕丝上下丄丈丏丒 = val_2;
        MainModule val_3 = val_2.main;
        int val_4 = val_3.m_ParticleSystem.maxParticles;
        this.一丞丛丗万丝东一丌 = new Particle[0];
        return (UnityEngine.ParticleSystem)this.丘丕丝上下丄丈丏丒;
    }
    public void GiveReward(int 丌丒丝东丌下丕丁丅)
    {
        this.gameObject.SetActive(value:  false);
        this.gameObject.SetActive(value:  true);
    }
    private void Update()
    {
        if(this.七万丅下丘丂丒丟一().particleCount < 1)
        {
                return;
        }
        
        this.专丘业丌三丕丂丌上();
    }
    private void 专丘业丌三丕丂丌上()
    {
        var val_13;
        float val_14;
        float val_15;
        Particle[] val_16;
        int val_2 = this.七万丅下丘丂丒丟一().GetParticles(particles:  this.一丞丛丗万丝东一丌);
        val_13 = val_2;
        if(val_2 < 1)
        {
            goto label_2;
        }
        
        val_14 = 0.1f;
        var val_15 = 0;
        var val_16 = 32;
        val_13 = val_2;
        label_27:
        val_15 = this.Delay;
        if(val_14 >= 0)
        {
            goto label_5;
        }
        
        val_16 = this.一丞丛丗万丝东一丌;
        if(this.一丞丛丗万丝东一丌 != null)
        {
            goto label_6;
        }
        
        val_16 = this.一丞丛丗万丝东一丌;
        if(val_16 == null)
        {
            goto label_7;
        }
        
        label_6:
        UnityEngine.Vector3 val_3 = this.target.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.speed);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, t:  UnityEngine.Time.deltaTime);
        val_14 = val_9.x;
        val_15 = val_9.y;
        label_5:
        UnityEngine.Vector3 val_10 = this.target.position;
        float val_11 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        if(val_11 < 0)
        {
                val_13 = val_13 - 1;
        }
        else
        {
                if(val_11 < 0)
        {
                var val_13 = this.一丞丛丗万丝东一丌[val_16];
            var val_14 = this.一丞丛丗万丝东一丌[val_16];
            val_11 = val_11 + val_14;
        }
        
        }
        
        val_15 = val_15 + 1;
        val_16 = val_16 + 124;
        if(val_2 != val_15)
        {
            goto label_27;
        }
        
        label_2:
        this.七万丅下丘丂丒丟一().SetParticles(particles:  this.一丞丛丗万丝东一丌, size:  val_2);
        if(val_13 > 0)
        {
                return;
        }
        
        if(this.丗丗世丘丙不世丁丅 == null)
        {
                return;
        }
        
        this.丗丗世丘丙不世丁丅.Invoke();
        return;
        label_7:
    }
    public ParticleAtraktor()
    {
        this.distanceToKill = 0.001f;
        this.一丞丛丗万丝东一丌 = new Particle[0];
    }

}
