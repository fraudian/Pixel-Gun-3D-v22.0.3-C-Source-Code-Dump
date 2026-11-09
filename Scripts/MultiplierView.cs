using UnityEngine;
internal sealed class MultiplierView : PGBehaviour
{
    // Fields
    private UILabel _multiplierLabel;
    
    // Methods
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        string val_4;
        int val_2 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒();
        if(val_2 != 0)
        {
                val_4 = System.String.Format(format:  "x{0}", arg0:  val_2);
        }
        else
        {
                val_4 = "";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._multiplierLabel, 丕丗丘丑丛与丑业丒:  val_4);
    }
    public MultiplierView()
    {
    
    }

}
