using UnityEngine;

namespace Rilisoft
{
    internal sealed class LobbyCraftSpeedUpButton : MonoBehaviour
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
        private UnityEngine.GameObject _objInternetDisabled;
        internal static Rilisoft.LobbyCraftSpeedUpButton 丆丕丝丒不丙且丐丗;
        
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
            if(Rilisoft.LobbyCraftSpeedUpButton.丆丕丝丒不丙且丐丗 != 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Rilisoft.LobbyCraftSpeedUpButton.丆丕丝丒不丙且丐丗 = this;
        }
        private void OnEnable()
        {
            UILabel val_17;
            this._container.SetActive(value:  false);
            Rilisoft.LobbyItemsController val_1 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if((val_1.<丛上丟丏与丕丒东丂>k__BackingField) != null)
            {
                    Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
                this.丘丐丟丑丈丗丟专下(万且万且丑丗且丌丆:  0);
            }
            
            this._buttonSpeedUpGems.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::七丅七不丈一一丄世()));
            this._buttonSpeedUpVideo.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丅丕东丌丟丛万世丁()));
            this._buttonSpeedUpGemsGeneral.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::七丅七不丈一一丄世()));
            Rilisoft.LobbyItemsController.丏丏与一丁丄世世万(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丘丐丟丑丈丗丟专下(Rilisoft.丏丘七丞丄丙丌丞丁 万且万且丑丗且丌丆)));
            Rilisoft.LobbyItemsController.专丏业且丙丆丁且丈(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丝与丟丕且丈丙且上(Rilisoft.丏丘七丞丄丙丌丞丁 万且万且丑丗且丌丆)));
            val_17 = 1152921505072021504;
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丞万专丒丁丒丅丙丆()));
            if(Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世() != 0)
            {
                    val_17 = Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世();
                int val_13 = val_17.GetReward();
                if(val_13 != 1)
            {
                    val_17 = this._buttonSpeedUpVideoLabel;
                val_17.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4044"), arg0:  val_13);
            }
            
            }
            
            UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.丑丈世与丙东丆丌七());
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
            this._buttonSpeedUpGems.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::七丅七不丈一一丄世()));
            this._buttonSpeedUpGemsGeneral.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::七丅七不丈一一丄世()));
            this._buttonSpeedUpVideo.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丅丕东丌丟丛万世丁()));
            Rilisoft.LobbyItemsController.与丌丌丒丘丅一丒上(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丘丐丟丑丈丗丟专下(Rilisoft.丏丘七丞丄丙丌丞丁 万且万且丑丗且丌丆)));
            Rilisoft.LobbyItemsController.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丝与丟丕且丈丙且上(Rilisoft.丏丘七丞丄丙丌丞丁 万且万且丑丗且丌丆)));
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftSpeedUpButton::丞万专丒丁丒丅丙丆()));
            this.StopCoroutine(routine:  this.丑丈世与丙东丆丌七());
        }
        private void 七丅七不丈一一丄世()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丐丑丑丝丂丁丗丘丗();
        }
        private void 丅丕东丌丟丛万世丁()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.专七丕业七丞丁丆丟();
        }
        private void 丘丐丟丑丈丗丟专下(Rilisoft.丏丘七丞丄丙丌丞丁 万且万且丑丗且丌丆)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_19;
            object val_20;
            val_19 = 1152921504848912384;
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) == 0)
            {
                goto label_3;
            }
            
            if(this.丆下世世丟七专丞丒() == 0)
            {
                goto label_7;
            }
            
            Rilisoft.LobbyItemsController val_7 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            val_19 = val_7.<丛上丟丏与丕丒东丂>k__BackingField;
            if((System.String.op_Inequality(a:  this.丆下世世丟七专丞丒().name, b:  val_19.丆丗丒丌且专丒丘七())) == false)
            {
                goto label_12;
            }
            
            label_7:
            Rilisoft.LobbyItemsController val_10 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            this._nameTextGroup.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_10.<丛上丟丏与丕丒东丂>k__BackingField.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
            UIBasicSprite val_14 = this.丆下世世丟七专丞丒();
            Rilisoft.LobbyItemsController val_15 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            val_19 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_15.<丛上丟丏与丕丒东丂>k__BackingField.丙三专万丛丟万丝丘());
            val_20 = "TextureUpdated On CraftStarted";
            goto label_24;
            label_12:
            val_20 = "Texture not Updated On CraftStarted";
            label_24:
            UnityEngine.Debug.Log(message:  val_20);
            label_3:
            if(this._container.activeInHierarchy != false)
            {
                    return;
            }
            
            this._container.SetActive(value:  true);
        }
        private void 丝与丟丕且丈丙且上(Rilisoft.丏丘七丞丄丙丌丞丁 万且万且丑丗且丌丆)
        {
            this.一丅万三丛不七丝丞();
            this._container.SetActive(value:  false);
        }
        private void 丞万专丒丁丒丅丙丆()
        {
            Rilisoft.LobbyItemsController val_1 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if((val_1.<丛上丟丏与丕丒东丂>k__BackingField) == null)
            {
                    return;
            }
            
            Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            this._nameTextGroup.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_2.<丛上丟丏与丕丒东丂>k__BackingField.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
        }
        internal System.Collections.IEnumerator 丑丈世与丙东丆丌七()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyCraftSpeedUpButton.万与世丄丈丌丐丑丄();
        }
        public LobbyCraftSpeedUpButton()
        {
        
        }
        private static LobbyCraftSpeedUpButton()
        {
        
        }
    
    }

}
