using UnityEngine;
public class FrameResizer : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] objects;
    public UISprite frame;
    public UITable table;
    public UnityEngine.Vector2[] frameSize;
    public int ObjectSize;
    public int MinSize;
    private int 丌丌丞万丈不世丁丟;
    
    // Methods
    public void ResizeFrame()
    {
        var val_10;
        int val_11;
        val_10 = 0;
        this.丌丌丞万丈不世丁丟 = 0;
        goto label_1;
        label_7:
        if(this.objects[0].activeSelf != false)
        {
                int val_11 = this.丌丌丞万丈不世丁丟;
            val_11 = val_11 + 1;
            this.丌丌丞万丈不世丁丟 = val_11;
        }
        
        val_10 = 1;
        label_1:
        if(val_10 < this.objects.Length)
        {
            goto label_7;
        }
        
        if((this.丌丌丞万丈不世丁丟 >= 1) && (this.frameSize.Length != 0))
        {
                this.frame.width = UnityEngine.Mathf.RoundToInt(f:  this.frameSize[(long)UnityEngine.Mathf.Min(a:  this.丌丌丞万丈不世丁丟 - 1, b:  this.frameSize.Length)]);
            this.frame.height = UnityEngine.Mathf.RoundToInt(f:  this.frameSize[(long)UnityEngine.Mathf.Min(a:  this.丌丌丞万丈不世丁丟 - 1, b:  this.frameSize.Length)]);
        }
        
        val_11 = this.ObjectSize;
        if(val_11 >= 1)
        {
                this.frame.width = (this.丌丌丞万丈不世丁丟 * val_11) + 20;
        }
        
        if(this.frame.width < this.MinSize)
        {
                val_11 = this.frame;
            val_11.width = this.MinSize;
        }
        
        if(this.table == 0)
        {
                return;
        }
        
        this.table.sorting = 1;
        this.table.repositionNow = true;
    }
    public FrameResizer()
    {
        this.ObjectSize = 0;
    }

}
