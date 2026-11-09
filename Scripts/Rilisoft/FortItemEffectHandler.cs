using UnityEngine;

namespace Rilisoft
{
    public abstract class FortItemEffectHandler : MonoBehaviour
    {
        // Fields
        private string _fortItemId;
        private Rilisoft.东且东丒丐世丐丞丒 <丐丒丅丒一丅七丐一>k__BackingField;
        
        // Properties
        protected Rilisoft.东且东丒丐世丐丞丒 东且东丒丐世丐丞丒 { get; set; }
        protected string 一丒不丑丐丛丂丒世 { get; }
        
        // Methods
        protected Rilisoft.东且东丒丐世丐丞丒 上一世业下上丒丙丂()
        {
            return (Rilisoft.东且东丒丐世丐丞丒)this.<丐丒丅丒一丅七丐一>k__BackingField;
        }
        private void 丙丟与且丗不七丈丘(Rilisoft.东且东丒丐世丐丞丒 丙业与丙丗丝不丈东)
        {
            this.<丐丒丅丒一丅七丐一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected string 世专与三丛丟丞一丐()
        {
            if((this.<丐丒丅丒一丅七丐一>k__BackingField) == null)
            {
                    return (string)this.<丐丒丅丒一丅七丐一>k__BackingField;
            }
            
            return System.String.Format(format:  "fort_item_effect_{0}", arg0:  this.<丐丒丅丒一丅七丐一>k__BackingField.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七());
        }
        public void Initialize(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘)
        {
            if(三丐业七丘丂丐下丘 != null)
            {
                    this.<丐丒丅丒一丅七丐一>k__BackingField = 三丐业七丘丂丐下丘;
                this._fortItemId = 三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七();
            }
            else
            {
                    System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "FortItemEffectHandler.Inicialize fail: fortItem is null");
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
            
            InfoWindowController.七丏不丕丈丁丗丒不(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFD700]{0}[-]", arg0:  this.<丐丒丅丒一丅七丐一>k__BackingField.丙丕丞且丕不丘丙丑().东丙上东业丆不丟丘()), 世丙丁丗业丝世丕丈:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3806"), arg0:  上丒丆丆丞且丐丆七), 不且丁丐不丌丟上丌:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.<丐丒丅丒一丅七丐一>k__BackingField.丙三专万丛丟万丝丘())), 不上丏上丝丆一丛丑:  0);
        }
        protected FortItemEffectHandler()
        {
            this._fortItemId = "not setted";
        }
    
    }

}
