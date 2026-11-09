using UnityEngine;
internal sealed class SettingsEnumSwitcher : PGBehaviour, 东七丟与丞丌专丞三
{
    // Fields
    private I2.Loc.Localize myLabel;
    public SwitcherParameter[] myParams;
    private int currentParamIndex;
    private int defaultParamIndex;
    
    // Methods
    private void Start()
    {
        this.丆三且丆三不世丈丌();
    }
    private void Update()
    {
    
    }
    public int CurrentParamIndex()
    {
        return (int)this.currentParamIndex;
    }
    public void SetParamsList(SwitcherParameter[] 七丏丄丅丌业与且丙)
    {
        this.myParams = 七丏丄丅丌业与且丙;
        this.currentParamIndex = 0;
        this.丆三且丆三不世丈丌();
    }
    private void 丆三且丆三不世丈丌()
    {
        SwitcherParameter val_4 = this.myParams[this.currentParamIndex];
        this.myLabel.gameObject.GetComponent<UILabel>().text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.myParams[this.currentParamIndex][0].localizationKey);
    }
    private void 东丏七专丑丙丛丅东(int 业下丌下三丕丙丌下)
    {
        业下丌下三丕丙丌下 = this.currentParamIndex + 业下丌下三丕丙丌下;
        this.SetParamIndex(业下丌下三丕丙丌下:  业下丌下三丕丙丌下);
    }
    public void SetParamIndex(int 业下丌下三丕丙丌下)
    {
        int val_2 = 业下丌下三丕丙丌下;
        if(this.myParams.Length <= val_2)
        {
            goto label_1;
        }
        
        if((val_2 & 2147483648) == 0)
        {
            goto label_4;
        }
        
        val_2 = this.myParams.Length - 1;
        goto label_4;
        label_1:
        val_2 = 0;
        label_4:
        this.currentParamIndex = val_2;
        this.丆三且丆三不世丈丌();
    }
    public void NextParam()
    {
        this.SetParamIndex(业下丌下三丕丙丌下:  this.currentParamIndex + 1);
    }
    public void PreviousParam()
    {
        this.SetParamIndex(业下丌下三丕丙丌下:  this.currentParamIndex - 1);
    }
    public void SetDefault()
    {
        this.SetParamIndex(业下丌下三丕丙丌下:  this.defaultParamIndex);
    }
    public bool IsDefault()
    {
        return (bool)(this.currentParamIndex == this.defaultParamIndex) ? 1 : 0;
    }
    public void Set(object 丄三丅七丆丛与与上)
    {
        this.SetParamIndex(业下丌下三丕丙丌下:  21884928);
    }
    public object Get()
    {
        return (object)this.currentParamIndex;
    }
    public void SetReadonly(bool 三丟东丕丄丄下下丑)
    {
    
    }
    private void OnEnable()
    {
        this.丆三且丆三不世丈丌();
    }
    public SettingsEnumSwitcher()
    {
    
    }

}
