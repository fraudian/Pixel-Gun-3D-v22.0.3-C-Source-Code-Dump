using UnityEngine;
internal class 与丑丛万不东专丅丙
{
    // Fields
    private static System.Collections.Generic.List<Rilisoft.OfferItem> 一不上丑丒下丟东下;
    private static int 丅丁世不丑下丛丟丂;
    
    // Methods
    internal static Rilisoft.业丙丘丆东丈丕丂丄 丗三丅七一世与一丞(string 丞一丁业丄一一业且)
    {
        string val_10;
        System.Object[] val_11;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_12;
        var val_13;
        var val_14;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_16;
        val_10 = 丞一丁业丄一一业且;
        与丑丛万不东专丅丙.丞上丕丈丒丘丆三丈 val_1 = null;
        val_11 = val_1;
        val_1 = new 与丑丛万不东专丅丙.丞上丕丈丒丘丆三丈();
        if(val_11 != null)
        {
                .丞一丁业丄一一业且 = val_10;
        }
        else
        {
                val_12 = 16;
            mem[16] = val_10;
            val_10 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) != false)
        {
                val_11 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "GetO_fferF_orItem itemId is null or empty", args:  val_11);
            val_13 = 0;
            return (Rilisoft.业丙丘丆东丈丕丂丄)System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40), predicate:  null), predicate:  null);
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = 与丑丛万不东专丅丙.<>c.<>9__0_0;
        if(val_16 == null)
        {
                val_16 = null;
            val_16 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  与丑丛万不东专丅丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丑丛万不东专丅丙.<>c::丆专丙下万丟丁丆七(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            与丑丛万不东专丅丙.<>c.<>9__0_0 = val_16;
        }
        
        val_12 = null;
        val_12 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  val_1, method:  System.Boolean 与丑丛万不东专丅丙.丞上丕丈丒丘丆三丈::世与丝万丟丗专丒丆(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
        return (Rilisoft.业丙丘丆东丈丕丂丄)System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40), predicate:  null), predicate:  null);
    }
    internal static string 丝丏专丁丄与丌丗丂(string 丞一丁业丄一一业且, Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 世七七丟丑丁丂与丞, bool 丑丗丕丈丒不丙专丐)
    {
        System.Object[] val_6;
        int val_7;
        val_6 = 世七七丟丑丁丂与丞;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞一丁业丄一一业且)) != false)
        {
                val_6 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "Get_TimeR_emain_sString itemId is null or empty", args:  val_6);
        }
        else
        {
                if(FriendsController.丝丗专上三不丄丑丑() > 0)
        {
                System.TimeSpan val_4 = 与丑丛万不东专丅丙.三丟丂下丙丄丟丐业(丞一丁业丄一一业且:  丞一丁业丄一一业且, 世七七丟丑丁丂与丞:  val_6);
            val_6 = val_4._ticks;
            string val_5 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_6}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            return (string)val_7;
        }
        
        }
        
        val_7 = System.String.alignConst;
        return (string)val_7;
    }
    internal static System.TimeSpan 三丟丂下丙丄丟丐业(string 丞一丁业丄一一业且, Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 世七七丟丑丁丂与丞)
    {
        string val_25;
        string val_26;
        System.Object[] val_27;
        var val_28;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_30;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_34;
        var val_35;
        var val_36;
        var val_37;
        val_25 = 丞一丁业丄一一业且;
        与丑丛万不东专丅丙.丛与丒丞丁丛上丄丆 val_1 = new 与丑丛万不东专丅丙.丛与丒丞丁丛上丄丆();
        if(val_1 != null)
        {
                .丞一丁业丄一一业且 = val_25;
        }
        else
        {
                mem[16] = val_25;
            val_25 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_25)) == false)
        {
            goto label_5;
        }
        
        val_25 = System.Array.Empty<System.Object>();
        val_26 = "Get_TimeR_emain_s itemId is null or empty";
        val_27 = val_25;
        goto label_8;
        label_5:
        if(FriendsController.丝丗专上三不丄丑丑() <= 0)
        {
            goto label_85;
        }
        
        val_28 = null;
        val_28 = null;
        val_30 = 与丑丛万不东专丅丙.<>c.<>9__2_0;
        if(val_30 == null)
        {
                val_30 = null;
            val_30 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  与丑丛万不东专丅丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丑丛万不东专丅丙.<>c::丁世丘万上丂且丕丄(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            与丑丛万不东专丅丙.<>c.<>9__2_0 = val_30;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        val_25 = System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().东东丛一丄丅丌丗且(世七七丟丑丁丂与丞:  世七七丟丑丁丂与丞), predicate:  null).GetEnumerator();
        label_40:
        var val_29 = 0;
        val_29 = val_29 + 1;
        if(val_25.MoveNext() == false)
        {
            goto label_30;
        }
        
        var val_30 = 0;
        val_30 = val_30 + 1;
        T val_14 = val_25.Current;
        if(val_14 == 0)
        {
            goto label_40;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_15 = val_14.丏与丅专三丙与丘丒();
        if(val_15 == null)
        {
            goto label_40;
        }
        
        val_34 = (与丑丛万不东专丅丙.丛与丒丞丁丛上丄丆)[1152921537931477728].丂丌丑一丏丌丌世丆;
        if(val_34 == null)
        {
                val_34 = null;
            val_34 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 与丑丛万不东专丅丙.丛与丒丞丁丛上丄丆::丄丌丙万万丛丏上丙(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            .丂丌丑一丏丌丌世丆 = val_34;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_15, predicate:  null)) == false)
        {
            goto label_40;
        }
        
        if(世七七丟丑丁丂与丞 != 60)
        {
            goto label_41;
        }
        
        System.Nullable<System.TimeSpan> val_18 = val_14.丙世丑丅丒丑业与不();
        if(((-1035159920) & 1) == 0)
        {
            goto label_42;
        }
        
        System.Nullable<System.TimeSpan> val_19 = val_14.丙世丑丅丒丑业与不();
        goto label_53;
        label_30:
        val_35 = 0;
        val_36 = 0;
        val_37 = 0;
        label_53:
        if(val_25 != null)
        {
            goto label_44;
        }
        
        goto label_74;
        label_41:
        System.TimeSpan val_23 = System.TimeSpan.FromSeconds(value:  (double)val_14.丘三丙丑一东世丛东() - FriendsController.丝丗专上三不丄丑丑());
        goto label_53;
        label_42:
        System.TimeSpan val_24 = System.TimeSpan.FromSeconds(value:  0);
        goto label_53;
        label_44:
        var val_31 = 0;
        val_31 = val_31 + 1;
        val_25.Dispose();
        label_74:
        if( == 1)
        {
            goto label_79;
        }
        
        if(316 == 358)
        {
                return (System.TimeSpan)val_37;
        }
        
        if(( == 0) || (316 != 316))
        {
            goto label_85;
        }
        
        goto label_85;
        label_79:
        if( == 0)
        {
            goto label_85;
        }
        
        goto label_85;
        label_8:
        UnityEngine.Debug.LogErrorFormat(format:  null, args:  null);
        label_85:
        System.TimeSpan val_27 = System.TimeSpan.FromSeconds(value:  0);
        val_37 = val_27._ticks;
        return (System.TimeSpan)val_37;
    }
    internal static string 丂世丗丟丞丒丂万一(string 丞一丁业丄一一业且)
    {
        string val_18;
        object val_19;
        string val_20;
        System.Object[] val_21;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_22;
        var val_23;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_25;
        int val_29;
        var val_30;
        var val_31;
        val_18 = 丞一丁业丄一一业且;
        与丑丛万不东专丅丙.上丌专丄丘丂东且丒 val_1 = new 与丑丛万不东专丅丙.上丌专丄丘丂东且丒();
        if(val_1 != null)
        {
                .丞一丁业丄一一业且 = val_18;
        }
        else
        {
                mem[16] = val_18;
            val_18 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_18)) == false)
        {
            goto label_5;
        }
        
        val_19 = System.Array.Empty<System.Object>();
        val_20 = "Get_Dis_ou_ntSt_ring itemId is null or empty";
        val_21 = val_19;
        goto label_8;
        label_5:
        val_22 = 1152921505210253312;
        val_23 = null;
        val_23 = null;
        val_25 = 与丑丛万不东专丅丙.<>c.<>9__3_0;
        if(val_25 == null)
        {
                val_25 = null;
            val_25 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  与丑丛万不东专丅丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丑丛万不东专丅丙.<>c::业丅丄丄七专东业下(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            与丑丛万不东专丅丙.<>c.<>9__3_0 = val_25;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        System.Collections.Generic.IEnumerator<T> val_9 = System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40), predicate:  null).GetEnumerator();
        label_37:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_27;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        T val_13 = val_9.Current;
        if(val_13 == 0)
        {
            goto label_37;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_14 = val_13.丏与丅专三丙与丘丒();
        if(val_14 == null)
        {
            goto label_37;
        }
        
        val_22 = (与丑丛万不东专丅丙.上丌专丄丘丂东且丒)[1152921537931756080].丂丌丑一丏丌丌世丆;
        if(val_22 == null)
        {
                val_22 = null;
            val_22 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 与丑丛万不东专丅丙.上丌专丄丘丂东且丒::专与一业丆丟丁丁丆(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            .丂丌丑一丏丌丌世丆 = val_22;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_14, predicate:  null)) == false)
        {
            goto label_37;
        }
        
        decimal val_17 = val_13.丐丁丒世丟世丘丌丅();
        val_29 = Rilisoft.业丙丘丆东丈丕丂丄.丌丕七与与万业丂丁(丐丌一丈丒一丕丐丙:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid}, 丅丟丏丐丅三不丗东:  true);
        val_30 = 0;
        val_19 = 0;
        val_31 = 234;
        goto label_40;
        label_27:
        val_30 = 0;
        val_19 = 0;
        val_29 = 0;
        val_31 = 201;
        label_40:
        if(val_9 == null)
        {
            
        }
        else
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_9.Dispose();
        }
        
        if( == 1)
        {
            goto label_62;
        }
        
        if(201 == 234)
        {
                return (string)val_29;
        }
        
        if(( == false) || (201 != 201))
        {
            goto label_68;
        }
        
        goto label_68;
        label_62:
        if( == false)
        {
            goto label_68;
        }
        
        goto label_68;
        label_8:
        UnityEngine.Debug.LogErrorFormat(format:  null, args:  null);
        label_68:
        val_29 = System.String.alignConst;
        return (string)val_29;
    }
    internal static 丈丞丕丘丕丗与上一 与丒一且丛丙丞丂专(string 丞一丁业丄一一业且)
    {
        string val_18;
        var val_19;
        string val_20;
        System.Object[] val_21;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_22;
        var val_23;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_25;
        var val_29;
        var val_30;
        var val_31;
        var val_35;
        val_18 = 丞一丁业丄一一业且;
        与丑丛万不东专丅丙.世丞丒丅一专丌丐丏 val_1 = new 与丑丛万不东专丅丙.世丞丒丅一专丌丐丏();
        if(val_1 != null)
        {
                .丞一丁业丄一一业且 = val_18;
        }
        else
        {
                val_19 = 16;
            mem[16] = val_18;
            val_18 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_18)) == false)
        {
            goto label_5;
        }
        
        val_20 = "Get_Pri_ceFor_Item itemId is null or empty";
        val_21 = System.Array.Empty<System.Object>();
        goto label_8;
        label_5:
        val_22 = 1152921505210253312;
        val_23 = null;
        val_23 = null;
        val_25 = 与丑丛万不东专丅丙.<>c.<>9__4_0;
        if(val_25 == null)
        {
                val_25 = null;
            val_25 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  与丑丛万不东专丅丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丑丛万不东专丅丙.<>c::丄丏丗三业丒七丅一(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            与丑丛万不东专丅丙.<>c.<>9__4_0 = val_25;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        System.Collections.Generic.IEnumerator<T> val_9 = System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40), predicate:  null).GetEnumerator();
        label_37:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_27;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        T val_13 = val_9.Current;
        if(val_13 == 0)
        {
            goto label_37;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_14 = val_13.丏与丅专三丙与丘丒();
        if(val_14 == null)
        {
            goto label_37;
        }
        
        val_22 = (与丑丛万不东专丅丙.世丞丒丅一专丌丐丏)[1152921537932042624].丂丌丑一丏丌丌世丆;
        if(val_22 == null)
        {
                val_22 = null;
            val_22 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 与丑丛万不东专丅丙.世丞丒丅一专丌丐丏::东且一丙丕丗丈丙丞(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            .丂丌丑一丏丌丌世丆 = val_22;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_14, predicate:  null)) == false)
        {
            goto label_37;
        }
        
        val_29 = val_13.丟丂丞不专丆万丒世();
        val_30 = 0;
        val_19 = 0;
        val_31 = 248;
        goto label_38;
        label_27:
        val_30 = 0;
        val_19 = 0;
        val_29 = 0;
        val_31 = 205;
        label_38:
        if(val_9 == null)
        {
            
        }
        else
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_9.Dispose();
        }
        
        if( == 1)
        {
            goto label_59;
        }
        
        if(205 == 248)
        {
                return (丈丞丕丘丕丗与上一)val_29;
        }
        
        if(( == false) || (205 != 205))
        {
            goto label_65;
        }
        
        goto label_65;
        label_59:
        if( == false)
        {
            goto label_65;
        }
        
        goto label_65;
        label_8:
        UnityEngine.Debug.LogErrorFormat(format:  null, args:  null);
        label_65:
        val_35 = null;
        val_35 = null;
        丈丞丕丘丕丗与上一 val_20 = null;
        val_29 = val_20;
        val_20 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  77, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        return (丈丞丕丘丕丗与上一)val_29;
    }
    internal static int 丞丁丌丗七丒丗丅业(string 丞一丁业丄一一业且)
    {
        string val_19;
        var val_20;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_21;
        var val_22;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_24;
        var val_28;
        var val_29;
        var val_30;
        val_19 = 丞一丁业丄一一业且;
        与丑丛万不东专丅丙.丞丂万丅不丒丘丟丗 val_1 = new 与丑丛万不东专丅丙.丞丂万丅不丒丘丟丗();
        if(val_1 != null)
        {
                .丞一丁业丄一一业且 = val_19;
        }
        else
        {
                val_20 = 16;
            mem[16] = val_19;
            val_19 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_19)) == false)
        {
            goto label_5;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "Get_Disc_ount_For itemId is null or empty", args:  System.Array.Empty<System.Object>());
        goto label_70;
        label_5:
        System.Collections.Generic.IEnumerable<Rilisoft.业丙丘丆东丈丕丂丄> val_5 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40);
        if((val_5 == null) || ((System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_5)) == false))
        {
            goto label_70;
        }
        
        val_21 = 1152921505210253312;
        val_22 = null;
        val_22 = null;
        val_24 = 与丑丛万不东专丅丙.<>c.<>9__5_0;
        if(val_24 == null)
        {
                val_24 = null;
            val_24 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  与丑丛万不东专丅丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丑丛万不东专丅丙.<>c::丑丛上丗七专丕上三(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            与丑丛万不东专丅丙.<>c.<>9__5_0 = val_24;
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        System.Collections.Generic.IEnumerator<T> val_10 = System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_5, predicate:  null).GetEnumerator();
        label_39:
        var val_23 = 0;
        val_23 = val_23 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_29;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        T val_14 = val_10.Current;
        if(val_14 == 0)
        {
            goto label_39;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_15 = val_14.丏与丅专三丙与丘丒();
        if(val_15 == null)
        {
            goto label_39;
        }
        
        val_21 = (与丑丛万不东专丅丙.丞丂万丅不丒丘丟丗)[1152921537932325072].丂丌丑一丏丌丌世丆;
        if(val_21 == null)
        {
                val_21 = null;
            val_21 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean 与丑丛万不东专丅丙.丞丂万丅不丒丘丟丗::丁丑下丈丑与丏下丂(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            .丂丌丑一丏丌丌世丆 = val_21;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_15, predicate:  null)) == false)
        {
            goto label_39;
        }
        
        decimal val_18 = val_14.丐丁丒世丟世丘丌丅();
        val_28 = System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_18.flags, hi = val_18.hi, lo = val_18.lo, mid = val_18.mid});
        val_29 = 0;
        val_20 = 0;
        val_30 = 249;
        goto label_42;
        label_29:
        val_29 = 0;
        val_20 = 0;
        val_28 = 0;
        val_30 = 220;
        label_42:
        if(val_10 == null)
        {
            
        }
        else
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_10.Dispose();
        }
        
        if( == 1)
        {
            goto label_65;
        }
        
        if(220 == 249)
        {
                return (int)val_28;
        }
        
        val_28 = 0;
        if( == false)
        {
                return (int)val_28;
        }
        
        if(220 != 220)
        {
            goto label_68;
        }
        
        return (int)val_28;
        label_65:
        if( == false)
        {
            goto label_70;
        }
        
        label_68:
        label_70:
        val_28 = 0;
        return (int)val_28;
    }
    internal static bool 丕三丌万丞世丟七丑(string 丞一丁业丄一一业且, Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 世七七丟丑丁丂与丞)
    {
        object val_15;
        var val_21;
        OfferModule val_22;
        var val_24;
        var val_26;
        var val_27;
        var val_28;
        var val_31;
        val_22 = 世七七丟丑丁丂与丞;
        if((FriendsController.丝丗专上三不丄丑丑() < 1) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞一丁业丄一一业且)) == true))
        {
            goto label_71;
        }
        
        val_21 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
        val_22 = val_21.丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  val_22);
        if(val_22 == null)
        {
            goto label_71;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_22 = val_22.GetEnumerator();
        val_21 = 0;
        val_24 = 0;
        goto label_39;
        label_45:
        var val_25 = 0;
        val_25 = val_25 + 1;
        T val_8 = val_22.Current;
        if(((val_8 == 0) || (val_8.世一丒专丛丏世丁丙() == true)) || (FriendsController.丝丗专上三不丄丑丑() >= val_8.丘三丙丑一东世丛东()))
        {
            goto label_39;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_12 = val_8.丏与丅专三丙与丘丒();
        if(val_12 == null)
        {
            goto label_39;
        }
        
        List.Enumerator<T> val_13 = val_12.GetEnumerator();
        label_29:
        if(((-1034081488) & 1) == 0)
        {
            goto label_27;
        }
        
        string val_16 = val_15.丐丏七丌丕丗业且上();
        if((val_16 == null) || ((System.String.op_Equality(a:  val_16.Id, b:  丞一丁业丄一一业且)) == false))
        {
            goto label_29;
        }
        
        val_26 = 0;
        val_27 = 207;
        val_24 = 1;
        goto label_30;
        label_27:
        val_26 = 0;
        val_27 = 158;
        label_30:
        val_26 = val_26 + 1;
        mem2[0] = 158;
        val_28 = val_21;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_27 = val_26;
        if(val_27 == 1)
        {
            goto label_35;
        }
        
        if((1152921537932503776 + ((val_26 + 1)) << 2) == 158)
        {
            goto label_36;
        }
        
        if((1152921537932503776 + ((val_26 + 1)) << 2) == 207)
        {
            goto label_48;
        }
        
        label_35:
        val_21 = 0;
        if( == 0)
        {
            goto label_39;
        }
        
        val_21 = 0;
        goto label_39;
        label_36:
        var val_26 = 0;
        val_26 = val_26 ^ (val_27 >> 31);
        val_27 = val_27 + val_26;
        val_21 = ;
        label_39:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_22.MoveNext() == true)
        {
            goto label_45;
        }
        
        var val_29 = val_27;
        val_29 = val_29 + 1;
        mem2[0] = 178;
        label_48:
        val_31 = 0;
        if(val_22 == null)
        {
            
        }
        else
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            val_22.Dispose();
        }
        
        if(val_29 != 1)
        {
                if((1152921537932503776 + ((((val_26 + 1) + (0 ^ ((int)(val_26 + 1)) >> 31)) + 1)) << 2) == 207)
        {
                return (bool)val_24 & 1;
        }
        
            val_24 = 0;
            if( == 0)
        {
                return (bool)val_24 & 1;
        }
        
            if((1152921537932503776 + ((((val_26 + 1) + (0 ^ ((int)(val_26 + 1)) >> 31)) + 1)) << 2) != 178)
        {
            goto label_71;
        }
        
            return (bool)val_24 & 1;
        }
        
        label_71:
        val_24 = 0;
        return (bool)val_24 & 1;
    }
    internal static bool 丁业丏丘丐世东一上(string 丞一丁业丄一一业且)
    {
        var val_24;
        var val_25;
        var val_29;
        var val_30;
        var val_31;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
                return false;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞一丁业丄一一业且)) == true)
        {
                return false;
        }
        
        val_24 = null;
        val_24 = null;
        if(UnityEngine.Time.frameCount == 与丑丛万不东专丅丙.丅丁世不丑下丛丟丂)
        {
            goto label_67;
        }
        
        val_25 = null;
        val_25 = null;
        与丑丛万不东专丅丙.丅丁世不丑下丛丟丂 = UnityEngine.Time.frameCount;
        与丑丛万不东专丅丙.一不上丑丒下丟东下.Clear();
        System.Collections.Generic.IEnumerable<Rilisoft.业丙丘丆东丈丕丂丄> val_6 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  60);
        if(val_6 == null)
        {
            goto label_67;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        System.Collections.Generic.IEnumerator<T> val_8 = val_6.GetEnumerator();
        label_42:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_8.MoveNext() == false)
        {
            goto label_26;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        T val_12 = val_8.Current;
        if(((val_12 == 0) || (val_12.世一丒专丛丏世丁丙() == true)) || (FriendsController.丝丗专上三不丄丑丑() >= val_12.丘三丙丑一东世丛东()))
        {
            goto label_42;
        }
        
        System.Nullable<AdaptiveModuleType> val_16 = val_12.下丐丝万丞丙丁丂丑();
        var val_18 = (val_16.HasValue.丙东专丂世丈丏丁丂() == 30) ? 1 : 0;
        val_18 = val_18 & 1152921537932689992;
        if((val_18 & 1) == 0)
        {
            goto label_42;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_19 = val_12.丏与丅专三丙与丘丒();
        if(val_19 == null)
        {
            goto label_42;
        }
        
        val_29 = null;
        val_29 = null;
        与丑丛万不东专丅丙.一不上丑丒下丟东下.AddRange(collection:  val_19);
        goto label_42;
        label_26:
        val_30 = 0;
        val_31 = 0;
        if(val_8 == null)
        {
            
        }
        else
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            val_8.Dispose();
        }
        
        if( == 1)
        {
            goto label_62;
        }
        
        if(( == false) || (186 != 186))
        {
            goto label_67;
        }
        
        goto label_67;
        label_62:
        label_67:
        val_33 = 0;
        goto label_78;
        label_91:
        val_34 = null;
        val_34 = null;
        if(与丑丛万不东专丅丙.一不上丑丒下丟东下.Item[0] != null)
        {
                val_35 = null;
            val_35 = null;
            if((System.String.op_Equality(a:  与丑丛万不东专丅丙.一不上丑丒下丟东下.Item[0].Id, b:  丞一丁业丄一一业且)) == true)
        {
                return false;
        }
        
        }
        
        val_33 = 1;
        label_78:
        val_36 = null;
        val_36 = null;
        if(val_33 < 与丑丛万不东专丅丙.一不上丑丒下丟东下.Count)
        {
            goto label_91;
        }
        
        return false;
    }
    internal static bool 上东世丏七东丌丕不(string 丞一丁业丄一一业且)
    {
        string val_20;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_24;
        var val_25;
        var val_26;
        var val_27;
        val_20 = 丞一丁业丄一一业且;
        .丞一丁业丄一一业且 = val_20;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_67;
        }
        
        val_20 = (与丑丛万不东专丅丙.下丌丛三下专丘丐丕)[1152921537932925312].丞一丁业丄一一业且;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_20)) == true)
        {
            goto label_67;
        }
        
        val_20 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  60);
        if(val_20 == null)
        {
            goto label_67;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_20 = val_20.GetEnumerator();
        label_36:
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(val_20.MoveNext() == false)
        {
            goto label_21;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        T val_11 = val_20.Current;
        if(((val_11 == 0) || (val_11.世一丒专丛丏世丁丙() == true)) || (FriendsController.丝丗专上三不丄丑丑() >= val_11.丘三丙丑一东世丛东()))
        {
            goto label_36;
        }
        
        System.Nullable<AdaptiveModuleType> val_15 = val_11.下丐丝万丞丙丁丂丑();
        var val_17 = (val_15.HasValue.丙东专丂世丈丏丁丂() == 30) ? 1 : 0;
        val_17 = val_17 & 1152921537932877112;
        if((val_17 & 1) == 0)
        {
            goto label_36;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_18 = val_11.丏与丅专三丙与丘丒();
        if(val_18 == null)
        {
            goto label_36;
        }
        
        val_24 = (与丑丛万不东专丅丙.下丌丛三下专丘丐丕)[1152921537932925312].上丌丘丑一且丆且丏;
        if(val_24 == null)
        {
                val_24 = null;
            val_24 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  new 与丑丛万不东专丅丙.下丌丛三下专丘丐丕(), method:  System.Boolean 与丑丛万不东专丅丙.下丌丛三下专丘丐丕::丁丝一丌丅丐丈丈丛(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            .上丌丘丑一且丆且丏 = val_24;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_18, predicate:  null)) == false)
        {
            goto label_36;
        }
        
        val_25 = 0;
        val_26 = 0;
        val_27 = 1;
        if(val_20 != null)
        {
            goto label_39;
        }
        
        goto label_56;
        label_21:
        val_25 = 0;
        val_26 = 0;
        val_27 = 0;
        if(val_20 != null)
        {
            goto label_39;
        }
        
        goto label_56;
        label_39:
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_20.Dispose();
        label_56:
        if( != 1)
        {
                if(214 == 243)
        {
                return (bool)val_27;
        }
        
            val_27 = 0;
            if( == false)
        {
                return (bool)val_27;
        }
        
            if(214 != 214)
        {
            goto label_67;
        }
        
            return (bool)val_27;
        }
        
        label_67:
        val_27 = 0;
        return (bool)val_27;
    }
    internal static System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 下七万丏丂下世丄丑(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 世七七丟丑丁丂与丞)
    {
        var val_7;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_9;
        System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> val_10;
        System.Collections.Generic.IEnumerable<Rilisoft.业丙丘丆东丈丕丂丄> val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  世七七丟丑丁丂与丞);
        if(val_2 != null)
        {
                val_7 = null;
            val_7 = null;
            val_9 = 与丑丛万不东专丅丙.<>c.<>9__11_0;
            if(val_9 == null)
        {
                val_9 = null;
            val_9 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  与丑丛万不东专丅丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丑丛万不东专丅丙.<>c::丆下丏专丒三丒东丄(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            与丑丛万不东专丅丙.<>c.<>9__11_0 = val_9;
        }
        
            val_10 = System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_2, predicate:  null));
            return val_10;
        }
        
        val_10 = null;
        val_10 = new System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>();
        return val_10;
    }
    public 与丑丛万不东专丅丙()
    {
    
    }
    private static 与丑丛万不东专丅丙()
    {
        与丑丛万不东专丅丙.一不上丑丒下丟东下 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        与丑丛万不东专丅丙.丅丁世不丑下丛丟丂 = 0;
    }

}
