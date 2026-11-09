using UnityEngine;
internal sealed class LootButtonAdjust : ButtonJoystickAdjust
{
    // Fields
    private WeaponsLootListAdjust 三一丗丅丏一丝且丕;
    private ControlSizeController 一上不七丂丆七丈万;
    private UISprite 万万丝不丒丐丘三丑;
    private UISprite 丘丒业一世丝丞丞丞;
    private float 与世丏丑不丏丁丆丂;
    private bool 世丆丏丙丈丕丁一一;
    private bool 丑不丗丌丟上丁丌世;
    
    // Methods
    private void OnEnable()
    {
        this.万万丝不丒丐丘三丑 = this.GetComponent<UISprite>();
        this.世丆丏丙丈丕丁一一 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        if(this.万万丝不丒丐丘三丑 != 0)
        {
                this.与世丏丑不丏丁丆丂 = (float)this.万万丝不丒丐丘三丑.width;
        }
        
        this.丑不丗丌丟上丁丌世 = true;
    }
    internal void 丘丂丕丅上丘丝丏世(ControlSizeController 丙业与丙丗丝不丈东)
    {
        this.一上不七丂丆七丈万 = 丙业与丙丗丝不丈东;
    }
    internal void 丁上万丘与七丆下世(WeaponsLootListAdjust 丙业与丙丗丝不丈东)
    {
        this.三一丗丅丏一丝且丕 = 丙业与丙丗丝不丈东;
        this.丘丒业一世丝丞丞丞 = 丙业与丙丗丝不丈东.GetComponent<UISprite>();
    }
    private void Update()
    {
        bool val_14;
        UnityEngine.GameObject val_15;
        if(this.一上不七丂丆七丈万 == 0)
        {
                return;
        }
        
        if(this.三一丗丅丏一丝且丕 == 0)
        {
                return;
        }
        
        if(this.一上不七丂丆七丈万._currentSprite == this.万万丝不丒丐丘三丑)
        {
                val_14 = 1;
        }
        else
        {
                val_14 = UnityEngine.Object.op_Equality(x:  this.一上不七丂丆七丈万._currentSprite, y:  this.丘丒业一世丝丞丞丞);
        }
        
        val_15 = this.三一丗丅丏一丝且丕.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  val_14);
        if(val_14 == false)
        {
                return;
        }
        
        if(this.与世丏丑不丏丁丆丂 == (float)this.万万丝不丒丐丘三丑.width)
        {
                if(this.丑不丗丌丟上丁丌世 == false)
        {
            goto label_21;
        }
        
        }
        
        this.与世丏丑不丏丁丆丂 = (float)this.万万丝不丒丐丘三丑.width;
        this.三一丗丅丏一丝且丕.万丛丌三丈一东丆且();
        this.丑不丗丌丟上丁丌世 = false;
        label_21:
        if((((this.世丆丏丙丈丕丁一一 == true) ? 1 : 0) ^ 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三()) == false)
        {
                return;
        }
        
        this.世丆丏丙丈丕丁一一 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        this.三一丗丅丏一丝且丕.万丛丌三丈一东丆且();
    }
    protected override void 丕下丗丆丄丘丆丈万(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        this.丕下丗丆丄丘丆丈万(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        if(this.三一丗丅丏一丝且丕 == null)
        {
                return;
        }
        
        this.三一丗丅丏一丝且丕.万丛丌三丈一东丆且();
    }
    internal bool 丝与下丈丄丞万丐专(int 丙一丐丗专丙丆丒且)
    {
        var val_14;
        WeaponsLootListAdjust val_15;
        var val_16;
        val_14 = this;
        val_15 = this.三一丗丅丏一丝且丕;
        if(val_15 != 0)
        {
                val_15 = this.丘丒业一世丝丞丞丞;
            if(val_15 != 0)
        {
                int val_7 = 丙一丐丗专丙丆丒且 - this.万万丝不丒丐丘三丑.width;
            val_7 = val_7 * (((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() & true) != 0) ? (-1) : 1);
            float val_15 = 0.5f;
            float val_14 = (float)val_7;
            val_14 = val_14 * val_15;
            val_15 = ((float)this.万万丝不丒丐丘三丑.width - 丙一丐丗专丙丆丒且) * val_15;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_14, y:  val_15);
            val_14 = this.丘丒业一世丝丞丞丞.width;
            val_15 = this.丘丒业一世丝丞丞丞.height;
            val_16 = (this.三一丗丅丏一丝且丕.上丁丟丝七丘丂丌业(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, 丂丟业东丕东万与丙:  (float)val_14, 七东丗不一丌丈丙丄:  (float)val_15)) ^ 1;
            return (bool)val_16 & 1;
        }
        
        }
        
        val_16 = 0;
        return (bool)val_16 & 1;
    }
    internal UnityEngine.Vector3 不与丁东世丕丗下丛()
    {
        var val_6 = 1;
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        val_6 = this.万万丝不丒丐丘三丑.width * (((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() & true) != 0) ? (-val_6) : (val_6));
        float val_7 = (float)val_6;
        val_7 = val_7 * (-0.5f);
        val_7 = val_4.x + val_7;
        return new UnityEngine.Vector3() {x = val_7, y = val_4.y, z = val_4.z};
    }
    public override bool CheckInConstraints(UnityEngine.Vector2 七丒业丏上业丛业丅, int 业与三万七丝不万东, out UnityEngine.Vector2[] 丏丕丕七三丛三丑丝)
    {
        var val_18;
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        UnityEngine.Vector3 val_6 = this.transform.localPosition;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4.x, y:  val_6.y);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 七丒业丏上业丛业丅.x, y = 七丒业丏上业丛业丅.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        val_18 = this.丘丒业一世丝丞丞丞.width;
        bool val_11 = this.三一丗丅丏一丝且丕.上丁丟丝七丘丂丌业(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, 丂丟业东丕东万与丙:  (float)val_18, 七东丗不一丌丈丙丄:  (float)this.丘丒业一世丝丞丞丞.height);
        if(val_11 == true)
        {
                return (bool)(this.CheckInConstraints(七丒业丏上业丛业丅:  new UnityEngine.Vector2() {x = 七丒业丏上业丛业丅.x, y = 七丒业丏上业丛业丅.y}, 业与三万七丝不万东:  业与三万七丝不万东, 丏丕丕七三丛三丑丝: out  UnityEngine.Vector2[] val_1 = 丏丕丕七三丛三丑丝)) & val_11;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_12 = null;
        val_18 = val_12;
        val_12 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  val_1);
        UnityEngine.Vector3 val_13 = this.不与丁东世丕丗下丛();
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_13.x, y:  val_13.y);
        if(val_18 != null)
        {
                val_12.Add(item:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        }
        else
        {
                val_12.Add(item:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        }
        
        丏丕丕七三丛三丑丝 = val_12.ToArray();
        return (bool)(this.CheckInConstraints(七丒业丏上业丛业丅:  new UnityEngine.Vector2() {x = 七丒业丏上业丛业丅.x, y = 七丒业丏上业丛业丅.y}, 业与三万七丝不万东:  业与三万七丝不万东, 丏丕丕七三丛三丑丝: out  val_1)) & val_11;
    }
    protected override UnityEngine.Vector3 丑丛丂丏丅丅丕丕下(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 世专七丘万丌一丟丗, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        float val_41;
        float val_42;
        var val_43;
        var val_47;
        float val_48;
        float val_49;
        float val_50;
        val_41 = 业丒丝丗与丐丛丟丏.z;
        val_42 = 业丒丝丗与丐丛丟丏.x;
        val_43 = this;
        UnityEngine.Vector3 val_3 = 上上专丂丂世业业七(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_42, y = 业丒丝丗与丐丛丟丏.y, z = val_41}, 世专七丘万丌一丟丗:  new UnityEngine.Vector3() {x = 世专七丘万丌一丟丗.x, y = 世专七丘万丌一丟丗.y, z = 世专七丘万丌一丟丗.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 0f}, 丒丐与丁丆丄丗丏丕:  (X21 + 112) & 1);
        val_47 = 1152921504848912384;
        val_48 = val_3.x;
        val_49 = val_3.y;
        val_50 = val_3.z;
        if(this.三一丗丅丏一丝且丕 == 0)
        {
                return new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50};
        }
        
        if(this.丘丒业一世丝丞丞丞 == 0)
        {
                return new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50};
        }
        
        UnityEngine.Vector3 val_7 = this.transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        UnityEngine.Vector3 val_13 = this.transform.parent.InverseTransformVector(vector:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_41 = val_13.y;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_42 = val_14.x;
        val_47 = this.丘丒业一世丝丞丞丞.width;
        if((this.三一丗丅丏一丝且丕.上丁丟丝七丘丂丌业(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_42, y = val_14.y}, 丂丟业东丕东万与丙:  (float)val_47, 七东丗不一丌丈丙丄:  (float)this.丘丒业一世丝丞丞丞.height)) == true)
        {
                return new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50};
        }
        
        UnityEngine.Vector3 val_21 = this.三一丗丅丏一丝且丕.transform.localPosition;
        UnityEngine.Vector3 val_24 = this.三一丗丅丏一丝且丕.transform.localPosition;
        float val_41 = (float)this.丘丒业一世丝丞丞丞.width;
        float val_42 = 0.5f;
        val_41 = val_41 * val_42;
        val_42 = (float)this.丘丒业一世丝丞丞丞.height * val_42;
        val_41 = ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f) * val_41;
        val_41 = val_21.x - val_41;
        val_42 = val_24.y - val_42;
        UnityEngine.Transform val_27 = this.三一丗丅丏一丝且丕.transform.parent;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_41, z = val_13.z});
        UnityEngine.Vector3 val_29 = val_27.TransformPoint(position:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_47 = this.三一丗丅丏一丝且丕.transform.parent;
        UnityEngine.Vector3 val_32 = val_47.lossyScale;
        UnityEngine.Vector3 val_33 = val_27.万丝丌一专丁丙丗丟(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, 且丛上丕业丂丒与一:  1f, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, 一世丅丕丑丈丕世丈:  false);
        val_41 = 0f;
        UnityEngine.Vector3 val_36 = this.三一丗丅丏一丝且丕.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_41, z = 0f});
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
        val_43 = this.transform;
        UnityEngine.Vector3 val_39 = val_43.position;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        val_48 = val_40.x;
        val_49 = val_40.y;
        val_50 = val_40.z;
        return new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50};
    }
    public LootButtonAdjust()
    {
    
    }

}
