using UnityEngine;
[Serializable]
private class ConnectSceneRollBackMigrationBanner.BoosterSlideProps
{
    // Fields
    private UnityEngine.GameObject keysIcon;
    private UnityEngine.GameObject arrow;
    private UnityEngine.GameObject gemsIcon;
    private UILabel keys;
    private UILabel gems;
    private UnityEngine.GameObject slide;
    private int keysNum;
    private int gemsNum;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(System.Action 丑丗丂丈丐丅丁下丝)
    {
        var val_9;
        int val_10;
        var val_11;
        int val_12;
        UILabel val_13;
        if((PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝() != null) && (val_2.ConnectSceneKeyChestSmallBooster != null))
        {
                int val_3 = val_2.ConnectSceneKeyChestSmallBooster.丂丁丏一丙丛业且丌();
            val_9 = 0;
        }
        else
        {
                val_9 = 0;
        }
        
        if(((-912379272) & 1) == 0)
        {
            goto label_5;
        }
        
        val_10 = val_9.丙东专丂世丈丏丁丂();
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_5:
        val_10 = 0;
        if(this != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        this.keysNum = val_10;
        if((PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().上丈下且世丈丟丄丝() != null) && (val_6.GemsByKeyChestSmallBooster != null))
        {
                int val_7 = val_6.GemsByKeyChestSmallBooster.丂丁丏一丙丛业且丌();
            val_11 = 0;
        }
        else
        {
                val_11 = 0;
        }
        
        if(((-912379272) & 1) == 0)
        {
            goto label_13;
        }
        
        val_12 = val_11.丙东专丂世丈丏丁丂();
        if(this != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_13:
        val_12 = 0;
        if(this != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        this.gemsNum = val_12;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.keys, 丕丗丘丑丛与丑业丒:  this.keysNum);
        val_13 = this.gems;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_13, 丕丗丘丑丛与丑业丒:  0);
        if(this.keysNum != 0)
        {
                if(this.gemsNum != 0)
        {
            goto label_23;
        }
        
        }
        
        val_13 = this.slide;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
        if(丑丗丂丈丐丅丁下丝 != null)
        {
                丑丗丂丈丐丅丁下丝.Invoke();
        }
        
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.keysIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrow, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gemsIcon, 丏业丟一东丂东丘丛:  false);
    }
    internal void 业丏丑丌一丛丞丌与(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.nextBtn, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丈丁丅丈丌三丕七丗.convertBtn, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丈丁丅丈丌三丕七丗.rewardBtn, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丟丗丟业丝一一丑与()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.keysIcon, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrow, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gemsIcon, 丏业丟一东丂东丘丛:  true);
    }
    internal void 一丏丕丅丐丑且丏丐(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        ConnectSceneRollBackMigrationBanner.BoosterSlideProps.丗丛丘丑丐不丌丑丙 val_1 = new ConnectSceneRollBackMigrationBanner.BoosterSlideProps.丗丛丘丑丐不丌丑丙();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丈丁丅丈丌三丕七丗 = 丈丁丅丈丌三丕七丗;
        UnityEngine.Coroutine val_6 = CoroutineRunner.Instance.StartCoroutine(routine:  PGCompany.与三七丝丆一且东丝.一丏丕丅丐丑且丏丐(丂三丟丂丈丐丆丗丟:  1f, 丕丕世且下一与丝与:  0f, 丄丙丞丁世上丄与与:  new System.Action<System.Single>(object:  val_1, method:  System.Void ConnectSceneRollBackMigrationBanner.BoosterSlideProps.丗丛丘丑丐不丌丑丙::丑丒不丁丕上丅丛万(float 与丕丁三万专世不丅)), 丄丆丙业世丏与丞丛:  new System.Action(object:  val_1, method:  System.Void ConnectSceneRollBackMigrationBanner.BoosterSlideProps.丗丛丘丑丐不丌丑丙::丆东三丐丂丒与业下()), 丝丝万丄丏丝世三丏:  0));
    }
    public ConnectSceneRollBackMigrationBanner.BoosterSlideProps()
    {
    
    }

}
