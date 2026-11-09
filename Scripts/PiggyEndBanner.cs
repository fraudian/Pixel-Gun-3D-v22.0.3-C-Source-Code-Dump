using UnityEngine;
internal sealed class PiggyEndBanner : PGBehaviour
{
    // Fields
    private MiniPoolMonoBehaviour levelSectionViewPool;
    private WidgetLayout levelSectionslayout;
    private ScrollViewHelper scrollHelper;
    private UnityEngine.GameObject purchsaceButtonHolder;
    private UnityEngine.GameObject collectButtonHolder;
    private UILabel levelLabel;
    private UILabel textTopLabel;
    private UILabel textBottomLabel;
    private UnityEngine.GameObject _timerContainer;
    private PGCompany.TimerUI _timerUi;
    private System.Collections.Generic.List<PGCompany.Piggy.PiggyLevelSectionView> 丛丑丘上不丝丏丝专;
    private PGCompany.MainStore.东丆丒丄丂丆上丈业 丑丘丙上丁丌一丗万;
    
    // Methods
    internal void 下与丞三丅丛丄七丕(PGCompany.MainStore.东丆丒丄丂丆上丈业 与不丁且丆万丂丞世)
    {
        this.丑丘丙上丁丌一丗万 = 与不丁且丆万丂丞世;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        if(this.scrollHelper != null)
        {
                this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘一与丆世丅专丗一());
    }
    private System.Collections.IEnumerator 丘一与丆世丅专丗一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PiggyEndBanner.丘丒丈丞三专丒丕丛();
    }
    private void 丝一丅丆三东丂丞七()
    {
        string val_13;
        string val_14;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.purchsaceButtonHolder, 丏业丟一东丂东丘丛:  (~this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐()) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.collectButtonHolder, 丏业丟一东丂东丘丛:  this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10431"), arg0:  this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄()));
        if(this.丑丘丙上丁丌一丗万.丂丕且七丆下丄不丘() != false)
        {
                if(this.丑丘丙上丁丌一丗万.丝一丞不丝上丆丄丅() == false)
        {
            goto label_11;
        }
        
        }
        
        val_13 = "Key_10988";
        goto label_14;
        label_11:
        val_13 = "Key_11152";
        label_14:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.textTopLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_13));
        if(this.丑丘丙上丁丌一丗万.丂且与丈且丁专丟丐() != false)
        {
                val_14 = "Key_10989";
        }
        else
        {
                val_14 = "Key_10990";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.textBottomLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_14));
        this.上丛业丙丙七丒丝丁();
        this.与丅丄丅丂丁丌且丐();
    }
    private void 上丛业丙丙七丒丝丁()
    {
        if(this._timerUi == 0)
        {
                return;
        }
        
        int val_5 = this.丑丘丙上丁丌一丗万.下丒丗丄丌丘不丑丘();
        val_5 = (long)val_5 - PixelTime.丙三丝下丛丈丌丟下();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerContainer, 丏业丟一东丂东丘丛:  (val_5 > 0) ? 1 : 0);
        this._timerUi.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_5, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    private void 与丅丄丅丂丁丌且丐()
    {
        var val_3;
        var val_4;
        if(this.levelSectionViewPool == 0)
        {
                return;
        }
        
        this.丐丆下丒丁丌丛丆世();
        List.Enumerator<T> val_2 = this.丑丘丙上丁丌一丗万.不丌东东丌丞丙专丝.GetEnumerator();
        label_19:
        if(((-427055728) & 1) == 0)
        {
            goto label_6;
        }
        
        if((val_3 != 0) || (val_5.m_stringLength > this.丑丘丙上丁丌一丗万.丈一下下丞世三丑丄()))
        {
            goto label_19;
        }
        
        PGCompany.Piggy.PiggyLevelSectionView val_7 = this.levelSectionViewPool.Get<PGCompany.Piggy.PiggyLevelSectionView>();
        val_7.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  this.丑丘丙上丁丌一丗万, 丈上丁丕世七丝丁丘:  val_4.丐丏七丌丕丗业且上());
        val_7.transform.SetParent(p:  this.levelSectionslayout.transform);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  true);
        this.丛丑丘上不丝丏丝专.Add(item:  val_7);
        goto label_19;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.levelSectionslayout.CollectWidgets();
        this.levelSectionslayout.Reposition();
        UnityEngine.Coroutine val_11 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PiggyEndBanner::且丗与丞丅三世专丌()), 业丗七丕万万不丈丗:  1);
    }
    private void 丐丆下丒丁丌丛丆世()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.levelSectionViewPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丛丑丘上不丝丏丝专.GetEnumerator();
        label_10:
        if(((-426836168) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_2.transform.SetParent(p:  this.levelSectionViewPool.transform);
        this.levelSectionViewPool.Return(万且万且丑丗且丌丆:  val_2);
        goto label_10;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛丑丘上不丝丏丝专.Clear();
    }
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>> 丟丛丁丅丐与东东且(System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 上业丟世三与七七三)
    {
        var val_4;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>>();
        if(上业丟世三与七七三 == null)
        {
                return val_1;
        }
        
        List.Enumerator<T> val_2 = 上业丟世三与七七三.GetEnumerator();
        label_9:
        if(((-426660720) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5 == null)
        {
            goto label_9;
        }
        
        string val_6 = val_5 + 32;
        if((val_1.ContainsKey(key:  val_6)) != true)
        {
                System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_8 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            val_1.set_Item(key:  val_6, value:  null);
        }
        
        val_1.Item[val_6].Add(item:  val_5);
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public PiggyEndBanner()
    {
        this.丛丑丘上不丝丏丝专 = new System.Collections.Generic.List<PGCompany.Piggy.PiggyLevelSectionView>();
    }
    private void 且丗与丞丅三世专丌()
    {
        if(this == 0)
        {
                return;
        }
        
        if(this.levelSectionslayout == 0)
        {
                return;
        }
        
        this.levelSectionslayout.Reposition();
    }

}
