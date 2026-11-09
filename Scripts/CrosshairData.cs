using UnityEngine;
[Serializable]
public class CrosshairData
{
    // Fields
    public CrosshairData.aimSprite center;
    public CrosshairData.aimSprite down;
    public int ID;
    public CrosshairData.aimSprite left;
    public CrosshairData.aimSprite leftDown;
    public CrosshairData.aimSprite leftUp;
    public string Name;
    public UnityEngine.Texture2D PreviewTexture;
    public CrosshairData.aimSprite up;
    
    // Methods
    public CrosshairData()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  6f, y:  6f);
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0f, y:  0f);
        .spriteName = "aim_1";
        .spriteSize = val_1.x;
        mem[1152921537065170836] = val_1.y;
        .offset = val_2.x;
        mem[1152921537065170820] = val_2.y;
        this.center = new CrosshairData.aimSprite();
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  6f, y:  10f);
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  0f, y:  5f);
        .spriteName = "aim_3";
        .spriteSize = val_4.x;
        mem[1152921537065174932] = val_4.y;
        .offset = val_5.x;
        mem[1152921537065174916] = val_5.y;
        this.down = new CrosshairData.aimSprite();
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  10f, y:  6f);
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  5f, y:  0f);
        .spriteName = "aim_2";
        .spriteSize = val_7.x;
        mem[1152921537065179028] = val_7.y;
        .offset = val_8.x;
        mem[1152921537065179012] = val_8.y;
        this.left = new CrosshairData.aimSprite();
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  0f, y:  0f);
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  0f, y:  0f);
        .spriteName = "";
        .spriteSize = val_10.x;
        mem[1152921537065183124] = val_10.y;
        .offset = val_11.x;
        mem[1152921537065183108] = val_11.y;
        this.leftDown = new CrosshairData.aimSprite();
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  12f, y:  12f);
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  8f, y:  8f);
        .spriteName = "";
        .spriteSize = val_13.x;
        mem[1152921537065187220] = val_13.y;
        .offset = val_14.x;
        mem[1152921537065187204] = val_14.y;
        this.leftUp = new CrosshairData.aimSprite();
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  6f, y:  10f);
        UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  0f, y:  5f);
        .spriteName = "aim_3";
        .spriteSize = val_16.x;
        mem[1152921537065191316] = val_16.y;
        .offset = val_17.x;
        mem[1152921537065191300] = val_17.y;
        this.up = new CrosshairData.aimSprite();
    }

}
