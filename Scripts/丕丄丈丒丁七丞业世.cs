using UnityEngine;
private sealed class BattlePassReminderGiveRewardsUI.丕丄丈丒丁七丞业世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassReminderGiveRewardsUI.丕丄丈丒丁七丞业世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_3;
        var val_4;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) == 0)
        {
                val_4 = null;
            val_4 = null;
            val_3 = PGCompany.BattlePass.丒丂丆丏丐一丞丄七.一丈丈丞丒丗丟丘丄;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_3, 下下丏一丙不丘丌丞:  FriendsController.丝丗专上三不丄丑丑(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            return false;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
