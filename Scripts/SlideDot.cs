using UnityEngine;
internal class SlideDot : MonoBehaviour
{
    // Fields
    private SlidesScrollController 丆丅丕丆七世丐丌丒;
    private int 丞世不丒下上上丝丑;
    private bool 丘丅专丅专丘不丙丛;
    private UnityEngine.GameObject _selected;
    private UnityEngine.GameObject _notSelected;
    
    // Methods
    public void Setup(SlidesScrollController 丆丅丕丆七世丐丌丒, int 丞世不丒下上上丝丑, bool 丘丅专丅专丘不丙丛)
    {
        this.丆丅丕丆七世丐丌丒 = 丆丅丕丆七世丐丌丒;
        this.丞世不丒下上上丝丑 = 丞世不丒下上上丝丑;
        this.丘丅专丅专丘不丙丛 = 丘丅专丅专丘不丙丛;
        this.世不丅东世丌丏丗三(丂丛丑东不丅丈一东:  false);
    }
    internal void 世不丅东世丌丏丗三(bool 丂丛丑东不丅丈一东)
    {
        丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selected, 丏业丟一东丂东丘丛:  丂丛丑东不丅丈一东);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notSelected, 丏业丟一东丂东丘丛:  (~丂丛丑东不丅丈一东) & 1);
    }
    internal void OnClick()
    {
        if(this.丆丅丕丆七世丐丌丒 == 0)
        {
                return;
        }
        
        if(this.丘丅专丅专丘不丙丛 != false)
        {
                return;
        }
        
        this.丆丅丕丆七世丐丌丒.CenterOnByIndex(丞世不丒下上上丝丑:  this.丞世不丒下上上丝丑, 丌丝丌丁下丐丞丆一:  false);
    }
    public SlideDot()
    {
    
    }

}
