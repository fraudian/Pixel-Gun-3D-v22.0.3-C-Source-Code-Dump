using UnityEngine;

namespace Rilisoft
{
    public abstract class LobbyItemEffectHandler : MonoBehaviour
    {
        // Fields
        private string _lobbyItemId;
        private Rilisoft.丏丘七丞丄丙丌丞丁 <丑丗丆上丄丁三丏丅>k__BackingField;
        
        // Properties
        protected Rilisoft.丏丘七丞丄丙丌丞丁 丏丘七丞丄丙丌丞丁 { get; set; }
        protected string 一丒不丑丐丛丂丒世 { get; }
        
        // Methods
        protected Rilisoft.丏丘七丞丄丙丌丞丁 东上专丑丏丞上丞丐()
        {
            return (Rilisoft.丏丘七丞丄丙丌丞丁)this.<丑丗丆上丄丁三丏丅>k__BackingField;
        }
        private void 丏东专专丌业业丌丑(Rilisoft.丏丘七丞丄丙丌丞丁 丙业与丙丗丝不丈东)
        {
            this.<丑丗丆上丄丁三丏丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected string 世专与三丛丟丞一丐()
        {
            if((this.<丑丗丆上丄丁三丏丅>k__BackingField) == null)
            {
                    return (string)this.<丑丗丆上丄丁三丏丅>k__BackingField;
            }
            
            return System.String.Format(format:  "lobby_item_effect_{0}", arg0:  this.<丑丗丆上丄丁三丏丅>k__BackingField.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七());
        }
        public void Initialize(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            if(丑丘丕且丆东丏丘丙 != null)
            {
                    this.<丑丗丆上丄丁三丏丅>k__BackingField = 丑丘丕且丆东丏丘丙;
                this._lobbyItemId = 丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            }
            else
            {
                    System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "LobbyItemEffectHandler.Inicialize fail: lobbyItem is null");
            }
        
        }
        public virtual void Remove()
        {
        
        }
        protected virtual void 丈且东丑丂且万丒丅()
        {
        
        }
        protected virtual void Awake()
        {
        
        }
        protected virtual void OnEnable()
        {
        
        }
        protected virtual void Start()
        {
        
        }
        protected virtual void OnDisable()
        {
        
        }
        protected void 不丒丂丕丅丌世专三(string 上丒丆丆丞且丐丆七)
        {
            if(InfoWindowController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            InfoWindowController.七丏不丕丈丁丗丒不(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFD700]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.<丑丗丆上丄丁三丏丅>k__BackingField.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐())), 世丙丁丗业丝世丕丈:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3806"), arg0:  上丒丆丆丞且丐丆七), 不且丁丐不丌丟上丌:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.<丑丗丆上丄丁三丏丅>k__BackingField.丙三专万丛丟万丝丘())), 不上丏上丝丆一丛丑:  0);
        }
        protected LobbyItemEffectHandler()
        {
            this._lobbyItemId = "not setted";
        }
    
    }

}
