using UnityEngine;

namespace PGCompany
{
    internal class InventoryItemModuleInfo : InventoryItemInfo
    {
        // Fields
        private PGCompany.丏丂一丗丙世丏丐三 丙丄七万三丁丆丅丅;
        private PropertiesLayout propertiesLayout;
        public UnityEngine.GameObject _upgradeButton;
        private CurrencyUI _upgradePriceUI;
        private UISprite _propertySprite;
        public UnityEngine.GameObject _insertButtonL;
        public UnityEngine.GameObject _insertButtonR;
        
        // Methods
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
            
            mem[1152921555533531536] = 与且专丈不万东一万;
            this.丙丄七万三丁丆丅丅 = 与且专丈不万东一万;
            this.gameObject.SetActive(value:  true);
        }
        protected override void UpdateView()
        {
            float val_24;
            float val_25;
            string val_26;
            this.UpdateView();
            this.propertiesLayout.世业丒万丘丆专丘丐();
            string val_2 = PGCompany.七丆丆丕丂丙丕丐丂.世丗丘丙丘丛丛一丟(丕上业丕丘上丘七一:  this.丙丄七万三丁丆丅丅, 不丗丐丘业专丂丝上:  this._propertySprite.atlas);
            if(this.丙丄七万三丁丆丅丅.丙丅丗丏丆丆世世丙() == false)
            {
                goto label_4;
            }
            
            if(this.丙丄七万三丁丆丅丅.七丂丅丗丂丏三丂三() == null)
            {
                goto label_8;
            }
            
            val_24 = val_4.Modificator;
            val_25 = val_24;
            goto label_9;
            label_4:
            val_26 = this.丙丄七万三丁丆丅丅.丅业专丏不丒丄丐一();
            PropertyUI val_9 = this.propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  val_2, 丟丒丏丛三丟丑丗丝:  this.丙丄七万三丁丆丅丅.业丙与世东丑丈丐万(), 丌丒丝东丌下丕丁丅:  val_26, 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            goto label_13;
            label_8:
            val_25 = 1.68059E-38f;
            val_24 = 1.68059E-38f;
            label_9:
            float val_10 = this.丙丄七万三丁丆丅丅.丞万丆丑且丟丑专丟();
            val_26 = this.丙丄七万三丁丆丅丅.丅七丑与丆丞丝且丟();
            PropertyUI val_13 = this.propertiesLayout.与丘丌业丗上下上世(丛丐丌丙丈七丛丛东:  val_2, 丟丒丏丛三丟丑丗丝:  this.丙丄七万三丁丆丅丅.业丙与世东丑丈丐万(), 丛丌丏专万业丞上丛:  this.丙丄七万三丁丆丅丅.丞万丆丑且丟丑专丟(), 三上七丑东丅业东丁:  val_25, 丆丝七丕丘七丝丁三:  0f, 丕丛丂丞世丁丐丌专:  (val_24 < 0) ? 1 : 0, 业丙丐丑丘世一一丏:  val_26);
            label_13:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._upgradeButton, 丏业丟一东丂东丘丛:  PGCompany.七丆丆丕丂丙丕丐丂.七东丆丙东丂三世三(丕上业丕丘上丘七一:  this.丙丄七万三丁丆丅丅));
            丙且上东下丏丏丟下 val_16 = PGCompany.七丆丆丕丂丙丕丐丂.丆丒上丗一丙一三丕();
            UnityEngine.GameObject val_23 = this._upgradeButton;
            val_23 = ((val_16 != 0) ? 1 : 0) & val_23.activeSelf ^ 1;
            this._insertButtonR.SetActive(value:  val_23);
            bool val_20 = (val_16 != 0) ? 1 : 0;
            val_20 = val_20 & this._upgradeButton.activeSelf;
            this._insertButtonL.SetActive(value:  val_20);
            this._upgradePriceUI.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  this.丙丄七万三丁丆丅丅.且与丏三不丟丂丙丏());
        }
        public void UpgradeModule()
        {
            if((PGCompany.七丆丆丕丂丙丕丐丂.七东丆丙东丂三世三(丕上业丕丘上丘七一:  this.丙丄七万三丁丆丅丅)) == false)
            {
                    return;
            }
            
            PGCompany.七丆丆丕丂丙丕丐丂.丑丌万三丄丞专三丝(丕上业丕丘上丘七一:  this.丙丄七万三丁丆丅丅, 丁七丏丝专丞丄丄丈:  0);
            goto typeof(PGCompany.InventoryItemModuleInfo).__il2cppRuntimeField_198;
        }
        public InventoryItemModuleInfo()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
