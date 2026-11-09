using UnityEngine;
private sealed class LoopGuiBase.丘不丒丐丑与丒下专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LoopGuiBase 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoopGuiBase.丘不丒丐丑与丒下专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_49;
        var val_50;
        int val_51;
        bool val_52;
        System.Collections.Generic.IEnumerable<T> val_53;
        object val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丗丕专丐丞丞下不丒 = new UnityEngine.WaitForSecondsRealtime(time:  0.5f);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        OfferModule val_2 = (this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 == 1) ? 60 : 0;
        if(this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 == 1)
        {
            goto label_6;
        }
        
        val_50 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丏丈丞丅丒与丄业东(丁丅丈丌丟世丗丗丟:  this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝);
        goto label_8;
        label_2:
        val_51 = 0;
        return (bool)val_51;
        label_6:
        val_50 = 0;
        label_8:
        if(this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟 == 0)
        {
            goto label_101;
        }
        
        if(this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.timerLabel == 0)
        {
            goto label_53;
        }
        
        if(val_50 == 0)
        {
                if(this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 != 1)
        {
            goto label_53;
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丝且与丝丒丟万丁专.<七七七丒业丗丅且丛>k__BackingField)) == true)
        {
            goto label_53;
        }
        
        new LoopGuiBase.世丘丛上丞丆丟丟丐() = new System.Object();
        if((this.丝且与丝丒丟万丁专.<东丁丘丄七丅与上丅>k__BackingField) == false)
        {
            goto label_22;
        }
        
        var val_10 = (FriendsController.丝丗专上三不丄丑丑() > 0) ? 1 : 0;
        if(new LoopGuiBase.世丘丛上丞丆丟丟丐() != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_22:
        val_52 = false;
        if(new LoopGuiBase.世丘丛上丞丆丟丟丐() != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        .一且丕万专业世七一 = val_52;
        UnityEngine.Transform val_12 = this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.timerLabel.transform.parent;
        .丄丑专丌丞七丐东不 = val_12;
        val_53 = val_12.GetComponentsInChildren<UnityEngine.Transform>(includeInactive:  true);
        System.Action<UnityEngine.Transform> val_14 = new System.Action<UnityEngine.Transform>(object:  new LoopGuiBase.世丘丛上丞丆丟丟丐(), method:  System.Void LoopGuiBase.世丘丛上丞丆丟丟丐::与丞丕业丂业业三七(UnityEngine.Transform 丁丂专业丁丅丅丈丙));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.Transform>(丌丛丏业世丄丞三丌:  val_53, 七丐丅专且专七三丆:  null);
        if((LoopGuiBase.世丘丛上丞丆丟丟丐)[1152921540166890448].一且丕万专业世七一 != false)
        {
                if(this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 != 1)
        {
                val_54 = val_50.丗万丐业不丑丛丝丝(丞一丁业丄一一业且:  this.丝且与丝丒丟万丁专.<七七七丒业丗丅且丛>k__BackingField, 丑丗丕丈丒不丙专丐:  ((this.丝且与丝丒丟万丁专.<丛丑专一万丞丄丐不>k__BackingField) == true) ? 1 : 0);
        }
        else
        {
                val_54 = 与丑丛万不东专丅丙.丝丏专丁丄与丌丗丂(丞一丁业丄一一业且:  this.丝且与丝丒丟万丁专.<七七七丒业丗丅且丛>k__BackingField, 世七七丟丑丁丂与丞:  val_2, 丑丗丕丈丒不丙专丐:  ((this.丝且与丝丒丟万丁专.<丛丑专一万丞丄丐不>k__BackingField) == true) ? 1 : 0);
        }
        
            val_53 = this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.timerLabel;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丝且与丝丒丟万丁专.<丂业万丟丈丆丒丘万>k__BackingField)) != true)
        {
                val_54 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丝且与丝丒丟万丁专.<丂业万丟丈丆丒丘万>k__BackingField), arg0:  val_54);
        }
        
            val_53.text = val_54;
            if((this.丝且与丝丒丟万丁专.<丘丟丞丄专下世丈丕>k__BackingField) != null)
        {
                if(this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 != 1)
        {
                val_55 = val_50;
        }
        else
        {
                System.TimeSpan val_22 = 与丑丛万不东专丅丙.三丟丂下丙丄丟丐业(丞一丁业丄一一业且:  this.丝且与丝丒丟万丁专.<七七七丒业丗丅且丛>k__BackingField, 世七七丟丑丁丂与丞:  val_2);
        }
        
            if(val_22._ticks.Seconds <= 0)
        {
                val_49 = this.丝且与丝丒丟万丁专.<丘丟丞丄专下世丈丕>k__BackingField;
            val_49.Invoke();
        }
        
        }
        
        }
        
        label_53:
        if((this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 == 1) || (this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 == 1))
        {
            goto label_101;
        }
        
        if(this.丝且与丝丒丟万丁专.丌上丕丆丕七丗三丝 != 4)
        {
            goto label_57;
        }
        
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false)
        {
            goto label_60;
        }
        
        val_53 = 1;
        goto label_61;
        label_57:
        val_49 = this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.丑一丆丑且丟上业丛();
        if((val_50 == 0) || (((UnityEngine.Object.op_Inequality(x:  val_49, y:  0)) ^ 1) == true))
        {
            goto label_101;
        }
        
        string val_29 = val_50.与不丕丏丐丂丕上丆().ToLowerInvariant();
        if(this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.丑一丆丑且丟上业丛() == 0)
        {
            goto label_72;
        }
        
        val_49 = this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.丑一丆丑且丟上业丛();
        if((System.String.op_Inequality(a:  val_49.name, b:  val_29)) == false)
        {
            goto label_101;
        }
        
        label_72:
        val_49 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "Textures/GameLoop_Textures/{0}", arg0:  val_29));
        if(this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.丑一丆丑且丟上业丛() != null)
        {
            goto label_101;
        }
        
        goto label_101;
        label_60:
        val_53 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.丟丂下七且七东丛丞();
        label_61:
        if((this.丝且与丝丒丟万丁专.<丄上丞不三与一丅丒>k__BackingField) != 250000)
        {
            goto label_82;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_40 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  this.丝且与丝丒丟万丁专.<七七七丒业丗丅且丛>k__BackingField);
        if(val_53 == false)
        {
            goto label_84;
        }
        
        val_56 = 业丌丐丈丛丙丐三下.丞专东丏丄丑下丛七(丈丄不七三万丄丁不:  val_40, 丏业丟一东丂东丘丛:  0);
        goto label_85;
        label_82:
        if(val_53 != false)
        {
                val_57 = 业丌丐丈丛丙丐三下.丞专东丏丄丑下丛七(下丅丙一丂丗丅丝七:  this.丝且与丝丒丟万丁专.<七七七丒业丗丅且丛>k__BackingField, 丏业丟一东丂东丘丛:  0);
        }
        else
        {
                val_57 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.grayBattlepass, 丏业丟一东丂东丘丛:  false);
        if(val_53 == false)
        {
            goto label_92;
        }
        
        val_49 = 业丌丐丈丛丙丐三下.丞专东丏丄丑下丛七(下丅丙一丂丗丅丝七:  this.丝且与丝丒丟万丁专.<七七七丒业丗丅且丛>k__BackingField, 丏业丟一东丂东丘丛:  100);
        goto label_93;
        label_84:
        val_56 = 0;
        label_85:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.grayBattlepass, 丏业丟一东丂东丘丛:  false);
        val_49 = this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.goldenBattlepass;
        if(val_53 == false)
        {
            goto label_97;
        }
        
        val_58 = 业丌丐丈丛丙丐三下.丞专东丏丄丑下丛七(丈丄不七三万丄丁不:  val_40, 丏业丟一东丂东丘丛:  100);
        goto label_98;
        label_92:
        val_49 = 0;
        label_93:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.丟丟专丘丙世丅丝丟.goldenBattlepass, 丏业丟一东丂东丘丛:  false);
        goto label_101;
        label_97:
        val_58 = 0;
        label_98:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_49, 丏业丟一东丂东丘丛:  false);
        label_101:
        val_51 = 1;
        this.丗丏丅丕丆世丁专丟 = val_51;
        this.丒上七丌业七丟与丐 = this.丗丕专丐丞丞下不丒;
        return (bool)val_51;
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
