using UnityEngine;

namespace BestHTTP.Authentication
{
    public sealed class Digest
    {
        // Fields
        private System.Uri <Uri>k__BackingField;
        private BestHTTP.Authentication.AuthenticationTypes <Type>k__BackingField;
        private string <Realm>k__BackingField;
        private bool <Stale>k__BackingField;
        private string <Nonce>k__BackingField;
        private string <Opaque>k__BackingField;
        private string <Algorithm>k__BackingField;
        private System.Collections.Generic.List<string> <ProtectedUris>k__BackingField;
        private string <QualityOfProtections>k__BackingField;
        private int <NonceCount>k__BackingField;
        private string <HA1Sess>k__BackingField;
        
        // Properties
        public System.Uri Uri { get; set; }
        public BestHTTP.Authentication.AuthenticationTypes Type { get; set; }
        public string Realm { get; set; }
        public bool Stale { get; set; }
        private string Nonce { get; set; }
        private string Opaque { get; set; }
        private string Algorithm { get; set; }
        public System.Collections.Generic.List<string> ProtectedUris { get; set; }
        private string QualityOfProtections { get; set; }
        private int NonceCount { get; set; }
        private string HA1Sess { get; set; }
        
        // Methods
        public System.Uri get_Uri()
        {
            return (System.Uri)this.<Uri>k__BackingField;
        }
        private void set_Uri(System.Uri value)
        {
            this.<Uri>k__BackingField = value;
        }
        public BestHTTP.Authentication.AuthenticationTypes get_Type()
        {
            return (BestHTTP.Authentication.AuthenticationTypes)this.<Type>k__BackingField;
        }
        private void set_Type(BestHTTP.Authentication.AuthenticationTypes value)
        {
            this.<Type>k__BackingField = value;
        }
        public string get_Realm()
        {
            return (string)this.<Realm>k__BackingField;
        }
        private void set_Realm(string value)
        {
            this.<Realm>k__BackingField = value;
        }
        public bool get_Stale()
        {
            return (bool)this.<Stale>k__BackingField;
        }
        private void set_Stale(bool value)
        {
            this.<Stale>k__BackingField = value;
        }
        private string get_Nonce()
        {
            return (string)this.<Nonce>k__BackingField;
        }
        private void set_Nonce(string value)
        {
            this.<Nonce>k__BackingField = value;
        }
        private string get_Opaque()
        {
            return (string)this.<Opaque>k__BackingField;
        }
        private void set_Opaque(string value)
        {
            this.<Opaque>k__BackingField = value;
        }
        private string get_Algorithm()
        {
            return (string)this.<Algorithm>k__BackingField;
        }
        private void set_Algorithm(string value)
        {
            this.<Algorithm>k__BackingField = value;
        }
        public System.Collections.Generic.List<string> get_ProtectedUris()
        {
            return (System.Collections.Generic.List<System.String>)this.<ProtectedUris>k__BackingField;
        }
        private void set_ProtectedUris(System.Collections.Generic.List<string> value)
        {
            this.<ProtectedUris>k__BackingField = value;
        }
        private string get_QualityOfProtections()
        {
            return (string)this.<QualityOfProtections>k__BackingField;
        }
        private void set_QualityOfProtections(string value)
        {
            this.<QualityOfProtections>k__BackingField = value;
        }
        private int get_NonceCount()
        {
            return (int)this.<NonceCount>k__BackingField;
        }
        private void set_NonceCount(int value)
        {
            this.<NonceCount>k__BackingField = value;
        }
        private string get_HA1Sess()
        {
            return (string)this.<HA1Sess>k__BackingField;
        }
        private void set_HA1Sess(string value)
        {
            this.<HA1Sess>k__BackingField = value;
        }
        internal Digest(System.Uri uri)
        {
            this.<Uri>k__BackingField = uri;
            this.<Algorithm>k__BackingField = "md5";
        }
        public void ParseChallange(string header)
        {
            var val_5;
            var val_38;
            string val_39;
            BestHTTP.Authentication.AuthenticationTypes val_40;
            val_38 = this;
            this.<Type>k__BackingField = 0;
            this.<Stale>k__BackingField = false;
            this.<Opaque>k__BackingField = 0;
            this.<HA1Sess>k__BackingField = 0;
            this.<NonceCount>k__BackingField = 0;
            this.<QualityOfProtections>k__BackingField = 0;
            if((this.<ProtectedUris>k__BackingField) != null)
            {
                    this.<ProtectedUris>k__BackingField.Clear();
            }
            
            BestHTTP.Extensions.WWWAuthenticateHeaderParser val_1 = null;
            val_39 = val_1;
            val_1 = new BestHTTP.Extensions.WWWAuthenticateHeaderParser(headerValue:  header);
            List.Enumerator<T> val_3 = val_1.Values.GetEnumerator();
            val_40 = 1;
            goto label_57;
            label_59:
            string val_6 = val_5.丐丏七丌丕丗业且上();
            val_39 = val_6.Key;
            uint val_8 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_39);
            if(val_8 >= 1863671839)
            {
                goto label_6;
            }
            
            if(val_8 > 474311018)
            {
                goto label_7;
            }
            
            if(val_8 == 87360061)
            {
                goto label_8;
            }
            
            if((val_8 != 474311018) || ((System.String.op_Equality(a:  val_39, b:  "algorithm")) == false))
            {
                goto label_57;
            }
            
            this.<Algorithm>k__BackingField = val_6.Value;
            goto label_57;
            label_6:
            if(val_8 > (-409757711))
            {
                goto label_13;
            }
            
            if(val_8 == (-409757711))
            {
                goto label_14;
            }
            
            if((val_8 != 1914854288) || ((System.String.op_Equality(a:  val_39, b:  "realm")) == false))
            {
                goto label_57;
            }
            
            this.<Realm>k__BackingField = val_6.Value;
            goto label_57;
            label_7:
            if(val_8 == 1749328254)
            {
                goto label_19;
            }
            
            if((val_8 != 1863671838) || ((System.String.op_Equality(a:  val_39, b:  "opaque")) == false))
            {
                goto label_57;
            }
            
            this.<Opaque>k__BackingField = val_6.Value;
            goto label_57;
            label_13:
            if(val_8 == (-151430213))
            {
                goto label_24;
            }
            
            if(val_8 == (-116885000))
            {
                goto label_25;
            }
            
            if((val_8 != (-115059235)) || ((System.String.op_Equality(a:  val_39, b:  "digest")) == false))
            {
                goto label_57;
            }
            
            this.<Type>k__BackingField = 2;
            goto label_57;
            label_8:
            if((System.String.op_Equality(a:  val_39, b:  "basic")) == false)
            {
                goto label_57;
            }
            
            this.<Type>k__BackingField = val_40;
            goto label_57;
            label_14:
            if(((System.String.op_Equality(a:  val_39, b:  "domain")) == false) || ((System.String.IsNullOrEmpty(value:  val_6.Value)) == true))
            {
                goto label_57;
            }
            
            val_39 = val_6.Value;
            if(val_39.Length == 0)
            {
                goto label_57;
            }
            
            if((this.<ProtectedUris>k__BackingField) == null)
            {
                    System.Collections.Generic.List<System.String> val_22 = new System.Collections.Generic.List<System.String>();
                this.<ProtectedUris>k__BackingField = null;
            }
            
            int val_24 = 0;
            do
            {
                this.<ProtectedUris>k__BackingField.Add(item:  BestHTTP.Extensions.Extensions.Read(str:  val_6.Value, pos: ref  val_24, block:  ' ', needResult:  true));
                val_39 = BestHTTP.Extensions.Extensions.Read(str:  val_6.Value, pos: ref  val_24, block:  ' ', needResult:  true);
                val_40 = 1;
            }
            while(0 < val_6.Value.Length);
            
            goto label_57;
            label_19:
            if((System.String.op_Equality(a:  val_39, b:  "stale")) == false)
            {
                goto label_57;
            }
            
            this.<Stale>k__BackingField = System.Boolean.Parse(value:  val_6.Value);
            goto label_57;
            label_24:
            if((System.String.op_Equality(a:  val_39, b:  "qop")) == false)
            {
                goto label_57;
            }
            
            this.<QualityOfProtections>k__BackingField = val_6.Value;
            goto label_57;
            label_25:
            if((System.String.op_Equality(a:  val_39, b:  "nonce")) != false)
            {
                    this.<Nonce>k__BackingField = val_6.Value;
            }
            
            label_57:
            if((2016692656 & 1) != 0)
            {
                goto label_59;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public string GenerateResponseHeader(BestHTTP.HTTPRequest request, BestHTTP.Authentication.Credentials credentials, bool isProxy = False)
        {
            object val_59;
            object val_60;
            System.Byte[] val_61;
            object val_62;
            object val_63;
            string val_64;
            string val_65;
            string val_66;
            string val_67;
            string val_68;
            var val_69;
            var val_70;
            object val_71;
            object val_72;
            System.Byte[] val_73;
            object val_74;
            val_59 = isProxy;
            val_60 = request;
            val_61 = this;
            if((this.<Type>k__BackingField) == 1)
            {
                goto label_1;
            }
            
            if((this.<Type>k__BackingField) != 2)
            {
                goto label_85;
            }
            
            int val_59 = this.<NonceCount>k__BackingField;
            val_59 = val_59 + 1;
            this.<NonceCount>k__BackingField = val_59;
            new System.Random() = new System.Random(Seed:  val_60.GetHashCode());
            val_62 = new System.Random().ToString(format:  "X8");
            val_63 = this.<NonceCount>k__BackingField.ToString(format:  "X8");
            string val_5 = BestHTTP.Extensions.Extensions.TrimAndLower(str:  this.<Algorithm>k__BackingField);
            if((System.String.op_Equality(a:  val_5, b:  "md5")) == false)
            {
                goto label_7;
            }
            
            if(credentials == null)
            {
                goto label_8;
            }
            
            val_64 = credentials.<UserName>k__BackingField;
            val_65 = this.<Realm>k__BackingField;
            goto label_9;
            label_1:
            if(credentials == null)
            {
                goto label_10;
            }
            
            val_66 = credentials.<UserName>k__BackingField;
            goto label_11;
            label_7:
            if((System.String.op_Equality(a:  val_5, b:  "md5-sess")) == false)
            {
                goto label_85;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.<HA1Sess>k__BackingField)) == false)
            {
                goto label_13;
            }
            
            object[] val_10 = new object[5];
            val_10[0] = credentials.<UserName>k__BackingField;
            val_10[1] = this.<Realm>k__BackingField;
            val_10[2] = credentials.<Password>k__BackingField;
            val_10[3] = this.<Nonce>k__BackingField;
            val_10[4] = val_63;
            this.<HA1Sess>k__BackingField = BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  System.String.Format(format:  "{0}:{1}:{2}:{3}:{4}", args:  val_10));
            goto label_40;
            label_10:
            val_66 = 28563616;
            label_11:
            string val_13 = System.String.Format(format:  "{0}:{1}", arg0:  val_66, arg1:  credentials.<Password>k__BackingField);
            val_61 = System.Text.Encoding.UTF8;
            val_68 = "Basic " + System.Convert.ToBase64String(inArray:  val_61)(System.Convert.ToBase64String(inArray:  val_61));
            return (string)val_68;
            label_8:
            val_64 = 28563616;
            val_65 = this.<Realm>k__BackingField;
            label_9:
            string val_17 = BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  System.String.Format(format:  "{0}:{1}:{2}", arg0:  val_64, arg1:  val_65, arg2:  credentials.<Password>k__BackingField));
            goto label_40;
            label_13:
            val_67 = this.<HA1Sess>k__BackingField;
            label_40:
            if((this.<QualityOfProtections>k__BackingField) == null)
            {
                goto label_41;
            }
            
            val_69 = 1152921505558708224;
            val_70 = BestHTTP.Extensions.Extensions.TrimAndLower(str:  this.<QualityOfProtections>k__BackingField);
            if(val_59 == false)
            {
                goto label_44;
            }
            
            label_48:
            val_71 = val_62;
            val_62 = "CONNECT";
            val_72 = System.String.Format(format:  "{0}:{1}", arg0:  val_60.CurrentUri.Host, arg1:  val_60.CurrentUri.Port);
            goto label_47;
            label_41:
            val_69 = 1152921505558708224;
            val_70 = 0;
            if(val_59 == true)
            {
                goto label_48;
            }
            
            label_44:
            val_71 = val_62;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_62 = val_60.MethodType.ToString().ToUpper();
            val_72 = BestHTTP.Extensions.Extensions.GetRequestPathAndQueryURL(uri:  val_60.CurrentUri);
            label_47:
            if(val_70 == 0)
            {
                goto label_53;
            }
            
            if((val_70.Contains(value:  "auth-int")) == false)
            {
                goto label_54;
            }
            
            val_59 = "auth-int";
            val_73 = val_60.GetEntityBody();
            val_74 = val_63;
            if(val_73 == null)
            {
                    val_73 = BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  System.String.alignConst);
            }
            
            val_62 = val_71;
            object[] val_35 = new object[6];
            val_63 = val_35;
            val_63[0] = val_67;
            val_63[1] = this.<Nonce>k__BackingField;
            val_63[2] = val_74;
            val_63[3] = val_62;
            val_63[4] = val_59;
            val_63[5] = BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  System.String.Format(format:  "{0}:{1}:{2}", arg0:  val_62, arg1:  val_72, arg2:  BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  val_73)));
            val_60 = BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  System.String.Format(format:  "{0}:{1}:{2}:{3}:{4}:{5}", args:  val_35));
            goto label_84;
            label_53:
            val_74 = val_63;
            val_62 = val_71;
            val_63 = val_60.MethodType.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_60 = BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  System.String.Format(format:  "{0}:{1}:{2}", arg0:  val_67, arg1:  this.<Nonce>k__BackingField, arg2:  BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  val_63.ToUpper() + ":"(":") + BestHTTP.Extensions.Extensions.GetRequestPathAndQueryURL(uri:  val_60.CurrentUri)(BestHTTP.Extensions.Extensions.GetRequestPathAndQueryURL(uri:  val_60.CurrentUri)))));
            val_59 = 0;
            goto label_84;
            label_54:
            val_59 = "auth";
            val_74 = val_63;
            if((val_70.Contains(value:  "auth")) == false)
            {
                goto label_85;
            }
            
            val_59 = "auth";
            val_62 = val_71;
            object[] val_50 = new object[6];
            val_63 = val_50;
            val_63[0] = val_67;
            val_63[1] = this.<Nonce>k__BackingField;
            val_63[2] = val_74;
            val_63[3] = val_62;
            val_63[4] = val_59;
            val_63[5] = BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  val_62 + ":"(":") + val_72);
            val_60 = BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  System.String.Format(format:  "{0}:{1}:{2}:{3}:{4}:{5}", args:  val_50));
            label_84:
            object[] val_53 = new object[6];
            val_53[0] = credentials.<UserName>k__BackingField;
            val_53[1] = this.<Realm>k__BackingField;
            val_53[2] = this.<Nonce>k__BackingField;
            val_53[3] = val_72;
            val_53[4] = val_62;
            val_53[5] = val_60;
            val_68 = System.String.Format(format:  "Digest username=\"{0}\", realm=\"{1}\", nonce=\"{2}\", uri=\"{3}\", cnonce=\"{4}\", response=\"{5}\"", args:  val_53);
            string[] val_55 = new string[5];
            val_62 = val_55;
            val_62[0] = val_68;
            val_62[1] = ", qop=\"";
            val_62[2] = val_59;
            val_62[3] = "\", nc=";
            val_62[4] = val_74;
            val_68 = +val_55;
            if((System.String.IsNullOrEmpty(value:  this.<Opaque>k__BackingField)) == true)
            {
                    return (string)val_68;
            }
            
            val_68 = val_68 + ", opaque=\""(", opaque=\"") + this.<Opaque>k__BackingField(this.<Opaque>k__BackingField) + "\"";
            return (string)val_68;
            label_85:
            val_68 = System.String.alignConst;
            return (string)val_68;
        }
        public bool IsUriProtected(System.Uri uri)
        {
            string val_8;
            var val_9;
            val_8 = uri.Host;
            if((System.String.CompareOrdinal(strA:  val_8, strB:  this.<Uri>k__BackingField.Host)) != 0)
            {
                    val_9 = 0;
                return (bool)val_9;
            }
            
            if(((this.<ProtectedUris>k__BackingField) == null) || ((this.<ProtectedUris>k__BackingField.Count) < 1))
            {
                goto label_9;
            }
            
            val_8 = 0;
            label_12:
            if(val_8 >= (this.<ProtectedUris>k__BackingField.Count))
            {
                goto label_9;
            }
            
            val_8 = val_8 + 1;
            if((uri.Contains(value:  this.<ProtectedUris>k__BackingField.Item[0])) == false)
            {
                goto label_12;
            }
            
            label_9:
            val_9 = 1;
            return (bool)val_9;
        }
    
    }

}
