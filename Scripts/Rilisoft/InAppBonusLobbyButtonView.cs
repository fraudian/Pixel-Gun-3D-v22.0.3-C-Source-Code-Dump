using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyButtonView : InAppBonusLobbyViewBase
    {
        // Fields
        private UnityEngine.Transform _backgroundsContainer;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _battlePassObj;
        private UnityEngine.Transform _dependingObjectsContainer;
        private UILabel _headerLabel;
        private UILabel _profitLabel;
        private UnityEngine.GameObject _profitObject;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _recommendClanObj;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _recommendDuelsObj;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _recommendLobbyBundlesObj;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _accountsObj;
        private Rilisoft.InAppBonusLobbyButtonThreeIconsGrid _threeItemsContainer;
        private UILabel _timeLeftLabel;
        private UnityEngine.GameObject _timePanel;
        private Rilisoft.InAppBonusLobbyButtonTwoIconsGrid _twoItemsContainer;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _x10Obj;
        public UILabel BadgeLabel;
        public UnityEngine.GameObject BadgeObject;
        public UIBasicSprite OverlaySprite;
        private PGCompany.MiniBannerConstructablePromotionView 东上七丅东丛丒丁丗;
        private PGCompany.DoubleOfferMiniBanner 丐一三丈世丞丁丟一;
        private PGCompany.NoviceDoubleOfferMiniBanner 七丞丙丛丆世丌丝丑;
        private System.Collections.Generic.Dictionary<string, MiniBannerViewPromotion> 一丈丅丌丅丏丁下不;
        private PGCompany.ChangeLogView 丒万上丌丈且丟丑丛;
        private PGCompany.TimerUI 不丟丙丞丅丌专丄与;
        private string 丆万丐不丝上下不丙;
        private UnityEngine.GameObject 丅丒七与上东不丛丒;
        private UnityEngine.GameObject commonHolder;
        private NovicePromotionLobbyBanner npLobbyBanner;
        private PGCompany.TierBundleLobbyBanner tierBundleLobbyBanner;
        private PGCompany.MiniBannerPromotionView _manualBundleLobbyBanner;
        
        // Methods
        private string 万万丟丕上丌丐丗丒(Rilisoft.BonusData 丂丈丗丄不丅丅丙丒)
        {
            var val_13;
            if(丂丈丗丄不丅丅丙丒 != null)
            {
                    不丕丟丐丒且与丛下 val_13 = 丂丈丗丄不丅丅丙丒.Type;
                val_13 = val_13 - 1;
                if(val_13 > 24)
            {
                    return (string)val_13;
            }
            
                var val_14 = 106031328;
                val_14 = (106031328 + ((丂丈丗丄不丅丅丙丒.Type - 1)) << 2) + val_14;
            }
            else
            {
                    val_13 = "Blue";
                return (string)val_13;
            }
        
        }
        private void 下丟东丛七丘七下丈(Rilisoft.BonusData 丂丈丗丄不丅丅丙丒)
        {
            var val_9;
            UnityEngine.GameObject val_10;
            var val_11;
            val_9 = 0;
            goto label_4;
            label_17:
            UnityEngine.Transform val_4 = this._backgroundsContainer.GetChild(index:  0);
            UnityEngine.GameObject val_7 = val_4.gameObject;
            if(val_4.gameObject != (丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  this._backgroundsContainer.gameObject, 丒丘丏上丙丟丑丕丈:  this.万万丟丕上丌丐丗丒(丂丈丗丄不丅丅丙丒:  丂丈丗丄不丅丅丙丒), 丟丝七七一丁丏丏丙:  true)))
            {
                    val_10 = val_7;
                val_11 = 0;
            }
            else
            {
                    val_11 = 1;
                val_10 = val_7;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
            val_9 = 1;
            label_4:
            if(val_9 < this._backgroundsContainer.childCount)
            {
                goto label_17;
            }
        
        }
        private void 业丝丈丑丟丒七丌专(Rilisoft.InAppBonusLobbyButtonDependingObject 丛万下七世丌且丒丂)
        {
            var val_6;
            UnityEngine.GameObject val_7;
            var val_8;
            val_6 = 0;
            goto label_1;
            label_14:
            UnityEngine.Transform val_1 = this._dependingObjectsContainer.GetChild(index:  0);
            UnityEngine.GameObject val_4 = val_1.gameObject;
            if(val_1 != 丛万下七世丌且丒丂.transform)
            {
                    val_7 = val_4;
                val_8 = 0;
            }
            else
            {
                    val_8 = 1;
                val_7 = val_4;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
            val_6 = 1;
            label_1:
            if(val_6 < this._dependingObjectsContainer.childCount)
            {
                goto label_14;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._twoItemsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._threeItemsContainer, 丏业丟一东丂东丘丛:  false);
        }
        private string 丛东一丁丟丛不上丑()
        {
            object val_25;
            int val_26;
            var val_27;
            var val_29;
            val_25 = this;
            val_26 = System.String.alignConst;
            val_27 = null;
            val_27 = null;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_1.Profit, hi = val_1.Profit, lo = this.Data, mid = this.Data}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == true)
            {
                    return (string)val_26;
            }
            
            Rilisoft.BonusData val_3 = this.Data;
            if(val_3.Type != 8)
            {
                goto label_6;
            }
            
            decimal val_5 = System.Decimal.op_Multiply(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_4.Profit, hi = val_4.Profit, lo = this.Data, mid = this.Data});
            bool val_6 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal());
            val_25 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3764");
            label_38:
            string val_8 = val_5.flags.ToString(format:  "0");
            goto label_13;
            label_6:
            Rilisoft.BonusData val_9 = this.Data;
            if(val_9.Type != 20)
            {
                goto label_15;
            }
            
            val_25 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3710");
            label_13:
            val_26 = System.String.Format(format:  "{0} {1}%", arg0:  val_25, arg1:  1000);
            return (string)val_26;
            label_15:
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_12.Profit, hi = val_12.Profit, lo = this.Data, mid = this.Data}, d2:  new System.Decimal())) == false)
            {
                goto label_21;
            }
            
            val_29 = null;
            val_29 = null;
            Rilisoft.BonusData val_14 = this.Data;
            decimal val_15 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_14.Profit, hi = val_14.Profit});
            decimal val_16 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid});
            decimal val_17 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_16.flags, hi = val_16.hi, lo = val_16.lo, mid = val_16.mid}, d2:  new System.Decimal());
            decimal val_18 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_17.flags, hi = val_17.hi, lo = val_17.lo, mid = val_17.mid}, 专丂丕丗丗东世丞下:  5);
            bool val_19 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_18.flags, hi = val_18.hi, lo = val_18.lo, mid = val_18.mid}, d2:  new System.Decimal());
            string val_20 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3764");
            goto label_38;
            label_21:
            decimal val_22 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_21.Profit, hi = val_21.Profit, lo = this.Data, mid = this.Data}, d2:  new System.Decimal());
            decimal val_23 = 丞东丑专丛丆丄丝世.丑丙丐一一丐丁丕丛(万丑丄丆上上丅一业:  new System.Decimal() {flags = val_22.flags, hi = val_22.hi, lo = val_22.lo, mid = val_22.mid}, 专丂丕丗丗东世丞下:  50);
            string val_24 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3710");
            goto label_38;
        }
        private PGCompany.MiniBannerConstructablePromotionView 丝丌丌东丆专丐专丟()
        {
            PGCompany.MiniBannerConstructablePromotionView val_14;
            if(this.东上七丅东丛丒丁丗 == 0)
            {
                    PGCompany.MiniBannerConstructablePromotionView val_2 = UnityEngine.Resources.Load<PGCompany.MiniBannerConstructablePromotionView>(path:  "inapps/LobbyConstractableOfferButton");
                val_14 = 0;
                if(val_2 == 0)
            {
                    return val_14;
            }
            
                PGCompany.MiniBannerConstructablePromotionView val_4 = UnityEngine.Object.Instantiate<PGCompany.MiniBannerConstructablePromotionView>(original:  val_2);
                val_14 = 0;
                if(val_4 == 0)
            {
                    return val_14;
            }
            
                this.东上七丅东丛丒丁丗 = val_4;
                val_4.transform.SetParent(p:  this.transform);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
                this.东上七丅东丛丒丁丗.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
                this.东上七丅东丛丒丁丗.transform.rotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
                this.东上七丅东丛丒丁丗.transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            }
            
            val_14 = this.东上七丅东丛丒丁丗;
            return val_14;
        }
        private PGCompany.DoubleOfferMiniBanner 丗丅与不业丂丈丒丞()
        {
            PGCompany.DoubleOfferMiniBanner val_13;
            if(this.丐一三丈世丞丁丟一 == 0)
            {
                    PGCompany.DoubleOfferMiniBanner val_3 = UnityEngine.Object.Instantiate<PGCompany.DoubleOfferMiniBanner>(original:  UnityEngine.Resources.Load<PGCompany.DoubleOfferMiniBanner>(path:  "inapps/LobbyDoubleOfferButton"));
                val_13 = 0;
                if(val_3 == 0)
            {
                    return val_13;
            }
            
                this.丐一三丈世丞丁丟一 = val_3;
                val_3.transform.SetParent(p:  this.transform);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                this.丐一三丈世丞丁丟一.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
                this.丐一三丈世丞丁丟一.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
                this.丐一三丈世丞丁丟一.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            }
            
            val_13 = this.丐一三丈世丞丁丟一;
            return val_13;
        }
        private PGCompany.NoviceDoubleOfferMiniBanner 专与丒丅与丌丂不万()
        {
            PGCompany.NoviceDoubleOfferMiniBanner val_13;
            if(this.七丞丙丛丆世丌丝丑 == 0)
            {
                    PGCompany.NoviceDoubleOfferMiniBanner val_3 = UnityEngine.Object.Instantiate<PGCompany.NoviceDoubleOfferMiniBanner>(original:  UnityEngine.Resources.Load<PGCompany.NoviceDoubleOfferMiniBanner>(path:  "inapps/LobbyNoviceDoubleOfferButton"));
                val_13 = 0;
                if(val_3 == 0)
            {
                    return val_13;
            }
            
                this.七丞丙丛丆世丌丝丑 = val_3;
                val_3.transform.SetParent(p:  this.transform);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                this.七丞丙丛丆世丌丝丑.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
                this.七丞丙丛丆世丌丝丑.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
                this.七丞丙丛丆世丌丝丑.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            }
            
            val_13 = this.七丞丙丛丆世丌丝丑;
            return val_13;
        }
        private MiniBannerViewPromotion 万丙丙上丗丞且且丗(PGCompany.与万丝丞下丒丗丏丙 且丘丏丁丑与丙与丁)
        {
            System.Collections.Generic.Dictionary<System.String, MiniBannerViewPromotion> val_11;
            string val_12;
            System.Collections.Generic.Dictionary<System.String, MiniBannerViewPromotion> val_13;
            var val_14;
            val_11 = this;
            PGCompany.东丑丆丗丏丐丟下丄 val_1 = 且丘丏丁丑与丙与丁.丂下丏且一丈与下三();
            if(val_1 != null)
            {
                    val_12 = val_1.丈丒丄万万丘丕世丐();
            }
            else
            {
                    val_12 = 0;
            }
            
            val_13 = this.一丈丅丌丅丏丁下不;
            if((val_13.ContainsKey(key:  val_12)) != true)
            {
                    MiniBannerViewPromotion val_5 = UnityEngine.Object.Instantiate<MiniBannerViewPromotion>(original:  UnityEngine.Resources.Load<MiniBannerViewPromotion>(path:  val_12));
                val_13 = val_5;
                val_14 = 0;
                if(val_5 == 0)
            {
                    return (MiniBannerViewPromotion)val_11.Item[val_12];
            }
            
                val_13.transform.SetParent(p:  this.transform);
                丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_13.transform);
                this.一丈丅丌丅丏丁下不.set_Item(key:  val_12, value:  val_13);
            }
            
            val_11 = this.一丈丅丌丅丏丁下不;
            return (MiniBannerViewPromotion)val_11.Item[val_12];
        }
        private PGCompany.ChangeLogView 丁业一丟丟三丐丕与()
        {
            PGCompany.ChangeLogView val_13;
            if(this.丒万上丌丈且丟丑丛 == 0)
            {
                    PGCompany.ChangeLogView val_3 = UnityEngine.Object.Instantiate<PGCompany.ChangeLogView>(original:  UnityEngine.Resources.Load<PGCompany.ChangeLogView>(path:  "inapps/LobbyChangeLogButton"));
                val_13 = 0;
                if(val_3 == 0)
            {
                    return val_13;
            }
            
                this.丒万上丌丈且丟丑丛 = val_3;
                val_3.transform.SetParent(p:  this.transform);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                this.丒万上丌丈且丟丑丛.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
                this.丒万上丌丈且丟丑丛.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
                this.丒万上丌丈且丟丑丛.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            }
            
            val_13 = this.丒万上丌丈且丟丑丛;
            return val_13;
        }
        private PGCompany.TimerUI 丂业丂丟丈丗丏丟业()
        {
            PGCompany.TimerUI val_13;
            if(this.不丟丙丞丅丌专丄与 == 0)
            {
                    PGCompany.TimerUI val_3 = UnityEngine.Object.Instantiate<PGCompany.TimerUI>(original:  UnityEngine.Resources.Load<PGCompany.TimerUI>(path:  "inapps/LobbyPiggyOfferButton"));
                val_13 = 0;
                if(val_3 == 0)
            {
                    return val_13;
            }
            
                this.不丟丙丞丅丌专丄与 = val_3;
                val_3.transform.SetParent(p:  this.transform);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                this.不丟丙丞丅丌专丄与.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
                this.不丟丙丞丅丌专丄与.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
                this.不丟丙丞丅丌专丄与.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            }
            
            val_13 = this.不丟丙丞丅丌专丄与;
            return val_13;
        }
        public override void UpdateView(bool 七丆丟丗世丟且丒丆 = False)
        {
            System.Collections.Generic.Dictionary<System.String, MiniBannerViewPromotion> val_226;
            var val_227;
            System.Action<System.Collections.Generic.KeyValuePair<System.String, MiniBannerViewPromotion>> val_229;
            UnityEngine.TextMesh val_230;
            string val_231;
            UnityEngine.MonoBehaviour val_232;
            var val_233;
            PGCompany.TierBundleLobbyBanner val_234;
            var val_235;
            UnityEngine.Object val_236;
            var val_237;
            int val_238;
            var val_239;
            var val_240;
            string val_241;
            string val_242;
            string val_243;
            var val_244;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.npLobbyBanner, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tierBundleLobbyBanner, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._manualBundleLobbyBanner, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝丌丌东丆专丐专丟(), 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丗丅与不业丂丈丒丞(), 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.专与丒丅与丌丂不万(), 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丂业丂丟丈丗丏丟业(), 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丁业一丟丟三丐丕与(), 丏业丟一东丂东丘丛:  false);
            val_226 = this.一丈丅丌丅丏丁下不;
            val_227 = null;
            val_227 = null;
            val_229 = InAppBonusLobbyButtonView.<>c.<>9__34_0;
            if(val_229 == null)
            {
                    System.Action<System.Collections.Generic.KeyValuePair<System.String, MiniBannerViewPromotion>> val_6 = null;
                val_229 = val_6;
                val_230 = public System.Void System.Action<System.Collections.Generic.KeyValuePair<System.String, MiniBannerViewPromotion>>::.ctor(object object, IntPtr method);
                val_6 = new System.Action<System.Collections.Generic.KeyValuePair<System.String, MiniBannerViewPromotion>>(object:  InAppBonusLobbyButtonView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void InAppBonusLobbyButtonView.<>c::万丗与丐世丌不丝丘(System.Collections.Generic.KeyValuePair<string, MiniBannerViewPromotion> 丐丏东世不丅丌且万));
                InAppBonusLobbyButtonView.<>c.<>9__34_0 = val_229;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<System.String, MiniBannerViewPromotion>>(丌丛丏业世丄丞三丌:  val_226, 七丐丅专且专七三丆:  val_6);
            this.UpdateView(七丆丟丗世丟且丒丆:  七丆丟丗世丟且丒丆);
            if(this.Data == null)
            {
                    return;
            }
            
            Rilisoft.BonusData val_9 = this.Data;
            val_231 = val_9.Action;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_231)) != false)
            {
                    return;
            }
            
            val_232 = this.Data;
            if(七丆丟丗世丟且丒丆 != true)
            {
                    val_233 = 0;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._recommendClanObj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._recommendDuelsObj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._recommendLobbyBundlesObj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._accountsObj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._x10Obj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._battlePassObj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._twoItemsContainer, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._threeItemsContainer, 丏业丟一东丂东丘丛:  false);
                val_233 = 1;
            }
            
            Rilisoft.BonusData val_12 = this.Data;
            if(val_12.Type == 28)
            {
                    this.丛三丁丒丏丑一丅丒();
                return;
            }
            
            Rilisoft.BonusData val_13 = this.Data;
            if(val_13.OfferModule == 150)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝丌丌东丆专丐专丟(), 丏业丟一东丂东丘丛:  true);
                if(this.丝丌丌东丆专丐专丟() == 0)
            {
                    return;
            }
            
                this.丝丌丌东丆专丐专丟().丈且东丑丂且万丒丅(一丐丗丁丞丆丅丟丄:  this.Data);
                return;
            }
            
            Rilisoft.BonusData val_19 = this.Data;
            if(val_19.OfferModule == 180)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丂业丂丟丈丗丏丟业(), 丏业丟一东丂东丘丛:  true);
                PGCompany.TimerUI val_21 = this.丂业丂丟丈丗丏丟业();
                if(val_21 == null)
            {
                    return;
            }
            
                val_21.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().七三不业三丕丈丅丈(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
                return;
            }
            
            Rilisoft.BonusData val_24 = this.Data;
            if(val_24.Type != 29)
            {
                goto label_39;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tierBundleLobbyBanner, 丏业丟一东丂东丘丛:  true);
            if(this.tierBundleLobbyBanner == 0)
            {
                    return;
            }
            
            val_234 = this.tierBundleLobbyBanner;
            val_235 = val_234;
            bool val_27 = val_235.丏丆业三万丝丂丘世(一丐丗丁丞丆丅丟丄:  this.Data);
            goto label_46;
            label_39:
            Rilisoft.BonusData val_28 = this.Data;
            if(val_28.OfferModule == 160)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
                PGCompany.不万丑丗丕与丐丒丏 val_30 = PGCompany.专三不不三三一丗丅.丑七不且上丗丁一世().七丄世专丛丗丞专三();
                if(val_30 != null)
            {
                    val_232 = this.丗丅与不业丂丈丒丞();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_232, 丏业丟一东丂东丘丛:  true);
                PGCompany.DoubleOfferMiniBanner val_32 = this.丗丅与不业丂丈丒丞();
                if(val_32 != null)
            {
                    val_32.丈且东丑丂且万丒丅(丙业丞丑七丗下丟丌:  val_30);
            }
            
            }
            
            }
            
            Rilisoft.BonusData val_33 = this.Data;
            if(val_33.OfferModule == 190)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
                Rilisoft.BonusData val_34 = this.Data;
                if(val_34.Offer != null)
            {
                    Rilisoft.BonusData val_36 = this.Data;
                val_232 = PGCompany.且丝丑上丛丁丕东丕.上丑丕丅与丟上丘业(一丗与一专丙丙丅丄:  new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  val_36.Offer.业上丙丞丐丄丆丅七()));
                PGCompany.上业七丕丒丂七丐丄 val_40 = PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丟丌业丝丝丈一一下(丗丟丁丐与下丙丕丛:  val_232);
                if(val_40 != null)
            {
                    val_232 = this.专与丒丅与丌丂不万();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_232, 丏业丟一东丂东丘丛:  true);
                PGCompany.NoviceDoubleOfferMiniBanner val_42 = this.专与丒丅与丌丂不万();
                if(val_42 != null)
            {
                    val_42.丈且东丑丂且万丒丅(丙业丞丑七丗下丟丌:  val_40);
            }
            
            }
            
            }
            
            }
            
            Rilisoft.BonusData val_43 = this.Data;
            if(val_43.OfferModule != 170)
            {
                goto label_70;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._manualBundleLobbyBanner, 丏业丟一东丂东丘丛:  true);
            if(this._manualBundleLobbyBanner == 0)
            {
                    return;
            }
            
            val_234 = this._manualBundleLobbyBanner;
            val_235 = val_234;
            Rilisoft.BonusData val_226 = this.Data;
            label_46:
            val_226 = val_235.丝一丅丆三东丂丞七(一丐丗丁丞丆丅丟丄:  val_226);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_234, 丏业丟一东丂东丘丛:  val_226);
            return;
            label_70:
            Rilisoft.BonusData val_47 = this.Data;
            if(val_47.OfferModule == 200)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
                Rilisoft.BonusData val_48 = this.Data;
                if(val_48.Offer == null)
            {
                    return;
            }
            
                Rilisoft.BonusData val_52 = this.Data;
                .一丗与一专丙丙丅丄 = new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  val_52.Offer.业上丙丞丐丄丆丅七());
                PGCompany.与万丝丞下丒丗丏丙 val_56 = System.Linq.Enumerable.FirstOrDefault<PGCompany.与万丝丞下丒丗丏丙>(source:  PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().丟业不业一丈丘丗丁(), predicate:  new System.Func<PGCompany.与万丝丞下丒丗丏丙, System.Boolean>(object:  new InAppBonusLobbyButtonView.下丏丌丑七丗丕丅世(), method:  System.Boolean InAppBonusLobbyButtonView.下丏丌丑七丗丕丅世::丆丞世与一下下丈一(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万)));
                if(val_56 == null)
            {
                    return;
            }
            
                MiniBannerViewPromotion val_57 = this.万丙丙上丗丞且且丗(且丘丏丁丑与丙与丁:  val_56);
                if(val_57 == 0)
            {
                    return;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_57, 丏业丟一东丂东丘丛:  true);
                .丏不万且丑丗丄一丕 = val_56.下丒丗丄丌丘不丑丘();
                val_57.丈且东丑丂且万丒丅(丄一世丁上丅丘东丈:  new 不专丞丘世七丈丙丞(), 且丘丏丁丑与丙与丁:  val_56.丂下丏且一丈与下三());
                return;
            }
            
            Rilisoft.BonusData val_62 = this.Data;
            if(val_62.Type == 30)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
                PGCompany.丑世丁三不丘丛一丑 val_63 = PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世();
                if(val_63.丒丏丝世丄与丏丆三 == null)
            {
                    return;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丁业一丟丟三丐丕与(), 丏业丟一东丂东丘丛:  true);
                PGCompany.ChangeLogView val_65 = this.丁业一丟丟三丐丕与();
                if(val_65 == null)
            {
                    return;
            }
            
                val_65.丈且东丑丂且万丒丅(丅丆一丂丒丗且丐丗:  val_63.丒丏丝世丄与丏丆三);
                return;
            }
            
            Rilisoft.BonusData val_66 = this.Data;
            if(val_66.Type != 24)
            {
                goto label_107;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_68 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            val_236 = this.gameObject.GetComponentInChildren<PGCompany.BattlePass.BattlePassLobbyButton>(includeInactive:  true);
            if(val_236 == 0)
            {
                goto label_117;
            }
            
            if(val_68 == null)
            {
                goto label_116;
            }
            
            if((System.String.op_Inequality(a:  val_70.三丘三丁丟七丞丈丐, b:  val_68.丕世丝七世与三丞一())) != false)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_236.gameObject);
                val_236 = 0;
            }
            
            label_117:
            if(val_236 != 0)
            {
                    return;
            }
            
            val_237 = 0;
            goto label_123;
            label_129:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.transform.GetChild(index:  0).gameObject, 丏业丟一东丂东丘丛:  false);
            val_237 = 1;
            label_123:
            if(val_237 < this.transform.childCount)
            {
                goto label_129;
            }
            
            UnityEngine.GameObject val_82 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPLobbyButton"));
            if(val_82 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_85 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_82, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            if((val_85.GetComponent<PGCompany.BattlePass.BattlePassLobbyButton>()) == 0)
            {
                    return;
            }
            
            val_86.三丘三丁丟七丞丈丐 = val_68.丕世丝七世与三丞一();
            MultButton val_89 = this.GetComponent<MultButton>();
            if(val_89 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_92 = val_85.transform.Find(n:  "BtnDarken");
            if(val_92 == 0)
            {
                    return;
            }
            
            val_89.AddTargetObject(丝三丁东丈丒世丅业:  val_92.gameObject);
            return;
            label_107:
            Rilisoft.BonusData val_95 = this.Data;
            if(val_95.Type == 9)
            {
                goto label_152;
            }
            
            Rilisoft.BonusData val_96 = this.Data;
            if(val_96.Offer == null)
            {
                goto label_157;
            }
            
            Rilisoft.BonusData val_97 = this.Data;
            if(val_97.Offer.不丌上丟不下丒与世 != 30000)
            {
                goto label_157;
            }
            
            label_152:
            if((val_233 & 1) == 0)
            {
                    if(val_97.Offer == this.Data)
            {
                    return;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._timeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._profitObject, 丏业丟一东丂东丘丛:  false);
            this.下丟东丛七丘七下丈(丂丈丗丄不丅丅丙丒:  this.Data);
            return;
            label_157:
            Rilisoft.BonusData val_101 = this.Data;
            if(val_101.IsTypePack == false)
            {
                goto label_164;
            }
            
            if((val_233 & 1) == 0)
            {
                    if(val_101.ShowedPack == this.Data.Pack)
            {
                goto label_211;
            }
            
            }
            
            mem2[0] = this.Data.Pack;
            label_217:
            if(this._timeLeftLabel != null)
            {
                goto label_382;
            }
            
            label_383:
            label_382:
            this._timeLeftLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2915"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.Data.Pack));
            goto label_211;
            label_116:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_236.gameObject);
            return;
            label_164:
            if((val_233 & 1) == 0)
            {
                    if(val_101.ShowedEnd == this.Data.End)
            {
                goto label_211;
            }
            
            }
            
            mem2[0] = this.Data.End;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timeLeftLabel, 丏业丟一东丂东丘丛:  true);
            if((this.Data.End & 2147483648) != 0)
            {
                goto label_189;
            }
            
            int val_119 = this.Data.End;
            val_230 = 0;
            val_238 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  val_230);
            if(this._timeLeftLabel != null)
            {
                goto label_195;
            }
            
            goto label_194;
            label_189:
            val_238 = System.String.alignConst;
            if(this._timeLeftLabel != null)
            {
                goto label_195;
            }
            
            label_194:
            label_195:
            this._timeLeftLabel.text = val_238;
            Rilisoft.BonusData val_121 = this.Data;
            if(val_121.Type == 20)
            {
                    var val_124 = (this.Data.End > 0) ? 1 : 0;
            }
            else
            {
                    val_239 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timePanel, 丏业丟一东丂东丘丛:  true);
            Rilisoft.BonusData val_125 = this.Data;
            if(val_125.OfferModule != 150)
            {
                goto label_211;
            }
            
            Rilisoft.BonusData val_126 = this.Data;
            if(val_126.Offer == null)
            {
                goto label_211;
            }
            
            Rilisoft.BonusData val_128 = this.Data;
            PGCompany.世丞上丏丗不丛上东 val_131 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丞世不丒下上上丝丑:  System.Convert.ToInt32(value:  val_128.Offer.业上丙丞丐丄丆丅七()));
            if(val_131 == null)
            {
                goto label_211;
            }
            
            if(((val_131.下丒丗丄丌丘不丑丘() - PixelTime.丙丅丅业丟丁世丁丗()) & 2147483648) != 0)
            {
                goto label_214;
            }
            
            string val_135 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            goto label_217;
            label_211:
            val_240 = null;
            val_240 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_136.Profit, hi = val_136.Profit, lo = this.Data, mid = this.Data}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
            {
                    string val_138 = this.丛东一丁丟丛不上丑();
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_138)) != true)
            {
                    this._profitLabel.text = val_138;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitObject, 丏业丟一东丂东丘丛:  false);
            Rilisoft.BonusData val_140 = this.Data;
            Rilisoft.BonusData val_141 = this.Data;
            if(val_140.Offer != null)
            {
                    val_241 = val_141.Offer.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_241 = val_141.Action;
            }
            
            Rilisoft.BonusData val_143 = this.Data;
            if(val_143.Type == 3)
            {
                    Rilisoft.BonusData val_144 = this.Data;
                val_242 = val_144.PetId;
            }
            else
            {
                    val_242 = 0;
            }
            
            val_243 = Rilisoft.Offers.丁且丕专万丈丒丏丗.丈七下丗万七不不一(丗丟丁丐与下丙丕丛:  val_241, 丐丁不丆丘丂丐丈丆:  val_242);
            if((System.String.op_Equality(a:  val_241, b:  "tryGun")) == false)
            {
                goto label_239;
            }
            
            label_258:
            val_243 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3692");
            goto label_251;
            label_239:
            Rilisoft.BonusData val_148 = this.Data;
            if(val_148.Offer == null)
            {
                goto label_251;
            }
            
            Rilisoft.BonusData val_149 = this.Data;
            if(val_149.Offer.丑且一丐东三不丈丝() != 120)
            {
                goto label_251;
            }
            
            Rilisoft.BonusData val_151 = this.Data;
            if((val_151.Offer.丁专丗万三上丟三丆() == null) || (val_152.丒上一丁丆丛东专丙 == null))
            {
                goto label_251;
            }
            
            Rilisoft.BonusData val_153 = this.Data;
            Rilisoft.七丈业与与不七丈丟 val_154 = val_153.Offer.丁专丗万三上丟三丆();
            goto label_258;
            label_251:
            Rilisoft.BonusData val_155 = this.Data;
            if(val_155.Offer != null)
            {
                    Rilisoft.BonusData val_156 = this.Data;
                if(val_156.Offer.丑且一丐东三不丈丝() == 150)
            {
                    val_244 = null;
                val_244 = null;
                val_243 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  不七七丌与丙丏丑专.丅丈丝丌丈三与上丕);
            }
            
            }
            
            Rilisoft.BonusData val_159 = this.Data;
            if(val_159.Type == 20)
            {
                    val_243 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12347");
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._headerLabel, 丕丗丘丑丛与丑业丒:  val_243);
            Rilisoft.BonusData val_161 = this.Data;
            if(val_161.Type != 2)
            {
                goto label_280;
            }
            
            if((val_233 & 1) == 0)
            {
                goto label_276;
            }
            
            val_233 = 1;
            goto label_277;
            label_276:
            Rilisoft.BonusData val_162 = this.Data;
            if((System.String.op_Inequality(a:  val_161.WeaponId, b:  val_162.WeaponId)) == false)
            {
                goto label_280;
            }
            
            val_233 = 0;
            label_277:
            this.丅上东丈丛一七专下();
            goto label_415;
            label_280:
            Rilisoft.BonusData val_164 = this.Data;
            if(val_164.Type != 23)
            {
                goto label_287;
            }
            
            if((val_233 & 1) == 0)
            {
                goto label_284;
            }
            
            val_233 = 1;
            goto label_285;
            label_284:
            Rilisoft.BonusData val_165 = this.Data;
            if((System.Linq.Enumerable.Any<System.String>(source:  val_165.Royales, predicate:  new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.InAppBonusLobbyButtonView::丌一丁丟丌且丈且丆(string 业七丐世专丝丂丟丈)))) == false)
            {
                goto label_287;
            }
            
            val_233 = 0;
            label_285:
            this.上丈三三丒丛丝丏专();
            goto label_415;
            label_287:
            Rilisoft.BonusData val_168 = this.Data;
            if(val_168.Type != 16)
            {
                goto label_295;
            }
            
            if((val_233 & 1) == 0)
            {
                goto label_291;
            }
            
            val_233 = 1;
            goto label_292;
            label_291:
            Rilisoft.BonusData val_169 = this.Data;
            if((System.String.op_Inequality(a:  val_168.DetailsItemId, b:  val_169.DetailsItemId)) == false)
            {
                goto label_295;
            }
            
            val_233 = 0;
            label_292:
            this.不上世丈世丅丏东丐();
            goto label_415;
            label_295:
            Rilisoft.BonusData val_171 = this.Data;
            Rilisoft.BonusData val_172 = this.Data;
            if(val_171.Type != 12)
            {
                goto label_299;
            }
            
            if(val_172.EventCurrencies == null)
            {
                goto label_346;
            }
            
            Rilisoft.BonusData val_173 = this.Data;
            if(val_174.Count <= 0)
            {
                goto label_346;
            }
            
            if((val_233 & 1) != 0)
            {
                goto label_312;
            }
            
            EventCurrencyData val_175 = val_173.EventCurrencies.Item[0].Item[0];
            Rilisoft.BonusData val_176 = this.Data;
            EventCurrencyData val_177 = val_176.EventCurrencies.Item[0];
            if(val_175.Count != val_177.Count)
            {
                goto label_312;
            }
            
            label_353:
            val_233 = 0;
            goto label_415;
            label_299:
            if(val_172.Type != 25)
            {
                goto label_314;
            }
            
            if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
            {
                goto label_415;
            }
            
            this.丆丑丝不丄万不丟丈();
            goto label_415;
            label_314:
            Rilisoft.BonusData val_180 = this.Data;
            Rilisoft.BonusData val_181 = this.Data;
            if(val_180.Type != 13)
            {
                goto label_320;
            }
            
            if(val_181.Wears == null)
            {
                goto label_346;
            }
            
            Rilisoft.BonusData val_182 = this.Data;
            if(val_182.Wears.Count == 0)
            {
                goto label_346;
            }
            
            if((val_233 & 1) != 0)
            {
                goto label_328;
            }
            
            Rilisoft.BonusData val_184 = this.Data;
            if(val_180.Type != val_184.Wears)
            {
                goto label_328;
            }
            
            Rilisoft.BonusData val_186 = this.Data;
            if((System.String.op_Inequality(a:  System.Linq.Enumerable.FirstOrDefault<System.String>(source:  val_184.Wears), b:  System.Linq.Enumerable.FirstOrDefault<System.String>(source:  val_186.Wears))) == false)
            {
                goto label_353;
            }
            
            label_328:
            this.丏丝丞上丑丈丂丆不();
            goto label_415;
            label_312:
            Rilisoft.BonusData val_190 = this.Data;
            EventCurrencyData val_191 = val_190.EventCurrencies.Item[0];
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  val_191.EventType)) == null)
            {
                goto label_346;
            }
            
            this.与丂丈丗丑万业丄与();
            goto label_415;
            label_320:
            Rilisoft.BonusData val_193 = this.Data;
            if(val_181.Type != 14)
            {
                goto label_342;
            }
            
            if(val_193.LobbyItems == null)
            {
                goto label_346;
            }
            
            Rilisoft.BonusData val_194 = this.Data;
            if(val_194.LobbyItems.Count == 0)
            {
                goto label_346;
            }
            
            if((val_233 & 1) != 0)
            {
                goto label_350;
            }
            
            Rilisoft.BonusData val_196 = this.Data;
            if(val_181.Type != val_196.LobbyItems)
            {
                goto label_350;
            }
            
            Rilisoft.BonusData val_198 = this.Data;
            if((System.String.op_Inequality(a:  System.Linq.Enumerable.FirstOrDefault<System.String>(source:  val_196.LobbyItems), b:  System.Linq.Enumerable.FirstOrDefault<System.String>(source:  val_198.LobbyItems))) == false)
            {
                goto label_353;
            }
            
            label_350:
            this.三东七丒丆三与三丌();
            goto label_415;
            label_346:
            this.丅业丂丟丐上丁丕丒();
            label_415:
            Rilisoft.BonusData val_201 = this.Data;
            if(val_172.Type == val_201.Type)
            {
                    Rilisoft.BonusData val_202 = this.Data;
                if((val_233 | (~(System.String.op_Equality(a:  val_201.Key, b:  val_202.Key)))) == false)
            {
                    return;
            }
            
            }
            
            this.下丟东丛七丘七下丈(丂丈丗丄不丅丅丙丒:  this.Data);
            Rilisoft.BonusData val_206 = this.Data;
            if((val_206.Type - 18) > 9)
            {
                goto label_362;
            }
            
            var val_227 = 106031428 + ((val_206.Type - 18)) << 2;
            val_227 = val_227 + 106031428;
            goto (106031428 + ((val_206.Type - 18)) << 2 + 106031428);
            label_362:
            if(val_206.Type != 15)
            {
                    return;
            }
            
            this.业丝丈丑丟丒七丌专(丛万下七世丌且丒丂:  this._recommendClanObj);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            Rilisoft.丗万且下与专业丏丝.丝上上丞丄丅丘丙专();
            return;
            label_214:
            if(this._timeLeftLabel != null)
            {
                goto label_382;
            }
            
            goto label_383;
            label_342:
            if(val_193.Type != 3)
            {
                goto label_389;
            }
            
            if((val_233 & 1) == 0)
            {
                goto label_385;
            }
            
            goto label_386;
            label_385:
            Rilisoft.BonusData val_211 = this.Data;
            if((System.String.op_Inequality(a:  val_193.PetId, b:  val_211.PetId)) == false)
            {
                goto label_389;
            }
            
            label_386:
            this.丘一下且丟丌丆丌丏();
            goto label_415;
            label_389:
            Rilisoft.BonusData val_213 = this.Data;
            if(val_213.Type != 7)
            {
                goto label_397;
            }
            
            if((val_233 & 1) == 0)
            {
                goto label_393;
            }
            
            goto label_394;
            label_393:
            Rilisoft.BonusData val_214 = this.Data;
            if(val_213.Offer == val_214.Offer)
            {
                goto label_397;
            }
            
            label_394:
            this.丟丈专丘丞且丌三丗();
            goto label_415;
            label_397:
            Rilisoft.BonusData val_215 = this.Data;
            var val_216 = (val_215.Type == 5) ? 1 : 0;
            val_216 = val_233 & val_216;
            if(val_216 != 1)
            {
                goto label_400;
            }
            
            this.一上东东丏专丞专丙();
            goto label_415;
            label_400:
            Rilisoft.BonusData val_217 = this.Data;
            if(val_217.Type != 8)
            {
                goto label_403;
            }
            
            this.不七上东丂丑丝与上();
            goto label_415;
            label_403:
            Rilisoft.BonusData val_218 = this.Data;
            var val_219 = (val_218.Type == 22) ? 1 : 0;
            val_219 = val_233 & val_219;
            if(val_219 != 1)
            {
                goto label_406;
            }
            
            this.且且丏丁下丒丄与与();
            goto label_415;
            label_406:
            Rilisoft.BonusData val_220 = this.Data;
            var val_221 = (val_220.Type == 4) ? 1 : 0;
            val_221 = val_233 & val_221;
            if(val_221 != 1)
            {
                goto label_409;
            }
            
            this.丐与丐业丗丗丐丄专();
            goto label_415;
            label_409:
            Rilisoft.BonusData val_222 = this.Data;
            var val_223 = (val_222.Type == 1) ? 1 : 0;
            val_223 = val_233 & val_223;
            if(val_223 != 1)
            {
                goto label_412;
            }
            
            this.丅业丂丟丐上丁丕丒();
            goto label_415;
            label_412:
            Rilisoft.BonusData val_224 = this.Data;
            var val_225 = (val_224.Type == 11) ? 1 : 0;
            val_225 = val_233 & val_225;
            if(val_225 != 1)
            {
                goto label_415;
            }
            
            this.丙丅丐东丘上丝丕丌();
            goto label_415;
        }
        private void 专与丑丕丗丛丗专丅()
        {
            UnityEngine.GameObject val_18;
            UnityEngine.Object val_19;
            var val_20;
            string val_2 = X10Manager.丑七不且上丗丁一世().与丑丏丅下丁丏丟丛();
            if(this.丆万丐不丝上下不丙 != null)
            {
                    if((System.String.op_Inequality(a:  this.丆万丐不丝上下不丙, b:  val_2)) != false)
            {
                    if(this.丅丒七与上东不丛丒 != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丅丒七与上东不丛丒);
                this.丅丒七与上东不丛丒 = 0;
            }
            
                this.丆万丐不丝上下不丙 = 0;
            }
            else
            {
                    if(this.丆万丐不丝上下不丙 != null)
            {
                    return;
            }
            
            }
            
            }
            
            this.丆万丐不丝上下不丙 = val_2;
            val_18 = this.丅丒七与上东不丛丒;
            if(val_18 != 0)
            {
                    return;
            }
            
            val_18 = 1152921524279436720;
            val_19 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/{0}", arg0:  System.String.Format(format:  "lobbyLeftBanner_x10_{0}", arg0:  val_2.ToLower())));
            if(val_19 == 0)
            {
                    val_20 = "basic";
                if("basic" == null)
            {
                    val_20 = "basic";
            }
            
                val_19 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/lobbyLeftBanner_x10_{0}", arg0:  ToLower()));
            }
            
            if(val_19 == 0)
            {
                    return;
            }
            
            val_18 = this._x10Obj.transform;
            int val_16 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            this.丅丒七与上东不丛丒 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_19, 丈东丘丏与丌东东下:  val_18, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        private void 丁丟且丙七专丅丏三(int 三丂丙不一丝不专一)
        {
            System.Object[] val_3;
            var val_4;
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_5;
            val_3 = this;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._twoItemsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._threeItemsContainer, 丏业丟一东丂东丘丛:  false);
            if(三丂丙不一丝不专一 == 3)
            {
                goto label_3;
            }
            
            if(三丂丙不一丝不专一 == 2)
            {
                goto label_4;
            }
            
            if(三丂丙不一丝不专一 != 1)
            {
                goto label_5;
            }
            
            label_3:
            val_4 = null;
            val_5 = this._threeItemsContainer;
            goto label_9;
            label_4:
            val_4 = null;
            val_5 = this._twoItemsContainer;
            label_9:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
            return;
            label_5:
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return;
            }
            
            object[] val_2 = new object[1];
            val_3 = val_2;
            val_3[0] = 三丂丙不一丝不专一;
            UnityEngine.Debug.LogErrorFormat(format:  "There is no chance to display {0} icons. Sorry.", args:  val_2);
        }
        private Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid 丄丆丐七丈专万丑丂(int 三丂丙不一丝不专一)
        {
            if(三丂丙不一丝不专一 == 3)
            {
                    return (Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid)this._threeItemsContainer;
            }
            
            if(三丂丙不一丝不专一 == 2)
            {
                    return (Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid)this._twoItemsContainer;
            }
            
            if(三丂丙不一丝不专一 != 1)
            {
                    return 0;
            }
            
            return (Rilisoft.InAppBonusLobbyButtonAbstractIconsGrid)this._threeItemsContainer;
        }
        private void 丅业丂丟丐上丁丕丒()
        {
            var val_13;
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_14;
            val_13 = this;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            int val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5);
            if(val_5 == 3)
            {
                goto label_3;
            }
            
            if(val_5 == 2)
            {
                goto label_4;
            }
            
            if(val_5 != 1)
            {
                goto label_5;
            }
            
            label_3:
            val_14 = this._threeItemsContainer;
            goto label_7;
            label_4:
            val_14 = this._twoItemsContainer;
            goto label_7;
            label_5:
            val_14 = 0;
            label_7:
            if(val_14 == 0)
            {
                    return;
            }
            
            Rilisoft.BonusData val_7 = this.Data;
            val_13 = ???;
            goto mem[282584257677031];
        }
        private void 丅上东丈丛一七专下()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677047];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677047];
        }
        private void 上丈三三丒丛丝丏专()
        {
            int val_9;
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_10;
            var val_11;
            Rilisoft.BonusData val_1 = this.Data;
            val_9 = UnityEngine.Mathf.Clamp(value:  val_1.Royales.Count, min:  0, max:  3);
            if(val_9 <= 1)
            {
                    Rilisoft.BonusData val_4 = this.Data;
                Rilisoft.BonusData val_5 = this.Data;
                var val_6 = (val_4.Coins > 0) ? (val_9 + 1) : (val_9);
                val_9 = (val_5.Gems > 0) ? (val_6 + 1) : (val_6);
            }
            
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_9);
            if(val_9 == 1)
            {
                goto label_8;
            }
            
            if(val_9 == 2)
            {
                goto label_9;
            }
            
            if(val_9 != 3)
            {
                goto label_10;
            }
            
            label_8:
            val_10 = this._threeItemsContainer;
            goto label_11;
            label_9:
            val_10 = this._twoItemsContainer;
            label_11:
            val_11 = this.Data;
            if(val_10 != null)
            {
                goto mem[282584257677063];
            }
            
            goto label_13;
            label_10:
            val_11 = this.Data;
            label_13:
            val_10 = 0;
            goto mem[282584257677063];
        }
        private void 不上世丈世丅丏东丐()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677079];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677079];
        }
        private void 与丂丈丗丑万业丄与()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677095];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677095];
        }
        private void 丆丑丝不丄万不丟丈()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677111];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677111];
        }
        private void 丏丝丞上丑丈丂丆不()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677127];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677127];
        }
        private void 三东七丒丆三与三丌()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677143];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677143];
        }
        private void 丘一下且丟丌丆丌丏()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677159];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677159];
        }
        private void 丟丈专丘丞且丌三丗()
        {
            int val_16;
            var val_17;
            var val_18;
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_19;
            var val_20;
            Rilisoft.BonusData val_1 = this.Data;
            if(val_1.Offer == null)
            {
                goto label_7;
            }
            
            System.Nullable<AdaptiveModuleType> val_2 = val_1.Offer.下丐丝万丞丙丁丂丑();
            if(((-277485992) & 1) == 0)
            {
                goto label_7;
            }
            
            System.Nullable<AdaptiveModuleType> val_3 = val_1.Offer.下丐丝万丞丙丁丂丑();
            val_16 = val_3.HasValue.丙东专丂世丈丏丁丂();
            if(val_16 == 70)
            {
                    if(((-277485992) & 1) != 0)
            {
                goto label_5;
            }
            
            }
            
            System.Nullable<AdaptiveModuleType> val_5 = val_1.Offer.下丐丝万丞丙丁丂丑();
            if((val_5.HasValue.丙东专丂世丈丏丁丂() != 90) || (((-277485992) & 1) == 0))
            {
                goto label_7;
            }
            
            label_5:
            val_17 = 1;
            goto label_8;
            label_7:
            Rilisoft.BonusData val_7 = this.Data;
            val_16 = val_7.Coins;
            Rilisoft.BonusData val_8 = this.Data;
            var val_9 = (val_16 > 0) ? (1 + 1) : 1;
            int val_10 = (val_8.Gems > 0) ? (val_9 + 1) : (val_9);
            label_8:
            if(this.Data == null)
            {
                goto label_15;
            }
            
            if(val_11.Offer != null)
            {
                    OfferModule val_12 = val_11.Offer.丑且一丐东三不丈丝();
                val_18 = 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            val_16 = val_18.丙东专丂世丈丏丁丂();
            if((val_16 != 150) || (((-277486008) & 1) == 0))
            {
                goto label_15;
            }
            
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  1);
            goto label_17;
            label_15:
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_10);
            if(val_10 == 1)
            {
                goto label_17;
            }
            
            if(val_10 == 2)
            {
                goto label_18;
            }
            
            if(val_10 != 3)
            {
                goto label_19;
            }
            
            label_17:
            val_19 = this._threeItemsContainer;
            goto label_20;
            label_18:
            val_19 = this._twoItemsContainer;
            label_20:
            val_20 = this.Data;
            if(val_19 != null)
            {
                    return;
            }
            
            goto label_22;
            label_19:
            val_20 = this.Data;
            label_22:
            val_19 = 0;
        }
        private void 一上东东丏专丞专丙()
        {
            int val_9;
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_10;
            var val_11;
            Rilisoft.BonusData val_1 = this.Data;
            val_9 = UnityEngine.Mathf.Clamp(value:  val_1.Gadgets.Count, min:  0, max:  3);
            if(val_9 <= 1)
            {
                    Rilisoft.BonusData val_4 = this.Data;
                Rilisoft.BonusData val_5 = this.Data;
                var val_6 = (val_4.Coins > 0) ? (val_9 + 1) : (val_9);
                val_9 = (val_5.Gems > 0) ? (val_6 + 1) : (val_6);
            }
            
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_9);
            if(val_9 == 1)
            {
                goto label_8;
            }
            
            if(val_9 == 2)
            {
                goto label_9;
            }
            
            if(val_9 != 3)
            {
                goto label_10;
            }
            
            label_8:
            val_10 = this._threeItemsContainer;
            goto label_11;
            label_9:
            val_10 = this._twoItemsContainer;
            label_11:
            val_11 = this.Data;
            if(val_10 != null)
            {
                goto mem[282584257677191];
            }
            
            goto label_13;
            label_10:
            val_11 = this.Data;
            label_13:
            val_10 = 0;
            goto mem[282584257677191];
        }
        private void 不七上东丂丑丝与上()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677207];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677207];
        }
        private void 且且丏丁下丒丄与与()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677223];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677223];
        }
        private void 丐与丐业丗丗丐丄专()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677239];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677239];
        }
        private void 丙丅丐东丘上丝丕丌()
        {
            Rilisoft.InAppBonusLobbyButtonThreeIconsGrid val_9;
            var val_10;
            Rilisoft.BonusData val_1 = this.Data;
            Rilisoft.BonusData val_2 = this.Data;
            var val_5 = (val_2.Gems <= 0) ? ((val_1.Coins > 0) ? 1 : 0) : ((val_1.Coins > 0) ? 2 : (0 + 1));
            this.丁丟且丙七专丅丏三(三丂丙不一丝不专一:  val_5 + 1);
            if(val_5 == 0)
            {
                goto label_2;
            }
            
            if(val_5 == 1)
            {
                goto label_3;
            }
            
            if(val_5 != 2)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = this._threeItemsContainer;
            goto label_5;
            label_3:
            val_9 = this._twoItemsContainer;
            label_5:
            val_10 = this.Data;
            if(val_9 != null)
            {
                goto mem[282584257677255];
            }
            
            goto label_7;
            label_4:
            val_10 = this.Data;
            label_7:
            val_9 = 0;
            goto mem[282584257677255];
        }
        private void OnClick()
        {
            goto typeof(Rilisoft.InAppBonusLobbyButtonView).__il2cppRuntimeField_1B8;
        }
        private void 丛三丁丒丏丑一丅丒()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonHolder, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.npLobbyBanner, 丏业丟一东丂东丘丛:  true);
            if(this.npLobbyBanner == 0)
            {
                    return;
            }
            
            Rilisoft.BonusData val_4 = this.Data;
            val_4 = this.npLobbyBanner.丏丆业三万丝丂丘世(一丐丗丁丞丆丅丟丄:  val_4);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.npLobbyBanner, 丏业丟一东丂东丘丛:  val_4);
        }
        public InAppBonusLobbyButtonView()
        {
            this.一丈丅丌丅丏丁下不 = new System.Collections.Generic.Dictionary<System.String, MiniBannerViewPromotion>();
        }
        private bool 丌一丁丟丌且丈且丆(string 业七丐世专丝丂丟丈)
        {
            .业七丐世专丝丂丟丈 = 业七丐世专丝丂丟丈;
            return System.Linq.Enumerable.All<System.String>(source:  业七丐世专丝丂丟丈, predicate:  new System.Func<System.String, System.Boolean>(object:  new InAppBonusLobbyButtonView.丞丌丐丝三万三丐丁(), method:  System.Boolean InAppBonusLobbyButtonView.丞丌丐丝三万三丐丁::丝下东三上丕丁专丙(string 丌丘丝三丆丌七丛专)));
        }
    
    }

}
