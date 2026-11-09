using UnityEngine;
internal sealed class TurretControllerScene_StreamLaser : TurretControllerScene_Tower
{
    // Fields
    private UnityEngine.AudioClip shotClip;
    private UnityEngine.ParticleSystem[] gunFlashes;
    private string rayName;
    private float _timeReload;
    private float _timeActivateShootTurret;
    private System.Collections.Generic.List<UnityEngine.Transform> _listPointFromShoot;
    private TurretControllerScene_StreamLaser.万七丏丂一且丞万三 丒丈万三与七丕丄下;
    private System.Collections.Generic.List<UnityEngine.LineRenderer> 丑丞丏丞丄丗专丂丄;
    private System.Collections.Generic.List<RayAndExplosionsStackItem> 七专丑丕丒万与世丟;
    private double 丌丂丏且丛丌丞一丛;
    private float 丅丄世一丂丙七丁业;
    private float 七丐不丝丂一一世丂;
    
    // Methods
    protected override void Awake()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        this.Awake();
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void TurretControllerScene_StreamLaser::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    protected override void 丟丞丆上上丁丅下丐()
    {
        var val_10;
        丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137129984);
        var val_10 = 0;
        val_10 = val_10 + 1;
        if(val_1.IsDead() == true)
        {
                return;
        }
        
        PhotonView val_4 = this.丕专与下丁不丆世业(丂丈丙且丈丗三丆丕:  val_1);
        if(val_4 != 0)
        {
                val_10 = val_4.isMine;
        }
        else
        {
                val_10 = 0;
        }
        
        if(1152921504848912384 == 0)
        {
                return;
        }
        
        if((val_10 & 1) == 0)
        {
                return;
        }
        
        if(this.丄上上不丛万丝不一() == false)
        {
                return;
        }
        
        万七丏丂一且丞万三 val_11 = this.丒丈万三与七丕丄下;
        val_11 = val_11 & 4294967294;
        if(val_11 == 2)
        {
                return;
        }
        
        val_10.SendShotRPC(上世万世丐丄上丑丆:  this, 一万与三东丞丈丙丁:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        this.丙丘丘丁丒丒丆丂下();
    }
    public override void AttackTargetsRPC(double 七不丅不丛不丁丁上)
    {
        double val_26;
        float val_27;
        float val_28;
        val_26 = 七不丅不丛不丁丁上;
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() <= 0f)
        {
                return;
        }
        
        this.丌丂丏且丛丌丞一丛 = val_26;
        val_27 = this._timeActivateShootTurret;
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_2 = val_2 - val_26;
        float val_3 = System.Convert.ToSingle(value:  val_2);
        val_3 = val_27 - val_3;
        this.丅丄世一丂丙七丁业 = val_3;
        if(val_3 <= 0f)
        {
            goto label_8;
        }
        
        this.七丐不丝丂一一世丂 = 0f;
        UnityEngine.Vector3 val_4 = forward;
        val_27 = val_4.z;
        UnityEngine.Vector3 val_5 = position;
        val_26 = 100f;
        if((((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_26, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())) == false) || (this.gunFlashes == null)) || (this.gunFlashes.Length == 0))
        {
            goto label_62;
        }
        
        List.Enumerator<T> val_8 = this._listPointFromShoot.GetEnumerator();
        label_40:
        if((1663852448 & 1) == 0)
        {
            goto label_15;
        }
        
        string val_9 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_10 = val_9.position;
        UnityEngine.Vector3 val_11 = val_9.forward;
        val_28 = val_26;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  (float)Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())) != false)
        {
                val_28 = 0.targetValue;
        }
        
        UnityEngine.Vector3 val_16 = val_9.transform.position;
        UnityEngine.Vector3 val_17 = val_9.forward;
        UnityEngine.GameObject val_18 = WeaponManager.上不丝专丏丝丙丅丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 丗丟东丗丕世丛丌丗:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, 丛丄万三丂东丙丑东:  this.rayName, 不丅丛专丘丅专丘丕:  val_28);
        val_18.transform.SetParent(p:  val_9.transform);
        RayAndExplosionsStackItem val_21 = val_18.GetComponent<RayAndExplosionsStackItem>();
        if(val_21 != 0)
        {
                val_21.timeDeactivate = this.丅丄世一丂丙七丁业;
        }
        
        val_21.丌丄丄丄丗丐丂丂三();
        this.七专丑丕丒万与世丟.Add(item:  val_21);
        UnityEngine.LineRenderer val_23 = val_18.GetComponentInChildren<UnityEngine.LineRenderer>();
        if(val_23 == 0)
        {
            goto label_40;
        }
        
        this.丑丞丏丞丄丗专丂丄.Add(item:  val_23);
        goto label_40;
        label_8:
        this.丒丐丌丒万上丙丅丌();
        return;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_62:
        this.丙丘丘丁丒丒丆丂下();
    }
    protected override void Update()
    {
        this.Update();
        if(this.isActive == false)
        {
                return;
        }
        
        if(this.丒丈万三与七丕丄下 == 3)
        {
            goto label_2;
        }
        
        if(this.丒丈万三与七丕丄下 != 2)
        {
            goto label_5;
        }
        
        this.丈丞丗三丛业不丒丙();
        goto label_5;
        label_2:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丅丄世一丂丙七丁业 - val_2;
        this.丅丄世一丂丙七丁业 = val_2;
        if(val_2 <= 0f)
        {
                this.丒丈万三与七丕丄下 = 1;
        }
        
        label_5:
        丅丙上七上一丐不下 val_3 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137129984);
        if(this.丒丈万三与七丕丄下 != 2)
        {
                return;
        }
        
        if((val_3 == null) || (X21 == 0))
        {
            goto label_22;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        if(val_3.IsDead() == false)
        {
            goto label_17;
        }
        
        label_22:
        this.丒丐丌丒万上丙丅丌();
        return;
        label_17:
        var val_7 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
    }
    private void 丈丞丗三丛业不丒丙()
    {
        float val_17;
        float val_18;
        var val_19;
        val_17 = this.丅丄世一丂丙七丁业;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_17 - val_1;
        this.丅丄世一丂丙七丁业 = val_1;
        if(val_1 <= 0f)
        {
            goto label_1;
        }
        
        val_17 = this.七丐不丝丂一一世丂;
        val_18 = val_17 - UnityEngine.Time.deltaTime;
        this.七丐不丝丂一一世丂 = val_18;
        if(val_18 > 0f)
        {
                return;
        }
        
        val_17 = 100f;
        val_19 = 0;
        goto label_3;
        label_14:
        UnityEngine.Vector3 val_4 = this._listPointFromShoot.Item[0].position;
        UnityEngine.Vector3 val_6 = this._listPointFromShoot.Item[0].forward;
        val_18 = val_17;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_17, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏())) != false)
        {
                丅丙上七上一丐不下 val_9 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
            if(val_9 != null)
        {
                if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_9)) != false)
        {
                bool val_11 = this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  val_9);
        }
        
        }
        
            float val_13 = 0.targetValue;
            val_18 = 0f;
            this.丑丞丏丞丄丗专丂丄.Item[0].SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_18, y = 0f, z = 0f});
        }
        
        val_19 = 1;
        label_3:
        if(val_19 < this._listPointFromShoot.Count)
        {
            goto label_14;
        }
        
        this.七丐不丝丂一一世丂 = this.丐丕世丂上丐丑东丂();
        return;
        label_1:
        this.丒丐丌丒万上丙丅丌();
    }
    private void 且丑世专丐丑不下丏()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丅丄世一丂丙七丁业 - val_1;
        this.丅丄世一丂丙七丁业 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.丒丈万三与七丕丄下 = 1;
    }
    private void 丙丘丘丁丒丒丆丂下()
    {
        var val_3;
        this.丒丈万三与七丕丄下 = 2;
        val_3 = 0;
        goto label_1;
        label_18:
        if(this.gunFlashes[0] != 0)
        {
                this.gunFlashes[0].enableEmission = true;
            this.gunFlashes[0].Play();
            this.gunFlashes[0].gameObject.SetActive(value:  true);
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < this.gunFlashes.Length)
        {
            goto label_18;
        }
    
    }
    private void 丒丐丌丒万上丙丅丌()
    {
        var val_3;
        this.丒丈万三与七丕丄下 = 3;
        this.丅丄世一丂丙七丁业 = this._timeReload;
        val_3 = 0;
        goto label_1;
        label_15:
        if(this.gunFlashes[0] != 0)
        {
                this.gunFlashes[0].enableEmission = false;
            this.gunFlashes[0].gameObject.SetActive(value:  false);
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < this.gunFlashes.Length)
        {
            goto label_15;
        }
        
        this.上丏丁万世东丘上下();
    }
    private void 丆丝丘丅丌七丙东丟()
    {
        this.丒丈万三与七丕丄下 = 1;
    }
    private void 上丏丁万世东丘上下()
    {
        List.Enumerator<T> val_1 = this.七专丑丕丒万与世丟.GetEnumerator();
        label_4:
        if((1665564408 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().Deactivate();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.七专丑丕丒万与世丟.Clear();
    }
    public override void StartDeactivate(bool 一丆丌丝专丂丛丙上)
    {
        this.StartDeactivate(一丆丌丝专丂丛丙上:  一丆丌丝专丂丛丙上);
        this.上丏丁万世东丘上下();
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        double val_1 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_1 = val_1 - this.丌丂丏且丛丌丞一丛;
        if(val_1 <= 0f)
        {
                return;
        }
        
        SendShotRPC(上世万世丐丄上丑丆:  this, 一万与三东丞丈丙丁:  this.丌丂丏且丛丌丞一丛, 丞下万上三丘上与专:  专丞上七七且丝七丗);
    }
    public TurretControllerScene_StreamLaser()
    {
        this._timeActivateShootTurret = 5f;
        this._listPointFromShoot = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.丑丞丏丞丄丗专丂丄 = new System.Collections.Generic.List<UnityEngine.LineRenderer>();
        this.七专丑丕丒万与世丟 = new System.Collections.Generic.List<RayAndExplosionsStackItem>();
        mem[1152921540632533192] = ;
        mem[1152921540632533208] = ;
        mem[1152921540632533228] = 1110704128;
        1152921540632533192 = new TurretControllerScene();
    }

}
