using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class DesEdeEngine : DesEngine
    {
        // Fields
        private int[] workingKey1;
        private int[] workingKey2;
        private int[] workingKey3;
        private bool forEncryption;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public override void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            System.Int32[] val_16;
            var val_17;
            var val_18;
            if(parameters == null)
            {
                goto label_3;
            }
            
            System.Byte[] val_1 = parameters.GetKey();
            int val_16 = val_1.Length;
            val_16 = val_16 | 8;
            if(val_16 != 24)
            {
                goto label_5;
            }
            
            this.forEncryption = forEncryption;
            byte[] val_3 = new byte[8];
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  0, length:  val_3.Length);
            this.workingKey1 = Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(encrypting:  forEncryption, key:  val_3);
            byte[] val_6 = new byte[8];
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  8, destinationArray:  val_6, destinationIndex:  0, length:  val_6.Length);
            this.workingKey2 = Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(encrypting:  (~forEncryption) & 1, key:  val_6);
            if(val_1.Length == 24)
            {
                    byte[] val_9 = new byte[8];
                System.Array.Copy(sourceArray:  val_1, sourceIndex:  16, destinationArray:  val_9, destinationIndex:  0, length:  val_9.Length);
                System.Int32[] val_11 = Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(encrypting:  forEncryption, key:  val_9);
            }
            else
            {
                    val_16 = this.workingKey1;
            }
            
            this.workingKey3 = val_16;
            return;
            label_3:
            val_17 = 1152921551499254640;
            val_18 = new System.ArgumentException(message:  "invalid parameter passed to DESede init - "("invalid parameter passed to DESede init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
            goto label_17;
            label_5:
            val_17 = 1152921551499254640;
            val_18 = new System.ArgumentException(message:  "key size must be 16 or 24 bytes.");
            label_17:
        }
        public override string get_AlgorithmName()
        {
            return "DESede";
        }
        public override int GetBlockSize()
        {
            return 8;
        }
        public override int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            System.Int32[] val_3;
            if(this.workingKey1 != null)
            {
                    Org.BouncyCastle.Crypto.Check.DataLength(buf:  input, off:  inOff, len:  8, msg:  "input buffer too short");
                Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  8, msg:  "output buffer too short");
                byte[] val_1 = new byte[8];
                if(this.forEncryption != false)
            {
                    Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(wKey:  this.workingKey1, input:  input, inOff:  inOff, outBytes:  val_1, outOff:  0);
                Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(wKey:  this.workingKey2, input:  val_1, inOff:  0, outBytes:  val_1, outOff:  0);
                val_3 = this.workingKey3;
            }
            else
            {
                    Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(wKey:  this.workingKey3, input:  input, inOff:  inOff, outBytes:  val_1, outOff:  0);
                Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(wKey:  this.workingKey2, input:  val_1, inOff:  0, outBytes:  val_1, outOff:  0);
                val_3 = this.workingKey1;
            }
            
                Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(wKey:  val_3, input:  val_1, inOff:  0, outBytes:  output, outOff:  outOff);
                return 8;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "DESede engine not initialised");
        }
        public override void Reset()
        {
        
        }
        public DesEdeEngine()
        {
            this = new System.Object();
        }
    
    }

}
