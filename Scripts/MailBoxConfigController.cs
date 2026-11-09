using UnityEngine;
internal sealed class MailBoxConfigController : PGBehaviour
{
    // Fields
    internal 与东业丟且丛七丝丛 丅丗专丅丏丌与万一;
    internal static MailBoxConfigController 丆丕丝丒不丙且丐丗;
    
    // Methods
    private void Awake()
    {
        MailBoxConfigController.丆丕丝丒不丙且丐丗 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    private void Start()
    {
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void MailBoxConfigController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void MailBoxConfigController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        this.不一丘丅且丆不七上(丅业丙丞且丐一丙丆:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  74));
    }
    private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 74)
        {
                return;
        }
        
        this.不一丘丅且丆不七上(丅业丙丞且丐一丙丆:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  74));
    }
    private void 不一丘丅且丆不七上(string 丅业丙丞且丐一丙丆)
    {
        this.丅丗专丅丏丌与万一 = new 与东业丟且丛七丝丛(丄丁丛丌丂丑丆丏丕:  丅业丙丞且丐一丙丆);
    }
    public MailBoxConfigController()
    {
    
    }

}
