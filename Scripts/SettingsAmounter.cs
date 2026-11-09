using UnityEngine;
internal sealed class SettingsAmounter : PGBehaviour, 东七丟与丞丌专丞三
{
    // Fields
    private UILabel amountLabel;
    private int minValue;
    private int maxValue;
    private int _value;
    private int defaultValue;
    private System.Collections.IEnumerator 不万丌东下世世丑三;
    
    // Methods
    private void Start()
    {
        this.丆三且丆三不世丈丌();
    }
    private void Update()
    {
        if(this.amountLabel.supportEncoding != false)
        {
                return;
        }
        
        this.amountLabel.supportEncoding = true;
    }
    public void CheckValue()
    {
        string val_14 = this.amountLabel.text;
        if((val_14.Contains(value:  "%")) != false)
        {
                val_14 = this.amountLabel.text.Substring(startIndex:  this.amountLabel.text.Length - 2);
        }
        
        if((((System.Int32.TryParse(s:  val_14, result: out  0)) != false) && (0 >= this.minValue)) && (0 <= this.maxValue))
        {
                this._value = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<MyUIInput>())) != false)
        {
                this.GetComponent<MyUIInput>().value = +0;
        }
        
        }
        
        this.丆三且丆三不世丈丌();
    }
    public void StartAdding()
    {
        System.Collections.IEnumerator val_1 = this.且丙丏丁东丕丅且丗(七丞丙丒三丕且丌丟:  1);
        this.不万丌东下世世丑三 = val_1;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  val_1);
    }
    public void StartSubtracting()
    {
        System.Collections.IEnumerator val_1 = this.且丙丏丁东丕丅且丗(七丞丙丒三丕且丌丟:  0);
        this.不万丌东下世世丑三 = val_1;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  val_1);
    }
    private void 丟丒丏丗丒丏东丈丅(int 七丞丙丒三丕且丌丟)
    {
        System.Collections.IEnumerator val_1 = this.且丙丏丁东丕丅且丗(七丞丙丒三丕且丌丟:  七丞丙丒三丕且丌丟);
        this.不万丌东下世世丑三 = val_1;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  val_1);
    }
    public void StopChanging()
    {
        if(this.不万丌东下世世丑三 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.不万丌东下世世丑三);
    }
    private System.Collections.IEnumerator 且丙丏丁东丕丅且丗(int 七丞丙丒三丕且丌丟)
    {
        SettingsAmounter.东丟丙丞专丙丅丁下 val_1 = new SettingsAmounter.东丟丙丞专丙丅丁下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七丞丙丒三丕且丌丟 = 七丞丙丒三丕且丌丟;
        return (System.Collections.IEnumerator)val_1;
    }
    public void SetValue(int 业下丌下三丕丙丌下)
    {
        var val_1 = (this.minValue > 业下丌下三丕丙丌下) ? this.minValue : 业下丌下三丕丙丌下;
        this._value = (val_1 > this.maxValue) ? this.maxValue : (val_1);
        this.丆三且丆三不世丈丌();
    }
    private void 丆三且丆三不世丈丌()
    {
        UILabel val_5;
        string val_7;
        if(this._value >= 100)
        {
                val_5 = this.amountLabel;
            string val_2 = this._value.ToString() + " %"(" %");
        }
        else
        {
                val_5 = this.amountLabel;
            if(this._value >= 10)
        {
                val_7 = "[808080]0[-]";
        }
        else
        {
                val_7 = "[808080]00[-]";
        }
        
        }
        
        val_5.text = val_7 + this._value.ToString() + " %"(" %");
    }
    public void AddToValue(int 业下丌下三丕丙丌下)
    {
        int val_3 = this._value;
        val_3 = val_3 + 业下丌下三丕丙丌下;
        var val_1 = (this.minValue > val_3) ? this.minValue : (val_3);
        this._value = (val_1 > this.maxValue) ? this.maxValue : (val_1);
        this.丆三且丆三不世丈丌();
    }
    public int Value()
    {
        return (int)this._value;
    }
    public void SetDefault()
    {
        var val_1 = (this.minValue > this.defaultValue) ? this.minValue : this.defaultValue;
        this._value = (val_1 > this.maxValue) ? this.maxValue : (val_1);
        this.丆三且丆三不世丈丌();
    }
    public bool IsDefault()
    {
        return (bool)(this._value == this.defaultValue) ? 1 : 0;
    }
    public void Set(object 丄三丅七丆丛与与上)
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丄三丅七丆丛与与上);
        var val_1 = (this.minValue > null) ? this.minValue : (null);
        this._value = (val_1 > this.maxValue) ? this.maxValue : (val_1);
        this.丆三且丆三不世丈丌();
    }
    public object Get()
    {
        return (object)this._value;
    }
    public void SetReadonly(bool 三丟东丕丄丄下下丑)
    {
    
    }
    public SettingsAmounter()
    {
        this.defaultValue = 100;
    }

}
