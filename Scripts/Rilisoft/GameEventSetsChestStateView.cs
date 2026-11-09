using UnityEngine;

namespace Rilisoft
{
    public class GameEventSetsChestStateView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.与专丒丞丐一丒丂东>
    {
        // Fields
        private Rilisoft.与专丒丞丐一丒丂东 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private UnityEngine.GameObject _active;
        private UnityEngine.GameObject _collected;
        private UISprite _icon;
        
        // Properties
        public Rilisoft.与专丒丞丐一丒丂东 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public Rilisoft.与专丒丞丐一丒丂东 get_Context()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.与专丒丞丐一丒丂东 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_14;
            UnityEngine.GameObject val_15;
            string val_16;
            UISprite val_17;
            string val_18;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._active, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._collected, 丏业丟一东丂东丘丛:  false);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.七丝丝丈七三丝丘一()) != true)
            {
                    if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丒世业三丘丝不下丕()) == false)
            {
                goto label_6;
            }
            
            }
            
            val_14 = null;
            val_15 = this._collected;
            goto label_10;
            label_6:
            val_14 = null;
            val_15 = this._active;
            label_10:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  true);
            if(this._icon == 0)
            {
                    return;
            }
            
            三丅丁丗丗丝丂万且 val_5 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅三专且丈一丝丂丏());
            if(val_5 == null)
            {
                goto label_17;
            }
            
            if((val_5.万上丄下业丛丌不丈() - 2) > 4)
            {
                goto label_18;
            }
            
            val_16 = mem[130691232 + ((val_6 - 2)) << 3];
            val_16 = 130691232 + ((val_6 - 2)) << 3;
            goto label_19;
            label_17:
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅三专且丈一丝丂丏())) != true)
            {
                    if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅三专且丈一丝丂丏())) == false)
            {
                    return;
            }
            
            }
            
            val_17 = this._icon;
            val_18 = "achievement_armadillo";
            goto label_31;
            label_18:
            val_16 = "achievement_soldier";
            label_19:
            val_18 = val_16;
            label_31:
            this._icon.spriteName = val_18;
        }
        public GameEventSetsChestStateView()
        {
        
        }
    
    }

}
