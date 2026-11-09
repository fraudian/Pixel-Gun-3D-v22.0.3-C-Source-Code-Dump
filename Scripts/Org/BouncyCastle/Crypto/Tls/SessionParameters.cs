using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public sealed class SessionParameters
    {
        // Fields
        private int mCipherSuite;
        private byte mCompressionAlgorithm;
        private byte[] mMasterSecret;
        private Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate;
        private byte[] mPskIdentity;
        private byte[] mSrpIdentity;
        private byte[] mEncodedServerExtensions;
        
        // Properties
        public int CipherSuite { get; }
        public byte CompressionAlgorithm { get; }
        public byte[] MasterSecret { get; }
        public Org.BouncyCastle.Crypto.Tls.Certificate PeerCertificate { get; }
        public byte[] PskIdentity { get; }
        public byte[] SrpIdentity { get; }
        
        // Methods
        private SessionParameters(int cipherSuite, byte compressionAlgorithm, byte[] masterSecret, Org.BouncyCastle.Crypto.Tls.Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions)
        {
            val_1 = new System.Object();
            this.mCipherSuite = cipherSuite;
            this.mCompressionAlgorithm = compressionAlgorithm;
            this.mMasterSecret = Org.BouncyCastle.Utilities.Arrays.Clone(data:  masterSecret);
            this.mPeerCertificate = val_1;
            this.mPskIdentity = Org.BouncyCastle.Utilities.Arrays.Clone(data:  pskIdentity);
            this.mSrpIdentity = Org.BouncyCastle.Utilities.Arrays.Clone(data:  srpIdentity);
            this.mEncodedServerExtensions = encodedServerExtensions;
        }
        public void Clear()
        {
            if(this.mMasterSecret == null)
            {
                    return;
            }
            
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.mMasterSecret, b:  0);
        }
        public Org.BouncyCastle.Crypto.Tls.SessionParameters Copy()
        {
            return (Org.BouncyCastle.Crypto.Tls.SessionParameters)new Org.BouncyCastle.Crypto.Tls.SessionParameters(cipherSuite:  this.mCipherSuite, compressionAlgorithm:  this.mCompressionAlgorithm, masterSecret:  this.mMasterSecret, peerCertificate:  this.mPeerCertificate, pskIdentity:  this.mPskIdentity, srpIdentity:  this.mSrpIdentity, encodedServerExtensions:  this.mEncodedServerExtensions);
        }
        public int get_CipherSuite()
        {
            return (int)this.mCipherSuite;
        }
        public byte get_CompressionAlgorithm()
        {
            return (byte)this.mCompressionAlgorithm;
        }
        public byte[] get_MasterSecret()
        {
            return (System.Byte[])this.mMasterSecret;
        }
        public Org.BouncyCastle.Crypto.Tls.Certificate get_PeerCertificate()
        {
            return (Org.BouncyCastle.Crypto.Tls.Certificate)this.mPeerCertificate;
        }
        public byte[] get_PskIdentity()
        {
            return (System.Byte[])this.mPskIdentity;
        }
        public byte[] get_SrpIdentity()
        {
            return (System.Byte[])this.mSrpIdentity;
        }
        public System.Collections.IDictionary ReadServerExtensions()
        {
            if(this.mEncodedServerExtensions == null)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadExtensions(input:  new System.IO.MemoryStream(buffer:  this.mEncodedServerExtensions, writable:  false));
        }
    
    }

}
