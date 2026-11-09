using UnityEngine;
internal sealed class USPViewComponentLootBoxWithCharacter : USPViewComponentLootBox
{
    // Fields
    private UnityEngine.GameObject shootButtonUI;
    private StoreCharacterHelper _character;
    private LoopedScrollItemSelector itemSelector;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableOnShowInfo;
    
    // Methods
    protected void OnEnable()
    {
        this.itemSelector.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void USPViewComponentLootBoxWithCharacter::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.add_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void USPViewComponentLootBoxWithCharacter::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void USPViewComponentLootBoxWithCharacter::业且三丙世丅丆丏世()));
    }
    protected void OnDisable()
    {
        this.itemSelector.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void USPViewComponentLootBoxWithCharacter::丘下丟丁上丏丛且且()));
        Rilisoft.ItemViewer.remove_OnViewerShow(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void USPViewComponentLootBoxWithCharacter::下丁下丛丙专丁丕上()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void USPViewComponentLootBoxWithCharacter::业且三丙世丅丆丏世()));
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        this._character.万与七丕七丁丞下丆 = false;
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        this.丕丙丝一丁丏且丘丛();
    }
    internal void 丘下丟丁上丏丛且且()
    {
        this.丕丙丝一丁丏且丘丛();
        this.七丑丁丝丑三上不与();
    }
    private void 下丁下丛丙专丁丕上()
    {
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShowInfo, 丏业丟一东丂东丘丛:  false);
    }
    private void 业且三丙世丅丆丏世()
    {
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.disableOnShowInfo, 丏业丟一东丂东丘丛:  true);
    }
    private void 丕丙丝一丁丏且丘丛()
    {
        this._character.与丕丆上丛丐下丕丂().专业丞丞专下丒丌下(东世丛丘丐下丏丄丈:  false);
        this._character.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        this._character.丞上丄丄上丞丘下丁();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  false);
        this.下专丙丛丐与丁专丘();
        UnityEngine.Coroutine val_3 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void USPViewComponentLootBoxWithCharacter::下专丙丛丐与丁专丘()), 业丗七丕万万不丈丗:  1);
    }
    private void 下专丙丛丐与丁专丘()
    {
        if(this.itemSelector != 0)
        {
                if(this.itemSelector.丕丟丐丈丐丄丌三丐() != null)
        {
                this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.itemSelector.不专上丕丙世丟且万());
        }
        
        }
        
        this.七丑丁丝丑三上不与();
    }
    private void 七丑丁丝丑三上不与()
    {
        var val_5;
        if(this.itemSelector.不专上丕丙世丟且万() != null)
        {
                var val_4 = (this.itemSelector.不专上丕丙世丟且万().不业丙丒丂丞下丆丙() == 10) ? 1 : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButtonUI, 丏业丟一东丂东丘丛:  false);
    }
    public USPViewComponentLootBoxWithCharacter()
    {
        val_1 = new SPViewComponentBase();
    }

}
