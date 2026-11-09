using UnityEngine;
private sealed class EmbeddedConfig.丆丂丏丑丙业上且丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.WWW 东丞丒丙世丏三下丟;
    public string 丟丈一下东业一丝丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EmbeddedConfig.丆丂丏丑丙业上且丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_9;
        int val_10;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_18;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Debug.Log(message:  "[E_mbeddedConfig] D_ownloadModulesConfigCoroutine => Downloading...");
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_5:
        if(this.东丞丒丙世丏三下丟.isDone == false)
        {
            goto label_7;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.东丞丒丙世丏三下丟.error)) == false)
        {
            goto label_9;
        }
        
        UnityEngine.Debug.Log(message:  "[E_mbeddedConfig] D_ownloadModulesConfigCoroutine => Downloaded.");
        val_9 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "Assets/Scripts/ConfigSystem/Resources/{0}.prefab", arg0:  this.丟丈一下东业一丝丆);
        object[] val_6 = new object[1];
        val_6[0] = val_9;
        UnityEngine.Debug.LogFormat(format:  "[E_mbeddedConfig] D_ownloadModulesConfigCoroutine => Saving... path: {0}", args:  val_6);
        goto label_18;
        label_7:
        val_10 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_9:
        object[] val_7 = new object[1];
        val_9 = val_7;
        val_9[0] = this.东丞丒丙世丏三下丟.error;
        UnityEngine.Debug.LogErrorFormat(format:  "[E_mbeddedConfig] D_ownloadModulesConfig => error: {0}", args:  val_7);
        label_18:
        val_10 = 0;
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
