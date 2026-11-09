using UnityEngine;
private sealed class WeaponManager.丂一丛下下丞丕丈丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponManager 丝且与丝丒丟万丁专;
    public FilterMaps 专丆丌丛东一不丑丙;
    public bool 万业丒丙丂丝丗不丈;
    private Rilisoft.丝丄丄不丏丘丝世丗 丛丟下一丘丂且丘丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponManager.丂一丛下下丞丕丈丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        object val_40;
        var val_53;
        var val_82;
        var val_86;
        var val_113;
        FilterMaps val_139;
        var val_140;
        var val_141;
        var val_142;
        var val_143;
        var val_144;
        var val_145;
        var val_146;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_148;
        var val_149;
        var val_150;
        var val_151;
        System.Func<System.String, System.Boolean> val_153;
        var val_154;
        var val_155;
        var val_156;
        var val_157;
        var val_158;
        var val_159;
        var val_160;
        var val_161;
        var val_162;
        var val_171;
        int val_172;
        var val_173;
        var val_174;
        object val_176;
        var val_177;
        var val_181;
        var val_182;
        var val_183;
        var val_184;
        var val_185;
        var val_186;
        CategoryNames val_187;
        var val_188;
        var val_189;
        int val_190;
        var val_191;
        丕丈丏丝丗下丟丅丂 val_91 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_591;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        this.丝且与丝丒丟万丁专.东业丞丁丌丟上上东(专丆丌丛东一不丑丙:  this.专丆丌丛东一不丑丙);
        val_139 = this.专丆丌丛东一不丑丙;
        this.丝且与丝丒丟万丁专.丟丆丛且丗丒丁一丏(万业丒丙丂丝丗不丈:  (this.万业丒丙丂丝丗不丈 == true) ? 1 : 0, 专丆丌丛东一不丑丙:  val_139);
        this.丝且与丝丒丟万丁专.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  0);
        val_140 = null;
        val_140 = null;
        if(WeaponManager.东丄三丆丌丟下丛一 != null)
        {
                WeaponManager.东丄三丆丌丟下丛一.Invoke();
        }
        
        this.一世丕丕业且且丅丌();
        val_141 = 0;
        this.丛丟下一丘丂且丘丞 = 0;
        return (bool)val_141;
        label_2:
        this.丗丏丅丕丆世丁专丟 = -3;
        val_142 = null;
        val_142 = null;
        val_143 = 1152921505066536960;
        val_144 = null;
        val_144 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.世丐丄三三上丅七三() == true)
        {
            goto label_30;
        }
        
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_30;
        }
        
        val_145 = null;
        val_145 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.万不丒丌丙万丗东不() == true)
        {
            goto label_30;
        }
        
        }
        
        if((((GameConnect.上丏丈七丘丁与丅丏() != true) ? (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 ^ 1) : 0) & 丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈()) == false)
        {
            goto label_31;
        }
        
        label_30:
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_33;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_183;
        }
        
        val_146 = null;
        val_146 = null;
        val_148 = WeaponManager.<>c.<>9__473_1;
        if(val_148 == null)
        {
                val_148 = null;
            val_148 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丟丏三丁与三丟丁世(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            WeaponManager.<>c.<>9__473_1 = val_148;
        }
        
        System.Action<三丅丁丗丗丝丂万且> val_17 = new System.Action<三丅丁丗丗丝丂万且>(object:  this.丝且与丝丒丟万丁专, method:  System.Void WeaponManager::丂丏丄丛一丛丝且专(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<三丅丁丗丗丝丂万且>(丌丛丏业世丄丞三丌:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  null), 七丐丅专且专七三丆:  null);
        goto label_183;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_143 = 1152921504848912384;
        if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
            goto label_49;
        }
        
        val_139 = PolygonController.一下一万丄丅丘且丑;
        if((PolygonController.一下一万丄丅丘且丑 + 24) != 0)
        {
            goto label_591;
        }
        
        label_49:
        if(this.丝且与丝丒丟万丁专.三丒世丙丙丒丝丟且 != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Simultaneous executing of WeaponManagers ResetCor_outines");
        }
        
        this.丝且与丝丒丟万丁专.三丒世丙丙丒丝丟且 = true;
        val_149 = null;
        val_149 = null;
        int val_138 = WeaponManager.三丁丆丑不且丞丅丆;
        val_138 = val_138 + 1;
        WeaponManager.三丁丆丑不且丞丅丆 = val_138;
        业丟丘一丑丗世丏丁.丑七不且上丗丁一世().丄七丐丛业丈丐丌万();
        new System.Action() = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  System.Void WeaponManager::一丛与七专丂上丂丐());
        new Rilisoft.丝丄丄不丏丘丝世丗() = new Rilisoft.丝丄丄不丏丘丝世丗(七丐丅专且专七三丆:  new System.Action());
        this.丛丟下一丘丂且丘丞 = new Rilisoft.丝丄丄不丏丘丝世丗();
        this.丗丏丅丕丆世丁专丟 = -3;
        WeaponManager.丟丙丘丄丈丟丆专丐();
        this.丝且与丝丒丟万丁专.丅丛丗丒丏丕丞丒丐 = this.专丆丌丛东一不丑丙;
        if(this.丝且与丝丒丟万丁专.myPlayerMoveC == 0)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_66;
        }
        
        }
        
        label_500:
        this.丝且与丝丒丟万丁专.丆丛丛丅上丐丌且丘(专丆丌丛东一不丑丙:  this.专丆丌丛东一不丑丙);
        if(this.丝且与丝丒丟万丁专.丅丛丗丒丏丕丞丒丐 == 3)
        {
                val_150 = null;
            val_150 = null;
            丅一丈与丄三丝丝丞 val_24 = WeaponManager.且专专丁丌丗丛且丙.Item[3];
            char[] val_26 = new char[1];
            val_26[0] = '#';
            val_151 = null;
            val_151 = null;
            val_153 = WeaponManager.<>c.<>9__473_6;
            if(val_153 == null)
        {
                val_153 = null;
            val_153 = new System.Func<System.String, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丐三与一三丅丏七三(string 丕下丅丆三丗丏丆丐));
            WeaponManager.<>c.<>9__473_6 = val_153;
        }
        
            if((System.Linq.Enumerable.Any<System.String>(source:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_24.丟丌东且上业丝丂丞).Split(separator:  val_26, options:  1), predicate:  null)) != false)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_24.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  val_24.万丏丁丟丝丛业不丕.Invoke());
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丅下三且万丟东不下().Clear();
        this.丝且与丝丒丟万丁专.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  0);
        char[] val_34 = new char[1];
        val_34[0] = '#';
        System.Collections.Generic.List<System.String> val_36 = new System.Collections.Generic.List<System.String>();
        val_154 = 0;
        goto label_95;
        label_99:
        null.Add(item:  Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_34)[0]);
        val_154 = 1;
        label_95:
        if(val_154 < val_35.Length)
        {
            goto label_99;
        }
        
        List.Enumerator<T> val_38 = this.丝且与丝丒丟万丁专.丘一丄丕不专上三丅().GetEnumerator();
        label_114:
        if((671199040 & 1) == 0)
        {
            goto label_102;
        }
        
        string val_41 = val_40.丐丏七丌丕丗业且上();
        if((this.丝且与丝丒丟万丁专.丈万东不丁与且东东(丆丐七世世且丏丐业:  val_41, 一业丆世丂世上丛丂:  null, 专丆丌丛东一不丑丙:  this.专丆丌丛东一不丑丙)) == false)
        {
            goto label_114;
        }
        
        new 三丈丟与丏丘丈丐万() = new 三丈丟与丏丘丈丐万();
        if(new 三丈丟与丏丘丈丐万() != null)
        {
                val_155 = new 三丈丟与丏丘丈丐万();
            .三丐三丞丘丕不丒专 = val_41;
        }
        else
        {
                mem[48] = val_41;
            val_155 = 48;
        }
        
        new 三丈丟与丏丘丈丐万().上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_155.丟七下专丈丏丕丈上());
        new 三丈丟与丏丘丈丐万().业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  mem[48].下世下丂丂丌丑丝世());
        this.丝且与丝丒丟万丁专.丅下三且万丟东不下().Add(item:  new 三丈丟与丏丘丈丐万());
        goto label_114;
        label_33:
        val_156 = null;
        val_156 = null;
        三丈丟与丏丘丈丐万 val_47 = this.丝且与丝丒丟万丁专.丝丟丌丛丆丅上万丑(丛丄东丙业上丈丄且:  与世丁丙且丑下丌不.与丝业丆七丐下三丐);
        label_183:
        this.丝且与丝丒丟万丁专.东业丞丁丌丟上上东(专丆丌丛东一不丑丙:  this.专丆丌丛东一不丑丙);
        val_139 = this.专丆丌丛东一不丑丙;
        this.丝且与丝丒丟万丁专.丟丆丛且丗丒丁一丏(万业丒丙丂丝丗不丈:  (this.万业丒丙丂丝丗不丈 == true) ? 1 : 0, 专丆丌丛东一不丑丙:  val_139);
        this.丝且与丝丒丟万丁专.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  0);
        val_157 = null;
        val_157 = null;
        if(WeaponManager.东丄三丆丌丟下丛一 != null)
        {
                WeaponManager.东丄三丆丌丟下丛一.Invoke();
        }
        
        this.一世丕丕业且且丅丌();
        label_591:
        val_141 = 0;
        return (bool)val_141;
        label_66:
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_51 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Values.GetEnumerator();
        label_132:
        if((671199136 & 1) == 0)
        {
            goto label_128;
        }
        
        string val_54 = val_53.丐丏七丌丕丗业且上();
        if(val_54 == null)
        {
            goto label_132;
        }
        
        val_54.且丄丂丝丈丆丄丏上(丑七丟丒丌丌万与丐:  BalanceController.丄专丅东丅上且丘七(丗丑丐丕丟丝且下丕:  val_54.业上丙丞丐丄丆丅七()));
        goto label_132;
        label_31:
        System.Collections.Generic.HashSet<System.String> val_57 = new System.Collections.Generic.HashSet<System.String>();
        System.Collections.Generic.List<TSource> val_59 = System.Linq.Enumerable.ToList<System.String>(source:  丏丄丑上丛不丈且万.丘上丆丂专业不下不());
        val_158 = 0;
        goto label_135;
        label_147:
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  val_59.Item[0])) == null)
        {
                if((this.丝且与丝丒丟万丁专.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_59.Item[0])) == false)
        {
            goto label_143;
        }
        
        }
        
        三丈丟与丏丘丈丐万 val_66 = this.丝且与丝丒丟万丁专.丝丟丌丛丆丅上万丑(丛丄东丙业上丈丄且:  val_59.Item[0]);
        label_143:
        val_158 = 1;
        label_135:
        if(val_158 < val_59.Count)
        {
            goto label_147;
        }
        
        goto label_148;
        label_128:
        val_159 = 0;
        val_160 = 0;
        val_161 = 1152921505286238208;
        goto label_149;
        label_102:
        val_162 = 0;
        goto label_150;
        label_148:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_141;
        label_150:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(1 == 1)
        {
            goto label_280;
        }
        
        if(( == 0) || (1617 != 1617))
        {
            goto label_285;
        }
        
        goto label_285;
        label_280:
        if( == 0)
        {
            goto label_285;
        }
        
        goto label_285;
        label_149:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (311 == 311))
        {
                val_159 = 0;
        }
        else
        {
                if( != 0)
        {
                val_160 = 0;
        }
        
        }
        
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_375;
        }
        
        val_171 = null;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_80 = 0x1000000028BEF000.__il2cppRuntimeField_88.Keys.GetEnumerator();
        label_352:
        if((671199104 & 1) == 0)
        {
            goto label_311;
        }
        
        int val_83 = val_82.丙东专丂世丈丏丁丂();
        if(val_83 < 100)
        {
            goto label_352;
        }
        
        List.Enumerator<T> val_84 = System.Linq.Enumerable.ToList<GadgetCategory>(source:  System.Linq.Enumerable.OfType<GadgetCategory>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))).GetEnumerator();
        label_337:
        label_325:
        if((671199072 & 1) == 0)
        {
            goto label_314;
        }
        
        int val_87 = val_86.丙东专丂世丈丏丁丂();
        string val_88 = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  val_87, 专丆丌丛东一不丑丙:  val_83);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_88)) == true)
        {
            goto label_325;
        }
        
        bool val_140 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  val_88, value: out  val_91);
        if(val_91 == 0)
        {
            goto label_325;
        }
        
        val_140 = val_140 ^ 1;
        if((val_140 == true) || ((val_91.上东丌丂丟不下丒业(专丆丌丛东一不丑丙:  val_83)) == true))
        {
            goto label_325;
        }
        
        if((val_87 == 12500) && ((丁下万丟且丟丛下业.一三专丞丒丅上业上().Item["gadget_fraggrenade"].上东丌丂丟不下丒业(专丆丌丛东一不丑丙:  val_83)) != false))
        {
                val_172 = 丁下万丟且丟丛下业.丆丏丒丆万丄且丗丛(丗丑丐丕丟丝且下丕:  "gadget_fraggrenade");
        }
        else
        {
                val_172 = System.String.alignConst;
        }
        
        丆丟七丌丞东丆丕丌.丏下丕丏丘丅与丂丐(丗丑丐丕丟丝且下丕:  val_172, 七丆丒与丗丌丄且丂:  val_87, 专丆丌丛东一不丑丙:  val_83, 且丙丄且丐上与丈丆:  true);
        goto label_337;
        label_314:
        val_173 = ;
        val_174 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (311 != 581))
        {
            goto label_349;
        }
        
        var val_141 = 0;
        val_141 = val_141 ^ 0;
         =  + val_141;
        goto label_352;
        label_349:
        if( == 0)
        {
            goto label_352;
        }
        
        goto label_352;
        label_311:
        val_176 = 0;
        val_177 =  + 1;
        mem2[0] = 609;
        var val_98 =  & 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (311 == 609))
        {
                var val_142 = 0;
            val_142 = val_142 ^ 0;
             =  + val_142;
        }
        
        label_375:
        val_181 = 0;
        goto label_385;
        label_397:
        丏丄丑上丛不丈且万.丛丐专不世丂丝与三().Item[0].且丄丂丝丈丆丄丏上(丁三东一丂丘丗丛丐:  BalanceController.丕丒丑丙与丑丈丆丈(丟丈一下东业一丝丆:  丏丄丑上丛不丈且万.丛丐专不世丂丝与三().Item[0].业东丅东丌上丗丑不()));
        val_181 = 1;
        label_385:
        if(val_181 < 丏丄丑上丛不丈且万.丛丐专不世丂丝与三().Count)
        {
            goto label_397;
        }
        
        val_182 = ;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_418;
        }
        
        val_183 = null;
        val_183 = null;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_111 = WeaponManager.且专专丁丌丗丛且丙.Keys.GetEnumerator();
        goto label_428;
        label_483:
        new WeaponManager.不丂丝丝万与丑一丑() = new System.Object();
        .丛丝丁丕不丛丙万万 = val_113.丙东专丂世丈丏丁丂();
        new WeaponManager.丗丑与丂一丛专三丘() = new System.Object();
        if(new WeaponManager.丗丑与丂一丛专三丘() != null)
        {
                val_184 = new WeaponManager.丗丑与丂一丛专三丘();
            .东丟且丗且三专丙丁 = new WeaponManager.不丂丝丝万与丑一丑();
        }
        else
        {
                mem[24] = new WeaponManager.不丂丝丝万与丑一丑();
            val_184 = 24;
        }
        
        if(.丛丝丁丕不丛丙万万 == 0)
        {
            goto label_428;
        }
        
        .业丗且丝三丞丕下且 = 0;
        val_185 = null;
        val_185 = null;
        丅一丈与丄三丝丝丞 val_118 = WeaponManager.且专专丁丌丗丛且丙.Item[.丛丝丁丕不丛丙万万];
        char[] val_120 = new char[1];
        val_120[0] = '#';
        val_186 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_118.丟丌东且上业丝丂丞).Split(separator:  val_120);
        val_187 = 0;
        goto label_450;
        label_482:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_186[0])) != true)
        {
                三丅丁丗丗丝丂万且 val_123 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_121[0x0] + 32);
            if(val_123 != null)
        {
                if((val_123.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  .丛丝丁丕不丛丙万万)) == false)
        {
            goto label_449;
        }
        
        }
        
        }
        
        val_186 = val_186;
        label_480:
        val_187 = 1;
        goto label_450;
        label_449:
        if(.丛丝丁丕不丛丙万万 == 107)
        {
                Competition.与丝丆丝丘丕七丞丒.丑七不且上丗丁一世().丒丝世专下上丞上丞(七丆丒与丗丌丄且丂:  val_187, 丝三丛且丘不丌丙下:  val_121[0x0] + 32);
        }
        
        if(this.专丆丌丛东一不丑丙 == 107)
        {
                System.String[] val_126 = new System.Func<System.String[]>(object:  new WeaponManager.丗丑与丂一丛专三丘(), method:  System.String[] WeaponManager.丗丑与丂一丛专三丘::世专且丁丘且丘丒三()).Invoke();
        }
        else
        {
                val_188 = null;
            val_188 = null;
            丅一丈与丄三丝丝丞 val_127 = WeaponManager.且专专丁丌丗丛且丙.Item[.丛丝丁丕不丛丙万万];
            char[] val_129 = new char[1];
            val_129[0] = '#';
        }
        
        val_189 = null;
        val_189 = null;
        丅一丈与丄三丝丝丞 val_131 = WeaponManager.且专专丁丌丗丛且丙.Item[.丛丝丁丕不丛丙万万];
        CategoryNames val_132 = val_123.丒万丕七专不丏丞丌();
        System.String[] val_133 = (val_127.万丏丁丟丝丛业不丕.Invoke().Split(separator:  val_129)) + (((long)(int)(val_132)) << 3);
        val_190 = mem[(val_130 + ((long)(int)(val_132)) << 3) + 32];
        val_190 = (val_130 + ((long)(int)(val_132)) << 3) + 32;
        if(val_190 == 0)
        {
                val_190 = System.String.alignConst;
        }
        
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  val_131.丟丌东且上业丝丂丞, 专丟丌丄东且上业一:  val_190, 下业丕七东丌丝下且:  val_123.丒万丕七专不丏丞丌(), 下与丙业丁世三丞丒:  false);
        goto label_480;
        label_450:
        if(val_187 < val_121.Length)
        {
            goto label_482;
        }
        
        label_428:
        if((671199104 & 1) != 0)
        {
            goto label_483;
        }
        
        goto label_484;
        label_418:
        label_570:
        if((1 & 1) == 0)
        {
            goto label_500;
        }
        
        val_191 = null;
        val_191 = null;
        if(WeaponManager.三与丂丙三专丑下丌 == null)
        {
            goto label_500;
        }
        
        WeaponManager.三与丂丙三专丑下丌.Invoke();
        goto label_500;
        label_484:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((1 == 1) || (1167 != 1167))
        {
            goto label_556;
        }
        
        if((1 & 2147483648) != 0)
        {
            goto label_570;
        }
        
        goto label_570;
        label_556:
        if( == 0)
        {
            goto label_570;
        }
        
        goto label_570;
        label_285:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_141;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丛丟下一丘丂且丘丞 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丛丟下一丘丂且丘丞.Dispose();
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
