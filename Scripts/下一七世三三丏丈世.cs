using UnityEngine;
private sealed class TournamentController.下一七世三三丏丈世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TournamentController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TournamentController.下一七世三三丏丈世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TournamentController val_22;
        int val_23;
        且丛丈丒万与丁丟丟 val_24;
        int val_25;
        var val_26;
        val_22 = this.丝且与丝丒丟万丁专;
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
            goto label_49;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Tournament: Initializing...");
        }
        
        val_23 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "DivisionsTournament.LastPhaseKey_v3", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        bool val_4 = System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_23);
        if(val_22 == null)
        {
            goto label_15;
        }
        
        if(val_4 == false)
        {
            goto label_16;
        }
        
        label_20:
        val_24 = val_23;
        goto label_17;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_18;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_19;
        label_15:
        if(val_4 == true)
        {
            goto label_20;
        }
        
        label_16:
        val_24 = 0;
        label_17:
        val_22.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  val_24);
        label_19:
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_21;
        }
        
        TournamentLeaderboard val_7 = TournamentLeaderboard.业三世丝且丈丐丄丁(下丕世不丈专万丗万:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "DivisionsTournament.LeaderboardCacheKey_v3", 丞丌丑丛上丕丙丕下:  System.String.alignConst));
        if(val_22 == null)
        {
            goto label_24;
        }
        
        val_22.丄万三丑万丞丏下一(丙业与丙丗丝不丈东:  val_7);
        goto label_25;
        label_21:
        val_25 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
        label_24:
        0.丄万三丑万丞丏下一(丙业与丙丗丝不丈东:  val_7);
        label_25:
        this.丝且与丝丒丟万丁专.丞下丒丄上丅世下丌 = val_22.丕丑与丏丌丝下上丛().丆丏业专与万丑三丂();
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  val_22, method:  System.Void TournamentController::不三东丒丟东不丝丘()));
        TournamentLeaderboard val_11 = val_22.丕丑与丏丌丝下上丛();
        val_23 = RatingSystem.与一丅丝不丈业与丙();
        if(val_11.league != val_23.与丌丛七七与东下丏())
        {
            goto label_34;
        }
        
        System.Action val_14 = null;
        val_23 = val_14;
        val_14 = new System.Action(object:  val_22, method:  System.Void TournamentController::世一丐丘丏上业东专());
        AuthSceneController.七东七不不丅下丞东(丙业与丙丗丝不丈东:  val_14);
        label_18:
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
            goto label_37;
        }
        
        val_23 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_23)) == false)
        {
            goto label_40;
        }
        
        label_37:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_25 = 1;
        return (bool)val_25;
        label_34:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Tournament: Player league was changed from progress");
        }
        
        TournamentController.下且与一万丙丗且丁();
        goto label_49;
        label_40:
        val_22.丆丛丌丁丛丂丞丘丌(丙丑七万丆万丆且丌:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        if(TournamentController.丅丑万丛丟与丆丘丈() != false)
        {
                val_26 = null;
            val_26 = null;
            val_22 = TournamentController.下世丄三且七东丅丞;
            val_22.Invoke();
        }
        
        TournamentController.丟七丟丘丒不丙世丙();
        label_49:
        val_25 = 0;
        return (bool)val_25;
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
