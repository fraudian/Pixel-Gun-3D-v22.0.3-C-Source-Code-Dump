using UnityEngine;
public class AGSSyncable : IDisposable
{
    // Fields
    protected AmazonJavaWrapper javaObject;
    
    // Methods
    public AGSSyncable(AmazonJavaWrapper jo)
    {
        this.javaObject = jo;
    }
    public AGSSyncable(UnityEngine.AndroidJavaObject jo)
    {
        .jo = jo;
        this.javaObject = new AmazonJavaWrapper();
    }
    public void Dispose()
    {
        if(this.javaObject == null)
        {
                return;
        }
        
        if(this.javaObject.jo == null)
        {
                return;
        }
        
        this.javaObject.jo.Dispose();
    }
    protected AmazonJavaWrapper DictionaryToAndroidHashMap(System.Collections.Generic.Dictionary<string, string> dictionary)
    {
        var val_10;
        var val_22;
        var val_25;
        var val_26;
        var val_27;
        var val_29;
        int val_1 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  10);
        UnityEngine.AndroidJavaObject val_3 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  System.Array.Empty<System.Object>());
        object[] val_6 = new object[2];
        Dictionary.Enumerator<TKey, TValue> val_7 = dictionary.GetEnumerator();
        val_25 = 0;
        val_26 = 0;
        val_27 = 0;
        goto label_42;
        label_58:
        ConfiguredValueTaskAwaiter val_11 = val_10.GetAwaiter();
        object[] val_12 = new object[1];
        val_12[0] = val_11._value._obj.丐丏七丌丕丗业且上();
        new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "java.lang.String", args:  val_12);
        object[] val_15 = new object[1];
        val_15[0] = ;
        new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "java.lang.String", args:  val_15);
        val_6[0] = new UnityEngine.AndroidJavaObject();
        val_6[1] = new UnityEngine.AndroidJavaObject();
        IntPtr val_19 = UnityEngine.AndroidJNI.CallObjectMethod(obj:  val_3.GetRawObject(), methodID:  UnityEngine.AndroidJNIHelper.GetMethodID(javaClass:  val_3.GetRawClass(), methodName:  "put", signature:  "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"), args:  UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  val_6));
        val_27 = 1;
        if(new UnityEngine.AndroidJavaObject() != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            new UnityEngine.AndroidJavaObject().Dispose();
        }
        
        if(val_27 == 1)
        {
            goto label_25;
        }
        
        if(val_26 != 0)
        {
                if(186 != 186)
        {
            goto label_27;
        }
        
        }
        
        val_29 = val_26;
        if(new UnityEngine.AndroidJavaObject() != null)
        {
            goto label_56;
        }
        
        goto label_57;
        label_25:
        if(val_26 == 0)
        {
            goto label_30;
        }
        
        label_27:
        val_25 = 0;
        val_29 = 0;
        if(new UnityEngine.AndroidJavaObject() != null)
        {
            goto label_56;
        }
        
        goto label_57;
        label_30:
        val_25 = 0;
        val_29 = 0;
        val_27 = 0;
        if(new UnityEngine.AndroidJavaObject() == null)
        {
            goto label_57;
        }
        
        label_56:
        var val_26 = 0;
        val_26 = val_26 + 1;
        new UnityEngine.AndroidJavaObject().Dispose();
        label_57:
        if((val_27 != 1) && (val_22 == 186))
        {
                var val_27 = 0;
            val_27 = val_27 ^ 0;
            val_27 = val_27 + val_27;
            val_26 = val_29;
        }
        else
        {
                val_25 = 0;
            val_26 = 0;
            if(val_29 != 0)
        {
                val_25 = 0;
            val_26 = 0;
        }
        
        }
        
        label_42:
        if(((-2002996144) & 1) != 0)
        {
            goto label_58;
        }
        
        val_27 = val_27 + 1;
        mem2[0] = 214;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_27 == 1)
        {
            goto label_67;
        }
        
        if(( == 0) || ((1152921524078687232 + ((val_27 + 1)) << 2) == 214))
        {
            goto label_71;
        }
        
        label_70:
        label_71:
        IntPtr val_23 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
        .jo = val_3;
        return (AmazonJavaWrapper)new AmazonJavaWrapper();
        label_67:
        if( != 0)
        {
            goto label_70;
        }
        
        goto label_71;
    }
    protected T GetAGSSyncable<T>(AGSSyncable.SyncableMethod method)
    {
        if(this == null)
        {
            
        }
    
    }
    protected T GetAGSSyncable<T>(AGSSyncable.SyncableMethod method, string key)
    {
        var val_9;
        object val_10;
        var val_11;
        string val_12;
        System.Object[] val_13;
        var val_14;
        val_9 = __RuntimeMethodHiddenParam;
        val_10 = key;
        if(val_10 != null)
        {
                object[] val_2 = new object[1];
            val_2[0] = val_10;
            val_11 = 1152921524073461776;
            val_12 = null.ToString();
            val_13 = val_2;
        }
        else
        {
                val_10 = null.ToString();
            val_11 = 1152921524073461776;
            val_12 = val_10;
            val_13 = System.Array.Empty<System.Object>();
        }
        
        UnityEngine.AndroidJavaObject val_5 = this.javaObject.Call<UnityEngine.AndroidJavaObject>(method:  val_12, args:  val_13);
        if(val_5 != null)
        {
                val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
            object[] val_7 = new object[1];
            val_7[0] = val_5;
            object val_8 = System.Activator.CreateInstance(type:  val_10, args:  val_7);
            val_9 = mem[__RuntimeMethodHiddenParam + 48 + 8];
            val_9 = __RuntimeMethodHiddenParam + 48 + 8;
            if(val_8 != null)
        {
                val_14 = val_8;
            if(val_14 != null)
        {
                return (AGSGameDataMap)val_14;
        }
        
        }
        
        }
        
        val_14 = 0;
        return (AGSGameDataMap)val_14;
    }
    protected System.Collections.Generic.HashSet<string> GetHashSet(AGSSyncable.HashSetMethod method)
    {
        string val_16;
        int val_1 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  10);
        System.Collections.Generic.HashSet<System.String> val_2 = new System.Collections.Generic.HashSet<System.String>();
        val_16 = method.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.AndroidJavaObject val_5 = this.javaObject.Call<UnityEngine.AndroidJavaObject>(method:  val_16, args:  System.Array.Empty<System.Object>());
        if(val_5 == null)
        {
                return val_2;
        }
        
        UnityEngine.AndroidJavaObject val_7 = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "iterator", args:  System.Array.Empty<System.Object>());
        if(val_7 == null)
        {
                return val_2;
        }
        
        if((val_7.Call<System.Boolean>(methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) != false)
        {
                do
        {
            val_16 = val_7.Call<System.String>(methodName:  "next", args:  System.Array.Empty<System.Object>());
            bool val_12 = val_2.Add(item:  val_16);
        }
        while((val_7.Call<System.Boolean>(methodName:  "hasNext", args:  System.Array.Empty<System.Object>())) == true);
        
        }
        
        IntPtr val_15 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
        return val_2;
    }

}
