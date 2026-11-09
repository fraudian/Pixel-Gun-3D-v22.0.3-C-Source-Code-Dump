using UnityEngine;
internal sealed class ProgressRoadPointView : EndlessScrollCellDynamic
{
    // Fields
    private static System.Action<ProgressRoadPointView> 一丅三丙专丌三丅丁;
    internal UnityEngine.GameObject holder;
    private UnityEngine.GameObject mainUI_Holder;
    private UnityEngine.GameObject brogressBarUI_Holder;
    private int normalWidth;
    private int noBarAdditionalWidth;
    private int normalEdgePos;
    private int veteranEdgePos;
    private ProgressRoadPointLevelView levelView;
    private UnityEngine.GameObject newLevelView;
    private ProgressRoadPointNewContentView contentView;
    private ProgressRoadPointNewItemsView itemsView;
    private ProgressRoadPointRewardsView rewardsView;
    private UnityEngine.GameObject veteranChestPoint;
    private PGCompany.InventoryItemView veteranLootBoxView;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfContainNewItems;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfContainRewards;
    private WidgetLayout contentViewsLayout;
    private ProgressRoadView roadView;
    private UILabel summXpLabel;
    private SimpleProgressBarWithAnimation brogressBar;
    private BarFillPoint barFillPoint;
    private UILabel addedProgressLabel;
    private SimpleTweenePlayer chekmarkAnimation;
    private SimpleTweenePlayer reachedAnimation;
    internal UnityEngine.Transform edgePoint;
    internal UnityEngine.Transform centerPoint;
    private PGPlaySound reachedSound;
    private PGPlaySound reachedLevelSound;
    public UnityEngine.Transform progressBarPointer;
    public System.Collections.Generic.List<UnityEngine.GameObject> enableOnAnimation;
    private bool 丅丐一丒一东丒上丂;
    private ProgressRoad.丅丂丅丕下丑丘万一 丘三丌丐丒丒七丑东;
    
    // Properties
    public bool 丞东丟东丂丈丈三丁 { get; }
    public int 丆专丙下丑不丛下丈 { get; }
    public ProgressRoad.丅丂丅丕下丑丘万一 丙丒丈不丆下世东业 { get; }
    
    // Methods
    internal static void 丂丗丗丙专丑且丙丁(System.Action<ProgressRoadPointView> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ProgressRoadPointView.一丅三丙专丌三丅丁, b:  丙业与丙丗丝不丈东);
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
    internal static void 万丑专一丟世丑业丛(System.Action<ProgressRoadPointView> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ProgressRoadPointView.一丅三丙专丌三丅丁, value:  丙业与丙丗丝不丈东);
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
    public bool get_BarAnimationInProgress()
    {
        return (bool)this.丅丐一丒一东丒上丂;
    }
    public int get_AnimatedProgress()
    {
        var val_3;
        int val_4;
        if(this.丘三丌丐丒丒七丑东 != null)
        {
                val_3 = this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄;
            val_4 = (int)UnityEngine.Mathf.Lerp(a:  (float)val_3, b:  (float)this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七, t:  this.brogressBar.AnimatedFillValue);
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }
    public ProgressRoad.丅丂丅丕下丑丘万一 get_PointData()
    {
        return (ProgressRoad.丅丂丅丕下丑丘万一)this.丘三丌丐丒丒七丑东;
    }
    private void OnEnable()
    {
        System.Delegate val_4 = System.Delegate.Combine(a:  this.brogressBar.世丅丙世不三丈世丅, b:  new System.Action(object:  this, method:  System.Void ProgressRoadPointView::东丞与不东丟丁丅丒()));
        if(this.brogressBar == null)
        {
            goto label_2;
        }
        
        if(val_4 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_4 = 0;
        }
        
        label_6:
        this.brogressBar.世丅丙世不三丈世丅 = val_4;
    }
    private void OnDisable()
    {
        System.Delegate val_4 = System.Delegate.Remove(source:  this.brogressBar.世丅丙世不三丈世丅, value:  new System.Action(object:  this, method:  System.Void ProgressRoadPointView::东丞与不东丟丁丅丒()));
        if(this.brogressBar == null)
        {
            goto label_2;
        }
        
        if(val_4 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_4 = 0;
        }
        
        label_6:
        this.brogressBar.世丅丙世不三丈世丅 = val_4;
    }
    internal void 丈且东丑丂且万丒丅(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈)
    {
        if(东东丗丅与一下丄丈 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  true);
            this.丘三丌丐丒丒七丑东 = 东东丗丅与一下丄丈;
            this.brogressBar.initialValue = 东东丗丅与一下丄丈.丈丄丂下丒专丌丛丄;
            this.丅丐一丒一东丒上丂 = false;
            int val_2 = ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.丟专丝丝丗下世丑不;
            val_2 = val_2 - (ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.万七丏业丟丗丙东不);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.addedProgressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "+{0}", arg0:  val_2));
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnAnimation, 丏业丟一东丂东丘丛:  false);
            this.丝一丅丆三东丂丞七();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丝一丅丆三东丂丞七()
    {
        int val_14;
        UnityEngine.Transform val_15;
        var val_16;
        ProgressRoad.丅丂丅丕下丑丘万一 val_17;
        var val_18;
        var val_19;
        int val_20;
        if(this.levelView != null)
        {
                this.levelView.丈且东丑丂且万丒丅(东东丗丅与一下丄丈:  this.丘三丌丐丒丒七丑东);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newLevelView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardsView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.contentView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemsView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.veteranChestPoint, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfContainNewItems, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfContainRewards, 丏业丟一东丂东丘丛:  false);
        if(this.丘三丌丐丒丒七丑东.丁丝丒七一一下不丆.Count >= 1)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfContainNewItems, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.丘三丌丐丒丒七丑东.一万丏丂丅丄丑且丂 == 0)
        {
            goto label_10;
        }
        
        if(this.丘三丌丐丒丒七丑东.丕丁丅业世上丁丘丆.Count < 1)
        {
            goto label_13;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.contentView, 丏业丟一东丂东丘丛:  true);
        if(this.contentView == null)
        {
            goto label_86;
        }
        
        this.contentView.丈且东丑丂且万丒丅(东东丗丅与一下丄丈:  this.丘三丌丐丒丒七丑东, 丕丕世且下一与丝与:  0f);
        goto label_86;
        label_10:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfContainRewards, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newLevelView, 丏业丟一东丂东丘丛:  true);
        label_86:
        if(this.contentViewsLayout != 0)
        {
                this.contentViewsLayout.Reposition();
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.summXpLabel, 丕丗丘丑丛与丑业丒:  专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄));
        UnityEngine.Transform val_5 = this.brogressBarUI_Holder.transform;
        if(this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七 >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_5, 丏业丟一东丂东丘丛:  true);
            val_5.width = this.normalWidth;
            val_14 = this.normalEdgePos;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_5, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.veteranChestPoint, 丏业丟一东丂东丘丛:  true);
            PGCompany.VeteranChest.丐丂丄丗业业丘下丕 val_6 = PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世();
            if(this.veteranLootBoxView != null)
        {
                this.veteranLootBoxView.Setup(丈丄不七三万丄丁不:  val_6.丝丁丝上丞丅三丑七());
        }
        
            float val_14 = 0.5f;
            val_14 = this.roadView.sizePanel.width * val_14;
            val_6.width = this.noBarAdditionalWidth + (int)val_14;
            val_14 = this.veteranEdgePos;
        }
        
        this.edgePoint.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Transform val_10 = this.mainUI_Holder.transform;
        if(this.丘三丌丐丒丒七丑东.丘丈不不下丙万丌专 < 2)
        {
                val_15 = val_10;
            val_16 = 0;
        }
        else
        {
                val_16 = 1;
            val_15 = val_10;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_15, 丏业丟一东丂东丘丛:  true);
        this.UpdateRects();
        if(this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七 < 1)
        {
            goto label_57;
        }
        
        val_17 = this.丘三丌丐丒丒七丑东;
        if((ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.丑上上丗丌专业丈与) <= this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄)
        {
            goto label_57;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_15 = this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄;
        Rilisoft.丝丑丂丛万丐丈丘且 val_16 = this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄;
        val_15 = (ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.丑上上丗丌专业丈与) - val_15;
        val_16 = (ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.丑上上丗丌专业丈与) - val_16;
        Rilisoft.丝丑丂丛万丐丈丘且 val_17 = this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七;
        val_17 = this.brogressBar;
        val_17 = val_17 - this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄;
        val_18 = val_15;
        val_19 = val_16;
        val_20 = val_17;
        goto label_67;
        label_57:
        val_18 = 0;
        val_19 = 0;
        val_20 = this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七;
        label_67:
        this.brogressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  0, 丑丒丒丅七丞东丟丕:  0, 七丝东丛东丝且丆不:  val_20, 丈世万丙丟东与丕丞:  false);
        if((ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.丑上上丗丌专业丈与) < this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄)
        {
                this.reachedAnimation.SetInitial();
            this.chekmarkAnimation.SetInitial();
        }
        else
        {
                this.reachedAnimation.SetFinal();
            this.chekmarkAnimation.SetFinal();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.progressBarPointer, 丏业丟一东丂东丘丛:  this.Selected);
        return;
        label_13:
        if(this.丘三丌丐丒丒七丑东.下丐丐丁与丂下世七.Count < 1)
        {
            goto label_86;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardsView, 丏业丟一东丂东丘丛:  true);
        if(this.rewardsView == null)
        {
            goto label_86;
        }
        
        this.rewardsView.丈且东丑丂且万丒丅(东东丗丅与一下丄丈:  this.丘三丌丐丒丒七丑东);
        goto label_86;
    }
    public override void OnSelectStateUpdate()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.progressBarPointer, 丏业丟一东丂东丘丛:  this.Selected);
    }
    public void U_ShowPointInfo()
    {
        if(this.roadView.万丝专丌丌三丟丆丄 != false)
        {
                return;
        }
        
        this.roadView.ShowPointInfo(东东丗丅与一下丄丈:  this.丘三丌丐丒丒七丑东);
    }
    public void AnimateProgressTo(int 丑业丕丒专丆丟专丞, float 丟丆七丌丄丒且世丂)
    {
        if(this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七 >= 1)
        {
                this.丘三丌丐丒丒七丑东 = this.丘三丌丐丒丒七丑东;
            if(this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄 < 丑业丕丒专丆丟专丞)
        {
                int val_4 = UnityEngine.Mathf.Min(a:  this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七, b:  丑业丕丒专丆丟专丞);
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄;
            val_3 = (ProgressRoadView.<不丁丄七丛不丆丁丕>k__BackingField.丑上上丗丌专业丈与) - val_3;
            val_4 = val_4 - this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄;
            this.brogressBar.animationSpeed = 丟丆七丌丄丒且世丂;
            this.brogressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  val_3, 丑丒丒丅七丞东丟丕:  val_4, 七丝东丛东丝且丆不:  this.丘三丌丐丒丒七丑东.万丝丙与丂丄且丘七 - this.丘三丌丐丒丒七丑东.丈丄丂下丒专丌丛丄, 丈世万丙丟东与丕丞:  true);
            this.丅丐一丒一东丒上丂 = true;
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnAnimation, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        }
        
        this.东丞与不东丟丁丅丒();
    }
    private void 东丞与不东丟丁丅丒()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnAnimation, 丏业丟一东丂东丘丛:  false);
        this.丅丐一丒一东丒上丂 = false;
        if(ProgressRoadPointView.一丅三丙专丌三丅丁 == null)
        {
                return;
        }
        
        ProgressRoadPointView.一丅三丙专丌三丅丁.Invoke(obj:  this);
    }
    public void OnReachPoint()
    {
        this.barFillPoint.丁丏下东七丙丏丗丘(丙业与丙丗丝不丈东:  0f);
    }
    public void PlayReachedAnimation()
    {
        this.reachedAnimation.Play();
        this.chekmarkAnimation.Play();
        if(this.丘三丌丐丒丒七丑东.一万丏丂丅丄丑且丂 != 0)
        {
                this = this.reachedSound;
            if(this != null)
        {
            goto label_5;
        }
        
        }
        else
        {
                if(this.reachedLevelSound == null)
        {
                return;
        }
        
        }
        
        label_5:
        this.reachedLevelSound.三且世三丂七丐一丟(丌丏丂与丂三丐一下:  0);
    }
    public float GetDistanceToEndge()
    {
        UnityEngine.Vector3 val_1 = this.edgePoint.position;
        UnityEngine.Vector3 val_3 = X20 + 104 + 112.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = X20 + 104 + 56, y = 0f, z = X20 + 104 + 64});
        UnityEngine.Vector3 val_5 = this.newLevelView.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = 0f, z = val_1.z});
        val_5.x = val_3.x - val_5.x;
        return (float)val_5.x;
    }
    public void U_ShowVeteranHintPanel()
    {
        if(this.roadView.veteranHintPanel == null)
        {
            
        }
    
    }
    public ProgressRoadPointView()
    {
        this.noBarAdditionalWidth = 300;
        this.normalEdgePos = 145;
        this.veteranEdgePos = 513;
    }

}
