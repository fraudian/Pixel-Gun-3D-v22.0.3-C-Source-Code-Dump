using UnityEngine;
internal sealed class ConnectScenePanelEventHint : PGBehaviour
{
    // Fields
    public Rilisoft.ButtonHandler mapEventHintBlockBtn;
    public MapEventWindowUI mapEventWindow;
    private System.Collections.Generic.Dictionary<丂丟丙丐不丟一丈且, MapEventWindowUI> 与丈丆丞丝三下不业;
    
    // Methods
    private MapEventWindowUI 不三与丙业丞七不丝(丂丟丙丐不丟一丈且 下一丁丒丁丒丑七上)
    {
        System.Collections.Generic.Dictionary<丂丟丙丐不丟一丈且, MapEventWindowUI> val_5;
        var val_6;
        val_5 = this.与丈丆丞丝三下不业;
        if((val_5.ContainsKey(key:  下一丁丒丁丒丑七上)) != false)
        {
                val_5 = this.与丈丆丞丝三下不业.Item[下一丁丒丁丒丑七上];
            if(val_5 != 0)
        {
                return (MapEventWindowUI)this.与丈丆丞丝三下不业.Item[下一丁丒丁丒丑七上];
        }
        
            return this.丏不丅丆下丒一丑丐(与丘一丙丒丄丆丟丞:  下一丁丒丁丒丑七上);
        }
        
        val_6 = 0;
        return (MapEventWindowUI)this.与丈丆丞丝三下不业.Item[下一丁丒丁丒丑七上];
    }
    internal void 丛丗丝且世丟丌东万(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 且丝丘万丅与丈丗一, bool 丁丏丗且上丗下与下)
    {
        var val_3;
        UnityEngine.Object val_27;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.与丈丆丞丝三下不业.GetEnumerator();
        label_15:
        if(((-1980961632) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_6 = 且丝丘万丅与丈丗一.丌不丅不丞东万专专();
        var val_8 = (val_6.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0;
        val_8 = val_8 & 1152921536985623688;
        if((val_8 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_9 = val_5._value._obj.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  0, b:  "MapEventWindow-Competition")) == false)
        {
            goto label_15;
        }
        
        goto label_7;
        label_4:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_11 = 且丝丘万丅与丈丗一.丌不丅不丞东万专专();
        var val_13 = (val_11.HasValue.丙东专丂世丈丏丁丂() == 5) ? 1 : 0;
        val_13 = val_13 & 1152921536985623688;
        if((val_13 & 1) == 0)
        {
            goto label_9;
        }
        
        string val_14 = val_5._value._obj.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  0, b:  "MapEventWindow-LoadoutFiltermap")) == false)
        {
            goto label_15;
        }
        
        goto label_12;
        label_9:
        string val_16 = val_5._value._obj.丐丏七丌丕丗业且上();
        var val_18 = (val_16.m_stringLength != 0) ? 1 : 0;
        val_18 = val_18 ^ 且丝丘万丅与丈丗一.且丆不丈丞专下世丐();
        if(val_18 == true)
        {
            goto label_15;
        }
        
        val_27 = this.不三与丙业丞七不丝(下一丁丒丁丒丑七上:  val_5._value._obj.丐丏七丌丕丗业且上());
        goto label_18;
        label_2:
        val_27 = 0;
        goto label_18;
        label_7:
        val_27 = this.不三与丙业丞七不丝(下一丁丒丁丒丑七上:  val_5._value._obj.丐丏七丌丕丗业且上());
        goto label_18;
        label_12:
        val_27 = this.不三与丙业丞七不丝(下一丁丒丁丒丑七上:  val_5._value._obj.丐丏七丌丕丗业且上());
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_27 == 0)
        {
                return;
        }
        
        this.mapEventWindow = val_27;
        this.下丗丒丆丗丗丆东丈(且丝丘万丅与丈丗一:  且丝丘万丅与丈丗一, 丁丏丗且上丗下与下:  丁丏丗且上丗下与下);
    }
    private MapEventWindowUI 丏不丅丆下丒一丑丐(丂丟丙丐不丟一丈且 与丘一丙丒丄丆丟丞)
    {
        MapEventWindowUI val_4 = UnityEngine.Object.Instantiate<MapEventWindowUI>(original:  UnityEngine.Resources.Load<MapEventWindowUI>(path:  "MapEventWindows/"("MapEventWindows/") + 与丘一丙丒丄丆丟丞.丒丘丏上丙丟丑丕丈), parent:  this.丌丟丄业且三丛丕丄());
        this.与丈丆丞丝三下不业.set_Item(key:  与丘一丙丒丄丆丟丞, value:  val_4);
        return val_4;
    }
    private void 下丗丒丆丗丗丆东丈(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 且丝丘万丅与丈丗一, bool 丁丏丗且上丗下与下)
    {
        this.丏丆下丘丅丙丐丌丅();
        丁丏丗且上丗下与下 = 丁丏丗且上丗下与下;
        this.mapEventWindow.上东与丛丞下丈专丈(丐且丘丑与万丞丑丅:  且丝丘万丅与丈丗一, 丛一丆专世丝丄丒与:  丁丏丗且上丗下与下);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.mapEventWindow, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丏丆下丘丅丙丐丌丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.mapEventWindow, 丏业丟一东丂东丘丛:  false);
    }
    public ConnectScenePanelEventHint()
    {
        System.Collections.Generic.Dictionary<丂丟丙丐不丟一丈且, MapEventWindowUI> val_1 = new System.Collections.Generic.Dictionary<丂丟丙丐不丟一丈且, MapEventWindowUI>();
        丂丟丙丐不丟一丈且 val_2 = new 丂丟丙丐不丟一丈且();
        if(val_2 != null)
        {
                .丒丘丏上丙丟丑丕丈 = "MapEventWindow-Default";
        }
        else
        {
                mem[24] = "MapEventWindow-Default";
        }
        
        .丟丘丟丂与丑丛丄丌 = false;
        val_1.Add(key:  val_2, value:  0);
        丂丟丙丐不丟一丈且 val_3 = new 丂丟丙丐不丟一丈且();
        if(val_3 != null)
        {
                .丒丘丏上丙丟丑丕丈 = "MapEventWindow-Rating";
        }
        else
        {
                mem[24] = "MapEventWindow-Rating";
        }
        
        .丟丘丟丂与丑丛丄丌 = true;
        val_1.Add(key:  val_3, value:  0);
        丂丟丙丐不丟一丈且 val_4 = new 丂丟丙丐不丟一丈且();
        if(val_4 != null)
        {
                .丒丘丏上丙丟丑丕丈 = "MapEventWindow-Competition";
        }
        else
        {
                mem[24] = "MapEventWindow-Competition";
        }
        
        .丟丘丟丂与丑丛丄丌 = false;
        val_1.Add(key:  val_4, value:  0);
        丂丟丙丐不丟一丈且 val_5 = new 丂丟丙丐不丟一丈且();
        if(val_5 != null)
        {
                .丒丘丏上丙丟丑丕丈 = "MapEventWindow-LoadoutFiltermap";
        }
        else
        {
                mem[24] = "MapEventWindow-LoadoutFiltermap";
        }
        
        .丟丘丟丂与丑丛丄丌 = false;
        val_1.Add(key:  val_5, value:  0);
        this.与丈丆丞丝三下不业 = val_1;
    }

}
