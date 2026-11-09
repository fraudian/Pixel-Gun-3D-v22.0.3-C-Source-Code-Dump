using UnityEngine;
public class AGSSyncableStringSet : AGSSyncable
{
    // Methods
    public AGSSyncableStringSet(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524090723152] = javaObject;
    }
    public AGSSyncableStringSet(UnityEngine.AndroidJavaObject javaObject)
    {
    
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
    public AGSSyncableStringElement Get(string val)
    {
        return this.GetAGSSyncable<AGSSyncableStringElement>(method:  10, key:  val);
    }
    public bool Contains(string val)
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
        if(this != null)
        {
                return this.Call<System.Boolean>(method:  "contains", args:  val_1);
        }
        
        return this.Call<System.Boolean>(method:  "contains", args:  val_1);
    }
    public bool IsSet()
    {
        if(this != null)
        {
                return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Boolean>(method:  "isSet", args:  System.Array.Empty<System.Object>());
    }
    public System.Collections.Generic.HashSet<AGSSyncableStringElement> GetValues()
    {
        System.Object[] val_16;
        int val_1 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  10);
        System.Collections.Generic.HashSet<AGSSyncableStringElement> val_2 = new System.Collections.Generic.HashSet<AGSSyncableStringElement>();
        val_16 = System.Array.Empty<System.Object>();
        UnityEngine.AndroidJavaObject val_4 = this.Call<UnityEngine.AndroidJavaObject>(method:  "getValues", args:  val_16);
        if(val_4 == null)
        {
                return val_2;
        }
        
        UnityEngine.AndroidJavaObject val_6 = val_4.Call<UnityEngine.AndroidJavaObject>(methodName:  "iterator", args:  System.Array.Empty<System.Object>());
        if(val_6 == null)
        {
                return val_2;
        }
        
        if((val_6.Call<System.Boolean>(methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) != false)
        {
                do
        {
            UnityEngine.AndroidJavaObject val_10 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  "next", args:  System.Array.Empty<System.Object>());
            if(val_10 != null)
        {
                AGSSyncableStringElement val_11 = null;
            val_16 = val_11;
            val_11 = new AGSSyncableStringElement(jo:  val_10);
            bool val_12 = val_2.Add(item:  val_11);
        }
        
        }
        while((val_6.Call<System.Boolean>(methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) == true);
        
        }
        
        IntPtr val_15 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
        return val_2;
    }

}
