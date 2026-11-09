using UnityEngine;
internal sealed class SelectClanBuilderUI : PGBehaviour
{
    // Fields
    private BuildLevelUI tankBuildLevel;
    private BuildLevelUI fortBuildLevel;
    private EnergyLevelUI tankBuildEnegrgy;
    private EnergyLevelUI fortBuildEnegrgy;
    private System.IDisposable 东三世丝丒三一丈丛;
    private UILabel tankBuildPower;
    private UILabel fortBuildPower;
    
    // Methods
    private void OnEnable()
    {
        this.东丒不七丝万丌丄三();
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SelectClanBuilderUI::丟三三业丆业丄丞且()), 与且专丈不万东一万:  System.String.Format(format:  "SelectClanBuilderUI_{0}", arg0:  this.gameObject.name));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SelectClanBuilderUI::丞丟业丙与丅丏丞丑()));
    }
    private void 丟三三业丆业丄丞且()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.东三世丝丒三一丈丛.Dispose();
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SelectClanBuilderUI::丞丟业丙与丅丏丞丑()));
    }
    private void 丞丟业丙与丅丏丞丑()
    {
        this.丟三三业丆业丄丞且();
    }
    private void 东丒不七丝万丌丄三()
    {
        int val_18;
        this.tankBuildLevel.丈且东丑丂且万丒丅(丏丛下与丌且丅丐一:  丂丘丗丗与且丌丁丙.丗专丕丌下专东丅丈());
        this.fortBuildLevel.丈且东丑丂且万丒丅(丏丛下与丌且丅丐一:  丂丘丗丗与且丌丁丙.丕上丒丅丝丛丒丐丅());
        丞丂丘丒丟丞丑下丄 val_4 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_4 != null)
        {
                val_18 = val_4.丈专丙与丛下丈丕丒();
        }
        else
        {
                val_18 = 0.丈专丙与丛下丈丕丒();
        }
        
        RootBuildingLevelData val_9 = 丂丘丗丗与且丌丁丙.丗专丕丌下专东丅丈().丞丘丕丈丄丛且丝东();
        this.tankBuildEnegrgy.丈且东丑丂且万丒丅(业万丒七丄丑万不且:  val_18, 丌一七世三丑专丒丆:  val_9.buldEnergy);
        RootBuildingLevelData val_11 = 丂丘丗丗与且丌丁丙.丕上丒丅丝丛丒丐丅().丞丘丕丈丄丛且丝东();
        this.fortBuildEnegrgy.丈且东丑丂且万丒丅(业万丒七丄丑万不且:  val_4.丁世丒丂丁不世丈丒(), 丌一七世三丑专丒丆:  val_11.buldEnergy);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.tankBuildPower, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}: {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8242"), arg1:  val_4.三丒三丕不七丁丅丈()));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.fortBuildPower, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}: {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8241"), arg1:  val_4.上上三七丟丝与丆与()));
    }
    public SelectClanBuilderUI()
    {
    
    }

}
