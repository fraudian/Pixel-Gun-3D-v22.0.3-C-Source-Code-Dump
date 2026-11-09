using UnityEngine;
[Serializable]
private class ConnectSceneRollBackMigrationBanner.ChestsSlideProps
{
    // Fields
    private UISprite eventChestProgress;
    private UILabel eventChestPoints;
    private UILabel eventChestAmount;
    private UISprite superChestProgress;
    private UILabel superChestPoints;
    private UILabel superChestAmount;
    private UILabel kingChestAmount;
    private UILabel winnerChestAmount;
    private UILabel smallChestAmount;
    private UILabel fighterChestAmount;
    private UILabel kingKeys;
    private UILabel smallKeys;
    private UILabel keys;
    private System.Collections.Generic.List<UnityEngine.GameObject> animationObjects;
    private const string CountFormat = "x{0}";
    private const string PointsFormat = "{0}/{1}";
    private int _kingKeys;
    private int _smallKeys;
    private int _keys;
    private int _kingChests;
    private int _winnerChests;
    private int _smallChests;
    private int _fighterChests;
    private int _eventChests;
    private int _eventChestsPoints;
    private int _eventChestsMax;
    private int _superChests;
    private int _superChestsPoints;
    private int _superChestsMax;
    
    // Methods
    internal void 丈且东丑丂且万丒丅()
    {
        PGCompany.ConnectSceneMigrationData val_2 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._kingKeys = val_2.ConnectSceneKeyChestBig.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_5 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._smallKeys = val_5.ConnectSceneKeyChestSmall.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_8 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._keys = val_8.EventCurrency.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_11 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._kingChests = val_11.ConnectSceneChestBig.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_14 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._winnerChests = val_14.EventChestBig.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_17 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._smallChests = val_17.ConnectSceneChestSmall.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_20 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._fighterChests = val_20.EventChestMedium.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_23 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._eventChests = val_23.ConnectSceneChestEvent.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_26 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._eventChestsPoints = val_26.ConnectSceneKeyChestEvent.丂丁丏一丙丛业且丌();
        this._eventChestsMax = 1000;
        PGCompany.ConnectSceneMigrationData val_29 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._superChests = val_29.EventChestSuper.丂丁丏一丙丛业且丌();
        PGCompany.ConnectSceneMigrationData val_32 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝();
        this._superChestsPoints = val_32._eventChestSuperPoint;
        this._superChestsMax = 1000;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.kingChestAmount, 丕丗丘丑丛与丑业丒:  this._kingChests);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.winnerChestAmount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  0));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.smallChestAmount, 丕丗丘丑丛与丑业丒:  this._smallChests);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.fighterChestAmount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  0));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.eventChestAmount, 丕丗丘丑丛与丑业丒:  this._eventChests);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.eventChestPoints, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  this._eventChestsPoints, arg1:  this._eventChestsMax));
        float val_43 = (float)this._eventChestsPoints;
        val_43 = val_43 / ((float)UnityEngine.Mathf.Max(a:  this._eventChestsMax, b:  1));
        this.eventChestProgress.fillAmount = val_43;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.superChestAmount, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  0));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.superChestPoints, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  0, arg1:  this._superChestsMax));
        float val_44 = (float)UnityEngine.Mathf.Max(a:  this._superChestsMax, b:  1);
        val_44 = 0f / val_44;
        this.superChestProgress.fillAmount = val_44;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.kingKeys, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  this._kingKeys));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.smallKeys, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  this._smallKeys));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.keys, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "x{0}", arg0:  0));
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.animationObjects, 丏业丟一东丂东丘丛:  false);
    }
    internal void 业丏丑丌一丛丞丌与(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        if(丈丁丅丈丌三丕七丗 != null)
        {
                丈丁丅丈丌三丕七丗.七丄专一世丁丆世丐();
        }
        else
        {
                0.七丄专一世丁丆世丐();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.nextBtn, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.convertBtn, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丈丁丅丈丌三丕七丗.rewardBtn, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丟丗丟业丝一一丑与()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.animationObjects, 丏业丟一东丂东丘丛:  true);
    }
    internal void 一丏丕丅丐丑且丏丐(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        ConnectSceneRollBackMigrationBanner.ChestsSlideProps.且下七业七业一上丈 val_1 = new ConnectSceneRollBackMigrationBanner.ChestsSlideProps.且下七业七业一上丈();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丈丁丅丈丌三丕七丗 = 丈丁丅丈丌三丕七丗;
        UnityEngine.Coroutine val_6 = CoroutineRunner.Instance.StartCoroutine(routine:  PGCompany.与三七丝丆一且东丝.一丏丕丅丐丑且丏丐(丂三丟丂丈丐丆丗丟:  1f, 丕丕世且下一与丝与:  0f, 丄丙丞丁世上丄与与:  new System.Action<System.Single>(object:  val_1, method:  System.Void ConnectSceneRollBackMigrationBanner.ChestsSlideProps.且下七业七业一上丈::丑丒不丁丕上丅丛万(float 与丕丁三万专世不丅)), 丄丆丙业世丏与丞丛:  new System.Action(object:  val_1, method:  System.Void ConnectSceneRollBackMigrationBanner.ChestsSlideProps.且下七业七业一上丈::丆东三丐丂丒与业下()), 丝丝万丄丏丝世三丏:  0));
    }
    public ConnectSceneRollBackMigrationBanner.ChestsSlideProps()
    {
    
    }

}
