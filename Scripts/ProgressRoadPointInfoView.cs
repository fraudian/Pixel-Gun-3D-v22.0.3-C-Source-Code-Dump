using UnityEngine;
internal sealed class ProgressRoadPointInfoView : PGBehaviour
{
    // Fields
    private static System.Action 丟不丒万丝与丂上丘;
    private UILabel headerLabel;
    private ProgressRoadPointNewItemsView itemsView;
    private ProgressRoadPointNewContentView contentView;
    private ProgressRoadPointRewardsView rewardsView;
    private WidgetLayout contentViewsLayout;
    private ScrollViewHelper weaponsScroll;
    private System.Collections.Generic.List<ScrollViewHelper> scrollHelpers;
    private string lockedHeaderKey;
    private string unlockedHeaderKey;
    private float stepDelay;
    private System.Collections.Generic.List<ProgressRoadPointInfoView.ScaleSettings> scaleSettings;
    private System.Collections.Generic.List<ProgressRoadPointInfoView.ScaleSettings> scaleSettingsModes;
    private System.IDisposable 与丅世与丄丑丌丞东;
    private UnityEngine.Coroutine 下丝丅丄丕丞丗丌丒;
    
    // Methods
    internal static void 丘丌世专丌专丕丂丅(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ProgressRoadPointInfoView.丟不丒万丝与丂上丘, b:  丙业与丙丗丝不丈东);
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
    internal static void 不丛丛丌上丕丏专三(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ProgressRoadPointInfoView.丟不丒万丝与丂上丘, value:  丙业与丙丗丝不丈东);
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
    private void OnEnable()
    {
        this.与丅世与丄丑丌丞东 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ProgressRoadPointInfoView::Hide()), 与且专丈不万东一万:  "ProgressRoadPointInfoView_" + this.gameObject.name);
    }
    private void OnDisable()
    {
        if(this.与丅世与丄丑丌丞东 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.与丅世与丄丑丌丞东.Dispose();
        }
        
        丌东一万丗上丝丌三.丌丛东不丝三丒丌丅(丒丘丏上丙丟丑丕丈:  "PRPI_fill_new_content");
    }
    public void Show(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈, bool 且丁丐丑丞丐七丙与)
    {
        System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> val_1 = new System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一>();
        val_1.Add(item:  东东丗丅与一下丄丈);
        this.Show(三丒不不一七东丕业:  val_1, 且丁丐丑丞丐七丙与:  且丁丐丑丞丐七丙与);
    }
    public void Show(System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业, bool 且丁丐丑丞丐七丙与)
    {
        var val_4;
        var val_20;
        var val_22;
        if(三丒不不一七东丕业 == null)
        {
                return;
        }
        
        if(三丒不不一七东丕业.Count == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = 三丒不不一七东丕业.GetEnumerator();
        label_4:
        if(((-189992384) & 1) == 0)
        {
            goto label_3;
        }
        
        if(val_4.丐丏七丌丕丗业且上() != null)
        {
            goto label_4;
        }
        
        val_20 = 263;
        goto label_5;
        label_3:
        val_20 = 60;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_20 == 263)
        {
                return;
        }
        
        var val_6 = (val_20 == 60) ? -1 : 0;
        List.Enumerator<T> val_7 = this.scrollHelpers.GetEnumerator();
        label_13:
        if(((-189992416) & 1) == 0)
        {
            goto label_11;
        }
        
        val_4.丐丏七丌丕丗业且上().ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        goto label_13;
        label_11:
        val_22 = 0;
        mem2[0] = 112;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((0 + 1) == 1)
        {
            goto label_17;
        }
        
        if(( == 0) || ((1152921538776592880 + ((0 + 1)) << 2) == 112))
        {
            goto label_32;
        }
        
        label_31:
        label_32:
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        this.itemsView.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        this.contentView.transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        this.rewardsView.transform.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemsView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.contentView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardsView, 丏业丟一东丂东丘丛:  false);
        if(this.下丝丅丄丕丞丗丌丒 != null)
        {
                this.StopCoroutine(routine:  this.下丝丅丄丕丞丗丌丒);
        }
        
        this.下丝丅丄丕丞丗丌丒 = this.StartCoroutine(routine:  this.一不丅丞丏丟丕丆世(三丒不不一七东丕业:  三丒不不一七东丕业, 且丁丐丑丞丐七丙与:  且丁丐丑丞丐七丙与));
        return;
        label_17:
        if( != 0)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    private System.Collections.IEnumerator 一不丅丞丏丟丕丆世(System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业, bool 且丁丐丑丞丐七丙与)
    {
        ProgressRoadPointInfoView.丛丈丆丅丈世丈丈丅 val_1 = new ProgressRoadPointInfoView.丛丈丆丅丈世丈丈丅();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .三丒不不一七东丕业 = 三丒不不一七东丕业;
            .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
            mem[32] = 三丒不不一七东丕业;
        }
        
        .且丁丐丑丞丐七丙与 = 且丁丐丑丞丐七丙与;
        return (System.Collections.IEnumerator)val_1;
    }
    public void Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        if(ProgressRoadPointInfoView.丟不丒万丝与丂上丘 == null)
        {
                return;
        }
        
        ProgressRoadPointInfoView.丟不丒万丝与丂上丘.Invoke();
    }
    private void 丟丟下东东业一丒丐(System.Collections.Generic.List<ProgressRoadPointInfoView.ScaleSettings> 丒丙丒丈上丌三与一, UnityEngine.Transform 万一专丐丄丐丗丒丏, int 丌丒丝东丌下丕丁丅)
    {
        var val_3;
        List.Enumerator<T> val_1 = 丒丙丒丈上丌三与一.GetEnumerator();
        label_13:
        if(((-189529392) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4.m_stringLength != 丌丒丝东丌下丕丁丅)
        {
            goto label_13;
        }
        
        val_3 = 0;
        万一专丐丄丐丗丒丏.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_8 = 万一专丐丄丐丗丒丏.transform.localPosition;
        UnityEngine.Vector3 val_10 = 万一专丐丄丐丗丒丏.transform.localPosition;
        万一专丐丄丐丗丒丏.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_13;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ProgressRoadPointInfoView()
    {
        this.stepDelay = 0.1f;
    }

}
