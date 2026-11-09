using UnityEngine;
[Serializable]
private class ConnectSceneRollBackMigrationBanner.ChestsRewardSlideProps
{
    // Fields
    private UnityEngine.GameObject glow;
    private UISprite superChestProgress;
    private UILabel superChestPoints;
    private UILabel superChests;
    private UILabel bigChests;
    private UILabel smallChests;
    private UILabel keys;
    private const string CountFormat = "x{0}";
    private const string PointsFormat = "{0}/{1}";
    
    // Methods
    internal void 丈且东丑丂且万丒丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.glow, 丏业丟一东丂东丘丛:  false);
    }
    internal void 业丏丑丌一丛丞丌与(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.glow, 丏业丟一东丂东丘丛:  true);
        PGCompany.ConnectSceneMigrationData val_2 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        float val_23 = 1000f;
        val_23 = (float)val_2._eventChestSuperPoint / val_23;
        this.superChestProgress.fillAmount = val_23;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.superChestPoints, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_2._eventChestSuperPoint, arg1:  1000));
        PGCompany.ConnectSceneMigrationData val_5 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.superChests, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  val_5.EventChestSuper.丂丁丏一丙丛业且丌()));
        PGCompany.ConnectSceneMigrationData val_9 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.bigChests, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  val_9.EventChestBig.丂丁丏一丙丛业且丌()));
        PGCompany.ConnectSceneMigrationData val_13 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.smallChests, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  val_13.EventChestMedium.丂丁丏一丙丛业且丌()));
        PGCompany.ConnectSceneMigrationData val_17 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.keys, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  val_17.EventCurrency.丂丁丏一丙丛业且丌()));
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
        UnityEngine.Coroutine val_22 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  PGCompany.ConnectSceneRollBackMigrationBanner.丒三丐丈丏丄丝一丂(丂三丟丂丈丐丆丗丟:  2f, 丟丕丞丂一丙不丅丝:  new System.Action(object:  丈丁丅丈丌三丕七丗, method:  System.Void PGCompany.ConnectSceneRollBackMigrationBanner::丒不一丟业丗丑世丁())));
    }
    internal void 丟丗丟业丝一一丑与()
    {
    
    }
    internal void 一丏丕丅丐丑且丏丐()
    {
    
    }
    public ConnectSceneRollBackMigrationBanner.ChestsRewardSlideProps()
    {
    
    }

}
