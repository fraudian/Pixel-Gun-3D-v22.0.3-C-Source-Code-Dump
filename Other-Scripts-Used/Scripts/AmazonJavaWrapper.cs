using UnityEngine;
public class AmazonJavaWrapper : IDisposable
{
    // Fields
    private UnityEngine.AndroidJavaObject jo;
    
    // Methods
    public AmazonJavaWrapper()
    {
    
    }
    public AmazonJavaWrapper(UnityEngine.AndroidJavaObject o)
    {
        this.jo = o;
    }
    public UnityEngine.AndroidJavaObject getJavaObject()
    {
        return (UnityEngine.AndroidJavaObject)this.jo;
    }
    public void setAndroidJavaObject(UnityEngine.AndroidJavaObject o)
    {
        this.jo = o;
    }
    public IntPtr GetRawObject()
    {
        if(UnityEngine.Application.platform != 11)
        {
                return 0;
        }
        
        if(this.jo != null)
        {
                return this.jo.GetRawObject();
        }
        
        return this.jo.GetRawObject();
    }
    public IntPtr GetRawClass()
    {
        if(UnityEngine.Application.platform != 11)
        {
                return 0;
        }
        
        if(this.jo != null)
        {
                return this.jo.GetRawClass();
        }
        
        return this.jo.GetRawClass();
    }
    public void Set<FieldType>(string fieldName, FieldType type)
    {
        var val_8;
        var val_9;
        val_8 = __RuntimeMethodHiddenParam;
        val_9 = type;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        val_9 = ???;
        val_8 = ???;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public FieldType Get<FieldType>(string fieldName)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return 0;
        }
        
        fieldName = ???;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public void SetStatic<FieldType>(string fieldName, FieldType type)
    {
        var val_8;
        var val_9;
        val_8 = __RuntimeMethodHiddenParam;
        val_9 = type;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        val_9 = ???;
        val_8 = ???;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public FieldType GetStatic<FieldType>(string fieldName)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return 0;
        }
        
        fieldName = ???;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public void CallStatic(string method, object[] args)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        int val_3 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  args.Length + 1);
        this.jo.CallStatic(methodName:  method, args:  args);
        IntPtr val_4 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
    }
    public void Call(string method, object[] args)
    {
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        int val_3 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  args.Length + 1);
        this.jo.Call(methodName:  method, args:  args);
        IntPtr val_4 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
    }
    public ReturnType CallStatic<ReturnType>(string method, object[] args)
    {
        var val_5;
        var val_6;
        val_5 = args;
        if(UnityEngine.Application.platform == 11)
        {
                int val_3 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  args.Length + 1);
            val_5 = this.jo;
            IntPtr val_4 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
            val_6 = val_5;
            return (object)val_6;
        }
        
        val_6 = 0;
        return (object)val_6;
    }
    public ReturnType Call<ReturnType>(string method, object[] args)
    {
        var val_6;
        var val_7;
        val_6 = args;
        if(UnityEngine.Application.platform == 11)
        {
                int val_3 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  args.Length + 1);
            val_6 = this.jo;
            IntPtr val_4 = UnityEngine.AndroidJNI.PopLocalFrame(ptr:  0);
            val_7 = val_6 & 1;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public void Dispose()
    {
        if(this.jo == null)
        {
                return;
        }
        
        this.jo.Dispose();
    }

}
