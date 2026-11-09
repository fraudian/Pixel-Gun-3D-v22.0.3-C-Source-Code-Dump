using UnityEngine;
internal sealed class CompetitionSelectPanel : PGBehaviour
{
    // Fields
    private UILabel competitionScoreLabel;
    private UILabel leaguePlaceLabel;
    private UISprite leagueIcon;
    private UnityEngine.GameObject noCompetitionMatches;
    private UnityEngine.GameObject competitionOnHold;
    private PGCompany.TimerUI competitionOnHoldTimer;
    private bool 丄丌丄与丘丑丈丄丐;
    
    // Methods
    private void 丅丗丕丄丄丌丘丘一()
    {
        this.competitionOnHoldTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  TournamentController.丝丘丙丙世丁丈丟世() - PixelTime.丙丅丅业丟丁世丁丗(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    private void OnEnable()
    {
        if(this.丄丌丄与丘丑丈丄丐 == false)
        {
                return;
        }
        
        this.丅丗丕丄丄丌丘丘一();
    }
    private void Update()
    {
        string val_22;
        string val_23;
        var val_24;
        var val_25;
        var val_26;
        if((((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 2) ? 1 : 0) != ((this.丄丌丄与丘丑丈丄丐 == true) ? 1 : 0))
        {
                且丛丈丒万与丁丟丟 val_6 = Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁();
            this.丄丌丄与丘丑丈丄丐 = (val_6 == 2) ? 1 : 0;
            this.competitionOnHold.SetActive(value:  (val_6 == 2) ? 1 : 0);
            if(this.丄丌丄与丘丑丈丄丐 != false)
        {
                this.丅丗丕丄丄丌丘丘一();
        }
        
        }
        
        int val_10 = Rilisoft.Singleton<TournamentController>.Instance.下丐丕东七丞丅丙丝();
        if(val_10 != 0)
        {
                val_22 = val_10.ToString();
        }
        else
        {
                val_22 = "?";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.leaguePlaceLabel, 丕丗丘丑丛与丑业丒:  val_22);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.competitionScoreLabel, 丕丗丘丑丛与丑业丒:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅().ToString());
        val_23 = System.String.Format(format:  "cup{0}_1", arg0:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏() + 1);
        this.leagueIcon.spriteName = val_23;
        if(this.丄丌丄与丘丑丈丄丐 == true)
        {
            goto label_21;
        }
        
        val_23 = 1152921505052479488;
        val_24 = static_value_081DACA8;
        val_24 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
            goto label_21;
        }
        
        val_25 = static_value_081DACA8;
        val_25 = static_value_081DACA8;
        var val_21 = ((static_value_081DACA8 + 184 + 16.上丕东万与一专丂业()) == 0) ? 1 : 0;
        if(this.noCompetitionMatches != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_21:
        val_26 = 0;
        if(this.noCompetitionMatches != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        this.noCompetitionMatches.SetActive(value:  false);
    }
    public void InfoBtnClicked()
    {
        CompetitionSelectPanel.专世且东丆上丂丙与();
    }
    internal static void 专世且东丆上丂丙与()
    {
        .Type = 8;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌())) == null)
        {
                return;
        }
        
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public CompetitionSelectPanel()
    {
    
    }

}
