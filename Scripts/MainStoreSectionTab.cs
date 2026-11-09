using UnityEngine;
internal sealed class MainStoreSectionTab : SelectableButtonController
{
    // Fields
    public MainStoreView mainStoreView;
    private MiniPoolMonoBehaviour sectionButtonPool;
    private bool 丒丂丏且上丌下丙丙;
    public MainStoreSectionTabSelectButton _highlighted;
    private PGCompany.MainStore.世专丟丕丝丝专东一 一丒专丘丂丐下且不;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.MainStore.丐丑丂上丑丑东丒丞> 业丝丅专丟世一丁七)
    {
        this.上东与丛丞下丈专丈(业丝丅专丟世一丁七:  业丝丅专丟世一丁七);
    }
    private void 上东与丛丞下丈专丈(System.Collections.Generic.List<PGCompany.MainStore.丐丑丂上丑丑东丒丞> 业丝丅专丟世一丁七)
    {
        var val_3;
        this.世业丒万丘丆专丘丐();
        List.Enumerator<T> val_1 = 业丝丅专丟世一丁七.GetEnumerator();
        label_7:
        if((292302176 & 1) == 0)
        {
            goto label_2;
        }
        
        MainStoreSectionTabSelectButton val_5 = this.sectionButtonPool.Get<MainStoreSectionTabSelectButton>();
        this.AddNewButton(丟丂丄丕下业丗丛丂:  val_5);
        val_5.丈且东丑丂且万丒丅(东东三丂丌世丌丁不:  val_3.丐丏七丌丕丗业且上());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_3.Reposition();
        if(this.丒丂丏且上丌下丙丙 == false)
        {
                return;
        }
        
        this.丒丂丏且上丌下丙丙 = false;
        UnityEngine.Coroutine val_7 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void MainStoreSectionTab::三专业七一专丆丏万()));
    }
    internal void 世业丒万丘丆专丘丐()
    {
        var val_3;
        UnityEngine.MonoBehaviour val_5;
        this._highlighted = 0;
        this.一丒专丘丂丐下且不 = 0;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_6:
        if((292446960 & 1) == 0)
        {
            goto label_2;
        }
        
        val_5 = val_3.丐丏七丌丕丗业且上();
        if(val_5 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_5 = 0;
        label_4:
        val_5.丒丙丑丝专丛丞丒丒(丙业与丙丗丝不丈东:  false);
        this.sectionButtonPool.Return(万且万且丑丗且丌丆:  val_5);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        Clear();
        mem[1152921539259044472] = 0;
    }
    public void OnScrollSmooothEnded()
    {
        if(this._highlighted == 0)
        {
                return;
        }
        
        this._highlighted = 0;
        this.丁丂业丏七丁丏且丌(丞且丌三三万七丛万:  this.一丒专丘丂丐下且不);
    }
    public override bool SelectButton(SelectableButton 丕丐不丑三上万丝东)
    {
        var val_4;
        SelectableButton val_11;
        var val_12;
        UnityEngine.Object val_13;
        val_11 = 丕丐不丑三上万丝东;
        bool val_1 = this.SelectButton(丕丐不丑三上万丝东:  val_11);
        if(val_1 == false)
        {
            goto label_21;
        }
        
        if(val_11 != null)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_12 = this;
        this._highlighted = 0;
        val_11 = 0;
        goto label_4;
        label_3:
        val_12 = this;
        this._highlighted = val_11;
        label_4:
        val_11.丒丙丑丝专丛丞丒丒(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_2 = val_11.GetEnumerator();
        label_13:
        if((292712912 & 1) == 0)
        {
            goto label_6;
        }
        
        val_13 = val_4.丐丏七丌丕丗业且上();
        if((val_13 != null) && (null != null))
        {
                val_13 = 0;
        }
        
        if(val_13 == this._highlighted)
        {
            goto label_13;
        }
        
        val_13.丒丙丑丝专丛丞丒丒(丙业与丙丗丝不丈东:  false);
        goto label_13;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_21:
        Reposition();
        UnityEngine.Coroutine val_8 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void MainStoreSectionTab::丞丏七丛丁丁丐不丘()));
        return val_1;
    }
    internal void 丁丂业丏七丁丏且丌(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万)
    {
        var val_6;
        MainStoreSectionTabSelectButton val_12;
        var val_13;
        if(丞且丌三三万七丛万 == null)
        {
                return;
        }
        
        this.一丒专丘丂丐下且不 = 丞且丌三三万七丛万;
        if(this._highlighted != 0)
        {
                if((this._highlighted.丆一专丌上专丌东丁(丞且丌三三万七丛万:  丞且丌三三万七丛万)) != false)
        {
                this._highlighted = 0;
        }
        
        }
        
        val_12 = this._highlighted;
        if(val_12 != 0)
        {
            goto label_24;
        }
        
        List.Enumerator<T> val_4 = val_12.GetEnumerator();
        label_16:
        if((292871024 & 1) == 0)
        {
            goto label_11;
        }
        
        val_13 = val_6.丐丏七丌丕丗业且上();
        if(val_13 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        if(val_13 != null)
        {
                label_13:
            if(null != null)
        {
                val_13 = 0;
        }
        
        }
        
        val_13.丁专丛丛七丄丄七一(丞且丌三三万七丛万:  丞且丌三三万七丛万);
        goto label_16;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_24:
        Reposition();
        UnityEngine.Coroutine val_10 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void MainStoreSectionTab::丅丞世丈上下东与丁()));
    }
    public MainStoreSectionTab()
    {
        this.丒丂丏且上丌下丙丙 = true;
    }
    private void 三专业七一专丆丏万()
    {
        X19.Reposition();
    }
    private void 丞丏七丛丁丁丐不丘()
    {
        X19.Reposition();
    }
    private void 丅丞世丈上下东与丁()
    {
        X19.Reposition();
    }

}
