using UnityEngine;
public class EventGuiSettings : ScriptableObject
{
    // Fields
    public Rilisoft.FogSettings fogSettings;
    public UnityEngine.Color ambientCollor;
    public EventGuiSettings.ColorPalette colorPalette;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Color> _colorDict;
    public EventGuiSettings.ResoucePalette spritePalette;
    private System.Collections.Generic.Dictionary<string, string> _spriteDict;
    public EventGuiSettings.ResoucePalette texturePalette;
    private System.Collections.Generic.Dictionary<string, string> _textureDict;
    public EventGuiSettings.ResoucePalette materialPalette;
    private System.Collections.Generic.Dictionary<string, string> _materialDict;
    
    // Properties
    internal System.Collections.Generic.Dictionary<string, UnityEngine.Color> colorDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> spriteDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> textureDict { get; }
    internal System.Collections.Generic.Dictionary<string, string> materialDict { get; }
    
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
    internal void 丒丗丙丙丙丟专丅万(string 丒丘丏上丙丟丑丕丈, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        System.Collections.Generic.List<ColorElement> val_5;
        ColorElement val_6;
        val_5 = this;
        List.Enumerator<T> val_1 = this.colorPalette.colors.GetEnumerator();
        label_5:
        if(((-1553579832) & 1) == 0)
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
        mem[1152921537413066044] = 丑丞丈丗丄丙丟万丄.g;
        mem[1152921537413066048] = 丑丞丈丗丄丙丟万丄.b;
        mem[1152921537413066052] = 丑丞丈丗丄丙丟万丄.a;
        val_5 = this.colorPalette.colors;
        val_5.Add(item:  val_4);
    }
    internal void 与专丟业下且丕不丈(string 丒丘丏上丙丟丑丕丈, string 万丑丞一丝丌丐丒丘)
    {
        string val_5 = 万丑丞一丝丌丐丒丘;
        List.Enumerator<T> val_1 = this.spritePalette.resouces.GetEnumerator();
        label_5:
        if(((-1553401240) & 1) == 0)
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
        if(((-1553223704) & 1) == 0)
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
    internal void 专丏专上丅与丄丙丅(string 丒丘丏上丙丟丑丕丈, string 丟东丕丗丑丏丐丟丅)
    {
        string val_5 = 丟东丕丗丑丏丐丟丅;
        List.Enumerator<T> val_1 = this.materialPalette.resouces.GetEnumerator();
        label_5:
        if(((-1553046168) & 1) == 0)
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
    internal UnityEngine.Color 丝一丙丝上丛三丄丈(string 丒丘丏上丙丟丑丕丈)
    {
        if((this.colorDict.ContainsKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                System.Collections.Generic.Dictionary<System.String, UnityEngine.Color> val_3 = this.colorDict;
            if(val_3 != null)
        {
                return val_3.Item[丒丘丏上丙丟丑丕丈];
        }
        
            return val_3.Item[丒丘丏上丙丟丑丕丈];
        }
        
        UnityEngine.Debug.LogError(message:  "Event GUI Settings: "("Event GUI Settings: ") + this.name + "  No color with name: "("  No color with name: ") + 丒丘丏上丙丟丑丕丈);
        return UnityEngine.Color.magenta;
    }
    internal string 丟丛丙不丗万丙一上(string 丒丘丏上丙丟丑丕丈)
    {
        string val_7;
        var val_8;
        val_7 = 丒丘丏上丙丟丑丕丈;
        if((this.spriteDict.ContainsKey(key:  val_7)) != false)
        {
                string val_4 = this.spriteDict.Item[val_7];
            return (string)val_8;
        }
        
        val_7 = "Event GUI Settings: "("Event GUI Settings: ") + this.name + "  No sprite with name: "("  No sprite with name: ") + val_7;
        UnityEngine.Debug.LogError(message:  val_7);
        val_8 = "";
        return (string)val_8;
    }
    internal string 丑东丐下专丞丕丘世(string 丒丘丏上丙丟丑丕丈)
    {
        string val_7;
        var val_8;
        val_7 = 丒丘丏上丙丟丑丕丈;
        if((this.textureDict.ContainsKey(key:  val_7)) != false)
        {
                string val_4 = this.textureDict.Item[val_7];
            return (string)val_8;
        }
        
        val_7 = "Event GUI Settings: "("Event GUI Settings: ") + this.name + "  No texture with name: "("  No texture with name: ") + val_7;
        UnityEngine.Debug.LogError(message:  val_7);
        val_8 = "";
        return (string)val_8;
    }
    internal string 丑丟七一丙丈丞丑东(string 丒丘丏上丙丟丑丕丈)
    {
        string val_7;
        var val_8;
        val_7 = 丒丘丏上丙丟丑丕丈;
        if((this.materialDict.ContainsKey(key:  val_7)) != false)
        {
                string val_4 = this.materialDict.Item[val_7];
            return (string)val_8;
        }
        
        val_7 = "Event GUI Settings: "("Event GUI Settings: ") + this.name + "  No material with name: "("  No material with name: ") + val_7;
        UnityEngine.Debug.LogError(message:  val_7);
        val_8 = "";
        return (string)val_8;
    }
    public EventGuiSettings()
    {
        this.ambientCollor = 0;
        mem[1152921537414350500] = 0;
        mem[1152921537414350508] = 0;
        this.colorPalette = new EventGuiSettings.ColorPalette();
        this.spritePalette = new EventGuiSettings.ResoucePalette();
        this.texturePalette = new EventGuiSettings.ResoucePalette();
        this.materialPalette = new EventGuiSettings.ResoucePalette();
    }

}
