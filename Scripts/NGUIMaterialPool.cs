using UnityEngine;
internal class NGUIMaterialPool : MonoBehaviour
{
    // Fields
    internal static NGUIMaterialPool 丄丘七三上丕世丞业;
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<NGUIMaterialPool.丘下与丄丂七丐丑丂>> _pool;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Shader> 三七上业业不丕丏丙;
    
    // Methods
    private void Awake()
    {
        null = null;
        NGUIMaterialPool.丄丘七三上丕世丞业 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    internal UnityEngine.Shader 丁一丏丆丟丗七丆丌(string 丌下上上世丏七丒丑)
    {
        if((this.三七上业业不丕丏丙.TryGetValue(key:  丌下上上世丏七丒丑, value: out  0)) == true)
        {
                return val_3;
        }
        
        UnityEngine.Shader val_3 = UnityEngine.Shader.Find(name:  丌下上上世丏七丒丑);
        if(val_3 == 0)
        {
                return val_3;
        }
        
        this.三七上业业不丕丏丙.set_Item(key:  丌下上上世丏七丒丑, value:  val_3);
        return val_3;
    }
    internal UnityEngine.Material 丁丄三下七丝丐丞七(string 丌下上上世丏七丒丑, UnityEngine.Material 不丘丅丝业世三业丏)
    {
        UnityEngine.Material val_1 = this.丁丄三下七丝丐丞七(丌下上上世丏七丒丑:  丌下上上世丏七丒丑);
        if(val_1 == 0)
        {
                return this.丒丌丄一丕丑丘丑丞(丌下上上世丏七丒丑:  丌下上上世丏七丒丑, 世丑丘丘丂专丅丆与:  不丘丅丝业世三业丏);
        }
        
        return val_1;
    }
    internal UnityEngine.Material 丁丄三下七丝丐丞七(string 丌下上上世丏七丒丑, UnityEngine.Shader 丕丄与专丛丝丄丐下)
    {
        UnityEngine.Material val_1 = this.丁丄三下七丝丐丞七(丌下上上世丏七丒丑:  丌下上上世丏七丒丑);
        if(val_1 == 0)
        {
                return this.丒丌丄一丕丑丘丑丞(丌下上上世丏七丒丑:  丌下上上世丏七丒丑, 丕丄与专丛丝丄丐下:  丕丄与专丛丝丄丐下);
        }
        
        return val_1;
    }
    private UnityEngine.Material 丁丄三下七丝丐丞七(string 丌下上上世丏七丒丑)
    {
        var val_4;
        int val_5;
        val_4 = this.丌丒丝七丞丄上丁丆(丌下上上世丏七丒丑:  丌下上上世丏七丒丑);
        List.Enumerator<T> val_2 = val_4.GetEnumerator();
        label_4:
        if(((-536251656) & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = 0.丐丏七丌丕丗业且上();
        if(0 == 0)
        {
            goto label_4;
        }
        
        val_5 = val_3.m_stringLength;
        mem2[0] = 0;
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (UnityEngine.Material);
    }
    internal bool 下一丟丆丅万丏丅丁(string 丌下上上世丏七丒丑, UnityEngine.Material 丘上专不丂万业不一)
    {
        int val_5;
        var val_6;
        val_5 = this;
        List.Enumerator<T> val_2 = this.丌丒丝七丞丄上丁丆(丌下上上世丏七丒丑:  丌下上上世丏七丒丑).GetEnumerator();
        label_6:
        if(((-536111000) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        val_5 = val_3.m_stringLength;
        if(val_5 != 丘上专不丂万业不一)
        {
            goto label_6;
        }
        
        val_6 = 1;
        mem2[0] = val_6;
        goto label_7;
        label_2:
        val_6 = 0;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    internal UnityEngine.Material 丒丌丄一丕丑丘丑丞(string 丌下上上世丏七丒丑, UnityEngine.Material 世丑丘丘丂专丅丆与)
    {
        var val_4;
        System.Collections.Generic.List<丘下与丄丂七丐丑丂> val_1 = this.丌丒丝七丞丄上丁丆(丌下上上世丏七丒丑:  丌下上上世丏七丒丑);
        NGUIMaterialPool.丘下与丄丂七丐丑丂 val_2 = null;
        .丄世不下专七丂丘丝 = true;
        val_2 = new NGUIMaterialPool.丘下与丄丂七丐丑丂();
        UnityEngine.Material val_3 = new UnityEngine.Material(source:  世丑丘丘丂专丅丆与);
        if(val_2 != null)
        {
                val_4 = val_2;
            .丘上专不丂万业不一 = val_3;
        }
        else
        {
                val_4 = 16;
            mem[16] = val_3;
        }
        
        .丄世不下专七丂丘丝 = false;
        val_1.Add(item:  val_2);
        this._pool.set_Item(key:  丌下上上世丏七丒丑, value:  val_1);
        return (UnityEngine.Material)val_4;
    }
    internal UnityEngine.Material 丒丌丄一丕丑丘丑丞(string 丌下上上世丏七丒丑, UnityEngine.Shader 丕丄与专丛丝丄丐下)
    {
        var val_4;
        System.Collections.Generic.List<丘下与丄丂七丐丑丂> val_1 = this.丌丒丝七丞丄上丁丆(丌下上上世丏七丒丑:  丌下上上世丏七丒丑);
        NGUIMaterialPool.丘下与丄丂七丐丑丂 val_2 = null;
        .丄世不下专七丂丘丝 = true;
        val_2 = new NGUIMaterialPool.丘下与丄丂七丐丑丂();
        UnityEngine.Material val_3 = new UnityEngine.Material(shader:  丕丄与专丛丝丄丐下);
        if(val_2 != null)
        {
                val_4 = val_2;
            .丘上专不丂万业不一 = val_3;
        }
        else
        {
                val_4 = 16;
            mem[16] = val_3;
        }
        
        .丄世不下专七丂丘丝 = false;
        val_1.Add(item:  val_2);
        this._pool.set_Item(key:  丌下上上世丏七丒丑, value:  val_1);
        return (UnityEngine.Material)val_4;
    }
    private System.Collections.Generic.List<NGUIMaterialPool.丘下与丄丂七丐丑丂> 丌丒丝七丞丄上丁丆(string 丌下上上世丏七丒丑)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<丘下与丄丂七丐丑丂>> val_3 = this._pool;
        if((val_3.ContainsKey(key:  丌下上上世丏七丒丑)) != true)
        {
                val_3 = this._pool;
            val_3.Add(key:  丌下上上世丏七丒丑, value:  new System.Collections.Generic.List<丘下与丄丂七丐丑丂>());
        }
        
        if(this._pool != null)
        {
                return this._pool.Item[丌下上上世丏七丒丑];
        }
        
        return this._pool.Item[丌下上上世丏七丒丑];
    }
    public NGUIMaterialPool()
    {
        this._pool = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<丘下与丄丂七丐丑丂>>();
        this.三七上业业不丕丏丙 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Shader>();
    }
    private static NGUIMaterialPool()
    {
    
    }

}
