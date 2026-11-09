using UnityEngine;
private sealed class HTTPRequest.<>c__DisplayClass237_0
{
    // Fields
    public BestHTTP.Cookies.Cookie customCookie;
    
    // Methods
    public HTTPRequest.<>c__DisplayClass237_0()
    {
    
    }
    internal bool <EnumerateHeaders>b__0(BestHTTP.Cookies.Cookie c)
    {
        string val_1 = c.Name;
        if(val_1 != null)
        {
                return val_1.Equals(value:  this.customCookie.Name);
        }
        
        return val_1.Equals(value:  this.customCookie.Name);
    }

}
