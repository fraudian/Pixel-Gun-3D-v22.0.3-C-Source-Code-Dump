using UnityEngine;
[Serializable]
public class EventDelegate.Parameter
{
    // Fields
    public UnityEngine.Object obj;
    public string field;
    private object mValue;
    public System.Type expectedType;
    public bool cached;
    public System.Reflection.PropertyInfo propInfo;
    public System.Reflection.FieldInfo fieldInfo;
    
    // Properties
    public object value { get; set; }
    public System.Type type { get; }
    
    // Methods
    public EventDelegate.Parameter()
    {
        this.expectedType = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
    }
    public EventDelegate.Parameter(UnityEngine.Object 万且万且丑丗且丌丆, string 上丘丕与丌且七万丟)
    {
        this.expectedType = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_2 = new System.Object();
        this.obj = 万且万且丑丗且丌丆;
        this.field = val_2;
    }
    public EventDelegate.Parameter(object 下下丏一丙不丘丌丞)
    {
        this.expectedType = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        this.mValue = 下下丏一丙不丘丌丞;
    }
    public object get_value()
    {
        var val_10;
        var val_12;
        var val_14;
        var val_24;
        System.Reflection.PropertyInfo val_25;
        string val_26;
        var val_27;
        val_24 = this;
        if(this.mValue != null)
        {
                return (object)this.mValue;
        }
        
        if(this.cached != false)
        {
                val_25 = this.propInfo;
        }
        else
        {
                val_25 = val_24;
            this.propInfo = 0;
            this.cached = true;
            mem[1152921531162649712] = 0;
            if((this.obj != 0) && ((System.String.IsNullOrEmpty(value:  this.field)) != true))
        {
                System.Type val_3 = this.obj.GetType();
            val_26 = this.field;
            System.Reflection.PropertyInfo val_4 = val_3.GetProperty(name:  val_26);
            this.propInfo = val_4;
            if((System.Reflection.PropertyInfo.op_Equality(left:  val_4, right:  0)) != false)
        {
                val_26 = this.field;
            this.fieldInfo = val_3.GetField(name:  val_26);
        }
        
        }
        
        }
        
        if((System.Reflection.PropertyInfo.op_Inequality(left:  this.propInfo, right:  0)) != false)
        {
                val_27 = ???;
            val_24 = ???;
            val_26 = ???;
        }
        else
        {
                if((System.Reflection.FieldInfo.op_Inequality(left:  val_24 + 64, right:  0)) != false)
        {
                val_27 = val_10;
            val_24 = val_12;
            val_26 = val_14;
        }
        else
        {
                if((val_12 + 16) != 0)
        {
                return (object)this.mValue;
        }
        
            if((System.Type.op_Inequality(left:  val_12 + 40, right:  0)) == false)
        {
                return System.Convert.ChangeType(value:  0, conversionType:  val_12 + 40);
        }
        
            if((val_12 + 40.IsValueType) == true)
        {
                return (object)this.mValue;
        }
        
            return System.Convert.ChangeType(value:  0, conversionType:  val_12 + 40);
        }
        
        }
    
    }
    public void set_value(object 丙业与丙丗丝不丈东)
    {
        this.mValue = 丙业与丙丗丝不丈东;
    }
    public System.Type get_type()
    {
        if(this.mValue != null)
        {
                return this.GetType();
        }
        
        if(this.obj == 0)
        {
                return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        
        this = this.obj;
        return this.GetType();
    }

}
