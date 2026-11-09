using UnityEngine;
private sealed class PersConfigurator.东且丞丗万与丌丞丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PersConfigurator 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PersConfigurator.东且丞丗万与丌丞丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PersConfigurator val_27;
        var val_28;
        var val_29;
        System.Action<System.String> val_30;
        int val_31;
        var val_32;
        var val_33;
        val_27 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_28 = null;
        val_28 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_29 = null;
            val_29 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈 = new System.Action<System.String>(object:  val_27, method:  public System.Void PersConfigurator::UpdateWear(string 丛丂丁丒丟且世上东));
        }
        
        System.Action<System.String> val_3 = null;
        val_30 = val_3;
        val_3 = new System.Action<System.String>(object:  val_27, method:  public System.Void PersConfigurator::UpdateWear(string 丛丂丁丒丟且世上东));
        丛且丗丌丏下七下丈.丑丌下丟且丒三丝丙(丙业与丙丗丝不丈东:  val_3);
        UnityEngine.WaitForEndOfFrame val_4 = null;
        val_27 = val_4;
        val_4 = new UnityEngine.WaitForEndOfFrame();
        val_31 = 1;
        this.丒上七丌业七丟与丐 = val_27;
        this.丗丏丅丕丆世丁专丟 = val_31;
        return (bool)val_31;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27.UpdateWear(丛丂丁丒丟且世上东:  null);
        丆丟七丌丞东丆丕丌.丂下下丒丘丙丘丟一(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  val_27, method:  System.Void PersConfigurator::下丂丂丙丘不东丟丄(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三, string 与丏七丞三与丐丆业)));
        丆丟七丌丞东丆丕丌.丝丏不丝丕丒一三丗(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  val_27, method:  System.Void PersConfigurator::下丂丂丙丘不东丟丄(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三, string 与丏七丞三与丐丆业)));
        丆丟七丌丞东丆丕丌.不丕丘业专丐丙万丑(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  val_27, method:  System.Void PersConfigurator::专丕丒丘业丘专下一(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三)));
        丆丟七丌丞东丆丕丌.丒专丑丅丐丂且丌丐(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  val_27, method:  System.Void PersConfigurator::专丕丒丘业丘专下一(CategoryNames 丁丂专业丁丅丅丈丙, string 丝丂丘丄丅且三丌三)));
        三丐下丁丒丆丘下丄.下丛丌下丈丒丟七七(丙业与丙丗丝不丈东:  new System.Action(object:  val_27, method:  public System.Void PersConfigurator::UpdateWear()));
        三丐下丁丒丆丘下丄.七丏丄丝业丟世业丅(丙业与丙丗丝不丈东:  new System.Action(object:  val_27, method:  public System.Void PersConfigurator::UpdateWear()));
        System.Action<System.Int32, PGCompany.丙丕丑丑丆丂丗丗丟> val_11 = new System.Action<System.Int32, PGCompany.丙丕丑丑丆丂丗丗丟>(object:  val_27, method:  System.Void PersConfigurator::且丟丙且丑三专丌丘(int 丛丆东与丑丞丅丝专, PGCompany.丙丕丑丑丆丂丗丗丟 不丁丌丐业丑丟且不));
        Progress.丌丆丈丛丁不丁万丒.与丐丕上丌丑丁丌上(丙业与丙丗丝不丈东:  val_11);
        val_11 = new System.Action<System.Int32>(object:  val_27, method:  System.Void PersConfigurator::且丄世丒丄且丙丗丝(int 万且万且丑丗且丌丆));
        Progress.丌丆丈丛丁不丁万丒.丒专七与丏丌丌业七(丙业与丙丗丝不丈东:  val_11);
        Progress.丟丕丒丑东丗丑丏丑.丂专丑东丂丏与与丒(丙业与丙丗丝不丈东:  new System.Action<System.String, PGCompany.丟丝世万东万丆丟上>(object:  val_27, method:  System.Void PersConfigurator::丑丐丙上丆丕丗丙丐(string 丅丐丞丞丐丘东丘丘, PGCompany.丟丝世万东万丆丟上 丂丒丘丅专丗丂世丛)));
        Progress.丟丕丒丑东丗丑丏丑.与丐丕上丌丑丁丌上(丙业与丙丗丝不丈东:  new System.Action<System.String, PGCompany.丟丝世万东万丆丟上>(object:  val_27, method:  System.Void PersConfigurator::丑丐丙上丆丕丗丙丐(string 丅丐丞丞丐丘东丘丘, PGCompany.丟丝世万东万丆丟上 丂丒丘丅专丗丂世丛)));
        val_30 = 1152921504615686144;
        Progress.丟丕丒丑东丗丑丏丑.丘丑且下丁丈专丝三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  val_27, method:  System.Void PersConfigurator::上丏上丞丐丕丆三世(string 丅丐丞丞丐丘东丘丘)));
        Progress.丟丕丒丑东丗丑丏丑.丒专七与丏丌丌业七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  val_27, method:  System.Void PersConfigurator::上丏上丞丐丕丆三世(string 丅丐丞丞丐丘东丘丘)));
        PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  val_27, method:  System.Void PersConfigurator::上丛丆丛丐丕一一丏(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丛丆丒业丑丁丄丆丞)));
        PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  val_27, method:  System.Void PersConfigurator::上丛丆丛丐丕一一丏(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丛丆丒业丑丁丄丆丞)));
        val_32 = null;
        val_32 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = UnityEngine.Camera.main;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
                if(MainMenuHeroCamera.丑七不且上丗丁一世() != 0)
        {
                val_33 = null;
            val_33 = null;
            丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三();
        }
        
        }
        
        丛且丗丌丏下七下丈.世丄业三一丞丅丌七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  val_27, method:  System.Void PersConfigurator::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
        丛且丗丌丏下七下丈.丕丞东上丗丄丞东丈(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  val_27, method:  System.Void PersConfigurator::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
        label_2:
        val_31 = 0;
        return (bool)val_31;
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
