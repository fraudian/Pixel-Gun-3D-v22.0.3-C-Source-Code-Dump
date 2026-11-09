using UnityEngine;
internal sealed class PixelPassPageDot : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfSelected;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNotSelected;
    private PixelPassPageDotsList 丄丘三丁上丐三丟世;
    private int 上上且丈丘下不丈上;
    
    // Properties
    internal bool 与丆与丂丄丞丒丏丑 { get; }
    internal PixelPassPageDotsList 丗丒丈世丏三丑丝与 { get; }
    internal int 上三丝且丕上丟丆七 { get; }
    
    // Methods
    internal bool 丆世丆东三专东东三()
    {
        return (bool)(this.丄丘三丁上丐三丟世.丒不丐丏且丐上丌万.GetSelected() == this.上上且丈丘下不丈上) ? 1 : 0;
    }
    internal PixelPassPageDotsList 丟丆丘丘专丅丄丑丙()
    {
        return (PixelPassPageDotsList)this.丄丘三丁上丐三丟世;
    }
    internal int 丈丁丝业与业丙三丅()
    {
        return (int)this.上上且丈丘下不丈上;
    }
    internal void 丈且东丑丂且万丒丅(PixelPassPageDotsList 丁丗丏丌不丌丁丅丑, int 丝业丈专业万上与丝)
    {
        this.丄丘三丁上丐三丟世 = 丁丗丏丌不丌丁丅丑;
        this.上上且丈丘下不丈上 = 丝业丈专业万上与丝;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfSelected, 丏业丟一东丂东丘丛:  this.丆世丆东三专东东三());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotSelected, 丏业丟一东丂东丘丛:  (~this.丆世丆东三专东东三()) & 1);
    }
    public void Select()
    {
        this.丄丘三丁上丐三丟世.SelectDot(丂丘丟丞丅丟丛上丐:  this);
    }
    public PixelPassPageDot()
    {
    
    }

}
