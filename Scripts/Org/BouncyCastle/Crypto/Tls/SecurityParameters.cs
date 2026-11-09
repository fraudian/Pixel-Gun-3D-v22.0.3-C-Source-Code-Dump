using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class SecurityParameters
    {
        // Fields
        internal int entity;
        internal int cipherSuite;
        internal byte compressionAlgorithm;
        internal int prfAlgorithm;
        internal int verifyDataLength;
        internal byte[] masterSecret;
        internal byte[] clientRandom;
        internal byte[] serverRandom;
        internal byte[] sessionHash;
        internal byte[] pskIdentity;
        internal byte[] srpIdentity;
        internal short maxFragmentLength;
        internal bool truncatedHMac;
        internal bool encryptThenMac;
        internal bool extendedMasterSecret;
        
        // Properties
        public virtual int Entity { get; }
        public virtual int CipherSuite { get; }
        public byte CompressionAlgorithm { get; }
        public virtual int PrfAlgorithm { get; }
        public virtual int VerifyDataLength { get; }
        public virtual byte[] MasterSecret { get; }
        public virtual byte[] ClientRandom { get; }
        public virtual byte[] ServerRandom { get; }
        public virtual byte[] SessionHash { get; }
        public virtual byte[] PskIdentity { get; }
        public virtual byte[] SrpIdentity { get; }
        
        // Methods
        internal virtual void Clear()
        {
            if(this.masterSecret == null)
            {
                    return;
            }
            
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.masterSecret, b:  0);
            this.masterSecret = 0;
        }
        public virtual int get_Entity()
        {
            return (int)this.entity;
        }
        public virtual int get_CipherSuite()
        {
            return (int)this.cipherSuite;
        }
        public byte get_CompressionAlgorithm()
        {
            return (byte)this.compressionAlgorithm;
        }
        public virtual int get_PrfAlgorithm()
        {
            return (int)this.prfAlgorithm;
        }
        public virtual int get_VerifyDataLength()
        {
            return (int)this.verifyDataLength;
        }
        public virtual byte[] get_MasterSecret()
        {
            return (System.Byte[])this.masterSecret;
        }
        public virtual byte[] get_ClientRandom()
        {
            return (System.Byte[])this.clientRandom;
        }
        public virtual byte[] get_ServerRandom()
        {
            return (System.Byte[])this.serverRandom;
        }
        public virtual byte[] get_SessionHash()
        {
            return (System.Byte[])this.sessionHash;
        }
        public virtual byte[] get_PskIdentity()
        {
            return (System.Byte[])this.pskIdentity;
        }
        public virtual byte[] get_SrpIdentity()
        {
            return (System.Byte[])this.srpIdentity;
        }
        public SecurityParameters()
        {
            this.entity = 0;
            this.cipherSuite = 0;
            this.prfAlgorithm = 0;
            this.verifyDataLength = 0;
            this.maxFragmentLength = 65535;
        }
    
    }

}
