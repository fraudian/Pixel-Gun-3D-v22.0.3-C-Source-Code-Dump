using UnityEngine;
internal sealed class DebugWindow : PGBehaviour
{
    // Fields
    private System.Collections.Generic.Dictionary<丄丌丐专丒与丂丅专, 不与丁业丕丏丗上丛> 丙丂丕丘丙丂丘丂丐;
    internal UITable table;
    internal UIScrollView scrollView;
    internal UnityEngine.Transform containter;
    internal UnityEngine.GameObject buttonsPanel;
    internal UIWidget widget;
    internal UISprite activeButton;
    internal UILabel activeLabel;
    internal bool 丗下丟万不丁且与丆;
    internal DebugDragUI 世东丐丁七丞七上丐;
    internal bool 丁下丏丙一丗下丈七;
    
    // Properties
    internal int 不上丟丏七丕不丑业 { get; }
    
    // Methods
    internal int 丆丞且丗丏丈丛丛下()
    {
        if(this.丙丂丕丘丙丂丘丂丐 != null)
        {
                return this.丙丂丕丘丙丂丘丂丐.Count;
        }
        
        return this.丙丂丕丘丙丂丘丂丐.Count;
    }
    private void Awake()
    {
    
    }
    private void Update()
    {
    
    }
    private void LateUpdate()
    {
        if(this.丁下丏丙一丗下丈七 == false)
        {
                return;
        }
        
        this.table.repositionNow = true;
        this.丁下丏丙一丗下丈七 = false;
    }
    public void SetVisible()
    {
    
    }
    internal void 专丙万一丞丅三专与()
    {
    
    }
    internal void 丕丞丄丈业三丘上丈(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑, string 丕丗丘丑丛与丑业丒, System.Action<bool> 七丐丅专且专七三丆, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
    
    }
    internal void 下与丞三丅丛丄七丕(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑, string 丝丁丒丂丂一丒丁丐, string 业世一丛丁世且丟丅, System.Action 丟与丛丁丕丂丝与丌, System.Action 丝不丛专丟丒丅丂丛, UnityEngine.Color 丙丅丐丆且与三世丟, UnityEngine.Color 丘丘丈丆丕丈世与与, bool 不丝七上一丛万七丆 = False)
    {
    
    }
    internal void 世丟丒丗丗丅丝丞东(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑, bool 丝三业丛丘且不丝丆)
    {
    
    }
    internal void 世丟丒丗丗丅丝丞东(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑, bool 丝三业丛丘且不丝丆, ref bool 丌丕与上专上万丂丌)
    {
    
    }
    internal void 下与丞三丅丛丄七丕(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑, string 丕丗丘丑丛与丑业丒, System.Action 七丐丅专且专七三丆, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
    
    }
    internal void 下与丞三丅丛丄七丕(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑, string 专丝丟丒丐丈三丒世, string 丗丂不丂丕丛丆且丕, System.Action 丟丑丞业丙丆专东丐, System.Action 下丂丕丗丝丄世丄万, System.Action<UILabel> 不东世丐专丘丗丂下, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
    
    }
    internal void 下与丞三丅丛丄七丕(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑, string 丕丗丘丑丛与丑业丒, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
    
    }
    private void 丅万业世丛丝丏丘东()
    {
    
    }
    private void 丞七丐三丑东且丈下()
    {
    
    }
    internal void 丆世与丑丆丅丐万且(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑)
    {
    
    }
    internal void 七丁丈丌丑丄下世丑(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑)
    {
    
    }
    internal void 丄丅丄不丆丁丗七丈(丄丌丐专丒与丂丅专[] 丑世万丆丅丈丆丗丝)
    {
    
    }
    internal void 丅万不丆一七丐丝专()
    {
    
    }
    internal 不与丁业丕丏丗上丛 丐下下丅与上东丙丑(丄丌丐专丒与丂丅专 丞世不丒下上上丝丑)
    {
        return 0;
    }
    internal static bool 与专丐三丝丈丌丄万(string 丛丄业丕且丗下一万, out UnityEngine.GameObject 丒专丟丞丌丐丑丕丄)
    {
        UnityEngine.GameObject val_1 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  丛丄业丕且丗下一万);
        丒专丟丞丌丐丑丕丄 = val_1;
        return UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
    }
    public DebugWindow()
    {
        this.丙丂丕丘丙丂丘丂丐 = new System.Collections.Generic.Dictionary<丄丌丐专丒与丂丅专, 不与丁业丕丏丗上丛>();
    }

}
