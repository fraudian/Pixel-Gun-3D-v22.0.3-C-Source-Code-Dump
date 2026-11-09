using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class TlsProtocol
    {
        // Fields
        private static readonly string TLS_ERROR_MESSAGE;
        protected const short CS_START = 0;
        protected const short CS_CLIENT_HELLO = 1;
        protected const short CS_SERVER_HELLO = 2;
        protected const short CS_SERVER_SUPPLEMENTAL_DATA = 3;
        protected const short CS_SERVER_CERTIFICATE = 4;
        protected const short CS_CERTIFICATE_STATUS = 5;
        protected const short CS_SERVER_KEY_EXCHANGE = 6;
        protected const short CS_CERTIFICATE_REQUEST = 7;
        protected const short CS_SERVER_HELLO_DONE = 8;
        protected const short CS_CLIENT_SUPPLEMENTAL_DATA = 9;
        protected const short CS_CLIENT_CERTIFICATE = 10;
        protected const short CS_CLIENT_KEY_EXCHANGE = 11;
        protected const short CS_CERTIFICATE_VERIFY = 12;
        protected const short CS_CLIENT_FINISHED = 13;
        protected const short CS_SERVER_SESSION_TICKET = 14;
        protected const short CS_SERVER_FINISHED = 15;
        protected const short CS_END = 16;
        protected const short ADS_MODE_1_Nsub1 = 0;
        protected const short ADS_MODE_0_N = 1;
        protected const short ADS_MODE_0_N_FIRSTONLY = 2;
        private Org.BouncyCastle.Crypto.Tls.ByteQueue mApplicationDataQueue;
        private Org.BouncyCastle.Crypto.Tls.ByteQueue mAlertQueue;
        private Org.BouncyCastle.Crypto.Tls.ByteQueue mHandshakeQueue;
        internal Org.BouncyCastle.Crypto.Tls.RecordStream mRecordStream;
        protected Org.BouncyCastle.Security.SecureRandom mSecureRandom;
        private Org.BouncyCastle.Crypto.Tls.TlsStream mTlsStream;
        private bool mClosed;
        private bool mFailedWithError;
        private bool mAppDataReady;
        private bool mAppDataSplitEnabled;
        private int mAppDataSplitMode;
        private byte[] mExpectedVerifyData;
        protected Org.BouncyCastle.Crypto.Tls.TlsSession mTlsSession;
        protected Org.BouncyCastle.Crypto.Tls.SessionParameters mSessionParameters;
        protected Org.BouncyCastle.Crypto.Tls.SecurityParameters mSecurityParameters;
        protected Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate;
        protected int[] mOfferedCipherSuites;
        protected byte[] mOfferedCompressionMethods;
        protected System.Collections.IDictionary mClientExtensions;
        protected System.Collections.IDictionary mServerExtensions;
        protected short mConnectionState;
        protected bool mResumedSession;
        protected bool mReceivedChangeCipherSpec;
        protected bool mSecureRenegotiation;
        protected bool mAllowCertificateStatus;
        protected bool mExpectSessionTicket;
        protected bool mBlocking;
        protected Org.BouncyCastle.Crypto.Tls.ByteQueueStream mInputBuffers;
        protected Org.BouncyCastle.Crypto.Tls.ByteQueueStream mOutputBuffer;
        
        // Properties
        protected abstract Org.BouncyCastle.Crypto.Tls.TlsContext Context { get; }
        internal abstract Org.BouncyCastle.Crypto.Tls.AbstractTlsContext ContextAdmin { get; }
        protected abstract Org.BouncyCastle.Crypto.Tls.TlsPeer Peer { get; }
        public virtual System.IO.Stream Stream { get; }
        public virtual bool IsClosed { get; }
        
        // Methods
        public TlsProtocol(System.IO.Stream stream, Org.BouncyCastle.Security.SecureRandom secureRandom)
        {
        
        }
        public TlsProtocol(System.IO.Stream input, System.IO.Stream output, Org.BouncyCastle.Security.SecureRandom secureRandom)
        {
            this.mApplicationDataQueue = new Org.BouncyCastle.Crypto.Tls.ByteQueue();
            this.mAlertQueue = new Org.BouncyCastle.Crypto.Tls.ByteQueue(capacity:  2);
            this.mHandshakeQueue = new Org.BouncyCastle.Crypto.Tls.ByteQueue();
            this.mAppDataSplitEnabled = true;
            this.mBlocking = true;
            val_4 = new System.Object();
            this.mRecordStream = new Org.BouncyCastle.Crypto.Tls.RecordStream(handler:  this, input:  input, output:  output);
            this.mSecureRandom = val_4;
        }
        public TlsProtocol(Org.BouncyCastle.Security.SecureRandom secureRandom)
        {
            this.mApplicationDataQueue = new Org.BouncyCastle.Crypto.Tls.ByteQueue();
            this.mAlertQueue = new Org.BouncyCastle.Crypto.Tls.ByteQueue(capacity:  2);
            this.mHandshakeQueue = new Org.BouncyCastle.Crypto.Tls.ByteQueue();
            this.mAppDataSplitEnabled = true;
            this.mBlocking = true;
            this.mBlocking = false;
            this.mInputBuffers = new Org.BouncyCastle.Crypto.Tls.ByteQueueStream();
            Org.BouncyCastle.Crypto.Tls.ByteQueueStream val_5 = new Org.BouncyCastle.Crypto.Tls.ByteQueueStream();
            this.mOutputBuffer = val_5;
            this.mRecordStream = new Org.BouncyCastle.Crypto.Tls.RecordStream(handler:  this, input:  this.mInputBuffers, output:  val_5);
            this.mSecureRandom = secureRandom;
        }
        protected abstract Org.BouncyCastle.Crypto.Tls.TlsContext get_Context(); // 0
        internal abstract Org.BouncyCastle.Crypto.Tls.AbstractTlsContext get_ContextAdmin(); // 0
        protected abstract Org.BouncyCastle.Crypto.Tls.TlsPeer get_Peer(); // 0
        protected virtual void HandleChangeCipherSpecMessage()
        {
        
        }
        protected abstract void HandleHandshakeMessage(byte type, byte[] buf); // 0
        protected virtual void HandleWarningMessage(byte description)
        {
        
        }
        protected virtual void ApplyMaxFragmentLengthExtension()
        {
            if((this.mSecurityParameters.maxFragmentLength & 2147483648) != 0)
            {
                    return;
            }
            
            short val_7 = this.mSecurityParameters.maxFragmentLength;
            val_7 = val_7 - 1;
            if(val_7 < 4)
            {
                    short val_8 = this.mSecurityParameters.maxFragmentLength;
                val_8 = val_8 + 8;
                val_8 = val_8 & 31;
                short val_1 = 1 << val_8;
                this = ???;
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_6 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
            }
        
        }
        protected virtual void CheckReceivedChangeCipherSpec(bool expected)
        {
            var val_1 = (this.mReceivedChangeCipherSpec == true) ? 1 : 0;
            val_1 = val_1 ^ expected;
            if(val_1 != true)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        protected virtual void CleanupHandshake()
        {
            if(this.mExpectedVerifyData != null)
            {
                    Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.mExpectedVerifyData, b:  0);
                this.mExpectedVerifyData = 0;
            }
            
            this.mServerExtensions = 0;
            this.mResumedSession = false;
            this.mReceivedChangeCipherSpec = false;
            this.mSecureRenegotiation = false;
            this.mAllowCertificateStatus = false;
            this.mOfferedCompressionMethods = 0;
            this.mPeerCertificate = 0;
            this.mExpectSessionTicket = false;
        }
        protected virtual void BlockForHandshake()
        {
            if(this.mBlocking == true)
            {
                goto label_0;
            }
            
            return;
            label_2:
            label_0:
            if(this.mConnectionState != 16)
            {
                goto label_2;
            }
        
        }
        protected virtual void CompleteHandshake()
        {
            Org.BouncyCastle.Crypto.Tls.TlsContext val_15;
            Org.BouncyCastle.Crypto.Tls.TlsProtocol val_16;
            System.Byte[] val_18;
            var val_19;
            var val_21;
            val_15 = this;
            val_16 = 0;
            bool val_16 = ~(Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV11(context:  this));
            val_16 = val_16 & 1;
            this.mAppDataSplitEnabled = val_16;
            if(this.mAppDataReady != true)
            {
                    this.mAppDataReady = true;
                if(this.mBlocking != false)
            {
                    val_16 = val_15;
                new Org.BouncyCastle.Crypto.Tls.TlsStream() = new Org.BouncyCastle.Crypto.Tls.TlsStream(handler:  this);
                this.mTlsStream = new Org.BouncyCastle.Crypto.Tls.TlsStream();
            }
            
            }
            
            if(this.mTlsSession != null)
            {
                    if(this.mSessionParameters == null)
            {
                    .mCipherSuite = 0;
                .mCompressionAlgorithm = 65535;
                new SessionParameters.Builder() = new System.Object();
                .mCipherSuite = this.mSecurityParameters;
                .mCompressionAlgorithm = this.mSecurityParameters.compressionAlgorithm;
                .mMasterSecret = this.mSecurityParameters;
                .mPeerCertificate = this.mPeerCertificate;
                .mPskIdentity = this.mSecurityParameters;
                .mSrpIdentity = this.mSecurityParameters;
                SessionParameters.Builder val_4 = new SessionParameters.Builder().SetServerExtensions(serverExtensions:  this.mServerExtensions);
                this.mSessionParameters = new SessionParameters.Builder().Build();
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_18 = this.mTlsSession.SessionID;
                new Org.BouncyCastle.Crypto.Tls.TlsSessionImpl() = new Org.BouncyCastle.Crypto.Tls.TlsSessionImpl(sessionID:  val_18, sessionParameters:  this.mSessionParameters);
                this.mTlsSession = new Org.BouncyCastle.Crypto.Tls.TlsSessionImpl();
            }
            
                val_19 = this.mTlsSession;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            this.NotifyHandshakeComplete();
            val_21 = 1;
            if((val_21 & 1) != 0)
            {
                    return;
            }
            
            if((1 & 1) != 0)
            {
                    return;
            }
            
            val_15 = ???;
            val_21 = ???;
        }
        protected internal void ProcessRecord(byte protocol, byte[] buf, int offset, int len)
        {
            int val_35 = len;
            byte val_1 = protocol & 255;
            val_1 = val_1 - 20;
            if(val_1 > 4)
            {
                    return;
            }
            
            var val_35 = 106068364 + (((protocol & 255) - 20)) << 2;
            val_35 = val_35 + 106068364;
            goto (106068364 + (((protocol & 255) - 20)) << 2 + 106068364);
        }
        private void ProcessHandshake()
        {
            Org.BouncyCastle.Crypto.Tls.ByteQueue val_14;
            var val_15;
            goto label_1;
            label_26:
            byte[] val_1 = new byte[4];
            this.mHandshakeQueue.Read(buf:  val_1, offset:  0, len:  4, skip:  0);
            int val_3 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf:  val_1, offset:  1);
            val_14 = this.mHandshakeQueue;
            if(val_14.Available < (val_3 + 4))
            {
                    return;
            }
            
            val_15 = 0;
            byte val_7 = (Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf:  val_1, offset:  0)) & 255;
            val_14 = this.mHandshakeQueue.RemoveData(len:  val_3, skip:  4);
            var val_10 = ((val_7 == 20) ? 1 : 0) | ((this.mConnectionState == 16) ? 1 : 0);
            if(val_7 != 0)
            {
                    if((val_7 == 20) && (this.mExpectedVerifyData == null))
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                if(this.SecurityParameters != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                var val_15 = (~this.IsServer) & 1;
                this.mExpectedVerifyData = this;
            }
            
            }
            
                val_15 = val_3;
            }
            
            label_1:
            if(this.mHandshakeQueue.Available >= 4)
            {
                goto label_26;
            }
        
        }
        private void ProcessApplicationData()
        {
        
        }
        private void ProcessAlert()
        {
            var val_6;
            int val_7;
            byte val_9;
            var val_10;
            goto label_1;
            label_14:
            val_6 = 2;
            System.Byte[] val_1 = this.mAlertQueue.RemoveData(len:  2, skip:  0);
            val_7 = val_1.Length;
            if(val_7 == 0)
            {
                    val_6 = 0;
                val_7 = val_1.Length;
            }
            
            byte val_6 = val_1[0];
            if(val_7 <= 1)
            {
                    val_6 = 0;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = val_1[0];
            this.NotifyAlertReceived(alertLevel:  val_6, alertDescription:  val_9);
            if(val_6 == 2)
            {
                goto label_11;
            }
            
            label_1:
            if(this.mAlertQueue.Available > 1)
            {
                goto label_14;
            }
            
            return;
            label_11:
            this.mFailedWithError = true;
            this.mClosed = true;
            val_10 = null;
            val_10 = null;
            System.IO.IOException val_5 = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.TlsProtocol.ADS_MODE_0_N_FIRSTONLY + " (from Process Alert)");
        }
        private void ProcessChangeCipherSpec(byte[] buf, int off, int len)
        {
            Org.BouncyCastle.Crypto.Tls.RecordStream val_7;
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_8;
            var val_9;
            if(len < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            label_11:
            if(((Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf:  buf, offset:  off + val_7)) & 255) != 1)
            {
                goto label_4;
            }
            
            if(((this.mReceivedChangeCipherSpec == true) || (this.mAlertQueue.Available > 0)) || (this.mHandshakeQueue.Available >= 1))
            {
                goto label_9;
            }
            
            val_7 = this.mRecordStream;
            this.mReceivedChangeCipherSpec = true;
            val_7 = val_7 + 1;
            if(val_7 < len)
            {
                goto label_11;
            }
            
            return;
            label_9:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_9 = 10;
            goto label_12;
            label_4:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_9 = 50;
            label_12:
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        protected internal virtual int ApplicationDataAvailable()
        {
            if(this.mApplicationDataQueue != null)
            {
                    return this.mApplicationDataQueue.Available;
            }
            
            return this.mApplicationDataQueue.Available;
        }
        protected internal virtual int ReadApplicationData(byte[] buf, int offset, int len)
        {
            int val_6;
            int val_7;
            var val_8;
            val_6 = offset;
            if(len >= 1)
            {
                goto label_1;
            }
            
            goto label_2;
            label_5:
            if(this.mClosed == true)
            {
                goto label_3;
            }
            
            label_1:
            if(this.mApplicationDataQueue.Available == 0)
            {
                goto label_5;
            }
            
            val_7 = System.Math.Min(val1:  len, val2:  this.mApplicationDataQueue.Available);
            this.mApplicationDataQueue.RemoveData(buf:  buf, off:  val_6, len:  val_7, skip:  0);
            return (int)val_7;
            label_3:
            val_6 = this.mFailedWithError;
            if(val_6 == true)
            {
                goto label_11;
            }
            
            label_2:
            val_7 = 0;
            return (int)val_7;
            label_11:
            val_8 = null;
            val_8 = null;
            System.IO.IOException val_5 = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.TlsProtocol.ADS_MODE_0_N_FIRSTONLY + " (from Read Aplication Data)");
        }
        protected virtual void SafeReadRecord()
        {
            var val_2;
            var val_3;
            System.IO.EndOfStreamException val_4;
            var val_6;
            if((this.mRecordStream & 1) != 0)
            {
                    return;
            }
            
            new System.IO.EndOfStreamException() = new System.IO.EndOfStreamException();
            val_2 = new System.IO.EndOfStreamException();
            if(0 != 1)
            {
                goto label_5;
            }
            
            val_3 = val_2;
            val_4 = null;
            if((null & 1) == 0)
            {
                goto label_6;
            }
            
            val_3 = 1;
            goto label_7;
            label_6:
            val_4 = null;
            if((null & 1) == 0)
            {
                goto label_8;
            }
            
            val_3 = 0;
            label_7:
            if(val_3 == 0)
            {
                goto label_9;
            }
            
            if(this.mClosed == true)
            {
                goto label_13;
            }
            
            val_6 = "Failed to read record";
            goto label_12;
            label_9:
            if(this.mClosed == true)
            {
                goto label_13;
            }
            
            val_6 = "Failed to read record";
            label_12:
            label_13:
            label_8:
            mem[8] = val_3;
            val_2 = 8;
            label_5:
        }
        protected virtual void SafeWriteRecord(byte type, byte[] buf, int offset, int len)
        {
            if(this.mRecordStream != null)
            {
                    return;
            }
        
        }
        protected internal virtual void WriteData(byte[] buf, int offset, int len)
        {
            int val_5;
            var val_6;
            bool val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_5 = len;
            val_6 = offset;
            val_7 = this.mClosed;
            if(val_7 == true)
            {
                goto label_1;
            }
            
            if(val_5 < 1)
            {
                    return;
            }
            
            label_13:
            if(this.mAppDataSplitEnabled == false)
            {
                goto label_7;
            }
            
            val_7 = this.mAppDataSplitMode;
            if(val_7 == 2)
            {
                goto label_4;
            }
            
            if(val_7 == 1)
            {
                goto label_5;
            }
            
            val_8 = 23;
            val_5 = val_5 - 1;
            if(val_5 < 1)
            {
                    return;
            }
            
            val_6 = val_6 + 1;
            goto label_7;
            label_4:
            this.mAppDataSplitEnabled = false;
            label_5:
            val_9 = null;
            val_9 = null;
            val_8 = 23;
            label_7:
            val_7 = System.Math.Min(val1:  val_5, val2:  this.mRecordStream);
            val_5 = val_5 - val_7;
            val_6 = val_7 + val_6;
            if(val_5 > 0)
            {
                goto label_13;
            }
            
            return;
            label_1:
            if(this.mFailedWithError != true)
            {
                    val_10 = 1152921547563207392;
                val_11 = new System.IO.IOException(message:  "Sorry, connection has been closed, you cannot write more data");
            }
            else
            {
                    val_12 = null;
                val_12 = null;
                val_10 = 1152921547563207392;
                val_11 = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.TlsProtocol.ADS_MODE_0_N_FIRSTONLY + " (from Write Data)");
            }
        
        }
        protected virtual void SetAppDataSplitMode(int appDataSplitMode)
        {
            if(appDataSplitMode < 3)
            {
                    this.mAppDataSplitMode = appDataSplitMode;
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Illegal appDataSplitMode mode: "("Illegal appDataSplitMode mode: ") + appDataSplitMode, paramName:  "appDataSplitMode");
        }
        protected virtual void WriteHandshakeMessage(byte[] buf, int off, int len)
        {
            var val_2;
            int val_3 = len;
            int val_2 = off;
            if(val_3 < 1)
            {
                    return;
            }
            
            do
            {
                val_2 = System.Math.Min(val1:  val_3 = len, val2:  this.mRecordStream);
                val_3 = val_3 - val_2;
                val_2 = val_2 + val_2;
            }
            while(val_3 > 0);
        
        }
        public virtual System.IO.Stream get_Stream()
        {
            if(this.mBlocking != false)
            {
                    return (System.IO.Stream)this.mTlsStream;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot use Stream in non-blocking mode! Use OfferInput()/OfferOutput() instead.");
        }
        public virtual void OfferInput(byte[] input)
        {
            Org.BouncyCastle.Crypto.Tls.ByteQueueStream val_6;
            var val_7;
            if(this.mBlocking == true)
            {
                goto label_1;
            }
            
            if(this.mClosed == true)
            {
                goto label_2;
            }
            
            val_6 = this.mInputBuffers;
            if(val_6 != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_11:
            val_6 = (Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf:  new byte[5], offset:  3)) + 5;
            if(this.mInputBuffers < val_6)
            {
                    return;
            }
            
            label_4:
            if(this.mInputBuffers > 4)
            {
                goto label_11;
            }
            
            return;
            label_1:
            System.InvalidOperationException val_3 = null;
            val_7 = val_3;
            val_3 = new System.InvalidOperationException(message:  "Cannot use OfferInput() in blocking mode! Use Stream instead.");
            goto label_12;
            label_2:
            System.IO.IOException val_4 = null;
            val_7 = val_4;
            val_4 = new System.IO.IOException(message:  "Connection is closed, cannot accept any more input");
            label_12:
        }
        public virtual int GetAvailableInputBytes()
        {
            if(this.mBlocking != true)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot use GetAvailableInputBytes() in blocking mode! Use ApplicationDataAvailable() instead.");
            }
        
        }
        public virtual int ReadInput(byte[] buffer, int offset, int length)
        {
            if(this.mBlocking != true)
            {
                    int val_1 = System.Math.Min(val1:  length, val2:  7755664);
            }
            else
            {
                    System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "Cannot use ReadInput() in blocking mode! Use Stream instead.");
            }
        
        }
        public virtual void OfferOutput(byte[] buffer, int offset, int length)
        {
            var val_3;
            if(this.mBlocking == true)
            {
                goto label_1;
            }
            
            if(this.mAppDataReady == false)
            {
                goto label_2;
            }
            
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsProtocol).__il2cppRuntimeField_258;
            label_1:
            System.InvalidOperationException val_1 = null;
            val_3 = val_1;
            val_1 = new System.InvalidOperationException(message:  "Cannot use OfferOutput() in blocking mode! Use Stream instead.");
            goto label_3;
            label_2:
            System.IO.IOException val_2 = null;
            val_3 = val_2;
            val_2 = new System.IO.IOException(message:  "Application data cannot be sent until the handshake is complete!");
            label_3:
        }
        public virtual int GetAvailableOutputBytes()
        {
            if(this.mBlocking != true)
            {
                    if(this.mOutputBuffer != null)
            {
                goto typeof(Org.BouncyCastle.Crypto.Tls.ByteQueueStream).__il2cppRuntimeField_348;
            }
            
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot use GetAvailableOutputBytes() in blocking mode! Use Stream instead.");
            }
        
        }
        public virtual int ReadOutput(byte[] buffer, int offset, int length)
        {
            if(this.mBlocking != true)
            {
                    if(this.mOutputBuffer != null)
            {
                goto typeof(Org.BouncyCastle.Crypto.Tls.ByteQueueStream).__il2cppRuntimeField_308;
            }
            
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot use ReadOutput() in blocking mode! Use Stream instead.");
            }
        
        }
        protected virtual void FailWithError(byte alertLevel, byte alertDescription, string message, System.Exception cause)
        {
            var val_4;
            byte val_4 = alertLevel;
            if(this.mClosed != true)
            {
                    this.mClosed = true;
                if((val_4 & 255) == 2)
            {
                    this.mFailedWithError = true;
            }
            
                val_4 = val_4 & 255;
                if(val_4 != 2)
            {
                    return;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            System.IO.IOException val_3 = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.TlsProtocol.ADS_MODE_0_N_FIRSTONLY + " (from Fail With Error)");
        }
        protected virtual void InvalidateSession()
        {
            if(this.mSessionParameters != null)
            {
                    if(this.mSessionParameters.mMasterSecret != null)
            {
                    Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.mSessionParameters.mMasterSecret, b:  0);
            }
            
                this.mSessionParameters = 0;
            }
            
            if(this.mTlsSession == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.mTlsSession.Invalidate();
            this.mTlsSession = 0;
        }
        protected virtual void ProcessFinishedMessage(System.IO.MemoryStream buf)
        {
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4;
            var val_5;
            if(this.mExpectedVerifyData == null)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  buf);
            if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  this.mExpectedVerifyData, b:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  this.mExpectedVerifyData.Length, input:  buf))) == false)
            {
                goto label_6;
            }
            
            return;
            label_1:
            val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_5 = 80;
            goto label_7;
            label_6:
            val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            val_5 = 51;
            label_7:
            val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  51);
        }
        protected virtual void RaiseAlert(byte alertLevel, byte alertDescription, string message, System.Exception cause)
        {
            int val_4;
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.NotifyAlertRaised(alertLevel:  alertLevel, alertDescription:  alertDescription, message:  message, cause:  cause);
            byte[] val_2 = new byte[2];
            val_4 = val_2.Length;
            if(val_4 == 0)
            {
                    val_4 = val_2.Length;
            }
            
            val_2[0] = alertLevel;
            val_2[0] = alertDescription;
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsProtocol).__il2cppRuntimeField_248;
        }
        protected virtual void RaiseWarning(byte alertDescription, string message)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsProtocol).__il2cppRuntimeField_328;
        }
        protected virtual void SendCertificateMessage(Org.BouncyCastle.Crypto.Tls.Certificate certificate)
        {
            Org.BouncyCastle.Crypto.Tls.Certificate val_14;
            Org.BouncyCastle.Crypto.Tls.TlsProtocol val_15;
            var val_16;
            var val_17;
            val_14 = certificate;
            val_15 = this;
            if(val_14 == null)
            {
                    val_16 = null;
                val_16 = null;
                val_14 = Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain;
                if(val_14 == null)
            {
                goto label_17;
            }
            
            }
            
            val_17 = 0;
            label_17:
            if((val_14 & 1) == 0)
            {
                goto label_19;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(this.IsServer == true)
            {
                goto label_19;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_4 = this.ServerVersion;
            if(val_4.IsSsl == false)
            {
                goto label_19;
            }
            
            string val_6 = val_4 + " client didn\'t provide credentials";
            val_14 = ???;
            val_15 = ???;
            val_17 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsProtocol).__il2cppRuntimeField_338;
            label_19:
            new TlsProtocol.HandshakeMessage(handshakeType:  11, length:  60).WriteToRecordStream(protocol:  val_15);
        }
        protected virtual void SendChangeCipherSpecMessage()
        {
            new byte[1][0] = 1;
            if(this.mRecordStream == null)
            {
                
            }
        
        }
        protected virtual void SendFinishedMessage()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            bool val_3 = this.IsServer;
            TlsProtocol.HandshakeMessage val_4 = new TlsProtocol.HandshakeMessage(handshakeType:  20, length:  this.mAlertQueue);
            if(val_4 != null)
            {
                    val_4.Write(buffer:  this, offset:  0, count:  this.mAlertQueue);
                val_4.WriteToRecordStream(protocol:  this);
                return;
            }
        
        }
        protected virtual void SendSupplementalDataMessage(System.Collections.IList supplementalData)
        {
            TlsProtocol.HandshakeMessage val_1 = new TlsProtocol.HandshakeMessage(handshakeType:  23, length:  60);
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteSupplementalData(output:  val_1, supplementalData:  supplementalData);
            val_1.WriteToRecordStream(protocol:  this);
        }
        protected virtual byte[] CreateVerifyData(bool isServer)
        {
            var val_3;
            var val_4;
            System.Byte[] val_5;
            var val_6;
            val_3 = null;
            if(isServer != false)
            {
                    val_4 = null;
                val_5 = 1152921505529958440;
                return Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(context:  this, asciiLabel:  (isServer != true) ? "server finished" : "client finished", handshakeHash:  Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(context:  this, handshakeHash:  this.mRecordStream, sslSender:  val_5 = 1152921505529958432));
            }
            
            val_6 = null;
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(context:  this, asciiLabel:  (isServer != true) ? "server finished" : "client finished", handshakeHash:  Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(context:  this, handshakeHash:  this.mRecordStream, sslSender:  val_5));
        }
        public virtual void Close()
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsProtocol).__il2cppRuntimeField_3A8;
        }
        protected virtual void HandleClose(bool user_canceled)
        {
            if(this.mClosed != false)
            {
                    return;
            }
            
            if((user_canceled != false) && (this.mAppDataReady != true))
            {
                
            }
        
        }
        protected internal virtual void Flush()
        {
            if(this.mRecordStream == null)
            {
                
            }
        
        }
        public virtual bool get_IsClosed()
        {
            return (bool)this.mClosed;
        }
        protected virtual short ProcessMaxFragmentLengthExtension(System.Collections.IDictionary clientExtensions, System.Collections.IDictionary serverExtensions, byte alertDescription)
        {
            if((((int)(Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(extensions:  serverExtensions)) & 65535) & 2147483648) != 0)
            {
                    return (short)(int)(Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(extensions:  serverExtensions)) & 65535;
            }
            
            var val_2 = ((int)(Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(extensions:  serverExtensions)) & 65535) - 1;
            val_2 = val_2 & 255;
            if(val_2 <= 3)
            {
                    if(this.mResumedSession == true)
            {
                    return (short)(int)(Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(extensions:  serverExtensions)) & 65535;
            }
            
                if((((int)(Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(extensions:  serverExtensions)) & 65535) & 65535) == (Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(extensions:  clientExtensions)))
            {
                    return (short)(int)(Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(extensions:  serverExtensions)) & 65535;
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_5 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  alertDescription);
        }
        protected virtual void RefuseRenegotiation()
        {
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  this)) != true)
            {
                
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  40);
            }
        
        }
        protected internal static void AssertEmpty(System.IO.MemoryStream buf)
        {
            if(buf >= buf)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        protected internal static byte[] CreateRandomBlock(bool useGmtUnixTime, Org.BouncyCastle.Crypto.Prng.IRandomGenerator randomGenerator)
        {
            byte[] val_1 = new byte[32];
            var val_3 = 0;
            val_3 = val_3 + 1;
            randomGenerator.NextBytes(bytes:  val_1);
            if(useGmtUnixTime == false)
            {
                    return (System.Byte[])val_1;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteGmtUnixTime(buf:  val_1, offset:  0);
            return (System.Byte[])val_1;
        }
        protected internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection)
        {
            return Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeOpaque8(buf:  renegotiated_connection);
        }
        protected internal static void EstablishMasterSecret(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Tls.TlsKeyExchange keyExchange)
        {
            System.Byte[] val_12;
            var val_14;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = keyExchange.GeneratePremasterSecret();
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = context.SecurityParameters;
            val_4.masterSecret = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateMasterSecret(context:  context, pre_master_secret:  val_12);
            if(val_12 != null)
            {
                    Org.BouncyCastle.Utilities.Arrays.Fill(buf:  val_12, b:  0);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_12 = ???;
            val_14 = ???;
        }
        protected internal static byte[] GetCurrentPrfHash(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash handshakeHash, byte[] sslSender)
        {
            Org.BouncyCastle.Crypto.Tls.TlsContext val_4 = context;
            var val_5 = 0;
            val_5 = val_5 + 1;
            Org.BouncyCastle.Crypto.IDigest val_2 = handshakeHash.ForkPrfHash();
            if(sslSender == null)
            {
                    return Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  val_2);
            }
            
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  val_4 = context)) == false)
            {
                    return Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  val_2);
            }
            
            val_4 = sslSender.Length;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_2.BlockUpdate(input:  sslSender, inOff:  0, length:  val_4);
            return Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  val_2);
        }
        protected internal static System.Collections.IDictionary ReadExtensions(System.IO.MemoryStream input)
        {
            System.IO.Stream val_9;
            System.Byte[] val_10;
            var val_11;
            val_9 = input;
            if(val_9 >= val_9)
            {
                goto label_3;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_9);
            System.IO.MemoryStream val_2 = null;
            val_10 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  val_9);
            val_9 = val_2;
            val_2 = new System.IO.MemoryStream(buffer:  val_10, writable:  false);
            val_11 = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            goto label_10;
            label_26:
            int val_4 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  val_2);
            var val_10 = 0;
            val_10 = val_10 + 1;
            if((val_11.Contains(key:  val_4)) == true)
            {
                goto label_18;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_10 = val_4;
            val_11.Add(key:  val_4, value:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  val_2));
            label_10:
            if(val_9 < val_9)
            {
                goto label_26;
            }
            
            return (System.Collections.IDictionary)val_11;
            label_3:
            val_11 = 0;
            return (System.Collections.IDictionary)val_11;
            label_18:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        protected internal static System.Collections.IList ReadSupplementalDataMessage(System.IO.MemoryStream input)
        {
            System.Byte[] val_8;
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  input);
            System.IO.MemoryStream val_2 = null;
            val_8 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque24(input:  input);
            val_2 = new System.IO.MemoryStream(buffer:  val_8, writable:  false);
            System.Collections.IList val_3 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            goto label_7;
            label_17:
            Org.BouncyCastle.Crypto.Tls.SupplementalDataEntry val_6 = new Org.BouncyCastle.Crypto.Tls.SupplementalDataEntry();
            .mDataType = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  val_2);
            .mData = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  val_2);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8 = val_6;
            int val_8 = val_3.Add(value:  val_6);
            label_7:
            if(val_2 < val_2)
            {
                goto label_17;
            }
            
            return val_3;
        }
        protected internal static void WriteExtensions(System.IO.Stream output, System.Collections.IDictionary extensions)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteSelectedExtensions(output:  val_1, extensions:  extensions, selectEmpty:  true);
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteSelectedExtensions(output:  val_1, extensions:  extensions, selectEmpty:  false);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  val_1, output:  output);
        }
        protected internal static void WriteSelectedExtensions(System.IO.Stream output, System.Collections.IDictionary extensions, bool selectEmpty)
        {
            var val_9;
            var val_15;
            System.Byte[] val_16;
            var val_17;
            var val_18;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_9 = 2;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_9 = 0;
            System.Collections.IEnumerator val_4 = extensions.Keys.GetEnumerator();
            label_35:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_9 = 0;
            if(val_4.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_9 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_4.Current);
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_9 = 0;
            object val_10 = extensions.Item[null];
            if(val_10 == null)
            {
                goto label_29;
            }
            
            val_15 = val_10;
            if(val_15 == null)
            {
                goto label_30;
            }
            
            val_16 = val_15;
            goto label_31;
            label_30:
            label_29:
            val_16 = 0;
            val_15 = 0;
            label_31:
            var val_12 = (28563616 == 0) ? 1 : 0;
            val_12 = val_12 ^ selectEmpty;
            if(val_12 == true)
            {
                goto label_35;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  21884928);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  21884928, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  val_16, output:  output);
            goto label_35;
            label_16:
            val_17 = 0;
            val_18 = 0;
            if(val_4 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_4.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        protected internal static void WriteSupplementalData(System.IO.Stream output, System.Collections.IList supplementalData)
        {
            var val_10;
            var val_12;
            var val_13;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Collections.IEnumerator val_3 = supplementalData.GetEnumerator();
            goto label_17;
            label_24:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_10 = public System.Object System.Collections.IEnumerator::get_Current();
            if(val_3.Current != null)
            {
                    val_10 = 0;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  0);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  0, output:  val_1);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  0, output:  val_1);
            label_17:
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_24;
            }
            
            val_12 = 0;
            val_13 = 0;
            if(val_3 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_3.Dispose();
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque24(buf:  val_1, output:  output);
        }
        protected internal static int GetPrfAlgorithm(Org.BouncyCastle.Crypto.Tls.TlsContext context, int ciphersuite)
        {
            var val_7;
            bool val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  context);
            if(ciphersuite <= 197)
            {
                goto label_3;
            }
            
            if(ciphersuite <= 52398)
            {
                goto label_4;
            }
            
            var val_6 = 65279;
            val_6 = ciphersuite + val_6;
            if(val_6 > 21)
            {
                goto label_16;
            }
            
            val_6 = 1 << val_6;
            val_6 = val_6 & 4128831;
            if(val_6 != 0)
            {
                goto label_17;
            }
            
            goto label_16;
            label_3:
            if((ciphersuite - 103) > 94)
            {
                goto label_8;
            }
            
            var val_7 = 106068480 + ((ciphersuite - 103)) << 2;
            val_7 = val_7 + 106068480;
            goto (106068480 + ((ciphersuite - 103)) << 2 + 106068480);
            label_4:
            var val_8 = 49186;
            val_8 = ciphersuite + val_8;
            if(val_8 > 140)
            {
                goto label_10;
            }
            
            var val_9 = 106068860 + ((ciphersuite + 49186)) << 2;
            val_9 = val_9 + 106068860;
            goto (106068860 + ((ciphersuite + 49186)) << 2 + 106068860);
            label_16:
            val_7 = val_1;
            return (int)val_7;
            label_8:
            if((ciphersuite - 59) >= 6)
            {
                goto label_16;
            }
            
            label_17:
            if(val_1 == false)
            {
                goto label_15;
            }
            
            val_7 = 1;
            return (int)val_7;
            label_10:
            var val_10 = 52391;
            val_10 = ciphersuite + val_10;
            if(val_10 > 6)
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_5 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        private static TlsProtocol()
        {
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.ADS_MODE_0_N_FIRSTONLY = "Internal TLS error, this could be an attack";
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.ADS_MODE_0_N_FIRSTONLY.__il2cppRuntimeField_1 = 655556;
        }
    
    }

}
