using UnityEngine;
public class AGSSyncableDeveloperString : AGSSyncable
{
    // Methods
    public AGSSyncableDeveloperString(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524081875584] = javaObject;
    }
    public AGSSyncableDeveloperString(UnityEngine.AndroidJavaObject javaObject)
    {
    
    }
    public string getCloudValue()
    {
        if(this != null)
        {
                return this.Call<System.String>(method:  "getCloudValue", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.String>(method:  "getCloudValue", args:  System.Array.Empty<System.Object>());
    }
    public string getValue()
    {
        if(this != null)
        {
                return this.Call<System.String>(method:  "getValue", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.String>(method:  "getValue", args:  System.Array.Empty<System.Object>());
    }
    public bool inConflict()
    {
        if(this != null)
        {
                return this.Call<System.Boolean>(method:  "inConflict", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Boolean>(method:  "inConflict", args:  System.Array.Empty<System.Object>());
    }
    public bool isSet()
    {
        if(this != null)
        {
                return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
    }
    public void markAsResolved()
    {
        this.Call(method:  "markAsResolved", args:  System.Array.Empty<System.Object>());
    }
    public void setValue(string val)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val;
        this.Call(method:  "setValue", args:  val_1);
    }

}
