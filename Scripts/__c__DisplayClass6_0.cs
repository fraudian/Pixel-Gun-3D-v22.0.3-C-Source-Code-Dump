using UnityEngine;
private sealed class DigestStore.<>c__DisplayClass6_0
{
    // Fields
    public int i;
    
    // Methods
    public DigestStore.<>c__DisplayClass6_0()
    {
    
    }
    internal bool <FindBest>b__0(string header)
    {
        null = null;
        System.String[] val_1 = BestHTTP.Authentication.DigestStore.SupportedAlgorithms + ((this.i) << 3);
        if(header != null)
        {
                return header.StartsWith(value:  (BestHTTP.Authentication.DigestStore.SupportedAlgorithms + (this.i) << 3) + 32);
        }
        
        return header.StartsWith(value:  (BestHTTP.Authentication.DigestStore.SupportedAlgorithms + (this.i) << 3) + 32);
    }

}
