using UnityEngine;
internal sealed class HoldPositions_TimerUI : MonoBehaviour
{
    // Fields
    private HoldPositions_PointCircleUI pointCircle;
    private HoldPositions_PointCircleUI[] myPointCircles;
    private UITable indicatorContainer;
    private bool 不丗丒上与上丞七丙;
    private HoldPositionsController 一丌丗丂丝丘丁丄丆;
    private bool 丞丐不与专业与专丈;
    private HoldPositions_PointCircleUI 下业一业丟丘与七丅;
    
    // Methods
    private void Start()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        this.一丌丗丂丝丘丁丄丆 = HoldPositionsController.丆丕丝丒不丙且丐丗;
        val_6 = System.Delegate.Combine(a:  HoldPositionsPointsController.__il2cppRuntimeField_fields, b:  new System.Action(object:  this, method:  System.Void HoldPositions_TimerUI::万东丈丛丆丅丝业丒()));
        if(null == 0)
        {
            goto label_5;
        }
        
        if(val_6 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_6 == null)
        {
            goto label_9;
        }
        
        label_6:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_9:
        typeof(HoldPositionsPointsController).__il2cppRuntimeField_80 = val_6;
        this.丞丐不与专业与专丈 = (this.一丌丗丂丝丘丁丄丆.spotLimit > 3) ? 1 : 0;
        this.万东丈丛丆丅丝业丒();
    }
    internal void 世七丂丁丅丟七一丏(HoldPositionsPoint 丅专与丒丈丗丒丘丌)
    {
        UnityEngine.Object val_6;
        if(this.丞丐不与专业与专丈 == false)
        {
                return;
        }
        
        if(this.下业一业丟丘与七丅 == 0)
        {
            goto label_4;
        }
        
        val_6 = this.下业一业丟丘与七丅.gameObject;
        if(val_6 != 0)
        {
            goto label_8;
        }
        
        label_4:
        this.万东丈丛丆丅丝业丒(丌丒丝东丌下丕丁丅:  1, 丄丟丌且七丕丅丗下:  true);
        val_6 = this.myPointCircles;
        this.下业一业丟丘与七丅 = val_6[0];
        label_8:
        if(丅专与丒丈丗丒丘丌 != 0)
        {
                this.下业一业丟丘与七丅.gameObject.SetActive(value:  true);
            this.下业一业丟丘与七丅.myPoint = 丅专与丒丈丗丒丘丌;
            this.下业一业丟丘与七丅.ShowMyPointInfo();
            return;
        }
        
        if(this.myPointCircles.Length == 0)
        {
                return;
        }
        
        this.不丗世丙业丂丂丛七();
    }
    private void Update()
    {
        this.三丙丞且丄上丏丞丟();
    }
    private void 三丙丞且丄上丏丞丟()
    {
        HoldPositions_PointCircleUI[] val_6;
        var val_7;
        val_6 = this.myPointCircles;
        if(val_6 == null)
        {
                return;
        }
        
        if(this.myPointCircles.Length == 0)
        {
                return;
        }
        
        val_7 = 0;
        goto label_3;
        label_27:
        if(this.myPointCircles[0] != 0)
        {
                HoldPositions_PointCircleUI val_7 = this.myPointCircles[0];
            if(this.myPointCircles[0x0][0].myPoint != 0)
        {
                double val_9 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            HoldPositions_PointCircleUI val_8 = this.myPointCircles[0];
            val_9 = val_9 - this.myPointCircles[0x0][0].myPoint.nextPointTime;
            val_9 = val_9 - (double)this.一丌丗丂丝丘丁丄丆.spotSpawnDelay;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.myPointCircles[0], 丏业丟一东丂东丘丛:  (int)val_9 >> 31);
        }
        
        }
        
        val_6 = this.myPointCircles;
        val_7 = 1;
        label_3:
        if(val_7 < this.myPointCircles.Length)
        {
            goto label_27;
        }
    
    }
    private void 不丗世丙业丂丂丛七()
    {
        HoldPositions_PointCircleUI[] val_5;
        var val_6;
        val_5 = this.myPointCircles;
        if(val_5 == null)
        {
                return;
        }
        
        if(this.myPointCircles.Length == 0)
        {
                return;
        }
        
        val_6 = 0;
        goto label_3;
        label_21:
        if(this.myPointCircles[0] != 0)
        {
                if(this.myPointCircles[0].gameObject != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.myPointCircles[0].gameObject);
        }
        
        }
        
        val_5 = this.myPointCircles;
        val_6 = 1;
        label_3:
        if(val_6 < this.myPointCircles.Length)
        {
            goto label_21;
        }
        
        this.myPointCircles = 0;
    }
    private void 万东丈丛丆丅丝业丒()
    {
        if(this.丞丐不与专业与专丈 != false)
        {
                return;
        }
        
        this.万东丈丛丆丅丝业丒(丌丒丝东丌下丕丁丅:  this.一丌丗丂丝丘丁丄丆.spotLimit, 丄丟丌且七丕丅丗下:  false);
    }
    private void 万东丈丛丆丅丝业丒(int 丌丒丝东丌下丕丁丅, bool 丄丟丌且七丕丅丗下 = False)
    {
        HoldPositions_PointCircleUI[] val_5;
        var val_6;
        this.不丗世丙业丂丂丛七();
        val_5 = new HoldPositions_PointCircleUI[0];
        this.myPointCircles = val_5;
        val_6 = 0;
        goto label_1;
        label_24:
        HoldPositions_PointCircleUI val_3 = UnityEngine.Object.Instantiate<HoldPositions_PointCircleUI>(original:  this.pointCircle, parent:  this.indicatorContainer.transform);
        val_3.gameObject.SetActive(value:  true);
        if(丄丟丌且七丕丅丗下 != true)
        {
                val_3.myPoint = this.一丌丗丂丝丘丁丄丆.pointsController.points[this.一丌丗丂丝丘丁丄丆.pointsController.currentPointsIndexes[0]];
            val_3.ShowMyPointInfo();
        }
        
        if(this.myPointCircles == null)
        {
            goto label_17;
        }
        
        if(val_3 != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(val_3 == null)
        {
            goto label_21;
        }
        
        label_18:
        label_21:
        this.myPointCircles[0] = val_3;
        val_5 = this.myPointCircles;
        val_6 = 1;
        label_1:
        if(val_6 < this.myPointCircles.Length)
        {
            goto label_24;
        }
        
        this.不丗丒上与上丞七丙 = true;
    }
    private void LateUpdate()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(this.不丗丒上与上丞七丙 != false)
        {
                if(this.indicatorContainer.gameObject.activeSelf != false)
        {
                this.不丗丒上与上丞七丙 = false;
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_16;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_16;
        }
        
        val_10 = null;
        val_10 = null;
        var val_6 = (丘七业丒丐世丂丅丒() > 0f) ? 1 : 0;
        goto label_21;
        label_16:
        val_11 = 0;
        label_21:
        this.indicatorContainer.gameObject.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        object val_5 = this;
        if(this.一丌丗丂丝丘丁丄丆 == 0)
        {
                return;
        }
        
        val_5 = System.Delegate.Remove(source:  this.一丌丗丂丝丘丁丄丆.pointsController.PointsApplied, value:  new System.Action(object:  this, method:  System.Void HoldPositions_TimerUI::万东丈丛丆丅丝业丒()));
        if(this.一丌丗丂丝丘丁丄丆.pointsController == null)
        {
            goto label_6;
        }
        
        if(val_5 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_5 == null)
        {
            goto label_10;
        }
        
        label_7:
        if(null != null)
        {
                val_5 = 0;
        }
        
        label_10:
        this.一丌丗丂丝丘丁丄丆.pointsController.PointsApplied = val_5;
    }
    public HoldPositions_TimerUI()
    {
    
    }

}
