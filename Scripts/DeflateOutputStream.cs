using UnityEngine;
protected class TlsDeflateCompression.DeflateOutputStream : ZOutputStream
{
    // Methods
    public TlsDeflateCompression.DeflateOutputStream(System.IO.Stream output, Org.BouncyCastle.Utilities.Zlib.ZStream z, bool compress)
    {
        mem[1152921547527857368] = compress;
        this.FlushMode = 2;
    }
    public override void Flush()
    {
    
    }

}
