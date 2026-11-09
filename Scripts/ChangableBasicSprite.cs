using UnityEngine;
[Serializable]
public class ChangableBasicSprite
{
    // Fields
    private UISprite chachedSprite;
    private System.Nullable<bool> m_isSprite;
    public UIBasicSprite sprite;
    public UnityEngine.Color spriteColor;
    public string spriteName;
    public UnityEngine.Texture texture;
    
    // Properties
    private bool isSprite { get; }
    
    // Methods
    private bool get_isSprite()
    {
        var val_8;
        System.Nullable<System.Boolean> val_9;
        val_8 = this;
        val_9 = this.m_isSprite;
        if((val_9 & 1) != 0)
        {
                val_8 = ???;
            val_9 = ???;
        }
        
        UISprite val_1 = val_8 + 32.GetComponent<UISprite>();
        mem2[0] = val_1;
        UnityEngine.Object val_8 = 0;
        val_8 = UnityEngine.Object.op_Inequality(x:  val_1, y:  val_8);
        var val_9 = val_9;
        mem2[0] = 0;
        val_9 = val_9 & 1;
        return (bool)val_9;
    }
    public void 与专丟业下且丕不丈()
    {
        UISprite val_4;
        if(this.isSprite != false)
        {
                if((System.String.IsNullOrEmpty(value:  this.spriteName)) != true)
        {
                this.chachedSprite.spriteName = this.spriteName;
        }
        
            val_4 = this.chachedSprite;
        }
        else
        {
                bool val_3 = UnityEngine.Object.op_Inequality(x:  this.texture, y:  0);
            val_4 = this.sprite;
        }
        
        val_4.color = new UnityEngine.Color() {r = this.spriteColor, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    public ChangableBasicSprite()
    {
    
    }

}
