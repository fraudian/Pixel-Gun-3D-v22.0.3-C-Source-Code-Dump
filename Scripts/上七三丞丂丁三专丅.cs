using UnityEngine;
private sealed class ConnectScene.上七三丞丂丁三专丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ConnectScene 丝且与丝丒丟万丁专;
    private System.Linq.ILookup<int, Rilisoft.七丕丟丏三丈一丄世> 丘丘与一丕三业丘七;
    private System.Collections.Generic.List<int> 丄与业丙万一丂丐业;
    private int 丝丝丄业丞丄七上与;
    private int 业专不丆丁丈丏下七;
    private BtnCategory 丌七一万三丗且与丐;
    private System.Collections.Generic.List.Enumerator<int> 丑不专丒丆丛七不业;
    private System.Collections.Generic.IEnumerator<Rilisoft.七丕丟丏三丈一丄世> 丟不丛丙丒万一下东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectScene.上七三丞丂丁三专丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(((this.丗丏丅丕丆世丁专丟 - 3) < 2) || (this.丗丏丅丕丆世丁专丟 == 4))
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 3)
        {
            goto label_4;
        }
        
        return;
        label_1:
        this.且丆与丗丏三专丅丌();
        label_4:
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_82;
        int val_123;
        BtnCategory val_125;
        List.Enumerator<System.Int32> val_126;
        int val_127;
        var val_129;
        var val_131;
        System.Collections.Generic.IEnumerable<TSource> val_134;
        var val_136;
        ConnectScene val_137;
        var val_140;
        var val_141;
        int val_143;
        var val_144;
        var val_145;
        var val_147;
        var val_151;
        int val_152;
        var val_153;
        var val_158;
        var val_161;
        var val_164;
        var val_168;
        var val_171;
        var val_172;
        var val_175;
        var val_176;
        var val_177;
        ConnectScene val_178;
        var val_179;
        if(this.丗丏丅丕丆世丁专丟 > 4)
        {
            goto label_524;
        }
        
        var val_139 = 106032640 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_139 = val_139 + 106032640;
        goto (106032640 + (this.丗丏丅丕丆世丁专丟) << 2 + 106032640);
        label_144:
        this.丗丏丅丕丆世丁专丟 = -4;
        label_22:
        var val_140 = 0;
        val_140 = val_140 + 1;
        if(this.丟不丛丙丒万一下东.MoveNext() == false)
        {
            goto label_7;
        }
        
        static_value_081DCFA0 = new System.Object();
        var val_141 = 0;
        val_141 = val_141 + 1;
        mem2[0] = this.丟不丛丙丒万一下东.Current;
        static_value_081DCFA8 = new System.Predicate<BtnCategory>(object:  static_value_081DCFA0, method:  System.Boolean ConnectScene.万业丙下丈一丛丈丄::丁世丙丑下且三丝丘(BtnCategory 丌丗丏丏丛东专丁且));
        int val_7 = System.Array.FindIndex<BtnCategory>(array:  this.丝且与丝丒丟万丁专.connectSceneMainMenu.modeButtonByLevel, match:  static_value_081DCFA8);
        if(((val_7 & 2147483648) != 0) || (this.丝丝丄业丞丄七上与 == 0))
        {
            goto label_22;
        }
        
        if((this.丝且与丝丒丟万丁专.UnlockGameModes.Contains(item:  static_value_081DCFA0 + 16)) == true)
        {
            goto label_22;
        }
        
        this.丝且与丝丒丟万丁专.万丛丛丙一下丌丒一(上且丗一丏丏万丅丌:  static_value_081DCFA0 + 16);
        if(this.丝且与丝丒丟万丁专.connectSceneMainMenu.modeButtonByLevel[(long)(int)(val_7)][0].unlocksController != null)
        {
                this.丝且与丝丒丟万丁专.connectSceneMainMenu.modeButtonByLevel[(long)(int)(val_7)][0].unlocksController.丅东丌业丁丞丕丒丆();
        }
        
        this.丝且与丝丒丟万丁专.connectSceneMainMenu.modeButtonByLevel[(long)val_7].isEnable = true;
        this.丒上七丌业七丟与丐 = 0;
        val_123 = 4;
        goto label_145;
        label_535:
        if((mem[this.丌七一万三丗且与丐] + 240.丅丈上丕丂与丏丝丛(丆世业世上丄丈下下:  this.丝且与丝丒丟万丁专)) == false)
        {
            goto label_39;
        }
        
        val_126 = mem[mem[this.丌七一万三丗且与丐] + 240];
        val_126 = mem[this.丌七一万三丗且与丐] + 240;
        float val_16 = val_126.丐丏丌丟丆且丒丙一();
        if(val_16 <= 0f)
        {
            goto label_535;
        }
        
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  val_16);
        val_127 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
        this.丗丏丅丕丆世丁专丟 = val_127;
        return (bool)val_127;
        label_161:
        val_129 = 1152921505061052416;
        val_126 = this.丑不专丒丆丛七不业;
        label_56:
        if((val_126 & 1) == 0)
        {
            goto label_50;
        }
        
        int val_21 = val_126.丙东专丂世丈丏丁丂();
        this.业专不丆丁丈丏下七 = val_21;
        if(val_21 <= )
        {
                if( != 0)
        {
            goto label_56;
        }
        
        }
        
        mem2[0] = val_21;
        if(val_21 > ExperienceController.丂丂下丑且下丌丝东())
        {
            goto label_50;
        }
        
        var val_143 = 0;
        val_143 = val_143 + 1;
        val_131 = public System.Collections.Generic.IEnumerable<TElement> System.Linq.ILookup<TKey, TElement>::get_Item(TKey key);
        if(this.丘丘与一丕三业丘七.Item[null] == null)
        {
            goto label_56;
        }
        
        var val_144 = 0;
        val_144 = val_144 + 1;
        val_131 = 1;
        goto label_61;
        label_50:
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        BannerWindowController.与丅与丒丅专丙丐丗().AddBannersTimeout(丆丐七丅丆丗丛上与:  -1f);
        goto label_524;
        label_118:
        val_137 = this.丝且与丝丒丟万丁专;
        var val_147 = 0;
        val_147 = val_147 + 1;
        if(MoveNext() == false)
        {
            goto label_106;
        }
        
        var val_148 = 0;
        val_148 = val_148 + 1;
        T val_55 = Current;
        var val_151 = val_55;
        if((val_55 + 286) == 0)
        {
            goto label_116;
        }
        
        var val_149 = val_55 + 176;
        var val_150 = 0;
        val_149 = val_149 + 8;
        label_115:
        if(((val_55 + 176 + 8) + -8) == null)
        {
            goto label_114;
        }
        
        val_150 = val_150 + 1;
        val_149 = val_149 + 16;
        if(val_150 < (val_55 + 286))
        {
            goto label_115;
        }
        
        goto label_116;
        label_114:
        val_151 = val_151 + (((val_55 + 176 + 8)) << 4);
        val_140 = val_151 + 296;
        label_116:
        this.丄与业丙万一丂丐业.Add(item:  val_55.Key);
        goto label_118;
        label_7:
        this.且丆与丗丏三专丅丌();
        this.丟不丛丙丒万一下东 = 0;
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == true)
        {
            goto label_161;
        }
        
        System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_58 = 丐丄丞世丂丄丛不一.七三世丂丛丙丅七业(上丕丈丞丌丘丅不与:  this.丝丝丄业丞丄七上与);
        if(val_58.Value.GetHashCode() != 1)
        {
            goto label_161;
        }
        
        val_141 = 0;
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  20)) == false)
        {
            goto label_126;
        }
        
        val_141 = 0;
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  0)) == true)
        {
            goto label_161;
        }
        
        label_126:
        var val_152 = 0;
        val_152 = val_152 + 1;
        val_141 = 1;
        goto label_135;
        label_39:
        val_143 = this.业专不丆丁丈丏下七;
        goto label_136;
        label_106:
        val_144 = 0;
        val_145 = 0;
        if( != null)
        {
            goto label_137;
        }
        
        goto label_247;
        label_61:
        var val_153 = 0;
        val_153 = val_153 + 1;
        this.丟不丛丙丒万一下东 = this.丘丘与一丕三业丘七.Item[null].GetEnumerator();
        goto label_144;
        label_135:
        if((System.Linq.Enumerable.Contains<Rilisoft.七丕丟丏三丈一丄世>(source:  this.丘丘与一丕三业丘七.Item[null], value:  20)) != true)
        {
                if((this.丝且与丝丒丟万丁专.UnlockGameModes.Contains(item:  20)) == true)
        {
            goto label_161;
        }
        
        }
        
        bool val_74 = this.丝且与丝丒丟万丁专.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this.丝且与丝丒丟万丁专.connectSceneSelectMap.selectMap, 下下丁一下丒业丄业:  true);
        UIButton val_75 = this.丝且与丝丒丟万丁专.connectSceneMainMenu.goBtn.GetComponent<UIButton>();
        bool val_76 = val_74;
        if(val_74 != true)
        {
                HintController val_77 = HintController.与一丅丝不丈业与丙();
            val_77.东丏一丁下丄丙丙丂();
        }
        
        val_147 = static_value_081DACA8;
        val_147 = static_value_081DACA8;
        mem2[0] = 1;
        goto label_161;
        label_137:
        var val_156 = X23;
        if((X23 + 286) == 0)
        {
            goto label_251;
        }
        
        var val_154 = X23 + 176;
        var val_155 = 0;
        val_154 = val_154 + 8;
        label_250:
        if(((X23 + 176 + 8) + -8) == null)
        {
            goto label_249;
        }
        
        val_155 = val_155 + 1;
        val_154 = val_154 + 16;
        if(val_155 < (X23 + 286))
        {
            goto label_250;
        }
        
        goto label_251;
        label_249:
        val_156 = val_156 + (((X23 + 176 + 8)) << 4);
        val_151 = val_156 + 296;
        label_251:
        X23.Dispose();
        label_247:
        if( != 1)
        {
                val_144 = 0;
        }
        else
        {
                val_145 = 0;
        }
        
        this.丄与业丙万一丂丐业.Sort();
        if(UnlockGameModes.Count == 0)
        {
            goto label_259;
        }
        
        List.Enumerator<T> val_80 = this.丄与业丙万一丂丐业.GetEnumerator();
        val_152 = 0;
        label_306:
        label_263:
        if(((-262852208) & 1) == 0)
        {
            goto label_305;
        }
        
        val_153 = public System.Int32 System.Collections.Generic.List<System.Int32>::get_Item(int index);
        if(val_82.丙东专丂世丈丏丁丂() == this.丄与业丙万一丂丐业.Item[0])
        {
            goto label_263;
        }
        
        var val_157 = 0;
        val_157 = val_157 + 1;
        val_153 = 1;
        var val_158 = 0;
        val_158 = val_158 + 1;
        System.Collections.Generic.IEnumerator<T> val_88 = this.丘丘与一丕三业丘七.Item[null].GetEnumerator();
        label_287:
        val_152 = val_152;
        var val_159 = 0;
        val_159 = val_159 + 1;
        if(val_88.MoveNext() == false)
        {
            goto label_279;
        }
        
        var val_160 = 0;
        val_160 = val_160 + 1;
        val_136 = 1152921504691191808;
        val_134 = this.丝丝丄业丞丄七上与;
        if((this.丝且与丝丒丟万丁专.UnlockGameModes.Contains(item:  val_88.Current)) == true)
        {
            goto label_287;
        }
        
        val_158 = 1;
        val_152 = val_152;
        goto label_288;
        label_279:
        val_158 = 0;
        label_288:
        if(val_88 == null)
        {
            
        }
        else
        {
                var val_161 = 0;
            val_161 = val_161 + 1;
            val_88.Dispose();
        }
        
        var val_163 = 1;
        if(val_163 == 1)
        {
            goto label_301;
        }
        
        var val_162 = 0;
        val_162 = val_162 ^ 0;
        val_163 = val_163 + val_162;
        goto label_302;
        label_301:
        if( == false)
        {
            goto label_303;
        }
        
        val_137 = this.丝且与丝丒丟万丁专;
        if(( & 1) == 0)
        {
            goto label_306;
        }
        
        goto label_305;
        label_303:
        label_302:
        val_137 = this.丝且与丝丒丟万丁专;
        if(( & 1) == 0)
        {
            goto label_306;
        }
        
        label_305:
        val_145 = 0;
        val_144 = val_163 + 1;
        mem2[0] = 630;
        val_161 = 1152921504691138560;
        goto label_307;
        label_259:
        val_161 = 1152921504691138560;
        val_152 = 0;
        goto label_325;
        label_307:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && ((1152921505052745728 + ((1 + (0 ^ 0))) << 2) == 630))
        {
                var val_164 = 0;
            val_164 = val_164 ^ ( >> 31);
            val_144 =  + val_164;
        }
        else
        {
                if( != 0)
        {
                val_145 = 0;
        }
        
        }
        
        label_325:
        this.丝丝丄业丞丄七上与 = val_152;
        int val_167 = this.丝丝丄业丞丄七上与;
        if((this.丝丝丄业丞丄七上与 + 286) == 0)
        {
            goto label_330;
        }
        
        var val_165 = this.丝丝丄业丞丄七上与 + 176;
        var val_166 = 0;
        val_165 = val_165 + 8;
        label_329:
        if(((this.丝丝丄业丞丄七上与 + 176 + 8) + -8) == null)
        {
            goto label_328;
        }
        
        val_166 = val_166 + 1;
        val_165 = val_165 + 16;
        if(val_166 < (this.丝丝丄业丞丄七上与 + 286))
        {
            goto label_329;
        }
        
        goto label_330;
        label_328:
        val_167 = val_167 + (((this.丝丝丄业丞丄七上与 + 176 + 8)) << 4);
        val_164 = val_167 + 296;
        label_330:
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32> val_97 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(capacity:  this.丝丝丄业丞丄七上与.Count);
        var val_168 = 0;
        val_168 = val_168 + 1;
        System.Collections.Generic.IEnumerator<T> val_99 = this.丘丘与一丕三业丘七.GetEnumerator();
        label_385:
        if(val_99 != null)
        {
            goto label_382;
        }
        
        label_383:
        label_382:
        var val_169 = 0;
        val_169 = val_169 + 1;
        if(val_99.MoveNext() == false)
        {
            goto label_341;
        }
        
        var val_170 = 0;
        val_170 = val_170 + 1;
        T val_103 = val_99.Current;
        var val_173 = val_103;
        if((val_103 + 286) == 0)
        {
            goto label_351;
        }
        
        var val_171 = val_103 + 176;
        var val_172 = 0;
        val_171 = val_171 + 8;
        label_350:
        if(((val_103 + 176 + 8) + -8) == null)
        {
            goto label_349;
        }
        
        val_172 = val_172 + 1;
        val_171 = val_171 + 16;
        if(val_172 < (val_103 + 286))
        {
            goto label_350;
        }
        
        goto label_351;
        label_349:
        val_173 = val_173 + (((val_103 + 176 + 8)) << 4);
        val_168 = val_173 + 296;
        label_351:
        System.Collections.Generic.IEnumerator<T> val_104 = val_103.GetEnumerator();
        label_369:
        var val_174 = 0;
        val_174 = val_174 + 1;
        if(val_104.MoveNext() == false)
        {
            goto label_357;
        }
        
        var val_175 = 0;
        val_175 = val_175 + 1;
        var val_178 = val_103;
        if((val_103 + 286) == 0)
        {
            goto label_367;
        }
        
        var val_176 = val_103 + 176;
        var val_177 = 0;
        val_176 = val_176 + 8;
        label_366:
        if(((val_103 + 176 + 8) + -8) == null)
        {
            goto label_365;
        }
        
        val_177 = val_177 + 1;
        val_176 = val_176 + 16;
        if(val_177 < (val_103 + 286))
        {
            goto label_366;
        }
        
        goto label_367;
        label_365:
        val_178 = val_178 + (((val_103 + 176 + 8)) << 4);
        val_171 = val_178 + 296;
        label_367:
        null.set_Item(key:  val_104.Current, value:  val_103.Key);
        goto label_369;
        label_357:
        val_172 = val_145;
        var val_179 = ;
        val_179 = val_179 + 1;
        var val_182 = val_179;
        mem2[0] = 734;
        if(val_104 != null)
        {
                var val_180 = 0;
            val_180 = val_180 + 1;
            val_104.Dispose();
        }
        
        if((val_182 == 1) || ((1152921505052745728 + (((1 + (0 ^ 0)) + 1)) << 2) != 734))
        {
            goto label_381;
        }
        
        var val_181 = 0;
        val_181 = val_181 ^ (val_182 >> 31);
        val_182 = val_182 + val_181;
        if(val_99 != null)
        {
            goto label_382;
        }
        
        goto label_383;
        label_381:
        if( == false)
        {
            goto label_385;
        }
        
        goto label_385;
        label_341:
         =  + 1;
        mem2[0] = 757;
        if(val_99 == null)
        {
            
        }
        else
        {
                var val_183 = 0;
            val_183 = val_183 + 1;
            val_99.Dispose();
        }
        
        if( == 1)
        {
            goto label_404;
        }
        
        if( == false)
        {
            goto label_408;
        }
        
        if((1152921505052745728 + (((1 + (0 ^ 0)) + 1)) << 2) != 757)
        {
            goto label_406;
        }
        
        goto label_408;
        label_404:
        if( == false)
        {
            goto label_408;
        }
        
        label_406:
        label_408:
        val_175 = 0;
        goto label_409;
        label_423:
        var val_112 = (((1 + (0 ^ 0)) + 1) + 192) + 0;
        if(((((1 + (0 ^ 0)) + 1) + 192 + 0) + 32.业丄丄且丕丕不一万()) == 2)
        {
                (((1 + (0 ^ 0)) + 1) + 192 + 0) + 32.isEnable = true;
        }
        else
        {
                Rilisoft.七丕丟丏三丈一丄世 val_184 = (((1 + (0 ^ 0)) + 1) + 192 + 0) + 32.业丄丄且丕丕不一万();
            val_184 = UnlockGameModes.Contains(item:  val_184);
            (((1 + (0 ^ 0)) + 1) + 192 + 0) + 32.isEnable = val_184;
        }
        
        val_175 = 1;
        label_409:
        if(val_175 < (this.丝且与丝丒丟万丁专 + 64 + 192 + 24))
        {
            goto label_423;
        }
        
        if((this.丝且与丝丒丟万丁专 + 64 + 200) == 0)
        {
            goto label_429;
        }
        
        val_176 = 0;
        goto label_426;
        label_469:
        if(val_176 >= (this.丝且与丝丒丟万丁专 + 64 + 200 + 24))
        {
            goto label_429;
        }
        
        var val_117 = (this.丝且与丝丒丟万丁专 + 64 + 192) + 8;
        Rilisoft.七丕丟丏三丈一丄世 val_118 = (this.丝且与丝丒丟万丁专 + 64 + 192 + 8) + 32.业丄丄且丕丕不一万();
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  val_118)) != false)
        {
                val_177 = (~(this.丝且与丝丒丟万丁专.UnlockGameModes.Contains(item:  val_118))) & 1;
        }
        else
        {
                val_177 = 0;
        }
        
        var val_123 = (this.丝且与丝丒丟万丁专 + 64 + 200) + 0;
        if(((this.丝且与丝丒丟万丁专 + 64 + 200 + 0) + 32) != 0)
        {
                var val_125 = (this.丝且与丝丒丟万丁专 + 64 + 200) + 0;
            (this.丝且与丝丒丟万丁专 + 64 + 200 + 0) + 32.gameObject.SetActive(value:  false);
        }
        
        if(val_177 != 0)
        {
                var val_129 = (this.丝且与丝丒丟万丁专 + 64 + 200) + 0;
            if(((this.丝且与丝丒丟万丁专 + 64 + 200 + 0) + 32) != 0)
        {
                var val_131 = (this.丝且与丝丒丟万丁专 + 64 + 200) + 0;
            val_82 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  val_118);
            (this.丝且与丝丒丟万丁专 + 64 + 200 + 0) + 32.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  val_82);
        }
        
        }
        
        val_176 = 1;
        label_426:
        if((val_176 + 1) < (this.丝且与丝丒丟万丁专 + 64 + 192 + 24))
        {
            goto label_469;
        }
        
        label_429:
        val_143 = this;
        this.业专不丆丁丈丏下七 = 0;
        val_178 = this.丝且与丝丒丟万丁专;
        val_179 = 0;
        goto label_536;
        label_524:
        val_127 = 0;
        return (bool)val_127;
        label_536:
        if(val_77 >= this.丝且与丝丒丟万丁专.connectSceneMainMenu.modeButtonByLevel.Length)
        {
            goto label_528;
        }
        
        BtnCategory val_185 = this.丝且与丝丒丟万丁专.connectSceneMainMenu.modeButtonByLevel[static_value_081DACA8];
        val_125 = this;
        this.丌七一万三丗且与丐 = val_185;
        if(val_185.业丄丄且丕丕不一万() == 2)
        {
            goto label_533;
        }
        
        if(this.丌七一万三丗且与丐.丆丕业丐丄丌一不专() == true)
        {
            goto label_535;
        }
        
        label_136:
        this.丌七一万三丗且与丐 = 0;
        label_533:
        var val_137 = static_value_081DACA8 + 1;
        goto label_536;
        label_528:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.8f);
        val_123 = 2;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
        label_145:
        this.丗丏丅丕丆世丁专丟 = val_123;
        return (bool)val_127;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.丑不专丒丆丛七不业);
    }
    private void 且丆与丗丏三专丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = -3;
        if(this.丟不丛丙丒万一下东 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丟不丛丙丒万一下东.Dispose();
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
