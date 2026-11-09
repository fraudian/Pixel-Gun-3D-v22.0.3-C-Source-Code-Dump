using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class Salsa20Engine : IStreamCipher
    {
        // Fields
        public static readonly int DEFAULT_ROUNDS;
        private const int StateSize = 16;
        private static readonly uint[] TAU_SIGMA;
        protected static readonly byte[] sigma;
        protected static readonly byte[] tau;
        protected int rounds;
        private int index;
        internal uint[] engineState;
        internal uint[] x;
        private byte[] keyStream;
        private bool initialised;
        private uint cW0;
        private uint cW1;
        private uint cW2;
        
        // Properties
        protected virtual int NonceSize { get; }
        public virtual string AlgorithmName { get; }
        
        // Methods
        internal void PackTauOrSigma(int keyLength, uint[] state, int stateOffset)
        {
            var val_12;
            int val_12 = keyLength;
            int val_1 = val_12 - 16;
            val_12 = null;
            val_12 = (val_1 < 0) ? (val_12 - 13) : (val_1);
            val_12 = null;
            val_12 = val_12 >> 2;
            var val_13 = (long)val_12;
            System.UInt32[] val_3 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2))) << 2);
            state[((long)(int)(stateOffset)) << 2] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2))) << 2) + 32;
            var val_4 = val_13 + 1;
            System.UInt32[] val_5 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2)) + 1)) << 2);
            int val_6 = stateOffset + 1;
            state[((long)(int)((stateOffset + 1))) << 2] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2)) + 1)) << 2) + 32;
            var val_7 = val_13 + 2;
            System.UInt32[] val_8 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2)) + 2)) << 2);
            int val_9 = stateOffset + 2;
            state[((long)(int)((stateOffset + 2))) << 2] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2)) + 2)) << 2) + 32;
            val_13 = val_13 + 3;
            System.UInt32[] val_10 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2)) + 3)) << 2);
            int val_11 = stateOffset + 3;
            state[((long)(int)((stateOffset + 3))) << 2] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyLength - 13) : (keyLength - 16) >> 2)) + 3)) << 2) + 32;
        }
        public Salsa20Engine()
        {
            null = null;
        }
        public Salsa20Engine(int rounds)
        {
            this.engineState = new uint[16];
            this.x = new uint[16];
            this.keyStream = new byte[64];
            if((rounds >= 1) && ((rounds & 1) == 0))
            {
                    this.rounds = rounds;
                return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "\'rounds\' must be a positive, even number");
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            val_13 = this;
            if(parameters == null)
            {
                goto label_3;
            }
            
            if((parameters.GetIV() == null) || (val_13 != val_1.Length))
            {
                goto label_5;
            }
            
            val_14 = 0;
            Org.BouncyCastle.Crypto.ICipherParameters val_2 = parameters.Parameters;
            if(val_2 == null)
            {
                goto label_6;
            }
            
            System.Byte[] val_3 = val_2.GetKey();
            goto label_9;
            label_6:
            if(this.initialised == false)
            {
                goto label_10;
            }
            
            label_9:
            this.initialised = true;
            return;
            label_3:
            val_13 = this + " Init requires an IV";
            System.ArgumentException val_5 = null;
            val_16 = val_5;
            val_5 = new System.ArgumentException(message:  val_13, paramName:  "parameters");
            goto label_13;
            label_5:
            string val_7 = +new object[4];
            val_13 = ;
            System.ArgumentException val_9 = null;
            val_16 = val_9;
            val_9 = new System.ArgumentException(message:  val_13);
            label_13:
            val_15 = 1152921553210720848;
            val_14 = 0;
            label_10:
            val_13 = new Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(algorithm:  public System.Void Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters::.ctor(Org.BouncyCastle.Math.EC.ECPoint q, Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet), d:  public System.Void Org.BouncyCastle.Crypto.Engines.Salsa20Engine::Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters), parameters:  null);
            System.InvalidOperationException val_12 = new System.InvalidOperationException(message:  val_13 + " KeyParameter can not be null for first initialisation");
            goto label_13;
        }
        protected virtual int get_NonceSize()
        {
            return 8;
        }
        public virtual string get_AlgorithmName()
        {
            var val_2;
            object val_3;
            val_2 = null;
            val_3 = "Salsa20";
            val_2 = null;
            if(this.rounds == Org.BouncyCastle.Crypto.Engines.Salsa20Engine.StateSize)
            {
                    return (string)val_3;
            }
            
            val_3 = val_3 + "/"("/") + this.rounds;
            return (string)val_3;
        }
        public virtual byte ReturnByte(byte input)
        {
            int val_3;
            uint val_3 = this.cW0;
            val_3 = val_3 + 1;
            this.cW0 = val_3;
            if(val_3 != 0)
            {
                goto label_2;
            }
            
            uint val_4 = this.cW1;
            val_4 = val_4 + 1;
            this.cW1 = val_4;
            if(val_4 != 0)
            {
                goto label_2;
            }
            
            uint val_5 = this.cW2;
            val_5 = val_5 + 1;
            this.cW2 = val_5;
            if((val_5 & 32) != 0)
            {
                goto label_3;
            }
            
            label_2:
            val_3 = this.index;
            if(val_3 == 0)
            {
                    val_3 = this.index;
            }
            
            int val_7 = this.index;
            val_7 = val_7 + 1;
            val_7 = val_7 & 63;
            this.index = val_7;
            return (byte)this.keyStream[(long)val_3] ^ input;
            label_3:
            Org.BouncyCastle.Crypto.MaxBytesExceededException val_2 = new Org.BouncyCastle.Crypto.MaxBytesExceededException(message:  "2^70 byte limit per IV; Change IV");
        }
        protected virtual void AdvanceCounter()
        {
            uint val_1 = this.engineState[8];
            val_1 = val_1 + 1;
            this.engineState[8] = val_1;
            if(val_1 != 0)
            {
                    return;
            }
            
            this = this.engineState;
            uint val_2 = this[9];
            val_2 = val_2 + 1;
            this[9] = val_2;
        }
        public virtual void ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
        {
            int val_5;
            int val_6;
            int val_7;
            val_6 = outOff;
            int val_10 = inOff;
            if(this.initialised == false)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Crypto.Check.DataLength(buf:  inBytes, off:  val_10, len:  len, msg:  "input buffer too short");
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  outBytes, off:  val_6, len:  len, msg:  "output buffer too short");
            uint val_4 = this.cW0;
            val_4 = val_4 + len;
            this.cW0 = val_4;
            if()
            {
                goto label_3;
            }
            
            uint val_5 = this.cW1;
            val_5 = val_5 + 1;
            this.cW1 = val_5;
            if(val_5 != 0)
            {
                goto label_3;
            }
            
            uint val_6 = this.cW2;
            val_6 = val_6 + 1;
            this.cW2 = val_6;
            if((val_6 & 32) != 0)
            {
                goto label_4;
            }
            
            label_3:
            if(len < 1)
            {
                    return;
            }
            
            val_7 = this.index;
            int val_9 = len;
            do
            {
                if(val_7 == 0)
            {
                    val_7 = this.index;
            }
            
                byte val_7 = this.keyStream[(long)val_7];
                val_7 = inBytes[(long)val_10] ^ val_7;
                outBytes[(long)val_6] = val_7;
                int val_11 = this.index;
                val_6 = val_6 + 1;
                val_9 = val_9 - 1;
                val_10 = val_10 + 1;
                val_11 = val_11 + 1;
                val_5 = val_11 & 63;
                this.index = val_5;
            }
            while(val_9 != 0);
            
            return;
            label_1:
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  this + " not initialised");
            label_14:
            label_4:
            Org.BouncyCastle.Crypto.MaxBytesExceededException val_3 = new Org.BouncyCastle.Crypto.MaxBytesExceededException(message:  "2^70 byte limit per IV would be exceeded; Change IV");
            goto label_14;
        }
        public virtual void Reset()
        {
            this.index = 0;
            this.cW0 = 0;
            this.cW1 = 0;
            this.cW2 = 0;
            goto typeof(Org.BouncyCastle.Crypto.Engines.Salsa20Engine).__il2cppRuntimeField_228;
        }
        protected virtual void ResetCounter()
        {
            int val_1 = this.engineState.Length;
            if(val_1 <= 9)
            {
                    val_1 = this.engineState.Length;
            }
            
            this.engineState[9] = 0;
            this.engineState[8] = 0;
        }
        protected virtual void SetKey(byte[] keyBytes, byte[] ivBytes)
        {
            System.UInt32[] val_12;
            var val_13;
            val_12 = this;
            if(keyBytes != null)
            {
                    int val_12 = keyBytes.Length;
                int val_1 = val_12 - 16;
                if()
            {
                    if(val_12 != 32)
            {
                goto label_3;
            }
            
            }
            
                val_12 = val_12 - 13;
                var val_2 = (val_1 < 0) ? (val_12) : (val_1);
                val_13 = null;
                val_13 = null;
                val_2 = val_2 >> 2;
                var val_13 = (long)val_2;
                System.UInt32[] val_3 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2))) << 2);
                this.engineState[0] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2))) << 2) + 32;
                var val_4 = val_13 + 1;
                System.UInt32[] val_5 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2)) + 1)) << 2);
                this.engineState[5] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2)) + 1)) << 2) + 32;
                var val_6 = val_13 + 2;
                System.UInt32[] val_7 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2)) + 2)) << 2);
                this.engineState[10] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2)) + 2)) << 2) + 32;
                val_13 = val_13 + 3;
                System.UInt32[] val_8 = Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + ((((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2)) + 3)) << 2);
                this.engineState[15] = (Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA + (((long)(int)((val_1 < 0 ? (keyBytes.Length - 13) : (keyBytes.Length - 16) >> 2)) + 3)) << 2) + 32;
                Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  keyBytes, bOff:  0, ns:  this.engineState, nOff:  1, count:  4);
                Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  keyBytes, bOff:  keyBytes.Length - 16, ns:  this.engineState, nOff:  11, count:  4);
            }
            else
            {
                    val_12 = this.engineState;
            }
            
            Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  ivBytes, bOff:  0, ns:  mem[this.engineState], nOff:  6, count:  2);
            return;
            label_3:
            System.ArgumentException val_11 = new System.ArgumentException(message:  this + " requires 128 bit or 256 bit key");
        }
        protected virtual void GenerateKeyStream(byte[] output)
        {
            Org.BouncyCastle.Crypto.Engines.Salsa20Engine.SalsaCore(rounds:  this.rounds, input:  this.engineState, x:  this.x);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(ns:  this.x, bs:  output, off:  0);
        }
        internal static void SalsaCore(int rounds, uint[] input, uint[] x)
        {
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            System.UInt32[] val_85;
            var val_86;
            var val_87;
            if(((input + 24) != 16) || (x.Length != 16))
            {
                goto label_4;
            }
            
            if((rounds & 1) != 0)
            {
                goto label_5;
            }
            
            val_69 = mem[input + 32];
            val_69 = input + 32;
            if((input + 24) <= 1)
            {
                    val_69 = val_69;
            }
            
            val_70 = mem[input + 36];
            val_70 = input + 36;
            if((input + 24) <= 2)
            {
                    val_69 = val_69;
                val_70 = val_70;
            }
            
            val_71 = mem[input + 40];
            val_71 = input + 40;
            if((input + 24) <= 3)
            {
                    val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
            }
            
            val_72 = mem[input + 44];
            val_72 = input + 44;
            if((input + 24) <= 4)
            {
                    val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
            }
            
            val_73 = mem[input + 48];
            val_73 = input + 48;
            if((input + 24) <= 5)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
            }
            
            val_74 = mem[input + 52];
            val_74 = input + 52;
            if((input + 24) <= 6)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_75 = mem[input + 56];
            val_75 = input + 56;
            if((input + 24) <= 7)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_76 = mem[input + 60];
            val_76 = input + 60;
            if((input + 24) <= 8)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_77 = mem[input + 64];
            val_77 = input + 64;
            if((input + 24) <= 9)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_78 = mem[input + 68];
            val_78 = input + 68;
            if((input + 24) <= 10)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_79 = mem[input + 72];
            val_79 = input + 72;
            if((input + 24) <= 11)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_80 = mem[input + 76];
            val_80 = input + 76;
            if((input + 24) <= 12)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_81 = mem[input + 80];
            val_81 = input + 80;
            if((input + 24) <= 13)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_82 = mem[input + 84];
            val_82 = input + 84;
            if((input + 24) <= 14)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_83 = mem[input + 88];
            val_83 = input + 88;
            if((input + 24) <= 15)
            {
                    val_73 = val_73;
                val_69 = val_69;
                val_70 = val_70;
                val_71 = val_71;
                val_72 = val_72;
                val_74 = val_74;
            }
            
            val_84 = mem[input + 92];
            val_84 = input + 92;
            if(rounds >= 1)
            {
                    int val_1 = rounds + 2;
                do
            {
                var val_2 = val_69 + val_81;
                var val_3 = val_73 ^ ((((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25));
                var val_4 = val_70 + val_74;
                var val_5 = val_75 + val_79;
                var val_6 = val_80 + val_84;
                var val_7 = val_78 ^ ((((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25));
                var val_8 = val_83 ^ ((((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25));
                var val_9 = val_72 ^ ((((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25));
                var val_10 = val_3 + val_69;
                var val_11 = val_77 ^ (((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << 23));
                var val_12 = val_7 + val_74;
                var val_13 = val_8 + val_79;
                var val_14 = val_9 + val_84;
                var val_15 = val_82 ^ (((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << 23));
                var val_16 = val_71 ^ (((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << 23));
                var val_17 = val_76 ^ (((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << 23));
                var val_18 = val_11 + val_3;
                var val_19 = val_81 ^ (((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) |) << (32-19)) | ((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) |) << 19));
                var val_20 = val_15 + val_7;
                var val_21 = val_17 + val_9;
                var val_22 = val_70 ^ (((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) |) << (32-19)) | ((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) |) << 19));
                var val_23 = val_16 + val_8;
                var val_24 = val_80 ^ (((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) |) << (32-19)) | ((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) |) << 19));
                var val_25 = val_19 + val_11;
                var val_26 = val_75 ^ (((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) |) << (32-19)) | ((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) |) << 19));
                var val_27 = val_69 ^ (((((input + 80 ^ ((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + 8) << (32-14)) | ((((input + 80 ^ ((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + 8) << 14));
                var val_28 = val_22 + val_15;
                var val_29 = val_24 + val_17;
                var val_30 = val_74 ^ (((((input + 36 ^ ((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + 5) << (32-14)) | ((((input + 36 ^ ((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + 5) << 14));
                var val_31 = val_26 + val_16;
                var val_32 = val_84 ^ (((((input + 76 ^ ((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + 9) << (32-14)) | ((((input + 76 ^ ((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + 9) << 14));
                var val_33 = val_27 + val_9;
                var val_34 = val_79 ^ (((((input + 56 ^ ((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + 7) << (32-14)) | ((((input + 56 ^ ((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + 7) << 14));
                val_70 = val_22 ^ (((((input + 32 ^ ((((input + 80 ^ ((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input) << (32-25)) | ((((input + 32 ^ ((((input + 80 ^ ((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input) << 25));
                var val_35 = val_30 + val_3;
                val_75 = val_26 ^ (((((input + 52 ^ ((((input + 36 ^ ((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input) << (32-25)) | ((((input + 52 ^ ((((input + 36 ^ ((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input) << 25));
                var val_36 = val_34 + val_7;
                val_80 = val_24 ^ (((((input + 72 ^ ((((input + 56 ^ ((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input) << (32-25)) | ((((input + 72 ^ ((((input + 56 ^ ((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input) << 25));
                var val_37 = val_32 + val_8;
                val_81 = val_19 ^ (((((input + 92 ^ ((((input + 76 ^ ((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input) << (32-25)) | ((((input + 92 ^ ((((input + 76 ^ ((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input) << 25));
                var val_38 = val_70 + val_27;
                val_71 = val_16 ^ ((((((input + 36 ^ ((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + ) << (32-23)) | (((((input + 36 ^ ((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + ) << 23));
                var val_39 = val_75 + val_30;
                val_76 = val_17 ^ ((((((input + 56 ^ ((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + ) << (32-23)) | (((((input + 56 ^ ((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + ) << 23));
                var val_40 = val_80 + val_34;
                val_77 = val_11 ^ ((((((input + 76 ^ ((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + ) << (32-23)) | (((((input + 76 ^ ((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + ) << 23));
                var val_41 = val_81 + val_32;
                val_82 = val_15 ^ ((((((input + 80 ^ ((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + ) << (32-23)) | (((((input + 80 ^ ((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + ) << 23));
                var val_42 = val_71 + val_70;
                val_72 = val_9 ^ ((((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) ) << (32-19)) | (((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) + input + 72)) << (32-23)) | ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) ) << 19));
                var val_43 = val_76 + val_75;
                val_73 = val_3 ^ ((((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) ) << (32-19)) | (((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) + input + 92)) << (32-23)) | ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) ) << 19));
                var val_44 = val_77 + val_80;
                val_78 = val_7 ^ ((((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) ) << (32-19)) | (((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) + input + 32)) << (32-23)) | ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) ) << 19));
                var val_45 = val_82 + val_81;
                val_83 = val_8 ^ ((((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) ) << (32-19)) | (((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) + input + 52)) << (32-23)) | ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) ) << 19));
                var val_46 = val_72 + val_71;
                val_69 = val_27 ^ ((((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) ^ (((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + ) << (32-14)) | (((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + 92)) << 25)) ^ (((((input + 40 ^ ((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + ) << 14));
                var val_47 = val_73 + val_76;
                val_74 = val_30 ^ ((((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) ^ (((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + ) << (32-14)) | (((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + 80)) << 25)) ^ (((((input + 60 ^ ((((input + 44 ^ (((input + 76 + input + 92)) << (32-25)) | (((input + 76 + input + ) << 14));
                var val_48 = val_78 + val_77;
                val_1 = val_1 - 2;
                val_79 = val_34 ^ ((((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) ^ (((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + ) << (32-14)) | (((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + 52)) << 25)) ^ (((((input + 64 ^ ((((input + 48 ^ (((input + 32 + input + 80)) << (32-25)) | (((input + 32 + input + ) << 14));
                var val_49 = val_83 + val_82;
                val_84 = val_32 ^ ((((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) ^ (((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + ) << (32-14)) | (((((input + 88 ^ (((input + 56 + input + 72)) << (32-25)) | (((input + 56 + input + 72)) << 25)) ^ (((((input + 84 ^ ((((input + 68 ^ (((input + 36 + input + 52)) << (32-25)) | (((input + 36 + input + ) << 14));
            }
            while(val_1 > 2);
            
            }
            
            val_85 = input;
            if(val_85 == 0)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_70 = val_70;
                val_71 = val_71;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
                val_69 = val_69;
            }
            
            if((input + 24) == 0)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_70 = val_70;
                val_71 = val_71;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
                val_69 = val_69;
            }
            
            val_86 = mem[input + 32];
            val_86 = input + 32;
            if(x == 0)
            {
                    var val_65 = val_69;
                val_86 = val_86;
                val_72 = val_72;
                val_73 = val_73;
                val_70 = val_70;
                val_71 = val_71;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
                val_69 = val_65;
            }
            
            val_65 = val_86 + val_69;
            if((x + 24) == 0)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_70 = val_70;
                val_71 = val_71;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = val_65;
            if((input + 24) <= 1)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_70 = val_70;
                val_71 = val_71;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 1)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_71 = val_71;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 36) + val_70;
            if((input + 24) <= 2)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_71 = val_71;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 2)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 40) + val_71;
            if((input + 24) <= 3)
            {
                    val_72 = val_72;
                val_73 = val_73;
                val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 3)
            {
                    val_73 = val_73;
                val_84 = val_84;
                val_74 = val_74;
                val_85 = input;
            }
            
            mem2[0] = (input + 44) + val_72;
            if((input + 24) <= 4)
            {
                    val_73 = val_73;
                val_84 = val_84;
                val_74 = val_74;
                val_85 = input;
            }
            
            if((x + 24) <= 4)
            {
                    val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 48) + val_73;
            if((input + 24) <= 5)
            {
                    val_74 = val_74;
                val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 5)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 52) + val_74;
            if((input + 24) <= 6)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            val_75 = (input + 56) + val_75;
            if((x + 24) <= 6)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = val_75;
            if((input + 24) <= 7)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 7)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 60) + val_76;
            if((input + 24) <= 8)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 8)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 64) + val_77;
            var val_66 = val_78;
            if((input + 24) <= 9)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            val_66 = (input + 68) + val_66;
            if((x + 24) <= 9)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = val_66;
            if((input + 24) <= 10)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 10)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 72) + val_79;
            if((input + 24) <= 11)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 11)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 76) + val_80;
            if((input + 24) <= 12)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 12)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 80) + val_81;
            if((input + 24) <= 13)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 13)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 84) + val_82;
            if((input + 24) <= 14)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            if((x + 24) <= 14)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 88) + val_83;
            if((input + 24) <= 15)
            {
                    val_84 = val_84;
                val_85 = input;
            }
            
            mem2[0] = (input + 92) + val_84;
            return;
            label_4:
            System.ArgumentException val_63 = null;
            val_87 = val_63;
            val_63 = new System.ArgumentException();
            goto label_60;
            label_5:
            System.ArgumentException val_64 = null;
            val_87 = val_64;
            val_64 = new System.ArgumentException(message:  "Number of rounds must be even");
            label_60:
        }
        internal static uint R(uint x, int y)
        {
            var val_1 = -y;
            val_1 = val_1 & 31;
            x = x >> val_1;
            return (uint)x;
        }
        private void ResetLimitCounter()
        {
            this.cW0 = 0;
            this.cW1 = 0;
            this.cW2 = 0;
        }
        private bool LimitExceeded()
        {
            uint val_1 = this.cW0;
            val_1 = val_1 + 1;
            this.cW0 = val_1;
            if(val_1 != 0)
            {
                    return false;
            }
            
            uint val_2 = this.cW1;
            val_2 = val_2 + 1;
            this.cW1 = val_2;
            if(val_2 != 0)
            {
                    return false;
            }
            
            uint val_3 = this.cW2;
            val_3 = val_3 + 1;
            this.cW2 = val_3;
            return (bool)(uint)(val_3 >> 5) & 1;
        }
        private bool LimitExceeded(uint len)
        {
            uint val_1 = this.cW0;
            val_1 = val_1 + len;
            this.cW0 = val_1;
            if()
            {
                    return false;
            }
            
            uint val_2 = this.cW1;
            val_2 = val_2 + 1;
            this.cW1 = val_2;
            if(val_2 != 0)
            {
                    return false;
            }
            
            uint val_3 = this.cW2;
            val_3 = val_3 + 1;
            this.cW2 = val_3;
            return (bool)(uint)(val_3 >> 5) & 1;
        }
        private static Salsa20Engine()
        {
            Org.BouncyCastle.Crypto.Engines.Salsa20Engine.StateSize = 20;
            Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  "expand 16-byte kexpand 32-byte k"), off:  0, count:  8);
            Org.BouncyCastle.Crypto.Engines.Salsa20Engine.sigma = Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  "expand 32-byte k");
            Org.BouncyCastle.Crypto.Engines.Salsa20Engine.tau = Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  "expand 16-byte k");
        }
    
    }

}
