using UnityEngine;
public class GuiSettings : ScriptableObject
{
    // Fields
    public EventGuiSettings.ColorPalette colorPalette;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Color> _colorDict;
    public EventGuiSettings.ResoucePalette spritePalette;
    private System.Collections.Generic.Dictionary<string, string> _spriteDict;
    public EventGuiSettings.ResoucePalette texturePalette;
    private System.Collections.Generic.Dictionary<string, string> _textureDict;
    public EventGuiSettings.ResoucePalette shaderPalette;
    private System.Collections.Generic.Dictionary<string, string> _shaderDict;
    public EventGuiSettings.ResoucePalette materialPalette;
    private System.Collections.Generic.Dictionary<string, string> _materialDict;
    public EventGuiSettings.ResoucePalette prefabPalette;
    private System.Collections.Generic.Dictionary<string, string> _prefabDict;
    public EventGuiSettings.ResoucePalette localizationKeyPalette;
    private System.Collections.Generic.Dictionary<string, string> _localizationKeyDict;
    
    // Properties
    internal System.Collections.Generic.Dictionary<string, UnityEngine.Color> colorDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> spriteDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> textureDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> shaderDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> materialDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> prefabDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> localizationKeyDict { get; }
    
    // Methods
    internal System.Collections.Generic.Dictionary<string, UnityEngine.Color> get_colorDict()
    {
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Color> val_3;
        if(this._colorDict != null)
        {
                if(this._colorDict.Count != 0)
        {
                val_3 = this._colorDict;
            return val_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Color> val_2 = this.colorPalette.丘且且丙丐丙丏丝与();
        this._colorDict = val_2;
        return val_2;
    }
    internal System.Collections.Generic.Dictionary<string, string> get_spriteDict()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_3;
        if(this._spriteDict != null)
        {
                if(this._spriteDict.Count != 0)
        {
                val_3 = this._spriteDict;
            return val_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.spritePalette.丒丒专丘丝丂丙世丝();
        this._spriteDict = val_2;
        return val_2;
    }
    internal System.Collections.Generic.Dictionary<string, string> get_textureDict()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_3;
        if(this._textureDict != null)
        {
                if(this._textureDict.Count != 0)
        {
                val_3 = this._textureDict;
            return val_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.texturePalette.丒丒专丘丝丂丙世丝();
        this._textureDict = val_2;
        return val_2;
    }
    internal System.Collections.Generic.Dictionary<string, string> get_shaderDict()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_3;
        if(this._shaderDict != null)
        {
                if(this._shaderDict.Count != 0)
        {
                val_3 = this._shaderDict;
            return val_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.shaderPalette.丒丒专丘丝丂丙世丝();
        this._shaderDict = val_2;
        return val_2;
    }
    internal System.Collections.Generic.Dictionary<string, string> get_materialDict()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_3;
        if(this._materialDict != null)
        {
                if(this._materialDict.Count != 0)
        {
                val_3 = this._materialDict;
            return val_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.materialPalette.丒丒专丘丝丂丙世丝();
        this._materialDict = val_2;
        return val_2;
    }
    internal System.Collections.Generic.Dictionary<string, string> get_prefabDict()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_3;
        if(this._prefabDict != null)
        {
                if(this._prefabDict.Count != 0)
        {
                val_3 = this._prefabDict;
            return val_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.prefabPalette.丒丒专丘丝丂丙世丝();
        this._prefabDict = val_2;
        return val_2;
    }
    internal System.Collections.Generic.Dictionary<string, string> get_localizationKeyDict()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_3;
        if(this._localizationKeyDict != null)
        {
                if(this._localizationKeyDict.Count != 0)
        {
                val_3 = this._localizationKeyDict;
            return val_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.localizationKeyPalette.丒丒专丘丝丂丙世丝();
        this._localizationKeyDict = val_2;
        return val_2;
    }
    internal void 丒丗丙丙丙丟专丅万(string 丒丘丏上丙丟丑丕丈, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        System.Collections.Generic.List<ColorElement> val_5;
        ColorElement val_6;
        val_5 = this;
        List.Enumerator<T> val_1 = this.colorPalette.colors.GetEnumerator();
        label_5:
        if(((-1105327128) & 1) == 0)
        {
            goto label_3;
        }
        
        val_6 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_5;
        }
        
        mem2[0] = 丑丞丈丗丄丙丟万丄.r;
        mem2[0] = 丑丞丈丗丄丙丟万丄.g;
        mem2[0] = 丑丞丈丗丄丙丟万丄.b;
        mem2[0] = 丑丞丈丗丄丙丟万丄.a;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        EventGuiSettings.ColorElement val_4 = null;
        val_6 = val_4;
        val_4 = new EventGuiSettings.ColorElement();
        if(val_6 != null)
        {
                .name = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[16] = 丒丘丏上丙丟丑丕丈;
        }
        
        .color = 丑丞丈丗丄丙丟万丄;
        mem[1152921537861318748] = 丑丞丈丗丄丙丟万丄.g;
        mem[1152921537861318752] = 丑丞丈丗丄丙丟万丄.b;
        mem[1152921537861318756] = 丑丞丈丗丄丙丟万丄.a;
        val_5 = this.colorPalette.colors;
        val_5.Add(item:  val_4);
    }
    internal void 与专丟业下且丕不丈(string 丒丘丏上丙丟丑丕丈, string 万丑丞一丝丌丐丒丘)
    {
        string val_5 = 万丑丞一丝丌丐丒丘;
        List.Enumerator<T> val_1 = this.spritePalette.resouces.GetEnumerator();
        label_5:
        if(((-1105153656) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_5;
        }
        
        mem2[0] = val_5;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        EventGuiSettings.ResouceElement val_4 = new EventGuiSettings.ResouceElement();
        if(val_4 != null)
        {
                .name = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[16] = 丒丘丏上丙丟丑丕丈;
        }
        
        .resouceName = val_5;
        val_5 = this.spritePalette.resouces;
        val_5.Add(item:  val_4);
    }
    internal void 丟不丏世丝丕与世丘(string 丒丘丏上丙丟丑丕丈, string 下丕不世丕丄丐丑万)
    {
        string val_5 = 下丕不世丕丄丐丑万;
        List.Enumerator<T> val_1 = this.texturePalette.resouces.GetEnumerator();
        label_5:
        if(((-1104976120) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_5;
        }
        
        mem2[0] = val_5;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        EventGuiSettings.ResouceElement val_4 = new EventGuiSettings.ResouceElement();
        if(val_4 != null)
        {
                .name = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[16] = 丒丘丏上丙丟丑丕丈;
        }
        
        .resouceName = val_5;
        val_5 = this.texturePalette.resouces;
        val_5.Add(item:  val_4);
    }
    internal void 丆丕丐丁丝丝不丒万(string 丒丘丏上丙丟丑丕丈, string 丌下上上世丏七丒丑)
    {
        string val_5 = 丌下上上世丏七丒丑;
        List.Enumerator<T> val_1 = this.shaderPalette.resouces.GetEnumerator();
        label_5:
        if(((-1104798584) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_5;
        }
        
        mem2[0] = val_5;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        EventGuiSettings.ResouceElement val_4 = new EventGuiSettings.ResouceElement();
        if(val_4 != null)
        {
                .name = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[16] = 丒丘丏上丙丟丑丕丈;
        }
        
        .resouceName = val_5;
        val_5 = this.shaderPalette.resouces;
        val_5.Add(item:  val_4);
    }
    internal void 专丏专上丅与丄丙丅(string 丒丘丏上丙丟丑丕丈, string 丟东丕丗丑丏丐丟丅)
    {
        string val_5 = 丟东丕丗丑丏丐丟丅;
        List.Enumerator<T> val_1 = this.materialPalette.resouces.GetEnumerator();
        label_5:
        if(((-1104621048) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_5;
        }
        
        mem2[0] = val_5;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        EventGuiSettings.ResouceElement val_4 = new EventGuiSettings.ResouceElement();
        if(val_4 != null)
        {
                .name = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[16] = 丒丘丏上丙丟丑丕丈;
        }
        
        .resouceName = val_5;
        val_5 = this.materialPalette.resouces;
        val_5.Add(item:  val_4);
    }
    internal void 丙丗丑丐上丂丐丞丛(string 丒丘丏上丙丟丑丕丈, string 丟丈一下东业一丝丆)
    {
        string val_5 = 丟丈一下东业一丝丆;
        List.Enumerator<T> val_1 = this.prefabPalette.resouces.GetEnumerator();
        label_5:
        if(((-1104443512) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_5;
        }
        
        mem2[0] = val_5;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        EventGuiSettings.ResouceElement val_4 = new EventGuiSettings.ResouceElement();
        if(val_4 != null)
        {
                .name = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[16] = 丒丘丏上丙丟丑丕丈;
        }
        
        .resouceName = val_5;
        val_5 = this.prefabPalette.resouces;
        val_5.Add(item:  val_4);
    }
    internal void 丏丗丐丝丞丆一丙与(string 丒丘丏上丙丟丑丕丈, string 业东丘与与业丏丛丈)
    {
        string val_5 = 业东丘与与业丏丛丈;
        List.Enumerator<T> val_1 = this.localizationKeyPalette.resouces.GetEnumerator();
        label_5:
        if(((-1104265976) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丒丘丏上丙丟丑丕丈)) == false)
        {
            goto label_5;
        }
        
        mem2[0] = val_5;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        EventGuiSettings.ResouceElement val_4 = new EventGuiSettings.ResouceElement();
        if(val_4 != null)
        {
                .name = 丒丘丏上丙丟丑丕丈;
        }
        else
        {
                mem[16] = 丒丘丏上丙丟丑丕丈;
        }
        
        .resouceName = val_5;
        val_5 = this.localizationKeyPalette.resouces;
        val_5.Add(item:  val_4);
    }
    internal UnityEngine.Color 丝一丙丝上丛三丄丈(string 丒丘丏上丙丟丑丕丈)
    {
        if((this.colorDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return UnityEngine.Color.clear;
        }
        
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Color> val_3 = this.colorDict;
        if(val_3 != null)
        {
                return val_3.Item[丒丘丏上丙丟丑丕丈];
        }
        
        return val_3.Item[丒丘丏上丙丟丑丕丈];
    }
    internal string 丟丛丙不丗万丙一上(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        if((this.spriteDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                string val_4 = this.spriteDict.Item[丒丘丏上丙丟丑丕丈];
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    internal string 万世丆丘丗丅丏万不(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        if((this.textureDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                string val_4 = this.textureDict.Item[丒丘丏上丙丟丑丕丈];
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    internal string 丒丛万丟且丂下专丞(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        if((this.shaderDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                string val_4 = this.shaderDict.Item[丒丘丏上丙丟丑丕丈];
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    internal string 东业东丗业丞丄专丅(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        if((this.materialDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                string val_4 = this.materialDict.Item[丒丘丏上丙丟丑丕丈];
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    internal string 业丛业丈丐七丑丂丅(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        if((this.prefabDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                string val_4 = this.prefabDict.Item[丒丘丏上丙丟丑丕丈];
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    internal string 丂丑万丙世与丞丈丞(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        if((this.localizationKeyDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                string val_4 = this.localizationKeyDict.Item[丒丘丏上丙丟丑丕丈];
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    public GuiSettings()
    {
        this.colorPalette = new EventGuiSettings.ColorPalette();
        this.spritePalette = new EventGuiSettings.ResoucePalette();
        this.texturePalette = new EventGuiSettings.ResoucePalette();
        this.shaderPalette = new EventGuiSettings.ResoucePalette();
        this.materialPalette = new EventGuiSettings.ResoucePalette();
        this.prefabPalette = new EventGuiSettings.ResoucePalette();
        this.localizationKeyPalette = new EventGuiSettings.ResoucePalette();
    }

}
