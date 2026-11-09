using UnityEngine;
internal sealed class ProgressRoadPointNewContentView : PGBehaviour
{
    // Fields
    private UILabel countLabel;
    private UnityEngine.GameObject moreLabel;
    private PGContentView newContentView;
    private bool showFirstOnly;
    private MiniPoolMonoBehaviour newContentPool;
    private WidgetLayout newContentLayout;
    private WidgetLayoutDelayed widgetLayoutDelayed;
    private System.Collections.Generic.List<PGContentView> 丗丁东且上东丟世丙;
    private System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 上丟丆上业一专且丁;
    
    // Properties
    internal int 丙丞上丂丆丌丝丅一 { get; }
    
    // Methods
    internal int 三丙丆上丘专丟丝丑()
    {
        if(this.gameObject.activeSelf == false)
        {
                return 0;
        }
        
        if(this.丗丁东且上东丟世丙 != null)
        {
                return this.丗丁东且上东丟世丙.Count;
        }
        
        return this.丗丁东且上东丟世丙.Count;
    }
    internal void 丈且东丑丂且万丒丅(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈, float 丕丕世且下一与丝与 = 0)
    {
        System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> val_1 = new System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一>();
        val_1.Add(item:  东东丗丅与一下丄丈);
        this.丈且东丑丂且万丒丅(三丒不不一七东丕业:  val_1, 丕丕世且下一与丝与:  丕丕世且下一与丝与);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业, float 丕丕世且下一与丝与 = 0)
    {
        int val_4;
        var val_21;
        UnityEngine.GameObject val_22;
        this.上丟丆上业一专且丁 = 三丒不不一七东丕业;
        System.Collections.Generic.List<ExpOpenSystem.丒上丂丑丐不丂丐且> val_1 = new System.Collections.Generic.List<ExpOpenSystem.丒上丂丑丐不丂丐且>();
        List.Enumerator<T> val_2 = this.上丟丆上业一专且丁.GetEnumerator();
        val_21 = 1152921538776509424;
        label_5:
        if(((-187615424) & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.AddRange(collection:  val_4.丐丏七丌丕丗业且上());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  (val_1.Count > 0) ? 1 : 0);
        val_22 = this.gameObject;
        if(val_22.activeSelf == false)
        {
                return;
        }
        
        val_21 = 1152921504622075904;
        val_4 = val_1.Count;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_4);
        val_22 = this.moreLabel;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_22, 丏业丟一东丂东丘丛:  (val_1.Count > 1) ? 1 : 0);
        ExpOpenSystem.丒上丂丑丐不丂丐且 val_14 = System.Linq.Enumerable.FirstOrDefault<ExpOpenSystem.丒上丂丑丐不丂丐且>(source:  val_1);
        if((val_14 != null) && (this.newContentView != null))
        {
                this.newContentView.丈且东丑丂且万丒丅(丕丈下丁丑丂丗丒业:  val_14, 丙丒七且世丂不丕丄:  "progress.road");
        }
        
        if(this.newContentPool == 0)
        {
                return;
        }
        
        this.世业丒万丘丆专丘丐();
        if(丕丕世且下一与丝与 > 0f)
        {
                ProgressRoad.丅丂丅丕下丑丘万一 val_16 = this.上丟丆上业一专且丁.Item[0];
            val_4 = val_16.丈丄丂下丒专丌丛丄;
            System.Action val_19 = null;
            val_22 = val_19;
            val_19 = new System.Action(object:  this, method:  System.Void ProgressRoadPointNewContentView::丂三丂七七丏丞丄丙());
            一丛丟世丗丈丘丏万 val_20 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "{0}_{1}_PRPI_fill_new_content", arg0:  val_4, arg1:  this.newContentPool.example.name), 丘丁三丅丆与丆业业:  丕丕世且下一与丝与, 七丐丅专且专七三丆:  val_19);
            return;
        }
        
        this.上东与丛丞下丈专丈(三丒不不一七东丕业:  0);
    }
    private void 上东与丛丞下丈专丈(System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业)
    {
        var val_4;
        System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> val_10;
        System.Collections.Generic.List<ExpOpenSystem.丒上丂丑丐不丂丐且> val_1 = new System.Collections.Generic.List<ExpOpenSystem.丒上丂丑丐不丂丐且>();
        val_10 = this.上丟丆上业一专且丁;
        List.Enumerator<T> val_2 = val_10.GetEnumerator();
        label_5:
        if(((-187366224) & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.AddRange(collection:  val_4.丐丏七丌丕丗业且上());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_6 = val_1.GetEnumerator();
        label_22:
        if(((-187366256) & 1) == 0)
        {
            goto label_13;
        }
        
        string val_7 = val_4.丐丏七丌丕丗业且上();
        if((val_7 == null) || ((System.String.IsNullOrEmpty(value:  val_7.m_stringLength)) == true))
        {
            goto label_22;
        }
        
        PGContentView val_9 = this.newContentPool.Get<PGContentView>();
        this.丗丁东且上东丟世丙.Add(item:  val_9);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9, 丏业丟一东丂东丘丛:  true);
        val_9.丈且东丑丂且万丒丅(丕丈下丁丑丂丗丒业:  val_7, 丙丒七且世丂不丕丄:  "progress.road");
        this.newContentLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_9);
        goto label_22;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.newContentLayout.Reposition();
        if(this.widgetLayoutDelayed == null)
        {
                return;
        }
        
        this.widgetLayoutDelayed.Animate();
    }
    private void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.newContentPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丗丁东且上东丟世丙.GetEnumerator();
        label_7:
        if(((-187175336) & 1) == 0)
        {
            goto label_5;
        }
        
        this.newContentPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丗丁东且上东丟世丙.Clear();
        this.newContentLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
    }
    public ProgressRoadPointNewContentView()
    {
        this.丗丁东且上东丟世丙 = new System.Collections.Generic.List<PGContentView>();
    }
    private void 丂三丂七七丏丞丄丙()
    {
        if(this == 0)
        {
                return;
        }
        
        this.上东与丛丞下丈专丈(三丒不不一七东丕业:  0);
    }

}
