using UnityEngine;
public class 丒且丑丙专丟丗丏业
{
    // Fields
    internal SkinName 丝丘丅与丌丗丅丈下;
    internal Player_move_c 丕丁丘丆万丄世专丛;
    
    // Methods
    internal string 丑丗丗业丈丙丑丂丝(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_2 = 上且丗一丏丏万丅丌 | 8;
        return (string)((上且丗一丏丏万丅丌 & 4294967294) == 20) ? "PlayerBattleRoyale" : "Player";
    }
    internal SkinName 丟丆丗丌下且丅丌丈(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        SkinName val_4;
        SkinName val_3 = UnityEngine.Object.Instantiate<SkinName>(original:  UnityEngine.Resources.Load<SkinName>(path:  this.丑丗丗业丈丙丑丂丝(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌)));
        this.丝丘丅与丌丗丅丈下 = val_3;
        if(val_3 == null)
        {
                val_4 = this.丝丘丅与丌丗丅丈下;
        }
        
        this.丕丁丘丆万丄世专丛 = val_3.playerMoveC;
        return val_4;
    }
    internal SkinName 丝丗丛丆下丟丑丟丆(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
        SkinName val_4;
        SkinName val_3 = 丅丒丗丑丒丙丛不丆.业丕丝丝万丕丛下三(丟丈一下东业一丝丆:  this.丑丗丗业丈丙丑丂丝(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌), 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w}, 不丝丄丒丌丐一一与:  0).GetComponent<SkinName>();
        this.丝丘丅与丌丗丅丈下 = val_3;
        if(val_3 == null)
        {
                val_4 = this.丝丘丅与丌丗丅丈下;
        }
        
        this.丕丁丘丆万丄世专丛 = val_3.playerMoveC;
        return val_4;
    }
    internal void 丟丙不上丝丂丄丗三(bool 丗丛丘万世丟丅不与)
    {
        if(丗丛丘万世丟丅不与 != false)
        {
                if(this.丝丘丅与丌丗丅丈下 == 0)
        {
                return;
        }
        
            UnityEngine.Object.Destroy(obj:  this.丝丘丅与丌丗丅丈下.gameObject);
            return;
        }
        
        if(this.丝丘丅与丌丗丅丈下 == 0)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.丝丘丅与丌丗丅丈下.gameObject);
    }
    public 丒且丑丙专丟丗丏业()
    {
    
    }

}
