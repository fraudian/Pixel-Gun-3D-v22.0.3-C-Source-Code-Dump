using UnityEngine;
private class Asn1Sequence.Asn1SequenceParserImpl : Asn1SequenceParser, IAsn1Convertible
{
    // Fields
    private readonly Org.BouncyCastle.Asn1.Asn1Sequence outer;
    private readonly int max;
    private int index;
    
    // Methods
    public Asn1Sequence.Asn1SequenceParserImpl(Org.BouncyCastle.Asn1.Asn1Sequence outer)
    {
        this.outer = outer;
        this.max = outer;
    }
    public Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
    {
        var val_4;
        if(this.index == this.max)
        {
                val_4 = 0;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_4;
        }
        
        this.index = this.index + 1;
        val_4 = this.outer;
        if(val_4 == null)
        {
                return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_4;
        }
        
        Org.BouncyCastle.Asn1.Asn1SetParser val_3 = val_4.Parser;
        return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_4;
    }
    public Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
    {
        return (Org.BouncyCastle.Asn1.Asn1Object)this.outer;
    }

}
