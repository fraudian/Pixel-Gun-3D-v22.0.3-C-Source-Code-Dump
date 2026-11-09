using UnityEngine;
private sealed class ARController.丕丟丅丁东丆丑万丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ARController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ARController.丕丟丅丁东丆丑万丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        int val_22;
        double val_23;
        double val_24;
        UnityEngine.Transform val_25;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_22 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_22;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_23 = 0.5;
        val_24 = val_23;
        val_25 = this.丝且与丝丒丟万丁专.丝不丙丄丒三丟东与.下七下且丐与丐世不(丅专与丒丈丗丒丘丌:  new UnityEngine.XR.iOS.丑丅丌业丅丈下丝丏() {三丟东丕丄丄下下丑 = val_23, 丒丒丄丁且丄丆丂丌 = val_24}, 一丕丅一丕丘世丑丆:  1);
        if((val_25 != null) && (val_25.Count != 0))
        {
                UnityEngine.XR.iOS.与下三丈丁丌丙丄不 val_3 = val_25.Item[0];
            if(this.丝且与丝丒丟万丁专.丁丆丒一一丒丗丙丛 == 0)
        {
                UnityEngine.Transform val_5 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  this.丝且与丝丒丟万丁专.planePrefab);
            this.丝且与丝丒丟万丁专.丁丆丒一一丒丗丙丛 = val_5;
            val_5.parent = this.丝且与丝丒丟万丁专.arCamera.parent;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丝且与丝丒丟万丁专.丁丆丒一一丒丗丙丛.gameObject, 不东丛三丂丌丑专丆:  this.丝且与丝丒丟万丁专.arCamera.gameObject.layer);
            UnityEngine.Transform val_10 = this.丝且与丝丒丟万丁专.丁丆丒一一丒丗丙丛.GetChild(index:  0);
            this.丝且与丝丒丟万丁专.丏丘丒丛不七一与专 = val_10;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.05f);
            val_10.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            val_23 = val_13.x;
            val_24 = val_13.y;
            this.丝且与丝丒丟万丁专.丏丘丒丛不七一与专.localPosition = new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_13.z};
        }
        
            this.丝且与丝丒丟万丁专.上丌与丒丟业丘世丐();
            UnityEngine.Vector3 val_18 = UnityEngine.XR.iOS.丗七丄下东不专丞专.丘丛丝七丐丁七一丐(丙丐万下万下丄上专:  new UnityEngine.Matrix4x4() {m00 = val_16, m10 = val_16, m20 = val_16, m30 = val_16, m01 = val_17, m11 = val_17, m21 = val_17, m31 = val_17, m02 = val_14, m12 = val_14, m22 = val_14, m32 = val_14, m03 = val_15, m13 = val_15, m23 = val_15, m33 = val_15});
            val_25 = this.丝且与丝丒丟万丁专.arCamera;
            UnityEngine.Vector3 val_19 = val_25.position;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            this.丝且与丝丒丟万丁专.七丝丕东不东丝丆丝 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            this.丝且与丝丒丟万丁专.东丗下丂上七丞丗七();
        }
        
        label_8:
        val_22 = 1;
        this.丗丏丅丕丆世丁专丟 = val_22;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.世七丙丐丌丏丄世世;
        return (bool)val_22;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
