using UnityEngine;

namespace PGCompany.MainStore
{
    internal sealed class 专一下上丏丒丆与上 : 丙丝丛丘丂世丒丄丒
    {
        // Fields
        private static readonly int 东丏丘且丝下丂丐丙;
        
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        internal override bool 丑丆丕业世一世一专 { get; }
        protected override bool 专专世与上七丄丅与 { get; }
        protected override bool 丐丟且下丘丛丕丞且 { get; }
        internal override bool 丑东丛丄丈专不丒丑 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.free";
        }
        internal override bool 丗且丒且万丄丕东丟()
        {
            return false;
        }
        protected override bool 丆丑丟丙上丄丁一丕()
        {
            return false;
        }
        protected override bool 丗丘上丌下丌丗一万()
        {
            return false;
        }
        internal override bool 下丐七不不丅丕七丑()
        {
            return true;
        }
        public 专一下上丏丒丆与上()
        {
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.专一下上丏丒丆与上::专丙东丏丑丈丞丂丑()));
            PGCompany.丅丛丙丐丈丑丌丙三.丑与丞丅丘丕丄丅不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
        }
        public override void Dispose()
        {
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.专一下上丏丒丆与上::专丙东丏丑丈丞丂丑()));
            PGCompany.丅丛丙丐丈丑丌丙三.世万丕丄三专丘丌世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
            this.Dispose();
        }
        private void 专丙东丏丑丈丞丂丑()
        {
            bool val_1 = this.丒丘业丁丆丙丆丗丞();
            if(val_1 == true)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            mem[1152921559788717056] = 1;
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.Invoke();
        }
        protected override void 专且丗丁东丆丝与丞()
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_25;
            int val_26;
            this.丟丕东丆上专七业丛();
            if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == true)
            {
                    return;
            }
            
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丐一丑与东丗丞丕下() == null)
            {
                    return;
            }
            
            if(val_3.Level > ExperienceController.丞丞丘业东丙丏七丌())
            {
                    return;
            }
            
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                    return;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_6 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
            val_25 = 1152921505369411584;
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  131)) == false)
            {
                goto label_18;
            }
            
            val_26 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  131);
            val_25 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().一丒世丂一丛万下七(下上丐丆丝丟丝丒不:  130);
            if(val_25 >= PixelTime.丝丗专上三不丄丑丑())
            {
                goto label_25;
            }
            
            val_25 = val_3.ItemParams;
            var val_16 = (val_26 >= (val_25.Count - 1)) ? 0 : (val_26 + 1);
            goto label_28;
            label_18:
            val_26 = 0;
            goto label_28;
            label_25:
            UnityEngine.Coroutine val_20 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  (float)val_25 - PixelTime.丝丗专上三不丄丑丑(), 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
            label_28:
            val_6.Add(item:  this.丝与丘丘丅业一业丘(丞世不丒下上上丝丑:  val_26, 丈丄不七三万丄丁不:  PGCompany.丁东丌世与丕东丆上.七东且东丕丟三下丘(丘丅丝东丏丄丛丛与:  val_3.ItemParams.Item[val_26])));
            this.万丌丌丛万万丆一丗(七丄丆丘丒与丐丘丅:  val_6);
            if((PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不()) == null)
            {
                
            }
        
        }
        private PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(int 丞世不丒下上上丝丑, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            string val_23;
            var val_24;
            PGCompany.StorePromotionSettings val_1 = PGCompany.MainStore.不丄且一丌与上不专.且一丕丒丌世丄丂七();
            PGCompany.StorePromotionPurchaseSettings val_2 = new PGCompany.StorePromotionPurchaseSettings();
            .Type = 16;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_3 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_3.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  7));
            val_2.Price = val_3;
            if(val_1 != null)
            {
                    val_1.PurchaseSettings = val_2;
                val_1.MainPrefabName = "MainStorePromotion/MainStorePromo_FreeRewards";
                val_1.InfoPrefabName = "";
                val_23 = "key_empty";
                val_1.TitleLocKey = val_23;
            }
            else
            {
                    mem[96] = val_2;
                mem[56] = "MainStorePromotion/MainStorePromo_FreeRewards";
                mem[64] = "";
                mem[16] = "key_empty";
                val_23 = "key_empty";
            }
            
            val_1.DescriptionLocKey = val_23;
            long val_6 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().一丒世丂一丛万下七(下上丐丆丝丟丝丒不:  130);
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_6);
            val_1.StartTime = val_7;
            mem2[0] = val_7.上万三丆专丏丒丗业;
            val_1.ObtainCurrencyCause = 85;
            .丄丑丘专丄七不专丆 = val_4.丑丁丄丟丟丁且东七;
            .丘丏丐丞丈专三且世 = 1152921505710571520;
            .下丐丐丁与丂下世七 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            bool val_14 = (PGCompany.丄与丘丑业专丞七丅)[1152921559789212032].Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "reward-currency");
            (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921559789203840].下丐丐丁与丂下世七.Add(item:  new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  丈丄不七三万丄丁不));
            int val_15 = 丈丄不七三万丄丁不.业东丅东丌上丗丑不();
            if(val_15 == 2015)
            {
                goto label_17;
            }
            
            if(val_15 != 1015)
            {
                goto label_18;
            }
            
            val_24 = "Textures/Bank/Coins_Shop_gift";
            goto label_20;
            label_17:
            val_24 = "Textures/Bank/Gems_Shop_gift";
            goto label_20;
            label_18:
            PGCompany.丌丑丕丙丅丈丈丘丄 val_17 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丑丕丙丅丈丈丘丄>(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(val_17 != null)
            {
                    if(val_17.下七丟丄丁丗下丞丕() != null)
            {
                goto label_23;
            }
            
            }
            
            label_20:
            label_23:
            val_1.TexturePath = System.String.__il2cppRuntimeField_static_fields;
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_19 = new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  14, 与不丕丆丈不丙丟丛:  val_1, 一丗与一专丙丙丅丄:  new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  PGCompany.三丛丗丆七丁丆上丌.丘丐丕世下丟丁丛三(丁丅丈丌丟世丗丗丟:  14, 丞丅上丏丂且下丅与:  丞世不丒下上上丝丑))), 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
            if(val_6 >= PixelTime.丝丗专上三不丄丑丑())
            {
                    return val_19;
            }
            
            bool val_22 = val_19.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "free");
            return val_19;
        }
        protected override void 丌丑丁上丞万丅丒丌(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 且丘丏丁丑与丙与丁)
        {
            var val_5;
            var val_23;
            PGCompany.丝丗丁丞丒且丙丑丙 val_8 = 0;
            PGCompany.DataObjects.三七业丘丑不丒且丄 val_2 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丐一丑与东丗丞丕下();
            val_23 = 且丘丏丁丑与丙与丁.七丈丒丒下下且万与();
            if(val_23 != null)
            {
                    val_23 = 0;
            }
            
            PGCompany.三丛丗丆七丁丆上丌.东丝上丒三丁丅上下(丙下不丏丅丅专丂丗:  val_23.七万丅丆且丁世丏丈(), 丁丅丈丌丟世丗丗丟: out  val_8, 丞丅上丏丂且下丅与: out  val_8);
            if((val_2 != null) && (0 == 14))
            {
                    Progress.下丁下丂七丆丙七一 val_9 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
                val_9.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  59);
                val_9.上丅丟下上丁丛丏丝(与丗且丄丝丟下东一:  val_2);
                val_5 = 0;
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  131, 丙业与丙丗丝不丈东:  0);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.下丝丆丟丕下丅上三(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  4, 丅丑三下丕万丙丁丘:  System.String.alignConst, 丐丅丒专丛丏上与业:  "free-reward", 丐丆丝业丙丈下世丁:  且丘丏丁丑与丙与丁, 丐丕丟与且丒丕丂丏:  0);
            PGCompany.StorePromotionConfig val_13 = 且丘丏丁丑与丙与丁.丘丑下丆上业丛一丄();
            long val_15 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().一丒世丂一丛万下七(下上丐丆丝丟丝丒不:  130);
            PGCompany.StorePromotionSettings val_16 = val_13.Settings;
            Rilisoft.丝丑丂丛万丐丈丘且 val_17 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_15);
            val_16.StartTime = val_17;
            mem2[0] = val_17.上万三丆专丏丒丗业;
            且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().Remove(丆万一不丌且东丐丐:  "free");
            且丘丏丁丑与丙与丁.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_13);
            UnityEngine.Coroutine val_22 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  (float)val_15 - PixelTime.丝丗专上三不丄丑丑(), 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
        }
        private void 上丅丟下上丁丛丏丝(PGCompany.DataObjects.三七业丘丑不丒且丄 与丗且丄丝丟下东一)
        {
            string val_16;
            var val_17;
            long val_18;
            var val_19;
            var val_20;
            val_16 = 与丗且丄丝丟下东一.TimeRefresh;
            if((System.DateTime.TryParse(s:  val_16, result: out  new System.DateTime())) == false)
            {
                    return;
            }
            
            System.DateTime val_3 = PixelTime.丑七不且上丗丁一世().业与丐丙东东丄丒丂();
            int val_4 = val_3.dateData.Year;
            int val_5 = val_3.dateData.Month;
            val_17 = val_3.dateData.Day;
            int val_7 = 0.Hour;
            int val_8 = 0.Minute;
            int val_9 = 0.Second;
            val_18 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime());
            if(val_18 < PixelTime.丝丗专上三不丄丑丑())
            {
                    val_17 = 1152921505663873024;
                val_19 = null;
                val_19 = null;
                if(PGCompany.MainStore.专一下上丏丒丆与上.东丏丘且丝下丂丐丙 >= 1)
            {
                    val_20 = null;
                val_20 = null;
                float val_16 = (float)PixelTime.丝丗专上三不丄丑丑() - val_18;
                val_16 = val_16 / (float)PGCompany.MainStore.专一下上丏丒丆与上.东丏丘且丝下丂丐丙;
                int val_17 = PGCompany.MainStore.专一下上丏丒丆与上.东丏丘且丝下丂丐丙;
                val_17 = val_17 * (UnityEngine.Mathf.CeilToInt(f:  val_16));
                val_18 = val_18 + (val_17 << );
            }
            
            }
            
            val_16 = val_18;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  130, 丙业与丙丗丝不丈东:  val_18);
        }
        private static 专一下上丏丒丆与上()
        {
            PGCompany.MainStore.专一下上丏丒丆与上.东丏丘且丝下丂丐丙 = 86400;
        }
    
    }

}
