using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class AlertDescription
    {
        // Fields
        public const byte close_notify = 0;
        public const byte unexpected_message = 10;
        public const byte bad_record_mac = 20;
        public const byte decryption_failed = 21;
        public const byte record_overflow = 22;
        public const byte decompression_failure = 30;
        public const byte handshake_failure = 40;
        public const byte no_certificate = 41;
        public const byte bad_certificate = 42;
        public const byte unsupported_certificate = 43;
        public const byte certificate_revoked = 44;
        public const byte certificate_expired = 45;
        public const byte certificate_unknown = 46;
        public const byte illegal_parameter = 47;
        public const byte unknown_ca = 48;
        public const byte access_denied = 49;
        public const byte decode_error = 50;
        public const byte decrypt_error = 51;
        public const byte export_restriction = 60;
        public const byte protocol_version = 70;
        public const byte insufficient_security = 71;
        public const byte internal_error = 80;
        public const byte user_canceled = 90;
        public const byte no_renegotiation = 100;
        public const byte unsupported_extension = 110;
        public const byte certificate_unobtainable = 111;
        public const byte unrecognized_name = 112;
        public const byte bad_certificate_status_response = 113;
        public const byte bad_certificate_hash_value = 114;
        public const byte unknown_psk_identity = 115;
        public const byte inappropriate_fallback = 86;
        
        // Methods
        public static string GetName(byte alertDescription)
        {
            var val_8;
            byte val_1 = alertDescription & 255;
            if(val_1 > 70)
            {
                goto label_1;
            }
            
            if(val_1 > 22)
            {
                goto label_2;
            }
            
            byte val_2 = alertDescription & 255;
            if(val_2 <= 19)
            {
                goto label_3;
            }
            
            if(val_2 == 22)
            {
                goto label_4;
            }
            
            if(val_2 == 21)
            {
                goto label_5;
            }
            
            if(val_2 != 20)
            {
                goto label_33;
            }
            
            val_8 = "bad_record_mac";
            return (string)val_8;
            label_1:
            if(val_1 > 86)
            {
                goto label_8;
            }
            
            byte val_3 = alertDescription & 255;
            if(val_3 == 71)
            {
                goto label_9;
            }
            
            if(val_3 == 80)
            {
                goto label_10;
            }
            
            if(val_3 != 86)
            {
                goto label_33;
            }
            
            val_8 = "inappropriate_fallback";
            return (string)val_8;
            label_2:
            byte val_4 = alertDescription & 255;
            if((val_4 - 40) > 30)
            {
                goto label_13;
            }
            
            var val_8 = 106048668;
            val_8 = (106048668 + (((alertDescription & 255) - 40)) << 2) + val_8;
            goto (106048668 + (((alertDescription & 255) - 40)) << 2 + 106048668);
            label_8:
            byte val_6 = alertDescription & 255;
            if((val_6 - 100) > 15)
            {
                goto label_15;
            }
            
            var val_9 = 106048604 + (((alertDescription & 255) - 100)) << 2;
            val_9 = val_9 + 106048604;
            goto (106048604 + (((alertDescription & 255) - 100)) << 2 + 106048604);
            label_3:
            if(val_2 == 0)
            {
                goto label_17;
            }
            
            if(val_2 != 10)
            {
                goto label_33;
            }
            
            val_8 = "unexpected_message";
            return (string)val_8;
            label_9:
            val_8 = "insufficient_security";
            return (string)val_8;
            label_10:
            val_8 = "internal_error";
            return (string)val_8;
            label_4:
            val_8 = "record_overflow";
            return (string)val_8;
            label_5:
            val_8 = "decryption_failed";
            return (string)val_8;
            label_15:
            if(val_6 != 90)
            {
                goto label_33;
            }
            
            val_8 = "user_canceled";
            return (string)val_8;
            label_17:
            val_8 = "close_notify";
            return (string)val_8;
            label_13:
            if(val_4 == 30)
            {
                    val_8 = "decompression_failure";
                return (string)val_8;
            }
            
            label_33:
            val_8 = "UNKNOWN";
            return (string)val_8;
        }
        public static string GetText(byte alertDescription)
        {
            object[] val_1 = new object[4];
            string val_2 = Org.BouncyCastle.Crypto.Tls.AlertDescription.GetName(alertDescription:  alertDescription);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = "(";
            val_1[2] = alertDescription;
            val_1[3] = ")";
            return (string)+val_1;
        }
        protected AlertDescription()
        {
        
        }
    
    }

}
