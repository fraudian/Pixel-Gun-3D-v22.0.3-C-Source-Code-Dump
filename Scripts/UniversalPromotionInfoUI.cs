using UnityEngine;
internal class UniversalPromotionInfoUI : StorePromotionInfoUIAbstract
{
    // Fields
    private UniversalPromotionView universalPromotionView;
    private System.Collections.Generic.List<UnityEngine.GameObject> hideOnItemViewerShow;
    private System.IDisposable 与丅世与丄丑丌丞东;
    
    // Methods
    protected override void OnEnable()
    {
        StoreKitEventListener.一万丟丌东丈丄三一(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void UniversalPromotionInfoUI::丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)));
        new System.Action() = new System.Action(object:  this, method:  typeof(UniversalPromotionInfoUI).__il2cppRuntimeField_1B0);
        this.与丅世与丄丑丌丞东 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "UniversalPromotionInfoUI" + this.gameObject.name);
        Rilisoft.ItemViewer.add_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionInfoUI::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionInfoUI::业且三丙世丅丆丏世()));
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        Rilisoft.ItemViewer.remove_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionInfoUI::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionInfoUI::业且三丙世丅丆丏世()));
        StoreKitEventListener.丛丈专丑上丙丕丗丝(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void UniversalPromotionInfoUI::丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)));
        if(this.与丅世与丄丑丌丞东 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.与丅世与丄丑丌丞东.Dispose();
        }
        
        this.OnDisable();
    }
    private void 丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == false)
        {
            goto typeof(UniversalPromotionInfoUI).__il2cppRuntimeField_178;
        }
    
    }
    internal override void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, object 一丐丗丁丞丆丅丟丄, PGCompany.丞丙上世丑丕与丁丁 且丒丛与丞世丙丕丌 = 0)
    {
        this.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
        this.universalPromotionView.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
    }
    protected override void 丝一丅丆三东丂丞七()
    {
        if(this.universalPromotionView == null)
        {
            
        }
    
    }
    private void 下丁下丛丙专丁丕上()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.hideOnItemViewerShow, 丏业丟一东丂东丘丛:  false);
    }
    private void 业且三丙世丅丆丏世()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.hideOnItemViewerShow, 丏业丟一东丂东丘丛:  true);
    }
    public UniversalPromotionInfoUI()
    {
    
    }

}
