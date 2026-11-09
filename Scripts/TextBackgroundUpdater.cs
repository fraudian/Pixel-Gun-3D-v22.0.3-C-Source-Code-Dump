using UnityEngine;
internal sealed class TextBackgroundUpdater : PGBehaviour
{
    // Fields
    private UILabel _label;
    private System.Collections.Generic.List<UIRect> _rects;
    private string 丞丁丄丂丘上丗专一;
    
    // Methods
    private void LateUpdate()
    {
        if((System.String.op_Inequality(a:  this.丞丁丄丂丘上丗专一, b:  this._label.text)) == false)
        {
            goto label_10;
        }
        
        List.Enumerator<T> val_3 = this._rects.GetEnumerator();
        label_6:
        if((316551880 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        if(val_4 == null)
        {
            goto label_6;
        }
        
        val_4.ResetAndUpdateAnchors();
        goto label_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_10:
        this.丞丁丄丂丘上丗专一 = this._label.text;
    }
    public TextBackgroundUpdater()
    {
    
    }

}
