using UnityEngine;
internal sealed class ScreenZonesController : MonoBehaviour
{
    // Fields
    private ControlSizeController 不万东丅丂丙丝丆丙;
    private ScreenZonesController.Area[] 丂丂丆丌不世丟丐不;
    private UnityEngine.GameObject ZoneBottonRight;
    private UnityEngine.GameObject ZoneTopLeft;
    private ScreenZonesController.Area[] Restricted;
    private ScreenZonesController.Area MapZone;
    private ScreenZonesController.Area ArsenalZone;
    
    // Methods
    private void Awake()
    {
        System.Collections.Generic.List<Area> val_1 = new System.Collections.Generic.List<Area>();
        if((this.Restricted != null) && (this.Restricted.Length >= 1))
        {
                do
        {
            val_1.Add(item:  this.Restricted[0]);
        }
        while((0 + 1) < this.Restricted.Length);
        
        }
        
        if(this.MapZone != null)
        {
                val_1.Add(item:  this.MapZone);
        }
        
        if(this.ArsenalZone != null)
        {
                val_1.Add(item:  this.ArsenalZone);
        }
        
        this.丂丂丆丌不世丟丐不 = val_1.ToArray();
    }
    internal UnityEngine.Vector3 丛丆丅丗丌七丆下丒(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 世专七丘万丌一丟丗, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        var val_1 = val_1;
        return this.丑丛丂丏丅丅丕丕下(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 世专七丘万丌一丟丗:  new UnityEngine.Vector3() {x = 世专七丘万丌一丟丗.x, y = 世专七丘万丌一丟丗.y, z = 世专七丘万丌一丟丗.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  true, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
    }
    internal UnityEngine.Vector3 上上专丂丂世业业七(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 世专七丘万丌一丟丗, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        var val_1 = val_1;
        return this.丑丛丂丏丅丅丕丕下(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 世专七丘万丌一丟丗:  new UnityEngine.Vector3() {x = 世专七丘万丌一丟丗.x, y = 世专七丘万丌一丟丗.y, z = 世专七丘万丌一丟丗.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  false, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
    }
    private void OnEnable()
    {
        this.不万东丅丂丙丝丆丙 = this.GetComponentInParent<ControlSizeController>();
    }
    private UnityEngine.Vector3 丑丛丂丏丅丅丕丕下(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 世专七丘万丌一丟丗, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        float val_1;
        float val_8;
        float val_9;
        UnityEngine.Vector3 val_10;
        一世丅丕丑丈丕世丈 = 一世丅丕丑丈丕世丈;
        val_8 = 业丒丝丗与丐丛丟丏.z;
        val_9 = 业丒丝丗与丐丛丟丏.y;
        val_10 = 业丒丝丗与丐丛丟丏.x;
        一丕丌丈万丝丈与世 val_2 = this.丛丅下丟丕丗丈丁丒(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = val_1, z = 丝丕丁丏丏上丅丏且.y}, 一世丅丕丑丈丕世丈:  一世丅丕丑丈丕世丈);
        if(val_2.丙丛下丈且丞丆丞丝 != false)
        {
                val_10 = val_2.业丒丝丗与丐丛丟丏;
        }
        
        if(val_4.丙丛下丈且丞丆丞丝 == false)
        {
                return new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8};
        }
        
        UnityEngine.Vector3 val_7 = this.世丒一下不丄丐丈东(一丐丗丁丞丆丅丟丄:  this.万丒丞丅万丏丐丌专(与专七丑丁上丛东丟:  new UnityEngine.Vector3() {x = 世专七丘万丌一丟丗.x, y = 世专七丘万丌一丟丗.y, z = 世专七丘万丌一丟丗.z}, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y}, 世下丆三丕世丁七丝:  丒丐与丁丆丄丗丏丕, 三丕丆丌丝七丝丗丞:  false), 丒不三丁丒丏丂丒丈:  new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = val_1, z = 丝丕丁丏丏上丅丏且.y}, 一世丅丕丑丈丕世丈:  一世丅丕丑丈丕世丈, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
        val_10 = val_7.x;
        val_9 = val_7.y;
        val_8 = val_7.z;
        return new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_8};
    }
    internal bool 丑且世丑七丁丂丌世(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, out UnityEngine.Vector2[] 业东丛丂丏下丗丘且, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        return this.丟丆丈丐丏丞与丄丆(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  false, 业东丛丂丏下丗丘且: out  UnityEngine.Vector2[] val_2 = 业东丛丂丏下丗丘且, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
    }
    internal bool 万与丕丑丄丕专与丟(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, out UnityEngine.Vector2[] 业东丛丂丏下丗丘且, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        return this.丟丆丈丐丏丞与丄丆(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  true, 业东丛丂丏下丗丘且: out  UnityEngine.Vector2[] val_2 = 业东丛丂丏下丗丘且, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
    }
    private bool 丟丆丈丐丏丞与丄丆(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈, out UnityEngine.Vector2[] 业东丛丂丏下丗丘且, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        System.Array val_6;
        var val_7;
        val_6 = this;
        一世丅丕丑丈丕世丈 = 一世丅丕丑丈丕世丈;
        if((this.丛丅下丟丕丗丈丁丒(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  一世丅丕丑丈丕世丈)) != null)
        {
                业东丛丂丏下丗丘且 = val_1.业东丛丂丏下丗丘且;
        }
        else
        {
                业东丛丂丏下丗丘且 = 64;
        }
        
        一丕丌丈万丝丈与世 val_3 = this.万丒丞丅万丏丐丌专(与专七丑丁上丛东丟:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.z, z = ???}, 世下丆三丕世丁七丝:  丒丐与丁丆丄丗丏丕, 三丕丆丌丝七丝丗丞:  true);
        if(val_1.丙丛下丈且丞丆丞丝 == false)
        {
            goto label_4;
        }
        
        if(val_3.丙丛下丈且丞丆丞丝 == false)
        {
            goto label_5;
        }
        
        int val_4 = val_3.业东丛丂丏下丗丘且.Length + 0;
        UnityEngine.Vector2[] val_5 = new UnityEngine.Vector2[0];
        val_6 = val_5;
        业东丛丂丏下丗丘且.CopyTo(array:  val_5, index:  0);
        if(业东丛丂丏下丗丘且 == null)
        {
            goto label_9;
        }
        
        if(val_3.业东丛丂丏下丗丘且 != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        val_3.业东丛丂丏下丗丘且.CopyTo(array:  val_5, index:  0);
        val_7 = 0;
        业东丛丂丏下丗丘且 = val_6;
        return (bool)val_7;
        label_4:
        if(val_3.丙丛下丈且丞丆丞丝 == false)
        {
            goto label_12;
        }
        
        val_7 = 0;
        业东丛丂丏下丗丘且 = val_3.业东丛丂丏下丗丘且;
        return (bool)val_7;
        label_5:
        val_7 = 0;
        return (bool)val_7;
        label_9:
        if(val_3.业东丛丂丏下丗丘且 != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_12:
        val_7 = 1;
        return (bool)val_7;
    }
    private UnityEngine.Vector3 世丒一下不丄丐丈东(ScreenZonesController.一丕丌丈万丝丈与世 一丐丗丁丞丆丅丟丄, UnityEngine.Vector3 丒不三丁丒丏丂丒丈, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈, bool 丒丐与丁丆丄丗丏丕)
    {
        var val_9;
        float val_40;
        UnityEngine.Vector3 val_41;
        var val_42;
        float val_43;
        float val_44;
        float val_48;
        var val_49;
        float val_50;
        val_40 = 丒不三丁丒丏丂丒丈.y;
        UnityEngine.Vector2[] val_25 = 0;
        .丒不三丁丒丏丂丒丈 = 丒不三丁丒丏丂丒丈;
        mem[1152921536182823380] = val_40;
        mem[1152921536182823384] = 丒不三丁丒丏丂丒丈.z;
        System.Collections.Generic.List<UnityEngine.Vector2> val_2 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  一丐丗丁丞丆丅丟丄.业东丛丂丏下丗丘且);
        System.Comparison<UnityEngine.Vector2> val_3 = new System.Comparison<UnityEngine.Vector2>(object:  new ScreenZonesController.三丅丞丒丕丅专一丅(), method:  System.Int32 ScreenZonesController.三丅丞丒丕丅专一丅::上且七丁与世业丝丞(UnityEngine.Vector2 三丑丝丗不丈丐丞与, UnityEngine.Vector2 丕七业丏专业上与丅));
        if(val_2 != null)
        {
                val_2.Sort(comparison:  val_3);
        }
        else
        {
                val_2.Sort(comparison:  val_3);
        }
        
        if(val_2.Count <= 0)
        {
            goto label_5;
        }
        
        List.Enumerator<T> val_5 = val_2.GetEnumerator();
        float val_6 = 丝丕丁丏丏上丅丏且.x * 且丛上丕业丂丒与一;
        val_6 = val_6 + (丝丕丁丏丏上丅丏且.y * 且丛上丕业丂丒与一);
        val_6 = val_6 * 0.5f;
        val_41 = 一丐丗丁丞丆丅丟丄.业丒丝丗与丐丛丟丏;
        val_42 = 一丐丗丁丞丆丅丟丄 + 20;
        val_40 = val_6 + 0.001f;
        label_18:
        if((1511157024 & 1) == 0)
        {
            goto label_7;
        }
        
        UnityEngine.Vector2 val_10 = val_9.position;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  一丐丗丁丞丆丅丟丄.业丒丝丗与丐丛丟丏.x, y:  3.220049E-20f);
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  (ScreenZonesController.三丅丞丒丕丅专一丅)[1152921536182823360].丒不三丁丒丏丂丒丈, y:  3.220049E-20f);
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        val_43 = val_11.x;
        val_44 = val_11.y;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_43, y = val_44}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        if(val_14.x.sqrMagnitude > val_16.x.sqrMagnitude)
        {
                val_43 = val_13.x;
            val_44 = val_13.y;
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_43, y = val_44}, d:  -1f);
        }
        
        UnityEngine.Vector2 val_19 = val_18.x.normalized;
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, d:  val_40);
        UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        if((this.丟丆丈丐丏丞与丄丆(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  一世丅丕丑丈丕世丈, 业东丛丂丏下丗丘且: out  val_25, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕)) == true)
        {
            goto label_15;
        }
        
        UnityEngine.Vector2 val_27 = val_18.x.normalized;
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y}, d:  val_40);
        UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
        UnityEngine.Vector3 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
        if((this.丟丆丈丐丏丞与丄丆(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  一世丅丕丑丈丕世丈, 业东丛丂丏下丗丘且: out  val_25, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕)) == false)
        {
            goto label_18;
        }
        
        UnityEngine.Vector3 val_34 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
        val_48 = val_34.x;
        val_49 = val_34.y;
        val_50 = val_34.z;
        goto label_21;
        label_5:
        val_41 = 一丐丗丁丞丆丅丟丄.业丒丝丗与丐丛丟丏;
        val_42 = 一丐丗丁丞丆丅丟丄 + 20;
        goto label_48;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_48;
        label_15:
        UnityEngine.Vector3 val_35 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        val_48 = val_35.x;
        val_49 = val_35.y;
        val_50 = val_35.z;
        label_21:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return new UnityEngine.Vector3() {x = val_48, y = 3.220049E-20f, z = val_50};
        label_48:
        val_48 = mem[一丐丗丁丞丆丅丟丄.业丒丝丗与丐丛丟丏];
        val_48 = 一丐丗丁丞丆丅丟丄.业丒丝丗与丐丛丟丏.x;
        return new UnityEngine.Vector3() {x = val_48, y = 3.220049E-20f, z = val_50};
    }
    internal UnityEngine.Vector3 万丝丌一专丁丙丗丟(UnityEngine.Vector3 下业丕七东丌丝下且, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈)
    {
        float val_3;
        float val_4;
        UnityEngine.Vector3 val_5;
        val_3 = 下业丕七东丌丝下且.z;
        val_4 = 下业丕七东丌丝下且.y;
        val_5 = 下业丕七东丌丝下且.x;
        一丕丌丈万丝丈与世 val_2 = this.丛丅下丟丕丗丈丁丒(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  一世丅丕丑丈丕世丈);
        if(val_2.丙丛下丈且丞丆丞丝 == false)
        {
                return new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_3};
        }
        
        val_5 = val_2.业丒丝丗与丐丛丟丏;
        return new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_3};
    }
    internal bool 丈丑丁与丝丞下且丌(UnityEngine.Vector3 下业丕七东丌丝下且, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈)
    {
        一丕丌丈万丝丈与世 val_2 = this.丛丅下丟丕丗丈丁丒(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 一世丅丕丑丈丕世丈:  一世丅丕丑丈丕世丈);
        return (bool)(val_2.丙丛下丈且丞丆丞丝 == false) ? 1 : 0;
    }
    private ScreenZonesController.一丕丌丈万丝丈与世 丛丅下丟丕丗丈丁丒(UnityEngine.Vector3 下业丕七东丌丝下且, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈)
    {
        float val_21;
        bool val_22;
        var val_23;
        float val_24;
        val_21 = 下业丕七东丌丝下且.y;
        UnityEngine.Vector3 val_2 = this.ZoneTopLeft.transform.position;
        UnityEngine.Vector3 val_4 = this.ZoneBottonRight.transform.position;
        if(一世丅丕丑丈丕世丈 != false)
        {
                val_4.x = val_4.x + val_2.x;
            val_4.x = val_4.x * 0.5f;
            if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != false)
        {
            
        }
        
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_6 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        float val_17 = 丝丕丁丏丏上丅丏且.x;
        float val_7 = val_17 * 且丛上丕业丂丒与一;
        val_17 = val_7 + val_2.x;
        if(下业丕七东丌丝下且.x >= 0)
        {
            goto label_10;
        }
        
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_2.x, y:  val_21);
        val_6.Add(item:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
        val_22 = 1;
        val_23 = val_7 + val_2.x;
        goto label_12;
        label_10:
        if(下业丕七东丌丝下且.x <= (val_4.x - val_7))
        {
            goto label_13;
        }
        
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_4.x, y:  val_21);
        val_24 = 下业丕七东丌丝下且.z;
        val_6.Add(item:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        val_22 = 1;
        val_23 = val_4.x - val_7;
        goto label_15;
        label_13:
        val_22 = 0;
        val_23 = 下业丕七东丌丝下且.x;
        label_12:
        val_24 = 下业丕七东丌丝下且.z;
        label_15:
        float val_18 = 丝丕丁丏丏上丅丏且.y;
        float val_11 = val_18 * 且丛上丕业丂丒与一;
        val_18 = val_11 + val_4.y;
        if(val_21 >= 0)
        {
            goto label_16;
        }
        
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  下业丕七东丌丝下且.x, y:  val_4.y);
        val_6.Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        val_21 = val_11 + val_4.y;
        goto label_18;
        label_16:
        if(val_21 <= (val_2.y - val_11))
        {
            goto label_19;
        }
        
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  下业丕七东丌丝下且.x, y:  val_2.y);
        val_6.Add(item:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        val_21 = val_2.y - val_11;
        label_18:
        val_22 = true;
        label_19:
        .丙丛下丈且丞丆丞丝 = val_22;
        .业丒丝丗与丐丛丟丏 = 0;
        mem[1152921536183306840] = 0;
        .业东丛丂丏下丗丘且 = val_6.ToArray();
        return (一丕丌丈万丝丈与世)new ScreenZonesController.一丕丌丈万丝丈与世();
    }
    private ScreenZonesController.一丕丌丈万丝丈与世 万丒丞丅万丏丐丌专(UnityEngine.Vector3 与专七丑丁上丛东丟, UnityEngine.Vector3 下业丕七东丌丝下且, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 世下丆三丕世丁七丝, bool 三丕丆丌丝七丝丗丞 = False)
    {
        float val_8;
        UnityEngine.Vector3 val_13;
        float val_38;
        Area val_39;
        Area val_40;
        var val_41;
        UnityEngine.Vector3 val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        float val_47;
        float val_48;
        System.Comparison<UnityEngine.Vector2> val_49;
        float val_50;
        float val_51;
        float val_52;
        float val_53;
        System.Comparison<UnityEngine.Vector2> val_54;
        bool val_55;
        val_38 = 与专七丑丁上丛东丟.x;
        ScreenZonesController.丈业丗丞丁七下一不 val_1 = new ScreenZonesController.丈业丗丞丁七下一不();
        .下业丕七东丌丝下且 = 下业丕七东丌丝下且;
        mem[1152921536183604180] = 下业丕七东丌丝下且.y;
        mem[1152921536183604184] = 下业丕七东丌丝下且.z;
        System.Collections.Generic.List<UnityEngine.Vector2> val_2 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Collections.Generic.List<Area> val_3 = new System.Collections.Generic.List<Area>();
        if((this.Restricted == null) || (this.Restricted.Length < 1))
        {
            goto label_3;
        }
        
        label_19:
        val_39 = this.Restricted[0];
        if(val_39 == null)
        {
            goto label_5;
        }
        
        if(世下丆三丕世丁七丝 == false)
        {
            goto label_6;
        }
        
        label_9:
        if(this.Restricted[0x0][0].RightHanded == true)
        {
            goto label_13;
        }
        
        goto label_17;
        label_5:
        if(世下丆三丕世丁七丝 == true)
        {
            goto label_9;
        }
        
        label_6:
        if(this.Restricted[0x0][0].LeftHanded != false)
        {
                if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false)
        {
            goto label_13;
        }
        
        }
        
        if((this.Restricted[0x0][0].RightHanded == false) || (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false))
        {
            goto label_17;
        }
        
        label_13:
        val_3.Add(item:  val_39);
        label_17:
        if((0 + 1) < this.Restricted.Length)
        {
            goto label_19;
        }
        
        label_3:
        if(世下丆三丕世丁七丝 != false)
        {
                val_40 = this.MapZone;
        }
        else
        {
                val_40 = this.ArsenalZone;
        }
        
        val_41 = 1152921536183604176;
        if(val_40 != null)
        {
                val_3.Add(item:  val_40);
        }
        
        if(val_1 != null)
        {
                val_42 = .下业丕七东丌丝下且;
        }
        else
        {
                val_41 = 16;
            val_42 = 1.68059E-38f;
        }
        
        val_43 = 1.401298E-45f;
        if(val_3.Count < 1)
        {
            goto label_27;
        }
        
        float val_38 = 丝丕丁丏丏上丅丏且.x;
        float val_9 = val_38 * 且丛上丕业丂丒与一;
        float val_10 = val_8 * 且丛上丕业丂丒与一;
        List.Enumerator<T> val_11 = val_3.GetEnumerator();
        val_38 = val_9 + val_10;
        val_38 = val_38 * 0.5f;
        val_39 = 1152921536183467264;
        label_89:
        val_38 = val_42;
        val_44 = val_43;
        if((1511941920 & 1) == 0)
        {
            goto label_29;
        }
        
        UnityEngine.Vector3 val_16 = val_14.m_stringLength.transform.position;
        UnityEngine.Vector3 val_18 = val_13.丐丏七丌丕丗业且上().transform.position;
        float val_39 = val_9;
        val_45 = 1.68059E-38f;
        val_39 = val_16.x - val_39;
        if(val_45 <= val_39)
        {
            goto label_89;
        }
        
        if(val_1 == null)
        {
                val_45 = 1.68059E-38f;
        }
        
        float val_40 = val_9;
        val_40 = val_40 + val_18.x;
        if(val_45 >= 0)
        {
            goto label_89;
        }
        
        float val_41 = val_10;
        val_46 = 1.401298E-45f;
        val_41 = val_18.y - val_41;
        if(val_46 <= val_41)
        {
            goto label_89;
        }
        
        if(val_1 == null)
        {
                val_46 = 1.401298E-45f;
        }
        
        float val_42 = val_10;
        val_42 = val_42 + val_16.y;
        if(val_46 >= 0)
        {
            goto label_89;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_19 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        val_47 = 1.68059E-38f;
        if(val_47 < 0)
        {
            goto label_44;
        }
        
        if(val_1 == null)
        {
                val_47 = 1.68059E-38f;
        }
        
        if(val_47 <= val_18.x)
        {
            goto label_50;
        }
        
        label_44:
        val_48 = 1.401298E-45f;
        if(val_48 > val_16.y)
        {
            goto label_48;
        }
        
        if(val_1 == null)
        {
                val_48 = 1.401298E-45f;
        }
        
        if(val_48 >= 0)
        {
            goto label_50;
        }
        
        label_48:
        val_13 = 0;
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_16.x, y:  val_16.y);
        null.Add(item:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_16.x, y:  val_18.y);
        null.Add(item:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_18.x, y:  val_16.y);
        null.Add(item:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_18.x, y:  val_18.y);
        null.Add(item:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
        val_49 = (ScreenZonesController.丈业丗丞丁七下一不)[1152921536183604160].上丌丘丑一且丆且丏;
        if(val_49 == null)
        {
                val_49 = null;
            val_49 = new System.Comparison<UnityEngine.Vector2>(object:  val_1, method:  System.Int32 ScreenZonesController.丈业丗丞丁七下一不::丂下丙丄东业不丏丞(UnityEngine.Vector2 三丑丝丗不丈丐丞与, UnityEngine.Vector2 丕七业丏专业上与丅));
            .上丌丘丑一且丆且丏 = val_49;
        }
        
        null.Sort(comparison:  null);
        UnityEngine.Vector2 val_25 = null.Item[0];
        UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = (ScreenZonesController.丈业丗丞丁七下一不)[1152921536183604160].下业丕七东丌丝下且, y = val_16.x, z = val_18.y});
        if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y}, b:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y})) >= 0)
        {
            goto label_89;
        }
        
        UnityEngine.Vector2 val_28 = null.Item[0];
        val_2.Add(item:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
        goto label_89;
        label_50:
        val_50 = 1.68059E-38f;
        if(val_50 >= val_16.x)
        {
                if(val_1 == null)
        {
                val_50 = 1.68059E-38f;
        }
        
            if(val_50 <= val_18.x)
        {
                val_13 = 0;
            UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  1.68059E-38f, y:  val_16.y);
            null.Add(item:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
            UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  1.68059E-38f, y:  val_18.y);
            val_50 = val_30.x;
            null.Add(item:  new UnityEngine.Vector2() {x = val_50, y = val_30.y});
        }
        
        }
        
        val_51 = 1.401298E-45f;
        if(val_51 >= val_18.y)
        {
                if(val_1 == null)
        {
                val_51 = 1.401298E-45f;
        }
        
            if(val_51 <= val_16.y)
        {
                if(val_1 == null)
        {
                val_52 = 1.401298E-45f;
        }
        
            val_13 = 0;
            UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  val_16.x, y:  val_52);
            null.Add(item:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y});
            UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_18.x, y:  1.401298E-45f);
            val_50 = val_32.x;
            val_53 = val_32.y;
            null.Add(item:  new UnityEngine.Vector2() {x = val_50, y = val_53});
        }
        
        }
        
        val_54 = (ScreenZonesController.丈业丗丞丁七下一不)[1152921536183604160].丂丌丑一丏丌丌世丆;
        if(val_54 == null)
        {
                val_54 = null;
            val_54 = new System.Comparison<UnityEngine.Vector2>(object:  val_1, method:  System.Int32 ScreenZonesController.丈业丗丞丁七下一不::与丟业丂丏上丞丌世(UnityEngine.Vector2 三丑丝丗不丈丐丞与, UnityEngine.Vector2 丕七业丏专业上与丅));
            .丂丌丑一丏丌丌世丆 = val_54;
        }
        
        null.Sort(comparison:  null);
        if(三丕丆丌丝七丝丗丞 == false)
        {
            goto label_84;
        }
        
        UnityEngine.Vector2 val_34 = null.Item[0];
        val_2.Add(item:  new UnityEngine.Vector2() {x = val_34.x, y = val_34.y});
        goto label_89;
        label_84:
        val_2.AddRange(collection:  null);
        goto label_89;
        label_27:
        val_55 = 0;
        goto label_90;
        label_29:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_35 = (0 != 255) ? 1 : 0;
        val_43 = val_44;
        val_42 = val_38;
        label_90:
        .丙丛下丈且丞丆丞丝 = ;
        val_13 = 0;
        .业丒丝丗与丐丛丟丏 = val_13;
        mem[1152921536183698392] = 0;
        .业东丛丂丏下丗丘且 = val_2.ToArray();
        return (一丕丌丈万丝丈与世)new ScreenZonesController.一丕丌丈万丝丈与世();
    }
    private void Update()
    {
        Area val_6;
        var val_7;
        System.Collections.Generic.List<Area> val_1 = new System.Collections.Generic.List<Area>();
        if((this.Restricted == null) || (this.Restricted.Length < 1))
        {
            goto label_4;
        }
        
        label_20:
        Area val_7 = this.Restricted[0];
        if(val_7 == null)
        {
            goto label_6;
        }
        
        if((this.不万东丅丂丙丝丆丙.丑丒专丙东万丒丂丆 & 1) == 0)
        {
            goto label_7;
        }
        
        label_10:
        if(this.Restricted[0x0][0].RightHanded == true)
        {
            goto label_14;
        }
        
        goto label_18;
        label_6:
        if((this.不万东丅丂丙丝丆丙.丑丒专丙东万丒丂丆 & 1) != 0)
        {
            goto label_10;
        }
        
        label_7:
        if(this.Restricted[0x0][0].LeftHanded != false)
        {
                if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false)
        {
            goto label_14;
        }
        
        }
        
        if((this.Restricted[0x0][0].RightHanded == false) || (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false))
        {
            goto label_18;
        }
        
        label_14:
        val_1.Add(item:  val_7);
        label_18:
        if((0 + 1) < this.Restricted.Length)
        {
            goto label_20;
        }
        
        label_4:
        if((this.不万东丅丂丙丝丆丙.丑丒专丙东万丒丂丆 & 1) == 0)
        {
            goto label_21;
        }
        
        val_6 = this.MapZone;
        if(val_6 == null)
        {
            goto label_24;
        }
        
        label_25:
        val_1.Add(item:  val_6);
        goto label_24;
        label_21:
        val_6 = this.ArsenalZone;
        if(val_6 != null)
        {
            goto label_25;
        }
        
        label_24:
        val_7 = 0;
        goto label_26;
        label_35:
        val_6 = this.丂丂丆丌不世丟丐不[0x0][0].Indication;
        if(val_6 != 0)
        {
                val_6 = this.丂丂丆丌不世丟丐不[0x0][0].Indication;
            Area val_9 = this.丂丂丆丌不世丟丐不[0];
            val_9 = val_1.Contains(item:  val_9);
            val_6.SetActive(value:  val_9);
        }
        
        val_7 = 1;
        label_26:
        if(val_7 < this.丂丂丆丌不世丟丐不.Length)
        {
            goto label_35;
        }
    
    }
    public ScreenZonesController()
    {
    
    }

}
