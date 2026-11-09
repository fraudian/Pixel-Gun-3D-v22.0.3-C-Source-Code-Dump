using UnityEngine;
public class LoaderFX : MonoBehaviour
{
    // Fields
    public bool dontLoadOnPixelgunLow;
    public string namePrefab;
    public UnityEngine.Transform[] parents;
    
    // Methods
    private void Start()
    {
        null = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                if(this.dontLoadOnPixelgunLow == true)
        {
                return;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.namePrefab)) == true)
        {
                return;
        }
        
        if(this.parents == null)
        {
                return;
        }
        
        if(this.parents.Length == 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丈丑丐丕与丑丞丌丘());
    }
    private System.Collections.IEnumerator 丈丑丐丕与丑丞丌丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LoaderFX.丒丕世丌不三且丑丏();
    }
    public LoaderFX()
    {
        this.dontLoadOnPixelgunLow = true;
    }

}
