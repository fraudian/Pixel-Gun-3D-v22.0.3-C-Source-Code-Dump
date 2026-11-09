using UnityEngine;
internal sealed class EquippedCarPreview : MonoBehaviour
{
    // Fields
    private string 丅丙丏丐丄丟丌丑丁;
    private UIBasicSprite vehicleIcon;
    
    // Properties
    private UIBasicSprite 丛丙丂丝不丏上东不 { get; }
    
    // Methods
    private UIBasicSprite 丑一丆丑且丟上业丛()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.vehicleIcon);
        this.vehicleIcon = val_1;
        return val_1;
    }
    private void Update()
    {
        string val_1 = 丛且丗丌丏下七下丈.丗丘丌丘七丏丝下七();
        if((System.String.IsNullOrEmpty(value:  val_1)) == true)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.丅丙丏丐丄丟丌丑丁, b:  val_1)) == false)
        {
                return;
        }
        
        UnityEngine.Texture val_4 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_1, 七丆丒与丗丌丄且丂:  80, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        UIBasicSprite val_5 = this.丑一丆丑且丟上业丛();
        this.丅丙丏丐丄丟丌丑丁 = val_1;
    }
    public EquippedCarPreview()
    {
        this.丅丙丏丐丄丟丌丑丁 = System.String.alignConst;
    }

}
