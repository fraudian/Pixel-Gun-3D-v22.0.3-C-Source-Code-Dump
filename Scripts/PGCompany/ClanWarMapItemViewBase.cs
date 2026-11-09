using UnityEngine;

namespace PGCompany
{
    public abstract class ClanWarMapItemViewBase : PGBehaviour
    {
        // Fields
        internal PGCompany.一丏不三且丆专东东 丞丂丄丙丐专与丘丅;
        internal PGCompany.与丐业一丂丗与七丟 丅世丏丙丗丂丌三丒;
        internal PGCompany.丁下丒丕丆下丂丆丌 丐丌丞东上万万丈丂;
        protected UnityEngine.Coroutine 丄三万东丒丙世丕万;
        
        // Methods
        protected abstract void 丙丗世不三丕丄上丂(); // 0
        protected abstract void 丘丛不丕不专丈三世(); // 0
        protected void OnDisable()
        {
            this.三不与万七不丑丏丌();
        }
        protected void 三不与万七不丑丏丌()
        {
            if(this.丄三万东丒丙世丕万 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丄三万东丒丙世丕万);
            this.丄三万东丒丙世丕万 = 0;
        }
        protected void OnDestroy()
        {
            this.三不与万七不丑丏丌();
        }
        protected ClanWarMapItemViewBase()
        {
        
        }
    
    }

}
