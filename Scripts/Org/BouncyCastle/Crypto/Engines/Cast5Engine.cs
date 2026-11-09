using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class Cast5Engine : IBlockCipher
    {
        // Fields
        internal static readonly uint[] S1;
        internal static readonly uint[] S2;
        internal static readonly uint[] S3;
        internal static readonly uint[] S4;
        internal static readonly uint[] S5;
        internal static readonly uint[] S6;
        internal static readonly uint[] S7;
        internal static readonly uint[] S8;
        internal static readonly int MAX_ROUNDS;
        internal static readonly int RED_ROUNDS;
        private const int BLOCK_SIZE = 8;
        private int[] _Kr;
        private uint[] _Km;
        private bool _encrypting;
        private byte[] _workingKey;
        private int _rounds;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        public Cast5Engine()
        {
            var val_3;
            this._Kr = new int[17];
            this._Km = new uint[17];
            val_3 = null;
            val_3 = null;
            this._rounds = Org.BouncyCastle.Crypto.Engines.Cast5Engine.MAX_ROUNDS;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            object val_9;
            var val_10;
            val_9 = parameters;
            if(val_9 != null)
            {
                    this._encrypting = forEncryption;
                val_9 = 0;
                this._workingKey = val_9.GetKey();
                return;
            }
            
            val_10 = new System.ArgumentException(message:  "Invalid parameter passed to " + this + " init - "(" init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_9)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_9)));
        }
        public virtual string get_AlgorithmName()
        {
            return "CAST5";
        }
        public virtual bool get_IsPartialBlockOkay()
        {
            return false;
        }
        public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            if(this._workingKey != null)
            {
                    Org.BouncyCastle.Crypto.Check.DataLength(buf:  input, off:  inOff, len:  -357751888, msg:  "input buffer too short");
                Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  -357751888, msg:  "output buffer too short");
                var val_1 = (this._encrypting == true) ? 272 : 288;
                val_1 = 1152921505536290816 + val_1;
                return this.Equals(obj:  input);
            }
            
            System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  this + " not initialised");
        }
        public virtual void Reset()
        {
        
        }
        public virtual int GetBlockSize()
        {
            return 8;
        }
        internal virtual void SetKey(byte[] key)
        {
            if(key.Length <= 10)
            {
                    mem[1152921551494235488] = Org.BouncyCastle.Crypto.Engines.Cast5Engine.RED_ROUNDS;
            }
            
            int[] val_1 = new int[16];
            int[] val_2 = new int[16];
            if(key.Length >= 1)
            {
                    do
            {
                val_2[0] = key[0];
            }
            while(1 < key.Length);
            
            }
            
            int val_428 = val_2[6];
            System.UInt32[] val_7 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[6]) << 2);
            int val_429 = val_2[7];
            System.UInt32[] val_8 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[7]) << 2);
            int val_430 = val_2[6];
            System.UInt32[] val_9 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[6]) << 2);
            int val_431 = val_2[7];
            System.UInt32[] val_10 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[7]) << 2);
            int val_432 = val_2[4];
            System.UInt32[] val_11 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            uint val_12 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[6]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  0));
            val_12 = val_12 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[7]) << 2) + 32);
            val_12 = val_12 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[6]) << 2) + 32);
            val_12 = val_12 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[7]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_12 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32), b:  val_1, offset:  0);
            int val_433 = val_1[0];
            System.UInt32[] val_14 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            int val_434 = val_1[1];
            System.UInt32[] val_15 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            int val_435 = val_1[0];
            System.UInt32[] val_16 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            int val_436 = val_1[1];
            System.UInt32[] val_17 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            int val_437 = val_2[5];
            uint val_438 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  8);
            System.UInt32[] val_18 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[5]) << 2);
            val_438 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32) ^ val_438;
            val_438 = val_438 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32);
            val_438 = val_438 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32);
            val_438 = val_438 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_438 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[5]) << 2) + 32), b:  val_1, offset:  4);
            int val_439 = val_1[3];
            System.UInt32[] val_20 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[3]) << 2);
            int val_440 = val_1[3];
            System.UInt32[] val_21 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_441 = val_1[2];
            System.UInt32[] val_22 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_442 = val_1[2];
            System.UInt32[] val_23 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[2]) << 2);
            int val_443 = val_2[4];
            uint val_444 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  12);
            System.UInt32[] val_24 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            val_444 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[3]) << 2) + 32) ^ val_444;
            val_444 = val_444 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_444 = val_444 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_444 = val_444 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_444 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32), b:  val_1, offset:  8);
            int val_445 = val_1[5];
            System.UInt32[] val_26 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[5]) << 2);
            int val_446 = val_1[4];
            System.UInt32[] val_27 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[4]) << 2);
            int val_447 = val_1[5];
            System.UInt32[] val_28 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[5]) << 2);
            int val_448 = val_1[4];
            System.UInt32[] val_29 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[4]) << 2);
            int val_449 = val_2[5];
            uint val_450 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  4);
            System.UInt32[] val_30 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[5]) << 2);
            val_450 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[5]) << 2) + 32) ^ val_450;
            val_450 = val_450 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[4]) << 2) + 32);
            val_450 = val_450 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[5]) << 2) + 32);
            val_450 = val_450 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_450 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[5]) << 2) + 32), b:  val_1, offset:  12);
            int val_451 = val_1[4];
            System.UInt32[] val_32 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[4]) << 2);
            int val_452 = val_1[4];
            System.UInt32[] val_33 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[4]) << 2);
            int val_453 = val_1[3];
            System.UInt32[] val_34 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[3]) << 2);
            int val_454 = val_1[3];
            System.UInt32[] val_35 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            int val_455 = val_1[1];
            System.UInt32[] val_36 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[1]) << 2);
            var val_456 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[1]) << 2) + 32;
            var val_37 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[4]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[4]) << 2) + 32);
            val_37 = val_37 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[3]) << 2) + 32);
            val_37 = val_37 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32);
            val_456 = val_37 ^ val_456;
            mem2[0] = val_456;
            int val_457 = val_1[5];
            System.UInt32[] val_38 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[5]) << 2);
            int val_458 = val_1[5];
            System.UInt32[] val_39 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[5]) << 2);
            int val_459 = val_1[2];
            System.UInt32[] val_40 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_460 = val_1[2];
            System.UInt32[] val_41 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[2]) << 2);
            int val_461 = val_1[3];
            System.UInt32[] val_42 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            var val_462 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32;
            var val_43 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[5]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[5]) << 2) + 32);
            val_43 = val_43 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_43 = val_43 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[2]) << 2) + 32);
            val_462 = val_43 ^ val_462;
            mem2[0] = val_462;
            int val_463 = val_1[6];
            System.UInt32[] val_44 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[6]) << 2);
            int val_464 = val_1[6];
            System.UInt32[] val_45 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[6]) << 2);
            int val_465 = val_1[1];
            System.UInt32[] val_46 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[1]) << 2);
            int val_466 = val_1[1];
            System.UInt32[] val_47 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            int val_467 = val_1[4];
            System.UInt32[] val_48 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[4]) << 2);
            var val_468 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[4]) << 2) + 32;
            var val_49 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[6]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[6]) << 2) + 32);
            val_49 = val_49 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[1]) << 2) + 32);
            val_49 = val_49 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32);
            val_468 = val_49 ^ val_468;
            mem2[0] = val_468;
            int val_469 = val_1[7];
            System.UInt32[] val_50 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[7]) << 2);
            int val_470 = val_1[7];
            System.UInt32[] val_51 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[7]) << 2);
            int val_471 = val_1[0];
            System.UInt32[] val_52 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            int val_472 = val_1[0];
            System.UInt32[] val_53 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[0]) << 2);
            int val_473 = val_1[6];
            System.UInt32[] val_54 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[6]) << 2);
            var val_474 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[6]) << 2) + 32;
            var val_55 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[7]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[7]) << 2) + 32);
            val_55 = val_55 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32);
            val_55 = val_55 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[0]) << 2) + 32);
            val_474 = val_55 ^ val_474;
            mem2[0] = val_474;
            int val_475 = val_1[2];
            System.UInt32[] val_60 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[2]) << 2);
            int val_476 = val_1[3];
            System.UInt32[] val_61 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_477 = val_1[2];
            System.UInt32[] val_62 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_478 = val_1[3];
            System.UInt32[] val_63 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            int val_479 = val_1[0];
            System.UInt32[] val_64 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            uint val_65 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[2]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  8));
            val_65 = val_65 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_65 = val_65 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_65 = val_65 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_65 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32), b:  val_2, offset:  0);
            int val_480 = val_2[0];
            System.UInt32[] val_67 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[0]) << 2);
            int val_481 = val_2[1];
            System.UInt32[] val_68 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[1]) << 2);
            int val_482 = val_2[0];
            System.UInt32[] val_69 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[0]) << 2);
            int val_483 = val_2[1];
            System.UInt32[] val_70 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[1]) << 2);
            int val_484 = val_1[1];
            uint val_485 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  0);
            System.UInt32[] val_71 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            val_485 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[0]) << 2) + 32) ^ val_485;
            val_485 = val_485 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[1]) << 2) + 32);
            val_485 = val_485 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[0]) << 2) + 32);
            val_485 = val_485 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_485 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32), b:  val_2, offset:  4);
            int val_486 = val_2[3];
            System.UInt32[] val_73 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[3]) << 2);
            int val_487 = val_2[3];
            System.UInt32[] val_74 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            int val_488 = val_2[2];
            System.UInt32[] val_75 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[2]) << 2);
            int val_489 = val_2[2];
            System.UInt32[] val_76 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[2]) << 2);
            int val_490 = val_1[0];
            uint val_491 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  4);
            System.UInt32[] val_77 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            val_491 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[3]) << 2) + 32) ^ val_491;
            val_491 = val_491 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32);
            val_491 = val_491 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[2]) << 2) + 32);
            val_491 = val_491 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_491 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32), b:  val_2, offset:  8);
            int val_492 = val_2[5];
            System.UInt32[] val_79 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[5]) << 2);
            int val_493 = val_2[4];
            System.UInt32[] val_80 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[4]) << 2);
            int val_494 = val_2[5];
            System.UInt32[] val_81 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[5]) << 2);
            int val_495 = val_2[4];
            System.UInt32[] val_82 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[4]) << 2);
            int val_496 = val_1[1];
            uint val_497 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  12);
            System.UInt32[] val_83 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            val_497 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[5]) << 2) + 32) ^ val_497;
            val_497 = val_497 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[4]) << 2) + 32);
            val_497 = val_497 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[5]) << 2) + 32);
            val_497 = val_497 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_497 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32), b:  val_2, offset:  12);
            int val_498 = val_2[1];
            System.UInt32[] val_85 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[1]) << 2);
            int val_499 = val_2[1];
            System.UInt32[] val_86 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[1]) << 2);
            int val_500 = val_2[6];
            System.UInt32[] val_87 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[6]) << 2);
            int val_501 = val_2[6];
            System.UInt32[] val_88 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[6]) << 2);
            int val_502 = val_2[4];
            System.UInt32[] val_89 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            var val_503 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32;
            var val_90 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[1]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[1]) << 2) + 32);
            val_90 = val_90 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[6]) << 2) + 32);
            val_90 = val_90 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[6]) << 2) + 32);
            val_503 = val_90 ^ val_503;
            mem2[0] = val_503;
            int val_504 = val_2[0];
            System.UInt32[] val_91 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[0]) << 2);
            int val_505 = val_2[0];
            System.UInt32[] val_92 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[0]) << 2);
            int val_506 = val_2[7];
            System.UInt32[] val_93 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[7]) << 2);
            int val_507 = val_2[7];
            System.UInt32[] val_94 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[7]) << 2);
            int val_508 = val_2[6];
            System.UInt32[] val_95 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[6]) << 2);
            var val_509 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[6]) << 2) + 32;
            var val_96 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[0]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[0]) << 2) + 32);
            val_96 = val_96 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[7]) << 2) + 32);
            val_96 = val_96 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[7]) << 2) + 32);
            val_509 = val_96 ^ val_509;
            mem2[0] = val_509;
            int val_510 = val_2[3];
            System.UInt32[] val_97 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[3]) << 2);
            int val_511 = val_2[3];
            System.UInt32[] val_98 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            int val_512 = val_2[4];
            System.UInt32[] val_99 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            int val_513 = val_2[4];
            System.UInt32[] val_100 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[4]) << 2);
            int val_514 = val_2[1];
            System.UInt32[] val_101 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[1]) << 2);
            var val_515 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[1]) << 2) + 32;
            var val_102 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[3]) << 2) + 32);
            val_102 = val_102 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32);
            val_102 = val_102 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[4]) << 2) + 32);
            val_515 = val_102 ^ val_515;
            mem2[0] = val_515;
            int val_516 = val_2[2];
            System.UInt32[] val_103 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[2]) << 2);
            int val_517 = val_2[2];
            System.UInt32[] val_104 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[2]) << 2);
            int val_518 = val_2[5];
            System.UInt32[] val_105 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[5]) << 2);
            int val_519 = val_2[5];
            System.UInt32[] val_106 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[5]) << 2);
            int val_520 = val_2[3];
            System.UInt32[] val_107 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[3]) << 2);
            var val_521 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[3]) << 2) + 32;
            var val_108 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[2]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[2]) << 2) + 32);
            val_108 = val_108 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[5]) << 2) + 32);
            val_108 = val_108 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[5]) << 2) + 32);
            val_521 = val_108 ^ val_521;
            mem2[0] = val_521;
            int val_522 = val_2[6];
            System.UInt32[] val_113 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[6]) << 2);
            int val_523 = val_2[7];
            System.UInt32[] val_114 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[7]) << 2);
            int val_524 = val_2[6];
            System.UInt32[] val_115 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[6]) << 2);
            int val_525 = val_2[7];
            System.UInt32[] val_116 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[7]) << 2);
            int val_526 = val_2[4];
            System.UInt32[] val_117 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            uint val_118 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[6]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  0));
            val_118 = val_118 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[7]) << 2) + 32);
            val_118 = val_118 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[6]) << 2) + 32);
            val_118 = val_118 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[7]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_118 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32), b:  val_1, offset:  0);
            int val_527 = val_1[0];
            System.UInt32[] val_120 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            int val_528 = val_1[1];
            System.UInt32[] val_121 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            int val_529 = val_1[0];
            System.UInt32[] val_122 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            int val_530 = val_1[1];
            System.UInt32[] val_123 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            int val_531 = val_2[5];
            uint val_532 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  8);
            System.UInt32[] val_124 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[5]) << 2);
            val_532 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32) ^ val_532;
            val_532 = val_532 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32);
            val_532 = val_532 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32);
            val_532 = val_532 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_532 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[5]) << 2) + 32), b:  val_1, offset:  4);
            int val_533 = val_1[3];
            System.UInt32[] val_126 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[3]) << 2);
            int val_534 = val_1[3];
            System.UInt32[] val_127 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_535 = val_1[2];
            System.UInt32[] val_128 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_536 = val_1[2];
            System.UInt32[] val_129 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[2]) << 2);
            int val_537 = val_2[4];
            uint val_538 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  12);
            System.UInt32[] val_130 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            val_538 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[3]) << 2) + 32) ^ val_538;
            val_538 = val_538 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_538 = val_538 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_538 = val_538 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_538 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32), b:  val_1, offset:  8);
            int val_539 = val_1[5];
            System.UInt32[] val_132 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[5]) << 2);
            int val_540 = val_1[4];
            System.UInt32[] val_133 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[4]) << 2);
            int val_541 = val_1[5];
            System.UInt32[] val_134 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[5]) << 2);
            int val_542 = val_1[4];
            System.UInt32[] val_135 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[4]) << 2);
            int val_543 = val_2[5];
            uint val_544 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  4);
            System.UInt32[] val_136 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[5]) << 2);
            val_544 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[5]) << 2) + 32) ^ val_544;
            val_544 = val_544 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[4]) << 2) + 32);
            val_544 = val_544 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[5]) << 2) + 32);
            val_544 = val_544 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_544 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[5]) << 2) + 32), b:  val_1, offset:  12);
            int val_545 = val_1[1];
            System.UInt32[] val_138 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[1]) << 2);
            int val_546 = val_1[1];
            System.UInt32[] val_139 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            int val_547 = val_1[6];
            System.UInt32[] val_140 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[6]) << 2);
            int val_548 = val_1[6];
            System.UInt32[] val_141 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[6]) << 2);
            int val_549 = val_1[4];
            System.UInt32[] val_142 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[4]) << 2);
            var val_550 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[4]) << 2) + 32;
            var val_143 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[1]) << 2) + 32);
            val_143 = val_143 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[6]) << 2) + 32);
            val_143 = val_143 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[6]) << 2) + 32);
            val_550 = val_143 ^ val_550;
            mem2[0] = val_550;
            int val_551 = val_1[0];
            System.UInt32[] val_144 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            int val_552 = val_1[0];
            System.UInt32[] val_145 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[0]) << 2);
            int val_553 = val_1[7];
            System.UInt32[] val_146 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[7]) << 2);
            int val_554 = val_1[7];
            System.UInt32[] val_147 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[7]) << 2);
            int val_555 = val_1[6];
            System.UInt32[] val_148 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[6]) << 2);
            var val_556 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[6]) << 2) + 32;
            var val_149 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[0]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32);
            val_149 = val_149 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[7]) << 2) + 32);
            val_149 = val_149 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[7]) << 2) + 32);
            val_556 = val_149 ^ val_556;
            mem2[0] = val_556;
            int val_557 = val_1[3];
            System.UInt32[] val_150 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[3]) << 2);
            int val_558 = val_1[3];
            System.UInt32[] val_151 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_559 = val_1[4];
            System.UInt32[] val_152 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[4]) << 2);
            int val_560 = val_1[4];
            System.UInt32[] val_153 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[4]) << 2);
            int val_561 = val_1[1];
            System.UInt32[] val_154 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[1]) << 2);
            var val_562 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[1]) << 2) + 32;
            var val_155 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[3]) << 2) + 32);
            val_155 = val_155 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[4]) << 2) + 32);
            val_155 = val_155 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[4]) << 2) + 32);
            val_562 = val_155 ^ val_562;
            mem2[0] = val_562;
            int val_563 = val_1[2];
            System.UInt32[] val_156 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[2]) << 2);
            int val_564 = val_1[2];
            System.UInt32[] val_157 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[2]) << 2);
            int val_565 = val_1[5];
            System.UInt32[] val_158 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[5]) << 2);
            int val_566 = val_1[5];
            System.UInt32[] val_159 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[5]) << 2);
            int val_567 = val_1[3];
            System.UInt32[] val_160 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            var val_568 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32;
            var val_161 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[2]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[2]) << 2) + 32);
            val_161 = val_161 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[5]) << 2) + 32);
            val_161 = val_161 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[5]) << 2) + 32);
            val_568 = val_161 ^ val_568;
            mem2[0] = val_568;
            int val_569 = val_1[2];
            System.UInt32[] val_166 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[2]) << 2);
            int val_570 = val_1[3];
            System.UInt32[] val_167 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_571 = val_1[2];
            System.UInt32[] val_168 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_572 = val_1[3];
            System.UInt32[] val_169 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            int val_573 = val_1[0];
            System.UInt32[] val_170 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            uint val_171 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[2]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  8));
            val_171 = val_171 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_171 = val_171 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_171 = val_171 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_171 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32), b:  val_2, offset:  0);
            int val_574 = val_2[0];
            System.UInt32[] val_173 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[0]) << 2);
            int val_575 = val_2[1];
            System.UInt32[] val_174 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[1]) << 2);
            int val_576 = val_2[0];
            System.UInt32[] val_175 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[0]) << 2);
            int val_577 = val_2[1];
            System.UInt32[] val_176 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[1]) << 2);
            int val_578 = val_1[1];
            uint val_579 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  0);
            System.UInt32[] val_177 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            val_579 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[0]) << 2) + 32) ^ val_579;
            val_579 = val_579 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[1]) << 2) + 32);
            val_579 = val_579 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[0]) << 2) + 32);
            val_579 = val_579 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_579 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32), b:  val_2, offset:  4);
            int val_580 = val_2[3];
            System.UInt32[] val_179 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[3]) << 2);
            int val_581 = val_2[3];
            System.UInt32[] val_180 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            int val_582 = val_2[2];
            System.UInt32[] val_181 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[2]) << 2);
            int val_583 = val_2[2];
            System.UInt32[] val_182 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[2]) << 2);
            int val_584 = val_1[0];
            uint val_585 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  4);
            System.UInt32[] val_183 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            val_585 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[3]) << 2) + 32) ^ val_585;
            val_585 = val_585 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32);
            val_585 = val_585 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[2]) << 2) + 32);
            val_585 = val_585 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_585 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32), b:  val_2, offset:  8);
            int val_586 = val_2[5];
            System.UInt32[] val_185 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[5]) << 2);
            int val_587 = val_2[4];
            System.UInt32[] val_186 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[4]) << 2);
            int val_588 = val_2[5];
            System.UInt32[] val_187 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[5]) << 2);
            int val_589 = val_2[4];
            System.UInt32[] val_188 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[4]) << 2);
            int val_590 = val_1[1];
            uint val_591 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  12);
            System.UInt32[] val_189 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            val_591 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[5]) << 2) + 32) ^ val_591;
            val_591 = val_591 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[4]) << 2) + 32);
            val_591 = val_591 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[5]) << 2) + 32);
            val_591 = val_591 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_591 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32), b:  val_2, offset:  12);
            int val_592 = val_2[4];
            System.UInt32[] val_191 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            int val_593 = val_2[4];
            System.UInt32[] val_192 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[4]) << 2);
            int val_594 = val_2[3];
            System.UInt32[] val_193 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[3]) << 2);
            int val_595 = val_2[3];
            System.UInt32[] val_194 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[3]) << 2);
            int val_596 = val_2[1];
            System.UInt32[] val_195 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[1]) << 2);
            var val_597 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[1]) << 2) + 32;
            var val_196 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[4]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32);
            val_196 = val_196 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[3]) << 2) + 32);
            val_196 = val_196 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[3]) << 2) + 32);
            val_597 = val_196 ^ val_597;
            mem2[0] = val_597;
            int val_598 = val_2[5];
            System.UInt32[] val_197 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[5]) << 2);
            int val_599 = val_2[5];
            System.UInt32[] val_198 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[5]) << 2);
            int val_600 = val_2[2];
            System.UInt32[] val_199 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[2]) << 2);
            int val_601 = val_2[2];
            System.UInt32[] val_200 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[2]) << 2);
            int val_602 = val_2[3];
            System.UInt32[] val_201 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            var val_603 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32;
            var val_202 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[5]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[5]) << 2) + 32);
            val_202 = val_202 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[2]) << 2) + 32);
            val_202 = val_202 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[2]) << 2) + 32);
            val_603 = val_202 ^ val_603;
            mem2[0] = val_603;
            int val_604 = val_2[6];
            System.UInt32[] val_203 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[6]) << 2);
            int val_605 = val_2[6];
            System.UInt32[] val_204 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[6]) << 2);
            int val_606 = val_2[1];
            System.UInt32[] val_205 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[1]) << 2);
            int val_607 = val_2[1];
            System.UInt32[] val_206 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[1]) << 2);
            int val_608 = val_2[4];
            System.UInt32[] val_207 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            var val_609 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32;
            var val_208 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[6]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[6]) << 2) + 32);
            val_208 = val_208 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[1]) << 2) + 32);
            val_208 = val_208 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[1]) << 2) + 32);
            val_609 = val_208 ^ val_609;
            mem2[0] = val_609;
            int val_610 = val_2[7];
            System.UInt32[] val_209 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[7]) << 2);
            int val_611 = val_2[7];
            System.UInt32[] val_210 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[7]) << 2);
            int val_612 = val_2[0];
            System.UInt32[] val_211 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[0]) << 2);
            int val_613 = val_2[0];
            System.UInt32[] val_212 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[0]) << 2);
            int val_614 = val_2[6];
            System.UInt32[] val_213 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[6]) << 2);
            var val_615 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[6]) << 2) + 32;
            var val_214 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[7]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[7]) << 2) + 32);
            val_214 = val_214 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[0]) << 2) + 32);
            val_214 = val_214 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[0]) << 2) + 32);
            val_615 = val_214 ^ val_615;
            mem2[0] = val_615;
            int val_616 = val_2[6];
            System.UInt32[] val_219 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[6]) << 2);
            int val_617 = val_2[7];
            System.UInt32[] val_220 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[7]) << 2);
            int val_618 = val_2[6];
            System.UInt32[] val_221 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[6]) << 2);
            int val_619 = val_2[7];
            System.UInt32[] val_222 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[7]) << 2);
            int val_620 = val_2[4];
            System.UInt32[] val_223 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            uint val_224 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[6]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  0));
            val_224 = val_224 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[7]) << 2) + 32);
            val_224 = val_224 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[6]) << 2) + 32);
            val_224 = val_224 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[7]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_224 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32), b:  val_1, offset:  0);
            int val_621 = val_1[0];
            System.UInt32[] val_226 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            int val_622 = val_1[1];
            System.UInt32[] val_227 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            int val_623 = val_1[0];
            System.UInt32[] val_228 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            int val_624 = val_1[1];
            System.UInt32[] val_229 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            int val_625 = val_2[5];
            uint val_626 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  8);
            System.UInt32[] val_230 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[5]) << 2);
            val_626 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32) ^ val_626;
            val_626 = val_626 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32);
            val_626 = val_626 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32);
            val_626 = val_626 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_626 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[5]) << 2) + 32), b:  val_1, offset:  4);
            int val_627 = val_1[3];
            System.UInt32[] val_232 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[3]) << 2);
            int val_628 = val_1[3];
            System.UInt32[] val_233 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_629 = val_1[2];
            System.UInt32[] val_234 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_630 = val_1[2];
            System.UInt32[] val_235 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[2]) << 2);
            int val_631 = val_2[4];
            uint val_632 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  12);
            System.UInt32[] val_236 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            val_632 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[3]) << 2) + 32) ^ val_632;
            val_632 = val_632 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_632 = val_632 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_632 = val_632 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_632 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32), b:  val_1, offset:  8);
            int val_633 = val_1[5];
            System.UInt32[] val_238 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[5]) << 2);
            int val_634 = val_1[4];
            System.UInt32[] val_239 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[4]) << 2);
            int val_635 = val_1[5];
            System.UInt32[] val_240 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[5]) << 2);
            int val_636 = val_1[4];
            System.UInt32[] val_241 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[4]) << 2);
            int val_637 = val_2[5];
            uint val_638 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  4);
            System.UInt32[] val_242 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[5]) << 2);
            val_638 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[5]) << 2) + 32) ^ val_638;
            val_638 = val_638 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[4]) << 2) + 32);
            val_638 = val_638 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[5]) << 2) + 32);
            val_638 = val_638 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_638 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[5]) << 2) + 32), b:  val_1, offset:  12);
            int val_639 = val_1[4];
            System.UInt32[] val_244 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[4]) << 2);
            int val_640 = val_1[4];
            System.UInt32[] val_245 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[4]) << 2);
            int val_641 = val_1[3];
            System.UInt32[] val_246 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[3]) << 2);
            int val_642 = val_1[3];
            System.UInt32[] val_247 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            int val_643 = val_1[1];
            System.UInt32[] val_248 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[1]) << 2);
            var val_644 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[1]) << 2) + 32;
            var val_249 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[4]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[4]) << 2) + 32);
            val_249 = val_249 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[3]) << 2) + 32);
            val_249 = val_249 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32);
            val_249 = val_249 ^ val_644;
            val_644 = val_249 & 31;
            mem2[0] = val_644;
            int val_645 = val_1[5];
            System.UInt32[] val_250 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[5]) << 2);
            int val_646 = val_1[5];
            System.UInt32[] val_251 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[5]) << 2);
            int val_647 = val_1[2];
            System.UInt32[] val_252 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_648 = val_1[2];
            System.UInt32[] val_253 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[2]) << 2);
            int val_649 = val_1[3];
            System.UInt32[] val_254 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            var val_650 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32;
            var val_255 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[5]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[5]) << 2) + 32);
            val_255 = val_255 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_255 = val_255 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[2]) << 2) + 32);
            val_255 = val_255 ^ val_650;
            val_650 = val_255 & 31;
            mem2[0] = val_650;
            int val_651 = val_1[6];
            System.UInt32[] val_256 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[6]) << 2);
            int val_652 = val_1[6];
            System.UInt32[] val_257 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[6]) << 2);
            int val_653 = val_1[1];
            System.UInt32[] val_258 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[1]) << 2);
            int val_654 = val_1[1];
            System.UInt32[] val_259 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            int val_655 = val_1[4];
            System.UInt32[] val_260 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[4]) << 2);
            var val_656 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[4]) << 2) + 32;
            var val_261 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[6]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[6]) << 2) + 32);
            val_261 = val_261 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[1]) << 2) + 32);
            val_261 = val_261 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32);
            val_261 = val_261 ^ val_656;
            val_656 = val_261 & 31;
            mem2[0] = val_656;
            int val_657 = val_1[7];
            System.UInt32[] val_262 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[7]) << 2);
            int val_658 = val_1[7];
            System.UInt32[] val_263 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[7]) << 2);
            int val_659 = val_1[0];
            System.UInt32[] val_264 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            int val_660 = val_1[0];
            System.UInt32[] val_265 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[0]) << 2);
            int val_661 = val_1[6];
            System.UInt32[] val_266 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[6]) << 2);
            var val_662 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[6]) << 2) + 32;
            var val_267 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[7]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[7]) << 2) + 32);
            val_267 = val_267 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32);
            val_267 = val_267 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[0]) << 2) + 32);
            val_267 = val_267 ^ val_662;
            val_662 = val_267 & 31;
            mem2[0] = val_662;
            int val_663 = val_1[2];
            System.UInt32[] val_272 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[2]) << 2);
            int val_664 = val_1[3];
            System.UInt32[] val_273 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_665 = val_1[2];
            System.UInt32[] val_274 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_666 = val_1[3];
            System.UInt32[] val_275 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            int val_667 = val_1[0];
            System.UInt32[] val_276 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            uint val_277 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[2]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  8));
            val_277 = val_277 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_277 = val_277 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_277 = val_277 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_277 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32), b:  val_2, offset:  0);
            int val_668 = val_2[0];
            System.UInt32[] val_279 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[0]) << 2);
            int val_669 = val_2[1];
            System.UInt32[] val_280 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[1]) << 2);
            int val_670 = val_2[0];
            System.UInt32[] val_281 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[0]) << 2);
            int val_671 = val_2[1];
            System.UInt32[] val_282 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[1]) << 2);
            int val_672 = val_1[1];
            uint val_673 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  0);
            System.UInt32[] val_283 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            val_673 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[0]) << 2) + 32) ^ val_673;
            val_673 = val_673 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[1]) << 2) + 32);
            val_673 = val_673 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[0]) << 2) + 32);
            val_673 = val_673 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_673 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32), b:  val_2, offset:  4);
            int val_674 = val_2[3];
            System.UInt32[] val_285 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[3]) << 2);
            int val_675 = val_2[3];
            System.UInt32[] val_286 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            int val_676 = val_2[2];
            System.UInt32[] val_287 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[2]) << 2);
            int val_677 = val_2[2];
            System.UInt32[] val_288 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[2]) << 2);
            int val_678 = val_1[0];
            uint val_679 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  4);
            System.UInt32[] val_289 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            val_679 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[3]) << 2) + 32) ^ val_679;
            val_679 = val_679 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32);
            val_679 = val_679 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[2]) << 2) + 32);
            val_679 = val_679 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_679 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32), b:  val_2, offset:  8);
            int val_680 = val_2[5];
            System.UInt32[] val_291 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[5]) << 2);
            int val_681 = val_2[4];
            System.UInt32[] val_292 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[4]) << 2);
            int val_682 = val_2[5];
            System.UInt32[] val_293 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[5]) << 2);
            int val_683 = val_2[4];
            System.UInt32[] val_294 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[4]) << 2);
            int val_684 = val_1[1];
            uint val_685 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  12);
            System.UInt32[] val_295 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            val_685 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[5]) << 2) + 32) ^ val_685;
            val_685 = val_685 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[4]) << 2) + 32);
            val_685 = val_685 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[5]) << 2) + 32);
            val_685 = val_685 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_685 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32), b:  val_2, offset:  12);
            int val_686 = val_2[1];
            System.UInt32[] val_297 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[1]) << 2);
            int val_687 = val_2[1];
            System.UInt32[] val_298 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[1]) << 2);
            int val_688 = val_2[6];
            System.UInt32[] val_299 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[6]) << 2);
            int val_689 = val_2[6];
            System.UInt32[] val_300 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[6]) << 2);
            int val_690 = val_2[4];
            System.UInt32[] val_301 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            var val_691 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32;
            var val_302 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[1]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[1]) << 2) + 32);
            val_302 = val_302 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[6]) << 2) + 32);
            val_302 = val_302 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[6]) << 2) + 32);
            val_302 = val_302 ^ val_691;
            val_691 = val_302 & 31;
            mem2[0] = val_691;
            int val_692 = val_2[0];
            System.UInt32[] val_303 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[0]) << 2);
            int val_693 = val_2[0];
            System.UInt32[] val_304 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[0]) << 2);
            int val_694 = val_2[7];
            System.UInt32[] val_305 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[7]) << 2);
            int val_695 = val_2[7];
            System.UInt32[] val_306 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[7]) << 2);
            int val_696 = val_2[6];
            System.UInt32[] val_307 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[6]) << 2);
            var val_697 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[6]) << 2) + 32;
            var val_308 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[0]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[0]) << 2) + 32);
            val_308 = val_308 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[7]) << 2) + 32);
            val_308 = val_308 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[7]) << 2) + 32);
            val_308 = val_308 ^ val_697;
            val_697 = val_308 & 31;
            mem2[0] = val_697;
            int val_698 = val_2[3];
            System.UInt32[] val_309 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[3]) << 2);
            int val_699 = val_2[3];
            System.UInt32[] val_310 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            int val_700 = val_2[4];
            System.UInt32[] val_311 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            int val_701 = val_2[4];
            System.UInt32[] val_312 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[4]) << 2);
            int val_702 = val_2[1];
            System.UInt32[] val_313 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[1]) << 2);
            var val_703 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[1]) << 2) + 32;
            var val_314 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[3]) << 2) + 32);
            val_314 = val_314 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32);
            val_314 = val_314 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[4]) << 2) + 32);
            val_314 = val_314 ^ val_703;
            val_703 = val_314 & 31;
            mem2[0] = val_703;
            int val_704 = val_2[2];
            System.UInt32[] val_315 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[2]) << 2);
            int val_705 = val_2[2];
            System.UInt32[] val_316 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[2]) << 2);
            int val_706 = val_2[5];
            System.UInt32[] val_317 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[5]) << 2);
            int val_707 = val_2[5];
            System.UInt32[] val_318 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[5]) << 2);
            int val_708 = val_2[3];
            System.UInt32[] val_319 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[3]) << 2);
            var val_709 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[3]) << 2) + 32;
            var val_320 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[2]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[2]) << 2) + 32);
            val_320 = val_320 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[5]) << 2) + 32);
            val_320 = val_320 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[5]) << 2) + 32);
            val_320 = val_320 ^ val_709;
            val_709 = val_320 & 31;
            mem2[0] = val_709;
            int val_710 = val_2[6];
            System.UInt32[] val_325 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[6]) << 2);
            int val_711 = val_2[7];
            System.UInt32[] val_326 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[7]) << 2);
            int val_712 = val_2[6];
            System.UInt32[] val_327 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[6]) << 2);
            int val_713 = val_2[7];
            System.UInt32[] val_328 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[7]) << 2);
            int val_714 = val_2[4];
            System.UInt32[] val_329 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            uint val_330 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[6]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  0));
            val_330 = val_330 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[7]) << 2) + 32);
            val_330 = val_330 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[6]) << 2) + 32);
            val_330 = val_330 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[7]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_330 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32), b:  val_1, offset:  0);
            int val_715 = val_1[0];
            System.UInt32[] val_332 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            int val_716 = val_1[1];
            System.UInt32[] val_333 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            int val_717 = val_1[0];
            System.UInt32[] val_334 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            int val_718 = val_1[1];
            System.UInt32[] val_335 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            int val_719 = val_2[5];
            uint val_720 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  8);
            System.UInt32[] val_336 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[5]) << 2);
            val_720 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32) ^ val_720;
            val_720 = val_720 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32);
            val_720 = val_720 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32);
            val_720 = val_720 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_720 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[5]) << 2) + 32), b:  val_1, offset:  4);
            int val_721 = val_1[3];
            System.UInt32[] val_338 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[3]) << 2);
            int val_722 = val_1[3];
            System.UInt32[] val_339 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_723 = val_1[2];
            System.UInt32[] val_340 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_724 = val_1[2];
            System.UInt32[] val_341 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[2]) << 2);
            int val_725 = val_2[4];
            uint val_726 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  12);
            System.UInt32[] val_342 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            val_726 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[3]) << 2) + 32) ^ val_726;
            val_726 = val_726 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_726 = val_726 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_726 = val_726 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_726 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32), b:  val_1, offset:  8);
            int val_727 = val_1[5];
            System.UInt32[] val_344 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[5]) << 2);
            int val_728 = val_1[4];
            System.UInt32[] val_345 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[4]) << 2);
            int val_729 = val_1[5];
            System.UInt32[] val_346 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[5]) << 2);
            int val_730 = val_1[4];
            System.UInt32[] val_347 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[4]) << 2);
            int val_731 = val_2[5];
            uint val_732 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_2, i:  4);
            System.UInt32[] val_348 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[5]) << 2);
            val_732 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[5]) << 2) + 32) ^ val_732;
            val_732 = val_732 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[4]) << 2) + 32);
            val_732 = val_732 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[5]) << 2) + 32);
            val_732 = val_732 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_732 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[5]) << 2) + 32), b:  val_1, offset:  12);
            int val_733 = val_1[1];
            System.UInt32[] val_350 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[1]) << 2);
            int val_734 = val_1[1];
            System.UInt32[] val_351 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            int val_735 = val_1[6];
            System.UInt32[] val_352 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[6]) << 2);
            int val_736 = val_1[6];
            System.UInt32[] val_353 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[6]) << 2);
            int val_737 = val_1[4];
            System.UInt32[] val_354 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[4]) << 2);
            var val_738 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[4]) << 2) + 32;
            var val_355 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[1]) << 2) + 32);
            val_355 = val_355 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[6]) << 2) + 32);
            val_355 = val_355 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[6]) << 2) + 32);
            val_355 = val_355 ^ val_738;
            val_738 = val_355 & 31;
            mem2[0] = val_738;
            int val_739 = val_1[0];
            System.UInt32[] val_356 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            int val_740 = val_1[0];
            System.UInt32[] val_357 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[0]) << 2);
            int val_741 = val_1[7];
            System.UInt32[] val_358 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[7]) << 2);
            int val_742 = val_1[7];
            System.UInt32[] val_359 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[7]) << 2);
            int val_743 = val_1[6];
            System.UInt32[] val_360 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[6]) << 2);
            var val_744 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[6]) << 2) + 32;
            var val_361 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[0]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32);
            val_361 = val_361 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[7]) << 2) + 32);
            val_361 = val_361 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[7]) << 2) + 32);
            val_361 = val_361 ^ val_744;
            val_744 = val_361 & 31;
            mem2[0] = val_744;
            int val_745 = val_1[3];
            System.UInt32[] val_362 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[3]) << 2);
            int val_746 = val_1[3];
            System.UInt32[] val_363 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_747 = val_1[4];
            System.UInt32[] val_364 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[4]) << 2);
            int val_748 = val_1[4];
            System.UInt32[] val_365 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[4]) << 2);
            int val_749 = val_1[1];
            System.UInt32[] val_366 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[1]) << 2);
            var val_750 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[1]) << 2) + 32;
            var val_367 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[3]) << 2) + 32);
            val_367 = val_367 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[4]) << 2) + 32);
            val_367 = val_367 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[4]) << 2) + 32);
            val_367 = val_367 ^ val_750;
            val_750 = val_367 & 31;
            mem2[0] = val_750;
            int val_751 = val_1[2];
            System.UInt32[] val_368 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[2]) << 2);
            int val_752 = val_1[2];
            System.UInt32[] val_369 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[2]) << 2);
            int val_753 = val_1[5];
            System.UInt32[] val_370 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[5]) << 2);
            int val_754 = val_1[5];
            System.UInt32[] val_371 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[5]) << 2);
            int val_755 = val_1[3];
            System.UInt32[] val_372 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            var val_756 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32;
            var val_373 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[2]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[2]) << 2) + 32);
            val_373 = val_373 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[5]) << 2) + 32);
            val_373 = val_373 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[5]) << 2) + 32);
            val_373 = val_373 ^ val_756;
            val_756 = val_373 & 31;
            mem2[0] = val_756;
            int val_757 = val_1[2];
            System.UInt32[] val_378 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[2]) << 2);
            int val_758 = val_1[3];
            System.UInt32[] val_379 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[3]) << 2);
            int val_759 = val_1[2];
            System.UInt32[] val_380 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[2]) << 2);
            int val_760 = val_1[3];
            System.UInt32[] val_381 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[3]) << 2);
            int val_761 = val_1[0];
            System.UInt32[] val_382 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_1[0]) << 2);
            uint val_383 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[2]) << 2) + 32) ^ (Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  8));
            val_383 = val_383 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[3]) << 2) + 32);
            val_383 = val_383 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[2]) << 2) + 32);
            val_383 = val_383 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[3]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_383 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_1[0]) << 2) + 32), b:  val_2, offset:  0);
            int val_762 = val_2[0];
            System.UInt32[] val_385 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[0]) << 2);
            int val_763 = val_2[1];
            System.UInt32[] val_386 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[1]) << 2);
            int val_764 = val_2[0];
            System.UInt32[] val_387 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[0]) << 2);
            int val_765 = val_2[1];
            System.UInt32[] val_388 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[1]) << 2);
            int val_766 = val_1[1];
            uint val_767 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  0);
            System.UInt32[] val_389 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_1[1]) << 2);
            val_767 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[0]) << 2) + 32) ^ val_767;
            val_767 = val_767 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[1]) << 2) + 32);
            val_767 = val_767 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[0]) << 2) + 32);
            val_767 = val_767 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[1]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_767 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_1[1]) << 2) + 32), b:  val_2, offset:  4);
            int val_768 = val_2[3];
            System.UInt32[] val_391 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[3]) << 2);
            int val_769 = val_2[3];
            System.UInt32[] val_392 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            int val_770 = val_2[2];
            System.UInt32[] val_393 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[2]) << 2);
            int val_771 = val_2[2];
            System.UInt32[] val_394 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[2]) << 2);
            int val_772 = val_1[0];
            uint val_773 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  4);
            System.UInt32[] val_395 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_1[0]) << 2);
            val_773 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[3]) << 2) + 32) ^ val_773;
            val_773 = val_773 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32);
            val_773 = val_773 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[2]) << 2) + 32);
            val_773 = val_773 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[2]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_773 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_1[0]) << 2) + 32), b:  val_2, offset:  8);
            int val_774 = val_2[5];
            System.UInt32[] val_397 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[5]) << 2);
            int val_775 = val_2[4];
            System.UInt32[] val_398 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[4]) << 2);
            int val_776 = val_2[5];
            System.UInt32[] val_399 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[5]) << 2);
            int val_777 = val_2[4];
            System.UInt32[] val_400 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[4]) << 2);
            int val_778 = val_1[1];
            uint val_779 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.IntsTo32bits(b:  val_1, i:  12);
            System.UInt32[] val_401 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_1[1]) << 2);
            val_779 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[5]) << 2) + 32) ^ val_779;
            val_779 = val_779 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[4]) << 2) + 32);
            val_779 = val_779 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[5]) << 2) + 32);
            val_779 = val_779 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[4]) << 2) + 32);
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.Bits32ToInts(inData:  val_779 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_1[1]) << 2) + 32), b:  val_2, offset:  12);
            int val_780 = val_2[4];
            System.UInt32[] val_403 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[4]) << 2);
            int val_781 = val_2[4];
            System.UInt32[] val_404 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[4]) << 2);
            int val_782 = val_2[3];
            System.UInt32[] val_405 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[3]) << 2);
            int val_783 = val_2[3];
            System.UInt32[] val_406 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[3]) << 2);
            int val_784 = val_2[1];
            System.UInt32[] val_407 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[1]) << 2);
            var val_785 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[1]) << 2) + 32;
            var val_408 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[4]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[4]) << 2) + 32);
            val_408 = val_408 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[3]) << 2) + 32);
            val_408 = val_408 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[3]) << 2) + 32);
            val_408 = val_408 ^ val_785;
            val_785 = val_408 & 31;
            mem2[0] = val_785;
            int val_786 = val_2[5];
            System.UInt32[] val_409 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[5]) << 2);
            int val_787 = val_2[5];
            System.UInt32[] val_410 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[5]) << 2);
            int val_788 = val_2[2];
            System.UInt32[] val_411 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[2]) << 2);
            int val_789 = val_2[2];
            System.UInt32[] val_412 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[2]) << 2);
            int val_790 = val_2[3];
            System.UInt32[] val_413 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[3]) << 2);
            var val_791 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[3]) << 2) + 32;
            var val_414 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[5]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[5]) << 2) + 32);
            val_414 = val_414 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[2]) << 2) + 32);
            val_414 = val_414 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[2]) << 2) + 32);
            val_414 = val_414 ^ val_791;
            val_791 = val_414 & 31;
            mem2[0] = val_791;
            int val_792 = val_2[6];
            System.UInt32[] val_415 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[6]) << 2);
            int val_793 = val_2[6];
            System.UInt32[] val_416 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[6]) << 2);
            int val_794 = val_2[1];
            System.UInt32[] val_417 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[1]) << 2);
            int val_795 = val_2[1];
            System.UInt32[] val_418 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[1]) << 2);
            int val_796 = val_2[4];
            System.UInt32[] val_419 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[4]) << 2);
            var val_797 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[4]) << 2) + 32;
            var val_420 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[6]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[6]) << 2) + 32);
            val_420 = val_420 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[1]) << 2) + 32);
            val_420 = val_420 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[1]) << 2) + 32);
            val_420 = val_420 ^ val_797;
            val_797 = val_420 & 31;
            mem2[0] = val_797;
            int val_798 = val_2[7];
            System.UInt32[] val_421 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + ((val_2[7]) << 2);
            int val_799 = val_2[7];
            System.UInt32[] val_422 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + ((val_2[7]) << 2);
            int val_800 = val_2[0];
            System.UInt32[] val_423 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + ((val_2[0]) << 2);
            int val_801 = val_2[0];
            System.UInt32[] val_424 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[0]) << 2);
            int val_802 = val_2[6];
            System.UInt32[] val_425 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + ((val_2[6]) << 2);
            var val_803 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[6]) << 2) + 32;
            var val_426 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 + (val_2[7]) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 + (val_2[7]) << 2) + 32);
            val_426 = val_426 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 + (val_2[0]) << 2) + 32);
            val_426 = val_426 ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 + (val_2[0]) << 2) + 32);
            val_426 = val_426 ^ val_803;
            val_803 = val_426 & 31;
            mem2[0] = val_803;
        }
        internal virtual int EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
        {
            uint[] val_4 = new uint[2];
            this.CAST_Encipher(L0:  Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  src, off:  srcIndex), R0:  Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  src, off:  srcIndex + 4), result:  val_4);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  val_4[0], bs:  dst, off:  dstIndex);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  val_4[0], bs:  dst, off:  dstIndex + 4);
            return 8;
        }
        internal virtual int DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
        {
            uint[] val_4 = new uint[2];
            this.CAST_Decipher(L16:  Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  src, off:  srcIndex), R16:  Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  src, off:  srcIndex + 4), result:  val_4);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  val_4[0], bs:  dst, off:  dstIndex);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  val_4[0], bs:  dst, off:  dstIndex + 4);
            return 8;
        }
        internal static uint F1(uint D, uint Kmi, int Kri)
        {
            var val_7;
            int val_8 = Kri;
            uint val_7 = D;
            val_7 = Kmi + val_7;
            val_8 = (-val_8) & 31;
            val_7 = null;
            val_7 = null;
            val_8 = val_7 >> val_8;
            val_7 = val_8 >> 24;
            int val_1 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.BLOCK_SIZE + (((((Kmi + D) >> (Kri & 31)) >> 24)) << 2);
            System.UInt32[] val_2 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S2 + (((uint)((((Kmi + D) >> (Kri & 31))>>16) & 0xFF)) << 2);
            System.UInt32[] val_3 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S3 + (((uint)((((Kmi + D) >> (Kri & 31))>>8) & 0xFF)) << 2);
            val_8 = val_8 & 255;
            System.UInt32[] val_4 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S4 + (((((Kmi + D) >> (Kri & 31)) & 255)) << 2);
            var val_5 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S2 + ((uint)((((Kmi + D) >> (Kri & 31))>>16) & 0xFF)) << 2) + 32) ^ ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.BLOCK_SIZE + ((((Kmi + D) >> (Kri & 31)) >> 24)) << 2) + 32);
            val_5 = val_5 - ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S3 + ((uint)((((Kmi + D) >> (Kri & 31))>>8) & 0xFF)) << 2) + 32);
            return (uint)val_5 + ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S4 + ((((Kmi + D) >> (Kri & 31)) & 255)) << 2) + 32);
        }
        internal static uint F2(uint D, uint Kmi, int Kri)
        {
            var val_7;
            int val_8 = Kri;
            uint val_7 = D;
            val_7 = Kmi ^ val_7;
            val_8 = (-val_8) & 31;
            val_7 = null;
            val_7 = null;
            val_8 = val_7 >> val_8;
            val_7 = val_8 >> 24;
            int val_1 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.BLOCK_SIZE + (((((Kmi ^ D) >> (Kri & 31)) >> 24)) << 2);
            System.UInt32[] val_2 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S2 + (((uint)((((Kmi ^ D) >> (Kri & 31))>>16) & 0xFF)) << 2);
            System.UInt32[] val_3 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S3 + (((uint)((((Kmi ^ D) >> (Kri & 31))>>8) & 0xFF)) << 2);
            val_8 = val_8 & 255;
            System.UInt32[] val_4 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S4 + (((((Kmi ^ D) >> (Kri & 31)) & 255)) << 2);
            var val_5 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.BLOCK_SIZE + ((((Kmi ^ D) >> (Kri & 31)) >> 24)) << 2) + 32) - ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S2 + ((uint)((((Kmi ^ D) >> (Kri & 31))>>16) & 0xFF)) << 2) + 32);
            val_5 = val_5 + ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S3 + ((uint)((((Kmi ^ D) >> (Kri & 31))>>8) & 0xFF)) << 2) + 32);
            return (uint)((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S4 + ((((Kmi ^ D) >> (Kri & 31)) & 255)) << 2) + 32) ^ val_5;
        }
        internal static uint F3(uint D, uint Kmi, int Kri)
        {
            var val_7;
            int val_8 = Kri;
            uint val_7 = D;
            val_7 = Kmi - val_7;
            val_8 = (-val_8) & 31;
            val_7 = null;
            val_7 = null;
            val_8 = val_7 >> val_8;
            val_7 = val_8 >> 24;
            int val_1 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.BLOCK_SIZE + (((((Kmi - D) >> (Kri & 31)) >> 24)) << 2);
            System.UInt32[] val_2 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S2 + (((uint)((((Kmi - D) >> (Kri & 31))>>16) & 0xFF)) << 2);
            System.UInt32[] val_3 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S3 + (((uint)((((Kmi - D) >> (Kri & 31))>>8) & 0xFF)) << 2);
            val_8 = val_8 & 255;
            System.UInt32[] val_4 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.S4 + (((((Kmi - D) >> (Kri & 31)) & 255)) << 2);
            var val_5 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S2 + ((uint)((((Kmi - D) >> (Kri & 31))>>16) & 0xFF)) << 2) + 32) + ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.BLOCK_SIZE + ((((Kmi - D) >> (Kri & 31)) >> 24)) << 2) + 32);
            val_5 = ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S3 + ((uint)((((Kmi - D) >> (Kri & 31))>>8) & 0xFF)) << 2) + 32) ^ val_5;
            return (uint)val_5 - ((Org.BouncyCastle.Crypto.Engines.Cast5Engine.S4 + ((((Kmi - D) >> (Kri & 31)) & 255)) << 2) + 32);
        }
        internal void CAST_Encipher(uint L0, uint R0, uint[] result)
        {
            uint val_4;
            uint val_5;
            uint val_6;
            var val_7;
            val_4 = R0;
            if(this._rounds < 1)
            {
                goto label_1;
            }
            
            var val_11 = 1;
            label_26:
            val_5 = val_4;
            if(val_11 > 16)
            {
                goto label_5;
            }
            
            if((0 & 74898) != 0)
            {
                goto label_3;
            }
            
            if(0 != 0)
            {
                goto label_4;
            }
            
            val_4 = val_5;
            if(0 == 0)
            {
                goto label_5;
            }
            
            val_6 = val_5;
            uint val_2 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(D:  val_6, Kmi:  this._Km[4], Kri:  this._Kr[1]);
            goto label_19;
            label_3:
            val_6 = val_5;
            uint val_3 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(D:  val_6, Kmi:  this._Km[4], Kri:  this._Kr[1]);
            goto label_19;
            label_4:
            val_6 = val_5;
            label_19:
            val_4 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(D:  val_6, Kmi:  this._Km[4], Kri:  this._Kr[1])) ^ L0;
            label_5:
            val_11 = val_11 + 1;
            if(val_11 <= this._rounds)
            {
                goto label_26;
            }
            
            goto label_27;
            label_1:
            val_5 = L0;
            label_27:
            val_7 = mem[result + 24];
            val_7 = result + 24;
            if(val_7 == 0)
            {
                    val_7 = mem[result + 24];
                val_7 = result + 24;
            }
            
            mem2[0] = val_4;
            mem2[0] = val_5;
        }
        internal void CAST_Decipher(uint L16, uint R16, uint[] result)
        {
            uint val_20;
            int val_21;
            var val_20 = mem[1152921551495929120];
            label_26:
            var val_21 = 0;
            label_5:
            val_20 = val_20 + val_21;
            if(val_20 <= 0)
            {
                goto label_1;
            }
            
            val_21 = val_21 - 1;
            if(val_20 > 16)
            {
                goto label_5;
            }
            
            val_20 = 1 << val_20;
            if((val_20 & 74898) != 0)
            {
                goto label_3;
            }
            
            if((val_20 & 18724) != 0)
            {
                goto label_4;
            }
            
            val_20 = val_20 & 37448;
            if(val_20 == 0)
            {
                goto label_5;
            }
            
            var val_4 = (val_20 + val_21) + 1;
            var val_5 = mem[1152921551495929096] + (val_20 << 2);
            val_5 = val_5 + (((0 - 1)) << 2);
            var val_6 = mem[1152921551495929088] + (val_20 << 2);
            val_6 = val_6 + (((0 - 1)) << 2);
            val_20 = R16;
            uint val_7 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(D:  val_20, Kmi:  ((mem[1152921551495929096] + (mem[1152921551495929120]) << 2) + ((0 - 1)) << 2) + 36, Kri:  ((mem[1152921551495929088] + (mem[1152921551495929120]) << 2) + ((0 - 1)) << 2) + 36);
            goto label_19;
            label_3:
            var val_9 = (val_20 + val_21) + 1;
            var val_10 = mem[1152921551495929096] + (val_20 << 2);
            val_10 = val_10 + (((0 - 1)) << 2);
            var val_11 = mem[1152921551495929088] + (val_20 << 2);
            val_11 = val_11 + (((0 - 1)) << 2);
            val_20 = R16;
            uint val_12 = Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(D:  val_20, Kmi:  ((mem[1152921551495929096] + (mem[1152921551495929120]) << 2) + ((0 - 1)) << 2) + 36, Kri:  ((mem[1152921551495929088] + (mem[1152921551495929120]) << 2) + ((0 - 1)) << 2) + 36);
            goto label_19;
            label_4:
            var val_14 = (val_20 + val_21) + 1;
            var val_15 = mem[1152921551495929096] + (val_20 << 2);
            val_15 = val_15 + (((0 - 1)) << 2);
            var val_16 = mem[1152921551495929088] + (val_20 << 2);
            val_16 = val_16 + (((0 - 1)) << 2);
            val_20 = R16;
            label_19:
            uint val_18 = (Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(D:  val_20, Kmi:  ((mem[1152921551495929096] + (mem[1152921551495929120]) << 2) + ((0 - 1)) << 2) + 36, Kri:  ((mem[1152921551495929088] + (mem[1152921551495929120]) << 2) + ((0 - 1)) << 2) + 36)) ^ L16;
            var val_19 = val_20 + val_21;
            goto label_26;
            label_1:
            val_21 = result.Length;
            if(val_21 == 0)
            {
                    val_21 = result.Length;
            }
            
            result[0] = R16;
            result[0] = L16;
        }
        internal static void Bits32ToInts(uint inData, int[] b, int offset)
        {
            int val_1 = offset + 3;
            b[((long)(int)((offset + 3))) << 2] = inData & 255;
            int val_3 = offset + 2;
            b[((long)(int)((offset + 2))) << 2] = (uint)(inData >> 8) & 255;
            int val_4 = offset + 1;
            b[((long)(int)((offset + 1))) << 2] = (uint)(inData >> 16) & 255;
            b[((long)(int)(offset)) << 2] = inData >> 24;
        }
        internal static uint IntsTo32bits(int[] b, int i)
        {
            int val_5 = b.Length;
            if(val_5 <= i)
            {
                    val_5 = b.Length;
            }
            
            if((i + 1) >= val_5)
            {
                    val_5 = b.Length;
            }
            
            int val_6 = b[((long)(int)((i + 1))) << 2];
            if((i + 2) >= val_5)
            {
                    val_5 = b.Length;
            }
            
            int val_7 = b[((long)(int)((i + 2))) << 2];
            int val_3 = i + 3;
            b = ((b[((long)(int)(i)) << 2]) << 24) | (b[((long)(int)((i + 3))) << 2]);
            return (uint)b;
        }
        private static Cast5Engine()
        {
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.BLOCK_SIZE = new uint[256] {821772500, -1616838901, 1810681135, 1059425402, 505495343, -1677701677, 1610868032, -811611831, -1076580569, -2000962123, -503103344, -1731160459, 1852023008, 365126098, -1025022435, 584384398, 677919599, -1065365415, -14452280, 2002735330, 1136869587, -550533546, -2005097446, -1563247315, -1580605226, 879511577, 1639411079, 575934255, 717107937, -1437329813, 576097850, -1563213360, 1725645000, -1484506833, 5111599, 767152862, -1751892052, 1251459544, 1383482551, -1242286169, -1205028113, -682503847, 1878520045, 1510570527, -2105841456, -1863518930, 582008916, -1131521739, 1265446783, 1354458274, -765048560, -1092255443, -1221385584, -382003809, -1265703919, 1275016285, -45759936, -1389258945, -990457810, 1442611557, -709768531, -1582551634, -1563117715, -1046803376, -2011021070, 208555832, -1528512553, 1331405426, 1447828783, -979610855, -1186340012, -1337562626, -1313428598, -955033379, 1669711173, 286233437, 1465092821, 1782121619, -432195616, 710211251, 980974943, 1651941557, 430374111, 2051154026, 704238805, -165996399, -1150146722, -1437564569, 948965521, -961214997, -2067281012, 718756367, -2025188313, -1563323541, 718440111, -1437150575, -678870176, 1113355533, -1816945114, 410092745, 1811985197, 1944238868, -1598112708, 1415722873, 1682284203, 1060277122, 1998114690, 1503841958, 82706478, -1979811610, 1068173648, 845149890, -2127020283, 1768146376, 1993038550, -728140599, -904393265, 940016341, -939893514, -1966926575, 904371731, 1205506512, -200306554, -1478344290, 825647681, 85914773, -1437123836, 1249926541, 1417871568, 3287612, -1083912737, -1168660850, 1975924523, 1353700161, -1480510859, -1856369675, 1800716203, 722146342, -1421030953, 1151126914, -134483355, -1417296397, 458611604, -1428888796, -811287233, 770352098, -1642050302, -927128148, -354462285, -708993384, -485346894, 718646636, -1790760482, -1380039384, -663679127, -1437480689, -1434948618, 575749918, -1437489253, 718488780, 2069512688, -746783827, 453416197, 1106044049, -1262275866, 52586708, -916452660, -835158419, -1083461268, 1785789304, 218356169, -723568162, -535796774, 1194783844, 1523787992, -1287140202, 1975193539, -1739514885, 1341901877, -1249128598, -518059332, -1077543350, -1492456432, -1405528310, 1057244207, 1636348243, -533104082, 1462225785, -1662303857, 481089165, 718503062, 24497053, -962724087, -950311440, -639942440, -334596231, 1195698900, -1323552140, -584791138, 2115785917, -267303687, -769388879, -1770671107, -1548994731, -730060881, 1372086093, 1452307862, -1514465818, 1476592880, -905696015, 18495466, -1916818725, 901398090, 891748256, -1015329527, -1137676583, -1734007194, 1447622437, -10594659, 216884176, 2086908623, 1879786977, -706064143, -2052511630, -1356874329, -735885200, -1484321805, 758861177, 1121993112, 215018983, 642190776, -125730484, 1196255959, 2081185372, -786228903, 941322904, -170724133, -1417443757, 1848581667, -2089706338, -1114513338, -1705622162, -600236020, 550028657, -1775511012, -504981761, -1321096440, 2093648313, 443148163, 46942275, -1560820359, 1117713533, 1115362972, 1523183689, -577827072, 1551984063};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.S2 = new uint[256] {522195092, -284448933, 1776537470, 960447360, -27144326, -289070982, 1435016340, 1929119313, -1381503111, 1310552629, -715496498, -570149190, -1715195665, 1594623892, 417127293, -1579749389, -1598738565, 1508390405, -300568428, -369108727, -599523194, -275495847, -1165767501, -524038661, -774225535, 990456497, -107482687, -1511600261, 21106139, -454561957, 631373633, -511641594, 532942976, 396095098, -746928471, -27774812, -1730245761, 2011709262, 2039648873, 620404603, -518797221, -1396440957, -682609371, -135634593, 1645490516, 223693667, 1567101217, -932789415, 1029951347, -824036160, -724009337, 1550265121, 119497089, 972513919, 907948164, -454338757, 1613718692, -700789348, 465323573, -1635712211, 654439692, -1719371084, -1595678855, -1167264884, 277098644, 624404830, -194023426, -1577108705, 546110314, -1891267468, -639589849, 1321679412, -58175639, 1045293279, -284295032, 895050893, -1975175028, 494945126, 1914543101, -1517910853, -400202957, -2075229678, 311263384, -19710028, -836236575, 669096869, -710491566, -459844419, -975809059, -345608092, 2005142349, -1581864959, -2066012503, -524982508, 569394103, -439330720, 1425027204, 108000370, -1558535853, -623098027, -1251844673, 1750473702, -2083886188, 762237499, -321977893, -1496067910, -1233109668, -1351112951, 867476300, 964413654, 1591880597, 1594774276, -2115145887, 552026980, -1268903048, -568826981, -2011389662, -1184422191, -2142656536, 582474363, 1582640421, 1383256631, 2043843868, -972191412, 1217180674, 463797851, -1531928725, 480777679, -1576259579, -2005803165, -1176621109, 214354409, 200212307, -484358889, -1269553099, -1620891332, -297670871, 1847405948, 1342460550, 510035443, -214695482, 815934613, 833030224, 1620250387, 1945732119, -1591306151, -328967100, 1388869545, -838913114, -1607788735, 2092620194, 562037615, 1356438536, -885045151, -1033119899, 1688467115, -2144065930, 631725691, -454635012, 549916902, -839862656, 394546491, 837744717, 2114462948, 751520235, -2073412690, -1879607160, -295870218, 2063029875, 803036379, -1592380991, 821456707, -1275401132, 360699898, -276465204, -783098280, -617611938, -1892495847, 812317050, 49299192, -1724802347, -1035798001, -1478235216, -963753722, -1193663732, -2138951640, -589368376, -748703375, 143268808, -1094662816, 1638124008, -1129777843, -953159686, 578956953, -2100989772, -656847223, -1961085764, 807278310, 658237817, -1325405530, 1641658566, 11683945, -1207972289, 148645947, 1138423386, -136210536, 1981396783, -1893950556, -595183712, 380097457, -1614572617, -1491898645, -960707010, 441530178, -278386500, 1375954390, 761952171, 891809099, -2111843818, 157052462, -611126533, 1592404427, 341349109, -1856483457, 1417898363, 644327628, -2061934520, -1941197590, -2093457196, 220455161, 1815641738, 182899273, -1299947508, -667585763, -592329145, -1404283158, 1052606899, 588164016, 1681439879, -256527878, -1889623373, -65518014, 167996282, 1336969661, 1688053129, -1555742370, 1543734051, 1046297529, 1138201970, 2121126012, 115334942, 1819067631, 1902159161, 1941945968, -2088274427, 1159982321};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.S3 = new uint[256] {-1913667008, 637164959, -342868545, -401553145, 1197506559, 916448331, -1944074684, -1362179440, -1095632449, -285488406, -389080752, 1373570990, -1844541434, -257096376, -516125309, -1838149419, 286293407, 124026297, -1293687596, 1028597854, -1179670496, -86080800, -1603852661, -2106427090, 1430237888, 1218109995, -722495596, 308166588, 570424558, -2107958275, -1839872531, 307733056, 1310360322, -1159692289, 1384269543, -1906895858, 863238079, -1935703672, -1493414168, -914180699, -1463804489, 1470087780, 1728663345, -222478497, 1090516929, 532123132, -1905536319, 1132193179, -1716503105, -1243888053, 1670234342, 1434557849, -1583888356, 1241591150, -980923864, -859607183, -1203518957, 1812415473, -2096527044, 267246943, 796911696, -675250306, 38830015, 1526438404, -1488465200, 374413614, -1351565506, 1489179520, 1603809326, 1920779204, 168801282, 260042626, -1936261715, 1563175598, -1897293239, 1356499128, -2077756256, 514611088, 2037363785, -2108498923, -272794213, -1502455427, -1381482280, 1173701892, -94538749, -398540027, 1334932762, -1839830590, 602925377, -1459359442, 1613172210, 41346230, -1795332748, -1837529678, -2106139701, 41386358, -122711667, 1313404830, -1889440289, -492993522, -2077262461, 873260488, -1766082942, -1816874680, -282051413, -1739608280, 2006953883, -1831053811, 575479328, -2076726648, 2099895446, 660001756, -1953465106, -1256205760, -406815517, -446253919, -1008115362, 1022894237, 1620365795, -845372607, 1551255054, 15374395, -724141951, -45656276, -143856167, -1113054564, 310226346, 1133119310, 530038928, 136043402, -1818198338, -1187460587, -1750057729, 1036173560, -1927630100, 1681395281, 1758231547, -653318264, 306774401, 1575354324, -578881430, 1990386196, -1180433560, -1839360625, 1262092282, -1170624791, -1526738165, -84438213, 1833535011, 423410938, 660763973, -2107837318, 1639812000, -786545967, -827521804, 310289298, 272797111, -2106414734, -1838103384, 310240523, 677093832, 1013118031, 901835429, -402271695, 1116285435, -1258496126, 1337354835, 243122523, 520626091, 277223598, -50526099, -100718455, 1766575121, 594173102, 316590669, 742362309, -758108674, -118531946, -456174886, -1793762457, 1229605004, -1179211764, 1552908988, -1982633147, 979407927, -335492695, 1148277331, 176638793, -680281024, 2083809052, 40992502, 1340822838, -1563414529, -759209788, -734067776, 1354035053, 122129617, 7215240, -1562034347, -1176054596, -1576763370, -1755891661, -685736601, -569405635, 1928887091, -1412673741, 1988674909, 2063640240, -1803878399, 1459647954, -105150216, -1992162914, 1113892351, -2057108768, 1927010603, -292086935, 1856122846, 1594404395, -1350934163, -439777433, -819991598, 1643104450, -240376463, -863880766, 1730235576, -1310358575, -1210302878, 2131803598, -116761544, 267404349, 1617849798, 1616132681, 1462223176, 736725533, -1967909064, 551665188, -1349068273, 1749386277, -1719452699, 1611482493, 674206544, -2093698206, -652406496, 728599968, 1680547377, -1674552832, 1388111496, 453204106, -138743851, 1094905244, -1540269039, -2093859131, -537967050, -1590442751, -372026596, -298502269};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.S4 = new uint[256] {-1649212384, 532081118, -1480688657, -764173672, 1246723035, 1689095255, -2058288061, -100528431, 2116582143, -435177885, 157234593, 2045505824, -49963709, 1687664561, -211542173, 605965023, 672431967, 1336064205, -918355904, 214114848, -36500688, -1062914225, 489488601, 605322005, -296939238, 264917351, 1912574028, 756637694, 436560991, 202637054, 135989450, 85393697, -2142043904, -398565634, -1399130888, 2145855233, -759632289, 115294817, -1147233398, 1922296357, -830144545, -177108991, 1037454084, -1569774021, 2127856640, 1417604070, 1148013728, 1827919605, 642362335, -1365194763, 909348033, 1346338451, -747167647, 297154785, 1917849091, -133254469, -1411362770, -326273058, 1469521537, -514889914, -919383040, 1763717519, 136166297, -3996507, 1295325189, 2134727907, -1496815930, 1566297257, -622039062, -1617793135, -1622793681, 965822077, -1514181234, 289653839, 1133871874, -803123477, 35685304, 1068898316, 418943774, 672553190, 642281022, -1948808592, 1954014401, -1257840516, -215152091, 2030668546, -454378623, 672283427, 1776201016, 359975446, -544793758, 555499703, -1524982023, 1324923, 69110472, 152125443, -1118182190, -472820011, 1340634837, 798073664, 1434183902, 15393959, 216384236, 1303690150, -413745665, -583833172, -333991883, 106373927, -1716533072, 1455997841, 1801814300, 1578393881, 1854262133, -1106788350, -1036888713, -1992297236, 1539295533, -789824731, -1216341321, -1922221276, 549938159, -1016683012, -1674041216, 181285381, -1429646198, -324937785, 68876850, 488006234, 1728155692, -1686799788, 836007927, -1859735503, 919367643, -955544762, -639210936, 1457871481, 40520939, 1380155135, 797931188, 234455205, -2039165469, -304478997, 397000196, 739833055, -1217101923, -1423247436, -272413408, 772369276, 390177364, -441016267, 557662966, 740064294, 1640166671, 1699928825, -759025160, 622006121, -669614174, 68743880, 1742502, 219489963, 1664179233, 1577743084, 1236991741, 410585305, -1928479354, 823226535, 1050371084, -868347689, -708127818, 212779912, -147848735, 1819446015, 1911218849, 530248558, -808726225, -1042381801, -1408778645, -884694568, -1952772266, 20547779, -1312477238, -1262603827, -663214074, 312714466, 1870521650, 1493008054, -803280640, 615382978, -191295547, -1760449851, 1932181, -2098862126, 278426614, 6369430, -1020422879, -1381948929, 697336853, 2143000447, -1348553765, 701099306, 1558357093, -1489964244, -794148888, -1973632879, -727831321, 216290473, -703935098, 23009561, 1996984579, -559924490, 2024298078, -555526433, 569400510, -1955208313, -1278933423, -1197095953, -655444270, -450642313, -1038793431, 795471839, -1343849733, -193936206, -203363493, -691234698, 971261452, 534414648, 428311343, -905940121, -1450097416, 694888862, 1227866773, -1838760277, -1251512727, -1680613926, -545389265, -618303460, 459166190, -162323226, 1794958188, 51825668, -2042355394, -1210295856, 2036672799, -858325693, 1099053433, -1825845770, -1235762355, 1323291266, 2061838604, 1018778475, -2061623042, -1741466242, 334295216, -738217102, 1065731521, 183467730};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.S5 = new uint[256] {2127105028, 745436345, -1693554977, -1506576111, -1200979969, 500390133, 1155374404, 389092991, 150729210, -403369524, -771417344, 1935325696, 716645080, 946045387, -1393155014, 1774124410, -425531521, -255385395, -1001830378, -856309376, 948246080, 363898952, -427091765, 1286266623, 1598556673, 68334250, 630723836, 1104211938, 1312863373, 613332731, -1917182722, 1101634306, 441780740, -1165007413, 1917973735, -1784342747, -1056510761, -1750755318, -986072662, 1299840618, -218892445, 1756332096, -317940138, 297047435, -504669560, -2029394256, -673156778, 1311375015, 1667687725, 47300608, -995324411, -1820854927, 201668394, 1468347890, 576830978, -700276535, -552361344, 1958042578, 1747032512, -735975956, 1408974056, -928125517, 682131401, 1033214337, 1545599232, -29830247, 206503691, 103024618, -1439739983, 1337551222, -1865968379, -1331124364, -279600641, -442719550, -1498010329, -429243805, -547028961, 247794022, -539142724, 702416469, -1860275302, 397379957, 851939612, -1980197784, 218229120, 1380406772, 62274761, 214451378, -1124863830, -2018756887, -449154010, 28563499, 446592073, 1693330814, -841240102, 29968656, -1201094784, 220656637, -1824330265, 77972100, 1667708854, 1358280214, -230201629, -1899350335, 325977563, -17726575, -74941897, -689440812, -939819575, 811859167, -1225422370, -332840486, 652502677, -1219075047, -162205755, -796043081, 1217549313, -1044722817, -436251377, -1240977335, 1538642152, -2015941030, -1419088159, 574252750, -970198067, -1643608583, 1758150215, 141295887, -1575098336, -779392546, -201959561, -100482058, 1082055363, -877406896, 395511885, -1328083270, 179534037, -648938740, -556279210, 1092926436, -1798698154, 257381841, -522066578, 1636087230, 1477059743, -1795732544, -483948402, -1619307167, -1008991616, 90732309, 1684827095, 1150307763, 1723134115, -1057921910, 1769919919, 1240018934, 815675215, 750138730, -2055174797, 1234303040, 1995484674, 138143821, 675421338, 1145607174, 1936608440, -1056364272, -1949737018, 2105974004, 323969391, 779555213, -1290064927, -1433357198, 1017501463, 2098600890, -1666346992, -1354355806, -1612424750, 1171473753, -638395885, -607759225, -203097778, 393037935, 159126506, 1662887367, 1147106178, 391545844, -842634601, 1891500680, -1278357646, 1851642611, 546529401, 1167818917, -1100946725, -1446891263, -341495460, 575554290, 475796850, -160294100, 450035699, -1943715762, 844027695, 1080539133, 86184846, 1554234488, -602941842, 1972511363, 2018339607, 1491841390, 1141460869, 1061690759, -50418053, 2008416118, -1943862593, -1426819754, 1598468138, 722020353, 1027143159, 212344630, 1387219594, 1725294528, -549779340, -1794813680, 458938280, -165751379, 1828119673, 544571780, -791741851, -1997029800, 1241802790, 267843827, -1600356496, 1397140384, 1558801448, -512299613, 1806446719, 929573330, -2060054615, 400817706, 616011623, -173446368, -691198571, 1761550015, 1968522284, -241236290, -102734438, -289847011, 872482584, -1154430280, -400359915, -2007561853, 1963876937, -631079339, 1584857000, -1319942842, 1833426440, -269883436};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.S6 = new uint[256] {-151351395, 749497569, 1285769319, -499941508, -1780807449, 23610292, -319988548, 844452780, -1080096416, -543038739, -2081400931, 1676510905, 448177848, -564216263, -208668878, -1987464904, 871450977, -1072089155, -184105254, -463315330, -1559696743, 1310974780, 2043402188, 1218528103, -1558931943, -20362283, -1592518838, -358606746, -1601905875, 162023535, -1467457206, 687910808, 23484817, -510056349, -923595680, 779677500, -791340750, -821040108, -137754670, -794288014, -46065282, -1828346192, -395582502, 1958663117, 925738300, 1283408968, -625617856, 1840910019, 137959847, -1615139111, 1239142320, 1315376211, 1547541505, 1690155329, 739140458, -1166157363, -361794680, -418658462, 905091803, 1548541325, -254505588, -1199483934, 144808038, 451078856, 676114313, -1433239005, -1825259949, 993665471, 373509091, -1695926010, -269958290, -124727847, -2145227346, -1019173725, -545350647, -1500207097, 1534877388, 572371878, -1704353745, 1753320020, -827184785, 1405125690, -24562091, 633333386, -1268610372, -819843393, 632057672, -1448504441, 1404951397, -412091417, -379060872, 195638627, -1909183551, -392094743, 1233155085, -938967556, -1914388583, -1592720992, 2144565621, -631626048, -400582321, -1792488055, -46948371, -1200081729, 1594115437, 572884632, -909850565, 767645374, 1331858858, 1475698373, -501085506, -762220865, 1321687957, 619889600, 1121017241, -854753376, 2070816767, -1461941520, 1933951238, -199351505, 890643334, -420837082, 859025556, 360630002, 925594799, 1764062180, -374745016, -216661367, 979562269, -1484266952, -207227274, 1949714515, 546639971, 1165388173, -1225075705, 1495988560, 922170659, 1291546247, 2107952832, 1813327274, -888957272, -988938659, -53016661, 153207855, -1981812549, 1608695416, 1150242611, 1967526857, 721801357, 1220138373, -603679679, -938897509, 2112743302, -1013304461, 1111556101, 1778980689, 250857638, -1996459306, 673216130, -1448478786, -1087215715, -732210315, -1286341376, -877599912, -2096160246, 529510932, -747450616, -868464109, -1930022554, 102533054, -2000056440, 1617093527, 1204784762, -1228385661, 1019391227, 1069574518, 1317995090, 1691889997, -633835293, 510022745, -1056372496, 1362108837, 1817929911, -2110813536, 805817662, 1953603311, -595122559, 120799444, 2118332377, 207536705, -2012665748, -174925679, 145305846, -1786842363, -1208221763, -1033442961, 1877257368, -1317802816, -1134513110, -1791715110, -73290222, 759945014, 254147243, -1527513877, -493448925, 629083197, -1823953079, 907280572, -394170550, 940896768, -1543946173, -1669704510, -1133490345, -633214983, -1034235078, 1425318020, -1317055227, 1496677566, -306375224, 2140652971, -1168455755, -1225335121, 977771578, 1392695845, 1698528874, 1411812681, 1369733098, 1343739227, -674079352, 1142123638, 67414216, -1192910559, -1206218102, 1626167401, -1748673642, -353593061, 697522451, 33404913, 143560186, -1699285259, 994885535, 1247667115, -435872459, -1595811755, -747942671, -180032021, -1326893788, -1095004227, -1562942769, 1237921620, 951448369, 1898488916, 1211705605, -1503978056, -2061723715, -696922321};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.S7 = new uint[256] {-2048901095, 858518887, 1714274303, -809085293, 713916271, -1415853806, -564131679, 539548191, 36158695, 1298409750, 419087104, 1358007170, 749914897, -1305286820, 1261868530, -1299773474, -1604338442, -851344919, -514842356, -498142787, -1318534271, -35330167, 1551479000, 512490819, 1296650241, 951993153, -1858277859, -1834509249, 144139966, -1158763020, 310820559, -1226126567, 643875328, 1969602020, 1680088954, -2109154135, -1011634842, 672358534, 198762408, 896343282, 276269502, -1280120370, 84060815, 197145886, 376173866, -351076478, -481793775, -749898474, 1316698879, 1598252827, -1661542345, 1233235075, 859989710, -1936506441, -791128896, -885363576, 1203513385, 1193654839, -1502948821, 2060853022, 207403770, 1144516871, -1226335902, 1121114134, 177607304, -509230994, 326409831, 1929119770, -1311688201, -111659195, -820388008, -1094453418, -1066485200, 119610148, 1170376745, -916573825, -1131494127, 951863017, -957941228, -1159178166, -1387348922, 1183797387, 2015970143, -249292741, -2111980897, -1342828556, -366195091, 384012900, -1839969653, 10178499, -1415148307, -1698074760, 111523738, -1299878290, 451689641, -1098676600, 235406569, 1441906262, -404408773, -1281232291, -136397947, 1644036924, 376726067, 1006849064, -630387596, 2041234796, 1021632941, 1374734338, -1728515238, 371631263, -287823063, 490221539, 206551450, -1154328712, 1053219195, 1853335209, -882537636, -732811065, 735133835, 1623211703, -1190752904, -1556654860, -198129539, -928574718, -1184003022, -338368578, -1098146515, 2038037254, -417180920, -1955213449, 300912036, -528234408, -1922336657, 1516443558, -94570592, 1574567987, -225525840, -172375280, -1595227520, 146372218, -1546005840, 2043888151, 35287437, -1698286742, 655490400, 1132482787, 110692520, 1031794116, -2106774545, 1324057718, 1217253157, 919197030, 686247489, -1033827638, 1028237775, -1159480865, -1235251738, -1834045596, 986174950, -1633155831, -232062595, -1541980304, -585230653, 367056889, 1353824391, 731860949, 1650113154, 1778481506, 784341916, 357075625, -686364864, 1074092588, -1814914526, -483541094, 92751289, 877911070, -694605458, 1231880047, 480201094, -538776313, -1200471343, 434011822, 87971354, 363687820, 1717726236, 1901380172, -368563414, -1813305031, 400339184, 1490350766, -1633512197, 1389319756, -1736180122, 784598401, 1983468483, 30828846, -744439544, -1578691058, -453845082, 1765724805, 1955612312, 1277890269, 1333098070, 1564029816, -1590549681, 1026694237, -1007296108, 1260819201, -945880529, 1016692350, 1582273796, 1073413053, 1995943182, 694588404, 1025494639, -971094594, -743068876, -148112969, 453260480, 1316140391, 1435673405, -1256025343, -808277889, 1622062951, 403978347, 817677117, 950059133, -48888078, -1016901221, 1486738320, 1417279718, 481875527, -1745002071, -361276940, 760697757, 1452955855, -397515859, 1177426808, 1702951038, -209618668, -1847962124, 1084371187, -778531019, -1226630958, 1073369276, 1027665953, -1010778706, 1230553676, 1368340146, -2068720784, 267243139, -2020746534, -224233017, -1797252120, -1871614133, -1790211421};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.S8 = new uint[256] {-501862387, -1143078916, -1477715267, 895778965, 2005530807, -423554533, 237245952, 86829237, 296341424, -443207919, -320366326, -1819881100, 709006108, 1994621201, -1322389702, 937287164, -560275791, 168608556, -1105629143, -2069886656, -1155253745, -1261357105, -1269925392, 77524477, 185966941, 1208824168, -1950622118, 1721625922, -940775375, 1066374631, 1927223579, 1971335949, -1811463599, 1551748602, -1413583517, -1438637724, -1291725814, 48746954, 1398218158, 2050065058, 313056748, -39177379, 393167848, 1912293076, 940740642, -829121836, -1203279443, -1772365726, -2097950635, 1727764327, 364383054, 492521376, 1291706479, -1030830920, 1474851438, 1685747964, -1719247548, 1619776915, 1814040067, 970743798, 1561002147, -1369198606, 2123093554, 1880132620, -1143779255, 697884420, -1743981526, -1687292783, -1635852973, 110200136, 1489731079, 997519150, 1378877361, -767096628, 478029773, -1528094373, 1022481122, 431258168, 1112503832, 897933369, -1659379993, 669726182, -911214981, 918222264, 163866573, -1047981903, -518144133, 114105080, 1903216136, 761148244, -723629734, 1690750982, -1128217044, 1037045171, 1888456500, 2010454850, 642736655, 616092351, 365016990, 1185228132, -120068786, 1043824992, 2023083429, -2053368411, -431646840, -1015298209, -620250612, 108438443, 2132974366, 830746235, 606445527, -121703310, -2090861384, 1844756978, -1762283115, -49614596, -1325526196, -498045635, 1335562986, -233442779, -1574734993, -1615543256, 634407289, 885462008, -1000242809, -361075048, 2094100220, 339117932, -246136569, -1092686316, 1458155303, -1605721023, 1022871705, -1829979418, -580451987, 353796843, -1472008481, -38117196, -242189451, 551748367, 618185374, -516331717, -274317384, 1904685140, -1225601221, -1624087486, -887774004, -1340455676, -236683891, -2075517979, -1159208996, 1120655984, -847401462, 1474845562, -717268234, 550456716, -828058584, 2043752612, 881257467, 869518812, 2005220179, 938474677, -989427848, -444550170, 1315485940, -976702594, 226533026, 965733244, 321539988, 1136104718, 804158748, 573969341, -586757470, 937399083, -1004240247, -1393300541, 1461057207, -281773859, -228105873, -1052193820, -1873641122, 1581322155, -1266015131, 786071460, -394575644, -376528764, 1485433313, -271347460, -586689701, -616016236, 953673138, 1467089153, 1930354364, 1533292819, -1802404273, 1346121658, 1685000834, 1965281866, -529033579, -104760689, 2052792609, -779634538, 690371149, -1169093409, -2114683745, -1391369235, -361014939, 436236910, 289419410, 14314871, 1242357089, -1390459389, 1616633776, -1628585116, 585885352, -823668086, -1595459936, 1432659641, 277164553, -940863689, 770115018, -1991158001, -553024981, -1117185428, -1441602318, -2025513969, -520707462, 987383833, 1290892879, 225909803, 1741533526, 890078084, 1496906255, 1111072499, 916028167, 243534141, 1252605537, -2090805125, 531204876, 290011180, -378133083, 102027703, 237315147, 209093447, 1486785922, 220223953, -1536771298, -119928190, 82940208, -1167176000, -1725542044, 518464269, 1353887104, -353474559, -1917672829, -359926370};
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.MAX_ROUNDS = 16;
            Org.BouncyCastle.Crypto.Engines.Cast5Engine.RED_ROUNDS = 12;
        }
    
    }

}
