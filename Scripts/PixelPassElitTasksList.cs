using UnityEngine;
internal sealed class PixelPassElitTasksList : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<PixelPassTaskView> taskViews;
    private UIGrid grid;
    private ItemListUI itemListUI;
    private UIScrollView scrollView;
    private StoreCharacterHelper character;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNOtPremium;
    private UILabel descriptionLabel;
    private System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丕丛丅专万丁万东一;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private void OnEnable()
    {
        PixelPassBuyPremium.丙七不丗东丞丘专不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassElitTasksList::丝丑丏下三丂丌丛下()));
    }
    private void OnDisable()
    {
        PixelPassBuyPremium.丞丕丂丏丌丈专业丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PixelPassElitTasksList::丝丑丏下三丂丌丛下()));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        var val_9;
        var val_20;
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  丈丂七世丟丞丂丗丒.三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNOtPremium, 丏业丟一东丂东丘丛:  丈丂七世丟丞丂丗丒.三丐丌丏专世丆丞丗());
        this.丝丑丏下三丂丌丛下();
        this.不且丕丟丝丐丞丛一();
        if(this.itemListUI != null)
        {
                this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  丈丂七世丟丞丂丗丒.丆丒丗丝丂东丈丏丒());
        }
        
        if(this.scrollView != null)
        {
                this.scrollView.ResetPosition();
        }
        
        this.丕丛丅专万丁万东一.Clear();
        List.Enumerator<T> val_7 = 丈丂七世丟丞丂丗丒.与丑丛下且专七万丄().GetEnumerator();
        label_17:
        if(((-406779856) & 1) == 0)
        {
            goto label_11;
        }
        
        string val_10 = val_9.丐丏七丌丕丗业且上();
        if((val_10.不业丙丒丂丞下丆丙() != 3) || ((val_10.丂不丈不丐业丁七丛(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int64>() {HasValue = false})) == false))
        {
            goto label_17;
        }
        
        this.丕丛丅专万丁万东一.Add(item:  val_10);
        goto label_17;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_13 = this.taskViews.GetEnumerator();
        label_28:
        if(((-406779888) & 1) == 0)
        {
            goto label_25;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_28;
        label_25:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_20 = 0;
        goto label_33;
        label_43:
        if(val_20 < this.taskViews.Count)
        {
                this.taskViews.Item[0].丈且东丑丂且万丒丅(万不且且丛丆东丒业:  this.丕丛丅专万丁万东一.Item[0]);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskViews.Item[0], 丏业丟一东丂东丘丛:  true);
        }
        
        val_20 = 1;
        label_33:
        if(val_20 < this.丕丛丅专万丁万东一.Count)
        {
            goto label_43;
        }
        
        this.grid.repositionNow = true;
        UIPanel.RefreshAllPanels();
    }
    private void 丝丑丏下三丂丌丛下()
    {
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        if(this.character == null)
        {
                return;
        }
        
        this.character.丌丄丘丅万丑丆丈丅(丈丄不七三万丄丁不:  this.丑与万三丐丒丏一专.丁丟丅与丂业丏不丅());
    }
    private void 不且丕丟丝丐丞丛一()
    {
        string val_6;
        if(this.descriptionLabel == 0)
        {
                return;
        }
        
        if(this.丑与万三丐丒丏一专 == null)
        {
                return;
        }
        
        if(this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗() != false)
        {
                var val_4 = (this.丑与万三丐丒丏一专.且丟丆丁世丛万丆丗() != true) ? "Key_11526" : "Key_11525";
        }
        else
        {
                val_6 = "Key_11524";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6));
    }
    public PixelPassElitTasksList()
    {
        this.丕丛丅专万丁万东一 = new System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>();
    }

}
