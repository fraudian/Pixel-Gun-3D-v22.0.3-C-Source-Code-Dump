using UnityEngine;
public class GuiApplyersGroup : MonoBehaviour
{
    // Fields
    private System.Action 丁与下万丄丑丐丗丐;
    public string category;
    public string subcategory;
    public GuiSettings guiSettings;
    public System.Collections.Generic.List<GuiApplyer> allGuiApplyers;
    public System.Collections.Generic.List<GuiColorApplyer> guiColorApplyers;
    public System.Collections.Generic.List<GuiSpriteApplyer> guiSpriteApplyers;
    public System.Collections.Generic.List<GuiTextureApplyer> guiTextureApplyers;
    public System.Collections.Generic.List<GuiShaderApplyer> guiShaderApplyers;
    public System.Collections.Generic.List<GuiMaterialApplyer> guiMaterialApplyers;
    public System.Collections.Generic.List<GuiPrefabApplyer> guiPrefabApplyers;
    public System.Collections.Generic.List<GuiLocalizationApplyer> guiLocalisationApplyers;
    
    // Methods
    public void add_onSetup(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丁与下万丄丑丐丗丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁与下万丄丑丐丗丐 != 1152921537852093416);
    
    }
    public void remove_onSetup(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丁与下万丄丑丐丗丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丁与下万丄丑丐丗丐 != 1152921537852229992);
    
    }
    public virtual bool Setup(string 丑丅七丅一丈丘丞七, string 丈丂三丟丕专东丑业)
    {
        GuiSettings val_7;
        GuiSettings val_8;
        var val_9;
        this.category = 丑丅七丅一丈丘丞七;
        this.subcategory = 丈丂三丟丕专东丑业;
        val_7 = 下下丈一业上万丏丕.三丒且世下丛三丅丆(七丆丒与丗丌丄且丂:  丑丅七丅一丈丘丞七, 丒丑丞丁世丌专不丈:  丈丂三丟丕专东丑业);
        this.guiSettings = val_7;
        if(val_7 == 0)
        {
                val_8 = 下下丈一业上万丏丕.三丒且世下丛三丅丆(七丆丒与丗丌丄且丂:  丑丅七丅一丈丘丞七, 丒丑丞丁世丌专不丈:  "default");
            this.guiSettings = val_8;
        }
        else
        {
                val_8 = this.guiSettings;
        }
        
        if(val_8 == 0)
        {
                val_9 = 0;
            return (bool)val_9;
        }
        
        List.Enumerator<T> val_5 = this.allGuiApplyers.GetEnumerator();
        val_7 = 1152921537852356880;
        label_12:
        if(((-1114206296) & 1) == 0)
        {
            goto label_10;
        }
        
        if(0.丐丏七丌丕丗业且上() == null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丁与下万丄丑丐丗丐 != null)
        {
                this.丁与下万丄丑丐丗丐.Invoke();
        }
        
        val_9 = 1;
        return (bool)val_9;
    }
    public virtual void AddApplyer(GuiApplyer 与丘一世下丕丁丝丛)
    {
        goto typeof(GuiApplyersGroup).__il2cppRuntimeField_198;
    }
    public virtual void CollectApplyers()
    {
        UnityEngine.Object val_7;
        var val_8;
        val_7 = this;
        this.allGuiApplyers.Clear();
        this.guiColorApplyers.Clear();
        this.guiSpriteApplyers.Clear();
        this.guiTextureApplyers.Clear();
        this.guiShaderApplyers.Clear();
        this.guiMaterialApplyers.Clear();
        this.guiPrefabApplyers.Clear();
        this.guiLocalisationApplyers.Clear();
        List.Enumerator<T> val_3 = System.Linq.Enumerable.ToList<GuiApplyer>(source:  this.GetComponentsInChildren<GuiApplyer>(includeInactive:  true)).GetEnumerator();
        label_18:
        if(((-1113853288) & 1) == 0)
        {
            goto label_10;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        val_8 = 0;
        if(X21 == 0)
        {
            goto label_18;
        }
        
        val_8 = 0;
        if(X21 != this)
        {
            goto label_18;
        }
        
        goto label_18;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    protected virtual bool 丛且三三丟七上丑丝(GuiApplyer 与丘一世下丕丁丝丛)
    {
        var val_9;
        var val_11;
        var val_14;
        var val_16;
        var val_18;
        var val_20;
        var val_22;
        var val_24;
        System.Collections.Generic.List<GuiLocalizationApplyer> val_26;
        var val_29;
        var val_38;
        if((this.allGuiApplyers.Contains(item:  与丘一世下丕丁丝丛)) != false)
        {
                val_9 = 0;
            return (bool)val_9;
        }
        
        this.allGuiApplyers.Add(item:  与丘一世下丕丁丝丛);
        if(与丘一世下丕丁丝丛 != null)
        {
                val_11 = null;
            val_14 = null;
            val_16 = null;
            val_18 = null;
            val_20 = null;
            val_22 = null;
            val_24 = null;
            val_26 = this.guiLocalisationApplyers;
            if(val_26 == null)
        {
                val_24 = null;
        }
        
            val_29 = 0;
            val_38 = 1152921537852958096;
            val_26.Add(item:  null);
        }
        
        val_9 = 1;
        return (bool)val_9;
    }
    public virtual UnityEngine.Color GetColor(string 丒丘丏上丙丟丑丕丈)
    {
        if(this.guiSettings == 0)
        {
                return UnityEngine.Color.clear;
        }
        
        if(this.guiSettings != null)
        {
                return this.guiSettings.丝一丙丝上丛三丄丈(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        }
        
        return this.guiSettings.丝一丙丝上丛三丄丈(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
    }
    public virtual string GetSprite(string 丒丘丏上丙丟丑丕丈)
    {
        if(this.guiSettings == 0)
        {
                return "";
        }
        
        if(this.guiSettings != null)
        {
                return this.guiSettings.丟丛丙不丗万丙一上(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        }
        
        return this.guiSettings.丟丛丙不丗万丙一上(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
    }
    public virtual UnityEngine.Texture GetTexture(string 丒丘丏上丙丟丑丕丈)
    {
        var val_4 = 0;
        if(this.guiSettings == 0)
        {
                return (UnityEngine.Texture)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Texture>(东丄丐丞丙不丒东丈:  this.guiSettings.万世丆丘丗丅丏万不(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
        }
        
        return (UnityEngine.Texture)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Texture>(东丄丐丞丙不丒东丈:  this.guiSettings.万世丆丘丗丅丏万不(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
    }
    public virtual UnityEngine.Shader GetShader(string 丒丘丏上丙丟丑丕丈)
    {
        var val_4 = 0;
        if(this.guiSettings == 0)
        {
                return (UnityEngine.Shader)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Shader>(东丄丐丞丙不丒东丈:  this.guiSettings.丒丛万丟且丂下专丞(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
        }
        
        return (UnityEngine.Shader)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Shader>(东丄丐丞丙不丒东丈:  this.guiSettings.丒丛万丟且丂下专丞(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
    }
    public virtual string GetLocalizationKey(string 丒丘丏上丙丟丑丕丈)
    {
        if(this.guiSettings == 0)
        {
                return "";
        }
        
        if(this.guiSettings != null)
        {
                return this.guiSettings.丂丑万丙世与丞丈丞(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        }
        
        return this.guiSettings.丂丑万丙世与丞丈丞(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
    }
    public virtual UnityEngine.Material GetMaterial(string 丒丘丏上丙丟丑丕丈)
    {
        var val_4 = 0;
        if(this.guiSettings == 0)
        {
                return (UnityEngine.Material)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Material>(东丄丐丞丙不丒东丈:  this.guiSettings.东业东丗业丞丄专丅(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
        }
        
        return (UnityEngine.Material)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Material>(东丄丐丞丙不丒东丈:  this.guiSettings.东业东丗业丞丄专丅(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
    }
    public virtual UnityEngine.GameObject GetPrefab(string 丒丘丏上丙丟丑丕丈)
    {
        var val_4 = 0;
        if(this.guiSettings == 0)
        {
                return (UnityEngine.GameObject)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.GameObject>(东丄丐丞丙不丒东丈:  this.guiSettings.业丛业丈丐七丑丂丅(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
        }
        
        return (UnityEngine.GameObject)下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.GameObject>(东丄丐丞丙不丒东丈:  this.guiSettings.业丛业丈丐七丑丂丅(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈));
    }
    public virtual void Save()
    {
    
    }
    public virtual void Load()
    {
        goto typeof(GuiApplyersGroup).__il2cppRuntimeField_168;
    }
    public virtual void OnColorApplyerUpdate(GuiColorApplyer 丒七不与丞丈丈专与)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.guiColorApplyers.GetEnumerator();
        label_15:
        if(((-1112178928) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((((val_4 == 0) || (丒七不与丞丈丈专与 == 0)) || ((System.String.op_Equality(a:  137121792, b:  0)) == false)) || (val_4 == 丒七不与丞丈丈专与))
        {
            goto label_15;
        }
        
        UnityEngine.Color val_9 = 丒七不与丞丈丈专与.专丄下丆丛丂丅七丗();
        val_4.丆东七丂专业下与三(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public virtual void OnSpriteApplyerUpdate(GuiSpriteApplyer 丒七不与丞丈丈专与)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.guiSpriteApplyers.GetEnumerator();
        label_15:
        if(((-1112034160) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((((val_4 == 0) || (丒七不与丞丈丈专与 == 0)) || ((System.String.op_Equality(a:  137121792, b:  0)) == false)) || (val_4 == 丒七不与丞丈丈专与))
        {
            goto label_15;
        }
        
        val_4.丆东七丂专业下与三(万丑丞一丝丌丐丒丘:  丒七不与丞丈丈专与.专丄下丆丛丂丅七丗());
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public virtual void OnLocalizationApplyerUpdate(GuiLocalizationApplyer 丒七不与丞丈丈专与)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.guiLocalisationApplyers.GetEnumerator();
        label_15:
        if(((-1111885296) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((((val_4 == 0) || (丒七不与丞丈丈专与 == 0)) || ((System.String.op_Equality(a:  137121792, b:  0)) == false)) || (val_4 == 丒七不与丞丈丈专与))
        {
            goto label_15;
        }
        
        val_4.丆东七丂专业下与三(与专丒七不丈上丐上:  丒七不与丞丈丈专与.专丄下丆丛丂丅七丗());
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public virtual void OnTextureApplyerUpdate(GuiTextureApplyer 丒七不与丞丈丈专与)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.guiTextureApplyers.GetEnumerator();
        label_15:
        if(((-1111736432) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((((val_4 == 0) || (丒七不与丞丈丈专与 == 0)) || ((System.String.op_Equality(a:  137121792, b:  0)) == false)) || (val_4 == 丒七不与丞丈丈专与))
        {
            goto label_15;
        }
        
        val_4.丆东七丂专业下与三(与万丆丛丒万丝丙丑:  丒七不与丞丈丈专与.专丄下丆丛丂丅七丗());
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public virtual void OnShaderApplyerUpdate(GuiShaderApplyer 丒七不与丞丈丈专与)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.guiShaderApplyers.GetEnumerator();
        label_15:
        if(((-1111587568) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((((val_4 == 0) || (丒七不与丞丈丈专与 == 0)) || ((System.String.op_Equality(a:  137121792, b:  0)) == false)) || (val_4 == 丒七不与丞丈丈专与))
        {
            goto label_15;
        }
        
        val_4.丆东七丂专业下与三(丕丄与专丛丝丄丐下:  丒七不与丞丈丈专与.专丄下丆丛丂丅七丗());
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public virtual void OnMaterialApplyerUpdate(GuiMaterialApplyer 丒七不与丞丈丈专与)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.guiMaterialApplyers.GetEnumerator();
        label_15:
        if(((-1111438704) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((((val_4 == 0) || (丒七不与丞丈丈专与 == 0)) || ((System.String.op_Equality(a:  137121792, b:  0)) == false)) || (val_4 == 丒七不与丞丈丈专与))
        {
            goto label_15;
        }
        
        val_4.丆东七丂专业下与三(丘上专不丂万业不一:  丒七不与丞丈丈专与.专丄下丆丛丂丅七丗());
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public virtual void OnPrefabApplyerUpdate(GuiPrefabApplyer 丒七不与丞丈丈专与)
    {
        var val_3;
        UnityEngine.Debug.Log(message:  "[GuiApplyers] OnPrefabApplyerUpdate");
        List.Enumerator<T> val_1 = this.guiPrefabApplyers.GetEnumerator();
        label_17:
        if(((-1111289696) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((((val_4 == 0) || (丒七不与丞丈丈专与 == 0)) || ((System.String.op_Equality(a:  137121792, b:  0)) == false)) || (val_4 == 丒七不与丞丈丈专与))
        {
            goto label_17;
        }
        
        val_4.丆东七丂专业下与三(丑且不丕与专丄业丙:  丒七不与丞丈丈专与.专丄下丆丛丂丅七丗());
        goto label_17;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public GuiApplyersGroup()
    {
        this.allGuiApplyers = new System.Collections.Generic.List<GuiApplyer>(capacity:  0);
        this.guiColorApplyers = new System.Collections.Generic.List<GuiColorApplyer>(capacity:  0);
        this.guiSpriteApplyers = new System.Collections.Generic.List<GuiSpriteApplyer>(capacity:  0);
        this.guiTextureApplyers = new System.Collections.Generic.List<GuiTextureApplyer>(capacity:  0);
        this.guiShaderApplyers = new System.Collections.Generic.List<GuiShaderApplyer>(capacity:  0);
        this.guiMaterialApplyers = new System.Collections.Generic.List<GuiMaterialApplyer>(capacity:  0);
        this.guiPrefabApplyers = new System.Collections.Generic.List<GuiPrefabApplyer>(capacity:  0);
        this.guiLocalisationApplyers = new System.Collections.Generic.List<GuiLocalizationApplyer>(capacity:  0);
    }

}
