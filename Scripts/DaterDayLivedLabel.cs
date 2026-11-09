using UnityEngine;
public class DaterDayLivedLabel : MonoBehaviour
{
    // Fields
    private UILabel 上丘丞丞丗丈丅丂下;
    
    // Methods
    private void Awake()
    {
        this.上丘丞丞丗丈丅丂下 = this.GetComponent<UILabel>();
    }
    private void 丒丁丅一下丂专万不()
    {
        this.上丘丞丞丗丈丅丂下.text = System.String.Format(format:  "{0}: {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1615"), arg1:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "DaterDayLived", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
    }
    private void OnEnable()
    {
        this.丒丁丅一下丂专万不();
    }
    private void Start()
    {
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void DaterDayLivedLabel::丞丛一丙丂世丈丅丗()));
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void DaterDayLivedLabel::丞丛一丙丂世丈丅丗()));
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.丒丁丅一下丂专万不();
    }
    public DaterDayLivedLabel()
    {
    
    }

}
