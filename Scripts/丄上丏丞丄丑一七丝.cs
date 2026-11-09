using UnityEngine;
private sealed class ThreeChestsGameEventView.丄上丏丞丄丑一七丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ThreeChestsGameEventView 丝且与丝丒丟万丁专;
    public System.Collections.Generic.List<Rilisoft.GameEventItemData> 丈万丏丌丘丂丄不丏;
    private UnityEngine.Animator 下丞丅三丝丗丄且丘;
    private float 七丁丆丙丕且下丏七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ThreeChestsGameEventView.丄上丏丞丄丑一七丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_13;
        int val_14;
        System.Collections.Generic.List<Rilisoft.GameEventItemData> val_15;
        float val_16;
        System.Collections.Generic.List<Rilisoft.GameEventItemData> val_17;
        val_13 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.下丞丅三丝丗丄且丘 = this.丝且与丝丒丟万丁专.丁丘丈业丙丑万丏丑();
        val_14 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_1:
        val_15 = this.丈万丏丌丘丂丄不丏;
        val_16 = this.七丁丆丙丕且下丏七;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = val_13;
        float val_13 = -2f;
        val_13 = this.丝且与丝丒丟万丁专.丝丈七丒丞七丏丕丗() + val_13;
        val_13 = val_13 / (float)this.丈万丏丌丘丂丄不丏.Count;
        val_16 = val_13;
        this.七丁丆丙丕且下丏七 = val_13;
        label_6:
        label_26:
        val_17 = null;
        if(val_17.Count <= 0)
        {
            goto label_10;
        }
        
        if(this.丝且与丝丒丟万丁专.丞世东丐业一丟东丄 == true)
        {
            goto label_12;
        }
        
        Rilisoft.GameEventItemData val_6 = null.Item[0];
        bool val_7 = null.Remove(item:  val_6);
        if(this.丝且与丝丒丟万丁专._fakeDropView != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._fakeDropView.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丝且与丝丒丟万丁专._fakeDropView.Show(下丅丙一丂丗丅丝七:  val_6);
        }
        
        val_17 = this.下丞丅三丝丗丄且丘;
        if(val_17 != 0)
        {
                val_17 = this.下丞丅三丝丗丄且丘;
            val_17.SetTrigger(name:  "Multy");
        }
        
        if(this.七丁丆丙丕且下丏七 <= 0f)
        {
            goto label_26;
        }
        
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.七丁丆丙丕且下丏七);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_14 = 1;
        return (bool)val_14;
        label_12:
        val_13 = this.丝且与丝丒丟万丁专._fakeDropView.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
        label_10:
        val_14 = 0;
        return (bool)val_14;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        82959 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
