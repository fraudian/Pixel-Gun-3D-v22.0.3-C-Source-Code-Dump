using UnityEngine;
internal sealed class WeaponCell : PGBehaviour
{
    // Fields
    private UIBasicSprite icon;
    private UILabel nameLabel;
    private int 丆专且丕专丗与一丏;
    private Rilisoft.ItemViewer 丁世丛业丟下丕三丟;
    
    // Properties
    public UIBasicSprite 丛丙丂丝不丏上东不 { get; }
    internal bool 丁万丐专专丝丗丈丌 { get; }
    
    // Methods
    public UIBasicSprite get_Icon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.icon);
        this.icon = val_1;
        return val_1;
    }
    private void Awake()
    {
        Rilisoft.ButtonHandler val_1 = this.GetComponent<Rilisoft.ButtonHandler>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void WeaponCell::丁丒丆丈下上世不丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丁丒丆丈下上世不丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丆专且丕专丗与一丏 == 1)
        {
                return;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.丆专且丕专丗与一丏);
        Rilisoft.ItemViewer val_6 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丕世丝且下且丒业丏().transform, 下丅丙一丂丗丅丝七:  val_2, 与丙丆世丘丑丒丌丄:  val_2.不业丙丒丂丞下丆丙(), 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        this.丁世丛业丟下丕三丟 = val_6;
        val_6.DoNotChangeAmbientColor = true;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  val_6.一万丟且丙丙丙东专());
    }
    private System.Collections.IEnumerator 一万丟且丙丙丙东专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new WeaponCell.丙丗三丐丝丂一丒丌();
    }
    internal void 上东与丛丞下丈专丈(三丅丁丗丗丝丂万且 下丅丙一丂丗丅丝七)
    {
        if(下丅丙一丂丗丅丝七 != null)
        {
                this.丆专且丕专丗与一丏 = 下丅丙一丂丗丅丝七.业东丅东丌上丗丑不();
            UnityEngine.Texture val_3 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  0, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            UIBasicSprite val_4 = this.Icon;
            this.nameLabel.text = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  0);
            this.gameObject.SetActive(value:  true);
            return;
        }
        
        this.且上下丌丗丝业丞丄();
    }
    internal void 上东与丛丞下丈专丈(string 丈丁丄丘丛世七丙丝)
    {
        this.上东与丛丞下丈专丈(下丅丙一丂丗丅丝七:  丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丈丁丄丘丛世七丙丝));
    }
    internal void 丁万丁丙三丞不丅且(PGCompany.世业业丝三丘业三下 丙丗丕丟七丟上丈丌)
    {
        if(丙丗丕丟七丟上丈丌 != null)
        {
                UnityEngine.Texture val_2 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  丙丗丕丟七丟上丈丌.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  188, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            UIBasicSprite val_3 = this.Icon;
            this.nameLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丙丗丕丟七丟上丈丌.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
            this.丆专且丕专丗与一丏 = 丙丗丕丟七丟上丈丌.丙丕丞且丕不丘丙丑().业东丅东丌上丗丑不();
            this.gameObject.SetActive(value:  true);
            return;
        }
        
        this.且上下丌丗丝业丞丄();
    }
    private void 且上下丌丗丝业丞丄()
    {
        UIBasicSprite val_1 = this.Icon;
        this.nameLabel.text = "";
        this.gameObject.SetActive(value:  false);
    }
    private void OnEnable()
    {
        if(this.丁世丛业丟下丕三丟 == 0)
        {
                return;
        }
        
        if(this.丁世丛业丟下丕三丟.gameObject == 0)
        {
                return;
        }
        
        this.丁世丛业丟下丕三丟 = 0;
    }
    internal bool 专丌不丄与丗丞东万()
    {
        if(this.丁世丛业丟下丕三丟 == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_2 = this.丁世丛业丟下丕三丟.gameObject;
        if(val_2 != null)
        {
                return val_2.activeSelf;
        }
        
        return val_2.activeSelf;
    }
    public WeaponCell()
    {
        this.丆专且丕专丗与一丏 = 0;
    }

}
