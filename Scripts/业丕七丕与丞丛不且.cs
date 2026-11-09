using UnityEngine;
private sealed class 七丈三丂且丗丈世一.业丕七丕与丞丛不且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.LootBoxSystem.七丈三丂且丗丈世一 丝且与丝丒丟万丁专;
    public PGCompany.三东丏不丗世丅丌丄 东丌一丟万丄丛且丗;
    public 丈下专丂丑不丑丗丁 业七丄丄丘上丌不上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 七丈三丂且丗丈世一.业丕七丕与丞丛不且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_10;
        var val_11;
        int val_12;
        var val_13;
        int val_14;
        val_10 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_11 = this.丝且与丝丒丟万丁专;
        val_12 = this.丝且与丝丒丟万丁专.上下丙一丘下一丗丗;
        mem2[0] = 1;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_14;
        }
        
        goto label_6;
        label_3:
        mem[40] = 1;
        val_11 = 44;
        val_12 = 0;
        label_4:
        mem[44] = 1;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.一三丛丅丌丒丙丆一>(丈丄不七三万丄丁不:  this.东丌一丟万丄丛且丗).丐不丐世三丕丘丆丝()) != false)
        {
                val_13 = 1;
        }
        else
        {
                bool val_4 = (mem[44] > 1) ? 1 : 0;
        }
        
        PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 val_5 = null;
        .丁丞丌与丘丝丕丈丂 = 352;
        val_5 = new PGCompany.LootBoxSystem.世七丈丆丐丕专业丗();
        if(val_5 != null)
        {
                .丁丞丌与丘丝丕丈丂 = 352;
            .七专丁丕世丏丁丘丛 = 42;
            .一万丕丑世丆七丟世 = true;
            .丗不丙丌丐世丛世丗 = val_4;
            .丈下专丂丑不丑丗丁 = this.业七丄丄丘上丌不上;
            .且丞丁丌万专万丝东 = true;
        }
        else
        {
                .丁丞丌与丘丝丕丈丂 = 352;
            .丌丟丐丞三丘三丏丈 = 98;
            mem[24] = 42;
            .丈下专丂丑不丑丗丁 = this.业七丄丄丘上丌不上;
            mem[32] = true;
            .丗不丙丌丐世丛世丗 = val_4;
            .且丞丁丌万专万丝东 = true;
        }
        
        .丆与丆专丂丐丟一与 = true;
        LootBoxBanner.ShowLootBoxUI(七丁丑丗丐专丌丝丗:  PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  this.东丌一丟万丄丛且丗, 与不丕丆丈不丙丟丛:  val_5), 丘丒丅三丞丞丛丛丌:  0);
        UniversalRewardBanner.丝七丘丌丝业一丟丁(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.LootBoxSystem.七丈三丂且丗丈世一::七丆丒万丗丘丛丛世()));
        UniversalRewardBanner.丒丏丏丛丕丐丂丛丐(丙业与丙丗丝不丈东:  new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.LootBoxSystem.七丈三丂且丗丈世一::七丆丒万丗丘丛丛世()));
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_14;
        }
        
        label_6:
        label_14:
        if(this.丝且与丝丒丟万丁专.丞丂万丄丆丈丌业丞 != false)
        {
                val_14 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_14;
            return (bool)val_14;
        }
        
        System.Action val_9 = null;
        val_10 = val_9;
        val_9 = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.LootBoxSystem.七丈三丂且丗丈世一::七丆丒万丗丘丛丛世());
        UniversalRewardBanner.丝七丘丌丝业一丟丁(丙业与丙丗丝不丈东:  val_9);
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
