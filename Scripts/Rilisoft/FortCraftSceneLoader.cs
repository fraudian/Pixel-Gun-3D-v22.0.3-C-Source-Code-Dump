using UnityEngine;

namespace Rilisoft
{
    public class FortCraftSceneLoader : Singleton<Rilisoft.FortCraftSceneLoader>
    {
        // Fields
        private const string 丛丁上丐上丛业丘专 = "Fort";
        private System.IDisposable 且丂七丑丈丞丈三丑;
        private UnityEngine.Coroutine 丒世七丆丂上与丄丟;
        private bool 下丑丞万东上丌丙丄;
        private UnityEngine.Coroutine 东专丄与丑世东丏且;
        private MainMenuHeroCamera.业丟丝丗且丌丌东且 丗且丙丛丏丒不丝不;
        private bool 丐与与丙上丗丐丟世;
        public System.Action OnClose;
        
        // Methods
        public void ToCraftScene(丞丂丘丒丟丞丑下丄 丞丌丐丞丞丘丏专下, bool 丆三丑万丂丌世丆丆, System.Action 丟不丒万丝与丂上丘, UnityEngine.GameObject 丈东丘丏与丌东东下)
        {
            System.Action val_15;
            if(this.丒世七丆丂上与丄丟 != null)
            {
                    return;
            }
            
            if(this.东专丄与丑世东丏且 != null)
            {
                    return;
            }
            
            if(((Rilisoft.Singleton<ClansController>.Instance) != 0) && ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null))
            {
                    if((System.String.op_Equality(a:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁(), b:  丞丌丐丞丞丘丏专下.业丐丐三丕一丗丛丁())) != false)
            {
                    this.丐与与丙上丗丐丟世 = true;
            }
            
            }
            
            if(((System.Delegate.Combine(a:  this.OnClose, b:  丟不丒万丝与丂上丘)) != null) && (null != null))
            {
                    val_15 = 0;
            }
            
            this.OnClose = val_15;
            this.丒世七丆丂上与丄丟 = this.StartCoroutine(routine:  this.业丞丂丛丂丅丒丈丅(丈东丘丏与丌东东下:  丈东丘丏与丌东东下, 丞丌丐丞丞丘丏专下:  丞丌丐丞丞丘丏专下, 丆三丑万丂丌世丆丆:  丆三丑万丂丌世丆丆));
        }
        public void ToLobby()
        {
            if(this.丒世七丆丂上与丄丟 != null)
            {
                    return;
            }
            
            if(this.东专丄与丑世东丏且 != null)
            {
                    return;
            }
            
            this.东专丄与丑世东丏且 = this.StartCoroutine(routine:  this.丗丌东丛丒不丝丛丆());
        }
        public void LeaveWithoutUnload()
        {
            this.丒丛丁丑丞丗丐且世();
            this.丌与丁丏丌三丅专丗();
        }
        private void 丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
        
        }
        private void 上丏丛丈且七丐七丅()
        {
        
        }
        private System.Collections.IEnumerator 业丞丂丛丂丅丒丈丅(UnityEngine.GameObject 丈东丘丏与丌东东下, 丞丂丘丒丟丞丑下丄 丞丌丐丞丞丘丏专下, bool 丆三丑万丂丌世丆丆)
        {
            FortCraftSceneLoader.丐丑丞世万业一丟专 val_1 = new FortCraftSceneLoader.丐丑丞世万业一丟专();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丈东丘丏与丌东东下 = 丈东丘丏与丌东东下;
                .丞丌丐丞丞丘丏专下 = 丞丌丐丞丞丘丏专下;
            }
            else
            {
                    mem[32] = this;
                mem[48] = 丈东丘丏与丌东东下;
                mem[56] = 丞丌丐丞丞丘丏专下;
            }
            
            .丆三丑万丂丌世丆丆 = 丆三丑万丂丌世丆丆;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丒丛丁丑丞丗丐且世()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_6 = null;
                val_6 = null;
                MainMenuController.丄丞丁丈与业上丞丟.丌丁丆丁万上丁丘丑(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.FortCraftSceneLoader::丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.FortSceneStubLoading, 丏业丟一东丂东丘丛:  true);
            }
            
            val_7 = null;
            val_7 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_8 = null;
                val_8 = null;
                Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
            }
            
            Rilisoft.FortCraftController.三专业与丑丈丈与丐(不与万丌一丈下丑丈:  false);
            Rilisoft.LobbyCraftController.三专业与丑丈丈与丐(不与万丌一丈下丑丈:  true);
            MainMenuHeroCamera.丑七不且上丗丁一世().ToLobby();
        }
        private void 丌与丁丏丌三丅专丗()
        {
            System.EventHandler val_12;
            var val_13;
            var val_14;
            UnityEngine.Object val_16;
            val_12 = 1152921505080860672;
            val_13 = null;
            val_13 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
                val_14 = null;
                val_14 = null;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.FortSceneStubLoading, 丏业丟一东丂东丘丛:  false);
                System.EventHandler val_2 = null;
                val_12 = val_2;
                val_2 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.FortCraftSceneLoader::丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                MainMenuController.丄丞丁丈与业上丞丟.丒丟万丂万丆业三丑(丙业与丙丗丝不丈东:  val_2);
            }
            
            if(this.丗且丙丛丏丒不丝不 != 0)
            {
                    val_12 = MainMenuHeroCamera.丑七不且上丗丁一世();
                val_12.丏且丑丕丈丗丂丐丘(丟丕上丂丏一丄丁专:  this.丗且丙丛丏丒不丝不, 丘丕丑一丅丆丝与丁:  true, 丈上不丆丑丑三专丗:  false);
            }
            
            if(this.且丂七丑丈丞丈三丑 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                this.且丂七丑丈丞丈三丑.Dispose();
                this.且丂七丑丈丞丈三丑 = 0;
            }
            
            if(this.OnClose != null)
            {
                    this.OnClose.Invoke();
                this.OnClose = 0;
            }
            
            val_16 = Rilisoft.Nest.丑七不且上丗丁一世();
            if(val_16 == 0)
            {
                    return;
            }
            
            val_16 = Rilisoft.Nest.丑七不且上丗丁一世().gameObject;
            if(val_16 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  Rilisoft.Nest.丑七不且上丗丁一世().gameObject, 丏业丟一东丂东丘丛:  true);
        }
        private System.Collections.IEnumerator 丗丌东丛丒不丝丛丆()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new FortCraftSceneLoader.丘世丆且三下不丈丑();
        }
        public FortCraftSceneLoader()
        {
            this.下丑丞万东上丌丙丄 = true;
        }
    
    }

}
