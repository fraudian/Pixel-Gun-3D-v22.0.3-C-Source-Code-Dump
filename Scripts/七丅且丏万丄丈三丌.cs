using UnityEngine;
private sealed class InhouseAnalyticsController.七丅且丏万丄丈三丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丑丁丒一丘丞业丗七;
    public string 七丙不丅丛丘丗万与;
    private int 丌丑与且丑东丞丕丗;
    private UnityEngine.WWW 丆丑万业丄与丈丏丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InhouseAnalyticsController.七丅且丏万丄丈三丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_9;
        int val_10;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_9;
        }
        
        this.丌丑与且丑东丞丕丗 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WWWForm val_1 = new UnityEngine.WWWForm();
        val_1.AddField(fieldName:  "Log", value:  this.丑丁丒一丘丞业丗七);
        UnityEngine.WWW val_2 = Rilisoft.与丄丁丄丙丞下下丙.与丛七丞且专丄丛世(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与, 丛丁且丏丁丄上上丄:  val_1, 丐丆丐七一上专三丑:  "");
        this.丆丑万业丄与丈丏丑 = val_2;
        if(val_2 == null)
        {
                return (bool)val_10;
        }
        
        this.丒上七丌业七丟与丐 = val_2;
        val_10 = 1;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_1:
        val_10 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((System.String.IsNullOrEmpty(value:  this.丆丑万业丄与丈丏丑.error)) == true)
        {
            goto label_9;
        }
        
        int val_9 = this.丌丑与且丑东丞丕丗;
        if(val_9 <= 2)
        {
            goto label_10;
        }
        
        val_9 = System.String.Format(format:  "ErrorSendLogWWW\t{1}\t{0}", arg0:  this.丑丁丒一丘丞业丗七, arg1:  this.丆丑万业丄与丈丏丑.error);
        System.Collections.IEnumerator val_7 = PGCompany.Analytics.InhouseAnalyticsController.丟七上丂丙三业丁丆(丑丁丒一丘丞业丗七:  val_9);
        label_9:
        val_10 = 0;
        return (bool)val_10;
        label_10:
        val_9 = val_9 + 1;
        this.丌丑与且丑东丞丕丗 = val_9;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  20f);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_10;
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
