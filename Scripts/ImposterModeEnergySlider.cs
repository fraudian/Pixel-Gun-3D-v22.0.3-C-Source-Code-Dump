using UnityEngine;
internal sealed class ImposterModeEnergySlider : PGBehaviour
{
    // Fields
    internal System.Action<ImposterModeEnergySlider> 七丂丌丐丛丏丌丑丞;
    private UILabel name;
    private UISlider slider;
    private UnityEngine.GameObject highlight;
    private UISprite bar;
    private float barRandom;
    public string _roomLocalization;
    internal PlayerTaskImposterMode 与世七丑丂专专丌丙;
    
    // Properties
    internal float 不丑一丙东丙丆丁七 { get; set; }
    
    // Methods
    internal float 世三丞丅丑丌丈丈一()
    {
        if(this.slider != null)
        {
                return this.slider.value;
        }
        
        return this.slider.value;
    }
    internal void 丙丏不三丗三丙丈与(float 丙业与丙丗丝不丈东)
    {
        this.slider.value = 丙业与丙丗丝不丈东;
    }
    internal void 丈且东丑丂且万丒丅(PlayerTaskImposterMode 万不且且丛丆东丒业, string 世丈丘丌丕三丐三丅)
    {
        this._roomLocalization = 世丈丘丌丕三丐三丅;
        this.与世七丑丂专专丌丙 = 万不且且丛丆东丒业;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.name, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  世丈丘丌丕三丐三丅));
    }
    internal void 丒丙丑丝专丛丞丒丒(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.highlight, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    public void OnSliderValueChaged()
    {
        if(this.七丂丌丐丛丏丌丑丞 == null)
        {
                return;
        }
        
        this.七丂丌丐丛丏丌丑丞.Invoke(obj:  this);
    }
    private void Update()
    {
        if(this.世三丞丅丑丌丈丈一() > 0f)
        {
                float val_5 = this.barRandom;
            val_5 = this.世三丞丅丑丌丈丈一() + val_5;
            float val_4 = UnityEngine.Random.Range(min:  this.世三丞丅丑丌丈丈一(), max:  val_5);
            if(this.bar != null)
        {
            goto label_2;
        }
        
        }
        
        label_2:
        this.bar.fillAmount = 0f;
    }
    public ImposterModeEnergySlider()
    {
        this.barRandom = 0.05f;
    }

}
