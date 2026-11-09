using UnityEngine;
public class 丛丌丙丂丑丞丂丏丟
{
    // Properties
    public static string 东丏丁东与下丟丙丘 { get; }
    public static string 且丏业丄七丌丒丁丄 { get; }
    public static string 丛丝丌上丑丛丟丁丕 { get; }
    
    // Methods
    public static string 丕下丗丏且万丈一丆()
    {
        return "SoundMusicSetting";
    }
    public static string 丏丏丌下丑三丐与东()
    {
        return "SoundMusicSetting";
    }
    public static string 丏丏丌丆丞丂丆不丗()
    {
        return "SoundFXSetting";
    }
    public static void 万丞上丘丗丆丙一丑(string 丒丘丏上丙丟丑丕丈, bool 丂且与下丘丅丟丈丕)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  丒丘丏上丙丟丑丕丈, value:  丂且与下丘丅丟丈丕);
    }
    public static bool 丑上万丌丏上丌下三(string 丒丘丏上丙丟丑丕丈)
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  丒丘丏上丙丟丑丕丈)) == 1) ? 1 : 0;
    }
    public static bool 丑上万丌丏上丌下三(string 丒丘丏上丙丟丑丕丈, bool 专不三上丏专丄且丞)
    {
        bool val_4 = 专不三上丏专丄且丞;
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  丒丘丏上丙丟丑丕丈);
        }
        
        val_2 = ((val_2 == 1) ? 1 : 0) & 1;
        return (bool)val_2;
    }
    public 丛丌丙丂丑丞丂丏丟()
    {
    
    }

}
