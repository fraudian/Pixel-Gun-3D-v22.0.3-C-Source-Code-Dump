using UnityEngine;
private sealed class 丅与专与丘丛万丘与.丙世万丂七丑丅三东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 与丗丆丏丙丟与丒业;
    public 丅与专与丘丛万丘与 丝且与丝丒丟万丁专;
    private MainMenuController 七丞丕一丁万丂丄丒;
    private string 丐丅丅丘丁丕专不丙;
    private UnityEngine.GameObject 丑丁丛丏丁丅三丏丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅与专与丘丛万丘与.丙世万丂七丑丅三东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_11;
        int val_12;
        string val_13;
        var val_14;
        MainMenuController val_15;
        var val_16;
        var val_17;
        UnityEngine.GameObject val_18;
        var val_19;
        val_11 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_12 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_12;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_13 = 1152921505080860672;
        val_14 = null;
        val_14 = null;
        val_15 = val_11;
        this.七丞丕一丁万丂丄丒 = MainMenuController.丄丞丁丈与业上丞丟;
        if(MainMenuController.丄丞丁丈与业上丞丟 == null)
        {
            goto label_6;
        }
        
        val_16 = null;
        if(丅与专与丘丛万丘与.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[DeepLinkHandler.WaitThenHandleLaunchUrl] caller: "("[DeepLinkHandler.WaitThenHandleLaunchUrl] caller: ") + this.与丗丆丏丙丟与丒业 + ", startIsDone: "(", startIsDone: ") + this.七丞丕一丁万丂丄丒.丌世世万不上丝丆三().ToString());
        }
        
        string val_6 = this.丝且与丝丒丟万丁专.丗丟万丛丞丝丁不万();
        this.丐丅丅丘丁丕专不丙 = val_6;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true)
        {
            goto label_19;
        }
        
        val_17 = null;
        val_17 = null;
        丅与专与丘丛万丘与.万七一丝不世丒丈丙 = true;
        goto label_19;
        label_1:
        val_18 = this.丑丁丛丏丁丅三丏丈;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_18 != null)
        {
            goto label_21;
        }
        
        val_18 = 0;
        goto label_21;
        label_2:
        val_15 = this.七丞丕一丁万丂丄丒;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_19:
        val_13 = mem[this.七丞丕一丁万丂丄丒];
        if(val_13.丌世世万不上丝丆三() == false)
        {
            goto label_23;
        }
        
        val_13 = mem[this.七丞丕一丁万丂丄丒];
        val_18 = mem[mem[this.七丞丕一丁万丂丄丒] + 304];
        val_18 = mem[this.七丞丕一丁万丂丄丒] + 304;
        this.丑丁丛丏丁丅三丏丈 = val_18;
        if(val_18 == 0)
        {
            goto label_26;
        }
        
        label_21:
        if(val_18.activeInHierarchy != false)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_12 = 1;
            return (bool)val_12;
        }
        
        label_26:
        val_13 = this.与丗丆丏丙丟与丒业;
        this.丝且与丝丒丟万丁专.东丐三丅丅丏万丕三(与丗丆丏丙丟与丒业:  val_13, 七丙不丅丛丘丗万与:  this.丐丅丅丘丁丕专不丙);
        val_11 = 1152921505171169280;
        val_19 = null;
        val_19 = null;
        val_12 = 0;
        丅与专与丘丛万丘与.丅丑东上丐丑世东七 = true;
        return (bool)val_12;
        label_23:
        val_12 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_6:
        val_11 = "[DeepLinkHandler.WaitThenHandleLaunchUrl] caller: "("[DeepLinkHandler.WaitThenHandleLaunchUrl] caller: ") + this.与丗丆丏丙丟与丒业 + ", MainMenuController: null"(", MainMenuController: null");
        UnityEngine.Debug.LogWarning(message:  val_11);
        val_12 = 0;
        return (bool)val_12;
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
