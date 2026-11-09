using UnityEngine;
private class SignerInputBuffer.SigStream : BaseOutputStream
{
    // Fields
    private readonly Org.BouncyCastle.Crypto.ISigner s;
    
    // Methods
    internal SignerInputBuffer.SigStream(Org.BouncyCastle.Crypto.ISigner s)
    {
        this.s = s;
    }
    public override void WriteByte(byte b)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.s.Update(input:  b);
    }
    public override void Write(byte[] buf, int off, int len)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.s.BlockUpdate(input:  buf, inOff:  off, length:  len);
    }

}
