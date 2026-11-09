using UnityEngine;
internal sealed class 万丒丆丞丘丆专丛丐 : 东上丛丂丅下丄七丝
{
    // Methods
    internal override void 下丌业业丐丘丐丘三()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void 万丒丆丞丘丆专丛丐::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    internal override void 不与丞下业丑丒丙万()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void 万丒丆丞丘丆专丛丐::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    internal override bool 专下丒丘丞下丟不下(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不)
    {
        if(上且丗一丏丏万丅丌 != 100)
        {
                return (bool)((上且丗一丏丏万丅丌 | 1) == 27) ? 1 : 0;
        }
        
        return true;
    }
    private void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且 == null)
        {
                return;
        }
        
        if(mem[137146504] == 100)
        {
                return;
        }
        
        if(mem[137146504] != 27)
        {
                if(mem[137146504] != 26)
        {
                return;
        }
        
        }
        
        if(ShouldWin != false)
        {
                if(丗丛不丁丑专专丂且.东丐三一业与丘丂丕() == false)
        {
                return;
        }
        
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌().Equals(obj:  mem[137146504])) == false)
        {
                return;
        }
        
        if(GameConnect.七丕丟上且丄丂丞丕() == false)
        {
                return;
        }
        
        if((Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝且丗丌丟丈世上万().业上丙丞丐丄丆丅七()})) == false)
        {
                return;
        }
        
        this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
    }
    public 万丒丆丞丘丆专丛丐()
    {
    
    }

}
