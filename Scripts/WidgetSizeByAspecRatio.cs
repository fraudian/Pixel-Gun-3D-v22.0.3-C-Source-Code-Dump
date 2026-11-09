using UnityEngine;
internal sealed class WidgetSizeByAspecRatio : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<WidgetSizeByAspecRatio.RatioSettings> _settings;
    internal UIWidget 与东七丏丆世丟丁丌;
    private System.Collections.Generic.List<UIRect> _anchoredRects;
    private WidgetLayout widgetLayout;
    private WidgetLayoutConstrained widgetLayoutConstrained;
    
    // Properties
    internal UIWidget Widget { get; set; }
    
    // Methods
    internal UIWidget 丁丏世七三丗与丏与()
    {
        UIWidget val_3;
        if(this.与东七丏丆世丟丁丌 == 0)
        {
                this.与东七丏丆世丟丁丌 = this.GetComponent<UIWidget>();
            return val_3;
        }
        
        val_3 = this.与东七丏丆世丟丁丌;
        return val_3;
    }
    internal void 丈世万丐丈世上七丒(UIWidget 丙业与丙丗丝不丈东)
    {
        this.与东七丏丆世丟丁丌 = 丙业与丙丗丝不丈东;
    }
    private void OnEnable()
    {
        this.下丒与丈世七丈丑丒();
    }
    internal void 下丒与丈世七丈丑丒()
    {
        int val_12;
        int val_13;
        var val_14;
        WidgetSizeByAspecRatio.下丌丛三下专丘丐丕 val_1 = new WidgetSizeByAspecRatio.下丌丛三下专丘丐丕();
        .东丞丅丕丌丑丗丞下 = 丒丁三上丂丅丌丈丁.丌且专业丈丒丄东万();
        RatioSettings val_3 = this._settings.Item[0];
        val_12 = val_3.aspectRatio;
        val_13 = val_3.width;
        if((this._settings.Exists(match:  new System.Predicate<RatioSettings>(object:  val_1, method:  System.Boolean WidgetSizeByAspecRatio.下丌丛三下专丘丐丕::丑与丈丗丂世三丏丏(WidgetSizeByAspecRatio.RatioSettings 三丟东丕丄丄下下丑)))) != false)
        {
                RatioSettings val_7 = this._settings.Find(match:  new System.Predicate<RatioSettings>(object:  val_1, method:  System.Boolean WidgetSizeByAspecRatio.下丌丛三下专丘丐丕::万丈丙丕丆七丘业下(WidgetSizeByAspecRatio.RatioSettings 三丟东丕丄丄下下丑)));
            val_12 = val_7.aspectRatio;
            val_13 = val_7.width;
        }
        
        val_12 = val_12 >> 32;
        this.丁丏世七三丗与丏与().width = val_12;
        this.丁丏世七三丗与丏与().height = val_13;
        this.丁丏世七三丗与丏与().ResetAndUpdateAnchors();
        val_14 = null;
        val_14 = null;
        if((WidgetSizeByAspecRatio.<>c.<>9__10_2) == null)
        {
            goto label_11;
        }
        
        label_18:
        this._anchoredRects.ForEach(action:  WidgetSizeByAspecRatio.<>c.<>9__10_2);
        if(this.widgetLayout != null)
        {
                this.widgetLayout.Reposition();
        }
        
        if(this.widgetLayoutConstrained == null)
        {
                return;
        }
        
        this.widgetLayoutConstrained.Reposition();
        return;
        label_11:
        WidgetSizeByAspecRatio.<>c.<>9__10_2 = new System.Action<UIRect>(object:  WidgetSizeByAspecRatio.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WidgetSizeByAspecRatio.<>c::七丈与专丘三业丏丄(UIRect 三丟东丕丄丄下下丑));
        if(this._anchoredRects != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }
    public WidgetSizeByAspecRatio()
    {
        this._settings = new System.Collections.Generic.List<RatioSettings>();
        this._anchoredRects = new System.Collections.Generic.List<UIRect>();
    }

}
