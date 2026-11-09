using UnityEngine;
public class AGSSyncableNumberList : AGSSyncableList
{
    // Methods
    public AGSSyncableNumberList(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524087728112] = javaObject;
    }
    public AGSSyncableNumberList(UnityEngine.AndroidJavaObject javaObject)
    {
        val_1 = new AGSSyncable(jo:  javaObject);
    }
    public void Add(long val)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val;
        this.Call(method:  "add", args:  val_1);
    }
    public void Add(double val)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val;
        this.Call(method:  "add", args:  val_1);
    }
    public void Add(int val)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val;
        this.Call(method:  "add", args:  val_1);
    }
    public void Add(long val, System.Collections.Generic.Dictionary<string, string> metadata)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val;
        val_1[1] = val.DictionaryToAndroidHashMap(dictionary:  metadata);
        this.Call(method:  "add", args:  val_1);
    }
    public void Add(double val, System.Collections.Generic.Dictionary<string, string> metadata)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val;
        val_1[1] = val.DictionaryToAndroidHashMap(dictionary:  metadata);
        this.Call(method:  "add", args:  val_1);
    }
    public void Add(int val, System.Collections.Generic.Dictionary<string, string> metadata)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val;
        val_1[1] = val.DictionaryToAndroidHashMap(dictionary:  metadata);
        this.Call(method:  "add", args:  val_1);
    }
    public AGSSyncableNumberElement[] GetValues()
    {
        var val_8;
        int val_1 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  10);
        UnityEngine.AndroidJavaObject[] val_3 = this.Call<UnityEngine.AndroidJavaObject[]>(method:  "getValues", args:  System.Array.Empty<System.Object>());
        if((val_3 == null) || (val_3.Length == 0))
        {
            goto label_3;
        }
        
        int val_4 = val_3.Length & 4294967295;
        val_8 = new AGSSyncableNumberElement[0];
        if(val_3.Length < 1)
        {
            goto label_4;
        }
        
        label_12:
        AGSSyncableNumber val_6 = new AGSSyncableNumber(jo:  val_3[0]);
        if(val_8 == null)
        {
            goto label_6;
        }
        
        if(val_6 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_6 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_8[0] = val_6;
        if((0 + 1) < val_3.Length)
        {
            goto label_12;
        }
        
        label_4:
        IntPtr val_8 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
        return (AGSSyncableNumberElement[])val_8;
        label_3:
        val_8 = 0;
        return (AGSSyncableNumberElement[])val_8;
    }

}
