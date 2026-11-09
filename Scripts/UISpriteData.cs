using UnityEngine;
[Serializable]
public class UISpriteData
{
    // Fields
    public string name;
    public int x;
    public int y;
    public int width;
    public int height;
    public int borderLeft;
    public int borderRight;
    public int borderTop;
    public int borderBottom;
    public int paddingLeft;
    public int paddingRight;
    public int paddingTop;
    public int paddingBottom;
    
    // Properties
    public bool hasBorder { get; }
    public bool hasPadding { get; }
    
    // Methods
    public bool get_hasBorder()
    {
        int val_2 = this.borderLeft;
        val_2 = this.borderRight | val_2;
        val_2 = val_2 | this.borderTop;
        val_2 = val_2 | this.borderBottom;
        return (bool)(val_2 != 0) ? 1 : 0;
    }
    public bool get_hasPadding()
    {
        int val_2 = this.paddingLeft;
        val_2 = this.paddingRight | val_2;
        val_2 = val_2 | this.paddingTop;
        val_2 = val_2 | this.paddingBottom;
        return (bool)(val_2 != 0) ? 1 : 0;
    }
    public void 万与丟丑丕万丘丟三(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一)
    {
        this.x = 三丟东丕丄丄下下丑;
        this.y = 丒丒丄丁且丄丆丂丌;
        this.width = 业与三万七丝不万东;
        this.height = 丟丌丐丘丆丙丑丑一;
    }
    public void 万专不丅不丐丟丞丆(int 丈丂丕下丏丈丞丗业, int 专丙丗业世丐与丝丙, int 丂丌丌丛丆丆丙丌丈, int 世丂丘万丛万丞丞丌)
    {
        this.paddingTop = 世丂丘万丛万丞丞丌;
        this.paddingBottom = 专丙丗业世丐与丝丙;
        this.paddingLeft = 丈丂丕下丏丈丞丗业;
        this.paddingRight = 丂丌丌丛丆丆丙丌丈;
    }
    public void 丘丐与丏丝丈丝东丄(int 丈丂丕下丏丈丞丗业, int 专丙丗业世丐与丝丙, int 丂丌丌丛丆丆丙丌丈, int 世丂丘万丛万丞丞丌)
    {
        this.borderTop = 世丂丘万丛万丞丞丌;
        this.borderBottom = 专丙丗业世丐与丝丙;
        this.borderLeft = 丈丂丕下丏丈丞丗业;
        this.borderRight = 丂丌丌丛丆丆丙丌丈;
    }
    public void 丕丕万丒丟丈专丌丟(UISpriteData 一下丆七与丐上丅下)
    {
        if(一下丆七与丐上丅下 != null)
        {
                this.name = 一下丆七与丐上丅下.name;
            this.x = 一下丆七与丐上丅下.x;
            this.y = 一下丆七与丐上丅下.y;
            this.width = 一下丆七与丐上丅下.width;
            this.height = 一下丆七与丐上丅下.height;
            this.borderLeft = 一下丆七与丐上丅下.borderLeft;
            this.borderRight = 一下丆七与丐上丅下.borderRight;
            this.borderTop = 一下丆七与丐上丅下.borderTop;
            this.borderBottom = 一下丆七与丐上丅下.borderBottom;
            this.paddingLeft = 一下丆七与丐上丅下.paddingLeft;
            this.paddingRight = 一下丆七与丐上丅下.paddingRight;
            this.paddingTop = 一下丆七与丐上丅下.paddingTop;
        }
        else
        {
                this.name = 11993091;
            this.x = 28563616;
            this.y = 0;
            this.width = 64;
            this.height = 0;
            this.borderLeft = 135970152;
            this.borderRight = 0;
            this.borderTop = 0;
            this.borderBottom = 3670080;
            this.paddingLeft = 4194311;
            this.paddingRight = 1769500;
            this.paddingTop = 1;
        }
        
        this.paddingBottom = 一下丆七与丐上丅下.paddingBottom;
    }
    public void 丄丒七下丙三丁丆丕(UISpriteData 一下丆七与丐上丅下)
    {
        if(一下丆七与丐上丅下 != null)
        {
                this.borderLeft = 一下丆七与丐上丅下.borderLeft;
            this.borderRight = 一下丆七与丐上丅下.borderRight;
            this.borderTop = 一下丆七与丐上丅下.borderTop;
        }
        else
        {
                this.borderLeft = 135970152;
            this.borderRight = 0;
            this.borderTop = 0;
        }
        
        this.borderBottom = 一下丆七与丐上丅下.borderBottom;
    }
    public UISpriteData()
    {
        this.name = "Sprite";
    }

}
