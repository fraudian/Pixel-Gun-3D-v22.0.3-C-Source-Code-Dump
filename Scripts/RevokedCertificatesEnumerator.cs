using UnityEngine;
private class TbsCertificateList.RevokedCertificatesEnumeration.RevokedCertificatesEnumerator : IEnumerator
{
    // Fields
    private readonly System.Collections.IEnumerator e;
    
    // Properties
    public object Current { get; }
    
    // Methods
    internal TbsCertificateList.RevokedCertificatesEnumeration.RevokedCertificatesEnumerator(System.Collections.IEnumerator e)
    {
        this.e = e;
    }
    public bool MoveNext()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.e.MoveNext();
    }
    public void Reset()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.e.Reset();
    }
    public object get_Current()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        return (object)new Org.BouncyCastle.Asn1.X509.CrlEntry(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  this.e.Current));
    }

}
