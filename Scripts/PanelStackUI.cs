using UnityEngine;
internal sealed class PanelStackUI : PGBehaviour
{
    // Fields
    public UIPanel holderPanel;
    public UnityEngine.Vector3 stepOffset;
    public UnityEngine.Vector3 stepScale;
    public System.Collections.Generic.List<UIPanel> panels;
    
    // Methods
    public void AddTop(UnityEngine.MonoBehaviour 丅丆东丏丙丝丅丆丟)
    {
        this.AddTop(丅丆东丏丙丝丅丆丟:  丅丆东丏丙丝丅丆丟.gameObject);
    }
    public void AddTop(UnityEngine.GameObject 丅丆东丏丙丝丅丆丟)
    {
        this.丁丌丒七丐丂且下丞(丞世不丒下上上丝丑:  0, 丛丘下丗业丂一且业:  丅丆东丏丙丝丅丆丟.GetComponent<UIPanel>());
    }
    internal void 丑上不不东丘丝丑丝(UIPanel 丛丘下丗业丂一且业)
    {
        this.丁丌丒七丐丂且下丞(丞世不丒下上上丝丑:  0, 丛丘下丗业丂一且业:  丛丘下丗业丂一且业);
    }
    public void AddBottom(UnityEngine.MonoBehaviour 丅丆东丏丙丝丅丆丟)
    {
        this.AddBottom(丅丆东丏丙丝丅丆丟:  丅丆东丏丙丝丅丆丟.gameObject);
    }
    public void AddBottom(UnityEngine.GameObject 丅丆东丏丙丝丅丆丟)
    {
        this.业丏丗丐丂业东丂丗(丛丘下丗业丂一且业:  丅丆东丏丙丝丅丆丟.GetComponent<UIPanel>());
    }
    internal void 东三丝丒丝丏一下东(UIPanel 丛丘下丗业丂一且业)
    {
        this.业丏丗丐丂业东丂丗(丛丘下丗业丂一且业:  丛丘下丗业丂一且业);
    }
    private void 业丏丗丐丂业东丂丗(UIPanel 丛丘下丗业丂一且业)
    {
        if((this.panels.Contains(item:  丛丘下丗业丂一且业)) != false)
        {
                return;
        }
        
        丛丘下丗业丂一且业.transform.SetParent(p:  this.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  丛丘下丗业丂一且业.transform);
        this.panels.Add(item:  丛丘下丗业丂一且业);
        this.丁下丏丙一丗下丈七();
    }
    private void 丁丌丒七丐丂且下丞(int 丞世不丒下上上丝丑, UIPanel 丛丘下丗业丂一且业)
    {
        if((this.panels.Contains(item:  丛丘下丗业丂一且业)) != false)
        {
                return;
        }
        
        丛丘下丗业丂一且业.transform.SetParent(p:  this.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  丛丘下丗业丂一且业.transform);
        this.panels.Insert(index:  丞世不丒下上上丝丑, item:  丛丘下丗业丂一且业);
        this.丁下丏丙一丗下丈七();
    }
    internal void 世业丒万丘丆专丘丐()
    {
        this.panels.Clear();
    }
    internal void 丁下丏丙一丗下丈七()
    {
        var val_3;
        var val_17;
        var val_18;
        var val_19;
        val_17 = this;
        List.Enumerator<T> val_1 = this.panels.GetEnumerator();
        val_18 = 0;
        goto label_8;
        label_15:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 != 0)
        {
                val_19 = val_4.gameObject;
            if(val_19.activeSelf != false)
        {
                val_19 = this.holderPanel.depth;
            val_4.depth = (val_19 - val_18) + this.panels.Count;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.stepOffset, y = V9.16B, z = V10.16B}, d:  0f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            TweenPosition val_16 = TweenPosition.Begin(丝三丁东丈丒世丅业:  val_4.gameObject, 与丈业丛丝丒丙一丏:  0.1f, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_18 = 1;
        }
        
        }
        
        label_8:
        if(((-1227298992) & 1) != 0)
        {
            goto label_15;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丈丒业丄丈七东丄与()
    {
        var val_14;
        var val_15;
        var val_16;
        this.世业丒万丘丆专丘丐();
        System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
        label_23:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = val_2.Current;
        if(val_14 != null)
        {
                val_14 = 0;
        }
        
        UIPanel val_11 = val_14.GetComponent<UIPanel>();
        if(val_11 == 0)
        {
            goto label_23;
        }
        
        this.panels.Add(item:  val_11);
        goto label_23;
        label_7:
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
    public PanelStackUI()
    {
        this.panels = new System.Collections.Generic.List<UIPanel>();
    }

}
