using UnityEngine;
public class KillStreakMapper : MonoBehaviour
{
    // Fields
    public UnityEngine.Renderer killstreakRenderer;
    public UIAtlas killstreakAtlas;
    private UnityEngine.Vector2 丟世与丞丞七与丂丌;
    public UnityEngine.Animator killstreakAnimator;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  (float)this.killstreakAtlas.texture, y:  (float)this.killstreakAtlas.texture);
        this.丟世与丞丞七与丂丌 = val_3.x;
        mem[1152921530789430492] = val_3.y;
    }
    internal void 世丄七丈丑下专丆丏(string 万丑丞一丝丌丐丒丘)
    {
        UISpriteData val_1 = this.killstreakAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  万丑丞一丝丌丐丒丘);
        UISpriteData val_2 = this.killstreakAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  万丑丞一丝丌丐丒丘);
        UISpriteData val_3 = this.killstreakAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  万丑丞一丝丌丐丒丘);
        UISpriteData val_4 = this.killstreakAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  万丑丞一丝丌丐丒丘);
        float val_5 = (float)val_3.height / (float)val_4.width;
        float val_15 = 0f;
        this.killstreakRenderer.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = val_15, z = 0f};
        UnityEngine.Vector2 val_14 = this.丟世与丞丞七与丂丌;
        val_14 = (float)val_4.width / val_14;
        val_15 = (float)val_3.height / val_15;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_14, y:  val_15);
        float val_17 = val_8.y;
        this.killstreakRenderer.material.mainTextureScale = new UnityEngine.Vector2() {x = val_8.x, y = val_17};
        UnityEngine.Vector2 val_16 = this.丟世与丞丞七与丂丌;
        val_16 = (float)val_1.x / val_16;
        val_17 = (val_17 - ((float)val_3.height + val_2.y)) / val_17;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_16, y:  val_17);
        this.killstreakRenderer.material.mainTextureOffset = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        if(this.killstreakAnimator == 0)
        {
                return;
        }
        
        this = this.killstreakAnimator;
        this.SetTrigger(name:  "play");
    }
    public KillStreakMapper()
    {
    
    }

}
