using UnityEngine;
internal sealed class ItemsHistoryView : PGBehaviour
{
    // Fields
    private UILabel[] _countLabels;
    private WidgetLayout _widgetLayout;
    private ItemView _inventoryItemViewPrefab;
    private System.Collections.Generic.List<ItemView> 业丕丐丈丕丈丒世丐;
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    private void OnEnable()
    {
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ItemsHistoryView::Hide()), 与且专丈不万东一万:  System.String.Format(format:  "ItemsHistoryView_{0}", arg0:  this.gameObject.name));
    }
    private void OnDisable()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    private void Awake()
    {
        this._inventoryItemViewPrefab.gameObject.SetActive(value:  false);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丑七不与丛丆一丂丞, int 丐丙丈且专丘东七丆, bool 七万不丆丄丙丁且下)
    {
        this.丗东丂东丈丌丑丈丆(丌丒丝东丌下丕丁丅:  丑七不与丛丆一丂丞.Count);
        this.世一丅专世下万丄不(丑七不与丛丆一丂丞:  丑七不与丛丆一丂丞);
        this.丛且丂且不丟丏丏丈(丐丙丈且专丘东七丆:  丐丙丈且专丘东七丆, 七万不丆丄丙丁且下:  七万不丆丄丙丁且下);
        this.gameObject.SetActive(value:  true);
    }
    public void Hide()
    {
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void 丗东丂东丈丌丑丈丆(int 丌丒丝东丌下丕丁丅)
    {
        int val_14;
        System.Collections.Generic.List<ItemView> val_15;
        System.Collections.Generic.List<ItemView> val_16;
        var val_17;
        WidgetLayout val_18;
        val_14 = 丌丒丝东丌下丕丁丅;
        if(this.业丕丐丈丕丈丒世丐.Count <= val_14)
        {
            goto label_2;
        }
        
        goto label_3;
        label_8:
        this.业丕丐丈丕丈丒世丐.Item[val_14].gameObject.SetActive(value:  false);
        val_14 = val_14 + 1;
        label_3:
        val_15 = this.业丕丐丈丕丈丒世丐;
        if(val_14 < val_15.Count)
        {
            goto label_8;
        }
        
        return;
        label_2:
        val_15 = this.业丕丐丈丕丈丒世丐;
        if(val_15.Count >= val_14)
        {
                return;
        }
        
        val_16 = this.业丕丐丈丕丈丒世丐;
        val_17 = val_14 - val_16.Count;
        if(val_17 > 0)
        {
                val_18 = this._widgetLayout;
            do
        {
            ItemView val_8 = UnityEngine.Object.Instantiate<ItemView>(original:  this._inventoryItemViewPrefab, parent:  this._widgetLayout.transform);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            val_8.transform.rotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            this.业丕丐丈丕丈丒世丐.Add(item:  val_8);
            val_16 = mem[this._widgetLayout];
            val_16.AddElement(世丌丌丙丞丟下东丞:  val_8.Widget);
            val_17 = val_17 - 1;
        }
        while(val_17 != 0);
        
        }
        else
        {
                val_18 = this._widgetLayout;
        }
        
        mem[this._widgetLayout].Reposition();
    }
    private void 世一丅专世下万丄不(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丑七不与丛丆一丂丞)
    {
        goto label_1;
        label_13:
        if(this.业丕丐丈丕丈丒世丐.Item[0] != 0)
        {
                this.业丕丐丈丕丈丒世丐.Item[0].gameObject.SetActive(value:  true);
            this.业丕丐丈丕丈丒世丐.Item[0].丈且东丑丂且万丒丅(下丅丙一丂丗丅丝七:  丑七不与丛丆一丂丞.Item[0]);
        }
        
        0 = 1;
        label_1:
        if(0 < this.业丕丐丈丕丈丒世丐.Count)
        {
            goto label_13;
        }
        
        this._widgetLayout.CollectWidgets();
        this._widgetLayout.Reposition();
    }
    private void 丛且丂且不丟丏丏丈(int 丐丙丈且专丘东七丆, bool 七万不丆丄丙丁且下)
    {
        UILabel val_4;
        var val_5;
        string val_6;
        var val_8;
        val_4 = this;
        if(七万不丆丄丙丁且下 != false)
        {
                val_5 = 1152921504622075904;
            val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8434");
        }
        else
        {
                val_5 = 1152921504622075904;
            val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3916");
        }
        
        val_8 = 0;
        goto label_7;
        label_11:
        val_4 = this._countLabels[0];
        val_4.text = System.String.Format(format:  val_6, arg0:  丐丙丈且专丘东七丆);
        val_8 = 1;
        label_7:
        if(val_8 < this._countLabels.Length)
        {
            goto label_11;
        }
    
    }
    public ItemsHistoryView()
    {
        this.业丕丐丈丕丈丒世丐 = new System.Collections.Generic.List<ItemView>();
    }

}
