using UnityEngine;
internal sealed class SelfExplosionComponent : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Transform> 丞七且丄丟下东丕一;
    private float explosionRadiusDamage;
    private string explosionName;
    private float damageExplosionMultiplier;
    private UnityEngine.Transform explosionPoint;
    private Player_move_c 丌丑丛业丈丘世丞丕;
    private float 丞丈专下丈专业三丞;
    
    // Methods
    private void Start()
    {
        this.丞七且丄丟下东丕一 = new System.Collections.Generic.List<UnityEngine.Transform>();
    }
    internal void 丐丟丐专丙一丄业丟(bool 丌且下丕下下丌万丞, Player_move_c 丌丑丛业丈丘世丞丕, float 业丞业一丒丛丝且专)
    {
        this.丌丑丛业丈丘世丞丕 = 丌丑丛业丈丘世丞丕;
        业丞业一丒丛丝且专 = this.damageExplosionMultiplier * 业丞业一丒丛丝且专;
        this.丞丈专下丈专业三丞 = 业丞业一丒丛丝且专;
        this.丆丕丒东丗丒丄万且();
        if(丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        this.丘丘业丁一与丅丛丗();
    }
    private void 丆丕丒东丗丒丄万且()
    {
        UnityEngine.Vector3 val_1 = this.explosionPoint.position;
        RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  this.explosionName)).transform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    private void 丘丘业丁一与丅丛丗()
    {
        float val_38;
        float val_39;
        var val_40;
        var val_41;
        var val_42;
        System.Collections.Generic.List<UnityEngine.Transform> val_45;
        var val_50;
        var val_51;
        UnityEngine.Vector3 val_1 = this.explosionPoint.position;
        val_38 = val_1.x;
        val_39 = val_1.z;
        val_40 = 1152921504691191808;
        val_41 = 1152921505117388800;
        val_42 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  this.丌丑丛业丈丘世丞丕, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
        label_39:
        var val_39 = 0;
        val_39 = val_39 + 1;
        if(val_42.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        T val_7 = val_42.Current;
        UnityEngine.Vector3 val_9 = val_7.position;
        if((val_7.丝丐下丛丝东丏业丟(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丂丑下与下与不东不:  new UnityEngine.Vector3() {x = val_38, y = val_1.y, z = val_39}, 且丛上丕业丂丒与一:  this.explosionRadiusDamage)) == false)
        {
            goto label_39;
        }
        
        if(this.丞七且丄丟下东丕一 == null)
        {
            goto label_21;
        }
        
        if((this.丞七且丄丟下东丕一.Contains(item:  val_7)) == true)
        {
            goto label_39;
        }
        
        val_45 = this.丞七且丄丟下东丕一;
        if(val_45 != null)
        {
            goto label_24;
        }
        
        label_21:
        val_45 = null;
        val_45 = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.丞七且丄丟下东丕一 = val_45;
        label_24:
        null.Add(item:  val_7);
        UnityEngine.Vector3 val_14 = this.transform.position;
        var val_41 = 0;
        val_41 = val_41 + 1;
        丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_7).ApplyDamage(丞丈专下丈专业三丞:  this.丞丈专下丈专业三丞, 丛世一丟丞丁业丘丒:  this.丌丑丛业丈丘世丞丕.丂七一业下丈业丕丒, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, 丐丟丘世丁三丕专专:  3, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        goto label_39;
        label_8:
        val_50 = 0;
        val_51 = 0;
        if(val_42 == null)
        {
            
        }
        else
        {
                var val_42 = 0;
            val_42 = val_42 + 1;
            val_42.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_42 = ???;
        val_50 = ???;
        val_40 = ???;
        val_41 = ???;
        val_38 = ???;
        val_39 = ???;
    }
    private bool 丝丐下丛丝东丏业丟(UnityEngine.Vector3 丙丌丛丘丗与一专丁, UnityEngine.Vector3 丂丑下与下与不东不, float 且丛上丕业丂丒与一)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丙丌丛丘丗与一专丁.x, y = 丙丌丛丘丗与一专丁.y, z = 丙丌丛丘丗与一专丁.z}, b:  new UnityEngine.Vector3() {x = 丂丑下与下与不东不.x, y = 丂丑下与下与不东不.y, z = 丂丑下与下与不东不.z});
        float val_2 = 且丛上丕业丂丒与一 * 且丛上丕业丂丒与一;
        return (bool)(val_1.x < 0) ? 1 : 0;
    }
    public SelfExplosionComponent()
    {
        this.丞七且丄丟下东丕一 = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.explosionRadiusDamage = 3f;
        this.damageExplosionMultiplier = 1f;
        this.explosionName = "Explosion501";
    }

}
