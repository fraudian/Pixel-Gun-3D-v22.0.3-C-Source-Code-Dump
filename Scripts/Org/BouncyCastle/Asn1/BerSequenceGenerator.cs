using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerSequenceGenerator : BerGenerator
    {
        // Methods
        public BerSequenceGenerator(System.IO.Stream outStream)
        {
            val_1 = new System.Object();
            mem[1152921553412792864] = outStream;
            val_1.WriteBerHeader(tag:  48);
        }
        public BerSequenceGenerator(System.IO.Stream outStream, int tagNo, bool isExplicit)
        {
            val_1 = new System.Object();
            mem[1152921553412913056] = outStream;
            mem[1152921553412913064] = 1;
            mem[1152921553412913065] = isExplicit;
            mem[1152921553412913068] = tagNo;
            val_1.WriteBerHeader(tag:  48);
        }
    
    }

}
