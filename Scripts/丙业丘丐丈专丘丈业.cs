using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丙业丘丐丈专丘丈业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丙丈丄丟业丗上丒丛;
    public System.Threading.Tasks.TaskCompletionSource<bool> 丕丝专丙丗丙丝丌丗;
    private Rilisoft.丐丌丝七下丈丒丅丗.丛世且不丕丕东丒三 丄丌丂东丘丗一万且;
    public bool 丑丗业丝丙丁且下七;
    private System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> 东下丅世丕与丆丌丕;
    private System.Action<bool> 丒丗丑丁业丆丝与丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丙业丘丐丈专丘丈业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.TaskCompletionSource<System.Boolean> val_42;
        bool val_43;
        var val_44;
        System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_46;
        var val_47;
        var val_48;
        丐丌丝七下丈丒丅丗.丛世且不丕丕东丒三 val_50;
        float val_51;
        float val_52;
        var val_53;
        int val_55;
        System.Object[] val_56;
        string val_57;
        var val_58;
        var val_60;
        var val_62;
        var val_64;
        var val_66;
        System.Object[] val_67;
        var val_68;
        var val_69;
        val_42 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new 丐丌丝七下丈丒丅丗.丛世且不丕丕东丒三();
        this.东下丅世丕与丆丌丕 = 0;
        val_43 = this.丙丈丄丟业丗上丒丛;
        bool val_3 = (val_43 == true) ? 1 : 0;
        System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> val_4 = Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().专业丛丂丅与世上丙(与且专丏丅世丐丐丑:  val_3, 丙丈丄丟业丗上丒丛:  val_3);
        this.东下丅世丕与丆丌丕 = val_4;
        if(val_4 == null)
        {
            goto label_6;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_16;
        }
        
        }
        
        val_44 = null;
        val_44 = null;
        val_46 = 丐丌丝七下丈丒丅丗.<>c.<>9__52_0;
        if(val_46 == null)
        {
                System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_7 = null;
            val_46 = val_7;
            val_7 = new System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::不丟丌丌丁万丐专三(System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 与丕丁三万专世不丅));
            丐丌丝七下丈丒丅丗.<>c.<>9__52_0 = val_46;
        }
        
        if((System.Linq.Enumerable.Any<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  this.东下丅世丕与丆丌丕, predicate:  val_7)) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "PullCore: null futures!", args:  System.Array.Empty<System.Object>());
        }
        
        label_16:
        val_47 = 1152921505438367744;
        val_48 = null;
        val_48 = null;
        val_43 = 丐丌丝七下丈丒丅丗.<>c.<>9__52_1;
        if(val_43 == null)
        {
                System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_10 = null;
            val_43 = val_10;
            val_10 = new System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::丙丄与与不丄丅丘丞(System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 与丕丁三万专世不丅));
            丐丌丝七下丈丒丅丗.<>c.<>9__52_1 = val_43;
        }
        
        System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  System.Linq.Enumerable.Where<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  this.东下丅世丕与丆丌丕, predicate:  val_10));
        this.东下丅世丕与丆丌丕 = val_12;
        if((System.Linq.Enumerable.Count<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  val_12)) == 0)
        {
            goto label_24;
        }
        
        this.丄丌丂东丘丗一万且.丛东丏丙万三上万七 = 0f;
        this.丄丌丂东丘丗一万且.丈丁万丕下丆丗三丆 = -1.175494E-38f;
        this.丒丗丑丁业丆丝与丄 = new System.Action<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Void 丐丌丝七下丈丒丅丗.丛世且不丕丕东丒三::丗专丐丞不丅世下丏(bool 丁与丟万丄丒丗专丌));
        LifetimeEventsRaiser.丑七不且上丗丁一世().丈丒丒东下丆丙丄丌(丙业与丙丗丝不丈东:  this.丒丗丑丁业丆丝与丄);
        goto label_35;
        label_1:
        val_50 = this.丄丌丂东丘丗一万且;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_50 != null)
        {
                val_51 = this.丄丌丂东丘丗一万且.丛东丏丙万三上万七;
            val_52 = UnityEngine.Time.unscaledDeltaTime;
        }
        else
        {
                val_50 = 20;
            val_51 = 1.401298E-45f;
            float val_17 = UnityEngine.Time.unscaledDeltaTime;
            val_52 = val_17;
        }
        
        val_17 = val_52 + val_51;
        mem[20] = val_17;
        if(this.丄丌丂东丘丗一万且.丛东丏丙万三上万七 >= 50f)
        {
            goto label_44;
        }
        
        if(this.丑丗业丝丙丁且下七 != false)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
            goto label_44;
        }
        
        }
        
        label_35:
        val_47 = 1152921505438367744;
        val_53 = null;
        val_53 = null;
        val_43 = 丐丌丝七下丈丒丅丗.<>c.<>9__52_3;
        if(val_43 == null)
        {
                System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_19 = null;
            val_43 = val_19;
            val_19 = new System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::丕丐丙丕上丅丞丄万(System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 与丕丁三万专世不丅));
            丐丌丝七下丈丒丅丗.<>c.<>9__52_3 = val_43;
        }
        
        if((System.Linq.Enumerable.Any<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  this.东下丅世丕与丆丌丕, predicate:  val_19)) != false)
        {
                val_55 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_55;
            return (bool)val_55;
        }
        
        label_44:
        val_43 = LifetimeEventsRaiser.丑七不且上丗丁一世();
        val_43.丏万万丄丐上丙且下(丙业与丙丗丝不丈东:  this.丒丗丑丁业丆丝与丄);
        if((this.丑丗业丝丙丁且下七 == false) || (ShopNGUIController.丛世丛与丌不丈丐丐() == false))
        {
            goto label_52;
        }
        
        val_56 = System.Array.Empty<System.Object>();
        val_57 = "PullCore: ShopNGUIController.GuiActive";
        goto label_86;
        label_52:
        val_47 = 1152921505438367744;
        val_58 = null;
        val_58 = null;
        val_43 = 丐丌丝七下丈丒丅丗.<>c.<>9__52_4;
        if(val_43 == null)
        {
                System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_24 = null;
            val_43 = val_24;
            val_24 = new System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::丞七丙丘丄丌三专丙(System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 与丕丁三万专世不丅));
            丐丌丝七下丈丒丅丗.<>c.<>9__52_4 = val_43;
        }
        
        if((System.Linq.Enumerable.All<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  this.东下丅世丕与丆丌丕, predicate:  val_24)) == false)
        {
            goto label_61;
        }
        
        val_56 = System.Array.Empty<System.Object>();
        val_57 = "PullCore: all pulls not completed within timeout";
        goto label_86;
        label_61:
        val_60 = null;
        val_60 = null;
        val_43 = 丐丌丝七下丈丒丅丗.<>c.<>9__52_5;
        if(val_43 == null)
        {
                System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_27 = null;
            val_43 = val_27;
            val_27 = new System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::丄丂丟万上七与丕专(System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 与丕丁三万专世不丅));
            丐丌丝七下丈丒丅丗.<>c.<>9__52_5 = val_43;
        }
        
        System.Collections.Generic.List<TSource> val_29 = System.Linq.Enumerable.ToList<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  System.Linq.Enumerable.Where<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  this.东下丅世丕与丆丌丕, predicate:  val_27));
        if((val_29 == null) || (val_29.Count == 0))
        {
            goto label_71;
        }
        
        val_62 = null;
        val_62 = null;
        val_43 = 丐丌丝七下丈丒丅丗.<>c.<>9__52_6;
        if(val_43 == null)
        {
                System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_31 = null;
            val_43 = val_31;
            val_31 = new System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::丒丗丘一丅丈一一不(System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 与丕丁三万专世不丅));
            丐丌丝七下丈丒丅丗.<>c.<>9__52_6 = val_43;
        }
        
        if((System.Linq.Enumerable.Any<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  val_29, predicate:  val_31)) == false)
        {
            goto label_77;
        }
        
        label_103:
        UnityEngine.Debug.LogWarningFormat(format:  "PullCore: login failed", args:  System.Array.Empty<System.Object>());
        goto label_80;
        label_24:
        val_56 = System.Array.Empty<System.Object>();
        val_57 = "PullCore: all futres are nulls";
        goto label_86;
        label_71:
        val_56 = System.Array.Empty<System.Object>();
        val_57 = "PullCore: all futures timed out or failed or canceled";
        goto label_86;
        label_77:
        val_64 = null;
        val_64 = null;
        val_43 = 丐丌丝七下丈丒丅丗.<>c.<>9__52_7;
        if(val_43 == null)
        {
                System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean> val_36 = null;
            val_43 = val_36;
            val_36 = new System.Func<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::丙丝与上三丗且丗丝(System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 与丕丁三万专世不丅));
            丐丌丝七下丈丒丅丗.<>c.<>9__52_7 = val_43;
        }
        
        if((System.Linq.Enumerable.All<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>>(source:  val_29, predicate:  val_36)) == false)
        {
            goto label_92;
        }
        
        val_43 = System.Array.Empty<System.Object>();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_103;
        }
        
        val_66 = "PullCore: all pulls failed (futures completed)";
        val_67 = val_43;
        goto label_98;
        label_92:
        val_42 = this.丕丝专丙丗丙丝丌丗;
        val_68 = 1152921537048726688;
        val_69 = 1;
        goto label_100;
        label_6:
        val_56 = System.Array.Empty<System.Object>();
        val_57 = "PullCore: futures == null";
        label_86:
        val_67 = val_56;
        label_98:
        UnityEngine.Debug.LogErrorFormat(format:  val_57, args:  val_67);
        label_80:
        val_42 = this.丕丝专丙丗丙丝丌丗;
        val_68 = 1152921537048726688;
        val_69 = 0;
        label_100:
        val_42.SetResult(result:  false);
        label_2:
        val_55 = 0;
        return (bool)val_55;
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
