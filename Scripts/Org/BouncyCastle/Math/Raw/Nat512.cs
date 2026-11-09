using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat512
    {
        // Methods
        public static void Mul(uint[] x, uint[] y, uint[] zz)
        {
            Org.BouncyCastle.Math.Raw.Nat256.Mul(x:  x, y:  y, zz:  zz);
            Org.BouncyCastle.Math.Raw.Nat256.Mul(x:  x, xOff:  8, y:  y, yOff:  8, zz:  zz, zzOff:  16);
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat256.AddToEachOther(u:  zz, uOff:  8, v:  zz, vOff:  16);
            System.UInt32[] val_6 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            System.UInt32[] val_7 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            bool val_14 = Org.BouncyCastle.Math.Raw.Nat256.Diff(x:  x, xOff:  8, y:  x, yOff:  0, z:  val_6, zOff:  0);
            val_14 = val_14 ^ (Org.BouncyCastle.Math.Raw.Nat256.Diff(x:  y, xOff:  8, y:  y, yOff:  0, z:  val_7, zOff:  0));
            System.UInt32[] val_10 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Mul(x:  val_6, y:  val_7, zz:  val_10);
            System.UInt32[] val_15 = val_10;
            if(val_14 != false)
            {
                    uint val_11 = Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  16, x:  val_15, xOff:  0, z:  zz, zOff:  8);
            }
            
            val_15 = ((Org.BouncyCastle.Math.Raw.Nat256.AddTo(x:  zz, xOff:  24, z:  zz, zOff:  16, cIn:  (Org.BouncyCastle.Math.Raw.Nat256.AddTo(x:  zz, xOff:  0, z:  zz, zOff:  8, cIn:  0)) + val_1)) + val_1) + (Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  16, x:  val_15, xOff:  0, z:  zz, zOff:  8));
            uint val_13 = Org.BouncyCastle.Math.Raw.Nat.AddWordAt(len:  32, x:  val_15, z:  zz, zPos:  24);
        }
        public static void Square(uint[] x, uint[] zz)
        {
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, zz:  zz);
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  x, xOff:  8, zz:  zz, zzOff:  16);
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat256.AddToEachOther(u:  zz, uOff:  8, v:  zz, vOff:  16);
            System.UInt32[] val_6 = Org.BouncyCastle.Math.Raw.Nat256.Create();
            bool val_7 = Org.BouncyCastle.Math.Raw.Nat256.Diff(x:  x, xOff:  8, y:  x, yOff:  0, z:  val_6, zOff:  0);
            System.UInt32[] val_8 = Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat256.Square(x:  val_6, zz:  val_8);
            System.UInt32[] val_11 = val_8;
            val_11 = ((Org.BouncyCastle.Math.Raw.Nat256.AddTo(x:  zz, xOff:  24, z:  zz, zOff:  16, cIn:  (Org.BouncyCastle.Math.Raw.Nat256.AddTo(x:  zz, xOff:  0, z:  zz, zOff:  8, cIn:  0)) + val_1)) + val_1) + (Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  16, x:  val_11, xOff:  0, z:  zz, zOff:  8));
            uint val_10 = Org.BouncyCastle.Math.Raw.Nat.AddWordAt(len:  32, x:  val_11, z:  zz, zPos:  24);
        }
        protected Nat512()
        {
        
        }
    
    }

}
