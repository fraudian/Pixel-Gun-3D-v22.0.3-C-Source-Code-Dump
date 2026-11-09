using UnityEngine;
public static class 下下丈一业上万丏丕
{
    // Methods
    public static GuiSettings 三丒且世下丛三丅丆(string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        string val_5;
        string val_6;
        if((System.String.IsNullOrEmpty(value:  七丆丒与丗丌丄且丂)) != false)
        {
                val_5 = 丒丑丞丁世丌专不丈;
            val_6 = "GuiApplyers/Settings/";
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  丒丑丞丁世丌专不丈)) == false)
        {
                return UnityEngine.Resources.Load<GuiSettings>(path:  "GuiApplyers/Settings/"("GuiApplyers/Settings/") + 七丆丒与丗丌丄且丂 + "_" + 丒丑丞丁世丌专不丈);
        }
        
            val_6 = "GuiApplyers/Settings/";
            val_5 = 七丆丒与丗丌丄且丂;
        }
        
        string val_3 = val_6 + val_5;
        return UnityEngine.Resources.Load<GuiSettings>(path:  "GuiApplyers/Settings/"("GuiApplyers/Settings/") + 七丆丒与丗丌丄且丂 + "_" + 丒丑丞丁世丌专不丈);
    }
    public static bool 丑丑丒与丙丂世丘丛(string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        return UnityEngine.Object.op_Inequality(x:  下下丈一业上万丏丕.三丒且世下丛三丅丆(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 丒丑丞丁世丌专不丈:  丒丑丞丁世丌专不丈), y:  0);
    }
    public static T 丄丙丏万丑且下专丕<T>(string 东丄丐丞丙不丒东丈)
    {
        var val_12;
        UnityEngine.Object val_13;
        val_12 = __RuntimeMethodHiddenParam;
        if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                UnityEngine.Shader val_4 = UnityEngine.Shader.Find(name:  东丄丐丞丙不丒东丈);
            val_12 = mem[__RuntimeMethodHiddenParam + 48 + 8];
            val_12 = __RuntimeMethodHiddenParam + 48 + 8;
            if(val_4 != null)
        {
                val_13 = val_4;
            if(val_13 != null)
        {
                return (object)val_13;
        }
        
        }
        
            val_13 = 0;
            return (object)val_13;
        }
        
        val_13 = 东丄丐丞丙不丒东丈;
        if(val_13 == 0)
        {
                return (object)val_13;
        }
        
        if(val_13 == null)
        {
                return (object)val_13;
        }
        
        val_13 = ???;
        val_12 = ???;
        goto __RuntimeMethodHiddenParam + 48 + 24;
    }
    public static string 东专下丘业丘丒丒世(string 下专丘上不一上丞丌)
    {
        return "";
    }
    public static string 丝丞丒七丞丕丏七丐(东七丏不东丏丘丛下 七丆丒与丗丌丄且丂)
    {
        return "default";
    }

}
