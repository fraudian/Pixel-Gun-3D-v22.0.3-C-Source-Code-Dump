using UnityEngine;
public class AGSSyncableStringList : AGSSyncableList
{
    // Methods
    public AGSSyncableStringList(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524090198736] = javaObject;
    }
    public AGSSyncableStringList(UnityEngine.AndroidJavaObject javaObject)
    {
        val_1 = new AGSSyncable(jo:  javaObject);
    }
    public AGSSyncableString[] GetValues()
    {
        var val_8;
        int val_1 = UnityEngine.AndroidJNI.PushLocalFrame(capacity:  10);
        UnityEngine.AndroidJavaObject[] val_3 = this.Call<UnityEngine.AndroidJavaObject[]>(method:  "getValues", args:  System.Array.Empty<System.Object>());
        if((val_3 == null) || (val_3.Length == 0))
        {
            goto label_3;
        }
        
        int val_4 = val_3.Length & 4294967295;
        val_8 = new AGSSyncableString[0];
        if(val_3.Length < 1)
        {
            goto label_4;
        }
        
        label_12:
        AGSSyncableString val_6 = new AGSSyncableString(jo:  val_3[0]);
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
        return (AGSSyncableString[])val_8;
        label_3:
        val_8 = 0;
        return (AGSSyncableString[])val_8;
    }

}
