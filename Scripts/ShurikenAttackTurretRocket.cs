using UnityEngine;
internal sealed class ShurikenAttackTurretRocket : BaseAttackTurretRocket
{
    // Fields
    private TurretControllerScene_BoomerangRocketLauncher 丁下丘七丙世东丗丅;
    protected UnityEngine.GameObject rocketModel;
    private bool 七丕丞丈丘丂丌丞专;
    
    // Methods
    protected override void 业万丗专丈下且丑万(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_23;
        var val_24;
        this.业万丗专丈下且丑万(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅);
        val_23 = 1152921504848912384;
        if(丘丛丏丘丝七世七丅 == 0)
        {
                return;
        }
        
        if(val_23 == 0)
        {
                return;
        }
        
        val_23 = 丘丛丏丘丝七世七丅.transform.root;
        if((val_23.CompareTag(tag:  "Rocket")) == true)
        {
                return;
        }
        
        val_23 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  丘丛丏丘丝七世七丅);
        if(val_23 == null)
        {
                return;
        }
        
        if(this.七丕丞丈丘丂丌丞专 == false)
        {
                return;
        }
        
        if((X22.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_23)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_9 = 丘丛丏丘丝七世七丅.transform.position;
        UnityEngine.Vector3 val_11 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_12.y = val_12.y * val_12.y;
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) >= 0)
        {
                return;
        }
        
        val_24 = 0;
        UnityEngine.Vector3 val_17 = this.transform.position;
        UnityEngine.Vector3 val_19 = this.transform.forward;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  2f);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_23.ApplyDamage(丞丈专下丈专业三丞:  this.丈丆丝丑丙丈丒丑丏(), 丛世一丟丞丁业丘丒:  null, 专不丑且不丏东丟丅:  丘丛丏丘丝七世七丅, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  this, 丒丈丐丐丗丐专丈丏:  0);
    }
    internal override void 世业丄丐三丂丛丈世(FortEquipObject 丗与丝丌东上与丒丅, bool 丗丂且丘不专丌一丂, bool 且丝业丙丁丂万丞与, bool 丅七上一丈丕上丒丞)
    {
        丗丂且丘不专丌一丂 = 丗丂且丘不专丌一丂;
        且丝业丙丁丂万丞与 = 且丝业丙丁丂万丞与;
        丅七上一丈丕上丒丞 = 丅七上一丈丕上丒丞;
        this.世业丄丐三丂丛丈世(丗与丝丌东上与丒丅:  丗与丝丌东上与丒丅, 丗丂且丘不专丌一丂:  丗丂且丘不专丌一丂, 且丝业丙丁丂万丞与:  且丝业丙丁丂万丞与, 丅七上一丈丕上丒丞:  丅七上一丈丕上丒丞);
        this.丁下丘七丙世东丗丅 = (38161477 == null) ? true : 0;
    }
    private void 丁丆丏上丂丒丒丏上()
    {
        this.丁下丘七丙世东丗丅.丁丆丏上丂丒丒丏上();
    }
    private void 三丐丟丛丆丞三东东(UnityEngine.Vector3 丘且下七丁丗丑业东)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rocketModel, 丏业丟一东丂东丘丛:  false);
        this = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.rocketModel)) != true) ? 1168330360 : "Explosion47"));
        if(this == 0)
        {
                return;
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = 丘且下七丁丗丑业东.x, y = 丘且下七丁丗丑业东.y, z = 丘且下七丁丗丑业东.z};
    }
    internal void 丆丌丙万与丛万丝世()
    {
        this.七丕丞丈丘丂丌丞专 = true;
    }
    public void StopAttack()
    {
        this.七丕丞丈丘丂丌丞专 = false;
    }
    public ShurikenAttackTurretRocket()
    {
    
    }

}
