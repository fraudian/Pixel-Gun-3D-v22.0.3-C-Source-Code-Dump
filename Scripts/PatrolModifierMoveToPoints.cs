using UnityEngine;
internal sealed class PatrolModifierMoveToPoints : PatrolModifierController
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Vector3> 丝万丂东丒下且丈丄;
    private System.Collections.Generic.List<PatrolModifierMoveToPoints.NodePoint> _nodePoint;
    private float 丙一丁上丆丞丐丗万;
    private int 万丆专下一丟不世与;
    private float 丐丛上丏丅丛丂丑丌;
    private System.Collections.Generic.List<UnityEngine.Vector3> 丌丄丟丂丆丑下丐世;
    
    // Methods
    internal void 与丘丗万业丕丏丄万(System.Collections.Generic.List<UnityEngine.Vector3> 丑七丐丈下世丆丞丟)
    {
        float val_11;
        var val_12;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
        val_11 = 2f;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  UnityEngine.Random.Range(min:  -2f, max:  val_11));
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  UnityEngine.Random.Range(min:  -2f, max:  val_11));
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_12 = 0;
        goto label_3;
        label_9:
        UnityEngine.Vector3 val_8 = 丑七丐丈下世丆丞丟.Item[0];
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_11 = val_9.y;
        this.丝万丂东丒下且丈丄.Add(item:  new UnityEngine.Vector3() {x = val_9.x, y = val_11, z = val_9.z});
        val_12 = 1;
        label_3:
        if(val_12 < 丑七丐丈下世丆丞丟.Count)
        {
            goto label_9;
        }
    
    }
    internal override UnityEngine.Vector3 专业业丐与丕丂万丘()
    {
        int val_4;
        if(this.丝万丂东丒下且丈丄.Count < 1)
        {
                return UnityEngine.Vector3.zero;
        }
        
        if(this.万丆专下一丟不世与 < this.丝万丂东丒下且丈丄.Count)
        {
                val_4 = this.万丆专下一丟不世与;
        }
        else
        {
                val_4 = this.丝万丂东丒下且丈丄.Count - 1;
            this.万丆专下一丟不世与 = val_4;
        }
        
        if(this.丝万丂东丒下且丈丄 != null)
        {
                return this.丝万丂东丒下且丈丄.Item[val_4];
        }
        
        return this.丝万丂东丒下且丈丄.Item[val_4];
    }
    internal override bool 不丝与下丙丙不丆丙(UnityEngine.Vector3 上丝丁业世且丆丑丁)
    {
        return true;
    }
    internal override bool 与丄万丟丐丝丕丄专()
    {
        return false;
    }
    internal System.Collections.Generic.List<UnityEngine.Vector3> 丑丗丗业丈丙丑丂丝()
    {
        int val_3;
        this.丌丄丟丂丆丑下丐世.Clear();
        val_3 = this.万丆专下一丟不世与;
        goto label_2;
        label_6:
        UnityEngine.Vector3 val_1 = this.丝万丂东丒下且丈丄.Item[val_3];
        X21.Add(item:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        val_3 = val_3 + 1;
        label_2:
        if(val_3 < this.丝万丂东丒下且丈丄.Count)
        {
            goto label_6;
        }
        
        return (System.Collections.Generic.List<UnityEngine.Vector3>)this.丌丄丟丂丆丑下丐世;
    }
    internal override void 与丞丕丝上三不丞与()
    {
        var val_2;
        var val_8;
        int val_9;
        val_8 = this;
        List.Enumerator<T> val_1 = this.丝万丂东丒下且丈丄.GetEnumerator();
        val_9 = 0;
        goto label_2;
        label_7:
        UnityEngine.Vector3 val_4 = val_2.position;
        UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) < 0)
        {
                this.万丆专下一丟不世与 = val_9;
        }
        
        val_9 = 1;
        label_2:
        if((1064840096 & 1) != 0)
        {
            goto label_7;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void Update()
    {
        int val_10;
        if(this.万丆专下一丟不世与 < this.丝万丂东丒下且丈丄.Count)
        {
                val_10 = this.万丆专下一丟不世与;
        }
        else
        {
                val_10 = this.丝万丂东丒下且丈丄.Count - 1;
            this.万丆专下一丟不世与 = val_10;
        }
        
        UnityEngine.Vector3 val_3 = this.丝万丂东丒下且丈丄.Item[val_10];
        UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
        if(this.万丆专下一丟不世与 >= this.丝万丂东丒下且丈丄.Count)
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = this.丌丟丄业且三丛丕丄().position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_5.y, z = val_3.z})) >= 0)
        {
                return;
        }
        
        int val_10 = this.万丆专下一丟不世与;
        val_10 = val_10 + 1;
        this.万丆专下一丟不世与 = val_10;
    }
    public PatrolModifierMoveToPoints()
    {
        this.丝万丂东丒下且丈丄 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this._nodePoint = new System.Collections.Generic.List<NodePoint>();
        this.丙一丁上丆丞丐丗万 = 3.5f;
        this.丌丄丟丂丆丑下丐世 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this = new PGBehaviour();
    }

}
