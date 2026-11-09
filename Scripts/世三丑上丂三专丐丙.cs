using UnityEngine;
internal sealed class 世三丑上丂三专丐丙
{
    // Fields
    private const int 丈上专丈丕且丆丑丕 = 120;
    private const int 不世东且丛丏丁下且 = 10;
    internal readonly int 丏丗丙丄丞丄丝丌丈;
    internal string 丅与丅丛丏万三丙七;
    private System.Collections.Generic.List<NetworkStartTable> 丛丂丛丝丑业丈丕丏;
    private System.Collections.Generic.List<万丅世丈丕丕丌丅丗> 且丘下丐一丅下丙丒;
    private System.Collections.Generic.List<世三丑上丂三专丐丙.丅不丄一丌下丁丕世> 三且丁丐一专丟丟与;
    private System.Collections.Generic.List<世三丑上丂三专丐丙.丅不丄一丌下丁丕世> 丘丝丆丐丕七丘丞不;
    internal Player_move_c 丗世丄丁丝丏万丝东;
    private NetworkStartTable 丁丌丄业丐东与且丑;
    private float 丕丕丛专丒世三且不;
    private bool 丑东丝下世丝丕三丒;
    
    // Properties
    internal System.Collections.Generic.List<NetworkStartTable> 下丙万且丒丗丑业且 { get; }
    internal bool 丘丗丈丅丏三且丒世 { get; }
    internal float 东丘丄万东万与且丁 { get; }
    internal int 丄丐丗丑七丑上丆不 { get; }
    
    // Methods
    internal System.Collections.Generic.List<NetworkStartTable> 丕丄丛丁丆丛东丐丕()
    {
        return (System.Collections.Generic.List<NetworkStartTable>)this.丛丂丛丝丑业丈丕丏;
    }
    public 世三丑上丂三专丐丙(int 丅三七丞丝丁专不丕)
    {
        this.丅与丅丛丏万三丙七 = System.String.alignConst;
        this.丛丂丛丝丑业丈丕丏 = new System.Collections.Generic.List<NetworkStartTable>();
        this.且丘下丐一丅下丙丒 = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>();
        this.三且丁丐一专丟丟与 = new System.Collections.Generic.List<丅不丄一丌下丁丕世>();
        this.丘丝丆丐丕七丘丞不 = new System.Collections.Generic.List<丅不丄一丌下丁丕世>();
        this.丕丕丛专丒世三且不 = -1f;
        this.丑东丝下世丝丕三丒 = true;
        this.丏丗丙丄丞丄丝丌丈 = 丅三七丞丝丁专不丕;
    }
    internal void 丅世东丂丘世丏下东()
    {
        this.丑东丝下世丝丕三丒 = true;
        if(this.丕丕丛专丒世三且不 <= 0f)
        {
                return;
        }
        
        this.丕丕丛专丒世三且不 = 10f;
    }
    internal bool 丆世一丄丞专丗不东()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.丅与丅丛丏万三丙七);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal float 丂专丐丒丟丞丕万丈()
    {
        return (float)this.丕丕丛专丒世三且不;
    }
    internal int 且丌世丈下丄三丅丅()
    {
        int val_1 = this.丛丂丛丝丑业丈丕丏.Count;
        val_1 = val_1 + 1;
        return (int)val_1;
    }
    internal bool 丘七丈丅丐丄丐丗万(FreeplayVehicleOwner 七三丁丄三一且丘上)
    {
        .七三丁丄三一且丘上 = 七三丁丄三一且丘上;
        int val_3 = this.丛丂丛丝丑业丈丕丏.FindIndex(match:  new System.Predicate<NetworkStartTable>(object:  new 世三丑上丂三专丐丙.上三且上丁业与与丑(), method:  System.Boolean 世三丑上丂三专丐丙.上三且上丁业与与丑::丑丝丞且丈丂业丝丆(NetworkStartTable 不且上一上丐三万丛)));
        val_3 = (val_3 >> 31) ^ 1;
        return (bool)val_3;
    }
    internal bool 丐丘专与上不丗丕丌(NetworkStartTable 下业七丕丝不世上丟)
    {
        var val_2;
        if(this.丁丌丄业丐东与且丑 != 0)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        val_2 = 1;
        this.丁丌丄业丐东与且丑 = 下业七丕丝不世上丟;
        return (bool)val_2;
    }
    internal void 业一丘专丈丂三丑丗(System.Nullable<bool> 丙业与丙丗丝不丈东)
    {
        string val_15;
        var val_16;
        var val_17;
        int val_18;
        var val_19;
        if(((-1307794996) & 1) == 0)
        {
            goto label_35;
        }
        
        val_15 = 1152921516780988800;
        if((((((-1307794996) & 1) == 0) || ((System.String.IsNullOrEmpty(value:  this.丅与丅丛丏万三丙七)) == false)) || (this.丁丌丄业丐东与且丑 == 0)) || (this.丁丌丄业丐东与且丑.丄丈丑丐丆丞丘与丗.owner == null))
        {
            goto label_9;
        }
        
        ExitGames.Client.Photon.Hashtable val_5 = this.丁丌丄业丐东与且丑.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆();
        val_16 = null;
        val_16 = null;
        val_15 = GameConnect.与丈业东丂丘丅三丙;
        if((val_5.ContainsKey(key:  val_15)) == false)
        {
            goto label_16;
        }
        
        val_17 = null;
        val_17 = null;
        val_15 = GameConnect.与丈业东丂丘丅三丙;
        val_18 = System.Convert.ToString(value:  val_5.Item[val_15]);
        goto label_22;
        label_9:
        if(((((-1307794996) & 1) != 0) || (this.丁丌丄业丐东与且丑 == 0)) || (this.丁丌丄业丐东与且丑.丄丈丑丐丆丞丘与丗.owner == null))
        {
            goto label_35;
        }
        
        val_19 = null;
        val_15 = System.String.alignConst;
        val_19 = null;
        this.丁丌丄业丐东与且丑.上丏七且丙丕不丞丘(且丏丝丂丑丅丄丈丏:  false, 万万丛丒丑丁丙业丑:  val_15, 与一丅三下丅丘丗三:  true, 丘丂丌丈丟东三业丟:  NetworkStartTable.__il2cppRuntimeField_method_count);
        goto label_35;
        label_16:
        val_18 = System.String.alignConst;
        label_22:
        if((System.String.IsNullOrEmpty(value:  val_18)) != false)
        {
                val_15 = this.丁丌丄业丐东与且丑;
            val_18 = "s" + 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
            val_15.丆丑万丝与一与丅丌(丈丏丕丛丟丘万丛丄:  val_18);
        }
        
        this.丛丕丆丛丏专丙七东(丈丏丕丛丟丘万丛丄:  val_18, 丆丄且丐丕东三丘丏:  true);
        label_35:
        this.丁丌丄业丐东与且丑 = 0;
    }
    internal void 丛丕丆丛丏专丙七东(string 丈丏丕丛丟丘万丛丄, bool 丆丄且丐丕东三丘丏 = False)
    {
        object val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_10 = 丈丏丕丛丟丘万丛丄;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_11 = null;
        val_11 = null;
        val_1.Add(key:  GameConnect.与丈业东丂丘丅三丙, value:  val_10);
        val_12 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_12.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        this.丅与丅丛丏万三丙七 = val_10;
        if(丆丄且丐丕东三丘丏 == false)
        {
                return;
        }
        
        val_12 = 1152921505189646336;
        val_13 = 0;
        goto label_8;
        label_29:
        val_14 = null;
        val_14 = null;
        if(Item[0] == 0)
        {
            goto label_15;
        }
        
        val_15 = null;
        val_15 = null;
        NetworkStartTable val_5 = Item[0];
        if(val_5.丄丈丑丐丆丞丘与丗.owner == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())
        {
            goto label_24;
        }
        
        label_15:
        val_13 = 1;
        label_8:
        val_16 = null;
        val_16 = null;
        val_10 = mem[GameController.onlineMode + 392];
        val_10 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_13 < Count)
        {
            goto label_29;
        }
        
        return;
        label_24:
        val_17 = null;
        val_17 = null;
        Item[0].丆丑万丝与一与丅丌(丈丏丕丛丟丘万丛丄:  this.丅与丅丛丏万三丙七);
    }
    internal bool 东与丗丂丛丌丁丁丄()
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = this.丅与丅丛丏万三丙七;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_10)) == false)
        {
                return true;
        }
        
        val_10 = 0;
        goto label_4;
        label_39:
        val_11 = null;
        val_11 = null;
        if(Item[0] != 0)
        {
                val_12 = null;
            val_12 = null;
            NetworkStartTable val_4 = Item[0];
            if(val_4.丄丈丑丐丆丞丘与丗.owner != null)
        {
                val_13 = null;
            val_13 = null;
            val_14 = null;
            val_14 = null;
            if(Item[0] != WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)
        {
                val_15 = null;
            val_15 = null;
            NetworkStartTable val_8 = Item[0];
            if(val_8.丞丗丅东业丑不丙丞 == true)
        {
                return true;
        }
        
        }
        
        }
        
        }
        
        val_10 = 1;
        label_4:
        val_16 = null;
        val_16 = null;
        if(val_10 < Count)
        {
            goto label_39;
        }
        
        return true;
    }
    internal void 不三丟丟专丗万业下()
    {
        var val_6;
        var val_7;
        System.Collections.Generic.List<NetworkStartTable> val_8;
        var val_9;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_6 = null;
        val_6 = null;
        val_1.Add(key:  GameConnect.与丈业东丂丘丅三丙, value:  System.String.alignConst);
        与丅丕丈丘东丝世丟 val_2 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if(val_2 != null)
        {
                val_2.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        this.丅与丅丛丏万三丙七 = System.String.alignConst;
        val_7 = null;
        val_7 = null;
        typeof(NetworkStartTable).__il2cppRuntimeField_D8 = 0;
        丘丑丗万丛丌丒万丌();
        val_8 = this.丛丂丛丝丑业丈丕丏;
        List.Enumerator<T> val_3 = val_8.GetEnumerator();
        label_21:
        if(((-1307217368) & 1) == 0)
        {
            goto label_14;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        mem2[0] = 0;
        val_9 = null;
        val_9 = null;
        丝丐丒业丄丄与丂丂(丑且丅丟不丂丌与丝:  owner);
        goto label_21;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal bool 东丟一七丁丞丝丏丕()
    {
        bool val_1 = this.丌丑丑丙丗丛丟丕丏();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal bool 丌丑丑丙丗丛丟丕丏()
    {
        if(this.丛丂丛丝丑业丈丕丏.Count == 0)
        {
                return (bool)((this.丛丂丛丝丑业丈丕丏.Count + 1) >= this.丏丗丙丄丞丄丝丌丈) ? 1 : 0;
        }
        
        return (bool)((this.丛丂丛丝丑业丈丕丏.Count + 1) >= this.丏丗丙丄丞丄丝丌丈) ? 1 : 0;
    }
    internal void 丛七不下业东世与丑()
    {
        var val_16;
        System.Collections.Generic.List<万丅世丈丕丕丌丅丗> val_79;
        var val_80;
        var val_81;
        int val_82;
        var val_83;
        System.Collections.Generic.List<NetworkStartTable> val_84;
        var val_86;
        var val_87;
        var val_88;
        var val_89;
        var val_90;
        var val_91;
        var val_92;
        var val_93;
        var val_94;
        string val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        var val_100;
        万丅世丈丕丕丌丅丗 val_102;
        var val_103;
        var val_104;
        var val_105;
        var val_106;
        int val_107;
        int val_108;
        var val_109;
        var val_110;
        int val_111;
        var val_112;
        val_79 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() != null)
        {
                val_80 = null;
            val_80 = null;
            if((丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.与丈业东丂丘丅三丙)) != false)
        {
                val_81 = null;
            val_81 = null;
            val_82 = System.Convert.ToString(value:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().Item[GameConnect.与丈业东丂丘丅三丙]);
        }
        else
        {
                val_82 = System.String.alignConst;
        }
        
            if((this.丅与丅丛丏万三丙七.Equals(value:  val_82)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  val_82)) != true)
        {
                this.丅与丅丛丏万三丙七 = val_82;
        }
        
        }
        
        }
        
        val_83 = 1152921525488042576;
        val_84 = this.丛丂丛丝丑业丈丕丏;
        val_84.Clear();
        if((System.String.IsNullOrEmpty(value:  this.丅与丅丛丏万三丙七)) == false)
        {
            goto label_25;
        }
        
        if(this.且丘下丐一丅下丙丒.Count < 1)
        {
            goto label_243;
        }
        
        List.Enumerator<T> val_14 = this.且丘下丐一丅下丙丒.GetEnumerator();
        val_84 = 1152921537659783200;
        val_79 = 0;
        goto label_29;
        label_32:
        string val_17 = val_16.丐丏七丌丕丗业且上();
        mem2[0] = val_79;
        label_29:
        if(((-1306576272) & 1) != 0)
        {
            goto label_32;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_149;
        label_25:
        val_86 = 0;
        goto label_34;
        label_131:
        val_87 = null;
        val_87 = null;
        if(Item[0] == 0)
        {
            goto label_126;
        }
        
        val_88 = null;
        val_88 = null;
        NetworkStartTable val_20 = Item[0];
        if(val_20.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_126;
        }
        
        val_89 = null;
        val_89 = null;
        val_90 = null;
        val_90 = null;
        if(Item[0] == WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)
        {
            goto label_126;
        }
        
        val_91 = null;
        val_91 = null;
        与丅丕丈丘东丝世丟 val_25 = val_24.丄丈丑丐丆丞丘与丗.owner;
        val_92 = null;
        val_92 = null;
        if((val_25.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.与丈业东丂丘丅三丙)) != false)
        {
                val_93 = 1152921525488042576;
            val_94 = null;
            val_94 = null;
            string val_30 = System.Convert.ToString(value:  val_25.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丈业东丂丘丅三丙]);
        }
        else
        {
                val_95 = "";
            val_93 = 1152921525488042576;
        }
        
        if((System.String.op_Equality(a:  val_95, b:  this.丅与丅丛丏万三丙七)) == false)
        {
            goto label_77;
        }
        
        this.丛丂丛丝丑业丈丕丏.Add(item:  Item[0]);
        this.丁丁丁世丗世上下丕(七丄丞不世三丅专万:  val_24.丈三世丞丕万丄七丂);
        this.不丘丑东丟丁丘丂丏(七丄丞不世三丅专万:  val_24.丈三世丞丕万丄七丂);
        val_96 = null;
        val_96 = null;
        NetworkStartTable val_32 = Item[0];
        if(val_32.丞丗丅东业丑不丙丞 != true)
        {
                val_97 = null;
            val_97 = null;
            NetworkStartTable val_33 = Item[0];
            val_33.丞丗丅东业丑不丙丞 = true;
        }
        
        val_98 = 0;
        goto label_90;
        label_100:
        val_98 = 1;
        label_90:
        if(val_98 >= this.且丘下丐一丅下丙丒.Count)
        {
            goto label_92;
        }
        
        万丅世丈丕丕丌丅丗 val_35 = this.且丘下丐一丅下丙丒.Item[1];
        val_99 = null;
        val_99 = null;
        NetworkStartTable val_36 = Item[0];
        if((System.String.op_Equality(a:  val_35.丆世丘丒丒丏上且丗, b:  val_36.丈三世丞丕万丄七丂)) == false)
        {
            goto label_100;
        }
        
        if(this.且丘下丐一丅下丙丒.Item[1] != null)
        {
            goto label_126;
        }
        
        label_92:
        val_100 = null;
        val_100 = null;
        this.且丘下丐一丅下丙丒.Add(item:  new 万丅世丈丕丕丌丅丗(不且上一上丐三万丛:  Item[0], 丒东丑丟世与下且丟:  0));
        goto label_126;
        label_77:
        List.Enumerator<T> val_41 = this.且丘下丐一丅下丙丒.GetEnumerator();
        label_113:
        if(((-1306576272) & 1) == 0)
        {
            goto label_110;
        }
        
        val_102 = val_16.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_42.m_stringLength + 272, b:  val_24.丈三世丞丕万丄七丂)) == false)
        {
            goto label_113;
        }
        
        goto label_114;
        label_110:
        val_102 = 0;
        label_114:
        val_103 = 0 + 1;
        mem2[0] = 642;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_104 = ;
        if(( != 1) && (1372 == 642))
        {
                val_104 = 0;
        }
        else
        {
                if(val_16 != 0)
        {
                val_104 = val_104;
        }
        
        }
        
        if( != 0)
        {
                bool val_44 = this.且丘下丐一丅下丙丒.Remove(item:  null);
            val_24.丙丕丗丁丌丗不丗世 = 0;
            if(val_24.丞丗丅东业丑不丙丞 != false)
        {
                val_24.丞丗丅东业丑不丙丞 = false;
        }
        
        }
        
        label_126:
        val_86 = 1;
        label_34:
        val_105 = null;
        val_105 = null;
        if(val_86 < Count)
        {
            goto label_131;
        }
        
        int val_46 = this.丏丗丙丄丞丄丝丌丈 - 2;
        System.Collections.Generic.List<System.Int32> val_47 = new System.Collections.Generic.List<System.Int32>();
        val_106 = 0;
        if((val_46 & 2147483648) == 0)
        {
                var val_78 = 0;
            do
        {
            val_47.Add(item:  0);
            val_78 = val_78 + 1;
        }
        while(val_78 <= val_46);
        
        }
        
        List.Enumerator<T> val_48 = this.且丘下丐一丅下丙丒.GetEnumerator();
        label_141:
        if(((-1306576272) & 1) == 0)
        {
            goto label_136;
        }
        
        if((val_47.Contains(item:  0)) == false)
        {
            goto label_141;
        }
        
        bool val_51 = val_47.Remove(item:  val_16.丐丏七丌丕丗业且上());
        goto label_141;
        label_136:
        var val_79 = val_104;
        val_79 = val_79 + 1;
        mem2[0] = 830;
        goto label_142;
        label_149:
        this.且丘下丐一丅下丙丒.Clear();
        goto label_243;
        label_142:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_81 = val_79;
        if((val_81 != 1) && ((-1306576384 + ((val_104 + 1)) << 2) == 830))
        {
                var val_80 = 0;
            val_80 = val_80 ^ (val_81 >> 31);
            val_81 = val_81 + val_80;
        }
        else
        {
                if( != 0)
        {
                val_106 = 0;
        }
        
        }
        
        val_79 = this.且丘下丐一丅下丙丒;
        List.Enumerator<T> val_52 = val_79.GetEnumerator();
        label_183:
        if(((-1306576272) & 1) == 0)
        {
            goto label_158;
        }
        
        val_107 = val_16.丐丏七丌丕丗业且上();
        if((1152921537659784224 & 2147483648) == 0)
        {
                val_107 = val_53.m_stringLength;
        }
        else
        {
                val_108 = val_46;
            if(val_47.Count > 0)
        {
                val_108 = val_47.Item[0];
        }
        
            mem2[0] = val_108;
            mem2[0] = val_108;
            if(val_47.Count >= 1)
        {
                val_47.RemoveAt(index:  0);
        }
        
            var val_57 = (InGameGUI.丙丞专丌丁丞与不丐 == 0) ? 0 : InGameGUI.丙丞专丌丁丞与不丐;
            if(InGameGUI.丙丞专丌丁丞与不丐 != null)
        {
                if((InGameGUI.丙丞专丌丁丞与不丐 == null ? 0 : InGameGUI.丙丞专丌丁丞与不丐 + 920) != 0)
        {
                ((InGameGUI.丙丞专丌丁丞与不丐 == null ? 0 : InGameGUI.丙丞专丌丁丞与不丐 + 920) == 0) ? 0 : (InGameGUI.丙丞专丌丁丞与不丐 == null ? 0 : InGameGUI.丙丞专丌丁丞与不丐 + 920).万丘三世丛丅与一丗(专丞上七七且丝七丗:  val_53 + 16 + 168);
        }
        
        }
        
        }
        
        if(((val_53 + 16 + 168) == 0) || ((val_53 + 16 + 168.丞丗丙一东丌丘与丕()) == false))
        {
            goto label_183;
        }
        
        val_53 + 16 + 168.丘丌丞丞且三丑不丐(丙业与丙丗丝不丈东:  false);
        goto label_183;
        label_158:
        var val_82 = val_81;
        val_82 = val_82 + 1;
        mem2[0] = 1052;
        val_109 = 1152921525488042576;
        val_110 = 1152921505107111936;
        val_111 = this.丛丂丛丝丑业丈丕丏.Count;
        val_112 = val_106;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_84 = val_82;
        if((val_84 != 1) && ((-1306576384 + ((((val_104 + 1) + (0 ^ ((int)(val_104 + 1)) >> 31)) + 1)) << 2) == 1052))
        {
                var val_83 = 0;
            val_83 = val_83 ^ (val_84 >> 31);
            val_84 = val_84 + val_83;
        }
        else
        {
                if( != 0)
        {
                val_112 = 0;
        }
        
        }
        
        if(this.且丘下丐一丅下丙丒.Count < this.丏丗丙丄丞丄丝丌丈)
        {
            goto label_237;
        }
        
        int val_63 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        val_79 = this.丛丂丛丝丑业丈丕丏;
        List.Enumerator<T> val_64 = val_79.GetEnumerator();
        label_219:
        label_216:
        if(((-1306576304) & 1) == 0)
        {
            goto label_210;
        }
        
        if((val_79.owner == null) || (val_79.owner.业丐丐三丕一丗丛丁() <= val_63))
        {
            goto label_216;
        }
        
        int val_70 = val_16.丐丏七丌丕丗业且上().owner.业丐丐三丕一丗丛丁();
        goto label_219;
        label_210:
        var val_85 = val_84;
        val_85 = val_85 + 1;
        mem2[0] = 1189;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_85 == 1)
        {
            goto label_228;
        }
        
        if(( == 0) || ((-1306576384 + ((((((val_104 + 1) + (0 ^ ((int)(val_104 + 1)) >> 31)) + 1) + (0 ^ ((int)(((val_104 + 1) + (0 ^ ((int)(val_104 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) == 1189))
        {
            goto label_250;
        }
        
        label_249:
        label_250:
        if(val_63 == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁())
        {
                this.不三丟丟专丗万业下();
            if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.丝丏三与丐业丌丂万();
        }
        
        }
        
        label_237:
        val_84 = this.丅与丅丛丏万三丙七;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_84)) != false)
        {
                val_84 = this.丛丂丛丝丑业丈丕丏;
            if(( >= 1) && (val_84.Count == 0))
        {
                this.丕丕丛专丒世三且不 = (this.丑东丝下世丝丕三丒 == true) ? 10f : 120f;
        }
        
        }
        
        label_243:
        if(this.丕丕丛专丒世三且不 <= 0f)
        {
            goto label_247;
        }
        
        if(this.丛丂丛丝丑业丈丕丏.Count >= 1)
        {
            goto label_246;
        }
        
        float val_77 = UnityEngine.Time.deltaTime;
        val_77 = this.丕丕丛专丒世三且不 - val_77;
        this.丕丕丛专丒世三且不 = val_77;
        if(val_77 > 0f)
        {
            goto label_247;
        }
        
        this.不三丟丟专丗万业下();
        label_246:
        this.丕丕丛专丒世三且不 = -1f;
        label_247:
        if(this.丑东丝下世丝丕三丒 == false)
        {
                return;
        }
        
        this.丑东丝下世丝丕三丒 = false;
        return;
        label_228:
        if( != 0)
        {
            goto label_249;
        }
        
        goto label_250;
    }
    internal void 丈丈上丅丕丄丙七丂(string 七丄丞不世三丅专万)
    {
        int val_10;
        .七丄丞不世三丅专万 = 七丄丞不世三丅专万;
        int val_3 = this.丘丝丆丐丕七丘丞不.FindIndex(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.且下七业七业一上丈(), method:  System.Boolean 世三丑上丂三专丐丙.且下七业七业一上丈::三七万丛业丗专丒丂(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
        if((val_3 & 2147483648) != 0)
        {
            goto label_3;
        }
        
        if(this.丘丝丆丐丕七丘丞不.Item[val_3] == null)
        {
            goto label_5;
        }
        
        val_10 = val_4.东业丗不东丄业三丟;
        goto label_6;
        label_3:
        世三丑上丂三专丐丙.丅不丄一丌下丁丕世 val_5 = new 世三丑上丂三专丐丙.丅不丄一丌下丁丕世();
        if(val_5 == null)
        {
            goto label_7;
        }
        
        .丅丑下万万业丄东且 = (世三丑上丂三专丐丙.且下七业七业一上丈)[1152921537660477536].七丄丞不世三丅专万;
        goto label_8;
        label_5:
        val_10 = val_4.东业丗不东丄业三丟;
        label_6:
        mem2[0] = val_10 + 1;
        丅不丄一丌下丁丕世 val_7 = this.丘丝丆丐丕七丘丞不.Item[val_3];
        val_7.上下七丏丐丒专丙七 = PixelTime.丙丅丅业丟丁世丁丗();
        return;
        label_7:
        mem[16] = (世三丑上丂三专丐丙.且下七业七业一上丈)[1152921537660477536].七丄丞不世三丅专万;
        label_8:
        .东业丗不东丄业三丟 = 1;
        .上下七丏丐丒专丙七 = PixelTime.丙丅丅业丟丁世丁丗();
        this.丘丝丆丐丕七丘丞不.Add(item:  val_5);
    }
    internal void 万丝丄丂专丛丘一下(string 七丄丞不世三丅专万)
    {
        this.不丘丑东丟丁丘丂丏(七丄丞不世三丅专万:  七丄丞不世三丅专万);
        this.三且丁丐一专丟丟与.Add(item:  this.丌丛丑丏且三与丏丆(七丄丞不世三丅专万:  七丄丞不世三丅专万));
        this.丁丁丁世丗世上下丕(七丄丞不世三丅专万:  七丄丞不世三丅专万);
    }
    internal void 丁丁丁世丗世上下丕(string 七丄丞不世三丅专万)
    {
        .七丄丞不世三丅专万 = 七丄丞不世三丅专万;
        int val_3 = this.丘丝丆丐丕七丘丞不.FindIndex(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.下丏丌丑七丗丕丅世(), method:  System.Boolean 世三丑上丂三专丐丙.下丏丌丑七丗丕丅世::丕丟七东丙业三丗丘(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
        if((val_3 & 2147483648) != 0)
        {
                return;
        }
        
        this.丘丝丆丐丕七丘丞不.RemoveAt(index:  val_3);
    }
    internal void 不丘丑东丟丁丘丂丏(string 七丄丞不世三丅专万)
    {
        .七丄丞不世三丅专万 = 七丄丞不世三丅专万;
        int val_3 = this.三且丁丐一专丟丟与.FindIndex(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.丑丗东丞三且丂丄丒(), method:  System.Boolean 世三丑上丂三专丐丙.丑丗东丞三且丂丄丒::下丅丙丞丕丑且丅丐(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
        if((val_3 & 2147483648) != 0)
        {
                return;
        }
        
        this.三且丁丐一专丟丟与.RemoveAt(index:  val_3);
    }
    internal bool 丟丅丑丄丑丌万一专(string 七丄丞不世三丅专万)
    {
        .七丄丞不世三丅专万 = 七丄丞不世三丅专万;
        int val_3 = this.丘丝丆丐丕七丘丞不.FindIndex(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.且且丛丌丝三丏丙丛(), method:  System.Boolean 世三丑上丂三专丐丙.且且丛丌丝三丏丙丛::丒丛丐丕业一丁业世(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
        val_3 = (val_3 >> 31) ^ 1;
        return (bool)val_3;
    }
    internal bool 丞丒三上三专与丏丗(string 七丄丞不世三丅专万)
    {
        .七丄丞不世三丅专万 = 七丄丞不世三丅专万;
        if(this.三且丁丐一专丟丟与 != null)
        {
                return this.三且丁丐一专丟丟与.Exists(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.丟丑不七不丆业丐丛(), method:  System.Boolean 世三丑上丂三专丐丙.丟丑不七不丆业丐丛::与丗丈丏丟丄一丌丘(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
        }
        
        return this.三且丁丐一专丟丟与.Exists(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.丟丑不七不丆业丐丛(), method:  System.Boolean 世三丑上丂三专丐丙.丟丑不七不丆业丐丛::与丗丈丏丟丄一丌丘(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
    }
    internal 世三丑上丂三专丐丙.丅不丄一丌下丁丕世 丌丛丑丏且三与丏丆(string 七丄丞不世三丅专万)
    {
        System.Collections.Generic.List<丅不丄一丌下丁丕世> val_5;
        var val_6;
        val_5 = this;
        .七丄丞不世三丅专万 = 七丄丞不世三丅专万;
        int val_3 = this.丘丝丆丐丕七丘丞不.FindIndex(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.与丙丌丟一七下丏与(), method:  System.Boolean 世三丑上丂三专丐丙.与丙丌丟一七下丏与::丘丅丑丏丌丈丗下丆(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
        if((val_3 & 2147483648) == 0)
        {
                val_5 = this.丘丝丆丐丕七丘丞不;
            丅不丄一丌下丁丕世 val_4 = val_5.Item[val_3];
            return (丅不丄一丌下丁丕世)val_6;
        }
        
        val_6 = 0;
        return (丅不丄一丌下丁丕世)val_6;
    }
    internal 世三丑上丂三专丐丙.丅不丄一丌下丁丕世 丟丘下丗东丝丏丅丛(string 七丄丞不世三丅专万)
    {
        System.Collections.Generic.List<丅不丄一丌下丁丕世> val_5;
        var val_6;
        val_5 = this;
        .七丄丞不世三丅专万 = 七丄丞不世三丅专万;
        int val_3 = this.三且丁丐一专丟丟与.FindIndex(match:  new System.Predicate<丅不丄一丌下丁丕世>(object:  new 世三丑上丂三专丐丙.且不丘丝丕业下万一(), method:  System.Boolean 世三丑上丂三专丐丙.且不丘丝丕业下万一::丛丁丆丅丆丑丂万丟(世三丑上丂三专丐丙.丅不丄一丌下丁丕世 三丟东丕丄丄下下丑)));
        if((val_3 & 2147483648) == 0)
        {
                val_5 = this.三且丁丐一专丟丟与;
            丅不丄一丌下丁丕世 val_4 = val_5.Item[val_3];
            return (丅不丄一丌下丁丕世)val_6;
        }
        
        val_6 = 0;
        return (丅不丄一丌下丁丕世)val_6;
    }
    internal void 丁丌丁丂丅下丑丝万(string 丄丒且丙三丆丟与丏)
    {
        this.丁丁丁世丗世上下丕(七丄丞不世三丅专万:  丄丒且丙三丆丟与丏);
        this.不丘丑东丟丁丘丂丏(七丄丞不世三丅专万:  丄丒且丙三丆丟与丏);
    }

}
