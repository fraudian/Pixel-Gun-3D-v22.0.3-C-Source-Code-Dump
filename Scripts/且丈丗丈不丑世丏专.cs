using UnityEngine;
public sealed class 且丈丗丈不丑世丏专
{
    // Methods
    public static void 业丄不丕丗下与万三(UnityEngine.Material 世丑丘丘丂专丅丆与)
    {
        if(世丑丘丘丂专丅丆与 != null)
        {
                世丑丘丘丂专丅丆与.EnableKeyword(keyword:  "IS_OPAQUE");
            世丑丘丘丂专丅丆与.SetOverrideTag(tag:  "RenderType", val:  "Opaque");
            世丑丘丘丂专丅丆与.SetInt(name:  "_SrcBlend", value:  1);
            世丑丘丘丂专丅丆与.SetInt(name:  "_DstBlend", value:  0);
        }
        else
        {
                0.EnableKeyword(keyword:  "IS_OPAQUE");
            0.SetOverrideTag(tag:  "RenderType", val:  "Opaque");
            0.SetInt(name:  "_SrcBlend", value:  1);
            0.SetInt(name:  "_DstBlend", value:  0);
        }
        
        世丑丘丘丂专丅丆与.renderQueue = 208;
    }
    public static void 丘丙下丅不丘万万下(UnityEngine.Material 世丑丘丘丂专丅丆与)
    {
        if(世丑丘丘丂专丅丆与 != null)
        {
                世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "IS_OPAQUE");
            世丑丘丘丂专丅丆与.SetOverrideTag(tag:  "RenderType", val:  "Transparent");
            世丑丘丘丂专丅丆与.SetInt(name:  "_SrcBlend", value:  5);
            世丑丘丘丂专丅丆与.SetInt(name:  "_DstBlend", value:  10);
        }
        else
        {
                0.DisableKeyword(keyword:  "IS_OPAQUE");
            0.SetOverrideTag(tag:  "RenderType", val:  "Transparent");
            0.SetInt(name:  "_SrcBlend", value:  5);
            0.SetInt(name:  "_DstBlend", value:  10);
        }
        
        世丑丘丘丂专丅丆与.renderQueue = 184;
    }
    public static void 且丆丙世与一与不丙(UnityEngine.Material 世丑丘丘丂专丅丆与)
    {
        if(世丑丘丘丂专丅丆与 != null)
        {
                世丑丘丘丂专丅丆与.SetInt(name:  "_Emission", value:  0);
            世丑丘丘丂专丅丆与.EnableKeyword(keyword:  "_EMISSION_OFF");
            世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "_EMISSION_TEX");
        }
        else
        {
                0.SetInt(name:  "_Emission", value:  0);
            0.EnableKeyword(keyword:  "_EMISSION_OFF");
            0.DisableKeyword(keyword:  "_EMISSION_TEX");
        }
        
        世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "_EMISSION_ALPHA");
    }
    public static void 丁下业丏与丐丞上万(UnityEngine.Material 世丑丘丘丂专丅丆与)
    {
        if(世丑丘丘丂专丅丆与 != null)
        {
                世丑丘丘丂专丅丆与.SetInt(name:  "_Emission", value:  1);
            世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "_EMISSION_OFF");
            世丑丘丘丂专丅丆与.EnableKeyword(keyword:  "_EMISSION_TEX");
        }
        else
        {
                0.SetInt(name:  "_Emission", value:  1);
            0.DisableKeyword(keyword:  "_EMISSION_OFF");
            0.EnableKeyword(keyword:  "_EMISSION_TEX");
        }
        
        世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "_EMISSION_ALPHA");
    }
    public static void 丁丘丄丑七丂丏专东(UnityEngine.Material 世丑丘丘丂专丅丆与)
    {
        if(世丑丘丘丂专丅丆与 != null)
        {
                世丑丘丘丂专丅丆与.SetInt(name:  "_Emission", value:  2);
            世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "_EMISSION_OFF");
            世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "_EMISSION_TEX");
        }
        else
        {
                0.SetInt(name:  "_Emission", value:  2);
            0.DisableKeyword(keyword:  "_EMISSION_OFF");
            0.DisableKeyword(keyword:  "_EMISSION_TEX");
        }
        
        世丑丘丘丂专丅丆与.EnableKeyword(keyword:  "_EMISSION_ALPHA");
    }
    public static void 丗丝丞且丆专与丂丐(UnityEngine.Material 世丑丘丘丂专丅丆与, bool 丑丒业丘丑东丕世丅)
    {
        bool val_1 = 丑丒业丘丑东丕世丅;
        if(世丑丘丘丂专丅丆与 != null)
        {
                世丑丘丘丂专丅丆与.SetInt(name:  "_LightingEnable", value:  val_1);
        }
        else
        {
                世丑丘丘丂专丅丆与.SetInt(name:  "_LightingEnable", value:  val_1);
        }
        
        if(丑丒业丘丑东丕世丅 != false)
        {
                世丑丘丘丂专丅丆与.EnableKeyword(keyword:  "LIGHTING_ENABLE");
            return;
        }
        
        世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "LIGHTING_ENABLE");
    }
    public static void 三丐业丙丏上丕不丘(UnityEngine.Material 世丑丘丘丂专丅丆与, UnityEngine.Rendering.CullMode 丂丛丑东不丅丈一东)
    {
        世丑丘丘丂专丅丆与.SetInt(name:  "_CullMode", value:  丂丛丑东不丅丈一东);
    }
    public static void 丄丄丞丌业丁丏丂丈(UnityEngine.Material 世丑丘丘丂专丅丆与, bool 丑丒业丘丑东丕世丅)
    {
        世丑丘丘丂专丅丆与.SetInt(name:  "_ZWriteEnable", value:  丑丒业丘丑东丕世丅);
    }
    public static void 丌东丌万丕丛丙丐丗(UnityEngine.Material 世丑丘丘丂专丅丆与, bool 丑丒业丘丑东丕世丅)
    {
        bool val_1 = 丑丒业丘丑东丕世丅;
        if(世丑丘丘丂专丅丆与 != null)
        {
                世丑丘丘丂专丅丆与.SetInt(name:  "_ColorEnable", value:  val_1);
        }
        else
        {
                世丑丘丘丂专丅丆与.SetInt(name:  "_ColorEnable", value:  val_1);
        }
        
        if(丑丒业丘丑东丕世丅 != false)
        {
                世丑丘丘丂专丅丆与.EnableKeyword(keyword:  "COLOR_ENABLE");
            return;
        }
        
        世丑丘丘丂专丅丆与.DisableKeyword(keyword:  "COLOR_ENABLE");
    }
    public 且丈丗丈不丑世丏专()
    {
    
    }

}
