using UnityEngine;
public class BallisticBullet : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject[] tracers;
    private int 七不丗丞丗丘业一丘;
    private static readonly float 丁七三丛丐丛丌东万;
    private bool 丘丄丆不丛丗上三上;
    private float 与丕丌丒丗丄丘丙东;
    private float 与与专丟丗东丌与丆;
    private WeaponSounds 丘丙不丄丕七万三丂;
    private float 丞丈专下丈专业三丞;
    private UnityEngine.Coroutine 丆丟业东丈不三丟丗;
    private UnityEngine.Vector3 丑专下专专一丞一丑;
    private bool 专丄丆丌丝丞丙丛丅;
    private float 丝与丅丕专业丁上丂;
    private UnityEngine.Vector3 万丛丞丂丘且三丈丈;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    
    // Properties
    internal bool 丅业东万丌丕上丌丄 { get; set; }
    private UnityEngine.Camera 丐丝丁东丂世丆东七 { get; }
    private float 丕下丐与丂丝丟七万 { get; }
    private float 丒丂专丁丗丐与不丌 { get; }
    private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    
    // Methods
    internal bool 丈丐丞丐上丑且丕万()
    {
        if(this.丘丄丆不丛丗上三上 == false)
        {
                return (bool)(this.丆丟业东丈不三丟丗 != 0) ? 1 : 0;
        }
        
        return true;
    }
    private void 七丝丆丂丞丙丆丟三(bool 丙业与丙丗丝不丈东)
    {
        if(this.丘丄丆不丛丗上三上 != false)
        {
                if(丙业与丙丗丝不丈东 == true)
        {
                return;
        }
        
        }
        
        if(丙业与丙丗丝不丈东 != false)
        {
                this.gameObject.SetActive(value:  true);
        }
        else
        {
                if(this.丘丄丆不丛丗上三上 != false)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丆丟业东丈不三丟丗 = this.StartCoroutine(routine:  this.东与丁丂丑下下丗丙().GetEnumerator());
        }
        
        }
        
        this.丘丄丆不丛丗上三上 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        goto label_1;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tracers[0].gameObject, 丏业丟一东丂东丘丛:  false);
        0 = 1;
        this.七不丗丞丗丘业一丘 = 0;
        label_1:
        if(0 < this.tracers.Length)
        {
            goto label_7;
        }
    
    }
    private UnityEngine.Camera 丛丑万丒丝丗不丁丘()
    {
        null = null;
        return (UnityEngine.Camera)丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
    }
    private float 世丗下丟丂与上下丙()
    {
        var val_7;
        float val_8;
        val_7 = this;
        if(GameConnect.万七丄丛丈丟专一丑() != false)
        {
                return val_8;
        }
        
        if(this.丘丙不丄丕七万三丂.丌上丗丕不七世丅丁() != null)
        {
                if(this.丘丙不丄丕七万三丂.丌上丗丕不七世丅丁().丒万丕七专不丏丞丌() == 4)
        {
                val_7 = PlayerCoreSettingsStorager.dynamicSettings;
            val_8 = val_5.丘丈丈丐丅上一丅丁;
            return val_8;
        }
        
        }
        
        val_7 = PlayerCoreSettingsStorager.dynamicSettings;
        val_8 = val_6.丅下丌世丏丁丗丂万;
        return val_8;
    }
    private float 与东丟丅丞业丙丗下()
    {
        var val_7;
        float val_8;
        val_7 = this;
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return val_8;
        }
        
        if(this.丘丙不丄丕七万三丂.丌上丗丕不七世丅丁() != null)
        {
                if(this.丘丙不丄丕七万三丂.丌上丗丕不七世丅丁().丒万丕七专不丏丞丌() == 4)
        {
                val_7 = PlayerCoreSettingsStorager.dynamicSettings;
            val_8 = val_5.上丟丄且上丄丞丝丏;
            return val_8;
        }
        
        }
        
        val_7 = PlayerCoreSettingsStorager.dynamicSettings;
        val_8 = val_6.丄丁不专丞丟一世丙;
        return val_8;
    }
    public void StartBullet(WeaponSounds 丌丝下丄业一丄不三, UnityEngine.Vector3 丈万丏丈上丑不丅上, UnityEngine.Vector3 丁丒东丟丙一丄下丝, UnityEngine.Vector3 东世与专丟丁一丒丛, bool 三丄不丛不丁丑丂丆, UnityEngine.RaycastHit 丂七丑世丏丐丅不丌)
    {
        float val_11;
        float val_21;
        var val_44;
        var val_45;
        float val_46;
        float val_47;
        var val_48;
        var val_49;
        float val_53;
        float val_54;
        float val_55;
        var val_56;
        float val_57;
        float val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_62;
        float val_63;
        var val_64;
        val_45 = 三丄不丛不丁丑丂丆;
        val_46 = 丈万丏丈上丑不丅上.z;
        val_47 = 丈万丏丈上丑不丅上.y;
        if(丌丝下丄业一丄不三 == 0)
        {
                return;
        }
        
        this.丘丙不丄丕七万三丂 = 丌丝下丄业一丄不三;
        val_48 = null;
        val_48 = null;
        this.专丄丆丌丝丞丙丛丅 = false;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丘丂三东丁且丙世七()) == false)
        {
            goto label_10;
        }
        
        val_49 = null;
        val_49 = null;
        val_44 = transform;
        if(val_44 == null)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_4 = val_44.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = val_47, z = val_46});
        val_53 = val_4.x;
        val_54 = 丈万丏丈上丑不丅上.x;
        val_55 = val_4.y;
        goto label_16;
        label_10:
        val_56 = null;
        val_56 = null;
        UnityEngine.Transform val_5 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform;
        UnityEngine.Vector3 val_6 = val_5.position;
        this.专丄丆丌丝丞丙丛丅 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, end:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = val_47, z = val_46}, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗());
        UnityEngine.Vector3 val_10 = val_5.position;
        UnityEngine.Vector3 val_12 = val_5.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = val_47, z = val_46});
        UnityEngine.Camera val_13 = val_5.丛丑万丒丝丗不丁丘();
        UnityEngine.Ray val_14 = val_13.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 东世与专丟丁一丒丛.x, y = val_11, z = 东世与专丟丁一丒丛.y});
        val_44 = val_13.丛丑万丒丝丗不丁丘();
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        UnityEngine.Ray val_19 = val_44.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        float val_44 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_21, y = val_18.y, z = val_18.z}, to:  new UnityEngine.Vector3() {x = val_21, y = val_18.y, z = val_18.z});
        float val_43 = 0.01745329f;
        val_57 = val_47;
        val_43 = val_43 / val_44;
        val_44 = val_12.z * val_43;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_43, y = val_18.y, z = val_18.z}, d:  val_44);
        val_59 = val_10.y;
        val_58 = val_10.x;
        val_60 = val_10.z;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_58, y = val_59, z = val_60}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        val_54 = val_24.x;
        val_61 = val_24.y;
        val_62 = val_24.z;
        goto label_31;
        label_15:
        UnityEngine.Vector3 val_25 = 0.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = val_47, z = val_46});
        val_53 = val_25.x;
        val_54 = 丈万丏丈上丑不丅上.x;
        val_55 = val_25.y;
        label_16:
        val_60 = 0f;
        val_58 = val_53;
        val_59 = val_55;
        UnityEngine.Vector3 val_26 = val_44.TransformPoint(position:  new UnityEngine.Vector3() {x = val_58, y = val_59, z = val_60});
        val_57 = val_47;
        val_61 = val_47;
        val_62 = val_46;
        label_31:
        UnityEngine.Color val_27 = UnityEngine.Color.green;
        val_63 = val_26.x;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_63, y = val_26.y, z = val_26.z}, end:  new UnityEngine.Vector3() {x = val_54, y = val_61, z = val_62}, color:  new UnityEngine.Color() {r = val_27.r, g = val_27.b, b = 1f}, duration:  丁丒东丟丙一丄下丝.y);
        val_46 = 丁丒东丟丙一丄下丝.z;
        val_47 = 丁丒东丟丙一丄下丝.y;
        if((this.丟七丕丌丈上丒丆丘(东丐丄丏丝丆丐专上:  new UnityEngine.Vector3() {x = val_63, y = val_26.y, z = val_26.z}, 上丕一不世七世丑上:  new UnityEngine.Vector3() {x = val_54, y = val_61, z = val_62})) == true)
        {
                return;
        }
        
        float val_30 = this.世丗下丟丂与上下丙();
        val_30 = 丌丝下丄业一丄不三.丕丟丕业丑三下专丑() / val_30;
        this.与与专丟丗东丌与丆 = val_30;
        this.与丕丌丒丗丄丘丙东 = UnityEngine.Time.realtimeSinceStartup;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = val_57, z = val_46};
        val_44 = 1152921504838316032;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丁丒东丟丙一丄下丝.x, y = val_47, z = val_46}, b:  new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = val_57, z = val_46});
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  this.世丗下丟丂与上下丙());
        val_63 = val_35.z;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_63}, d:  UnityEngine.Time.fixedDeltaTime);
        this.万丛丞丂丘且三丈丈 = val_37;
        mem[1152921536292963312] = val_37.y;
        mem[1152921536292963316] = val_37.z;
        var val_38 = (丌丝下丄业一丄不三.typeTracer >= 0) ? 丌丝下丄业一丄不三.typeTracer : (!0);
        int val_45 = this.tracers.Length;
        val_62 = 丈万丏丈上丑不丅上.x;
        val_45 = val_45 - 1;
        int val_39 = (val_38 > val_45) ? 0 : (val_38);
        if(val_39 != this.七不丗丞丗丘业一丘)
        {
                if((this.七不丗丞丗丘业一丘 & 2147483648) == 0)
        {
                this.tracers[this.七不丗丞丗丘业一丘].gameObject.SetActive(value:  false);
        }
        
            this.七不丗丞丗丘业一丘 = val_39;
            if((val_39 & 2147483648) == 0)
        {
                this.tracers[(long)val_39].gameObject.SetActive(value:  true);
        }
        
        }
        
        this.七丝丆丂丞丙丆丟三(丙业与丙丗丝不丈东:  true);
        if(val_45 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丁丒东丟丙一丄下丝.x, y = val_47, z = val_46}, b:  new UnityEngine.Vector3() {x = val_62, y = val_57, z = val_46});
        val_45 = 1152921505133363200;
        val_62 = val_42.x;
        val_64 = null;
        val_64 = null;
        float val_48 = BallisticBullet.丁七三丛丐丛丌东万;
        val_48 = val_48 * val_48;
        if(val_62 >= 0)
        {
                return;
        }
        
        this.且与丙丞东丘丛丂丘(丁丂丝不丟丛丟一丂:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 丂七丑世丏丐丅不丌.m_Point.x}, m_Normal = new UnityEngine.Vector3() {y = 丂七丑世丏丐丅不丌.m_Normal.y}, m_Distance = 丂七丑世丏丐丅不丌.m_Distance, m_UV = new UnityEngine.Vector2()});
        this.丑专下专专一丞一丑 = 丂七丑世丏丐丅不丌.m_Point.x;
        mem[1152921536292963292] = val_42.y;
        mem[1152921536292963296] = val_42.z;
        this.七丝丆丂丞丙丆丟三(丙业与丙丗丝不丈东:  false);
    }
    private bool 丟七丕丌丈上丒丆丘(UnityEngine.Vector3 东丐丄丏丝丆丐专上, UnityEngine.Vector3 上丕一不世七世丑上)
    {
        float val_12;
        float val_13;
        var val_14;
        val_12 = 上丕一不世七世丑上.z;
        val_13 = 上丕一不世七世丑上.y;
        if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = 东丐丄丏丝丆丐专上.x, y = 东丐丄丏丝丆丐专上.y, z = 东丐丄丏丝丆丐专上.z}, end:  new UnityEngine.Vector3() {x = 上丕一不世七世丑上.x, y = val_13, z = val_12}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) != false)
        {
                label_11:
            this.且与丙丞东丘丛丂丘(丁丂丝不丟丛丟一丂:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            val_12 = 0;
            val_13 = 0;
            this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
            this.丑专下专专一丞一丑 = val_5;
            mem[1152921536293251452] = val_5.y;
            mem[1152921536293251456] = val_5.z;
            this.七丝丆丂丞丙丆丟三(丙业与丙丗丝不丈东:  false);
            val_14 = 1;
            return (bool)val_14;
        }
        
        if(this.专丄丆丌丝丞丙丛丅 != false)
        {
                float val_7 = this.世丗下丟丂与上下丙();
            val_7 = (UnityEngine.Time.realtimeSinceStartup - this.与丕丌丒丗丄丘丙东) * val_7;
            if(val_7 < 0)
        {
                if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = 上丕一不世七世丑上.x, y = val_13, z = val_12}, end:  new UnityEngine.Vector3() {x = 东丐丄丏丝丆丐专上.x, y = 东丐丄丏丝丆丐专上.y, z = 东丐丄丏丝丆丐专上.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) == true)
        {
            goto label_11;
        }
        
        }
        
        }
        
        val_14 = 0;
        return (bool)val_14;
    }
    private void 且与丙丞东丘丛丂丘(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂)
    {
        Player_move_c val_8;
        var val_9;
        var val_10;
        var val_11;
        val_9 = 1152921536293411760;
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_8 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if((与七丒丂丛丈丂业万(丌丝下丄业一丄不三:  this.丘丙不丄丕七万三丂, 丆万丑上丛下丗丌世:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 丁丂丝不丟丛丟一丂.m_Point.x}, m_Normal = new UnityEngine.Vector3() {y = 丁丂丝不丟丛丟一丂.m_Normal.y}, m_Distance = 丁丂丝不丟丛丟一丂.m_Distance, m_UV = new UnityEngine.Vector2()}, 一丞与七丙丁丞丗与:  1f, 丏丟丘丈丁丌丗丗丕:  false, 丌丙与上且丁丝丌且:  0)) == true)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 1f, y = 丁丂丝不丟丛丟一丂.m_Normal.y, z = 丁丂丝不丟丛丟一丂.m_Point.x}, d:  0.001f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1f, y = 丁丂丝不丟丛丟一丂.m_Normal.y, z = 丁丂丝不丟丛丟一丂.m_Point.x}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, toDirection:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        丆东丏丕七丝丘丝与(丒丅丄丅专不东丛丝:  false, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丐丘丗上丂丒丐丟业:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
    }
    private void FixedUpdate()
    {
        var val_18;
        float val_19;
        float val_20;
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_6;
        }
        
        label_16:
        this.七丝丆丂丞丙丆丟三(丙业与丙丗丝不丈东:  false);
        return;
        label_6:
        if(this.丆丟业东丈不三丟丗 != null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.与东丟丅丞业丙丗下());
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  UnityEngine.Time.fixedDeltaTime);
        val_19 = this.万丛丞丂丘且三丈丈;
        val_20 = V9.16B;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19, y = V8.16B, z = val_20}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.万丛丞丂丘且三丈丈 = val_7;
        mem[1152921536293520528] = val_7.y;
        mem[1152921536293520532] = val_7.z;
        UnityEngine.Vector3 val_9 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = this.万丛丞丂丘且三丈丈, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_12 = this.丌丟丄业且三丛丕丄().position;
        if((this.丟七丕丌丈上丒丆丘(东丐丄丏丝丆丐专上:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 上丕一不世七世丑上:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) != true)
        {
                val_19 = val_10.x;
            val_20 = val_10.z;
            this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_19, y = val_10.y, z = val_20};
        }
        
        float val_15 = UnityEngine.Time.realtimeSinceStartup;
        val_15 = val_15 - this.与丕丌丒丗丄丘丙东;
        if(val_15 <= this.与与专丟丗东丌与丆)
        {
                return;
        }
        
        UnityEngine.Vector3 val_17 = this.丌丟丄业且三丛丕丄().position;
        this.丑专下专专一丞一丑 = val_17;
        mem[1152921536293520508] = val_17.y;
        mem[1152921536293520512] = val_17.z;
        goto label_16;
    }
    private System.Collections.IEnumerable 东与丁丂丑下下丗丙()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new BallisticBullet.业东丂丆且丆丁业下();
    }
    private UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if(this.专专丏下丐丂丂丅东 == 0)
        {
                this.专专丏下丐丂丂丅东 = this.transform;
            return val_3;
        }
        
        val_3 = this.专专丏下丐丂丂丅东;
        return val_3;
    }
    public BallisticBullet()
    {
        this.七不丗丞丗丘业一丘 = 0;
        this.与与专丟丗东丌与丆 = 2.5f;
        this.丝与丅丕专业丁上丂 = 5f;
    }
    private static BallisticBullet()
    {
        BallisticBullet.丁七三丛丐丛丌东万 = 2f;
    }

}
