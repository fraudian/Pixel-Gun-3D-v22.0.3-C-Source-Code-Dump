using UnityEngine;
internal class FortGuardMob_Melee : FortGuardMob
{
    // Fields
    private float damageAdditionalRadius;
    
    // Methods
    private bool 丞丄丞丟丏丕专丂丙()
    {
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = val_2.position;
        UnityEngine.Vector3 val_4 = val_2.position;
        UnityEngine.Vector3 val_6 = this.transform.position;
        float val_7 = val_1.x - val_3.x;
        val_6.z = val_4.z - val_6.z;
        UnityEngine.Vector3 val_9 = this.transform.forward;
        float val_10 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        bool val_11 = System.Single.IsNaN(f:  val_10);
        var val_12 = (val_10 < 0) ? 1 : 0;
        val_12 = val_12 | val_11;
        val_11 = val_12;
        return (bool)val_11;
    }
    public override bool IsCanAttackCurrentTarget()
    {
        return this.丘丌且丆丘丏丏与丛();
    }
    public override void Shot()
    {
        var val_18;
        var val_19;
        this.TryPlayHitSound(丕丕世且下一与丝与:  length);
        UnityEngine.Transform val_2 = this.transform;
        val_18 = 1152921504848912384;
        if(val_2 == 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        if(val_2 != typeof(Player_move_c).__il2cppRuntimeField_378)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = val_2.position;
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_9 = val_7.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) > ((this.attackRadius + this.damageAdditionalRadius) * (this.attackRadius + this.damageAdditionalRadius)))
        {
                return;
        }
        
        丅丙上七上一丐不下 val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_7);
        if(val_13 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_15 = this.万丈且与七下上不专();
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_13.ApplyDamage(丞丈专下丈专业三丞:  this.下与丗丒丐三丕丘丈(), 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this), 丒丈丐丐丗丐专丈丏:  0);
    }
    public FortGuardMob_Melee()
    {
        this.damageAdditionalRadius = 2f;
        mem[1152921526057319904] = 1067030938;
        mem[1152921526057320088] = 1099431936;
        mem[1152921526057320112] = 1092616192;
        mem[1152921526057320120] = 2f;
        val_1 = new FortEquipObject();
    }

}
