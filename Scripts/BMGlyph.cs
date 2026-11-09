using UnityEngine;
[Serializable]
public class BMGlyph
{
    // Fields
    public int index;
    public int x;
    public int y;
    public int width;
    public int height;
    public int offsetX;
    public int offsetY;
    public int advance;
    public int channel;
    public System.Collections.Generic.List<int> kerning;
    
    // Methods
    public int 世且与丒且丄下世丌(int 丏丛丞一下丙世一专)
    {
        var val_3;
        if(丏丛丞一下丙世一专 == 0)
        {
                return 0;
        }
        
        if(this.kerning == null)
        {
                return 0;
        }
        
        int val_1 = this.kerning.Count;
        if(val_1 < 1)
        {
                return 0;
        }
        
        label_6:
        if((this.kerning.Item[1 - 1]) == 丏丛丞一下丙世一专)
        {
            goto label_5;
        }
        
        val_3 = 1 + 2;
        if((1 + 1) < val_1)
        {
            goto label_6;
        }
        
        return 0;
        label_5:
        if(this.kerning != null)
        {
                return this.kerning.Item[1];
        }
        
        return this.kerning.Item[1];
    }
    public void 世丟丑下三丌丕不丁(int 丏丛丞一下丙世一专, int 丛丁三世世丆七不业)
    {
        System.Collections.Generic.List<System.Int32> val_4;
        var val_5;
        val_4 = this.kerning;
        if(val_4 == null)
        {
                System.Collections.Generic.List<System.Int32> val_1 = null;
            val_4 = val_1;
            val_1 = new System.Collections.Generic.List<System.Int32>();
            this.kerning = val_4;
        }
        
        val_5 = 1;
        goto label_2;
        label_6:
        if(val_1.Item[W24] == 丏丛丞一下丙世一专)
        {
            goto label_3;
        }
        
        val_4 = this.kerning;
        val_5 = 3;
        label_2:
        if((val_5 - 1) < val_4.Count)
        {
            goto label_6;
        }
        
        this.kerning.Add(item:  丏丛丞一下丙世一专);
        this.kerning.Add(item:  丛丁三世世丆七不业);
        return;
        label_3:
        this.kerning.set_Item(index:  1, value:  丛丁三世世丆七不业);
    }
    public void 丝丙丆三丑东丈且丙(int 丘丄七七丝丞丄七万, int 与上世世专丐与丄丐, int 丌丝丘丑丘丂专丞丗, int 丏丐丘丗丙上世丏不)
    {
        int val_6;
        int val_7;
        int val_5 = this.y;
        int val_4 = this.width;
        val_6 = val_4;
        if(this.x < 丘丄七七丝丞丄七万)
        {
                int val_1 = 丘丄七七丝丞丄七万 - this.x;
            val_6 = val_4 - val_1;
            this.x = 丘丄七七丝丞丄七万;
            val_1 = this.offsetX + val_1;
            this.width = val_6;
            this.offsetX = val_1;
        }
        
        val_4 = val_4 + this.x;
        val_7 = this.height;
        if(val_5 < 与上世世专丐与丄丐)
        {
                int val_2 = 与上世世专丐与丄丐 - val_5;
            val_7 = this.height - val_2;
            this.y = 与上世世专丐与丄丐;
            val_2 = this.offsetY + val_2;
            this.height = val_7;
            this.offsetY = val_2;
        }
        
        val_5 = this.height + val_5;
        if(val_4 > 丌丝丘丑丘丂专丞丗)
        {
                int val_3 = 丌丝丘丑丘丂专丞丗 - val_4;
            val_3 = val_3 + val_6;
            this.width = val_3;
        }
        
        if(val_5 <= 丏丐丘丗丙上世丏不)
        {
                return;
        }
        
        val_5 = 丏丐丘丗丙上世丏不 - val_5;
        val_5 = val_5 + val_7;
        this.height = val_5;
    }
    public BMGlyph()
    {
    
    }

}
