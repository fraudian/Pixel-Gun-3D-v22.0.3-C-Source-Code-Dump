using UnityEngine;
[Serializable]
private class ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.LeaguesSlideModeProps
{
    // Fields
    private UIWidget widget;
    private UIWidget arrow;
    private UISprite progress;
    private UILabel count;
    private UITexture shield;
    private UILabel level;
    private ParticleAtraktor particles;
    private 下下丟丒三不下三丗.丞三丕丒且丗与世丄 mode;
    private float animationTime;
    private float animationDelay;
    private int <Tokens>k__BackingField;
    private int <MaxTokens>k__BackingField;
    private int <Rank>k__BackingField;
    
    // Properties
    internal int Tokens { get; set; }
    internal int MaxTokens { get; set; }
    internal int Rank { get; set; }
    
    // Methods
    internal int get_Tokens()
    {
        return (int)this.<Tokens>k__BackingField;
    }
    private void set_Tokens(int 丙业与丙丗丝不丈东)
    {
        this.<Tokens>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int get_MaxTokens()
    {
        return (int)this.<MaxTokens>k__BackingField;
    }
    private void set_MaxTokens(int 丙业与丙丗丝不丈东)
    {
        this.<MaxTokens>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int get_Rank()
    {
        return (int)this.<Rank>k__BackingField;
    }
    private void set_Rank(int 丙业与丙丗丝不丈东)
    {
        this.<Rank>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丈且东丑丂且万丒丅()
    {
        this.<Tokens>k__BackingField = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().丄且专丝丁上丌与丄(万丕丘丒丛丑一业专:  this.mode);
        this.<MaxTokens>k__BackingField = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().世丟丅丒丘丙丙且七(丐丂业丒丟七丐丗丕:  this.mode);
        this.<Rank>k__BackingField = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().且丂丗世丁丂上丈丐(丑丅丁专丅丛丁丑且:  this.mode, 丌丌业丙丌三丗丅丈:  this.<Tokens>k__BackingField);
        PGCompany.丙三上丗丝丆上且东 val_8 = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().业不丟东东丟丟一丏(专世专丟丝丌与丘上:  this.<Rank>k__BackingField);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.shield, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "RankIcons/csv2_shield_"("RankIcons/csv2_shield_") + val_8.Id));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.count, 丕丗丘丑丛与丑业丒:  this.<Tokens>k__BackingField);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.level, 丕丗丘丑丛与丑业丒:  this.<Rank>k__BackingField);
        float val_11 = (float)this.<Tokens>k__BackingField;
        val_11 = val_11 / ((float)this.<MaxTokens>k__BackingField);
        this.progress.fillAmount = val_11;
    }
    internal void 一丏丕丅丐丑且丏丐()
    {
        UnityEngine.Coroutine val_4 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  PGCompany.与三七丝丆一且东丝.一丏丕丅丐丑且丏丐(丂三丟丂丈丐丆丗丟:  this.animationTime, 丕丕世且下一与丝与:  this.animationDelay, 丄丙丞丁世上丄与与:  new System.Action<System.Single>(object:  this, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.LeaguesSlideModeProps::丁世丆丟不丌一东丂(float 与丕丁三万专世不丅)), 丄丆丙业世丏与丞丛:  0, 丝丝万丄丏丝世三丏:  new System.Action(object:  this, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.LeaguesSlideModeProps::丘丕丛丝业丐丑一丂())));
    }
    public ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.LeaguesSlideModeProps()
    {
        this.animationTime = 0.5f;
    }
    private void 丁世丆丟不丌一东丂(float 与丕丁三万专世不丅)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.count, 丕丗丘丑丛与丑业丒:  (int)UnityEngine.Mathf.Lerp(a:  (float)this.<Tokens>k__BackingField, b:  0f, t:  与丕丁三万专世不丅));
        float val_3 = (float)this.<Tokens>k__BackingField;
        val_3 = val_3 / ((float)this.<MaxTokens>k__BackingField);
        val_3 = (1f - 与丕丁三万专世不丅) * val_3;
        this.progress.fillAmount = val_3;
    }
    private void 丘丕丛丝业丐丑一丂()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.particles, 丏业丟一东丂东丘丛:  true);
        this.particles.七万丅下丘丂丒丟一().Play();
    }

}
