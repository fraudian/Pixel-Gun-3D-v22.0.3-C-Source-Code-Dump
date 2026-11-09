using UnityEngine;
private sealed class LevelUpWithOffers.世丑丗上丘丗东丐丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LevelUpWithOffers 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelUpWithOffers.世丑丗上丘丗东丐丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_14;
        int val_15;
        var val_16;
        System.Action<UnityEngine.Transform> val_18;
        var val_19;
        System.Action<UnityEngine.Transform> val_21;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_14 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_15 = 1;
        this.丒上七丌业七丟与丐 = val_14;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_16 = null;
        val_16 = null;
        val_18 = LevelUpWithOffers.<>c.<>9__17_0;
        if(val_18 == null)
        {
                System.Action<UnityEngine.Transform> val_7 = null;
            val_18 = val_7;
            val_7 = new System.Action<UnityEngine.Transform>(object:  LevelUpWithOffers.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelUpWithOffers.<>c::丑丈专与丄丙不上下(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            LevelUpWithOffers.<>c.<>9__17_0 = val_18;
        }
        
        Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  this.丝且与丝丒丟万丁专.transform.parent.parent.parent.gameObject, 丌专业且丛丏丞丝且:  val_7);
        val_19 = null;
        val_14 = this.丝且与丝丒丟万丁专.transform.parent.parent.parent.gameObject;
        val_19 = null;
        val_21 = LevelUpWithOffers.<>c.<>9__17_1;
        if(val_21 == null)
        {
                System.Action<UnityEngine.Transform> val_13 = null;
            val_21 = val_13;
            val_13 = new System.Action<UnityEngine.Transform>(object:  LevelUpWithOffers.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelUpWithOffers.<>c::丄丈丈丆上丙万与东(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            LevelUpWithOffers.<>c.<>9__17_1 = val_21;
        }
        
        Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  val_14, 丌专业且丛丏丞丝且:  val_13);
        label_2:
        val_15 = 0;
        return (bool)val_15;
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
