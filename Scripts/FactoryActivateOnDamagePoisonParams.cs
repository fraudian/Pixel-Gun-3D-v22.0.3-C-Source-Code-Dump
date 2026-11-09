using UnityEngine;
internal sealed class FactoryActivateOnDamagePoisonParams : PGBehaviour
{
    // Fields
    private RilisoftBot.BaseBot _baseBot;
    private RilisoftBot.ShockerBotEffect _shockBotEfffect;
    private SettingsPoisonParams _poisonParams;
    
    // Methods
    private void Awake()
    {
        if(this._poisonParams == 0)
        {
                return;
        }
        
        if(this._baseBot != 0)
        {
                this.与一丄丒七下专丞丂();
        }
        
        if(this._shockBotEfffect == 0)
        {
                return;
        }
        
        this.丐丕丗丆不丈丄七丆();
    }
    private void OnDestroy()
    {
        if(this._baseBot != 0)
        {
                this.丂丟丅丒丑七一丕丕();
        }
        
        if(this._shockBotEfffect == 0)
        {
                return;
        }
        
        this.丂丟一丆世丑丂丕下();
    }
    private void 与一丄丒七下专丞丂()
    {
        this._baseBot.add_OnDamageTarget(丙业与丙丗丝不丈东:  new System.Action<丅丙上七上一丐不下>(object:  this, method:  System.Void FactoryActivateOnDamagePoisonParams::丐丘不一专专世丘丂(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)));
    }
    private void 丂丟丅丒丑七一丕丕()
    {
        this._baseBot.remove_OnDamageTarget(丙业与丙丗丝不丈东:  new System.Action<丅丙上七上一丐不下>(object:  this, method:  System.Void FactoryActivateOnDamagePoisonParams::丐丘不一专专世丘丂(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)));
    }
    private void 丐丘不一专专世丘丂(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this._poisonParams.丈丞与与丕丕一丝世(丕不丝丛丌丁万上万:  丂丈丙且丈丗三丆丕, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    private void 丐丕丗丆不丈丄七丆()
    {
        this._shockBotEfffect.丄丟丝丄业丟丂丏丘(丙业与丙丗丝不丈东:  new System.Action<丅丙上七上一丐不下>(object:  this, method:  System.Void FactoryActivateOnDamagePoisonParams::一丘丛丏丙丆东丅丟(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)));
    }
    private void 丂丟一丆世丑丂丕下()
    {
        this._shockBotEfffect.丄丏丑七业丏与且丞(丙业与丙丗丝不丈东:  new System.Action<丅丙上七上一丐不下>(object:  this, method:  System.Void FactoryActivateOnDamagePoisonParams::一丘丛丏丙丆东丅丟(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)));
    }
    private void 一丘丛丏丙丆东丅丟(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this._poisonParams.丈丞与与丕丕一丝世(丕不丝丛丌丁万上万:  丂丈丙且丈丗三丆丕, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public FactoryActivateOnDamagePoisonParams()
    {
    
    }

}
