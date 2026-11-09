using UnityEngine;
[Serializable]
private class ConnectSceneRollBackMigrationBanner.BoosterRewardSlideProps
{
    // Fields
    private UnityEngine.GameObject slide;
    private UILabel amount;
    private UnityEngine.GameObject glow;
    private int gemsNum;
    
    // Methods
    internal void 丈且东丑丂且万丒丅()
    {
        UnityEngine.GameObject val_5;
        var val_6;
        int val_7;
        val_5 = this;
        if((PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝() != null) && (val_2.GemsByKeyChestSmallBooster != null))
        {
                int val_3 = val_2.GemsByKeyChestSmallBooster.丂丁丏一丙丛业且丌();
            val_6 = 0;
        }
        else
        {
                val_6 = 0;
        }
        
        if(((-911178088) & 1) == 0)
        {
            goto label_5;
        }
        
        val_7 = val_6.丙东专丂世丈丏丁丂();
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_5:
        val_7 = 0;
        if(this != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        this.gemsNum = val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.glow, 丏业丟一东丂东丘丛:  false);
        if(this.gemsNum != 0)
        {
                return;
        }
        
        val_5 = this.slide;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
    }
    internal void 业丏丑丌一丛丞丌与(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.nextBtn, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.convertBtn, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丈丁丅丈丌三丕七丗.rewardBtn, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.amount, 丕丗丘丑丛与丑业丒:  this.gemsNum);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.glow, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Coroutine val_3 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  PGCompany.ConnectSceneRollBackMigrationBanner.丒三丐丈丏丄丝一丂(丂三丟丂丈丐丆丗丟:  2f, 丟丕丞丂一丙不丅丝:  new System.Action(object:  丈丁丅丈丌三丕七丗, method:  System.Void PGCompany.ConnectSceneRollBackMigrationBanner::丒不一丟业丗丑世丁())));
    }
    internal void 丟丗丟业丝一一丑与()
    {
    
    }
    internal void 一丏丕丅丐丑且丏丐()
    {
    
    }
    public ConnectSceneRollBackMigrationBanner.BoosterRewardSlideProps()
    {
    
    }

}
