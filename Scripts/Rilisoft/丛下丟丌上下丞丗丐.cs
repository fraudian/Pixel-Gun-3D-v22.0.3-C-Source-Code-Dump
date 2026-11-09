using UnityEngine;

namespace Rilisoft
{
    public class 丛下丟丌上下丞丗丐
    {
        // Fields
        internal const string 三丛三丝丁七与丆万 = "o_single";
        internal const string 万世业丏与丝丒丏丈 = "o_pack";
        private static Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛下丟丌上下丞丗丐> 丝业丆丁业三丈丟东;
        private static int 专世丙上丒世丏丁三;
        private int 丑三丌一业且丈且世;
        private Rilisoft.不丅且丝丁丁与不丒<Rilisoft.丛下丟丌上下丞丗丐.Content> 丂上丞丁丑业丅不世;
        private Rilisoft.丛下丟丌上下丞丗丐.Content 丏丝一业丁丝丆丘一;
        
        // Properties
        internal static Rilisoft.丛下丟丌上下丞丗丐 丆丕丝丒不丙且丐丗 { get; }
        private int 丗三七丟丕业丌万七 { get; }
        private int 丘丟丑丟丏丕万且专 { get; }
        private System.Collections.Generic.List<Rilisoft.丛下丟丌上下丞丗丐.Content> 丘上丗丅万丗专丕且 { get; }
        
        // Methods
        private 丛下丟丌上下丞丗丐()
        {
            this.丂上丞丁丑业丅不世 = new Rilisoft.不丅且丝丁丁与不丒<Content>(丟东丟丑丕丄丂丟丙:  "ContentViewManager-lastShowContent");
        }
        internal static Rilisoft.丛下丟丌上下丞丗丐 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.丛下丟丌上下丞丗丐.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.丛下丟丌上下丞丗丐.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.丛下丟丌上下丞丗丐.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        public void 丝上丌丂七东东与丈()
        {
            null = null;
            int val_1 = Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三;
            val_1 = val_1 + 1;
            Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三 = val_1;
        }
        public bool 丛丏丈东与丂东丝丐()
        {
            var val_30;
            System.Func<TSource, System.Boolean> val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            if(BalanceController.专上七丑丙丞七一丈() == false)
            {
                goto label_69;
            }
            
            Content val_2 = this.丏万丐丕万丐不三丞();
            this.丏丝一业丁丝丆丘一 = val_2;
            if(val_2 == null)
            {
                    return (bool)val_30;
            }
            
            if((BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() == true) || (BannerWindowController.与丅与丒丅专丙丐丗().CanShowAnyBanner() == false))
            {
                goto label_69;
            }
            
            if(this.丏丝一业丁丝丆丘一.Type == 1)
            {
                    System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_9 = null;
                val_31 = val_9;
                val_9 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丛下丟丌上下丞丗丐::丂世与丌丆上丞下东(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
                Rilisoft.丛且世丐丆上七业丁 val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().与不下且且丅东丘世(), predicate:  val_9);
                if(val_10 == null)
            {
                    return (bool)val_30;
            }
            
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
                val_32 = val_11.x;
                val_33 = val_11.y;
                val_34 = val_11.z;
                if(Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世() != 0)
            {
                    Rilisoft.InAppBonusLobbyViewBase val_15 = Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世().GetTopViewForEvent(丅东专与不三丂丁丝:  val_10);
                if(val_15 != 0)
            {
                    UnityEngine.Vector3 val_18 = val_15.transform.position;
                val_32 = val_18.x;
                val_33 = val_18.y;
                val_34 = val_18.z;
            }
            
            }
            
                Rilisoft.AbstractGameEventGui.丌丒丗丕专东丐上丗 = 0;
                Rilisoft.AbstractGameEventGui.丌丒丗丕专东丐上丗.__il2cppRuntimeField_8 = 0;
                val_31 = 1152921505451360256;
                val_35 = null;
                val_35 = null;
                Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上 = val_10.<丅不丙丌丟业一业丂>k__BackingField.EventId;
                if((BannerWindowController.与丅与丒丅专丙丐丗().AddBannerToShowQueue(世丁丌万丏丟丗世三:  25)) != false)
            {
                    val_31 = this.丏丝一业丁丝丆丘一;
                val_36 = null;
                val_36 = null;
                this.丑三丌一业且丈且世 = Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三;
            }
            
                val_30 = 1;
                return (bool)val_30;
            }
            
            if(this.丏丝一业丁丝丆丘一.Type == 0)
            {
                goto label_42;
            }
            
            label_69:
            val_30 = 0;
            return (bool)val_30;
            label_42:
            if((System.String.op_Equality(a:  this.丏丝一业丁丝丆丘一.Id, b:  "o_pack")) == false)
            {
                goto label_44;
            }
            
            Rilisoft.业丙丘丆东丈丕丂丄 val_23 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丐上丙世丂丅丝不丈(丁丅丈丌丟世丗丗丟:  10);
            if(val_23 == null)
            {
                    return (bool)val_30;
            }
            
            Rilisoft.OfferPackWindow.丄丂丅一万上不七丟(不专一业下丞丝丑丗:  val_23);
            if((BannerWindowController.与丅与丒丅专丙丐丗().AddBannerToShowQueue(世丁丌万丏丟丗世三:  18)) == false)
            {
                goto label_69;
            }
            
            val_37 = null;
            val_37 = null;
            goto label_72;
            label_44:
            if((System.String.op_Equality(a:  this.丏丝一业丁丝丆丘一.Id, b:  "o_single")) == false)
            {
                goto label_69;
            }
            
            Rilisoft.BonusData val_27 = Rilisoft.丛下丟丌上下丞丗丐.丁丈不丙丝丑丘不丒();
            if(val_27 == null)
            {
                    return (bool)val_30;
            }
            
            Rilisoft.OfferPackWindow.且七丄丈丗专七丝万(丛丝丙丄七一丁丅三:  val_27);
            if((BannerWindowController.与丅与丒丅专丙丐丗().AddBannerToShowQueue(世丁丌万丏丟丗世三:  18)) == false)
            {
                goto label_69;
            }
            
            val_37 = null;
            val_37 = null;
            label_72:
            this.丑三丌一业且丈且世 = Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三;
            return (bool)val_30;
        }
        private Rilisoft.丛下丟丌上下丞丗丐.Content 丏万丐丕万丐不三丞()
        {
            var val_34;
            int val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            UnityEngine.Object val_41;
            var val_42;
            var val_43;
            if(this.丆上三东七丂上丛丞() < 1)
            {
                    return 0;
            }
            
            val_34 = null;
            val_34 = null;
            val_35 = Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三;
            if(this.丑三丌一业且丈且世 == val_35)
            {
                    return 0;
            }
            
            val_35 = Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三;
            if(val_35 < null.丆上三东七丂上丛丞())
            {
                    return 0;
            }
            
            val_36 = null;
            val_36 = null;
            int val_3 = 丆上三东七丂上丛丞();
            if(Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三 > val_3)
            {
                    if(val_3.专一下丁且丞丂丁七() < 1)
            {
                    return 0;
            }
            
                val_37 = null;
                val_37 = null;
                int val_34 = Rilisoft.丛下丟丌上下丞丗丐.专世丙上丒世丏丁三;
                int val_5 = 丆上三东七丂上丛丞();
                val_34 = val_34 - val_5;
                if(val_34 == 0)
            {
                    return 0;
            }
            
                int val_6 = val_5.专一下丁且丞丂丁七();
                int val_7 = val_34 / val_6;
                val_7 = val_34 - (val_7 * val_6);
                if(val_7 != 0)
            {
                    return 0;
            }
            
            }
            
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return 0;
            }
            
            val_38 = null;
            val_38 = null;
            if(GiftBannerWindow.丘丆且七丑丘且专丟 == true)
            {
                    return 0;
            }
            
            val_39 = null;
            val_39 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_40 = null;
                val_40 = null;
                if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.isActiveAndEnabled == true)
            {
                    return 0;
            }
            
            }
            
            val_41 = 0;
            if(Rilisoft.ClansLobbyGui.丑七不且上丗丁一世() != val_41)
            {
                    val_41 = 0;
                if(Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().gameObject.activeInHierarchy == true)
            {
                    return 0;
            }
            
            }
            
            if(this.丂上丞丁丑业丅不世 == null)
            {
                goto label_39;
            }
            
            Content val_18 = System.Linq.Enumerable.FirstOrDefault<Content>(source:  this.丂上丞丁丑业丅不世.丒丟与丅丌丙丆丌上(), predicate:  new System.Func<Content, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丛下丟丌上下丞丗丐::丞一丑丙丏且丆丏下(Rilisoft.丛下丟丌上下丞丗丐.Content 丁丂专业丁丅丅丈丙)));
            if(val_18 == null)
            {
                goto label_39;
            }
            
            val_42 = (val_18.丒丟与丅丌丙丆丌上().IndexOf(item:  val_18)) + 1;
            goto label_41;
            label_39:
            val_42 = 0;
            label_41:
            int val_22 = this.丂上丞丁丑业丅不世.丒丟与丅丌丙丆丌上().Count;
            int val_23 = val_22 - 1;
            val_43 = 0;
            int val_24 = (val_42 > val_23) ? 0 : (val_42);
            goto label_43;
            label_48:
            Content val_26 = val_22.丒丟与丅丌丙丆丌上().Item[val_24];
            bool val_27 = val_26.丝三丐丈丐不下丈丐(三丏丑不业丏不丂丈:  val_26);
            if(val_27 == true)
            {
                    return 0;
            }
            
            var val_28 = val_24 + 1;
            int val_30 = val_27.丒丟与丅丌丙丆丌上().Count;
            val_23 = val_30 - 1;
            var val_31 = (val_28 > val_23) ? 0 : (val_28);
            val_43 = 1;
            label_43:
            if(val_43 < val_30.丒丟与丅丌丙丆丌上().Count)
            {
                goto label_48;
            }
            
            return 0;
        }
        private bool 丝三丐丈丐不下丈丐(Rilisoft.丛下丟丌上下丞丗丐.Content 三丏丑不业丏不丂丈)
        {
            object val_12;
            var val_13;
            丛下丟丌上下丞丗丐.丌丟丘丏丕丅七万丕 val_1 = null;
            val_12 = val_1;
            val_1 = new 丛下丟丌上下丞丗丐.丌丟丘丏丕丅七万丕();
            if(val_12 == null)
            {
                goto label_1;
            }
            
            .三丏丑不业丏不丂丈 = 三丏丑不业丏不丂丈;
            if(三丏丑不业丏不丂丈 != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            if(三丏丑不业丏不丂丈.Type != 1)
            {
                goto label_3;
            }
            
            if((System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().与不下且且丅东丘世(), predicate:  new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  val_1, method:  System.Boolean 丛下丟丌上下丞丗丐.丌丟丘丏丕丅七万丕::丟丘丁世丐业丟丈下(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且)))) == null)
            {
                goto label_24;
            }
            
            val_13 = 1;
            return (bool)(Rilisoft.丛下丟丌上下丞丗丐.丁丈不丙丝丑丘不丒() != 0) ? 1 : 0;
            label_3:
            if(三丏丑不业丏不丂丈.Type == 0)
            {
                goto label_11;
            }
            
            label_24:
            val_13 = 0;
            return (bool)(Rilisoft.丛下丟丌上下丞丗丐.丁丈不丙丝丑丘不丒() != 0) ? 1 : 0;
            label_1:
            mem[16] = 三丏丑不业丏不丂丈;
            if(mem[16] != 0)
            {
                goto label_13;
            }
            
            goto label_14;
            label_11:
            if((System.String.op_Equality(a:  三丏丑不业丏不丂丈.Id, b:  "o_pack")) != false)
            {
                    val_12 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
                Rilisoft.业丙丘丆东丈丕丂丄 val_8 = val_12.丐上丙世丂丅丝不丈(丁丅丈丌丟世丗丗丟:  10);
                return (bool)(Rilisoft.丛下丟丌上下丞丗丐.丁丈不丙丝丑丘不丒() != 0) ? 1 : 0;
            }
            
            val_12 = .三丏丑不业丏不丂丈;
            if((System.String.op_Equality(a:  三丏丑不业丏不丂丈.Id, b:  "o_single")) == false)
            {
                goto label_24;
            }
            
            return (bool)(Rilisoft.丛下丟丌上下丞丗丐.丁丈不丙丝丑丘不丒() != 0) ? 1 : 0;
        }
        private static Rilisoft.BonusData 丁丈不丙丝丑丘不丒()
        {
            System.Collections.Generic.IEnumerable<TSource> val_10;
            var val_11;
            System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean> val_13;
            val_10 = BalanceController.下丂万丐丄丅七一东();
            if(val_10 == null)
            {
                    return (Rilisoft.BonusData)val_10;
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = 丛下丟丌上下丞丗丐.<>c.<>9__15_0;
            if(val_13 == null)
            {
                    System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean> val_2 = null;
                val_13 = val_2;
                val_2 = new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Boolean>(object:  丛下丟丌上下丞丗丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丛下丟丌上下丞丗丐.<>c::下丅且丘丂专丟丒万(System.Collections.Generic.Dictionary<string, object> 丌丗丏丏丛东专丁且));
                丛下丟丌上下丞丗丐.<>c.<>9__15_0 = val_13;
            }
            
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_10, predicate:  val_2));
            if(val_4.Count >= 1)
            {
                    Rilisoft.BonusData val_9 = null;
                val_10 = val_9;
                val_9 = new Rilisoft.BonusData();
                val_9.丅专下万丕丑丆丅丝(丛丝丙丄七一丁丅三:  val_10.Item[UnityEngine.Random.Range(min:  0, max:  val_4.Count)], 业丈丈丗丐丄三丞丈:  false);
                return (Rilisoft.BonusData)val_10;
            }
            
            val_10 = 0;
            return (Rilisoft.BonusData)val_10;
        }
        private int 丆上三东七丂上丛丞()
        {
            return BalanceController.业三与丐东丂丏三丆();
        }
        private int 专一下丁且丞丂丁七()
        {
            return BalanceController.三丑丙且丞与三丛下();
        }
        private System.Collections.Generic.List<Rilisoft.丛下丟丌上下丞丗丐.Content> 丒丟与丅丌丙丆丌上()
        {
            return BalanceController.与三世丆丝丒丒与与();
        }
        private static 丛下丟丌上下丞丗丐()
        {
            null = null;
            Rilisoft.丛下丟丌上下丞丗丐.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛下丟丌上下丞丗丐>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.丛下丟丌上下丞丗丐>(object:  丛下丟丌上下丞丗丐.<>c.<>9, method:  Rilisoft.丛下丟丌上下丞丗丐 丛下丟丌上下丞丗丐.<>c::三丂丗丏上丄丏丗丟()));
        }
        private bool 丂世与丌丆上丞下东(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且)
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)System.String.op_Equality(a:  丗丛不丁丑专专丂且.<丅不丙丌丟业一业丂>k__BackingField.Type.ToString(), b:  this.丏丝一业丁丝丆丘一.Id);
        }
        private bool 丞一丑丙丏且丆丏下(Rilisoft.丛下丟丌上下丞丗丐.Content 丁丂专业丁丅丅丈丙)
        {
            if(丁丂专业丁丅丅丈丙.Type != null)
            {
                    return false;
            }
            
            if(this.丂上丞丁丑业丅不世 != null)
            {
                    return System.String.op_Equality(a:  丁丂专业丁丅丅丈丙.Id, b:  typeof(Rilisoft.不丅且丝丁丁与不丒<T>).__il2cppRuntimeField_190);
            }
            
            return System.String.op_Equality(a:  丁丂专业丁丅丅丈丙.Id, b:  typeof(Rilisoft.不丅且丝丁丁与不丒<T>).__il2cppRuntimeField_190);
        }
    
    }

}
