using UnityEngine;
internal class 东丑丐丂七丒丅丕丙 : 丏七丁丌世丟丁丅丙
{
    // Fields
    private CategoryNames 丌丂丕丘丌丟万丌七;
    private string 万丂丘万一丐三世丂;
    
    // Methods
    internal 东丑丐丂七丒丅丕丙(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
    {
        this.丌丂丕丘丌丟万丌七 = 0;
        this.万丂丘万一丐三世丂 = System.String.alignConst;
        goto typeof(东丑丐丂七丒丅丕丙).__il2cppRuntimeField_1B8;
    }
    internal override void 丈丗丝丂丝丑上三丌()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丛万业且与丒丈七且(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void 东丑丐丂七丒丅丕丙::东上丆丝丒下业丟下(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        this.丈丗丝丂丝丑上三丌();
    }
    internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
    {
        var val_3;
        var val_15;
        System.Object[] val_16;
        bool val_17;
        val_16 = this;
        this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
        if(丗丟上上丒丐丗丞丙 == null)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
        label_41:
        if((1719474960 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((val_4 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
        {
            goto label_41;
        }
        
        if((System.String.Equals(a:  val_4.m_stringLength, b:  "weaponSlot", comparisonType:  5)) != false)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == false)
        {
            goto label_10;
        }
        
        }
        
        if(((System.String.Equals(a:  val_4.m_stringLength, b:  "my_player_effect", comparisonType:  5)) == false) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
        {
            goto label_41;
        }
        
        this.万丂丘万一丐三世丂 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished;
        goto label_41;
        label_10:
        val_17 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_4, ignoreCase:  true);
        val_15 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_17);
        this.丌丂丕丘丌丟万丌七 = null;
        goto label_41;
        label_1:
        val_16 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionKillFlying UpdateParams parameters == null", args:  val_16);
        return;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 东上丆丝丒下业丟下(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
    {
        var val_15;
        string val_16;
        var val_17;
        var val_18;
        Rilisoft.下丝丅世上与丌丗丛 val_15 = 丗丛不丁丑专专丂且;
        if(this.丈丐丞丐上丑且丕万() == false)
        {
                return;
        }
        
        val_15 = this.业丑丁丆丕丆丂丅万();
        if(val_15.世丑丐丅丆丂丘不丁() != false)
        {
                return;
        }
        
        if(this.丘丛丆丕且丂业世丌() != 1)
        {
                if(val_15 == null)
        {
                return;
        }
        
            if(this.丘丛丆丕且丂业世丌() != val_15.丘丛丆丕且丂业世丌())
        {
                return;
        }
        
        }
        
        if(this.丌丂丕丘丌丟万丌七 != 1)
        {
                if(val_15 == null)
        {
                return;
        }
        
            if(this.丌丂丕丘丌丟万丌七 != val_15.丄丄世七三业丝丛丘())
        {
                return;
        }
        
        }
        
        val_16 = this.万丂丘万一丐三世丂;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != true)
        {
                System.Collections.Generic.List<System.Object> val_9 = new System.Collections.Generic.List<System.Object>();
            object val_11 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_15.丞一万丗上丄丏丁丈());
            val_17 = 0;
            do
        {
            if(0 >= Count)
        {
                return;
        }
        
            object val_13 = Item[0];
            val_16 = 0 + 1;
        }
        while((System.String.op_Equality(a:  this.万丂丘万一丐三世丂, b:  val_13)) == false);
        
        }
        
        if((null == null) || (val_13 < 1))
        {
            goto label_23;
        }
        
        mem[1152921536391331980] = null;
        if(null == val_13)
        {
            goto label_28;
        }
        
        goto label_29;
        label_23:
        if((null == null) || (val_13 < 1))
        {
            goto label_27;
        }
        
        mem[1152921536391331976] = null;
        if(null == val_13)
        {
            goto label_28;
        }
        
        goto label_29;
        label_27:
        val_18 = 1;
        label_28:
        this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
        label_29:
        this.丐三上丏丈丕且且丞();
    }
    internal override void 丞上丝丗七丁七丑丘()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().业丟丛万丟专丅丘丁(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void 东丑丐丂七丒丅丕丙::东上丆丝丒下业丟下(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        this.丞上丝丗七丁七丑丘();
    }

}
