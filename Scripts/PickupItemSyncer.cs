using UnityEngine;
public class PickupItemSyncer : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public bool IsWaitingForPickupInit;
    private const float 专丅丐与丗与丝丙与 = 0.2;
    
    // Methods
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 丐万丙下丙丘专丈与)
    {
        bool val_1 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_1 == false)
        {
                return;
        }
        
        val_1.下丈下丒丝不一丑丛(万丌万丅专丞业丈万:  丐万丙下丙丘专丈与);
    }
    public void OnJoinedRoom()
    {
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Joined Room. isMasterClient: {0} id: {1}", arg0:  丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东(), arg1:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁()));
        bool val_8 = ~丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        val_8 = val_8 & 1;
        this.IsWaitingForPickupInit = val_8;
        与丅丕丈丘东丝世丟[] val_7 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_7.Length < 2)
        {
                return;
        }
        
        this.Invoke(methodName:  "AskForPickupItemSpawnTimes", time:  2f);
    }
    public void AskForPickupItemSpawnTimes()
    {
        var val_10;
        object val_11;
        if(this.IsWaitingForPickupInit == false)
        {
                return;
        }
        
        与丅丕丈丘东丝世丟[] val_1 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_1.Length > 1)
        {
                val_10 = 丅丒丗丑丒丙丛不丆.一丐丒丒一业丁丂丁().丙丛丌上丑丗丌业丌();
            if(val_10 != null)
        {
                if((val_10.Equals(丘丛丏丘丝七世七丅:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) == false)
        {
            goto label_12;
        }
        
        }
        
            val_10 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丙丛丌上丑丗丌业丌();
            if(val_10 != null)
        {
                label_12:
            if((val_10.Equals(丘丛丏丘丝七世七丅:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) == false)
        {
                return;
        }
        
        }
        
            val_11 = "No player left to ask";
        }
        else
        {
                val_11 = "Cant ask anyone else for PickupItem spawn times.";
        }
        
        UnityEngine.Debug.Log(message:  val_11);
        this.IsWaitingForPickupInit = false;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    internal void RequestForPickupTimes(业丘丘丘丁丂丕万东 与上丛丞丑与与丗专)
    {
        this.RequestForPickupItems(与上丛丞丑与与丗专:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 与上丛丞丑与与丗专.丒世丗丐专世丛丞丌, 丄丈丑丐丆丞丘与丗 = 与上丛丞丑与与丗专.丄丈丑丐丆丞丘与丗});
    }
    internal void RequestForPickupItems(业丘丘丘丁丂丕万东 与上丛丞丑与与丗专)
    {
        if(与上丛丞丑与与丗专.不丟丗丏丛丕不丁丌 != null)
        {
                this.下丈下丒丝不一丑丛(万丌万丅专丞业丈万:  与上丛丞丑与与丗专.不丟丗丏丛丕不丁丌);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Unknown player asked for PickupItems");
    }
    private void 下丈下丒丝不一丑丛(与丅丕丈丘东丝世丟 万丌万丅专丞业丈万)
    {
        var val_16;
        PickupItem val_17;
        var val_18;
        if(万丌万丅专丞业丈万 == null)
        {
            goto label_1;
        }
        
        double val_1 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_16 = null;
        val_16 = null;
        int val_2 = PickupItem.DisabledPickupItems.Count;
        PickupItem[] val_3 = new PickupItem[0];
        PickupItem.DisabledPickupItems.CopyTo(array:  val_3);
        System.Collections.Generic.List<System.Single> val_5 = new System.Collections.Generic.List<System.Single>(capacity:  val_3.Length << 1);
        if(val_3.Length < 1)
        {
            goto label_9;
        }
        
        label_41:
        val_17 = val_3[0];
        if(val_17 == null)
        {
            goto label_11;
        }
        
        if(val_3[0x0][0].SecondsBeforeRespawn <= 0f)
        {
            goto label_12;
        }
        
        label_19:
        double val_17 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(val_3[0x0][0].TimeOfRespawn <= (val_1 + 0.200000002980232))
        {
            goto label_15;
        }
        
        object[] val_8 = new object[4];
        int val_9 = val_17.ViewID;
        if(val_8 == null)
        {
            goto label_16;
        }
        
        if(val_9 != 0)
        {
            goto label_17;
        }
        
        goto label_24;
        label_11:
        if((8.96831E-44f) > 0f)
        {
            goto label_19;
        }
        
        label_12:
        val_17 = val_17.ViewID;
        if(val_5 != null)
        {
                val_5.Add(item:  (float)val_17);
        }
        else
        {
                val_5.Add(item:  (float)val_17);
        }
        
        val_18 = public System.Void System.Collections.Generic.List<System.Single>::Add(System.Single item);
        goto label_22;
        label_16:
        if(val_9 == 0)
        {
            goto label_24;
        }
        
        label_17:
        label_24:
        val_8[0] = val_9;
        val_17 = val_3[0x0][0].TimeOfRespawn - val_17;
        val_8[1] = val_3[0x0][0].TimeOfRespawn;
        val_8[2] = val_17;
        val_8[3] = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "{0} respawn: {1} timeUntilRespawn: {2} (now: {3})", args:  val_8));
        val_17 = val_17.ViewID;
        if(val_5 != null)
        {
                val_5.Add(item:  (float)val_17);
        }
        else
        {
                val_5.Add(item:  (float)val_17);
        }
        
        val_18 = public System.Void System.Collections.Generic.List<System.Single>::Add(System.Single item);
        label_22:
        val_5.Add(item:  (float)val_17);
        label_15:
        if((0 + 1) < val_3.Length)
        {
            goto label_41;
        }
        
        label_9:
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Sent count: {0} now: {1}", arg0:  val_5.Count, arg1:  val_1));
        return;
        label_1:
        UnityEngine.Debug.LogWarning(message:  "Cant send PickupItem spawn times to unknown targetPlayer.");
    }
    internal void PickupItemInit(double 不业与丄丅丑丞丈丅, float[] 丛丐丒丌且丄丆专丞)
    {
        object val_7;
        var val_8;
        this.IsWaitingForPickupInit = false;
        val_8 = 0;
        goto label_1;
        label_28:
        float val_8 = 丛丐丒丌且丄丆专丞[1];
        if(val_8 > 0f)
        {
                object[] val_3 = new object[4];
            double val_9 = (double)val_8;
            val_9 = val_9 + 不业与丄丅丑丞丈丅;
            val_3[0] = val_1.viewIdField;
            val_3[1] = val_9;
            val_3[2] = val_8;
            val_3[3] = val_2.SecondsBeforeRespawn;
            val_7 = System.String.Format(format:  "{0} respawn: {1} timeUntilRespawnBasedOnTimeBase:{2} SecondsBeforeRespawn: {3}", args:  val_3);
            UnityEngine.Debug.Log(message:  val_7);
            double val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            val_5 = val_9 - val_5;
        }
        
        PhotonView.Find(世上丕丐丈世上不丏:  (int)丛丐丒丌且丄丆专丞[0]).GetComponent<PickupItem>().丛丆且东万下丅丟丝(且三丄丄丞丟丝丏丞:  0f);
        val_8 = 1;
        label_1:
        if(val_8 < (((丛丐丒丌且丄丆专丞.Length < 0) ? (丛丐丒丌且丄丆专丞.Length + 1) : 丛丐丒丌且丄丆专丞.Length) >> 1))
        {
            goto label_28;
        }
    
    }
    public PickupItemSyncer()
    {
    
    }

}
