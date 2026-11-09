using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丝丄丄不丏丘丝世丗 : IDisposable
    {
        // Fields
        private readonly System.Action 丄丐且丂上丒丑专丂;
        private bool 丄上丈丝丒七丂下东;
        
        // Methods
        public 丝丄丄不丏丘丝世丗(System.Action 七丐丅专且专七三丆)
        {
            this.丄丐且丂上丒丑专丂 = 七丐丅专且专七三丆;
        }
        public void Dispose()
        {
            if(this.丄上丈丝丒七丂下东 == true)
            {
                    return;
            }
            
            if(this.丄丐且丂上丒丑专丂 != null)
            {
                    this.丄丐且丂上丒丑专丂.Invoke();
            }
            
            this.丄上丈丝丒七丂下东 = true;
        }
    
    }

}
