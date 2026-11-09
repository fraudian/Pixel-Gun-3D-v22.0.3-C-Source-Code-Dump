using UnityEngine;
internal sealed class SettingsPathMob : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Vector3> _listPath;
    
    // Properties
    internal System.Collections.Generic.List<UnityEngine.Vector3> 丈丏丐丒丌丁丞丄世 { get; }
    
    // Methods
    internal System.Collections.Generic.List<UnityEngine.Vector3> 丒丞丘丏丘专丗丄丂()
    {
        return (System.Collections.Generic.List<UnityEngine.Vector3>)this._listPath;
    }
    private void 丌丄专一丝丝丁且不()
    {
        var val_2;
        List.Enumerator<T> val_1 = this._listPath.GetEnumerator();
        label_10:
        if((1172544768 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_4 = val_2.position;
        new UnityEngine.GameObject() = new UnityEngine.GameObject();
        new UnityEngine.GameObject().transform.SetParent(p:  this.丌丟丄业且三丛丕丄());
        new UnityEngine.GameObject().transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        new UnityEngine.GameObject().tag = "Skull";
        new UnityEngine.GameObject().name = "Point" + 0.ToString();
        DrawCubeGizmos val_11 = new UnityEngine.GameObject().AddComponent<DrawCubeGizmos>();
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
    }
    private void 与丄专丞丑且下丏万()
    {
        var val_19;
        var val_20;
        var val_21;
        UnityEngine.Transform val_22;
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<UnityEngine.Transform>(source:  this.GetComponentsInChildren<UnityEngine.Transform>());
        if(val_2.Count < 1)
        {
            goto label_8;
        }
        
        val_19 = 0;
        val_20 = 0;
        goto label_3;
        label_7:
        val_20 = val_20 | (System.String.op_Equality(a:  val_2.Item[0].tag, b:  "Skull"));
        val_19 = 1;
        label_3:
        if(val_19 < val_2.Count)
        {
            goto label_7;
        }
        
        if(val_20 != false)
        {
                this._listPath.Clear();
        }
        
        label_8:
        val_21 = 0;
        goto label_23;
        label_25:
        if((System.String.op_Inequality(a:  val_2.Item[0].tag, b:  "Skull")) != true)
        {
                val_20 = val_2.Item[0];
            UnityEngine.Vector3 val_12 = val_20.position;
            this._listPath.Add(item:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Object.DestroyImmediate(obj:  val_2.Item[0].gameObject);
            if(val_2 != null)
        {
                val_22 = val_2.Item[0];
        }
        else
        {
                val_22 = 0.Item[0];
        }
        
            bool val_17 = val_2.Remove(item:  val_22);
        }
        else
        {
                val_21 = 1;
        }
        
        label_23:
        if(val_21 < val_2.Count)
        {
            goto label_25;
        }
    
    }
    public SettingsPathMob()
    {
        this._listPath = new System.Collections.Generic.List<UnityEngine.Vector3>();
    }

}
