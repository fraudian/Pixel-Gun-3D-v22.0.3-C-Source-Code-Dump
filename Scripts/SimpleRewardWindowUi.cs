using UnityEngine;
internal sealed class SimpleRewardWindowUi : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _generalPanelGo;
    private WidgetLayout _widgetLayout;
    private OfferItemView _offerItemViewPrefab;
    private System.Collections.Generic.List<OfferItemView> 丑丘七丄万丐三下世;
    
    // Methods
    private void Awake()
    {
        this._generalPanelGo.SetActive(value:  false);
        OfferItemView.丂东东丌世与与上丛(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void SimpleRewardWindowUi::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
        OfferItemView.万万且丞与万业丈丌(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void SimpleRewardWindowUi::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
    }
    private void OnDestroy()
    {
        OfferItemView.丂东东丌世与与上丛(丙业与丙丗丝不丈东:  new System.Action<OfferItemView>(object:  this, method:  System.Void SimpleRewardWindowUi::丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)));
    }
    public void Show(System.Collections.Generic.List<Rilisoft.OfferItem> 丞丑丘丂不不丝丈丞)
    {
        this.东丆丞东一丕丒东东(丞丑丘丂不不丝丈丞:  丞丑丘丂不不丝丈丞);
        this._generalPanelGo.SetActive(value:  true);
    }
    public void Close()
    {
        this._generalPanelGo.SetActive(value:  false);
    }
    private void 丞上一丈丘丞三丞三(OfferItemView 丆万丞丅专三丟丄下)
    {
        if(丆万丞丅专三丟丄下 == 0)
        {
                return;
        }
        
        if(丆万丞丅专三丟丄下.Context == null)
        {
                return;
        }
        
        if((this.丑丘七丄万丐三下世.Contains(item:  丆万丞丅专三丟丄下)) == false)
        {
                return;
        }
        
        if(丆万丞丅专三丟丄下.Context.Type == 1130)
        {
                return;
        }
        
        Rilisoft.ItemViewer val_8 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丏且丕丄丁丟丆丏丁:  丆万丞丅专三丟丄下.Context, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
    }
    private void 东丆丞东一丕丒东东(System.Collections.Generic.List<Rilisoft.OfferItem> 丞丑丘丂不不丝丈丞)
    {
        var val_8;
        this.丑一丘丁丌丛三丙丄(丌丒丝东丌下丕丁丅:  丞丑丘丂不不丝丈丞.Count);
        val_8 = 0;
        goto label_2;
        label_12:
        if(丞丑丘丂不不丝丈丞.Item[0] != null)
        {
                this.丑丘七丄万丐三下世.Item[0].gameObject.SetActive(value:  true);
            this.丑丘七丄万丐三下世.Item[0].Setup(与且专丈不万东一万:  丞丑丘丂不不丝丈丞.Item[0]);
        }
        
        val_8 = 1;
        label_2:
        if(val_8 < 丞丑丘丂不不丝丈丞.Count)
        {
            goto label_12;
        }
        
        this._widgetLayout.CollectWidgets();
        this._widgetLayout.Reposition();
    }
    private void 丑一丘丁丌丛三丙丄(int 丌丒丝东丌下丕丁丅)
    {
        int val_15;
        System.Collections.Generic.List<OfferItemView> val_16;
        System.Collections.Generic.List<OfferItemView> val_17;
        var val_18;
        WidgetLayout val_19;
        val_15 = 丌丒丝东丌下丕丁丅;
        if(this.丑丘七丄万丐三下世.Count <= val_15)
        {
            goto label_2;
        }
        
        goto label_3;
        label_8:
        this.丑丘七丄万丐三下世.Item[val_15].gameObject.SetActive(value:  false);
        val_15 = val_15 + 1;
        label_3:
        val_16 = this.丑丘七丄万丐三下世;
        if(val_15 < val_16.Count)
        {
            goto label_8;
        }
        
        return;
        label_2:
        val_16 = this.丑丘七丄万丐三下世;
        if(val_16.Count >= val_15)
        {
                return;
        }
        
        val_17 = this.丑丘七丄万丐三下世;
        val_18 = val_15 - val_17.Count;
        if(val_18 > 0)
        {
                val_19 = this._widgetLayout;
            do
        {
            OfferItemView val_8 = UnityEngine.Object.Instantiate<OfferItemView>(original:  this._offerItemViewPrefab, parent:  this._widgetLayout.transform);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            val_8.transform.rotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            this.丑丘七丄万丐三下世.Add(item:  val_8);
            val_17 = mem[this._widgetLayout];
            val_17.AddElement(世丌丌丙丞丟下东丞:  val_8.丁丏世七三丗与丏与());
            val_18 = val_18 - 1;
        }
        while(val_18 != 0);
        
        }
        else
        {
                val_19 = this._widgetLayout;
        }
        
        mem[this._widgetLayout].Reposition();
    }
    public SimpleRewardWindowUi()
    {
        this.丑丘七丄万丐三下世 = new System.Collections.Generic.List<OfferItemView>();
    }

}
