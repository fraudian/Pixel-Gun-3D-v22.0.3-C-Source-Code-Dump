using UnityEngine;
internal class ClanBunnerSceneController : PGBehaviour
{
    // Fields
    internal ClanLogoBunner[] bunners;
    
    // Methods
    private void Start()
    {
        var val_7;
        var val_8;
        val_7 = 1152921525544440992;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0)
        {
            goto label_5;
        }
        
        PGCompany.ClanWarController val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_3.丒世丐七丑丈一丈丞 == null)
        {
            goto label_5;
        }
        
        PGCompany.ClanWarController val_4 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        System.ValueTuple<System.String, UnityEngine.Texture2D> val_5 = val_4.丒世丐七丑丈一丈丞.且丙丙丛丞不丝丆丆();
        val_7 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5.Item2)) == false)
        {
            goto label_10;
        }
        
        label_5:
        this.丙丈万与与不丛七三(丙业与丙丗丝不丈东:  false);
        return;
        label_10:
        val_8 = 0;
        goto label_11;
        label_20:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bunners[0], 丏业丟一东丂东丘丛:  true);
        this.bunners[0].丈且东丑丂且万丒丅(丞七业上丏下三专丌:  new System.ValueTuple<System.String, UnityEngine.Texture2D>() {Item2 = val_5.Item2});
        val_8 = 1;
        label_11:
        if(val_8 < this.bunners.Length)
        {
            goto label_20;
        }
    
    }
    private void 丙丈万与与不丛七三(bool 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.bunners[0], 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        0 = 1;
        label_1:
        if(0 < this.bunners.Length)
        {
            goto label_7;
        }
    
    }
    public ClanBunnerSceneController()
    {
    
    }

}
