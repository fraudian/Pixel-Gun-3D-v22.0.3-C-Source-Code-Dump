using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanWarWindowRegError : PGBehaviour
    {
        // Fields
        private UILabel textLabel;
        private System.IDisposable 丙丁下丂丄三东丘丝;
        
        // Methods
        internal void 丒丁丅一下丂专万不(string 丕丗丘丑丛与丑业丒)
        {
            if(this.textLabel == 0)
            {
                    return;
            }
            
            this.textLabel.text = 丕丗丘丑丛与丑业丒;
        }
        public void U_Close()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        private void OnEnable()
        {
            if(this.丙丁下丂丄三东丘丝 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丙丁下丂丄三东丘丝.Dispose();
            }
            
            this.丙丁下丂丄三东丘丝 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanWarWindowRegError::U_Close()), 与且专丈不万东一万:  this.GetType());
        }
        private void OnDisable()
        {
            if(this.丙丁下丂丄三东丘丝 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丙丁下丂丄三东丘丝.Dispose();
        }
        public ClanWarWindowRegError()
        {
        
        }
    
    }

}
