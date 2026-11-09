using UnityEngine;
private sealed class BattlePassMainUI.不且上业万与丝且丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassMainUI 丝且与丝丒丟万丁专;
    private PGCompany.BattlePass.上丕丁专三丗丝万丆 丝丈丕东丞且不万不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassMainUI.不且上业万与丝且丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_77;
        var val_78;
        var val_79;
        System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_81;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_88;
        PGCompany.BattlePass.BPReward val_89;
        int val_90;
        System.Func<丕丟丕丌丒丞世与丅, System.Boolean> val_91;
        var val_94;
        System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_96;
        var val_97;
        System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_99;
        var val_100;
        BattlePassMainUI.丕丟丕丌丒丞世与丅 val_101;
        var val_102;
        var val_103;
        BattlePassMainUI.丕丟丕丌丒丞世与丅 val_104;
        var val_105;
        PGCompany.BattlePass.BPReward val_106;
        var val_107;
        var val_108;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_77 = Rilisoft.Singleton<BattlePassController>.Instance;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = val_77.丛东丛丕东丟丂丈丝();
        this.丝丈丕东丞且不万不 = val_2;
        if(val_2 == null)
        {
                return (bool)val_78;
        }
        
        this.丝且与丝丒丟万丁专._strech.to = 0;
        val_79 = null;
        val_79 = null;
        val_81 = BattlePassMainUI.<>c.<>9__50_0;
        if(val_81 == null)
        {
                System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_4 = null;
            val_81 = val_4;
            val_4 = new System.Func<PGCompany.BattlePass.BPReward, System.Int32>(object:  BattlePassMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassMainUI.<>c::丝丟与丗丄丂丗丗丘(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
            BattlePassMainUI.<>c.<>9__50_0 = val_81;
        }
        
        this.丝且与丝丒丟万丁专.丄丌专丈丗丆丆丈丗.Clear();
        System.Collections.Generic.List<丕丟丕丌丒丞世与丅> val_6 = new System.Collections.Generic.List<丕丟丕丌丒丞世与丅>();
        var val_75 = 0;
        val_75 = val_75 + 1;
        goto label_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._wrap.ResetCells();
        label_200:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  PGCompany.BattlePass.BattlePassMainUI.下丐丌丅丗丂丐三七)) == true)
        {
            goto label_23;
        }
        
        val_83 = 1152921560098792192;
        val_84 = 0;
        goto label_24;
        label_38:
        val_77 = this.丝且与丝丒丟万丁专.丄丌专丈丗丆丆丈丗.Item[0];
        val_85 = val_77;
        if(val_8.丒上丄万世且丙且上 != null)
        {
                if(val_8.丒上丄万世且丙且上.Item != null)
        {
                if((System.String.op_Equality(a:  val_8 + 40.Item.Id, b:  PGCompany.BattlePass.BattlePassMainUI.下丐丌丅丗丂丐三七)) == true)
        {
            goto label_36;
        }
        
        }
        
        }
        
        val_85 = val_77;
        if(val_8.且业丞七丂世丑丞丒 != null)
        {
                if(val_8.且业丞七丂世丑丞丒.Item != null)
        {
                if((System.String.op_Equality(a:  val_8 + 16.Item.Id, b:  PGCompany.BattlePass.BattlePassMainUI.下丐丌丅丗丂丐三七)) == true)
        {
            goto label_36;
        }
        
        }
        
        }
        
        val_84 = 1;
        label_24:
        if(val_84 < this.丝且与丝丒丟万丁专.丄丌专丈丗丆丆丈丗.Count)
        {
            goto label_38;
        }
        
        PGCompany.BattlePass.BattlePassMainUI.下丐丌丅丗丂丐三七 = 0;
        label_23:
        if(this.丝丈丕东丞且不万不.东东丒不下丆世业不() == false)
        {
            goto label_47;
        }
        
        val_86 = null;
        val_86 = null;
        val_88 = BattlePassMainUI.<>c.<>9__50_4;
        if(val_88 == null)
        {
                System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_20 = null;
            val_88 = val_20;
            val_20 = new System.Func<PGCompany.BattlePass.BPReward, System.Int32>(object:  BattlePassMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassMainUI.<>c::丙丒丂七丁丕丅丛丆(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
            BattlePassMainUI.<>c.<>9__50_4 = val_88;
        }
        
        val_89 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.OrderBy<PGCompany.BattlePass.BPReward, System.Int32>(source:  this.丝丈丕东丞且不万不.丑万丘丈业丁丟丏七(), keySelector:  val_20));
        if(val_89 == null)
        {
            goto label_47;
        }
        
        val_77 = this.丝且与丝丒丟万丁专.且七丕三丞上三丗丛(丗七丟丈三不丕一三:  val_89);
        if(val_77 != null)
        {
            goto label_61;
        }
        
        label_47:
        if(this.丝且与丝丒丟万丁专.不一丘丘业丛且上世 == null)
        {
            goto label_50;
        }
        
        val_77 = this.丝且与丝丒丟万丁专.且七丕三丞上三丗丛(丗七丟丈三不丕一三:  this.丝且与丝丒丟万丁专.不一丘丘业丛且上世);
        if(val_77 == null)
        {
            goto label_50;
        }
        
        val_89 = this.丝且与丝丒丟万丁专.不一丘丘业丛且上世;
        goto label_61;
        label_2:
        val_78 = 0;
        return (bool)val_78;
        label_50:
        val_90 = this.丝丈丕东丞且不万不.业丈丅丂且丁与丄丂();
        val_83 = 1152921560103467376;
        val_85 = 1152921560103469424;
        goto label_55;
        label_59:
        if(val_90.丌丌丌上丁丁丒专丟() != false)
        {
                if(val_90.业丗丐丗丕专丟丝丘() == true)
        {
            goto label_57;
        }
        
        }
        
        val_90 = (BattlePassMainUI.且丘东丙不三丈丗丁)[1152921560103772304].且与且上业丂一不七 + 1;
        label_55:
        .且与且上业丂一不七 = val_90;
        val_91 = (BattlePassMainUI.且丘东丙不三丈丗丁)[1152921560103772304].丟丕丁与丝丝丂下丕;
        if(val_91 == null)
        {
                System.Func<丕丟丕丌丒丞世与丅, System.Boolean> val_29 = null;
            val_91 = val_29;
            val_29 = new System.Func<丕丟丕丌丒丞世与丅, System.Boolean>(object:  new BattlePassMainUI.且丘东丙不三丈丗丁(), method:  System.Boolean BattlePassMainUI.且丘东丙不三丈丗丁::丌丄丂丏下丐丟万丟(PGCompany.BattlePass.BattlePassMainUI.丕丟丕丌丒丞世与丅 丁丂专业丁丅丅丈丙));
            .丟丕丁与丝丝丂下丕 = val_91;
        }
        
        val_77 = System.Linq.Enumerable.FirstOrDefault<丕丟丕丌丒丞世与丅>(source:  this.丝且与丝丒丟万丁专.丄丌专丈丗丆丆丈丗, predicate:  val_29);
        if(val_77 != null)
        {
            goto label_59;
        }
        
        val_89 = 0;
        goto label_60;
        label_36:
        val_89 = mem[val_8 + 40];
        val_89 = val_8 + 40;
        PGCompany.BattlePass.BattlePassMainUI.下丐丌丅丗丂丐三七 = 0;
        goto label_61;
        label_18:
        System.Collections.Generic.IEnumerator<T> val_32 = System.Linq.Enumerable.GroupBy<PGCompany.BattlePass.BPReward, System.Int32>(source:  this.丝丈丕东丞且不万不.业下丈丕丙丁东世丙(上丌丆丁丟上下专丁:  new System.Nullable<PlayerPaymentState>() {HasValue = false}, 丈丘丝一丗下丈丐不:  new System.Nullable<System.Int32>() {HasValue = false}, 不丝丟与丟丈一三与:  false), keySelector:  val_4).GetEnumerator();
        val_85 = 1152921560103486832;
        label_122:
        var val_76 = 0;
        val_76 = val_76 + 1;
        if(val_32.MoveNext() == false)
        {
            goto label_67;
        }
        
        var val_77 = 0;
        val_77 = val_77 + 1;
        T val_36 = val_32.Current;
        val_94 = null;
        val_94 = null;
        val_96 = BattlePassMainUI.<>c.<>9__50_1;
        if(val_96 == null)
        {
                val_96 = null;
            val_96 = new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  BattlePassMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassMainUI.<>c::丑丂业丒与丏上丄三(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
            BattlePassMainUI.<>c.<>9__50_1 = val_96;
        }
        
        System.Collections.Generic.List<TSource> val_39 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  val_36, predicate:  null));
        val_97 = null;
        val_97 = null;
        val_99 = BattlePassMainUI.<>c.<>9__50_2;
        if(val_99 == null)
        {
                val_99 = null;
            val_99 = new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  BattlePassMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassMainUI.<>c::丒丒业下丅丏世上丄(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
            BattlePassMainUI.<>c.<>9__50_2 = val_99;
        }
        
        System.Collections.Generic.List<TSource> val_42 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  val_36, predicate:  null));
        label_87:
        if(val_42.Count <= val_39.Count)
        {
            goto label_85;
        }
        
        val_39.Insert(index:  0, item:  0);
        goto label_87;
        label_91:
        val_42.Insert(index:  0, item:  0);
        label_85:
        if(val_39.Count > val_42.Count)
        {
            goto label_91;
        }
        
        val_6.Clear();
        if(val_42 != null)
        {
            goto label_116;
        }
        
        label_117:
        label_116:
        if(0 >= val_42.Count)
        {
            goto label_94;
        }
        
        PGCompany.BattlePass.BPReward val_48 = val_39.Item[0];
        PGCompany.BattlePass.BPReward val_49 = val_42.Item[0];
        if(0 == 0)
        {
                if(val_42.Count >= 2)
        {
            goto label_99;
        }
        
        }
        
        var val_52 = (val_42.Count == 1) ? 1 : 0;
        label_119:
        BattlePassMainUI.丕丟丕丌丒丞世与丅 val_53 = new BattlePassMainUI.丕丟丕丌丒丞世与丅();
        var val_80 = val_36;
        if((val_36 + 286) == 0)
        {
            goto label_105;
        }
        
        var val_78 = val_36 + 176;
        var val_79 = 0;
        val_78 = val_78 + 8;
        label_104:
        if(((val_36 + 176 + 8) + -8) == null)
        {
            goto label_103;
        }
        
        val_79 = val_79 + 1;
        val_78 = val_78 + 16;
        if(val_79 < (val_36 + 286))
        {
            goto label_104;
        }
        
        goto label_105;
        label_103:
        val_80 = val_80 + (((val_36 + 176 + 8)) << 4);
        val_100 = val_80 + 296;
        label_105:
        TKey val_54 = val_36.Key;
        val_101 = val_53;
        if(val_101 != 0)
        {
                mem[1152921560103833800] = val_54;
            mem[1152921560103833792] = val_49;
            mem[1152921560103833816] = val_48;
            val_102 = val_52;
        }
        else
        {
                mem[24] = val_54;
            mem[40] = val_48;
            val_102 = val_52;
            mem[16] = val_49;
            val_101 = val_53;
        }
        
        mem[1152921560103833808] = val_102;
        var val_83 = val_36;
        if((val_36 + 286) == 0)
        {
            goto label_112;
        }
        
        var val_81 = val_36 + 176;
        var val_82 = 0;
        val_81 = val_81 + 8;
        label_111:
        if(((val_36 + 176 + 8) + -8) == null)
        {
            goto label_110;
        }
        
        val_82 = val_82 + 1;
        val_81 = val_81 + 16;
        if(val_82 < (val_36 + 286))
        {
            goto label_111;
        }
        
        goto label_112;
        label_110:
        val_83 = val_83 + (((val_36 + 176 + 8)) << 4);
        val_103 = val_83 + 296;
        label_112:
        val_104 = val_53;
        if(val_104 == 0)
        {
                val_104 = val_53;
        }
        
        mem[1152921560103833804] = (val_36.Key == this.丝丈丕东丞且不万不.业丈丅丂且丁与丄丂()) ? 1 : 0;
        if(val_6 == 0)
        {
                val_104 = val_53;
        }
        
        val_6.Add(item:  val_53);
        if(val_42 != null)
        {
            goto label_116;
        }
        
        goto label_117;
        label_99:
        int val_58 = val_42.Count;
        goto label_119;
        label_94:
        this.丝且与丝丒丟万丁专.丄丌专丈丗丆丆丈丗.AddRange(collection:  val_6);
        goto label_122;
        label_57:
        val_89 = 0;
        label_61:
        val_91 = 1152921505676279808;
        if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() != false)
        {
                if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() >= 2)
        {
            goto label_128;
        }
        
        }
        
        if(val_89 != 0)
        {
            goto label_129;
        }
        
        if(val_90 == 0)
        {
            goto label_130;
        }
        
        if(val_90.业丗丐丗丕专丟丝丘() == false)
        {
            goto label_131;
        }
        
        label_137:
        val_105 = val_90 + 16;
        goto label_132;
        label_128:
        if(val_89 != 0)
        {
            goto label_133;
        }
        
        if(val_90 == 0)
        {
            goto label_134;
        }
        
        if(val_90.业丗丐丗丕专丟丝丘() == false)
        {
            goto label_135;
        }
        
        label_143:
        val_106 = val_90 + 16;
        goto label_136;
        label_130:
        if(0.业丗丐丗丕专丟丝丘() == true)
        {
            goto label_137;
        }
        
        label_131:
        val_105 = val_90 + 40;
        label_132:
        val_89 = mem[(val_26 + 40)];
        val_89 = val_105;
        label_129:
        val_77 = this.丝且与丝丒丟万丁专.丄丌专丈丗丆丆丈丗.IndexOf(item:  val_90);
        val_91 = this.丝且与丝丒丟万丁专.丄丌专丈丗丆丆丈丗.Count;
        val_107 = UnityEngine.Mathf.Clamp(value:  val_77 - 2, min:  0, max:  val_91 - 1);
        goto label_142;
        label_134:
        if(0.业丗丐丗丕专丟丝丘() == true)
        {
            goto label_143;
        }
        
        label_135:
        val_106 = val_90 + 40;
        label_136:
        val_89 = mem[(val_26 + 40)];
        val_89 = val_106;
        label_133:
        val_107 = 0;
        label_142:
        this.丝且与丝丒丟万丁专.万丗丞丂丒世丁丟丟(一丆丈东万丙丞丕下:  0, 与丑丑丑丂丛一丝一:  false, 丅丐业与丛世丐丐丞:  val_89);
        label_60:
        this.丝且与丝丒丟万丁专.不一丘丘业丛且上世 = val_89;
        this.丝且与丝丒丟万丁专.丑与丗一丘下丆丐丅 = this.丝丈丕东丞且不万不.业丈丅丂且丁与丄丂();
        goto label_145;
        label_67:
        val_91 = 0;
        val_108 = 0;
        if(val_32 == null)
        {
            
        }
        else
        {
                var val_84 = 0;
            val_84 = val_84 + 1;
            val_32.Dispose();
        }
        
        val_77 = this.丝丈丕东丞且不万不;
        if(this.丝且与丝丒丟万丁专.丑与丗一丘下丆丐丅 != val_77.业丈丅丂且丁与丄丂())
        {
            goto label_194;
        }
        
        label_145:
        this.丝且与丝丒丟万丁专._wrap.UpdateVisibleCells();
        val_78 = 0;
        this.丝且与丝丒丟万丁专.丒丂丏且上丌下丙丙 = false;
        this.丝且与丝丒丟万丁专.丗丙七世且三丅丟丝 = 0;
        return (bool)val_78;
        label_194:
        this.丝且与丝丒丟万丁专._wrap.ExtendCellsCount = 10;
        this.丝且与丝丒丟万丁专._wrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 PGCompany.BattlePass.BattlePassMainUI::上丏世丛上丟不丄与()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.BattlePass.BattlePassMainUI::与专且丌丕丞丈丑世(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丗世世丝丄丌且上下)));
        this.丝且与丝丒丟万丁专._scroll.Restrict();
        this.丝且与丝丒丟万丁专._scroll.ResetPosition();
        if(this.丝且与丝丒丟万丁专.丒丂丏且上丌下丙丙 == false)
        {
            goto label_200;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_78;
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
