using UnityEngine;
public class CaptionView : MonoBehaviour
{
    // Fields
    private UITexture texureIcon;
    private UISprite spriteIcon;
    private UILabel label;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(UnityEngine.Texture 与万丆丛丒万丝丙丑, string 丕丗丘丑丛与丑业丒)
    {
        UISprite val_3;
        if((UnityEngine.Object.op_Implicit(exists:  this.texureIcon)) != false)
        {
                this.texureIcon.enabled = true;
        }
        
        val_3 = this.spriteIcon;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                val_3 = this.spriteIcon;
            val_3.enabled = false;
        }
        
        this.label.text = 丕丗丘丑丛与丑业丒;
    }
    internal void 丈且东丑丂且万丒丅(string 万丑丞一丝丌丐丒丘, string 丕丗丘丑丛与丑业丒)
    {
        UITexture val_3;
        if((UnityEngine.Object.op_Implicit(exists:  this.spriteIcon)) != false)
        {
                this.spriteIcon.spriteName = 万丑丞一丝丌丐丒丘;
            this.spriteIcon.enabled = true;
        }
        
        val_3 = this.texureIcon;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                val_3 = this.texureIcon;
            val_3.enabled = false;
        }
        
        this.label.text = 丕丗丘丑丛与丑业丒;
    }
    public CaptionView()
    {
    
    }

}
