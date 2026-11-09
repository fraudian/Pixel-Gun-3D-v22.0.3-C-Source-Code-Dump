using UnityEngine;
public class AGSGameDataMap : AGSSyncable
{
    // Methods
    public AGSGameDataMap(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524074940176] = javaObject;
    }
    public AGSGameDataMap(UnityEngine.AndroidJavaObject javaObject)
    {
    
    }
    public AGSSyncableDeveloperString getDeveloperString(string name)
    {
        return this.GetAGSSyncable<AGSSyncableDeveloperString>(method:  0, key:  name);
    }
    public System.Collections.Generic.HashSet<string> getDeveloperStringKeys()
    {
        return this.GetHashSet(method:  0);
    }
    public AGSSyncableNumber GetHighestNumber(string name)
    {
        return this.GetAGSSyncable<AGSSyncableNumber>(method:  1, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetHighestNumberKeys()
    {
        return this.GetHashSet(method:  1);
    }
    public AGSSyncableNumber GetLowestNumber(string name)
    {
        return this.GetAGSSyncable<AGSSyncableNumber>(method:  2, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetLowestNumberKeys()
    {
        return this.GetHashSet(method:  2);
    }
    public AGSSyncableNumber GetLatestNumber(string name)
    {
        return this.GetAGSSyncable<AGSSyncableNumber>(method:  3, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetLatestNumberKeys()
    {
        return this.GetHashSet(method:  3);
    }
    public AGSSyncableNumberList GetHighNumberList(string name)
    {
        return this.GetAGSSyncable<AGSSyncableNumberList>(method:  4, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetHighNumberListKeys()
    {
        return this.GetHashSet(method:  4);
    }
    public AGSSyncableNumberList GetLowNumberList(string name)
    {
        return this.GetAGSSyncable<AGSSyncableNumberList>(method:  5, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetLowNumberListKeys()
    {
        return this.GetHashSet(method:  5);
    }
    public AGSSyncableNumberList GetLatestNumberList(string name)
    {
        return this.GetAGSSyncable<AGSSyncableNumberList>(method:  6, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetLatestNumberListKeys()
    {
        return this.GetHashSet(method:  6);
    }
    public AGSSyncableAccumulatingNumber GetAccumulatingNumber(string name)
    {
        return this.GetAGSSyncable<AGSSyncableAccumulatingNumber>(method:  7, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetAccumulatingNumberKeys()
    {
        return this.GetHashSet(method:  7);
    }
    public AGSSyncableString GetLatestString(string name)
    {
        return this.GetAGSSyncable<AGSSyncableString>(method:  8, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetLatestStringKeys()
    {
        return this.GetHashSet(method:  8);
    }
    public AGSSyncableStringList GetLatestStringList(string name)
    {
        return this.GetAGSSyncable<AGSSyncableStringList>(method:  9, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetLatestStringListKeys()
    {
        return this.GetHashSet(method:  9);
    }
    public AGSSyncableStringSet GetStringSet(string name)
    {
        return this.GetAGSSyncable<AGSSyncableStringSet>(method:  10, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetStringSetKeys()
    {
        return this.GetHashSet(method:  10);
    }
    public AGSGameDataMap GetMap(string name)
    {
        return this.GetAGSSyncable<AGSGameDataMap>(method:  11, key:  name);
    }
    public System.Collections.Generic.HashSet<string> GetMapKeys()
    {
        return this.GetHashSet(method:  11);
    }

}
