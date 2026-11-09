using UnityEngine;
private sealed class LobbySeasonController.不不丙丌丘丁丝丆丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LobbySeasonController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbySeasonController.不不丙丌丘丁丝丆丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.LobbyCraftController val_30;
        int val_31;
        val_30 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_47;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) != 0)
        {
            goto label_7;
        }
        
        }
        
        val_31 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_31;
        return (bool)val_31;
        label_7:
        if(((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  128)) != false) && ((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  132)) != false))
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  132))) != true)
        {
                if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  132).Equals(value:  this.丝且与丝丒丟万丁专.seasonNameEn, comparisonType:  5)) == true)
        {
            goto label_28;
        }
        
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  132, 丙业与丙丗丝不丈东:  this.丝且与丝丒丟万丁专.seasonNameEn);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  128, 丙业与丙丗丝不丈东:  1);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  129, 丙业与丙丗丝不丈东:  0);
        UnityEngine.Coroutine val_19 = CoroutineRunner.Instance.StartCoroutine(routine:  MenuBackgroundMusic.丆不一万丗下不丆万(七不丐下丟专业万丅:  "season_lobby", 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  true));
        this.丝且与丝丒丟万丁专.与三丂与世丗丆丆丗 = true;
        label_28:
        Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丏丐三丌丒丝不不(丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  128)));
        val_30 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_30.下丟丈不一上万不业() != false)
        {
                val_30 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            val_30.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
        }
        
        label_47:
        val_31 = 0;
        return (bool)val_31;
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
