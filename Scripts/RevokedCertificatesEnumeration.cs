using UnityEngine;
private class TbsCertificateList.RevokedCertificatesEnumeration : IEnumerable
{
    // Fields
    private readonly System.Collections.IEnumerable en;
    
    // Methods
    internal TbsCertificateList.RevokedCertificatesEnumeration(System.Collections.IEnumerable en)
    {
        this.en = en;
    }
    public System.Collections.IEnumerator GetEnumerator()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        .e = this.en.GetEnumerator();
        return (System.Collections.IEnumerator)new TbsCertificateList.RevokedCertificatesEnumeration.RevokedCertificatesEnumerator();
    }

}
