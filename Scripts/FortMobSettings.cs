using UnityEngine;
internal sealed class FortMobSettings : IMobeSettings
{
    // Fields
    private float _damageToTurrets;
    private float _damageToPlayer;
    public float multipler;
    
    // Methods
    internal override float 业丂丛丟上且丂东丂(object[] 丗专丆万丏万丂丂丆)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        float val_13;
        object val_14;
        if(this.multipler != (-1f))
        {
            goto label_1;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_7;
        }
        
        }
        
        val_10 = null;
        val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        if((val_9.ContainsKey(key:  GameConnect.丛专丌丅丁万丅丙丒)) == false)
        {
            goto label_16;
        }
        
        世丁与丕丗丟丒丆上 val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_6 == null)
        {
            goto label_19;
        }
        
        val_11 = val_6.丑丗三丛丛丆丟丌丆();
        if(val_11 == null)
        {
            goto label_24;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = val_11.Item[GameConnect.丛专丌丅丁万丅丙丒];
        if(val_6 != null)
        {
                if(this != null)
        {
            goto label_24;
        }
        
        }
        
        val_9 = 0;
        goto label_25;
        label_16:
        val_13 = this.multipler;
        goto label_29;
        label_7:
        this.multipler = 1f;
        if(丗专丆万丏万丂丂丆 != null)
        {
            goto label_30;
        }
        
        goto label_28;
        label_19:
        val_11 = 0;
        label_24:
        val_9 = this;
        label_25:
        this.multipler = 13073.37f;
        val_13 = this.multipler;
        if(val_13 <= 0f)
        {
                val_13 = 1f;
            this.multipler = 1f;
        }
        
        label_29:
        float val_9 = this._damageToPlayer;
        val_9 = val_9 * val_13;
        val_13 = val_13 * this._damageToTurrets;
        this._damageToTurrets = val_13;
        this._damageToPlayer = val_9;
        label_1:
        if(丗专丆万丏万丂丂丆 != null)
        {
            goto label_30;
        }
        
        label_28:
        label_30:
        if(丗专丆万丏万丂丂丆.Length == 0)
        {
            goto label_40;
        }
        
        val_14 = 丗专丆万丏万丂丂丆[0];
        if(丗专丆万丏万丂丂丆.Length == 0)
        {
            goto label_36;
        }
        
        if(val_14 != null)
        {
            goto label_37;
        }
        
        goto label_40;
        label_36:
        val_14 = 丗专丆万丏万丂丂丆[0];
        if(val_14 == null)
        {
            goto label_40;
        }
        
        label_37:
        label_40:
        float val_10 = this._damageToTurrets;
        val_10 = val_10 * val_9;
        return (float)val_10;
    }
    internal override bool 七不一业丁丑专丝世()
    {
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
                return GameConnect.七丂万专且丏丘一丙();
        }
        
        return true;
    }
    internal override void 丘上丐世丆丑且丞丒(string 丒丘丏上丙丟丑丕丈)
    {
        丈丝丞下丙七与丙丟 val_2 = 万七万丂三与丏丘丅.丑七不且上丗丁一世().丐下下丅与上东丙丑(三丒丈七东下丌丝丗:  丒丘丏上丙丟丑丕丈);
        if(val_2 != null)
        {
                mem[1152921540123708312] = val_2.且丝丘丐且下丄丕业();
            mem[1152921540123708316] = val_2.且丝丘丐且下丄丕业();
            mem[1152921540123708320] = val_2.三丏丟不丆丅丞不丛();
            mem[1152921540123708324] = val_2.三丌丂下丛业丈丝东();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_2.世丕上丕丞丘丅且上());
            mem[1152921540123708332] = val_9.x;
            mem[1152921540123708336] = val_9.y;
            mem[1152921540123708340] = val_9.z;
            this._damageToTurrets = val_2.丅且丌业一丕业丝万();
            this._damageToPlayer = val_2.与丙丈专丗丄丟丕专();
            mem[1152921540123708328] = val_2.七与万且专丁丝丘丈();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Нету настроек для моба " + 丒丘丏上丙丟丑丕丈);
    }
    public FortMobSettings()
    {
        this.multipler = -1f;
    }

}
