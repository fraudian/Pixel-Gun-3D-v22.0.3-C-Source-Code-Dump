using UnityEngine;
internal sealed class LoopedScrollItemSelector : SelectableButtonController
{
    // Fields
    private UnityEngine.Transform selectorTransform;
    private UnityEngine.Transform buttonsContainer;
    
    // Properties
    internal PGCompany.三东丏不丗世丅丌丄 专一丟丆专丟一世一 { get; }
    internal PGCompany.丗丟丄丈东丝丕丄世 丈丝丂七与丑下上丄 { get; }
    
    // Methods
    internal PGCompany.三东丏不丗世丅丌丄 丕丟丐丈丐丄丌三丐()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  137146368, y:  0);
        if(val_1 == false)
        {
                return 0;
        }
        
        if(val_1 == false)
        {
                return 0;
        }
        
        return 0;
    }
    internal PGCompany.丗丟丄丈东丝丕丄世 不专上丕丙世丟且万()
    {
        PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this.丕丟丐丈丐丄丌三丐());
        }
        
        return val_1.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this.丕丟丐丈丐丄丌三丐());
    }
    private void OnEnable()
    {
        this.下万与与丏丛丗万且();
    }
    private void OnDisable()
    {
        this.万不丑东丞丟丘丞下();
    }
    internal void 下万与与丏丛丗万且()
    {
        var val_13;
        var val_14;
        var val_15;
        this.万不丑东丞丟丘丞下();
        Clear();
        System.Collections.IEnumerator val_1 = this.buttonsContainer.GetEnumerator();
        label_23:
        var val_13 = 0;
        val_13 = val_13 + 1;
        if(val_1.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_13 = val_1.Current;
        if(val_13 != null)
        {
                val_13 = 0;
        }
        
        if((val_13.GetComponent<SelectableButton>()) == 0)
        {
            goto label_23;
        }
        
        goto label_23;
        label_8:
        val_14 = 0;
        val_15 = 0;
        if(val_1 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_1.Dispose();
        }
        
        this.万不丑东丞丟丘丞下();
        this.上丝上上世丅丙丈东();
    }
    internal void 万不丑东丞丟丘丞下()
    {
        var val_3;
        mem[1152921537692606344] = 0;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_3 = 1152921524324429632;
        label_4:
        if(((-1273991128) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() == null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 上丝上上世丅丙丈东()
    {
        var val_7;
        var val_8;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_7 = 0;
        goto label_8;
        label_9:
        val_8 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_4 = val_8.transform.position;
        UnityEngine.Vector3 val_5 = this.selectorTransform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) < 0)
        {
                val_7 = val_8;
        }
        
        label_8:
        if(((-1273862840) & 1) != 0)
        {
            goto label_9;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void LateUpdate()
    {
        this.上丝上上世丅丙丈东();
    }
    public LoopedScrollItemSelector()
    {
    
    }

}
