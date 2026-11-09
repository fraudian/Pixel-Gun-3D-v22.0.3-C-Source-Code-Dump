using UnityEngine;
public class NetworkChunksController : MonoBehaviour
{
    // Fields
    internal static NetworkChunksController 丄丘七三上丕世丞业;
    public int chunksWidth;
    public int chunksHeight;
    public float chunkSizeX;
    public float chunkSizeY;
    private System.Collections.Generic.List<int> 专丞一三丙丈丛且丂;
    
    // Methods
    private void Awake()
    {
        NetworkChunksController.丄丘七三上丕世丞业 = this;
    }
    public int GetChunkByPosition(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_3.x = val_3.x / this.chunkSizeX;
        float val_6 = this.chunkSizeY;
        val_6 = val_3.z / val_6;
        int val_5 = UnityEngine.Mathf.Clamp(value:  (int)val_6, min:  0, max:  this.chunksHeight);
        val_5 = (UnityEngine.Mathf.Clamp(value:  (int)val_3.x, min:  0, max:  this.chunksWidth)) + (this.chunksHeight * val_5);
        return (int)val_5;
    }
    public System.Collections.Generic.List<int> GetNeighbourChunks(int 世世不东丗不业丆业, int 丛不丗三与三丘东丆)
    {
        int val_4 = 世世不东丗不业丆业;
        this.专丞一三丙丈丛且丂.Clear();
        if(val_4 == 1)
        {
                return (System.Collections.Generic.List<System.Int32>)this.专丞一三丙丈丛且丂;
        }
        
        if(1 < 1)
        {
                return (System.Collections.Generic.List<System.Int32>)this.专丞一三丙丈丛且丂;
        }
        
        int val_4 = this.chunksHeight;
        var val_7 = 0;
        int val_1 = val_4 / val_4;
        val_4 = val_4 - (val_1 * val_4);
        val_4 = val_4 - 丛不丗三与三丘东丆;
        val_4 = val_1 - 丛不丗三与三丘东丆;
        do
        {
            var val_6 = val_4;
            var val_5 = 1;
            int val_2 = val_7 + val_4;
            do
        {
            if(((((val_2 & 2147483648) == 0) && ((val_6 & 2147483648) == 0)) && (val_2 < this.chunksWidth)) && (val_6 < this.chunksHeight))
        {
                this.专丞一三丙丈丛且丂.Add(item:  val_2 + (this.chunksHeight * val_6));
        }
        
            val_5 = val_5 - 1;
            val_6 = val_6 + 1;
        }
        while(val_5 != 0);
        
            val_7 = val_7 + 1;
        }
        while(val_7 != 1);
        
        return (System.Collections.Generic.List<System.Int32>)this.专丞一三丙丈丛且丂;
    }
    public bool CheckChunkVisibility(int 万丌丘三丗丑丟丅下, int 与三丁丑上丏东下万, int 丛不丗三与三丘东丆)
    {
        if(万丌丘三丗丑丟丅下 == 1)
        {
                return false;
        }
        
        if(与三丁丑上丏东下万 == 1)
        {
                return false;
        }
        
        int val_11 = this.chunksHeight;
        int val_1 = 万丌丘三丗丑丟丅下 / val_11;
        int val_2 = 与三丁丑上丏东下万 / val_11;
        int val_3 = 万丌丘三丗丑丟丅下 - (val_1 * val_11);
        val_11 = 与三丁丑上丏东下万 - (val_2 * val_11);
        val_11 = val_11 + 丛不丗三与三丘东丆;
        val_2 = val_2 + 丛不丗三与三丘东丆;
        var val_7 = (val_3 <= val_11) ? 1 : 0;
        val_7 = ((val_3 >= (val_11 - 丛不丗三与三丘东丆)) ? 1 : 0) & val_7;
        val_7 = val_7 & ((val_1 >= (val_2 - 丛不丗三与三丘东丆)) ? 1 : 0);
        return (bool)((val_1 <= val_2) ? 1 : 0) & val_7;
    }
    public NetworkChunksController()
    {
        this.chunksWidth = 10;
        this.chunksHeight = 10;
        this.chunkSizeX = 600f;
        this.chunkSizeY = 600f;
        this.专丞一三丙丈丛且丂 = new System.Collections.Generic.List<System.Int32>(capacity:  9);
    }

}
