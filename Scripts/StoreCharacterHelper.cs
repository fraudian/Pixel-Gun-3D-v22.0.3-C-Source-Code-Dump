using UnityEngine;
internal sealed class StoreCharacterHelper : PGBehaviour
{
    // Fields
    private AnimationCoroutineRunner _animationCoroutineRunner;
    private AnimationCoroutineRunner _petProfileAnimationRunner;
    private Rilisoft.CharacterHelper _characterHelper;
    private UICharacterPositionModyfier positionModyfier;
    private UnityEngine.Transform petPoint;
    private UnityEngine.GameObject shootButtonHolder;
    private bool usePetPointPosition;
    internal bool 万与七丕七丁丞下丆;
    internal bool showGliders;
    internal bool showTrails;
    internal bool showTransport;
    
    // Properties
    internal Rilisoft.CharacterHelper 丅专丞上丗下丌丈丟 { get; }
    internal CharacterInterfaceV2 丙世丐万丆丌上丕丘 { get; }
    internal bool 东丝丝专世丁东丗丗 { get; set; }
    
    // Methods
    internal Rilisoft.CharacterHelper 与丕丆上丛丐下丕丂()
    {
        Rilisoft.CharacterHelper val_4;
        if(this._characterHelper == 0)
        {
                this._characterHelper = this.gameObject.AddComponent<Rilisoft.CharacterHelper>();
            return val_4;
        }
        
        val_4 = this._characterHelper;
        return val_4;
    }
    internal CharacterInterfaceV2 丟丑万与丒与不下丛()
    {
        if(this.与丕丆上丛丐下丕丂().丟丑万与丒与不下丛() != 0)
        {
                CharacterInterfaceV2 val_5 = this.与丕丆上丛丐下丕丂().丟丑万与丒与不下丛();
            val_5.petPoint = this.petPoint;
            CharacterInterfaceV2 val_7 = this.与丕丆上丛丐下丕丂().丟丑万与丒与不下丛();
            val_7.usePetPointPosition = this.usePetPointPosition;
        }
        
        Rilisoft.CharacterHelper val_8 = this.与丕丆上丛丐下丕丂();
        if(val_8 != null)
        {
                return val_8.丟丑万与丒与不下丛();
        }
        
        return val_8.丟丑万与丒与不下丛();
    }
    internal bool 业丘丄专丅丈丟下丆()
    {
        Rilisoft.CharacterHelper val_1 = this.与丕丆上丛丐下丕丂();
        if(val_1 != null)
        {
                return val_1.CharacterVisible;
        }
        
        return val_1.CharacterVisible;
    }
    internal void 丛丄丘不七万丞丂丅(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        this.与丕丆上丛丐下丕丂().CharacterVisible = 丙业与丙丗丝不丈东;
    }
    internal void 专业丞丞专下丒丌下()
    {
        this._characterHelper.不丟丞丆丑丅丘丛东(东世丛丘丐下丏丄丈:  false);
    }
    internal void 丂不丅不专丆丅丌与()
    {
        this._characterHelper.丂不丅不专丆丅丌与();
    }
    internal void 丌丄丘丅万丑丆丈丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        val_1.Add(item:  丈丄不七三万丄丁不);
        this.丌丄丘丅万丑丆丈丅(丈丄不七三万丄丁不:  val_1);
    }
    internal void 丌丄丘丅万丑丆丈丅(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        var val_9;
        string val_10;
        var val_11;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_13;
        this.丟丑万与丒与不下丛().专丌丁七丆三下丈丑(七丅丞丗丁与不专丙:  丈丄不七三万丄丁不);
        PGCompany.三东丏不丗世丅丌丄 val_2 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不);
        if(val_2 == null)
        {
            goto label_2;
        }
        
        if(this.positionModyfier == null)
        {
            goto label_7;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_2);
        val_9 = 0;
        val_10 = val_2.业上丙丞丐丄丆丅七();
        goto label_6;
        label_2:
        if(this.positionModyfier == null)
        {
            goto label_7;
        }
        
        val_9 = 0;
        val_10 = 0;
        label_6:
        this.positionModyfier.SetPosition(业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false}, 丞一丁业丄一一业且:  val_10);
        label_7:
        val_11 = null;
        val_11 = null;
        val_13 = StoreCharacterHelper.<>c.<>9__21_0;
        if(val_13 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_6 = null;
            val_13 = val_6;
            val_6 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丕丌丕与丒且业专丗(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__21_0 = val_13;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButtonHolder, 丏业丟一东丂东丘丛:  ((System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_6)) != 0) ? 1 : 0);
    }
    internal void 丂丄丗丝丌丌丝世丘(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, bool 万下万丘丌丄丝丐丆 = True, bool 丙万丘丗丅万丐一世 = True)
    {
        var val_11;
        var val_12;
        System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_14;
        var val_15;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_17;
        System.Action<T> val_18;
        var val_19;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_21;
        var val_22;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_24;
        val_11 = 万下万丘丌丄丝丐丆;
        if(丈丄不七三万丄丁不 == null)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_14 = StoreCharacterHelper.<>c.<>9__22_0;
        if(val_14 == null)
        {
                System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_1 = null;
            val_14 = val_1;
            val_1 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::一与丌丈丒业丛东丌(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
            StoreCharacterHelper.<>c.<>9__22_0 = val_14;
        }
        
        int val_2 = 丈丄不七三万丄丁不.RemoveAll(match:  val_1);
        val_15 = null;
        val_15 = null;
        val_17 = StoreCharacterHelper.<>c.<>9__22_1;
        if(val_17 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_3 = null;
            val_17 = val_3;
            val_3 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丈东三丞不丛丏万不(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
            StoreCharacterHelper.<>c.<>9__22_1 = val_17;
        }
        
        System.Action<PGCompany.三东丏不丗世丅丌丄> val_5 = null;
        val_18 = val_5;
        val_5 = new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void StoreCharacterHelper::业专东丗下丒丝丈丘(PGCompany.三东丏不丗世丅丌丄 与丛丗丈七专上丕丏));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<PGCompany.三东丏不丗世丅丌丄>(丌丛丏业世丄丞三丌:  System.Linq.Enumerable.OrderByDescending<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(source:  丈丄不七三万丄丁不, keySelector:  val_3), 七丐丅专且专七三丆:  val_5);
        if(val_11 == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        val_21 = StoreCharacterHelper.<>c.<>9__22_3;
        if(val_21 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_6 = null;
            val_21 = val_6;
            val_6 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::与上丞丂万一专业丟(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
            StoreCharacterHelper.<>c.<>9__22_3 = val_21;
        }
        
        val_22 = null;
        val_11 = System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_6);
        val_22 = null;
        val_24 = StoreCharacterHelper.<>c.<>9__22_4;
        if(val_24 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_8 = null;
            val_24 = val_8;
            val_8 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::且丌丆丄丙万下东且(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
            StoreCharacterHelper.<>c.<>9__22_4 = val_24;
        }
        
        if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_8)) == false)
        {
                return;
        }
        
        if(val_11 ^ 1 == false)
        {
                return;
        }
        
        this.世与且丅下万丄丑且(下丗丁丒丘东丂不丑:  20, 七丆丒与丗丌丄且丂:  112);
    }
    internal void 东丌丟三丞世一一丑(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        int val_32;
        string val_33;
        string val_34;
        string val_35;
        string val_36;
        string val_37;
        string val_39;
        val_32 = 下丅丙一丂丗丅丝七.业东丅东丌上丗丑不();
        val_33 = 下丅丙一丂丗丅丝七;
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  val_32)) != false)
        {
                val_32 = 下丅丙一丂丗丅丝七.丑丐丙丄丅世世丑丒();
            val_33 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丐丆丅丝丂丄下业业(上七下丘一下三世丏:  val_32);
        }
        
        if(val_33 == null)
        {
            goto label_40;
        }
        
        if(null == null)
        {
            goto label_7;
        }
        
        if(null == null)
        {
            goto label_8;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        if(null == null)
        {
            goto label_10;
        }
        
        val_34 = val_33.业上丙丞丐丄丆丅七();
        this.丙丘丙不丟东且丌丏(且丘世丏丛丛万丟万:  val_34);
        goto label_40;
        label_7:
        val_34 = val_33.业上丙丞丐丄丆丅七();
        this.三且七丐与丐不丄与(三不三丟专丘东东丂:  val_34);
        goto label_40;
        label_8:
        val_34 = val_33.业上丙丞丐丄丆丅七();
        this.东与万丕丂且七上专(不丐上专丌丒丘丟丐:  val_34);
        goto label_40;
        label_9:
        if(val_33 == 12)
        {
                val_35 = val_33.业上丙丞丐丄丆丅七();
            this.丁丄丙丙丈专丆三丆(丟世丟丐且丐丟七上:  val_35, 下丈丝丁丟下世丐丒:  三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅());
        }
        
        if(val_33 == 9)
        {
                val_36 = val_33.业上丙丞丐丄丆丅七();
            this.且丘丙下七丘丄丐丑(丈丐丕业下丟业丛一:  val_36, 下丈丝丁丟下世丐丒:  三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七());
        }
        
        if(val_33 == 10)
        {
                val_37 = val_33.业上丙丞丐丄丆丅七();
            this.丑丛不丙丝东丞上丆(上世丘丐东万丐丆不:  val_37, 下丈丝丁丟下世丐丒:  三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏());
        }
        
        if(val_33 != 6)
        {
            goto label_40;
        }
        
        val_33 = val_33.业上丙丞丐丄丆丅七();
        val_34 = val_33;
        this.丛世丟万专丌丑丐丈(上丈专丌万丕丙万丘:  val_34, 下丈丝丁丟下世丐丒:  三丐下丁丒丆丘下丄.丟万三丁丙丅东三三());
        goto label_40;
        label_10:
        if(this.万与七丕七丁丞下丆 != false)
        {
                if((val_33 != 6) && (val_33 != 180000))
        {
                if(val_33 != 2100)
        {
            goto label_26;
        }
        
        }
        
            this.丞上丄丄上丞丘下丁();
        }
        
        label_26:
        if(val_33 == 190000)
        {
                val_39 = val_33.业上丙丞丐丄丆丅七();
            this.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  val_39, 东世丛丘丐下丏丄丈:  true);
            if(this.万与七丕七丁丞下丆 != false)
        {
                val_39 = 丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7);
            this.七丑世万东专丂与丏(与丙丕丛一丌丛丆丈:  val_39, 丒七丞丄丟且丂丆下:  0, 下丈丝丁丟下世丐丒:  false);
        }
        
        }
        
        if((val_33 != 6) && (val_33 != 180000))
        {
                if(val_33 != 2100)
        {
            goto label_33;
        }
        
        }
        
        val_34 = val_33.业上丙丞丐丄丆丅七();
        this.丛世丟万专丌丑丐丈(上东丞不不丄丝丗丟:  val_34);
        label_33:
        if((this.showGliders != false) && (val_33 == 160000))
        {
                val_34 = val_33.业上丙丞丐丄丆丅七();
            this.丗丒丑丗丁丝丛丂丙(丁且业丁丞下丕丄不:  val_34);
        }
        
        if((this.showTrails != false) && (val_33 == 200000))
        {
                val_34 = val_33.业上丙丞丐丄丆丅七();
            this.丆丏一下丝丛世丘丒(丅丗万丛丈不三丒丏:  val_34);
        }
        
        if((this.showTransport != false) && (val_33 == 210000))
        {
                val_34 = val_33.业上丙丞丐丄丆丅七();
            this.丑世万上专下丒丈丏(丄丄丄丕丂东丈丞丐:  val_34);
        }
        
        label_40:
        if(下丅丙一丂丗丅丝七 != null)
        {
                if(this.positionModyfier == null)
        {
                return;
        }
        
            this.positionModyfier.SetPosition(业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false}, 丞一丁业丄一一业且:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
            return;
        }
        
        if(this.positionModyfier == null)
        {
                return;
        }
        
        this.positionModyfier.SetPosition(业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false}, 丞一丁业丄一一业且:  0);
    }
    internal void 世与且丅下万丄丑且(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        var val_3;
        Rilisoft.OfferItemType val_4;
        if(下丅丙一丂丗丅丝七 == null)
        {
            goto label_1;
        }
        
        if(null != null)
        {
            goto label_2;
        }
        
        val_3 = 下丅丙一丂丗丅丝七;
        val_4 = 下丅丙一丂丗丅丝七.不业丙丒丂丞下丆丙();
        goto label_3;
        label_1:
        label_2:
        val_3 = 9961472;
        val_3 = 152;
        val_4 = 下丅丙一丂丗丅丝七.不业丙丒丂丞下丆丙();
        label_3:
        this.世与且丅下万丄丑且(下丗丁丒丘东丂不丑:  val_4, 七丆丒与丗丌丄且丂:  112);
    }
    internal void 世与且丅下万丄丑且(Rilisoft.OfferItemType 下丗丁丒丘东丂不丑, CategoryNames 七丆丒与丗丌丄且丂 = 9990000)
    {
        if(下丗丁丒丘东丂不丑 > 20)
        {
            goto label_1;
        }
        
        if(下丗丁丒丘东丂不丑 == 10)
        {
            goto label_2;
        }
        
        if(下丗丁丒丘东丂不丑 != 20)
        {
                return;
        }
        
        this.丟丑万与丒与不下丛().上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  0);
        return;
        label_1:
        if(下丗丁丒丘东丂不丑 == 70)
        {
            goto label_5;
        }
        
        if(下丗丁丒丘东丂不丑 != 1080)
        {
                return;
        }
        
        if(this.万与七丕七丁丞下丆 != false)
        {
                this.丞上丄丄上丞丘下丁();
        }
        
        if(七丆丒与丗丌丄且丂 <= 179999)
        {
            goto label_8;
        }
        
        if(七丆丒与丗丌丄且丂 > 199999)
        {
            goto label_9;
        }
        
        if(七丆丒与丗丌丄且丂 == 180000)
        {
            goto label_15;
        }
        
        if(七丆丒与丗丌丄且丂 != 190000)
        {
                return;
        }
        
        this.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  true);
        if(this.万与七丕七丁丞下丆 == false)
        {
                return;
        }
        
        this.七丑世万东专丂与丏(与丙丕丛一丌丛丆丈:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7), 丒七丞丄丟且丂丆下:  0, 下丈丝丁丟下世丐丒:  false);
        return;
        label_2:
        this.三且七丐与丐不丄与(三不三丟专丘东东丂:  0);
        return;
        label_5:
        this.东与万丕丂且七上专(不丐上专丌丒丘丟丐:  0);
        return;
        label_8:
        if(七丆丒与丗丌丄且丂 != 6)
        {
                if(七丆丒与丗丌丄且丂 != 2100)
        {
            goto label_16;
        }
        
        }
        
        label_15:
        this.丛世丟万专丌丑丐丈(上东丞不不丄丝丗丟:  0);
        label_16:
        if(七丆丒与丗丌丄且丂 != 160000)
        {
                return;
        }
        
        this.丗丒丑丗丁丝丛丂丙(丁且业丁丞下丕丄不:  System.String.alignConst);
        return;
        label_9:
        if(七丆丒与丗丌丄且丂 != 200000)
        {
                if(七丆丒与丗丌丄且丂 != 210000)
        {
                return;
        }
        
            this.丑世万上专下丒丈丏(丄丄丄丕丂东丈丞丐:  System.String.alignConst);
            return;
        }
        
        this.丆丏一下丝丛世丘丒(丅丗万丛丈不三丒丏:  System.String.alignConst);
    }
    internal void 丞上丄丄上丞丘下丁()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_1 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        val_6 = null;
        val_6 = null;
        if((StoreCharacterHelper.<>c.<>9__26_0) == null)
        {
            goto label_6;
        }
        
        label_14:
        if((val_1.Find(match:  StoreCharacterHelper.<>c.<>9__26_0)) == null)
        {
            goto label_8;
        }
        
        if(this != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        this.三且七丐与丐不丄与(三不三丟专丘东东丂:  val_2.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛());
        return;
        label_6:
        StoreCharacterHelper.<>c.<>9__26_0 = new System.Predicate<三丈丟与丏丘丈丐万>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丒不丈丄丆丑丑丐七(三丈丟与丏丘丈丐万 三丟东丕丄丄下下丑));
        if(val_1 != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_8:
        if(this != null)
        {
            goto label_15;
        }
        
        goto label_16;
    }
    internal void 东与丁丁丁丐丅丕丑(bool 下丈丝丁丟下世丐丒 = False)
    {
        bool val_2 = 下丈丝丁丟下世丐丒;
        this.丛世丟万专丌丑丐丈(上丈专丌万丕丙万丘:  丘丕万丁丞业七丛与.东专丑三丕业世业丈(), 下丈丝丁丟下世丐丒:  val_2);
        this.且丘丙下七丘丄丐丑(丈丐丕业下丟业丛一:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  9), 下丈丝丁丟下世丐丒:  val_2);
        this.丑丛不丙丝东丞上丆(上世丘丐东万丐丆不:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  10), 下丈丝丁丟下世丐丒:  val_2);
        this.丁丄丙丙丈专丆三丆(丟世丟丐且丐丟七上:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  12), 下丈丝丁丟下世丐丒:  val_2);
        this.七丑世万东专丂与丏(与丙丕丛一丌丛丆丈:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7), 丒七丞丄丟且丂丆下:  0, 下丈丝丁丟下世丐丒:  val_2);
        this.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  0, 东世丛丘丐下丏丄丈:  false);
        this.丗丒丑丗丁丝丛丂丙(丁且业丁丞下丕丄不:  System.String.alignConst);
        this.丆丏一下丝丛世丘丒(丅丗万丛丈不三丒丏:  System.String.alignConst);
        this.丑世万上专下丒丈丏(丄丄丄丕丂东丈丞丐:  System.String.alignConst);
        this.东与且不上不东且上(上东丞世三世且丈丌:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏());
    }
    internal void 三且七丐与丐不丄与(string 三不三丟专丘东东丂)
    {
        this.丟丑万与丒与不下丛().世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  三不三丟专丘东东丂);
        this.丟丑万与丒与不下丛().业不丛不丞七丕东世(七不丐下丟专业万丅:  "Profile");
        this.丟丑万与丒与不下丛().且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  丏丄丑上丛不丈且万.丘与丗业丁丞专丝世(丆万一不丌且东丐丐:  三不三丟专丘东东丂)));
    }
    internal void 丛世丟万专丌丑丐丈(string 上丈专丌万丕丙万丘, bool 下丈丝丁丟下世丐丒)
    {
        bool val_8 = 下丈丝丁丟下世丐丒;
        this.丟丑万与丒与不下丛().丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  上丈专丌万丕丙万丘);
        val_8 = (三丐下丁丒丆丘下丄.丟万三丁丙丅东三三() | val_8) ^ 1;
        this.丟丑万与丒与不下丛().不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  val_8);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  上丈专丌万丕丙万丘)) == false)
        {
                return;
        }
        
        this.丟丑万与丒与不下丛().丟丌七上业丕丈东丌(丙业与丙丗丝不丈东:  true);
    }
    internal void 且丘丙下七丘丄丐丑(string 丈丐丕业下丟业丛一, bool 下丈丝丁丟下世丐丒)
    {
        bool val_6 = 下丈丝丁丟下世丐丒;
        this.丟丑万与丒与不下丛().丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丈丐丕业下丟业丛一);
        val_6 = (三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七() | val_6) ^ 1;
        this.丟丑万与丒与不下丛().丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  val_6);
    }
    internal void 丑丛不丙丝东丞上丆(string 上世丘丐东万丐丆不, bool 下丈丝丁丟下世丐丒)
    {
        bool val_6 = 下丈丝丁丟下世丐丒;
        this.丟丑万与丒与不下丛().上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  上世丘丐东万丐丆不);
        val_6 = (三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏() | val_6) ^ 1;
        this.丟丑万与丒与不下丛().业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  val_6);
    }
    internal void 丁丄丙丙丈专丆三丆(string 丟世丟丐且丐丟七上, bool 下丈丝丁丟下世丐丒)
    {
        bool val_6 = 下丈丝丁丟下世丐丒;
        this.丟丑万与丒与不下丛().不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  丟世丟丐且丐丟七上);
        val_6 = (三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅() | val_6) ^ 1;
        this.丟丑万与丒与不下丛().丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  val_6);
    }
    internal void 七丑世万东专丂与丏(string 与丙丕丛一丌丛丆丈, string 丒七丞丄丟且丂丆下, bool 下丈丝丁丟下世丐丒)
    {
        var val_9;
        var val_10;
        string val_11;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丒七丞丄丟且丂丆下)) == false)
        {
            goto label_3;
        }
        
        PGCompany.丙丕丑丑丆丂丗丗丟 val_2 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  与丙丕丛一丌丛丆丈);
        if(val_2 == null)
        {
            goto label_6;
        }
        
        string val_4 = val_2.业上丙丞丐丄丆丅七();
        goto label_7;
        label_3:
        val_10 = this.丟丑万与丒与不下丛();
        val_11 = 丒七丞丄丟且丂丆下;
        goto label_9;
        label_6:
        val_9 = 0;
        label_7:
        val_11 = (val_9 == 0) ? 与丙丕丛一丌丛丆丈 : (val_9);
        label_9:
        this.丟丑万与丒与不下丛().上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  val_11);
        StoreCharacterHelper.丑丟业专万丂丈上丂(世丟丈丏丕万丝丆万:  this.丟丑万与丒与不下丛(), 下丈丝丁丟下世丐丒:  下丈丝丁丟下世丐丒);
    }
    internal static void 丑丟业专万丂丈上丂(CharacterInterfaceV2 世丟丈丏丕万丝丆万, bool 下丈丝丁丟下世丐丒 = False)
    {
        bool val_4 = 下丈丝丁丟下世丐丒;
        if(世丟丈丏丕万丝丆万 == 0)
        {
                return;
        }
        
        val_4 = 三丐下丁丒丆丘下丄.丟不丞丒丘丁丁丙丁() | val_4;
        世丟丈丏丕万丝丆万.丄丌丏三专丏丄丒丌(丙业与丙丗丝不丈东:  (~val_4) & 1);
    }
    internal void 丒一丛丈七丂一与世(string 丐丒丈丌与丈丏不上, bool 东世丛丘丐下丏丄丈 = True)
    {
        string val_7;
        var val_8;
        val_7 = 丐丒丈丌与丈丏不上;
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) != false) && (东世丛丘丐下丏丄丈 != false))
        {
                val_7 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        }
        
        if((System.String.op_Equality(a:  val_7, b:  "EMPTY_ROYALE_AVATAR")) != true)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == false)
        {
            goto label_10;
        }
        
        }
        
        this.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  "EMPTY_ROYALE_AVATAR");
        val_8 = null;
        val_8 = null;
        this.丙丘丙不丟东且丌丏(且丘世丏丛丛万丟万:  SkinsController.丂下丅丑丗一不东丘);
        return;
        label_10:
        this.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  val_7);
    }
    internal void 丛世丟万专丌丑丐丈(string 上东丞不不丄丝丗丟)
    {
        this.丟丑万与丒与不下丛().丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  上东丞不不丄丝丗丟);
    }
    internal void 丙丘丙不丟东且丌丏(string 且丘世丏丛丛万丟万)
    {
        var val_3;
        if(且丘世丏丛丛万丟万 != null)
        {
                val_3 = null;
            val_3 = null;
            this.丟丑万与丒与不下丛().上丈一万东三东世东(丂丒丘丅专丗丂世丛:  SkinsController.与业七丙三三万丕上.Item[且丘世丏丛丛万丟万]);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Skin id should not be null!");
    }
    internal void 丗丒丑丗丁丝丛丂丙(string 丁且业丁丞下丕丄不)
    {
        if(this._animationCoroutineRunner != null)
        {
                this._animationCoroutineRunner.StopAllCoroutines();
        }
        
        this.丟丑万与丒与不下丛().一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  丁且业丁丞下丕丄不);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  丁且业丁丞下丕丄不)) == false)
        {
                return;
        }
        
        this.丟丑万与丒与不下丛().七丛下专丙丈万丈不(丙业与丙丗丝不丈东:  true);
    }
    internal void 丆丏一下丝丛世丘丒(string 丅丗万丛丈不三丒丏)
    {
        this.丟丑万与丒与不下丛().丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  丅丗万丛丈不三丒丏);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  丅丗万丛丈不三丒丏)) == false)
        {
                return;
        }
        
        this.丟丑万与丒与不下丛().丁与世丕丑业丒丗业(丙业与丙丗丝不丈东:  true);
    }
    internal void 丑世万上专下丒丈丏(string 丄丄丄丕丂东丈丞丐)
    {
        this.丟丑万与丒与不下丛().专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  丄丄丄丕丂东丈丞丐);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  丄丄丄丕丂东丈丞丐)) == false)
        {
                return;
        }
        
        this.丟丑万与丒与不下丛().丐上七丒丂丁丏丆丑(丙业与丙丗丝不丈东:  true);
    }
    internal void 东与且不上不东且上(string 上东丞世三世且丈丌)
    {
        if(this._petProfileAnimationRunner != null)
        {
                this._petProfileAnimationRunner.StopAllCoroutines();
        }
        
        this.丟丑万与丒与不下丛().丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  上东丞世三世且丈丌, 丐丕与丈丘丌东不丈:  1);
        this.专东丁丙丞丂东丝丁();
    }
    internal void 东与万丕丂且七上专(string 不丐上专丌丒丘丟丐)
    {
        if(this._animationCoroutineRunner != null)
        {
                this._animationCoroutineRunner.StopAllCoroutines();
        }
        
        this.丟丑万与丒与不下丛().丟且丏业丈七七三与(丕丁下丌不万丅丞丛:  不丐上专丌丒丘丟丐);
        if((丁下万丟且丟丛下业.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  不丐上专丌丒丘丟丐)) == false)
        {
                return;
        }
        
        this.丟丑万与丒与不下丛().丟业不七丝七丐一丗(丙业与丙丗丝不丈东:  true);
    }
    private void 丝丂丗七丒丄丄东丐()
    {
        if(this._petProfileAnimationRunner == null)
        {
                return;
        }
        
        this._petProfileAnimationRunner.StopAllCoroutines();
    }
    private void 专东丁丙丞丂东丝丁()
    {
        System.Object[] val_18 = this;
        if(this.丟丑万与丒与不下丛() == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = this.丟丑万与丒与不下丛().丐丁丟丏丄东不丘丒();
        if(val_4 == 0)
        {
                return;
        }
        
        if(上丑三丁丄丛丁万丑.东丅三丏丂丞下上丑() == true)
        {
                return;
        }
        
        UnityEngine.Animation val_9 = val_4.GetComponent<Rilisoft.PetEngine>().下七丏不丒丗业丛专().GetComponent<UnityEngine.Animation>();
        if(this._petProfileAnimationRunner != null)
        {
                this._petProfileAnimationRunner.StopAllCoroutines();
        }
        
        if((val_9.GetClip(name:  "Profile")) == 0)
        {
                object[] val_12 = new object[1];
            val_18 = val_12;
            val_18[0] = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_4);
            UnityEngine.Debug.LogErrorFormat(format:  "Error: pet {0} has no Profile animation clip", args:  val_12);
            return;
        }
        
        if(this._petProfileAnimationRunner != 0)
        {
                if(this._petProfileAnimationRunner.gameObject.activeInHierarchy != false)
        {
                val_18 = this._petProfileAnimationRunner;
            val_18.StartPlay(丆不丝丝上一丞七业:  val_9, 七不丐下丟专业万丅:  "Profile", 丄三丗丛丑下丅丏七:  false, 丟丘丙丄丅万丏与丗:  0);
            return;
        }
        
        }
        
        val_18 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "Coroutine couldn\'t be started because the the game object \'AnimationCoroutineRunner\' is inactive! (Pet)", args:  val_18);
    }
    internal void 丑不丒丑丒不丌丄丛(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        Rilisoft.OfferItemType val_19;
        var val_25;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_27;
        var val_29;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_31;
        var val_32;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_34;
        var val_35;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_37;
        var val_38;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_40;
        var val_41;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_43;
        var val_44;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_46;
        PGCompany.三东丏不丗世丅丌丄 val_47;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        val_25 = null;
        val_25 = null;
        val_27 = StoreCharacterHelper.<>c.<>9__45_0;
        if(val_27 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_2 = null;
            val_27 = val_2;
            val_2 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丁三丞丒丈丘丞三丘(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__45_0 = val_27;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_3 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_2);
        if(val_3 != null)
        {
                val_1.Add(item:  val_3);
        }
        
        val_29 = null;
        val_29 = null;
        val_31 = StoreCharacterHelper.<>c.<>9__45_1;
        if(val_31 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_4 = null;
            val_31 = val_4;
            val_4 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::万丏丆丝丗丕丛三专(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__45_1 = val_31;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_5 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_4);
        if(val_5 != null)
        {
                val_1.Add(item:  val_5);
        }
        
        val_32 = null;
        val_32 = null;
        val_34 = StoreCharacterHelper.<>c.<>9__45_2;
        if(val_34 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_6 = null;
            val_34 = val_6;
            val_6 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丑与丟丑一世丝丗丛(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__45_2 = val_34;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_7 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_6);
        if(val_7 != null)
        {
                val_1.Add(item:  val_7);
        }
        
        val_35 = null;
        val_35 = null;
        val_37 = StoreCharacterHelper.<>c.<>9__45_3;
        if(val_37 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_8 = null;
            val_37 = val_8;
            val_8 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丟丘丏专丆丑丌丗丏(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__45_3 = val_37;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_9 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_8);
        if(val_9 != null)
        {
                val_1.Add(item:  val_9);
        }
        
        val_38 = null;
        val_38 = null;
        val_40 = StoreCharacterHelper.<>c.<>9__45_4;
        if(val_40 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_10 = null;
            val_40 = val_10;
            val_10 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丒丞与丐丙丌丁丟丌(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__45_4 = val_40;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_11 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_10);
        if(val_11 != null)
        {
                val_1.Add(item:  val_11);
        }
        
        val_41 = null;
        val_41 = null;
        val_43 = StoreCharacterHelper.<>c.<>9__45_5;
        if(val_43 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_12 = null;
            val_43 = val_12;
            val_12 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::丅丁丗万万丌一世与(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__45_5 = val_43;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_13 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_12);
        if(val_13 != null)
        {
                val_1.Add(item:  val_13);
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_14 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不);
        if(val_14 != null)
        {
                val_1.Add(item:  val_14);
        }
        
        val_44 = null;
        val_44 = null;
        val_46 = StoreCharacterHelper.<>c.<>9__45_6;
        if(val_46 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_15 = null;
            val_46 = val_15;
            val_15 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StoreCharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StoreCharacterHelper.<>c::七丑丑丌丒一丁丅丑(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            StoreCharacterHelper.<>c.<>9__45_6 = val_46;
        }
        
        val_47 = System.Linq.Enumerable.LastOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丈丄不七三万丄丁不, predicate:  val_15);
        if(val_47 != null)
        {
                val_1.Add(item:  val_47);
        }
        
        List.Enumerator<T> val_17 = val_1.GetEnumerator();
        label_59:
        if((321646720 & 1) == 0)
        {
            goto label_53;
        }
        
        string val_20 = val_19.丐丏七丌丕丗业且上();
        val_19 = val_20.不业丙丒丂丞下丆丙();
        UnityEngine.Debug.LogError(message:  val_19 + "   " + PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_20)(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_20)));
        goto label_59;
        label_53:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丂丄丗丝丌丌丝世丘(丈丄不七三万丄丁不:  val_1, 万下万丘丌丄丝丐丆:  false, 丙万丘丗丅万丐一世:  false);
    }
    public StoreCharacterHelper()
    {
        this.万与七丕七丁丞下丆 = true;
    }
    private void 业专东丗下丒丝丈丘(PGCompany.三东丏不丗世丅丌丄 与丛丗丈七专上丕丏)
    {
        this.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  与丛丗丈七专上丕丏));
    }

}
