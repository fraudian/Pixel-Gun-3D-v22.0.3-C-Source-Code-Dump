using UnityEngine;
private sealed class GameEventSetsViewChestContentTap.丈一业下专丌丕七专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventSetsViewChestContentTap 丝且与丝丒丟万丁专;
    public System.Action 丟丘丙丄丅万丏与丗;
    private System.Collections.Generic.List<Rilisoft.GameEventSetItemTwoSidedView> 一世且万丗丙丂万三;
    private UnityEngine.Transform 一一丕世丅丟丞丅丘;
    private int 丟丗丒丟丝丘丞丝丏;
    private Rilisoft.GameEventSetItemTwoSidedView 万不丂丏丗丒丕丌丗;
    private UnityEngine.Vector3 丘丗丁丈丟七七丘丐;
    private UnityEngine.Vector3 丗业且丌上丁丘丈丄;
    private float 丁上东丌业丁上世丟;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventSetsViewChestContentTap.丈一业下专丌丕七专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        System.Collections.Generic.List<Rilisoft.GameEventSetItemTwoSidedView> val_70;
        var val_71;
        bool val_72;
        int val_73;
        float val_74;
        var val_75;
        System.Collections.Generic.List<Rilisoft.GameEventSetItemTwoSidedView> val_76;
        var val_77;
        float val_78;
        System.Action val_79;
        float val_80;
        int val_81;
        var val_82;
        float val_83;
        if(this.丗丏丅丕丆世丁专丟 > 6)
        {
            goto label_1;
        }
        
        var val_66 = 106048480 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_66 = val_66 + 106048480;
        goto (106048480 + (this.丗丏丅丕丆世丁专丟) << 2 + 106048480);
        label_15:
        if(((-446955936) & 1) == 0)
        {
            goto label_11;
        }
        
        mem2[0] = ;
        val_10.丐丏七丌丕丗业且上().SetHiddenBackVisible(下下东且万业丞丅丒:  false, 丛丆与丆丞丏丅万丅:  true);
        goto label_15;
        label_48:
        Rilisoft.GameEventSetItemTwoSidedView val_12 = this.一世且万丗丙丂万三.SyncRoot.Item[0];
        Rilisoft.GameEventItemContainer val_13 = 40221.Item[0];
        if(val_13.AvailableToDropItems.Count != 0)
        {
                if((40221.丁且且丐不丝丐下丘().Contains(item:  val_13.Id)) == false)
        {
            goto label_31;
        }
        
        }
        
        if(val_13 != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        Rilisoft.GameEventItem val_20 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_13.AllItems);
        int val_21 = val_13.Id;
        val_75 = 1;
        goto label_35;
        label_31:
        if((1633641569 != 1) || ((1634890337.Contains(item:  val_13.Id)) == false))
        {
            goto label_39;
        }
        
        if(val_13 != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_39:
        System.Collections.Generic.List<System.Int32> val_67 = 40221.万丐丘丟丂丛丂丈万();
        val_67 = val_67.Contains(item:  val_13.Id);
        if(val_13 != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_35:
        if( < this.一世且万丗丙丂万三.SyncRoot.Count)
        {
            goto label_48;
        }
        
        val_77 = 0;
        this.丟丗丒丟丝丘丞丝丏 = 0;
        goto label_49;
        label_59:
        if(((-446955936) & 1) == 0)
        {
            goto label_52;
        }
        
        string val_29 = val_10.丐丏七丌丕丗业且上();
        if(val_29 == null)
        {
            goto label_54;
        }
        
        mem2[0] = 257;
        goto label_59;
        label_54:
        val_29.SetBack(丏专丒丙丟且丈万七:  40221);
        val_29.SetHiddenBackVisible(下下东且万业丞丅丒:  true, 丛丆与丆丞丏丅万丅:  true);
        goto label_59;
        label_1:
        val_79 = 0;
        return (bool)val_79;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_80;
        label_52:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        GameEventsHalper val_30 = GameEventsHalper.Instance;
        val_80 = val_30.animation.tapDaly_4;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_80);
        val_81 = 6;
        goto label_136;
        label_80:
        GameEventsHalper val_32 = GameEventsHalper.Instance;
        val_80 = val_32.animation.tapDaly_1;
        val_79 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_80);
        this.丗丏丅丕丆世丁专丟 = val_79;
        return (bool)val_79;
        label_107:
        this.万不丂丏丗丒丕丌丗 = this.一世且万丗丙丂万三.Item[this.丟丗丒丟丝丘丞丝丏];
        UnityEngine.Vector3 val_35 = 6713204.Item[-454904192];
        this.丘丗丁丈丟七七丘丐 = val_35;
        mem[1152921542814608980] = val_35.y;
        mem[1152921542814608984] = val_35.z;
        UnityEngine.Vector3 val_36 = this.一一丕世丅丟丞丅丘.localPosition;
        this.丗业且丌上丁丘丈丄 = val_36;
        mem[1152921542814608992] = val_36.y;
        mem[1152921542814608996] = val_36.z;
        val_72 = 0;
        goto label_89;
        label_94:
        T val_68 = this.万不丂丏丗丒丕丌丗.GetComponentsInChildren<UIWidget>(includeInactive:  true)[0];
        if(val_68 != 0)
        {
                val_82 = public System.Boolean List.Enumerator<Rilisoft.GameEventSetItemTwoSidedView>::MoveNext();
            val_71 = val_68.depth;
        }
        else
        {
                val_82 = public System.Boolean List.Enumerator<Rilisoft.GameEventSetItemTwoSidedView>::MoveNext();
            val_71 = 0.depth;
        }
        
        val_68.depth = (val_82 + val_71) + 1;
        val_72 = 1;
        label_89:
        if(val_72 < val_37.Length)
        {
            goto label_94;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_43 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  1633641569);
        }
        
        this.丁上东丌业丁上世丟 = 0f;
        val_74 = 0f;
        GameEventsHalper val_44 = GameEventsHalper.Instance;
        val_70 = val_44.animation;
        if(val_74 < 0)
        {
            goto label_103;
        }
        
        this.万不丂丏丗丒丕丌丗.transform.localPosition = new UnityEngine.Vector3() {x = this.丗业且丌上丁丘丈丄, y = V9.16B, z = V10.16B};
        this.万不丂丏丗丒丕丌丗 = 0;
        mem[1152921542814608984] = 0;
        val_73 = this.丟丗丒丟丝丘丞丝丏 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_73;
        val_70 = this.一世且万丗丙丂万三;
        if(val_73 < val_70.Count)
        {
            goto label_107;
        }
        
        GameEventsHalper val_47 = GameEventsHalper.Instance;
        val_80 = val_47.animation.tapDaly_2;
        val_81 = 3;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_80);
        goto label_136;
        label_103:
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丘丗丁丈丟七七丘丐, y = V9.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = this.丗业且丌上丁丘丈丄, y = V12.16B, z = V10.16B}, t:  this.丁上东丌业丁上世丟);
        val_83 = val_49.z;
        this.万不丂丏丗丒丕丌丗.transform.localPosition = new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_83};
        val_80 = this.丁上东丌业丁上世丟;
        float val_51 = UnityEngine.Time.deltaTime;
        this.丒上七丌业七丟与丐 = 0;
        goto label_141;
        label_136:
        this.丗丏丅丕丆世丁专丟 = val_81;
        goto label_116;
        label_141:
        val_51 = val_51 * 9f;
        val_51 = val_80 + val_51;
        this.丗丏丅丕丆世丁专丟 = 2;
        this.丁上东丌业丁上世丟 = val_51;
        label_116:
        val_79 = 1;
        return (bool)val_79;
        label_133:
        Rilisoft.GameEventSetItemTwoSidedView val_52 = ???.Item[???];
        mem2[0] = val_52;
        UnityEngine.Vector3 val_54 = val_52.transform.localPosition;
        mem2[0] = val_54.x;
        mem2[0] = val_54.y;
        mem2[0] = val_54.z;
        UnityEngine.Vector3 val_55 = ??? + 272.Item[???];
        mem2[0] = val_55.x;
        mem2[0] = val_55.y;
        mem2[0] = val_55.z;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_57 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  ??? + 208);
        }
        
        mem2[0] = 0;
        val_78 = 0f;
        GameEventsHalper val_58 = GameEventsHalper.Instance;
        if(val_78 < 0)
        {
            goto label_129;
        }
        
        ??? + 72.transform.localPosition = new UnityEngine.Vector3() {x = ??? + 80, y = ??? + 80 + 4, z = ??? + 88};
        mem2[0] = 0;
        mem2[0] = 0;
        val_77 = (??? + 64) + 1;
        val_76 = (??? + 64) - 16;
        mem2[0] = val_77;
        label_49:
        if(val_77 < val_76.Count)
        {
            goto label_133;
        }
        
        GameEventsHalper val_61 = GameEventsHalper.Instance;
        mem2[0] = new UnityEngine.WaitForSeconds(seconds:  val_61.animation.tapDaly_3);
        goto label_136;
        label_129:
        UnityEngine.Vector3 val_63 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = ??? + 88 + 4, y = ??? + 96, z = ??? + 96 + 4}, b:  new UnityEngine.Vector3() {x = ??? + 80, y = ??? + 80 + 4, z = ??? + 88}, t:  ??? + 104);
        ??? + 72.transform.localPosition = new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z};
        float val_65 = UnityEngine.Time.deltaTime;
        mem2[0] = 0;
        goto label_141;
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
