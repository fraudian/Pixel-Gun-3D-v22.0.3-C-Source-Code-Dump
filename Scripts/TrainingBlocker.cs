using UnityEngine;
public class TrainingBlocker : PGBehaviour
{
    // Fields
    public UITexture darkTexture;
    public float darkAlpha;
    public Rilisoft.ButtonHandler[] blocks;
    private bool 丞万且丁丞丟一丒七;
    
    // Methods
    public void HandleBlockClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丞万且丁丞丟一丒七 = true;
    }
    private void Awake()
    {
        Rilisoft.ButtonHandler[] val_2;
        var val_3;
        this.darkTexture.alpha = 0f;
        val_2 = this.blocks;
        if(val_2 == null)
        {
                return;
        }
        
        val_3 = 0;
        goto label_3;
        label_8:
        this.blocks[0].add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void TrainingBlocker::HandleBlockClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_2 = this.blocks;
        val_3 = 1;
        label_3:
        if(val_3 < this.blocks.Length)
        {
            goto label_8;
        }
    
    }
    private void OnDisable()
    {
        this.darkTexture.alpha = 0f;
        this.丞万且丁丞丟一丒七 = false;
    }
    private void Update()
    {
        if(this.丞万且丁丞丟一丒七 == false)
        {
                return;
        }
        
        if(this.darkTexture.alpha >= 0)
        {
                return;
        }
        
        float val_6 = 6f;
        val_6 = UnityEngine.Time.deltaTime * val_6;
        this.darkTexture.alpha = UnityEngine.Mathf.Min(a:  this.darkAlpha, b:  this.darkTexture.alpha + val_6);
    }
    public TrainingBlocker()
    {
        this.darkAlpha = 0.4f;
    }

}
