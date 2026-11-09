using UnityEngine;
private sealed class GameEventSetsViewChestContentField.丒丆业且下七不丅丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 不丐丐东东丁与且下;
    public Rilisoft.GameEventSetsViewChestContentField 丝且与丝丒丟万丁专;
    private Rilisoft.GameEventSetsViewChestContentField.且上且专丗一丛专丑 丄丌丂东丘丗一万且;
    private Rilisoft.GameEventSetsViewChestContentField.东丌业万丁丗一下丞 一专丘丕与丑丙丗与;
    public System.Action 丟丘丙丄丅万丏与丗;
    private Rilisoft.GameEventItemContainer 世丘丗丁丕丁丙丒丐;
    private int 丒世三万丄丒丄万丞;
    private int 与一上业丌不丏丒丗;
    private Rilisoft.GameEventSetItemView 七一丟丛丅专下丕丏;
    private int 丟东东丑且丐与丑丅;
    private System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 一丅万丒丛丈丏丐万;
    private Rilisoft.GameEventItemContainer 丏丏丏丌万一丄东三;
    private Rilisoft.GameEventSetItemView 丗业且业丁丝丅丏丁;
    private int 丟丗不不丕与下丛丐;
    private UnityEngine.WaitForSecondsRealtime 上一七下丝丒万丒丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventSetsViewChestContentField.丒丆业且下七不丅丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_114;
        System.Collections.Generic.IEnumerable<TSource> val_116;
        UnityEngine.WaitForSecondsRealtime val_119;
        var val_120;
        bool val_124;
        int val_127;
        int val_128;
        int val_129;
        var val_130;
        System.Collections.IEnumerator val_131;
        val_114 = this;
        if(this.丗丏丅丕丆世丁专丟 > 8)
        {
            goto label_71;
        }
        
        var val_113 = 106048424 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_113 = val_113 + 106048424;
        goto (106048424 + (this.丗丏丅丕丆世丁专丟) << 2 + 106048424);
        label_71:
        val_124 = 0;
        return (bool)val_124;
        label_127:
        val_130 = 0.丂丄丘专丈业三且丛();
        goto label_114;
        label_121:
        Rilisoft.GameEventSetItemView val_74 = this.丗业且业丁丝丅丏丁.丂丄丘专丈业三且丛().Item[null];
        if( <= (this.一丅万丒丛丈丏丐万.Count - 1))
        {
            goto label_118;
        }
        
        val_127 =  + 1;
        mem2[0] = val_127;
        if(val_127 < this.丗业且业丁丝丅丏丁.丂丄丘专丈业三且丛().Count)
        {
            goto label_121;
        }
        
        if(this.丗业且业丁丝丅丏丁 != 0)
        {
                if(this.丏丏丏丌万一丄东三.ContentType != 3)
        {
            goto label_126;
        }
        
        }
        
        if(this.丗业且业丁丝丅丏丁 == null)
        {
            goto label_127;
        }
        
        val_130 = this.丗业且业丁丝丅丏丁.丂丄丘专丈业三且丛();
        label_114:
        val_116 = this.丗业且业丁丝丅丏丁.丂丄丘专丈业三且丛();
        int val_85 = val_130.IndexOf(item:  System.Linq.Enumerable.First<Rilisoft.GameEventSetItemView>(source:  val_116, predicate:  new System.Func<Rilisoft.GameEventSetItemView, System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean GameEventSetsViewChestContentField.且上且专丗一丛专丑::一下不下专丙且丝万(Rilisoft.GameEventSetItemView 业下丌下三丕丙丌下))));
        if(this.丗业且业丁丝丅丏丁 == null)
        {
            goto label_129;
        }
        
        val_131 = this.丗业且业丁丝丅丏丁.丛丒丝下业丐丝上七(丗丏丑丁万东丆丝丝:  0, 专丌丏世丐丛丗丝丂:  val_85, 丅与丅丝丈世丑丐丗:  true);
        goto label_130;
        label_118:
        Rilisoft.GameEventItemContainer val_87 = this.一丅万丒丛丈丏丐万.Item[null];
        if(val_87.AvailableToDropItems.Count == 0)
        {
            goto label_134;
        }
        
        System.Collections.Generic.List<System.Int32> val_90 = this.丗业且业丁丝丅丏丁.丁且且丐不丝丐下丘();
        if((val_90.Contains(item:  val_87.Id)) == false)
        {
            goto label_139;
        }
        
        label_134:
        if(val_87 != null)
        {
            goto label_168;
        }
        
        label_169:
        label_168:
        Rilisoft.GameEventItem val_94 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_87.AllItems);
        int val_95 = val_87.Id;
        var val_97 = (val_87.ContentType == 3) ? 1 : 0;
        val_74.PlayItemChangeAnimation();
        val_116 = 1152921504615686144;
        System.Action<Rilisoft.GameEventSetItemView> val_98 = null;
        val_129 = 1152921542747136624;
        val_98 = new System.Action<Rilisoft.GameEventSetItemView>(object:  this.丗业且业丁丝丅丏丁, method:  System.Void Rilisoft.GameEventSetsViewChestContentField::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟));
        val_74.remove_Clicked(丙业与丙丗丝不丈东:  val_98);
        val_74.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventSetItemView>(object:  this.丗业且业丁丝丅丏丁, method:  System.Void Rilisoft.GameEventSetsViewChestContentField::丗业与丐与一世丝丌(Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟)));
        GameEventsHalper val_100 = GameEventsHalper.Instance;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  val_100.animation.diceLapBlink);
        val_128 = 4;
        goto label_146;
        label_129:
        val_131 = 0.丛丒丝下业丐丝上七(丗丏丑丁万东丆丝丝:  0, 专丌丏世丐丛丗丝丂:  val_85, 丅与丅丝丈世丑丐丗:  true);
        label_130:
        this.丒上七丌业七丟与丐 = this.丗业且业丁丝丅丏丁.StartCoroutine(routine:  val_131);
        val_128 = 8;
        label_146:
        this.丗丏丅丕丆世丁专丟 = val_128;
        goto label_147;
        label_126:
        this.上一七下丝丒万丒丐 = new UnityEngine.WaitForSecondsRealtime(time:  0.07f);
        mem2[0] = 0;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.丗业且业丁丝丅丏丁._gemsIndicator != 0)
        {
                UnityEngine.AudioSource val_107 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丗业且业丁丝丅丏丁._gemsIndicator);
        }
        
        }
        
        val_119 = this.上一七下丝丒万丒丐;
        val_120 = 5;
        this.丗丏丅丕丆世丁专丟 = 5;
        this.丒上七丌业七丟与丐 = val_119;
        label_147:
        val_124 = 1;
        return (bool)val_124;
        label_139:
        if((null != 1) || ((val_90.Contains(item:  val_87.Id)) == false))
        {
            goto label_162;
        }
        
        if(val_87 != null)
        {
            goto label_168;
        }
        
        goto label_169;
        label_162:
        System.Collections.Generic.List<System.Int32> val_117 = this.丗业且业丁丝丅丏丁.万丐丘丟丂丛丂丈万();
        val_117 = val_117.Contains(item:  val_87.Id);
        if(val_87 != null)
        {
            goto label_168;
        }
        
        goto label_169;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
