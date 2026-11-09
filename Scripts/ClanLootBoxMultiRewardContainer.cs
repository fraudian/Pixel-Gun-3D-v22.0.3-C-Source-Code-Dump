using UnityEngine;
internal sealed class ClanLootBoxMultiRewardContainer : PGBehaviour
{
    // Fields
    private ClanLootBoxResultRewardItem Item;
    private UIScrollView Scroll;
    private UnityEngine.Transform ContentContainer;
    private UIGrid scrollGrid;
    private System.Collections.Generic.List<UnityEngine.GameObject> 且专一上丏丕三丙与;
    private bool 丝丗丐下专丏丌三与;
    private ClanLootBoxCraftWeaponWindow 世丒丟丏业丐七丄丂;
    private System.Action 不世丆丝丆丑丑与丑;
    private System.Collections.Generic.Dictionary<string, PGCompany.三东丏不丗世丅丌丄> 丟丐丈丗下专丗丕丅;
    internal bool 丑不万丁丟丏丂业与;
    
    // Methods
    internal void 丈且东丑丂且万丒丅<T>(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, T 丙与丟丞三三丈丁七, System.Action 与万一丏丙且丝丒丞)
    {
        var val_4;
        var val_5;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        val_37 = mem[__RuntimeMethodHiddenParam + 48 + 294];
        val_37 = __RuntimeMethodHiddenParam + 48 + 294;
        if((val_37 & 1) == 0)
        {
                val_37 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_37 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 48 + 184 + 8) == 0)
        {
            goto label_7;
        }
        
        label_41:
        this.且专一上丏丕三丙与.ForEach(action:  __RuntimeMethodHiddenParam + 48 + 184 + 8);
        this.且专一上丏丕三丙与.Clear();
        this.丝丗丐下专丏丌三与 = false;
        this.丟丐丈丗下专丗丕丅 = new System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄>();
        this.丑不万丁丟丏丂业与 = false;
        this.世丒丟丏业丐七丄丂 = 丙与丟丞三三丈丁七;
        this.不世丆丝丆丑丑与丑 = 与万一丏丙且丝丒丞;
        System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄> val_2 = new System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_3 = 上业丟世三与七七三.GetEnumerator();
        goto label_25;
        label_31:
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((val_2.ContainsKey(key:  val_6.业上丙丞丐丄丆丅七())) != false)
        {
                PGCompany.三东丏不丗世丅丌丄 val_10 = val_2.Item[val_6.业上丙丞丐丄丆丅七()];
            val_10.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_6.丂丁丏一丙丛业且丌() + val_10.丂丁丏一丙丛业且丌());
        }
        else
        {
                val_2.Add(key:  val_6.业上丙丞丐丄丆丅七(), value:  val_6);
        }
        
        if((this.丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_2.Item[val_6.业上丙丞丐丄丆丅七()])) != false)
        {
                if((this.丟丐丈丗下专丗丕丅.ContainsKey(key:  val_6.业上丙丞丐丄丆丅七())) != true)
        {
                this.丟丐丈丗下专丗丕丅.Add(key:  val_6.业上丙丞丐丄丆丅七(), value:  val_6);
        }
        
            this.丝丗丐下专丏丌三与 = true;
        }
        
        label_25:
        if((2096964256 & 1) != 0)
        {
            goto label_31;
        }
        
        val_38 = 0;
        val_39 = 0;
        goto label_32;
        label_7:
        val_40 = mem[__RuntimeMethodHiddenParam + 48 + 294];
        val_40 = __RuntimeMethodHiddenParam + 48 + 294;
        if((val_40 & 1) == 0)
        {
                val_40 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_40 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
        mem2[0] = new System.Action<UnityEngine.GameObject>(object:  __RuntimeMethodHiddenParam + 48 + 184, method:  __RuntimeMethodHiddenParam + 48 + 8);
        if(this.且专一上丏丕三丙与 != null)
        {
            goto label_41;
        }
        
        goto label_41;
        label_32:
        val_4 = val_5;
        val_5 = null;
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_5.Dispose();
        if(( == 1) || (293 != 293))
        {
            goto label_64;
        }
        
        val_38 = 0;
        if(与万一丏丙且丝丒丞 != null)
        {
            goto label_68;
        }
        
        goto label_66;
        label_64:
        if( != 0)
        {
                val_39 = 0;
        }
        
        if(与万一丏丙且丝丒丞 != null)
        {
            goto label_68;
        }
        
        label_66:
        label_68:
        List.Enumerator<T> val_26 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.三东丏不丗世丅丌丄, System.Int32>(source:  与万一丏丙且丝丒丞.Values, keySelector:  new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Int32>(object:  this, method:  __RuntimeMethodHiddenParam + 48 + 24))).GetEnumerator();
        label_84:
        if((2096964256 & 1) == 0)
        {
            goto label_85;
        }
        
        ClanLootBoxResultRewardItem val_28 = UnityEngine.Object.Instantiate<ClanLootBoxResultRewardItem>(original:  this.Item);
        val_28.丌丟丄业且三丛丕丄().SetParent(p:  this.ContentContainer);
        this.且专一上丏丕三丙与.Add(item:  val_28.丅与丌专丟一丝业三());
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
        val_28.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z};
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.one;
        val_28.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        val_28.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_5.丐丏七丌丕丗业且上());
        goto label_84;
        label_85:
        val_4 = val_5;
        val_5 = null;
        var val_36 = 0;
        val_36 = val_36 + 1;
        val_5.Dispose();
        if(1 != 1)
        {
                if((new List.Enumerator<T>()) == 0)
        {
                return;
        }
        
            if(455 == 455)
        {
                return;
        }
        
            return;
        }
        
        if((new List.Enumerator<T>()) != 0)
        {
                return;
        }
    
    }
    private bool 丞丒丒三丞且丏东丄(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        var val_15;
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() != 1070)
        {
            goto label_7;
        }
        
        Rilisoft.OfferItem val_3 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
        if(val_3.ItemParams == null)
        {
            goto label_7;
        }
        
        bool val_6 = 丆丐三丅丆丗东丑世.丞丒丒三丞且丏东丄(丞丅上丏丂且下丅与:  val_3.Id);
        if(val_6 == false)
        {
            goto label_7;
        }
        
        if((val_6.七丈丁丂丐丕下丄丕(丏且丕丄丁丟丆丏丁:  val_3)) == false)
        {
            goto label_14;
        }
        
        val_15 = val_3.IsExists ^ 1;
        return (bool)val_15 & 1;
        label_7:
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1300)
        {
                PGCompany.三东丏不丗世丅丌丄 val_11 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丛丈丏丅丂一不丒业(上七下丘一下三世丏:  丈丄不七三万丄丁不);
            if(val_11 != null)
        {
                PGCompany.丄丂丌丞丁丙七丆三 val_12 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
            if(val_12 != null)
        {
                return val_12.三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_11.业东丅东丌上丗丑不());
        }
        
            return val_12.三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_11.业东丅东丌上丗丑不());
        }
        
        }
        
        label_14:
        val_15 = 0;
        return (bool)val_15 & 1;
    }
    private bool 七丈丁丂丐丕下丄丕(Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁)
    {
        var val_13;
        三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛());
        if(val_3 != null)
        {
                val_13 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_3.三与丛丑且丐丈业丌());
            return (bool)((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛())) >= val_13) ? 1 : 0;
        }
        
        val_13 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛());
        return (bool)((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛())) >= val_13) ? 1 : 0;
    }
    public void U_Collect()
    {
        if((this.世丒丟丏业丐七丄丂 != 0) && (this.丝丗丐下专丏丌三与 != false))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
            this.世丒丟丏业丐七丄丂.丌万丗与七丄丕不丁(上业丟世三与七七三:  this.丟丐丈丗下专丗丕丅, 丁且丙丞丁丌丆丛丐:  this.不世丆丝丆丑丑与丑);
            return;
        }
        
        this.丑不万丁丟丏丂业与 = true;
        this.丝丗丐下专丏丌三与 = false;
        if(this.不世丆丝丆丑丑与丑 == null)
        {
                return;
        }
        
        this.不世丆丝丆丑丑与丑.Invoke();
    }
    internal void 专丈丟丛丛一专丈丞()
    {
        if(this.丝丗丐下专丏丌三与 != true)
        {
                this.丑不万丁丟丏丂业与 = true;
            if(this.不世丆丝丆丑丑与丑 != null)
        {
                this.不世丆丝丆丑丑与丑.Invoke();
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.U_Collect();
    }
    private void OnDisable()
    {
        this.丑不万丁丟丏丂业与 = false;
    }
    internal void 丄下丑与与丟丗丟丏()
    {
        this.scrollGrid.enabled = true;
        this.Scroll.enabled = true;
        this.Scroll.ResetPosition();
        this.Scroll.enabled = (this.且专一上丏丕三丙与.Count > 3) ? 1 : 0;
    }
    private int 丗与不丒丈上东专专(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        PGCompany.三东丏不丗世丅丌丄 val_22;
        var val_23;
        int val_24;
        var val_25;
        var val_26;
        var val_27;
        val_22 = 丈丄不七三万丄丁不;
        if(val_22.不业丙丒丂丞下丆丙() != 1010)
        {
                if(val_22.不业丙丒丂丞下丆丙() != 1000)
        {
                if(val_22.不业丙丒丂丞下丆丙() != 1180)
        {
            goto label_6;
        }
        
        }
        
        }
        
        val_23 = 10;
        if(val_22 != null)
        {
            goto label_27;
        }
        
        label_28:
        label_27:
        if(val_22.不业丙丒丂丞下丆丙() == 1070)
        {
                val_24 = val_22.业东丅东丌上丗丑不();
            Rilisoft.OfferItem val_6 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  val_24);
            if(val_6 != null)
        {
                var val_9 = 10 + 9;
            var val_10 = ((丆丐三丅丆丗东丑世.丞丒丒三丞且丏东丄(丞丅上丏丂且下丅与:  val_6.Id)) != true) ? (val_9) : 10;
        }
        
        }
        
        val_9 = val_10 + 8;
        if(val_22.不业丙丒丂丞下丆丙() != 1150)
        {
                if(val_22.不业丙丒丂丞下丆丙() != 1155)
        {
            goto label_15;
        }
        
        }
        
        val_25 = ((val_22.不业丙丒丂丞下丆丙() == 1300) ? (val_9) : (val_10)) + 7;
        label_15:
        if(val_22.不业丙丒丂丞下丆丙() != 1250)
        {
                return (int)val_25;
        }
        
        PGCompany.三丙业丆上丏三丈丌 val_16 = null;
        val_24 = val_16;
        val_16 = new PGCompany.三丙业丆上丏三丈丌(丈丄不七三万丄丁不:  val_22);
        if(val_24 == null)
        {
                return (int)val_25;
        }
        
        PlaceableItemSettings val_17 = val_16.丈丏专三世七丒丘丑();
        val_22 = val_17.supercategory;
        val_26 = null;
        val_26 = null;
        if((System.String.op_Equality(a:  val_22, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) != false)
        {
                val_25 = val_25 + 5;
            return (int)val_25;
        }
        
        PlaceableItemSettings val_19 = val_16.丈丏专三世七丒丘丑();
        val_27 = null;
        val_27 = null;
        var val_22 = ((System.String.op_Equality(a:  val_19.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) != true) ? (val_25 + 6) : (val_25);
        return (int)val_25;
        label_6:
        if(val_22 != null)
        {
            goto label_27;
        }
        
        goto label_28;
    }
    public ClanLootBoxMultiRewardContainer()
    {
        this.且专一上丏丕三丙与 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.丟丐丈丗下专丗丕丅 = new System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄>();
    }
    private int 丟丂丂丛丂丅丄丛丟<T>(PGCompany.三东丏不丗世丅丌丄 七丞丙丒三丕且丌丟)
    {
        if(this != null)
        {
                return this.丗与不丒丈上东专专(丈丄不七三万丄丁不:  七丞丙丒三丕且丌丟);
        }
        
        return this.丗与不丒丈上东专专(丈丄不七三万丄丁不:  七丞丙丒三丕且丌丟);
    }

}
