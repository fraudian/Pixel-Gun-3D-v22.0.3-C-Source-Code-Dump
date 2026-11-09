using UnityEngine;

namespace Rilisoft
{
    public sealed class AdvertisementController : MonoBehaviour
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<Rilisoft.AdvertisementController.丙丟与丐三丐万万丆> 丗丐丝丌不丏丒丂丐;
        private UnityEngine.Texture2D 万丗丝三丘丈丌丗丄;
        private UnityEngine.WWW 下丕七丗丁丈丕不丏;
        private Rilisoft.AdvertisementController.丙丟与丐三丐万万丆 丗下丘世三七一专丕;
        private float 丈上七下专丒世丞丕;
        private UnityEngine.WWW 丝丈丛一丗丏东丞丞;
        public bool updateBanner;
        public bool updateFromMultiBanner;
        
        // Properties
        public UnityEngine.Texture2D 丏丕丟专上不七丙下 { get; }
        public Rilisoft.AdvertisementController.丙丟与丐三丐万万丆 上丅丑丌丑丏丏丙东 { get; }
        
        // Methods
        public UnityEngine.Texture2D get_AdvertisementTexture()
        {
            return (UnityEngine.Texture2D)this.万丗丝三丘丈丌丗丄;
        }
        public Rilisoft.AdvertisementController.丙丟与丐三丐万万丆 get_CurrentState()
        {
            return (丙丟与丐三丐万万丆)this.丗下丘世三七一专丕;
        }
        public void Close()
        {
            if(this.丗下丘世三七一专丕 == 5)
            {
                    this.万丗丝三丘丈丌丗丄 = 0;
                if(this.丝丈丛一丗丏东丞丞 != null)
            {
                    this.丝丈丛一丗丏东丞丞.Dispose();
                this.丝丈丛一丗丏东丞丞 = 0;
            }
            
                this.丗下丘世三七一专丕 = 6;
                return;
            }
            
            this = System.String.Format(format:  "AdvertisementController cannot be started in {0} state.", arg0:  this.丗下丘世三七一专丕);
            UnityEngine.Debug.LogError(message:  this);
        }
        public void Run()
        {
            object val_24;
            丙丟与丐三丐万万丆 val_25;
            object val_26;
            object val_27;
            val_24 = this;
            string val_6 = 0;
            PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_4 = 0;
            val_25 = this.丗下丘世三七一专丕;
            if((this.丗丐丝丌不丏丒丂丐.Contains(item:  val_25)) == false)
            {
                goto label_2;
            }
            
            if(UnityEngine.Debug.isDebugBuild != false)
            {
                    UnityEngine.Debug.Log(message:  "Start checking advertisement.");
            }
            
            if(this.丝丈丛一丗丏东丞丞 != null)
            {
                    this.丝丈丛一丗丏东丞丞.Dispose();
                this.丝丈丛一丗丏东丞丞 = 0;
            }
            
            if(this.下丕七丗丁丈丕不丏 != null)
            {
                    this.下丕七丗丁丈丕不丏.Dispose();
                this.下丕七丗丁丈丕不丏 = 0;
            }
            
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().不万丝丐丁一丏一丐(上世丏丁世丟世丆业: out  val_4)) == false)
            {
                    return;
            }
            
            if((PGCompany.DataObjects.三丛丂丟与不专丛丏.七三丟三丛上东丒且(上世丏丁世丟世丆业:  val_4, 七丆丒与丗丌丄且丂: out  val_6)) == false)
            {
                    return;
            }
            
            Rilisoft.丆丆丕丟不一丝丕世 val_9 = Rilisoft.且且丌与专丐一东一.丑七不且上丗丁一世().专万丗丁丗下不丂丈(七丆丒与丗丌丄且丂:  val_6);
            val_25 = System.String.IsNullOrEmpty(value:  val_9.不丈东丒丄丅丝丂丑());
            if(val_9 == null)
            {
                goto label_19;
            }
            
            if(val_25 == false)
            {
                goto label_20;
            }
            
            label_29:
            if(val_9.世丑三丆丒七丘丕丑() == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_9.丆丞丐不丂丛丞丘业())) == false)
            {
                goto label_23;
            }
            
            val_26 = "Pereliv image url is empty.";
            goto label_26;
            label_2:
            val_24 = System.String.Format(format:  "AdvertisementController cannot be started in {0} state.", arg0:  this.丗下丘世三七一专丕);
            UnityEngine.Debug.LogError(message:  val_24);
            return;
            label_19:
            if(val_25 == true)
            {
                goto label_29;
            }
            
            label_20:
            val_26 = val_9.不丈东丒丄丅丝丂丑();
            label_26:
            UnityEngine.Debug.LogWarning(message:  val_26);
            return;
            label_23:
            if(this.updateBanner != true)
            {
                    if(this.updateFromMultiBanner == false)
            {
                goto label_34;
            }
            
            }
            
            this.万丗丝三丘丈丌丗丄 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "update_available");
            this.丗下丘世三七一专丕 = 5;
            return;
            label_34:
            if(UnityEngine.Application.isEditor != false)
            {
                    if(FriendsController.丘丟专专丘东丈丒上() != false)
            {
                    val_27 = "<color=yellow>PerelivSettings.ImageUrl: "("<color=yellow>PerelivSettings.ImageUrl: ") + val_9.丆丞丐不丂丛丞丘业() + "</color>"("</color>");
                UnityEngine.Debug.Log(message:  val_27);
            }
            
            }
            
            this.下丕七丗丁丈丕不丏 = Rilisoft.与丄丁丄丙丞下下丙.三专世丝丝丈丂东与(七丙不丅丛丘丗万与:  val_9.丆丞丐不丂丛丞丘业(), 丝丌丝不丟丞丑丑丗:  true);
            this.丗下丘世三七一专丕 = 1;
        }
        private void OnDestroy()
        {
            if(this.下丕七丗丁丈丕不丏 != null)
            {
                    this.下丕七丗丁丈丕不丏.Dispose();
                this.下丕七丗丁丈丕不丏 = 0;
            }
            
            if(this.丝丈丛一丗丏东丞丞 == null)
            {
                    return;
            }
            
            this.丝丈丛一丗丏东丞丞.Dispose();
            this.丝丈丛一丗丏东丞丞 = 0;
        }
        private void Update()
        {
            if(this.丗下丘世三七一专丕 <= 6)
            {
                    var val_1 = 106025376 + (this.丗下丘世三七一专丕) << 2;
                val_1 = val_1 + 106025376;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "Unknown state.");
            }
        
        }
        public AdvertisementController()
        {
            System.Collections.Generic.HashSet<丙丟与丐三丐万万丆> val_1 = new System.Collections.Generic.HashSet<丙丟与丐三丐万万丆>();
            if(val_1 != null)
            {
                    bool val_2 = val_1.Add(item:  0);
                bool val_3 = val_1.Add(item:  2);
            }
            else
            {
                    bool val_4 = val_1.Add(item:  0);
                bool val_5 = val_1.Add(item:  2);
            }
            
            bool val_6 = val_1.Add(item:  6);
            this.丗丐丝丌不丏丒丂丐 = val_1;
        }
    
    }

}
