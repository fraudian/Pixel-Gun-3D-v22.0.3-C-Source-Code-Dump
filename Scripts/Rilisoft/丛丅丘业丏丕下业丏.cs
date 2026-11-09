using UnityEngine;

namespace Rilisoft
{
    internal class 丛丅丘业丏丕下业丏
    {
        // Fields
        private const int 万丙业丆丁七上不丈 = 62000;
        private const string 且丅丐丑不丟下丞丂 = "lobby_textures/custom_lobby_foto.png";
        private const string 丟且丒东丈丅七丘上 = "lobby_textures/custom_lobby_foto_blured.png";
        private const string 下丟丁业一业三丟丘 = "lobby_textures/user-{0}/custom_lobby_foto.png";
        private const string 世丟丅万与丏丈丆东 = "lobby_textures/user-{0}/custom_lobby_foto_blured.png";
        private static Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛丅丘业丏丕下业丏> 丝业丆丁业三丈丟东;
        private static bool 丐下丏丂万丆东丅一;
        private static UnityEngine.Texture2D 且丂七丐丝下丟万丏;
        private static UnityEngine.Texture2D 七丕丌丄丛丆专丄且;
        private int 一丂丞且丒下丂业丑;
        
        // Properties
        private static string 丄下丟一与丑丘丘且 { get; }
        private static string 丅丘七丑丅丆东丄丈 { get; }
        private static string 与丙丝丅丕丆丄与东 { get; }
        internal static Rilisoft.丛丅丘业丏丕下业丏 丆丕丝丒不丙且丐丗 { get; }
        internal static UnityEngine.Texture2D 丑丝丈丌东丏丐丄丟 { get; set; }
        internal static UnityEngine.Texture2D 专丕丅丑丝丅丈丂丅 { get; }
        internal static UnityEngine.Texture2D 丕丙上不东丈丄东东 { get; set; }
        
        // Methods
        private static string 丕一丁丒东上丈丕丆()
        {
            return System.String.Format(format:  "lobby_textures/user-{0}/custom_lobby_foto.png", arg0:  Rilisoft.丛丅丘业丏丕下业丏.丏丂丘东万丈七且丒());
        }
        private static string 丄丝丛丄丌丄东丅三()
        {
            return System.String.Format(format:  "lobby_textures/user-{0}/custom_lobby_foto_blured.png", arg0:  Rilisoft.丛丅丘业丏丕下业丏.丏丂丘东万丈七且丒());
        }
        private static string 丏丂丘东万丈七且丒()
        {
            string val_1 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true) ? "any" : (val_1);
        }
        internal static Rilisoft.丛丅丘业丏丕下业丏 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.丛丅丘业丏丕下业丏.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.丛丅丘业丏丕下业丏.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.丛丅丘业丏丕下业丏.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        internal static UnityEngine.Texture2D 且世上且丏丄三丂丘()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            val_5 = null;
            if(Rilisoft.丛丅丘业丏丕下业丏.且丂七丐丝下丟万丏 == 0)
            {
                    val_5 = null;
                Rilisoft.丛丅丘业丏丕下业丏.且丂七丐丝下丟万丏 = Rilisoft.丛丅丘业丏丕下业丏.不丌下丐丂丗丌丑丈(丝丈丝丆世丁丄专丂:  Rilisoft.丛丅丘业丏丕下业丏.丕一丁丒东上丈丕丆());
            }
            
            val_5 = null;
            return (UnityEngine.Texture2D)Rilisoft.丛丅丘业丏丕下业丏.且丂七丐丝下丟万丏;
        }
        private static void 万丝丘丐世丟与三丛(UnityEngine.Texture2D 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.丛丅丘业丏丕下业丏.且丂七丐丝下丟万丏 = 丙业与丙丗丝不丈东;
        }
        internal static UnityEngine.Texture2D 世丄七丅专且万丁丂()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "LoadingSeason/loading_active");
        }
        internal static UnityEngine.Texture2D 东丝专世丏丙丈三丕()
        {
            var val_6;
            UnityEngine.Texture2D val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            val_7 = Rilisoft.丛丅丘业丏丕下业丏.七丕丌丄丛丆专丄且;
            if(val_7 == 0)
            {
                    Rilisoft.丛丅丘业丏丕下业丏.七丕丌丄丛丆专丄且 = Rilisoft.丛丅丘业丏丕下业丏.不丌下丐丂丗丌丑丈(丝丈丝丆世丁丄专丂:  Rilisoft.丛丅丘业丏丕下业丏.丄丝丛丄丌丄东丅三());
                val_7 = Rilisoft.丛丅丘业丏丕下业丏.七丕丌丄丛丆专丄且;
                if(val_7 == 0)
            {
                    Rilisoft.丛丅丘业丏丕下业丏.七丕丌丄丛丆专丄且 = Rilisoft.丛丅丘业丏丕下业丏.且世上且丏丄三丂丘();
            }
            
            }
            
            val_8 = null;
            val_8 = null;
            return (UnityEngine.Texture2D)Rilisoft.丛丅丘业丏丕下业丏.七丕丌丄丛丆专丄且;
        }
        private static void 丈丑丗三一七上丂丕(UnityEngine.Texture2D 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.丛丅丘业丏丕下业丏.七丕丌丄丛丆专丄且 = 丙业与丙丗丝不丈东;
        }
        private static 丛丅丘业丏丕下业丏()
        {
            null = null;
            Rilisoft.丛丅丘业丏丕下业丏.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛丅丘业丏丕下业丏>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.丛丅丘业丏丕下业丏>(object:  丛丅丘业丏丕下业丏.<>c.<>9, method:  Rilisoft.丛丅丘业丏丕下业丏 丛丅丘业丏丕下业丏.<>c::丛丞丌丂且三丝三东()));
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void Rilisoft.丛丅丘业丏丕下业丏::丏上丛丐且丒世丆丕()));
            Rilisoft.丛丅丘业丏丕下业丏.丄专丒丑专丐不丝丞();
        }
        public void 东三世丈东丝丄与业(bool 七丆丟丗世丟且丒丆 = False)
        {
            七丆丟丗世丟且丒丆 = 七丆丟丗世丟且丒丆;
            UnityEngine.Coroutine val_3 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丙丘上丒与丂丄丌丝(七丆丟丗世丟且丒丆:  七丆丟丗世丟且丒丆));
        }
        private System.Collections.IEnumerator 丙丘上丒与丂丄丌丝(bool 七丆丟丗世丟且丒丆 = False)
        {
            丛丅丘业丏丕下业丏.上下一丌七丏丁丕丏 val_1 = new 丛丅丘业丏丕下业丏.上下一丌七丏丁丕丏();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .七丆丟丗世丟且丒丆 = 七丆丟丗世丟且丒丆;
            return (System.Collections.IEnumerator)val_1;
        }
        public bool 丐一七东丏不丅丗丘(bool 七丆丟丗世丟且丒丆 = False)
        {
            UnityEngine.Texture2D val_20;
            UnityEngine.Camera val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_21 = this;
            if(七丆丟丗世丟且丒丆 != true)
            {
                    if(this.一丂丞且丒下丂业丑 == UnityEngine.Time.frameCount)
            {
                goto label_2;
            }
            
            }
            
            if(MainMenuHeroCamera.丑七不且上丗丁一世() == 0)
            {
                    label_2:
                val_22 = 0;
                return (bool)val_22;
            }
            
            int val_4 = UnityEngine.Time.frameCount;
            this.一丂丞且丒下丂业丑 = val_4;
            val_4.上丘三丙丒业丙丘丘();
            val_21 = MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三();
            bool val_7 = 东丗上丁下业一丂丂.丗丟专一丏不丛与丑();
            UnityEngine.Texture2D val_10 = Rilisoft.丘上丕丗丘专万丆丁.丕丑丈丒丄丅丅丝一(业丆丆东丂与万丅不:  val_21, 业与三万七丝不万东:  (val_7 != true) ? 2160 : 1440, 丟丌丐丘丆丙丑丑一:  (val_7 != true) ? 1080 : 720, 世业丄业下丛丞丟下:  3);
            Rilisoft.丛丅丘业丏丕下业丏.丈丝丅丛丙丑且丛不(与万丆丛丒万丝丙丑:  val_10, 丝丈丝丆世丁丄专丂:  Rilisoft.丛丅丘业丏丕下业丏.丕一丁丒东上丈丕丆());
            UnityEngine.Object.Destroy(obj:  val_10);
            Rilisoft.丛丅丘业丏丕下业丏.万丝丘丐世丟与三丛(丙业与丙丗丝不丈东:  0);
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
            {
                    val_23 = null;
                val_23 = null;
                float val_21 = 360f;
                float val_20 = 1f;
                val_20 = val_20 - IphoneXCameraScaler.且下丒丘丙丒丈丏万;
                val_21 = val_20 * val_21;
                val_21 = val_21 + 2f;
                val_24 = UnityEngine.Mathf.RoundToInt(f:  val_21);
            }
            else
            {
                    val_24 = 0;
            }
            
            val_25 = null;
            val_25 = null;
            float val_22 = 720f;
            val_22 = val_22 / IphoneXCameraScaler.不丅七丘丈不丌丝丏;
            int val_14 = UnityEngine.Mathf.RoundToInt(f:  val_22);
            new UnityEngine.RenderTexture() = new UnityEngine.RenderTexture(width:  val_14, height:  360, depth:  16);
            val_21.targetTexture = new UnityEngine.RenderTexture();
            val_21.Render();
            UnityEngine.RenderTexture.active = new UnityEngine.RenderTexture();
            new UnityEngine.Material() = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "ImageEffect/Blur"));
            val_20 = new UnityEngine.Texture2D();
            val_20 = new UnityEngine.Texture2D(width:  val_14, height:  104, textureFormat:  3, mipChain:  false);
            new UnityEngine.Texture2D().ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
            new UnityEngine.Texture2D().Apply();
            new UnityEngine.RenderTexture().DiscardContents();
            UnityEngine.Graphics.Blit(source:  new UnityEngine.Texture2D(), dest:  new UnityEngine.RenderTexture(), mat:  new UnityEngine.Material());
            new UnityEngine.Texture2D().ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
            new UnityEngine.Texture2D().Apply();
            val_21.targetTexture = 0;
            UnityEngine.RenderTexture.active = 0;
            Rilisoft.丛丅丘业丏丕下业丏.丈丝丅丛丙丑且丛不(与万丆丛丒万丝丙丑:  new UnityEngine.Texture2D(), 丝丈丝丆世丁丄专丂:  Rilisoft.丛丅丘业丏丕下业丏.丄丝丛丄丌丄东丅三());
            Rilisoft.丛丅丘业丏丕下业丏.丈丑丗三一七上丂丕(丙业与丙丗丝不丈东:  0);
            UnityEngine.Object.Destroy(obj:  new UnityEngine.RenderTexture());
            UnityEngine.Object.Destroy(obj:  new UnityEngine.Texture2D());
            new UnityEngine.Texture2D().丞丙业丅三不与丐一();
            val_22 = 1;
            return (bool)val_22;
        }
        public void 世世三不丏与丌与专()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Rilisoft.丛丅丘业丏丕下业丏.丐下丏丂万丆东丅一 == false)
            {
                    return;
            }
            
            if((this.丐一七东丏不丅丗丘(七丆丟丗世丟且丒丆:  false)) == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Rilisoft.丛丅丘业丏丕下业丏.丐下丏丂万丆东丅一 = false;
        }
        private void 上丘三丙丒业丙丘丘()
        {
            var val_3;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = Rilisoft.丛丅丘业丏丕下业丏.丂一丕丞一丑下丈世(三丛东丒三丝丅丌丁:  true);
            val_3 = null;
            val_3 = null;
            if((丛丅丘业丏丕下业丏.<>c.<>9__31_0) == null)
            {
                goto label_5;
            }
            
            label_10:
            val_1.ForEach(action:  丛丅丘业丏丕下业丏.<>c.<>9__31_0);
            return;
            label_5:
            丛丅丘业丏丕下业丏.<>c.<>9__31_0 = new System.Action<UnityEngine.GameObject>(object:  丛丅丘业丏丕下业丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丛丅丘业丏丕下业丏.<>c::丏丐丛且上丝专丛丑(UnityEngine.GameObject 丄三丅七丆丛与与上));
            if(val_1 != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        private void 丞丙业丅三不与丐一()
        {
            var val_3;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = Rilisoft.丛丅丘业丏丕下业丏.丂一丕丞一丑下丈世(三丛东丒三丝丅丌丁:  true);
            val_3 = null;
            val_3 = null;
            if((丛丅丘业丏丕下业丏.<>c.<>9__32_0) == null)
            {
                goto label_5;
            }
            
            label_10:
            val_1.ForEach(action:  丛丅丘业丏丕下业丏.<>c.<>9__32_0);
            return;
            label_5:
            丛丅丘业丏丕下业丏.<>c.<>9__32_0 = new System.Action<UnityEngine.GameObject>(object:  丛丅丘业丏丕下业丏.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丛丅丘业丏丕下业丏.<>c::丗丅丗一丝丅万丙丗(UnityEngine.GameObject 丄三丅七丆丛与与上));
            if(val_1 != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        internal static System.Collections.Generic.List<UnityEngine.GameObject> 丂一丕丞一丑下丈世(bool 三丛东丒三丝丅丌丁 = True)
        {
            UnityEngine.Object val_41;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            if(AnimationGift.丄丘七三上丕世丞业 != 0)
            {
                    val_1.Add(item:  AnimationGift.丄丘七三上丕世丞业.gameObject);
            }
            
            if(FreeAwardShowHandler.丑七不且上丗丁一世() != 0)
            {
                    val_1.Add(item:  FreeAwardShowHandler.丑七不且上丗丁一世().gameObject);
            }
            
            if(Rilisoft.Nest.丑七不且上丗丁一世() != 0)
            {
                    val_1.Add(item:  Rilisoft.Nest.丑七不且上丗丁一世().gameObject);
            }
            
            if(Rilisoft.LeprechauntLobbyView.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_1.Add(item:  Rilisoft.LeprechauntLobbyView.丆丕丝丒不丙且丐丗.gameObject);
            }
            
            if(FifthEggInLobbyController.丑七不且上丗丁一世() != 0)
            {
                    val_1.Add(item:  FifthEggInLobbyController.丑七不且上丗丁一世().gameObject);
            }
            
            if(PGCompany.LobbyEventStoreDelegate.Instance != 0)
            {
                    val_1.Add(item:  PGCompany.LobbyEventStoreDelegate.Instance.gameObject);
            }
            
            val_41 = PGCompany.Piggy.PiggyOffersLobby.丑七不且上丗丁一世();
            if(val_41 != 0)
            {
                    val_41 = PGCompany.Piggy.PiggyOffersLobby.丑七不且上丗丁一世().三下且丁专业丝丅丙();
                val_1.Add(item:  val_41);
            }
            
            if(三丛东丒三丝丅丌丁 == false)
            {
                    return val_1;
            }
            
            if(PersConfigurator.下一丁七丅丕七万丑() != 0)
            {
                    val_1.Add(item:  PersConfigurator.下一丁七丅丕七万丑().gameObject.transform.root.gameObject);
            }
            
            if(PersConfigurator.下一丁七丅丕七万丑() == 0)
            {
                    return val_1;
            }
            
            if(PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐() == 0)
            {
                    return val_1;
            }
            
            CharacterInterfaceV2 val_41 = PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐();
            UnityEngine.Object val_40 = val_41.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  13);
            if(val_40 == null)
            {
                goto label_62;
            }
            
            val_41 = (null == null) ? (val_40) : 0;
            if(val_1 != null)
            {
                goto label_64;
            }
            
            label_65:
            label_64:
            val_1.Add(item:  val_41);
            return val_1;
            label_62:
            if(val_1 != null)
            {
                goto label_64;
            }
            
            goto label_65;
        }
        internal static void 东丒万丘丆丐世丕丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 下下东且万业丞丅丒)
        {
            UnityEngine.GameObject val_11 = 丝三丁东丈丒世丅业;
            if(val_11 == 0)
            {
                    return;
            }
            
            if((val_11 & 1) != 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = val_11.transform.localPosition;
            UnityEngine.Vector3 val_6 = val_11.transform.localPosition;
            UnityEngine.Vector3 val_8 = val_11.transform.localPosition;
            float val_9 = ((下下东且万业丞丅丒 != true) ? 5000f : -5000f) + val_6.y;
            val_11 = val_11.transform;
            val_11.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private static void 丈丝丅丛丙丑且丛不(UnityEngine.Texture2D 与万丆丛丒万丝丙丑, string 丝丈丝丆世丁丄专丂)
        {
            System.Byte[] val_12;
            if(与万丆丛丒万丝丙丑 != 0)
            {
                    string val_4 = System.IO.Path.Combine(path1:  Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().不万丛七世三丗丐丟(), path2:  丝丈丝丆世丁丄专丂);
                string val_5 = System.IO.Path.GetDirectoryName(path:  val_4);
                if((System.IO.Directory.Exists(path:  val_5)) != true)
            {
                    System.IO.DirectoryInfo val_7 = System.IO.Directory.CreateDirectory(path:  val_5);
            }
            
                val_12 = UnityEngine.ImageConversion.EncodeToPNG(tex:  与万丆丛丒万丝丙丑);
                if(val_8.Length > 61999)
            {
                    System.IO.File.WriteAllBytes(path:  val_4, bytes:  val_12);
                return;
            }
            
                if((System.IO.File.Exists(path:  val_4)) == false)
            {
                    return;
            }
            
                val_12 = System.IO.File.ReadAllBytes(path:  val_4);
                if(val_10.Length > 61999)
            {
                    return;
            }
            
                System.IO.File.Delete(path:  val_4);
                return;
            }
            
            System.ArgumentNullException val_11 = new System.ArgumentNullException(paramName:  "texture is null");
        }
        private static UnityEngine.Texture2D 不丌下丐丂丗丌丑丈(string 丝丈丝丆世丁丄专丂)
        {
            UnityEngine.Texture2D val_8;
            string val_3 = System.IO.Path.Combine(path1:  Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().不万丛七世三丗丐丟(), path2:  丝丈丝丆世丁丄专丂);
            val_8 = 0;
            if((System.IO.File.Exists(path:  val_3)) == false)
            {
                    return (UnityEngine.Texture2D)val_8;
            }
            
            if(val_5.Length >= 62000)
            {
                    UnityEngine.Texture2D val_6 = null;
                val_8 = val_6;
                val_6 = new UnityEngine.Texture2D(width:  2, height:  2, textureFormat:  4, mipChain:  false);
                bool val_7 = UnityEngine.ImageConversion.LoadImage(tex:  val_6, data:  System.IO.File.ReadAllBytes(path:  val_3), markNonReadable:  true);
                val_6.filterMode = 2;
                return (UnityEngine.Texture2D)val_8;
            }
            
            val_8 = 0;
            return (UnityEngine.Texture2D)val_8;
        }
        private static void 丄专丒丑专丐不丝丞()
        {
            Rilisoft.丛丅丘业丏丕下业丏.一丁丙丒丞不丐丂丐(丈丆三万七丛上丄丒:  System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "lobby_textures/custom_lobby_foto.png"), 丆且丁丅一一一丘丈:  System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  Rilisoft.丛丅丘业丏丕下业丏.丕一丁丒东上丈丕丆()));
            Rilisoft.丛丅丘业丏丕下业丏.一丁丙丒丞不丐丂丐(丈丆三万七丛上丄丒:  System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "lobby_textures/custom_lobby_foto_blured.png"), 丆且丁丅一一一丘丈:  System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  Rilisoft.丛丅丘业丏丕下业丏.丄丝丛丄丌丄东丅三()));
        }
        private static void 一丁丙丒丞不丐丂丐(string 丈丆三万七丛上丄丒, string 丆且丁丅一一一丘丈)
        {
            if((System.IO.File.Exists(path:  丈丆三万七丛上丄丒)) == false)
            {
                    return;
            }
            
            if((System.IO.File.Exists(path:  丆且丁丅一一一丘丈)) == true)
            {
                    return;
            }
            
            if((System.IO.Directory.Exists(path:  System.IO.Path.GetDirectoryName(path:  丆且丁丅一一一丘丈))) != true)
            {
                    System.IO.DirectoryInfo val_6 = System.IO.Directory.CreateDirectory(path:  System.IO.Path.GetDirectoryName(path:  丆且丁丅一一一丘丈));
            }
            
            System.IO.File.Move(sourceFileName:  丈丆三万七丛上丄丒, destFileName:  丆且丁丅一一一丘丈);
        }
        private static void 丏上丛丐且丒世丆丕()
        {
            Rilisoft.丛丅丘业丏丕下业丏.万丝丘丐世丟与三丛(丙业与丙丗丝不丈东:  0);
            Rilisoft.丛丅丘业丏丕下业丏.丈丑丗三一七上丂丕(丙业与丙丗丝不丈东:  0);
            Rilisoft.丛丅丘业丏丕下业丏.丐下丏丂万丆东丅一 = true;
        }
        public 丛丅丘业丏丕下业丏()
        {
        
        }
    
    }

}
