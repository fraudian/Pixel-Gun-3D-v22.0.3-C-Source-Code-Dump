using UnityEngine;
internal class SatelliteController : TurretControllerScene
{
    // Fields
    public UnityEngine.GameObject rayFromTower;
    public UnityEngine.GameObject rayToTarget;
    public UnityEngine.GameObject explosionSatellite;
    public float delayBeetwinRayToTargetAndExplosion;
    public float delayExplosion;
    public float radiusExplosion;
    protected float 丈三丐且丝上丙丐丙;
    
    // Methods
    protected override void 丗丅世且丛丑业世丑()
    {
        var val_40;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        var val_47;
        var val_48;
        var val_50;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W22, 丅七上一丈丕上丒丞:  W21).世且一丄且上丄不一();
        val_40 = 0;
        goto label_2;
        label_19:
        var val_42 = 0;
        val_42 = val_42 + 1;
        T val_4 = val_2.Current;
        UnityEngine.Vector3 val_5 = val_4.position;
        val_42 = val_5.z;
        UnityEngine.Vector3 val_7 = this.transform.position;
        val_43 = val_7.y;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_42}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_43, z = val_7.z});
        val_44 = val_8.x;
        丅丙上七上一丐不下 val_9 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_4);
        var val_10 = (val_44 < 0) ? 1 : 0;
        var val_11 = (val_44 < 0) ? 1 : 0;
        var val_12 = (val_10 != val_11) ? (val_44) : 3.402823E+38f;
        UnityEngine.Object val_13 = (val_10 != val_11) ? (val_4) : (val_40);
        label_2:
        var val_43 = 0;
        val_43 = val_43 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_19;
        }
        
        val_47 = 0;
        val_48 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_44 = 0;
            val_44 = val_44 + 1;
            val_2.Dispose();
        }
        
        val_50 = UnityEngine.Object.op_Inequality(x:  val_13, y:  0);
        if((UnityEngine.Object.__il2cppRuntimeField_cctor_finished != 0) && (val_13 != 0))
        {
                if(val_2 != val_13)
        {
                UnityEngine.Vector3 val_21 = val_13.position;
            UnityEngine.Transform val_22 = this.transform;
            UnityEngine.Vector3 val_23 = val_22.position;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            UnityEngine.Vector3 val_25 = val_22.position;
            val_43 = val_25.z;
            UnityEngine.Vector3 val_27 = this.transform.position;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_43}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            val_42 = val_28.x;
            UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_24.x, y:  val_24.z);
            val_44 = val_29.x.sqrMagnitude;
            val_45 = val_42;
            UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  val_45, y:  val_28.z);
            float val_32 = val_31.x.sqrMagnitude;
        }
        
        }
        
        不七世丁丟丏世业丑 val_35 = this.丛丞丘一丘丈丐丂丙(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_13));
        if(val_35.丄丈丑丐丆丞丘与丗 == 0)
        {
                return;
        }
        
        if((((val_44 < 0) ? 1 : 0) & 1) != 0)
        {
                if(val_13 == 1152921505189965824)
        {
                return;
        }
        
            float val_38 = UnityEngine.Time.time;
            if(val_44 >= 0)
        {
                return;
        }
        
            val_13.SendSetTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  val_35.丄丈丑丐丆丞丘与丗.viewID, 丏与丅下丞丗与七下:  val_35.丏与丅下丞丗与七下);
            return;
        }
        
        if(val_13 != 1152921505189965824)
        {
                return;
        }
        
        val_13.SendRemoveTargetRPC(上世万世丐丄上丑丆:  this, 世上丕丐丈世上不丏:  val_35.丄丈丑丐丆丞丘与丗.viewID, 丏与丅下丞丗与七下:  val_35.丏与丅下丞丗与七下);
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        this.丟丞丆上上丁丅下丐();
        丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137138176);
        if(val_1 == null)
        {
                return;
        }
        
        if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_1)) == false)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丈三丐且丝上丙丐丙 - val_3;
        this.丈三丐且丝上丙丐丙 = val_3;
        if(val_3 >= 0)
        {
                return;
        }
        
        SendShotRPC(上世万世丐丄上丑丆:  this);
        this.丈三丐且丝上丙丐丙 = this.丐丕世丂上丐丑东丂();
    }
    protected override void 丅丙业不丏丟丄丕丝()
    {
        if(137138176 == 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.一丘三三丐不三不世());
    }
    private System.Collections.IEnumerator 一丘三三丐不三不世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SatelliteController.丅丅不丑丂上丟丌万();
    }
    public SatelliteController()
    {
        this.delayBeetwinRayToTargetAndExplosion = 1f;
        this.delayExplosion = 1f;
        this.radiusExplosion = 5f;
    }

}
