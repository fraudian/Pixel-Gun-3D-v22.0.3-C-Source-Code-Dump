using UnityEngine;
public class NetworkChunkAgent : MonoBehaviour
{
    // Fields
    private int 东与丒上东丒东不丐;
    private System.Collections.Generic.List<byte> 丙丅专世丏丐丑专业;
    private System.Collections.Generic.List<byte> 丞下丆万丞七丁丂七;
    private System.Collections.Generic.List<byte> 三丄丕东丄下丕三丕;
    public System.Action<int> OnChunkChange;
    private bool <丕丞丙丕不世丆专七>k__BackingField;
    
    // Properties
    internal bool 丝丂丕丛下丈丙丞丄 { get; set; }
    
    // Methods
    internal bool 丌丛三丅下一丒丈丘()
    {
        return (bool)this.<丕丞丙丕不世丆专七>k__BackingField;
    }
    internal void 丐丞丛东一丏三丏丘(bool 丙业与丙丗丝不丈东)
    {
        this.<丕丞丙丕不世丆专七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void UpdateByPosition(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        int val_1 = NetworkChunksController.丄丘七三上丕世丞业.GetChunkByPosition(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        if(this.东与丒上东丒东不丐 == val_1)
        {
                return;
        }
        
        this.丈丟下世专世业丑上(丂丞丗万丅三业且丁:  val_1);
    }
    public void UpdateByChunk(int 丂万丁丑东一丌丑丞)
    {
        if(this.东与丒上东丒东不丐 == 丂万丁丑东一丌丑丞)
        {
                return;
        }
        
        this.丈丟下世专世业丑上(丂丞丗万丅三业且丁:  丂万丁丑东一丌丑丞);
    }
    public void ResetChunk()
    {
        if(this.东与丒上东丒东不丐 == 1)
        {
                return;
        }
        
        this.丈丟下世专世业丑上(丂丞丗万丅三业且丁:  0);
    }
    private void 丈丟下世专世业丑上(int 丂丞丗万丅三业且丁)
    {
        var val_20;
        var val_21;
        string val_22;
        var val_23;
        string val_24;
        var val_25;
        System.Byte[] val_26;
        System.Byte[] val_27;
        int val_20 = 丂丞丗万丅三业且丁;
        this.东与丒上东丒东不丐 = val_20;
        this.丞下丆万丞七丁丂七.Clear();
        this.三丄丕东丄下丕三丕.Clear();
        this.丞下丆万丞七丁丂七.AddRange(collection:  this.丙丅专世丏丐丑专业);
        this.丙丅专世丏丐丑专业.Clear();
        System.Collections.Generic.List<System.Int32> val_1 = NetworkChunksController.丄丘七三上丕世丞业.GetNeighbourChunks(世世不东丗不业丆业:  val_20, 丛不丗三与三丘东丆:  1);
        val_20 = 1152921516995557280;
        val_21 = 0;
        goto label_6;
        label_15:
        val_20 = val_1.Item[0] + 1;
        if((this.丞下丆万丞七丁丂七.Contains(item:  val_20)) != false)
        {
                bool val_4 = this.丞下丆万丞七丁丂七.Remove(item:  val_20);
        }
        else
        {
                this.三丄丕东丄下丕三丕.Add(item:  val_20);
        }
        
        this.丙丅专世丏丐丑专业.Add(item:  val_20);
        val_21 = 1;
        label_6:
        if(val_21 < val_1.Count)
        {
            goto label_15;
        }
        
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
            goto label_16;
        }
        
        val_22 = "Subscribed to: ";
        val_20 = 1152921530959992112;
        val_23 = 0;
        goto label_17;
        label_20:
        val_22 = val_22 + this.三丄丕东丄下丕三丕.Item[0].ToString() + " ";
        val_23 = 1;
        label_17:
        if(val_23 < this.三丄丕东丄下丕三丕.Count)
        {
            goto label_20;
        }
        
        val_24 = val_22 + "Unsubscribed from: "("Unsubscribed from: ");
        val_25 = 0;
        goto label_21;
        label_24:
        val_24 = val_24 + this.丞下丆万丞七丁丂七.Item[0].ToString() + " ";
        val_25 = 1;
        label_21:
        if(val_25 < this.丞下丆万丞七丁丂七.Count)
        {
            goto label_24;
        }
        
        UnityEngine.Debug.Log(message:  val_24);
        label_16:
        if(this.丞下丆万丞七丁丂七.Count >= 1)
        {
                val_26 = this.丞下丆万丞七丁丂七.ToArray();
        }
        else
        {
                val_26 = 0;
        }
        
        if(this.三丄丕东丄下丕三丕.Count >= 1)
        {
                val_27 = this.三丄丕东丄下丕三丕.ToArray();
        }
        else
        {
                val_27 = 0;
        }
        
        丅丒丗丑丒丙丛不丆.丞丘万三上丛丅万不(丝上丙丂世丗丏丄丑:  val_26, 丈业世东丘七丆且上:  val_27);
        this.OnChunkChange.Invoke(obj:  val_20);
    }
    private void 业下丈丅丂丁丄世丈()
    {
        System.Byte[] val_3;
        if(this.丙丅专世丏丐丑专业.Count >= 1)
        {
                val_3 = this.丙丅专世丏丐丑专业.ToArray();
        }
        else
        {
                val_3 = 0;
        }
        
        丅丒丗丑丒丙丛不丆.丞丘万三上丛丅万不(丝上丙丂世丗丏丄丑:  val_3, 丈业世东丘七丆且上:  0);
    }
    private void OnDestroy()
    {
        if((this.<丕丞丙丕不世丆专七>k__BackingField) != false)
        {
                return;
        }
        
        this.业下丈丅丂丁丄世丈();
    }
    public NetworkChunkAgent()
    {
        this.东与丒上东丒东不丐 = 0;
        this.丙丅专世丏丐丑专业 = new System.Collections.Generic.List<System.Byte>();
        this.丞下丆万丞七丁丂七 = new System.Collections.Generic.List<System.Byte>();
        this.三丄丕东丄下丕三丕 = new System.Collections.Generic.List<System.Byte>();
    }

}
