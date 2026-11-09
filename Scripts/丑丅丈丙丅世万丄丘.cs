using UnityEngine;
private sealed class Switcher.丑丅丈丙丅世万丄丘 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private float 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Switcher 丝且与丝丒丟万丁专;
    private WeaponManager 世东丞丐东万丞三丂;
    private System.Collections.Generic.IEnumerator<float> 业东东下丘丒丝业专;
    private int 丟丗丒丟丝丘丞丝丏;
    private float 丒丄丏不丐丟丒下丗;
    
    // Properties
    private float System.Collections.Generic.IEnumerator<System.Single>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Switcher.丑丅丈丙丅世万丄丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 <= 7)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 15)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 18)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 28)
        {
            goto label_3;
        }
        
        return;
        label_0:
        if((this.丗丏丅丕丆世丁专丟 + 6) > 3)
        {
            goto label_5;
        }
        
        var val_2 = 106015428;
        val_2 = (106015428 + ((this.丗丏丅丕丆世丁专丟 + 6)) << 2) + val_2;
        goto (106015428 + ((this.丗丏丅丕丆世丁专丟 + 6)) << 2 + 106015428);
        label_3:
        this.七丂丈丅丞业万丗丈();
        return;
        label_2:
        this.七三世丕业世业万丑();
        return;
        label_1:
        this.且丆与丗丏三专丅丌();
        return;
        label_5:
        if(this.丗丏丅丕丆世丁专丟 != 7)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        Rilisoft.丛业丗不丅丑业丈丛 val_300;
        var val_301;
        float val_313;
        float val_338;
        var val_339;
        int val_344;
        var val_349;
        var val_350;
        var val_351;
        var val_352;
        var val_357;
        var val_359;
        var val_361;
        var val_364;
        var val_366;
        var val_367;
        if(this.丗丏丅丕丆世丁专丟 > 39)
        {
                return (bool)val_344;
        }
        
        var val_306 = 106015444 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_306 = val_306 + 106015444;
        goto (106015444 + (this.丗丏丅丕丆世丁专丟) << 2 + 106015444);
        label_536:
        if((System.IO.File.Exists(path:  System.IO.Path.Combine(path1:  [0], path2:  "su"))) == false)
        {
            goto label_525;
        }
        
        val_350 = null;
        goto label_528;
        label_525:
        val_349 = 1;
        if(val_349 < val_182.Length)
        {
            goto label_536;
        }
        
        goto label_772;
        label_674:
        if(((mem[val_245] + 176 + 8) + -8) == null)
        {
            goto label_673;
        }
        
         =  + 1;
         =  + 16;
        if( < (mem[val_245] + 286))
        {
            goto label_674;
        }
        
        goto label_675;
        label_688:
        if(((mem[val_250] + 176 + 8) + -8) == null)
        {
            goto label_687;
        }
        
         =  + 1;
         =  + 16;
        if( < (mem[val_250] + 286))
        {
            goto label_688;
        }
        
        goto label_689;
        label_673:
         =  + (((mem[val_245] + 176 + 8)) << 4);
        val_357 =  + 296;
        label_675:
        T val_258 = Current;
        val_338 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        val_339 = 15;
        goto label_1403;
        label_687:
         =  + (((mem[val_250] + 176 + 8)) << 4);
        val_359 =  + 296;
        label_689:
        T val_259 = Current;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_300 = this.丝且与丝丒丟万丁专.业东丛丂丏下丗丘且;
        }
        else
        {
                val_300 = 36;
        }
        
        val_313 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        float val_340 = 0.01f;
        val_340 = val_313 + val_340;
        float val_260 = val_300.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  val_340);
        this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄 = val_260;
        this.丒上七丌业七丟与丐 = val_260;
        val_301 = 7;
        goto label_771;
        label_723:
        if(((mem[val_262] + 176 + 8) + -8) == null)
        {
            goto label_722;
        }
        
         =  + 1;
         =  + 16;
        if( < (mem[val_262] + 286))
        {
            goto label_723;
        }
        
        goto label_724;
        label_722:
         =  + (((mem[val_262] + 176 + 8)) << 4);
        val_361 =  + 296;
        label_724:
        T val_266 = Current;
        val_338 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        val_339 = 28;
        goto label_1403;
        label_747:
        if(((mem[val_269] + 176 + 8) + -8) == null)
        {
            goto label_746;
        }
        
         =  + 1;
         =  + 16;
        if( < (mem[val_269] + 286))
        {
            goto label_747;
        }
        
        goto label_748;
        label_746:
         =  + (((mem[val_269] + 176 + 8)) << 4);
        val_364 =  + 296;
        label_748:
        T val_274 = Current;
        val_338 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        val_339 = 18;
        goto label_1403;
        label_528:
        val_350 = null;
        int val_351 = ;
        val_351 = val_351 | 4;
        Switcher.丙万丛业专丘三丝丒 = val_351;
        goto label_772;
        label_773:
        val_351 = 123444064;
        val_352 = 8;
        if( != 1)
        {
            goto label_1410;
        }
        
        if((null & 1) == 0)
        {
            goto label_1377;
        }
        
        UnityEngine.Debug.LogException(exception:  null);
        label_772:
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_1381;
        }
        
        val_366 = null;
        val_366 = null;
        if(TwitterController.丗丘丒丈专丘丕世与 != 0)
        {
            goto label_1386;
        }
        
        if(this.丝且与丝丒丟万丁专.twitterControllerPrefab == 0)
        {
            goto label_1393;
        }
        
        UnityEngine.GameObject val_303 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.twitterControllerPrefab);
        goto label_1393;
        label_1381:
        val_367 = null;
        val_367 = null;
        val_300 = Switcher.丌不丙丞丙丌丗七上;
        float val_352 = 1000f;
        val_352 = (float)val_300.ElapsedMilliseconds / val_352;
        if(val_352 >= 0)
        {
                Switcher.丌不丙丞丙丌丗七上.Reset();
            val_300 = Switcher.丌不丙丞丙丌丗七上;
            val_300.Start();
            val_338 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
            val_339 = 27;
        }
        else
        {
                val_338 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
            val_339 = 26;
        }
        
        label_1403:
        this.丗丏丅丕丆世丁专丟 = 26;
        this.丒上七丌业七丟与丐 = val_338;
        goto label_1405;
        label_1386:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_1408;
        }
        
        label_1393:
        val_300 = this.丝且与丝丒丟万丁专.业东丛丂丏下丗丘且;
        label_1408:
        val_313 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        float val_353 = 0.03f;
        val_353 = val_313 + val_353;
        float val_305 = val_300.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  val_353);
        this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄 = val_305;
        this.丒上七丌业七丟与丐 = val_305;
        val_301 = 29;
        label_771:
        this.丗丏丅丕丆世丁专丟 = 29;
        label_1405:
        val_344 = 1;
        return (bool)val_344;
        label_1377:
        mem[8] = ;
        goto label_773;
        label_1410:
        if( == 1)
        {
                this.System.IDisposable.Dispose();
            if(mem[8] == 0)
        {
                return (bool)val_344;
        }
        
            return (bool)val_344;
        }
    
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.业东东下丘丒丝业专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.业东东下丘丒丝业专.Dispose();
    }
    private void 且丆与丗丏三专丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.业东东下丘丒丝业专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.业东东下丘丒丝业专.Dispose();
    }
    private void 七三世丕业世业万丑()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.业东东下丘丒丝业专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.业东东下丘丒丝业专.Dispose();
    }
    private void 七丂丈丅丞业万丗丈()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.业东东下丘丒丝业专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.业东东下丘丒丝业专.Dispose();
    }
    private float System.Collections.Generic.IEnumerator<System.Single>.get_Current()
    {
        return (float)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Single>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new Switcher.丑丅丈丙丅世万丄丘();
        return (System.Collections.Generic.IEnumerator<System.Single>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator();
    }

}
