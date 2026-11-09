using UnityEngine;
private sealed class LobbyCraftButton.丆丄三丆万丒丙丑丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LobbyCraftButton 丝且与丝丒丟万丁专;
    private UIButton 丝丘丄七丐丄七丗丒;
    private UnityEngine.WaitForSeconds 业一下丝丗丌与丙丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyCraftButton.丆丄三丆万丒丙丑丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        UIButton val_12;
        var val_13;
        System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_15;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_11 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝丘丄七丐丄七丗丒 = this.丝且与丝丒丟万丁专.GetComponent<UIButton>();
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_3:
        this.丝丘丄七丐丄七丗丒 = 0.GetComponent<UIButton>();
        label_4:
        this.丝且与丝丒丟万丁专._newItemsCountLabel.gameObject.SetActive(value:  false);
        this.业一下丝丗丌与丙丘 = new UnityEngine.WaitForSeconds(seconds:  1f);
        label_5:
        val_12 = this.丝丘丄七丐丄七丗丒;
        if((val_12 & 1) != 0)
        {
                val_13 = null;
            val_13 = null;
            val_15 = LobbyCraftButton.<>c.<>9__7_0;
            if(val_15 == null)
        {
                System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_7 = null;
            val_15 = val_7;
            val_7 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyCraftButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyCraftButton.<>c::丛不丁万丈下一丙丁(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            LobbyCraftButton.<>c.<>9__7_0 = val_15;
        }
        
            val_12 = System.Linq.Enumerable.Count<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  val_7);
            UnityEngine.GameObject val_9 = this.丝且与丝丒丟万丁专._newItemsCountLabel.gameObject;
            if(val_12 >= 1)
        {
                val_9.SetActive(value:  true);
            val_12 = val_12.ToString();
            this.丝且与丝丒丟万丁专._newItemsCountLabel.text = val_12;
        }
        else
        {
                val_9.SetActive(value:  false);
        }
        
        }
        
        val_11 = 1;
        this.丗丏丅丕丆世丁专丟 = val_11;
        this.丒上七丌业七丟与丐 = this.业一下丝丗丌与丙丘;
        return (bool)val_11;
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
