using UnityEngine;
public sealed class StarReview : MonoBehaviour
{
    // Fields
    public UILabel lbNumStar;
    public int numOrderStar;
    public UnityEngine.GameObject objActiveStar;
    public UnityEngine.GameObject objFonStar;
    
    // Methods
    internal void 一丘三丆下三丆与丕(bool 下下丏一丙不丘丌丞)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.objActiveStar)) == false)
        {
                return;
        }
        
        this.objActiveStar.SetActive(value:  下下丏一丙不丘丌丞);
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        var val_3;
        StarReview val_4;
        val_3 = this;
        if(丆且上丘世下丅且丞 != false)
        {
                ReviewHUDWindow val_1 = ReviewHUDWindow.丑七不且上丗丁一世();
            val_4 = val_3;
        }
        else
        {
                val_3 = ReviewHUDWindow.丑七不且上丗丁一世();
            val_4 = 0;
        }
        
        val_3.丙业丈丄丕丏下丕丑(丑上东丘丂专丗丈不:  val_4);
    }
    private void OnClick()
    {
        ReviewHUDWindow.丑七不且上丗丁一世().OnClickStarRating();
    }
    public StarReview()
    {
    
    }

}
