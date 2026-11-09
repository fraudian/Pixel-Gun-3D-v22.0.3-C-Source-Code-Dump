using UnityEngine;
internal class PropertiesLayout : MonoBehaviour
{
    // Fields
    private WidgetLayout widgetLayout;
    private UIGrid grid;
    private PropertyUI propertyUI;
    private UIWidget widget;
    private System.Collections.Generic.List<PropertyUI> 丏丐丆业丘七万丑丝;
    private System.Collections.Generic.List<PropertyUI> 万丂丛丏丗东丘丝丗;
    
    // Methods
    internal float 丂丗丏丝丈丟丗丕万()
    {
        if(this.widgetLayout != null)
        {
                return this.widgetLayout.GetSize();
        }
        
        return this.widgetLayout.GetSize();
    }
    internal PropertyUI 丟丛丁丒丟丞丐丙丙(InfoPropertyData 与丌七七丈业且一丒)
    {
        string val_5;
        string val_6;
        if(与丌七七丈业且一丒 != null)
        {
                val_6 = 与丌七七丈业且一丒.nameKey;
            val_5 = 与丌七七丈业且一丒.iconName;
        }
        else
        {
                val_5 = 64;
            val_6 = 28563616;
        }
        
        return (PropertyUI)this.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  val_5, 丟丒丏丛三丟丑丗丝:  val_6, 丌丒丝东丌下丕丁丅:  UnityEngine.Mathf.CeilToInt(f:  与丌七七丈业且一丒.value).ToString(provider:  System.Globalization.CultureInfo.InvariantCulture), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
    }
    internal PropertyUI 丟丛丁丒丟丞丐丙丙(string 丞丅上丏丂且下丅与, string 丌丒丝东丌下丕丁丅)
    {
        return (PropertyUI)this.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  丞丅上丏丂且下丅与, 丟丒丏丛三丟丑丗丝:  丞丅上丏丂且下丅与, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
    }
    internal PropertyUI 丟丛丁丒丟丞丐丙丙(string 丛丐丌丙丈七丛丛东, string 丟丒丏丛三丟丑丗丝, string 丌丒丝东丌下丕丁丅, float 丙丝与丆三丝不且丑 = 0, System.Nullable<UnityEngine.Color> 丂万丆七丁且丏丗丂, System.Nullable<UnityEngine.Color> 业丑丙一丐丞丌丘丅)
    {
        PropertyUI val_1 = this.万与丌七丅东丒丘丆();
        val_1.世与东丗世三丞丞不(丟丕丞丁丝丂上丄上:  this.widget.depth, 丛丐丌丙丈七丛丛东:  丛丐丌丙丈七丛丛东, 丟丒丏丛三丟丑丗丝:  丟丒丏丛三丟丑丗丝, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丙丝与丆三丝不且丑:  丙丝与丆三丝不且丑, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        this.丏丐丆业丘七万丑丝.Add(item:  val_1);
        if(this.widgetLayout != 0)
        {
                this.widgetLayout.AddElement(世丌丌丙丞丟下东丞:  val_1.widget);
            this.widgetLayout.Reposition();
        }
        
        if(this.grid == 0)
        {
                return val_1;
        }
        
        this.grid.repositionNow = true;
        return val_1;
    }
    internal PropertyUI 与丘丌业丗上下上世(InfoPropertyData 与丈丘上丙丘丕丝丘, InfoPropertyData 丌丞丏专专七上与丞)
    {
        string val_3;
        string val_4;
        if(与丈丘上丙丘丕丝丘 != null)
        {
                val_4 = 与丈丘上丙丘丕丝丘.nameKey;
            val_3 = 与丈丘上丙丘丕丝丘.iconName;
            return this.与丘丌业丗上下上世(丛丐丌丙丈七丛丛东:  val_3 = 64, 丟丒丏丛三丟丑丗丝:  val_4 = 28563616, 丛丌丏专万业丞上丛:  (float)UnityEngine.Mathf.CeilToInt(f:  与丈丘上丙丘丕丝丘.value), 三上七丑东丅业东丁:  (float)UnityEngine.Mathf.CeilToInt(f:  丌丞丏专专七上与丞.value), 丆丝七丕丘七丝丁三:  0f, 丕丛丂丞世丁丐丌专:  false, 业丙丐丑丘世一一丏:  "");
        }
        
        return this.与丘丌业丗上下上世(丛丐丌丙丈七丛丛东:  val_3, 丟丒丏丛三丟丑丗丝:  val_4, 丛丌丏专万业丞上丛:  (float)UnityEngine.Mathf.CeilToInt(f:  与丈丘上丙丘丕丝丘.value), 三上七丑东丅业东丁:  (float)UnityEngine.Mathf.CeilToInt(f:  丌丞丏专专七上与丞.value), 丆丝七丕丘七丝丁三:  0f, 丕丛丂丞世丁丐丌专:  false, 业丙丐丑丘世一一丏:  "");
    }
    internal PropertyUI 与丘丌业丗上下上世(string 丞丅上丏丂且下丅与, float 丛丌丏专万业丞上丛, float 三上七丑东丅业东丁, float 丆丝七丕丘七丝丁三 = 0, bool 丕丛丂丞世丁丐丌专 = False, string 业丙丐丑丘世一一丏 = "")
    {
        return this.与丘丌业丗上下上世(丛丐丌丙丈七丛丛东:  丞丅上丏丂且下丅与, 丟丒丏丛三丟丑丗丝:  丞丅上丏丂且下丅与, 丛丌丏专万业丞上丛:  丛丌丏专万业丞上丛, 三上七丑东丅业东丁:  三上七丑东丅业东丁, 丆丝七丕丘七丝丁三:  丆丝七丕丘七丝丁三, 丕丛丂丞世丁丐丌专:  丕丛丂丞世丁丐丌专, 业丙丐丑丘世一一丏:  业丙丐丑丘世一一丏);
    }
    internal PropertyUI 与丘丌业丗上下上世(string 丛丐丌丙丈七丛丛东, string 丟丒丏丛三丟丑丗丝, float 丛丌丏专万业丞上丛, float 三上七丑东丅业东丁, float 丆丝七丕丘七丝丁三 = 0, bool 丕丛丂丞世丁丐丌专 = False, string 业丙丐丑丘世一一丏 = "")
    {
        PropertyUI val_1 = this.万与丌七丅东丒丘丆();
        val_1.业丐丅丕丏丅丅丞丒(丟丕丞丁丝丂上丄上:  this.widget.depth, 丛丐丌丙丈七丛丛东:  丛丐丌丙丈七丛丛东, 丟丒丏丛三丟丑丗丝:  丟丒丏丛三丟丑丗丝, 丛丌丏专万业丞上丛:  丛丌丏专万业丞上丛, 三上七丑东丅业东丁:  三上七丑东丅业东丁, 丆丝七丕丘七丝丁三:  丆丝七丕丘七丝丁三, 丕丛丂丞世丁丐丌专:  丕丛丂丞世丁丐丌专, 业丙丐丑丘世一一丏:  业丙丐丑丘世一一丏);
        this.丏丐丆业丘七万丑丝.Add(item:  val_1);
        if(this.widgetLayout != 0)
        {
                this.widgetLayout.AddElement(世丌丌丙丞丟下东丞:  val_1.widget);
            this.widgetLayout.Reposition();
        }
        
        if(this.grid == 0)
        {
                return val_1;
        }
        
        this.grid.repositionNow = true;
        return val_1;
    }
    internal void 世业丒万丘丆专丘丐()
    {
        var val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.propertyUI, 丏业丟一东丂东丘丛:  false);
        System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<PropertyUI>(source:  this.丏丐丆业丘七万丑丝);
        val_5 = 0;
        goto label_3;
        label_6:
        this.丄七下丛与丁丅丏丘(丘业丙七丌丗丏且上:  val_1.Item[0]);
        val_5 = 1;
        label_3:
        if(val_5 < val_1.Count)
        {
            goto label_6;
        }
        
        if(this.widgetLayout == 0)
        {
                return;
        }
        
        this.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
    }
    private void 丄七下丛与丁丅丏丘(PropertyUI 丘业丙七丌丗丏且上)
    {
        if(丘业丙七丌丗丏且上 != null)
        {
                丘业丙七丌丗丏且上.丐丘七丘丒丅业丈世();
        }
        else
        {
                0.丐丘七丘丒丅业丈世();
        }
        
        丘业丙七丌丗丏且上.gameObject.SetActive(value:  false);
        this.万丂丛丏丗东丘丝丗.Add(item:  丘业丙七丌丗丏且上);
        if((this.丏丐丆业丘七万丑丝.Contains(item:  丘业丙七丌丗丏且上)) == false)
        {
                return;
        }
        
        bool val_3 = this.丏丐丆业丘七万丑丝.Remove(item:  丘业丙七丌丗丏且上);
    }
    private PropertyUI 万与丌七丅东丒丘丆()
    {
        UnityEngine.Transform val_11;
        if(this.万丂丛丏丗东丘丝丗.Count < 1)
        {
            goto label_2;
        }
        
        PropertyUI val_2 = this.万丂丛丏丗东丘丝丗.Item[0];
        this.万丂丛丏丗东丘丝丗.RemoveAt(index:  0);
        if(val_2 != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        val_2.gameObject.SetActive(value:  true);
        return val_2;
        label_2:
        this.propertyUI.gameObject.SetActive(value:  false);
        val_11 = 0;
        if(this.grid != 0)
        {
                val_11 = this.grid.transform;
        }
        
        if(this.widgetLayout != 0)
        {
                val_11 = this.widgetLayout.transform;
        }
        
        PropertyUI val_9 = UnityEngine.Object.Instantiate<PropertyUI>(original:  this.propertyUI, parent:  val_11);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_9.transform);
        if(val_9 != null)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    public PropertiesLayout()
    {
        this.丏丐丆业丘七万丑丝 = new System.Collections.Generic.List<PropertyUI>();
        this.万丂丛丏丗东丘丝丗 = new System.Collections.Generic.List<PropertyUI>();
    }

}
