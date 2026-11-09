using UnityEngine;
internal sealed class GameStageEvent : PGBehaviour
{
    // Fields
    private UILabel eventLabel;
    private bool 丞不不丛丏世丁丞万;
    private float 丁丝丘丌不丁丂丝万;
    private System.Collections.Generic.List<GameStageEvent.业丅丑七与丈且丕丏> 与且与丙与万丂业不;
    
    // Properties
    public bool 丅丗丘且万丈下专丄 { get; set; }
    
    // Methods
    public bool get_WithQuaue()
    {
        return (bool)this.丞不不丛丏世丁丞万;
    }
    public void set_WithQuaue(bool 丙业与丙丗丝不丈东)
    {
        this.丞不不丛丏世丁丞万 = 丙业与丙丗丝不丈东;
    }
    private void Update()
    {
        string val_4;
        float val_6;
        float val_7;
        float val_8;
        float val_9;
        float val_11;
        float val_15;
        if(this.丞不不丛丏世丁丞万 == false)
        {
            goto label_1;
        }
        
        val_15 = this.丁丝丘丌不丁丂丝万;
        if((this.与且与丙与万丂业不.Count < 1) || (val_15 > 0f))
        {
            goto label_4;
        }
        
        this.eventLabel.gameObject.SetActive(value:  true);
        业丅丑七与丈且丕丏 val_3 = this.与且与丙与万丂业不.Item[0];
        this.eventLabel.text = val_4;
        业丅丑七与丈且丕丏 val_5 = this.与且与丙与万丂业不.Item[0];
        val_15 = val_6;
        this.eventLabel.color = new UnityEngine.Color() {r = val_15, g = val_7, b = val_8, a = val_9};
        业丅丑七与丈且丕丏 val_10 = this.与且与丙与万丂业不.Item[0];
        this.丁丝丘丌不丁丂丝万 = val_11;
        this.与且与丙与万丂业不.RemoveAt(index:  0);
        return;
        label_1:
        val_15 = this.丁丝丘丌不丁丂丝万;
        if(val_15 <= 0f)
        {
                return;
        }
        
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = val_15 - val_12;
        this.丁丝丘丌不丁丂丝万 = val_12;
        goto label_16;
        label_4:
        if(val_15 > 0f)
        {
                float val_13 = UnityEngine.Time.deltaTime;
            val_13 = val_15 - val_13;
            this.丁丝丘丌不丁丂丝万 = val_13;
            return;
        }
        
        label_16:
        if(val_12 > 0f)
        {
                return;
        }
        
        this.eventLabel.gameObject.SetActive(value:  false);
    }
    public void Show(string 丕丗丘丑丛与丑业丒, float 丂三丟丂丈丐丆丗丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(this.丞不不丛丏世丁丞万 != false)
        {
                this = this.与且与丙与万丂业不;
            this.Add(item:  new 业丅丑七与丈且丕丏() {丕丗丘丑丛与丑业丒 = 丕丗丘丑丛与丑业丒, 丘东丏丆丑丐与丆丝 = 丂三丟丂丈丐丆丗丟, 丑丞丈丗丄丙丟万丄 = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a}});
            return;
        }
        
        this.eventLabel.gameObject.SetActive(value:  true);
        this.eventLabel.text = 丕丗丘丑丛与丑业丒;
        this.eventLabel.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.丁丝丘丌不丁丂丝万 = 丂三丟丂丈丐丆丗丟;
    }
    public GameStageEvent()
    {
        this.与且与丙与万丂业不 = new System.Collections.Generic.List<业丅丑七与丈且丕丏>();
    }

}
