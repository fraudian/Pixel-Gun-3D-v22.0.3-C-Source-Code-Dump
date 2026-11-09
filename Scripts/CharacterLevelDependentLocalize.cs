using UnityEngine;
public class CharacterLevelDependentLocalize : MonoBehaviour
{
    // Fields
    public string LocalizationKey;
    private UILabel[] _labels;
    private string 与丏丌且丌下丛世丒;
    
    // Properties
    private bool 丌上丞与与丈世丙丄 { get; }
    
    // Methods
    private bool 丈一丙丐丁丐丞丙丁()
    {
        return System.String.op_Inequality(a:  I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业(), b:  this.与丏丌且丌下丛世丒);
    }
    private void OnEnable()
    {
        if(this.丈一丙丐丁丐丞丙丁() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._labels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.LocalizationKey), arg0:  CharacterLevelDependentLocalize.丗上与丛丌丞丆丞丆()));
        this.与丏丌且丌下丛世丒 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
    }
    internal static int 丗上与丛丌丞丆丞丆()
    {
        return 丑丝丞丒丅丄万丒三.万上丘丙丗丛丛丅丈();
    }
    public CharacterLevelDependentLocalize()
    {
        this.与丏丌且丌下丛世丒 = System.String.alignConst;
    }

}
