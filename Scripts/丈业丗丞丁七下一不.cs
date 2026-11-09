using UnityEngine;
private sealed class 丙丘丄东专东三不丑.丈业丗丞丁七下一不
{
    // Fields
    public Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> 丅丟丛丙下丙丄丒丁;
    public PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万;
    
    // Methods
    public 丙丘丄东专东三不丑.丈业丗丞丁七下一不()
    {
    
    }
    internal void 丁丁丐三丝丛丗丒丞()
    {
        bool val_1 = this.丅丟丛丙下丙丄丒丁.TryProcessEvent(ev:  2);
    }
    internal void 丁丁丆万丙七丝丄丌()
    {
        Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> val_11;
        var val_12;
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 val_2 = this.丅丟丛丙下丙丄丒丁.CurrentState;
            if(val_2 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        }
        
        val_11 = this.丅丟丛丙下丙丄丒丁;
        val_12 = val_11;
        if(PGCompany.Ads.丙丘丄东专东三不丑.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_11 = "[AdvertisingChestWindowController.CreateStateMachine+HandleCloseClicked] Close processed: "("[AdvertisingChestWindowController.CreateStateMachine+HandleCloseClicked] Close processed: ") + val_12.TryProcessEvent(ev:  10).ToString()(val_12.TryProcessEvent(ev:  10).ToString());
        UnityEngine.Debug.Log(message:  val_11);
        return;
        label_4:
        UnityEngine.Debug.Log(message:  "[AdvertisingChestWindowController.CreateStateMachine+HandleCloseClicked] Simulate Earned for Editor in WatchingState");
        val_11 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_10 = val_11.StartCoroutine(routine:  val_2.丛丐丐上丆丂丏丈丛(与且专丈不万东一万:  this.与且专丈不万东一万));
    }
    internal void 世不丄万丑丏丞丈且()
    {
        Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> val_6;
        var val_7;
        val_6 = this.丅丟丛丙下丙丄丒丁;
        val_7 = val_6;
        if(PGCompany.Ads.丙丘丄东专东三不丑.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_6 = "[AdvertisingChestWindowController.CreateStateMachine+HandleViewDisabling] Disable processed: "("[AdvertisingChestWindowController.CreateStateMachine+HandleViewDisabling] Disable processed: ") + val_7.TryProcessEvent(ev:  11).ToString()(val_7.TryProcessEvent(ev:  11).ToString());
        UnityEngine.Debug.Log(message:  val_6);
    }

}
