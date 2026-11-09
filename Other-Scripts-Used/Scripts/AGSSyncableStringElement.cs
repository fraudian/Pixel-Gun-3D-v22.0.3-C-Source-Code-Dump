using UnityEngine;
public class AGSSyncableStringElement : AGSSyncableElement
{
    // Methods
    public AGSSyncableStringElement(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524089772624] = javaObject;
    }
    public AGSSyncableStringElement(UnityEngine.AndroidJavaObject javaObject)
    {
        val_1 = new AGSSyncable(jo:  javaObject);
    }
    public string GetValue()
    {
        if(this != null)
        {
                return this.Call<System.String>(method:  "getValue", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.String>(method:  "getValue", args:  System.Array.Empty<System.Object>());
    }

}
