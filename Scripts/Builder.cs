using UnityEngine;
public sealed class SessionParameters.Builder
{
    // Fields
    private int mCipherSuite;
    private short mCompressionAlgorithm;
    private byte[] mMasterSecret;
    private Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate;
    private byte[] mPskIdentity;
    private byte[] mSrpIdentity;
    private byte[] mEncodedServerExtensions;
    
    // Methods
    public SessionParameters.Builder()
    {
        this.mCipherSuite = 0;
        this.mCompressionAlgorithm = 65535;
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters Build()
    {
        int val_5 = this.mCipherSuite;
        val_5 = val_5 >> 31;
        this.Validate(condition:  val_5 ^ 1, parameter:  "cipherSuite");
        this.Validate(condition:  (this.mCompressionAlgorithm >= 0) ? 1 : 0, parameter:  "compressionAlgorithm");
        this.Validate(condition:  (this.mMasterSecret != null) ? 1 : 0, parameter:  "masterSecret");
        return (Org.BouncyCastle.Crypto.Tls.SessionParameters)new Org.BouncyCastle.Crypto.Tls.SessionParameters(cipherSuite:  this.mCipherSuite, compressionAlgorithm:  this.mCompressionAlgorithm, masterSecret:  this.mMasterSecret, peerCertificate:  this.mPeerCertificate, pskIdentity:  this.mPskIdentity, srpIdentity:  this.mSrpIdentity, encodedServerExtensions:  this.mEncodedServerExtensions);
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetCipherSuite(int cipherSuite)
    {
        this.mCipherSuite = cipherSuite;
        return (SessionParameters.Builder)this;
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetCompressionAlgorithm(byte compressionAlgorithm)
    {
        this.mCompressionAlgorithm = compressionAlgorithm & 255;
        return (SessionParameters.Builder)this;
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetMasterSecret(byte[] masterSecret)
    {
        this.mMasterSecret = masterSecret;
        return (SessionParameters.Builder)this;
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetPeerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate peerCertificate)
    {
        this.mPeerCertificate = peerCertificate;
        return (SessionParameters.Builder)this;
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetPskIdentity(byte[] pskIdentity)
    {
        this.mPskIdentity = pskIdentity;
        return (SessionParameters.Builder)this;
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetSrpIdentity(byte[] srpIdentity)
    {
        this.mSrpIdentity = srpIdentity;
        return (SessionParameters.Builder)this;
    }
    public Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetServerExtensions(System.Collections.IDictionary serverExtensions)
    {
        System.Byte[] val_2;
        if(serverExtensions != null)
        {
                System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteExtensions(output:  val_1, extensions:  serverExtensions);
            val_2 = val_1;
        }
        else
        {
                val_2 = 0;
        }
        
        this.mEncodedServerExtensions = val_2;
        return (SessionParameters.Builder)this;
    }
    private void Validate(bool condition, string parameter)
    {
        if(condition != false)
        {
                return;
        }
        
        System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "Required session parameter \'" + parameter + "\' not configured");
    }

}
