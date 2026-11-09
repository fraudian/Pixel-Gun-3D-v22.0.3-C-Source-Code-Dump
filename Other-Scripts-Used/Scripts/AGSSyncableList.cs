using UnityEngine;
public class AGSSyncableList : AGSSyncable
{
    // Methods
    public AGSSyncableList(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524084212176] = javaObject;
    }
    public AGSSyncableList(UnityEngine.AndroidJavaObject javaObject)
    {
    
    }
    public void SetMaxSize(int size)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(size != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(size == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = size;
        this.Call(method:  "setMaxSize", args:  val_1);
    }
    public int GetMaxSize()
    {
        if(this != null)
        {
                return this.Call<System.Int32>(method:  "getMaxSize", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Int32>(method:  "getMaxSize", args:  System.Array.Empty<System.Object>());
    }
    public bool IsSet()
    {
        if(this != null)
        {
                return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
    }
    public void Add(string val, System.Collections.Generic.Dictionary<string, string> metadata)
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
        this.Call(method:  "add", args:  val_1);
    }
    public void Add(string val)
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
        this.Call(method:  "add", args:  val_1);
    }

}
