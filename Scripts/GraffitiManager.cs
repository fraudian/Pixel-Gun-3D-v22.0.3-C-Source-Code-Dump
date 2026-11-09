using UnityEngine;
internal class GraffitiManager : PGBehaviour
{
    // Fields
    private static System.Action<bool> 与专丅万七下丅七三;
    private Graffiti <丞丁下上上丑丆丄丐>k__BackingField;
    private UnityEngine.Collider 业丗丄一专丗丁丑丏;
    private bool 下丟业东三丙万不丙;
    private UnityEngine.Coroutine 与东丘丗与丟丛三与;
    private float <且七丌丐丐且丛三丐>k__BackingField;
    private float 下丏丒万丒丏丕丄丈;
    private const float 与丄且丄丌丆万下业 = 0.74;
    private const float 上丘七丟丑丅丆丕专 = 0.05;
    
    // Properties
    internal static bool 上丏世丝丑业一丁丘 { get; }
    internal Graffiti 丕且下七丑丂丘丁丛 { get; set; }
    internal bool 丏世三丞丘丄丑丕三 { get; }
    internal float 丙一丑丏丁一且丒业 { get; set; }
    
    // Methods
    internal static void 丑丐丛丂丒专丙丌丈(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  GraffitiManager.上丘七丟丑丅丆丕专, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 世一丁丑丏三丌上丝(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  GraffitiManager.上丘七丟丑丅丆丕专, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static bool 业三与一东东丐七丛()
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
                return false;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 21)
        {
                return false;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 23)
        {
                return false;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 13)
        {
                return false;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 19)
        {
                return false;
        }
        
        var val_7 = (GameConnect.丑丌丛丈丅丅与不业() != 14) ? 1 : 0;
        return false;
    }
    internal Graffiti 上万丙丝且丒丅丕且()
    {
        return (Graffiti)this.<丞丁下上上丑丆丄丐>k__BackingField;
    }
    private void 丕丆且丏世且世七丙(Graffiti 丙业与丙丗丝不丈东)
    {
        this.<丞丁下上上丑丆丄丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        this.<且七丌丐丐且丛三丐>k__BackingField = 1f;
    }
    private void Update()
    {
        float val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if(this.下丟业东三丙万不丙 != true)
        {
                val_10 = 1f;
            if((this.<且七丌丐丐且丛三丐>k__BackingField) >= val_10)
        {
                this.下丟业东三丙万不丙 = true;
            val_11 = null;
            val_11 = null;
            GraffitiManager.上丘七丟丑丅丆丕专.Invoke(obj:  true);
        }
        
        }
        
        if((this.<丞丁下上上丑丆丄丐>k__BackingField) == 0)
        {
                return;
        }
        
        if(this.业丗丄一专丗丁丑丏.enabled != false)
        {
                if(this.业丗丄一专丗丁丑丏.gameObject.activeSelf != false)
        {
                UnityEngine.Vector3 val_6 = this.业丗丄一专丗丁丑丏.transform.position;
            val_10 = V9.16B;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.<丞丁下上上丑丆丄丐>k__BackingField.且东丑丂丝丟世七一, y = val_10, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) == false)
        {
                return;
        }
        
        }
        
        }
        
        this.丐东丞不丝丄丆专丒();
        float val_10 = this.<且七丌丐丐且丛三丐>k__BackingField;
        val_10 = val_10 * this.下丏丒万丒丏丕丄丈;
        if(val_10 < 0)
        {
                val_12 = null;
            val_12 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_13 = null;
            val_13 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_550 != 0)
        {
                val_14 = null;
            val_14 = null;
            typeof(Player_move_c).__il2cppRuntimeField_550.BlinkNoGraffiti(丌丒丝东丌下丕丁丅:  1);
        }
        
        }
        
        }
        
        if(this.与东丘丗与丟丛三与 != null)
        {
                this.StopCoroutine(routine:  this.与东丘丗与丟丛三与);
        }
        
        this.下丟业东三丙万不丙 = true;
        this.<且七丌丐丐且丛三丐>k__BackingField = 1f;
    }
    internal void 丑丗丟上三丈丞丐业(bool 丁丌且丏丟且七丈丅 = True)
    {
        if((丁丌且丏丟且七丈丅 != false) && (this.与东丘丗与丟丛三与 != null))
        {
                this.StopCoroutine(routine:  this.与东丘丗与丟丛三与);
        }
        
        this.丐东丞不丝丄丆专丒();
    }
    internal bool 专业七下丗丁丐丘丑()
    {
        float val_7;
        float val_8;
        var val_17;
        var val_18;
        float val_19;
        var val_20;
        float val_21;
        var val_22;
        var val_23;
        object val_24;
        val_17 = null;
        val_17 = null;
        val_18 = UnityEngine.Screen.width;
        val_19 = 0.5f;
        val_20 = (float)val_18 * val_19;
        val_21 = 0f;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_18 = UnityEngine.Screen.height;
            val_22 = null;
            val_22 = null;
            float val_17 = (float)val_18;
            float val_16 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_16 = 1f - val_16;
            val_16 = val_16 * val_17;
            val_21 = val_16 * val_19;
        }
        
        val_17 = ((float)UnityEngine.Screen.height * val_19) + val_21;
        UnityEngine.Ray val_6 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if((丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.丕丆且上丘下东丁丆(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, m_Direction = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}}, 丟丙丒一丑丈丙丂丛: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丛业上丄丏丛丞丆丕:  40f)) == false)
        {
            goto label_9;
        }
        
        val_20 = 40f;
        val_19 = 0f;
        val_23 = null;
        val_23 = null;
        UnityEngine.Vector3 val_11 = 丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 40f, y = val_8, z = 0f}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        float val_13 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        if(val_13 <= 20f)
        {
            goto label_17;
        }
        
        val_24 = "Нельзя поставить граффити - слишком далеко";
        goto label_33;
        label_9:
        val_24 = "Нельзя поставить граффити - не найдена поверхность";
        label_33:
        UnityEngine.Debug.Log(message:  val_24);
        return false;
        label_17:
        if((0.丟丅丄丅丘丟丄三丌(一丁丙业丒东丞丄丆:  new UnityEngine.Vector3() {x = val_13, y = 20f, z = val_12.z}, 丗丌丒丘一丟下七上:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, m_Direction = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}}, 丄下上丈丛丁丅丆丏:  new UnityEngine.Vector3() {x = val_13, y = 20f, z = val_12.z})) == false)
        {
            goto label_33;
        }
        
        if(0 == 0)
        {
            goto label_33;
        }
        
        this.丐丕一丏丑与上丙丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_13, y = 20f, z = val_12.z}, 丏与三业丈丕专且丑:  new UnityEngine.Vector3() {x = val_13, y = 20f, z = val_12.z}, 世专下丈万丙丝丕万:  0);
        return false;
    }
    internal bool 丞丒丝丂业三上三丒()
    {
        return (bool)this.下丟业东三丙万不丙;
    }
    private void 丐丕一丏丑与上丙丘(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 丏与三业丈丕专且丑, UnityEngine.Collider 世专下丈万丙丝丕万)
    {
        float val_27;
        float val_28;
        var val_29;
        float val_30;
        string val_31;
        var val_32;
        float val_33;
        float val_34;
        float val_35;
        val_27 = 丏与三业丈丕专且丑.y;
        val_28 = 业丒丝丗与丐丛丟丏.x;
        this.丐东丞不丝丄丆专丒();
        val_29 = null;
        val_29 = null;
        UnityEngine.Vector3 val_2 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, planeNormal:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_27, z = 丏与三业丈丕专且丑.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_27, z = 丏与三业丈丕专且丑.z}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_27, z = 丏与三业丈丕专且丑.z}));
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, upwards:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_27, z = 丏与三业丈丕专且丑.z});
        val_30 = val_7.y;
        val_31 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().不丄丟东万丘丌丟丛();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_31)) == true)
        {
                return;
        }
        
        PGCompany.GraffitiSystem.七丄上丑七丐丟与东 val_27 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世();
        int val_12 = val_27.且丘丁丗专丞世丂专();
        val_32 = null;
        val_27 = (val_12 < 0) ? 240 : (val_12);
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_27, z = 丏与三业丈丕专且丑.z}, d:  0.032f);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_27 = val_15.z;
            val_33 = val_15.x;
            val_34 = val_15.y;
            val_35 = val_27;
            UnityEngine.GameObject val_16 = 丅丒丗丑丒丙丛不丆.业丕丝丝万丕丛下三(丟丈一下东业一丝丆:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "GraffitiPrefabs", 丌丗丏丏丛东专丁且:  val_31), 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_33, y = val_34, z = val_35}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_7.x, y = val_30, z = val_7.z, w = val_7.w}, 不丝丄丒丌丐一一与:  0);
        }
        else
        {
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_27, z = 丏与三业丈丕专且丑.z}, d:  0.032f);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            val_27 = val_20.z;
            val_33 = val_20.x;
            val_34 = val_20.y;
            val_35 = val_27;
        }
        
        this.<丞丁下上上丑丆丄丐>k__BackingField = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "GraffitiPrefabs", 丌丗丏丏丛东专丁且:  val_31)), position:  new UnityEngine.Vector3() {x = val_33, y = val_34, z = val_35}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_30, z = val_7.z, w = val_7.w}).GetComponent<Graffiti>();
        val_22.丟丄丕丝丝上三一丒 = val_27;
        val_31 = 世专下丈万丙丝丕万.transform;
        UnityEngine.Vector3 val_24 = val_31.position;
        val_30 = val_24.x;
        val_28 = val_24.z;
        this.<丞丁下上上丑丆丄丐>k__BackingField.且东丑丂丝丟世七一 = val_24;
        mem2[0] = val_24.y;
        mem2[0] = val_28;
        this.业丗丄一专丗丁丑丏 = 世专下丈万丙丝丕万;
        if(this.与东丘丗与丟丛三与 != null)
        {
                this.StopCoroutine(routine:  this.与东丘丗与丟丛三与);
        }
        
        this.与东丘丗与丟丛三与 = this.StartCoroutine(routine:  this.丅丟丁丟丅丌丌丂丑());
    }
    internal float 丛万下专丝丑丐世七()
    {
        return (float)this.<且七丌丐丐且丛三丐>k__BackingField;
    }
    private void 丑七下丑七丌下丆三(float 丙业与丙丗丝不丈东)
    {
        this.<且七丌丐丐且丛三丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private System.Collections.IEnumerator 丅丟丁丟丅丌丌丂丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GraffitiManager.丙丈丌不丝万丏丒七();
    }
    internal void 不三下一上且丈上万(float 专万三下丈丁世丅东)
    {
        this.下丏丒万丒丏丕丄丈 = 专万三下丈丁世丅东;
    }
    private bool 丕丆且上丘下东丁丆(UnityEngine.Ray 不万专丐世丒丆丆下, out UnityEngine.RaycastHit 丟丙丒一丑丈丙丂丛, float 丛业上丄丏丛丞丆丕)
    {
        object val_23;
        UnityEngine.Ray val_24;
        var val_26;
        var val_27;
        var val_28;
        GraffitiManager.丒丂万丒丂一上丞一 val_1 = null;
        val_23 = val_1;
        val_1 = new GraffitiManager.丒丂万丒丂一上丞一();
        if(val_23 != null)
        {
                val_24 = (GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下;
            mem[1152921540181196928] = 不万专丐世丒丆丆下.m_Direction.y;
            .不万专丐世丒丆丆下 = 不万专丐世丒丆丆下.m_Origin.x;
            丟丙丒一丑丈丙丂丛.m_Collider = 0;
            丟丙丒一丑丈丙丂丛.m_UV.x = 0f;
            丟丙丒一丑丈丙丂丛.m_UV.y = 0f;
            丟丙丒一丑丈丙丂丛.m_Point.x = 0f;
            丟丙丒一丑丈丙丂丛.m_Point.y = 0f;
            丟丙丒一丑丈丙丂丛.m_Point.z = 0f;
            丟丙丒一丑丈丙丂丛.m_Normal.x = 0f;
            丟丙丒一丑丈丙丂丛.m_Normal.y = 0f;
            丟丙丒一丑丈丙丂丛.m_Normal.z = 0f;
            丟丙丒一丑丈丙丂丛.m_FaceID = 0;
            丟丙丒一丑丈丙丂丛.m_Distance = 0f;
        }
        else
        {
                val_24 = (GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下;
            mem[1152921540181196928] = 不万专丐世丒丆丆下.m_Direction.y;
            .不万专丐世丒丆丆下 = 不万专丐世丒丆丆下.m_Origin.x;
            丟丙丒一丑丈丙丂丛.m_Collider = 0;
            丟丙丒一丑丈丙丂丛.m_UV.x = 0f;
            丟丙丒一丑丈丙丂丛.m_UV.y = 0f;
            丟丙丒一丑丈丙丂丛.m_Point.x = 0f;
            丟丙丒一丑丈丙丂丛.m_Point.y = 0f;
            丟丙丒一丑丈丙丂丛.m_Point.z = 0f;
            丟丙丒一丑丈丙丂丛.m_Normal.x = 0f;
            丟丙丒一丑丈丙丂丛.m_Normal.y = 0f;
            丟丙丒一丑丈丙丂丛.m_Normal.z = 0f;
            丟丙丒一丑丈丙丂丛.m_FaceID = 0;
            丟丙丒一丑丈丙丂丛.m_Distance = 0f;
        }
        
        UnityEngine.RaycastHit[] val_3 = UnityEngine.Physics.RaycastAll(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = (GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下.m_Origin, y = (GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下.m_Origin, z = (GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下.m_Origin}, m_Direction = new UnityEngine.Vector3() {x = (GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下.m_Origin, y = mem[(GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下 + 16], z = mem[(GraffitiManager.丒丂万丒丂一上丞一)[1152921540181196896].不万专丐世丒丆丆下 + 16]}}, maxDistance:  丛业上丄丏丛丞丆丕, layerMask:  Portal.丗专东丂上丄下丝丄());
        if(val_3 == null)
        {
                return (bool)val_26;
        }
        
        if(val_3.Length == 0)
        {
            goto label_4;
        }
        
        System.Array.Sort<UnityEngine.RaycastHit>(array:  val_3, comparison:  new System.Comparison<UnityEngine.RaycastHit>(object:  val_1, method:  System.Int32 GraffitiManager.丒丂万丒丂一上丞一::丈下上上万三世万丗(UnityEngine.RaycastHit 丁下丗七丟丗丞丁丐, UnityEngine.RaycastHit 专丟丗丗丈丅丙七三)));
        if(val_3.Length < 1)
        {
            goto label_37;
        }
        
        val_27 = 0;
        val_28 = 0;
        label_36:
        val_23 = (val_3 + (0 * 44)) + 32;
        if(val_23.gameObject.transform.parent != 0)
        {
                if((val_23.gameObject.transform.parent.GetComponent<PhotonView>()) != 0)
        {
            goto label_28;
        }
        
        }
        
        if(((val_23.transform.GetComponent<PhotonView>()) != 0) || (val_23.targetValue >= 0))
        {
            goto label_28;
        }
        
        if((val_23.gameObject.GetComponent<DeadCollider>()) != 0)
        {
            goto label_34;
        }
        
        float val_22 = val_23.targetValue;
        val_28 = val_27;
        label_28:
        val_27 = val_27 + 1;
        if(val_27 < val_3.Length)
        {
            goto label_36;
        }
        
        label_34:
        if(val_28 != 1)
        {
                val_23 = 0;
            var val_23 = val_3 + (val_23 * 44);
            丟丙丒一丑丈丙丂丛.m_Collider = (val_23 * 44) + val_3 + 72;
            丟丙丒一丑丈丙丂丛.m_UV.x = (val_23 * 44) + val_3 + 64;
            丟丙丒一丑丈丙丂丛.m_Point.x = (val_23 * 44) + val_3 + 32;
            丟丙丒一丑丈丙丂丛.m_Normal.y = (val_23 * 44) + val_3 + 32 + 16;
        }
        
        label_37:
        var val_24 = (val_3.Length != 0) ? 1 : 0;
        return (bool)val_26;
        label_4:
        val_26 = 0;
        return (bool)val_26;
    }
    private bool 丟丅丄丅丘丟丄三丌(UnityEngine.Vector3 一丁丙业丒东丞丄丆, UnityEngine.Ray 丗丌丒丘一丟下七上, UnityEngine.Vector3 丄下上丈丛丁丅丆丏)
    {
        float val_60;
        float val_61;
        float val_62;
        float val_63;
        UnityEngine.Vector3 val_2 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, planeNormal:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = 一丁丙业丒东丞丄丆.y, z = 一丁丙业丒东丞丄丆.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = 一丁丙业丒东丞丄丆.y, z = 一丁丙业丒东丞丄丆.z}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = 一丁丙业丒东丞丄丆.y, z = 一丁丙业丒东丞丄丆.z}));
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, upwards:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = 一丁丙业丒东丞丄丆.y, z = 一丁丙业丒东丞丄丆.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.74f);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丄下上丈丛丁丅丆丏.x, y = 丄下上丈丛丁丅丆丏.y, z = 丄下上丈丛丁丅丆丏.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_13 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  0.74f);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_17 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  0.74f);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丄下上丈丛丁丅丆丏.x, y = 丄下上丈丛丁丅丆丏.y, z = 丄下上丈丛丁丅丆丏.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_21 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  0.74f);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_25 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  0.74f);
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丄下上丈丛丁丅丆丏.x, y = 丄下上丈丛丁丅丆丏.y, z = 丄下上丈丛丁丅丆丏.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_29 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_60 = 0.74f;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  val_60);
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_33 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  val_60);
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丄下上丈丛丁丅丆丏.x, y = 丄下上丈丛丁丅丆丏.y, z = 丄下上丈丛丁丅丆丏.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_37 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  val_60);
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
        val_61 = val_39.x;
        val_62 = val_39.z;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        val_63 = val_39.y;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_61, y = val_39.y, z = val_62}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        if((0.丕丆且上丘下东丁丆(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, 丟丙丒一丑丈丙丂丛: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丛业上丄丏丛丞丆丕:  40f)) == false)
        {
                return false;
        }
        
        val_61 = 40f;
        val_63 = 40f;
        val_60 = 一丁丙业丒东丞丄丆.z;
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 40f, y = 一丁丙业丒东丞丄丆.y, z = 一丁丙业丒东丞丄丆.z}, b:  new UnityEngine.Vector3() {x = 40f, y = 一丁丙业丒东丞丄丆.y, z = val_60});
        float val_46 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
        val_62 = 0.1f;
        if(val_46 > val_62)
        {
                return false;
        }
        
        val_61 = val_46;
        val_63 = val_45.z;
        if((0.丕丆且上丘下东丁丆(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, 丟丙丒一丑丈丙丂丛: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丛业上丄丏丛丞丆丕:  40f)) == false)
        {
                return false;
        }
        
        val_63 = 40f;
        val_60 = val_45.z;
        val_61 = val_45.y;
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 40f, y = val_45.y, z = val_60}, b:  new UnityEngine.Vector3() {x = 40f, y = val_61, z = val_45.z});
        float val_49 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
        if(val_49 > val_62)
        {
                return false;
        }
        
        val_61 = val_49;
        val_63 = val_48.z;
        if((0.丕丆且上丘下东丁丆(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, 丟丙丒一丑丈丙丂丛: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丛业上丄丏丛丞丆丕:  40f)) == false)
        {
                return false;
        }
        
        val_63 = val_48.y;
        val_61 = 40f;
        val_60 = val_48.y;
        UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 40f, y = val_63, z = val_48.z}, b:  new UnityEngine.Vector3() {x = 40f, y = val_60, z = val_48.z});
        float val_52 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z});
        if(val_52 > val_62)
        {
                return false;
        }
        
        if((0.丕丆且上丘下东丁丆(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, 丟丙丒一丑丈丙丂丛: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丛业上丄丏丛丞丆丕:  40f)) == false)
        {
                return false;
        }
        
        val_63 = val_51.y;
        val_61 = 40f;
        val_60 = val_51.y;
        UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 40f, y = val_63, z = val_51.z}, b:  new UnityEngine.Vector3() {x = 40f, y = val_60, z = val_51.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z})) > val_62)
        {
                return false;
        }
        
        val_63 = 一丁丙业丒东丞丄丆.y;
        UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = val_63, z = 一丁丙业丒东丞丄丆.z}, b:  new UnityEngine.Vector3() {x = val_61, y = val_45.y, z = val_63});
        val_61 = val_61;
        val_62 = val_63;
        val_60 = val_51.y;
        if(val_56.x >= 0)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = val_63, z = 一丁丙业丒东丞丄丆.z}, b:  new UnityEngine.Vector3() {x = val_61, y = val_48.y, z = val_62});
        if(val_57.x >= 0)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = val_63, z = 一丁丙业丒东丞丄丆.z}, b:  new UnityEngine.Vector3() {x = val_52, y = val_60, z = val_51.z});
        if(val_58.x < 0)
        {
                val_61 = val_58.x;
            val_62 = val_58.z;
            UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 一丁丙业丒东丞丄丆.x, y = val_63, z = 一丁丙业丒东丞丄丆.z}, b:  new UnityEngine.Vector3() {x = val_61, y = val_58.y, z = val_62});
            if(val_59.x < 0)
        {
                return false;
        }
        
        }
        
        return false;
    }
    private void 丐东丞不丝丄丆专丒()
    {
        var val_3;
        if((this.<丞丁下上上丑丆丄丐>k__BackingField) == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        UnityEngine.GameObject val_2 = this.<丞丁下上上丑丆丄丐>k__BackingField.gameObject;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  val_2);
        }
        else
        {
                UnityEngine.Object.Destroy(obj:  val_2);
        }
        
        this.<丞丁下上上丑丆丄丐>k__BackingField = 0;
        mem[1152921540181503696] = 0;
    }
    public GraffitiManager()
    {
        this.下丟业东三丙万不丙 = true;
        this.下丏丒万丒丏丕丄丈 = 15f;
    }
    private static GraffitiManager()
    {
        null = null;
        GraffitiManager.上丘七丟丑丅丆丕专 = new System.Action<System.Boolean>(object:  GraffitiManager.<>c.<>9, method:  System.Void GraffitiManager.<>c::丁丒丐且丏上丛丙专(bool 世丗丈丗丂业丙一不));
    }

}
