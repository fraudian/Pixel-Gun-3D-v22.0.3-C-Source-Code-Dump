using UnityEngine;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
    public sealed class Gost3410NamedParameters
    {
        // Fields
        private static readonly System.Collections.IDictionary objIds;
        private static readonly System.Collections.IDictionary parameters;
        private static readonly Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProA;
        private static readonly Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProB;
        private static readonly Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProXchA;
        
        // Properties
        public static System.Collections.IEnumerable Names { get; }
        
        // Methods
        private Gost3410NamedParameters()
        {
        
        }
        private static Gost3410NamedParameters()
        {
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters val_6 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters(keySize:  1024, p:  new Org.BouncyCastle.Math.BigInteger(value:  "127021248288932417465907042777176443525787653508916535812817507265705031260985098497423188333483401180925999995120988934130659205614996724254121049274349357074920312769561451689224110579311248812610229678534638401693520013288995000362260684222750813532307004517341633685004541062586971416883686778842537820383"), q:  new Org.BouncyCastle.Math.BigInteger(value:  "68363196144955700784444165611827252895102170888761442055095051287550314083023"), a:  new Org.BouncyCastle.Math.BigInteger(value:  "100997906755055304772081815535925224869841082572053457874823515875577147990529272777244152852699298796483356699682842027972896052747173175480590485607134746852141928680912561502802222185647539190902656116367847270145019066794290930185446216399730872221732889830323194097355403213400972588322876850946740663962"));
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.cryptoProA = val_6;
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters val_10 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters(keySize:  1024, p:  new Org.BouncyCastle.Math.BigInteger(value:  "139454871199115825601409655107690713107041707059928031797758001454375765357722984094124368522288239833039114681648076688236921220737322672160740747771700911134550432053804647694904686120113087816240740184800477047157336662926249423571248823968542221753660143391485680840520336859458494803187341288580489525163"), q:  new Org.BouncyCastle.Math.BigInteger(value:  "79885141663410976897627118935756323747307951916507639758300472692338873533959"), a:  new Org.BouncyCastle.Math.BigInteger(value:  "42941826148615804143873447737955502392672345968607143066798112994089471231420027060385216699563848719957657284814898909770759462613437669456364882730370838934791080835932647976778601915343474400961034231316672578686920482194932878633360203384797092684342247621055760235016132614780652761028509445403338652341"));
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.cryptoProB = val_10;
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters val_14 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters(keySize:  1024, p:  new Org.BouncyCastle.Math.BigInteger(value:  "142011741597563481196368286022318089743276138395243738762872573441927459393512718973631166078467600360848946623567625795282774719212241929071046134208380636394084512691828894000571524625445295769349356752728956831541775441763139384457191755096847107846595662547942312293338483924514339614727760681880609734239"), q:  new Org.BouncyCastle.Math.BigInteger(value:  "91771529896554605945588149018382750217296858393520724172743325725474374979801"), a:  new Org.BouncyCastle.Math.BigInteger(value:  "133531813272720673433859519948319001217942375967847486899482359599369642528734712461590403327731821410328012529253871914788598993103310567744136196364803064721377826656898686468463277710150809401182608770201615324990468332931294920912776241137878030224355746606283971659376426832674269780880061631528163475887"));
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.cryptoProXchA = val_14;
            val_22 = null;
            val_22 = null;
            var val_18 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_9;
            }
            
            var val_15 = mem[val_2] + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_8:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (mem[val_2] + 286))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            var val_17 = val_15;
            val_17 = val_17 + 1;
            val_18 = val_18 + val_17;
            val_23 = val_18 + 296;
            label_9:
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters.set_Item(key:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProA, value:  val_6);
            var val_22 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_14;
            }
            
            var val_19 = mem[val_2] + 176;
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_13:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < (mem[val_2] + 286))
            {
                goto label_13;
            }
            
            goto label_14;
            label_12:
            var val_21 = val_19;
            val_21 = val_21 + 1;
            val_22 = val_22 + val_21;
            val_24 = val_22 + 296;
            label_14:
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters.set_Item(key:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProB, value:  val_10);
            var val_26 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_19;
            }
            
            var val_23 = mem[val_2] + 176;
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_18:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_17;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < (mem[val_2] + 286))
            {
                goto label_18;
            }
            
            goto label_19;
            label_17:
            var val_25 = val_23;
            val_25 = val_25 + 1;
            val_26 = val_26 + val_25;
            val_25 = val_26 + 296;
            label_19:
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters.set_Item(key:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProXchA, value:  val_14);
            var val_30 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_24;
            }
            
            var val_27 = mem[val_1] + 176;
            var val_28 = 0;
            val_27 = val_27 + 8;
            label_23:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_28 = val_28 + 1;
            val_27 = val_27 + 16;
            if(val_28 < (mem[val_1] + 286))
            {
                goto label_23;
            }
            
            goto label_24;
            label_22:
            var val_29 = val_27;
            val_29 = val_29 + 1;
            val_30 = val_30 + val_29;
            val_26 = val_30 + 296;
            label_24:
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds.set_Item(key:  "GostR3410-94-CryptoPro-A", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProA);
            var val_34 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_29;
            }
            
            var val_31 = mem[val_1] + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_28:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_27;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (mem[val_1] + 286))
            {
                goto label_28;
            }
            
            goto label_29;
            label_27:
            var val_33 = val_31;
            val_33 = val_33 + 1;
            val_34 = val_34 + val_33;
            val_27 = val_34 + 296;
            label_29:
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds.set_Item(key:  "GostR3410-94-CryptoPro-B", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProB);
            var val_38 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_34;
            }
            
            var val_35 = mem[val_1] + 176;
            var val_36 = 0;
            val_35 = val_35 + 8;
            label_33:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_32;
            }
            
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            if(val_36 < (mem[val_1] + 286))
            {
                goto label_33;
            }
            
            goto label_34;
            label_32:
            var val_37 = val_35;
            val_37 = val_37 + 1;
            val_38 = val_38 + val_37;
            val_28 = val_38 + 296;
            label_34:
            Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds.set_Item(key:  "GostR3410-94-CryptoPro-XchA", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProXchA);
        }
        public static Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetByOid(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4;
            var val_6;
            val_4 = null;
            val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters;
            if(val_6.Item[oid] == null)
            {
                    return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)val_6;
            }
            
            val_6 = 0;
            return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)val_6;
        }
        public static System.Collections.IEnumerable get_Names()
        {
            var val_3 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds.Keys);
        }
        public static Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetByName(string name)
        {
            var val_6;
            var val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = public System.Object System.Collections.IDictionary::get_Item(object key);
            val_9 = Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds;
            if(val_9.Item[name] == null)
            {
                    return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)val_9;
            }
            
            val_9 = 0;
            return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)val_9;
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
        {
            var val_4;
            var val_6;
            val_4 = null;
            val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds;
            if(val_6.Item[name] == null)
            {
                    return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_6;
            }
            
            val_6 = 0;
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_6;
        }
    
    }

}
