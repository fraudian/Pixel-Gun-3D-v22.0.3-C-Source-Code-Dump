using UnityEngine;
internal sealed class WidgetLayoutConstrained : PGBehaviour
{
    // Fields
    public UIWidget widget;
    public WidgetLayout widgetLayout;
    public bool sizeCompensate;
    
    // Methods
    public void Reposition()
    {
        this.widgetLayout.CollectWidgets();
        专万丛丘下丄丄丞丟 val_7 = this.widgetLayout.layoutType;
        if(val_7 <= 5)
        {
                val_7 = 1 << val_7;
            val_7 = val_7 & 35;
            if(val_7 != 0)
        {
                this.丈丁丈东丝七专业一(丟丌丐丘丆丙丑丑一:  this.丐且丈不丝丈七丐丒(丑万丂丕丝业不七丌:  (float)this.widget.height));
        }
        else
        {
                this.丞丛丙下丕与三丙丟(业与三万七丝不万东:  this.丐且丈不丝丈七丐丒(丑万丂丕丝业不七丌:  (float)this.widget.width));
        }
        
        }
        
        List.Enumerator<T> val_5 = this.widgetLayout.widgets.GetEnumerator();
        label_12:
        if(((-764898152) & 1) == 0)
        {
            goto label_10;
        }
        
        0.丐丏七丌丕丗业且上().ResetAnchors();
        goto label_12;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.widgetLayout.Reposition();
    }
    private void 丞丛丙下丕与三丙丟(float 业与三万七丝不万东)
    {
        var val_8;
        int val_9;
        val_8 = this;
        int val_8 = this.widgetLayout.GetCount();
        val_8 = this.widget.width - (val_8 * (int)业与三万七丝不万东);
        List.Enumerator<T> val_3 = this.widgetLayout.widgets.GetEnumerator();
        label_12:
        if(((-764724744) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        if(this.sizeCompensate == false)
        {
            goto label_6;
        }
        
        var val_7 = (val_8 > 0) ? 1 : 0;
        val_7 = val_4.gameObject.activeSelf & val_7;
        val_9 = val_7 + (int)业与三万七丝不万东;
        val_8 = val_8 - val_7;
        if(val_4 != null)
        {
            goto label_11;
        }
        
        goto label_10;
        label_6:
        val_9 = (int)业与三万七丝不万东;
        if(val_4 != null)
        {
            goto label_11;
        }
        
        label_10:
        label_11:
        val_4.width = val_9;
        val_4.丞丝一三丟东丛东且(世丌丌丙丞丟下东丞:  val_4);
        goto label_12;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丈丁丈东丝七专业一(float 丟丌丐丘丆丙丑丑一)
    {
        var val_8;
        int val_9;
        val_8 = this;
        int val_8 = this.widgetLayout.GetCount();
        val_8 = this.widget.height - (val_8 * (int)丟丌丐丘丆丙丑丑一);
        List.Enumerator<T> val_3 = this.widgetLayout.widgets.GetEnumerator();
        label_12:
        if(((-764563592) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        if(this.sizeCompensate == false)
        {
            goto label_6;
        }
        
        var val_7 = (val_8 > 0) ? 1 : 0;
        val_7 = val_4.gameObject.activeSelf & val_7;
        val_9 = val_7 + (int)丟丌丐丘丆丙丑丑一;
        val_8 = val_8 - val_7;
        if(val_4 != null)
        {
            goto label_11;
        }
        
        goto label_10;
        label_6:
        val_9 = (int)丟丌丐丘丆丙丑丑一;
        if(val_4 != null)
        {
            goto label_11;
        }
        
        label_10:
        label_11:
        val_4.height = val_9;
        val_4.丞丝一三丟东丛东且(世丌丌丙丞丟下东丞:  val_4);
        goto label_12;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丞丝一三丟东丛东且(UIWidget 世丌丌丙丞丟下东丞)
    {
        if(世丌丌丙丞丟下东丞.gameObject.activeSelf == false)
        {
                return;
        }
        
        世丌丌丙丞丟下东丞.ResetAndUpdateAnchors();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  世丌丌丙丞丟下东丞, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  世丌丌丙丞丟下东丞, 丏业丟一东丂东丘丛:  true);
    }
    private float 丐且丈不丝丈七丐丒(float 丑万丂丕丝业不七丌)
    {
        WidgetLayout val_3;
        float val_4;
        val_3 = this;
        val_4 = 丑万丂丕丝业不七丌;
        int val_1 = this.widgetLayout.GetCount();
        if(val_1 < 2)
        {
                return (float)val_4;
        }
        
        val_3 = this.widgetLayout;
        float val_3 = this.widgetLayout.spacing;
        val_3 = val_3 * ((float)val_1 - 1);
        val_3 = val_4 - val_3;
        val_4 = val_3 / (float)val_1;
        return (float)val_4;
    }
    public WidgetLayoutConstrained()
    {
    
    }

}
