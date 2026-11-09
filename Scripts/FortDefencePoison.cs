using UnityEngine;
internal sealed class FortDefencePoison : FortTrap
{
    // Fields
    public float damagePercent;
    private float 丂丐丈丕丞下丁下丘;
    private int 丂上上不一丐业一丕;
    private float 丙一丑丏丁一且丒业;
    private System.Collections.Generic.List<丅丙上七上一丐不下> 丘与专丒丕丙丈世东;
    
    // Methods
    public override void DetectTargets()
    {
        var val_19;
        var val_20;
        if(this.丙一丑丏丁一且丒业 >= 0f)
        {
            goto label_1;
        }
        
        this.丘与专丒丕丙丈世东.Clear();
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W21, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        label_26:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_9;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        T val_6 = val_2.Current;
        UnityEngine.Vector3 val_8 = val_6.transform.position;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        float val_13 = this.detectRadius;
        val_13 = this.detectRadius * val_13;
        if(val_11.x >= 0)
        {
            goto label_26;
        }
        
        丅丙上七上一丐不下 val_15 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_6.transform);
        if(val_15 == null)
        {
            goto label_26;
        }
        
        this.丘与专丒丕丙丈世东.Add(item:  val_15);
        goto label_26;
        label_1:
        float val_16 = UnityEngine.Time.deltaTime;
        val_16 = this.丙一丑丏丁一且丒业 - val_16;
        this.丙一丑丏丁一且丒业 = val_16;
        return;
        label_9:
        val_19 = 0;
        val_20 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_2.Dispose();
        }
        
        if(this.丘与专丒丕丙丈世东.Count < 1)
        {
                return;
        }
    
    }
    public override void DetectedTarget()
    {
        this.丁丛丏上一业七上丁();
    }
    private void 丁丛丏上一业七上丁()
    {
        List.Enumerator<T> val_1 = this.丘与专丒丕丙丈世东.GetEnumerator();
        label_9:
        if(((-46924328) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        var val_7 = 0;
        val_7 = val_7 + 1;
        0.丐丏七丌丕丗业且上().ApplyDamage(丞丈专下丈专业三丞:  this.下与丗丒丐三丕丘丈(), 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丐丟丘世丁三丕专专:  12, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丙一丑丏丁一且丒业 = this.丂丐丈丕丞下丁下丘;
    }
    public override void StartDeactivate()
    {
        if(true != 0)
        {
                return;
        }
        
        mem[1152921526034912340] = 1;
        if(137129984 != 0)
        {
                SetActive(value:  false);
        }
        
        this.Invoke(methodName:  "DeactivateDelayed", time:  null);
        UnityEngine.GameObject val_3 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  "Explosion47"));
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.position;
        val_3.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public FortDefencePoison()
    {
        this.丂丐丈丕丞下丁下丘 = 1f;
        this.丂上上不一丐业一丕 = 3;
        this.丙一丑丏丁一且丒业 = -1f;
        this.丘与专丒丕丙丈世东 = new System.Collections.Generic.List<丅丙上七上一丐不下>();
    }

}
