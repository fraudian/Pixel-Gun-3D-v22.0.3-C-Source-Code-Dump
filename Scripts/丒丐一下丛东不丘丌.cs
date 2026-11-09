using UnityEngine;
internal class 丒丐一下丛东不丘丌 : 业丒与上丄丟与一丘
{
    // Fields
    private UnityEngine.Coroutine 丗丒业东丈丙不丌万;
    
    // Methods
    internal override void 丛丗上丝业下不丈丟(System.Action<bool> 万万丗丛丏丐七丘丏)
    {
        var val_5;
        if((this & 1) != 0)
        {
                return;
        }
        
        if(this.丗丒业东丈丙不丌万 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丗丒业东丈丙不丌万);
        }
        
        CoroutineRunner val_2 = CoroutineRunner.Instance;
        val_5 = val_2;
        this.丗丒业东丈丙不丌万 = val_5.StartCoroutine(routine:  val_2.丐丕与上七七丕业丈(丗丞丒丆丄业丕上丄:  万万丗丛丏丐七丘丏));
    }
    internal override void 丘丙丛东丁与丒七上(System.Action<bool> 万万丗丛丏丐七丘丏)
    {
        goto typeof(丒丐一下丛东不丘丌).__il2cppRuntimeField_168;
    }
    internal override bool 下丏丗与七丑丅与丅()
    {
        string val_11;
        var val_14;
        if(AGSClient.IsServiceReady() != false)
        {
                val_11 = GameCircleSocial.Instance.localUser;
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_11.authenticated != false)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_11 = GameCircleSocial.Instance.localUser.id;
            val_14 = (丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) ^ 1;
            return (bool)val_14 & 1;
        }
        
        }
        
        val_14 = 0;
        return (bool)val_14 & 1;
    }
    internal override string 丘与下下丘丕丆业丒()
    {
        var val_5;
        int val_7;
        val_5 = this;
        if((val_5 & 1) != 0)
        {
                val_5 = GameCircleSocial.Instance.localUser;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = val_5;
            string val_4 = val_7.id;
            return (string)val_7;
        }
        
        val_7 = System.String.alignConst;
        return (string)val_7;
    }
    internal override string 一丅上且丆七业丁且()
    {
        return "amazon";
    }
    private System.Collections.IEnumerator 丐丕与上七七丕业丈(System.Action<bool> 丗丞丒丆丄业丕上丄)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丗丞丒丆丄业丕上丄 = 丗丞丒丆丄业丕上丄;
        return (System.Collections.IEnumerator)new 丒丐一下丛东不丘丌.丄下丕丏丙丝丑丛世();
    }
    public 丒丐一下丛东不丘丌()
    {
    
    }

}
