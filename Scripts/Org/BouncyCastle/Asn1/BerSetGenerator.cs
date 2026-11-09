using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerSetGenerator : BerGenerator
    {
        // Methods
        public BerSetGenerator(System.IO.Stream outStream)
        {
            val_1 = new System.Object();
            mem[1152921553414392320] = outStream;
            val_1.WriteBerHeader(tag:  49);
        }
        public BerSetGenerator(System.IO.Stream outStream, int tagNo, bool isExplicit)
        {
            val_1 = new System.Object();
            mem[1152921553414512512] = outStream;
            mem[1152921553414512520] = 1;
            mem[1152921553414512521] = isExplicit;
            mem[1152921553414512524] = tagNo;
            val_1.WriteBerHeader(tag:  49);
        }
    
    }

}
