using UnityEngine;
internal sealed class ObjectOnDamagePoisonParams : PGBehaviour
{
    // Fields
    private SettingsPoisonParams _poisonParams;
    
    // Methods
    internal void 丅世丏七丅东丄万一(Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐, float 丞丈专下丈专业三丞, float 丂丐丈丕丞下丁下丘, int 丂上上不一丐业一丕, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, string 丈丁丄丘丛世七丙丝, bool 丌丛丑三丆丘万丘丛)
    {
        SettingsPoisonParams val_5;
        if(this._poisonParams != 0)
        {
            goto label_3;
        }
        
        val_5 = this.gameObject.AddComponent<SettingsPoisonParams>();
        this._poisonParams = val_5;
        if(val_5 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_3:
        val_5 = this._poisonParams;
        if(val_5 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        this._poisonParams.poisonType = 三一丝且丝丛不丄丐;
        this._poisonParams.multiplayerDamage = 丞丈专下丈专业三丞;
        this._poisonParams.poisonTime = 丂丐丈丕丞下丁下丘;
        this._poisonParams.poisonCount = 丂上上不一丐业一丕;
        this._poisonParams.typeDead = 东丏业丞丞业下丄世;
        this._poisonParams.weaponId = 丈丁丄丘丛世七丙丝;
        this._poisonParams.下丅丐一一丌丐丙丒();
        this._poisonParams.isIgnoreIgnoreDamage = 丌丛丑三丆丘万丘丛;
    }
    internal void 丝丙丂丅丘丄丙丂三(丅丙上七上一丐不下 世万丘丟丐上世不上, 丅丙上七上一丐不下 丂丈丙且丈丗三丆丕, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        this._poisonParams.丟丞丝丝东丆七且且(世万丘丟丐上世不上:  世万丘丟丐上世不上);
        this._poisonParams.丈丞与与丕丕一丝世(丕不丝丛丌丁万上万:  丂丈丙且丈丗三丆丕, 专不丑且不丏东丟丅:  专不丑且不丏东丟丅, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
    }
    public ObjectOnDamagePoisonParams()
    {
    
    }

}
