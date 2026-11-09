using UnityEngine;
public class UISliderCont : PGBehaviour
{
    // Fields
    public UISlider slider;
    public UIToggle toggle;
    public UILabel amountLabel;
    public float minValue;
    public float maxValue;
    public bool isPercentageDisplay;
    internal UnityEngine.Events.UnityAction<bool> 丑三丘丑丘业丘丌上;
    internal UnityEngine.Events.UnityAction<float> 丝丞丁三丐丌不丄丟;
    
    // Methods
    private void Awake()
    {
        this.东一三一万且丕世不();
        this.toggle.onChange.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISliderCont::且专丘丑丐一丗专且())));
        this.slider.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISliderCont::丌丏不丒丈七丕丟下())));
    }
    private void 东一三一万且丕世不()
    {
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.slider, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "UISliderCont.{0} is null", arg0:  "slider"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.toggle, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "UISliderCont.{0} is null", arg0:  "toggle"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.amountLabel, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "UISliderCont.{0} is null", arg0:  "amountLabel"));
    }
    internal void 丘上丐世丆丑且丞丒(float 丛丁三世世丆七不业)
    {
        this.丘上丐世丆丑且丞丒(丌丈丝业三丕丗丌世:  true, 丛丁三世世丆七不业:  丛丁三世世丆七不业, 丒丛七丄世业东丝丁:  this.minValue, 七丝东丛东丝且丆不:  this.maxValue);
    }
    internal void 丘上丐世丆丑且丞丒(bool 丌丈丝业三丕丗丌世, float 丛丁三世世丆七不业)
    {
        this.丘上丐世丆丑且丞丒(丌丈丝业三丕丗丌世:  丌丈丝业三丕丗丌世, 丛丁三世世丆七不业:  丛丁三世世丆七不业, 丒丛七丄世业东丝丁:  this.minValue, 七丝东丛东丝且丆不:  this.maxValue);
    }
    internal void 丘上丐世丆丑且丞丒(float 丛丁三世世丆七不业, float 丒丛七丄世业东丝丁, float 七丝东丛东丝且丆不)
    {
        this.丘上丐世丆丑且丞丒(丌丈丝业三丕丗丌世:  true, 丛丁三世世丆七不业:  丛丁三世世丆七不业, 丒丛七丄世业东丝丁:  丒丛七丄世业东丝丁, 七丝东丛东丝且丆不:  七丝东丛东丝且丆不);
    }
    internal void 丘上丐世丆丑且丞丒(bool 丌丈丝业三丕丗丌世, float 丛丁三世世丆七不业, float 丒丛七丄世业东丝丁, float 七丝东丛东丝且丆不)
    {
        this.minValue = 丒丛七丄世业东丝丁;
        this.maxValue = 七丝东丛东丝且丆不;
        float val_3 = UnityEngine.Mathf.Clamp(value:  丛丁三世世丆七不业, min:  丒丛七丄世业东丝丁, max:  七丝东丛东丝且丆不);
        丌丈丝业三丕丗丌世 = 丌丈丝业三丕丗丌世;
        val_3 = val_3 - this.minValue;
        this.toggle.value = 丌丈丝业三丕丗丌世;
        float val_2 = this.maxValue - this.minValue;
        val_2 = val_3 / val_2;
        this.slider.value = val_2;
    }
    private void 且专丘丑丐一丗专且()
    {
        丏一丒丑丁丞一丏丟.不上丕不丞业一丗丂(丆且丞丟丛丗万一世:  this.slider, 东丅丞丁丗万且丁丗:  this.toggle.value);
        if(this.丑三丘丑丘业丘丌上 == null)
        {
                return;
        }
        
        this.丑三丘丑丘业丘丌上.Invoke(arg0:  this.toggle.value);
    }
    private void 丌丏不丒丈七丕丟下()
    {
        float val_2 = this.maxValue - this.minValue;
        val_2 = this.slider.value * val_2;
        val_2 = this.minValue + val_2;
        float val_3 = UnityEngine.Mathf.Clamp(value:  val_2, min:  this.minValue, max:  this.maxValue);
        this.七万丟丐丘丏一丄丙(丁下丛丅丅丌丅三三:  val_3);
        if(this.丝丞丁三丐丌不丄丟 == null)
        {
                return;
        }
        
        this.丝丞丁三丐丌不丄丟.Invoke(arg0:  val_3);
    }
    private void 七万丟丐丘丏一丄丙(float 丁下丛丅丅丌丅三三)
    {
        string val_4;
        if(this.isPercentageDisplay != false)
        {
                float val_1 = this.slider.value;
            val_1 = val_1 * 100f;
            val_4 = "{0:F0}";
        }
        else
        {
                val_4 = "{0:F1}";
        }
        
        this.amountLabel.text = System.String.Format(format:  val_4, arg0:  丁下丛丅丅丌丅三三);
    }
    public UISliderCont()
    {
        this.maxValue = 1f;
        this.isPercentageDisplay = true;
    }

}
