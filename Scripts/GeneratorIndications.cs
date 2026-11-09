using UnityEngine;
internal sealed class GeneratorIndications : PGBehaviour
{
    // Fields
    private UnityEngine.Color 丄丂专且七丌业丙不;
    private UnityEngine.Color 丑丞丈丗丄丙丟万丄;
    private System.Collections.Generic.List<GeneratorIndications.GeneratorPoints> _listGeneratorPoints;
    private bool 丆世不丄业丘丆且丒;
    private int 丞丛东丛上丁且丟丅;
    private System.Collections.Generic.List<GeneratorIndications.东世丗下世丌与一丆> 专丛下丞丅丄丑丟与;
    private float deleyTimeChangeColor;
    private float timeToHidePoint;
    
    // Methods
    private void Awake()
    {
        InGameGUI.add_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GeneratorIndications::丕七下丗专丈三丄丈()));
    }
    private void OnDestroy()
    {
        InGameGUI.remove_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GeneratorIndications::丕七下丗专丈三丄丈()));
    }
    private void 丕七下丗专丈三丄丈()
    {
        var val_4;
        var val_34;
        UnityEngine.MonoBehaviour val_35;
        var val_36;
        var val_37;
        var val_39;
        val_34 = this;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this._listGeneratorPoints.GetEnumerator();
        goto label_5;
        label_27:
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                WorldPosIndicatonItem_Filling val_7 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicatonItem_Filling>();
            if(val_5 != null)
        {
                val_35 = val_5;
            mem2[0] = val_7;
        }
        else
        {
                mem[24] = val_7;
            val_35 = 24;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_35, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Transform val_8 = this.transform;
            mem[24].万三丗丆下万丅上丈(丞下万上三丘上与专:  val_8, 丒专丌万丄一丒万丏:  2.4f);
        }
        
        val_36 = 1;
        goto label_16;
        label_26:
        FortDamageableGenerator val_9 = X23.Item[val_8];
        DamageableObject val_10 = val_9.业丒丁丙丛丒上丙丟();
        val_37 = public System.Int32 System.Collections.Generic.List<FortDamageableGenerator>::get_Count();
        if(val_36 < val_9.Count)
        {
                val_37 = 0;
            DamageableObject val_13 = val_9.Item[1].业丒丁丙丛丒上丙丟();
        }
        
        string val_15 = val_5.m_stringLength + val_36.ToString();
        UnityEngine.Color val_16 = UnityEngine.Color.red;
        UnityEngine.Color val_17 = UnityEngine.Color.gray;
        UnityEngine.Color val_18 = UnityEngine.Color.blue;
        val_4 = 0;
        UnityEngine.Color val_19 = UnityEngine.Color.green;
        val_36 = 2;
        label_16:
        var val_21 = val_36 - 1;
        if(val_21 < val_5.m_stringLength.Count)
        {
            goto label_26;
        }
        
        label_5:
        if((1157659088 & 1) != 0)
        {
            goto label_27;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(FortDefenceLinkController.丄丘七三上丕世丞业 != 0)
        {
                UnityEngine.Color val_24 = UnityEngine.Color.red;
            UnityEngine.Color val_25 = UnityEngine.Color.gray;
            UnityEngine.Color val_26 = UnityEngine.Color.blue;
            val_4 = 0;
            UnityEngine.Color val_27 = UnityEngine.Color.green;
        }
        
        }
        
        System.Collections.Generic.List<FortDamageableGenerator> val_28 = new System.Collections.Generic.List<FortDamageableGenerator>();
        List.Enumerator<T> val_29 = this._listGeneratorPoints.GetEnumerator();
        goto label_63;
        label_70:
        string val_30 = val_4.丐丏七丌丕丗业且上();
        val_39 = 0;
        goto label_64;
        label_69:
        mem2[0] = 0;
        FortDamageableGenerator val_31 = val_21.Item[0];
        val_28.Add(item:  val_31);
        val_39 = 1;
        label_64:
        if(val_39 < val_31.Count)
        {
            goto label_69;
        }
        
        label_63:
        if((1157659088 & 1) != 0)
        {
            goto label_70;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_28.Add(item:  FortDefenceLinkController.丄丘七三上丕世丞业.baseGenerator);
        val_34 = 下丝且丐丞丘一丁丂();
        val_34.七丂丅丗不丟丏丒七(丐业丗万丂丛下丁下:  val_28, 丂丞丅丁丕丁上丁丏:  FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor);
    }
    private void Update()
    {
        InGameGUI val_3;
        this.且与丒一且丛东丆三();
        this.丆丝丑丈丑丞丞丐专();
        this.丁丗且丂且丘与一专();
        val_3 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = 丌丗一丁与丐丟丗三();
        val_2.丞不不丛丏世丁丞万 = true;
    }
    private void 且与丒一且丛东丆三()
    {
        object val_4;
        var val_37;
        GeneratorIndications val_38;
        var val_39;
        var val_40;
        var val_41;
        UnityEngine.Object val_42;
        object val_43;
        var val_44;
        var val_45;
        val_38 = this;
        if(this.丆世不丄业丘丆且丒 != true)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                this.丕七下丗专丈三丄丈();
            this.丆世不丄业丘丆且丒 = true;
        }
        else
        {
                if(this.丆世不丄业丘丆且丒 == false)
        {
                return;
        }
        
        }
        
        }
        
        List.Enumerator<T> val_2 = this._listGeneratorPoints.GetEnumerator();
        val_37 = 1152921540124209040;
        val_40 = 0;
        val_41 = 0;
        val_42 = 0;
        var val_37 = 0;
        label_122:
        if((1158037728 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(X23 == 0)
        {
            goto label_16;
        }
        
        DamageableObject val_7 = X23.业丒丁丙丛丒上丙丟();
        if(val_7 == 0)
        {
            goto label_16;
        }
        
        DamageableObject val_9 = val_7.业丒丁丙丛丒上丙丟();
        if(val_9.IsDead() == false)
        {
            goto label_19;
        }
        
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_11 = val_9.GetEnumerator();
        val_43 = 1;
        goto label_23;
        label_29:
        val_43 = 2;
        label_23:
        if((1158037696 & 1) == 0)
        {
            goto label_24;
        }
        
        string val_12 = val_4.丐丏七丌丕丗业且上();
        if((val_12 == 0) || (val_12.丏丏丘丄丟丆丝丗丄() == true))
        {
            goto label_29;
        }
        
        if(val_5 == null)
        {
            goto label_30;
        }
        
        if(val_42 != 0)
        {
                DamageableObject val_16 = val_42.业丒丁丙丛丒上丙丟();
            if(val_16 != 0)
        {
                DamageableObject val_18 = val_16.业丒丁丙丛丒上丙丟();
            System.Action<DamageableObject> val_19 = new System.Action<DamageableObject>(object:  this, method:  System.Void GeneratorIndications::丒与丐丟业丐专丁上(DamageableObject 丅丞万丒不专丈专丕));
            val_18.上丄丟一丂丟与丛丗(丙业与丙丗丝不丈东:  null);
            System.Action<DamageableObject> val_21 = new System.Action<DamageableObject>(object:  this, method:  System.Void GeneratorIndications::上业丄七且丘丐与七(DamageableObject 丅丞万丒不专丈专丕));
            val_18.业丒丁丙丛丒上丙丟().丗丁世丈东丗丐丘世(丙业与丙丗丝不丈东:  null);
        }
        
        }
        
        mem2[0] = val_12;
        val_44 = val_12;
        if(val_44 != null)
        {
            goto label_45;
        }
        
        goto label_43;
        label_24:
        val_45 = val_37 + 1;
        mem2[0] = 502;
        goto label_69;
        label_30:
        mem2[0] = val_12;
        if(val_42 != 0)
        {
            goto label_45;
        }
        
        label_43:
        label_45:
        DamageableObject val_22 = val_42.业丒丁丙丛丒上丙丟();
        System.Action<DamageableObject> val_23 = new System.Action<DamageableObject>(object:  this, method:  System.Void GeneratorIndications::丒与丐丟业丐专丁上(DamageableObject 丅丞万丒不专丈专丕));
        val_22.丆下且丘七丂不丂专(丙业与丙丗丝不丈东:  null);
        DamageableObject val_24 = val_22.业丒丁丙丛丒上丙丟();
        System.Action<DamageableObject> val_25 = new System.Action<DamageableObject>(object:  this, method:  System.Void GeneratorIndications::上业丄七且丘丐与七(DamageableObject 丅丞万丒不专丈专丕));
        val_24.丗丕世丞专丄丙三丛(丙业与丙丗丝不丈东:  null);
        object[] val_26 = new object[4];
        val_26[0] = "Point_";
        val_26[1] = val_5.m_stringLength;
        val_26[2] = "_";
        val_4 = val_43;
        val_26[3] = val_4;
        val_24.与丕与丝丑丐丁丐丕(丒丘丏上丙丟丑丕丈:  +val_26);
        val_39 = 1158037632;
        val_24.丂丁丅世丙上丕与丏(与专丌丅丙上丌一丄:  0.4f);
        UnityEngine.Transform val_28 = val_12.丌丟丄业且三丛丕丄();
        val_24.万三丗丆下万丅上丈(丞下万上三丘上与专:  val_28, 丒专丌万丄一丒万丏:  2.4f);
        UnityEngine.Color val_29 = UnityEngine.Color.blue;
        val_42 = 0;
        val_28.丛丟专丕世下丒丛七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_28, 丏业丟一东丂东丘丛:  true);
        val_45 = val_37 + 1;
        mem2[0] = 502;
        label_69:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_45 == 1) || ((val_39 + ((0 + 1)) << 2) != 502))
        {
            goto label_104;
        }
        
        val_45 = val_45 + (val_42 ^ (val_45 >> 31));
        label_19:
        if(val_5 != null)
        {
            goto label_110;
        }
        
        goto label_109;
        label_104:
        if( == null)
        {
            goto label_107;
        }
        
        if(val_5 != null)
        {
            goto label_110;
        }
        
        goto label_109;
        label_107:
        if(val_5 != null)
        {
            goto label_110;
        }
        
        label_109:
        label_110:
        if((val_28 == 0) || (val_28 == 0))
        {
            goto label_122;
        }
        
        float val_36 = val_5.业丒丁丙丛丒上丙丟().maxHealth;
        val_36 = val_42.业丒丁丙丛丒上丙丟().三丏丟不丆丅丞不丛() / val_36;
        val_28.丝与丑与丘丝专与且(丛丁三世世丆七不业:  val_36);
        goto label_122;
        label_8:
        val_37 = val_37 + 1;
        mem2[0] = 602;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_37 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921540124622976 + ((0 + 1)) << 2) == 602)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private void 丒与丐丟业丐专丁上(DamageableObject 丅丞万丒不专丈专丕)
    {
        var val_3;
        var val_11;
        var val_12;
        var val_13;
        List.Enumerator<T> val_1 = mem[1152921540124849784].GetEnumerator();
        val_11 = 0;
        val_12 = 0;
        var val_11 = 0;
        label_26:
        if((1158252176 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        List.Enumerator<T> val_5 = X23.GetEnumerator();
        label_12:
        if((1158252144 & 1) == 0)
        {
            goto label_5;
        }
        
        DamageableObject val_7 = val_3.丐丏七丌丕丗业且上().业丒丁丙丛丒上丙丟();
        if(val_7 != 丅丞万丒不专丈专丕)
        {
            goto label_12;
        }
        
        UnityEngine.Color val_9 = UnityEngine.Color.red;
        val_7.丛丟专丕世下丒丛七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
        this.丈三丑上且三业与上(丑丞丑丆与业丑丄丗:  丅丞万丒不专丈专丕, 丕一一丞丂丕丆世与:  X24, 丅专与丒丈丗丒丘丌:  val_4.m_stringLength, 东上业丐丄专七丑业:  1.ToString());
        goto label_12;
        label_5:
        val_11 = val_11 + 1;
        val_13 = val_12;
        mem2[0] = 129;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_11 == 1) || ((1158252080 + ((0 + 1)) << 2) != 129))
        {
            goto label_23;
        }
        
        var val_12 = 0;
        val_12 = val_12 ^ (val_11 >> 31);
        val_11 = val_11 + val_12;
        goto label_26;
        label_23:
        if( == 0)
        {
            goto label_26;
        }
        
        goto label_26;
        label_2:
        val_11 = val_11 + 1;
        mem2[0] = 154;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_11 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1158252080 + ((0 + 1)) << 2) == 154)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private void 上业丄七且丘丐与七(DamageableObject 丅丞万丒不专丈专丕)
    {
        object val_3;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        List.Enumerator<T> val_1 = mem[1152921540125015128].GetEnumerator();
        val_13 = 1152921540102888656;
        val_14 = 1152921540102889680;
        val_15 = 1152921504848912384;
        val_16 = 0;
        val_17 = 0;
        val_18 = 0;
        label_34:
        if((1158417504 & 1) == 0)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_5 = val_3.丐丏七丌丕丗业且上().GetEnumerator();
        goto label_5;
        label_18:
        if(val_3.丐丏七丌丕丗业且上().业丒丁丙丛丒上丙丟() == 丅丞万丒不专丈专丕)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_3 = 1;
            丌丗一丁与丐丟丗三().Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7966"), arg0:  val_3), 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = mem[1152921540125015112], g = mem[1152921540125015116], b = mem[1152921540125015120], a = mem[1152921540125015124]});
            val_13 = val_13;
            val_18 = val_18;
        }
        
        }
        
        label_5:
        if((1158417472 & 1) != 0)
        {
            goto label_18;
        }
        
        val_19 = val_17;
        val_20 = val_18 + 1;
        mem2[0] = 153;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_20 == 1) || ((1158417408 + ((val_18 + 1)) << 2) != 153))
        {
            goto label_31;
        }
        
        var val_13 = 0;
        val_13 = val_13 ^ (val_20 >> 31);
        val_20 = val_20 + val_13;
        goto label_34;
        label_31:
        if( == 0)
        {
            goto label_34;
        }
        
        goto label_34;
        label_2:
        val_22 = val_18 + 1;
        mem2[0] = 181;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_20 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1158417408 + ((val_18 + 1)) << 2) == 181)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private void 丈三丑上且三业与上(DamageableObject 丑丞丑丆与业丑丄丗, WorldPosIndicatonItem_Filling 丕一一丞丂丕丆世与, string 丅专与丒丈丗丒丘丌, string 东上业丐丄专七丑业)
    {
        var val_22;
        var val_23;
        System.Collections.Generic.List<东世丗下世丌与一丆> val_24;
        float val_26;
        var val_27;
        val_22 = this;
        val_23 = 0;
        goto label_1;
        label_6:
        东世丗下世丌与一丆 val_1 = X25.Item[0];
        if((System.String.op_Equality(a:  丅专与丒丈丗丒丘丌, b:  val_1.丛丂丂一丛丕东丙丛)) == true)
        {
            goto label_4;
        }
        
        val_23 = 1;
        label_1:
        val_24 = this.专丛下丞丅丄丑丟与;
        if(val_23 < this.专丛下丞丅丄丑丟与.Count)
        {
            goto label_6;
        }
        
        GeneratorIndications.东世丗下世丌与一丆 val_4 = new GeneratorIndications.东世丗下世丌与一丆();
        if(val_4 == null)
        {
            goto label_7;
        }
        
        .丛丂丂一丛丕东丙丛 = 丅专与丒丈丗丒丘丌;
        .东上业丐丄专七丑业 = 东上业丐丄专七丑业;
        .下丗不丟丌丂丟一丞 = UnityEngine.Time.time;
        .丘丘丙丐且丂丂丂丅 = true;
        .丅丞万丒不专丈专丕 = 丑丞丑丆与业丑丄丗;
        goto label_8;
        label_4:
        val_24 = this.专丛下丞丅丄丑丟与.Item[0];
        val_6.东上业丐丄专七丑业 = 东上业丐丄专七丑业;
        东世丗下世丌与一丆 val_7 = this.专丛下丞丅丄丑丟与.Item[0];
        val_7.丅丞万丒不专丈专丕 = 丑丞丑丆与业丑丄丗;
        东世丗下世丌与一丆 val_8 = this.专丛下丞丅丄丑丟与.Item[0];
        val_8.丛丂丂一丛丕东丙丛 = 丅专与丒丈丗丒丘丌;
        东世丗下世丌与一丆 val_9 = this.专丛下丞丅丄丑丟与.Item[0];
        val_26 = UnityEngine.Time.time;
        val_9.下丗不丟丌丂丟一丞 = val_26;
        东世丗下世丌与一丆 val_11 = this.专丛下丞丅丄丑丟与.Item[0];
        val_11.丘丘丙丐且丂丂丂丅 = true;
        val_22 = this.专丛下丞丅丄丑丟与.Item[0];
        val_12.丞丈且下且丙丞与丈 = 丕一一丞丂丕丆世与;
        return;
        label_7:
        mem[40] = 东上业丐丄专七丑业;
        mem[32] = 丅专与丒丈丗丒丘丌;
        val_26 = UnityEngine.Time.time;
        mem[48] = val_26;
        .丘丘丙丐且丂丂丂丅 = true;
        mem[16] = 丑丞丑丆与业丑丄丗;
        label_8:
        .丞丈且下且丙丞与丈 = 丕一一丞丂丕丆世与;
        val_24.Add(item:  val_4);
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.专丛下丞丅丄丑丟与 != null)
        {
                val_27 = this.专丛下丞丅丄丑丟与.Count;
        }
        else
        {
                val_27 = 0.Count;
        }
        
        东世丗下世丌与一丆 val_20 = this.专丛下丞丅丄丑丟与.Item[val_27 - 1];
        丌丗一丁与丐丟丗三().Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7967"), arg0:  val_20.东上业丐丄专七丑业), 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丄丂专且七丌业丙不, g = V9.16B, b = V10.16B, a = V11.16B});
    }
    private void 丁丗且丂且丘与一专()
    {
        List.Enumerator<T> val_1 = this.专丛下丞丅丄丑丟与.GetEnumerator();
        label_7:
        if((1158910968 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = S8 + val_3;
        mem2[0] = val_3;
        if(val_3 < this.deleyTimeChangeColor)
        {
            goto label_7;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        if(0 != 0)
        {
            goto label_5;
        }
        
        UnityEngine.Color val_4 = UnityEngine.Color.red;
        label_8:
        this.专丛下丞丅丄丑丟与.丛丟专丕世下丒丛七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        goto label_7;
        label_5:
        UnityEngine.Color val_5 = UnityEngine.Color.blue;
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丆丝丑丈丑丞丞丐专()
    {
        var val_13;
        float val_14;
        val_13 = 0;
        goto label_23;
        label_26:
        东世丗下世丌与一丆 val_1 = this.专丛下丞丅丄丑丟与.Item[0];
        if(val_1.丅丞万丒不专丈专丕 != 0)
        {
                东世丗下世丌与一丆 val_3 = this.专丛下丞丅丄丑丟与.Item[0];
            if(val_3.丅丞万丒不专丈专丕.IsDead() != true)
        {
                东世丗下世丌与一丆 val_5 = this.专丛下丞丅丄丑丟与.Item[0];
            val_14 = val_5.下丗不丟丌丂丟一丞;
            float val_6 = UnityEngine.Time.time;
            if((val_14 + this.timeToHidePoint) >= 0)
        {
            goto label_24;
        }
        
        }
        
        }
        
        东世丗下世丌与一丆 val_8 = this.专丛下丞丅丄丑丟与.Item[0];
        if(val_8.丞丈且下且丙丞与丈 != 0)
        {
                东世丗下世丌与一丆 val_10 = this.专丛下丞丅丄丑丟与.Item[0];
            UnityEngine.Color val_11 = UnityEngine.Color.blue;
            val_14 = val_11.r;
            val_10.丞丈且下且丙丞与丈.丛丟专丕世下丒丛七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_14, g = val_11.g, b = val_11.b, a = val_11.a});
        }
        
        this.专丛下丞丅丄丑丟与.RemoveAt(index:  0);
        label_24:
        val_13 = 1;
        label_23:
        if(val_13 < this.专丛下丞丅丄丑丟与.Count)
        {
            goto label_26;
        }
    
    }
    public GeneratorIndications()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.丄丂专且七丌业丙不 = val_1;
        mem[1152921540125883036] = val_1.g;
        mem[1152921540125883040] = val_1.b;
        mem[1152921540125883044] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.red;
        this.丑丞丈丗丄丙丟万丄 = val_2;
        mem[1152921540125883052] = val_2.g;
        mem[1152921540125883056] = val_2.b;
        mem[1152921540125883060] = val_2.a;
        this._listGeneratorPoints = new System.Collections.Generic.List<GeneratorPoints>();
        this.专丛下丞丅丄丑丟与 = new System.Collections.Generic.List<东世丗下世丌与一丆>();
        this.deleyTimeChangeColor = 0.5f;
        this.timeToHidePoint = Infinityf;
    }

}
