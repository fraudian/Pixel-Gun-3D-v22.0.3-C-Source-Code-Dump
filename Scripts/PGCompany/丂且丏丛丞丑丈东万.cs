using UnityEngine;

namespace PGCompany
{
    internal class 丂且丏丛丞丑丈东万 : 丌与世世丆丄丞丌世
    {
        // Fields
        private InappRememberedBonus 丒丅丂与丕且丙且不;
        private string 丒丕丝万丐下丌不东;
        
        // Methods
        internal override void 东丞丐业丂丞不丕丈<T>(T 丞万丕丏东与丑下丕)
        {
            this.东丞丐业丂丞不丕丈(丛丐与丌丑专丑七丄:  X20);
        }
        protected void 东丞丐业丂丞不丕丈(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丛丐与丌丑专丑七丄)
        {
            object val_24;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_63;
            object val_64;
            var val_65;
            var val_66;
            var val_67;
            string val_69;
            丘丝丑丐丆丑七不丙 val_70;
            var val_71;
            object val_72;
            var val_73;
            var val_74;
            string val_75;
            var val_76;
            object val_77;
            var val_81;
            val_63 = 丛丐与丌丑专丑七丄;
            val_64 = this;
            val_65 = 1152921505614245888;
            if((PGCompany.万丞丘与丕丞下万丌.丈三世丆丙丄丌东丗(丈丄不七三万丄丁不:  与丂三丟业丘与丅三())) == false)
            {
                    return;
            }
            
            val_66 = 1152921505164300288;
            val_67 = null;
            val_67 = null;
            if(coinsShop.专丆专上丗万世丒七 == 0)
            {
                    return;
            }
            
            专且丝丄丙丗丈不丞.丂丝三丏丞七万七东(丈丄不七三万丄丁不:  val_63);
            if((PGCompany.万丞丘与丕丞下万丌.且丞丙下丅与下业丒(丈丄不七三万丄丁不:  val_63)) == false)
            {
                    return;
            }
            
            string val_5 = coinsShop.专丆专上丗万世丒七.丒不丟丒丁丗丒丕丑();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_5)) != false)
            {
                    string val_7 = val_5.丒不丟丒丁丗丒丕丑();
            }
            else
            {
                    string val_12 = AbstractBankView.丕东与丐丆丛丛与丅(丞丂业丅丟丙丏七丗:  val_5.与丂三丟业丘与丅三().业东丅东丌上丗丑不(), 世丈三丐丞一丒丛不:  X21.与丂三丟业丘与丅三().丂丁丏一丙丛业且丌());
            }
            
            this.丒丕丝万丐下丌不东 = val_12;
            val_69 = this.丒丕丝万丐下丌不东;
            val_70 = AbstractBankView.七丆丆世丄且丕世万(丄丒丌上丁丂不万东:  val_12);
            if(val_70 == null)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_69)) == true)
            {
                    return;
            }
            
            if(val_70.不业丙丒丂丞下丆丙() != 0)
            {
                    if(val_70.不业丙丒丂丞下丆丙() != 1)
            {
                goto label_34;
            }
            
            }
            
            if((丅且东丙业丏丛东丛.丑七不且上丗丁一世().三丐丏专万上丕不丒(丆专且丕专丗与一丏:  (val_70.不业丙丒丂丞下丆丙() == 1) ? 2015 : 1015, 世丈三丐丞一丒丛不:  X24.丂丁丏一丙丛业且丌())) < 1)
            {
                goto label_40;
            }
            
            List.Enumerator<T> val_22 = val_63.GetEnumerator();
            val_71 = 0;
            goto label_46;
            label_47:
            string val_25 = val_24.丐丏七丌丕丗业且上();
            if(val_25 != null)
            {
                    if((PGCompany.万丞丘与丕丞下万丌.丞丒丟丒且丑丏且业(丁丅丈丌丟世丗丗丟:  val_25.不业丙丒丂丞下丆丙())) != false)
            {
                    val_71 = val_25.丂丁丏一丙丛业且丌() + val_71;
            }
            
            }
            
            label_46:
            if(((-201216016) & 1) != 0)
            {
                goto label_47;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_57;
            label_34:
            val_72 = 0;
            goto label_49;
            label_40:
            StoreKitEventListener.丁东丝丄丄丑三与一(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::且且东丈丆丄不专丗(string 丘专丈与三专丈丈专)));
            StoreKitEventListener.万万丞丟东丞丂丏三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::且且东丈丆丄不专丗(string 丘专丈与三专丈丈专)));
            val_69 = 0;
            goto label_134;
            label_57:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_31 = null;
            val_69 = val_31;
            val_31 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_69 != null)
            {
                    val_31.Add(key:  "ID", value:  this.丒丕丝万丐下丌不东);
            }
            else
            {
                    val_31.Add(key:  "ID", value:  this.丒丕丝万丐下丌不东);
            }
            
            val_31.Add(key:  "action", value:  "multiplier");
            val_24 = 1152921504615686144;
            val_31.Add(key:  "Key", value:  System.String.Format(format:  "x{0}_{1}", arg0:  val_24, arg1:  this.丒丕丝万丐下丌不东));
            val_31.Add(key:  "multiplier", value:  1152921504615686144);
            val_70 = val_70;
            val_73 = null;
            if(val_70.不业丙丒丂丞下丆丙() == 1)
            {
                    val_74 = null;
                val_75 = 1152921505171281160;
            }
            else
            {
                    val_76 = null;
                val_75 = 1152921505171281152;
            }
            
            val_72 = 1152921504615686144;
            Rilisoft.丝丑丂丛万丐丈丘且 val_34 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  1152921505164300288);
            val_24 = val_34.七丄不丐丗三丝丑一;
            val_66 = 1152921505164300288;
            val_31.Add(key:  val_75, value:  val_34);
            this.丒丅丂与丕且丙且不 = 一下丛与丛丛万万丏.丑七不且上丗丁一世().三丌丑丏一丏丙一丒(丄上下丟与不丈丏丄:  val_31);
            if(val_69 != null)
            {
                goto label_134;
            }
            
            label_49:
            System.Collections.Generic.List<System.String> val_37 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_38 = GetEnumerator();
            label_78:
            if(((-201216016) & 1) == 0)
            {
                goto label_74;
            }
            
            val_37.Add(item:  PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  val_24.丐丏七丌丕丗业且上()));
            goto label_78;
            label_74:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_41 = null;
            val_69 = val_41;
            val_41 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_69 != null)
            {
                    val_41.Add(key:  "ID", value:  this.丒丕丝万丐下丌不东);
            }
            else
            {
                    val_41.Add(key:  "ID", value:  this.丒丕丝万丐下丌不东);
            }
            
            val_65 = 1152921516595677584;
            val_41.Add(key:  "Key", value:  "promotion");
            val_77 = "promotion";
            val_41.Add(key:  "action", value:  val_77);
            var val_65 = 0;
            val_65 = val_65 + 1;
            val_77 = 0;
            string val_44 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丒丕丝万丐下丌不东);
            val_41.Add(key:  "promotion", value:  val_44);
            string val_46 = PGCompany.丂丑业与上丄丂且下.丙业不丝丗丌丗世下(一丗与一专丙丙丅丄:  val_44.七丈丒丒下下且万与());
            if(val_69 != null)
            {
                    val_41.Add(key:  "promotionId", value:  val_46);
            }
            else
            {
                    val_41.Add(key:  "promotionId", value:  val_46);
            }
            
            val_41.Add(key:  "ItemsParams", value:  val_37);
            val_41.Add(key:  "ItemsParamsForAnalytics", value:  val_37);
            val_24 = PixelTime.丝丗专上三不丄丑丑();
            val_41.Add(key:  "ServerTime", value:  val_24);
            丌丟丐丞三丘三丏丈 val_48 = val_24.丂丟丄丐丂丄丒丅丘();
            val_41.Add(key:  "AddCurrencyCause", value:  val_48);
            七专丁丕世丏丁丘丛 val_49 = val_48.丂丐丌不丌万丗丟丙();
            val_41.Add(key:  "ObtainWeaponCause", value:  val_49);
            if(val_49.下丒丁丌一丐不三一() != null)
            {
                    val_24 = val_49.下丒丁丌一丐不三一().不业丙丒丂丞下丆丙();
                val_41.Add(key:  "ObtainSourceType", value:  val_24);
                val_41.Add(key:  "ObtainSourceId", value:  val_24.下丒丁丌一丐不三一().业上丙丞丐丄丆丅七());
            }
            
            val_24 = val_72;
            val_41.Add(key:  "multiplier", value:  val_24);
            if(val_69 != null)
            {
                    var val_66 = 0;
                val_66 = val_66 + 1;
                val_24 = val_41.不丆丑丌三不丗丐丈();
                val_41.Add(key:  "offer-module", value:  val_24);
                var val_67 = 0;
                val_67 = val_67 + 1;
                val_41.Add(key:  "offer-id", value:  val_41.丙三丝一丝专丌丁丛());
            }
            
            if(val_69 == null)
            {
                goto label_126;
            }
            
            string val_59 = val_41.三丕丛世丟世丈丐七();
            val_41.Add(key:  "bonus-key", value:  val_59);
            if(val_69 != null)
            {
                goto label_130;
            }
            
            label_126:
            label_130:
            if(0.与不丞丑七丘丁丂丛() != null)
            {
                    if((val_59.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "source.clan.silver")) != false)
            {
                    val_24 = true;
                val_41.Add(key:  "IsClanSilver", value:  val_24);
            }
            
            }
            
            label_134:
            val_63 = 1152921504615686144;
            PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::丁东丙丈丂东三丑下(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
            PGCompany.丌与丛丕业丈不丐世.丅丂且三丂丟丒业丕(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::丁东丙丈丂东三丑下(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
            val_81 = null;
            val_64 = coinsShop.专丆专上丗万世丒七;
            val_64.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  val_70, 丈上上丟丟丏万丐且:  val_41);
        }
        private void 丁东丙丈丂东三丑下(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
        {
            var val_15;
            System.Action<InappRememberedBonus> val_29;
            var val_30;
            DataSystem.丈且丈上不下且丝丒 val_31;
            System.Collections.Generic.List<System.String> val_33;
            Rilisoft.OfferItemType val_17 = 0;
            if(81878 != 0)
            {
                    if(81878.七丈丒丒下下且万与() != null)
            {
                    PGCompany.专丟专世丅丂丁且专 val_2 = 七丈丒丒下下且万与();
            }
            
            }
            
            System.Action<InappRememberedBonus> val_3 = null;
            val_29 = val_3;
            val_3 = new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::丁东丙丈丂东三丑下(InappRememberedBonus 丂丈丗丄不丅丅丙丒));
            PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  val_3);
            if(丂丈丗丄不丅丅丙丒 == null)
            {
                    return;
            }
            
            if(this.丒丅丂与丕且丙且不 == null)
            {
                goto label_9;
            }
            
            val_30 = 0;
            if((System.String.op_Equality(a:  this.丒丅丂与丕且丙且不.InappId, b:  丂丈丗丄不丅丅丙丒.InappId)) == false)
            {
                goto label_9;
            }
            
            PGCompany.专丟专世丅丂丁且专 val_8 = val_3.七丈丒丒下下且万与();
            val_29 = val_29;
            if(val_29 != null)
            {
                goto label_30;
            }
            
            return;
            label_9:
            val_29 = 丂丈丗丄不丅丅丙丒.Promotion;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_29)) == true)
            {
                    return;
            }
            
            bool val_9 = PGCompany.丂丑业与上丄丂且下.丂东专丙丒丏且丛丁(丞丕丒专一下丙业上:  丂丈丗丄不丅丅丙丒.PromotionId, 丗不丁丐下世上丙专: out  0, 一丗与一专丙丙丅丄: out  val_8);
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_30 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_10, typeof(public PGCompany.东丑丆丗丏丐丟下丄 DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<PGCompany.东丑丆丗丏丐丟下丄>(string 丞丕丒专一下丙业上).__il2cppRuntimeField_18), slot: 0) + 8;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_12 = null;
            val_29 = val_12;
            val_12 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_33 = 丂丈丗丄不丅丅丙丒.ItemParams;
            List.Enumerator<T> val_13 = val_33.GetEnumerator();
            label_29:
            if(((-200778336) & 1) == 0)
            {
                goto label_25;
            }
            
            string val_18 = 0;
            if((Rilisoft.不丗上万丟丏不丄下.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  val_15.丐丏七丌丕丗业且上(), 丁丅丈丌丟世丗丗丟: out  val_17, 丞丅上丏丂且下丅与: out  val_18, 丌丒丝东丌下丕丁丅: out  0)) == false)
            {
                goto label_29;
            }
            
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  val_17, 丞丅上丏丂且下丅与:  val_18);
            new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
            val_12.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            goto label_29;
            label_25:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_31 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            if(val_29 == null)
            {
                    return;
            }
            
            label_30:
            val_33 = val_8;
            if(val_33 == 0)
            {
                    return;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_30 = 0;
            if((X24.七丈丒丒下下且万与().Equals(other:  null)) == false)
            {
                    return;
            }
            
            if( != 0)
            {
                    PGCompany.StorePromotionSettings val_27 = 丘丑下丆上业丛一丄().Settings;
                PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().一丗丙丝丒丂丗三丁(丟不丄一丄丅一世丗:  val_27.ItemObtainPlace, 丛丐与丌丑专丑七丄:  val_12);
            }
            
            this.丆丌丄业丙丘丅七世(且丘丏丁丑与丙与丁:  val_33, 丛丐与丌丑专丑七丄:  val_12, 一丐丗丁丞丆丅丟丄:  0);
        }
        private void 且且东丈丆丄不专丗(string 丘专丈与三专丈丈专)
        {
            System.Action<System.String> val_1 = new System.Action<System.String>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::且且东丈丆丄不专丗(string 丘专丈与三专丈丈专));
            StoreKitEventListener.丁东丝丄丄丑三与一(丙业与丙丗丝不丈东:  val_1);
            if(this.丒丕丝万丐下丌不东 != null)
            {
                    if((System.String.op_Inequality(a:  this.丒丕丝万丐下丌不东, b:  丘专丈与三专丈丈专)) != false)
            {
                    return;
            }
            
            }
            
            PGCompany.丂丞万丒下万丒业丌 val_3 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世();
            PGCompany.StorePromotionSettings val_5 = val_1.丘丑下丆上业丛一丄().Settings;
            val_3.一丗丙丝丒丂丗三丁(丟不丄一丄丅一世丗:  val_5.ItemObtainPlace, 丛丐与丌丑专丑七丄:  X22);
            this.丆丌丄业丙丘丅七世(且丘丏丁丑与丙与丁:  val_3.七丈丒丒下下且万与(), 丛丐与丌丑专丑七丄:  val_5.ItemObtainPlace.System.IConvertible.ToBoolean(provider:  System.Boolean System.Enum::System.IConvertible.ToBoolean(System.IFormatProvider provider)), 一丐丗丁丞丆丅丟丄:  0);
        }
        public override void Dispose()
        {
            if(81877 != 0)
            {
                    if(81877.七丈丒丒下下且万与() != null)
            {
                    PGCompany.专丟专世丅丂丁且专 val_2 = 七丈丒丒下下且万与();
            }
            
            }
            
            PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::丁东丙丈丂东三丑下(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
            StoreKitEventListener.丁东丝丄丄丑三与一(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.丂且丏丛丞丑丈东万::且且东丈丆丄不专丗(string 丘专丈与三专丈丈专)));
        }
        public 丂且丏丛丞丑丈东万()
        {
        
        }
    
    }

}
