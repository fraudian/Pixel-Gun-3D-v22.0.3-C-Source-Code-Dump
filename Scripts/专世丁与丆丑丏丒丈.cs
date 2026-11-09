using UnityEngine;
private sealed class PolygonController.专世丁与丆丑丏丒丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PolygonController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PolygonController.专世丁与丆丑丏丒丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_29;
        System.Collections.Generic.List<RilisoftBot.BaseBot> val_30;
        var val_31;
        int val_32;
        var val_33;
        var val_34;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        label_5:
        val_29 = this.丝且与丝丒丟万丁专._maxCountBot;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_3:
        val_29 = 0;
        label_4:
        val_30 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下;
        if(0 <= val_30.Count)
        {
            goto label_7;
        }
        
        this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Add(item:  this.丝且与丝丒丟万丁专.丛丌丂丕丁丄上专丘());
        if(this.丝且与丝丒丟万丁专.且东丕三丝东丒世下 == null)
        {
            goto label_9;
        }
        
        val_31 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        goto label_10;
        label_2:
        val_32 = 0;
        return (bool)val_32;
        label_9:
        val_31 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        label_10:
        this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Item[val_31 - 1].七东丘与丁丌三丛丐(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PolygonController::世丗三东东三东七上(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
        if(this.丝且与丝丒丟万丁专.且东丕三丝东丒世下 != null)
        {
                val_33 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        }
        else
        {
                val_33 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        }
        
        UnityEngine.Transform val_13 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Item[val_33 - 1].transform;
        val_13.SetParent(p:  this.丝且与丝丒丟万丁专._container.transform);
        UnityEngine.Vector3 val_18 = this.丝且与丝丒丟万丁专._listPosition.Item[UnityEngine.Random.Range(min:  0, max:  this.丝且与丝丒丟万丁专._listPosition.Count)].position;
        val_13.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        if(this.丝且与丝丒丟万丁专.且东丕三丝东丒世下 != null)
        {
                val_34 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        }
        else
        {
                val_34 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        }
        
        RilisoftBot.BaseBot val_22 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Item[val_34 - 1];
        if(this.丝且与丝丒丟万丁专.且东丕三丝东丒世下 != null)
        {
                val_30 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        }
        else
        {
                val_30 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Count;
        }
        
        RilisoftBot.BaseBot val_26 = this.丝且与丝丒丟万丁专.且东丕三丝东丒世下.Item[val_30 - 1];
        val_22.下不丌万丙且一万东.丆丞业丅三丞专丝丒 = val_26.下不丌万丙且一万东.gameObject.AddComponent<PolygonCurrentAiState>();
        label_7:
        val_32 = 1;
        this.丗丏丅丕丆世丁专丟 = val_32;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_32;
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
