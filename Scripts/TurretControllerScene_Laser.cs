using UnityEngine;
internal sealed class TurretControllerScene_Laser : TurretControllerScene_Tower
{
    // Fields
    private UnityEngine.AudioClip shotClip;
    private UnityEngine.Transform shotPoint;
    private UnityEngine.Transform shotPoint2;
    private UnityEngine.GameObject[] gunFlashes;
    private string rayName;
    
    // Methods
    protected override void 丅丙业不丏丟丄丕丝()
    {
        UnityEngine.AudioClip val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        UnityEngine.GameObject[] val_35;
        val_30 = 1152921504848912384;
        val_31 = 0;
        if(this.shotPoint2 == 0)
        {
                return;
        }
        
        if(this.shotPoint == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.shotPoint != 0)
        {
                val_30 = this.shotClip;
            this.shotPoint.PlayOneShot(clip:  val_30);
        }
        
        }
        
        if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  this.shotPoint))) != true)
        {
                val_31 = this.丐丕世丂上丐丑东丂() + 0.1f;
            mem[1152921540624561032] = val_31;
        }
        
        UnityEngine.Vector3 val_8 = this.shotPoint2.position;
        val_32 = val_8.x;
        UnityEngine.Vector3 val_9 = this.shotPoint.position;
        UnityEngine.Vector3 val_10 = this.shotPoint2.position;
        val_33 = val_10.y;
        UnityEngine.Vector3 val_11 = this.shotPoint.position;
        UnityEngine.Vector3 val_12 = this.shotPoint2.position;
        val_34 = val_12.z;
        UnityEngine.Vector3 val_13 = this.shotPoint.position;
        float val_14 = val_32 - val_9.x;
        float val_15 = val_33 - val_11.y;
        val_13.z = val_34 - val_13.z;
        UnityEngine.Vector3 val_16 = this.shotPoint.position;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  100f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())) != false)
        {
                丅丙上七上一丐不下 val_19 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  val_31);
            if(val_19 != null)
        {
                if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_19)) != false)
        {
                bool val_21 = this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  val_19);
        }
        
        }
        
        }
        
        val_35 = this.gunFlashes;
        if(val_35 == null)
        {
                return;
        }
        
        if(this.gunFlashes.Length == 0)
        {
                return;
        }
        
        val_30 = 0;
        goto label_29;
        label_46:
        this.gunFlashes[0].SetActive(value:  true);
        UnityEngine.Vector3 val_23 = this.gunFlashes[0].transform.position;
        val_33 = val_23.z;
        UnityEngine.Vector3 val_25 = this.gunFlashes[0].transform.position;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        val_34 = val_26.y;
        val_32 = val_31.targetValue;
        UnityEngine.GameObject val_28 = WeaponManager.上不丝专丏丝丙丅丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_33}, 丗丟东丗丕世丛丌丗:  new UnityEngine.Vector3() {x = val_26.x, y = val_34, z = val_26.z}, 丛丄万三丂东丙丑东:  this.rayName, 不丅丛专丘丅专丘丕:  val_32);
        val_35 = this.gunFlashes;
        val_30 = 1;
        label_29:
        if(val_30 < this.gunFlashes.Length)
        {
            goto label_46;
        }
    
    }
    public TurretControllerScene_Laser()
    {
        mem[1152921540624935144] = ;
        mem[1152921540624935160] = ;
        mem[1152921540624935180] = 1110704128;
        1152921540624935144 = new TurretControllerScene();
    }

}
