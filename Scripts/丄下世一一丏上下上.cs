using UnityEngine;
private sealed class UnityDataConnector.丄下世一一丏上下上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityDataConnector 丝且与丝丒丟万丁专;
    public string 丌七与万丆丘丞丁一;
    public float 且丐丑丐与丂上万世;
    private UnityEngine.WWW 丝与丞丈上丆丄丝丌;
    private float 丒丒丅丞丗丑丏东下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UnityDataConnector.丄下世一一丏上下上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WWW val_14;
        UnityEngine.WWW val_15;
        var val_16;
        int val_17;
        val_14 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_58;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丗丆丅丄不丝一上丐 == false)
        {
            goto label_58;
        }
        
        string[] val_1 = new string[12];
        val_1[0] = this.丝且与丝丒丟万丁专.webServiceUrl;
        val_1[1] = "?ssid=";
        val_1[2] = this.丝且与丝丒丟万丁专.spreadsheetId;
        val_1[3] = "&sheet=";
        val_1[4] = this.丝且与丝丒丟万丁专.statisticsWorksheetName;
        val_1[5] = "&pass=";
        val_1[6] = this.丝且与丝丒丟万丁专.password;
        val_1[7] = "&val1=";
        val_1[8] = this.丌七与万丆丘丞丁一;
        val_1[9] = "&val2=";
        val_1[10] = this.且丐丑丐与丂上万世.ToString();
        val_1[11] = "&action=SetData";
        string val_3 = +val_1;
        if(this.丝且与丝丒丟万丁专.debugMode != false)
        {
                UnityEngine.Debug.Log(message:  "Connection String: "("Connection String: ") + val_3);
        }
        
        UnityEngine.WWW val_5 = null;
        val_15 = val_5;
        val_5 = new UnityEngine.WWW(url:  val_3);
        val_16 = val_14;
        this.丝与丞丈上丆丄丝丌 = val_15;
        mem[1152921526189364416] = 0;
        if(val_15 != null)
        {
            goto label_47;
        }
        
        goto label_46;
        label_1:
        val_16 = val_14;
        val_15 = this.丝与丞丈上丆丄丝丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_15 != null)
        {
            goto label_47;
        }
        
        label_46:
        label_47:
        if(val_15.isDone != true)
        {
                float val_14 = this.丒丒丅丞丗丑丏东下;
            val_14 = val_14 + UnityEngine.Time.deltaTime;
            this.丒丒丅丞丗丑丏东下 = val_14;
            if(val_14 < this.丝且与丝丒丟万丁专.maxWaitTime)
        {
                val_17 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_17;
            return (bool)val_17;
        }
        
        }
        
        val_14 = this.丝与丞丈上丆丄丝丌;
        if(val_5.isDone != false)
        {
                val_14 = this.丝与丞丈上丆丄丝丌;
            if((System.String.IsNullOrEmpty(value:  val_5.error)) != false)
        {
                val_14 = val_5.text;
            if((val_14.Contains(value:  "Incorrect Password")) != true)
        {
                bool val_13 = val_14.Contains(value:  "RCVD OK");
        }
        
        }
        
        }
        
        label_58:
        val_17 = 0;
        return (bool)val_17;
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
