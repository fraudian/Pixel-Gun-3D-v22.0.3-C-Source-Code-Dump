using UnityEngine;
internal class 丙丌丘丞丘不丁丏与 : BaseTriggerAlternativeAttack
{
    // Fields
    private float 丄丁三丟丌丆且丙丝;
    private float 丘丅丆业世丂丝丝丐;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 丁不丆且丁丁上丂不;
    
    // Methods
    internal override void 上专丄丑专丑丘业丌()
    {
        var val_4;
        float val_35;
        float val_36;
        System.Collections.Generic.List<RilisoftBot.BaseBot> val_37;
        var val_38;
        var val_39;
        var val_40;
        float val_41;
        float val_42;
        var val_43;
        float val_44;
        val_35 = this.丘丅丆业世丂丝丝丐;
        val_36 = val_35 + UnityEngine.Time.deltaTime;
        this.丘丅丆业世丂丝丝丐 = val_36;
        if(val_36 >= this.丄丁三丟丌丆且丙丝)
        {
            goto label_1;
        }
        
        val_37 = this.丁不丆且丁丁上丂不;
        goto label_33;
        label_1:
        val_38 = null;
        val_38 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.GetEnumerator();
        val_37 = this.丁不丆且丁丁上丂不;
        label_21:
        if((919357312 & 1) == 0)
        {
            goto label_6;
        }
        
        丅丙上七上一丐不下 val_7 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_4.丐丏七丌丕丗业且上().transform);
        if(val_7 == null)
        {
            goto label_21;
        }
        
        UnityEngine.Transform val_8 = val_7.transform;
        UnityEngine.Vector3 val_9 = val_8.position;
        UnityEngine.Vector3 val_11 = val_8.transform.position;
        float val_12 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_12 = val_12 + val_12;
        if(val_12 >= 0)
        {
            goto label_21;
        }
        
        this.丘丅丆业世丂丝丝丐 = 0f;
        this.丁不丆且丁丁上丂不.Add(item:  val_7);
        goto label_21;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_33:
        val_39 = 0;
        val_40 = 0;
        goto label_40;
        label_70:
        RilisoftBot.BaseBot val_13 = this.丁不丆且丁丁上丂不.SyncRoot.Item[0];
        if(val_13 == 0)
        {
                bool val_15 = this.丁不丆且丁丁上丂不.SyncRoot.Remove(item:  val_13);
        }
        else
        {
                UnityEngine.Transform val_16 = val_13.transform;
            UnityEngine.Vector3 val_17 = val_16.position;
            val_41 = val_17.z;
            UnityEngine.Transform val_18 = val_16.transform;
            UnityEngine.Vector3 val_19 = val_18.position;
            val_35 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_41}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            if(val_35 < 0)
        {
                if(val_13 != null)
        {
                val_42 = val_13.health;
        }
        else
        {
                val_42 = 5.605194E-45f;
        }
        
            val_35 = val_13.maxHealth;
            if((val_42 / val_35) < 0)
        {
                RilisoftBot.BotAiController val_23 = val_18.七与世丄丞丒一七三();
            if(val_23.东万三丈万丗专业专 == 0)
        {
                val_40 = 1;
        }
        else
        {
                RilisoftBot.BotAiController val_25 = val_23.东万三丈万丗专业专.七与世丄丞丒一七三();
            if(val_25.东万三丈万丗专业专 != 0)
        {
                RilisoftBot.BotAiController val_27 = val_25.东万三丈万丗专业专.七与世丄丞丒一七三();
            UnityEngine.Vector3 val_29 = val_13.transform.position;
            val_35 = val_29.x;
            val_41 = val_29.z;
            val_36 = val_35;
            val_40 = val_40 + (val_27.东万三丈万丗专业专 & 1);
        }
        
        }
        
        }
        
        }
        
            val_39 = 1;
        }
        
        label_40:
        if(val_39 < this.丁不丆且丁丁上丂不.SyncRoot.Count)
        {
            goto label_70;
        }
        
        if(val_40 < (-1610612736))
        {
                val_43 = this;
            mem[1152921539885954864] = 0;
            val_44 = 0f;
        }
        else
        {
                val_43 = this;
            val_44 = val_35 - UnityEngine.Time.deltaTime;
            mem[1152921539885954864] = val_44;
        }
        
        if(val_44 > 0f)
        {
                return;
        }
        
        if(val_39.与上丂丗万上丄丙丅() == true)
        {
                return;
        }
        
        mem[1152921539885954864] = 0;
        this.丕丙丂丆丒与与东丑();
    }
    public 丙丌丘丞丘不丁丏与()
    {
        this.丄丁三丟丌丆且丙丝 = 5f;
        this.丁不丆且丁丁上丂不 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
    }

}
