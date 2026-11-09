using UnityEngine;
public class WidgetLayout : MonoBehaviour
{
    // Fields
    public 专万丛丘下丄丄丞丟 layoutType;
    public float spacing;
    public bool addAditinalSpacing;
    public bool elementPivotAtCenter;
    public UIWidget sizeRessiver;
    public System.Collections.Generic.List<UIWidget> widgets;
    
    // Methods
    public void AddElement(UnityEngine.MonoBehaviour 丅丆东丏丙丝丅丆丟)
    {
        this.AddElement(丅丆东丏丙丝丅丆丟:  丅丆东丏丙丝丅丆丟.gameObject);
    }
    public void AddElement(UnityEngine.GameObject 丅丆东丏丙丝丅丆丟)
    {
        this.AddElement(世丌丌丙丞丟下东丞:  丅丆东丏丙丝丅丆丟.GetComponent<UIWidget>());
    }
    public void AddElement(UIWidget 世丌丌丙丞丟下东丞)
    {
        System.Collections.Generic.List<UIWidget> val_9;
        if(世丌丌丙丞丟下东丞 == 0)
        {
                return;
        }
        
        val_9 = this.widgets;
        if((val_9.Contains(item:  世丌丌丙丞丟下东丞)) != false)
        {
                return;
        }
        
        世丌丌丙丞丟下东丞.transform.SetParent(p:  this.transform);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        世丌丌丙丞丟下东丞.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = this.丘丛丝七丐丁七一丐(世丌丌丙丞丟下东丞:  世丌丌丙丞丟下东丞);
        世丌丌丙丞丟下东丞.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        this.widgets.Add(item:  世丌丌丙丞丟下东丞);
    }
    public void RemoveElement(UnityEngine.MonoBehaviour 丅丆东丏丙丝丅丆丟)
    {
        this.RemoveElement(丅丆东丏丙丝丅丆丟:  丅丆东丏丙丝丅丆丟.gameObject);
    }
    public void RemoveElement(UnityEngine.GameObject 丅丆东丏丙丝丅丆丟)
    {
        this.RemoveElement(丅丆东丏丙丝丅丆丟:  丅丆东丏丙丝丅丆丟.GetComponent<UIWidget>());
    }
    public void RemoveElement(UIWidget 世丌丌丙丞丟下东丞, bool 丏丞丙丌丆丙万丂丛)
    {
        if(世丌丌丙丞丟下东丞 == 0)
        {
                return;
        }
        
        if((this.widgets.Contains(item:  世丌丌丙丞丟下东丞)) == false)
        {
                return;
        }
        
        bool val_3 = this.widgets.Remove(item:  世丌丌丙丞丟下东丞);
        if(丏丞丙丌丆丙万丂丛 != false)
        {
                UnityEngine.Object.Destroy(obj:  世丌丌丙丞丟下东丞.gameObject);
        }
        
        this.Reposition();
    }
    public void Reposition()
    {
        var val_4;
        UIWidget val_23;
        float val_24;
        var val_25;
        System.Func<UIWidget, System.Boolean> val_27;
        val_23 = this;
        this.widgets.Clear();
        List.Enumerator<T> val_2 = System.Linq.Enumerable.ToList<UIWidget>(source:  this.widgets).GetEnumerator();
        label_4:
        if(((-771619280) & 1) == 0)
        {
            goto label_3;
        }
        
        this.AddElement(世丌丌丙丞丟下东丞:  val_4.丐丏七丌丕丗业且上());
        goto label_4;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        float val_7 = this.GetSize() * 0.5f;
        if(this.layoutType == 5)
        {
            goto label_9;
        }
        
        if(this.layoutType != 4)
        {
            goto label_10;
        }
        
        if(this.elementPivotAtCenter != false)
        {
                if(this.widgets.Count >= 2)
        {
            goto label_13;
        }
        
        }
        
        label_30:
        val_24 = (this.widgets.Count == 1) ? 0f : (val_7);
        goto label_15;
        label_9:
        if(this.elementPivotAtCenter != false)
        {
                if(this.widgets.Count >= 2)
        {
            goto label_18;
        }
        
        }
        
        var val_13 = (this.widgets.Count == 1) ? 0f : (val_7);
        goto label_20;
        label_13:
        val_25 = null;
        val_25 = null;
        val_27 = WidgetLayout.<>c.<>9__12_0;
        if(val_27 == null)
        {
                System.Func<UIWidget, System.Boolean> val_14 = null;
            val_27 = val_14;
            val_14 = new System.Func<UIWidget, System.Boolean>(object:  WidgetLayout.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WidgetLayout.<>c::业且一丑东丘丑丟丝(UIWidget 三丟东丕丄丄下下丑));
            WidgetLayout.<>c.<>9__12_0 = val_27;
        }
        
        UIWidget val_15 = System.Linq.Enumerable.FirstOrDefault<UIWidget>(source:  this.widgets, predicate:  val_14);
        if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
        {
            goto label_30;
        }
        
        float val_23 = (float)val_15.width;
        val_23 = val_23 * (-0.5f);
        val_7 = val_7 + val_23;
        goto label_30;
        label_18:
        float val_24 = (float)this.widgets.Item[0].height;
        val_24 = val_24 * (-0.5f);
        val_24 = val_7 + val_24;
        label_20:
        label_15:
        this.丝丟世下且丂丏丏丞(丙业与丙丗丝不丈东:  val_24);
        label_10:
        if(this.sizeRessiver == 0)
        {
                return;
        }
        
        专万丛丘下丄丄丞丟 val_25 = this.layoutType;
        if(val_25 <= 5)
        {
                val_25 = 1 << val_25;
            val_25 = val_25 & 35;
            if(val_25 != 0)
        {
                this.sizeRessiver.height = (int)this.GetSize();
        }
        else
        {
                this.sizeRessiver.width = (int)this.GetSize();
        }
        
        }
        
        val_23 = this.sizeRessiver;
        val_23.ResetAndUpdateAnchors();
    }
    internal void 万万丘丙丗丈丘丙丁(System.Func<UnityEngine.GameObject, int> 业丁一且丄丂丗七丈)
    {
        .业丁一且丄丂丗七丈 = 业丁一且丄丂丗七丈;
        this.widgets = System.Linq.Enumerable.ToList<UIWidget>(source:  System.Linq.Enumerable.OrderBy<UIWidget, System.Int32>(source:  this.widgets, keySelector:  new System.Func<UIWidget, System.Int32>(object:  new WidgetLayout.世东丒与丞七不不东(), method:  System.Int32 WidgetLayout.世东丒与丞七不不东::丂丂丙业下七七丘且(UIWidget 与丘东下丈东丛丂万))));
    }
    public void RemoveAll(bool 丏丞丙丌丆丙万丂丛)
    {
        var val_5;
        if(丏丞丙丌丆丙万丂丛 == false)
        {
            goto label_16;
        }
        
        List.Enumerator<T> val_1 = this.widgets.GetEnumerator();
        val_5 = 1152921526158938576;
        label_10:
        if(((-771248840) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_10;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2.gameObject);
        goto label_10;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_16:
        this.widgets.Clear();
    }
    private UnityEngine.Vector3 丘丛丝七丐丁七一丐(UIWidget 世丌丌丙丞丟下东丞)
    {
        System.Collections.Generic.List<UIWidget> val_22;
        float val_23;
        float val_24;
        float val_25;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_22 = this.widgets;
        val_23 = val_1.x;
        val_24 = val_1.y;
        val_25 = val_1.z;
        if(val_22.Count < 1)
        {
                return new UnityEngine.Vector3() {y = val_24, z = val_25};
        }
        
        int val_19 = this.widgets.Count;
        label_10:
        val_19 = val_19 - 1;
        if((val_19 & 2147483648) != 0)
        {
            goto label_6;
        }
        
        if(this.widgets.Item[val_19].gameObject.activeSelf == false)
        {
            goto label_10;
        }
        
        val_22 = this.widgets.Item[val_19];
        UnityEngine.Vector3 val_9 = val_22.transform.localPosition;
        val_23 = val_9.x;
        val_24 = val_9.y;
        val_25 = val_9.z;
        goto label_14;
        label_6:
        val_22 = 0;
        label_14:
        if(val_22 == 0)
        {
                return new UnityEngine.Vector3() {y = val_24, z = val_25};
        }
        
        if(this.layoutType > 5)
        {
                return new UnityEngine.Vector3() {y = val_24, z = val_25};
        }
        
        var val_20 = 106038256 + (this.layoutType) << 2;
        val_20 = val_20 + 106038256;
        goto (106038256 + (this.layoutType) << 2 + 106038256);
    }
    public void CollectWidgets()
    {
        var val_14;
        var val_15;
        var val_16;
        this.widgets.Clear();
        System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
        label_24:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = val_2.Current;
        if(val_14 != null)
        {
                val_14 = 0;
        }
        
        UIWidget val_11 = val_14.GetComponent<UIWidget>();
        if(val_11 == 0)
        {
            goto label_24;
        }
        
        this.widgets.Add(item:  val_11);
        goto label_24;
        label_8:
        val_15 = 0;
        val_16 = 0;
        if(val_2 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public float GetSize(UIWidget 世丌丌丙丞丟下东丞)
    {
        var val_3;
        专万丛丘下丄丄丞丟 val_3 = this.layoutType;
        if(val_3 > 5)
        {
                return (float)(float)val_3.width;
        }
        
        val_3 = 1 << val_3;
        val_3 = val_3 & 35;
        if(val_3 != 0)
        {
                val_3 = 世丌丌丙丞丟下东丞;
            int val_1 = val_3.height;
        }
        else
        {
                val_3 = 世丌丌丙丞丟下东丞;
        }
        
        return (float)(float)val_3.width;
    }
    public float GetSize()
    {
        float val_4;
        System.Collections.Generic.List<UIWidget> val_5;
        IntPtr val_7;
        int val_8;
        WidgetLayout.与丟业一丈上丅上不 val_1 = new WidgetLayout.与丟业一丈上丅上不();
        if(val_1 != null)
        {
                val_4 = val_1;
            .东且丁丆丛丁丏丘且 = 0f;
        }
        else
        {
                val_4 = 0f;
            mem[16] = 0;
        }
        
        .专不丕七丄东下丗丘 = 0;
        专万丛丘下丄丄丞丟 val_4 = this.layoutType;
        if(val_4 <= 5)
        {
                val_4 = 1 << val_4;
            val_4 = val_4 & 35;
            if(val_4 != 0)
        {
                val_5 = this.widgets;
            val_7 = 1152921538195948816;
        }
        else
        {
                val_5 = this.widgets;
            System.Action<UIWidget> val_2 = null;
            val_7 = 1152921538195958032;
        }
        
            val_2 = new System.Action<UIWidget>(object:  val_1, method:  val_7);
            val_5.ForEach(action:  val_2);
        }
        
        val_8 = (WidgetLayout.与丟业一丈上丅上不)[1152921538196015056].专不丕七丄东下丗丘;
        if(this.addAditinalSpacing != false)
        {
            
        }
        else
        {
                val_8 = val_8 - 1;
        }
        
        float val_5 = (float)UnityEngine.Mathf.Max(a:  0, b:  val_8);
        val_5 = this.spacing * val_5;
        val_5 = val_4 + val_5;
        mem[16] = val_5;
        return val_5;
    }
    public int GetCount()
    {
        System.Collections.Generic.List<UIWidget> val_3;
        IntPtr val_5;
        .专不丕七丄东下丗丘 = 0;
        专万丛丘下丄丄丞丟 val_3 = this.layoutType;
        if(val_3 > 5)
        {
                return (int)(WidgetLayout.业丂七丏丟丕丌丂世)[1152921538196178256].专不丕七丄东下丗丘;
        }
        
        val_3 = 1 << val_3;
        val_3 = val_3 & 35;
        if(val_3 != 0)
        {
                val_3 = this.widgets;
            val_5 = 1152921538196112016;
        }
        else
        {
                val_3 = this.widgets;
            System.Action<UIWidget> val_2 = null;
            val_5 = 1152921538196121232;
        }
        
        val_2 = new System.Action<UIWidget>(object:  new WidgetLayout.业丂七丏丟丕丌丂世(), method:  val_5);
        val_3.ForEach(action:  val_2);
        return (int)(WidgetLayout.业丂七丏丟丕丌丂世)[1152921538196178256].专不丕七丄东下丗丘;
    }
    private void 丝丟世下且丂丏丏丞(float 丙业与丙丗丝不丈东)
    {
        var val_8;
        var val_9;
        float val_10;
        float val_11;
        val_8 = this;
        List.Enumerator<T> val_1 = this.widgets.GetEnumerator();
        label_10:
        if(((-770294152) & 1) == 0)
        {
            goto label_2;
        }
        
        val_9 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_4 = val_9.transform.localPosition;
        val_10 = val_4.x;
        val_11 = val_4.y;
        if(this.layoutType != 4)
        {
            goto label_5;
        }
        
        val_10 = val_10 - 丙业与丙丗丝不丈东;
        if(val_9 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_5:
        val_11 = (this.layoutType == 5) ? (val_11 + 丙业与丙丗丝不丈东) : (val_11);
        val_9 = (this.layoutType == 5) ? (val_9) : ((this.layoutType == 4) ? 0 : (val_9));
        if(val_9 != 0)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_9.transform.localPosition = new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_4.z};
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丅丆丗上丆与东下丟(UIWidget 世丌丌丙丞丟下东丞, int 丞世不丒下上上丝丑)
    {
        if(this.widgets == null)
        {
                return;
        }
        
        if((this.widgets.Contains(item:  世丌丌丙丞丟下东丞)) == false)
        {
                return;
        }
        
        bool val_5 = this.widgets.Remove(item:  世丌丌丙丞丟下东丞);
        this.widgets.Insert(index:  UnityEngine.Mathf.Clamp(value:  丞世不丒下上上丝丑, min:  0, max:  this.widgets.Count - 1), item:  世丌丌丙丞丟下东丞);
    }
    public WidgetLayout()
    {
        this.elementPivotAtCenter = true;
        this.widgets = new System.Collections.Generic.List<UIWidget>();
    }

}
