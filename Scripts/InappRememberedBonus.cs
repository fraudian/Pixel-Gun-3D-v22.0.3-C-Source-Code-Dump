using UnityEngine;
[Serializable]
public class InappRememberedBonus
{
    // Fields
    public string Action;
    public int Multiplier;
    public string ActionStartTime;
    public int ArmorUpgrade;
    public string ArmorId;
    public int BattlePassCurrency;
    public string OfferId;
    public Rilisoft.业丙丘丆东丈丕丂丄.TierContextType OfferContextType;
    public Rilisoft.业丙丘丆东丈丕丂丄.OfferModule OfferModule;
    public Rilisoft.业丙丘丆东丈丕丂丄.AdaptiveModuleType OfferSubModule;
    public int ClanChestId;
    public int ClanCurrency;
    public int ClanSeason;
    public int Coins;
    public int Count;
    public string CurrencyLeprechaun;
    public int DaysLeprechaun;
    public int DetailsCount;
    public string DetailsItemId;
    public System.Collections.Generic.List<InappRememberedBonus.EventCurrency> EventCurrencies;
    public int FortItemDetails;
    public string FortItemDetailsTag;
    public bool FromBattlePass;
    public int GachaFreeSpins;
    public System.Collections.Generic.List<string> GadgetIds;
    public int Gems;
    public string GroupActionUniqueKey;
    public int GroupIndex;
    public string InappId;
    public bool IsEventCurrencyBonus;
    public bool IsVipBonus;
    public bool IsPetCardsDirect;
    public System.Collections.Generic.List<string> LobbyItemsIds;
    public int PerDayLeprechaun;
    public string PetId;
    public System.Collections.Generic.List<string> PetsIds;
    public int Quantity;
    public int RoyaleDetails;
    public string RoyaleDetailsTag;
    public System.Collections.Generic.List<string> RoyaleIds;
    public int SubGroupIndex;
    public int VipSeconds;
    public int WeaponDetails;
    public string WeaponDetailsWeaponTag;
    public string WeaponId;
    public System.Collections.Generic.List<string> WeaponsIds;
    public string WeaponUpgrade;
    public string WeaponLevelUpgrade;
    public string WeaponQualityUpgrade;
    public System.Collections.Generic.List<string> WearIds;
    public System.Collections.Generic.List<string> OfferItems;
    public System.Collections.Generic.List<string> OfferItemsInfo;
    public bool IsCraftCurrency;
    public bool IsModuleChest;
    public int Character;
    public string Promotion;
    public string PromotionId;
    public System.Collections.Generic.List<string> ItemParams;
    public System.Collections.Generic.List<string> ItemsParamsForAnalytics;
    public string Gifts;
    public int Real;
    public bool IsClanSilver;
    public long ServerTime;
    public bool IsClanGift;
    public bool IsFriendGift;
    public int AddCurrencyCause;
    public string BonusKey;
    public int ObtainWeaponCause;
    public int ObtainSourceType;
    public string ObtainSourceId;
    private PGCompany.东丑丆丗丏丐丟下丄 _storePromotion;
    
    // Properties
    internal PGCompany.东丑丆丗丏丐丟下丄 StorePromotion { get; }
    
    // Methods
    public override string ToString()
    {
        return (string)System.String.Format(format:  "InappId {0}, Action {1}, Multiplier {2} ", arg0:  this.InappId, arg1:  this.Action, arg2:  this.Multiplier);
    }
    internal PGCompany.东丑丆丗丏丐丟下丄 get_StorePromotion()
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_4 = this._storePromotion;
        if(val_4 != null)
        {
                return val_4;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.Promotion)) == true)
        {
                return val_4;
        }
        
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        this._storePromotion = val_4;
        return val_4;
    }
    internal static System.Collections.Generic.List<Rilisoft.OfferItem> 丆丅东世专一丞丏且(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        int val_6;
        int val_97;
        var val_98;
        var val_99;
        string val_100;
        int val_101;
        var val_102;
        var val_103;
        System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_105;
        string val_106;
        var val_107;
        System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_109;
        var val_110;
        var val_112;
        int val_113;
        var val_114;
        var val_115;
        var val_116;
        var val_117;
        var val_118;
        int val_120;
        var val_122;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        if(丂丈丗丄不丅丅丙丒 == null)
        {
                return val_1;
        }
        
        val_97 = 丂丈丗丄不丅丅丙丒.Coins;
        if(val_97 >= 1)
        {
                val_98 = null;
            val_98 = null;
            val_97 = 丂丈丗丄不丅丅丙丒.Coins;
            val_99 = 1152921505475907584;
            val_100 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  242, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  val_97));
        }
        
        val_101 = 丂丈丗丄不丅丅丙丒.Gems;
        if(val_101 >= 1)
        {
                val_102 = null;
            val_102 = null;
            val_101 = 丂丈丗丄不丅丅丙丒.Gems;
            val_99 = 1152921505475907584;
            val_100 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            Rilisoft.OfferItem val_3 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  232, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  val_101);
            val_1.Add(item:  val_3);
        }
        
        if(丂丈丗丄不丅丅丙丒.EventCurrencies == null)
        {
            goto label_66;
        }
        
        List.Enumerator<T> val_4 = 丂丈丗丄不丅丅丙丒.EventCurrencies.GetEnumerator();
        label_45:
        if(((-936681136) & 1) == 0)
        {
            goto label_11;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) == false)
        {
            goto label_15;
        }
        
        val_103 = null;
        val_103 = null;
        val_105 = InappRememberedBonus.<>c.<>9__75_0;
        if(val_105 == null)
        {
                val_105 = null;
            val_105 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  InappRememberedBonus.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InappRememberedBonus.<>c::丑七丑丆丂丐且世丅(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
            InappRememberedBonus.<>c.<>9__75_0 = val_105;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_12 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  null);
        if(val_12 == null)
        {
            goto label_24;
        }
        
        val_106 = val_12.业上丙丞丐丄丆丅七();
        goto label_25;
        label_15:
        val_106 = 0;
        goto label_38;
        label_24:
        val_106 = 0;
        label_25:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_106)) != false)
        {
                val_107 = null;
            val_107 = null;
            val_109 = InappRememberedBonus.<>c.<>9__75_1;
            if(val_109 == null)
        {
                val_109 = null;
            val_109 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  InappRememberedBonus.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InappRememberedBonus.<>c::东不丅丝丒业丏丝丄(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
            InappRememberedBonus.<>c.<>9__75_1 = val_109;
        }
        
            Rilisoft.丛且世丐丆上七业丁 val_18 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丟丛上丅七丂七丛下(), predicate:  null);
            if(val_18 != null)
        {
                val_106 = val_18.业上丙丞丐丄丆丅七();
        }
        
        }
        
        label_38:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_106)) == false)
        {
            goto label_41;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  26, 丞一丁业丄一一业且:  val_106, 丂丕丂丏专丂丄丕且:  val_7.m_stringLength);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_45;
        label_41:
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  26, 丞一丁业丄一一业且:  val_106, 丂丕丂丏专丂丄丕且:  val_7.m_stringLength);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_45;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_23 = (354 == 354) ? -1 : 0;
        goto label_46;
        label_66:
        val_110 = 0;
        label_46:
        if(丂丈丗丄不丅丅丙丒.VipSeconds >= 1)
        {
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  36, 丞一丁业丄一一业且:  "vip", 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.VipSeconds));
        }
        
        if(丂丈丗丄不丅丅丙丒.BattlePassCurrency >= 1)
        {
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  86, 丞一丁业丄一一业且:  "BattlePassCurrency", 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.BattlePassCurrency));
        }
        
        if(丂丈丗丄不丅丅丙丒.ClanCurrency >= 1)
        {
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  156, 丞一丁业丄一一业且:  "ClanCurrency", 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.ClanCurrency));
        }
        
        if(丂丈丗丄不丅丅丙丒.Character >= 1)
        {
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  186, 丞一丁业丄一一业且:  "Character", 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.Character));
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.PetId)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.Quantity;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  80, 丞一丁业丄一一业且:  丂丈丗丄不丅丅丙丒.PetId, 丂丕丂丏专丂丄丕且:  val_100));
        }
        
        if(丂丈丗丄不丅丅丙丒.PetsIds == null)
        {
            goto label_79;
        }
        
        List.Enumerator<T> val_30 = 丂丈丗丄不丅丅丙丒.PetsIds.GetEnumerator();
        val_100 = 1152921519126358176;
        val_112 = 1152921505475907584;
        label_82:
        if(((-936681168) & 1) == 0)
        {
            goto label_80;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  80, 丞一丁业丄一一业且:  val_6.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_82;
        label_80:
        val_99 = -936681344;
        val_110 = 1;
        val_113 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_110 == 1) || (609 != 609))
        {
            goto label_88;
        }
        
        var val_96 = 0;
        val_96 = val_96 ^ 0;
        val_110 = val_110 + val_96;
        goto label_90;
        label_88:
        if( == 0)
        {
            goto label_90;
        }
        
        label_79:
        val_113 = 0;
        label_90:
        val_114 = val_110;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponId)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.WeaponId;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  10, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  1));
        }
        
        if(丂丈丗丄不丅丅丙丒.WeaponsIds == null)
        {
            goto label_95;
        }
        
        List.Enumerator<T> val_35 = 丂丈丗丄不丅丅丙丒.WeaponsIds.GetEnumerator();
        val_112 = 1152921519126359200;
        label_98:
        if(((-936681168) & 1) == 0)
        {
            goto label_96;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  10, 丞一丁业丄一一业且:  val_6.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_98;
        label_95:
        val_115 = 1152921505284374528;
        goto label_107;
        label_96:
        val_99 = -936681344;
        val_114 = 2;
        val_115 = 1152921505284374528;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_114 != 1) && (715 == 715))
        {
                var val_97 = 0;
            val_97 = val_97 ^ 0;
            val_114 = val_114 + val_97;
        }
        else
        {
                if( != 0)
        {
                val_113 = 0;
        }
        
        }
        
        label_107:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.ArmorId)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.ArmorId;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  20, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  1));
        }
        
        if((丂丈丗丄不丅丅丙丒.GadgetIds == null) || (丂丈丗丄不丅丅丙丒.GadgetIds.Count < 1))
        {
            goto label_125;
        }
        
        List.Enumerator<T> val_41 = 丂丈丗丄不丅丅丙丒.GadgetIds.GetEnumerator();
        val_112 = 1152921519126359200;
        label_117:
        if(((-936681168) & 1) == 0)
        {
            goto label_115;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  70, 丞一丁业丄一一业且:  val_6.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_117;
        label_115:
        val_99 = -936681344;
        val_114 = val_114 + 1;
        mem2[0] = 835;
        val_115 = 1152921505284374528;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_114 != 1) && ((-936681344 + ((val_114 + 1)) << 2) == 835))
        {
                var val_98 = 0;
            val_98 = val_98 ^ (val_114 >> 31);
            val_114 = val_114 + val_98;
        }
        else
        {
                if( != 0)
        {
                val_113 = 0;
        }
        
        }
        
        label_125:
        if((丂丈丗丄不丅丅丙丒.DaysLeprechaun < 1) || (丂丈丗丄不丅丅丙丒.PerDayLeprechaun < 1))
        {
            goto label_133;
        }
        
        val_100 = 1152921505171275776;
        val_116 = null;
        val_116 = null;
        if((System.String.op_Equality(a:  丂丈丗丄不丅丅丙丒.CurrencyLeprechaun, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == true)
        {
            goto label_130;
        }
        
        val_117 = null;
        val_117 = null;
        if((System.String.op_Equality(a:  丂丈丗丄不丅丅丙丒.CurrencyLeprechaun, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_133;
        }
        
        label_130:
        val_112 = 1152921504622075904;
        val_6 = 丂丈丗丄不丅丅丙丒.DaysLeprechaun;
        val_100 = System.String.Format(format:  "{0}|{1}|{2}", arg0:  val_6, arg1:  丂丈丗丄不丅丅丙丒.CurrencyLeprechaun, arg2:  丂丈丗丄不丅丅丙丒.PerDayLeprechaun);
        val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  1020, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  1));
        label_133:
        if((丂丈丗丄不丅丅丙丒.WearIds == null) || ((System.Linq.Enumerable.Any<System.String>(source:  丂丈丗丄不丅丅丙丒.WearIds)) == false))
        {
            goto label_159;
        }
        
        List.Enumerator<T> val_49 = 丂丈丗丄不丅丅丙丒.WearIds.GetEnumerator();
        val_112 = 106014032;
        label_149:
        if(((-936681168) & 1) == 0)
        {
            goto label_138;
        }
        
        string val_50 = val_6.丐丏七丌丕丗业且上();
        int val_51 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_50);
        if((val_51 & 2147483648) != 0)
        {
            goto label_149;
        }
        
        if((val_51 - 6) > 6)
        {
            goto label_146;
        }
        
        var val_99 = val_112 + ((val_51 - 6)) << 2;
        val_99 = val_99 + val_112;
        goto (val_112 + ((val_51 - 6)) << 2 + val_112);
        label_146:
        if(((-936681176) & 1) == 0)
        {
            goto label_149;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  0, 丞一丁业丄一一业且:  val_50, 丂丕丂丏专丂丄丕且:  1);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_149;
        label_138:
        val_114 = val_114 + 1;
        mem2[0] = 1193;
        val_115 = 1152921505284374528;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && ((-936681344 + ((val_114 + 1)) << 2) == 1193))
        {
                var val_100 = 0;
            val_100 = val_100 ^ ( >> 31);
            val_114 =  + val_100;
        }
        else
        {
                if( != 0)
        {
                val_113 = 0;
        }
        
        }
        
        label_159:
        if((丂丈丗丄不丅丅丙丒.LobbyItemsIds == null) || ((System.Linq.Enumerable.Any<System.String>(source:  丂丈丗丄不丅丅丙丒.LobbyItemsIds)) == false))
        {
            goto label_173;
        }
        
        List.Enumerator<T> val_55 = 丂丈丗丄不丅丅丙丒.LobbyItemsIds.GetEnumerator();
        val_112 = 1152921519126359200;
        label_165:
        if(((-936681168) & 1) == 0)
        {
            goto label_163;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  85, 丞一丁业丄一一业且:  val_6.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_165;
        label_163:
        val_114 =  + 1;
        mem2[0] = 1279;
        val_115 = 1152921505284374528;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_114 != 1) && ((-936681344 + (((val_114 + 1) + 1)) << 2) == 1279))
        {
                var val_101 = 0;
            val_101 = val_101 ^ (val_114 >> 31);
            val_114 = val_114 + val_101;
        }
        else
        {
                if( != 0)
        {
                val_113 = 0;
        }
        
        }
        
        label_173:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponUpgrade)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.WeaponUpgrade;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  6, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.Quantity));
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponLevelUpgrade)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.WeaponLevelUpgrade;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  30, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.Quantity));
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponQualityUpgrade)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.WeaponQualityUpgrade;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  60, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.Quantity));
        }
        
        if(丂丈丗丄不丅丅丙丒.GachaFreeSpins >= 1)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            Rilisoft.OfferItem val_65 = null;
            val_100 = val_65;
            val_65 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  16, 丞一丁业丄一一业且:  1040.ToString(), 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.GachaFreeSpins);
            val_1.Add(item:  val_65);
        }
        
        if(丂丈丗丄不丅丅丙丒.DetailsCount >= 1)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.DetailsItemId)) != false)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.DetailsItemId;
            val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  46, 丞一丁业丄一一业且:  val_100, 丂丕丂丏专丂丄丕且:  丂丈丗丄不丅丅丙丒.DetailsCount));
        }
        
        }
        
        if((丂丈丗丄不丅丅丙丒.RoyaleIds == null) || ((System.Linq.Enumerable.Any<System.String>(source:  丂丈丗丄不丅丅丙丒.RoyaleIds)) == false))
        {
            goto label_208;
        }
        
        List.Enumerator<T> val_69 = 丂丈丗丄不丅丅丙丒.RoyaleIds.GetEnumerator();
        val_112 = 1152921519126359200;
        label_200:
        if(((-936681168) & 1) == 0)
        {
            goto label_198;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  56, 丞一丁业丄一一业且:  val_6.丐丏七丌丕丗业且上(), 丂丕丂丏专丂丄丕且:  1);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_200;
        label_198:
        val_114 = val_114 + 1;
        mem2[0] = 1592;
        val_115 = 1152921505284374528;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_114 != 1) && ((-936681344 + ((((val_114 + 1) + 1) + 1)) << 2) == 1592))
        {
                var val_102 = 0;
            val_102 = val_102 ^ (val_114 >> 31);
            val_114 = val_114 + val_102;
        }
        else
        {
                if( != 0)
        {
                val_113 = 0;
        }
        
        }
        
        label_208:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.WeaponDetails;
            if(val_100 >= 1)
        {
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  46, 丞一丁业丄一一业且:  丂丈丗丄不丅丅丙丒.WeaponDetailsWeaponTag, 丂丕丂丏专丂丄丕且:  val_100));
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.RoyaleDetails;
            if(val_100 >= 1)
        {
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  46, 丞一丁业丄一一业且:  丂丈丗丄不丅丅丙丒.RoyaleDetailsTag, 丂丕丂丏专丂丄丕且:  val_100));
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag)) != true)
        {
                val_100 = 丂丈丗丄不丅丅丙丒.FortItemDetails;
            if(val_100 >= 1)
        {
                val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  46, 丞一丁业丄一一业且:  丂丈丗丄不丅丅丙丒.FortItemDetailsTag, 丂丕丂丏专丂丄丕且:  val_100));
        }
        
        }
        
        if((丂丈丗丄不丅丅丙丒.OfferItems == null) || ((System.Linq.Enumerable.Any<System.String>(source:  丂丈丗丄不丅丅丙丒.OfferItems)) == false))
        {
            goto label_239;
        }
        
        List.Enumerator<T> val_79 = 丂丈丗丄不丅丅丙丒.OfferItems.GetEnumerator();
        val_112 = 1152921519126359200;
        val_115 = 1152921537134046960;
        label_230:
        if(((-936681168) & 1) == 0)
        {
            goto label_227;
        }
        
        string val_80 = val_6.丐丏七丌丕丗业且上();
        if(val_80 == null)
        {
            goto label_230;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  val_80);
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_230;
        label_227:
        val_114 = val_114 + 1;
        mem2[0] = 1833;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_114 != 1) && ((-936681344 + (((((val_114 + 1) + 1) + 1) + 1)) << 2) == 1833))
        {
                var val_103 = 0;
            val_103 = val_103 ^ (val_114 >> 31);
            val_114 = val_114 + val_103;
        }
        else
        {
                if( != 0)
        {
                val_113 = 0;
        }
        
        }
        
        label_239:
        if(丂丈丗丄不丅丅丙丒.ItemParams == null)
        {
            goto label_240;
        }
        
        List.Enumerator<T> val_82 = 丂丈丗丄不丅丅丙丒.ItemParams.GetEnumerator();
        val_112 = 1152921519126359200;
        val_115 = 1152921537134046960;
        label_245:
        if(((-936681168) & 1) == 0)
        {
            goto label_241;
        }
        
        string val_83 = val_6.丐丏七丌丕丗业且上();
        if(val_83 == null)
        {
            goto label_245;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  val_83);
        if(new Rilisoft.OfferItem() == null)
        {
            goto label_245;
        }
        
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_245;
        label_240:
        val_118 = 1152921505284374528;
        goto label_255;
        label_241:
        val_114 = val_114 + 1;
        mem2[0] = 1915;
        val_118 = 1152921505284374528;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_114 != 1) && ((-936681344 + ((((((val_114 + 1) + 1) + 1) + 1) + 1)) << 2) == 1915))
        {
                var val_104 = 0;
            val_104 = val_104 ^ (val_114 >> 31);
            val_114 = val_114 + val_104;
        }
        else
        {
                if( != 0)
        {
                val_113 = 0;
        }
        
        }
        
        label_255:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂丈丗丄不丅丅丙丒.Gifts)) == true)
        {
                return val_1;
        }
        
        var val_105 = 0;
        val_105 = val_105 + 1;
        List.Enumerator<T> val_88 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().GetEnumerator();
        val_100 = 1152921538029868784;
        val_115 = 1152921519126358176;
        label_285:
        if(((-936681216) & 1) == 0)
        {
            goto label_267;
        }
        
        string val_89 = val_6.丐丏七丌丕丗业且上();
        if(val_89.万丅世世丐东丙丒丙() == null)
        {
            goto label_285;
        }
        
        List.Enumerator<T> val_92 = val_89.万丅世世丐东丙丒丙().GetEnumerator();
        label_275:
        if(((-936681168) & 1) == 0)
        {
            goto label_272;
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  丂丈丗丄不丅丅丙丒.PerDayLeprechaun.丐丏七丌丕丗业且上());
        if(new Rilisoft.OfferItem() == null)
        {
            goto label_275;
        }
        
        val_1.Add(item:  new Rilisoft.OfferItem());
        goto label_275;
        label_272:
        var val_106 = val_114;
        val_106 = val_106 + 1;
        mem2[0] = 2041;
        val_120 = val_113;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_108 = val_106;
        if((val_108 == 1) || ((-936681344 + (((((((val_114 + 1) + 1) + 1) + 1) + 1) + 1)) << 2) != 2041))
        {
            goto label_282;
        }
        
        var val_107 = 0;
        val_107 = val_107 ^ (val_108 >> 31);
        val_108 = val_108 + val_107;
        goto label_285;
        label_282:
        if( == 0)
        {
            goto label_285;
        }
        
        goto label_285;
        label_267:
        val_122 = -936681344;
        val_112 = val_114 + 1;
        mem2[0] = 2066;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_112 != 1)
        {
                if( == 0)
        {
                return val_1;
        }
        
            if((val_122 + (((((((val_114 + 1) + 1) + 1) + 1) + 1) + 1)) << 2) != 2066)
        {
                return val_1;
        }
        
            return val_1;
        }
        
        if( == 0)
        {
                return val_1;
        }
        
        return val_1;
    }
    public InappRememberedBonus()
    {
        this.ClanChestId = 0;
        this.ClanSeason = 0;
    }

}
