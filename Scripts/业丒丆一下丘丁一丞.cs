using UnityEngine;
private sealed class PlaceableItemUpgradeUI.业丒丆一下丘丁一丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlaceableItemUpgradeUI 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlaceableItemUpgradeUI.业丒丆一下丘丁一丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丙丑丘业丕丗丗不丘();
        if(FriendsController.丝丗专上三不丄丑丑() >= 1)
        {
                if(this.丝且与丝丒丟万丁专.丄丂世丕不丂不丐丆() != null)
        {
                if(this.丝且与丝丒丟万丁专.丑丝一一三丟三三丞.IsUnknown == false)
        {
            goto label_10;
        }
        
        }
        
        }
        
        label_24:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.timerlLabel, 丕丗丘丑丛与丑业丒:  "");
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  0.3f);
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_1:
        val_10 = 0;
        return (bool)val_10;
        label_10:
        int val_10 = this.丝且与丝丒丟万丁专.丄丂世丕不丂不丐丆().丄丟与丏丄七丒且丗();
        val_10 = val_10 - FriendsController.丝丗专上三不丄丑丑();
        string val_9 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  UnityEngine.Mathf.Clamp(value:  val_10, min:  0, max:  val_10), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        goto label_24;
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
