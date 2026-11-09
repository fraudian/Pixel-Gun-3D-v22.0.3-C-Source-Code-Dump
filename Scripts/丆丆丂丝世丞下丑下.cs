using UnityEngine;
private sealed class UpdatesChecker.丆丆丂丝世丞下丑下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丝丅丏丙丞丟丕丘上;
    public UpdatesChecker 丝且与丝丒丟万丁专;
    private string 丅七不丕上丁万上丟;
    private UnityEngine.WWW 不世世丄丗丈丅七三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UpdatesChecker.丆丆丂丝世丞下丑下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_17;
        System.Object[] val_18;
        int val_19;
        string val_20;
        val_17 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_18 = Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世();
        this.丅七不丕上丁万上丟 = val_18.三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  this.丝丅丏丙丞丟丕丘上);
        val_19 = 1;
        UnityEngine.WWW val_3 = Rilisoft.与丄丁丄丙丞下下丙.三专世丝丝丈丂东与(七丙不丅丛丘丗万与:  this.丝丅丏丙丞丟丕丘上, 丝丌丝不丟丞丑丑丗:  true);
        this.不世世丄丗丈丅七三 = val_3;
        if(val_3 == null)
        {
            goto label_6;
        }
        
        this.丒上七丌业七丟与丐 = val_3;
        this.丗丏丅丕丆世丁专丟 = val_19;
        return (bool)val_19;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((System.String.IsNullOrEmpty(value:  this.不世世丄丗丈丅七三.error)) != false)
        {
                if((System.String.IsNullOrEmpty(value:  this.丅七不丕上丁万上丟)) != true)
        {
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_20 = this.丅七不丕上丁万上丟;
            if(UnityEngine.Application.isEditor != false)
        {
                val_20 = "<color=orange>"("<color=orange>") + val_20 + "</color>"("</color>");
        }
        
            object[] val_10 = new object[1];
            val_18 = val_10;
            val_18[0] = val_20;
            UnityEngine.Debug.LogFormat(format:  "Trying to save updates image to cache \'{0}\'", args:  val_10);
        }
        
            string val_11 = System.IO.Path.GetDirectoryName(path:  this.丅七不丕上丁万上丟);
            if((System.IO.Directory.Exists(path:  val_11)) != true)
        {
                System.IO.DirectoryInfo val_13 = System.IO.Directory.CreateDirectory(path:  val_11);
        }
        
            System.IO.File.WriteAllBytes(path:  this.丅七不丕上丁万上丟, bytes:  this.不世世丄丗丈丅七三.bytes);
            0.一丘丏丗丈一万丛不(丝丅丏丙丞丟丕丘上:  this.丝丅丏丙丞丟丕丘上);
        }
        
            this.不世世丄丗丈丅七三.Dispose();
            val_19 = 0;
            this.不世世丄丗丈丅七三 = 0;
            return (bool)val_19;
        }
        
        val_17 = "Download pic error: "("Download pic error: ") + this.不世世丄丗丈丅七三.error;
        UnityEngine.Debug.LogWarning(message:  val_17);
        label_6:
        val_19 = 0;
        return (bool)val_19;
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
