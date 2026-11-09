using UnityEngine;
public class ScrollHelper : MonoBehaviour
{
    // Fields
    private static float 三丁一丂与丕丄丆七;
    private UnityEngine.Vector3 丏上丙一丛丆丝丑下;
    public UIScrollView scroll;
    public float ScrollSpeed;
    private System.Action 丞下丁丑丏三东丆七;
    
    // Properties
    public bool 万七丌丄丐一东丟下 { get; }
    
    // Methods
    public bool get_IsScrolling()
    {
        null = null;
        return (bool)(V0.16B > ScrollHelper.三丁一丂与丕丄丆七) ? 1 : 0;
    }
    public void add_OnPosition(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丞下丁丑丏三东丆七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞下丁丑丏三东丆七 != 1152921539438769592);
    
    }
    public void remove_OnPosition(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丞下丁丑丏三东丆七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞下丁丑丏三东丆七 != 1152921539438906168);
    
    }
    private UnityEngine.Vector3 丈丕丄丂丈丗专丘三(UnityEngine.Transform 七上东丕丅专专下与, ScrollHelper.丝丏七丘专丒丗丒丒 万丛丑且三万且东专 = 1, float 丛上丙丄丄七丈且丅 = 0)
    {
        float val_72;
        float val_73;
        float val_74;
        float val_76;
        var val_77;
        var val_78;
        float val_79;
        float val_80;
        var val_81;
        var val_82;
        float val_85;
        var val_86;
        float val_87;
        float val_89;
        val_72 = 丛上丙丄丄七丈且丅;
        UIPanel val_1 = this.scroll.panel;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector4 val_3 = val_1.finalClipRegion;
        if(this.scroll.movement != 1)
        {
            goto label_4;
        }
        
        UnityEngine.Vector4 val_4 = val_1.finalClipRegion;
        float val_68 = 0.5f;
        val_68 = val_4.w * val_68;
        float val_5 = val_3.y + val_68;
        UnityEngine.Vector3 val_6 = val_2.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_72 = val_6.y;
        if(val_1 == null)
        {
            goto label_7;
        }
        
        UnityEngine.Vector4 val_8 = val_1.finalClipRegion;
        val_73 = val_8.y;
        goto label_8;
        label_4:
        UnityEngine.Vector4 val_9 = val_1.finalClipRegion;
        float val_69 = 0.5f;
        val_69 = val_9.z * val_69;
        val_69 = val_3.x + val_69;
        UnityEngine.Vector3 val_10 = val_2.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(val_1 == null)
        {
            goto label_11;
        }
        
        UnityEngine.Vector4 val_12 = val_1.finalClipRegion;
        val_74 = val_12.x;
        goto label_12;
        label_7:
        UnityEngine.Vector4 val_13 = 0.finalClipRegion;
        val_73 = val_13.y;
        label_8:
        UnityEngine.Vector4 val_14 = val_1.finalClipRegion;
        float val_70 = -0.5f;
        val_70 = val_14.w * val_70;
        float val_15 = val_73 + val_70;
        UnityEngine.Vector3 val_16 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector4 val_18 = val_1.finalClipRegion;
        UnityEngine.Vector3 val_19 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_76 = val_19.y;
        System.Collections.Generic.List<UnityEngine.Transform> val_20 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_77 = 1152921519066836496;
        val_78 = 0;
        goto label_16;
        label_27:
        if((val_1.transform.GetChild(index:  0).gameObject.activeSelf) != false)
        {
                val_20.Add(item:  val_1.transform.GetChild(index:  0));
        }
        
        val_78 = 1;
        label_16:
        if(val_78 < val_1.transform.childCount)
        {
            goto label_27;
        }
        
        val_79 = -3.402823E+38f;
        val_80 = 3.402823E+38f;
        val_81 = 1152921519067102480;
        val_82 = 0;
        goto label_28;
        label_33:
        UnityEngine.Bounds val_30 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  val_20.Item[0], 一丐丂丘专丅丟丞七:  true);
        if(val_79 < 0)
        {
                val_79 = val_19.y;
        }
        
        if(val_80 > val_19.y)
        {
                val_80 = val_19.y;
        }
        
        val_82 = 1;
        label_28:
        if(val_82 < val_20.Count)
        {
            goto label_33;
        }
        
        if(万丛丑且三万且东专 == 2)
        {
            goto label_34;
        }
        
        if(万丛丑且三万且东专 != 1)
        {
            goto label_35;
        }
        
        UnityEngine.Bounds val_33 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  七上东丕丅专专下与, 一丐丂丘专丅丟丞七:  true);
        val_85 = val_76 - val_19.y;
        goto label_61;
        label_11:
        UnityEngine.Vector4 val_34 = 0.finalClipRegion;
        val_74 = val_34.x;
        label_12:
        UnityEngine.Vector4 val_35 = val_1.finalClipRegion;
        float val_71 = -0.5f;
        val_71 = val_35.z * val_71;
        val_71 = val_74 + val_71;
        UnityEngine.Vector3 val_36 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_76 = val_36.x;
        UnityEngine.Vector4 val_38 = val_1.finalClipRegion;
        UnityEngine.Vector3 val_39 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        System.Collections.Generic.List<UnityEngine.Transform> val_40 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_77 = 1152921519066836496;
        val_86 = 0;
        goto label_40;
        label_51:
        if((val_1.transform.GetChild(index:  0).gameObject.activeSelf) != false)
        {
                val_40.Add(item:  val_1.transform.GetChild(index:  0));
        }
        
        val_86 = 1;
        label_40:
        if(val_86 < val_1.transform.childCount)
        {
            goto label_51;
        }
        
        val_80 = -3.402823E+38f;
        val_87 = 3.402823E+38f;
        val_81 = 1152921519067102480;
        val_82 = 0;
        goto label_52;
        label_57:
        UnityEngine.Bounds val_50 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  val_40.Item[0], 一丐丂丘专丅丟丞七:  true);
        if(val_80 < 0)
        {
                val_80 = 0f;
        }
        
        if(val_87 > 0f)
        {
                val_87 = 0f;
        }
        
        val_82 = 1;
        label_52:
        if(val_82 < val_40.Count)
        {
            goto label_57;
        }
        
        if(万丛丑且三万且东专 == 2)
        {
            goto label_58;
        }
        
        if(万丛丑且三万且东专 != 1)
        {
            goto label_59;
        }
        
        UnityEngine.Bounds val_52 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  七上东丕丅专专下与, 一丐丂丘专丅丟丞七:  true);
        val_89 = val_39.x - 0f;
        goto label_66;
        label_34:
        UnityEngine.Bounds val_53 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  七上东丕丅专专下与, 一丐丂丘专丅丟丞七:  true);
        val_85 = val_72 - val_19.y;
        goto label_61;
        label_35:
        UnityEngine.Bounds val_54 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  七上东丕丅专专下与, 一丐丂丘专丅丟丞七:  true);
        val_85 = val_16.y - val_19.y;
        label_61:
        val_19.y = val_79 - val_80;
        if(val_19.y <= (val_72 - val_16.y))
        {
            goto label_67;
        }
        
        float val_56 = val_80 + val_85;
        float val_57 = val_56 - val_16.y;
        val_57 = val_85 - val_57;
        val_85 = (val_56 > val_16.y) ? (val_57) : (val_85);
        val_56 = val_79 + val_85;
        val_57 = val_56 - val_72;
        val_57 = val_85 - val_57;
        val_72 = (val_56 < 0) ? (val_57) : (val_85);
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.up;
        goto label_65;
        label_58:
        UnityEngine.Bounds val_59 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  七上东丕丅专专下与, 一丐丂丘专丅丟丞七:  true);
        float val_72 = 0f;
        val_72 = val_10.x - val_72;
        val_89 = val_72 - val_72;
        goto label_66;
        label_59:
        UnityEngine.Bounds val_60 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  七上东丕丅专专下与, 一丐丂丘专丅丟丞七:  true);
        float val_73 = 0f;
        val_73 = val_76 - val_73;
        val_89 = val_73 + val_72;
        label_66:
        if((val_80 - val_87) <= (val_10.x - val_76))
        {
            goto label_67;
        }
        
        float val_63 = val_87 + val_89;
        float val_64 = val_63 - val_76;
        val_64 = val_89 - val_64;
        val_89 = (val_63 > val_76) ? (val_64) : (val_89);
        val_63 = val_80 + val_89;
        val_64 = val_63 - val_10.x;
        val_64 = val_89 - val_64;
        val_72 = (val_63 < 0) ? (val_64) : (val_89);
        UnityEngine.Vector3 val_65 = UnityEngine.Vector3.right;
        label_65:
        UnityEngine.Vector3 val_66 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z}, d:  val_72);
        return new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z};
        label_67:
        UnityEngine.Vector3 val_67 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z};
    }
    public void ScrollToObjectImmediately(UnityEngine.Transform 丌丟专且丞丁万丑丞, ScrollHelper.丝丏七丘专丒丗丒丒 万丛丑且三万且东专 = 1, float 丛上丙丄丄七丈且丅 = 0)
    {
        UnityEngine.Vector3 val_1 = this.丈丕丄丂丈丗专丘三(七上东丕丅专专下与:  丌丟专且丞丁万丑丞, 万丛丑且三万且东专:  万丛丑且三万且东专, 丛上丙丄丄七丈且丅:  丛上丙丄丄七丈且丅);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.不不丏专丟丆丕丛丗(丄丑三东丘丆丂丟丙:  this.scroll);
        this.scroll.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        if(this.丞下丁丑丏三东丆七 == null)
        {
                return;
        }
        
        this.丞下丁丑丏三东丆七.Invoke();
    }
    public void ScrollToObject(UnityEngine.Transform 丌丟专且丞丁万丑丞, ScrollHelper.丝丏七丘专丒丗丒丒 万丛丑且三万且东专 = 1, float 丛上丙丄丄七丈且丅 = 0)
    {
        this.scroll.DisableSpring();
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.scroll.currentMomentum = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = this.丈丕丄丂丈丗专丘三(七上东丕丅专专下与:  丌丟专且丞丁万丑丞, 万丛丑且三万且东专:  万丛丑且三万且东专, 丛上丙丄丄七丈且丅:  丛上丙丄丄七丈且丅);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.不不丏专丟丆丕丛丗(丄丑三东丘丆丂丟丙:  this.scroll);
        this.丏上丙一丛丆丝丑下 = val_2;
        mem[1152921539439602076] = val_2.y;
        mem[1152921539439602080] = val_2.z;
    }
    private void LateUpdate()
    {
        null = null;
        if(V0.16B > ScrollHelper.三丁一丂与丕丄丆七)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丏上丙一丛丆丝丑下, y = V9.16B, z = V10.16B}, d:  UnityEngine.Time.unscaledDeltaTime);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.ScrollSpeed);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  5f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丏上丙一丛丆丝丑下, y = val_4.y, z = 5f}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.丏上丙一丛丆丝丑下 = val_5;
            mem[1152921539439742748] = val_5.y;
            mem[1152921539439742752] = val_5.z;
            this.scroll.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return;
        }
        
        if(this.丞下丁丑丏三东丆七 == null)
        {
                return;
        }
        
        this.丞下丁丑丏三东丆七.Invoke();
    }
    private void OnDisable()
    {
        this.七丝丞丏丁丛丌世丝();
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 == false)
        {
                return;
        }
        
        this.七丝丞丏丁丛丌世丝();
    }
    private void 七丝丞丏丁丛丌世丝()
    {
        float val_2;
        var val_3;
        val_2 = V0.16B;
        val_3 = null;
        val_3 = null;
        if(val_2 <= ScrollHelper.三丁一丂与丕丄丆七)
        {
                return;
        }
        
        val_2 = this.丏上丙一丛丆丝丑下;
        this.scroll.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_2, y = V9.16B, z = V10.16B});
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丏上丙一丛丆丝丑下 = val_1;
        mem[1152921539440095132] = val_1.y;
        mem[1152921539440095136] = val_1.z;
        if(this.丞下丁丑丏三东丆七 == null)
        {
                return;
        }
        
        this.丞下丁丑丏三东丆七.Invoke();
    }
    public ScrollHelper()
    {
        this.ScrollSpeed = 1f;
    }
    private static ScrollHelper()
    {
        ScrollHelper.三丁一丂与丕丄丆七 = 1E-05f;
    }

}
