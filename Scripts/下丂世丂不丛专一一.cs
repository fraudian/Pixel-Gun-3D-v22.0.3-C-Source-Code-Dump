using UnityEngine;
internal abstract class 下丂世丂不丛专一一
{
    // Fields
    private static System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<下丂世丂不丛专一一.丛七万丑下东业下丟, 下丂世丂不丛专一一.丁三丆丒丝与丏丕一>, 下丂世丂不丛专一一> 丒丅上三且丟东丅丙;
    private static System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<下丂世丂不丛专一一.丛七万丑下东业下丟, 下丂世丂不丛专一一.丁三丆丒丝与丏丕一>, 下丂世丂不丛专一一> 万三丂丆不丝七专丛;
    private static System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<下丂世丂不丛专一一.丛七万丑下东业下丟, 下丂世丂不丛专一一.丁三丆丒丝与丏丕一>, 下丂世丂不丛专一一> 业一丐丏一上丕丙万;
    protected 下丂世丂不丛专一一.丟一丙丈东上万不丕[] 丘丏丆三丟丞丅上世;
    internal int[] 丛丝七丌丁丑丆丞下;
    internal UnityEngine.Vector3[] 丌丂丑丁专下丈丏三;
    internal float[] 丕丑丈丄丄丒世业丐;
    private System.Version 三丑不丐丆丝东丘不;
    
    // Properties
    protected virtual 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 与丄丁丏丙与业丗丑 { get; }
    internal bool 丁丄专丑丗丘丂丞丛 { get; }
    internal 下丂世丂不丛专一一.丟一丙丈东上万不丕[] 上丅丁不丒一丌丙东 { get; }
    internal abstract string 丕丙三下丈丒三七业 { get; }
    internal abstract string 下万丅下专丘丅东丟 { get; }
    internal abstract string 与丐与丅业丄丞专万 { get; }
    internal virtual bool 下丆七丅三丐丈丑且 { get; }
    internal abstract float 丏丕丑丐丙三丞七丒 { get; }
    
    // Methods
    internal static 下丂世丂不丛专一一.丛七万丑下东业下丟 丕丙丛万丒七业丄下(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        if(上且丗一丏丏万丅丌 == 20)
        {
                return 1;
        }
        
        上且丗一丏丏万丅丌 = ((上且丗一丏丏万丅丌 == 31) ? 1 : 0) << 1;
        return (丛七万丑下东业下丟)上且丗一丏丏万丅丌;
    }
    internal static 下丂世丂不丛专一一 丏丛丌世专丒丆不世(下丂世丂不丛专一一.丛七万丑下东业下丟 丏专丌万与上丆丈三, 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 丏东丆丆丛丄丕丈丞)
    {
        int val_10;
        int val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_10 = 丏东丆丆丛丄丕丈丞;
        val_11 = 丏专丌万与上丆丈三;
        if(val_10 == 1)
        {
            goto label_1;
        }
        
        if(val_10 != 2)
        {
            goto label_2;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = 1152921505166807056;
        goto label_8;
        label_1:
        val_14 = null;
        val_14 = null;
        val_13 = 1152921505166807048;
        goto label_8;
        label_2:
        val_15 = null;
        val_15 = null;
        label_8:
        DiscreteVector2 val_1 = new DiscreteVector2(三丟东丕丄丄下下丑:  val_11, 丒丒丄丁且丄丆丂丌:  val_10);
        if((下丂世丂不丛专一一.__il2cppRuntimeField_static_fields.TryGetValue(key:  new System.Collections.Generic.KeyValuePair<丛七万丑下东业下丟, 丁三丆丒丝与丏丕一>() {Value = val_1._x}, value: out  0)) == true)
        {
                return (下丂世丂不丛专一一)val_11;
        }
        
        if(val_10 == 0)
        {
            goto label_13;
        }
        
        if(val_11 != 1)
        {
            goto label_14;
        }
        
        三不七丅下丘万且丄 val_4 = null;
        val_11 = val_4;
        val_4 = new 三不七丅下丘万且丄(丏东丆丆丛丄丕丈丞:  val_10);
        goto label_22;
        label_13:
        if(val_11 != 1)
        {
            goto label_16;
        }
        
        丅丅一丟专七业丅三 val_5 = null;
        val_11 = val_5;
        val_5 = new 丅丅一丟专七业丅三();
        goto label_22;
        label_14:
        if(val_11 != 2)
        {
            goto label_18;
        }
        
        丆上与丟丛丞丕专世 val_6 = null;
        val_11 = val_6;
        val_6 = new 丆上与丟丛丞丕专世(丏东丆丆丛丄丕丈丞:  val_10);
        goto label_22;
        label_16:
        if(val_11 != 2)
        {
            goto label_20;
        }
        
        丝丙七丟丝丗丟丈三 val_7 = null;
        val_11 = val_7;
        val_7 = new 丝丙七丟丝丗丟丈三();
        goto label_22;
        label_18:
        丝东且七丘三三丝丏 val_8 = null;
        val_11 = val_8;
        val_8 = new 丝东且七丘三三丝丏(丏东丆丆丛丄丕丈丞:  val_10);
        goto label_22;
        label_20:
        世与且丆东丞万且下 val_9 = null;
        val_11 = val_9;
        val_9 = new 世与且丆东丞万且下();
        label_22:
        下丂世丂不丛专一一.__il2cppRuntimeField_static_fields.set_Item(key:  new System.Collections.Generic.KeyValuePair<丛七万丑下东业下丟, 丁三丆丒丝与丏丕一>() {Value = val_1._x}, value:  val_9);
        val_10 = val_11;
        return (下丂世丂不丛专一一)val_11;
    }
    internal static 下丂世丂不丛专一一 丏丛丌世专丒丆不世(下丂世丂不丛专一一.丛七万丑下东业下丟 丏专丌万与上丆丈三)
    {
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_7;
        if((ControlFireSettings.丈业且丘丈不丄丈丒(丁丅丈丌丟世丗丗丟:  丏专丌万与上丆丈三)) == null)
        {
                if((ControlFireSettings.不丁丑丁丈上丅丌丐(丁丅丈丌丟世丗丗丟:  丏专丌万与上丆丈三, 丏东丆丆丛丄丕丈丞:  0)) == null)
        {
            goto label_2;
        }
        
        }
        
        val_7 = val_2.Style;
        return 下丂世丂不丛专一一.丏丛丌世专丒丆不世(丏专丌万与上丆丈三:  丏专丌万与上丆丈三, 丏东丆丆丛丄丕丈丞:  val_7 = (~(UnityEngine.PlayerPrefs.HasKey(key:  下丂世丂不丛专一一.丏丛丌世专丒丆不世(丏专丌万与上丆丈三:  丏专丌万与上丆丈三, 丏东丆丆丛丄丕丈丞:  0)))) & 1);
        label_2:
        UnityEngine.Debug.LogError(message:  "No initialized controls settings");
        val_7 = 丟丌丁且且世丈丈丟.不丙丈丟丂丒丆丝一();
        if(val_7 != 0)
        {
                return 下丂世丂不丛专一一.丏丛丌世专丒丆不世(丏专丌万与上丆丈三:  丏专丌万与上丆丈三, 丏东丆丆丛丄丕丈丞:  val_7);
        }
        
        return 下丂世丂不丛专一一.丏丛丌世专丒丆不世(丏专丌万与上丆丈三:  丏专丌万与上丆丈三, 丏东丆丆丛丄丕丈丞:  val_7);
    }
    internal static 下丂世丂不丛专一一 丏丛丌世专丒丆不世(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        var val_1 = (上且丗一丏丏万丅丌 == 31) ? 1 : 0;
        val_1 = val_1 << 1;
        return 下丂世丂不丛专一一.丏丛丌世专丒丆不世(丏专丌万与上丆丈三:  (上且丗一丏丏万丅丌 != 20) ? (val_1) : (0 + 1));
    }
    protected virtual 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 丂丗专丅丑丝丑上丛()
    {
        return 0;
    }
    internal bool 一下丐丗丈与丟丄业()
    {
        return (bool)(this == 1) ? 1 : 0;
    }
    internal 下丂世丂不丛专一一.丟一丙丈东上万不丕[] 丆丈丆三丕不丘丄不()
    {
        丟一丙丈东上万不丕[] val_1 = this.丘丏丆三丟丞丅上世;
        if(val_1 != null)
        {
                return val_1;
        }
        
        val_1 = this.丘丏丆三丟丞丅上世;
        return val_1;
    }
    protected abstract void 丏且丛专专丁丕世丑(); // 0
    internal abstract string 上丁丈丐与丙东下七(); // 0
    internal abstract string 上丗丁丆丙不丙上上(); // 0
    internal abstract string 丆且下丏一丛丑下专(); // 0
    internal virtual bool 丁专世丅丄丟丏丒丟()
    {
        return false;
    }
    internal abstract float 与丌与业丁丄丙不东(); // 0
    internal virtual void 丘上丐世丆丑且丞丒()
    {
        System.Version val_26;
        System.Version val_27;
        int val_29;
        UnityEngine.Vector3[] val_30;
        var val_31;
        var val_32;
        val_26 = 1152921504626122752;
        val_27 = 0;
        if((System.Version.op_Inequality(v1:  业丂丏与世一丏业不.一丒三丝三下丑业下(), v2:  val_27)) == false)
        {
            goto label_10;
        }
        
        val_26 = 业丂丏与世一丏业不.一丒三丝三下丑业下();
        val_27 = this.三丑不丐丆丝东丘不;
        if((System.Version.op_LessThan(v1:  val_26, v2:  val_27)) == false)
        {
            goto label_10;
        }
        
        goto label_11;
        label_10:
        label_11:
        val_29 = 0;
        UnityEngine.Vector3[] val_5 = Load.丏丙上丞丏丆丏丙不(丒丘丏上丙丟丑丕丈:  this);
        if(val_5 != null)
        {
                val_26 = this.丌丂丑丁专下丈丏三;
            val_29 = val_5.Length & 4294967295;
            if(this.丌丂丑丁专下丈丏三.Length < val_5.Length)
        {
                this.丌丂丑丁专下丈丏三 = new UnityEngine.Vector3[0];
            val_29 = val_5.Length;
        }
        
            if(val_29 >= 1)
        {
                val_26 = 12;
            do
        {
            val_30 = this.丌丂丑丁专下丈丏三;
            var val_7 = val_5 + (0 * val_26);
            val_31 = mem[(0 * val_26) + val_5 + 32 + 4];
            val_31 = (0 * val_26) + val_5 + 32 + 4;
            var val_8 = val_30 + (0 * val_26);
            mem2[0] = (0 * val_26) + val_5 + 32;
            mem2[0] = val_31;
            mem2[0] = (0 * val_26) + val_5 + 40;
            val_29 = val_5.Length;
        }
        while((0 + 1) < val_29);
        
        }
        
        }
        
        val_32 = 0;
        object val_11 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  this, defaultValue:  "[]"));
        if(val_11 != null)
        {
                val_26 = this.丛丝七丌丁丑丆丞下;
            val_31 = 1152921516473664400;
            if(val_11.Count > this.丛丝七丌丁丑丆丞下.Length)
        {
                int val_13 = val_11.Count;
            this.丛丝七丌丁丑丆丞下 = new int[0];
        }
        
            val_32 = public System.Int32 System.Collections.Generic.List<System.Object>::get_Count();
            if(val_11.Count >= 1)
        {
                do
        {
            val_30 = 0;
            this.丛丝七丌丁丑丆丞下[0] = System.Convert.ToInt32(value:  val_11.Item[0]);
            val_32 = public System.Int32 System.Collections.Generic.List<System.Object>::get_Count();
            val_26 = 0 + 1;
        }
        while(val_26 < val_11.Count);
        
        }
        
        }
        
        object val_20 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  this, defaultValue:  "[]"));
        if(val_20 == null)
        {
                return;
        }
        
        var val_21 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_20) : 0;
        val_30 = 1152921516473664400;
        if(val_21.Count > this.丕丑丈丄丄丒世业丐.Length)
        {
                int val_23 = val_21.Count;
            this.丕丑丈丄丄丒世业丐 = new float[0];
        }
        
        val_31 = 1152921504618561536;
        val_26 = 0;
        goto label_38;
        label_45:
        val_26 = 1;
        this.丕丑丈丄丄丒世业丐[0] = System.Convert.ToSingle(value:  val_21.Item[0]);
        label_38:
        if(val_26 < val_21.Count)
        {
            goto label_45;
        }
    
    }
    internal abstract void 与丛丂且丁丟丕丂丛(); // 0
    internal abstract void 东丕丞丛三丗丈丕丆(); // 0
    internal virtual void 丘不丞丛丅丌丏不一()
    {
        goto typeof(下丂世丂不丛专一一).__il2cppRuntimeField_1E8;
    }
    internal virtual UnityEngine.Vector3 丒丅不丞下东丒丄丒(下丂世丂不丛专一一.丟一丙丈东上万不丕 丟丒丞丐丐丘丒丄东)
    {
        var val_9;
        丟一丙丈东上万不丕[] val_10;
        var val_11;
        丟一丙丈东上万不丕[] val_12;
        float val_16 = -1f;
        val_9 = 0;
        goto label_3;
        label_12:
        val_10 = this.丘丏丆三丟丞丅上世;
        if(val_10 == null)
        {
                val_10 = this.丘丏丆三丟丞丅上世;
        }
        
        if(val_9 >= this.丘丏丆三丟丞丅上世.Length)
        {
                val_11 = 0;
        }
        
        if(val_10[0] == 丟丒丞丐丐丘丒丄东)
        {
                if(val_9 < this.丌丂丑丁专下丈丏三.Length)
        {
            goto label_9;
        }
        
        }
        
        val_9 = 1;
        label_3:
        val_12 = this.丘丏丆三丟丞丅上世;
        if(val_12 != null)
        {
            goto label_10;
        }
        
        val_12 = this.丘丏丆三丟丞丅上世;
        if(val_12 == null)
        {
            goto label_11;
        }
        
        label_10:
        if(val_9 < this.丘丏丆三丟丞丅上世.Length)
        {
            goto label_12;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  10000f);
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        label_9:
        if(丟丒丞丐丐丘丒丄东 == 16)
        {
            goto label_15;
        }
        
        if(丟丒丞丐丐丘丒丄东 != 14)
        {
            goto label_16;
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        var val_10 = 12;
        val_10 = this.丌丂丑丁专下丈丏三 + (0 * val_10);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  (0 * 12) + this.丌丂丑丁专下丈丏三 + 36);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = 1f, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        if(val_7.y <= 728f)
        {
                return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        label_15:
        float val_12 = 0.5f;
        float val_11 = -1.152922E+18f;
        val_11 = val_11 * val_12;
        val_12 = (1.152922E+18f) * val_12;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = 1f, z = V2.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        label_16:
        var val_13 = 12;
        val_13 = this.丌丂丑丁专下丈丏三 + (0 * val_13);
        var val_14 = 12;
        val_14 = this.丌丂丑丁专下丈丏三 + (0 * val_14);
        var val_15 = 12;
        val_15 = this.丌丂丑丁专下丈丏三 + (0 * val_15);
        val_16 = ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : (val_16)) * ((0 * 12) + this.丌丂丑丁专下丈丏三 + 32);
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        label_11:
    }
    internal virtual void 丘业七七丆专丒丆一(下丂世丂不丛专一一.丟一丙丈东上万不丕 丟丒丞丐丐丘丒丄东, UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        var val_3;
        丟一丙丈东上万不丕[] val_4;
        var val_5;
        丟一丙丈东上万不丕[] val_6;
        float val_4 = 下业丕七东丌丝下且.x;
        val_3 = 0;
        val_4 = val_4 * ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f);
        goto label_3;
        label_12:
        val_4 = this.丘丏丆三丟丞丅上世;
        if(val_4 == null)
        {
                val_4 = this.丘丏丆三丟丞丅上世;
        }
        
        if(val_3 >= this.丘丏丆三丟丞丅上世.Length)
        {
                val_5 = 0;
        }
        
        if(val_4[0] == 丟丒丞丐丐丘丒丄东)
        {
                val_5 = 0;
            if(val_3 >= this.丌丂丑丁专下丈丏三.Length)
        {
                val_5 = 0;
        }
        
            var val_3 = this.丌丂丑丁专下丈丏三 + (0 * 12);
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        
        val_3 = 1;
        label_3:
        val_6 = this.丘丏丆三丟丞丅上世;
        if(val_6 != null)
        {
            goto label_10;
        }
        
        val_6 = this.丘丏丆三丟丞丅上世;
        if(val_6 == null)
        {
            goto label_11;
        }
        
        label_10:
        if(val_3 < this.丘丏丆三丟丞丅上世.Length)
        {
            goto label_12;
        }
        
        return;
        label_11:
    }
    internal virtual void 丟丆且丒丒七丁丝不()
    {
        Save.下丑丈丟丘丒三与丘(丒丘丏上丙丟丑丕丈:  this, 三丂丏不三上上丏丝:  this.丌丂丑丁专下丈丏三);
        UnityEngine.PlayerPrefs.SetString(key:  this, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丛丝七丌丁丑丆丞下));
        UnityEngine.PlayerPrefs.SetString(key:  this, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丕丑丈丄丄丒世业丐));
    }
    internal virtual void 丛万丘且丟丁专丒世(int[] 不丈东业与丆东丞万)
    {
        this.丛丝七丌丁丑丆丞下 = 不丈东业与丆东丞万;
        UnityEngine.PlayerPrefs.SetString(key:  this, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丛丝七丌丁丑丆丞下));
    }
    internal virtual void 上世丁丅丅丝丐不东(float[] 丈丈一丏丗丏丌丆丄)
    {
        this.丕丑丈丄丄丒世业丐 = 丈丈一丏丗丏丌丆丄;
        UnityEngine.PlayerPrefs.SetString(key:  this, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丕丑丈丄丄丒世业丐));
    }
    internal virtual int 丝丐丘丞丕不丗丑东(下丂世丂不丛专一一.丟一丙丈东上万不丕 丟丒丞丐丐丘丒丄东)
    {
        var val_1;
        int val_2;
        val_1 = 丟丒丞丐丐丘丒丄东;
        if(this.丛丝七丌丁丑丆丞下.Length > val_1)
        {
                val_1 = (long)val_1;
            val_2 = this.丛丝七丌丁丑丆丞下[((long)(int)(丟丒丞丐丐丘丒丄东)) << 2];
            return 80;
        }
        
        val_2 = 80;
        return 80;
    }
    internal virtual float 丑丁丑下丞丈丁丘东(下丂世丂不丛专一一.丟一丙丈东上万不丕 丟丒丞丐丐丘丒丄东)
    {
        丟一丙丈东上万不丕 val_1 = 丟丒丞丐丐丘丒丄东;
        if(this.丕丑丈丄丄丒世业丐.Length <= val_1)
        {
                return 1f;
        }
        
        val_1 = (long)val_1;
        float val_1 = this.丕丑丈丄丄丒世业丐[val_1];
        return 1f;
    }
    protected 下丂世丂不丛专一一()
    {
        this.三丑不丐丆丝东丘不 = new System.Version(major:  21, minor:  4, build:  0);
    }
    private static 下丂世丂不丛专一一()
    {
        下丂世丂不丛专一一.丒丅上三且丟东丅丙 = new System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<丛七万丑下东业下丟, 丁三丆丒丝与丏丕一>, 下丂世丂不丛专一一>();
        下丂世丂不丛专一一.万三丂丆不丝七专丛 = new System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<丛七万丑下东业下丟, 丁三丆丒丝与丏丕一>, 下丂世丂不丛专一一>();
        下丂世丂不丛专一一.业一丐丏一上丕丙万 = new System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<丛七万丑下东业下丟, 丁三丆丒丝与丏丕一>, 下丂世丂不丛专一一>();
    }

}
