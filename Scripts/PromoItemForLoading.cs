using UnityEngine;
public class PromoItemForLoading : MonoBehaviour
{
    // Fields
    private UIBasicSprite[] texture;
    private bool 丈三上专丁世业专丆;
    public UILabel[] label;
    
    // Properties
    public UIBasicSprite[] 丅一与丄一丐丛丏丅 { get; }
    
    // Methods
    public UIBasicSprite[] get_Textures()
    {
        UIBasicSprite[] val_3;
        var val_4;
        val_3 = this.texture;
        if(this.丈三上专丁世业专丆 == true)
        {
                return val_3;
        }
        
        val_3 = new UIBasicSprite[0];
        val_4 = 0;
        goto label_3;
        label_15:
        UIBasicSprite val_2 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.texture[0]);
        if(val_3 == null)
        {
            goto label_8;
        }
        
        if(val_2 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_2 == null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        val_4 = 1;
        val_3[0] = val_2;
        label_3:
        if(val_4 < this.texture.Length)
        {
            goto label_15;
        }
        
        this.texture = val_3;
        this.丈三上专丁世业专丆 = true;
        return val_3;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public PromoItemForLoading()
    {
    
    }

}
