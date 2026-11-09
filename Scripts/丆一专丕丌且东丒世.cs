using UnityEngine;
private sealed class SkinName.丆一专丕丌且东丒世
{
    // Fields
    public bool 丕专丄丄丞丑七万丟;
    
    // Methods
    public SkinName.丆一专丕丌且东丒世()
    {
    
    }
    internal UnityEngine.Material[] 丁世上丈不专世上丆(UnityEngine.GameObject 万且万且丑丗且丌丆)
    {
        UnityEngine.Material val_26;
        var val_27;
        var val_28;
        val_26 = 万且万且丑丗且丌丆.transform;
        if(val_26.childCount == 0)
        {
            goto label_9;
        }
        
        UnityEngine.Transform val_4 = 万且万且丑丗且丌丆.transform.GetChild(index:  0);
        if(val_4 == null)
        {
            goto label_9;
        }
        
        UnityEngine.Transform val_5 = val_4.GetChild(index:  0);
        if(val_5 == null)
        {
            goto label_9;
        }
        
        UnityEngine.Renderer val_7 = val_5.gameObject.GetComponentInChildren<UnityEngine.Renderer>();
        if(val_7 == null)
        {
            goto label_9;
        }
        
        val_27 = val_7.materials;
        if(val_27 == null)
        {
                return (UnityEngine.Material[])val_27;
        }
        
        if(val_8.Length < 1)
        {
                return (UnityEngine.Material[])val_27;
        }
        
        label_35:
        val_26 = val_27[0];
        if(((val_26 == 0) || ((System.String.op_Inequality(a:  val_26.shader.name, b:  "Optimized/MultiShader")) == false)) || ((System.String.op_Inequality(a:  val_26.shader.name, b:  "Optimized/MultiShaderGloss")) == false))
        {
            goto label_21;
        }
        
        if((val_26.HasProperty(name:  "_ScrollX")) == false)
        {
            goto label_23;
        }
        
        UnityEngine.Shader val_17 = UnityEngine.Shader.Find(name:  "Optimized/MultiShaderGloss");
        if(val_26 == null)
        {
            goto label_24;
        }
        
        val_26.shader = val_17;
        val_26.SetTexture(name:  "_SelfIllum", value:  val_26.GetTexture(name:  "_MainTex"));
        val_26.SetInt(name:  "_OnlyScroll", value:  1);
        goto label_25;
        label_23:
        val_26.shader = UnityEngine.Shader.Find(name:  "Optimized/MultiShader");
        goto label_27;
        label_24:
        0.shader = val_17;
        0.SetTexture(name:  "_SelfIllum", value:  0.GetTexture(name:  "_MainTex"));
        0.SetInt(name:  "_OnlyScroll", value:  1);
        label_25:
        val_26.EnableKeyword(keyword:  "ONLY_SCROLL");
        label_27:
        且丈丗丈不丑世丏专.丗丝丞且丆专与丂丐(世丑丘丘丂专丅丆与:  val_26, 丑丒业丘丑东丕世丅:  true);
        且丈丗丈不丑世丏专.丄丄丞丌业丁丏丂丈(世丑丘丘丂专丅丆与:  val_26, 丑丒业丘丑东丕世丅:  true);
        且丈丗丈不丑世丏专.丌东丌万丕丛丙丐丗(世丑丘丘丂专丅丆与:  val_26, 丑丒业丘丑东丕世丅:  true);
        且丈丗丈不丑世丏专.丘丙下丅不丘万万下(世丑丘丘丂专丅丆与:  val_26);
        label_21:
        if(this.丕专丄丄丞丑七万丟 == false)
        {
            goto label_28;
        }
        
        且丈丗丈不丑世丏专.丘丙下丅不丘万万下(世丑丘丘丂专丅丆与:  val_26);
        if(val_26 == null)
        {
            goto label_29;
        }
        
        val_28 = val_26.renderQueue;
        goto label_30;
        label_28:
        if((val_26.name.Contains(value:  "aquarium")) == true)
        {
            goto label_34;
        }
        
        且丈丗丈不丑世丏专.业丄不丕丗下与万三(世丑丘丘丂专丅丆与:  val_26);
        goto label_34;
        label_29:
        val_28 = 0.renderQueue;
        label_30:
        val_26.renderQueue = val_28 - 30;
        label_34:
        if((0 + 1) < val_8.Length)
        {
            goto label_35;
        }
        
        return (UnityEngine.Material[])val_27;
        label_9:
        val_27 = 0;
        return (UnityEngine.Material[])val_27;
    }

}
