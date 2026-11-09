using UnityEngine;
private sealed class ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丘丞丅丕丈东丈三丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RatingSystem.RatingLeague 丙丑七万丆万丆且丌;
    public PGCompany.ConnectSceneRollBackMigrationBanner.LeaguesSlideProps 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectSceneRollBackMigrationBanner.LeaguesSlideProps.丘丞丅丕丈东丈三丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丙丑七万丆万丆且丌 != this.丝且与丝丒丟万丁专.currentLeague)
        {
            goto label_5;
        }
        
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_1:
        val_9 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_9;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        RatingLeague val_9 = this.丙丑七万丆万丆且丌;
        val_9 = val_9 + 1;
        this.丝且与丝丒丟万丁专.cup.spriteName = System.String.Format(format:  "cup{0}_1", arg0:  val_9);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.leagueLabel, 丕丗丘丑丛与丑业丒:  LeaguesGUIController.丈丒丞丁下且与丛且(丙丑七万丆万丆且丌:  this.丙丑七万丆万丆且丌));
        this.丒上七丌业七丟与丐 = PGCompany.与三七丝丆一且东丝.一丏丕丅丐丑且丏丐(丂三丟丂丈丐丆丗丟:  this.丝且与丝丒丟万丁专.glowTime, 丕丕世且下一与丝与:  0f, 丄丙丞丁世上丄与与:  new System.Action<System.Single>(object:  this.丝且与丝丒丟万丁专, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps::且丝丈丙丏丘专丑七(float 与丕丁三万专世不丅)), 丄丆丙业世丏与丞丛:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps::丐丈与丈丈丂丑不丄()), 丝丝万丄丏丝世三丏:  0);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_9 = 1;
        return (bool)val_9;
        label_5:
        val_9 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.glow, 丏业丟一东丂东丘丛:  true);
        this.丝且与丝丒丟万丁专.glow.alpha = 0f;
        this.丒上七丌业七丟与丐 = PGCompany.与三七丝丆一且东丝.一丏丕丅丐丑且丏丐(丂三丟丂丈丐丆丗丟:  this.丝且与丝丒丟万丁专.glowTime, 丕丕世且下一与丝与:  0f, 丄丙丞丁世上丄与与:  new System.Action<System.Single>(object:  this.丝且与丝丒丟万丁专, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps::丝丐三上不丕与丁丄(float 与丕丁三万专世不丅)), 丄丆丙业世丏与丞丛:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void ConnectSceneRollBackMigrationBanner.LeaguesSlideProps::万丕丏七不世丕与丛()), 丝丝万丄丏丝世三丏:  0);
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
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
