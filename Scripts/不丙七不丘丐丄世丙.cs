using UnityEngine;
private sealed class CloudHashMigrationValidator.不丙七不丘丐丄世丙
{
    // Fields
    public Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 丁七丙丛丕丙上丌丁;
    public bool 丁丐丞丝三丘丌丁万;
    public System.Func<System.Collections.Generic.Dictionary<object, object>> 专一丂三与丄专丈丆;
    public CloudHashMigrationValidator.世万丌丑丂世不丕丈 丕丅丏丁丅东且七丌;
    
    // Methods
    public CloudHashMigrationValidator.不丙七不丘丐丄世丙()
    {
    
    }
    internal void 丛丝丆丕不丏丄下丕(System.Collections.Generic.Dictionary<string, object> 丕上丑丕万丌丈丁丟, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        且万上世上丝丏丕丑 val_10;
        var val_11;
        var val_12;
        bool val_13;
        var val_14;
        var val_15;
        CloudHashMigrationValidator.世万丌丑丂世不丕丈 val_16;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丒业三下丏下东丒丕, 七丐丅专且专七三丆:  this.丁七丙丛丕丙上丌丁);
        if(丕上丑丕万丌丈丁丟 == null)
        {
            goto label_5;
        }
        
        if((丕上丑丕万丌丈丁丟.ContainsKey(key:  "err_code")) == false)
        {
            goto label_11;
        }
        
        val_12 = System.Convert.ToInt32(value:  丕上丑丕万丌丈丁丟.Item["err_code"], provider:  System.Globalization.CultureInfo.InvariantCulture);
        if(val_12 == 0)
        {
            goto label_11;
        }
        
        val_13 = 0;
        goto label_12;
        label_11:
        val_12 = 0;
        val_13 = 丕上丑丕万丌丈丁丟.ContainsKey(key:  "is_valid");
        label_12:
        val_14 = null;
        CloudHashMigrationValidator.<丆与不丟三不三丒七>k__BackingField = val_13;
        if(val_12 == 0)
        {
            goto label_14;
        }
        
        label_5:
        val_15 = null;
        val_15 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丒业三下丏下东丒丕, 七丐丅专且专七三丆:  this.丁七丙丛丕丙上丌丁);
        int val_8 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丒业三下丏下东丒丕, 一丐丗丁丞丆丅丟丄:  this.专一丂三与丄专丈丆.Invoke());
        return;
        label_14:
        this.丁丐丞丝三丘丌丁万 = true;
        val_14 = null;
        if((CloudHashMigrationValidator.<丆与不丟三不三丒七>k__BackingField) == false)
        {
                return;
        }
        
        val_16 = this.丕丅丏丁丅东且七丌;
        val_10 = this.丕丅丏丁丅东且七丌.东丟且丗且三专丙丁.丌丙丒业不丛丝丅丗.Item[this.丕丅丏丁丅东且七丌.七丞丙丒三丕且丌丟];
        CloudHashMigrationValidator.<万七丞丙丆万万一丙>k__BackingField = val_10;
    }
    internal bool 与专丙下丂丂专丏丈()
    {
        return (bool)this.丁丐丞丝三丘丌丁万;
    }

}
