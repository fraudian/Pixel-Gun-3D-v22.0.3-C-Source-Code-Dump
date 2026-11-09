using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal abstract class AbstractTlsContext : TlsContext
    {
        // Fields
        private static long counter;
        private readonly Org.BouncyCastle.Crypto.Prng.IRandomGenerator mNonceRandom;
        private readonly Org.BouncyCastle.Security.SecureRandom mSecureRandom;
        private readonly Org.BouncyCastle.Crypto.Tls.SecurityParameters mSecurityParameters;
        private Org.BouncyCastle.Crypto.Tls.ProtocolVersion mClientVersion;
        private Org.BouncyCastle.Crypto.Tls.ProtocolVersion mServerVersion;
        private Org.BouncyCastle.Crypto.Tls.TlsSession mSession;
        private object mUserObject;
        
        // Properties
        public virtual Org.BouncyCastle.Crypto.Prng.IRandomGenerator NonceRandomGenerator { get; }
        public virtual Org.BouncyCastle.Security.SecureRandom SecureRandom { get; }
        public virtual Org.BouncyCastle.Crypto.Tls.SecurityParameters SecurityParameters { get; }
        public abstract bool IsServer { get; }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion { get; }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion ServerVersion { get; }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsSession ResumableSession { get; }
        public virtual object UserObject { get; set; }
        
        // Methods
        private static long NextCounterValue()
        {
            null = null;
            return System.Threading.Interlocked.Increment(location: ref  void* val_1 = Org.BouncyCastle.Crypto.Tls.AbstractTlsContext.__il2cppRuntimeField_static_fields);
        }
        internal AbstractTlsContext(Org.BouncyCastle.Security.SecureRandom secureRandom, Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters)
        {
            var val_12;
            var val_14;
            var val_16;
            val_1 = new System.Object();
            Org.BouncyCastle.Crypto.IDigest val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  4);
            var val_12 = 0;
            val_12 = val_12 + 1;
            int val_4 = val_2.GetDigestSize();
            Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator val_6 = new Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator(digest:  val_2);
            this.mNonceRandom = val_6;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = 1;
            val_14 = public System.Void Org.BouncyCastle.Crypto.Prng.IRandomGenerator::AddSeedMaterial(long seed);
            val_6.AddSeedMaterial(seed:  Org.BouncyCastle.Crypto.Tls.AbstractTlsContext.NextCounterValue());
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = 1;
            val_16 = public System.Void Org.BouncyCastle.Crypto.Prng.IRandomGenerator::AddSeedMaterial(long seed);
            this.mNonceRandom.AddSeedMaterial(seed:  Org.BouncyCastle.Utilities.Times.NanoTime());
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = 0;
            this.mNonceRandom.AddSeedMaterial(seed:  new byte[0]);
            this.mSecureRandom = secureRandom;
            this.mSecurityParameters = val_1;
        }
        public virtual Org.BouncyCastle.Crypto.Prng.IRandomGenerator get_NonceRandomGenerator()
        {
            return (Org.BouncyCastle.Crypto.Prng.IRandomGenerator)this.mNonceRandom;
        }
        public virtual Org.BouncyCastle.Security.SecureRandom get_SecureRandom()
        {
            return (Org.BouncyCastle.Security.SecureRandom)this.mSecureRandom;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.SecurityParameters get_SecurityParameters()
        {
            return (Org.BouncyCastle.Crypto.Tls.SecurityParameters)this.mSecurityParameters;
        }
        public abstract bool get_IsServer(); // 0
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ClientVersion()
        {
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)this.mClientVersion;
        }
        internal virtual void SetClientVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion)
        {
            this.mClientVersion = clientVersion;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ServerVersion()
        {
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)this.mServerVersion;
        }
        internal virtual void SetServerVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion)
        {
            this.mServerVersion = serverVersion;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsSession get_ResumableSession()
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsSession)this.mSession;
        }
        internal virtual void SetResumableSession(Org.BouncyCastle.Crypto.Tls.TlsSession session)
        {
            this.mSession = session;
        }
        public virtual object get_UserObject()
        {
            return (object)this.mUserObject;
        }
        public virtual void set_UserObject(object value)
        {
            this.mUserObject = value;
        }
        public virtual byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length)
        {
            var val_6;
            var val_7;
            int val_8;
            var val_9;
            if(context_value != null)
            {
                    if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint16(i:  context_value.Length)) == false)
            {
                goto label_4;
            }
            
            }
            
            if(this == null)
            {
                goto label_7;
            }
            
            label_17:
            val_6 = this.mSecureRandom + this.mSecureRandom;
            if(context_value != null)
            {
                    int val_5 = context_value.Length;
                val_5 = val_6 + val_5;
                val_6 = val_5 + 2;
            }
            
            byte[] val_2 = new byte[0];
            System.Array.Copy(sourceArray:  this, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  this.mSecureRandom);
            val_7 = 0;
            System.Array.Copy(sourceArray:  this, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  this.mSecureRandom, length:  this.mSecureRandom);
            val_8 = this.mSecureRandom + this.mSecureRandom;
            if(context_value != null)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  context_value.Length, buf:  val_2, offset:  val_8);
                val_8 = val_8 + 2;
                val_7 = 0;
                System.Array.Copy(sourceArray:  context_value, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  val_8, length:  context_value.Length);
                val_8 = val_8 + context_value.Length;
            }
            
            if(val_8 != val_6)
            {
                goto label_13;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context:  this, secret:  this, asciiLabel:  asciiLabel, seed:  val_2, size:  length);
            label_7:
            if(this != null)
            {
                goto label_17;
            }
            
            goto label_17;
            label_13:
            System.InvalidOperationException val_3 = null;
            val_9 = val_3;
            val_3 = new System.InvalidOperationException(message:  "error in calculation of seed for export");
            goto label_18;
            label_4:
            System.ArgumentException val_4 = null;
            val_9 = val_4;
            val_4 = new System.ArgumentException(message:  "must have length less than 2^16 (or be null)", paramName:  "context_value");
            label_18:
        }
        private static AbstractTlsContext()
        {
            Org.BouncyCastle.Crypto.Tls.AbstractTlsContext.counter = Org.BouncyCastle.Utilities.Times.NanoTime();
        }
    
    }

}
