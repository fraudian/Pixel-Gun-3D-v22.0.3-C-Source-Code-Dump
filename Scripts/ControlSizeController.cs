using UnityEngine;
internal sealed class ControlSizeController : MonoBehaviour
{
    // Fields
    internal const string 丂丗下七丈且丛丑丏 = "Controls.Size";
    internal const string 与且一东丟世三丒丄 = "Controls.Size.BR";
    private float 世丝上丙丛东丌下丈;
    private float 丛丑且丛丈丝不丙丈;
    private readonly float 丗丂丘不业丈丐丁东;
    private readonly float 丈丞三不丈一丌万万;
    public UISprite _currentSprite;
    private System.Collections.Generic.List<丅下世下七下七一世> 万与丞七业业东丝丌;
    private UISprite[] 丞丅业丕业专丒丈丛;
    private float 丙专丄上丟丕丈丘丗;
    private bool[] 与与丐丒丑丙丒丙东;
    public UISprite _brMap;
    public UISprite _weaponPanel;
    public UISprite[] _weaponPanelSprites;
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 丏专丌万与上丆丈三;
    internal 下丂世丂不丛专一一 丑丒专丙东万丒丂丆;
    public ControlSizeView view;
    private UnityEngine.Coroutine 专业上下丘丟东上丁;
    private static ControlSizeController <不丁丄七丛不丆丁丕>k__BackingField;
    
    // Properties
    internal static ControlSizeController 丆丕丝丒不丙且丐丗 { get; set; }
    
    // Methods
    public void CheckAllButtonsForCollision()
    {
        if(this.专业上下丘丟东上丁 != null)
        {
                this.StopCoroutine(routine:  this.专业上下丘丟东上丁);
        }
        
        this.专业上下丘丟东上丁 = this.StartCoroutine(routine:  this.世业丛丕丄丘丛世下());
    }
    private System.Collections.IEnumerator 世业丛丕丄丘丛世下()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ControlSizeController.丏丁丅丄丕丛一丑丐(丗丏丅丕丆世丁专丟:  0);
    }
    public void HandleAlphaSliderChanged(UISlider 丆且丞丟丛丗万一世)
    {
        UISprite val_6;
        object val_7;
        val_6 = this._currentSprite;
        if(val_6 != 0)
        {
            goto label_3;
        }
        
        val_7 = "_currentSprite == null";
        goto label_6;
        label_3:
        val_6 = this._currentSprite.GetComponent<ControlSize>();
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        val_7 = "cs == null";
        label_6:
        UnityEngine.Debug.LogWarning(message:  val_7);
        return;
        label_10:
        this.丑万丒丏七丝丁丘丕(与丄丈丘丟丕丏丐丁:  this._currentSprite, 下丌丟丏丏丘专丒专:  UnityEngine.Mathf.Lerp(a:  this.丗丂丘不业丈丐丁东, b:  this.丈丞三不丈一丌万万, t:  丆且丞丟丛丗万一世.value));
    }
    private void 丑万丒丏七丝丁丘丕(UISprite 与丄丈丘丟丕丏丐丁, float 下丌丟丏丏丘专丒专)
    {
        UISprite val_10 = 与丄丈丘丟丕丏丐丁;
        if(val_10 == 0)
        {
                return;
        }
        
        if((val_10.GetComponent<ButtonJoystickAdjust>()) != 0)
        {
                val_10 = ???;
        }
        else
        {
                ButtonJoystickAdjust.业丟不丏丐丛丅丟丂(丒一东丁世三万专下:  val_10.transform, 与专丌丅丙上丌一丄:  下丌丟丏丏丘专丒专);
        }
    
    }
    public void HandleSizeSliderChanged(UISlider 丆且丞丟丛丗万一世)
    {
        object val_143;
        ControlSize val_144;
        float val_145;
        float val_146;
        int val_147;
        var val_148;
        System.Func<UISprite, System.Boolean> val_150;
        var val_151;
        System.Func<UISprite, System.Boolean> val_153;
        System.Collections.Generic.List<丅下世下七下七一世> val_154;
        var val_155;
        var val_156;
        var val_158;
        float val_159;
        var val_160;
        ButtonJoystickAdjust val_161;
        var val_162;
        System.Collections.Generic.List<T> val_163;
        UnityEngine.Vector2[] val_167;
        bool val_168;
        int val_169;
        var val_170;
        float val_174;
        float val_175;
        float val_176;
        float val_177;
        float val_178;
        UISlider val_179;
        var val_180;
        var val_181;
        ControlSize val_182;
        var val_183;
        float val_184;
        var val_185;
        var val_186;
        var val_187;
        System.Collections.Generic.List<T> val_188;
        ControlSize val_189;
        System.Collections.Generic.List<T> val_190;
        ControlSizeController.丌丐丝丐下上三丛丌 val_1 = new ControlSizeController.丌丐丝丐下上三丛丌();
        .丝且与丝丒丟万丁专 = this;
        if(this._currentSprite != 0)
        {
            goto label_4;
        }
        
        val_143 = "_currentSprite == null";
        goto label_7;
        label_4:
        ControlSize val_3 = this._currentSprite.GetComponent<ControlSize>();
        .丁丒丂丙业丒一七且 = val_3;
        if(val_3 != 0)
        {
            goto label_11;
        }
        
        val_143 = "cs == null";
        label_7:
        UnityEngine.Debug.LogWarning(message:  val_143);
        return;
        label_11:
        val_144 = (ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且;
        if((ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且 != null)
        {
            goto label_14;
        }
        
        val_144 = (ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且;
        if(val_144 == null)
        {
            goto label_220;
        }
        
        label_14:
        val_145 = 丆且丞丟丛丗万一世.value;
        val_146 = (float)(ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且.minValue;
        int val_7 = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Lerp(a:  val_146, b:  (float)(ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且.maxValue, t:  val_145));
        if(val_7 == this._currentSprite.width)
        {
                return;
        }
        
        ButtonJoystickAdjust val_9 = this._currentSprite.GetComponent<ButtonJoystickAdjust>();
        if((val_9 != null) && (val_9 != 0))
        {
                if((null == null) || (null == null))
        {
            goto label_27;
        }
        
        }
        
        val_147 = val_7;
        val_148 = null;
        val_148 = null;
        val_150 = ControlSizeController.<>c.<>9__22_0;
        if(val_150 == null)
        {
                System.Func<UISprite, System.Boolean> val_11 = null;
            val_150 = val_11;
            val_11 = new System.Func<UISprite, System.Boolean>(object:  ControlSizeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ControlSizeController.<>c::业丁丗丟下丁丐不丂(UISprite 丏丂丛丙丆三专丂丛));
            ControlSizeController.<>c.<>9__22_0 = val_150;
        }
        
        val_151 = null;
        val_151 = null;
        val_153 = ControlSizeController.<>c.<>9__22_1;
        if(val_153 == null)
        {
                System.Func<UISprite, System.Boolean> val_13 = null;
            val_153 = val_13;
            val_13 = new System.Func<UISprite, System.Boolean>(object:  ControlSizeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ControlSizeController.<>c::七丝且丒且与丕丑上(UISprite 丏丂丛丙丆三专丂丛));
            ControlSizeController.<>c.<>9__22_1 = val_153;
        }
        
        System.Collections.Generic.List<丅下世下七下七一世> val_17 = null;
        val_154 = val_17;
        val_17 = new System.Collections.Generic.List<丅下世下七下七一世>(collection:  System.Linq.Enumerable.Select<UISprite, 丅下世下七下七一世>(source:  System.Linq.Enumerable.Where<UISprite>(source:  System.Linq.Enumerable.Where<UISprite>(source:  this.丞丅业丕业专丒丈丛, predicate:  val_11), predicate:  val_13), selector:  new System.Func<UISprite, 丅下世下七下七一世>(object:  val_1, method:  丅下世下七下七一世 ControlSizeController.丌丐丝丐下上三丛丌::丗丐丏与丕丝丌丝专(UISprite 丏丂丛丙丆三专丂丛))));
        goto label_38;
        label_27:
        System.Collections.Generic.List<丅下世下七下七一世> val_18 = null;
        val_154 = val_18;
        val_18 = new System.Collections.Generic.List<丅下世下七下七一世>();
        val_147 = val_7;
        label_38:
        this.万与丞七业业东丝丌 = val_154;
        if(((val_9 != null) && (null == null)) && ((val_9.丝与下丈丄丞万丐专(丙一丐丗专丙丆丒且:  val_147)) != false))
        {
                val_155 = null;
            if(null != val_155)
        {
                val_156 = null;
        }
        else
        {
                val_156 = val_155;
        }
        
            UnityEngine.Vector3 val_21 = (val_155 == val_156) ? (val_9) : 0.不与丁东世丕丗下丛();
            this.万与丞七业业东丝丌.Add(item:  new 丅下世下七下七一世() {下丝丟七丅不丁丘丗 = new UnityEngine.Vector2() {x = 0f, y = 0f}, 丏三丞专下一丂丙业 = new System.Nullable<System.Boolean>() {HasValue = false}});
        }
        
        System.Collections.Generic.List<丅下世下七下七一世> val_22 = new System.Collections.Generic.List<丅下世下七下七一世>(collection:  this.万与丞七业业东丝丌);
        int[] val_23 = new int[1];
        val_23[0] = val_22.IndexOf(item:  new 丅下世下七下七一世() {下丝丟七丅不丁丘丗 = new UnityEngine.Vector2() {x = 0f, y = 0f}, 丏三丞专下一丂丙业 = new System.Nullable<System.Boolean>() {HasValue = false}});
        System.Collections.Generic.List<System.Int32> val_25 = new System.Collections.Generic.List<System.Int32>(collection:  val_23);
        System.Collections.Generic.List<System.Single> val_26 = new System.Collections.Generic.List<System.Single>();
        if((val_25.Item[0] & 2147483648) != 0)
        {
            goto label_49;
        }
        
        val_158 = 0;
        goto label_50;
        label_61:
        UnityEngine.Vector3 val_29 = this._currentSprite.transform.localPosition;
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        val_159 = val_30.y;
        丅下世下七下七一世 val_31 = val_22.Item[0];
        val_146 = val_30.x;
        val_145 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_146, y = val_159}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        if((val_25.Contains(item:  0)) == true)
        {
            goto label_57;
        }
        
        丅下世下七下七一世 val_34 = val_22.Item[0];
        var val_144 = 0;
        val_144 = val_144 + val_7;
        val_146 = (float)val_144 * 0.5f;
        if(val_145 <= val_146)
        {
            goto label_59;
        }
        
        label_57:
        val_158 = 1;
        label_50:
        if(val_158 < val_22.Count)
        {
            goto label_61;
        }
        
        label_49:
        val_160 = 1152921504848912384;
        val_161 = val_9;
        val_162 = 1;
        goto label_62;
        label_59:
        丅下世下七下七一世 val_36 = val_22.Item[0];
        val_160 = 1152921504848912384;
        val_163 = val_26;
        val_161 = val_9;
        if(val_163 == 0)
        {
                val_163 = val_26;
        }
        
        float val_145 = 0f;
        val_145 = val_145 * (-0.5f);
        val_145 = val_145 + val_145;
        val_146 = val_145 + val_145;
        val_26.Add(item:  val_146);
        丅下世下七下七一世 val_37 = val_22.Item[0];
        val_25.Add(item:  0);
        val_162 = 0;
        label_62:
        if(val_161 != 0)
        {
                bool val_40 = val_161.CheckInConstraints(业与三万七丝不万东:  val_7, 丏丕丕七三丛三丑丝: out  0);
        }
        
        int val_42 = this._currentSprite.width;
        int val_43 = this._currentSprite.height;
        UnityEngine.Vector3 val_46 = this._currentSprite.transform.localPosition;
        bool val_47 = this.CheckWeaponPanelCollision(丕万丂丕丁丅专丈不:  this._currentSprite, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, 业与三万七丝不万东:  val_7, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 三丂丏丕与丈丙专丝:  (val_42 != val_43) ? 1 : 0);
        if((val_47 != true) && ((this.丑丒专丙东万丒丂丆 & 1) != 0))
        {
                UnityEngine.Vector3 val_49 = this._currentSprite.transform.localPosition;
            val_167 = this.CheckBRMapCollision(丕万丂丕丁丅专丈不:  this._currentSprite, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, 业与三万七丝不万东:  val_7, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
        }
        else
        {
                val_167 = 0;
        }
        
        var val_51 = (val_42 == val_43) ? 1 : 0;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_83;
        }
        
        }
        
        val_168 = val_47 & val_51;
        val_51 = val_168 | val_167;
        var val_52 = (val_51 != true) ? 0 : (val_162);
        val_52 = val_52 & 1;
        if(val_52 == 0)
        {
            goto label_84;
        }
        
        if(val_47 == false)
        {
            goto label_85;
        }
        
        丆且丞丟丛丗万一世.value = this.丙专丄上丟丕丈丘丗;
        return;
        label_84:
        val_169 = val_7;
        if(((1 & 1) != 0) || (mem[1152921537021937768] == 0))
        {
            goto label_99;
        }
        
        val_170 = 0;
        goto label_91;
        label_98:
        val_167 = new UnityEngine.Vector2[0];
        UnityEngine.Vector2[] val_53 = val_167 + 0;
        val_159 = mem[(val_41 + 0) + 32];
        val_159 = (val_41 + 0) + 32;
        val_145 = mem[(val_41 + 0) + 32 + 4];
        val_145 = (val_41 + 0) + 32 + 4;
        UnityEngine.Vector3 val_54 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_159, y = val_145});
        val_22.Add(item:  new 丅下世下七下七一世() {下丝丟七丅不丁丘丗 = new UnityEngine.Vector2() {x = 0f, y = 0f}, 丏三丞专下一丂丙业 = new System.Nullable<System.Boolean>() {HasValue = false}});
        val_170 = 1;
        label_91:
        if(val_170 < mem[1152921537021937768])
        {
            goto label_98;
        }
        
        val_169 = val_7;
        val_168 = val_168;
        if((val_47 | (~(System.String.IsNullOrEmpty(value:  0)))) != true)
        {
                val_159 = mem[1152921537021937776];
            UnityEngine.Vector3 val_57 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_159, y = mem[1152921537021937780]});
            val_169 = val_7;
            val_25.Add(item:  val_22.IndexOf(item:  new 丅下世下七下七一世() {下丝丟七丅不丁丘丗 = new UnityEngine.Vector2() {x = 0f, y = 0f}, 丏三丞专下一丂丙业 = new System.Nullable<System.Boolean>() {HasValue = false}}));
        }
        
        label_99:
        if(val_168 == false)
        {
            goto label_106;
        }
        
        var val_147 = 12;
        val_147 = this._weaponPanelSprites[0].worldCorners + (((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? (1 + 1) : 1) * val_147);
        UnityEngine.Vector3 val_64 = this._currentSprite.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = (val_62 != true ? (1 + 1) : 1 * 12) + val_61 + 32, y = (val_62 != true ? (1 + 1) : 1 * 12) + val_61 + 32 + 4, z = (val_62 != true ? (1 + 1) : 1 * 12) + val_61 + 40});
        if(val_22 != null)
        {
            goto label_140;
        }
        
        label_141:
        label_140:
        val_22.Add(item:  new 丅下世下七下七一世() {下丝丟七丅不丁丘丗 = new UnityEngine.Vector2() {x = 0f, y = 0f}, 丏三丞专下一丂丙业 = new System.Nullable<System.Boolean>() {HasValue = false}});
        val_174 = val_64.x;
        val_175 = val_64.z;
        int[] val_66 = new int[2];
        val_66[0] = val_25.Item[0];
        val_66[0] = val_22.IndexOf(item:  new 丅下世下七下七一世() {下丝丟七丅不丁丘丗 = new UnityEngine.Vector2() {x = 0f, y = 0f}, 丏三丞专下一丂丙业 = new System.Nullable<System.Boolean>() {HasValue = false}});
        System.Collections.Generic.List<System.Int32> val_68 = new System.Collections.Generic.List<System.Int32>(collection:  val_66);
        val_176 = 0f;
        val_177 = 0f;
        goto label_123;
        label_85:
        this.丙专丄上丟丕丈丘丗 = 丆且丞丟丛丗万一世.value;
        this._currentSprite.width = val_7;
        if(val_9 == 0)
        {
                return;
        }
        
        if(val_9 != null)
        {
                return;
        }
        
        val_9.与不丗上丈丛丈丘丁();
        return;
        label_83:
        val_178 = (float)val_7;
        if((val_9.丞丄丞丝东丝丂丌丂(丙一丐丗专丙丆丒且:  val_178)) == false)
        {
            goto label_129;
        }
        
        val_179 = 丆且丞丟丛丗万一世;
        this._currentSprite.width = val_7;
        val_180 = null;
        if(val_9 == val_180)
        {
            goto label_131;
        }
        
        val_181 = null;
        val_180 = mem[val_9];
        val_180 = val_9;
        goto label_132;
        label_106:
        if((val_167 & 1) == 0)
        {
            goto label_133;
        }
        
        UnityEngine.Vector3[] val_73 = this._brMap.worldCorners;
        UnityEngine.Vector3 val_74 = this._currentSprite.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_73[0], y = val_73[0], z = val_73[1]});
        if(val_22 != null)
        {
            goto label_140;
        }
        
        goto label_141;
        label_129:
        val_179 = 丆且丞丟丛丗万一世;
        val_182 = (ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且;
        if((ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且 != null)
        {
            goto label_143;
        }
        
        val_182 = (ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且;
        if(val_182 == null)
        {
            goto label_220;
        }
        
        label_143:
        val_178 = UnityEngine.Mathf.InverseLerp(a:  (float)(ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且.minValue, b:  (float)(ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且.maxValue, value:  (float)this._currentSprite.width);
        val_179.value = val_178;
        if(val_179 != 0)
        {
            goto label_240;
        }
        
        goto label_150;
        label_133:
        UnityEngine.Vector3 val_78 = this._currentSprite.transform.localPosition;
        UnityEngine.Vector2 val_79 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_78.x, y = val_78.y, z = val_78.z});
        UnityEngine.Vector2 val_81 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_79.x, y = val_79.y}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        float val_151 = (float)val_169;
        val_151 = ((0 == 0) ? 0.1f : 0f) + val_151;
        UnityEngine.Vector2 val_83 = val_81.x.normalized;
        UnityEngine.Vector2 val_84 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_83.x, y = val_83.y}, d:  val_151 * 0.5f);
        val_175 = val_84.x;
        val_174 = 0f;
        UnityEngine.Vector2 val_85 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_175, y = val_84.y});
        val_176 = val_85.x;
        val_177 = val_85.y;
        label_123:
        val_183 = 0;
        goto label_157;
        label_176:
        if((val_25.Contains(item:  0)) == true)
        {
            goto label_169;
        }
        
        丅下世下七下七一世 val_87 = val_22.Item[0];
        val_175 = 0f;
        丅下世下七下七一世 val_89 = val_22.Item[0];
        var val_152 = 1;
        val_152 = val_152 + val_169;
        val_174 = (float)val_152 * 0.5f;
        if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_176, y = val_177}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f})) > val_174)
        {
            goto label_169;
        }
        
        丅下世下七下七一世 val_90 = val_22.Item[0];
        UnityEngine.Vector2 val_91 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_176, y = val_177}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        丅下世下七下七一世 val_93 = val_22.Item[0];
        var val_153 = 1;
        val_153 = val_153 + val_169;
        float val_94 = (float)val_153 * 0.5f;
        UnityEngine.Vector2 val_95 = val_91.x.normalized;
        UnityEngine.Vector2 val_96 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_95.x, y = val_95.y}, d:  val_94);
        val_175 = val_96.x;
        val_184 = val_96.y;
        val_174 = 0f;
        val_185 = 0f;
        UnityEngine.Vector2 val_97 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_175, y = val_184});
        UnityEngine.Vector3 val_98 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_97.x, y = val_97.y});
        if((this.CheckWeaponPanelCollision(丕万丂丕丁丅专丈不:  this._currentSprite, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_98.x, y = val_98.y, z = val_98.z}, 业与三万七丝不万东:  val_169, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 三丂丏丕与丈丙专丝:  (val_42 != val_43) ? 1 : 0)) == true)
        {
            goto label_169;
        }
        
        if((this.丑丒专丙东万丒丂丆 & 1) == 0)
        {
            goto label_174;
        }
        
        UnityEngine.Vector2 val_100 = val_91.x.normalized;
        UnityEngine.Vector2 val_101 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_100.x, y = val_100.y}, d:  val_94);
        val_175 = val_101.x;
        val_184 = val_101.y;
        val_174 = 0f;
        val_185 = 0f;
        UnityEngine.Vector2 val_102 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_175, y = val_184});
        UnityEngine.Vector3 val_103 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_102.x, y = val_102.y});
        if((this.CheckBRMapCollision(丕万丂丕丁丅专丈不:  this._currentSprite, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_103.x, y = val_103.y, z = val_103.z}, 业与三万七丝不万东:  val_169, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f})) == false)
        {
            goto label_174;
        }
        
        label_169:
        val_183 = 1;
        label_157:
        if(val_183 < val_22.Count)
        {
            goto label_176;
        }
        
        label_238:
        val_186 = 0;
        val_187 = 0;
        goto label_177;
        label_195:
        if((val_25.Count >= 2) && ((val_25.Contains(item:  0)) != true))
        {
                丅下世下七下七一世 val_108 = val_22.Item[0];
            val_175 = 0f;
            丅下世下七下七一世 val_110 = val_22.Item[0];
            var val_154 = 1;
            val_154 = val_154 + val_169;
            val_174 = (float)val_154 * 0.5f;
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_176, y = val_177}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f})) <= val_174)
        {
                UnityEngine.Vector3 val_112 = this._currentSprite.transform.localPosition;
            UnityEngine.Vector2 val_113 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_112.x, y = val_112.y, z = val_112.z});
            丅下世下七下七一世 val_114 = val_22.Item[0];
            val_175 = 0f;
            丅下世下七下七一世 val_116 = val_22.Item[0];
            val_188 = val_26;
            if(val_188 == 0)
        {
                val_188 = val_26;
        }
        
            float val_155 = 1f;
            val_155 = val_155 * (-0.5f);
            val_155 = (UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_113.x, y = val_113.y}, b:  new UnityEngine.Vector2() {x = val_175, y = 0f})) + val_155;
            val_174 = val_155 + val_155;
            val_26.Add(item:  val_174);
            val_169 = val_7;
            val_187 = 1;
        }
        
        }
        
        val_186 = 1;
        label_177:
        if(val_186 < val_22.Count)
        {
            goto label_195;
        }
        
        if(val_9 != 0)
        {
                val_174 = val_176;
        }
        
        if(((val_9.CheckInConstraints(七丒业丏上业丛业丅:  new UnityEngine.Vector2() {x = val_174, y = val_177}, 业与三万七丝不万东:  val_169)) == false) || ((val_187 ^ 1 & 1) == 0))
        {
            goto label_201;
        }
        
        this._currentSprite.width = val_169;
        if(val_9 == 0)
        {
            goto label_205;
        }
        
        UnityEngine.Vector3 val_122 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_176, y = val_177});
        val_178 = val_122.x;
        val_9.丒丆一丌丒丗丑丏丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_178, y = val_122.y, z = val_122.z});
        goto label_209;
        label_201:
        System.Collections.Generic.List<TSource> val_125 = System.Linq.Enumerable.ToList<System.Single>(source:  System.Linq.Enumerable.Where<System.Single>(source:  val_26, predicate:  new System.Func<System.Single, System.Boolean>(object:  val_1, method:  System.Boolean ControlSizeController.丌丐丝丐下上三丛丌::丞丒丐丈丌世且丈一(float 与丘东下丈东丛丂万))));
        if(val_125.Count == 0)
        {
                val_174 = (float)(ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且.minValue;
            val_125.Add(item:  val_174);
        }
        
        this._currentSprite.width = UnityEngine.Mathf.FloorToInt(f:  System.Linq.Enumerable.Min(source:  val_125));
        val_189 = (ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且;
        if((ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且 != null)
        {
            goto label_219;
        }
        
        val_189 = (ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且;
        if(val_189 == null)
        {
            goto label_220;
        }
        
        label_219:
        float val_130 = UnityEngine.Mathf.InverseLerp(a:  (float)(ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且.minValue, b:  (float)(ControlSizeController.丌丐丝丐下上三丛丌)[1152921537021761792].丁丒丂丙业丒一七且.maxValue, value:  (float)this._currentSprite.width);
        if(丆且丞丟丛丗万一世 == 0)
        {
            goto label_222;
        }
        
        val_178 = val_130;
        丆且丞丟丛丗万一世.value = val_178;
        goto label_239;
        label_205:
        UnityEngine.Vector3 val_132 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_176, y = val_177});
        val_178 = val_132.x;
        this._currentSprite.transform.localPosition = new UnityEngine.Vector3() {x = val_178, y = val_132.y, z = val_132.z};
        label_209:
        if(丆且丞丟丛丗万一世 != 0)
        {
            goto label_239;
        }
        
        goto label_239;
        label_174:
        UnityEngine.Vector3 val_134 = this._currentSprite.transform.localPosition;
        UnityEngine.Vector2 val_135 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_134.x, y = val_134.y, z = val_134.z});
        丅下世下七下七一世 val_136 = val_22.Item[0];
        丅下世下七下七一世 val_138 = val_22.Item[0];
        val_190 = val_26;
        if(val_190 == 0)
        {
                val_190 = val_26;
        }
        
        float val_156 = 1f;
        val_156 = val_156 * (-0.5f);
        val_156 = (UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_135.x, y = val_135.y}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f})) + val_156;
        val_156 = val_156 + val_156;
        val_26.Add(item:  val_156);
        UnityEngine.Vector2 val_139 = val_91.x.normalized;
        UnityEngine.Vector2 val_140 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_139.x, y = val_139.y}, d:  val_94);
        UnityEngine.Vector2 val_141 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_140.x, y = val_140.y});
        val_25.Add(item:  0);
        goto label_238;
        label_222:
        val_178 = val_130;
        丆且丞丟丛丗万一世.value = val_178;
        goto label_239;
        label_131:
        val_181 = val_180;
        label_132:
        (val_180 == val_181) ? (val_9) : 0.万丛丌三丈一东丆且();
        if(val_179 != 0)
        {
            goto label_240;
        }
        
        label_150:
        label_240:
        label_239:
        this.丙专丄上丟丕丈丘丗 = val_179.value;
        return;
        label_220:
    }
    private bool 东专业一万丗丂且丄(ButtonJoystickAdjust 丆丑丛丞东丂丒丟丁, 丅下世下七下七一世 丅丆东丏丙丝丅丆丟)
    {
        UnityEngine.Object val_3;
        var val_4;
        val_3 = 丆丑丛丞东丂丒丟丁;
        if((val_3 != 0) && ((1152921537022434292 & 1) != 0))
        {
                bool val_4 = 丆丑丛丞东丂丒丟丁.IsDefaultPosLeft;
            val_4 = ((val_4 == true) ? 1 : 0) ^ 1152921537022434292;
            val_4 = val_4 ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 1;
        return (bool)val_4 & 1;
    }
    public bool CheckWeaponPanelCollision(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东, bool 三丂丏丕与丈丙专丝 = False)
    {
        return (bool)this.CheckWeaponPanelCollision(丕万丂丕丁丅专丈不:  丕万丂丕丁丅专丈不, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 业与三万七丝不万东:  业与三万七丝不万东, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 三丂丏丕与丈丙专丝:  三丂丏丕与丈丙专丝);
    }
    public bool CheckWeaponPanelCollision(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东, out UnityEngine.Vector2 七丒业丏上业丛业丅, bool 三丂丏丕与丈丙专丝 = False)
    {
        bool val_64;
        UISprite val_65;
        float val_66;
        float val_67;
        UISprite val_68;
        float val_69;
        var val_70;
        var val_71;
        var val_74;
        int val_76;
        int val_77;
        var val_78;
        float val_79;
        var val_80;
        val_64 = 三丂丏丕与丈丙专丝;
        val_65 = 1152921537022883536;
        val_66 = 业丒丝丗与丐丛丟丏.z;
        val_67 = 业丒丝丗与丐丛丟丏.y;
        val_68 = 丕万丂丕丁丅专丈不;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        七丒业丏上业丛业丅.x = val_1.x;
        七丒业丏上业丛业丅.y = val_1.y;
        if((val_68.Equals(other:  this._weaponPanel)) == false)
        {
            goto label_4;
        }
        
        var val_62 = 0;
        label_13:
        if(val_62 >= this.丞丅业丕业专丒丈丛.Length)
        {
            goto label_6;
        }
        
        val_65 = this.丞丅业丕业专丒丈丛[0];
        val_68 = val_65.transform;
        UnityEngine.Vector3 val_4 = val_68.localPosition;
        val_69 = val_4.z;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_69});
        val_66 = val_5.x;
        val_62 = val_62 + 1;
        if((this.丏丕丒三丟丆丒丕万(丕万丂丕丁丅专丈不:  val_65, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = val_66, y = val_5.y}, 业与三万七丝不万东:  val_65.width, 丕万丘下万丑丄丕专: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 不不专东丆专丗丟丅:  false, 三丂丏丕与丈丙专丝:  val_64, 丒丄丈丏丁丟丆丙且:  业与三万七丝不万东, 三丑丕丌丄丞丑丒丝:  0)) == false)
        {
            goto label_13;
        }
        
        goto label_97;
        label_4:
        if(val_64 == false)
        {
            goto label_15;
        }
        
        val_70 = 1;
        goto label_16;
        label_6:
        val_71 = 0;
        return (bool)val_71;
        label_15:
        val_64 = val_68.GetComponent<ButtonJoystickAdjust>();
        var val_10 = (val_9.IsDefaultPosLeft == false) ? 1 : 0;
        label_16:
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = val_67, z = val_66});
        val_71 = 0;
        if((this.丏丕丒三丟丆丒丕万(丕万丂丕丁丅专丈不:  val_68, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, 业与三万七丝不万东:  业与三万七丝不万东, 丕万丘下万丑丄丕专: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 不不专东丆专丗丟丅:  false, 三丂丏丕与丈丙专丝:  false, 丒丄丈丏丁丟丆丙且:  0, 三丑丕丌丄丞丑丒丝:  0)) == false)
        {
                return (bool)val_71;
        }
        
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = val_67, z = val_66});
        UnityEngine.Vector3 val_15 = val_68.transform.localPosition;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3[] val_19 = this._weaponPanel.localCorners;
        UnityEngine.Vector3 val_20 = this._weaponPanel.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_19[1], y = val_19[2], z = val_19[2]});
        val_64 = this._weaponPanel.localCorners;
        UnityEngine.Vector3 val_24 = this._weaponPanel.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_64[3], y = val_64[3], z = val_64[4]});
        UnityEngine.Vector3 val_27 = val_68.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        UnityEngine.Vector3 val_30 = val_68.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        val_68 = val_68.gameObject.GetComponent<ButtonJoystickAdjust>();
        float val_33 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = val_67, z = val_66}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        float val_34 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = val_67, z = val_66}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        var val_36 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f;
        var val_37 = (val_33 < 0) ? (-val_36) : (val_36);
        if(((val_68 != null) && (val_68 != 0)) && (null == null))
        {
                float val_40 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? -1f : 1f;
        }
        
        if(((-1943750072) & 1) == 0)
        {
            goto label_53;
        }
        
        val_69 = 0f;
        val_66 = 0f;
        UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, b:  new UnityEngine.Vector2() {x = val_69, y = val_66});
        float val_42 = val_40 * val_41.x;
        if(val_42 <= 0f)
        {
            goto label_56;
        }
        
        float val_69 = (float)业与三万七丝不万东;
        val_69 = val_69 * 0.5f;
        val_69 = val_69 * val_40;
        val_69 = val_69 + val_69;
        goto label_57;
        label_53:
        UnityEngine.Vector2 val_43 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        val_68 = 1152921504838422528;
        val_74 = null;
        val_74 = null;
        float val_70 = System.Math.Abs(val_43.x);
        if(val_70 <= System.Math.Abs(val_43.y))
        {
            goto label_62;
        }
        
        val_69 = 0f;
        if(System.Math.Abs(val_16.y) <= System.Math.Abs(val_69))
        {
            goto label_65;
        }
        
        float val_74 = val_13.y;
        float val_44 = (val_74 >= 0f) ? (val_74) : 0f;
        val_74 = val_44 - val_69;
        float[] val_45 = new float[2];
        val_68 = val_45;
        val_76 = val_45.Length;
        float val_75 = System.Math.Abs(val_44);
        if(val_76 == 0)
        {
                val_76 = val_45.Length;
        }
        
        float val_46 = (float)业与三万七丝不万东 * 0.5f;
        val_68[0] = val_75;
        val_68[1] = val_46;
        val_66 = System.Linq.Enumerable.Min(source:  val_45);
        float[] val_48 = new float[2];
        val_77 = val_48.Length;
        if(val_77 == 0)
        {
                val_77 = val_48.Length;
        }
        
        val_48[0] = val_75;
        val_48[1] = val_46;
        float val_50 = val_48.七丙丝万丙且丏丗三(丆丛丑世下一丐且丕:  val_66, 丁丂专业丁丅丅丈丙:  System.Linq.Enumerable.Max(source:  val_48));
        val_50 = val_40 * val_50;
        float val_51 = val_75 + val_69;
        val_50 = 0f + val_50;
        goto label_77;
        label_56:
        label_57:
        if(val_41.y <= 0f)
        {
            goto label_77;
        }
        
        if(val_42 <= 0f)
        {
            goto label_76;
        }
        
        goto label_77;
        label_62:
        val_74 = null;
        if(val_70 >= 0)
        {
            goto label_97;
        }
        
        var val_52 = (val_33 < 0) ? 1 : 0;
        if((val_10 | val_52) != 1)
        {
            goto label_85;
        }
        
        val_52 = val_10 & val_52;
        if(val_52 != 0)
        {
            goto label_85;
        }
        
        float val_76 = System.Math.Abs(0f);
        if(System.Math.Abs(val_16.x) >= val_76)
        {
            goto label_85;
        }
        
        val_76 = val_76 - System.Math.Abs(val_13.x);
        if(val_76 >= 0f)
        {
            goto label_88;
        }
        
        if((double)val_76 != (-0.5))
        {
            goto label_89;
        }
        
        val_78 = 0;
        val_79 = (float)0;
        val_80 = val_79 + (-1f);
        goto label_90;
        label_65:
        val_66 = 0f;
        UnityEngine.Vector2 val_54 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_66, y = val_69}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        UnityEngine.Vector2 val_55 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_66, y = val_69}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        float val_57 = val_54.x.sqrMagnitude;
        float val_79 = 3f;
        val_79 = val_55.x.sqrMagnitude * val_79;
        if(val_79 >= 0)
        {
            goto label_93;
        }
        
        float val_80 = (float)业与三万七丝不万东;
        val_80 = val_80 * 0.5f;
        val_80 = val_80 + val_69;
        goto label_99;
        label_76:
        float val_81 = (float)业与三万七丝不万东;
        val_81 = val_81 * 0.5f;
        val_81 = val_81 + val_66;
        label_77:
        label_99:
        label_103:
        UnityEngine.Vector2 val_58 = new UnityEngine.Vector2(x:  val_13.x, y:  val_81);
        七丒业丏上业丛业丅.x = val_58.x;
        label_97:
        val_71 = 1;
        return (bool)val_71;
        label_85:
        float val_83 = 0f;
        float val_82 = (float)业与三万七丝不万东;
        val_82 = val_82 * 0.5f;
        val_83 = val_82 + val_83;
        goto label_99;
        label_93:
        float val_84 = (float)业与三万七丝不万东;
        val_84 = val_84 * 0.5f;
        val_84 = val_84 * val_40;
        val_84 = val_84 + val_66;
        goto label_99;
        label_88:
        if((double)val_76 != 0.5)
        {
            goto label_100;
        }
        
        val_78 = 0;
        val_79 = (float)0;
        val_80 = val_79 + 1f;
        label_90:
        var val_59 = ((val_78 & (1.401298E-45f)) != 0) ? (val_79) : (val_80);
        goto label_102;
        label_89:
        float val_85 = -0.5f;
        val_85 = val_76 + val_85;
        goto label_102;
        label_100:
        float val_86 = 0.5f;
        val_86 = val_76 + val_86;
        label_102:
        float val_87 = 0.5f;
        val_87 = (float)业与三万七丝不万东 * val_87;
        float val_88 = 0f;
        float val_61 = val_40 * val_76;
        val_61 = val_61 + 0f;
        val_88 = (0.七丙丝万丙且丏丗三(丆丛丑世下一丐且丕:  val_76, 丁丂专业丁丅丅丈丙:  val_87)) + val_88;
        goto label_103;
    }
    public bool CheckBRMapCollision(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东)
    {
        return (bool)this.CheckBRMapCollision(丕万丂丕丁丅专丈不:  丕万丂丕丁丅专丈不, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 业与三万七丝不万东:  业与三万七丝不万东, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
    }
    public bool CheckBRMapCollision(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东, out UnityEngine.Vector2 七丒业丏上业丛业丅)
    {
        float val_37;
        float val_38;
        UISprite val_39;
        UISprite val_40;
        var val_43;
        var val_44;
        int val_46;
        int val_47;
        float val_48;
        long val_49;
        float val_50;
        var val_51;
        val_37 = 业丒丝丗与丐丛丟丏.z;
        val_38 = 业丒丝丗与丐丛丟丏.x;
        val_39 = 丕万丂丕丁丅专丈不;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        七丒业丏上业丛业丅.x = val_1.x;
        七丒业丏上业丛业丅.y = val_1.y;
        val_40 = this._weaponPanel;
        if((val_39.Equals(other:  val_40)) == true)
        {
            goto label_8;
        }
        
        ButtonJoystickAdjust val_3 = val_39.GetComponent<ButtonJoystickAdjust>();
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_38, y = 业丒丝丗与丐丛丟丏.y, z = val_37});
        if((this.丆丈丅丈专专不丙丟(丕万丂丕丁丅专丈不:  val_39, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, 业与三万七丝不万东:  业与三万七丝不万东, 且丆丛世专丌丝丈丙: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 不不专东丆专丗丟丅:  (val_3.IsDefaultPosLeft == true) ? 1 : 0)) == false)
        {
            goto label_8;
        }
        
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_38, y = 业丒丝丗与丐丛丟丏.y, z = val_37});
        val_39 = val_39.transform;
        UnityEngine.Vector3 val_9 = val_39.localPosition;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_37 = val_10.x;
        var val_12 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f;
        if(((-1943284376) & 1) == 0)
        {
            goto label_14;
        }
        
        val_37 = 0f;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = val_37}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        val_38 = val_14.x;
        if(val_38 <= 0f)
        {
            goto label_19;
        }
        
        float val_35 = (float)业与三万七丝不万东;
        val_35 = val_35 * 0.5f;
        val_35 = val_35 * ((val_3.IsDefaultPosLeft == true) ? ((((val_3.IsDefaultPosLeft == true) ? 1 : 0) != 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() ^ 1) ? -1f : ((val_3.IsDefaultPosLeft == true) ? (-val_12) : (val_12))) : -1f);
        val_35 = val_35 + 0f;
        goto label_20;
        label_8:
        val_43 = 0;
        return (bool)val_43;
        label_14:
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_37, y = val_10.y});
        val_39 = 1152921504838422528;
        val_44 = null;
        val_44 = null;
        val_38 = System.Math.Abs(val_20.x);
        if(val_38 <= System.Math.Abs(val_20.y))
        {
            goto label_26;
        }
        
        val_38 = 0f;
        if(System.Math.Abs(val_10.y) >= System.Math.Abs(val_38))
        {
            goto label_29;
        }
        
        float val_39 = val_7.y;
        float val_21 = (val_39 >= 0f) ? (val_39) : 0f;
        val_39 = val_38 - val_21;
        float[] val_22 = new float[2];
        val_39 = val_22;
        val_46 = val_22.Length;
        float val_40 = System.Math.Abs(val_21);
        if(val_46 == 0)
        {
                val_46 = val_22.Length;
        }
        
        float val_23 = (float)业与三万七丝不万东 * 0.5f;
        val_39[0] = val_40;
        val_39[1] = val_23;
        val_37 = System.Linq.Enumerable.Min(source:  val_22);
        float[] val_25 = new float[2];
        val_47 = val_25.Length;
        if(val_47 == 0)
        {
                val_47 = val_25.Length;
        }
        
        val_25[0] = val_40;
        val_25[1] = val_23;
        float val_27 = val_25.七丙丝万丙且丏丗三(丆丛丑世下一丐且丕:  val_37, 丁丂专业丁丅丅丈丙:  System.Linq.Enumerable.Max(source:  val_25));
        float val_28 = val_38 - val_40;
        val_27 = 0f - val_27;
        goto label_41;
        label_19:
        label_20:
        if(val_14.y <= 0f)
        {
            goto label_41;
        }
        
        if(val_38 <= 0f)
        {
            goto label_40;
        }
        
        goto label_41;
        label_26:
        if(val_38 >= 0)
        {
            goto label_56;
        }
        
        if(val_3.IsDefaultPosLeft == false)
        {
            goto label_45;
        }
        
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false)
        {
            goto label_48;
        }
        
        label_59:
        val_48 = 0f;
        if(System.Math.Abs(val_37) < System.Math.Abs(val_48))
        {
            goto label_51;
        }
        
        label_62:
        float val_44 = 0f;
        float val_43 = (float)业与三万七丝不万东;
        val_43 = val_43 * (-0.5f);
        val_44 = val_44 + val_43;
        goto label_53;
        label_29:
        float val_46 = 0f;
        float val_45 = (float)业与三万七丝不万东;
        val_45 = val_45 * (-0.5f);
        val_46 = val_46 + val_45;
        goto label_53;
        label_40:
        float val_47 = (float)业与三万七丝不万东;
        val_47 = val_47 * (-0.5f);
        val_47 = val_37 + val_47;
        label_41:
        label_53:
        label_71:
        UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  val_7.x, y:  val_47);
        七丒业丏上业丛业丅.x = val_30.x;
        label_56:
        val_43 = 1;
        return (bool)val_43;
        label_45:
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == false)
        {
            goto label_59;
        }
        
        label_48:
        val_48 = 0f;
        if(System.Math.Abs(val_37) <= System.Math.Abs(val_48))
        {
            goto label_62;
        }
        
        label_51:
        float val_32 = System.Math.Abs(val_48) - System.Math.Abs(val_7.x);
        if(val_32 >= 0f)
        {
            goto label_65;
        }
        
        if((double)val_32 != (-0.5))
        {
            goto label_66;
        }
        
        val_49 = (long)val_30.x;
        val_50 = (float)val_30.x;
        val_51 = val_50 + (-1f);
        goto label_67;
        label_65:
        if((double)val_32 != 0.5)
        {
            goto label_68;
        }
        
        val_49 = (long)val_30.x;
        val_50 = (float)val_30.x;
        val_51 = val_50 + 1f;
        label_67:
        val_50 = ((val_49 & (1.401298E-45f)) != 0) ? (val_50) : (val_51);
        goto label_70;
        label_66:
        float val_52 = -0.5f;
        val_52 = val_32 + val_52;
        goto label_70;
        label_68:
        float val_53 = 0.5f;
        val_53 = val_32 + val_53;
        label_70:
        float val_54 = System.Math.Abs(val_53);
        float val_55 = 0.5f;
        val_55 = (float)业与三万七丝不万东 * val_55;
        float val_56 = 0f;
        float val_34 = val_48 - val_54;
        val_56 = val_56 - (val_30.x.七丙丝万丙且丏丗三(丆丛丑世下一丐且丕:  val_54, 丁丂专业丁丅丅丈丙:  val_55));
        goto label_71;
    }
    private float 七丙丝万丙且丏丗三(float 丆丛丑世下一丐且丕, float 丁丂专业丁丅丅丈丙)
    {
        float val_1 = 丁丂专业丁丅丅丈丙 * 丁丂专业丁丅丅丈丙;
        float val_2 = 丆丛丑世下一丐且丕 * 丆丛丑世下一丐且丕;
        val_1 = val_1 - val_2;
        if(val_2 <= _TYPE_MAX_)
        {
                return val_2;
        }
    
    }
    private bool 丏丕丒三丟丆丒丕万(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector2 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东)
    {
        return (bool)this.丏丕丒三丟丆丒丕万(丕万丂丕丁丅专丈不:  丕万丂丕丁丅专丈不, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y}, 业与三万七丝不万东:  业与三万七丝不万东, 丕万丘下万丑丄丕专: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 不不专东丆专丗丟丅:  false, 三丂丏丕与丈丙专丝:  false, 丒丄丈丏丁丟丆丙且:  0, 三丑丕丌丄丞丑丒丝:  0);
    }
    private bool 丏丕丒三丟丆丒丕万(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector2 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东, bool 三丂丏丕与丈丙专丝 = False, int 丒丄丈丏丁丟丆丙且 = 0, int 三丑丕丌丄丞丑丒丝 = 0)
    {
        return (bool)this.丏丕丒三丟丆丒丕万(丕万丂丕丁丅专丈不:  丕万丂丕丁丅专丈不, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y}, 业与三万七丝不万东:  业与三万七丝不万东, 丕万丘下万丑丄丕专: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 不不专东丆专丗丟丅:  false, 三丂丏丕与丈丙专丝:  三丂丏丕与丈丙专丝, 丒丄丈丏丁丟丆丙且:  丒丄丈丏丁丟丆丙且, 三丑丕丌丄丞丑丒丝:  0);
    }
    private bool 丏丕丒三丟丆丒丕万(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector2 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东, out UnityEngine.Vector2 丕万丘下万丑丄丕专, bool 不不专东丆专丗丟丅 = False, bool 三丂丏丕与丈丙专丝 = False, int 丒丄丈丏丁丟丆丙且 = 0, int 三丑丕丌丄丞丑丒丝 = 0)
    {
        var val_50;
        var val_51;
        float val_52;
        var val_53;
        var val_54;
        UISprite val_51 = this._weaponPanelSprites[0];
        if(val_51 != null)
        {
                val_50 = val_51.width;
            val_51 = val_51;
        }
        else
        {
                val_50 = 0.width;
            val_51 = 0;
        }
        
        if(三丂丏丕与丈丙专丝 != false)
        {
                float val_52 = this.世丝上丙丛东丌下丈;
            val_52 = val_52 * (float)丒丄丈丏丁丟丆丙且;
            val_52 = val_52 * this.丛丑且丛丈丝不丙丈;
        }
        else
        {
                val_52 = (float)val_51.height;
        }
        
        UnityEngine.Vector3[] val_6 = this._weaponPanel.localCorners;
        UnityEngine.Vector3 val_7 = this._weaponPanel.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_6[1], y = val_6[2], z = val_6[2]});
        UnityEngine.Vector3[] val_10 = this._weaponPanel.localCorners;
        UnityEngine.Vector3 val_11 = this._weaponPanel.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_10[3], y = val_10[3], z = val_10[4]});
        UnityEngine.Vector3 val_14 = 丕万丂丕丁丅专丈不.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        float val_61 = val_14.z;
        UnityEngine.Vector3 val_17 = 丕万丂丕丁丅专丈不.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        ButtonJoystickAdjust val_19 = 丕万丂丕丁丅专丈不.gameObject.GetComponent<ButtonJoystickAdjust>();
        UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y});
        float val_23 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        var val_25 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f;
        float val_26 = ((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_61})) < 0) ? (-val_25) : (val_25);
        if((val_19 != null) && (val_19 != 0))
        {
                if(null == null)
        {
            goto label_37;
        }
        
        }
        
        if(丕万丂丕丁丅专丈不 != null)
        {
            goto label_54;
        }
        
        label_55:
        label_54:
        UnityEngine.Vector3 val_30 = val_51.worldCenter;
        UnityEngine.Vector3 val_31 = 丕万丂丕丁丅专丈不.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        int val_59 = (float)val_50;
        int val_60 = val_52;
        val_59 = val_59 * 0.5f;
        val_60 = val_60 * 0.5f;
        val_61 = val_59 * val_26;
        float val_33 = val_60 + val_32.y;
        val_59 = val_61 + val_32.x;
        UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  val_59, y:  val_33);
        丕万丘下万丑丄丕专.x = val_34.x;
        UnityEngine.Vector2 val_36 = new UnityEngine.Vector2(x:  val_32.x - val_61, y:  val_33);
        float val_62 = (float)业与三万七丝不万东;
        float val_37 = val_62 * 0.5f;
        float val_38 = val_37 * val_26;
        float val_39 = 业丒丝丗与丐丛丟丏.y - val_37;
        val_62 = 业丒丝丗与丐丛丟丏.x - val_38;
        UnityEngine.Vector2 val_40 = new UnityEngine.Vector2(x:  val_62, y:  val_39);
        UnityEngine.Vector2 val_42 = new UnityEngine.Vector2(x:  业丒丝丗与丐丛丟丏.x + val_38, y:  val_39);
        if(System.Math.Abs(val_40.x) > System.Math.Abs(丕万丘下万丑丄丕专.x))
        {
                var val_43 = (val_40.y < 0) ? 1 : 0;
        }
        else
        {
                val_53 = 0;
        }
        
        if(System.Math.Abs(val_42.x) > System.Math.Abs(val_36.x))
        {
                var val_44 = (val_42.y < 0) ? 1 : 0;
            return (bool)(((val_54 | val_53) != 0) ? 1 : 0) & (((val_54 & val_53) != 0) ? 1 : 0);
        }
        
        val_54 = 0;
        return (bool)(((val_54 | val_53) != 0) ? 1 : 0) & (((val_54 & val_53) != 0) ? 1 : 0);
        label_37:
        var val_50 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? (val_26) : 1f;
        if(丕万丂丕丁丅专丈不 != null)
        {
            goto label_54;
        }
        
        goto label_55;
    }
    private bool 丆丈丅丈专专不丙丟(UISprite 丕万丂丕丁丅专丈不, UnityEngine.Vector2 业丒丝丗与丐丛丟丏, int 业与三万七丝不万东, out UnityEngine.Vector2 且丆丛世专丌丝丈丙, bool 不不专东丆专丗丟丅 = False)
    {
        float val_17;
        var val_18;
        bool val_3 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        UnityEngine.Vector3 val_6 = this._brMap.worldCenter;
        UnityEngine.Vector3 val_7 = 丕万丂丕丁丅专丈不.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_8.x = val_8.x - ((float)this._brMap.width * 0.5f);
        val_8.y = val_8.y - ((float)this._brMap.height * 0.5f);
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
        float val_17 = (float)业与三万七丝不万东;
        float val_12 = val_17 * 0.5f;
        val_17 = 业丒丝丗与丐丛丟丏.x + val_12;
        val_12 = 业丒丝丗与丐丛丟丏.y + val_12;
        且丆丛世专丌丝丈丙.x = val_11.x;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_17, y:  val_12);
        if(不不专东丆专丗丟丅 == false)
        {
            goto label_11;
        }
        
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == true)
        {
            goto label_14;
        }
        
        label_21:
        val_17 = val_13.x;
        float val_19 = System.Math.Abs(且丆丛世专丌丝丈丙.x);
        if(System.Math.Abs(val_17) >= 0)
        {
            goto label_17;
        }
        
        label_24:
        var val_15 = (val_13.y > 且丆丛世专丌丝丈丙.y) ? 1 : 0;
        return (bool)val_18;
        label_11:
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == true)
        {
            goto label_21;
        }
        
        label_14:
        val_17 = val_13.x;
        if(System.Math.Abs(val_17) > System.Math.Abs(且丆丛世专丌丝丈丙.x))
        {
            goto label_24;
        }
        
        label_17:
        val_18 = 0;
        return (bool)val_18;
    }
    private void 世丟与丁一丝丈丞上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(不丟丗丏丛丕不丁丌 != null)
        {
                UnityEngine.Object val_3 = (null == null) ? (不丟丗丏丛丕不丁丌) : 0;
        }
        
        if(val_3 == 0)
        {
                return;
        }
        
        UISprite val_5 = val_3.GetComponent<UISprite>();
        if(val_5 == 0)
        {
                return;
        }
        
        this.丅丄万丌丟丗东丏丈(与丄丈丘丟丕丏丐丁:  val_5);
    }
    public void HandleControlButton(UISprite 与丄丈丘丟丕丏丐丁, UISlider 丆且丞丟丛丗万一世)
    {
    
    }
    public void HandleSaveButton()
    {
        UnityEngine.Debug.Log(message:  "[Save] Pressed.");
        this.SaveControlSize();
    }
    public void HandleDefaultButton()
    {
        UnityEngine.Debug.Log(message:  "[Default] Pressed.");
        if((this.view != 0) && (this.view.buttons != null))
        {
                this.东丂丂丆下业丟丄丟();
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "view == null || view.buttons == null");
    }
    private void 东丂丂丆下业丟丄丟()
    {
        var val_5;
        var val_6;
        val_5 = 0;
        val_6 = 0;
        goto label_1;
        label_41:
        if(this.view.buttons[0] != 0)
        {
                this.view.buttons[0].width = this.丑丒专丙东万丒丂丆.丛丝七丌丁丑丆丞下[0];
            this.丑万丒丏七丝丁丘丕(与丄丈丘丟丕丏丐丁:  this.view.buttons[0], 下丌丟丏丏丘专丒专:  this.丑丒专丙东万丒丂丆.丕丑丈丄丄丒世业丐[0]);
            if(this._currentSprite == this.view.buttons[0])
        {
                this.丅丄万丌丟丗东丏丈(与丄丈丘丟丕丏丐丁:  this._currentSprite);
        }
        
            LootButtonAdjust val_3 = this.view.buttons[0].GetComponent<LootButtonAdjust>();
            if(val_3 != null)
        {
                (val_3 == 0) ? (val_5) : (val_3).丘丂丕丅上丘丝丏世(丙业与丙丗丝不丈东:  this);
            val_5 = val_3;
        }
        
        }
        
        val_6 = 1;
        label_1:
        if(val_6 >= this.view.buttons.Length)
        {
                return;
        }
        
        if(val_6 >= this.丑丒专丙东万丒丂丆.丛丝七丌丁丑丆丞下.Length)
        {
                return;
        }
        
        if(val_6 < this.丑丒专丙东万丒丂丆.丕丑丈丄丄丒世业丐.Length)
        {
            goto label_41;
        }
    
    }
    public void HandleCancelButton()
    {
        UnityEngine.Debug.Log(message:  "[Cancel] Pressed.");
    }
    public void SaveControlSize()
    {
        var val_8;
        System.Func<UISprite, System.Int32> val_10;
        if(this.view == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "view == null");
            return;
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = ControlSizeController.<>c.<>9__39_0;
        if(val_10 == null)
        {
                System.Func<UISprite, System.Int32> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<UISprite, System.Int32>(object:  ControlSizeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ControlSizeController.<>c::丛下专丈与丙万丗丈(UISprite 丏丛与丅丛丌万专丌));
            ControlSizeController.<>c.<>9__39_0 = val_10;
        }
        
        TSource[] val_4 = System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<UISprite, System.Int32>(source:  this.view.buttons, selector:  val_2));
        TSource[] val_7 = System.Linq.Enumerable.ToArray<System.Single>(source:  System.Linq.Enumerable.Select<UISprite, System.Single>(source:  this.view.buttons, selector:  new System.Func<UISprite, System.Single>(object:  this, method:  System.Single ControlSizeController::丄丅一丏丙丝丙世丝(UISprite 丏丛与丅丛丌万专丌))));
        if(this.丑丒专丙东万丒丂丆 == null)
        {
            
        }
    
    }
    internal static ControlSizeController 丑七不且上丗丁一世()
    {
        return (ControlSizeController)ControlSizeController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    internal static void 丒且丒丗丗丟下丗丝(ControlSizeController 丙业与丙丗丝不丈东)
    {
        ControlSizeController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        var val_23;
        var val_24;
        System.Func<UISprite, System.Boolean> val_26;
        System.EventHandler<System.EventArgs> val_27;
        System.EventHandler<System.EventArgs> val_28;
        if((UnityEngine.Object.op_Implicit(exists:  ControlSizeController.<不丁丄七丛不丆丁丕>k__BackingField)) != true)
        {
                ControlSizeController.<不丁丄七丛不丆丁丕>k__BackingField = this;
        }
        
        if(((this.view == 0) || (this.view.slider == 0)) || (this.view.sliderAlpha == 0))
        {
            goto label_16;
        }
        
        System.Collections.Generic.List<UISprite> val_5 = new System.Collections.Generic.List<UISprite>();
        val_23 = 0;
        goto label_18;
        label_29:
        UISprite val_23 = this.view.buttons[0];
        if(val_23 != 0)
        {
                if((val_23.GetComponent<ButtonJoystickAdjust>()) != 0)
        {
                val_5.Add(item:  val_23);
        }
        
        }
        
        val_23 = 1;
        label_18:
        if(val_23 < this.view.buttons.Length)
        {
            goto label_29;
        }
        
        T[] val_9 = val_5.ToArray();
        this.丞丅业丕业专丒丈丛 = val_9;
        val_24 = null;
        val_24 = null;
        val_26 = ControlSizeController.<>c.<>9__44_0;
        if(val_26 == null)
        {
                System.Func<UISprite, System.Boolean> val_10 = null;
            val_26 = val_10;
            val_10 = new System.Func<UISprite, System.Boolean>(object:  ControlSizeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ControlSizeController.<>c::丕下丐丑业丛丄三丈(UISprite 丌丗丏丏丛东专丁且));
            ControlSizeController.<>c.<>9__44_0 = val_26;
        }
        
        this.与与丐丒丑丙丒丙东 = System.Linq.Enumerable.ToArray<System.Boolean>(source:  System.Linq.Enumerable.Select<UISprite, System.Boolean>(source:  val_9, selector:  val_10));
        float val_26 = (float)this._weaponPanelSprites[0].height;
        val_26 = val_26 / (float)this._weaponPanelSprites[0].width;
        this.丛丑且丛丈丝不丙丈 = val_26;
        float val_28 = (float)this._weaponPanelSprites[0].width;
        val_28 = val_28 / (float)this._weaponPanel.width;
        this.世丝上丙丛东丌下丈 = val_28;
        label_16:
        if(((System.Delegate.Combine(a:  ButtonJoystickAdjust.世丗一上丑上丑丄一, b:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void ControlSizeController::世丟与丁一丝丈丞上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)))) != null) && (null != null))
        {
                val_27 = 0;
        }
        
        ButtonJoystickAdjust.世丗一上丑上丑丄一 = val_27;
        if(((System.Delegate.Combine(a:  PressDetector.世丗一上丑上丑丄一, b:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void ControlSizeController::世丟与丁一丝丈丞上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)))) != null) && (null != null))
        {
                val_28 = 0;
        }
        
        PressDetector.世丗一上丑上丑丄一 = val_28;
        SettingsController.丏不丗一丝丅丛丟丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ControlSizeController::CheckAllButtonsForCollision()));
    }
    private void OnDestroy()
    {
        System.EventHandler<System.EventArgs> val_7;
        System.EventHandler<System.EventArgs> val_8;
        if(((System.Delegate.Remove(source:  ButtonJoystickAdjust.世丗一上丑上丑丄一, value:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void ControlSizeController::世丟与丁一丝丈丞上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)))) != null) && (null != null))
        {
                val_7 = 0;
        }
        
        ButtonJoystickAdjust.世丗一上丑上丑丄一 = val_7;
        if(((System.Delegate.Remove(source:  PressDetector.世丗一上丑上丑丄一, value:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void ControlSizeController::世丟与丁一丝丈丞上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)))) != null) && (null != null))
        {
                val_8 = 0;
        }
        
        PressDetector.世丗一上丑上丑丄一 = val_8;
        SettingsController.丛丛且与专丙丕丘丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ControlSizeController::CheckAllButtonsForCollision()));
        if(this.专业上下丘丟东上丁 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.专业上下丘丟东上丁);
    }
    internal void 下丁万万丅丆东不不()
    {
        this.东丂丂丆下业丟丄丟();
        this.丅丄万丌丟丗东丏丈(与丄丈丘丟丕丏丐丁:  this.view.buttons[0]);
    }
    internal static void 业丈丝丐丛丄丈丈丙(bool 与专一业丏三丒万下, System.Action 丕丒上丄丒业丕丕丐)
    {
        bool val_1 = 与专一业丏三丒万下;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Left Handed] button clicked: "("[Left Handed] button clicked: ") + val_1.ToString());
        }
        
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() == val_1)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丙丗专东丂丁一一丛(丙业与丙丗丝不丈东:  (val_1 == true) ? 1 : 0);
        if(丕丒上丄丒业丕丕丐 != null)
        {
                丕丒上丄丒业丕丕丐.Invoke();
        }
        
        if(val_1 == true)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Left-handed Layout Enabled");
    }
    private void 与丞丂丆世丒世丘丏(UISlider 丆且丞丟丛丗万一世, bool 专丛丅东丂七丐业丂 = False)
    {
        int val_8;
        float val_9;
        int val_10;
        val_8 = 专丛丅东丂七丐业丂;
        if(丆且丞丟丛丗万一世 == 0)
        {
                return;
        }
        
        bool val_2 = UnityEngine.Object.op_Equality(x:  this._currentSprite, y:  0);
        if(val_2 == false)
        {
            goto label_6;
        }
        
        label_16:
        if(丆且丞丟丛丗万一世 != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_6:
        if(val_8 == false)
        {
            goto label_9;
        }
        
        float val_3 = val_2.丛且丁且丞与下丂世(丟丒丞丐丐丘丒丄东:  this._currentSprite);
        val_9 = this.丗丂丘不业丈丐丁东;
        goto label_12;
        label_9:
        ControlSize val_4 = this._currentSprite.GetComponent<ControlSize>();
        if(val_4 == 0)
        {
            goto label_16;
        }
        
        if(val_4 != null)
        {
                val_10 = val_4.minValue;
        }
        else
        {
                val_10 = 64;
        }
        
        val_8 = val_4.maxValue;
        val_9 = 64f;
        label_12:
        label_8:
        丆且丞丟丛丗万一世.value = UnityEngine.Mathf.InverseLerp(a:  val_9, b:  (float)val_8, value:  (float)this._currentSprite.width);
    }
    private float 丛且丁且丞与下丂世(UISprite 丟丒丞丐丐丘丒丄东)
    {
        if(val_2.Length == 0)
        {
                return (float)1f;
        }
        
        if(val_2.Length < 1)
        {
                return (float)1f;
        }
        
        do
        {
            T val_11 = 丟丒丞丐丐丘丒丄东.gameObject.GetComponentsInChildren<UIBasicSprite>()[0];
            if(val_11.gameObject != 丟丒丞丐丐丘丒丄东.gameObject)
        {
                if((System.String.op_Inequality(a:  val_11.gameObject.name, b:  "BackGround")) == true)
        {
            goto label_14;
        }
        
        }
        
        }
        while((0 + 1) < val_2.Length);
        
        return (float)1f;
        label_14:
        UnityEngine.Color val_10 = val_11.color;
        1f = val_10.a;
        return (float)1f;
    }
    private void 丅丄万丌丟丗东丏丈(UISprite 与丄丈丘丟丕丏丐丁)
    {
        ControlSizeView val_30;
        var val_31;
        ControlSizeView val_32;
        UISlider val_33;
        var val_34;
        System.Func<UISprite, System.Boolean> val_36;
        UnityEngine.Object val_37;
        var val_40;
        System.Func<UIBasicSprite, System.Boolean> val_42;
        var val_43;
        float val_44;
        float val_45;
        var val_47;
        var val_48;
        var val_49;
        val_30 = this.view;
        this._currentSprite = 与丄丈丘丟丕丏丐丁;
        if(val_30 != null)
        {
                val_31 = val_30;
        }
        else
        {
                val_32 = this.view;
            if(val_32 != null)
        {
                val_30 = val_32;
        }
        else
        {
                val_30 = this.view;
            if(val_30 == null)
        {
            goto label_86;
        }
        
        }
        
        }
        
        val_33 = this.view.sliderAlpha;
        val_34 = null;
        val_34 = null;
        val_36 = ControlSizeController.<>c.<>9__50_0;
        if(val_36 == null)
        {
                System.Func<UISprite, System.Boolean> val_1 = null;
            val_36 = val_1;
            val_1 = new System.Func<UISprite, System.Boolean>(object:  ControlSizeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ControlSizeController.<>c::丒丟丗丝与丙丈丑丝(UISprite 丌丗丏丏丛东专丁且));
            ControlSizeController.<>c.<>9__50_0 = val_36;
        }
        
        var val_32 = 0;
        val_32 = val_32 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = System.Linq.Enumerable.Where<UISprite>(source:  this.view.buttons, predicate:  val_1).GetEnumerator();
        goto label_45;
        label_58:
        var val_33 = 0;
        val_33 = val_33 + 1;
        val_37 = val_4.Current;
        val_40 = null;
        val_40 = null;
        val_42 = ControlSizeController.<>c.<>9__50_1;
        if(val_42 == null)
        {
                val_42 = null;
            val_42 = new System.Func<UIBasicSprite, System.Boolean>(object:  ControlSizeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ControlSizeController.<>c::丈丁一与专专丛丌丟(UIBasicSprite 丄世业且下业上丄丟));
            ControlSizeController.<>c.<>9__50_1 = val_42;
        }
        
        TSource[] val_11 = System.Linq.Enumerable.ToArray<UIBasicSprite>(source:  System.Linq.Enumerable.Where<UIBasicSprite>(source:  val_37.gameObject.GetComponentsInChildren<UIBasicSprite>(), predicate:  null));
        if(val_11.Length == 0)
        {
            goto label_45;
        }
        
        val_37 = val_37.gameObject;
        if(val_37 != 与丄丈丘丟丕丏丐丁.gameObject)
        {
            goto label_35;
        }
        
        if(val_11.Length < 1)
        {
            goto label_45;
        }
        
        do
        {
            val_43 = 0;
            TSource val_34 = val_11[val_43];
            if((System.String.op_Inequality(a:  val_34.gameObject.name, b:  "BackGround")) != false)
        {
                UnityEngine.Color val_18 = UnityEngine.Color.red;
            val_44 = val_18.r;
            val_45 = val_18.b;
            UnityEngine.Color val_19 = val_34.color;
            val_34.color = new UnityEngine.Color() {r = val_44, g = val_18.g, b = val_45, a = val_19.a};
        }
        
            val_37 = val_43 + 1;
        }
        while(val_37 < val_11.Length);
        
        goto label_45;
        label_35:
        if(val_11.Length >= 1)
        {
                do
        {
            val_43 = 0;
            TSource val_35 = val_11[val_43];
            if((System.String.op_Inequality(a:  val_35.gameObject.name, b:  "BackGround")) != false)
        {
                UnityEngine.Color val_23 = UnityEngine.Color.white;
            val_44 = val_23.r;
            val_45 = val_23.b;
            UnityEngine.Color val_24 = val_35.color;
            val_35.color = new UnityEngine.Color() {r = val_44, g = val_23.g, b = val_45, a = val_24.a};
        }
        
            val_37 = val_43 + 1;
        }
        while(val_37 < val_11.Length);
        
        }
        
        label_45:
        var val_36 = 0;
        val_36 = val_36 + 1;
        if(val_4.MoveNext() == true)
        {
            goto label_58;
        }
        
        val_47 = 0;
        val_48 = 0;
        if(val_4 != null)
        {
            goto label_59;
        }
        
        goto label_88;
        label_86:
        if(与丄丈丘丟丕丏丐丁 != 1)
        {
            goto label_87;
        }
        
        val_48 = 1179403647;
        val_47 = 0;
        if(X22 == 0)
        {
            goto label_88;
        }
        
        label_59:
        var val_39 = X22;
        if((X22 + 286) == 0)
        {
            goto label_92;
        }
        
        var val_37 = X22 + 176;
        var val_38 = 0;
        val_37 = val_37 + 8;
        label_91:
        if(((X22 + 176 + 8) + -8) == null)
        {
            goto label_90;
        }
        
        val_38 = val_38 + 1;
        val_37 = val_37 + 16;
        if(val_38 < (X22 + 286))
        {
            goto label_91;
        }
        
        goto label_92;
        label_90:
        val_39 = val_39 + (((X22 + 176 + 8)) << 4);
        val_49 = val_39 + 296;
        label_92:
        X22.Dispose();
        label_88:
        this.与丞丂丆世丒世丘丏(丆且丞丟丛丗万一世:  this.view.slider, 专丛丅东丂七丐业丂:  false);
        this.与丞丂丆世丒世丘丏(丆且丞丟丛丗万一世:  val_32, 专丛丅东丂七丐业丂:  true);
        ButtonJoystickAdjust val_27 = this._currentSprite.GetComponent<ButtonJoystickAdjust>();
        if(val_27 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.view.slider, 丏业丟一东丂东丘丛:  val_27 & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_32, 丏业丟一东丂东丘丛:  val_27 & 1);
        val_27.Touch();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.view.slidersBackground, 丏业丟一东丂东丘丛:  val_27 & 1);
        return;
        label_87:
    }
    public ControlSizeController()
    {
        this.丗丂丘不业丈丐丁东 = 0.1f;
        this.丈丞三不丈一丌万万 = 1f;
        this.万与丞七业业东丝丌 = new System.Collections.Generic.List<丅下世下七下七一世>();
        this.丞丅业丕业专丒丈丛 = new UISprite[0];
        this.与与丐丒丑丙丒丙东 = new bool[0];
    }
    private float 丄丅一丏丙丝丙世丝(UISprite 丏丛与丅丛丌万专丌)
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  丏丛与丅丛丌万专丌, y:  0);
        if(val_1 == false)
        {
                return 1f;
        }
        
        return val_1.丛且丁且丞与下丂世(丟丒丞丐丐丘丒丄东:  丏丛与丅丛丌万专丌);
    }

}
