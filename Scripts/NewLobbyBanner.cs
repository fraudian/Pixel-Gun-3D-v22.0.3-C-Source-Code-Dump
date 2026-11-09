using UnityEngine;
internal sealed class NewLobbyBanner : BannerWindow
{
    // Fields
    protected System.IDisposable 专丏业专不丂一丂丛;
    private System.Collections.Generic.List<UnityEngine.GameObject> slides;
    private System.Collections.Generic.List<SlideDot> dots;
    private UILabel buttonLabel;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丂丙丝世丑丞业三丘;
    private System.Collections.Generic.List<SlideDot> 三七丛下三一下丟丘;
    private UnityEngine.GameObject 丟丄一且丝丅丈世上;
    private SlideDot 丟三丝丟丒丟丄与丆;
    
    // Properties
    internal static bool 下东丘丆丗东丑丗七 { get; }
    
    // Methods
    internal static bool 丞专业丟丂丅七丙丝()
    {
        return (bool)((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  154)) > 0) ? 1 : 0;
    }
    internal static bool 丐丄丞丏丈丆丆丏丁()
    {
        return System.Version.op_Inequality(v1:  业丂丏与世一丏业不.一丒三丝三下丑业下(), v2:  0);
    }
    internal static bool 丕世一与业丅万专丑()
    {
        if(NewLobbyBanner.丐丄丞丏丈丆丆丏丁() == false)
        {
                return false;
        }
        
        if(NewLobbyBanner.丞专业丟丂丅七丙丝() == false)
        {
                return System.Version.op_LessThan(v1:  业丂丏与世一丏业不.一丒三丝三下丑业下(), v2:  new System.Version(major:  21, minor:  6));
        }
        
        return false;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "BannerWindowWithBack_" + this.gameObject.name);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        if(this.专丏业专不丂一丂丛 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.专丏业专不丂一丂丛.Dispose();
    }
    public override void Show()
    {
        this.Show();
        this.丂丙丝世丑丞业三丘 = System.Linq.Enumerable.ToList<UnityEngine.GameObject>(source:  this.slides);
        this.三七丛下三一下丟丘 = System.Linq.Enumerable.ToList<SlideDot>(source:  this.dots);
        if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄业丝丆丗世丈丏丒()) != true)
        {
                bool val_6 = this.丂丙丝世丑丞业三丘.Remove(item:  System.Linq.Enumerable.LastOrDefault<UnityEngine.GameObject>(source:  this.丂丙丝世丑丞业三丘));
            bool val_8 = this.三七丛下三一下丟丘.Remove(item:  System.Linq.Enumerable.LastOrDefault<SlideDot>(source:  this.三七丛下三一下丟丘));
        }
        
        this.丟丄一且丝丅丈世上 = this.丂丙丝世丑丞业三丘.Item[0];
        this.丟三丝丟丒丟丄与丆 = this.三七丛下三一下丟丘.Item[0];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.buttonLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11616"));
        this.下丐业丞丟万一丏丏();
    }
    private void 下丐业丞丟万一丏丏()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<SlideDot>(不丗上三丛丒上东丑:  this.dots, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<SlideDot>(不丗上三丛丒上东丑:  this.三七丛下三一下丟丘, 丏业丟一东丂东丘丛:  true);
        List.Enumerator<T> val_1 = this.dots.GetEnumerator();
        label_6:
        if((901782024 & 1) == 0)
        {
            goto label_4;
        }
        
        0.丐丏七丌丕丗业且上().世不丅东世丌丏丗三(丂丛丑东不丅丈一东:  false);
        goto label_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.slides, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丟丄一且丝丅丈世上, 丏业丟一东丂东丘丛:  true);
        if(this.丟三丝丟丒丟丄与丆 == null)
        {
                return;
        }
        
        this.丟三丝丟丒丟丄与丆.世不丅东世丌丏丗三(丂丛丑东不丅丈一东:  true);
    }
    public void U_Next()
    {
        SlideDot val_10;
        UnityEngine.GameObject val_11;
        UnityEngine.Object val_12;
        int val_10 = this.丂丙丝世丑丞业三丘.IndexOf(item:  this.丟丄一且丝丅丈世上);
        val_10 = val_10 + 1;
        if(val_10 < this.丂丙丝世丑丞业三丘.Count)
        {
                this.丟丄一且丝丅丈世上 = this.丂丙丝世丑丞业三丘.Item[val_10];
            SlideDot val_4 = this.三七丛下三一下丟丘.Item[val_10];
            val_11 = this.丟丄一且丝丅丈世上;
        }
        else
        {
                val_11 = 0;
            val_10 = 0;
            this.丟丄一且丝丅丈世上 = 0;
        }
        
        this.丟三丝丟丒丟丄与丆 = val_10;
        val_12 = System.Linq.Enumerable.LastOrDefault<UnityEngine.GameObject>(source:  this.丂丙丝世丑丞业三丘);
        if(val_11 == val_12)
        {
                val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11617");
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.buttonLabel, 丕丗丘丑丛与丑业丒:  val_12);
        }
        
        if(this.丟丄一且丝丅丈世上 == 0)
        {
                val_12 = 1;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  154, 丙业与丙丗丝不丈东:  1);
            this.HideSelf();
        }
        
        this.下丐业丞丟万一丏丏();
    }
    public NewLobbyBanner()
    {
    
    }

}
