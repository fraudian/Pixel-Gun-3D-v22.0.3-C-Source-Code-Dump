using UnityEngine;
internal class RaceLapCounter : MonoBehaviour
{
    // Fields
    public UILabel lapLabel;
    public UnityEngine.GameObject container;
    private System.Text.StringBuilder 专丁下七丞丂丏下丕;
    private int 丙三丌丁丕丘丟丏专;
    
    // Methods
    private void Update()
    {
        var val_7;
        var val_8;
        var val_9;
        RacingCheckpointController val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        if(RacingCheckpointController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(RacingCheckpointController.丄丘七三上丕世丞业.专上丒丏业七丂丆东 >= 1)
        {
                val_9 = null;
            val_9 = null;
            val_10 = RacingCheckpointController.丄丘七三上丕世丞业;
            if(this.丙三丌丁丕丘丟丏专 == RacingCheckpointController.丄丘七三上丕世丞业.专上丒丏业七丂丆东)
        {
                return;
        }
        
            this.专丁下七丞丂丏下丕.Length = 0;
            this.container.SetActive(value:  true);
            val_11 = null;
            val_11 = null;
            System.Text.StringBuilder val_4 = this.专丁下七丞丂丏下丕.Append(value:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7069"), arg0:  RacingCheckpointController.丄丘七三上丕世丞业.专上丒丏业七丂丆东));
            System.Text.StringBuilder val_5 = this.专丁下七丞丂丏下丕.Append(value:  "/");
            System.Text.StringBuilder val_6 = this.专丁下七丞丂丏下丕.Append(value:  RacingCheckpointController.lapCountForWin);
            val_10 = this.专丁下七丞丂丏下丕;
            this.lapLabel.text = val_10;
            this.丙三丌丁丕丘丟丏专 = RacingCheckpointController.丄丘七三上丕世丞业.专上丒丏业七丂丆东;
            return;
        }
        
        this.container.SetActive(value:  false);
    }
    public RaceLapCounter()
    {
        this.专丁下七丞丂丏下丕 = new System.Text.StringBuilder();
    }

}
