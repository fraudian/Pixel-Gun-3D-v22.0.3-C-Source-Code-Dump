using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class X509Name : Asn1Encodable
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier C;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier O;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier OU;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier T;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CN;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Street;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SerialNumber;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier L;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ST;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Surname;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier GivenName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Initials;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Generation;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier UniqueIdentifier;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BusinessCategory;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PostalCode;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DnQualifier;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Pseudonym;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DateOfBirth;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PlaceOfBirth;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Gender;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CountryOfCitizenship;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CountryOfResidence;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NameAtBirth;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PostalAddress;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DmdName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier TelephoneNumber;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier Name;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier EmailAddress;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier UnstructuredName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier UnstructuredAddress;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier E;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DC;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier UID;
        private static readonly bool[] defaultReverse;
        public static readonly System.Collections.Hashtable DefaultSymbols;
        public static readonly System.Collections.Hashtable RFC2253Symbols;
        public static readonly System.Collections.Hashtable RFC1779Symbols;
        public static readonly System.Collections.Hashtable DefaultLookup;
        private readonly System.Collections.IList ordering;
        private readonly Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter;
        private System.Collections.IList values;
        private System.Collections.IList added;
        private Org.BouncyCastle.Asn1.Asn1Sequence seq;
        
        // Properties
        public static bool DefaultReverse { get; set; }
        
        // Methods
        public static bool get_DefaultReverse()
        {
            null = null;
            if(Org.BouncyCastle.Asn1.X509.X509Name.defaultReverse.Length != 0)
            {
                    return (bool)Org.BouncyCastle.Asn1.X509.X509Name.defaultReverse + 32;
            }
            
            return (bool)Org.BouncyCastle.Asn1.X509.X509Name.defaultReverse + 32;
        }
        public static void set_DefaultReverse(bool value)
        {
            null = null;
            Org.BouncyCastle.Asn1.X509.X509Name.defaultReverse.__unknownFiledOffset_20 = value;
        }
        private static X509Name()
        {
            var val_34;
            var val_35;
            var val_36;
            Org.BouncyCastle.Asn1.X509.X509Name.C = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.6");
            Org.BouncyCastle.Asn1.X509.X509Name.O = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.10");
            Org.BouncyCastle.Asn1.X509.X509Name.OU = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.11");
            Org.BouncyCastle.Asn1.X509.X509Name.T = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.12");
            Org.BouncyCastle.Asn1.X509.X509Name.CN = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.3");
            Org.BouncyCastle.Asn1.X509.X509Name.Street = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.9");
            Org.BouncyCastle.Asn1.X509.X509Name.SerialNumber = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.5");
            Org.BouncyCastle.Asn1.X509.X509Name.L = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.7");
            Org.BouncyCastle.Asn1.X509.X509Name.ST = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.8");
            Org.BouncyCastle.Asn1.X509.X509Name.Surname = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.4");
            Org.BouncyCastle.Asn1.X509.X509Name.GivenName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.42");
            Org.BouncyCastle.Asn1.X509.X509Name.Initials = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.43");
            Org.BouncyCastle.Asn1.X509.X509Name.Generation = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.44");
            Org.BouncyCastle.Asn1.X509.X509Name.UniqueIdentifier = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.45");
            Org.BouncyCastle.Asn1.X509.X509Name.BusinessCategory = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.15");
            Org.BouncyCastle.Asn1.X509.X509Name.PostalCode = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.17");
            Org.BouncyCastle.Asn1.X509.X509Name.DnQualifier = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.46");
            Org.BouncyCastle.Asn1.X509.X509Name.Pseudonym = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.65");
            Org.BouncyCastle.Asn1.X509.X509Name.DateOfBirth = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.9.1");
            Org.BouncyCastle.Asn1.X509.X509Name.PlaceOfBirth = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.9.2");
            Org.BouncyCastle.Asn1.X509.X509Name.Gender = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.9.3");
            Org.BouncyCastle.Asn1.X509.X509Name.CountryOfCitizenship = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.9.4");
            Org.BouncyCastle.Asn1.X509.X509Name.CountryOfResidence = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.9.5");
            Org.BouncyCastle.Asn1.X509.X509Name.NameAtBirth = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.36.8.3.14");
            Org.BouncyCastle.Asn1.X509.X509Name.PostalAddress = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.16");
            val_34 = null;
            Org.BouncyCastle.Asn1.X509.X509Name.DmdName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.4.54");
            val_35 = null;
            val_35 = null;
            val_34 = null;
            Org.BouncyCastle.Asn1.X509.X509Name.TelephoneNumber = Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.id_at_telephoneNumber;
            Org.BouncyCastle.Asn1.X509.X509Name.Name = Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.id_at_name;
            val_36 = null;
            val_36 = null;
            val_34 = null;
            Org.BouncyCastle.Asn1.X509.X509Name.EmailAddress = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtEmailAddress;
            Org.BouncyCastle.Asn1.X509.X509Name.UnstructuredName = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtUnstructuredName;
            Org.BouncyCastle.Asn1.X509.X509Name.UnstructuredAddress = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtUnstructuredAddress;
            Org.BouncyCastle.Asn1.X509.X509Name.E = Org.BouncyCastle.Asn1.X509.X509Name.EmailAddress;
            Org.BouncyCastle.Asn1.X509.X509Name.DC = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "0.9.2342.19200300.100.1.25");
            Org.BouncyCastle.Asn1.X509.X509Name.UID = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "0.9.2342.19200300.100.1.1");
            Org.BouncyCastle.Asn1.X509.X509Name.defaultReverse = new bool[1];
            Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols = new System.Collections.Hashtable();
            Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols = new System.Collections.Hashtable();
            Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols = new System.Collections.Hashtable();
            Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup = new System.Collections.Hashtable();
            if(Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup == null)
            {
                
            }
        
        }
        public static Org.BouncyCastle.Asn1.X509.X509Name GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            explicitly = explicitly;
            return Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.X509Name GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509Name)val_3;
            }
            
            Org.BouncyCastle.Asn1.X509.X509Name val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X509.X509Name(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X509.X509Name)val_3;
        }
        protected X509Name()
        {
            this.ordering = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.values = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.added = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
        }
        protected X509Name(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            object val_19;
            var val_32;
            object val_33;
            object val_34;
            var val_35;
            System.Collections.IList val_36;
            var val_37;
            object val_38;
            var val_40;
            var val_41;
            System.Collections.IList val_42;
            var val_43;
            string val_44;
            var val_45;
            var val_47;
            var val_48;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            this.ordering = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.values = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.added = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.seq = seq;
            if(seq != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_72:
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_32 = public System.Object System.Collections.IEnumerator::get_Current();
            val_33 = seq.Current;
            if(val_33 != null)
            {
                    val_32 = 0;
            }
            
            if(val_33 != null)
            {
                    val_32 = null;
                val_32 = 0;
                val_33 = 0;
            }
            
            val_34 = 0;
            Org.BouncyCastle.Asn1.Asn1Set val_10 = Org.BouncyCastle.Asn1.Asn1Set.GetInstance(obj:  val_33);
            val_35 = 0;
            goto label_16;
            label_66:
            val_36 = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_10.ToAsn1Object());
            if(val_36 != 2)
            {
                goto label_19;
            }
            
            val_38 = Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj:  val_36.ToAsn1Object());
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_37 = 2;
            int val_16 = this.ordering.Add(value:  val_38);
            Org.BouncyCastle.Asn1.Asn1Object val_17 = val_36.ToAsn1Object();
            val_40 = null;
            if(val_17 == null)
            {
                goto label_30;
            }
            
            if(val_17 == null)
            {
                goto label_31;
            }
            
            if(val_17 == null)
            {
                goto label_34;
            }
            
            val_41 = null;
            goto label_35;
            label_30:
            val_42 = this.values;
            if(val_17 != null)
            {
                goto label_37;
            }
            
            goto label_37;
            label_34:
            val_40 = 0;
            label_31:
            val_41 = null;
            if(val_17 == null)
            {
                goto label_38;
            }
            
            label_35:
            val_40 = val_41;
            val_38 = val_17;
            if(val_38 != null)
            {
                goto label_39;
            }
            
            val_40 = 0;
            label_38:
            val_38 = 0;
            label_39:
            if(mem[282584257676957] == 0)
            {
                goto label_40;
            }
            
            var val_39 = mem[282584257676847];
            var val_40 = 0;
            val_39 = val_39 + 8;
            label_42:
            if(((mem[282584257676847] + 8) + -8) == val_41)
            {
                goto label_41;
            }
            
            val_40 = val_40 + 1;
            val_39 = val_39 + 16;
            if(val_40 < mem[282584257676957])
            {
                goto label_42;
            }
            
            label_40:
            val_40 = val_41;
            goto label_43;
            label_41:
            val_38 = val_38 + (((mem[282584257676847] + 8)) << 4);
            val_43 = val_38 + 296;
            label_43:
            val_44 = val_38.GetString();
            val_45 = 0;
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_44, prefix:  "#")) != false)
            {
                    val_45 = 0;
                val_44 = "\\" + val_44;
            }
            
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_45 = 2;
            val_47 = public System.Int32 System.Collections.IList::Add(object value);
            int val_24 = this.values.Add(value:  val_44);
            goto label_52;
            label_37:
            val_48 = 0;
            var val_42 = 0;
            val_42 = val_42 + 1;
            val_48 = 2;
            val_47 = public System.Int32 System.Collections.IList::Add(object value);
            int val_29 = Add(value:  "#" + Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  val_17.GetEncoded())(Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  val_17.GetEncoded())));
            label_52:
            val_36 = this.added;
            val_19 = (val_35 != 0) ? 1 : 0;
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_47 = 2;
            val_34 = val_19;
            int val_32 = val_36.Add(value:  val_19);
            val_35 = 1;
            label_16:
            if(val_35 < val_10)
            {
                goto label_66;
            }
            
            label_4:
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(seq.MoveNext() == true)
            {
                goto label_72;
            }
            
            val_52 = 0;
            val_53 = 0;
            goto label_73;
            label_19:
            new System.ArgumentException() = new System.ArgumentException(message:  "badly sized pair");
            val_54 = 0;
            val_55 = new System.ArgumentException();
            if(val_54 != 1)
            {
                goto label_109;
            }
            
            val_52 = 0;
            label_73:
            if(seq != null)
            {
                    var val_45 = 0;
                val_45 = val_45 + 1;
                seq.Dispose();
            }
            
            if(val_52 != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_109:
        }
        public X509Name(System.Collections.IList ordering, System.Collections.IDictionary attributes)
        {
            Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter val_1 = new Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter();
        }
        public X509Name(System.Collections.IList ordering, System.Collections.IDictionary attributes, Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
        {
            object val_16;
            var val_17;
            var val_22;
            var val_24;
            var val_26;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            this.ordering = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.values = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.added = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.converter = converter;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_17 = 0;
            System.Collections.IEnumerator val_5 = ordering.GetEnumerator();
            label_43:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_17 = 0;
            if(val_5.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_17 = 1;
            val_16 = val_5.Current;
            if(val_16 != null)
            {
                    val_17 = 0;
                val_16 = 0;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_17 = 0;
            val_22 = public System.Object System.Collections.IDictionary::get_Item(object key);
            object val_13 = attributes.Item[val_16];
            if(val_13 == null)
            {
                goto label_27;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_22 = 2;
            val_24 = public System.Int32 System.Collections.IList::Add(object value);
            int val_15 = this.ordering.Add(value:  val_16);
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_24 = 2;
            val_26 = public System.Int32 System.Collections.IList::Add(object value);
            int val_17 = this.added.Add(value:  null);
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_26 = 2;
            int val_19 = this.values.Add(value:  val_13);
            goto label_43;
            label_13:
            val_28 = 0;
            val_29 = 0;
            goto label_44;
            label_27:
            new System.ArgumentException() = new System.ArgumentException(message:  "No attribute for object id - "("No attribute for object id - ") + val_16 + " - passed to distinguished name"(" - passed to distinguished name"));
            val_30 = 0;
            val_31 = new System.ArgumentException();
            if(val_30 != 1)
            {
                goto label_57;
            }
            
            val_28 = 0;
            label_44:
            if(val_5 != null)
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_5.Dispose();
            }
            
            if(val_28 != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_57:
        }
        public X509Name(System.Collections.IList oids, System.Collections.IList values)
        {
            Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter val_1 = new Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter();
        }
        public X509Name(System.Collections.IList oids, System.Collections.IList values, Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
        {
            System.Collections.IList val_13;
            var val_16;
            var val_18;
            var val_20;
            var val_22;
            var val_24;
            this.ordering = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.values = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.added = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.converter = converter;
            var val_21 = 0;
            val_21 = val_21 + 1;
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(oids.Count != values.Count)
            {
                goto label_13;
            }
            
            val_16 = 0;
            goto label_14;
            label_45:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_18 = public System.Object System.Collections.IList::get_Item(int index);
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_18 = 2;
            val_20 = public System.Int32 System.Collections.IList::Add(object value);
            int val_11 = this.ordering.Add(value:  oids.Item[0]);
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_20 = 0;
            val_22 = public System.Object System.Collections.IList::get_Item(int index);
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_22 = 2;
            val_24 = public System.Int32 System.Collections.IList::Add(object value);
            int val_15 = this.values.Add(value:  values.Item[0]);
            val_13 = this.added;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_24 = 2;
            int val_17 = val_13.Add(value:  null);
            val_16 = 1;
            label_14:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_16 < oids.Count)
            {
                goto label_45;
            }
            
            return;
            label_13:
            System.ArgumentException val_20 = new System.ArgumentException(message:  "\'oids\' must be same length as \'values\'.");
        }
        public X509Name(string dirName)
        {
            var val_3 = null;
            bool val_2 = Org.BouncyCastle.Asn1.X509.X509Name.DefaultReverse;
        }
        public X509Name(string dirName, Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
        {
            var val_3 = null;
            bool val_2 = Org.BouncyCastle.Asn1.X509.X509Name.DefaultReverse;
        }
        public X509Name(bool reverse, string dirName)
        {
            null = null;
            reverse = reverse;
        }
        public X509Name(bool reverse, string dirName, Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
        {
            null = null;
            reverse = reverse;
        }
        public X509Name(bool reverse, System.Collections.IDictionary lookUp, string dirName)
        {
            Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter val_1 = new Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter();
            bool val_2 = reverse;
        }
        private Org.BouncyCastle.Asn1.DerObjectIdentifier DecodeOid(string name, System.Collections.IDictionary lookUp)
        {
            string val_15;
            object val_16;
            var val_17;
            var val_18;
            val_15 = name;
            val_16 = Org.BouncyCastle.Utilities.Platform.StartsWith(source:  Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  val_15), prefix:  "OID.");
            if(val_15 == null)
            {
                goto label_3;
            }
            
            if(val_16 == false)
            {
                goto label_4;
            }
            
            label_6:
            val_15 = val_15.Substring(startIndex:  4);
            label_17:
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_4 = null;
            val_17 = val_4;
            val_4 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_15);
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_17;
            label_3:
            if(val_16 == true)
            {
                goto label_6;
            }
            
            label_4:
            val_18 = 0;
            if((val_15.Chars[0] & 65535) >= '0')
            {
                    val_18 = 0;
                if((val_15.Chars[0] & 65535) <= '9')
            {
                goto label_17;
            }
            
            }
            
            val_16 = Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(s:  val_15);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = 0;
            val_17 = lookUp.Item[val_16];
            if(val_17 != null)
            {
                    return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_17;
            }
            
            System.ArgumentException val_15 = new System.ArgumentException(message:  "Unknown object id - "("Unknown object id - ") + val_15 + " - passed to distinguished name"(" - passed to distinguished name"));
        }
        public X509Name(bool reverse, System.Collections.IDictionary lookUp, string dirName, Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
        {
            System.Collections.IDictionary val_48;
            Org.BouncyCastle.Asn1.X509.X509NameTokenizer val_49;
            var val_50;
            string val_51;
            var val_52;
            var val_53;
            System.Collections.IList val_54;
            var val_57;
            var val_59;
            System.Collections.IList val_60;
            object val_61;
            var val_62;
            var val_63;
            var val_65;
            int val_68;
            string val_69;
            System.Collections.IDictionary val_70;
            var val_72;
            var val_75;
            object val_78;
            object val_81;
            val_48 = lookUp;
            this.ordering = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.values = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.added = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.converter = converter;
            Org.BouncyCastle.Asn1.X509.X509NameTokenizer val_4 = null;
            val_49 = val_4;
            val_4 = new Org.BouncyCastle.Asn1.X509.X509NameTokenizer(oid:  dirName, separator:  ',');
            val_50 = 0;
            goto label_3;
            label_64:
            string val_5 = val_4.NextToken();
            int val_6 = val_5.IndexOf(value:  '=');
            var val_7 = (val_6 == 1) ? (val_50) : (val_5);
            if(val_6 == 1)
            {
                goto label_6;
            }
            
            if(val_7 != 0)
            {
                    val_51 = val_7.Substring(startIndex:  0, length:  val_6);
            }
            else
            {
                    val_51 = 0.Substring(startIndex:  0, length:  val_6);
            }
            
            string val_11 = val_7.Substring(startIndex:  val_6 + 1);
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_12 = val_11.DecodeOid(name:  val_51, lookUp:  val_48);
            val_52 = 0;
            if((val_11.IndexOf(value:  '+')) < 1)
            {
                goto label_10;
            }
            
            Org.BouncyCastle.Asn1.X509.X509NameTokenizer val_14 = null;
            val_53 = 43;
            val_14 = new Org.BouncyCastle.Asn1.X509.X509NameTokenizer(oid:  val_11, separator:  '+');
            val_54 = this.ordering;
            var val_60 = 0;
            val_60 = val_60 + 1;
            val_53 = 2;
            goto label_16;
            label_10:
            var val_61 = 0;
            val_61 = val_61 + 1;
            val_52 = 2;
            goto label_21;
            label_16:
            val_57 = public System.Int32 System.Collections.IList::Add(object value);
            int val_17 = val_54.Add(value:  val_12);
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_57 = 2;
            val_59 = public System.Int32 System.Collections.IList::Add(object value);
            int val_19 = this.values.Add(value:  val_14.NextToken());
            val_60 = this.added;
            val_61 = null;
            val_62 = null;
            var val_63 = 0;
            val_63 = val_63 + 1;
            goto label_58;
            label_21:
            val_63 = public System.Int32 System.Collections.IList::Add(object value);
            int val_21 = this.ordering.Add(value:  val_12);
            var val_64 = 0;
            val_64 = val_64 + 1;
            val_63 = 2;
            val_65 = public System.Int32 System.Collections.IList::Add(object value);
            int val_23 = this.values.Add(value:  val_11);
            val_60 = null;
            var val_65 = 0;
            val_65 = val_65 + 1;
            val_65 = 2;
            int val_25 = this.added.Add(value:  val_60);
            goto label_42;
            label_62:
            string val_27 = val_14.NextToken();
            if(val_27 != null)
            {
                    val_68 = val_27.IndexOf(value:  '=');
                val_69 = val_27.Substring(startIndex:  0, length:  val_68);
            }
            else
            {
                    val_68 = 0.IndexOf(value:  '=');
                val_69 = 0.Substring(startIndex:  0, length:  val_68);
            }
            
            string val_33 = val_27.Substring(startIndex:  val_68 + 1);
            val_70 = val_48;
            val_54 = val_33.DecodeOid(name:  val_69, lookUp:  val_70);
            var val_66 = 0;
            val_66 = val_66 + 1;
            val_70 = 2;
            val_72 = public System.Int32 System.Collections.IList::Add(object value);
            int val_36 = this.ordering.Add(value:  val_54);
            var val_67 = 0;
            val_67 = val_67 + 1;
            val_72 = 2;
            int val_38 = this.values.Add(value:  val_33);
            val_60 = this.added;
            val_61 = true;
            val_62 = null;
            var val_68 = 0;
            val_68 = val_68 + 1;
            label_58:
            val_59 = 2;
            int val_39 = val_60.Add(value:  true);
            if(val_14.HasMoreTokens() == true)
            {
                goto label_62;
            }
            
            label_42:
            val_49 = val_49;
            label_3:
            if(val_4.HasMoreTokens() == true)
            {
                goto label_64;
            }
            
            if(reverse == false)
            {
                    return;
            }
            
            System.Collections.IList val_42 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_48 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            System.Collections.IList val_44 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_50 = 0;
            val_54 = 1;
            goto label_68;
            label_109:
            var val_69 = 0;
            val_69 = val_69 + 1;
            val_75 = public System.Object System.Collections.IList::get_Item(int index);
            object val_46 = this.added.Item[0];
            int val_47 = (null == 0) ? 0 : (val_54);
            var val_70 = 0;
            val_70 = val_70 + 1;
            val_75 = 0;
            var val_71 = 0;
            val_71 = val_71 + 1;
            val_78 = this.ordering.Item[0];
            val_42.Insert(index:  val_47, value:  val_78);
            var val_72 = 0;
            val_72 = val_72 + 1;
            val_78 = 0;
            var val_73 = 0;
            val_73 = val_73 + 1;
            val_81 = this.values.Item[0];
            val_48.Insert(index:  val_47, value:  val_81);
            var val_74 = 0;
            val_74 = val_74 + 1;
            val_81 = 0;
            val_60 = this.added.Item[0];
            val_54 = val_47 + 1;
            var val_75 = 0;
            val_75 = val_75 + 1;
            val_44.Insert(index:  val_47, value:  val_60);
            val_50 = 1;
            label_68:
            var val_76 = 0;
            val_76 = val_76 + 1;
            if(val_50 < this.ordering.Count)
            {
                goto label_109;
            }
            
            this.ordering = val_42;
            this.values = val_48;
            this.added = val_44;
            return;
            label_6:
            System.ArgumentException val_59 = new System.ArgumentException(message:  "badly formated directory string");
        }
        public System.Collections.IList GetOidList()
        {
            return Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection:  this.ordering);
        }
        public System.Collections.IList GetValueList()
        {
            return this.GetValueList(oid:  0);
        }
        public System.Collections.IList GetValueList(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_10;
            var val_12;
            string val_14;
            var val_15;
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_10 = 0;
            goto label_3;
            label_32:
            if(oid == null)
            {
                goto label_4;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_12 = public System.Boolean Org.BouncyCastle.Asn1.Asn1Encodable::Equals(object obj);
            if((oid.Equals(obj:  this.ordering.Item[0])) == false)
            {
                goto label_10;
            }
            
            label_4:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_12 = 0;
            val_14 = this.values.Item[0];
            if((val_14 != null) && (null != null))
            {
                    val_14 = 0;
            }
            
            val_15 = 0;
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_14, prefix:  "\\#")) != false)
            {
                    val_15 = 0;
                val_14 = val_14.Substring(startIndex:  1);
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_15 = 2;
            int val_11 = val_1.Add(value:  val_14);
            label_10:
            val_10 = 1;
            label_3:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_10 != this.values.Count)
            {
                goto label_32;
            }
            
            return val_1;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_21;
            var val_22;
            var val_24;
            Org.BouncyCastle.Asn1.Asn1Encodable val_25;
            var val_27;
            var val_28;
            if(this.seq != null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)this.seq;
            }
            
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_4 = null;
            val_21 = val_4;
            val_4 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            val_22 = 0;
            goto label_2;
            label_52:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_24 = public System.Object System.Collections.IList::get_Item(int index);
            val_25 = this.ordering.Item[0];
            if(val_25 != null)
            {
                    val_24 = 0;
                val_25 = 0;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_24 = 0;
            val_27 = public System.Object System.Collections.IList::get_Item(int index);
            val_28 = this.values.Item[0];
            if((val_28 != null) && (null != null))
            {
                    val_27 = 0;
                val_28 = 0;
            }
            
            if(0 != 0)
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                val_27 = 0;
                object val_12 = this.added.Item[0];
                if(null == null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_13 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_13[0] = new Org.BouncyCastle.Asn1.DerSet(v:  val_4);
                val_2.Add(objs:  val_13);
                Org.BouncyCastle.Asn1.Asn1EncodableVector val_16 = null;
                val_21 = val_16;
                val_16 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            }
            
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_17 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_18 = new Org.BouncyCastle.Asn1.Asn1Encodable[2];
            if(val_18 == null)
            {
                goto label_30;
            }
            
            if(val_25 != 0)
            {
                goto label_31;
            }
            
            goto label_34;
            label_30:
            if(val_25 == 0)
            {
                goto label_34;
            }
            
            label_31:
            label_34:
            val_18[0] = val_25;
            val_18[1] = this.converter;
            Org.BouncyCastle.Asn1.DerSequence val_19 = new Org.BouncyCastle.Asn1.DerSequence(v:  val_18);
            if(val_17 == null)
            {
                goto label_40;
            }
            
            if(val_19 != null)
            {
                goto label_41;
            }
            
            goto label_44;
            label_40:
            if(val_19 == null)
            {
                goto label_44;
            }
            
            label_41:
            label_44:
            val_17[0] = val_19;
            val_16.Add(objs:  val_17);
            val_22 = 1;
            label_2:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_22 != this.ordering.Count)
            {
                goto label_52;
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_22 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_22[0] = new Org.BouncyCastle.Asn1.DerSet(v:  val_16);
            val_2.Add(objs:  val_22);
            this.seq = new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            return (Org.BouncyCastle.Asn1.Asn1Object)this.seq;
        }
        public bool Equivalent(Org.BouncyCastle.Asn1.X509.X509Name other, bool inOrder)
        {
            var val_12;
            string val_13;
            var val_14;
            var val_18;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_25;
            string val_27;
            var val_28;
            val_12 = inOrder;
            if(val_12 == false)
            {
                    return this.Equivalent(other:  other);
            }
            
            if(other == null)
            {
                goto label_52;
            }
            
            if(other == this)
            {
                goto label_15;
            }
            
            val_13 = 1152921504686080000;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_14 = 1;
            val_12 = this.ordering.Count;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_14 = 1;
            if(val_12 != other.ordering.Count)
            {
                goto label_52;
            }
            
            if(val_12 < 1)
            {
                goto label_15;
            }
            
            var val_24 = 0;
            label_53:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_14 = 0;
            val_18 = public System.Object System.Collections.IList::get_Item(int index);
            val_13 = this.ordering.Item[0];
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_18 = 0;
            val_20 = public System.Object System.Collections.IList::get_Item(int index);
            val_21 = null;
            val_22 = other.ordering.Item[0];
            if(val_22 != null)
            {
                    val_20 = 0;
                val_21 = null;
                val_22 = 0;
            }
            
            if(val_13 != null)
            {
                    val_20 = 0;
                val_20 = 0;
                val_13 = 0;
            }
            
            if((val_13 & 1) == 0)
            {
                goto label_52;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_23 = 0;
            val_25 = public System.Object System.Collections.IList::get_Item(int index);
            val_13 = this.values.Item[0];
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = 0;
            val_27 = other.values.Item[0];
            if((val_27 != null) && (null != null))
            {
                    val_27 = 0;
            }
            
            if((val_13 != null) && (null != null))
            {
                    val_13 = 0;
            }
            
            if((Org.BouncyCastle.Asn1.X509.X509Name.equivalentStrings(s1:  val_13, s2:  val_27)) == false)
            {
                goto label_52;
            }
            
            val_24 = val_24 + 1;
            val_28 = 1;
            if(val_24 < val_12)
            {
                goto label_53;
            }
            
            return (bool)val_28;
            label_52:
            val_28 = 0;
            return (bool)val_28;
            label_15:
            val_28 = 1;
            return (bool)val_28;
        }
        public bool Equivalent(Org.BouncyCastle.Asn1.X509.X509Name other)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_22;
            var val_25;
            var val_27;
            string val_28;
            var val_30;
            var val_31;
            var val_33;
            var val_35;
            string val_36;
            var val_37;
            if(other == null)
            {
                goto label_67;
            }
            
            if(other != this)
            {
                    val_19 = 1152921504686080000;
                var val_26 = 0;
                val_26 = val_26 + 1;
                val_20 = 1;
            }
            else
            {
                    val_22 = 1;
                return (bool)val_22;
            }
            
            val_18 = this.ordering.Count;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_20 = 1;
            if(val_18 != other.ordering.Count)
            {
                goto label_67;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_20 = 0;
            val_25 = public System.Object System.Collections.IList::get_Item(int index);
            val_19 = this.ordering.Item[0];
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_25 = 0;
            object val_9 = other.ordering.Item[0];
            val_22 = 1;
            var val_11 = (val_19 != 1) ? (val_18) : (!0);
            int val_12 = (val_19 != 1) ? 0 : (val_18 - 1);
            if(val_12 == val_11)
            {
                    return (bool)val_22;
            }
            
            val_19 = (long)val_18;
            label_70:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_27 = 0;
            val_30 = public System.Object System.Collections.IList::get_Item(int index);
            val_31 = this.ordering.Item[val_12];
            if(val_31 != null)
            {
                    val_30 = 0;
                val_31 = 0;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_30 = 0;
            val_33 = public System.Object System.Collections.IList::get_Item(int index);
            val_28 = this.values.Item[val_12];
            if((val_28 != null) && (null != null))
            {
                    val_33 = 0;
                val_28 = 0;
            }
            
            if(val_18 < 1)
            {
                goto label_67;
            }
            
            var val_35 = 0;
            label_66:
            if(val_35 >= val_5.Length)
            {
                    val_33 = 0;
            }
            
            if(new bool[0][val_35] == true)
            {
                goto label_55;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_33 = 0;
            val_35 = public System.Object System.Collections.IList::get_Item(int index);
            val_36 = other.ordering.Item[0];
            if(val_36 != null)
            {
                    val_35 = 0;
                val_36 = 0;
            }
            
            val_37 = mem[282584257676975];
            if((val_31 & 1) == 0)
            {
                goto label_55;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_37 = 0;
            val_36 = other.values.Item[0];
            if((val_36 != null) && (null != null))
            {
                    val_36 = 0;
            }
            
            if((Org.BouncyCastle.Asn1.X509.X509Name.equivalentStrings(s1:  val_28, s2:  val_36)) == true)
            {
                goto label_65;
            }
            
            label_55:
            val_35 = val_35 + 1;
            if(val_35 < val_19)
            {
                goto label_66;
            }
            
            goto label_67;
            label_65:
            val_28 = val_11;
            var val_36 = val_12;
            val_22 = 1;
            val_36 = val_36 + (((val_19 & 1) != 0) ? (-val_22) : (val_22));
            mem2[0] = val_22;
            if(val_36 != val_28)
            {
                goto label_70;
            }
            
            return (bool)val_22;
            label_67:
            val_22 = 0;
            return (bool)val_22;
        }
        private static bool equivalentStrings(string s1, string s2)
        {
            string val_7;
            var val_8;
            val_7 = Org.BouncyCastle.Asn1.X509.X509Name.canonicalize(s:  s1);
            string val_2 = Org.BouncyCastle.Asn1.X509.X509Name.canonicalize(s:  s2);
            if((val_7.Equals(value:  val_2)) == true)
            {
                goto label_4;
            }
            
            val_7 = Org.BouncyCastle.Asn1.X509.X509Name.stripInternalSpaces(str:  val_7);
            if((val_7.Equals(value:  Org.BouncyCastle.Asn1.X509.X509Name.stripInternalSpaces(str:  val_2))) == false)
            {
                goto label_8;
            }
            
            label_4:
            val_8 = 1;
            return (bool)val_8;
            label_8:
            val_8 = 0;
            return (bool)val_8;
        }
        private static string canonicalize(string s)
        {
            string val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            string val_2 = Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(s:  s).Trim();
            val_9 = val_2;
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_2, prefix:  "#")) == false)
            {
                    return (string)val_9;
            }
            
            Org.BouncyCastle.Asn1.Asn1Object val_4 = Org.BouncyCastle.Asn1.X509.X509Name.decodeObject(v:  val_9);
            val_10 = 1152921505544384512;
            val_11 = null;
            if(val_4 == null)
            {
                    return (string)val_9;
            }
            
            if(val_4 == null)
            {
                goto label_8;
            }
            
            val_12 = null;
            val_11 = val_12;
            val_10 = val_4;
            if(val_10 != null)
            {
                goto label_10;
            }
            
            val_11 = 0;
            goto label_11;
            label_8:
            val_12 = null;
            label_11:
            val_10 = 0;
            label_10:
            if(mem[282584257676957] == 0)
            {
                goto label_12;
            }
            
            var val_9 = mem[282584257676847];
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_14:
            if(((mem[282584257676847] + 8) + -8) == val_12)
            {
                goto label_13;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < mem[282584257676957])
            {
                goto label_14;
            }
            
            label_12:
            val_11 = val_12;
            goto label_15;
            label_13:
            val_10 = val_10 + (((mem[282584257676847] + 8)) << 4);
            val_13 = val_10 + 296;
            label_15:
            val_9 = Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(s:  val_10.GetString()).Trim();
            return (string)val_9;
        }
        private static Org.BouncyCastle.Asn1.Asn1Object decodeObject(string v)
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  v.Substring(startIndex:  1)));
        }
        private static string stripInternalSpaces(string str)
        {
            var val_10;
            var val_11;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_10 = 0;
            if(str.Length == 0)
            {
                goto label_2;
            }
            
            char val_3 = str.Chars[0];
            System.Text.StringBuilder val_4 = val_1.Append(value:  val_3);
            val_11 = 1;
            goto label_5;
            label_11:
            char val_5 = str.Chars[1];
            if((val_3 & 65535) == ' ')
            {
                    if((val_5 & 65535) == ' ')
            {
                goto label_8;
            }
            
            }
            
            System.Text.StringBuilder val_8 = val_1.Append(value:  val_5);
            label_8:
            val_11 = 2;
            label_5:
            val_10 = 0;
            if(val_11 < str.Length)
            {
                goto label_11;
            }
            
            label_2:
            if(val_1 == null)
            {
                
            }
        
        }
        private void AppendValue(System.Text.StringBuilder buf, System.Collections.IDictionary oidSymbols, Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string val)
        {
            string val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_33 = 0;
            val_33 = val_33 + 1;
            object val_2 = oidSymbols.Item[oid];
            if(val_2 != null)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            val_33 = oid.Id;
            goto label_10;
            label_7:
            val_33 = val_2;
            label_10:
            System.Text.StringBuilder val_5 = buf.Append(value:  val_33);
            if(buf != null)
            {
                    System.Text.StringBuilder val_6 = buf.Append(value:  '=');
                val_34 = buf.Length;
                System.Text.StringBuilder val_8 = buf.Append(value:  val);
            }
            else
            {
                    System.Text.StringBuilder val_9 = 0.Append(value:  '=');
                val_34 = 0.Length;
                System.Text.StringBuilder val_11 = 0.Append(value:  val);
            }
            
            val_35 = buf.Length;
            int val_14 = val_34 + 2;
            int val_15 = ((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val, prefix:  "\\#")) != true) ? (val_14) : (val_34);
            if(val_15 == val_35)
            {
                    return;
            }
            
            label_34:
            val_14 = buf.Chars[val_15] & 65535;
            if((((((val_14 != ',') && ((buf.Chars[val_15] & 65535) != '"')) && ((buf.Chars[val_15] & 65535) != '\')) && ((buf.Chars[val_15] & 65535) != ('+'))) && ((buf.Chars[val_15] & 65535) != ('='))) && ((buf.Chars[val_15] & 65535) != ('<')))
            {
                    if((buf.Chars[val_15] & 65535) != ('>'))
            {
                    if((buf.Chars[val_15] & 65535) != ';')
            {
                goto label_32;
            }
            
            }
            
            }
            
            System.Text.StringBuilder val_32 = buf.Insert(index:  val_15, value:  "\\");
            val_35 = val_35 + 1;
            val_36 = val_15 + 1;
            label_32:
            val_36 = val_36 + 1;
            if(val_36 != val_35)
            {
                goto label_34;
            }
        
        }
        public string ToString(bool reverse, System.Collections.IDictionary oidSymbols)
        {
            System.Collections.IDictionary val_19;
            var val_20;
            var val_22;
            var val_23;
            var val_26;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_27;
            string val_29;
            var val_30;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_31;
            string val_33;
            val_19 = oidSymbols;
            System.Collections.ArrayList val_1 = new System.Collections.ArrayList();
            val_20 = 0;
            goto label_1;
            label_46:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_22 = public System.Object System.Collections.IList::get_Item(int index);
            object val_3 = this.added.Item[0];
            if(null == null)
            {
                goto label_7;
            }
            
            val_23 = 0;
            System.Text.StringBuilder val_4 = 0.Append(value:  '+');
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_23 = 0;
            goto label_13;
            label_7:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_22 = 0;
            goto label_18;
            label_13:
            val_26 = public System.Object System.Collections.IList::get_Item(int index);
            val_27 = this.ordering.Item[0];
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_26 = 0;
            val_29 = this.values.Item[0];
            if(val_27 != null)
            {
                    val_27 = 0;
            }
            
            if((val_29 != null) && (null != null))
            {
                    val_29 = 0;
            }
            
            X0.AppendValue(buf:  0, oidSymbols:  val_19, oid:  val_27, val:  val_29);
            goto label_29;
            label_18:
            val_30 = public System.Object System.Collections.IList::get_Item(int index);
            val_31 = this.ordering.Item[0];
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_30 = 0;
            val_33 = this.values.Item[0];
            if(val_31 != null)
            {
                    val_31 = 0;
            }
            
            if((val_33 != null) && (null != null))
            {
                    val_33 = 0;
            }
            
            X0.AppendValue(buf:  new System.Text.StringBuilder(), oidSymbols:  val_19, oid:  val_31, val:  val_33);
            label_29:
            val_20 = 1;
            label_1:
            var val_30 = 0;
            val_30 = val_30 + 1;
            if(val_20 < this.ordering.Count)
            {
                goto label_46;
            }
            
            System.Text.StringBuilder val_19 = new System.Text.StringBuilder();
            if(val_1 >= 1)
            {
                    val_19 = val_1.ToString();
                System.Text.StringBuilder val_21 = val_19.Append(value:  val_19);
                if(val_1 >= 2)
            {
                    do
            {
                System.Text.StringBuilder val_22 = val_19.Append(value:  ',');
                System.Text.StringBuilder val_24 = val_19.Append(value:  val_1.ToString());
                val_19 = 1 + 1;
            }
            while(val_19 < val_1);
            
            }
            
            }
            
            if(val_19 != null)
            {
                    return (string)val_19;
            }
            
            return (string)val_19;
        }
        public override string ToString()
        {
            var val_3 = null;
            return this.ToString(reverse:  Org.BouncyCastle.Asn1.X509.X509Name.DefaultReverse, oidSymbols:  Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols);
        }
    
    }

}
