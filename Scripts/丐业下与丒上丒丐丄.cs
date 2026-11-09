using UnityEngine;
private sealed class 丝丄三业丙专丛与不.丐业下与丒上丒丐丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 万下丈世丏业丛丕不;
    public string 丗万丟万七专丗下丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丝丄三业丙专丛与不.丐业下与丒上丒丐丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_6;
        int val_7;
        var val_8;
        if(this.丗丏丅丕丆世丁专丟 <= 1)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            string val_1 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            val_6 = val_1;
            if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
            val_8 = null;
            val_8 = null;
            Rilisoft.丝丄三业丙专丛与不.世世丘丝丑万下丛七 = new Rilisoft.丄上且丘丙丙丝丙丅(万下丈世丏业丛丕不:  this.万下丈世丏业丛丕不, 丗万丟万七专丗下丕:  this.丗万丟万七专丗下丕, 丗丆丌丘丄丞丞东丁:  val_6, 丅丂且丆万且丂丝丙:  Rilisoft.丝丄三业丙专丛与不.丆丞丈丐且丌丙丑不);
            PGCompany.万丘业丅丅丏丆东丈.丑七不且上丗丁一世().上丛丌丆丑上七世三();
            val_6 = PGCompany.万丘业丅丅丏丆东丈.丑七不且上丗丁一世();
            val_6.丗专丁三丝且东专且();
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
