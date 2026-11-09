using UnityEngine;
private sealed class BannerWindowController.专且万丞丂丂丙上丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.AdvertisementController 东不丙业丒与万世七;
    public BannerWindowController 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 不丒三业下丑不丞业;
    private BannerWindowController.专丏丌丏丑东万丝专 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BannerWindowController.专且万丞丂丂丙上丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_15;
        BannerWindowController.专丏丌丏丑东万丝专 val_16;
        丆丝丈丐不专一丟且 val_7 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            this.丄丌丂东丘丗一万且 = new BannerWindowController.专丏丌丏丑东万丝专();
            val_15 = this.东不丙业丒与万世七.AdvertisementTexture;
            if(val_15 == 0)
        {
                return false;
        }
        
            val_16 = this.丄丌丂东丘丗一万且;
            this.丝且与丝丒丟万丁专.advertiseController = this.东不丙业丒与万世七;
            mem2[0] = 0;
            this.丝且与丝丒丟万丁专.丁丅丝丒丂上丘丏丑(丌丅丕一丛丛丄一万:  8, 丛万下上万丙下世丂:  true, 丈世且丞专丑丂丐世:  0, 丟丘丙丄丅万丏与丗:  new System.Action(object:  mem[this.丄丌丂东丘丗一万且], method:  System.Void BannerWindowController.专丏丌丏丑东万丝专::丙丒丄七一专丘世丆()), 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = ???}});
        }
        else
        {
                val_16 = this.丄丌丂东丘丗一万且;
            this.丗丏丅丕丆世丁专丟 = 0;
        }
        
        val_15 = mem[this.丄丌丂东丘丗一万且];
        if((mem[this.丄丌丂东丘丗一万且] + 16) != 0)
        {
                val_15 = this.丝且与丝丒丟万丁专.东一丏七业丙万丞丅;
            if(val_15 == 0)
        {
                return false;
        }
        
            val_15 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if((val_15.不万丝丐丁一丏一丐(上世丏丁世丟世丆业: out  val_7)) == false)
        {
                return false;
        }
        
            this.丝且与丝丒丟万丁专.东一丏七业丙万丞丅.SetEnableExitButton(丑丒业丘丑东丕世丅:  Rilisoft.且且丌与专丐一东一.丑七不且上丗丁一世().专万丗丁丗下不丂丈(七丆丒与丗丌丄且丂:  PGCompany.DataObjects.三丛丂丟与不专丛丏.丟丁丆业丌丈丌丂丄(上世丏丁世丟世丆业:  val_7)).丗丞万业丒上万丑丞());
            val_15 = this.东不丙业丒与万世七.AdvertisementTexture;
            this.丝且与丝丒丟万丁专.东一丏七业丙万丞丅.SetBackgroundImage(东上万丆七丌且丒丈:  val_15);
            return false;
        }
        
        if((this.不丒三业下丑不丞业 & 1) != 0)
        {
                return false;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
