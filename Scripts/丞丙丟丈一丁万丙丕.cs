using UnityEngine;
private sealed class ClanWarUI.丞丙丟丈一丁万丙丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClanWarUI 丝且与丝丒丟万丁专;
    private ClanWarUI.丛丙丑专东东世丛世 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarUI.丞丙丟丈一丁万丙丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_17;
        var val_18;
        ClanWarUI.丛丙丑专东东世丛世 val_19;
        int val_21;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new ClanWarUI.丛丙丑专东东世丛世();
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        val_17 = 1152921525544440992;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.与丐业一丂丗与七丟>(且下丕七丙丗丄不七:  1)) != null)
        {
                不上丌世万丁丝丏丆 val_5 = this.丝且与丝丒丟万丁专.clanWarMap.丞丆丂上万丅丒丞丙(丙丐一丕丗万丁下一:  PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂());
            if(val_5 != null)
        {
                DiscreteVector2 val_6 = val_5.丞丑丟下丘三下专不();
            bool val_7 = this.丝且与丝丒丟万丁专.clanWarMap.七丞万丅一丄丛丛丝(业丄世世一世三与丝:  new System.Nullable<DiscreteVector2>() {HasValue = false});
        }
        
        }
        
        val_18 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_18.专世东丌丑丐与与业() == false)
        {
            goto label_13;
        }
        
        val_19 = this.丄丌丂东丘丗一万且;
        业丞下丞丆下丑万上.丒丂丝世丂世与丁下(丙业与丙丗丝不丈东:  false);
        PGCompany.丐丁七一丒三东万丌.丐丒下丈丈三丟丕丙();
        mem2[0] = 1;
        if(this.丝且与丝丒丟万丁专.万且下世业丑专七业 == null)
        {
            goto label_19;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        goto label_23;
        label_1:
        val_19 = this.丄丌丂东丘丗一万且;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_24;
        label_23:
        this.丝且与丝丒丟万丁专.万且下世业丑专七业.Dispose();
        label_19:
        System.IDisposable val_15 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  System.String.Format(format:  "ClanWarUi_{0}", arg0:  "tribute animation backBlocker"));
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.万且下世业丑专七业 = val_15;
        }
        else
        {
                this.丝且与丝丒丟万丁专.万且下世业丑专七业 = val_15;
        }
        
        System.Action val_16 = null;
        val_17 = val_16;
        val_16 = new System.Action(object:  mem[this.丄丌丂东丘丗一万且], method:  System.Void ClanWarUI.丛丙丑专东东世丛世::且且一丘东丁丙丈丞());
        this.丝且与丝丒丟万丁专._rewardsAnimator.东丒丑丛丂丁上丞丟(丙业与丙丗丝不丈东:  val_16);
        this.丝且与丝丒丟万丁专._rewardsAnimator.下与丞三丅丛丄七丕(上业丟世三与七七三:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丑丕丝业三丗世不业());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._touchBlocker, 丏业丟一东丂东丘丛:  true);
        label_24:
        val_18 = mem[this.丄丌丂东丘丗一万且];
        if((mem[this.丄丌丂东丘丗一万且] + 16) != 0)
        {
                val_21 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_21;
            return (bool)val_21;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._touchBlocker, 丏业丟一东丂东丘丛:  false);
        this.丝且与丝丒丟万丁专.丗业丗丁且七丐三丛();
        label_13:
        val_21 = 0;
        return (bool)val_21;
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
