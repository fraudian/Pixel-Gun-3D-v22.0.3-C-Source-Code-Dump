using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    internal abstract class LimitedInputStream : BaseInputStream
    {
        // Fields
        protected readonly System.IO.Stream _in;
        private int _limit;
        
        // Methods
        internal LimitedInputStream(System.IO.Stream inStream, int limit)
        {
            this._in = inStream;
            this._limit = limit;
        }
        internal virtual int GetRemaining()
        {
            return (int)this._limit;
        }
        protected virtual void SetParentEofDetect(bool on)
        {
            if(this._in == null)
            {
                    return;
            }
            
            mem2[0] = on;
            if(on == false)
            {
                    return;
            }
            
            bool val_2 = this._in.CheckForEof();
        }
    
    }

}
