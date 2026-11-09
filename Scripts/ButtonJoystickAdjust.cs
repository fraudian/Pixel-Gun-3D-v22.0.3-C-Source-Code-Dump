using UnityEngine;
public class ButtonJoystickAdjust : MonoBehaviour
{
    // Fields
    internal static System.EventHandler<System.EventArgs> 世丗一上丑上丑丄一;
    internal ControlSizeController 上丌七一丑丟丌专上;
    private float 一一丟丛丆丘东丝丌;
    public bool _isDrag;
    private bool 业下丝丐且丁万丛丐;
    private bool 丏三丛专丄下丝东丈;
    private bool 丝丑东丐丑丕丌三业;
    private System.Nullable<UnityEngine.Vector3> 丕三丈专丛丄与不丅;
    private System.Nullable<UnityEngine.Vector3> 丈丘专丗丗丟且丏下;
    private UISprite[] 丗丟丕七丂与与丙上;
    private bool[] 与与丐丒丑丙丒丙东;
    private UISprite 丛东上丂东一丒丈世;
    public UnityEngine.GameObject defaultControlSprite;
    public UnityEngine.GameObject daterControlSprite;
    public bool IsDefaultPosLeft;
    public bool IsPress;
    public float TimeBlink;
    internal ScreenZonesController screenZones;
    private bool 丛与专与且丝世与专;
    private bool 且丟丁七丂一丗丟丆;
    
    // Properties
    internal virtual bool 万丒丗且丘丈丕丈世 { get; }
    
    // Methods
    internal virtual bool 丈丏丆世丟三丙丌丑()
    {
        return true;
    }
    private void Start()
    {
        var val_19;
        System.Func<UISprite, System.Boolean> val_21;
        if(this.defaultControlSprite != 0)
        {
                if(this.daterControlSprite != 0)
        {
                this.defaultControlSprite.SetActive(value:  (~GameConnect.东且三丆丑世世丘丟()) & 1);
            this.daterControlSprite.SetActive(value:  GameConnect.东且三丆丑世世丘丟());
        }
        
        }
        
        this.丝丑东丐丑丕丌三业 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        this.丛东上丂东一丒丈世 = this.GetComponent<UISprite>();
        this.上丌七一丑丟丌专上 = this.GetComponentInParent<ControlSizeController>();
        this.丗丟丕七丂与与丙上 = System.Linq.Enumerable.ToArray<UISprite>(source:  System.Linq.Enumerable.Where<UISprite>(source:  val_10.view.buttons, predicate:  new System.Func<UISprite, System.Boolean>(object:  this, method:  System.Boolean ButtonJoystickAdjust::万七不丂丂丙丘万下(UISprite 丏丂丛丙丆三专丂丛))));
        val_19 = null;
        val_19 = null;
        val_21 = ButtonJoystickAdjust.<>c.<>9__20_2;
        if(val_21 == null)
        {
                System.Func<UISprite, System.Boolean> val_16 = null;
            val_21 = val_16;
            val_16 = new System.Func<UISprite, System.Boolean>(object:  ButtonJoystickAdjust.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ButtonJoystickAdjust.<>c::丝丈一东丅上丑七丗(UISprite 丌丗丏丏丛东专丁且));
            ButtonJoystickAdjust.<>c.<>9__20_2 = val_21;
        }
        
        this.与与丐丒丑丙丒丙东 = System.Linq.Enumerable.ToArray<System.Boolean>(source:  System.Linq.Enumerable.Select<UISprite, System.Boolean>(source:  System.Linq.Enumerable.Where<UISprite>(source:  this.上丌七一丑丟丌专上.view.buttons, predicate:  new System.Func<UISprite, System.Boolean>(object:  this, method:  System.Boolean ButtonJoystickAdjust::丗丞丁丄一丟丕丐丘(UISprite 丏丂丛丙丆三专丂丛))), selector:  val_16));
    }
    private static System.Collections.Generic.List<UIBasicSprite> 丌丈丒七丟丐丗丄三(UnityEngine.Transform 丙业东万下业丗丒丕)
    {
        var val_13;
        var val_14;
        System.Collections.Generic.List<UIBasicSprite> val_1 = new System.Collections.Generic.List<UIBasicSprite>();
        System.Collections.IEnumerator val_2 = 丙业东万下业丗丒丕.GetEnumerator();
        goto label_20;
        label_27:
        var val_13 = 0;
        val_13 = val_13 + 1;
        object val_4 = val_2.Current;
        UIBasicSprite val_7 = 0.GetComponent<UIBasicSprite>();
        if(val_7 != 0)
        {
                val_1.Add(item:  val_7);
        }
        else
        {
                if(0.childCount >= 1)
        {
                val_1.AddRange(collection:  0);
        }
        
        }
        
        label_20:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_27;
        }
        
        val_13 = 0;
        val_14 = 0;
        if(val_2 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return val_1;
        }
        
        if( == false)
        {
                return val_1;
        }
        
        return val_1;
    }
    internal static void 业丟不丏丐丛丅丟丂(UnityEngine.Transform 丒一东丁世三万专下, float 与专丌丅丙上丌一丄)
    {
        if((ButtonJoystickAdjust.丌丈丒七丟丐丗丄三(丙业东万下业丗丒丕:  丒一东丁世三万专下).Count) == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = ButtonJoystickAdjust.丌丈丒七丟丐丗丄三(丙业东万下业丗丒丕:  丒一东丁世三万专下).GetEnumerator();
        label_9:
        if((939163080 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Color val_9 = val_4.color;
        val_4.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = (((System.String.op_Inequality(a:  val_4.gameObject.name, b:  "BackGround")) != true) ? 1f : 0.27f) * 与专丌丅丙上丌一丄};
        goto label_9;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal virtual void 丝丆且下丁三不丘世(float 与专丌丅丙上丌一丄)
    {
        ButtonJoystickAdjust.业丟不丏丐丛丅丟丂(丒一东丁世三万专下:  this.transform, 与专丌丅丙上丌一丄:  与专丌丅丙上丌一丄);
    }
    protected virtual UnityEngine.Vector3 丑丛丂丏丅丅丕丕下(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 世专七丘万丌一丟丗, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        var val_1 = val_1;
        return this.screenZones.上上专丂丂世业业七(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 世专七丘万丌一丟丗:  new UnityEngine.Vector3() {x = 世专七丘万丌一丟丗.x, y = 世专七丘万丌一丟丗.y, z = 世专七丘万丌一丟丗.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 丒丐与丁丆丄丗丏丕:  this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1);
    }
    protected virtual System.Nullable<UnityEngine.Vector3> 丒丑丆下下丛丄丛下(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_18;
        var val_19;
        UnityEngine.Object val_20;
        val_18 = 丞且丅三三东不丄且.y;
        val_19 = this;
        val_20 = 0;
        if(this.screenZones == val_20)
        {
                return 0;
        }
        
        val_20 = public System.Boolean System.Nullable<UnityEngine.Vector3>::get_HasValue();
        if((this.丈丘专丗丗丟且丏下 & 1) == 0)
        {
                return 0;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = val_18});
        UnityEngine.Vector3 val_4 = this.transform.TransformVector(vector:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_4.x = val_4.x + val_4.x;
        val_4.y = val_4.y + val_4.y;
        this.丈丘专丗丗丟且丏下 = 0;
        mem[1152921539906194928] = 0;
        UnityEngine.Vector3 val_6 = this.transform.position;
        UnityEngine.Vector3 val_10 = this.transform.parent.lossyScale;
        float val_11 = (float)this.丛东上丂东一丒丈世.width * 0.5f;
        下丂世丂不丛专一一 val_12 = this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1;
        UnityEngine.Vector3 val_14 = this.transform.position;
        val_18 = 0f;
        val_19 = this.transform.parent;
        UnityEngine.Vector3 val_17 = val_19.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_18, y = 0f, z = 0f});
        val_20 = public System.Void System.Nullable<UnityEngine.Vector3>::.ctor(UnityEngine.Vector3 value);
        return 0;
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_182;
        float val_183;
        float val_184;
        var val_187;
        var val_188;
        float val_189;
        float val_190;
        float val_191;
        float val_192;
        float val_193;
        float val_194;
        float val_195;
        UISprite val_199;
        var val_200;
        float val_201;
        float val_202;
        float val_203;
        var val_204;
        var val_205;
        var val_206;
        float val_207;
        float val_208;
        float val_214;
        float val_215;
        float val_216;
        float val_217;
        float val_219;
        UISprite val_220;
        float val_221;
        float val_222;
        var val_225;
        var val_226;
        var val_227;
        float val_1 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y}, d:  val_1);
        this._isDrag = true;
        if((941003672 & 1) == 0)
        {
            goto label_5;
        }
        
        val_182 = val_2.x;
        val_183 = val_2.y;
        val_184 = val_1;
        if(((System.Double.IsNaN(d:  (double)0f)) == true) || ((System.Double.IsNaN(d:  (double)0f)) == true))
        {
            goto label_97;
        }
        
        if((this.上丌七一丑丟丌专上.CheckWeaponPanelCollision(丕万丂丕丁丅专丈不:  this.丛东上丂东一丒丈世, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_182, y = val_183, z = val_184}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, 三丂丏丕与丈丙专丝:  false)) != false)
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_182 = val_7.x;
            val_183 = val_7.y;
            val_184 = val_7.z;
        }
        
        if((this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1) == 0)
        {
            goto label_19;
        }
        
        UISprite val_179 = this.丛东上丂东一丒丈世;
        val_179 = this.上丌七一丑丟丌专上.CheckBRMapCollision(丕万丂丕丁丅专丈不:  val_179, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_182, y = val_183, z = val_184}, 业与三万七丝不万东:  val_179.width, 七丒业丏上业丛业丅: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
        goto label_22;
        label_5:
        UnityEngine.Vector3 val_11 = this.transform.localPosition;
        UnityEngine.Vector3 val_13 = this.transform.localPosition;
        float val_14 = val_2.x + val_11.x;
        val_13.y = val_2.y + val_13.y;
        label_260:
        label_162:
        this.丒丆一丌丒丗丑丏丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        label_97:
        this.丛与专与且丝世与专 = false;
        this.且丟丁七丂一丗丟丆 = false;
        return;
        label_19:
        label_22:
        if(((System.Double.IsNaN(d:  (double)0f)) == true) || ((System.Double.IsNaN(d:  (double)0f)) == true))
        {
            goto label_97;
        }
        
        if(0 != 0)
        {
                UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_182 = val_17.x;
            val_183 = val_17.y;
            val_184 = val_17.z;
        }
        
        if((null == null) || (null == null))
        {
            goto label_88;
        }
        
        val_187 = 0;
        val_188 = 0;
        goto label_36;
        label_87:
        ButtonJoystickAdjust val_18 = this.丗丟丕七丂与与丙上[0].GetComponent<ButtonJoystickAdjust>();
        if((val_18 != null) && (val_18 != 0))
        {
                if((null == null) || (null == null))
        {
            goto label_83;
        }
        
        }
        
        var val_20 = (this.IsDefaultPosLeft == true) ? 1 : 0;
        val_20 = val_20 ^ ((this.与与丐丒丑丙丒丙东[0] == true) ? 1 : 0);
        if((val_20 & 1) == 0)
        {
            goto label_48;
        }
        
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_182, y = val_183, z = val_184});
        val_189 = val_22.y;
        UnityEngine.Vector3 val_26 = this.丗丟丕七丂与与丙上[0].transform.position;
        UnityEngine.Vector3 val_27 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        val_190 = val_28.y;
        float val_29 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_22.x, y = val_189}, b:  new UnityEngine.Vector2() {x = val_28.x, y = val_190});
        val_182 = val_182;
        val_183 = val_183;
        val_184 = val_184;
        if(val_29 > (3.402823E+38f))
        {
            goto label_83;
        }
        
        this.丗丟丕七丂与与丙上[0] = this.丛东上丂东一丒丈世.width + this.丗丟丕七丂与与丙上[0].width;
        float val_184 = (float)this.丗丟丕七丂与与丙上[0];
        val_184 = val_184 * 0.5f;
        if(val_29 >= 0)
        {
            goto label_83;
        }
        
        UISprite val_185 = this.丗丟丕七丂与与丙上[0];
        UnityEngine.Vector3 val_35 = this.丗丟丕七丂与与丙上[0].transform.position;
        val_189 = val_35.x;
        UnityEngine.Vector3 val_36 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_189, y = val_35.y, z = val_35.z});
        goto label_71;
        label_48:
        UnityEngine.Vector2 val_37 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_182, y = val_183, z = val_184});
        val_189 = val_37.y;
        UnityEngine.Vector3 val_39 = this.丗丟丕七丂与与丙上[0].transform.localPosition;
        UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        val_190 = val_40.y;
        float val_41 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_37.x, y = val_189}, b:  new UnityEngine.Vector2() {x = val_40.x, y = val_190});
        if(val_41 > (3.402823E+38f))
        {
            goto label_83;
        }
        
        this.丗丟丕七丂与与丙上[0] = this.丛东上丂东一丒丈世.width + this.丗丟丕七丂与与丙上[0].width;
        float val_189 = (float)this.丗丟丕七丂与与丙上[0];
        val_189 = val_189 * 0.5f;
        if(val_41 >= 0)
        {
            goto label_83;
        }
        
        UISprite val_190 = this.丗丟丕七丂与与丙上[0];
        label_71:
        val_188 = 1;
        label_83:
        val_187 = 1;
        label_36:
        if(val_187 < this.丗丟丕七丂与与丙上.Length)
        {
            goto label_87;
        }
        
        if((val_188 & 1) == 0)
        {
            goto label_88;
        }
        
        UnityEngine.Vector2 val_44 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_182, y = val_183, z = val_184});
        UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        val_191 = 0f;
        val_192 = ((float)this.丛东上丂东一丒丈世.width + 0) * 0.5f;
        UnityEngine.Vector2 val_48 = val_45.x.normalized;
        UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y}, d:  val_192);
        val_193 = val_49.x;
        UnityEngine.Vector2 val_50 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0f, y = val_191}, b:  new UnityEngine.Vector2() {x = val_193, y = val_49.y});
        UnityEngine.Vector3 val_51 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_50.x, y = val_50.y});
        val_194 = val_51.x;
        val_195 = val_51.z;
        UnityEngine.Vector3 val_53 = this.transform.localPosition;
        UnityEngine.Vector2 val_54 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z});
        val_199 = this.丛东上丂东一丒丈世.width;
        val_201 = val_54.x;
        val_202 = val_54.y;
        if((this & 1) == 0)
        {
            goto label_94;
        }
        
        val_203 = val_51.y;
        goto label_95;
        label_88:
        UnityEngine.Vector3 val_58 = this.ClampPosInConstraints(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_182, y = val_183, z = val_184}, 且丛上丕业丂丒与一:  (float)this.丛东上丂东一丒丈世.width * 0.5f);
        goto label_97;
        label_94:
        UnityEngine.Vector3 val_60 = this.transform.localPosition;
        UnityEngine.Vector2 val_61 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z});
        UnityEngine.Vector2 val_62 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_61.x, y = val_61.y}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        val_199 = 0;
        UnityEngine.Vector2 val_63 = val_62.x.normalized;
        UnityEngine.Vector2 val_64 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_63.x, y = val_63.y}, d:  val_192);
        val_193 = val_64.x;
        val_201 = 0f;
        val_202 = val_191;
        UnityEngine.Vector2 val_65 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0f, y = val_191}, b:  new UnityEngine.Vector2() {x = val_193, y = val_64.y});
        UnityEngine.Vector3 val_66 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_65.x, y = val_65.y});
        val_194 = val_66.x;
        val_203 = val_66.y;
        val_195 = val_66.z;
        label_95:
        val_204 = 0;
        val_205 = 0;
        val_206 = 0;
        goto label_101;
        label_130:
        if(val_187 != val_204)
        {
                var val_67 = (this.IsDefaultPosLeft == true) ? 1 : 0;
            val_67 = val_67 ^ ((this.与与丐丒丑丙丒丙东[0] == true) ? 1 : 0);
            if((val_67 & 1) != 0)
        {
                UnityEngine.Vector2 val_69 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
            val_191 = val_69.y;
            UnityEngine.Vector3 val_73 = this.丗丟丕七丂与与丙上[0].transform.position;
            val_192 = val_73.x;
            UnityEngine.Vector3 val_74 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_192, y = val_73.y, z = val_73.z});
            UnityEngine.Vector2 val_75 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            val_193 = val_75.x;
            val_207 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_69.x, y = val_191}, b:  new UnityEngine.Vector2() {x = val_193, y = val_75.y});
            val_203 = val_203;
            val_194 = val_194;
            val_195 = val_195;
            val_199 = 0;
            this.丗丟丕七丂与与丙上[0] = this.丛东上丂东一丒丈世.width + this.丗丟丕七丂与与丙上[0].width;
            val_208 = (float)this.丗丟丕七丂与与丙上[0];
            val_202 = 0.5f;
        }
        else
        {
                UnityEngine.Vector2 val_79 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
            val_191 = val_79.y;
            UnityEngine.Vector3 val_81 = this.丗丟丕七丂与与丙上[0].transform.localPosition;
            UnityEngine.Vector2 val_82 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z});
            val_193 = val_82.x;
            val_207 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_79.x, y = val_191}, b:  new UnityEngine.Vector2() {x = val_193, y = val_82.y});
            val_199 = 0;
            this.丗丟丕七丂与与丙上[0] = this.丛东上丂东一丒丈世.width + this.丗丟丕七丂与与丙上[0].width;
            val_208 = (float)this.丗丟丕七丂与与丙上[0];
            val_202 = 0.5f;
        }
        
            val_201 = val_208 * val_202;
            var val_86 = (val_207 < 0) ? 1 : 0;
            var val_87 = (val_207 >= 0) ? 1 : 0;
            val_87 = ((val_207 > (3.402823E+38f)) ? 1 : 0) | val_87;
            val_86 = ((val_207 <= (3.402823E+38f)) ? 1 : 0) & val_86;
            val_205 = val_205 | val_86;
            var val_90 = (val_87 != 0) ? (val_206) : (val_204);
            var val_91 = (val_87 != 0) ? 3.402823E+38f : (val_207);
        }
        
        val_204 = 1;
        label_101:
        if(val_204 < this.丗丟丕七丂与与丙上.Length)
        {
            goto label_130;
        }
        
        if((val_205 & 1) == 0)
        {
            goto label_131;
        }
        
        UISprite val_196 = this.丗丟丕七丂与与丙上[(long)val_90];
        if(((this.与与丐丒丑丙丒丙东[(long)val_90] == true) ? 1 : 0) == ((this.IsDefaultPosLeft == true) ? 1 : 0))
        {
            goto label_136;
        }
        
        UnityEngine.Vector3 val_97 = this.丗丟丕七丂与与丙上[(long)val_90].transform.position;
        val_201 = val_97.x;
        val_202 = val_97.y;
        val_193 = val_97.z;
        UnityEngine.Vector3 val_98 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_201, y = val_202, z = val_193});
        goto label_143;
        label_131:
        UnityEngine.Vector2 val_99 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
        UnityEngine.Vector2 val_100 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_99.x, y = val_99.y});
        UnityEngine.Vector3 val_101 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_100.x, y = val_100.y});
        val_214 = val_101.y;
        val_215 = val_101.x;
        val_216 = val_214;
        val_217 = val_101.z;
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_215, y = val_216, z = val_217})) <= 0f)
        {
            goto label_161;
        }
        
        val_199 = this.丛东上丂东一丒丈世;
        val_215 = val_194;
        val_216 = val_203;
        val_217 = val_195;
        val_200 = 0;
        if((this.上丌七一丑丟丌专上.CheckWeaponPanelCollision(丕万丂丕丁丅专丈不:  val_199, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_215, y = val_216, z = val_217}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width, 三丂丏丕与丈丙专丝:  false)) == true)
        {
            goto label_161;
        }
        
        if((this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1) == 0)
        {
            goto label_154;
        }
        
        val_199 = this.丛东上丂东一丒丈世;
        val_215 = val_194;
        val_216 = val_203;
        val_217 = val_195;
        val_200 = 0;
        if((this.上丌七一丑丟丌专上.CheckBRMapCollision(丕万丂丕丁丅专丈不:  val_199, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_215, y = val_216, z = val_217}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width)) == true)
        {
            goto label_161;
        }
        
        label_154:
        val_217 = val_195;
        UnityEngine.Vector2 val_107 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_217});
        val_214 = val_107.y;
        val_199 = this.丛东上丂东一丒丈世.width;
        val_215 = val_107.x;
        val_216 = val_214;
        if((this & 1) == 0)
        {
            goto label_161;
        }
        
        goto label_162;
        label_161:
        if((this.丛与专与且丝世与专 == false) || ((this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1) == 0))
        {
            goto label_174;
        }
        
        UnityEngine.Vector3 val_110 = this.transform.localPosition;
        val_214 = val_110.y;
        val_200 = 0;
        if((this.上丌七一丑丟丌专上.CheckBRMapCollision(丕万丂丕丁丅专丈不:  this.丛东上丂东一丒丈世, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_110.x, y = val_214, z = val_110.z}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width)) == false)
        {
            goto label_174;
        }
        
        UnityEngine.Vector2 val_113 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
        val_214 = val_113.y;
        if((this.丛丅下丟丕丗丈丁丒(七丒业丏上业丛业丅:  new UnityEngine.Vector2() {x = val_113.x, y = val_214}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width)) == false)
        {
            goto label_174;
        }
        
        this.丛与专与且丝世与专 = false;
        this.丒丆一丌丒丗丑丏丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
        goto label_175;
        label_174:
        if(this.且丟丁七丂一丗丟丆 == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_116 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
        UnityEngine.Vector2 val_117 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_116.x, y = val_116.y});
        UnityEngine.Vector3 val_118 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_117.x, y = val_117.y});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_118.x, y = val_118.y, z = val_118.z})) != 0f)
        {
                return;
        }
        
        UnityEngine.Vector2 val_120 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
        int val_121 = this.丛东上丂东一丒丈世.width;
        if((this & 1) == 0)
        {
                return;
        }
        
        this.且丟丁七丂一丗丟丆 = false;
        this.丒丆一丌丒丗丑丏丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_194, y = val_203, z = val_195});
        UnityEngine.Vector2 val_122 = new UnityEngine.Vector2(x:  0f, y:  0f);
        return;
        label_136:
        UnityEngine.Vector3 val_124 = val_196.transform.localPosition;
        label_143:
        UnityEngine.Vector2 val_125 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_124.x, y = val_124.y, z = val_124.z});
        UnityEngine.Vector2 val_126 = new UnityEngine.Vector2(x:  val_194, y:  val_203);
        UnityEngine.Vector2 val_127 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_126.x, y = val_126.y}, b:  new UnityEngine.Vector2() {x = val_125.x, y = val_125.y});
        UnityEngine.Vector2 val_128 = val_127.x.normalized;
        UnityEngine.Vector2 val_132 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_128.x, y = val_128.y}, d:  (float)this.丛东上丂东一丒丈世.width + val_196.width);
        UnityEngine.Vector2 val_133 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_132.x, y = val_132.y}, d:  2f);
        UnityEngine.Vector2 val_134 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_125.x, y = val_125.y}, b:  new UnityEngine.Vector2() {x = val_133.x, y = val_133.y});
        val_219 = 0f;
        val_220 = 0;
        val_221 = 0.5f;
        val_222 = ((float)this.丛东上丂东一丒丈世.width + 0) * val_221;
        if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_134.x, y = val_134.y}, b:  new UnityEngine.Vector2() {x = val_219, y = 0f})) >= 0)
        {
            goto label_227;
        }
        
        UnityEngine.Vector2 val_138 = new UnityEngine.Vector2(x:  0f, y:  0f);
        UnityEngine.Vector2 val_139 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_134.x, y = val_134.y}, b:  new UnityEngine.Vector2() {x = val_138.x, y = val_138.y});
        UnityEngine.Vector2 val_140 = val_139.x.normalized;
        UnityEngine.Vector2 val_143 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_140.x, y = val_140.y}, d:  (float)this.丛东上丂东一丒丈世.width + 0);
        UnityEngine.Vector2 val_144 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_143.x, y = val_143.y}, d:  2f);
        UnityEngine.Vector2 val_145 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_138.x, y = val_138.y}, b:  new UnityEngine.Vector2() {x = val_144.x, y = val_144.y});
        val_219 = val_125.x;
        val_220 = 0;
        val_221 = 0.5f;
        val_222 = ((float)this.丛东上丂东一丒丈世.width + val_196.width) * val_221;
        if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_145.x, y = val_145.y}, b:  new UnityEngine.Vector2() {x = val_219, y = val_125.y})) < val_222)
        {
            goto label_227;
        }
        
        UnityEngine.Vector2 val_150 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_145.x, y = val_145.y});
        UnityEngine.Vector3 val_151 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_150.x, y = val_150.y});
        val_222 = val_151.x;
        val_221 = val_151.y;
        val_219 = val_151.z;
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_222, y = val_221, z = val_219})) <= 0f)
        {
            goto label_227;
        }
        
        UnityEngine.Vector3 val_153 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_145.x, y = val_145.y});
        val_220 = this.丛东上丂东一丒丈世;
        val_222 = val_153.x;
        val_221 = val_153.y;
        val_219 = val_153.z;
        val_225 = 0;
        if((this.上丌七一丑丟丌专上.CheckWeaponPanelCollision(丕万丂丕丁丅专丈不:  val_220, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_222, y = val_221, z = val_219}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width, 三丂丏丕与丈丙专丝:  false)) == false)
        {
            goto label_211;
        }
        
        label_227:
        if((this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_157 = this.transform.localPosition;
        if((this.上丌七一丑丟丌专上.CheckBRMapCollision(丕万丂丕丁丅专丈不:  this.丛东上丂东一丒丈世, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_157.x, y = val_157.y, z = val_157.z}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width)) == false)
        {
                return;
        }
        
        label_175:
        this.丛一世丐丝丂上且丈();
        return;
        label_211:
        if((this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1) == 0)
        {
            goto label_222;
        }
        
        UnityEngine.Vector3 val_160 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_145.x, y = val_145.y});
        val_225 = 0;
        if((this.上丌七一丑丟丌专上.CheckBRMapCollision(丕万丂丕丁丅专丈不:  this.丛东上丂东一丒丈世, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_160.x, y = val_160.y, z = val_160.z}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width)) == true)
        {
            goto label_227;
        }
        
        label_222:
        val_226 = 0;
        val_227 = 0;
        goto label_228;
        label_254:
        if((val_187 != val_226) && (val_90 != val_226))
        {
                var val_164 = (this.与与丐丒丑丙丒丙东[0] == true) ? 1 : 0;
            val_164 = ((this.IsDefaultPosLeft == true) ? 1 : 0) ^ val_164;
            if((val_164 & 1) != 0)
        {
                UnityEngine.Vector3 val_168 = this.丗丟丕七丂与与丙上[0].transform.position;
            UnityEngine.Vector3 val_169 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_168.x, y = val_168.y, z = val_168.z});
        }
        else
        {
                UnityEngine.Vector3 val_171 = this.丗丟丕七丂与与丙上[0].transform.localPosition;
        }
        
            UnityEngine.Vector2 val_172 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_171.x, y = val_171.y, z = val_171.z});
            if((val_227 & 1) != 0)
        {
                val_227 = 1;
        }
        else
        {
                this.丗丟丕七丂与与丙上[0] = this.丛东上丂东一丒丈世.width + this.丗丟丕七丂与与丙上[0].width;
            float val_203 = (float)this.丗丟丕七丂与与丙上[0];
            val_203 = val_203 * 0.5f;
        }
        
        }
        
        val_226 = 1;
        label_228:
        if(val_226 < this.丗丟丕七丂与与丙上.Length)
        {
            goto label_254;
        }
        
        if(((((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_145.x, y = val_145.y}, b:  new UnityEngine.Vector2() {x = val_172.x, y = val_172.y})) <= val_203) ? 1 : 0) & 1) != 0)
        {
                return;
        }
        
        int val_177 = this.丛东上丂东一丒丈世.width;
        if((this & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_178 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_145.x, y = val_145.y});
        goto label_260;
    }
    protected virtual void 丕下丗丆丄丘丆丈万(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        this.transform.localPosition = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
    }
    internal void 丒丆一丌丒丗丑丏丂(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        int val_2 = this.丛东上丂东一丒丈世.width;
        if((this & 1) == 0)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        this.与不丗上丈丛丈丘丁();
    }
    public UnityEngine.Vector3 ClampPosInConstraints(UnityEngine.Vector3 下业丕七东丌丝下且, float 且丛上丕业丂丒与一)
    {
        var val_17;
        float val_18;
        var val_19;
        val_17 = 且丛上丕业丂丒与一;
        val_18 = 下业丕七东丌丝下且.y;
        val_19 = this;
        if(this.screenZones != 0)
        {
                UnityEngine.Vector3 val_4 = this.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = val_18, z = 下业丕七东丌丝下且.z});
            val_18 = val_4.y;
            UnityEngine.Vector3 val_6 = this.transform.position;
            UnityEngine.Vector3 val_9 = this.transform.parent.lossyScale;
            下丂世丂不丛专一一 val_10 = this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1;
            val_17 = val_18;
            val_19 = this.transform;
            UnityEngine.Vector3 val_14 = val_19.position;
            UnityEngine.Vector3 val_15 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
    }
    public void Touch()
    {
        if(this.丛东上丂东一丒丈世 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.localPosition;
        if(val_3.x >= 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.localPosition;
        if(val_5.y >= 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.localPosition;
        UnityEngine.Vector3 val_9 = this.transform.localPosition;
        this.丕三丈专丛丄与不丅 = 0;
        mem[1152921539909433696] = 0;
        UnityEngine.Vector3 val_11 = this.transform.position;
        UnityEngine.Vector3 val_13 = this.transform.position;
        this.丈丘专丗丗丟且丏下 = 0;
        mem[1152921539909433712] = 0;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  0.01f, y:  0f);
        this.OnDrag(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
    }
    public void CheckForCollisionWithMap()
    {
        ControlSizeController val_15;
        float val_16;
        if(this.丛东上丂东一丒丈世 == 0)
        {
                return;
        }
        
        val_15 = this.上丌七一丑丟丌专上;
        UnityEngine.Vector3 val_3 = this.丛东上丂东一丒丈世.transform.localPosition;
        val_16 = val_3.x;
        if((val_15.CheckBRMapCollision(丕万丂丕丁丅专丈不:  this.丛东上丂东一丒丈世, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_16, y = val_3.y, z = val_3.z}, 业与三万七丝不万东:  this.丛东上丂东一丒丈世.width)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.localPosition;
        UnityEngine.Vector3 val_9 = this.transform.localPosition;
        val_15 = 1152921537296417824;
        this.丕三丈专丛丄与不丅 = 0;
        mem[1152921539909611232] = 0;
        UnityEngine.Vector3 val_11 = this.transform.position;
        val_16 = val_11.x;
        UnityEngine.Vector3 val_13 = this.transform.position;
        this.丈丘专丗丗丟且丏下 = 0;
        mem[1152921539909611248] = 0;
        this.丛与专与且丝世与专 = true;
        this.且丟丁七丂一丗丟丆 = true;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  0f, y:  -0.1f);
        this.OnDrag(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
    }
    protected virtual bool 丁丝丑丙三丘且业丄(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, out UnityEngine.Vector2[] 业东丛丂丏下丗丘且, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        return this.screenZones.丑且世丑七丁丂丌世(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 丝丕丁丏丏上丅丏且.z}, 业东丛丂丏下丗丘且: out  UnityEngine.Vector2[] val_2 = 业东丛丂丏下丗丘且, 丒丐与丁丆丄丗丏丕:  this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1);
    }
    private bool 丛丅下丟丕丗丈丁丒(UnityEngine.Vector2 七丒业丏上业丛业丅, int 业与三万七丝不万东)
    {
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        UnityEngine.Vector3 val_5 = this.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_8 = this.transform.parent.lossyScale;
        var val_9 = (业与三万七丝不万东 < 0) ? (业与三万七丝不万东 + 1) : 业与三万七丝不万东;
        val_9 = val_9 >> 1;
        return (bool)this.screenZones.丈丑丁与丝丞下且丌(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 且丛上丕业丂丒与一:  (float)val_9, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 一世丅丕丑丈丕世丈:  (null == null) ? 1 : 0);
    }
    public virtual bool CheckInConstraints(UnityEngine.Vector2 七丒业丏上业丛业丅, int 业与三万七丝不万东, out UnityEngine.Vector2[] 丏丕丕七三丛三丑丝)
    {
        var val_16;
        var val_17;
        float val_18;
        UnityEngine.Vector2[] val_19;
        var val_20;
        val_16 = 七丒业丏上业丛业丅.y;
        丏丕丕七三丛三丑丝 = new UnityEngine.Vector2[0];
        if(this.screenZones == 0)
        {
            goto label_3;
        }
        
        val_17 = this.transform;
        UnityEngine.Vector3 val_6 = val_17.localPosition;
        UnityEngine.Vector3 val_7 = this.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_18 = val_7.y;
        val_16 = val_7.z;
        float val_17 = (float)业与三万七丝不万东;
        UnityEngine.Vector3 val_10 = this.transform.parent.lossyScale;
        val_17 = val_17 * 0.5f;
        下丂世丂不丛专一一 val_11 = this.上丌七一丑丟丌专上.丑丒专丙东万丒丂丆 & 1;
        val_19 = 丏丕丕七三丛三丑丝;
        val_20 = this;
        if(val_19 == null)
        {
                return (bool)val_20 & 1;
        }
        
        val_17 = 0;
        goto label_12;
        label_22:
        UnityEngine.Vector3 val_14 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        val_18 = val_15.y;
        mem2[0] = val_15.x;
        mem2[0] = val_18;
        val_19 = 丏丕丕七三丛三丑丝;
        val_17 = 1;
        label_12:
        if(val_17 < mem[1152921539910151080])
        {
            goto label_22;
        }
        
        return (bool)val_20 & 1;
        label_3:
        val_20 = 1;
        return (bool)val_20 & 1;
    }
    private bool 丞丒与丘丛丐丒丅一(UnityEngine.Vector2 业丒丝丗与丐丛丟丏)
    {
        float val_18;
        var val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        var val_28;
        val_18 = 业丒丝丗与丐丛丟丏.y;
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        val_19 = 0;
        goto label_2;
        label_27:
        val_20 = 0f;
        var val_3 = (this.IsDefaultPosLeft == true) ? 1 : 0;
        val_3 = val_3 ^ ((this.与与丐丒丑丙丒丙东[0] == true) ? 1 : 0);
        if((val_3 & 1) != 0)
        {
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_20, y = 0f, z = 0f});
            val_21 = val_5.x;
            val_22 = val_5.y;
            UnityEngine.Vector3 val_9 = this.丗丟丕七丂与与丙上[0].transform.position;
            val_20 = val_9.x;
            val_23 = val_20;
            val_24 = val_9.y;
            UnityEngine.Vector3 val_10 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_9.z});
        }
        else
        {
                val_23 = val_20;
            val_24 = 0f;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_20, y = 0f, z = 0f});
            val_21 = val_11.x;
            val_22 = val_11.y;
            UnityEngine.Vector3 val_13 = this.丗丟丕七丂与与丙上[0].transform.localPosition;
        }
        
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_18 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_21, y = val_22}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        this.丗丟丕七丂与与丙上[0] = this.丛东上丂东一丒丈世.width + this.丗丟丕七丂与与丙上[0].width;
        float val_22 = (float)this.丗丟丕七丂与与丙上[0];
        val_22 = val_22 * 0.5f;
        if(val_18 < 0)
        {
            goto label_25;
        }
        
        val_19 = 1;
        label_2:
        if(val_19 < this.丗丟丕七丂与与丙上.Length)
        {
            goto label_27;
        }
        
        val_28 = 1;
        return (bool)val_28;
        label_25:
        val_28 = 0;
        return (bool)val_28;
    }
    private UnityEngine.Vector2[] 丗丌业业丅丌丐丁丑(UnityEngine.Vector2 丈万丏丈上丑不丅上, int 丛上丙丄丄七丈且丅)
    {
        float val_19;
        float val_20;
        float val_21;
        var val_22;
        val_19 = 丈万丏丈上丑不丅上.y;
        UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[8];
        var val_22 = 0;
        do
        {
            var val_20 = -1;
            val_20 = val_20 * 丛上丙丄丄七丈且丅;
            val_20 = 丈万丏丈上丑不丅上.x + (float)val_20;
            do
        {
            label_5:
            if(0 == 1)
        {
                if(0 == 1)
        {
            goto label_5;
        }
        
        }
        
            var val_21 = -1;
            val_21 = val_21 * 丛上丙丄丄七丈且丅;
            丈万丏丈上丑不丅上.y = val_19 + (float)val_21;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_20, y:  丈万丏丈上丑不丅上.y);
            val_21 = val_2.x;
            val_22 = val_22 + 1;
            val_1[0] = val_21;
            val_1[0] = val_2.y;
        }
        while((0 + 1) != 3);
        
            val_22 = 0 + 1;
        }
        while(val_22 != 3);
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_4 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        if(val_1.Length < 1)
        {
                return (UnityEngine.Vector2[])val_4.ToArray();
        }
        
        float val_23 = (float)this.丛东上丂东一丒丈世.width;
        val_23 = val_23 * 0.5f;
        val_21 = 1152921516216384640;
        do
        {
            val_20 = val_1[0];
            UnityEngine.Vector3 val_9 = this.transform.localPosition;
            UnityEngine.Vector3 val_10 = this.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_22 = this.transform.parent;
            UnityEngine.Vector3 val_13 = val_22.lossyScale;
            val_19 = val_13.z;
            if((this.screenZones.丈丑丁与丝丞下且丌(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, 且丛上丕业丂丒与一:  val_23, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_19}, 一世丅丕丑丈丕世丈:  ((null == null) ? 1 : 0) & ((this != 0) ? 1 : 0))) != false)
        {
                val_4.Add(item:  new UnityEngine.Vector2() {x = val_1[0], y = val_20});
        }
        
        }
        while((0 + 1) < val_1.Length);
        
        return (UnityEngine.Vector2[])val_4.ToArray();
    }
    private void 丛一世丐丝丂上且丈()
    {
        var val_19;
        UnityEngine.Vector2 val_20;
        System.Collections.Generic.IEnumerable<TSource> val_21;
        UISprite val_22;
        var val_23;
        var val_24;
        val_19 = this;
        float val_19 = (float)this.丛东上丂东一丒丈世.width;
        val_19 = val_19 * 0.25f;
        int val_2 = ((int)val_19 > (2.101948E-44f)) ? ((int)val_19) : 15;
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        val_20 = val_4.x;
        UnityEngine.Vector3 val_6 = this.transform.localPosition;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  (float)(int)val_20, y:  (float)(int)val_6.y);
        val_21 = this.丗丌业业丅丌丐丁丑(丈万丏丈上丑不丅上:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, 丛上丙丄丄七丈且丅:  val_2);
        val_22 = 0;
        label_22:
        if(val_8.Length == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_9 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        val_23 = 0;
        goto label_6;
        label_20:
        UnityEngine.Vector2 val_20 = val_21[0];
        val_20 = val_21[0];
        if((this.丞丒与丘丛丐丒丅一(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = val_20, y = val_20})) == false)
        {
            goto label_8;
        }
        
        val_22 = this.丛东上丂东一丒丈世;
        int val_11 = val_22.width;
        if((val_19 & 1) != 0)
        {
            goto label_10;
        }
        
        label_8:
        val_24 = 0;
        goto label_11;
        label_18:
        val_20 = this.丗丌业业丅丌丐丁丑(丈万丏丈上丑不丅上:  new UnityEngine.Vector2() {x = val_20, y = val_20}, 丛上丙丄丄七丈且丅:  val_2)[0];
        UnityEngine.Vector2 val_21 = this.丗丌业业丅丌丐丁丑(丈万丏丈上丑不丅上:  new UnityEngine.Vector2() {x = val_20, y = val_20}, 丛上丙丄丄七丈且丅:  val_2)[0];
        if((val_9.Contains(item:  new UnityEngine.Vector2() {x = val_20, y = val_21})) != true)
        {
                if((System.Linq.Enumerable.Contains<UnityEngine.Vector2>(source:  val_21, value:  new UnityEngine.Vector2() {x = val_20, y = val_21})) != true)
        {
                val_9.Add(item:  new UnityEngine.Vector2() {x = val_20, y = val_21});
        }
        
        }
        
        val_24 = 1;
        label_11:
        if(val_24 < val_12.Length)
        {
            goto label_18;
        }
        
        val_23 = 1;
        label_6:
        if(val_23 < val_8.Length)
        {
            goto label_20;
        }
        
        val_22 = 1;
        val_21 = val_9.ToArray();
        if(val_22 <= 48)
        {
            goto label_22;
        }
        
        return;
        label_10:
        val_19 = this.transform;
        UnityEngine.Vector3 val_18 = val_19.localPosition;
        this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public bool CheckInConstraints(int 业与三万七丝不万东, out UnityEngine.Vector2[] 丏丕丕七三丛三丑丝)
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        goto typeof(ButtonJoystickAdjust).__il2cppRuntimeField_1C8;
    }
    public bool CheckInConstraints(UnityEngine.Vector2 七丒业丏上业丛业丅, int 业与三万七丝不万东)
    {
        return false;
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        object val_16;
        var val_17;
        val_16 = this;
        this.IsPress = 丆且上丘世下丅且丞;
        if(丆且上丘世下丅且丞 != false)
        {
                UnityEngine.Vector3 val_3 = this.transform.localPosition;
            UnityEngine.Vector3 val_5 = this.transform.localPosition;
            this.丕三丈专丛丄与不丅 = 0;
            mem[1152921539911743392] = 0;
            UnityEngine.Vector3 val_7 = this.transform.position;
            UnityEngine.Vector3 val_9 = this.transform.position;
            this.丈丘专丗丗丟且丏下 = 0;
            mem[1152921539911743408] = 0;
            if((((this.丝丑东丐丑丕丌三业 == true) ? 1 : 0) ^ 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三()) != false)
        {
                this.丝丑东丐丑丕丌三业 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        }
        
            if(ButtonJoystickAdjust.世丗一上丑上丑丄一 == null)
        {
                return;
        }
        
            val_16 = this.gameObject;
            val_17 = null;
            val_17 = null;
            ButtonJoystickAdjust.世丗一上丑上丑丄一.Invoke(sender:  val_16, e:  System.EventArgs.Empty);
            return;
        }
        
        this.丈丘专丗丗丟且丏下 = 0;
        this.丕三丈专丛丄与不丅 = 0;
    }
    private void LateUpdate()
    {
        bool val_7;
        float val_8;
        if(this.IsPress == false)
        {
            goto label_0;
        }
        
        if(this.一一丟丛丆丘东丝丌 >= 0)
        {
            goto label_1;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.丏三丛专丄下丝东丈 == false)
        {
            goto label_2;
        }
        
        TweenAlpha val_2 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  val_1, 与丈业丛丝丒丙一丏:  this.TimeBlink, 与专丌丅丙上丌一丄:  0.9f);
        val_7 = 0;
        goto label_3;
        label_0:
        if(this.业下丝丐且丁万丛丐 == true)
        {
                return;
        }
        
        TweenAlpha val_4 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  this.gameObject, 与丈业丛丝丒丙一丏:  0.5f, 与专丌丅丙上丌一丄:  1f);
        this.业下丝丐且丁万丛丐 = true;
        this.丏三丛专丄下丝东丈 = false;
        this.一一丟丛丆丘东丝丌 = this.TimeBlink;
        return;
        label_1:
        val_8 = this.一一丟丛丆丘东丝丌 - UnityEngine.Time.deltaTime;
        goto label_6;
        label_2:
        TweenAlpha val_6 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  val_1, 与丈业丛丝丒丙一丏:  this.TimeBlink, 与专丌丅丙上丌一丄:  0.1f);
        val_7 = true;
        label_3:
        val_8 = this.TimeBlink;
        this.丏三丛专丄下丝东丈 = val_7;
        label_6:
        this.一一丟丛丆丘东丝丌 = val_8;
        this.业下丝丐且丁万丛丐 = false;
    }
    public bool IsDrag()
    {
        this._isDrag = false;
        return (bool)this._isDrag;
    }
    public ButtonJoystickAdjust()
    {
        this.业下丝丐且丁万丛丐 = true;
        this.TimeBlink = 0.5f;
    }
    private bool 万七不丂丂丙丘万下(UISprite 丏丂丛丙丆三专丂丛)
    {
        var val_6;
        if(丏丂丛丙丆三专丂丛 != 0)
        {
                if((丏丂丛丙丆三专丂丛.GetComponent<ButtonJoystickAdjust>()) != 0)
        {
                val_6 = (丏丂丛丙丆三专丂丛.Equals(other:  this.丛东上丂东一丒丈世)) ^ 1;
            return (bool)val_6 & 1;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6 & 1;
    }
    private bool 丗丞丁丄一丟丕丐丘(UISprite 丏丂丛丙丆三专丂丛)
    {
        var val_6;
        if(丏丂丛丙丆三专丂丛 != 0)
        {
                if((丏丂丛丙丆三专丂丛.GetComponent<ButtonJoystickAdjust>()) != 0)
        {
                val_6 = (丏丂丛丙丆三专丂丛.Equals(other:  this.丛东上丂东一丒丈世)) ^ 1;
            return (bool)val_6 & 1;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6 & 1;
    }

}
