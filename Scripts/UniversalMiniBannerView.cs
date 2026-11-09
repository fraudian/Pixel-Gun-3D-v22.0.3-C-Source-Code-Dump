using UnityEngine;
internal class UniversalMiniBannerView : PGBehaviour
{
    // Fields
    private PGCompany.TimerUI _timerUI;
    private UnityEngine.GameObject _timerUIHolder;
    private UniversalMiniBannerListUI 专东丌七丙丅专丄万;
    private 不专丞丘世七丈丙丞 丅且丈丞东一万丂且;
    
    // Properties
    internal 不专丞丘世七丈丙丞 丗下东东丑业丒东不 { get; }
    
    // Methods
    internal 不专丞丘世七丈丙丞 丌丆丝三万丄丁丗丂()
    {
        return (不专丞丘世七丈丙丞)this.丅且丈丞东一万丂且;
    }
    internal virtual void 丈且东丑丂且万丒丅(不专丞丘世七丈丙丞 丄一世丁上丅丘东丈)
    {
        this.丅且丈丞东一万丂且 = 丄一世丁上丅丘东丈;
        goto typeof(UniversalMiniBannerView).__il2cppRuntimeField_198;
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void OnDisable()
    {
    
    }
    internal virtual void 丝一丅丆三东丂丞七()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        if(this.丅且丈丞东一万丂且.丏不万且丑丗丄一丕 >= 1)
        {
                this._timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.丅且丈丞东一万丂且.丏不万且丑丗丄一丕 - PixelTime.丝丗专上三不丄丑丑(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  typeof(UniversalMiniBannerView).__il2cppRuntimeField_1B0), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_4 = this._timerUIHolder;
            val_5 = 1;
            val_6 = val_4;
        }
        else
        {
                this._timerUI.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  "");
            val_4 = this._timerUIHolder;
            val_6 = val_4;
            val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
    }
    internal virtual void 丞丆专丙东丟三且且()
    {
        goto typeof(UniversalMiniBannerView).__il2cppRuntimeField_198;
    }
    public UniversalMiniBannerView()
    {
    
    }

}
