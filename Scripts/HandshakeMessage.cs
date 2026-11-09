using UnityEngine;
internal class TlsProtocol.HandshakeMessage : MemoryStream
{
    // Methods
    internal TlsProtocol.HandshakeMessage(byte handshakeType)
    {
    
    }
    internal TlsProtocol.HandshakeMessage(byte handshakeType, int length)
    {
        int val_1 = length + 4;
        Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  handshakeType, output:  this);
        Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(i:  0, output:  this);
    }
    internal void Write(byte[] data)
    {
        this.Write(buffer:  data, offset:  0, count:  data.Length);
    }
    internal void WriteToRecordStream(Org.BouncyCastle.Crypto.Tls.TlsProtocol protocol)
    {
        long val_2 = this.Length - 4;
        Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint24(i:  val_2);
        this.Position = 1;
        Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(i:  val_2, output:  this);
        System.Byte[] val_3 = this.GetBuffer();
        long val_4 = this.Length;
        Org.BouncyCastle.Utilities.Platform.Dispose(s:  this);
    }

}
