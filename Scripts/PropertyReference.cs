using UnityEngine;
[Serializable]
public class PropertyReference
{
    // Fields
    private UnityEngine.Component mTarget;
    private string mName;
    private System.Reflection.FieldInfo mField;
    private System.Reflection.PropertyInfo mProperty;
    private static int s_Hash;
    
    // Properties
    public UnityEngine.Component target { get; set; }
    public string name { get; set; }
    public bool isValid { get; }
    public bool isEnabled { get; }
    
    // Methods
    public UnityEngine.Component get_target()
    {
        return (UnityEngine.Component)this.mTarget;
    }
    public void set_target(UnityEngine.Component 丙业与丙丗丝不丈东)
    {
        this.mTarget = 丙业与丙丗丝不丈东;
        this.mField = 0;
        this.mProperty = 0;
    }
    public string get_name()
    {
        return (string)this.mName;
    }
    public void set_name(string 丙业与丙丗丝不丈东)
    {
        this.mField = 0;
        this.mProperty = 0;
        this.mName = 丙业与丙丗丝不丈东;
    }
    public bool get_isValid()
    {
        var val_4;
        if(this.mTarget != 0)
        {
                val_4 = (System.String.IsNullOrEmpty(value:  this.mName)) ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 0;
        return (bool)val_4 & 1;
    }
    public bool get_isEnabled()
    {
        var val_4;
        var val_5;
        val_4 = this;
        if(this.mTarget == 0)
        {
                val_5 = 0;
            return (bool)val_5;
        }
        
        val_4 = 0;
        if( != 0)
        {
                return enabled;
        }
        
        val_5 = 1;
        return (bool)val_5;
    }
    public PropertyReference()
    {
    
    }
    public PropertyReference(UnityEngine.Component 丞下万上三丘上与专, string 世丘下丐丐丅一丑丙)
    {
        val_1 = new System.Object();
        this.mTarget = 丞下万上三丘上与专;
        this.mName = val_1;
    }
    public System.Type 东丝丒与三丐丏丛丛()
    {
        System.Reflection.PropertyInfo val_11;
        if(((System.Reflection.PropertyInfo.op_Equality(left:  this.mProperty, right:  0)) != false) && ((System.Reflection.FieldInfo.op_Equality(left:  this.mField, right:  0)) != false))
        {
                if(this.isValid != false)
        {
                bool val_4 = this.丏万丟丙上丏丟万丑();
        }
        
        }
        
        if((System.Reflection.PropertyInfo.op_Inequality(left:  this.mProperty, right:  0)) == false)
        {
            goto label_4;
        }
        
        val_11 = this.mProperty;
        if(val_11 != null)
        {
            goto typeof(System.Reflection.FieldInfo).__il2cppRuntimeField_258;
        }
        
        goto typeof(System.Reflection.FieldInfo).__il2cppRuntimeField_258;
        label_4:
        if((System.Reflection.FieldInfo.op_Inequality(left:  this.mField, right:  0)) == false)
        {
                return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        
        val_11 = this.mField;
        goto typeof(System.Reflection.FieldInfo).__il2cppRuntimeField_258;
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
        UnityEngine.Component val_4;
        var val_5;
        if(万且万且丑丗且丌丆 != null)
        {
                val_4 = this.mTarget;
            if(val_4 == X22)
        {
                return System.String.Equals(a:  this.mName, b:  X22);
        }
        
            val_5 = 0;
        }
        else
        {
                bool val_2 = this.isValid;
            val_5 = val_2 ^ 1;
        }
        
        val_2 = val_5;
        return (bool)val_2;
    }
    public override int GetHashCode()
    {
        null = null;
        return (int)PropertyReference.s_Hash;
    }
    public void 丅专下万丕丑丆丅丝(UnityEngine.Component 丞下万上三丘上与专, string 丑与丆丝丕东丛丄丝)
    {
        this.mTarget = 丞下万上三丘上与专;
        this.mName = 丑与丆丝丕东丛丄丝;
    }
    public void 世业丒万丘丆专丘丐()
    {
        this.mTarget = 0;
        this.mName = 0;
    }
    public void 且七丙丄丘一丄上不()
    {
        this.mField = 0;
        this.mProperty = 0;
    }
    public override string ToString()
    {
        return PropertyReference.一丁与丙世与东丆丆(不下丙丟专丙丆万丆:  this.mTarget, 丄丒丗丟世丘万丙丟:  this.mName);
    }
    public static string 一丁与丙世与东丆丆(UnityEngine.Component 不下丙丟专丙丆万丆, string 丄丒丗丟世丘万丙丟)
    {
        string val_7;
        if(不下丙丟专丙丆万丆 == 0)
        {
                return 0;
        }
        
        val_7 = 不下丙丟专丙丆万丆.GetType();
        int val_3 = val_7.LastIndexOf(value:  '.');
        if(val_3 >= 1)
        {
                val_7 = val_7.Substring(startIndex:  val_3 + 1);
        }
        
        if((System.String.IsNullOrEmpty(value:  丄丒丗丟世丘万丙丟)) == false)
        {
                return val_7 + "." + 丄丒丗丟世丘万丙丟;
        }
        
        return val_7 + ".[property]";
    }
    public object 丐下下丅与上东丙丑()
    {
        var val_8;
        var val_10;
        var val_15;
        var val_16;
        val_15 = this;
        if(((System.Reflection.PropertyInfo.op_Equality(left:  this.mProperty, right:  0)) != false) && ((System.Reflection.FieldInfo.op_Equality(left:  this.mField, right:  0)) != false))
        {
                if(this.isValid != false)
        {
                bool val_4 = this.丏万丟丙上丏丟万丑();
        }
        
        }
        
        if((System.Reflection.PropertyInfo.op_Inequality(left:  this.mProperty, right:  0)) != false)
        {
                if((this.mProperty & 1) == 0)
        {
                return 0;
        }
        
            val_16 = ???;
            val_15 = ???;
        }
        else
        {
                if((System.Reflection.FieldInfo.op_Inequality(left:  val_15 + 32, right:  0)) == false)
        {
                return 0;
        }
        
            val_16 = val_8;
            val_15 = val_10;
        }
    
    }
    public bool 丅专下万丕丑丆丅丝(object 丙业与丙丗丝不丈东)
    {
        UnityEngine.Component val_16;
        var val_17;
        val_16 = this;
        object val_7 = 丙业与丙丗丝不丈东;
        if(((System.Reflection.PropertyInfo.op_Equality(left:  this.mProperty, right:  0)) != false) && ((System.Reflection.FieldInfo.op_Equality(left:  this.mField, right:  0)) != false))
        {
                if(this.isValid != false)
        {
                bool val_4 = this.丏万丟丙上丏丟万丑();
        }
        
        }
        
        if((System.Reflection.PropertyInfo.op_Equality(left:  this.mProperty, right:  0)) != false)
        {
                if((System.Reflection.FieldInfo.op_Equality(left:  this.mField, right:  0)) == true)
        {
            goto label_37;
        }
        
        }
        
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_6;
        }
        
        label_13:
        if((this.丘丙丄丆丑丗下丁丒(丙业与丙丗丝不丈东: ref  val_7)) == false)
        {
            goto label_7;
        }
        
        if((System.Reflection.FieldInfo.op_Inequality(left:  this.mField, right:  0)) == false)
        {
            goto label_8;
        }
        
        val_16 = this.mTarget;
        this.mField.SetValue(obj:  val_16, value:  val_7);
        goto label_35;
        label_6:
        if((System.Reflection.PropertyInfo.op_Inequality(left:  this.mProperty, right:  0)) == false)
        {
            goto label_11;
        }
        
        if((this.mProperty & 1) == 0)
        {
            goto label_13;
        }
        
        val_16 = this.mTarget;
        if(this.mProperty != null)
        {
            goto label_35;
        }
        
        goto label_35;
        label_7:
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_37;
        }
        
        object[] val_12 = new object[4];
        val_12[0] = "Unable to convert ";
        val_12[1] = val_7.GetType();
        val_12[2] = " to ";
        val_12[3] = this.东丝丒与三丐丏丛丛();
        val_16 = +val_12;
        UnityEngine.Debug.LogError(message:  val_16);
        goto label_37;
        label_11:
        val_16 = this.mTarget;
        this.mField.SetValue(obj:  val_16, value:  0);
        goto label_35;
        label_8:
        if((this.mProperty & 1) == 0)
        {
            goto label_37;
        }
        
        val_16 = this.mTarget;
        label_35:
        val_17 = 1;
        return (bool)val_17;
        label_37:
        val_17 = 0;
        return (bool)val_17;
    }
    private bool 丏万丟丙上丏丟万丑()
    {
        System.Reflection.FieldInfo val_7;
        var val_8;
        if(this.mTarget != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.mName)) == false)
        {
            goto label_4;
        }
        
        }
        
        val_7 = 0;
        val_8 = 0;
        this.mField = 0;
        goto label_5;
        label_4:
        System.Type val_3 = this.mTarget.GetType();
        this.mField = val_3.GetField(name:  this.mName);
        val_7 = this.mField;
        label_5:
        this.mProperty = val_3.GetProperty(name:  this.mName);
        if((System.Reflection.FieldInfo.op_Inequality(left:  val_7, right:  0)) == false)
        {
                return System.Reflection.PropertyInfo.op_Inequality(left:  this.mProperty, right:  0);
        }
        
        return true;
    }
    private bool 丘丙丄丆丑丗下丁丒(ref object 丙业与丙丗丝不丈东)
    {
        System.Type val_6;
        if(this.mTarget == 0)
        {
                return false;
        }
        
        System.Type val_2 = this.东丝丒与三丐丏丛丛();
        if(val_5 != null)
        {
                val_6 = val_5.GetType();
            return PropertyReference.丘丙丄丆丑丗下丁丒(丙业与丙丗丝不丈东: ref  object val_5 = 丙业与丙丗丝不丈东, 丈丗与丞一上且上上:  val_6 = val_2, 专丂丕丗丗东世丞下:  val_2);
        }
        
        if(val_2.IsClass == false)
        {
                return false;
        }
        
        return PropertyReference.丘丙丄丆丑丗下丁丒(丙业与丙丗丝不丈东: ref  val_5, 丈丗与丞一上且上上:  val_6, 专丂丕丗丗东世丞下:  val_2);
    }
    public static bool 丘丙丄丆丑丗下丁丒(System.Type 丈丗与丞一上且上上, System.Type 专丂丕丗丗东世丞下)
    {
        return (bool)PropertyReference.丘丙丄丆丑丗下丁丒(丙业与丙丗丝不丈东: ref  0, 丈丗与丞一上且上上:  丈丗与丞一上且上上, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下);
    }
    public static bool 丘丙丄丆丑丗下丁丒(object 丙业与丙丗丝不丈东, System.Type 专丂丕丗丗东世丞下)
    {
        System.Type val_5;
        if(丙业与丙丗丝不丈东 != null)
        {
                val_5 = 丙业与丙丗丝不丈东.GetType();
            return (bool)PropertyReference.丘丙丄丆丑丗下丁丒(丙业与丙丗丝不丈东: ref  0, 丈丗与丞一上且上上:  val_5 = 专丂丕丗丗东世丞下, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下);
        }
        
        val_5 = 专丂丕丗丗东世丞下;
        val_5 = 专丂丕丗丗东世丞下;
        return (bool)PropertyReference.丘丙丄丆丑丗下丁丒(丙业与丙丗丝不丈东: ref  0, 丈丗与丞一上且上上:  val_5, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下);
    }
    public static bool 丘丙丄丆丑丗下丁丒(ref object 丙业与丙丗丝不丈东, System.Type 丈丗与丞一上且上上, System.Type 专丂丕丗丗东世丞下)
    {
        int val_7;
        System.Type val_18;
        var val_19;
        object val_20;
        var val_21;
        var val_22;
        object val_23;
        var val_24;
        var val_26;
        val_18 = 专丂丕丗丗东世丞下;
        int val_8 = 0;
        if((val_18 & 1) != 0)
        {
            goto label_2;
        }
        
        if((System.Type.op_Equality(left:  val_18, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_5;
        }
        
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_6;
        }
        
        val_19 = 丙业与丙丗丝不丈东;
        goto label_19;
        label_5:
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_32;
        }
        
        if((System.Type.op_Equality(left:  val_18, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_11;
        }
        
        val_18 = null;
        if((System.Type.op_Equality(left:  丈丗与丞一上且上上, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_18}))) == false)
        {
            goto label_14;
        }
        
        val_20 = 丙业与丙丗丝不丈东;
        if((val_20 != null) && (mem[丙业与丙丗丝不丈东] != null))
        {
                val_20 = 0;
        }
        
        if((System.Int32.TryParse(s:  val_20, result: out  val_8)) == false)
        {
            goto label_32;
        }
        
        val_21 = 0;
        val_22 = 1152921504622075904;
        goto label_18;
        label_6:
        val_19 = "null";
        goto label_19;
        label_11:
        if((System.Type.op_Equality(left:  val_18, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_32;
        }
        
        val_18 = null;
        if((System.Type.op_Equality(left:  丈丗与丞一上且上上, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_18}))) == false)
        {
            goto label_32;
        }
        
        val_23 = 丙业与丙丗丝不丈东;
        if((val_23 != null) && (mem[丙业与丙丗丝不丈东] != null))
        {
                val_23 = 0;
        }
        
        if((System.Single.TryParse(s:  val_23, result: out  val_8)) == false)
        {
            goto label_32;
        }
        
        val_21 = 0;
        val_22 = 1152921504624205824;
        label_18:
        val_7 = val_21;
        goto label_29;
        label_14:
        val_18 = null;
        if((System.Type.op_Equality(left:  丈丗与丞一上且上上, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_18}))) == false)
        {
            goto label_32;
        }
        
        val_18 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        val_7 = UnityEngine.Mathf.RoundToInt(f:  mem[丙业与丙丗丝不丈东]);
        val_24 = null;
        label_29:
        label_19:
        丙业与丙丗丝不丈东 = val_7;
        mem[1152921535217089076] = 268435463;
        label_2:
        val_26 = 1;
        return (bool)val_26;
        label_32:
        val_26 = 0;
        return (bool)val_26;
    }
    private static PropertyReference()
    {
        if("PropertyBinding" == null)
        {
                "PropertyBinding" = "PropertyBinding";
        }
        
        PropertyReference.s_Hash = "PropertyBinding";
    }

}
