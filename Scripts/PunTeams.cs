using UnityEngine;
public class PunTeams : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.Dictionary<PunTeams.丅一丏丐丕丕丌丝专, System.Collections.Generic.List<与丅丕丈丘东丝世丟>> PlayersPerTeam;
    public const string TeamPlayerProp = "team";
    
    // Methods
    public void Start()
    {
        var val_21;
        var val_22;
        var val_23;
        var val_26;
        var val_27;
        var val_28;
        System.Collections.Generic.Dictionary<丅一丏丐丕丕丌丝专, System.Collections.Generic.List<与丅丕丈丘东丝世丟>> val_1 = new System.Collections.Generic.Dictionary<丅一丏丐丕丕丌丝专, System.Collections.Generic.List<与丅丕丈丘东丝世丟>>();
        val_21 = 1152921505110786048;
        PunTeams.TeamPlayerProp = val_1;
        System.Collections.IEnumerator val_4 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_22 = 1152921504691564544;
        val_23 = 1152921505110839296;
        label_18:
        var val_23 = 0;
        val_23 = val_23 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        object val_8 = val_4.Current;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_9 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        val_1.set_Item(key:  null, value:  null);
        goto label_18;
        label_11:
        val_26 = 0;
        val_27 = 0;
        val_28 = val_4;
        if(val_28 != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_28.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_28 = ???;
        val_26 = ???;
        val_21 = ???;
        val_22 = ???;
        val_23 = ???;
    }
    public void OnDisable()
    {
        PunTeams.TeamPlayerProp = new System.Collections.Generic.Dictionary<丅一丏丐丕丕丌丝专, System.Collections.Generic.List<与丅丕丈丘东丝世丟>>();
    }
    public void OnJoinedRoom()
    {
        this.UpdateTeams();
    }
    public void OnLeftRoom()
    {
        this.Start();
    }
    public void OnPhotonPlayerPropertiesChanged(object[] 丏丗丐世丕丕丙丝丄)
    {
        this.UpdateTeams();
    }
    public void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 丞七东丕丗业七丒三)
    {
        this.UpdateTeams();
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 丐万丙下丙丘专丈与)
    {
        this.UpdateTeams();
    }
    public void UpdateTeams()
    {
        string val_14;
        var val_15;
        var val_17;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_19:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        object val_7 = val_3.Current;
        PunTeams.TeamPlayerProp.Item[null].Clear();
        goto label_19;
        label_11:
        val_14 = 0;
        val_15 = 0;
        if(val_3 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.Dispose();
        }
        
        val_17 = 0;
        goto label_32;
        label_42:
        与丅丕丈丘东丝世丟 val_17 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
        val_14 = PunTeams.TeamPlayerProp;
        val_14.Item[丄丝丆丅丛丏且不丛.丈下丁丄丆丟丏丁专(专丞上七七且丝七丗:  val_17)].Add(item:  val_17);
        val_17 = 1;
        label_32:
        与丅丕丈丘东丝世丟[] val_13 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_17 < val_13.Length)
        {
            goto label_42;
        }
    
    }
    public PunTeams()
    {
    
    }

}
