using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat384
    {
        // Methods
        public static void Mul(uint[] x, uint[] y, uint[] zz)
        {
            Org.BouncyCastle.Math.Raw.Nat192.Mul(x:  x, y:  y, zz:  zz);
            Org.BouncyCastle.Math.Raw.Nat192.Mul(x:  x, xOff:  6, y:  y, yOff:  6, zz:  zz, zzOff:  12);
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat192.AddToEachOther(u:  zz, uOff:  6, v:  zz, vOff:  12);
            System.UInt32[] val_6 = Org.BouncyCastle.Math.Raw.Nat192.Create();
            System.UInt32[] val_7 = Org.BouncyCastle.Math.Raw.Nat192.Create();
            bool val_14 = Org.BouncyCastle.Math.Raw.Nat192.Diff(x:  x, xOff:  6, y:  x, yOff:  0, z:  val_6, zOff:  0);
            val_14 = val_14 ^ (Org.BouncyCastle.Math.Raw.Nat192.Diff(x:  y, xOff:  6, y:  y, yOff:  0, z:  val_7, zOff:  0));
            System.UInt32[] val_10 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat192.Mul(x:  val_6, y:  val_7, zz:  val_10);
            System.UInt32[] val_15 = val_10;
            if(val_14 != false)
            {
                    uint val_11 = Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  12, x:  val_15, xOff:  0, z:  zz, zOff:  6);
            }
            
            val_15 = ((Org.BouncyCastle.Math.Raw.Nat192.AddTo(x:  zz, xOff:  18, z:  zz, zOff:  12, cIn:  (Org.BouncyCastle.Math.Raw.Nat192.AddTo(x:  zz, xOff:  0, z:  zz, zOff:  6, cIn:  0)) + val_1)) + val_1) + (Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  12, x:  val_15, xOff:  0, z:  zz, zOff:  6));
            uint val_13 = Org.BouncyCastle.Math.Raw.Nat.AddWordAt(len:  24, x:  val_15, z:  zz, zPos:  18);
        }
        public static void Square(uint[] x, uint[] zz)
        {
            Org.BouncyCastle.Math.Raw.Nat192.Square(x:  x, zz:  zz);
            Org.BouncyCastle.Math.Raw.Nat192.Square(x:  x, xOff:  6, zz:  zz, zzOff:  12);
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat192.AddToEachOther(u:  zz, uOff:  6, v:  zz, vOff:  12);
            System.UInt32[] val_6 = Org.BouncyCastle.Math.Raw.Nat192.Create();
            bool val_7 = Org.BouncyCastle.Math.Raw.Nat192.Diff(x:  x, xOff:  6, y:  x, yOff:  0, z:  val_6, zOff:  0);
            System.UInt32[] val_8 = Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
            Org.BouncyCastle.Math.Raw.Nat192.Square(x:  val_6, zz:  val_8);
            System.UInt32[] val_11 = val_8;
            val_11 = ((Org.BouncyCastle.Math.Raw.Nat192.AddTo(x:  zz, xOff:  18, z:  zz, zOff:  12, cIn:  (Org.BouncyCastle.Math.Raw.Nat192.AddTo(x:  zz, xOff:  0, z:  zz, zOff:  6, cIn:  0)) + val_1)) + val_1) + (Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  12, x:  val_11, xOff:  0, z:  zz, zOff:  6));
            uint val_10 = Org.BouncyCastle.Math.Raw.Nat.AddWordAt(len:  24, x:  val_11, z:  zz, zPos:  18);
        }
        protected Nat384()
        {
        
        }
    
    }

}
