using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public sealed class ProtocolVersion
    {
        // Fields
        public static readonly Org.BouncyCastle.Crypto.Tls.ProtocolVersion SSLv3;
        public static readonly Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv10;
        public static readonly Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv11;
        public static readonly Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv12;
        public static readonly Org.BouncyCastle.Crypto.Tls.ProtocolVersion DTLSv10;
        public static readonly Org.BouncyCastle.Crypto.Tls.ProtocolVersion DTLSv12;
        private readonly int version;
        private readonly string name;
        
        // Properties
        public int FullVersion { get; }
        public int MajorVersion { get; }
        public int MinorVersion { get; }
        public bool IsDtls { get; }
        public bool IsSsl { get; }
        public bool IsTls { get; }
        
        // Methods
        private ProtocolVersion(int v, string name)
        {
            val_1 = new System.Object();
            this.version = v & 65535;
            this.name = val_1;
        }
        public int get_FullVersion()
        {
            return (int)this.version;
        }
        public int get_MajorVersion()
        {
            return (int)this.version >> 8;
        }
        public int get_MinorVersion()
        {
            return (int)this.version;
        }
        public bool get_IsDtls()
        {
            int val_2 = this.version;
            val_2 = val_2 >> 8;
            return (bool)(val_2 == 254) ? 1 : 0;
        }
        public bool get_IsSsl()
        {
            null = null;
            return (bool)(Org.BouncyCastle.Crypto.Tls.ProtocolVersion.SSLv3 == this) ? 1 : 0;
        }
        public bool get_IsTls()
        {
            int val_2 = this.version;
            val_2 = val_2 & 4294967040;
            return (bool)(val_2 == 768) ? 1 : 0;
        }
        public Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetEquivalentTLSVersion()
        {
            var val_1;
            var val_2;
            var val_6;
            val_1 = this;
            int val_1 = this.version;
            val_1 = val_1 >> 8;
            if(val_1 != 254)
            {
                    return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)val_6;
            }
            
            val_2 = null;
            val_2 = null;
            if(Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv10 != val_1)
            {
                    val_6 = 1152921505526763544;
                return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)val_6;
            }
            
            val_6 = 1152921505526763536;
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)val_6;
        }
        public bool IsEqualOrEarlierVersionOf(Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
        {
            var val_5;
            int val_4 = version.version;
            if(val_4 ^ this.version > 255)
            {
                goto label_1;
            }
            
            val_4 = val_4 & 255;
            val_4 = val_4 - this.version;
            if((this.version >> 8) != 254)
            {
                goto label_2;
            }
            
            var val_3 = (val_4 < 1) ? 1 : 0;
            return (bool)val_5;
            label_1:
            val_5 = 0;
            return (bool)val_5;
            label_2:
            val_4 = val_4 >> 31;
            val_5 = val_4 ^ 1;
            return (bool)val_5;
        }
        public bool IsLaterVersionOf(Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
        {
            var val_5;
            int val_4 = version.version;
            if(val_4 ^ this.version > 255)
            {
                goto label_1;
            }
            
            val_4 = val_4 & 255;
            val_4 = val_4 - this.version;
            if((this.version >> 8) != 254)
            {
                goto label_2;
            }
            
            var val_3 = (val_4 > 0) ? 1 : 0;
            return (bool)val_5;
            label_1:
            val_5 = 0;
            return (bool)val_5;
            label_2:
            val_5 = val_4 >> 31;
            return (bool)val_5;
        }
        public override bool Equals(object other)
        {
            var val_2;
            if(this != other)
            {
                    if(other != null)
            {
                    if(null == null)
            {
                    return (bool)(this.version == null) ? 1 : 0;
            }
            
            }
            
                val_2 = 0;
                return (bool)(this.version == null) ? 1 : 0;
            }
            
            val_2 = 1;
            return (bool)(this.version == null) ? 1 : 0;
        }
        public bool Equals(Org.BouncyCastle.Crypto.Tls.ProtocolVersion other)
        {
            if(other == null)
            {
                    return false;
            }
            
            return (bool)(this.version == other.version) ? 1 : 0;
        }
        public override int GetHashCode()
        {
            return (int)this.version;
        }
        public static Org.BouncyCastle.Crypto.Tls.ProtocolVersion Get(int major, int minor)
        {
            var val_7;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_9;
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            if(major == 254)
            {
                goto label_1;
            }
            
            if(major != 3)
            {
                goto label_9;
            }
            
            if(minor > 3)
            {
                goto label_3;
            }
            
            var val_7 = 106068348 + (minor) << 2;
            val_7 = val_7 + 106068348;
            goto (106068348 + (minor) << 2 + 106068348);
            label_1:
            if(minor == 253)
            {
                goto label_7;
            }
            
            if(minor == 255)
            {
                goto label_8;
            }
            
            if(minor == 254)
            {
                goto label_9;
            }
            
            val_10 = "DTLS";
            val_11 = 254;
            return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.GetUnknownVersion(major:  3, minor:  minor, prefix:  val_10 = "TLS");
            label_7:
            val_7 = 1152921505526759424;
            val_12 = null;
            val_12 = null;
            val_9 = Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv12;
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion);
            label_8:
            val_7 = 1152921505526759424;
            val_13 = null;
            val_13 = null;
            val_9 = Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv10;
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion);
            label_3:
            val_11 = 3;
            return Org.BouncyCastle.Crypto.Tls.ProtocolVersion.GetUnknownVersion(major:  3, minor:  minor, prefix:  val_10);
            label_9:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_6 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public override string ToString()
        {
            return (string)this.name;
        }
        private static Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
        {
            int val_8 = major;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(i:  val_8);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(i:  minor);
            val_8 = minor | (val_8 << 8);
            .version = val_8 & 65535;
            .name = prefix + " 0x" + Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  System.Convert.ToString(value:  val_8 | 65536, toBase:  16).Substring(startIndex:  1))(Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  System.Convert.ToString(value:  val_8 | 65536, toBase:  16).Substring(startIndex:  1)));
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)new Org.BouncyCastle.Crypto.Tls.ProtocolVersion();
        }
        private static ProtocolVersion()
        {
            .version = 768;
            .name = "SSL 3.0";
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion.SSLv3 = new Org.BouncyCastle.Crypto.Tls.ProtocolVersion();
            .version = 769;
            .name = "TLS 1.0";
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10 = new Org.BouncyCastle.Crypto.Tls.ProtocolVersion();
            .version = 770;
            .name = "TLS 1.1";
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11 = new Org.BouncyCastle.Crypto.Tls.ProtocolVersion();
            .version = 771;
            .name = "TLS 1.2";
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12 = new Org.BouncyCastle.Crypto.Tls.ProtocolVersion();
            .version = 65279;
            .name = "DTLS 1.0";
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv10 = new Org.BouncyCastle.Crypto.Tls.ProtocolVersion();
            .version = 65277;
            .name = "DTLS 1.2";
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv12 = new Org.BouncyCastle.Crypto.Tls.ProtocolVersion();
        }
    
    }

}
