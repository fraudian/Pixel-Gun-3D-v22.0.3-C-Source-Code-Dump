using UnityEngine;
public class EventCurrencyUpdater : CurrencyUpdater
{
    // Fields
    private UITexture _currencyTexture;
    private Rilisoft.上专业三丟丁丞专下 下丐丘丒丂不东丗丂;
    private string 七丌丗丗与三丌丅丘;
    private System.Nullable<UnityEngine.Color> 三一丑丘丛丆丘丟专;
    
    // Properties
    protected override string 世丟丑丘丘业七丑不 { get; }
    protected override UnityEngine.Color 丝三东三丆不业丞业 { get; }
    
    // Methods
    protected override void OnEnable()
    {
        string val_9;
        var val_10;
        var val_11;
        this.OnEnable();
        Rilisoft.上专业三丟丁丞专下 val_1 = this.世下丟丞万东丞丌丆();
        this.下丐丘丒丂不东丗丂 = val_1;
        if(val_1 != null)
        {
                val_9 = val_1.东与三丌丅三丒丏业();
        }
        else
        {
                val_9 = "EventCurrency";
        }
        
        if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_9)) == false)
        {
            goto label_4;
        }
        
        BankController.丕丝丌丅七丌三万丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void CurrencyUpdater::上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅)));
        goto label_13;
        label_4:
        val_10 = null;
        val_10 = null;
        if((System.String.op_Equality(a:  val_9, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == true)
        {
            goto label_10;
        }
        
        val_11 = null;
        val_11 = null;
        if((System.String.op_Equality(a:  val_9, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_13;
        }
        
        label_10:
        BankController.丁下丂丒万一下七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EventCurrencyUpdater::三丕丆三丙丐七丗上()));
        label_13:
        this.世丐丕三丞一丂三且();
        Rilisoft.丛且世丐丆上七业丁.东东丞三专丏业万丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EventCurrencyUpdater::丆丄七丁与丂丁丞下()));
    }
    private void 三丕丆三丙丐七丗上()
    {
        this.上业丝丙丅东业丟丅(丌丒丝东丌下丕丁丅:  1);
    }
    protected override void OnDisable()
    {
        this.下丐丘丒丂不东丗丂 = 0;
        BankController.丘与丗丆专丘丞丂丞(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void CurrencyUpdater::上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅)));
        BankController.与丄丅丘且丟世丗丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EventCurrencyUpdater::三丕丆三丙丐七丗上()));
        Rilisoft.丛且世丐丆上七业丁.丛业一万下不丈丑七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EventCurrencyUpdater::丆丄七丁与丂丁丞下()));
        this.OnDisable();
    }
    private void 丆丄七丁与丂丁丞下()
    {
        this.世丐丕三丞一丂三且();
        this.丏七且万丒东丏丛丅();
    }
    protected override int 丞下丂下东东丅一七()
    {
        string val_12;
        var val_13;
        var val_14;
        Rilisoft.丛且世丐丆上七业丁 val_1 = this.丌丐东业专丑丘丑丗();
        if(val_1 == null)
        {
                return 0;
        }
        
        if(val_1.且丌三丙丙与与丝世() != null)
        {
                val_12 = val_1.且丌三丙丙与与丝世().东与三丌丅三丒丏业();
        }
        else
        {
                val_12 = "EventCurrency";
        }
        
        if((System.String.op_Inequality(a:  val_12, b:  this.七丌丗丗与三丌丅丘)) != false)
        {
                this.七丌丗丗与三丌丅丘 = val_12;
            this.世丐丕三丞一丂三且();
        }
        
        if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_12)) != false)
        {
                return BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  val_1.业上丙丞丐丄丆丅七());
        }
        
        val_13 = null;
        val_13 = null;
        if((System.String.op_Equality(a:  val_12, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                Progress.丑丅专一业丙丝丄丁 val_9 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
            if(val_9 != null)
        {
                return val_9.世丄丂下丏丝丞丒且();
        }
        
            return val_9.世丄丂下丏丝丞丒且();
        }
        
        val_14 = null;
        val_14 = null;
        if((System.String.op_Equality(a:  val_12, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
                return 0;
        }
        
        Progress.丑丅专一业丙丝丄丁 val_11 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        if(val_11 != null)
        {
                return val_11.丗丞丝丅丈丑丗丂丌();
        }
        
        return val_11.丗丞丝丅丈丑丗丂丌();
    }
    protected override string 丌东世丁丁丌丐丕丟()
    {
        return "EventCurrencyUpdater_blink_sequence";
    }
    protected override UnityEngine.Color 丐业丅丒丅丁丞且丝()
    {
        if(this.三一丑丘丛丆丘丟专.HasValue == true)
        {
                return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void 世丐丕三丞一丂三且()
    {
        var val_26;
        var val_27;
        string val_28;
        UITexture val_29;
        string val_30;
        var val_31;
        var val_32;
        val_26 = this;
        bool val_1 = UnityEngine.Object.op_Equality(x:  this._currencyTexture, y:  0);
        if(val_1 == true)
        {
                return;
        }
        
        val_27 = val_1.丌丐东业专丑丘丑丗();
        if(val_27 == null)
        {
                return;
        }
        
        if(val_27.且丌三丙丙与与丝世() != null)
        {
                val_28 = val_27.且丌三丙丙与与丝世().东与三丌丅三丒丏业();
        }
        else
        {
                val_28 = "EventCurrency";
        }
        
        if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_28)) == false)
        {
            goto label_9;
        }
        
        Rilisoft.GameEventData val_7 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_7.EventId, b:  "4july")) == false)
        {
            goto label_11;
        }
        
        val_29 = this._currencyTexture;
        val_30 = "Textures/ribbon_bank_icon";
        goto label_40;
        label_9:
        val_31 = null;
        val_31 = null;
        if((System.String.op_Equality(a:  val_28, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_15;
        }
        
        val_29 = this._currencyTexture;
        val_30 = "Textures/gem_icon_bank";
        goto label_40;
        label_11:
        Rilisoft.GameEventData val_10 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_10.EventId, b:  "halloween")) == false)
        {
            goto label_18;
        }
        
        val_29 = this._currencyTexture;
        val_30 = "Textures/halloween_key_bank";
        goto label_40;
        label_15:
        val_32 = null;
        val_32 = null;
        if((System.String.op_Equality(a:  val_28, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
                return;
        }
        
        val_29 = this._currencyTexture;
        val_30 = "Textures/coin_icon_bank";
        goto label_40;
        label_18:
        Rilisoft.GameEventData val_13 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_13.EventId, b:  "christmas2")) == false)
        {
            goto label_25;
        }
        
        val_29 = this._currencyTexture;
        label_39:
        val_30 = "Textures/key_icon_christmas";
        goto label_40;
        label_25:
        Rilisoft.GameEventData val_15 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_15.EventId, b:  "new_year2")) == false)
        {
            goto label_28;
        }
        
        val_29 = this._currencyTexture;
        val_30 = "Textures/new_year_key_bank";
        goto label_40;
        label_28:
        Rilisoft.GameEventData val_17 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_17.EventId, b:  "sniper_tournament")) == true)
        {
            goto label_31;
        }
        
        Rilisoft.GameEventData val_19 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_19.EventId, b:  "sniper2_roulette")) == false)
        {
            goto label_33;
        }
        
        label_31:
        val_29 = this._currencyTexture;
        val_30 = "Textures/sniper_tournament_key_bank";
        label_40:
        UnityEngine.Texture val_21 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_30);
        val_27 = ???;
        val_26 = ???;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
        label_33:
        Rilisoft.GameEventData val_22 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_22.EventId, b:  "BTchests")) == false)
        {
            goto label_36;
        }
        
        goto label_40;
        label_36:
        Rilisoft.GameEventData val_24 = val_27.丁专丗万三上丟三丆();
        if((System.String.op_Equality(a:  val_24.EventId, b:  "crampus_lottery")) == true)
        {
            goto label_39;
        }
        
        goto label_40;
    }
    private Rilisoft.丛且世丐丆上七业丁 丌丐东业专丑丘丑丗()
    {
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() != 0)
        {
                if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().Context != null)
        {
                Rilisoft.AbstractGameEventGui val_5 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_5 != null)
        {
                return val_5.Context;
        }
        
            return val_5.Context;
        }
        
        }
        
        Rilisoft.三一丈七且丄与丝东 val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        if(val_6 != null)
        {
                return val_6.丏世丞丕丂丒七上业();
        }
        
        return val_6.丏世丞丕丂丒七上业();
    }
    private Rilisoft.上专业三丟丁丞专下 世下丟丞万东丞丌丆()
    {
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
        {
                return 0;
        }
        
        if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().Context == null)
        {
                return 0;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_6 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().Context;
        if(val_6 != null)
        {
                return val_6.且丌三丙丙与与丝世();
        }
        
        return val_6.且丌三丙丙与与丝世();
    }
    public EventCurrencyUpdater()
    {
    
    }

}
