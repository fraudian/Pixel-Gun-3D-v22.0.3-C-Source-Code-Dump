using UnityEngine;
public class AGSLatestStringList : AGSSyncableStringList
{
    // Methods
    public AGSLatestStringList(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524077975056] = javaObject;
    }
    public AGSLatestStringList(UnityEngine.AndroidJavaObject javaObject)
    {
        val_1 = new AGSSyncable(jo:  javaObject);
    }

}
