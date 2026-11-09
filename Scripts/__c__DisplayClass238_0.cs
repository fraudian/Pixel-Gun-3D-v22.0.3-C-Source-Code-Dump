using UnityEngine;
private sealed class HTTPRequest.<>c__DisplayClass238_0
{
    // Fields
    public BestHTTP.HTTPRequest <>4__this;
    public System.IO.Stream stream;
    
    // Methods
    public HTTPRequest.<>c__DisplayClass238_0()
    {
    
    }
    internal void <SendHeaders>b__0(string header, System.Collections.Generic.List<string> values)
    {
        string val_19;
        var val_22;
        if(values == null)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  header)) == true)
        {
                return;
        }
        
        if(values.Count < 1)
        {
                return;
        }
        
        var val_22 = 0;
        label_44:
        if((System.String.IsNullOrEmpty(value:  values.Item[0])) == false)
        {
            goto label_6;
        }
        
        val_19 = System.String.Format(format:  "Null/empty value for header: {0}", arg0:  header);
        var val_20 = 0;
        val_20 = val_20 + 1;
        goto label_13;
        label_6:
        var val_21 = 0;
        val_21 = val_21 + 1;
        goto label_20;
        label_13:
        BestHTTP.HTTPManager.Logger.Warning(division:  "HTTPRequest", warn:  val_19);
        goto label_21;
        label_20:
        if((BestHTTP.HTTPManager.Logger.Level & 255) <= 1)
        {
                string[] val_14 = new string[5];
            val_14[0] = "Header - \'";
            val_14[1] = header;
            val_14[2] = "\': \'";
            val_14[3] = values.Item[0];
            val_14[4] = "\'";
            val_19 = +val_14;
            this.<>4__this.VerboseLogging(str:  val_19);
        }
        
        BestHTTP.Extensions.Extensions.WriteArray(stream:  this.stream, array:  BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  header + ": "(": ")));
        BestHTTP.Extensions.Extensions.WriteArray(stream:  this.stream, array:  BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  values.Item[0]));
        val_22 = null;
        val_22 = null;
        BestHTTP.Extensions.Extensions.WriteArray(stream:  this.stream, array:  BestHTTP.HTTPRequest.EOL);
        label_21:
        val_22 = val_22 + 1;
        if(val_22 < values.Count)
        {
            goto label_44;
        }
    
    }

}
