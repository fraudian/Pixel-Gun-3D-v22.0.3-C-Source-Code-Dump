using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class TlsSessionImpl : TlsSession
    {
        // Fields
        internal readonly byte[] mSessionID;
        internal Org.BouncyCastle.Crypto.Tls.SessionParameters mSessionParameters;
        
        // Properties
        public virtual byte[] SessionID { get; }
        public virtual bool IsResumable { get; }
        
        // Methods
        internal TlsSessionImpl(byte[] sessionID, Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters)
        {
            var val_5;
            val_1 = new System.Object();
            if(sessionID == null)
            {
                goto label_1;
            }
            
            int val_5 = sessionID.Length;
            val_5 = val_5 - 1;
            if(val_5 >= 32)
            {
                goto label_2;
            }
            
            this.mSessionID = Org.BouncyCastle.Utilities.Arrays.Clone(data:  sessionID);
            this.mSessionParameters = val_1;
            return;
            label_1:
            System.ArgumentNullException val_3 = null;
            val_5 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  "sessionID");
            goto label_3;
            label_2:
            System.ArgumentException val_4 = null;
            val_5 = val_4;
            val_4 = new System.ArgumentException(message:  "must have length between 1 and 32 bytes, inclusive", paramName:  "sessionID");
            label_3:
        }
        public virtual Org.BouncyCastle.Crypto.Tls.SessionParameters ExportSessionParameters()
        {
            var val_3;
            var val_4;
            var val_5;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            if(this.mSessionParameters != null)
            {
                    val_3 = this.mSessionParameters.Copy();
                val_4 = 0;
                val_5 = 0;
            }
            else
            {
                    val_4 = 0;
                val_5 = 0;
                val_3 = 0;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(val_4 != 1)
            {
                    return (Org.BouncyCastle.Crypto.Tls.SessionParameters)val_3;
            }
            
            if(val_5 == 0)
            {
                    return (Org.BouncyCastle.Crypto.Tls.SessionParameters)val_3;
            }
            
            return (Org.BouncyCastle.Crypto.Tls.SessionParameters)val_3;
        }
        public virtual byte[] get_SessionID()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])this.mSessionID;
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])this.mSessionID;
            }
            
            return (System.Byte[])this.mSessionID;
        }
        public virtual void Invalidate()
        {
            var val_2;
            var val_3;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            if(this.mSessionParameters != null)
            {
                    if(this.mSessionParameters.mMasterSecret != null)
            {
                    Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.mSessionParameters.mMasterSecret, b:  0);
            }
            
                val_2 = 0;
                val_3 = 0;
                this.mSessionParameters = 0;
            }
            else
            {
                    val_2 = 0;
                val_3 = 0;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(val_2 != 1)
            {
                    return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
        
        }
        public virtual bool get_IsResumable()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(0 != 1)
            {
                    return (bool)(this.mSessionParameters != 0) ? 1 : 0;
            }
            
            if(0 == 0)
            {
                    return (bool)(this.mSessionParameters != 0) ? 1 : 0;
            }
            
            return (bool)(this.mSessionParameters != 0) ? 1 : 0;
        }
    
    }

}
