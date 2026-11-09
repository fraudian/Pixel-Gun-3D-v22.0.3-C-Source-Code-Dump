using UnityEngine;
private sealed class ShopNGUIController.丞丐与与不丆专丆上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ShopNGUIController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopNGUIController.丞丐与与不丆专丆上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_72;
        FriendsController val_73;
        var val_74;
        var val_75;
        int val_76;
        var val_77;
        Rilisoft.BankBannersHolder val_78;
        var val_79;
        string val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        string val_86;
        var val_87;
        var val_88;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_72 = null;
        val_72 = null;
        val_73 = FriendsController.丄丞丁丈与业上丞丟;
        if(val_73 == 0)
        {
            goto label_6;
        }
        
        val_74 = null;
        val_74 = null;
        val_73 = TempItemsController.丄丞丁丈与业上丞丟;
        if(val_73 != 0)
        {
            goto label_117;
        }
        
        label_6:
        val_75 = 0;
        val_76 = 1;
        goto label_12;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((ShopNGUIController.丛世丛与丌不丈丐丐() == false) || (ExchangeWindow.与丌上丄丌丐丟丟丈() == true))
        {
            goto label_117;
        }
        
        val_77 = null;
        val_77 = null;
        if(SkinEditorController.丄丞丁丈与业上丞丟 != 0)
        {
            goto label_117;
        }
        
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() != false)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_117;
        }
        
        }
        
        if((this.丝且与丝丒丟万丁专.rentScreenPoint.childCount != 0) || (HatchEggUIBanner.丈丐丞丐上丑且丕万() == true))
        {
            goto label_117;
        }
        
        val_78 = 1152921505259880448;
        if((上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  this.丝且与丝丒丟万丁专.丗丛丐丑丛丅丞七且())) == false)
        {
            goto label_36;
        }
        
        if((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.一且丂不丈丝丗一丆()) < 1)
        {
            goto label_117;
        }
        
        new ShopNGUIController.丑丐丌丌丞丑丏丏丞() = new System.Object();
        new PGCompany.丕下丆丑万世业丈丟() = new PGCompany.丕下丆丑万世业丈丟(三万万丒丏丒不丐丙:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.万丅业丛丄丟丙丟丗());
        val_78 = this.丝且与丝丒丟万丁专.bannersHolder;
        HatchEggUIBanner.丈丛丝万丙万七丝丘(世丕丘丈丙世业东丕:  new PGCompany.丕下丆丑万世业丈丟(), 丘丒丅三丞丞丛丛丌:  val_78);
        .且丌业上丕丛世不东 = 0;
        new System.Action() = new System.Action(object:  new ShopNGUIController.丑丐丌丌丞丑丏丏丞(), method:  System.Void ShopNGUIController.丑丐丌丌丞丑丏丏丞::丙上丁丙上丛丏丅且());
        .且丌业上丕丛世不东 = new System.Action();
        HatchEggUIBanner.丑七不且上丗丁一世().丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  (ShopNGUIController.丑丐丌丌丞丑丏丏丞)[1152921539137570432].且丌业上丕丛世不东);
        goto label_117;
        label_13:
        val_79 = 0;
        return (bool)val_79;
        label_36:
        if((GameConnect.东且三丆丑世世丘丟() == true) || (GameConnect.世丐丄三三上丅七三() == true))
        {
            goto label_117;
        }
        
        if(((this.丝且与丝丒丟万丁专.royaleUnavailable != 0) && (this.丝且与丝丒丟万丁专.royaleUnavailable.activeSelf != true)) && (FriendsController.丝丗专上三不丄丑丑() != 1))
        {
                if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().与丟三三丐丝丑万业().丙万三丗丘丌业且丕() & 2147483648) == 0)
        {
                if(FriendsController.丝丗专上三不丄丑丑() >= Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().与丟三三丐丝丑万业().东丂丞业三丗业三丙())
        {
            goto label_71;
        }
        
        }
        
        }
        
        if(((FriendsController.丝丗专上三不丄丑丑() == 1) || (WeaponManager.七世丂丁丆丙丐丆丌().Count < 1)) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
        {
            goto label_117;
        }
        
        new ShopNGUIController.不丈丁业丛丟丒东且() = new System.Object();
        string val_38 = WeaponManager.业丌丗上业丏丛世丙();
        if(new ShopNGUIController.不丈丁业丛丟丒东且() == null)
        {
            goto label_84;
        }
        
        .业丞丏不丕丟丁丆丒 = val_38;
        if(val_38 != null)
        {
            goto label_85;
        }
        
        goto label_117;
        label_84:
        mem[16] = val_38;
        val_80 = mem[16];
        if(val_80 == 0)
        {
            goto label_117;
        }
        
        label_85:
        if(new ShopNGUIController.不丈丁业丛丟丒东且() == null)
        {
                val_80 = mem[16];
        }
        
        WeaponManager.三万不上上三一丟丕(丒东业不丐丑丕丄丆:  val_80, 七丆丟丗世丟且丒丆:  false, 丒三且丟丈七丈丙丏:  false, 不丌丟专丙丈丟丘专:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true});
        bool val_39 = 丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  mem[16]);
        三丅丁丗丗丝丂万且 val_40 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  mem[16]);
        val_81 = 1152921517987147792;
        bool val_71 = val_39;
        val_71 = val_71 | (WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  mem[16]));
        if(val_71 == false)
        {
            goto label_99;
        }
        
        val_82 = null;
        val_82 = null;
        if((WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  mem[16])) == false)
        {
            goto label_104;
        }
        
        label_99:
        val_83 = 0;
        if(new ShopNGUIController.不丈丁业丛丟丒东且() != null)
        {
            goto label_122;
        }
        
        goto label_106;
        label_71:
        丞丑七丙业万与七丟 val_44 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().与丟三三丐丝丑万业();
        string val_46 = 丛且丗丌丏下七下丈.丒不七丛丝丕且业丁(上丛丛丞且东且丄丘:  val_44.丙万三丗丘丌业且丕());
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_46)) == true)
        {
            goto label_117;
        }
        
        CategoryNames val_48 = val_44.一七三不丝丄丌丆丘();
        val_78 = new 丙且上东下丏丏丟下();
        val_78 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_46, 七丆丒与丗丌丄且丂:  val_48);
        this.丝且与丝丒丟万丁专.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  val_48, 与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(), 七丑业业丒七一丂丆:  false);
        this.丝且与丝丒丟万丁专.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        this.丝且与丝丒丟万丁专.不丂专三丟丞丕丂三(丞一丁业丄一一业且:  val_46, 丁丂专业丁丅丅丈丙:  val_48);
        goto label_117;
        label_104:
        val_84 = null;
        val_84 = null;
        val_83 = (~(WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  mem[16]))) & 1;
        if(new ShopNGUIController.不丈丁业丛丟丒东且() != null)
        {
            goto label_122;
        }
        
        label_106:
        label_122:
        int val_51 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  mem[16]);
        if(val_83 == 0)
        {
            goto label_125;
        }
        
        System.Func<丛且专丞丗丆丙丒万, System.Boolean> val_54 = new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  new ShopNGUIController.不丈丁业丛丟丒东且(), method:  System.Boolean ShopNGUIController.不丈丁业丛丟丒东且::丅不丐世丝丞专丝丌(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌));
        val_81 = val_55.丝丈不丗丐不丙丟丁.Count;
        if(val_55.上七不丅丈丁不丛丝 == null)
        {
            goto label_131;
        }
        
        val_85 = val_55.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.Count;
        goto label_133;
        label_125:
        val_86 = 16;
        val_87 = val_51;
        if(new ShopNGUIController.不丈丁业丛丟丒东且() != null)
        {
            goto label_142;
        }
        
        val_86 = 16;
        val_87 = val_51;
        goto label_142;
        label_131:
        val_85 = 0;
        label_133:
        if(((丙丞丟丑丗丅专丈一.丂丙丟丅七七丗丄与(丂万丏专丒下丈丂丟:  System.Linq.Enumerable.First<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  null)).Count) == (val_85 + val_81)) && (上丑三丁丄丛丁万丑.不三丛丂世且丗丑东() != false))
        {
                val_86 = val_55.下丄丈不与世丐业专;
            val_87 = 131072;
            val_87 = 2;
        }
        else
        {
                var val_62 = (new ShopNGUIController.不丈丁业丛丟丒东且() != 0) ? 1 : 0;
            val_62 = val_39 | val_62;
            var val_63 = (val_39 != true) ? "Armor_Army_1" : 16;
            var val_64 = (val_39 != true) ? 7 : (val_51);
            if(val_62 != true)
        {
                val_86 = 16;
            val_87 = val_51;
        }
        
        }
        
        label_142:
        if(val_40 != 0)
        {
                CategoryNames val_66 = (val_40.东七与与不丅丙上上() != true) ? 170000 : (val_87);
        }
        
        var val_67 = (val_66 == 190000) ? 8 : (val_66);
        val_66 = (val_67 == 180000) ? 6 : (val_67);
        new 丙且上东下丏丏丟下() = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_86, 七丆丒与丗丌丄且丂:  val_51);
        this.丝且与丝丒丟万丁专.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  val_66, 与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(), 七丑业业丒七一丂丆:  false);
        this.丝且与丝丒丟万丁专.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        this.丝且与丝丒丟万丁专.丆丗世且丆丛丏丞上(丈丌丌万上丅丌丒不:  mem[16], 七丆丒与丗丌丄且丂:  val_51);
        label_117:
        val_88 = null;
        val_88 = null;
        val_73 = FriendsController.丄丞丁丈与业上丞丟.MyWaitForSeconds(七且丆丞丌丘下世丑:  1f);
        val_76 = 2;
        label_12:
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_73);
        val_79 = 1;
        this.丗丏丅丕丆世丁专丟 = val_76;
        return (bool)val_79;
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
