using UnityEngine;

namespace Rilisoft
{
    internal class FortCraftSpeedUpButton : MonoBehaviour
    {
        // Fields
        private float 丙丝七丙丈丑丒丑上;
        private UnityEngine.GameObject _container;
        private Rilisoft.TextGroup _nameTextGroup;
        private UIBasicSprite _texture;
        private Rilisoft.TextGroup _timeLeftTextGroup;
        private Rilisoft.PriceView _buttonSpeedUpGemsGeneral;
        private Rilisoft.PriceView _buttonSpeedUpGems;
        private Rilisoft.PriceView _buttonSpeedUpVideo;
        private UILabel _buttonSpeedUpVideoLabel;
        private UILabel _craftingLabel;
        private UnityEngine.GameObject _objInternetDisabled;
        private UnityEngine.GameObject _loadingCircle;
        internal static Rilisoft.FortCraftSpeedUpButton 丆丕丝丒不丙且丐丗;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        private void Awake()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Rilisoft.FortCraftSpeedUpButton.丆丕丝丒不丙且丐丗 != 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Rilisoft.FortCraftSpeedUpButton.丆丕丝丒不丙且丐丗 = this;
        }
        private void OnEnable()
        {
            var val_21;
            var val_22;
            this._container.SetActive(value:  false);
            this._loadingCircle.SetActive(value:  false);
            this._buttonSpeedUpGems.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::七丅七不丈一一丄世()));
            this._buttonSpeedUpVideo.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丅丕东丌丟丛万世丁()));
            this._buttonSpeedUpGemsGeneral.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::七丅七不丈一一丄世()));
            Rilisoft.FortsManager.专丏业且丙丆丁且丈(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丝与丟丕且丈丙且上(Rilisoft.东且东丒丐世丐丞丒 万且万且丑丗且丌丆, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.FortCraftSpeedUpButton::丞万专丒丁丒丅丙丆()));
            val_21 = 1152921524404748272;
            if(((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
            {
                goto label_17;
            }
            
            val_21 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_21.丁丏丌丟丂丌一七与())) == false)
            {
                goto label_17;
            }
            
            this._buttonSpeedUpGemsGeneral.gameObject.SetActive(value:  true);
            UnityEngine.GameObject val_16 = this._craftingLabel.gameObject;
            val_22 = 0;
            goto label_22;
            label_17:
            this._buttonSpeedUpGemsGeneral.gameObject.SetActive(value:  false);
            val_22 = 1;
            label_22:
            this._craftingLabel.gameObject.SetActive(value:  true);
            UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  this.UpdateUpgradeTimer());
        }
        private void 一丅万三丛不七丝丞()
        {
            if(this.丆下世世丟七专丞丒() == 0)
            {
                    return;
            }
            
            if(this.丆下世世丟七专丞丒() == 0)
            {
                    return;
            }
            
            this = this.丆下世世丟七专丞丒();
            UnityEngine.Resources.UnloadAsset(assetToUnload:  this);
        }
        private void OnDisable()
        {
            this._buttonSpeedUpGems.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::七丅七不丈一一丄世()));
            this._buttonSpeedUpGemsGeneral.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::七丅七不丈一一丄世()));
            this._buttonSpeedUpVideo.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丅丕东丌丟丛万世丁()));
            Rilisoft.FortsManager.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丝与丟丕且丈丙且上(Rilisoft.东且东丒丐世丐丞丒 万且万且丑丗且丌丆, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            PGCompany.Clans.Network.三与丞不下丆且丑世.丟专丐丄丒丘丈与万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.丄三丐上丈且丄丘下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丌上丕丈丛丝三且七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.FortCraftSpeedUpButton::丞万专丒丁丒丅丙丆()));
            this.StopCoroutine(routine:  this.UpdateUpgradeTimer());
        }
        private void 七丅七不丈一一丄世()
        {
            var val_10;
            var val_11;
            val_10 = 1152921524473519280;
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 != false)
            {
                    if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
                this._loadingCircle.SetActive(value:  false);
                return;
            }
            
            }
            
            val_10 = 1152921505448005632;
            val_11 = null;
            val_11 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            this._loadingCircle.SetActive(value:  true);
            PGCompany.Clans.Network.三与丞不下丆且丑世.下丞世丏丐上丑专丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.专业丛万丝丙东丒丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丈且丗丞丕世且丁丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.SpeedUpCraftingItem();
        }
        private void 丅丕东丌丟丛万世丁()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.SpeedUpCraftingItemVideo();
        }
        private void 丝与丟丕且丈丙且上(Rilisoft.东且东丒丐世丐丞丒 万且万且丑丗且丌丆, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            this.一丅万三丛不七丝丞();
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this._container.SetActive(value:  false);
            this._loadingCircle.SetActive(value:  false);
        }
        private void 丞万专丒丁丒丅丙丆()
        {
            Rilisoft.FortsManager val_1 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if((val_1.<丛上丟丏与丕丒东丂>k__BackingField) == null)
            {
                    return;
            }
            
            Rilisoft.FortsManager val_2 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            this._nameTextGroup.Text = val_2.<丛上丟丏与丕丒东丂>k__BackingField.丙丕丞且丕不丘丙丑().东丙上东业丆不丟丘();
        }
        private void 丗丄万丏丟丘与丙丟()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(this.gameObject == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy != false)
            {
                    this._loadingCircle.SetActive(value:  false);
            }
            
            PGCompany.Clans.Network.三与丞不下丆且丑世.丟专丐丄丒丘丈与万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.丄三丐上丈且丄丘下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丌上丕丈丛丝三且七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftSpeedUpButton::丗丄万丏丟丘与丙丟()));
        }
        public System.Collections.IEnumerator UpdateUpgradeTimer()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new FortCraftSpeedUpButton.万与世丄丈丌丐丑丄();
        }
        public FortCraftSpeedUpButton()
        {
        
        }
        private static FortCraftSpeedUpButton()
        {
        
        }
    
    }

}
