using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class ChaCha7539Engine : Salsa20Engine
    {
        // Properties
        public override string AlgorithmName { get; }
        protected override int NonceSize { get; }
        
        // Methods
        public ChaCha7539Engine()
        {
        
        }
        public override string get_AlgorithmName()
        {
            return (string)"ChaCha" + true;
        }
        protected override int get_NonceSize()
        {
            return 12;
        }
        protected override void AdvanceCounter()
        {
            bool val_2 = true;
            val_2 = val_2 + 1;
            mem[1152921551497058464] = val_2;
            if(val_2 != 0)
            {
                    return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "attempt to increase counter past 2^32.");
        }
        protected override void ResetCounter()
        {
            mem2[0] = 0;
        }
        protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
        {
            if(keyBytes == null)
            {
                goto label_1;
            }
            
            if(keyBytes.Length != 32)
            {
                goto label_2;
            }
            
            15127.PackTauOrSigma(keyLength:  32, state:  ivBytes, stateOffset:  0);
            Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  keyBytes, bOff:  0, ns:  ivBytes, nOff:  4, count:  8);
            goto label_3;
            label_1:
            this = 1152921551497369560;
            label_3:
            Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  ivBytes, bOff:  0, ns:  null, nOff:  13, count:  3);
            return;
            label_2:
            System.ArgumentException val_2 = new System.ArgumentException(message:  this + " requires 256 bit key");
        }
        protected override void GenerateKeyStream(byte[] output)
        {
            Org.BouncyCastle.Crypto.Engines.ChaChaEngine.ChachaCore(rounds:  -353886912, input:  X8, x:  null);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(ns:  this, bs:  output, off:  0);
        }
    
    }

}
