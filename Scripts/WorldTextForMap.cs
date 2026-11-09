using UnityEngine;
public class WorldTextForMap : MonoBehaviour
{
    // Fields
    private string text;
    private string localizatioKey;
    public UILabel miniMapLabel;
    public UILabel worldMapLabel;
    
    // Properties
    public string 不三世丏丙丁与丑丒 { get; }
    
    // Methods
    public string get_Text()
    {
        if((System.String.op_Equality(a:  this.localizatioKey, b:  System.String.alignConst)) == false)
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.localizatioKey);
        }
        
        return (string)this.text;
    }
    public WorldTextForMap()
    {
    
    }

}
