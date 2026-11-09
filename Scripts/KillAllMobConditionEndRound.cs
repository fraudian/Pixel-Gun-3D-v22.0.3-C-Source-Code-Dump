using UnityEngine;
internal sealed class KillAllMobConditionEndRound : BaseConditionEndRound
{
    // Fields
    private int 业丌专丁上丁丛世丗;
    
    // Methods
    internal override void 丅专下万丕丑丆丅丝(object[] 丗专丆万丏万丂丂丆)
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丗专丆万丏万丂丂丆[0]);
        this.业丌专丁上丁丛世丗 = null;
    }
    internal override void 下丌且丈丝丗丛上丌()
    {
        RilisoftBot.BaseBot.丏下丁丒丟丝丂丄丐(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void KillAllMobConditionEndRound::世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
    }
    internal override void 一丗一上丙丅下丑万()
    {
        RilisoftBot.BaseBot.丞七且上丌万下一丞(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void KillAllMobConditionEndRound::世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
    }
    private void OnDestroy()
    {
        RilisoftBot.BaseBot.丞七且上丌万下一丞(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void KillAllMobConditionEndRound::世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
    }
    private void 世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)
    {
        RilisoftBot.BotAiController val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.业丌专丁上丁丛世丗 == 1)
        {
                return;
        }
        
        val_8 = 业丘东且七丕丞东不.下不丌万丙且一万东;
        if(业丘东且七丕丞东不.下不丌万丙且一万东.丞不且丌丆丆万业丘 != this.业丌专丁上丁丛世丗)
        {
                return;
        }
        
        val_9 = 1152921505189646336;
        val_10 = null;
        val_10 = null;
        val_8 = GameController.丆丘丂丈世丏丟丑丏;
        if(val_8 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        val_8 = GameController.丆丘丂丈世丏丟丑丏;
        if(GameController.丆丘丂丈世丏丟丑丏.丞不丄丐丗不上专丞 == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = 0;
        if( != 0)
        {
                val_8 = mem[(OnlineModeController.__il2cppRuntimeField_typeHierarchy + (FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? GameController.onlineMode : 0 + 512];
            val_8 = (OnlineModeController.__il2cppRuntimeField_typeHierarchy + (FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? GameController.onlineMode : 0 + 512;
            if(val_8.万上丌丙丌七丗丞丙() > 0)
        {
                return;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        val_8 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞;
        HashSet.Enumerator<T> val_5 = val_8.GetEnumerator();
        val_9 = 1152921526061845088;
        label_34:
        if(((-1510586040) & 1) == 0)
        {
            goto label_28;
        }
        
        if(0.丐丏七丌丕丗业且上() == 业丘东且七丕丞东不)
        {
            goto label_34;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_28:
        val_15 = public System.Void HashSet.Enumerator<RilisoftBot.BaseBot>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛万丙丏丝丗丛丄丐();
    }
    public KillAllMobConditionEndRound()
    {
        this.业丌专丁上丁丛世丗 = 0;
    }

}
