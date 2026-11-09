using UnityEngine;

namespace Rilisoft
{
    internal sealed class DialogEscape : MonoBehaviour
    {
        // Fields
        private readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.ButtonHandler> 丗丅丂三且不七丒东;
        private System.IDisposable 且丂七丑丈丞丈三丑;
        private string <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        public string 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public DialogEscape()
        {
            this.丗丅丂三且不七丒东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.ButtonHandler>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.ButtonHandler>(object:  this, method:  public Rilisoft.ButtonHandler UnityEngine.Component::GetComponent<Rilisoft.ButtonHandler>()));
        }
        public string get_Context()
        {
            return (string)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        public void set_Context(string 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void OnEnable()
        {
            if(this.且丂七丑丈丞丈三丑 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.且丂七丑丈丞丈三丑.Dispose();
            }
            
            this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.DialogEscape::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null) ? "Dialog" : this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        private void OnDisable()
        {
            if(this.且丂七丑丈丞丈三丑 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
            this.且丂七丑丈丞丈三丑 = 0;
        }
        private void 丕丈丝丅且丙业丕丆()
        {
            if(this.丗丅丂三且不七丒东.世三丞丅丑丌丈丈一() == 0)
            {
                    return;
            }
            
            this.丗丅丂三且不七丒东.世三丞丅丑丌丈丈一().DoClick();
        }
    
    }

}
