using UnityEngine;
internal sealed class ProgressRoadPointNewItemsView : PGBehaviour
{
    // Fields
    private ItemStackUI itemStackUI;
    private ItemListUI itemListUI;
    private UIPanel panel;
    private UIWidget widget;
    private WidgetLayoutDelayed widgetLayoutDelayed;
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
        
        if(this.itemListUI == 0)
        {
                return 0;
        }
        
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_4 = this.itemListUI.丆业丈丐丞丄丙业丂();
        if(val_4 != null)
        {
                return val_4.Count;
        }
        
        return val_4.Count;
    }
    internal void 丈且东丑丂且万丒丅(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈)
    {
        System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> val_1 = new System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一>();
        val_1.Add(item:  东东丗丅与一下丄丈);
        this.丈且东丑丂且万丒丅(三丒不不一七东丕业:  val_1);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业)
    {
        this.上丟丆上业一专且丁 = 三丒不不一七东丕业;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_2 = 三丒不不一七东丕业.GetEnumerator();
        label_5:
        if(((-186495528) & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.AddRange(collection:  0.丐丏七丌丕丗业且上());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  (val_1.Count > 0) ? 1 : 0);
        if(this.gameObject.activeSelf != false)
        {
                if(this.itemStackUI != null)
        {
                this.itemStackUI.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_1);
        }
        
            if(this.itemListUI != null)
        {
                this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_1);
        }
        
            if(this.widgetLayoutDelayed != null)
        {
                this.widgetLayoutDelayed.Animate();
        }
        
        }
        
        this.上丅丕丅丟丕丏丁丆();
    }
    internal float 丂丗丏丝丈丟丗丕万()
    {
        if(this.itemListUI != null)
        {
                return this.itemListUI.丂丗丏丝丈丟丗丕万();
        }
        
        return this.itemListUI.丂丗丏丝丈丟丗丕万();
    }
    private void 上丅丕丅丟丕丏丁丆()
    {
        if(this.panel == 0)
        {
                return;
        }
        
        if(this.widget == 0)
        {
                return;
        }
        
        float val_11 = this.panel.width;
        UnityEngine.Vector2 val_4 = this.panel.clipSoftness;
        val_11 = val_11 + (val_4.x * (-2f));
        int val_6 = this.widget.width;
        if(val_11 < 0)
        {
                float val_12 = (float)this.widget.width;
            val_12 = val_12 - val_11;
            val_11 = val_12 * 0.5f;
            this = this.widget.transform;
            this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        this.widget.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    public ProgressRoadPointNewItemsView()
    {
    
    }

}
