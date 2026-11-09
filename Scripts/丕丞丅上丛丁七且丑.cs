using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丕丞丅上丛丁七且丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 上丟专下不一丗丙丆;
    public bool 七万东下丛万丁且丘;
    public bool 丝丌丆一上丙丏丁业;
    private System.Threading.Tasks.Task<Progress.丘丟丆丝丁丏丄专一> 丆万丐上丙丒丏丆下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丕丞丅上丛丁七且丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_53;
        System.Collections.IEnumerator val_54;
        int val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        System.Func<PGCompany.三丘丌上丁万丏丛丟, System.Boolean> val_62;
        var val_63;
        var val_66;
        var val_67;
        var val_68;
        val_53 = this;
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
            goto label_197;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = Progress.七七世万专丕丁上业.七丑丂丛丛丏丒丄丁();
        this.丆万丐上丙丒丏丆下 = new Progress.丗丙丒丁丈丒丅万业(丝不丄业丛三上丕丄:  CloudHashMigrationValidator.世丒丕一不丂三七万());
        val_54 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_54.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.丆万丐上丙丒丏丆下);
        val_55 = 1;
        this.丗丏丅丕丆世丁专丟 = val_55;
        return (bool)val_55;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        Progress.丘丟丆丝丁丏丄专一 val_6 = this.丆万丐上丙丒丏丆下.Result;
        if(val_6.丆丆丆不丂丑丂丙丅() == false)
        {
            goto label_13;
        }
        
        if(this.上丟专下不一丗丙丆 == 1)
        {
                val_56 = null;
            val_56 = null;
            if(ExperienceController.sharedController != 0)
        {
                if(ExperienceController.丞丞丘业东丙丏七丌() >= 2)
        {
                PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丛丏且丑丈世世丘丂();
            TrainingController.三世丈且一三且丕丌();
        }
        
        }
        
        }
        
        if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().丂专下丌丈丙专丁东(丙丄不丈专丕与万万:  "Armor_Army_1")) != ExperienceController.丞丞丘业东丙丏七丌())
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().与丁上东七丟一丞丌(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  "Armor_Army_1"), 丈丘丝一丗下丈丐不:  ExperienceController.丞丞丘业东丙丏七丌(), 世丁丙世丄一万丆三:  "clmigr");
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丑丝丝丅丝丝一七();
        Progress.下丁下丂七丆丙七一.丄丁丒一丂东丞东丏();
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                val_57 = null;
            val_57 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_58 = null;
            val_58 = null;
            MainMenuController.丄丞丁丈与业上丞丟.UpdateOldHints(丕丕世且下一与丝与:  false);
        }
        
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "gobattle");
        }
        
        val_59 = null;
        val_59 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丄丕且一东丒业不丞();
        Rilisoft.丗丄丙丁丌业丅丒丕.且丕上丝丟丞与丐丛();
        val_54 = Rilisoft.丐丌丝七下丈丒丅丗.丙丑丘不丙丆丏丂万();
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  val_54);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_55 = 1;
        return (bool)val_55;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_54 = 1152921505438208000;
        Rilisoft.丐丌丝七下丈丒丅丗.丆且业丈丆丘七且上(七万东下丛万丁且丘:  (this.七万东下丛万丁且丘 == true) ? 1 : 0, 丝丌丆一上丙丏丁业:  (this.丝丌丆一上丙丏丁业 == true) ? 1 : 0);
        val_53 = this.上丟专下不一丗丙丆;
        if(val_53 != ExperienceController.丞丞丘业东丙丏七丌())
        {
                Rilisoft.丞丛七上丕专丏丌丈.丝丁丟丏丏丐丒三丅();
        }
        
        Rilisoft.PetsManager.丄丒丕丐且专丐与东();
        Rilisoft.丐丌丝七下丈丒丅丗.丁丘丘丙下东丟万丞(丄丌丟丛丆丝东世一:  true);
        Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丞世丟丟东一下丟丄();
        if(ExperienceController.丞丞丘业东丙丏七丌() < 6)
        {
            goto label_197;
        }
        
        val_53 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_53.丗业丝万业一与三且() != 0)
        {
            goto label_197;
        }
        
        val_53 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_53.丌丑东东丒丑丁不丕() == false)
        {
            goto label_197;
        }
        
        业丈不上丟万一丕丏.丑七不且上丗丁一世().万丂丝丒丈丛世丁丌();
        val_60 = null;
        val_60 = null;
        val_62 = 丐丌丝七下丈丒丅丗.<>c.<>9__34_0;
        if(val_62 == null)
        {
                val_62 = null;
            val_62 = new System.Func<PGCompany.三丘丌上丁万丏丛丟, System.Boolean>(object:  丐丌丝七下丈丒丅丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丐丌丝七下丈丒丅丗.<>c::丗丑丕丈丆丟丕丝七(PGCompany.三丘丌上丁万丏丛丟 丁丂专业丁丅丅丈丙));
            丐丌丝七下丈丒丅丗.<>c.<>9__34_0 = val_62;
        }
        
        if((System.Linq.Enumerable.Any<PGCompany.三丘丌上丁万丏丛丟>(source:  System.Linq.Enumerable.OfType<PGCompany.三丘丌上丁万丏丛丟>(source:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  136, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})), predicate:  null)) == false)
        {
            goto label_95;
        }
        
        业丈不上丟万一丕丏.丑七不且上丗丁一世().丄丑业丝丐与世一丝();
        goto label_135;
        label_13:
        if(val_6.不三丑丟丄万丁万丞() != null)
        {
                val_53 = val_6.不三丑丟丄万丁万丞();
            if((val_53.ContainsKey(key:  "GeneralError")) != false)
        {
                val_63 = null;
            val_63 = null;
            val_53 = 与丂丏丛丞丞丒丟丄.丁一与万与丈不七丌;
            System.DateTime val_44 = System.DateTime.UtcNow;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_53, 下下丏一丙不丘丌丞:  val_44.dateData);
        }
        
        }
        
        丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        label_197:
        val_55 = 0;
        return (bool)val_55;
        label_95:
        业丈不上丟万一丕丏.丑七不且上丗丁一世().不丘七七丛丙丏丆万();
        if(ConnectScene.丈丘丂丙不丛业丟三() != false)
        {
                val_66 = static_value_081DACA8;
            val_66 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16) != 0)
        {
                val_67 = static_value_081DACA8;
            val_67 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.HandleBackBtnClicked();
        }
        
        }
        
        label_135:
        val_68 = null;
        val_68 = null;
        MainMenuController.丄丞丁丈与业上丞丟.丟丙且丝万与不丑丐();
        goto label_197;
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
