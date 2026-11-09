using UnityEngine;
internal sealed class TurretControllerScene_TeslaCoil : TurretControllerScene_Tower
{
    // Fields
    private UnityEngine.AudioClip shotClip;
    public UnityEngine.Transform shotPoint;
    private FlashFireForTurret turretFlashScript;
    private string onGroundEffectName;
    
    // Methods
    protected override void 丈丞一丈丑丝丈丂丂()
    {
    
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        var val_13;
        float val_15;
        var val_17;
        var val_18;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W22, 丅七上一丈丕上丒丞:  W21).世且一丄且上丄不一();
        val_13 = 0;
        goto label_12;
        label_18:
        var val_15 = 0;
        val_15 = val_15 + 1;
        T val_4 = val_2.Current;
        UnityEngine.Vector3 val_5 = val_4.position;
        UnityEngine.Vector3 val_6 = val_4.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_15 = val_7.x;
        float val_9 = this.丝丟丆上业丒丕上丂();
        val_9 = this.丝丟丆上业丒丕上丂() * val_9;
        if(val_15 < 0)
        {
                val_13 = 1;
        }
        
        label_12:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_18;
        }
        
        val_17 = 0;
        val_18 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_2.Dispose();
        }
        
        if((val_13 & 1) == 0)
        {
                return;
        }
        
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = val_15 - val_13;
        mem[1152921540632777752] = val_13;
        if(val_13 >= 0)
        {
                return;
        }
        
        val_2.SendShotRPC(上世万世丐丄上丑丆:  this);
        mem[1152921540632777752] = this.丐丕世丂上丐丑东丂();
    }
    protected override void 丅丙业不丏丟丄丕丝()
    {
        var val_36;
        var val_37;
        var val_38;
        var val_41;
        var val_42;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(137129984 != 0)
        {
                PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        this.丏丗丐七丑丏丛七上(丛丄业丕且丗下一万:  "OnGroundWeaponEffects/"("OnGroundWeaponEffects/") + this.onGroundEffectName);
        val_36 = 1152921505189965824;
        if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137129984))) != true)
        {
                float val_6 = this.丐丕世丂上丐丑东丂();
            val_6 = val_6 + 0.1f;
            mem[1152921540632930808] = val_6;
        }
        
        val_37 = 1152921504691191808;
        val_38 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W22, 丅七上一丈丕上丒丞:  this.shotClip).世且一丄且上丄不一();
        label_30:
        var val_38 = 0;
        val_38 = val_38 + 1;
        if(val_38.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_39 = 0;
        val_39 = val_39 + 1;
        T val_12 = val_38.Current;
        UnityEngine.Vector3 val_13 = val_12.position;
        UnityEngine.Vector3 val_14 = X22.position;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        float val_18 = this.丝丟丆上业丒丕上丂();
        val_18 = this.丝丟丆上业丒丕上丂() * val_18;
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z})) >= 0)
        {
            goto label_30;
        }
        
        bool val_20 = this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_12));
        goto label_30;
        label_17:
        val_41 = 0;
        val_42 = 0;
        if(val_38 == null)
        {
            
        }
        else
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_38.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_38 = ???;
        val_41 = ???;
        val_36 = ???;
        val_37 = ???;
    }
    private void 丏丗丐七丑丏丛七上(string 丛丄业丕且丗下一万)
    {
        RayAndExplosionsStackController val_12;
        UnityEngine.Object val_13;
        var val_14;
        System.Action<UnityEngine.Transform> val_16;
        var val_17;
        System.Action<UnityEngine.Transform> val_19;
        val_12 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟;
        val_13 = val_12.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丛丄业丕且丗下一万);
        if(val_13 == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = TurretControllerScene_TeslaCoil.<>c.<>9__7_0;
        if(val_16 == null)
        {
                System.Action<UnityEngine.Transform> val_3 = null;
            val_16 = val_3;
            val_3 = new System.Action<UnityEngine.Transform>(object:  TurretControllerScene_TeslaCoil.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TurretControllerScene_TeslaCoil.<>c::丏万三七且丄丂丆七(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            TurretControllerScene_TeslaCoil.<>c.<>9__7_0 = val_16;
        }
        
        TurretControllerScene_TeslaCoil.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  val_13, 丌专业且丛丏丞丝且:  val_3);
        val_12 = val_13.transform;
        val_12.parent = this.shotPoint;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_13.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0f);
        val_13.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        val_17 = null;
        val_17 = null;
        val_19 = TurretControllerScene_TeslaCoil.<>c.<>9__7_1;
        if(val_19 == null)
        {
                System.Action<UnityEngine.Transform> val_9 = null;
            val_19 = val_9;
            val_9 = new System.Action<UnityEngine.Transform>(object:  TurretControllerScene_TeslaCoil.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TurretControllerScene_TeslaCoil.<>c::丛丏丗与与上不丒丛(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            TurretControllerScene_TeslaCoil.<>c.<>9__7_1 = val_19;
        }
        
        TurretControllerScene_TeslaCoil.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  val_13, 丌专业且丛丏丞丝且:  val_9);
        val_13 = val_13.GetComponent<UnityEngine.ParticleSystem>();
        if(val_13 == 0)
        {
                return;
        }
        
        val_13.Play();
    }
    internal static void 丛专专丗专丕东七丅(UnityEngine.GameObject 万且万且丑丗且丌丆, System.Action<UnityEngine.Transform> 丌专业且丛丏丞丝且)
    {
        var val_7;
        if(丌专业且丛丏丞丝且 == null)
        {
                return;
        }
        
        if(0 == 万且万且丑丗且丌丆)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = 万且万且丑丗且丌丆.transform;
        丌专业且丛丏丞丝且.Invoke(obj:  val_2);
        val_7 = val_2.childCount;
        if(val_7 < 1)
        {
                return;
        }
        
        var val_7 = 0;
        do
        {
            UnityEngine.Transform val_4 = val_2.GetChild(index:  0);
            if(0 != val_4)
        {
                UnityEngine.GameObject val_6 = val_4.gameObject;
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 != val_7);
    
    }
    public TurretControllerScene_TeslaCoil()
    {
        this.onGroundEffectName = "Fort_Tesla_AOE";
        mem[1152921540633416424] = ;
        mem[1152921540633416440] = ;
        mem[1152921540633416460] = 1110704128;
        this = new TurretControllerScene();
    }

}
