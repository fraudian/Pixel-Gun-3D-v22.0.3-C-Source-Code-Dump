using UnityEngine;
public class AGSSyncableElement : AGSSyncable
{
    // Methods
    public AGSSyncableElement(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524083173488] = javaObject;
    }
    public AGSSyncableElement(UnityEngine.AndroidJavaObject javaObject)
    {
    
    }
    public long GetTimestamp()
    {
        if(this != null)
        {
                return this.Call<System.Int64>(method:  "getTimestamp", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Int64>(method:  "getTimestamp", args:  System.Array.Empty<System.Object>());
    }
    public System.Collections.Generic.Dictionary<string, string> GetMetadata()
    {
        System.Object[] val_18;
        string val_19;
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        int val_2 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  10);
        val_18 = System.Array.Empty<System.Object>();
        UnityEngine.AndroidJavaObject val_4 = this.Call<UnityEngine.AndroidJavaObject>(method:  "getMetadata", args:  val_18);
        if(val_4 == null)
        {
            goto label_2;
        }
        
        val_18 = val_4.Call<UnityEngine.AndroidJavaObject>(methodName:  "keySet", args:  System.Array.Empty<System.Object>());
        if(val_18 == null)
        {
            goto label_3;
        }
        
        val_18 = val_18.Call<UnityEngine.AndroidJavaObject>(methodName:  "iterator", args:  System.Array.Empty<System.Object>());
        if(val_18 == null)
        {
            goto label_4;
        }
        
        if((val_18.Call<System.Boolean>(methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) != false)
        {
                do
        {
            string val_12 = val_18.Call<System.String>(methodName:  "next", args:  System.Array.Empty<System.Object>());
            if(val_12 != null)
        {
                object[] val_13 = new object[1];
            val_13[0] = val_12;
            string val_14 = val_4.Call<System.String>(methodName:  "get", args:  val_13);
            if(val_14 != null)
        {
                val_1.Add(key:  val_12, value:  val_14);
        }
        
        }
        
        }
        while((val_18.Call<System.Boolean>(methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) == true);
        
        }
        
        IntPtr val_17 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
        return val_1;
        label_2:
        val_19 = "Whispersync element was unable to retrieve metadata java map";
        goto label_19;
        label_3:
        val_19 = "Whispersync element was unable to retrieve java keyset";
        goto label_19;
        label_4:
        val_19 = "Whispersync element was unable to retrieve java iterator";
        label_19:
        AGSClient.LogGameCircleError(errorMessage:  val_19);
        return val_1;
    }

}
