using UnityEngine;
private class DigestInputBuffer.DigStream : BaseOutputStream
{
    // Fields
    private readonly Org.BouncyCastle.Crypto.IDigest d;
    
    // Methods
    internal DigestInputBuffer.DigStream(Org.BouncyCastle.Crypto.IDigest d)
    {
        this.d = d;
    }
    public override void WriteByte(byte b)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.d.Update(input:  b);
    }
    public override void Write(byte[] buf, int off, int len)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.d.BlockUpdate(input:  buf, inOff:  off, length:  len);
    }

}
