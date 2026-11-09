using UnityEngine;
[Serializable]
public class BMFont
{
    // Fields
    private int mSize;
    private int mBase;
    private int mWidth;
    private int mHeight;
    private string mSpriteName;
    private System.Collections.Generic.List<BMGlyph> mSaved;
    private System.Collections.Generic.Dictionary<int, BMGlyph> mDict;
    
    // Properties
    public bool isValid { get; }
    public int charSize { get; set; }
    public int baseOffset { get; set; }
    public int texWidth { get; set; }
    public int texHeight { get; set; }
    public int glyphCount { get; }
    public string spriteName { get; set; }
    public System.Collections.Generic.List<BMGlyph> glyphs { get; }
    
    // Methods
    public bool get_isValid()
    {
        return (bool)(this.mSaved.Count > 0) ? 1 : 0;
    }
    public int get_charSize()
    {
        return (int)this.mSize;
    }
    public void set_charSize(int 丙业与丙丗丝不丈东)
    {
        this.mSize = 丙业与丙丗丝不丈东;
    }
    public int get_baseOffset()
    {
        return (int)this.mBase;
    }
    public void set_baseOffset(int 丙业与丙丗丝不丈东)
    {
        this.mBase = 丙业与丙丗丝不丈东;
    }
    public int get_texWidth()
    {
        return (int)this.mWidth;
    }
    public void set_texWidth(int 丙业与丙丗丝不丈东)
    {
        this.mWidth = 丙业与丙丗丝不丈东;
    }
    public int get_texHeight()
    {
        return (int)this.mHeight;
    }
    public void set_texHeight(int 丙业与丙丗丝不丈东)
    {
        this.mHeight = 丙业与丙丗丝不丈东;
    }
    public int get_glyphCount()
    {
        if(this.isValid == false)
        {
                return 0;
        }
        
        if(this.mSaved != null)
        {
                return this.mSaved.Count;
        }
        
        return this.mSaved.Count;
    }
    public string get_spriteName()
    {
        return (string)this.mSpriteName;
    }
    public void set_spriteName(string 丙业与丙丗丝不丈东)
    {
        this.mSpriteName = 丙业与丙丗丝不丈东;
    }
    public System.Collections.Generic.List<BMGlyph> get_glyphs()
    {
        return (System.Collections.Generic.List<BMGlyph>)this.mSaved;
    }
    public BMGlyph 且丞世东丟丌且下丁(int 丞世不丒下上上丝丑, bool 丐丗丏东丘东丘丈且)
    {
        BMGlyph val_7;
        BMGlyph val_8;
        val_7 = 丐丗丏东丘东丘丈且;
        if(this.mDict.Count == 0)
        {
                int val_2 = this.mSaved.Count;
            if(val_2 >= 1)
        {
                var val_7 = 0;
            do
        {
            this.mDict.Add(key:  val_3.index, value:  this.mSaved.Item[0]);
            val_7 = val_7 + 1;
        }
        while(val_2 != val_7);
        
        }
        
        }
        
        if((this.mDict.TryGetValue(key:  丞世不丒下上上丝丑, value: out  0)) == true)
        {
                return val_6;
        }
        
        if(val_7 == false)
        {
                return val_6;
        }
        
        BMGlyph val_6 = new BMGlyph();
        val_8 = val_6;
        if(val_6 == null)
        {
                val_8 = val_6;
        }
        
        .index = 丞世不丒下上上丝丑;
        this.mSaved.Add(item:  val_6);
        val_7 = val_6;
        this.mDict.Add(key:  丞世不丒下上上丝丑, value:  val_6);
        return val_6;
    }
    public BMGlyph 且丞世东丟丌且下丁(int 丞世不丒下上上丝丑)
    {
        return this.且丞世东丟丌且下丁(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丐丗丏东丘东丘丈且:  false);
    }
    public void 世业丒万丘丆专丘丐()
    {
        this.mDict.Clear();
        this.mSaved.Clear();
    }
    public void 丝丙丆三丑东丈且丙(int 丘丄七七丝丞丄七万, int 与上世世专丐与丄丐, int 丌丝丘丑丘丂专丞丗, int 丏丐丘丗丙上世丏不)
    {
        if(this.isValid == false)
        {
                return;
        }
        
        int val_2 = this.mSaved.Count;
        if(val_2 < 1)
        {
                return;
        }
        
        var val_4 = 0;
        do
        {
            BMGlyph val_3 = this.mSaved.Item[0];
            if(val_3 != null)
        {
                val_3.丝丙丆三丑东丈且丙(丘丄七七丝丞丄七万:  丘丄七七丝丞丄七万, 与上世世专丐与丄丐:  与上世世专丐与丄丐, 丌丝丘丑丘丂专丞丗:  丌丝丘丑丘丂专丞丗, 丏丐丘丗丙上世丏不:  丏丐丘丗丙上世丏不);
        }
        
            val_4 = val_4 + 1;
        }
        while(val_2 != val_4);
    
    }
    public BMFont()
    {
        this.mSize = 16;
        this.mSaved = new System.Collections.Generic.List<BMGlyph>();
        this.mDict = new System.Collections.Generic.Dictionary<System.Int32, BMGlyph>();
    }

}
