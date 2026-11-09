using UnityEngine;
public class GameEventLastRewards : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.丛且世丐丆上七业丁>
{
    // Fields
    public UILabel[] chestsCountLabels;
    private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
    
    // Properties
    public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
    
    // Methods
    public Rilisoft.丛且世丐丆上七业丁 get_Context()
    {
        return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
    }
    private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
    {
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
    {
        UILabel val_5;
        var val_6;
        val_5 = this;
        this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
        val_6 = 0;
        goto label_5;
        label_9:
        val_5 = this.chestsCountLabels[0];
        val_5.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3916"), arg0:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丝丁丅丆丌丗丌丛丌().丂且丑丐丁下丅丞上());
        val_6 = 1;
        label_5:
        if(val_6 < this.chestsCountLabels.Length)
        {
            goto label_9;
        }
    
    }
    public GameEventLastRewards()
    {
    
    }

}
