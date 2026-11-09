using UnityEngine;
public class PlatformDependentLocalize : MonoBehaviour
{
    // Fields
    public string LocalizationKey;
    private UILabel[] _labels;
    private string 与丏丌且丌下丛世丒;
    private const string 一丂丗丐三与三丝丕 = "Key_7392";
    private const string 丕且专一丆七丝世下 = "Key_7393";
    private const string 丗丂世一业丆丞东与 = "Key_7394";
    
    // Properties
    private bool 丌上丞与与丈世丙丄 { get; }
    
    // Methods
    private bool 丈一丙丐丁丐丞丙丁()
    {
        return System.String.op_Inequality(a:  I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业(), b:  this.与丏丌且丌下丛世丒);
    }
    private void OnEnable()
    {
        string val_9;
        if(this.丈一丙丐丁丐丞丙丁() == false)
        {
                return;
        }
        
        val_9 = 0;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.LocalizationKey)) != false)
        {
                val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.LocalizationKey);
        }
        
        string val_4 = PlatformDependentLocalize.丄丗丅丙丗丑丘三丏();
        if(val_9 != null)
        {
                string val_6 = System.String.Format(format:  val_9, arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4));
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._labels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4));
        this.与丏丌且丌下丛世丒 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
    }
    internal static string 丄丗丅丙丗丑丘三丏()
    {
        var val_3;
        var val_4;
        val_3 = "Key_7392";
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
                return (string)val_4;
        }
        
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                val_4 = "Key_7394";
            return (string)val_4;
        }
        
        val_4 = "Key_7393";
        return (string)val_4;
    }
    public PlatformDependentLocalize()
    {
        this.与丏丌且丌下丛世丒 = System.String.alignConst;
    }

}
