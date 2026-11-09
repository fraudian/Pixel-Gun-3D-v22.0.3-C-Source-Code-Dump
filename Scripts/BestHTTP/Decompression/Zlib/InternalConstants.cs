using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    internal static class InternalConstants
    {
        // Fields
        internal static readonly int MAX_BITS;
        internal static readonly int BL_CODES;
        internal static readonly int D_CODES;
        internal static readonly int LITERALS;
        internal static readonly int LENGTH_CODES;
        internal static readonly int L_CODES;
        internal static readonly int MAX_BL_BITS;
        internal static readonly int REP_3_6;
        internal static readonly int REPZ_3_10;
        internal static readonly int REPZ_11_138;
        
        // Methods
        private static InternalConstants()
        {
            BestHTTP.Decompression.Zlib.InternalConstants.MAX_BITS = 15;
            BestHTTP.Decompression.Zlib.InternalConstants.BL_CODES = 19;
            BestHTTP.Decompression.Zlib.InternalConstants.D_CODES = 30;
            BestHTTP.Decompression.Zlib.InternalConstants.LITERALS = 256;
            BestHTTP.Decompression.Zlib.InternalConstants.LENGTH_CODES = 29;
            BestHTTP.Decompression.Zlib.InternalConstants.L_CODES = 286;
            BestHTTP.Decompression.Zlib.InternalConstants.MAX_BL_BITS = 7;
            BestHTTP.Decompression.Zlib.InternalConstants.REP_3_6 = 16;
            BestHTTP.Decompression.Zlib.InternalConstants.REPZ_3_10 = 17;
            BestHTTP.Decompression.Zlib.InternalConstants.REPZ_11_138 = 18;
        }
    
    }

}
