using UnityEngine;
internal class ClanWarUIBottomButtons : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject soloActive;
    private UnityEngine.GameObject soloInactive;
    private UnityEngine.GameObject soloOnlyActive;
    private UnityEngine.GameObject soloOnlyInactive;
    private UnityEngine.GameObject sqaudActive;
    private UnityEngine.GameObject sqaudInactive;
    private UnityEngine.GameObject sqaudOnlyActive;
    private UnityEngine.GameObject sqaudOnlyInactive;
    private UnityEngine.GameObject sqaudForFort;
    private UnityEngine.GameObject siegeFight;
    private UnityEngine.GameObject toAppStore;
    private UnityEngine.GameObject toArmory;
    private UnityEngine.GameObject toChest;
    private UnityEngine.GameObject toBattleBass;
    private UnityEngine.GameObject toAlmanah;
    private UnityEngine.GameObject toClans;
    
    // Methods
    internal void 丅万不丆一七丐丝专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.soloActive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.soloInactive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.soloOnlyActive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.soloOnlyInactive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sqaudActive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sqaudInactive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sqaudOnlyActive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sqaudOnlyInactive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sqaudForFort, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.siegeFight, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.toAppStore, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.toArmory, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.toChest, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.toBattleBass, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.toAlmanah, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.toClans, 丏业丟一东丂东丘丛:  false);
    }
    private bool 丌丙丛万专不丏下不(PGCompany.丒丘且上丟专东不丐 丌下丏丐丕丏不丗一)
    {
        PGCompany.丒丘且上丟专东不丐 val_1 = 丌下丏丐丕丏不丗一 - 19;
        if(val_1 > 59)
        {
                return (bool)((丌下丏丐丕丏不丗一 != 29) ? 1 : 0) & ((丌下丏丐丕丏不丗一 != 13) ? 1 : 0);
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 1143914309647073281;
        if(val_1 == 0)
        {
                return (bool)((丌下丏丐丕丏不丗一 != 29) ? 1 : 0) & ((丌下丏丐丕丏不丗一 != 13) ? 1 : 0);
        }
        
        return false;
    }
    internal void 丈且东丑丂且万丒丅(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        var val_39;
        var val_40;
        var val_41;
        UnityEngine.GameObject val_42;
        var val_43;
        var val_44;
        this.丅万不丆一七丐丝专();
        PGCompany.丝丂丒专丞与丙丏一 val_1 = 丌丝万上丅丒一丈丘.丗丐东丑丕丞丅丞东();
        if(val_1 == 3)
        {
            goto label_2;
        }
        
        if(val_1 == 2)
        {
            goto label_3;
        }
        
        if(val_1 != 1)
        {
                return;
        }
        
        if(丌丝万上丅丒一丈丘 == null)
        {
            goto label_5;
        }
        
        val_40 = 丌丝万上丅丒一丈丘.业丝丙下七下七下专();
        goto label_6;
        label_2:
        if(丌丝万上丅丒一丈丘.丛丆东上上丗丗业丕() != PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂())
        {
                return;
        }
        
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝丌丄丘丞东丕世且(且下丕七丙丗丄不七:  1)) == false)
        {
                return;
        }
        
        val_41 = 1152921505284374528;
        val_42 = this.siegeFight;
        goto label_80;
        label_3:
        val_39 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.一丏不三且丆专东东>(且下丕七丙丗丄不七:  2);
        if(val_39 == null)
        {
                return;
        }
        
        if(丌丝万上丅丒一丈丘.丛丆东上上丗丗业丕() != val_39.专东丏与万下丑丂丅())
        {
                return;
        }
        
        val_41 = 1152921505284374528;
        val_42 = this.sqaudForFort;
        goto label_80;
        label_5:
        val_40 = 0.业丝丙下七下七下专();
        label_6:
        PGCompany.世丐下丕专东丘丏且 val_12 = 0.下三下东业丘且丟业();
        if(val_40 == null)
        {
            goto label_19;
        }
        
        val_39 = val_12.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        PGCompany.丒丘且上丟专东不丐 val_39 = val_14.Type;
        if(val_39 <= 29)
        {
            goto label_23;
        }
        
        if(val_39 == 49)
        {
            goto label_24;
        }
        
        if(val_39 == 51)
        {
                return;
        }
        
        val_39 = val_39 - 72;
        if(val_39 <= 6)
        {
                return;
        }
        
        goto label_46;
        label_19:
        if(val_12 == null)
        {
            goto label_31;
        }
        
        val_43 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业();
        if(val_43.七一丈丁专丞丛丟丌() == false)
        {
            goto label_31;
        }
        
        val_44 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        PGCompany.丒丘且上丟专东不丐 val_20 = val_19.Type - 19;
        if(val_20 <= 59)
        {
                val_20 = 1 << val_20;
            val_20 = val_20 & 1143914309647074305;
            if(val_20 != 0)
        {
                return;
        }
        
        }
        
        if(val_19.Type == 13)
        {
                return;
        }
        
        val_43 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_23.GameMode != 8)
        {
            goto label_43;
        }
        
        val_41 = 1152921505284374528;
        val_42 = this.soloOnlyInactive;
        goto label_80;
        label_23:
        if(val_39 > 29)
        {
            goto label_46;
        }
        
        val_39 = 1 << val_39;
        val_39 = val_39 & 537403392;
        if(val_39 == 0)
        {
            goto label_46;
        }
        
        return;
        label_31:
        val_41 = 1152921505284374528;
        val_42 = this.toAppStore;
        goto label_80;
        label_46:
        val_43 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_26.GameMode != 8)
        {
            goto label_52;
        }
        
        val_41 = 1152921505284374528;
        val_42 = this.soloOnlyActive;
        goto label_80;
        label_24:
        val_41 = 1152921505284374528;
        val_42 = this.sqaudActive;
        goto label_80;
        label_52:
        val_43 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_29.Type == 28)
        {
            goto label_59;
        }
        
        PGCompany.GameTaskActionSettings val_32 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_32.Type != 36)
        {
            goto label_64;
        }
        
        label_59:
        val_41 = 1152921505284374528;
        val_42 = this.sqaudOnlyActive;
        label_80:
        label_69:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_42, 丏业丟一东丂东丘丛:  true);
        return;
        label_64:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sqaudActive, 丏业丟一东丂东丘丛:  true);
        goto label_69;
        label_43:
        PGCompany.GameTaskActionSettings val_35 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_35.Type == 28)
        {
            goto label_80;
        }
        
        PGCompany.GameTaskActionSettings val_38 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_38.Type != 36)
        {
            goto label_79;
        }
        
        goto label_80;
        label_79:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.soloInactive, 丏业丟一东丂东丘丛:  true);
        goto label_69;
    }
    public ClanWarUIBottomButtons()
    {
    
    }

}
