using UnityEngine;
internal class FortGuardMob_RocketsLauncher : FortGuardMob
{
    // Fields
    private UnityEngine.Transform aimingPoint;
    private UnityEngine.Transform shotPoint;
    private UnityEngine.GameObject rocketPrefab;
    private float rocketStartSpeed;
    private float attackAdditionalRadius;
    
    // Methods
    private bool 世七丑丁一丕丕业东()
    {
        UnityEngine.Object val_14;
        UnityEngine.Object val_15;
        val_14 = this;
        UnityEngine.Vector3 val_1 = this.aimingPoint.position;
        UnityEngine.Vector3 val_3 = this.aimingPoint.transform.position;
        UnityEngine.Vector3 val_4 = this.aimingPoint.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  this.attackRadius + this.attackAdditionalRadius, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())) != false)
        {
                丅丙上七上一丐不下 val_10 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
            if(val_10 == null)
        {
                return (bool)UnityEngine.Object.op_Equality(x:  val_15 = val_10.transform, y:  this);
        }
        
            var val_15 = 0;
            val_15 = val_15 + 1;
        }
        else
        {
                val_15 = 0;
            return (bool)UnityEngine.Object.op_Equality(x:  val_15, y:  this);
        }
        
        return (bool)UnityEngine.Object.op_Equality(x:  val_15, y:  this);
    }
    public override bool IsCanAttackCurrentTarget()
    {
        float val_9;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = val_1.position;
        UnityEngine.Vector3 val_3 = val_1.position;
        val_9 = val_2.x;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        float val_5 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        float val_6 = this.attackRadius;
        val_6 = val_6 + this.attackAdditionalRadius;
        val_9 = val_6 * val_6;
        if(val_5 < 0)
        {
                return this.世七丑丁一丕丕业东();
        }
        
        float val_8 = this.attackRadius;
        val_8 = this.attackRadius * val_8;
        if(val_5 >= 0)
        {
                return false;
        }
        
        return this.世七丑丁一丕丕业东();
    }
    public override void Shot()
    {
        float val_13;
        float val_14;
        this.TryPlayHitSound(丕丕世且下一与丝与:  length);
        UnityEngine.Vector3 val_2 = this.shotPoint.position;
        UnityEngine.Quaternion val_4 = this.transform.rotation;
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.rocketPrefab, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
        UnityEngine.Vector3 val_7 = X22.position;
        val_5.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        TurretRocketControllerScene val_8 = val_5.GetComponent<TurretRocketControllerScene>();
        if(val_8 != null)
        {
                val_8.丌不且专丘丆丞丂丟 = this;
            val_8.splashRadius = 0f;
            val_8.fortObjectName = 1152921526057697296;
            val_8.SetTarget(丞下万上三丘上与专:  public TurretRocketControllerScene UnityEngine.GameObject::GetComponent<TurretRocketControllerScene>());
            val_13 = this.rocketStartSpeed;
            val_14 = this.rocketStartSpeed;
        }
        else
        {
                mem[48] = this;
            mem[72] = ???;
            mem[40] = 0;
            val_8.SetTarget(丞下万上三丘上与专:  X22);
            val_13 = this.rocketStartSpeed;
            val_14 = this.rocketStartSpeed;
        }
        
        val_8.丝丏丗丘丞丄丘丅且(丟丞一专丕三东丗一:  val_13);
        UnityEngine.Vector3 val_11 = val_8.transform.forward;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_14);
        val_5.GetComponent<UnityEngine.Rigidbody>().velocity = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
    }
    public FortGuardMob_RocketsLauncher()
    {
        this.rocketStartSpeed = 10f;
        this.attackAdditionalRadius = 7f;
        mem[1152921526057879552] = 1067030938;
        mem[1152921526057879736] = 1099431936;
        mem[1152921526057879760] = 1092616192;
        mem[1152921526057879768] = 1073741824;
        val_1 = new FortEquipObject();
    }

}
