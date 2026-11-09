using UnityEngine;
private sealed class 丗一丄且与一丕丙丝.丟丏业丑且丗丘丅丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.VIP20.丗一丄且与一丕丙丝 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丗一丄且与一丕丙丝.丟丏业丑且丗丘丅丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.VIP20.丗一丄且与一丕丙丝 val_6;
        int val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_6 = this.丝且与丝丒丟万丁专;
            if(PixelTime.丝业丁丌丘东丏世与() != false)
        {
                this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 = 0;
            string val_3 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  113);
            DataSystem.丈且丈上不下且丝丒 val_4 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_6 = 0;
            val_6 = val_6 + 1;
        }
        else
        {
                val_8 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_8;
            return (bool)val_8;
        }
        
            if(val_6 != null)
        {
                this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 = val_4;
        }
        else
        {
                this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 = val_4;
        }
        
            val_6.丁与东三专丗与丁上();
            val_9 = null;
            val_9 = null;
            if(PGCompany.VIP20.丗一丄且与一丕丙丝.与世专丁一丌丛丐专 != null)
        {
                PGCompany.VIP20.丗一丄且与一丕丙丝.与世专丁一丌丛丐专.Invoke();
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
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
