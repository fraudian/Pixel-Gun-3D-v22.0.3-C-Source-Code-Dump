using UnityEngine;
public class GridLayout : PGBehaviour
{
    // Fields
    public GridLayout.不且丌世丛丏专且丂 layoutType;
    public int cellsInRow;
    public int cellWidth;
    public int cellHeight;
    public bool ignoreInactive;
    public bool elementPivotAtCenter;
    public UnityEngine.Vector2 sizeTwick;
    private UnityEngine.Vector2 丂与丏一业与下东丛;
    private int 东丟与丝丟丐七万丙;
    private int 丞不丕丅丐丟专业不;
    
    // Properties
    public UnityEngine.Vector2 丁业丛且一丂一丟丁 { get; }
    public int 丏丏丐丗下丁丕丅丄 { get; }
    public int 上丛丞下丝丝丆丝不 { get; }
    
    // Methods
    public UnityEngine.Vector2 get_Size()
    {
        return new UnityEngine.Vector2() {x = this.丂与丏一业与下东丛};
    }
    public int get_VerticalCount()
    {
        return (int)this.东丟与丝丟丐七万丙;
    }
    public int get_HorizontalCount()
    {
        return (int)this.丞不丕丅丐丟专业不;
    }
    public void Reposition()
    {
        this.东丟与丝丟丐七万丙 = 0;
        this.丞不丕丅丐丟专业不 = 0;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丂与丏一业与下东丛 = val_1;
        mem[1152921538167056664] = val_1.y;
        if(this.layoutType == 1)
        {
            goto label_3;
        }
        
        if(this.layoutType != 0)
        {
            goto label_5;
        }
        
        this.丂与丈丟三丛上丝丝();
        goto label_5;
        label_3:
        this.下一七丒万丄丘丙上();
        label_5:
        int val_3 = this.东丟与丝丟丐七万丙;
        int val_2 = this.丞不丕丅丐丟专业不;
        UnityEngine.Vector2 val_4 = this.sizeTwick;
        val_2 = this.cellWidth * val_2;
        val_3 = this.cellHeight * val_3;
        val_4 = val_4 + (float)val_2;
        val_1.y = val_1.y + (float)val_3;
        this.丂与丏一业与下东丛 = val_4;
        mem[1152921538167056664] = val_1.y;
    }
    private void 下一七丒万丄丘丙上()
    {
        bool val_11;
        var val_12;
        val_11 = this.ignoreInactive;
        System.Collections.Generic.List<UnityEngine.Transform> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  (val_11 == true) ? 1 : 0);
        if(val_3.Count == 0)
        {
                return;
        }
        
        float val_12 = (float)val_3.Count;
        val_12 = val_12 / (float)this.cellsInRow;
        this.丞不丕丅丐丟专业不 = UnityEngine.Mathf.CeilToInt(f:  val_12);
        this.东丟与丝丟丐七万丙 = UnityEngine.Mathf.Min(a:  val_3.Count, b:  this.cellsInRow);
        val_12 = 0;
        val_11 = 0;
        do
        {
            if(this.cellsInRow >= 1)
        {
                var val_13 = 0;
            do
        {
            int val_9 = val_12 + val_13;
            if(val_9 >= val_3.Count)
        {
                return;
        }
        
            this.上丕丂丞专丂东世专(不七丘丘丒万七丄丒:  val_3.Item[val_9], 一丗世三专三万丞丞:  0, 业下丌下三丕丙丌下:  0);
            val_13 = val_13 + 1;
        }
        while(val_13 < this.cellsInRow);
        
            val_12 = val_12 + val_13;
        }
        
            val_11 = val_11 + 1;
        }
        while(val_11 != 2147483647);
    
    }
    private void 丂与丈丟三丛上丝丝()
    {
        bool val_11;
        var val_12;
        val_11 = this.ignoreInactive;
        System.Collections.Generic.List<UnityEngine.Transform> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  (val_11 == true) ? 1 : 0);
        if(val_3.Count == 0)
        {
                return;
        }
        
        float val_12 = (float)val_3.Count;
        val_12 = val_12 / (float)this.cellsInRow;
        this.东丟与丝丟丐七万丙 = UnityEngine.Mathf.CeilToInt(f:  val_12);
        this.丞不丕丅丐丟专业不 = UnityEngine.Mathf.Min(a:  val_3.Count, b:  this.cellsInRow);
        val_12 = 0;
        val_11 = 0;
        do
        {
            if(this.cellsInRow >= 1)
        {
                var val_13 = 0;
            do
        {
            int val_9 = val_12 + val_13;
            if(val_9 >= val_3.Count)
        {
                return;
        }
        
            this.上丕丂丞专丂东世专(不七丘丘丒万七丄丒:  val_3.Item[val_9], 一丗世三专三万丞丞:  0, 业下丌下三丕丙丌下:  0);
            val_13 = val_13 + 1;
        }
        while(val_13 < this.cellsInRow);
        
            val_12 = val_12 + val_13;
        }
        
            val_11 = val_11 + 1;
        }
        while(val_11 != 2147483647);
    
    }
    private void 丏丙且丟丐业一丞丆()
    {
        int val_23;
        var val_29;
        object val_30;
        int val_31;
        var val_32;
        var val_33;
        int val_34;
        System.Collections.Generic.List<UnityEngine.Transform> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  (this.ignoreInactive == true) ? 1 : 0);
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
        val_29 = 1152921519067102480;
        label_8:
        val_30 = val_3.Count - 1;
        if(val_30 <= 0)
        {
            goto label_4;
        }
        
        val_31 = 0 + 1;
        if(val_31 > 0)
        {
                val_4.Add(item:  val_31);
        }
        else
        {
                val_31 = 0;
        }
        
        if(val_30 > val_31)
        {
            goto label_8;
        }
        
        val_32 = 0;
        goto label_10;
        label_13:
        val_4.set_Item(index:  0, value:  val_4.Item[0] + 1);
        val_32 = -1;
        label_10:
        if((((((val_4.Count - 1) + val_32) < 0) ? 1 : 0) | (((val_30 + val_32) < 1) ? 1 : 0)) == 0)
        {
            goto label_13;
        }
        
        int val_16 = val_4.Count - 1;
        if(val_4 != null)
        {
                val_33 = val_4.Item[val_16];
        }
        else
        {
                val_33 = val_4.Item[val_16];
        }
        
        val_29 = 1152921519067102480;
        val_4.set_Item(index:  val_16, value:  (val_33 + val_30) + val_32);
        label_4:
        List.Enumerator<T> val_21 = val_4.GetEnumerator();
        val_34 = 0;
        goto label_17;
        label_20:
        int val_24 = val_23.丙东专丂世丈丏丁丂();
        val_23 = val_24;
        val_30 = "--------------   "("--------------   ") + val_23;
        UnityEngine.Debug.LogError(message:  val_30);
        val_34 = val_24 + val_34;
        label_17:
        if(((-799114464) & 1) != 0)
        {
            goto label_20;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_23 = val_34;
        UnityEngine.Debug.LogError(message:  "-----sum------   "("-----sum------   ") + val_23);
        UnityEngine.Debug.LogError(message:  "----count-----   "("----count-----   ") + val_3.Count);
    }
    private void 上丕丂丞专丂东世专(UnityEngine.Transform 不七丘丘丒万七丄丒, int 一丗世三专三万丞丞, int 业下丌下三丕丙丌下)
    {
        var val_5;
        int val_6;
        val_5 = this.cellWidth * 一丗世三专三万丞丞;
        if(this.elementPivotAtCenter != false)
        {
                float val_4 = (float)this.cellWidth;
            float val_5 = 0.5f;
            val_4 = val_4 * val_5;
            val_5 = (float)this.cellHeight * val_5;
            val_5 = val_5 + (int)val_4;
            val_6 = (int)val_5;
        }
        else
        {
                val_6 = 0;
        }
        
        int val_1 = this.cellHeight * 业下丌下三丕丙丌下;
        val_1 = val_1 + val_6;
        UnityEngine.Vector3 val_3 = 不七丘丘丒万七丄丒.transform.localPosition;
        不七丘丘丒万七丄丒.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public GridLayout()
    {
        this.cellsInRow = 3;
        this.cellWidth = 200;
        this.cellHeight = 200;
        this.ignoreInactive = true;
        this.elementPivotAtCenter = true;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丂与丏一业与下东丛 = val_1;
        mem[1152921538167760360] = val_1.y;
    }

}
