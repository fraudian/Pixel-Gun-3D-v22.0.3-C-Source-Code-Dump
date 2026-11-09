using UnityEngine;

namespace Org.BouncyCastle.Security
{
    public class SecureRandom : Random
    {
        // Fields
        private static long counter;
        private static readonly Org.BouncyCastle.Security.SecureRandom master;
        protected readonly Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator;
        private static readonly double DoubleScale;
        
        // Properties
        private static Org.BouncyCastle.Security.SecureRandom Master { get; }
        
        // Methods
        private static long NextCounterValue()
        {
            null = null;
            return System.Threading.Interlocked.Increment(location: ref  void* val_1 = Org.BouncyCastle.Security.SecureRandom.__il2cppRuntimeField_static_fields);
        }
        private static Org.BouncyCastle.Security.SecureRandom get_Master()
        {
            null = null;
            return (Org.BouncyCastle.Security.SecureRandom)Org.BouncyCastle.Security.SecureRandom.master;
        }
        private static Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator CreatePrng(string digestName, bool autoSeed)
        {
            var val_7;
            Org.BouncyCastle.Crypto.IDigest val_1 = Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm:  digestName);
            if(val_1 != null)
            {
                    Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator val_2 = null;
                val_7 = val_2;
                val_2 = new Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator(digest:  val_1);
                if(autoSeed == false)
            {
                    return (Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator)val_7;
            }
            
                val_2.AddSeedMaterial(rSeed:  Org.BouncyCastle.Security.SecureRandom.NextCounterValue());
                var val_8 = 0;
                val_8 = val_8 + 1;
            }
            else
            {
                    val_7 = 0;
                return (Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator)val_7;
            }
            
            val_2.AddSeedMaterial(inSeed:  Org.BouncyCastle.Security.SecureRandom.GetNextBytes(secureRandom:  Org.BouncyCastle.Security.SecureRandom.Master, length:  val_1.GetDigestSize()));
            return (Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator)val_7;
        }
        public static byte[] GetNextBytes(Org.BouncyCastle.Security.SecureRandom secureRandom, int length)
        {
            if(secureRandom != null)
            {
                    return (System.Byte[])new byte[0];
            }
            
            return (System.Byte[])new byte[0];
        }
        public static Org.BouncyCastle.Security.SecureRandom GetInstance(string algorithm)
        {
            return Org.BouncyCastle.Security.SecureRandom.GetInstance(algorithm:  algorithm, autoSeed:  true);
        }
        public static Org.BouncyCastle.Security.SecureRandom GetInstance(string algorithm, bool autoSeed)
        {
            var val_12;
            string val_1 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithm);
            if((Org.BouncyCastle.Utilities.Platform.EndsWith(source:  val_1, suffix:  "PRNG")) != false)
            {
                    val_12 = "PRNG";
                if("PRNG" == null)
            {
                    val_12 = "PRNG";
            }
            
                Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator val_8 = Org.BouncyCastle.Security.SecureRandom.CreatePrng(digestName:  val_1.Substring(startIndex:  0, length:  val_1.Length - Length), autoSeed:  autoSeed);
                if(val_8 != null)
            {
                    .generator = val_8;
                return (Org.BouncyCastle.Security.SecureRandom)new Org.BouncyCastle.Security.SecureRandom(Seed:  0);
            }
            
            }
            
            System.ArgumentException val_11 = new System.ArgumentException(message:  "Unrecognised PRNG algorithm: "("Unrecognised PRNG algorithm: ") + algorithm, paramName:  "algorithm");
        }
        public static byte[] GetSeed(int length)
        {
            return Org.BouncyCastle.Security.SecureRandom.GetNextBytes(secureRandom:  Org.BouncyCastle.Security.SecureRandom.Master, length:  length);
        }
        public SecureRandom()
        {
            this.generator = Org.BouncyCastle.Security.SecureRandom.CreatePrng(digestName:  "SHA256", autoSeed:  true);
        }
        public SecureRandom(byte[] seed)
        {
            this.generator = Org.BouncyCastle.Security.SecureRandom.CreatePrng(digestName:  "SHA1", autoSeed:  false);
            goto typeof(Org.BouncyCastle.Security.SecureRandom).__il2cppRuntimeField_1D8;
        }
        public SecureRandom(Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator)
        {
            this.generator = generator;
        }
        public virtual byte[] GenerateSeed(int length)
        {
            return Org.BouncyCastle.Security.SecureRandom.GetNextBytes(secureRandom:  Org.BouncyCastle.Security.SecureRandom.Master, length:  length);
        }
        public virtual void SetSeed(byte[] seed)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.generator.AddSeedMaterial(seed:  seed);
        }
        public virtual void SetSeed(long seed)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.generator.AddSeedMaterial(seed:  seed);
        }
        public override int Next()
        {
            return (int)668828032;
        }
        public override int Next(int maxValue)
        {
            var val_7;
            int val_1 = maxValue - 1;
            if()
            {
                goto label_1;
            }
            
            if((val_1 & maxValue) == 0)
            {
                goto label_2;
            }
            
            do
            {
                Org.BouncyCastle.Security.SecureRandom val_5 = 668945360;
                Org.BouncyCastle.Security.SecureRandom val_3 = val_5 / maxValue;
                val_7 = val_5 - (val_3 * maxValue);
                val_3 = val_1 - val_7;
                val_5 = val_3 + val_5;
            }
            while((val_5 & 2147483648) != 0);
            
            return (int)val_7;
            label_1:
            var val_6 = 3;
            val_6 = val_6 & (~(maxValue >> 31));
            if(val_6 == 0)
            {
                goto label_5;
            }
            
            val_7 = 0;
            return (int)val_7;
            label_2:
            Org.BouncyCastle.Security.SecureRandom val_7 = 668945360;
            val_7 = val_7 * (long)maxValue;
            val_7 = val_7 >> 31;
            return (int)val_7;
            label_5:
            System.ArgumentOutOfRangeException val_4 = new System.ArgumentOutOfRangeException(paramName:  "maxValue", message:  "cannot be negative");
        }
        public override int Next(int minValue, int maxValue)
        {
            int val_3 = maxValue;
            minValue = val_3 - minValue;
            if()
            {
                goto label_1;
            }
            
            if(minValue <= 0)
            {
                goto label_5;
            }
            
            val_3 = this + minValue;
            return (int)val_3;
            label_1:
            if()
            {
                    return (int)val_3;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "maxValue cannot be less than minValue");
        }
        public override void NextBytes(byte[] buf)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.generator.NextBytes(bytes:  buf);
        }
        public virtual void NextBytes(byte[] buf, int off, int len)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.generator.NextBytes(bytes:  buf, start:  off, len:  len);
        }
        public override double NextDouble()
        {
            var val_2 = null;
            double val_2 = Org.BouncyCastle.Security.SecureRandom.DoubleScale;
            val_2 = (System.Convert.ToDouble(value:  this)) / val_2;
            return (double)val_2;
        }
        public virtual int NextInt()
        {
            int val_2;
            byte[] val_1 = new byte[4];
            val_2 = val_1.Length;
            if(val_2 == 0)
            {
                    val_2 = val_1.Length;
            }
            
            byte val_2 = val_1[0];
            if(val_2 <= 1)
            {
                    val_2 = val_1.Length;
            }
            
            byte val_3 = val_1[0];
            if(val_2 <= 2)
            {
                    val_2 = val_1.Length;
            }
            
            byte val_4 = val_1[0];
            return (int)val_1[0];
        }
        public virtual long NextLong()
        {
            return (long)this;
        }
        private static SecureRandom()
        {
            var val_4;
            Org.BouncyCastle.Security.SecureRandom.counter = Org.BouncyCastle.Utilities.Times.NanoTime();
            .generator = new Org.BouncyCastle.Crypto.Prng.CryptoApiRandomGenerator();
            val_4 = null;
            Org.BouncyCastle.Security.SecureRandom.master = new Org.BouncyCastle.Security.SecureRandom(Seed:  0);
            val_4 = null;
            Org.BouncyCastle.Security.SecureRandom.DoubleScale = 1.84467440737096E+19;
        }
    
    }

}
