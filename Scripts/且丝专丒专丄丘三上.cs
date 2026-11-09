using UnityEngine;
private sealed class UnityDataConnector.且丝专丒专丄丘三上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityDataConnector 丝且与丝丒丟万丁专;
    private UnityEngine.WWW 丝与丞丈上丆丄丝丌;
    private float 丒丒丅丞丗丑丏东下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UnityDataConnector.且丝专丒专丄丘三上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_17;
        UnityEngine.WWW val_18;
        UnityEngine.WWW val_19;
        int val_20;
        val_17 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        string[] val_1 = new string[8];
        val_1[0] = this.丝且与丝丒丟万丁专.webServiceUrl;
        val_1[1] = "?ssid=";
        val_1[2] = this.丝且与丝丒丟万丁专.spreadsheetId;
        val_1[3] = "&sheet=";
        val_1[4] = this.丝且与丝丒丟万丁专.worksheetName;
        val_1[5] = "&pass=";
        val_1[6] = this.丝且与丝丒丟万丁专.password;
        val_1[7] = "&action=GetData";
        string val_2 = +val_1;
        if(this.丝且与丝丒丟万丁专.debugMode != false)
        {
                UnityEngine.Debug.Log(message:  "Connecting to webservice on " + val_2);
        }
        
        UnityEngine.WWW val_4 = null;
        val_18 = val_4;
        val_4 = new UnityEngine.WWW(url:  val_2);
        val_19 = val_17;
        this.丝与丞丈上丆丄丝丌 = val_18;
        mem[1152921526188498112] = 0;
        this.丝且与丝丒丟万丁专.世专世且丟专丁丑丄 = "Stablishing Connection... ";
        goto label_32;
        label_1:
        val_19 = this.丝与丞丈上丆丄丝丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_32:
        if(mem[this.丝与丞丈上丆丄丝丌].isDone != true)
        {
                float val_17 = this.丒丒丅丞丗丑丏东下;
            val_17 = val_17 + UnityEngine.Time.deltaTime;
            this.丒丒丅丞丗丑丏东下 = val_17;
            if(val_17 < this.丝且与丝丒丟万丁专.maxWaitTime)
        {
                val_20 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_20;
            return (bool)val_20;
        }
        
            this.丝且与丝丒丟万丁专.世专世且丟专丁丑丄 = "Max wait time reached, connection aborted.";
            UnityEngine.Debug.Log(message:  "Max wait time reached, connection aborted.");
            this.丝且与丝丒丟万丁专.丂丟世丛七丗丆不世 = false;
        }
        
        if((mem[this.丝与丞丈上丆丄丝丌].isDone == false) || ((System.String.IsNullOrEmpty(value:  mem[this.丝与丞丈上丆丄丝丌].error)) == false))
        {
            goto label_43;
        }
        
        string val_10 = mem[this.丝与丞丈上丆丄丝丌].text;
        val_18 = 1152921504833470464;
        UnityEngine.Debug.Log(message:  this.丒丒丅丞丗丑丏东下 + " : "(" : ") + val_10);
        this.丝且与丝丒丟万丁专.世专世且丟专丁丑丄 = "Connection stablished, parsing data...";
        if((System.String.op_Equality(a:  val_10, b:  "\"Incorrect Password.\"")) == false)
        {
            goto label_48;
        }
        
        val_17 = "Connection error: Incorrect Password.";
        this.丝且与丝丒丟万丁专.世专世且丟专丁丑丄 = val_17;
        UnityEngine.Debug.LogError(message:  val_17);
        goto label_57;
        label_43:
        val_17 = "Connection error after" + this.丒丒丅丞丗丑丏东下.ToString() + "seconds: "("seconds: ") + this.丝与丞丈上丆丄丝丌.error;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.世专世且丟专丁丑丄 = val_17;
        }
        else
        {
                mem[88] = val_17;
            val_17 = mem[88];
        }
        
        UnityEngine.Debug.LogError(message:  val_17);
        label_57:
        val_20 = 0;
        this.丝且与丝丒丟万丁专.丂丟世丛七丗丆不世 = false;
        return (bool)val_20;
        label_48:
        val_17 = LitJson.丑丕丈丌丂三业一下.丐丞丆丆丛丘三丗一<LitJson.丑丘丆不丄丐丟丄七[]>(丌且专不丙丕专丅万:  val_10);
        this.丝且与丝丒丟万丁专.丗一且丙丛丈丛下上 = val_17;
        this.丝且与丝丒丟万丁专.丂丟世丛七丗丆不世 = false;
        this.丝且与丝丒丟万丁专.世专世且丟专丁丑丄 = "Data Successfully Retrieved!";
        this.丝且与丝丒丟万丁专.dataDestinationObject.SendMessage(methodName:  "DoSomethingWithTheData", value:  val_17);
        label_2:
        val_20 = 0;
        return (bool)val_20;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
