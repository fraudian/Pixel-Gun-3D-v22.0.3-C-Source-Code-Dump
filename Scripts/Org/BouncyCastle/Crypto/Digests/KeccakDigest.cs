using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class KeccakDigest : IDigest, IMemoable
    {
        // Fields
        private static readonly ulong[] KeccakRoundConstants;
        private static readonly int[] KeccakRhoOffsets;
        protected byte[] state;
        protected byte[] dataQueue;
        protected int rate;
        protected int bitsInQueue;
        protected int fixedOutputLength;
        protected bool squeezing;
        protected int bitsAvailableForSqueezing;
        protected byte[] chunk;
        protected byte[] oneByte;
        private ulong[] C;
        private ulong[] tempA;
        private ulong[] chiC;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        private static ulong[] KeccakInitializeRoundConstants()
        {
            ulong[] val_1 = new ulong[24];
            var val_7 = 0;
            do
            {
                var val_6 = 0;
                val_1[val_7] = 0;
                do
            {
                if((1 & 1) != 0)
            {
                    var val_4 = 0;
                val_4 = val_4 + 63;
                var val_5 = val_1[0x0] + 32;
                var val_2 = val_4 & 63;
                val_2 = 1 << val_2;
                val_5 = val_5 ^ val_2;
                mem2[0] = val_5;
            }
            
                val_6 = val_6 + 1;
                val_2 = val_5 ^ 113;
                var val_3 = ((1 & 128) != 0) ? (val_5) : (val_2);
            }
            while(val_6 != 7);
            
                val_7 = val_7 + 1;
            }
            while(val_7 != 24);
            
            return (System.UInt64[])val_1;
        }
        private static int[] KeccakInitializeRhoOffsets()
        {
            int[] val_1 = new int[25];
            var val_12 = 0;
            var val_11 = 1;
            val_1[0] = 0;
            do
            {
                var val_3 = X9 >> 63;
                val_3 = (X9 >> 33) + val_3;
                var val_5 = X10 >> 63;
                val_5 = (X10 >> 33) + val_5;
                val_5 = val_5 + (val_5 << 2);
                val_3 = val_3 + (val_3 << 2);
                var val_7 = val_12 - val_5;
                val_3 = 1 - val_3;
                val_5 = val_7 + (val_7 << 2);
                val_3 = val_5 + val_3;
                var val_8 = val_12 + 0;
                val_1[((long)(int)((((0 - (((X10 >> 33) + (X10 >> 63)) + (((X10 >> 33) + (X10 >> 63))) << 2)) + ((0 - (((X10 >> 33) + (X10 >> 63)) + (((X10 >> 33) + (X10 >> 63))) << 2))) << 2) + (1 - (((X9 >> 33) + (X9 >> 63)) + (((X9 )) << 2] = 1 & 63;
                val_8 = val_8 >> 63;
                val_8 = val_8 + ((val_8 >> 32) >> 1);
                val_11 = val_11 + 1;
                val_8 = val_8 + (val_8 << 2);
                val_12 = (val_8 + 2) - val_8;
            }
            while(val_11 != 25);
            
            return (System.Int32[])val_1;
        }
        private void ClearDataQueueSection(int off, int len)
        {
            int val_1 = len;
            int val_1 = off;
            if(val_1 == 0)
            {
                    return;
            }
            
            do
            {
                val_1 = val_1 - 1;
                val_1 = val_1 + 1;
                this.dataQueue[(long)val_1] = 0;
            }
            while(val_1 != 0);
        
        }
        public KeccakDigest()
        {
        
        }
        public KeccakDigest(int bitLength)
        {
            this.state = new byte[200];
            this.dataQueue = new byte[192];
            this.C = new ulong[5];
            this.tempA = new ulong[25];
            this.chiC = new ulong[5];
            this.Init(bitLength:  bitLength);
        }
        public KeccakDigest(Org.BouncyCastle.Crypto.Digests.KeccakDigest source)
        {
            this.state = new byte[200];
            this.dataQueue = new byte[192];
            this.C = new ulong[5];
            this.tempA = new ulong[25];
            this.chiC = new ulong[5];
            this.CopyIn(source:  source);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.KeccakDigest source)
        {
            if(source == null)
            {
                goto label_0;
            }
            
            if(source.state != null)
            {
                goto label_6;
            }
            
            label_7:
            label_6:
            System.Array.Copy(sourceArray:  source.state, sourceIndex:  0, destinationArray:  this.state, destinationIndex:  0, length:  source.state.Length);
            if(source == null)
            {
                goto label_2;
            }
            
            if(source.dataQueue != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            System.Array.Copy(sourceArray:  source.dataQueue, sourceIndex:  0, destinationArray:  this.dataQueue, destinationIndex:  0, length:  source.dataQueue.Length);
            if(source == null)
            {
                goto label_4;
            }
            
            this.rate = source.rate;
            this.bitsInQueue = source.bitsInQueue;
            this.fixedOutputLength = source.fixedOutputLength;
            this.squeezing = source.squeezing;
            this.bitsAvailableForSqueezing = source.bitsAvailableForSqueezing;
            goto label_5;
            label_0:
            if(11993091 != 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_2:
            if(28563616 != 0)
            {
                goto label_8;
            }
            
            goto label_9;
            label_4:
            this.rate = 64;
            this.bitsInQueue = 0;
            this.fixedOutputLength = 135970152;
            this.squeezing = false;
            this.bitsAvailableForSqueezing = 0;
            label_5:
            this.chunk = Org.BouncyCastle.Utilities.Arrays.Clone(data:  source.chunk);
            this.oneByte = Org.BouncyCastle.Utilities.Arrays.Clone(data:  source.oneByte);
        }
        public virtual string get_AlgorithmName()
        {
            return (string)"Keccak-"("Keccak-") + this.fixedOutputLength;
        }
        public virtual int GetDigestSize()
        {
            int val_3 = this.fixedOutputLength;
            val_3 = (val_3 < 0) ? (val_3 + 7) : (val_3);
            return (int)val_3 >> 3;
        }
        public virtual void Update(byte input)
        {
            this.oneByte[0] = input;
            goto typeof(Org.BouncyCastle.Crypto.Digests.KeccakDigest).__il2cppRuntimeField_278;
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int len)
        {
            goto typeof(Org.BouncyCastle.Crypto.Digests.KeccakDigest).__il2cppRuntimeField_278;
        }
        public virtual int DoFinal(byte[] output, int outOff)
        {
            goto typeof(Org.BouncyCastle.Crypto.Digests.KeccakDigest).__il2cppRuntimeField_208;
        }
        protected virtual int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
        {
            if(partialBits > 0)
            {
                    this.oneByte[0] = partialByte;
            }
        
        }
        public virtual void Reset()
        {
            this.Init(bitLength:  this.fixedOutputLength);
        }
        public virtual int GetByteLength()
        {
            int val_3 = this.rate;
            val_3 = (val_3 < 0) ? (val_3 + 7) : (val_3);
            return (int)val_3 >> 3;
        }
        private void Init(int bitLength)
        {
            var val_2;
            var val_3;
            if(bitLength > 256)
            {
                goto label_1;
            }
            
            if(bitLength == 128)
            {
                goto label_2;
            }
            
            if(bitLength == 224)
            {
                goto label_3;
            }
            
            if(bitLength != 256)
            {
                goto label_8;
            }
            
            val_2 = 1088;
            val_3 = 512;
            goto label_12;
            label_1:
            if(bitLength == 288)
            {
                goto label_6;
            }
            
            if(bitLength == 384)
            {
                goto label_7;
            }
            
            if(bitLength != 512)
            {
                goto label_8;
            }
            
            val_2 = 576;
            val_3 = 1024;
            goto label_12;
            label_2:
            val_2 = 1344;
            val_3 = 256;
            goto label_12;
            label_3:
            val_2 = 1152;
            val_3 = 448;
            goto label_12;
            label_6:
            val_2 = 1024;
            val_3 = 576;
            goto label_12;
            label_7:
            val_2 = 832;
            val_3 = 768;
            label_12:
            this.InitSponge(rate:  64, capacity:  768);
            return;
            label_8:
            System.ArgumentException val_1 = new System.ArgumentException(message:  "must be one of 128, 224, 256, 288, 384, or 512.", paramName:  "bitLength");
        }
        private void InitSponge(int rate, int capacity)
        {
            string val_10;
            if((capacity + rate) != 1600)
            {
                goto label_1;
            }
            
            if(((rate - 1) > 1598) || ((rate & 63) != 0))
            {
                goto label_3;
            }
            
            this.rate = rate;
            this.fixedOutputLength = 0;
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.state, b:  0);
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.dataQueue, b:  0);
            int val_4 = (capacity < 0) ? (capacity + 1) : capacity;
            val_4 = val_4 >> 1;
            this.squeezing = false;
            this.bitsAvailableForSqueezing = 0;
            this.bitsInQueue = 0;
            this.fixedOutputLength = val_4;
            int val_5 = rate >> 3;
            this.chunk = new byte[0];
            this.oneByte = new byte[1];
            return;
            label_1:
            val_10 = "rate + capacity != 1600";
            goto label_4;
            label_3:
            val_10 = "invalid rate value";
            label_4:
            null = new System.InvalidOperationException(message:  val_10);
        }
        private void AbsorbQueue()
        {
            int val_3 = this.rate;
            val_3 = (val_3 < 0) ? (val_3 + 7) : (val_3);
            this.KeccakPermutationAfterXor(state:  this.state, data:  this.dataQueue, dataLengthInBytes:  val_3 >> 3);
            this.bitsInQueue = 0;
        }
        protected virtual void Absorb(byte[] data, int off, long databitlen)
        {
            System.Byte[] val_30;
            int val_31;
            int val_32;
            int val_33;
            var val_34;
            byte val_35;
            System.Byte[] val_36;
            string val_38;
            val_31 = this.bitsInQueue;
            if((val_31 & 7) != 0)
            {
                goto label_1;
            }
            
            if(this.squeezing == true)
            {
                goto label_2;
            }
            
            if(databitlen < 1)
            {
                    return;
            }
            
            goto label_4;
            label_20:
            val_31 = this.bitsInQueue;
            label_4:
            val_32 = this.rate;
            if(val_31 == 0)
            {
                goto label_5;
            }
            
            label_14:
            long val_2 = databitlen - 0;
            int val_4 = val_32 - val_31;
            var val_5 = ((val_31 + val_2) > val_32) ? (val_4) : (val_2);
            val_4 = val_5 + 7;
            var val_7 = (val_5 < 0) ? (val_4) : (val_5);
            var val_9 = val_7 & 4294967288;
            val_30 = val_5 - val_9;
            val_31 = (val_31 < 0) ? (val_31 + 7) : (val_31);
            System.Array.Copy(sourceArray:  data, sourceIndex:  (((0 < 0) ? (0 + 7) : 0) >> 3) + off, destinationArray:  this.dataQueue, destinationIndex:  val_31 >> 3, length:  val_7 >> 3);
            int val_30 = this.bitsInQueue;
            val_33 = val_9 + val_30;
            this.bitsInQueue = val_33;
            if(val_33 == this.rate)
            {
                    val_30 = val_33 + 7;
                this.KeccakPermutationAfterXor(state:  this.state, data:  this.dataQueue, dataLengthInBytes:  ((val_33 < 0) ? (val_30) : (val_33)) >> 3);
                val_33 = 0;
                this.bitsInQueue = 0;
            }
            
            val_34 = 0 + (val_9 << );
            if(val_30 < 1)
            {
                goto label_12;
            }
            
            var val_17 = val_30 & 31;
            val_17 = 1 << val_17;
            var val_19 = (val_34 < 0) ? (val_34 + 7) : (val_34);
            val_19 = val_19 >> 3;
            val_19 = val_19 + off;
            val_17 = val_17 + 255;
            var val_21 = (val_33 < 0) ? (val_33 + 7) : (val_33);
            var val_22 = val_21 >> 3;
            val_35 = val_17 & data[(long)val_19];
            this.dataQueue[(long)(val_21 >> 3) & 536870911] = val_35;
            int val_32 = this.bitsInQueue;
            val_34 = val_34 + (val_30 << );
            val_32 = val_32 + val_30;
            this.bitsInQueue = val_32;
            goto label_12;
            label_5:
            if(((long)val_32 > databitlen) || (0 > (databitlen - (long)val_32)))
            {
                goto label_14;
            }
            
            long val_25 = (databitlen - 0) / (long)val_32;
            if(val_25 >= 1)
            {
                    var val_33 = 0;
                val_35 = off + (((0 < 0) ? (0 + 7) : 0) >> 3);
                do
            {
                val_36 = this.chunk;
                if(this.chunk == null)
            {
                    val_36 = this.chunk;
                if(val_36 == null)
            {
                    val_36 = 0;
            }
            
            }
            
                System.Array.Copy(sourceArray:  data, sourceIndex:  val_35 + (this.chunk.Length * val_33), destinationArray:  val_36, destinationIndex:  0, length:  28563616);
                val_30 = this.chunk;
                this.KeccakPermutationAfterXor(state:  this.state, data:  val_30, dataLengthInBytes:  this.chunk.Length);
                val_33 = val_33 + 1;
            }
            while(val_25 != val_33);
            
                val_32 = this.rate;
            }
            
            val_34 = 0 + (val_25 * (long)val_32);
            label_12:
            if(val_34 < databitlen)
            {
                goto label_20;
            }
            
            return;
            label_1:
            val_38 = "attempt to absorb with odd length queue";
            goto label_21;
            label_2:
            val_38 = "attempt to absorb while squeezing";
            label_21:
            null = new System.InvalidOperationException(message:  val_38);
        }
        private void PadAndSwitchToSqueezingPhase()
        {
            int val_31;
            int val_32;
            int val_33 = this.rate;
            if((this.bitsInQueue + 1) == val_33)
            {
                    var val_3 = (this.bitsInQueue < 0) ? (this.bitsInQueue + 7) : this.bitsInQueue;
                var val_4 = val_3 >> 3;
                int val_30 = this.bitsInQueue;
                var val_6 = (val_30 < 0) ? (val_30 + 7) : (val_30);
                val_6 = val_6 & 24;
                val_30 = val_30 - val_6;
                val_30 = val_30 & 31;
                val_30 = 1 << val_30;
                val_30 = val_30 | (this.dataQueue[(long)(val_3 >> 3) & 536870911]);
                this.dataQueue[(long)(val_3 >> 3) & 536870911] = val_30;
                int val_31 = this.rate;
                val_31 = (val_31 < 0) ? (val_31 + 7) : (val_31);
                this.KeccakPermutationAfterXor(state:  this.state, data:  this.dataQueue, dataLengthInBytes:  val_31 >> 3);
                int val_32 = this.rate;
                this.bitsInQueue = 0;
                val_32 = (val_32 < 0) ? (val_32 + 7) : (val_32);
                val_31 = val_32 >> 3;
                this.ClearDataQueueSection(off:  0, len:  val_31);
            }
            else
            {
                    int val_10 = this.bitsInQueue + 7;
                var val_13 = (val_10 < 0) ? (this.bitsInQueue + 14) : (val_10);
                val_33 = (val_33 < 0) ? (val_33 + 7) : (val_33);
                val_33 = val_33 >> 3;
                val_31 = val_33 - (val_13 >> 3);
                this.ClearDataQueueSection(off:  val_13 >> 3, len:  val_31);
                var val_16 = (this.bitsInQueue < 0) ? (this.bitsInQueue + 7) : this.bitsInQueue;
                if((val_16 >> 3) >= this.dataQueue.Length)
            {
                    val_31 = 0;
            }
            
                int val_35 = this.bitsInQueue;
                var val_19 = (val_35 < 0) ? (val_35 + 7) : (val_35);
                val_19 = val_19 & 24;
                val_35 = val_35 - val_19;
                val_35 = val_35 & 31;
                val_35 = 1 << val_35;
                val_35 = val_35 | (this.dataQueue[(long)(val_16 >> 3) & 536870911]);
                this.dataQueue[(long)(val_16 >> 3) & 536870911] = val_35;
            }
            
            int val_20 = this.rate - 1;
            int val_21 = this.rate + 6;
            var val_22 = (val_20 < 0) ? (val_21) : (val_20);
            val_21 = val_22 >> 3;
            if(val_21 >= this.dataQueue.Length)
            {
                    val_31 = 0;
            }
            
            int val_37 = this.rate;
            int val_23 = val_37 - 1;
            val_37 = val_37 + 6;
            byte val_24 = (val_23 < 0) ? (val_37) : (val_23);
            val_24 = val_24 & 24;
            val_24 = val_23 - val_24;
            val_24 = val_24 & 31;
            val_24 = 1 << val_24;
            val_24 = val_24 | (this.dataQueue[(long)(val_22 >> 3) & 536870911]);
            this.dataQueue[(long)(val_22 >> 3) & 536870911] = val_24;
            int val_38 = this.rate;
            val_38 = (val_38 < 0) ? (val_38 + 7) : (val_38);
            this.KeccakPermutationAfterXor(state:  this.state, data:  this.dataQueue, dataLengthInBytes:  val_38 >> 3);
            int val_39 = this.rate;
            this.bitsInQueue = 0;
            if(val_39 == 1024)
            {
                    System.Array.Copy(sourceArray:  this.state, sourceIndex:  0, destinationArray:  this.dataQueue, destinationIndex:  0, length:  128);
                val_32 = 1024;
            }
            else
            {
                    val_39 = (val_39 < 0) ? (val_39 + 63) : (val_39);
                val_39 = val_39 >> 6;
                System.Array.Copy(sourceArray:  this.state, sourceIndex:  0, destinationArray:  this.dataQueue, destinationIndex:  0, length:  val_39 << 3);
                val_32 = this.rate;
            }
            
            this.bitsAvailableForSqueezing = val_32;
            this.squeezing = true;
        }
        protected virtual void Squeeze(byte[] output, int offset, long outputLength)
        {
            var val_14;
            int val_15;
            if(this.squeezing != true)
            {
                    this.PadAndSwitchToSqueezingPhase();
            }
            
            if((outputLength & 7) == 0)
            {
                    if(outputLength < 1)
            {
                    return;
            }
            
                val_15 = this.bitsAvailableForSqueezing;
                do
            {
                if(val_15 == 0)
            {
                    this.KeccakPermutation(state:  this.state);
                int val_15 = this.rate;
                if(val_15 == 1024)
            {
                    System.Array.Copy(sourceArray:  this.state, sourceIndex:  0, destinationArray:  this.dataQueue, destinationIndex:  0, length:  128);
                val_15 = 1024;
            }
            else
            {
                    val_15 = (val_15 < 0) ? (val_15 + 63) : (val_15);
                val_15 = val_15 >> 6;
                System.Array.Copy(sourceArray:  this.state, sourceIndex:  0, destinationArray:  this.dataQueue, destinationIndex:  0, length:  val_15 << 3);
                val_15 = this.rate;
            }
            
                this.bitsAvailableForSqueezing = val_15;
            }
            
                long val_4 = outputLength - 0;
                var val_5 = (val_4 < (val_15 << )) ? (val_4) : (val_15);
                val_15 = this.rate - val_15;
                val_15 = (val_15 < 0) ? (val_15 + 7) : (val_15);
                var val_10 = (0 < 0) ? (0 + 7) : 0;
                val_10 = val_10 >> 3;
                System.Array.Copy(sourceArray:  this.dataQueue, sourceIndex:  val_15 >> 3, destinationArray:  output, destinationIndex:  val_10 + offset, length:  ((val_5 < 0) ? (val_5 + 7) : (val_5)) >> 3);
                int val_16 = this.bitsAvailableForSqueezing;
                val_14 = 0 + (val_5 << );
                val_16 = val_16 - val_5;
                this.bitsAvailableForSqueezing = val_16;
            }
            while(val_14 < outputLength);
            
                return;
            }
            
            System.InvalidOperationException val_14 = new System.InvalidOperationException(message:  "outputLength not a multiple of 8");
        }
        private static void FromBytesToWords(ulong[] stateAsWords, byte[] state)
        {
            byte val_1;
            var val_5 = 0;
            var val_4 = 0;
            do
            {
                var val_3 = 0;
                val_1 = 0;
                stateAsWords[val_4] = 0;
                var val_2 = val_5;
                do
            {
                if(val_4 >= stateAsWords.Length)
            {
                    val_1 = mem[stateAsWords[0x0] + 32];
                val_1 = stateAsWords[0x0] + 32;
            }
            
                byte val_1 = state[val_2];
                val_2 = val_2 + 1;
                val_1 = val_1 << val_3;
                val_3 = val_3 + 8;
                val_1 = val_1 | val_1;
                mem2[0] = val_1;
            }
            while(val_3 != 64);
            
                val_4 = val_4 + 1;
                val_5 = val_5 + 8;
            }
            while(val_4 != 25);
        
        }
        private static void FromWordsToBytes(byte[] state, ulong[] stateAsWords)
        {
            var val_4 = 0;
            var val_5 = 32;
            do
            {
                var val_2 = 0;
                var val_3 = val_5;
                do
            {
                var val_1 = val_3 - 32;
                val_2 = val_2 + 8;
                state[0] = 0;
                val_3 = val_3 + 1;
            }
            while(val_2 != 64);
            
                val_4 = val_4 + 1;
                val_5 = val_5 + 8;
            }
            while(val_4 != 25);
        
        }
        private void KeccakPermutation(byte[] state)
        {
            int val_4 = state.Length;
            val_4 = (val_4 < 0) ? (val_4 + 7) : (val_4);
            var val_2 = val_4 >> 3;
            ulong[] val_3 = new ulong[0];
            Org.BouncyCastle.Crypto.Digests.KeccakDigest.FromBytesToWords(stateAsWords:  val_3, state:  state);
            this.KeccakPermutationOnWords(state:  val_3);
            Org.BouncyCastle.Crypto.Digests.KeccakDigest.FromWordsToBytes(state:  state, stateAsWords:  val_3);
        }
        private void KeccakPermutationAfterXor(byte[] state, byte[] data, int dataLengthInBytes)
        {
            if(dataLengthInBytes >= 1)
            {
                    var val_2 = 0;
                do
            {
                mem2[0] = 1152921505721910208 ^ 1152921505721910208;
                val_2 = val_2 + 1;
            }
            while(dataLengthInBytes != val_2);
            
            }
            
            this.KeccakPermutation(state:  state);
        }
        private void KeccakPermutationOnWords(ulong[] state)
        {
            var val_1 = 0;
            do
            {
                this.Theta(A:  state);
                this.Rho(A:  state);
                this.Pi(A:  state);
                this.Chi(A:  state);
                Org.BouncyCastle.Crypto.Digests.KeccakDigest.Iota(A:  state, indexRound:  0);
                val_1 = val_1 + 1;
            }
            while(val_1 != 24);
        
        }
        private void Theta(ulong[] A)
        {
            var val_11 = 0;
            do
            {
                var val_10 = 0;
                this.C[val_11] = 0;
                do
            {
                var val_1 = val_11 + val_10;
                val_10 = val_10 + 5;
                mem2[0] = 1152921505846136544 ^ this.C[val_11];
            }
            while(val_10 != 25);
            
                val_11 = val_11 + 1;
            }
            while(val_11 != 5);
            
            do
            {
                var val_3 = 0 + 1;
                ulong val_12 = this.C[(long)(val_3 == 5) ? 0 : (val_3)];
                ulong val_13 = this.C[(long)(val_3 == 5) ? 0 : (val_3)];
                var val_5 = 0 + 4;
                val_5 = val_5 - 0;
                var val_15 = 0;
                do
            {
                var val_7 = 0 + val_15;
                mem2[0] = this.C[(long)val_5] ^ 0 ^ 1152921505846136544;
                val_15 = val_15 + 5;
            }
            while(val_15 != 25);
            
            }
            while(val_3 != 5);
        
        }
        private void Rho(ulong[] A)
        {
            var val_3;
            System.UInt64[] val_4;
            var val_5;
            var val_5 = 32;
            do
            {
                var val_4 = 0;
                do
            {
                val_3 = null;
                val_3 = null;
                var val_1 = 0 + val_4;
                if((Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakRhoOffsets.Length + 0) != 0)
            {
                    val_5 = null;
                val_5 = null;
                var val_2 = (X9 + 0) & 63;
                val_2 = 1152921505846136544 << val_2;
                var val_3 = -(Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakRhoOffsets.Length + 0);
                val_3 = val_3 & 63;
                val_3 = 1152921505846136544 >> val_3;
                val_4 = val_3 ^ val_2;
            }
            
                mem2[0] = val_4;
                val_4 = val_4 + 5;
            }
            while(val_4 != 25);
            
                val_5 = val_5 + 4;
            }
            while(1 != 5);
        
        }
        private void Pi(ulong[] A)
        {
            System.Array.Copy(sourceArray:  A, sourceIndex:  0, destinationArray:  this.tempA, destinationIndex:  0, length:  this.tempA.Length);
            var val_8 = 0;
            var val_9 = 4;
            do
            {
                var val_5 = 0;
                var val_7 = val_9;
                var val_6 = val_8;
                do
            {
                int val_4 = this.tempA.Length;
                var val_1 = val_7 - 4;
                val_4 = val_4 >> 33;
                val_4 = val_4 + (val_4 >> 63);
                val_4 = val_4 + (val_4 << 2);
                val_4 = val_6 - val_4;
                val_4 = val_4 + (val_4 << 2);
                val_4 = val_5 + val_4;
                val_5 = val_5 + 1;
                val_6 = val_6 + 3;
                val_7 = val_7 + 5;
                A[(long)val_4] = this.tempA[0];
            }
            while(val_5 != 5);
            
                val_8 = val_8 + 2;
                val_9 = val_9 + 1;
            }
            while(1 != 5);
        
        }
        private void Chi(ulong[] A)
        {
            int val_4;
            var val_7 = 0;
            do
            {
                val_7 = val_7 + 0;
                do
            {
                val_4 = A.Length;
                if((0 + 0) >= val_4)
            {
                    val_4 = A.Length;
            }
            
                var val_2 = 0 + 1;
                var val_3 = (0 == 4) ? 0 : (val_2);
                val_3 = val_3 + val_7;
                if(val_3 >= val_4)
            {
                    val_4 = A.Length;
            }
            
                var val_10 = 0;
                val_10 = (0 + 2) - val_10;
                val_10 = val_10 + val_7;
                val_10 = A[(long)val_10] & (~A[(long)val_3]);
                var val_14 = 0;
                this.chiC[0] = val_10 ^ 1152921505846136544;
            }
            while(val_2 != 5);
            
                var val_13 = 0;
                do
            {
                var val_6 = val_14 + val_13;
                mem2[0] = this.chiC[val_13];
                val_13 = val_13 + 1;
            }
            while(val_13 != 5);
            
                val_14 = val_14 + 5;
            }
            while(1 != 5);
        
        }
        private static void Iota(ulong[] A, int indexRound)
        {
            var val_2 = null;
            System.UInt64[] val_1 = Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakRoundConstants + (((long)(int)(indexRound)) << 3);
            ulong val_3 = (Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakRoundConstants + ((long)(int)(indexRound)) << 3) + 32;
            val_3 = val_3 ^ A[0];
            A[0] = val_3;
        }
        private void KeccakAbsorb(byte[] byteState, byte[] data, int dataInBytes)
        {
            this.KeccakPermutationAfterXor(state:  byteState, data:  data, dataLengthInBytes:  dataInBytes);
        }
        private void KeccakExtract1024bits(byte[] byteState, byte[] data)
        {
            System.Array.Copy(sourceArray:  byteState, sourceIndex:  0, destinationArray:  data, destinationIndex:  0, length:  128);
        }
        private void KeccakExtract(byte[] byteState, byte[] data, int laneCount)
        {
            System.Array.Copy(sourceArray:  byteState, sourceIndex:  0, destinationArray:  data, destinationIndex:  0, length:  laneCount << 3);
        }
        public virtual Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.KeccakDigest(source:  this);
        }
        public virtual void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            Org.BouncyCastle.Utilities.IMemoable val_3 = other;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this.CopyIn(source:  val_3);
        }
        private static KeccakDigest()
        {
            Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakRoundConstants = Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakInitializeRoundConstants();
            Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakRhoOffsets = Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakInitializeRhoOffsets();
        }
    
    }

}
