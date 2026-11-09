using UnityEngine;
internal class FortBearTrapsController : FortTrap
{
    // Fields
    public UnityEngine.Animation anim;
    
    // Methods
    public override void DetectedTarget()
    {
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  1000f, 丞丗且下世丐业丌丙:  0, 丐丟丘世丁三丕专专:  0);
    }
    private void 丁丛丏上一业七上丁()
    {
        var val_22;
        var val_23;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W21, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        label_28:
        var val_21 = 0;
        val_21 = val_21 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        T val_6 = val_2.Current;
        UnityEngine.Vector3 val_7 = val_6.position;
        UnityEngine.Vector3 val_9 = this.transform.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        float val_12 = this.detectRadius;
        val_12 = this.detectRadius * val_12;
        if(val_10.x >= 0)
        {
            goto label_28;
        }
        
        丅丙上七上一丐不下 val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_6);
        if(val_13 == null)
        {
            goto label_28;
        }
        
        UnityEngine.Vector3 val_16 = this.transform.position;
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_13.ApplyDamage(丞丈专下丈专业三丞:  this.下与丗丒丐三丕丘丈(), 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), 丒丈丐丐丗丐专丈丏:  0);
        goto label_28;
        label_7:
        val_22 = 0;
        val_23 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public override void StartDeactivate()
    {
        if(true != 0)
        {
                return;
        }
        
        mem[1152921526033189348] = 1;
        if(this.anim != 0)
        {
                bool val_2 = this.anim.Play(animation:  "attack");
        }
        
        this.Invoke(methodName:  "DeactivateDelayed", time:  null);
        this.丁丛丏上一业七上丁();
    }
    public override void Activate()
    {
        this.Activate();
        mem[1152921526033317812] = 0;
        if(this.anim == 0)
        {
                return;
        }
        
        bool val_2 = this.anim.Play(animation:  "idle");
    }
    public override void Deactivate()
    {
        if(this.isActive == false)
        {
                return;
        }
        
        this.isActive = false;
        mem[1152921526033437920] = 0;
        double val_4 = (double)this.丌七丞七专丘丞世丒();
        val_4 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_4;
        mem[1152921526033437928] = val_4;
    }
    public FortBearTrapsController()
    {
    
    }

}
