using UnityEngine;
public class AGSSyncableNumberElement : AGSSyncableElement
{
    // Methods
    public AGSSyncableNumberElement(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524086744816] = javaObject;
    }
    public AGSSyncableNumberElement(UnityEngine.AndroidJavaObject javaObject)
    {
        val_1 = new AGSSyncable(jo:  javaObject);
    }
    public long AsLong()
    {
        if(this != null)
        {
                return this.Call<System.Int64>(method:  "asLong", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Int64>(method:  "asLong", args:  System.Array.Empty<System.Object>());
    }
    public double AsDouble()
    {
        if(this != null)
        {
                return this.Call<System.Double>(method:  "asDouble", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Double>(method:  "asDouble", args:  System.Array.Empty<System.Object>());
    }
    public int AsInt()
    {
        if(this != null)
        {
                return this.Call<System.Int32>(method:  "asInt", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Int32>(method:  "asInt", args:  System.Array.Empty<System.Object>());
    }
    public string AsString()
    {
        if(this != null)
        {
                return this.Call<System.String>(method:  "asString", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.String>(method:  "asString", args:  System.Array.Empty<System.Object>());
    }

}
