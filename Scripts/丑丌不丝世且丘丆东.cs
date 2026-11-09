using UnityEngine;
private sealed class NewsLobbyController.丑丌不丝世且丘丆东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.NewsLobbyController 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List<string> 下与万丗丕丕业丈上;
    private System.Collections.Generic.List<string> 上丘专丙丘丂三世丅;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NewsLobbyController.丑丌不丝世且丘丆东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.NewsLobbyController val_26;
        var val_27;
        var val_28;
        int val_29;
        System.Collections.Generic.List<System.String> val_30;
        string val_31;
        var val_32;
        var val_33;
        int val_34;
        val_26 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  this.丝且与丝丒丟万丁专.丛丑丙丗丞丝丘且丞, defaultValue:  "[]"));
        val_27 = 0;
        goto label_6;
        label_1:
        val_28 = this;
        val_29 = this.丟丗丒丟丝丘丞丝丏 + 1;
        val_30 = 1152921553931508688;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丟丗丒丟丝丘丞丝丏 = val_29;
        goto label_7;
        label_6:
        System.Collections.Generic.List<System.String> val_4 = null;
        val_31 = 1152921516107644960;
        val_4 = new System.Collections.Generic.List<System.String>();
        this.下与万丗丕丕业丈上 = val_4;
        this.上丘专丙丘丂三世丅 = new System.Collections.Generic.List<System.String>();
        val_32 = 0;
        val_30 = this.上丘专丙丘丂三世丅;
        goto label_8;
        label_16:
        this.下与万丗丕丕业丈上.Add(item:  Item[0]);
        val_31 = Item[0];
        this.上丘专丙丘丂三世丅.SyncRoot.Add(item:  val_31);
        val_32 = 1;
        label_8:
        if(val_32 < Count)
        {
            goto label_16;
        }
        
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_9 = MailBoxMessagesController.丄丞丁丈与业上丞丟.业丗与世东丗丒世专();
        val_33 = 0;
        goto label_18;
        label_34:
        丏不一丏丗丗丗丈丞 val_10 = val_9.Item[0];
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10.FullPicture)) != true)
        {
                if((this.上丘专丙丘丂三世丅.SyncRoot.Contains(item:  val_10.FullPicture)) != false)
        {
                bool val_13 = this.上丘专丙丘丂三世丅.SyncRoot.Remove(item:  val_10.FullPicture);
        }
        
        }
        
        val_31 = val_10.SquareFullPicture;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_31)) != true)
        {
                val_31 = mem[this.上丘专丙丘丂三世丅];
            val_31 = this.上丘专丙丘丂三世丅.SyncRoot;
            if((val_31.Contains(item:  val_10.SquareFullPicture)) != false)
        {
                val_31 = mem[this.上丘专丙丘丂三世丅];
            val_31 = this.上丘专丙丘丂三世丅.SyncRoot;
            bool val_16 = val_31.Remove(item:  val_10.SquareFullPicture);
        }
        
        }
        
        val_33 = 1;
        label_18:
        if(val_33 < val_9.Count)
        {
            goto label_34;
        }
        
        val_28 = this;
        this.丟丗丒丟丝丘丞丝丏 = 0;
        val_26 = val_26;
        val_29 = 0;
        label_7:
        if(val_29 < this.上丘专丙丘丂三世丅.SyncRoot.Count)
        {
                val_31 = 1152921516223708000;
            System.IO.File.Delete(path:  Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  this.上丘专丙丘丂三世丅.SyncRoot.Item[0]));
            val_29 = this.上丘专丙丘丂三世丅.Item[this.丟丗丒丟丝丘丞丝丏];
            bool val_23 = this.下与万丗丕丕业丈上.Remove(item:  val_29);
            val_34 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_34;
            return (bool)val_34;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  this.丝且与丝丒丟万丁专 + 304, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.下与万丗丕丕业丈上));
        label_2:
        val_34 = 0;
        return (bool)val_34;
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
