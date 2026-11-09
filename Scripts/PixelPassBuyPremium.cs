using UnityEngine;
internal sealed class PixelPassBuyPremium : PGBehaviour
{
    // Fields
    private static System.Action 七东业丅丗下一丄丘;
    private static System.Action 且丆万丂世不丑丙世;
    private float lerpParam;
    private PixelPassPremiumView offerRight;
    private UnityEngine.Transform rightHoldert;
    private float rightHoldertAtivePos;
    private float rightHoldertinativePos;
    private System.Collections.Generic.List<UnityEngine.GameObject> activeRight;
    private SimpleTweenePlayer rightAnitation;
    private UnityEngine.GameObject maxLevel;
    private PixelPassPremiumView offerLeft;
    private UnityEngine.Transform leftHoldert;
    private float leftHoldertAtivePos;
    private float leftHoldertinativePos;
    private System.Collections.Generic.List<UnityEngine.GameObject> activeLeft;
    private SimpleTweenePlayer leftAnitation;
    private UnityEngine.GameObject disableOnOpen;
    private UnityEngine.Transform 七万且一丙丁世与东;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    protected System.IDisposable 专丏业专不丂一丂丛;
    private bool 不丒上万丘丆丐专丒;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal static void 丙七不丗东丞丘专不(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  PixelPassBuyPremium.七东业丅丗下一丄丘, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丞丕丂丏丌丈专业丕(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  PixelPassBuyPremium.七东业丅丗下一丄丘, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 世丁万丛上丈丆丈不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PixelPassBuyPremium.且丆万丂世不丑丙世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PixelPassBuyPremium.且丆万丂世不丑丙世 != 1152921505241460744);
    
    }
    internal static void 丐东丄专业丁丅一丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PixelPassBuyPremium.且丆万丂世不丑丙世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PixelPassBuyPremium.且丆万丂世不丑丙世 != 1152921505241460744);
    
    }
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private void OnEnable()
    {
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PixelPassBuyPremium::Hide()), 与且专丈不万东一万:  "PixelPassBuyPremium");
        if(PixelPassBuyPremium.七东业丅丗下一丄丘 == null)
        {
                return;
        }
        
        PixelPassBuyPremium.七东业丅丗下一丄丘.Invoke();
    }
    private void OnDisable()
    {
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        if(PixelPassBuyPremium.且丆万丂世不丑丙世 == null)
        {
                return;
        }
        
        PixelPassBuyPremium.且丆万丂世不丑丙世.Invoke();
    }
    internal void 下与丞三丅丛丄七丕(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        this.不丒上万丘丆丐专丒 = this.disableOnOpen.activeSelf;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableOnOpen, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  丈丂七世丟丞丂丗丒);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东一丄上丙丘下三上(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗());
    }
    public void Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableOnOpen, 丏业丟一东丂东丘丛:  (this.不丒上万丘丆丐专丒 == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        this.offerLeft.丈且东丑丂且万丒丅(不东万下丆丝东丞丏:  丈丂七世丟丞丂丗丒.东丏与丁七业丝丏专().Item[0]);
        this.offerRight.丈且东丑丂且万丒丅(不东万下丆丝东丞丏:  丈丂七世丟丞丂丗丒.东丏与丁七业丝丏专().Item[1]);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.maxLevel, 丏业丟一东丂东丘丛:  false);
        this.SelectRight(丈世万丙丟东与丕丞:  false);
        if(this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌() >= this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.maxLevel, 丏业丟一东丂东丘丛:  true);
            this.SeletLeft(丈世万丙丟东与丕丞:  true);
        }
        
        if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() == false)
        {
                return;
        }
        
        this.SeletLeft(丈世万丙丟东与丕丞:  true);
    }
    public void SelectRight(bool 丈世万丙丟东与丕丞 = True)
    {
        if(this.丑与万三丐丒丏一专.丞丞丘业东丙丏七丌() >= this.丑与万三丐丒丏一专.丄且东且丕丛与丆丒())
        {
                return;
        }
        
        this.七万且一丙丁世与东 = this.rightHoldert;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.activeRight, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.activeLeft, 丏业丟一东丂东丘丛:  false);
        if(丈世万丙丟东与丕丞 != false)
        {
                this.leftAnitation.Play();
            this.rightAnitation.PlayRewers();
            return;
        }
        
        UnityEngine.Vector3 val_3 = this.rightHoldert.localPosition;
        this.rightHoldert.localPosition = new UnityEngine.Vector3() {x = this.rightHoldertAtivePos, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_4 = this.leftHoldert.localPosition;
        this.leftHoldert.localPosition = new UnityEngine.Vector3() {x = this.leftHoldertinativePos, y = val_4.y, z = val_4.z};
        this.leftAnitation.SetFinal();
        this.rightAnitation.SetInitial();
    }
    public void SeletLeft(bool 丈世万丙丟东与丕丞 = True)
    {
        this.七万且一丙丁世与东 = this.leftHoldert;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.activeRight, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.activeLeft, 丏业丟一东丂东丘丛:  true);
        if(丈世万丙丟东与丕丞 != false)
        {
                this.rightAnitation.Play();
            this.leftAnitation.PlayRewers();
            return;
        }
        
        UnityEngine.Vector3 val_1 = this.rightHoldert.localPosition;
        this.rightHoldert.localPosition = new UnityEngine.Vector3() {x = this.rightHoldertinativePos, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = this.leftHoldert.localPosition;
        this.leftHoldert.localPosition = new UnityEngine.Vector3() {x = this.leftHoldertAtivePos, y = val_2.y, z = val_2.z};
        this.rightAnitation.SetFinal();
        this.leftAnitation.SetInitial();
    }
    private void Update()
    {
        UnityEngine.Transform val_13;
        float val_14;
        UnityEngine.Vector3 val_2 = this.rightHoldert.localPosition;
        if(this.七万且一丙丁世与东 != this.rightHoldert)
        {
            goto label_4;
        }
        
        val_13 = this.rightHoldert;
        val_14 = this.rightHoldertAtivePos;
        if(val_13 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_4:
        val_13 = this.rightHoldert;
        val_14 = this.rightHoldertinativePos;
        if(val_13 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        UnityEngine.Vector3 val_3 = val_13.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_14, y = val_2.y, z = val_2.z}, t:  UnityEngine.Time.deltaTime * this.lerpParam);
        val_13.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = this.leftHoldert.localPosition;
        if(this.七万且一丙丁世与东 != this.leftHoldert)
        {
            goto label_14;
        }
        
        if(this.leftHoldert != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        UnityEngine.Vector3 val_9 = this.leftHoldert.localPosition;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = this.leftHoldertAtivePos, y = val_8.y, z = val_8.z}, t:  UnityEngine.Time.deltaTime * this.lerpParam);
        this.leftHoldert.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        return;
        label_14:
        if(this.leftHoldert != null)
        {
            goto label_19;
        }
        
        goto label_20;
    }
    public void U_SelectRight()
    {
        this.SelectRight(丈世万丙丟东与丕丞:  true);
    }
    public void U_SelectLeft()
    {
        this.SeletLeft(丈世万丙丟东与丕丞:  true);
    }
    public PixelPassBuyPremium()
    {
        this.lerpParam = 6f;
    }

}
