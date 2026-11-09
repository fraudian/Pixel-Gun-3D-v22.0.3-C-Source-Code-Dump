using UnityEngine;
private sealed class Packet.<>c__DisplayClass60_0
{
    // Fields
    public int number;
    public BestHTTP.SocketIO.Packet <>4__this;
    public string switch;
    
    // Methods
    public Packet.<>c__DisplayClass60_0()
    {
    
    }
    internal void <ReplacePlaceholderWithNumber>b__0(string json, System.Collections.Generic.Dictionary<string, object> obj)
    {
        BestHTTP.SocketIO.Packet val_4;
        object val_5;
        val_4 = this;
        val_5 = obj.Item["num"];
        if((System.Convert.ToInt32(value:  val_5)) != this.number)
        {
                return;
        }
        
        val_5 = this.<>4__this.<Payload>k__BackingField;
        this.<>4__this.<Payload>k__BackingField = val_5.Replace(oldValue:  json, newValue:  this.switch);
        val_4 = this.<>4__this;
        this.<>4__this.<IsDecoded>k__BackingField = false;
    }

}
