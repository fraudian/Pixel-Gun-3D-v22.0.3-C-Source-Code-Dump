using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class RecordStream
    {
        // Fields
        private const int DEFAULT_PLAINTEXT_LIMIT = 16384;
        internal const int TLS_HEADER_SIZE = 5;
        internal const int TLS_HEADER_TYPE_OFFSET = 0;
        internal const int TLS_HEADER_VERSION_OFFSET = 1;
        internal const int TLS_HEADER_LENGTH_OFFSET = 3;
        private Org.BouncyCastle.Crypto.Tls.TlsProtocol mHandler;
        private System.IO.Stream mInput;
        private System.IO.Stream mOutput;
        private Org.BouncyCastle.Crypto.Tls.TlsCompression mPendingCompression;
        private Org.BouncyCastle.Crypto.Tls.TlsCompression mReadCompression;
        private Org.BouncyCastle.Crypto.Tls.TlsCompression mWriteCompression;
        private Org.BouncyCastle.Crypto.Tls.TlsCipher mPendingCipher;
        private Org.BouncyCastle.Crypto.Tls.TlsCipher mReadCipher;
        private Org.BouncyCastle.Crypto.Tls.TlsCipher mWriteCipher;
        private long mReadSeqNo;
        private long mWriteSeqNo;
        private System.IO.MemoryStream mBuffer;
        private Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash mHandshakeHash;
        private Org.BouncyCastle.Crypto.Tls.ProtocolVersion mReadVersion;
        private Org.BouncyCastle.Crypto.Tls.ProtocolVersion mWriteVersion;
        private bool mRestrictReadVersion;
        private int mPlaintextLimit;
        private int mCompressedLimit;
        private int mCiphertextLimit;
        
        // Properties
        internal virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion ReadVersion { get; set; }
        internal virtual Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash HandshakeHash { get; }
        
        // Methods
        internal RecordStream(Org.BouncyCastle.Crypto.Tls.TlsProtocol handler, System.IO.Stream input, System.IO.Stream output)
        {
            this.mBuffer = new System.IO.MemoryStream();
            this.mRestrictReadVersion = true;
            val_2 = new System.Object();
            this.mHandler = handler;
            this.mInput = val_2;
            this.mOutput = output;
            Org.BouncyCastle.Crypto.Tls.TlsNullCompression val_3 = new Org.BouncyCastle.Crypto.Tls.TlsNullCompression();
            this.mReadCompression = val_3;
            this.mWriteCompression = val_3;
        }
        internal virtual void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            Org.BouncyCastle.Crypto.Tls.TlsNullCipher val_1 = new Org.BouncyCastle.Crypto.Tls.TlsNullCipher();
            .writeMac = 0;
            .readMac = 0;
            .context = context;
            this.mReadCipher = val_1;
            this.mWriteCipher = val_1;
            Org.BouncyCastle.Crypto.Tls.DeferredHash val_2 = new Org.BouncyCastle.Crypto.Tls.DeferredHash();
            this.mHandshakeHash = val_2;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.Init(context:  context);
            goto typeof(Org.BouncyCastle.Crypto.Tls.RecordStream).__il2cppRuntimeField_188;
        }
        internal virtual int GetPlaintextLimit()
        {
            return (int)this.mPlaintextLimit;
        }
        internal virtual void SetPlaintextLimit(int plaintextLimit)
        {
            this.mPlaintextLimit = plaintextLimit;
            this.mCompressedLimit = plaintextLimit + 1024;
            this.mCiphertextLimit = plaintextLimit + 2048;
        }
        internal virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ReadVersion()
        {
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)this.mReadVersion;
        }
        internal virtual void set_ReadVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion value)
        {
            this.mReadVersion = value;
        }
        internal virtual void SetWriteVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion writeVersion)
        {
            this.mWriteVersion = writeVersion;
        }
        internal virtual void SetRestrictReadVersion(bool enabled)
        {
            this.mRestrictReadVersion = enabled;
        }
        internal virtual void SetPendingConnectionState(Org.BouncyCastle.Crypto.Tls.TlsCompression tlsCompression, Org.BouncyCastle.Crypto.Tls.TlsCipher tlsCipher)
        {
            this.mPendingCompression = tlsCompression;
            this.mPendingCipher = tlsCipher;
        }
        internal virtual void SentWriteCipherSpec()
        {
            if((this.mPendingCompression != null) && (this.mPendingCipher != null))
            {
                    this.mWriteCompression = this.mPendingCompression;
                this.mWriteCipher = this.mPendingCipher;
                this.mWriteSeqNo = 0;
                return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  40);
        }
        internal virtual void ReceivedReadCipherSpec()
        {
            if((this.mPendingCompression != null) && (this.mPendingCipher != null))
            {
                    this.mReadCompression = this.mPendingCompression;
                this.mReadCipher = this.mPendingCipher;
                this.mReadSeqNo = 0;
                return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  40);
        }
        internal virtual void FinaliseHandshake()
        {
            static_value_082D1164 = true;
            if((((this.mReadCompression == this.mPendingCompression) && (this.mWriteCompression == this.mReadCompression)) && (this.mReadCipher == this.mPendingCipher)) && (this.mWriteCipher == this.mReadCipher))
            {
                    this.mPendingCompression = 0;
                this.mPendingCipher = 0;
                return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  40);
        }
        internal virtual bool ReadRecord()
        {
            var val_8;
            var val_9;
            System.Byte[] val_10;
            System.Byte[] val_11;
            System.Byte[] val_12;
            val_8 = this;
            val_10 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadAllOrNothing(length:  5, input:  this.mInput);
            if(val_10 == null)
            {
                    return (bool)val_9;
            }
            
            byte val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf:  val_10, offset:  0);
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckType(type:  val_2, alertDescription:  10);
            if(this.mRestrictReadVersion == false)
            {
                goto label_6;
            }
            
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_3 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(buf:  val_10, offset:  1);
            if(this.mReadVersion == null)
            {
                goto label_9;
            }
            
            if(val_3.version == this.mReadVersion.version)
            {
                goto label_15;
            }
            
            goto label_12;
            label_6:
            if(((Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersionRaw(buf:  val_10, offset:  1)) & 4294967040) == 768)
            {
                goto label_15;
            }
            
            label_12:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_6 = null;
            val_11 = val_6;
            val_6 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            label_9:
            mem[1152921547504351096] = ???;
            label_15:
            int val_7 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf:  val_10, offset:  3);
            val_12 = val_11;
            if(val_12 == null)
            {
                goto label_18;
            }
            
            label_21:
            val_10.ProcessRecord(protocol:  val_2, buf:  val_6, offset:  0, len:  typeof(Org.BouncyCastle.Crypto.Tls.TlsFatalAlert).__il2cppRuntimeField_230>>0&0xFFFFFFFF);
            val_9 = 1;
            return (bool)val_9;
            label_18:
            if(val_10 != null)
            {
                goto label_21;
            }
            
            goto label_21;
        }
        internal virtual byte[] DecodeAndVerify(byte type, System.IO.Stream input, int len)
        {
            var val_9;
            var val_10;
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(length:  len, limit:  this.mCiphertextLimit, alertDescription:  22);
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  len, input:  input);
            this.mReadSeqNo = this.mReadSeqNo + 1;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            label_10:
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_8;
            label_3:
            if(this.mReadCipher != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_8:
            val_9 = this.mReadCipher.DecodeCiphertext(seqNo:  this.mReadSeqNo, type:  type, ciphertext:  val_1, offset:  0, len:  val_1.Length);
            val_10 = 22;
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(length:  val_4.Length, limit:  this.mCompressedLimit, alertDescription:  22);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_10 = 1;
            System.IO.Stream val_6 = this.mReadCompression.Decompress(output:  this.mBuffer);
            if(val_6 == this.mBuffer)
            {
                goto label_17;
            }
            
            if(val_9 == null)
            {
                goto label_18;
            }
            
            label_26:
            val_9 = this.GetBufferContents();
            label_17:
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(length:  val_7.Length, limit:  this.mPlaintextLimit, alertDescription:  30);
            if((type & 255) == 23)
            {
                    return (System.Byte[])val_9;
            }
            
            if(val_7.Length <= 0)
            {
                goto label_24;
            }
            
            return (System.Byte[])val_9;
            label_18:
            if(val_6 != null)
            {
                goto label_26;
            }
            
            goto label_26;
            label_24:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_9 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        internal virtual void WriteRecord(byte type, byte[] plaintext, int plaintextOffset, int plaintextLength)
        {
            Org.BouncyCastle.Crypto.Tls.TlsCipher val_12;
            var val_13;
            var val_17;
            System.IO.Stream val_18;
            val_12 = plaintext;
            if(this.mWriteVersion == null)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckType(type:  type, alertDescription:  80);
            val_13 = 80;
            byte val_1 = type & 255;
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(length:  plaintextLength, limit:  this.mPlaintextLimit, alertDescription:  80);
            if(val_1 != 23)
            {
                    if(plaintextLength <= 0)
            {
                goto label_3;
            }
            
            }
            
            if(val_1 == 22)
            {
                    val_13 = plaintextOffset;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = 0;
            if((this.mWriteCompression.Compress(output:  this.mBuffer)) == this.mBuffer)
            {
                goto label_10;
            }
            
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(length:  val_4.Length, limit:  plaintextLength + 1024, alertDescription:  80);
            val_12 = this.mWriteCipher;
            this.mWriteSeqNo = this.mWriteSeqNo + 1;
            if(this.GetBufferContents() == null)
            {
                goto label_14;
            }
            
            label_26:
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_19;
            label_10:
            this.mWriteSeqNo = this.mWriteSeqNo + 1;
            var val_16 = 0;
            val_16 = val_16 + 1;
            goto label_24;
            label_14:
            if(val_12 != null)
            {
                goto label_26;
            }
            
            goto label_26;
            label_19:
            val_17 = val_12;
            goto label_27;
            label_24:
            val_17 = this.mWriteCipher;
            label_27:
            Org.BouncyCastle.Crypto.Tls.RecordStream.CheckLength(length:  val_10.Length, limit:  this.mCiphertextLimit, alertDescription:  80);
            int val_11 = val_10.Length + 5;
            byte[] val_12 = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  type, buf:  val_12, offset:  0);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(version:  this.mWriteVersion, buf:  val_12, offset:  1);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_10.Length, buf:  val_12, offset:  3);
            System.Array.Copy(sourceArray:  val_17.EncodePlaintext(seqNo:  this.mWriteSeqNo, type:  type, plaintext:  val_12, offset:  plaintextOffset, len:  plaintextLength), sourceIndex:  0, destinationArray:  val_12, destinationIndex:  5, length:  val_10.Length);
            val_18 = this.mOutput;
            if(val_12 == null)
            {
                goto label_32;
            }
            
            label_36:
            val_18 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_268;
            label_32:
            if(val_18 != 0)
            {
                goto label_36;
            }
            
            goto label_36;
            label_3:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_13 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        internal virtual void NotifyHelloComplete()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.mHandshakeHash = this.mHandshakeHash.NotifyPrfDetermined();
        }
        internal virtual Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash get_HandshakeHash()
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash)this.mHandshakeHash;
        }
        internal virtual Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash PrepareToFinish()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.mHandshakeHash = this.mHandshakeHash.StopTracking();
            return (Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash)this.mHandshakeHash;
        }
        internal virtual void UpdateHandshakeData(byte[] message, int offset, int len)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.mHandshakeHash.BlockUpdate(input:  message, inOff:  offset, length:  len);
        }
        internal virtual void SafeClose()
        {
            Org.BouncyCastle.Utilities.Platform.Dispose(s:  this.mInput);
            Org.BouncyCastle.Utilities.Platform.Dispose(s:  this.mOutput);
        }
        internal virtual void Flush()
        {
            if(this.mOutput == null)
            {
                
            }
        
        }
        private byte[] GetBufferContents()
        {
            if(this.mBuffer != null)
            {
                    return (System.Byte[])this.mBuffer;
            }
            
            return (System.Byte[])this.mBuffer;
        }
        private static void CheckType(byte type, byte alertDescription)
        {
            byte val_1 = type & 255;
            val_1 = val_1 - 20;
            if(val_1 < 5)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  alertDescription);
        }
        private static void CheckLength(int length, int limit, byte alertDescription)
        {
            if(length <= limit)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  alertDescription);
        }
    
    }

}
