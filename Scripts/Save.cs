using UnityEngine;
public class Save : MonoBehaviour
{
    // Methods
    internal static void 不丏丒丐世三万不丙(string 丒丘丏上丙丟丑丕丈, string 三丂丏不三上上丏丝)
    {
        UnityEngine.PlayerPrefs.SetString(key:  丒丘丏上丙丟丑丕丈, value:  三丂丏不三上上丏丝);
    }
    internal static void 丐丏丑丟丐丁上上丑(string 丒丘丏上丙丟丑丕丈, int 三丂丏不三上上丏丝)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  丒丘丏上丙丟丑丕丈, value:  三丂丏不三上上丏丝);
    }
    internal static void 丌丂一丗丌世丞世下(string 丒丘丏上丙丟丑丕丈, bool 三丂丏不三上上丏丝)
    {
        UnityEngine.PlayerPrefs.SetString(key:  丒丘丏上丙丟丑丕丈, value:  三丂丏不三上上丏丝.ToString());
    }
    internal static void 下丑丈丟丘丒三与丘(string 丒丘丏上丙丟丑丕丈, UnityEngine.Vector3[] 三丂丏不三上上丏丝)
    {
        var val_3;
        string val_4;
        val_3 = 0;
        val_4 = "";
        goto label_1;
        label_6:
        var val_1 = 三丂丏不三上上丏丝 + (0 * 12);
        var val_2 = 三丂丏不三上上丏丝 + (0 * 12);
        val_4 = val_4 + System.String.Format(format:  "{0}&{1}&{2}#", arg0:  8.96831E-44f, arg1:  (0 * 12) + 三丂丏不三上上丏丝 + 36, arg2:  (0 * 12) + 三丂丏不三上上丏丝 + 40)(System.String.Format(format:  "{0}&{1}&{2}#", arg0:  8.96831E-44f, arg1:  (0 * 12) + 三丂丏不三上上丏丝 + 36, arg2:  (0 * 12) + 三丂丏不三上上丏丝 + 40));
        val_3 = 1;
        label_1:
        if(val_3 < 三丂丏不三上上丏丝.Length)
        {
            goto label_6;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  丒丘丏上丙丟丑丕丈, value:  val_4);
    }
    public Save()
    {
    
    }

}
