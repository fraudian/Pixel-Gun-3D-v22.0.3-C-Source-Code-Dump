using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丐不三丆丝丅丞丞与 : 丙丝丛丘丂世丒丄丒
    {
        // Fields
        private System.Threading.CancellationTokenSource 且丙丄一丗与与丂丂;
        
        // Properties
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override bool 专专世与上七丄丅与 { get; }
        protected override bool 丐丟且下丘丛丕丞且 { get; }
        internal override bool 丑丆丕业世一世一专 { get; }
        
        // Methods
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.advert";
        }
        protected override bool 丆丑丟丙上丄丁一丕()
        {
            return false;
        }
        protected override bool 丗丘上丌下丌丗一万()
        {
            return false;
        }
        internal override bool 丗且丒且万丄丕东丟()
        {
            return false;
        }
        public 丐不三丆丝丅丞丞与()
        {
            UniversalRewardBanner.丒丏丏丛丕丐丂丛丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::丅丐丐丂丁丐上与丏()));
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::丆丘万丁丝丌丗丄丌()));
            MainStoreView.一与与一世丑丒与丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::丛丟丆丑丏东世七丛()));
            MainStoreView.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::七三丂丂丒丘三万一()));
            PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::七东丙丟丝丈丄且不()));
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::专丙东丏丑丈丞丂丑()));
            FreeAwardChestWeaponController.丆丏丝丐世丗丘三丛(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丒丑丗丒七东丕丌(bool 丙业与丙丗丝不丈东)));
        }
        private void 专丙东丏丑丈丞丂丑()
        {
            if((this & 1) != 0)
            {
                    return;
            }
            
            this.丗丄丐万丏业丏丑万();
        }
        protected override void 专且丗丁东丆丝与丞()
        {
            string val_1 = 0;
            this.丟丕东丆上专七业丛();
            if((PGCompany.MainStore.丐不三丆丝丅丞丞与.丆与世世丞东下一丑(丏丞专丏业丗丝七丝: out  val_1)) != false)
            {
                    if(PGCompany.MainStore.丐不三丆丝丅丞丞与.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
                this = "[AdvertStoreSectionContentProvider.RecalculatePromotions] " + val_1;
                UnityEngine.Debug.Log(message:  this);
                return;
            }
            
            this.与丟专世丙丒且下丅(且丘丏丁丑与丙与丁:  this.丝与丘丘丅业一业丘());
        }
        private PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘()
        {
            string val_30;
            var val_31;
            TagSystem.三与下丘七丘丌丏丄 val_32;
            PGCompany.StorePromotionSettings val_1 = PGCompany.MainStore.不丄且一丌与上不专.且一丕丒丌世丄丂七();
            if(val_1 != null)
            {
                    val_1.TitleLocKey = "Key_9720";
            }
            else
            {
                    mem[16] = "Key_9720";
            }
            
            val_1.DescriptionLocKey = "key_empty";
            if((PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世().丕不一东下丅丒业丏(丙业与丙丗丝不丈东: out  0, 丏丞专丏业丗丝七丝: out  0)) != false)
            {
                    string val_7 = "OfferIcons/"("OfferIcons/") + val_3.业上丙丞丐丄丆丅七() + "_icon1_big";
            }
            else
            {
                    val_30 = "Textures/Bank/Main_Store_Advert";
            }
            
            val_1.TexturePath = val_30;
            val_1.MainPrefabName = "MainStorePromotion/MainStorePromo_WatchAds";
            val_1.InfoPrefabName = "StorePromotion/SPDefaultInfo";
            PGCompany.StorePromotionPurchaseSettings val_8 = new PGCompany.StorePromotionPurchaseSettings();
            .Type = 10;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_9 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_9.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  119));
            val_8.Price = val_9;
            val_1.PurchaseSettings = val_8;
            System.Nullable<System.DateTime> val_11 = PGCompany.MainStore.丐不三丆丝丅丞丞与.丏丒丏丟丑且丁上下();
            if(((-672399320) & 1) == 0)
            {
                goto label_9;
            }
            
            if(((-672399320) & 1) == 0)
            {
                goto label_10;
            }
            
            long val_13 = 丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_11.HasValue.丐丏七丌丕丗业且上()});
            val_31 = 1152921516341962336;
            goto label_14;
            label_9:
            val_31 = 1152921516341962336;
            goto label_14;
            label_10:
            label_14:
            Rilisoft.丝丑丂丛万丐丈丘且 val_14 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  -672399344);
            val_1.StartTime = val_14;
            mem2[0] = val_14.上万三丆专丏丒丗业;
            Rilisoft.丝丑丂丛万丐丈丘且 val_15 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
            val_1.EndTime = val_15;
            mem2[0] = val_15.上万三丆专丏丒丗业;
            val_32 = 1152921505345343488;
            val_1.Tag = new TagSystem.三与下丘七丘丌丏丄(丆万一不丌且东丐丐:  "view.header.count");
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_22 = this.不世丈丏丈上与东且();
            .丄丑丘专丄七不专丆 = val_22.Section;
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_23 = this.不世丈丏丈上与东且();
            .丘丏丐丞丈专三且世 = val_23.Season;
            System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_24 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            .下丐丐丁与丂下世七 = val_24;
            PGCompany.三东丏不丗世丅丌丄 val_25 = val_24.丑七丆三丛丙丏丆丁();
            if(val_25 == null)
            {
                    return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  12, 与不丕丆丈不丙丟丛:  val_1, 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  PGCompany.三丛丗丆七丁丆上丌.丌丏专且丁丂丟世东() + 30000)), 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
            }
            
            string[] val_26 = new string[3];
            val_26[0] = "reward-main";
            val_26[1] = "reward-currency";
            val_26[2] = "show-old-price";
            TagSystem.三与下丘七丘丌丏丄 val_27 = null;
            val_32 = val_27;
            val_27 = new TagSystem.三与下丘七丘丌丏丄(丏上业丞上丈丄丈不:  val_26);
            (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921559769111648].下丐丐丁与丂下世七.Add(item:  new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_25, 丆万一不丌且东丐丐:  val_27));
            return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  12, 与不丕丆丈不丙丟丛:  val_1, 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  PGCompany.三丛丗丆七丁丆上丌.丌丏专且丁丂丟世东() + 30000)), 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
        }
        private PGCompany.三东丏不丗世丅丌丄 丑七丆三丛丙丏丆丁()
        {
            string val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            丅丒不上七丘万丙一 val_4 = 0;
            string val_3 = 0;
            System.Collections.Generic.IReadOnlyList<PGCompany.三东丏不丗世丅丌丄> val_11 = 0;
            丕丄丘不专丘七专与 val_5 = 0;
            string val_6 = 0;
            val_27 = 0;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_27.Item[val_26];
            }
            
            val_26 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世();
            val_27 = 0;
            if((val_26.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_3, 丟丐丗万丅下丗丝万: out  val_4, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_27.Item[val_26];
            }
            
            val_26 = PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世();
            val_27 = 0;
            if(val_26.业且万丝丛东丂丄丑() == true)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_27.Item[val_26];
            }
            
            val_26 = val_3;
            val_28 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世();
            val_27 = 0;
            if((val_28.丂丗世丕七丈且丒丒(丅专与丒丈丗丒丘丌:  val_26, 丌东丙丝丂一丅三丞:  val_5, 上业丟世三与七七三: out  val_11, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)val_27.Item[val_26];
            }
            
            val_26 = val_11;
            var val_27 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_16;
            }
            
            var val_25 = mem[282584257676847];
            var val_26 = 0;
            val_25 = val_25 + 8;
            label_15:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_26 = val_26 + 1;
            val_25 = val_25 + 16;
            if(val_26 < mem[282584257676957])
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            val_27 = val_27 + (((mem[282584257676847] + 8)) << 4);
            val_29 = val_27 + 296;
            label_16:
            if(val_26.Count == 0)
            {
                goto label_17;
            }
            
            System.TimeSpan val_15 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().业丞不上丞丛三与万(丅专与丒丈丗丒丘丌:  val_3, 丟丐丗万丅下丗丝万:  val_4, 丌东丙丝丂一丅三丞:  val_5);
            val_28 = 1152921505693052928;
            System.DateTime val_16 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丝丞且丈东丅丟丏与(丅专与丒丈丗丒丘丌:  val_3);
            System.DateTime val_17 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_16.dateData}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_15._ticks});
            System.TimeSpan val_18 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_17.dateData}, d2:  new System.DateTime());
            val_30 = null;
            val_30 = null;
            val_31 = 0;
            if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_18._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == false)
            {
                goto label_29;
            }
            
            val_26 = val_11;
            var val_32 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_31;
            }
            
            var val_28 = mem[282584257676847];
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_33:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_32;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < mem[282584257676957])
            {
                goto label_33;
            }
            
            label_31:
            val_31 = 0;
            goto label_34;
            label_17:
            val_27 = 0;
            return (PGCompany.三东丏不丗世丅丌丄)val_27.Item[val_26];
            label_29:
            System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32> val_20 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.东丅丁万与丝丘丐不(丅专与丒丈丗丒丘丌:  val_3);
            val_33 = 0;
            int val_21 = System.Math.Max(val1:  0, val2:  -672176656);
            var val_33 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_41;
            }
            
            var val_30 = mem[282584257676847];
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_43:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < mem[282584257676957])
            {
                goto label_43;
            }
            
            label_41:
            val_33 = 0;
            goto label_44;
            label_32:
            val_32 = val_32 + (((mem[282584257676847] + 8)) << 4);
            val_32 = val_32 + 296;
            label_34:
            val_27 = val_26;
            return (PGCompany.三东丏不丗世丅丌丄)val_27.Item[val_26];
            label_42:
            val_33 = val_33 + (((mem[282584257676847] + 8)) << 4);
            val_34 = val_33 + 296;
            label_44:
            int val_22 = val_11.Count;
            val_26 = val_21 - ((val_21 / val_22) * val_22);
            var val_36 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_47;
            }
            
            var val_34 = mem[282584257676847];
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_49:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_48;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < mem[282584257676957])
            {
                goto label_49;
            }
            
            label_47:
            val_33 = 0;
            goto label_50;
            label_48:
            val_36 = val_36 + (((mem[282584257676847] + 8)) << 4);
            val_35 = val_36 + 296;
            label_50:
            val_27 = val_11;
            return (PGCompany.三东丏不丗世丅丌丄)val_27.Item[val_26];
        }
        internal static System.Nullable<System.DateTime> 丏丒丏丟丑且丁上下()
        {
            ulong val_25;
            ulong val_26;
            System.DateTime val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_34;
            丅丒不上七丘万丙一 val_4 = 0;
            string val_3 = 0;
            丕丄丘不专丘七专与 val_5 = 0;
            System.DateTime val_1 = PGCompany.且世万丐七丆丛丄丌.丒丌丟业丂丌丈丕丒();
            val_25 = 1152921505691721728;
            val_26 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世();
            if((val_26.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_3, 丟丐丗万丅下丗丝万: out  val_4, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  0)) == false)
            {
                    return 0;
            }
            
            val_26 = PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世();
            val_27 = 0;
            if(val_26.业且万丝丛东丂丄丑() == true)
            {
                    return 0;
            }
            
            System.TimeSpan val_11 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().业丞不上丞丛三与万(丅专与丒丈丗丒丘丌:  val_3, 丟丐丗万丅下丗丝万:  val_4, 丌东丙丝丂一丅三丞:  val_5);
            System.DateTime val_12 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丝丞且丈东丅丟丏与(丅专与丒丈丗丒丘丌:  val_3);
            val_25 = val_12.dateData;
            System.DateTime val_13 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_25}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_11._ticks});
            val_26 = val_13.dateData;
            val_28 = null;
            val_28 = null;
            val_27 = System.DateTime.MaxValue;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_26}, d2:  new System.DateTime() {dateData = val_27})) != false)
            {
                    return 0;
            }
            
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_26}, t2:  new System.DateTime() {dateData = val_1.dateData})) == false)
            {
                goto label_19;
            }
            
            label_37:
            val_29 = 1152921516288211696;
            return 0;
            label_19:
            System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32> val_16 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.东丅丁万与丝丘丐不(丅专与丒丈丗丒丘丌:  val_3);
            if(135970152 == 0)
            {
                goto label_29;
            }
            
            var val_27 = 106557164;
            if(0 == 0)
            {
                goto label_28;
            }
            
            var val_25 = 0;
            var val_26 = 107374182407;
            label_27:
            if(mem[107374182399] == null)
            {
                goto label_26;
            }
            
            val_25 = val_25 + 1;
            val_26 = val_26 + 16;
            if(val_25 < 0)
            {
                goto label_27;
            }
            
            goto label_28;
            label_26:
            val_27 = val_27 + ((mem[107374182407]) << 4);
            val_30 = val_27 + 296;
            label_28:
            if(135970152.Count == 0)
            {
                goto label_29;
            }
            
            val_31 = 0;
            int val_18 = System.Math.Max(val1:  0, val2:  -672027688);
            var val_30 = 106557164;
            if(0 == 0)
            {
                goto label_32;
            }
            
            var val_28 = 0;
            var val_29 = 107374182407;
            label_34:
            if(mem[107374182399] == null)
            {
                goto label_33;
            }
            
            val_28 = val_28 + 1;
            val_29 = val_29 + 16;
            if(val_28 < 0)
            {
                goto label_34;
            }
            
            label_32:
            val_31 = 0;
            goto label_35;
            label_29:
            string val_19 = val_16.Value.丐丏七丌丕丗业且上();
            goto label_36;
            label_33:
            val_30 = val_30 + ((mem[107374182407]) << 4);
            val_32 = val_30 + 296;
            label_35:
            if(val_18 >= 135970152.Count)
            {
                goto label_37;
            }
            
            var val_33 = 106557164;
            if(0 == 0)
            {
                goto label_38;
            }
            
            var val_31 = 0;
            var val_32 = 107374182407;
            label_40:
            if(mem[107374182399] == null)
            {
                goto label_39;
            }
            
            val_31 = val_31 + 1;
            val_32 = val_32 + 16;
            if(val_31 < 0)
            {
                goto label_40;
            }
            
            label_38:
            val_31 = 0;
            goto label_41;
            label_39:
            val_33 = val_33 + ((mem[107374182407]) << 4);
            val_34 = val_33 + 296;
            label_41:
            T val_21 = 135970152.Item[val_18];
            System.TimeSpan val_22 = System.TimeSpan.FromMinutes(value:  (double)V0.16B);
            System.DateTime val_24 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_16.Value.丐丏七丌丕丗业且上()}, t:  new System.TimeSpan() {_ticks = val_22._ticks});
            label_36:
            val_29 = 1152921516288211696;
            return 0;
        }
        private void 丅丐丐丂丁丐上与丏()
        {
            System.Collections.Generic.List<T> val_13;
            var val_14;
            PGCompany.三东丏不丗世丅丌丄 val_15;
            System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_1 = new System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>();
            val_13 = val_1;
            if(val_1.Count == 0)
            {
                    return;
            }
            
            val_13 = val_1.Item[0];
            System.Nullable<System.DateTime> val_4 = PGCompany.MainStore.丐不三丆丝丅丞丞与.丏丒丏丟丑且丁上下();
            PGCompany.StorePromotionConfig val_5 = val_13.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_6 = val_5.Settings;
            if(( & 1) != 0)
            {
                    long val_7 = 丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {});
            }
            else
            {
                    val_14 = 0;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_8 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
            val_6.StartTime = val_8;
            mem2[0] = val_8.上万三丆专丏丒丗业;
            if(val_13 != null)
            {
                    val_13.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_5);
            }
            else
            {
                    val_13.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_5);
            }
            
            val_3.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七.Clear();
            val_15 = val_3.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七.丑七丆三丛丙丏丆丁();
            if(val_15 != null)
            {
                    string[] val_10 = new string[3];
                val_10[0] = "reward-main";
                val_10[1] = "reward-currency";
                val_10[2] = "show-old-price";
                val_15 = val_3.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七;
                val_15.Add(item:  new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_15, 丆万一不丌且东丐丐:  new TagSystem.三与下丘七丘丌丏丄(丏上业丞上丈丄丈不:  val_10)));
            }
            
            val_13.丙丛东七丛一世一丕(且万丄丏专丄丛丌丗:  val_3.丗专丄丑下丄丘丁与);
            val_13.专不丗丈丒丄三三丙();
        }
        public override void Dispose()
        {
            UniversalRewardBanner.丝七丘丌丝业一丟丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::丅丐丐丂丁丐上与丏()));
            MainStoreView.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::七三丂丂丒丘三万一()));
            MainStoreView.丟丂万与万与丆丄丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::丛丟丆丑丏东世七丛()));
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::丆丘万丁丝丌丗丄丌()));
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::七东丙丟丝丈丄且不()));
            if(this.且丙丄一丗与与丂丂 != null)
            {
                    this.且丙丄一丗与与丂丂.Cancel();
            }
            
            this.且丙丄一丗与与丂丂 = 0;
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丐不三丆丝丅丞丞与::专丙东丏丑丈丞丂丑()));
            FreeAwardChestWeaponController.东丘丞丏丐丅丞专一(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丒丑丗丒七东丕丌(bool 丙业与丙丗丝不丈东)));
            this.Dispose();
        }
        private void 丛丟丆丑丏东世七丛()
        {
            string val_1 = 0;
            if(PGCompany.MainStore.丐不三丆丝丅丞丞与.世丈且业丆丑丏丐一() != false)
            {
                    string val_6 = this.丈丅且丛丛东丆丐丙(丏丞专丏业丗丝七丝: out  val_1).ToString();
                if((System.String.IsNullOrWhiteSpace(value:  val_1)) != false)
            {
                    string val_7 = "[AdvertStoreSectionContentProvider.OnBankShow] TryScheduleRefresh: "("[AdvertStoreSectionContentProvider.OnBankShow] TryScheduleRefresh: ") + val_6;
            }
            
                UnityEngine.Debug.Log(message:  "[AdvertStoreSectionContentProvider.OnBankShow] TryScheduleRefresh: "("[AdvertStoreSectionContentProvider.OnBankShow] TryScheduleRefresh: ") + val_6 + ", explanation: "(", explanation: ") + val_1);
            }
            
            this.丅丐丐丂丁丐上与丏();
        }
        private void 七三丂丂丒丘三万一()
        {
            if(this.且丙丄一丗与与丂丂 != null)
            {
                    this.且丙丄一丗与与丂丂.Cancel();
            }
            
            this.且丙丄一丗与与丂丂 = 0;
        }
        private void 丆丘万丁丝丌丗丄丌()
        {
            if(PGCompany.MainStore.丐不三丆丝丅丞丞与.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AdvertStoreSectionContentProvider.OnLevelChanged]");
            }
            
            this.丗丄丐万丏业丏丑万();
        }
        private bool 丈丅且丛丛东丆丐丙(out string 丏丞专丏业丗丝七丝)
        {
            ulong val_23;
            var val_24;
            var val_25;
            string val_26;
            丅丒不上七丘万丙一 val_4 = 0;
            string val_3 = 0;
            丕丄丘不专丘七专与 val_5 = 0;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_1;
            }
            
            val_23 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世();
            if((val_23.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_3, 丟丐丗万丅下丗丝万: out  val_4, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  string val_6 = 丏丞专丏业丗丝七丝)) == false)
            {
                goto label_7;
            }
            
            val_23 = PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世();
            if((val_23.业且万丝丛东丂丄丑(丏丞专丏业丗丝七丝: out  val_6)) == true)
            {
                goto label_7;
            }
            
            System.TimeSpan val_11 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().业丞不上丞丛三与万(丅专与丒丈丗丒丘丌:  val_3, 丟丐丗万丅下丗丝万:  val_4, 丌东丙丝丂一丅三丞:  val_5);
            System.DateTime val_12 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丝丞且丈东丅丟丏与(丅专与丒丈丗丒丘丌:  val_3);
            System.DateTime val_13 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_12.dateData}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_11._ticks});
            val_23 = val_13.dateData;
            val_24 = null;
            val_24 = null;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_23}, d2:  new System.DateTime() {dateData = System.DateTime.MaxValue})) == false)
            {
                goto label_17;
            }
            
            label_7:
            val_25 = 0;
            return (bool)val_25;
            label_1:
            label_31:
            val_25 = 0;
            丏丞专丏业丗丝七丝 = "TryGetServerUniversalTime";
            return (bool)val_25;
            label_17:
            System.TimeSpan val_15 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_23}, d2:  new System.DateTime());
            if((float)val_15._ticks.TotalSeconds <= 0f)
            {
                goto label_31;
            }
            
            if(this.且丙丄一丗与与丂丂 != null)
            {
                    this.且丙丄一丗与与丂丂.Cancel();
            }
            
            this.且丙丄一丗与与丂丂 = new System.Threading.CancellationTokenSource();
            System.Threading.CancellationToken val_19 = this.且丙丄一丗与与丂丂.Token;
            UnityEngine.Coroutine val_21 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丏丘丟上丁丌丛万万(丆丐七丅丆丗丛上与:  (float)val_15._ticks.TotalSeconds, 业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_19.m_source}));
            val_26 = 0;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_26;
            }
            
            丏丞专丏业丗丝七丝 = val_26;
            return (bool)val_25;
        }
        private System.Collections.IEnumerator 丏丘丟上丁丌丛万万(float 丆丐七丅丆丗丛上与, System.Threading.CancellationToken 业丘丝业丛丆丄一上)
        {
            丐不三丆丝丅丞丞与.业业丆万不丛上丐丒 val_1 = new 丐不三丆丝丅丞丞与.业业丆万不丛上丐丒(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
            }
            else
            {
                    mem[48] = this;
                mem[32] = 丆丐七丅丆丗丛上与;
            }
            
            .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
            return (System.Collections.IEnumerator)val_1;
        }
        private static bool 丁丂专丝丑丗丅业丑(string 业与丑上丒丐且丕丂, out string 丏丞专丏业丗丝七丝)
        {
            丏丞专丏业丗丝七丝 = 业与丑上丒丐且丕丂;
            return false;
        }
        private static bool 下丟丂丌丛丁上上丑(string 业与丑上丒丐且丕丂, out string 丏丞专丏业丗丝七丝)
        {
            丏丞专丏业丗丝七丝 = 业与丑上丒丐且丕丂;
            return true;
        }
        private static bool 丆与世世丞东下一丑(out string 丏丞专丏业丗丝七丝)
        {
            bool val_6 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  string val_5 = 丏丞专丏业丗丝七丝);
            val_6 = (~val_6) & 1;
            return (bool)val_6;
        }
        private void 七东丙丟丝丈丄且不()
        {
            if(MainStoreView.丈丐丞丐上丑且丕万() == false)
            {
                    return;
            }
            
            this.丅丐丐丂丁丐上与丏();
        }
    
    }

}
