using UnityEngine;
public class RenderTextureForBlur : MonoBehaviour
{
    // Fields
    public UnityEngine.Material mat;
    private UnityEngine.Texture2D 丟三丟三丅专丂丄丂;
    
    // Methods
    private void Start()
    {
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() == false)
        {
                return;
        }
        
        this.丟三丟三丅专丂丄丂 = new UnityEngine.Texture2D(width:  UnityEngine.Screen.width, height:  2);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丘丙丑丆三业与东下());
    }
    private System.Collections.IEnumerator 丘丙丑丆三业与东下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RenderTextureForBlur.三丙丈世三丒丄丘业();
    }
    public RenderTextureForBlur()
    {
    
    }

}
