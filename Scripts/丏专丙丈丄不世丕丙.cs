using UnityEngine;
private sealed class ConnectScene.丏专丙丈丄不世丕丙
{
    // Fields
    public int 丐丂丛与万丛丞丘万;
    public string 丆丌且丕丏丛丐上不;
    public ConnectScene 丝且与丝丒丟万丁专;
    
    // Methods
    public ConnectScene.丏专丙丈丄不世丕丙()
    {
    
    }
    internal void 丒丏丝上丌丑三上下()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        Progress.丑丅专一业丙丝丄丁 val_16 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        val_16 = val_16.丗丞丝丅丈丑丗丂丌() - this.丐丂丛与万丛丞丘万;
        if((val_16 & 2147483648) == 0)
        {
                丌丝世丞世丛丆丅丟.东丌丟三丞世一一丑(丌丘不丆丈丈世万上:  this.丆丌且丕丏丛丐上不, 丕万不丌世丟三丛丈:  false);
            val_16 = null;
            val_16 = null;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 下下丏一丙不丘丌丞:  val_16, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            if(UnityEngine.Application.platform != 8)
        {
                UnityEngine.PlayerPrefs.Save();
        }
        
            val_17 = null;
            val_17 = null;
            if(coinsPlashka.专丆专上丗万世丒七 != 0)
        {
                val_18 = null;
            val_18 = null;
            coinsPlashka.专丆专上丗万世丒七.enabled = false;
        }
        
            this.丝且与丝丒丟万丁专.connectSceneSelectMap.customBtn.SetActive(value:  true);
            this.丝且与丝丒丟万丁专.connectSceneSelectMap.randomBtn.SetActive(value:  true);
            this.丝且与丝丒丟万丁专.connectSceneMainMenu.goBtn.SetActive(value:  true);
            return;
        }
        
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "Mode opened");
        if(BankController.丑七不且上丗丁一世() == 0)
        {
            goto label_34;
        }
        
        ConnectScene.丒上且丄与丁世丏丝 val_8 = new ConnectScene.丒上且丄与丁世丏丝();
        if(val_8 == null)
        {
            goto label_35;
        }
        
        .东丟且丗且三专丙丁 = this;
        goto label_36;
        label_34:
        UnityEngine.Debug.LogWarning(message:  "BankController.Instance == null");
        return;
        label_35:
        mem[24] = this;
        label_36:
        .丑丘丐丂不丐丒丟且 = 0;
        .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  val_8, method:  System.Void ConnectScene.丒上且丄与丁世丏丝::七丘万丗与丟丈世下(object 专丙丏丄与丛下丛丒, System.EventArgs 丏一丕七丆丘一世丙));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ConnectScene.丒上且丄与丁世丏丝)[1152921525824812832].丑丘丐丂不丐丒丟且);
        this.丝且与丝丒丟万丁专.connectSceneMainMenu.gameObject.transform.root.gameObject.SetActive(value:  false);
        val_19 = null;
        val_19 = null;
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丁丕丈丏且丕丒丞丏:  true, 世丁丙世丄一万丆三:  "");
    }

}
