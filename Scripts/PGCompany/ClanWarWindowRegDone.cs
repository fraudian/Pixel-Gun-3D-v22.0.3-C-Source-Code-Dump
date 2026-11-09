using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanWarWindowRegDone : PGBehaviour
    {
        // Fields
        private PGCompany.TimerUI _timer;
        private System.IDisposable 东三世丝丒三一丈丛;
        
        // Methods
        private void OnEnable()
        {
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanWarWindowRegDone::U_Close()), 与且专丈不万东一万:  "ClanWarWindowRegDone_" + this.gameObject.name);
        }
        private void OnDisable()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        internal void 丈且东丑丂且万丒丅(int 丛万不丘七丐丗丙三)
        {
            if(丛万不丘七丐丗丙三 > 0)
            {
                    this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  丛万不丘七丐丗丙三, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timer, 丏业丟一东丂东丘丛:  false);
        }
        public void U_Close()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public ClanWarWindowRegDone()
        {
        
        }
    
    }

}
