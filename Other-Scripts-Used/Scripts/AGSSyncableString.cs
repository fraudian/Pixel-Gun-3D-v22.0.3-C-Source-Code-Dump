using UnityEngine;
public class AGSSyncableString : AGSSyncableStringElement
{
    // Methods
    public AGSSyncableString(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524089073296] = javaObject;
    }
    public AGSSyncableString(UnityEngine.AndroidJavaObject javaObject)
    {
        val_1 = new AGSSyncable(jo:  javaObject);
    }
    public void Set(string val)
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
        this.Call(method:  "set", args:  val_1);
    }
    public void Set(string val, System.Collections.Generic.Dictionary<string, string> metadata)
    {
        object[] val_1 = new object[2];
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
        val_1[1] = val.DictionaryToAndroidHashMap(dictionary:  metadata);
        this.Call(method:  "set", args:  val_1);
    }
    public bool IsSet()
    {
        if(this != null)
        {
                return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
    }

}
