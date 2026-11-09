using UnityEngine;
private sealed class Player_move_c.丅七丑上丟与丆专丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 专世丁且丑丛丐丗不;
    public Player_move_c 丝且与丝丒丟万丁专;
    private string 丌且丛丐丗下丝丒丈;
    private UnityEngine.ResourceRequest 专上业三丗万丙丗一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丅七丑上丟与丆专丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_21;
        int val_22;
        UnityEngine.GameObject val_23;
        val_21 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        string val_2 = "RoyaleMarkerRay" + this.专世丁且丑丛丐丗不.ToString();
        this.丌且丛丐丗下丝丒丈 = val_2;
        UnityEngine.ResourceRequest val_4 = UnityEngine.Resources.LoadAsync(path:  "RoyaleMapMarkersRays/"("RoyaleMapMarkersRays/") + val_2);
        this.专上业三丗万丙丗一 = val_4;
        this.丒上七丌业七丟与丐 = val_4;
        val_22 = 1;
        this.丗丏丅丕丆世丁专丟 = val_22;
        return (bool)val_22;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.专上业三丗万丙丗一.isDone != false)
        {
                if(this.专上业三丗万丙丗一.asset != 0)
        {
            goto label_9;
        }
        
        }
        
        object[] val_8 = new object[1];
        val_21 = val_8;
        val_21[0] = this.丌且丛丐丗下丝丒丈;
        UnityEngine.Debug.LogWarningFormat(format:  "Can\'t load marker ray: {0}", args:  val_8);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_49;
        }
        
        goto label_17;
        label_2:
        val_22 = 0;
        return (bool)val_22;
        label_9:
        if(this.专上业三丗万丙丗一.asset != null)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        object[] val_10 = new object[1];
        val_21 = val_10;
        val_21[0] = this.丌且丛丐丗下丝丒丈;
        UnityEngine.Debug.LogErrorFormat(format:  "Wrong marker ray asset {0}! Must be a GameObject!", args:  val_10);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_49;
        }
        
        label_17:
        label_49:
        val_22 = 0;
        this.丝且与丝丒丟万丁专.一丅东丗七丙丅丐丑 = 0;
        return (bool)val_22;
        label_21:
        val_23 = this.专上业三丗万丙丗一.asset;
        if((val_23 != null) && (null != null))
        {
                val_23 = 0;
        }
        
        this.丝且与丝丒丟万丁专.与丗七一丏三丌专与 = val_23;
        if(this.丝且与丝丒丟万丁专.丘世东东丈丏丏丒丒 == 0)
        {
            goto label_49;
        }
        
        UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.与丗七一丏三丌专与, parent:  this.丝且与丝丒丟万丁专.丘世东东丈丏丏丒丒.transform);
        if(val_15 == 0)
        {
            goto label_49;
        }
        
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        val_15.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.identity;
        val_15.transform.localRotation = new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w};
        this.丝且与丝丒丟万丁专.丑丅世世丛丙万丌丈 = true;
        goto label_49;
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
