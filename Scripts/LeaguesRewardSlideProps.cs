using UnityEngine;
[Serializable]
private class ConnectSceneRollBackMigrationBanner.LeaguesRewardSlideProps
{
    // Fields
    private UnityEngine.GameObject glow;
    private UILabel leagueLabel;
    private UILabel cups;
    private UISprite cup;
    private const string IconFormat = "cup{0}_1";
    internal RatingSystem.RatingLeague League;
    internal int Rating;
    
    // Methods
    internal void 丈且东丑丂且万丒丅()
    {
        this.League = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        this.Rating = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.glow, 丏业丟一东丂东丘丛:  false);
    }
    internal void 业丏丑丌一丛丞丌与(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.leagueLabel, 丕丗丘丑丛与丑业丒:  LeaguesGUIController.丈丒丞丁下且与丛且(丙丑七万丆万丆且丌:  this.League));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.cups, 丕丗丘丑丛与丑业丒:  this.Rating);
        RatingLeague val_6 = this.League;
        val_6 = val_6 + 1;
        this.cup.spriteName = System.String.Format(format:  "cup{0}_1", arg0:  val_6);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.glow, 丏业丟一东丂东丘丛:  true);
        if(丈丁丅丈丌三丕七丗 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.nextBtn, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  152, 丏业丟一东丂东丘丛:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.convertBtn, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丈丁丅丈丌三丕七丗.rewardBtn, 丏业丟一东丂东丘丛:  false);
        UnityEngine.Coroutine val_5 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  PGCompany.ConnectSceneRollBackMigrationBanner.丒三丐丈丏丄丝一丂(丂三丟丂丈丐丆丗丟:  2f, 丟丕丞丂一丙不丅丝:  new System.Action(object:  丈丁丅丈丌三丕七丗, method:  System.Void PGCompany.ConnectSceneRollBackMigrationBanner::丒不一丟业丗丑世丁())));
    }
    internal void 丟丗丟业丝一一丑与()
    {
    
    }
    internal void 一丏丕丅丐丑且丏丐()
    {
    
    }
    public ConnectSceneRollBackMigrationBanner.LeaguesRewardSlideProps()
    {
    
    }

}
