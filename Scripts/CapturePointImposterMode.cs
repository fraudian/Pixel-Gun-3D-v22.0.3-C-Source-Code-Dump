using UnityEngine;
internal sealed class CapturePointImposterMode : PGBehaviour
{
    // Fields
    public string nameBasePoint;
    internal bool isSabotagePoint;
    private UnityEngine.LineRenderer rayPoint;
    private UnityEngine.GameObject basePointRender;
    private bool 丞一业不丟万世三且;
    private float captureCounter;
    private float captureSpeedCoef;
    private float timeCaptureCounter;
    private float maxCaptureCounter;
    internal UnityEngine.Transform 万一丂丐丄丁上与丟;
    internal System.Action 丄丝丘丈三丝七上丞;
    
    // Properties
    internal UnityEngine.Vector3 万世丂业一丑七东丒 { get; }
    private bool 与专丘丞一丑丘丕丁 { get; }
    
    // Methods
    internal UnityEngine.Vector3 丌丆丈世世丞丄丏下()
    {
        if(this.万一丂丐丄丁上与丟 != null)
        {
                return this.万一丂丐丄丁上与丟.position;
        }
        
        return this.万一丂丐丄丁上与丟.position;
    }
    private bool 七七世三东业丞丘专()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(丟东丘丏上世且上丕() != false)
        {
                var val_2 = (this.isSabotagePoint == true) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 1;
        return (bool)val_4;
    }
    private void Awake()
    {
        this.万一丂丐丄丁上与丟 = this.transform;
    }
    internal void Reset()
    {
        this.captureCounter = 0f;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.丌丐丛丁与丁丂丛丟(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        this.丈东丌丟丒丄丏丆与();
        this.丄丝丘丈三丝七上丞 = 0;
    }
    private void Update()
    {
        this.丈丝丂业丑丅丗上东();
    }
    private void 丈丝丂业丑丅丗上东()
    {
        if((this.丞一业不丟万世三且 != false) && (this.七七世三东业丞丘专() != false))
        {
                float val_2 = UnityEngine.Time.deltaTime;
            val_2 = val_2 * this.maxCaptureCounter;
            val_2 = val_2 / this.timeCaptureCounter;
            val_2 = this.captureCounter + val_2;
            this.captureCounter = val_2;
            if(val_2 > this.maxCaptureCounter)
        {
                this.captureCounter = this.maxCaptureCounter;
            if(this.丄丝丘丈三丝七上丞 != null)
        {
                this.丄丝丘丈三丝七上丞.Invoke();
            this.丄丝丘丈三丝七上丞 = 0;
        }
        
        }
        
        }
        
        this.丁丟丏丁业世且世世();
    }
    private void 丁丟丏丁业世且世世()
    {
        if(this.丞一业不丟万世三且 == false)
        {
                return;
        }
        
        if(this.七七世三东业丞丘专() == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_Imposter.__il2cppRuntimeField_this_arg.SetActive(value:  true);
        InGameGUIPart_Imposter.__il2cppRuntimeField_element_class.text = this.nameBasePoint;
        typeof(InGameGUIPart_Imposter).__il2cppRuntimeField_38.fillAmount = this.captureCounter / this.maxCaptureCounter;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        var val_14;
        var val_15;
        val_14 = null;
        val_14 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丘丛丏丘丝七世七丅.name, b:  "BodyCollider")) == false)
        {
                return;
        }
        
        if(丘丛丏丘丝七世七丅.transform.parent == 0)
        {
                return;
        }
        
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject.CompareTag(tag:  "Player")) == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        this.下一万丄一丐一三丐();
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        var val_14;
        var val_15;
        val_14 = null;
        val_14 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丘丛丏丘丝七世七丅.name, b:  "BodyCollider")) == false)
        {
                return;
        }
        
        if(丘丛丏丘丝七世七丅.transform.parent == 0)
        {
                return;
        }
        
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject.CompareTag(tag:  "Player")) == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        this.丈东丌丟丒丄丏丆与();
    }
    private void 下一万丄一丐一三丐()
    {
        this.丞一业不丟万世三且 = true;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.七七世三东业丞丘专() == false)
        {
                return;
        }
        
        InGameGUIPart_Imposter.__il2cppRuntimeField_this_arg.SetActive(value:  true);
    }
    private void 丈东丌丟丒丄丏丆与()
    {
        this.丞一业不丟万世三且 = false;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_Imposter.__il2cppRuntimeField_this_arg.SetActive(value:  false);
    }
    private void 丌丐丛丁与丁丂丛丟(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        UnityEngine.Color val_1 = this.rayPoint.startColor;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, rhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a})) != true)
        {
                UnityEngine.Color val_3 = this.rayPoint.endColor;
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, rhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a})) == false)
        {
                return;
        }
        
        }
        
        this.rayPoint.startColor = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.rayPoint.endColor = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    public CapturePointImposterMode()
    {
        this.captureSpeedCoef = 1f;
        this.timeCaptureCounter = 0f;
        this.maxCaptureCounter = 100f;
    }

}
