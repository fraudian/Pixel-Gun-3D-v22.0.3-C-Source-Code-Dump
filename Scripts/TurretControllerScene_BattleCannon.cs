using UnityEngine;
internal sealed class TurretControllerScene_BattleCannon : TurretControllerScene_Tower
{
    // Fields
    public UnityEngine.ParticleSystem gunFlash;
    public UnityEngine.AudioClip shotClip;
    public UnityEngine.Transform shotPoint1;
    public UnityEngine.Transform shotPoint2;
    public float dissipation;
    public UnityEngine.Transform frontGunBarrel;
    public UnityEngine.Vector3 startFrontGunBarrelPosition;
    public UnityEngine.Vector3 endFrontGunBarrelPosition;
    public float shootFrontGunBarrelAnimationTime;
    public float returnFrontGunBarrelAnimationTime;
    public float frontGunBarrelPauseBeforeReturn;
    public UnityEngine.Transform backGunBarrel;
    public UnityEngine.Vector3 startBackGunBarrelPosition;
    public UnityEngine.Vector3 endBackGunBarrelPosition;
    public float shootBackGunBarrelAnimationTime;
    public float returnBackGunBarrelAnimationTime;
    public float backGunBarrelPauseBeforeReturn;
    public UnityEngine.GameObject shellPrefab;
    private float shellSpeed;
    
    // Methods
    protected override void 丅丙业不丏丟丄丕丝()
    {
        UnityEngine.Vector3 val_47;
        float val_48;
        float val_49;
        float val_50;
        float val_51;
        var val_52;
        float val_54;
        var val_55;
        float val_56;
        var val_59;
        if(this.shotPoint1 == 0)
        {
                return;
        }
        
        if(this.shotPoint2 == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.shotPoint2 != 0)
        {
                this.shotPoint2.PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        if(this.frontGunBarrel != 0)
        {
                bool val_6 = UnityEngine.Object.op_Inequality(x:  this.backGunBarrel, y:  0);
            if(val_6 != false)
        {
                val_47 = this.startBackGunBarrelPosition;
            UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.StartCoroutine(routine:  val_6.丁丈丒世丂下丙一专(丆丐丟丝世丈丑丈不:  this.frontGunBarrel, 丙丌丙三一专丙且丟:  new UnityEngine.Vector3() {x = this.startFrontGunBarrelPosition}, 丌丄丑丁丟丒且丅丂:  new UnityEngine.Vector3() {x = this.endFrontGunBarrelPosition}, 丒丑且丏上丕上丝丏:  this.shootFrontGunBarrelAnimationTime, 丁丅丒上三丕世下丅:  this.returnFrontGunBarrelAnimationTime, 丟丈丘丏丁专丛与丛:  this.frontGunBarrelPauseBeforeReturn)).丁丈丒世丂下丙一专(丆丐丟丝世丈丑丈不:  this.backGunBarrel, 丙丌丙三一专丙且丟:  new UnityEngine.Vector3() {x = val_47}, 丌丄丑丁丟丒且丅丂:  new UnityEngine.Vector3() {x = this.endBackGunBarrelPosition}, 丒丑且丏上丕上丝丏:  this.shootBackGunBarrelAnimationTime, 丁丅丒上三丕世下丅:  this.returnBackGunBarrelAnimationTime, 丟丈丘丏丁专丛与丛:  this.backGunBarrelPauseBeforeReturn));
        }
        
        }
        
        丅丙上七上一丐不下 val_11 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  this.backGunBarrel);
        bool val_12 = this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_11);
        if(val_12 != true)
        {
                if(val_12 != false)
        {
                float val_13 = val_12.丟一丞丗业三丁上东();
        }
        else
        {
                val_49 = 0.15f;
        }
        
            val_48 = 0.1f;
            val_50 = val_49 + val_48;
            mem[1152921540621593864] = val_50;
            this.丐万丙专丟丒丙与丂(丘业丝下丑丈且东丒:  val_11);
        }
        
        UnityEngine.Vector3 val_14 = this.shotPoint2.position;
        UnityEngine.Quaternion val_15 = this.shotPoint2.rotation;
        val_51 = val_14.x;
        UnityEngine.GameObject val_16 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.shellPrefab, position:  new UnityEngine.Vector3() {x = val_51, y = val_14.y, z = val_14.z}, rotation:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w});
        ExplosionAttackTurretRocket val_17 = val_16.GetComponent<ExplosionAttackTurretRocket>();
        if((System.String.IsNullOrEmpty(value:  丆丘丒东且丂与丂丑())) == true)
        {
            goto label_37;
        }
        
        string val_20 = 丆丘丒东且丂与丂丑();
        if((val_20.Equals(value:  "Nuclear Area")) == true)
        {
            goto label_37;
        }
        
        string val_22 = val_20.丆丘丒东且丂与丂丑();
        if((val_22.Contains(value:  "Area")) == false)
        {
            goto label_37;
        }
        
        string val_24 = val_22.丆丘丒东且丂与丂丑();
        if((System.String.op_Equality(a:  val_24, b:  "Poison Area")) != true)
        {
                if((System.String.op_Equality(a:  val_24, b:  "Fire Area")) == false)
        {
            goto label_40;
        }
        
        }
        
        val_51 = this.三丟丅不丅丅业丛丁();
        val_17.丕不丙丈与丅上丂业(三一丝且丝丛不丄丐:  val_24, 丒丂且不丅丞三丒世:  val_51);
        goto label_72;
        label_37:
        if((System.String.IsNullOrEmpty(value:  丆丘丒东且丂与丂丑())) != true)
        {
                mem[1152921540621593472] = this.三丟丅不丅丅业丛丁();
        }
        
        label_72:
        val_52 = 0;
        if(丕丗业丝万上丂且丝() <= 0f)
        {
            goto label_46;
        }
        
        val_52 = 0;
        val_54 = 丕丗业丝万上丂且丝();
        if(val_17 == null)
        {
            goto label_48;
        }
        
        val_55 = 0;
        goto label_51;
        label_46:
        var val_33 = (val_17 == 0) ? 1 : 0;
        goto label_51;
        label_48:
        val_55 = 1;
        label_51:
        mem2[0] = val_54;
        val_56 = 0f;
        if(0 == 0)
        {
            goto label_56;
        }
        
        val_52 = 0;
        if(0.七与万且专丁丝丘丈() >= 0f)
        {
            goto label_53;
        }
        
        var val_35 = (1152921540621531392 != 0) ? 1 : 0;
        var val_36 = (W9 != 0) ? 1 : 0;
        if(val_55 != 0)
        {
            goto label_54;
        }
        
        label_58:
        val_59 = 0;
        goto label_55;
        label_53:
        if(0 != 0)
        {
                val_52 = 0;
            val_56 = 0.七与万且专丁丝丘丈();
        }
        
        label_56:
        val_17.丆丞丐一一丒业丏与(丟上丝丞丄丞东丅与:  val_56);
        bool val_38 = (null != 0) ? 1 : 0;
        bool val_39 = ((System.Void BaseAttackTurretRocket::丆丞丐一一丒业丏与(float 丟上丝丞丄丞东丅与)) != 0) ? 1 : 0;
        if((val_55 & 1) == 0)
        {
            goto label_58;
        }
        
        label_54:
        val_59 = 1;
        label_55:
        val_17.世业丄丐三丂丛丈世(丗与丝丌东上与丒丅:  this, 丗丂且丘不专丌一丂:  true, 且丝业丙丁丂万丞与:  val_38, 丅七上一丈丕上丒丞:  val_39);
        val_17.丞专业丗丟东丗三丏(东丏业丞丞业下丄世:  val_38, 三一丝且丝丛不丄丐:  val_39, 专丞丅丗丌丈且东丁:  1, 丗丝丂丕丑不丆丗丂:  val_56, 丒丙丘丕且一丞丕丑:  val_14.y);
        BaseMovementTurretRocket val_40 = val_16.GetComponent<BaseMovementTurretRocket>();
        UnityEngine.Vector3 val_42 = this.shotPoint2.forward;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, d:  this.shellSpeed);
        val_16.GetComponent<UnityEngine.Rigidbody>().velocity = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
        return;
        label_40:
        if((System.String.op_Equality(a:  val_24, b:  "SlowDown Area")) == false)
        {
            goto label_68;
        }
        
        val_17.下专与三丗丂丒不丑(丂业丑丅与且三丐与:  this.三丟丅不丅丅业丛丁());
        goto label_72;
        label_68:
        if(val_24 == null)
        {
            goto label_72;
        }
        
        int val_46 = val_24.Length;
        goto label_72;
    }
    private System.Collections.IEnumerator 丁丈丒世丂下丙一专(UnityEngine.Transform 丆丐丟丝世丈丑丈不, UnityEngine.Vector3 丙丌丙三一专丙且丟, UnityEngine.Vector3 丌丄丑丁丟丒且丅丂, float 丒丑且丏上丕上丝丏, float 丁丅丒上三丕世下丅, float 丟丈丘丏丁专丛与丛)
    {
        TurretControllerScene_BattleCannon.七丘丛七丁三专下下 val_1 = new TurretControllerScene_BattleCannon.七丘丛七丁三专下下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丆丐丟丝世丈丑丈不 = 丆丐丟丝世丈丑丈不;
        }
        else
        {
                mem[56] = 丆丐丟丝世丈丑丈不;
        }
        
        .丙丌丙三一专丙且丟 = 丙丌丙三一专丙且丟;
        mem[1152921540621852016] = 丙丌丙三一专丙且丟.y;
        mem[1152921540621852020] = 丙丌丙三一专丙且丟.z;
        if(val_1 != null)
        {
                .丌丄丑丁丟丒且丅丂 = 丌丄丑丁丟丒且丅丂;
            mem[1152921540621852004] = 丌丄丑丁丟丒且丅丂.y;
            mem[1152921540621852008] = 丌丄丑丁丟丒且丅丂.z;
            .丒丑且丏上丕上丝丏 = 丒丑且丏上丕上丝丏;
            .丁丅丒上三丕世下丅 = 丁丅丒上三丕世下丅;
        }
        else
        {
                mem[32] = 丌丄丑丁丟丒且丅丂.x;
            mem[1152921540621852004] = 丌丄丑丁丟丒且丅丂.y;
            mem[40] = 丌丄丑丁丟丒且丅丂.z;
            mem[64] = 丒丑且丏上丕上丝丏;
            mem[72] = 丁丅丒上三丕世下丅;
        }
        
        .丟丈丘丏丁专丛与丛 = 丟丈丘丏丁专丛与丛;
        return (System.Collections.IEnumerator)val_1;
    }
    public TurretControllerScene_BattleCannon()
    {
        this.dissipation = 0.015f;
        this.shellSpeed = 10f;
    }

}
