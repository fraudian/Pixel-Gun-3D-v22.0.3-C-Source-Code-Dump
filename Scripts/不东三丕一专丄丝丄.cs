using UnityEngine;
private sealed class NetworkStartTableNGUIController.不东三丕一专丄丝丄 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.不东三丕一专丄丝丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_24;
        FriendsController val_25;
        var val_26;
        var val_27;
        int val_28;
        var val_29;
        var val_30;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_24 = null;
        val_24 = null;
        val_25 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_25 == 0)
        {
            goto label_6;
        }
        
        val_26 = null;
        val_26 = null;
        val_25 = TempItemsController.丄丞丁丈与业上丞丟;
        if(val_25 != 0)
        {
            goto label_52;
        }
        
        label_6:
        val_27 = 0;
        val_28 = 1;
        goto label_12;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
        {
                if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
            goto label_52;
        }
        
        }
        
            if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().丆丝丅丗世丞丟下且() == true)
        {
            goto label_52;
        }
        
        }
        
            if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
            goto label_52;
        }
        
        }
        
            if(((((this.丝且与丝丒丟万丁专.世丒丗一丑丏丞丑一 != true) && (this.丝且与丝丒丟万丁专.丐丐丑丏丁丙上上丄 != true)) && (this.丝且与丝丒丟万丁专.与与丁下万丈丆丝上 != true)) && (ExchangeWindow.与丌上丄丌丐丟丟丈() != true)) && ((Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙()) != true))
        {
                if(this.丝且与丝丒丟万丁专.rentScreenPoint.childCount == 0)
        {
                不丑世不专上专专丝.丐丗丅丆丘丐丆丏丞(丛丕下丕丞世丂东与:  this.丝且与丝丒丟万丁专.startInterfacePanel.activeSelf, 丅专与丒丈丗丒丘丌:  this.丝且与丝丒丟万丁专.rentScreenPoint, 且丅丟丛丛万丝下上:  "NGUITable");
        }
        
        }
        
        }
        
        label_52:
        val_29 = null;
        val_29 = null;
        val_25 = FriendsController.丄丞丁丈与业上丞丟.MyWaitForSeconds(七且丆丞丌丘下世丑:  1f);
        val_28 = 2;
        label_12:
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_25);
        val_30 = 1;
        this.丗丏丅丕丆世丁专丟 = val_28;
        return (bool)val_30;
        label_13:
        val_30 = 0;
        return (bool)val_30;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new NetworkStartTableNGUIController.不东三丕一专丄丝丄();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
