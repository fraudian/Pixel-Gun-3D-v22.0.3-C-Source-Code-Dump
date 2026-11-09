using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丄丒七丐与丛上上丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private Rilisoft.丐丌丝七下丈丒丅丗.丈丞丕丘丄丐且丈丂 丄丌丂东丘丗一万且;
    private System.Action 丅上专七丐丅万不业;
    private UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> 丂丒三上丐下业丟丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丄丒七丐与丛上上丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_20;
        var val_21;
        var val_22;
        System.Action val_24;
        System.Collections.IEnumerator val_25;
        int val_26;
        var val_27;
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_29;
        val_20 = this;
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
            goto label_9;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new 丐丌丝七下丈丒丅丗.丈丞丕丘丄丐且丈丂();
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_4;
        }
        
        val_21 = null;
        if(Rilisoft.丐丌丝七下丈丒丅丗.丏与上不丛且业与丘() == false)
        {
            goto label_9;
        }
        
        label_4:
        if(UnityEngine.Application.isEditor != true)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
            goto label_9;
        }
        
        }
        
        Rilisoft.丐丌丝七下丈丒丅丗.丂上且丞丘丗下一丐(丙业与丙丗丝不丈东:  true);
        InfoWindowController.丘东丕丌丌东丟丕专();
        val_22 = null;
        val_22 = null;
        val_24 = 丐丌丝七下丈丒丅丗.<>c.<>9__45_0;
        if(val_24 == null)
        {
                System.Action val_7 = null;
            val_24 = val_7;
            val_7 = new System.Action(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丐丌丝七下丈丒丅丗.<>c::且世丐丆专万万丑丄());
            丐丌丝七下丈丒丅丗.<>c.<>9__45_0 = val_24;
        }
        
        this.丄丌丂东丘丗一万且.丁丆丈与丆丞丙与丁 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_7, 与且专丈不万东一万:  "Sync_hronize_Wit_hCloud_Blockin_ForCloudMig_ration");
        val_25 = Rilisoft.丐丌丝七下丈丒丅丗.一丈丈丐丆丙丛丝丌();
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  val_25);
        val_26 = 1;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.SceneManagement.SceneManager.remove_activeSceneChanged(value:  this.丂丒三上丐下业丟丞);
        val_20 = this.丅上专七丐丅万不业;
        val_20.Invoke();
        label_9:
        val_26 = 0;
        return (bool)val_26;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        this.丅上专七丐丅万不业 = new System.Action(object:  this.丄丌丂东丘丗一万且, method:  System.Void 丐丌丝七下丈丒丅丗.丈丞丕丘丄丐且丈丂::七丑业万七丄一丘与());
        val_27 = null;
        val_27 = null;
        val_29 = 丐丌丝七下丈丒丅丗.<>c.<>9__45_2;
        if(val_29 == null)
        {
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_13 = null;
            val_29 = val_13;
            val_13 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丐丌丝七下丈丒丅丗.<>c::丛丅丁上丑一丗一业(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.Scene 丛丆东与丑丞丅丝专));
            丐丌丝七下丈丒丅丗.<>c.<>9__45_2 = val_29;
        }
        
        this.丂丒三上丐下业丟丞 = val_29;
        UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  val_13);
        val_25 = Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丂丗丞丞且万丛万不(丟东丈丗丏丛世万一:  ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "TableViewKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0, 且丏下一下上丟与丐:  true);
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  val_25);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_26 = 1;
        return (bool)val_26;
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
