using UnityEngine;
[Serializable]
private class ConnectSceneRollBackMigrationBanner.LeaguesSlideProps
{
    // Fields
    private System.Collections.Generic.List<PGCompany.ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.LeaguesSlideModeProps> modes;
    private UILabel cups;
    private UILabel leagueLabel;
    private UISprite cup;
    private float animationTime;
    private UITexture glow;
    private float glowTime;
    private const string IconFormat = "cup{0}_1";
    private RatingSystem.RatingLeague currentLeague;
    private int currentRating;
    
    // Methods
    internal void 丈且东丑丂且万丒丅()
    {
        List.Enumerator<T> val_1 = this.modes.GetEnumerator();
        label_4:
        if(((-920688248) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().丈且东丑丂且万丒丅();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.currentLeague = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        this.currentRating = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
        RatingLeague val_9 = this.currentLeague;
        val_9 = val_9 + 1;
        this.cup.spriteName = System.String.Format(format:  "cup{0}_1", arg0:  val_9);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.cups, 丕丗丘丑丛与丑业丒:  this.currentRating);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.leagueLabel, 丕丗丘丑丛与丑业丒:  LeaguesGUIController.丈丒丞丁下且与丛且(丙丑七万丆万丆且丌:  this.currentLeague));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.glow, 丏业丟一东丂东丘丛:  false);
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
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.glow, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丟丗丟业丝一一丑与()
    {
    
    }
    internal void 一丏丕丅丐丑且丏丐(PGCompany.ConnectSceneRollBackMigrationBanner 丈丁丅丈丌三丕七丗)
    {
        var val_13;
        System.Func<LeaguesSlideModeProps, System.Int32> val_15;
        RatingLeague val_16;
        System.Collections.Generic.List<LeaguesSlideModeProps> val_17;
        ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丌丟丘丏丕丅七万丕 val_1 = new ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丌丟丘丏丕丅七万丕();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .丈丁丅丈丌三丕七丗 = 丈丁丅丈丌三丕七丗;
        mem[1152921555226315328] = this;
        if(丈丁丅丈丌三丕七丗 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        val_13 = null;
        val_13 = null;
        val_15 = ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.<>c.<>9__14_0;
        if(val_15 == null)
        {
                System.Func<LeaguesSlideModeProps, System.Int32> val_2 = null;
            val_15 = val_2;
            val_2 = new System.Func<LeaguesSlideModeProps, System.Int32>(object:  ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.<>c::丂丘丟丈七三丝丟丁(PGCompany.ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.LeaguesSlideModeProps 三丟东丕丄丄下下丑));
            ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.<>c.<>9__14_0 = val_15;
        }
        
        int val_3 = System.Linq.Enumerable.Sum<LeaguesSlideModeProps>(source:  this.modes, selector:  val_2);
        PGCompany.上丄丝东丂业上专丂 val_4 = new PGCompany.上丄丝东丂业上专丂();
        System.ValueTuple<RatingLeague, System.Int32> val_5 = val_4.不丝上七丗丘与丝不(丌丌业丙丌三丗丅丈:  val_3);
        if(val_1 == null)
        {
            goto label_10;
        }
        
        val_16 = val_1;
        .丙丑七万丆万丆且丌 = val_5.Item2;
        goto label_11;
        label_1:
        mem[16] = this;
        mem[40] = 丈丁丅丈丌三丕七丗;
        if(mem[40] != 0)
        {
            goto label_12;
        }
        
        goto label_13;
        label_10:
        val_16 = 32;
        mem[32] = val_5.Item2;
        label_11:
        .丈丐世下丞与丂专丏 = val_5.Item2 >> 32;
        val_4.丄业丙丈丞东丟丌丘(丌丌业丙丌三丗丅丈:  val_3);
        League = val_16;
        Rating = (ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丌丟丘丏丕丅七万丕)[1152921555226315312].丈丐世下丞与丂专丏;
        .上万一丈丅丏业丂不 = false;
        UnityEngine.Coroutine val_10 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  PGCompany.与三七丝丆一且东丝.一丏丕丅丐丑且丏丐(丂三丟丂丈丐丆丗丟:  this.animationTime, 丕丕世且下一与丝与:  0f, 丄丙丞丁世上丄与与:  new System.Action<System.Single>(object:  val_1, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丌丟丘丏丕丅七万丕::丆东三丐丂丒与业下(float 与丕丁三万专世不丅)), 丄丆丙业世丏与丞丛:  new System.Action(object:  val_1, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丌丟丘丏丕丅七万丕::丁与丏七丌且专丄与()), 丝丝万丄丏丝世三丏:  0));
        val_17 = this.modes;
        List.Enumerator<T> val_11 = val_17.GetEnumerator();
        label_24:
        if(((-920187416) & 1) == 0)
        {
            goto label_22;
        }
        
        0.丐丏七丌丕丗业且上().一丏丕丅丐丑且丏丐();
        goto label_24;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private System.Collections.IEnumerator 丏三丑丕丆丑丝上上(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丘丞丅丕丈东丈三丈 val_1 = new ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丘丞丅丕丈东丈三丈();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丙丑七万丆万丆且丌 = 丙丑七万丆万丆且丌;
        return (System.Collections.IEnumerator)val_1;
    }
    public ConnectSceneRollBackMigrationBanner.LeaguesSlideProps()
    {
        this.animationTime = 0.5f;
        this.glowTime = 0.3f;
    }
    private void 丝丐三上不丕与丁丄(float 与丕丁三万专世不丅)
    {
        this.glow.alpha = PGCompany.与三七丝丆一且东丝.丈世丙丅万丁下丌丒(丆丛丑世下一丐且丕:  0f, 丌丗丏丏丛东专丁且:  1f, 丙丒七丄上与丏丙丙:  与丕丁三万专世不丅);
    }
    private void 万丕丏七不世丕与丛()
    {
        this.glow.alpha = 1f;
    }
    private void 且丝丈丙丏丘专丑七(float 与丕丁三万专世不丅)
    {
        this.glow.alpha = PGCompany.与三七丝丆一且东丝.丈世丙丅万丁下丌丒(丆丛丑世下一丐且丕:  1f, 丌丗丏丏丛东专丁且:  0f, 丙丒七丄上与丏丙丙:  与丕丁三万专世不丅);
    }
    private void 丐丈与丈丈丂丑不丄()
    {
        this.glow.alpha = 0f;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.glow, 丏业丟一东丂东丘丛:  false);
    }

}
