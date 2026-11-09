using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class IsoTrailers
    {
        // Fields
        public const int TRAILER_IMPLICIT = 188;
        public const int TRAILER_RIPEMD160 = 12748;
        public const int TRAILER_RIPEMD128 = 13004;
        public const int TRAILER_SHA1 = 13260;
        public const int TRAILER_SHA256 = 13516;
        public const int TRAILER_SHA512 = 13772;
        public const int TRAILER_SHA384 = 14028;
        public const int TRAILER_WHIRLPOOL = 14284;
        public const int TRAILER_SHA224 = 14540;
        public const int TRAILER_SHA512_224 = 14796;
        public const int TRAILER_SHA512_256 = 16588;
        private static readonly System.Collections.IDictionary trailerMap;
        
        // Methods
        private static System.Collections.IDictionary CreateTrailerMap()
        {
            System.Collections.IDictionary val_1 = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_1.Add(key:  "RIPEMD128", value:  13004);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_1.Add(key:  "RIPEMD160", value:  12748);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_1.Add(key:  "SHA-1", value:  13260);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_1.Add(key:  "SHA-224", value:  14540);
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_1.Add(key:  "SHA-256", value:  13516);
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_1.Add(key:  "SHA-384", value:  14028);
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_1.Add(key:  "SHA-512", value:  13772);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_1.Add(key:  "SHA-512/224", value:  14796);
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_1.Add(key:  "SHA-512/256", value:  16588);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_1.Add(key:  "Whirlpool", value:  14284);
            return (System.Collections.IDictionary)Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(d:  val_1);
        }
        public static int GetTrailer(Org.BouncyCastle.Crypto.IDigest digest)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_5 = 0;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_5 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  Org.BouncyCastle.Crypto.Signers.IsoTrailers.trailerMap.Item[digest.AlgorithmName]);
            return (int)null;
        }
        public static bool NoTrailerAvailable(Org.BouncyCastle.Crypto.IDigest digest)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 0;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4 = 4;
            bool val_4 = Org.BouncyCastle.Crypto.Signers.IsoTrailers.trailerMap.Contains(key:  digest.AlgorithmName);
            val_4 = (~val_4) & 1;
            return (bool)val_4;
        }
        public IsoTrailers()
        {
        
        }
        private static IsoTrailers()
        {
            Org.BouncyCastle.Crypto.Signers.IsoTrailers.trailerMap = Org.BouncyCastle.Crypto.Signers.IsoTrailers.CreateTrailerMap();
        }
    
    }

}
