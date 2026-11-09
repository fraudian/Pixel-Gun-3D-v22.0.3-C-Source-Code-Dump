using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丝丟丄丅与业世专丈 : IDisposable
    {
        // Fields
        private readonly System.Diagnostics.Stopwatch 丏下丞丑丗业且丟且;
        private readonly string 三丈丌专丁七丟且下;
        private readonly bool 且丄丁丌丒不不丗专;
        
        // Methods
        public 丝丟丄丅与业世专丈(string 丕丗丘丑丛与丑业丒, bool 丘丏与丒丗下丌世丐)
        {
            string val_4 = 丕丗丘丑丛与丑业丒;
            this.且丄丁丌丒不不丗专 = 丘丏与丒丗下丌世丐;
            if(val_4 == null)
            {
                    val_4 = System.String.alignConst;
            }
            
            this.三丈丌专丁七丟且下 = val_4;
            if(丘丏与丒丗下丌世丐 != false)
            {
                    UnityEngine.Debug.Log(message:  System.String.Format(format:  "{0}: started.", arg0:  val_4));
            }
            
            this.丏下丞丑丗业且丟且 = System.Diagnostics.Stopwatch.StartNew();
        }
        public 丝丟丄丅与业世专丈(string 丕丗丘丑丛与丑业丒)
        {
        
        }
        public void Dispose()
        {
            this.丏下丞丑丗业且丟且.Stop();
            if(this.且丄丁丌丒不不丗专 == false)
            {
                    return;
            }
            
            this = System.String.Format(format:  "{0}: finished at {1:0.00}", arg0:  this.三丈丌专丁七丟且下, arg1:  this.丏下丞丑丗业且丟且.ElapsedMilliseconds);
            UnityEngine.Debug.Log(message:  this);
        }
    
    }

}
