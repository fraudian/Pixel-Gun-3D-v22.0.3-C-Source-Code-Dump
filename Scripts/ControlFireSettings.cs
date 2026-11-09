using UnityEngine;
[Serializable]
public class ControlFireSettings : ISerializable
{
    // Fields
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 Type;
    internal 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 Style;
    internal bool IsSelected;
    internal bool IsAiming;
    internal bool IsAutoShooting;
    internal 与丂丏丛丞丞丒丟丄.丄丆一上丗世丞丛丘 GameSecondFireButtonMode;
    internal bool IsLeftHanded;
    
    // Methods
    internal ControlFireSettings()
    {
    
    }
    internal static ControlFireSettings 不丁丑丁丈上丅丌丐(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟, 下丂世丂不丛专一一.丁三丆丒丝与丏丕一 丏东丆丆丛丄丕丈丞 = 0)
    {
        System.Version val_22;
        var val_23;
        var val_24;
        System.Version val_26;
        bool val_27;
        var val_28;
        System.Version val_1 = null;
        val_22 = val_1;
        val_1 = new System.Version(major:  21, minor:  6);
        if((System.Version.op_Inequality(v1:  业丂丏与世一丏业不.一丒三丝三下丑业下(), v2:  0)) != false)
        {
                var val_6 = ((System.Version.op_LessThan(v1:  业丂丏与世一丏业不.一丒三丝三下丑业下(), v2:  val_1)) != true) ? (1 + 1) : 1;
        }
        else
        {
                val_23 = 1;
        }
        
        下丂世丂不丛专一一.丁三丆丒丝与丏丕一 val_7 = (丏东丆丆丛丄丕丈丞 == 0) ? (val_23) : 丏东丆丆丛丄丕丈丞;
        ControlFireSettings val_8 = new ControlFireSettings();
        if(val_8 != null)
        {
                val_24 = val_8;
            .IsAiming = true;
            mem[1152921538960965332] = val_7;
            mem[1152921538960965328] = 丁丅丈丌丟世丗丗丟;
            mem[1152921538960965336] = (val_7 == val_23) ? 1 : 0;
            mem[1152921538960965338] = (val_7 == 1) ? 1 : 0;
        }
        else
        {
                mem[16] = 丁丅丈丌丟世丗丗丟;
            .Style = val_7;
            mem[24] = (val_7 == val_23) ? 1 : 0;
            val_24 = val_8;
            .IsAiming = true;
            var val_12 = (val_7 == 1) ? 1 : 0;
            mem[1152921538960965338] = val_12;
        }
        
        .GameSecondFireButtonMode = 0;
        val_26 = 业丂丏与世一丏业不.一丒三丝三下丑业下();
        if((System.Version.op_Inequality(v1:  val_26, v2:  0)) == false)
        {
                return val_8;
        }
        
        val_26 = 业丂丏与世一丏业不.一丒三丝三下丑业下();
        if((System.Version.op_LessThan(v1:  val_26, v2:  val_1)) == false)
        {
                return val_8;
        }
        
        val_22 = 1152921505171275776;
        mem[1152921538960965337] = 与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且();
        if((val_12 & 1) != 0)
        {
                val_27 = 1;
        }
        else
        {
                val_27 = 与丂丏丛丞丞丒丟丄.三上丕丟丛世世专丁();
        }
        
        .IsAutoShooting = val_27;
        val_28 = null;
        val_28 = null;
        .GameSecondFireButtonMode = 与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐;
        bool val_21 = ~丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
        val_21 = val_21 & 1;
        .IsLeftHanded = val_21;
        return val_8;
    }
    internal static ControlFireSettings 丈业且丘丈不丄丈丒(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟)
    {
        var val_4;
        System.Collections.Generic.IEnumerable<TSource> val_5;
        .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        val_4 = null;
        val_4 = null;
        val_5 = 丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三;
        if(val_5 == null)
        {
                return (ControlFireSettings)System.Linq.Enumerable.FirstOrDefault<ControlFireSettings>(source:  val_5, predicate:  new System.Func<ControlFireSettings, System.Boolean>(object:  new ControlFireSettings.丌万一一业丝丁丈丝(), method:  System.Boolean ControlFireSettings.丌万一一业丝丁丈丝::与丅丞下丈丆丄东三(ControlFireSettings 三丟东丕丄丄下下丑)));
        }
        
        return (ControlFireSettings)System.Linq.Enumerable.FirstOrDefault<ControlFireSettings>(source:  val_5, predicate:  new System.Func<ControlFireSettings, System.Boolean>(object:  new ControlFireSettings.丌万一一业丝丁丈丝(), method:  System.Boolean ControlFireSettings.丌万一一业丝丁丈丝::与丅丞下丈丆丄东三(ControlFireSettings 三丟东丕丄丄下下丑)));
    }
    internal ControlFireSettings(System.Runtime.Serialization.SerializationInfo 东一丁世丑丞业丄丐, System.Runtime.Serialization.StreamingContext 与且专丈不万东一万)
    {
        if(东一丁世丑丞业丄丐 != null)
        {
                this.Type = 东一丁世丑丞业丄丐.GetInt32(name:  "Type");
        }
        else
        {
                this.Type = 0.GetInt32(name:  "Type");
        }
        
        this.Style = 东一丁世丑丞业丄丐.GetInt32(name:  "Style");
        if(东一丁世丑丞业丄丐 != null)
        {
                this.IsSelected = 东一丁世丑丞业丄丐.GetBoolean(name:  "IsSelected");
        }
        else
        {
                this.IsSelected = 0.GetBoolean(name:  "IsSelected");
        }
        
        this.IsAiming = 东一丁世丑丞业丄丐.GetBoolean(name:  "IsAiming");
        if(东一丁世丑丞业丄丐 != null)
        {
                this.IsAutoShooting = 东一丁世丑丞业丄丐.GetBoolean(name:  "IsAutoShooting");
        }
        else
        {
                this.IsAutoShooting = 0.GetBoolean(name:  "IsAutoShooting");
        }
        
        this.GameSecondFireButtonMode = 东一丁世丑丞业丄丐.GetInt32(name:  "GameSecondFireButtonMode");
        this.IsLeftHanded = 东一丁世丑丞业丄丐.GetBoolean(name:  "IsLeftHanded");
    }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo 东一丁世丑丞业丄丐, System.Runtime.Serialization.StreamingContext 与且专丈不万东一万)
    {
        东一丁世丑丞业丄丐.AddValue(name:  "Type", value:  this.Type);
        东一丁世丑丞业丄丐.AddValue(name:  "Style", value:  this.Style);
        东一丁世丑丞业丄丐.AddValue(name:  "IsSelected", value:  (this.IsSelected == true) ? 1 : 0);
        东一丁世丑丞业丄丐.AddValue(name:  "IsAiming", value:  (this.IsAiming == true) ? 1 : 0);
        东一丁世丑丞业丄丐.AddValue(name:  "IsAutoShooting", value:  (this.IsAutoShooting == true) ? 1 : 0);
        东一丁世丑丞业丄丐.AddValue(name:  "GameSecondFireButtonMode", value:  this.GameSecondFireButtonMode);
        东一丁世丑丞业丄丐.AddValue(name:  "IsLeftHanded", value:  (this.IsLeftHanded == true) ? 1 : 0);
    }

}
