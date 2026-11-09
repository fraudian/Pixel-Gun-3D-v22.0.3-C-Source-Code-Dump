using UnityEngine;

namespace Org.BouncyCastle.Crypto.Prng
{
    public class DigestRandomGenerator : IRandomGenerator
    {
        // Fields
        private const long CYCLE_COUNT = 10;
        private long stateCounter;
        private long seedCounter;
        private Org.BouncyCastle.Crypto.IDigest digest;
        private byte[] state;
        private byte[] seed;
        
        // Methods
        public DigestRandomGenerator(Org.BouncyCastle.Crypto.IDigest digest)
        {
            this.digest = digest;
            var val_7 = 0;
            val_7 = val_7 + 1;
            int val_2 = digest.GetDigestSize();
            this.seed = new byte[0];
            this.seedCounter = 1;
            var val_8 = 0;
            val_8 = val_8 + 1;
            int val_5 = digest.GetDigestSize();
            this.state = new byte[0];
            this.stateCounter = 1;
        }
        public void AddSeedMaterial(byte[] inSeed)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            this.DigestUpdate(inSeed:  inSeed);
            this.DigestUpdate(inSeed:  this.seed);
            this.DigestDoFinal(result:  this.seed);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void AddSeedMaterial(long rSeed)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            this.DigestAddCounter(seedVal:  rSeed);
            this.DigestUpdate(inSeed:  this.seed);
            this.DigestDoFinal(result:  this.seed);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void NextBytes(byte[] bytes)
        {
            this.NextBytes(bytes:  bytes, start:  0, len:  bytes.Length);
        }
        public void NextBytes(byte[] bytes, int start, int len)
        {
            var val_5;
            var val_6;
            var val_7;
            int val_6 = start;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            this.GenerateState();
            int val_2 = len + val_6;
            if(val_2 > val_6)
            {
                    val_5 = 0;
                var val_3 = (long)val_6 + 32;
                do
            {
                if(val_5 == this.state.Length)
            {
                    this.GenerateState();
                val_5 = 0;
            }
            
                val_5 = val_5 + 1;
                mem2[0] = this.state[0];
                val_3 = val_3 + 1;
                val_6 = val_6 + 1;
            }
            while((val_3 - 31) < (long)val_2);
            
            }
            
            val_6 = 0;
            val_7 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private void CycleSeed()
        {
            this.DigestUpdate(inSeed:  this.seed);
            this.seedCounter = this.seedCounter + 1;
            this.DigestAddCounter(seedVal:  this.seedCounter);
            this.DigestDoFinal(result:  this.seed);
        }
        private void GenerateState()
        {
            this.stateCounter = this.stateCounter + 1;
            this.DigestAddCounter(seedVal:  this.stateCounter);
            this.DigestUpdate(inSeed:  this.state);
            this.DigestUpdate(inSeed:  this.seed);
            this.DigestDoFinal(result:  this.state);
            if(6 != 0)
            {
                    return;
            }
            
            this.CycleSeed();
        }
        private void DigestAddCounter(long seedVal)
        {
            byte[] val_1 = new byte[8];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(n:  seedVal, bs:  val_1);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.digest != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_6;
            label_1:
            if(this.digest != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            this.digest.BlockUpdate(input:  val_1, inOff:  0, length:  val_1.Length);
        }
        private void DigestUpdate(byte[] inSeed)
        {
            if(inSeed == null)
            {
                goto label_1;
            }
            
            if(this.digest != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto label_6;
            label_1:
            if(this.digest != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            this.digest.BlockUpdate(input:  inSeed, inOff:  0, length:  inSeed.Length);
        }
        private void DigestDoFinal(byte[] result)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            int val_2 = this.digest.DoFinal(output:  result, outOff:  0);
        }
    
    }

}
