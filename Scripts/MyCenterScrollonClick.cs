using UnityEngine;
public class MyCenterScrollonClick : UIDragScrollView
{
    // Fields
    private MyCenterOnChild 丙丂丂业丂丁丌丂下;
    
    // Methods
    private void Awake()
    {
        if(this.丙丂丂业丂丁丌丂下 != 0)
        {
                return;
        }
        
        this.丙丂丂业丂丁丌丂下 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<MyCenterOnChild>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
    }
    private void OnClick()
    {
        this.丙丂丂业丂丁丌丂下.CenterOn(丞下万上三丘上与专:  this.transform);
    }
    public MyCenterScrollonClick()
    {
    
    }

}
