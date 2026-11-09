using UnityEngine;
internal sealed class HoldPositions_PointCircleUI : PointCircleUI
{
    // Fields
    private UILabel timeLabel;
    private SimpleTween tween;
    public HoldPositionsPoint myPoint;
    private float 与丕丌丒丗丄丘丙东;
    private float 专上上丄丐且七丆上;
    private float 丙丝丙与丂丄丈不业;
    private float 丙丝丏丈丄世七丌丞;
    private UnityEngine.GameObject lockedIcon;
    private double 丛专丅与丄下丝专世;
    
    // Methods
    private void OnDisable()
    {
        if(this.tween == 0)
        {
                return;
        }
        
        if(this.tween.IsActive == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(SimpleTween).__il2cppRuntimeField_188;
    }
    private void 七一丈丟一世丄丝专(double 丂三丟丂丈丐丆丗丟)
    {
        double val_15;
        SimpleTween val_16;
        val_15 = 丂三丟丂丈丐丆丗丟;
        val_16 = this;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  val_15);
        this.timeLabel.text = System.String.Format(format:  "{0}:{1}", arg0:  val_1._ticks.Minutes.ToString(), arg1:  val_1._ticks.Seconds.ToString(format:  "D2"));
        if(this.myPoint.isLocked != false)
        {
                UnityEngine.Color val_8 = UnityEngine.Color.yellow;
        }
        else
        {
                UnityEngine.Color val_9 = UnityEngine.Color.white;
        }
        
        this.timeLabel.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
        if((val_1._ticks.Milliseconds & 2147483648) != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        if(this.tween == 0)
        {
                return;
        }
        
        val_15 = UnityEngine.Mathf.Max(a:  0f, b:  (float)val_15);
        bool val_14 = this.tween.IsActive;
        if(val_15 > this.与丕丌丒丗丄丘丙东)
        {
                if(val_14 == false)
        {
                return;
        }
        
            val_16 = this.tween;
            if(val_16 != null)
        {
                return;
        }
        
            return;
        }
        
        if(val_14 == true)
        {
                return;
        }
        
        val_16 = this.tween;
        val_16.Play();
    }
    private void Awake()
    {
        this.timeLabel.text = "";
        this.东与丂丏丐丞三丘丁(丙业与丙丗丝不丈东:  "");
    }
    private void 丐专丒丁专丌丑丘丙()
    {
        var val_20;
        var val_21;
        var val_22;
        bool val_23;
        if(this.myPoint.丛七且专丗丒丟丞丈() == false)
        {
            goto label_11;
        }
        
        val_20 = null;
        val_20 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_11;
        }
        
        val_21 = null;
        val_21 = null;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗.世丛丞丗丈丘丘东丅 == false)
        {
            goto label_11;
        }
        
        val_22 = this.myPoint.丘丕丐不与丂业丝丁() ^ 1;
        goto label_13;
        label_11:
        val_22 = 0;
        label_13:
        if(this.myPoint.业七业与三东三丆丐() != false)
        {
                val_23 = 1;
        }
        else
        {
                val_23 = (~this.myPoint.丁三专一丒世丕丕丛()) & 1;
        }
        
        this.丐专丒丁专丌丑丘丙(丙东丏丕丞丁丈丈万:  this.myPoint.丛七且专丗丒丟丞丈(), 专七世丕且丐丙丕东:  this.myPoint.且丈万七丗东丕业且(), 七丟丁下且不丟丌丏:  this.myPoint.不东丞丌丂专丂丟东(), 下丑业丕丌丐三丒丙:  this.myPoint.万业丕丁丒专丈丅三(), 下且下丄专下丝丞丟:  this.myPoint.丅丅世不丝丝丝丄万(), 丆丅丐三一不丕世三:  val_23, 丑丁丐一三东丟业丝:  this.myPoint.业丟东丛且下一丕丘(), 上不世不七丒上不东:  this.myPoint.丒上丝丐丐丒丂丐下(), 丟下丑三丒与丘世东:  val_22 & 1);
    }
    private void Update()
    {
        this.ShowMyPointInfo();
    }
    public void SetPoint(HoldPositionsPoint 七丏丄丅丌业与且丙)
    {
        this.myPoint = 七丏丄丅丌业与且丙;
        this.ShowMyPointInfo();
    }
    public void ShowMyPointInfo()
    {
        float val_18;
        float val_19;
        string val_20;
        var val_22;
        HoldPositionsController val_23;
        var val_24;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  this.专上上丄丐且七丆上, y:  this.专上上丄丐且七丆上);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        val_18 = val_3.x;
        this.timeLabel.transform.localScale = new UnityEngine.Vector3() {x = val_18, y = val_3.y, z = val_3.z};
        val_19 = this.专上上丄丐且七丆上;
        if(val_19 > 1f)
        {
                val_18 = this.丙丝丏丈丄世七丌丞 * UnityEngine.Time.deltaTime;
            val_19 = val_19 - val_18;
            this.专上上丄丐且七丆上 = val_19;
        }
        
        if(val_19 < 0)
        {
                this.专上上丄丐且七丆上 = 1f;
        }
        
        if(this.myPoint == 0)
        {
                return;
        }
        
        if(this.myPoint.isLocked != false)
        {
                val_20 = "";
        }
        else
        {
                val_20 = this.myPoint.myLetterName;
        }
        
        this.东与丂丏丐丞三丘丁(丙业与丙丗丝不丈东:  val_20);
        if(this.lockedIcon != 0)
        {
                this.lockedIcon.SetActive(value:  this.myPoint.isLocked);
        }
        
        if(this.myPoint.isLocked == false)
        {
            goto label_20;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(HoldPositionsController.丆丕丝丒不丙且丐丗 != null)
        {
            goto label_26;
        }
        
        val_23 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        if(val_23 == null)
        {
            goto label_27;
        }
        
        label_26:
        double val_18 = HoldPositionsController.丆丕丝丒不丙且丐丗.spotLifeTime;
        val_18 = this.myPoint.nextPointTime - val_18;
        val_18 = val_18 - (double)HoldPositionsController.丆丕丝丒不丙且丐丗.spotSpawnDelay;
        val_19 = val_18 - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        goto label_28;
        label_20:
        val_24 = null;
        val_24 = null;
        val_19 = (this.myPoint.nextPointTime - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄()) - (double)HoldPositionsController.丆丕丝丒不丙且丐丗.spotSpawnDelay;
        label_28:
        this.七一丈丟一世丄丝专(丂三丟丂丈丐丆丗丟:  val_19);
        if((this.myPoint.isLocked != false) && ((int)val_19 != (int)this.丛专丅与丄下丝专世))
        {
                this.专上上丄丐且七丆上 = this.丙丝丙与丂丄丈不业;
        }
        
        this.丛专丅与丄下丝专世 = val_19;
        this.丐专丒丁专丌丑丘丙();
        return;
        label_27:
    }
    public HoldPositions_PointCircleUI()
    {
        this.与丕丌丒丗丄丘丙东 = ;
        this.专上上丄丐且七丆上 = ;
        this.丙丝丙与丂丄丈不业 = 1.4f;
        this.丙丝丏丈丄世七丌丞 = 1f;
    }

}
