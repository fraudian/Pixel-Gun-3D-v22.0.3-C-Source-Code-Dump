using UnityEngine;
internal sealed class GridScrollHelper : PGBehaviour
{
    // Fields
    private UIGrid grid;
    private WidgetLayout layoutHelper;
    private MiniPoolMonoBehaviour layoutHelperPool;
    public ScrollViewHelper scrollHelper;
    private System.Collections.Generic.List<UIWidget> 丟丂万丁丝七丑丈丗;
    public float widthParam;
    public float distance;
    public float startPos;
    
    // Methods
    private void 丑丟三丟丑丑丐丒丐()
    {
        var val_3;
        var val_9;
        int val_10;
        List.Enumerator<T> val_1 = this.丟丂万丁丝七丑丈丗.GetEnumerator();
        val_9 = 1152921526158939600;
        label_4:
        if((77330496 & 1) == 0)
        {
            goto label_2;
        }
        
        this.layoutHelperPool.Return(万且万且丑丗且丌丆:  val_3.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.layoutHelper.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.丟丂万丁丝七丑丈丗.Clear();
        val_10 = this.grid.maxPerLine;
        float val_9 = (float)this.grid.GetChildList().Count;
        val_9 = val_9 / (float)val_10;
        int val_10 = UnityEngine.Mathf.CeilToInt(f:  val_9);
        if(val_10 >= 1)
        {
                val_9 = 1152921526158971344;
            do
        {
            val_10 = this.layoutHelperPool.Get<UIWidget>();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_10, 丏业丟一东丂东丘丛:  true);
            val_10.height = (int)this.grid.cellHeight;
            if(val_10 != null)
        {
                val_10.width = (int)this.grid.cellWidth;
        }
        else
        {
                val_10.width = (int)this.grid.cellWidth;
        }
        
            val_10.ResetAndUpdateAnchors();
            this.layoutHelper.AddElement(世丌丌丙丞丟下东丞:  val_10);
            this.丟丂万丁丝七丑丈丗.Add(item:  val_10);
            val_10 = val_10 - 1;
        }
        while(val_10 != 0);
        
        }
        
        this.layoutHelper.Reposition();
    }
    internal void 万丗丞丂丒世丁丟丟(UnityEngine.Transform 丞下万上三丘上与专)
    {
        this.丑丟三丟丑丑丐丒丐();
        if(丞下万上三丘上与专 == 0)
        {
                return;
        }
        
        float val_8 = (float)this.grid.GetChildList().IndexOf(item:  丞下万上三丘上与专);
        val_8 = val_8 / (float)this.grid.maxPerLine;
        int val_4 = UnityEngine.Mathf.FloorToInt(f:  val_8);
        if(this.丟丂万丁丝七丑丈丗.Count <= val_4)
        {
                return;
        }
        
        this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  this.丟丂万丁丝七丑丈丗.Item[val_4].transform, 丌与丟丁万丝丞丄丏:  false);
    }
    internal void 万丄下丈丏一不丑七(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Transform 丈丂丕下丏丈丞丗业, float 业与三万七丝不万东)
    {
        float val_13;
        UnityEngine.Object val_14;
        val_13 = 业与三万七丝不万东;
        val_14 = 丞下万上三丘上与专;
        this.丑丟三丟丑丑丐丒丐();
        if(val_14 == 0)
        {
                return;
        }
        
        业与三万七丝不万东 = val_13 - this.widthParam;
        this.scrollHelper.scrollDelta = 业与三万七丝不万东;
        float val_13 = (float)this.grid.GetChildList().IndexOf(item:  val_14);
        val_13 = val_13 / (float)this.grid.maxPerLine;
        int val_4 = UnityEngine.Mathf.FloorToInt(f:  val_13);
        if(((val_4 & 2147483648) == 0) && (this.丟丂万丁丝七丑丈丗.Count > val_4))
        {
                this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  this.丟丂万丁丝七丑丈丗.Item[val_4].transform, 丌与丟丁万丝丞丄丏:  false);
        }
        
        val_14 = this.丟丂万丁丝七丑丈丗;
        if(val_14.Count < 1)
        {
                return;
        }
        
        val_14 = this.丟丂万丁丝七丑丈丗.Item[0].transform;
        UnityEngine.Vector3 val_11 = val_14.position;
        val_13 = val_11.x;
        UnityEngine.Vector3 val_12 = 丈丂丕下丏丈丞丗业.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_13, y = val_11.y, z = val_11.z});
        if(val_12.x <= this.distance)
        {
                return;
        }
        
        this.scrollHelper.scrollDelta = 0f;
        if(this.scrollHelper == null)
        {
                return;
        }
        
        this.scrollHelper.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 七丙不一下丞与丞一:  0f, 丌与丟丁万丝丞丄丏:  false);
    }
    public GridScrollHelper()
    {
        this.丟丂万丁丝七丑丈丗 = new System.Collections.Generic.List<UIWidget>();
        this.widthParam = 200f;
        this.distance = 200f;
        this.startPos = 15f;
    }

}
