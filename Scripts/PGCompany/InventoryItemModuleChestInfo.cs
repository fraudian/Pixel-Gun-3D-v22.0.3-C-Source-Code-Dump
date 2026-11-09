using UnityEngine;

namespace PGCompany
{
    internal sealed class InventoryItemModuleChestInfo : InventoryItemInfo
    {
        // Fields
        private System.Collections.Generic.KeyValuePair<long, string> 丌东丒不三丑东丟丁;
        private UIButton boostButton;
        private UILabel boostLabel;
        private PGCompany.三丘丌上丁万丏丛丟 上丁丗丐丝丛丝世丂;
        private PropertiesLayout propertiesLayout;
        private UnityEngine.GameObject startOpenButton;
        private UnityEngine.GameObject openNowButton;
        private UnityEngine.GameObject canOpenButton;
        private CurrencyUI openNowItemPriceUI;
        private UILabel maxOpenTime;
        private UnityEngine.Coroutine 不丐丛丙世上丑丂丈;
        
        // Properties
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        
        // Methods
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private void 世三丐丈东丅丄丈上()
        {
            MoonSharp.Interpreter.TablePair val_1 = new MoonSharp.Interpreter.TablePair(key:  -9223372036854775808, val:  System.String.alignConst);
            this.丌东丒不三丑东丟丁 = val_1.key;
            mem[1152921555529390928] = val_1.value;
        }
        private void 丌丏丒丐丙丂丑丙专()
        {
            object val_47;
            string val_9 = 0;
            if(this.上丁丗丐丝丛丝世丂 == null)
            {
                goto label_1;
            }
            
            if(this.上丁丗丐丝丛丝世丂 == 丐东不丅丂丂丅丙不.丆万丂东东三世丄专())
            {
                goto label_4;
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_65;
            }
            
            val_47 = "[InventoryItemModuleChestInfo.RefreshBoostButtonAndLabel] moduleChest != chestToOpen";
            goto label_10;
            label_1:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_65;
            }
            
            val_47 = "[InventoryItemModuleChestInfo.RefreshBoostButtonAndLabel] moduleChest: null";
            label_10:
            label_59:
            UnityEngine.Debug.Log(message:  val_47);
            label_65:
            this.且丁丄丑丛丈业丆业();
            return;
            label_4:
            if(丐东不丅丂丂丅丙不.丏丑丑一丌丅丂丅丘() <= 0)
            {
                goto label_18;
            }
            
            if((PGCompany.丒丌东丙丝丂丌丞丂.丑七不且上丗丁一世().丐丅且丗东丘上与丏(万丄丅丝三丈丆世丟:  PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三(), 与三丂丆丗东下丐丙: out  new System.DateTime(), 丄丅丛不丒丒丅下丄: out  double val_7 = 1.28824432010077E-231, 东一丟丝丗万丐业丁: out  double val_8 = 1.28824432010076E-231, 丐丐丕丌万不丛丏七: out  val_9)) == false)
            {
                goto label_22;
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    System.Text.StringBuilder val_12 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  24);
                System.Globalization.CultureInfo val_14 = PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈();
                System.Text.StringBuilder val_24 = val_12.Append(value:  "[InventoryItemModuleChestInfo.RefreshBoostButtonAndLabel]").Append(value:  " timeUtc: "(" timeUtc: ") + 0).Append(value:  ", durationInMinutes: "(", durationInMinutes: ") + 0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())(0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈()))).Append(value:  ", delayInMinutes: "(", delayInMinutes: ") + 0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())(0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())));
                UnityEngine.Debug.Log(message:  PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_12));
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.boostButton, 丏业丟一东丂东丘丛:  true);
            if(this.boostLabel == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.boostLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            System.TimeSpan val_28 = System.TimeSpan.FromMinutes(value:  0);
            long val_30 = System.Convert.ToInt64(value:  val_28._ticks.TotalSeconds);
            if((System.String.IsNullOrEmpty(value:  this.丌东丒不三丑东丟丁)) != true)
            {
                    if(this.丌东丒不三丑东丟丁.丐丏七丌丕丗业且上() == val_30)
            {
                goto label_45;
            }
            
            }
            
            MoonSharp.Interpreter.TablePair val_37 = new MoonSharp.Interpreter.TablePair(key:  val_30, val:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5118")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5118")) + System.Environment.NewLine + 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_30, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)(专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_30, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
            this.丌东丒不三丑东丟丁 = val_37.key;
            mem[1152921555529645744] = val_37.value;
            label_45:
            this.boostLabel.text = this.丌东丒不三丑东丟丁;
            return;
            label_18:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_65;
            }
            
            string val_42 = "[InventoryItemModuleChestInfo.RefreshBoostButtonAndLabel] timeToOpen: "("[InventoryItemModuleChestInfo.RefreshBoostButtonAndLabel] timeToOpen: ") + 丐东不丅丂丂丅丙不.丏丑丑一丌丅丂丅丘().ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())(丐东不丅丂丂丅丙不.丏丑丑一丌丅丂丅丘().ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈()));
            if(new UnityEngine.Vector3Int() != 0)
            {
                goto label_59;
            }
            
            goto label_59;
            label_22:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_65;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[InventoryItemModuleChestInfo.RefreshBoostButtonAndLabel] disabledReason: "("[InventoryItemModuleChestInfo.RefreshBoostButtonAndLabel] disabledReason: ") + val_9 + ", delayInMinutes: "(", delayInMinutes: ") + 0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())(0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())));
            goto label_65;
        }
        private void 且丁丄丑丛丈业丆业()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.boostButton, 丏业丟一东丂东丘丛:  false);
            if(this.boostLabel == 0)
            {
                    return;
            }
            
            MoonSharp.Interpreter.TablePair val_2 = new MoonSharp.Interpreter.TablePair(key:  -9223372036854775808, val:  System.String.alignConst);
            this.丌东丒不三丑东丟丁 = val_2.key;
            mem[1152921555529917488] = val_2.value;
            this.boostLabel.text = System.String.alignConst;
            this = this.boostLabel.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  false);
        }
        public void OnBoostPressed()
        {
            long val_28;
            string val_5 = 0;
            string val_1 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            val_28 = PGCompany.丒丌东丙丝丂丌丞丂.丑七不且上丗丁一世();
            if((val_28.丐丅且丗东丘上与丏(万丄丅丝三丈丆世丟:  val_1, 与三丂丆丗东下丐丙: out  new System.DateTime(), 丄丅丛不丒丒丅下丄: out  double val_3 = 1.28824432024256E-231, 东一丟丝丗万丐业丁: out  double val_4 = 1.28824432024256E-231, 丐丐丕丌万不丛丏七: out  val_5)) != false)
            {
                    if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    System.Text.StringBuilder val_8 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  24);
                System.Globalization.CultureInfo val_10 = PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈();
                System.Text.StringBuilder val_20 = val_8.Append(value:  "[InventoryItemModuleChestInfo.OnBoostPressed]").Append(value:  " timeUtc: "(" timeUtc: ") + 0).Append(value:  ", durationInMinutes: "(", durationInMinutes: ") + 0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())(0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈()))).Append(value:  ", delayInMinutes: "(", delayInMinutes: ") + 0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())(0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())));
                UnityEngine.Debug.Log(message:  PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_8));
            }
            
                System.TimeSpan val_22 = System.TimeSpan.FromMinutes(value:  0);
                val_28 = val_22._ticks;
                PGCompany.丒丌东丙丝丂丌丞丂.丑七不且上丗丁一世().丗丘东万不七专丕三(万丄丅丝三丈丆世丟:  val_1, 上丁丗丐丝丛丝世丂:  this.上丁丗丐丝丛丝世丂, 与三丂丆丗东下丐丙:  new System.DateTime(), 丆丌丒丐丙丟世七丑:  new System.TimeSpan() {_ticks = val_28}, 七丆丘上专丞上丟丗:  new System.Action(object:  this, method:  System.Void PGCompany.InventoryItemModuleChestInfo::丌丏丒丐丙丂丑丙专()));
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[InventoryItemModuleChestInfo.OnBoostPressed] disabledReason: "("[InventoryItemModuleChestInfo.OnBoostPressed] disabledReason: ") + val_5 + ", delayInMinutes: "(", delayInMinutes: ") + 0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())(0.ToString(provider:  PGCompany.InventoryItemModuleChestInfo.丙专丝世不业下丂丈())));
            this.且丁丄丑丛丈业丆业();
        }
        private void Start()
        {
            I2.Loc.丗丈下丕丟丟丙七丞.三世丅丁丝丟丛丄丝(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.InventoryItemModuleChestInfo::世三丐丈东丅丄丈上()));
        }
        private void OnEnable()
        {
            this.丛丟丞丆丏丕丛丕丄();
            丐东不丅丂丂丅丙不.丂丑丟丘万上丂丆七(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三丘丌上丁万丏丛丟>(object:  this, method:  System.Void PGCompany.InventoryItemModuleChestInfo::且七丞且丅一三丕丌(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌)));
            丐东不丅丂丂丅丙不.不丂业丆下不丗万丁(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三丘丌上丁万丏丛丟, System.Collections.Generic.List<Rilisoft.OfferItem>>(object:  this, method:  System.Void PGCompany.InventoryItemModuleChestInfo::丄丐东且丁丟七东不(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)));
            丐东不丅丂丂丅丙不.东丘七丝丑七不丙丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.InventoryItemModuleChestInfo::丆丁世七丙丝丕丙世()));
        }
        private void OnDisable()
        {
            if(this.不丐丛丙世上丑丂丈 != null)
            {
                    this.StopCoroutine(routine:  this.不丐丛丙世上丑丂丈);
                this.不丐丛丙世上丑丂丈 = 0;
            }
            
            丐东不丅丂丂丅丙不.丒丟丐上丅丕丄丂万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三丘丌上丁万丏丛丟>(object:  this, method:  System.Void PGCompany.InventoryItemModuleChestInfo::且七丞且丅一三丕丌(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌)));
            丐东不丅丂丂丅丙不.丑丂丁丘且万东丙东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三丘丌上丁万丏丛丟, System.Collections.Generic.List<Rilisoft.OfferItem>>(object:  this, method:  System.Void PGCompany.InventoryItemModuleChestInfo::丄丐东且丁丟七东不(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)));
            丐东不丅丂丂丅丙不.丙七与七丗丝与丌与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.InventoryItemModuleChestInfo::丆丁世七丙丝丕丙世()));
        }
        private void OnDestroy()
        {
            I2.Loc.丗丈下丕丟丟丙七丞.丑丘丆丘世丕丌专七(丙业与丙丗丝不丈东:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.InventoryItemModuleChestInfo::世三丐丈东丅丄丈上()));
        }
        private void 且七丞且丅一三丕丌(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌)
        {
            this.丙丑丘业丕丗丗不丘();
        }
        private void 丄丐东且丁丟七东不(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)
        {
            this.丙丑丘业丕丗丗不丘();
        }
        private void 丆丁世七丙丝丕丙世()
        {
            this.丙丑丘业丕丗丗不丘();
        }
        public override void Setup(PGCompany.丗丟丄丈东丝丕丄世 与且专丈不万东一万)
        {
            if(与且专丈不万东一万 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            丐东不丅丂丂丅丙不.不与丁丁世不七丙世();
            mem[1152921555531238144] = 与且专丈不万东一万;
            this.上丁丗丐丝丛丝世丂 = (null == null) ? 与且专丈不万东一万 : 0;
            this.gameObject.SetActive(value:  true);
        }
        protected override void UpdateView()
        {
            if(this.上丁丗丐丝丛丝世丂 == null)
            {
                    return;
            }
            
            this.UpdateView();
            this.propertiesLayout.世业丒万丘丆专丘丐();
            ModuleChestData val_1 = this.上丁丗丐丝丛丝世丂.丁且七专七丗上与丑();
            PropertyUI val_3 = this.propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  "ModuleChest_AllModulesCount", 丟丒丏丛三丟丑丗丝:  "ModuleChest_Property_AllModulesCount", 丌丒丝东丌下丕丁丅:  val_1.modulesCount.ToString(), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            ModuleChestData val_4 = this.上丁丗丐丝丛丝世丂.丁且七专七丗上与丑();
            PropertyUI val_6 = this.propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  "ModuleChest_TypeModulesCount", 丟丒丏丛三丟丑丗丝:  "ModuleChest_Property_ModuleTypesCount", 丌丒丝东丌下丕丁丅:  val_4.modulesTypesCount.ToString(), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            ModuleChestData val_7 = this.上丁丗丐丝丛丝世丂.丁且七专七丗上与丑();
            PropertyUI val_9 = this.propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  "shop_stats_coin", 丟丒丏丛三丟丑丗丝:  "Key_0275", 丌丒丝东丌下丕丁丅:  val_7.currencyReward.ToString(), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            this.maxOpenTime.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.上丁丗丐丝丛丝世丂.丑丞一丘万丘丗业丘(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            this.丙丑丘业丕丗丗不丘();
        }
        private void 丙丑丘业丕丗丗不丘()
        {
            this.startOpenButton.gameObject.SetActive(value:  false);
            this.openNowButton.gameObject.SetActive(value:  false);
            this.canOpenButton.gameObject.SetActive(value:  false);
            this.maxOpenTime.gameObject.SetActive(value:  false);
            this.openNowItemPriceUI.gameObject.SetActive(value:  false);
            this.丌丏丒丐丙丂丑丙专();
            if(this.上丁丗丐丝丛丝世丂 == null)
            {
                    return;
            }
            
            if(丐东不丅丂丂丅丙不.丑业丝丛丅丐丙丙上() > 0)
            {
                    if(this.上丁丗丐丝丛丝世丂.丅丙丛丑丌丆丌丕丒() == 丐东不丅丂丂丅丙不.丑业丝丛丅丐丙丙上())
            {
                    if(丐东不丅丂丂丅丙不.丏丑丑一丌丅丂丅丘() <= 0)
            {
                goto label_21;
            }
            
            }
            
                this.openNowButton.gameObject.SetActive(value:  true);
                this.openNowItemPriceUI.gameObject.SetActive(value:  true);
                this.丕下丛丗丑业丌且丑();
                return;
            }
            
            this.startOpenButton.gameObject.SetActive(value:  true);
            UnityEngine.GameObject val_13 = this.maxOpenTime.gameObject;
            goto label_29;
            label_21:
            label_29:
            this.canOpenButton.gameObject.SetActive(value:  true);
        }
        private void 丕下丛丗丑业丌且丑()
        {
            if(this.上丁丗丐丝丛丝世丂 == null)
            {
                    return;
            }
            
            this.openNowItemPriceUI.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  丐东不丅丂丂丅丙不.且丁不丟丗丘东丘世(上丁丗丐丝丛丝世丂:  this.上丁丗丐丝丛丝世丂));
        }
        public void OnStartOpenPressed()
        {
            var val_3;
            var val_4;
            丐东不丅丂丂丅丙不.丕丂丐丄一世丌丏丗(上丁丗丐丝丛丝世丂:  this.上丁丗丐丝丛丝世丂);
            业丈不上丟万一丕丏.丑七不且上丗丁一世().且七丞且丅一三丕丌();
            val_3 = null;
            val_3 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丟丙且丝万与不丑丐();
        }
        public void OnOpenNowPressed()
        {
            丐东不丅丂丂丅丙不.丆专丑万丒丙丂丞丌(上丁丗丐丝丛丝世丂:  this.上丁丗丐丝丛丝世丂, 丁七丏丝专丞丄丄丈:  0);
        }
        private void 丛丟丞丆丏丕丛丕丄()
        {
            if(this.不丐丛丙世上丑丂丈 != null)
            {
                    return;
            }
            
            this.不丐丛丙世上丑丂丈 = this.StartCoroutine(routine:  this.且丈丏业丞与七丁业());
        }
        private void 世丗丑丌丒上丛丐丄()
        {
            if(this.不丐丛丙世上丑丂丈 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.不丐丛丙世上丑丂丈);
            this.不丐丛丙世上丑丂丈 = 0;
        }
        private System.Collections.IEnumerator 且丈丏业丞与七丁业()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new InventoryItemModuleChestInfo.丗万丗丕丛一丕丌与();
        }
        public InventoryItemModuleChestInfo()
        {
            MoonSharp.Interpreter.TablePair val_1 = new MoonSharp.Interpreter.TablePair(key:  -9223372036854775808, val:  System.String.alignConst);
            this.丌东丒不三丑东丟丁 = val_1.key;
            mem[1152921555532689184] = val_1.value;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
