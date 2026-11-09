using UnityEngine;
internal sealed class ClanInteractiveSlideTutorial : PGBehaviour
{
    // Fields
    private string[] 世且丌丕七丘东上丟;
    private string[] 与七上丕丁下丅丗丟;
    private Rilisoft.CharactersCorousel CharactersCorousel;
    
    // Methods
    private void Awake()
    {
        var val_4;
        var val_5;
        if(this.CharactersCorousel == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.Camera val_2 = cachedCamera;
        this.CharactersCorousel.Setup(专丁丘三丂丝丅不丐:  this.世且丌丕七丘东上丟.Length, 与业丞东丙丕且丏丈:  val_2);
        val_5 = 0;
        goto label_10;
        label_17:
        val_2.GetItem(世万专丛与丐丌专不:  0).丗丏三万东丏世丂丞(丛丗丅丆丕丅上丑三:  this.世且丌丕七丘东上丟[0], 丝丁不丝丌三丅且丗:  this.与七上丕丁下丅丗丟[0]);
        val_5 = 1;
        label_10:
        if(val_5 < 4)
        {
            goto label_17;
        }
        
        this.CharactersCorousel.enabled = true;
    }
    private void 丝丘与世丄丆一下上(int 丞丅上丏丂且下丅与)
    {
        this.CharactersCorousel.RotateTo(丂专丏丐且丁世丏丙:  丞丅上丏丂且下丅与);
    }
    private void OnEnable()
    {
        this.CharactersCorousel.add_OnDragStopped(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanInteractiveSlideTutorial::丝丘与世丄丆一下上(int 丞丅上丏丂且下丅与)));
    }
    private void OnDisable()
    {
        this.CharactersCorousel.remove_OnDragStopped(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanInteractiveSlideTutorial::丝丘与世丄丆一下上(int 丞丅上丏丂且下丅与)));
    }
    private void OnDestroy()
    {
        this.CharactersCorousel.remove_OnDragStopped(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanInteractiveSlideTutorial::丝丘与世丄丆一下上(int 丞丅上丏丂且下丅与)));
    }
    public ClanInteractiveSlideTutorial()
    {
        string[] val_1 = new string[4];
        val_1[0] = "avatar_iron_warrior";
        val_1[1] = "avatar_yakuza";
        val_1[2] = "avatar_log";
        val_1[3] = "avatar_street_king";
        this.世且丌丕七丘东上丟 = val_1;
        string[] val_2 = new string[4];
        val_2[0] = "lancelot";
        val_2[1] = "gems_power";
        val_2[2] = "mordred";
        val_2[3] = "luxury_beats";
        this.与七上丕丁下丅丗丟 = val_2;
    }

}
