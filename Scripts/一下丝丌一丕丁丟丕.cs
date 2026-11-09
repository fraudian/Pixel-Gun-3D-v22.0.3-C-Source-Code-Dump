using UnityEngine;
private sealed class ThreeChestsGameEventView.一下丝丌一丕丁丟丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ThreeChestsGameEventView 丝且与丝丒丟万丁专;
    private Rilisoft.ThreeChestsGameEventView.丕丘丅三丛丘专世一 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ThreeChestsGameEventView.一下丝丌一丕丁丟丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        Rilisoft.ThreeChestsGameEventView val_114;
        var val_116;
        Rilisoft.上专业三丟丁丞专下 val_117;
        var val_118;
        var val_119;
        var val_120;
        var val_121;
        string val_122;
        bool val_123;
        var val_124;
        var val_125;
        var val_126;
        var val_127;
        var val_128;
        var val_129;
        var val_130;
        var val_131;
        var val_132;
        var val_133;
        var val_134;
        var val_135;
        var val_136;
        var val_137;
        var val_138;
        var val_139;
        if(this.丗丏丅丕丆世丁专丟 > 4)
        {
            goto label_1;
        }
        
        var val_111 = 106043632 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_114 = this.丝且与丝丒丟万丁专;
        val_111 = val_111 + 106043632;
        goto (106043632 + (this.丗丏丅丕丆世丁专丟) << 2 + 106043632);
        label_10:
        if(((-392097872) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        val_6.ResetTrigger(name:  "Multy");
        goto label_10;
        label_263:
        if(GameObject == null)
        {
            goto label_19;
        }
        
        val_118 = 2;
        mem2[0] = 0;
        goto label_23;
        label_141:
        if(GameObject == null)
        {
            goto label_22;
        }
        
        mem2[0] = 0;
        val_118 = 3;
        goto label_23;
        label_259:
        if(GameObject == null)
        {
            goto label_25;
        }
        
        val_119 = 1;
        mem2[0] = 0;
        mem2[0] = val_119;
        return (bool)val_119;
        label_22:
        if(val_114 != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_19:
        int val_16 = val_114.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().IndexOf(item:  val_114.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世());
        if(val_16 == 2)
        {
            goto label_36;
        }
        
        if(val_16 == 1)
        {
            goto label_37;
        }
        
        if(val_16 != 0)
        {
            goto label_38;
        }
        
        val_120 = "First";
        goto label_51;
        label_25:
        this.丝且与丝丒丟万丁专._viewAnimator.SetTrigger(name:  "Back");
        this.丝且与丝丒丟万丁专.下专丞丅丟丏丐丆丙 = false;
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
        {
            goto label_43;
        }
        
        val_121 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_121 == null)
        {
            goto label_44;
        }
        
        val_121 = 0;
        goto label_47;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_114 != null)
        {
            goto label_117;
        }
        
        goto label_49;
        label_37:
        val_120 = "Second";
        goto label_51;
        label_36:
        val_120 = "Third";
        goto label_51;
        label_38:
        val_122 = 0;
        label_51:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_122)) == false)
        {
            goto label_54;
        }
        
        label_1:
        val_119 = 0;
        return (bool)val_119;
        label_54:
        if(val_114 != null)
        {
                val_123 = this.丝且与丝丒丟万丁专.丟丟丁丏丞专下丙专;
        }
        else
        {
                val_123 = 200;
        }
        
        this.丝且与丝丒丟万丁专.下专丞丅丟丏丐丆丙 = true;
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
        {
            goto label_62;
        }
        
        val_124 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_124 == null)
        {
            goto label_63;
        }
        
        val_124 = 0;
        goto label_66;
        label_44:
        label_47:
        val_121.一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  true);
        val_125 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_125 != null)
        {
                val_125 = 0;
        }
        
        val_125.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  true);
        label_43:
        val_114.丕丂丐丑丄丁上丈丞();
        List.Enumerator<T> val_30 = val_114.丘丆且上七业三丆不().GetEnumerator();
        val_116 = 1152921542861875888;
        label_77:
        if(((-392097872) & 1) == 0)
        {
            goto label_72;
        }
        
        string val_31 = val_5.丐丏七丌丕丗业且上();
        val_31.gameObject.SetActive(value:  false);
        val_31.gameObject.SetActive(value:  true);
        goto label_77;
        label_72:
        var val_34 = 0 + 1;
        val_126 = 0;
        mem2[0] = 822;
        goto label_78;
        label_63:
        label_66:
        val_124.一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  false);
        val_127 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_127 != null)
        {
                val_127 = 0;
        }
        
        val_127.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  false);
        label_62:
        this.丝且与丝丒丟万丁专._viewAnimator.SetTrigger(name:  ((((val_123 != 0) ? 1 : 0) & ((this.丝且与丝丒丟万丁专.七丅专丏丅丌不七丞.业上丙丞丐丄丆丅七() != val_114.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().业上丙丞丐丄丆丅七()) ? 1 : 0)) != 0) ? "Select" : "Set"(((((val_123 != 0) ? 1 : 0) & ((this.丝且与丝丒丟万丁专.七丅专丏丅丌不七丞.业上丙丞丐丄丆丅七() != val_114.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().业上丙丞丐丄丆丅七()) ? 1 : 0)) != 0) ? "Select" : "Set") + val_122);
        goto label_84;
        label_78:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(1152921542861875888 == 1)
        {
            goto label_105;
        }
        
        if( == false)
        {
            goto label_112;
        }
        
        label_111:
        label_112:
        丏丞三丏与丂丟且丁();
        if( == true)
        {
            goto label_234;
        }
        
        val_129 = 123372880;
        val_130 = 1;
        goto label_110;
        label_105:
        if( == true)
        {
            goto label_111;
        }
        
        goto label_112;
        label_49:
        label_117:
        if(上丕丌丕丂丘丁丙万().丕丒丙七丘丈丙且丂() != true)
        {
                if(上丕丌丕丂丘丁丙万().下一三万丝丟丐丒丆() != false)
        {
                if((上丕丌丕丂丘丁丙万().不七丘丙不三丗业上().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false)
        {
            goto label_126;
        }
        
        }
        
        }
        
        if((X0 + 344) == 0)
        {
            goto label_143;
        }
        
        if(上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世() == 上丕丌丕丂丘丁丙万().不七丘丙不三丗业上())
        {
            goto label_131;
        }
        
        label_146:
        if(上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().丐丏下丕三丒丗丅丛() == false)
        {
            goto label_134;
        }
        
        UnityEngine.Debug.Log(message:  "change chest from common to golden");
        if((X0 + 128.GameEvent) == null)
        {
            goto label_138;
        }
        
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_10 = 1;
        X0 + 128.UpdateFill(丞与与丝不业丐一丆:  new System.Action(object:  1152921504834002944, method:  System.Void ThreeChestsGameEventView.丕丘丅三丛丘专世一::丗丅与与丗丗东下丗()));
        goto label_141;
        label_131:
        if((X0 + 344.丐丏下丕三丒丗丅丛()) != true)
        {
                if((上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false)
        {
            goto label_146;
        }
        
        }
        
        label_143:
        上丕丌丕丂丘丁丙万().不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  上丕丌丕丂丘丁丙万().不七丘丙不三丗业上());
        丈不丛丆丘上丛丟丐().gameObject.SetActive(value:  false);
        丈不丛丆丘上丛丟丐().gameObject.SetActive(value:  true);
        mem2[0] = 1;
        X0 + 248.SetTrigger(name:  "SetSuper");
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
        {
            goto label_196;
        }
        
        val_131 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_131 == null)
        {
            goto label_156;
        }
        
        val_131 = 0;
        goto label_159;
        label_134:
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
        {
            goto label_161;
        }
        
        val_132 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_132 == null)
        {
            goto label_162;
        }
        
        val_132 = 0;
        goto label_165;
        label_126:
        if(上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世() == null)
        {
            goto label_169;
        }
        
        List.Enumerator<T> val_72 = X0 + 240.GetEnumerator();
        label_177:
        if(((-392097904) & 1) == 0)
        {
            goto label_171;
        }
        
        string val_73 = val_5.丐丏七丌丕丗业且上();
        if(val_73 == 0)
        {
            goto label_177;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_73, 丏业丟一东丂东丘丛:  false);
        goto label_177;
        label_138:
        X0 + 128.UpdateView(丅东专与不三丂丁丝:  上丕丌丕丂丘丁丙万(), 七丆丟丗世丟且丒丆:  true);
        label_28:
        val_117 = mem[X0 + 344];
        val_117 = X0 + 344;
        if(val_117 != 0)
        {
                val_117 = 上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().IndexOf(item:  val_117);
            丘丆且上七业三丆不().Item[val_117].SetTrigger(name:  "Hide");
        }
        
        UnityEngine.WaitForSeconds val_81 = null;
        val_114 = val_81;
        val_81 = new UnityEngine.WaitForSeconds(seconds:  0.7f);
        mem2[0] = val_114;
        val_118 = 4;
        label_23:
        mem2[0] = val_118;
        val_119 = 1;
        return (bool)val_119;
        label_169:
        List.Enumerator<T> val_83 = 丘丆且上七业三丆不().GetEnumerator();
        label_191:
        if(((-392097872) & 1) == 0)
        {
            goto label_186;
        }
        
        string val_84 = val_5.丐丏七丌丕丗业且上();
        val_84.gameObject.SetActive(value:  false);
        val_84.gameObject.SetActive(value:  true);
        goto label_191;
        label_156:
        label_159:
        val_131.一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  false);
        val_133 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_133 != null)
        {
                val_133 = 0;
        }
        
        val_133.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  false);
        goto label_196;
        label_162:
        label_165:
        val_132.一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  true);
        val_134 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_134 != null)
        {
                val_134 = 0;
        }
        
        val_134.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  true);
        label_161:
        X0 + 248.SetTrigger(name:  "Golden");
        label_196:
        丐上丛丞丑且丅世丄();
        label_84:
        业丑丈丁丙丁世丂丁(丐下丝丘丑丟丟丗丌:  上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世());
        label_234:
        val_129 = mem[X0 + 128];
        val_129 = X0 + 128;
        val_130 = 0;
        label_110:
        val_117 = 上丕丌丕丂丘丁丙万();
        val_129.UpdateView(丅东专与不三丂丁丝:  val_117, 七丆丟丗世丟且丒丆:  true);
        if(val_130 != 0)
        {
            goto label_210;
        }
        
        val_119 = 0;
        mem2[0] = 上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世();
        return (bool)val_119;
        label_171:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_135 = 1152921542861873840;
        if( == true)
        {
            goto label_238;
        }
        
        goto label_207;
        label_186:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == true)
        {
            goto label_232;
        }
        
        goto label_209;
        label_210:
        val_128 = 0;
        goto label_283;
        label_209:
        label_232:
        X0 + 248.SetTrigger(name:  "Back");
        丕丂丐丑丄丁上丈丞();
        goto label_234;
        label_207:
        label_238:
        if(((X0 + 344) == 0) || ((X0 + 344.丐丏下丕三丒丗丅丛()) == false))
        {
            goto label_240;
        }
        
        X0 + 248.SetTrigger(name:  "Back");
        丕丂丐丑丄丁上丈丞();
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
        {
            goto label_243;
        }
        
        val_136 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_136 == null)
        {
            goto label_244;
        }
        
        val_136 = 0;
        goto label_247;
        label_240:
        label_290:
        if( == true)
        {
            goto label_291;
        }
        
        label_292:
        label_291:
        if((上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().丐丏下丕三丒丗丅丛() == true) || ((上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false))
        {
            goto label_255;
        }
        
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_10 = 1;
        X0 + 128.UpdateFill(丞与与丝不业丐一丆:  new System.Action(object:  1152921504834002944, method:  System.Void ThreeChestsGameEventView.丕丘丅三丛丘专世一::且丝丆丁丘万七丗与()));
        goto label_259;
        label_255:
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_10 = 1;
        X0 + 128.UpdateFill(丞与与丝不业丐一丆:  new System.Action(object:  1152921504834002944, method:  System.Void ThreeChestsGameEventView.丕丘丅三丛丘专世一::东七丝丂丒世丗丁且()));
        goto label_263;
        label_244:
        label_247:
        val_136.一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  true);
        val_137 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_137 != null)
        {
                val_137 = 0;
        }
        
        val_137.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  true);
        label_243:
        List.Enumerator<T> val_107 = 丘丆且上七业三丆不().GetEnumerator();
        label_274:
        if(((-392097872) & 1) == 0)
        {
            goto label_269;
        }
        
        string val_108 = val_5.丐丏七丌丕丗业且上();
        val_108.gameObject.SetActive(value:  false);
        val_108.gameObject.SetActive(value:  true);
        goto label_274;
        label_269:
        val_138 = 0;
        val_139 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == false)
        {
            goto label_290;
        }
        
        if( == true)
        {
            goto label_291;
        }
        
        goto label_292;
        label_283:
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
