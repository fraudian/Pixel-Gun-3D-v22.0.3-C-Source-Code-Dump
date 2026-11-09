using UnityEngine;
public class PromoActionPreview : MonoBehaviour
{
    // Fields
    public UIButton button;
    public UITexture stickerTexture;
    public UnityEngine.GameObject stickersLabel;
    public UISprite currencyImage;
    public string tg;
    public UITexture icon;
    public UILabel topSeller;
    public UILabel newItem;
    public UILabel sale;
    public UILabel coins;
    public UnityEngine.Texture unpressed;
    public UnityEngine.Texture pressed;
    private int <丆上与下丅丆丂且东>k__BackingField;
    
    // Properties
    public int 丒业业丞丄丑与丗丒 { get; set; }
    
    // Methods
    public int get_Discount()
    {
        return (int)this.<丆上与下丅丆丂且东>k__BackingField;
    }
    public void set_Discount(int 丙业与丙丗丝不丈东)
    {
        this.<丆上与下丅丆丂且东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Start()
    {
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PromoActionPreview::丞丛一丙丂世丈丅丗()));
    }
    private void 丘且东丌丑丁不万丝()
    {
        if((this.<丆上与下丅丆丂且东>k__BackingField) < 1)
        {
                return;
        }
        
        if(this.sale == 0)
        {
                return;
        }
        
        this = System.String.Format(format:  "{0}\n{1}%", arg0:  丟丏下丂七三下丗丕.与丛丛上丒丒东丞专(), arg1:  this.<丆上与下丅丆丂且东>k__BackingField);
        this.sale.text = this;
    }
    private void OnEnable()
    {
    
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PromoActionPreview::丞丛一丙丂世丈丅丗()));
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.丘且东丌丑丁不万丝();
    }
    public PromoActionPreview()
    {
    
    }

}
