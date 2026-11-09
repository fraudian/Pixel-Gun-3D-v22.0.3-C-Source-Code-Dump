using UnityEngine;
private sealed class LanguageSource.丑不丒且丐丂东专丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public I2.Loc.LanguageSource 丝且与丝丒丟万丁专;
    private UnityEngine.WWW 丝与丞丈上丆丄丝丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LanguageSource.丑不丒且丐丂东专丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        UnityEngine.WWW val_15;
        int val_16;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WWW val_1 = this.丝且与丝丒丟万丁专.Import_Google_CreateWWWcall(丑丁丌上且且丘下丌:  false);
        val_14 = this;
        this.丝与丞丈上丆丄丝丌 = val_1;
        if(val_1 != null)
        {
            goto label_6;
        }
        
        return (bool)val_16;
        label_1:
        val_14 = this;
        val_15 = this.丝与丞丈上丆丄丝丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_15 == null)
        {
                val_15 = 0;
        }
        
        label_6:
        if(val_15.isDone == false)
        {
            goto label_7;
        }
        
        if(((System.String.IsNullOrEmpty(value:  this.丝与丞丈上丆丄丝丌.error)) == false) || ((System.String.op_Inequality(a:  this.丝与丞丈上丆丄丝丌.text, b:  "\"\"")) == false))
        {
            goto label_11;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "I2Source_" + this.丝且与丝丒丟万丁专.Google_SpreadsheetKey, value:  this.丝与丞丈上丆丄丝丌.text);
        UnityEngine.PlayerPrefs.Save();
        this.丝且与丝丒丟万丁专.Import_Google_Result(丌丗丒丄丐丆与七专:  this.丝与丞丈上丆丄丝丌.text, 丟不东丌丕不丐专业:  1);
        I2.Loc.丗丈下丕丟丟丙七丞.七专丕一业丁丌且丏();
        UnityEngine.Debug.Log(message:  "Done Google Sync \'" + this.丝与丞丈上丆丄丝丌.text + "\'");
        goto label_25;
        label_2:
        val_16 = 0;
        return (bool)val_16;
        label_7:
        val_16 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
        label_11:
        UnityEngine.Debug.Log(message:  "Language Source was up-to-date with Google Spreadsheet");
        label_25:
        UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专.且且丛一业丏丁且丂.gameObject);
        val_16 = 0;
        this.丝且与丝丒丟万丁专.且且丛一业丏丁且丂 = 0;
        return (bool)val_16;
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
