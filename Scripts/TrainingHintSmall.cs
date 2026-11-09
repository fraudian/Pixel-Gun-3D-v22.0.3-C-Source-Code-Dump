using UnityEngine;
public class TrainingHintSmall : MonoBehaviour
{
    // Fields
    public UILabel hintLabel;
    private string 与世下丟丒丞丁丝东;
    
    // Methods
    public void Show(TrainingHints.SmallHintItem 丙不丈东丒下三丛丁)
    {
        this.gameObject.SetActive(value:  true);
        if(丙不丈东丒下三丛丁 != null)
        {
                this.与世下丟丒丞丁丝东 = 丙不丈东丒下三丛丁.localizationKey;
            this.丆三且丆三不世丈丌();
        }
        else
        {
                this.与世下丟丒丞丁丝东 = 28563616;
            this.丆三且丆三不世丈丌();
        }
        
        if(丙不丈东丒下三丛丁.hintPoint == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = 丙不丈东丒下三丛丁.hintPoint.position;
        this.transform.GetChild(index:  0).position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public void Hide()
    {
        this.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TrainingHintSmall::丆三且丆三不世丈丌()));
    }
    private void OnDisable()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TrainingHintSmall::丆三且丆三不世丈丌()));
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TrainingHintSmall::丆三且丆三不世丈丌()));
    }
    private void 丆三且丆三不世丈丌()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.与世下丟丒丞丁丝东)) != false)
        {
                return;
        }
        
        this.hintLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.与世下丟丒丞丁丝东);
    }
    public TrainingHintSmall()
    {
    
    }

}
