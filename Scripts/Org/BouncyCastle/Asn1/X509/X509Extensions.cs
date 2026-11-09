using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class X509Extensions : Asn1Encodable
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectDirectoryAttributes;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectKeyIdentifier;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier KeyUsage;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PrivateKeyUsagePeriod;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectAlternativeName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IssuerAlternativeName;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BasicConstraints;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CrlNumber;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ReasonCode;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier InstructionCode;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier InvalidityDate;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier DeltaCrlIndicator;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier IssuingDistributionPoint;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CertificateIssuer;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NameConstraints;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CrlDistributionPoints;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier CertificatePolicies;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyMappings;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier AuthorityKeyIdentifier;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyConstraints;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier ExtendedKeyUsage;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier FreshestCrl;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier InhibitAnyPolicy;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier AuthorityInfoAccess;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectInfoAccess;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier LogoType;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier BiometricInfo;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier QCStatements;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier AuditIdentity;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier NoRevAvail;
        public static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier TargetInformation;
        private readonly System.Collections.IDictionary extensions;
        private readonly System.Collections.IList ordering;
        
        // Properties
        public System.Collections.IEnumerable ExtensionOids { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.X509Extensions GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            explicitly = explicitly;
            return Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.X509Extensions GetInstance(object obj)
        {
            object val_10;
            var val_11;
            val_10 = obj;
            if(val_10 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509Extensions)val_11;
            }
            
            val_11 = val_10.GetObject();
            return (Org.BouncyCastle.Asn1.X509.X509Extensions)val_11;
        }
        private X509Extensions(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.Asn1Sequence val_10;
            var val_25;
            Org.BouncyCastle.Asn1.Asn1Sequence val_26;
            var val_27;
            var val_30;
            object val_31;
            var val_34;
            bool val_35;
            object val_37;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            val_25 = this;
            this.extensions = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            this.ordering = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_26 = seq;
            label_44:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_27 = 0;
            if(val_26.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_27 = 1;
            val_30 = public System.Object System.Collections.IEnumerator::get_Current();
            val_31 = val_26.Current;
            if(val_31 != null)
            {
                    val_30 = 0;
                val_27 = 0;
            }
            
            if(val_31 != null)
            {
                    val_30 = null;
                val_30 = 0;
                val_27 = 0;
                val_31 = 0;
            }
            
            Org.BouncyCastle.Asn1.Asn1Sequence val_11 = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_31);
            if((val_11 < 2) || (val_11 >= 4))
            {
                goto label_23;
            }
            
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_13 = Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj:  val_11.ToAsn1Object());
            if(val_11 == 3)
            {
                    val_34 = 0;
                val_35 = Org.BouncyCastle.Asn1.DerBoolean.GetInstance(obj:  val_11.ToAsn1Object()).IsTrue;
                val_25 = val_25;
            }
            else
            {
                    val_35 = false;
            }
            
            Org.BouncyCastle.Asn1.Asn1Sequence val_17 = val_11 - 1;
            new Org.BouncyCastle.Asn1.X509.X509Extension() = new System.Object();
            .critical = val_35;
            .value = Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(obj:  val_11.ToAsn1Object());
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_37 = new Org.BouncyCastle.Asn1.X509.X509Extension();
            this.extensions.Add(key:  val_13, value:  new Org.BouncyCastle.Asn1.X509.X509Extension());
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_37 = 2;
            int val_23 = this.ordering.Add(value:  val_13);
            goto label_44;
            label_9:
            val_39 = 0;
            val_40 = 0;
            goto label_45;
            label_23:
            val_10 = val_11;
            new System.ArgumentException() = new System.ArgumentException(message:  "Bad sequence size: "("Bad sequence size: ") + val_10);
            val_41 = 0;
            val_42 = new System.ArgumentException();
            if(val_41 != 1)
            {
                goto label_75;
            }
            
            val_39 = 0;
            label_45:
            if(val_26 != null)
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_26.Dispose();
            }
            
            if(val_39 != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_75:
        }
        public X509Extensions(System.Collections.IDictionary extensions)
        {
        
        }
        public X509Extensions(System.Collections.IList ordering, System.Collections.IDictionary extensions)
        {
            System.Collections.ICollection val_14;
            var val_15;
            var val_16;
            object val_21;
            object val_23;
            var val_25;
            var val_26;
            val_14 = ordering;
            this.extensions = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            if(val_14 != null)
            {
                    val_15 = null;
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_16 = 2;
                val_14 = extensions.Keys;
                val_15 = null;
            }
            
            System.Collections.IList val_4 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection:  val_14);
            this.ordering = val_4;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_16 = 0;
            System.Collections.IEnumerator val_6 = val_4.GetEnumerator();
            label_46:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_16 = 0;
            if(val_6.MoveNext() == false)
            {
                goto label_24;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_16 = 1;
            val_21 = val_6.Current;
            if(val_21 != null)
            {
                    val_16 = 0;
                val_21 = 0;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_16 = 0;
            val_23 = extensions.Item[val_21];
            if(val_23 != null)
            {
                    val_23 = 0;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            this.extensions.Add(key:  val_21, value:  val_23);
            goto label_46;
            label_24:
            val_25 = 0;
            val_26 = 0;
            if(val_6 != null)
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_6.Dispose();
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
        public X509Extensions(System.Collections.IList oids, System.Collections.IList values)
        {
            var val_13;
            object val_17;
            object val_19;
            var val_21;
            var val_22;
            this.extensions = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            System.Collections.IList val_2 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection:  oids);
            this.ordering = val_2;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_13 = 0;
            System.Collections.IEnumerator val_4 = val_2.GetEnumerator();
            var val_22 = 0;
            label_35:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_13 = 0;
            if(val_4.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_13 = 1;
            val_17 = val_4.Current;
            if(val_17 != null)
            {
                    val_13 = 0;
                val_17 = 0;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_13 = 0;
            val_19 = values.Item[0];
            if(val_19 != null)
            {
                    val_19 = 0;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = val_22 + 1;
            this.extensions.Add(key:  val_17, value:  val_19);
            goto label_35;
            label_13:
            val_21 = 0;
            val_22 = 0;
            if(val_4 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
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
        public X509Extensions(System.Collections.Hashtable extensions)
        {
        
        }
        public X509Extensions(System.Collections.ArrayList ordering, System.Collections.Hashtable extensions)
        {
            System.Collections.ICollection val_12;
            var val_13;
            object val_17;
            object val_18;
            var val_20;
            var val_21;
            val_12 = ordering;
            this.extensions = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            if(val_12 != null)
            {
                    val_13 = null;
            }
            else
            {
                    val_12 = extensions;
                val_13 = null;
            }
            
            System.Collections.IList val_2 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection:  val_12);
            this.ordering = val_2;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.IEnumerator val_4 = val_2.GetEnumerator();
            label_38:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_20;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = val_4.Current;
            if(val_17 != null)
            {
                    val_17 = 0;
            }
            
            val_18 = extensions;
            if(val_18 != null)
            {
                    val_18 = 0;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            this.extensions.Add(key:  val_17, value:  val_18);
            goto label_38;
            label_20:
            val_20 = 0;
            val_21 = 0;
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
        public X509Extensions(System.Collections.ArrayList oids, System.Collections.ArrayList values)
        {
            object val_15;
            object val_16;
            var val_18;
            var val_19;
            this.extensions = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            System.Collections.IList val_2 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(collection:  oids);
            this.ordering = val_2;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.IEnumerator val_4 = val_2.GetEnumerator();
            var val_19 = 0;
            label_31:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_15 = val_4.Current;
            if(val_15 != null)
            {
                    val_15 = 0;
            }
            
            val_16 = values;
            if(val_16 != null)
            {
                    val_16 = 0;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = val_19 + 1;
            this.extensions.Add(key:  val_15, value:  val_16);
            goto label_31;
            label_13:
            val_18 = 0;
            val_19 = 0;
            if(val_4 != null)
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
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
        public System.Collections.IEnumerator Oids()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.ExtensionOids.GetEnumerator();
        }
        public System.Collections.IEnumerable get_ExtensionOids()
        {
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  this.ordering);
        }
        public Org.BouncyCastle.Asn1.X509.X509Extension GetExtension(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_5;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.extensions;
            if(val_5.Item[oid] == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509Extension)val_5;
            }
            
            val_5 = 0;
            return (Org.BouncyCastle.Asn1.X509.X509Extension)val_5;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            var val_19;
            var val_21;
            object val_24;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = null;
            val_19 = 0;
            val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_19 = 0;
            System.Collections.IEnumerator val_4 = this.ordering.GetEnumerator();
            val_21 = 1152921505543532544;
            label_51:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_19 = 0;
            if(val_4.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_19 = 1;
            val_24 = val_4.Current;
            if(val_24 != null)
            {
                    val_19 = 0;
                val_24 = 0;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_19 = 0;
            val_26 = this.extensions.Item[val_24];
            if(val_26 != null)
            {
                    val_26 = 0;
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_15 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_15[0] = val_24;
            new Org.BouncyCastle.Asn1.Asn1EncodableVector() = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_15);
            if(3 != 0)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_17 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_27 = null;
                val_27 = null;
                val_17[0] = Org.BouncyCastle.Asn1.DerBoolean.True;
                new Org.BouncyCastle.Asn1.Asn1EncodableVector().Add(objs:  val_17);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_18 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_18[0] = 28563616;
            new Org.BouncyCastle.Asn1.Asn1EncodableVector().Add(objs:  val_18);
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_19 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            new Org.BouncyCastle.Asn1.DerSequence() = new Org.BouncyCastle.Asn1.DerSequence(v:  new Org.BouncyCastle.Asn1.Asn1EncodableVector());
            val_19[0] = new Org.BouncyCastle.Asn1.DerSequence();
            val_2.Add(objs:  val_19);
            goto label_51;
            label_11:
            val_28 = 0;
            val_29 = 0;
            if(val_4 == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_4.Dispose();
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
        public bool Equivalent(Org.BouncyCastle.Asn1.X509.X509Extensions other)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_16;
            object val_22;
            var val_24;
            var val_26;
            var val_27;
            var val_31;
            val_12 = other;
            val_13 = 1152921504686080000;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_14 = 1;
            val_16 = this.extensions.Count;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_14 = 1;
            if(val_16 != other.extensions.Count)
            {
                goto label_12;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_14 = 2;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_14 = 0;
            val_16 = this.extensions.Keys.GetEnumerator();
            label_49:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_14 = 0;
            if(val_16.MoveNext() == false)
            {
                goto label_28;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_14 = 1;
            val_22 = val_16.Current;
            if(val_22 != null)
            {
                    val_14 = 0;
                val_22 = 0;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_14 = 0;
            val_24 = public System.Object System.Collections.IDictionary::get_Item(object key);
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_24 = 0;
            object val_18 = other.extensions.Item[val_22];
            if((this.extensions.Item[val_22] & 1) != 0)
            {
                goto label_49;
            }
            
            val_26 = 0;
            val_12 = 0;
            val_27 = 121;
            goto label_51;
            label_28:
            val_26 = 0;
            val_12 = 0;
            val_27 = 119;
            label_51:
            val_13 = 1152921504621703168;
            if(val_16 != null)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_16.Dispose();
            }
            
            if( == 1)
            {
                goto label_66;
            }
            
            if(119 != 121)
            {
                goto label_67;
            }
            
            label_12:
            val_31 = 0;
            return (bool)val_31;
            label_66:
            if( == true)
            {
                goto label_69;
            }
            
            goto label_70;
            label_67:
            val_31 = 1;
            if( == false)
            {
                    return (bool)val_31;
            }
            
            if(119 == 119)
            {
                    return (bool)val_31;
            }
            
            label_69:
            label_70:
            val_31 = 1;
            return (bool)val_31;
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetExtensionOids()
        {
            return Org.BouncyCastle.Asn1.X509.X509Extensions.ToOidArray(oids:  this.ordering);
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetNonCriticalExtensionOids()
        {
            return this.GetExtensionOids(isCritical:  false);
        }
        public Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetCriticalExtensionOids()
        {
            return this.GetExtensionOids(isCritical:  true);
        }
        private Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetExtensionOids(bool isCritical)
        {
            var val_16;
            object val_20;
            var val_22;
            var val_24;
            var val_25;
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_16 = 0;
            System.Collections.IEnumerator val_3 = this.ordering.GetEnumerator();
            label_38:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_16 = 0;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_16 = 1;
            val_20 = val_3.Current;
            if(val_20 != null)
            {
                    val_16 = 0;
                val_20 = 0;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_16 = 0;
            val_22 = public System.Object System.Collections.IDictionary::get_Item(object key);
            if(this.extensions.Item[val_20] != null)
            {
                    val_22 = 0;
            }
            
            var val_15 = (null != 0) ? 1 : 0;
            val_15 = val_15 ^ isCritical;
            if(val_15 == true)
            {
                goto label_38;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_22 = 2;
            int val_17 = val_1.Add(value:  val_20);
            goto label_38;
            label_13:
            val_24 = 0;
            val_25 = 0;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerObjectIdentifier[])Org.BouncyCastle.Asn1.X509.X509Extensions.ToOidArray(oids:  val_1);
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_3.Dispose();
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier[])Org.BouncyCastle.Asn1.X509.X509Extensions.ToOidArray(oids:  val_1);
        }
        private static Org.BouncyCastle.Asn1.DerObjectIdentifier[] ToOidArray(System.Collections.IList oids)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            int val_2 = oids.Count;
            Org.BouncyCastle.Asn1.DerObjectIdentifier[] val_3 = new Org.BouncyCastle.Asn1.DerObjectIdentifier[0];
            var val_6 = 0;
            val_6 = val_6 + 1;
            oids.CopyTo(array:  val_3, index:  0);
            return val_3;
        }
        private static X509Extensions()
        {
            Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectDirectoryAttributes = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.9");
            Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectKeyIdentifier = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.14");
            Org.BouncyCastle.Asn1.X509.X509Extensions.KeyUsage = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.15");
            Org.BouncyCastle.Asn1.X509.X509Extensions.PrivateKeyUsagePeriod = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.16");
            Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectAlternativeName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.17");
            Org.BouncyCastle.Asn1.X509.X509Extensions.IssuerAlternativeName = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.18");
            Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.19");
            Org.BouncyCastle.Asn1.X509.X509Extensions.CrlNumber = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.20");
            Org.BouncyCastle.Asn1.X509.X509Extensions.ReasonCode = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.21");
            Org.BouncyCastle.Asn1.X509.X509Extensions.InstructionCode = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.23");
            Org.BouncyCastle.Asn1.X509.X509Extensions.InvalidityDate = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.24");
            Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.27");
            Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.28");
            Org.BouncyCastle.Asn1.X509.X509Extensions.CertificateIssuer = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.29");
            Org.BouncyCastle.Asn1.X509.X509Extensions.NameConstraints = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.30");
            Org.BouncyCastle.Asn1.X509.X509Extensions.CrlDistributionPoints = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.31");
            Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.32");
            Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyMappings = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.33");
            Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityKeyIdentifier = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.35");
            Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyConstraints = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.36");
            Org.BouncyCastle.Asn1.X509.X509Extensions.ExtendedKeyUsage = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.37");
            Org.BouncyCastle.Asn1.X509.X509Extensions.FreshestCrl = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.46");
            Org.BouncyCastle.Asn1.X509.X509Extensions.InhibitAnyPolicy = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.54");
            Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityInfoAccess = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.1.1");
            Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectInfoAccess = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.1.11");
            Org.BouncyCastle.Asn1.X509.X509Extensions.LogoType = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.1.12");
            Org.BouncyCastle.Asn1.X509.X509Extensions.BiometricInfo = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.1.2");
            Org.BouncyCastle.Asn1.X509.X509Extensions.QCStatements = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.1.3");
            Org.BouncyCastle.Asn1.X509.X509Extensions.AuditIdentity = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "1.3.6.1.5.5.7.1.4");
            Org.BouncyCastle.Asn1.X509.X509Extensions.NoRevAvail = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.56");
            Org.BouncyCastle.Asn1.X509.X509Extensions.TargetInformation = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  "2.5.29.55");
        }
    
    }

}
