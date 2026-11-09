using UnityEngine;
public class UvScroller : MonoBehaviour
{
    // Fields
    public UnityEngine.Material mat;
    private UnityEngine.Renderer 七丈业东丘丅丂且丄;
    public float scrollSpeed;
    private float 丄丏丗丕丐七丒丗丂;
    
    // Methods
    private void Start()
    {
        UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
        if(val_1 == 0)
        {
                return;
        }
        
        this.七丈业东丘丅丂且丄 = val_1;
    }
    private void Update()
    {
        var val_13;
        float val_13 = this.丄丏丗丕丐七丒丗丂;
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = val_1 * this.scrollSpeed;
        val_13 = val_13 + val_1;
        this.丄丏丗丕丐七丒丗丂 = val_13;
        if(System.Math.Abs(val_13) >= 1f)
        {
                this.丄丏丗丕丐七丒丗丂 = 0f;
        }
        
        if(this.七丈业东丘丅丂且丄 == 0)
        {
            goto label_20;
        }
        
        val_13 = this.七丈业东丘丅丂且丄.sharedMaterial.HasProperty(name:  "_GlossTex");
        if(this.七丈业东丘丅丂且丄 == null)
        {
            goto label_9;
        }
        
        if(val_13 == false)
        {
            goto label_10;
        }
        
        label_13:
        label_24:
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  this.丄丏丗丕丐七丒丗丂, y:  0f);
        this.七丈业东丘丅丂且丄.material.SetTextureOffset(name:  "_GlossTex", value:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        goto label_20;
        label_9:
        if(val_13 == true)
        {
            goto label_13;
        }
        
        label_10:
        UnityEngine.Material[] val_7 = this.七丈业东丘丅丂且丄.sharedMaterials;
        if((val_7.Length < 2) || ((this.七丈业东丘丅丂且丄.sharedMaterials[1].HasProperty(name:  "_GlossTex")) == false))
        {
            goto label_20;
        }
        
        UnityEngine.Material val_16 = this.七丈业东丘丅丂且丄.materials[1];
        goto label_24;
        label_20:
        if(this.mat == 0)
        {
                return;
        }
        
        val_13 = "_Scroll";
        if((this.mat.HasProperty(name:  "_Scroll")) == false)
        {
                return;
        }
        
        this.mat.SetFloat(name:  "_Scroll", value:  this.丄丏丗丕丐七丒丗丂);
    }
    public UvScroller()
    {
        this.scrollSpeed = -0.5f;
    }

}
