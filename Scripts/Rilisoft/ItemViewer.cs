using UnityEngine;

namespace Rilisoft
{
    public class ItemViewer : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _baseWindow;
        private UIBasicSprite _itemTexture;
        private Rilisoft.TextGroup _headerText;
        private Rilisoft.TextGroup _itemNameText;
        private UILabel _itemSubNameLabel;
        private UILabel _itemDescriptionLabel;
        private ItemPreviewInArmoryInfoScreen _3dItemPreview;
        private UnityEngine.GameObject _skinPreview;
        private UnityEngine.GameObject _buttonTransitionContainer;
        private UILabel _buttonTransitionLabel;
        private UnityEngine.GameObject _window;
        private float _simpleWindowY;
        private float _battlePassWindowY;
        internal const string 丕丈丗一丛丝丛七东 = "NguiWindows/InfoView";
        internal const string 上丕丕上上下丞万丙 = "NguiWindows/InfoViewClanStorage";
        internal const string 丁丐与万与与一下丌 = "NguiWindows/InfoViewBattlePass";
        internal const string 丛七丙三不三丅三下 = "NguiWindows/InfoViewClanStore";
        private const string 三下丏三三三丌丌下 = "Rocket";
        private static readonly System.Collections.Generic.List<Rilisoft.ItemViewer> 丟下丟专丏丘东丁丄;
        private static System.Action 业丄上丅丐丒下丈丞;
        private static System.Action 丒丂三丑不丛业丐且;
        private System.Action 丛丄业丘不丆丄三丞;
        private UnityEngine.Color 万丞丞丄丄不丐丛丗;
        private UnityEngine.Color 丟且丐丂丂三下丒专;
        private UnityEngine.Color 丆丙丅丅东且万一丄;
        private bool 丄丛丏东丝丐丑且一;
        private ArmoryInfoScreenController 下丏丗且丅丟丄丂与;
        private PetInfoController 且世丅业且丁上丘丞;
        private Rilisoft.GameEventExtendedEventInfoView 丑丏世丆丞丘丆丞丑;
        private LootBoxInfo 丗丆丕东万且业专业;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private bool 丘丝世丒三丑七丗七;
        private bool <业上东丏不丂丛丐且>k__BackingField;
        private string 丝三业丌丟丁丗丕丞;
        private System.Nullable<CategoryNames> 与丆万丆上丐不丕丞;
        private bool 丅与丂丞丈下丒丘世;
        
        // Properties
        private static bool 丟丑丏且丒丝丙丛丏 { get; }
        public bool 七丕世丌不七丁东下 { get; set; }
        public bool 丙三丂丒世丙专万世 { get; set; }
        public bool 丕东丞丐丑上万丅丗 { get; set; }
        private UIBasicSprite 下丝万丄丕世丝丝与 { get; }
        
        // Methods
        private static bool 丏三丑丘三丒丙丞且()
        {
            null = null;
            return System.Linq.Enumerable.Any<Rilisoft.ItemViewer>(source:  Rilisoft.ItemViewer.丟下丟专丏丘东丁丄);
        }
        private static void 丂七东丌万丞东丐三()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if((System.Linq.Enumerable.Any<Rilisoft.ItemViewer>(source:  Rilisoft.ItemViewer.丟下丟专丏丘东丁丄)) == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if(Rilisoft.ItemViewer.丟下丟专丏丘东丁丄 != null)
            {
                    val_7 = Rilisoft.ItemViewer.丟下丟专丏丘东丁丄.Count;
            }
            else
            {
                    val_7 = 0.Count;
            }
            
            Rilisoft.ItemViewer.丟下丟专丏丘东丁丄.RemoveAt(index:  val_7 - 1);
        }
        private static void 丁一丈上世专丙下下(Rilisoft.ItemViewer 丈丗世丗丟丒一丑丐)
        {
            var val_3;
            var val_4;
            if(丈丗世丗丟丒一丑丐 == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if((Rilisoft.ItemViewer.丟下丟专丏丘东丁丄.Contains(item:  丈丗世丗丟丒一丑丐)) != false)
            {
                    UnityEngine.Debug.LogError(message:  "cant push ItemViewer to stack, current instance already exists");
                return;
            }
            
            val_4 = null;
            val_4 = null;
            Rilisoft.ItemViewer.丟下丟专丏丘东丁丄.Add(item:  丈丗世丗丟丒一丑丐);
        }
        public static void add_OnViewerShow(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.ItemViewer.业丄上丅丐丒下丈丞, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.ItemViewer.业丄上丅丐丒下丈丞 != 1152921505493696520);
        
        }
        public static void remove_OnViewerShow(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.ItemViewer.业丄上丅丐丒下丈丞, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.ItemViewer.业丄上丅丐丒下丈丞 != 1152921505493696520);
        
        }
        public static void add_OnViewerHided(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.ItemViewer.丒丂三丑不丛业丐且, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.ItemViewer.丒丂三丑不丛业丐且 != 1152921505493696528);
        
        }
        public static void remove_OnViewerHided(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.ItemViewer.丒丂三丑不丛业丐且, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.ItemViewer.丒丂三丑不丛业丐且 != 1152921505493696528);
        
        }
        public void add_OnHide(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921543584988824);
        
        }
        public void remove_OnHide(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921543585125400);
        
        }
        public bool get_PossibleBack()
        {
            return (bool)this.<业上东丏不丂丛丐且>k__BackingField;
        }
        public void set_PossibleBack(bool 丙业与丙丗丝不丈东)
        {
            this.<业上东丏不丂丛丐且>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_HideByBack()
        {
            return (bool)this.丘丝世丒三丑七丗七;
        }
        public void set_HideByBack(bool 丙业与丙丗丝不丈东)
        {
            System.IDisposable val_9;
            this.丘丝世丒三丑七丗七 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == false)
            {
                goto label_1;
            }
            
            if(this.丐丆七且丞丏下三丙 == null)
            {
                goto label_2;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_6;
            label_1:
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_11;
            label_6:
            this.丐丆七且丞丏下三丙.Dispose();
            label_2:
            new System.Action() = new System.Action(object:  this, method:  typeof(Rilisoft.ItemViewer).__il2cppRuntimeField_180);
            System.IDisposable val_5 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
            goto label_16;
            label_11:
            this.丐丆七且丞丏下三丙.Dispose();
            val_9 = 0;
            label_16:
            this.丐丆七且丞丏下三丙 = val_9;
        }
        public bool get_DoNotChangeAmbientColor()
        {
            return (bool)this.丅与丂丞丈下丒丘世;
        }
        public void set_DoNotChangeAmbientColor(bool 丙业与丙丗丝不丈东)
        {
            this.丅与丂丞丈下丒丘世 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == false)
            {
                    return;
            }
            
            this.丈世业丆丞丐丈下专();
        }
        private UIBasicSprite 丑世丝世丈世丌丝七()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._itemTexture);
            this._itemTexture = val_1;
            return val_1;
        }
        public static void DevShow(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
        
        }
        internal static Rilisoft.ItemViewer 下与丞三丅丛丄七丕(string 丌丅丕一丛丛丄一万, UnityEngine.Transform 丆丏七丟不丒与七专, Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁, Rilisoft.ItemViewer.丕丈丏丑丌丂且万不 丗丟上上丒丐丗丞丙, bool 丘丙丞丟丂丅丄丟丐 = False, bool 丒不业且丄丅世世下 = False)
        {
            string val_13;
            var val_14;
            var val_15;
            if(丏且丕丄丁丟丆丏丁 == null)
            {
                goto label_1;
            }
            
            if(丏且丕丄丁丟丆丏丁.Record != null)
            {
                    if(丏且丕丄丁丟丆丏丁.Record.东七与与不丅丙上上() == false)
            {
                goto label_4;
            }
            
            }
            
            val_14 = 0;
            goto label_5;
            label_1:
            val_15 = 0;
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_13 = 丏且丕丄丁丟丆丏丁.Id, 丅三丟世下丞丝丙万:  丏且丕丄丁丟丆丏丁.Count, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((丏且丕丄丁丟丆丏丁.Type == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  丏且丕丄丁丟丆丏丁.Type, 丒不业且丄丅世世下:  丒不业且丄丅世世下);
            label_4:
            label_5:
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_13, 丅三丟世下丞丝丙万:  丏且丕丄丁丟丆丏丁.Count, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((丏且丕丄丁丟丆丏丁.Type == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  丏且丕丄丁丟丆丏丁.Type, 丒不业且丄丅世世下:  丒不业且丄丅世世下);
        }
        internal static Rilisoft.ItemViewer 下与丞三丅丛丄七丕(string 丌丅丕一丛丛丄一万, UnityEngine.Transform 丆丏七丟不丒与七专, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, Rilisoft.ItemViewer.丕丈丏丑丌丂且万不 丗丟上上丒丐丗丞丙, bool 丘丙丞丟丂丅丄丟丐 = False, bool 丒不业且丄丅世世下 = False)
        {
            string val_14;
            var val_15;
            var val_16;
            if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  丈丄不七三万丄丁不)) == false)
            {
                goto label_3;
            }
            
            三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
            if(val_3 != null)
            {
                    if(val_3.东七与与不丅丙上上() == false)
            {
                goto label_8;
            }
            
            }
            
            val_15 = 0;
            if(丈丄不七三万丄丁不 == null)
            {
                goto label_9;
            }
            
            label_13:
            val_14 = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_14 = 0.业上丙丞丐丄丆丅七(), 丅三丟世下丞丝丙万:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  丒不业且丄丅世世下);
            label_3:
            val_16 = 0;
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_14, 丅三丟世下丞丝丙万:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  丒不业且丄丅世世下);
            label_8:
            if(丈丄不七三万丄丁不 != null)
            {
                goto label_13;
            }
            
            label_9:
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_14, 丅三丟世下丞丝丙万:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  丒不业且丄丅世世下);
        }
        internal static Rilisoft.ItemViewer 下与丞三丅丛丄七丕(string 丌丅丕一丛丛丄一万, UnityEngine.Transform 丆丏七丟不丒与七专, PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七, Rilisoft.ItemViewer.丕丈丏丑丌丂且万不 丗丟上上丒丐丗丞丙, bool 丘丙丞丟丂丅丄丟丐 = False, bool 业万丒丌丗丄东丁丕 = False, bool 丒不业且丄丅世世下 = False)
        {
            string val_12;
            var val_13;
            var val_14;
            if(下丅丙一丂丗丅丝七 == null)
            {
                goto label_1;
            }
            
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  下丅丙一丂丗丅丝七.业东丅东丌上丗丑不());
            if(val_2 != null)
            {
                    if(val_2.东七与与不丅丙上上() == false)
            {
                goto label_5;
            }
            
            }
            
            val_13 = 0;
            goto label_6;
            label_1:
            val_14 = 0;
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_12 = 下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), 丅三丟世下丞丝丙万:  下丅丙一丂丗丅丝七, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((下丅丙一丂丗丅丝七.不业丙丒丂丞下丆丙() == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  下丅丙一丂丗丅丝七.不业丙丒丂丞下丆丙(), 丒不业且丄丅世世下:  丒不业且丄丅世世下);
            label_5:
            label_6:
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_12, 丅三丟世下丞丝丙万:  下丅丙一丂丗丅丝七, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((下丅丙一丂丗丅丝七.不业丙丒丂丞下丆丙() == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  下丅丙一丂丗丅丝七.不业丙丒丂丞下丆丙(), 丒不业且丄丅世世下:  丒不业且丄丅世世下);
        }
        internal static Rilisoft.ItemViewer 下与丞三丅丛丄七丕(string 丌丅丕一丛丛丄一万, UnityEngine.Transform 丆丏七丟不丒与七专, PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七, Rilisoft.OfferItemType 与丙丆世丘丑丒丌丄, Rilisoft.ItemViewer.丕丈丏丑丌丂且万不 丗丟上上丒丐丗丞丙, bool 丘丙丞丟丂丅丄丟丐 = False, bool 丒不业且丄丅世世下 = False)
        {
            int val_10;
            var val_11;
            var val_12;
            val_10 = 下丅丙一丂丗丅丝七;
            if(val_10 == null)
            {
                goto label_1;
            }
            
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_10.业东丅东丌上丗丑不());
            if(val_2 != null)
            {
                    if(val_2.东七与与不丅丙上上() == false)
            {
                goto label_5;
            }
            
            }
            
            val_11 = 0;
            goto label_6;
            label_1:
            val_12 = 0;
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_10.业上丙丞丐丄丆丅七(), 丅三丟世下丞丝丙万:  val_10 = val_10, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐 = 丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((val_10.不业丙丒丂丞下丆丙() == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  与丙丆世丘丑丒丌丄, 丒不业且丄丅世世下:  丒不业且丄丅世世下);
            label_5:
            label_6:
            return (Rilisoft.ItemViewer)Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万, 丆丏七丟不丒与七专:  丆丏七丟不丒与七专, 丕丁下丌不万丅丞丛:  val_10.业上丙丞丐丄丆丅七(), 丅三丟世下丞丝丙万:  val_10, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 丘丙丞丟丂丅丄丟丐:  丘丙丞丟丂丅丄丟丐, 业万丒丌丗丄东丁丕:  (((val_10.不业丙丒丂丞下丆丙() == 1070) ? 1 : 0) == 0) ? 1 : 0, 与丙丆世丘丑丒丌丄:  与丙丆世丘丑丒丌丄, 丒不业且丄丅世世下:  丒不业且丄丅世世下);
        }
        internal static Rilisoft.ItemViewer 下与丞三丅丛丄七丕(string 丌丅丕一丛丛丄一万, UnityEngine.Transform 丆丏七丟不丒与七专, string 丕丁下丌不万丅丞丛, int 丅三丟世下丞丝丙万 = 0, Rilisoft.ItemViewer.丕丈丏丑丌丂且万不 丗丟上上丒丐丗丞丙, bool 丘丙丞丟丂丅丄丟丐 = False, bool 业万丒丌丗丄东丁丕 = False, Rilisoft.OfferItemType 与丙丆世丘丑丒丌丄 = 0, bool 丒不业且丄丅世世下 = False)
        {
            ShopNGUIController val_48;
            Rilisoft.OfferItemType val_49;
            丕丈丏丑丌丂且万不 val_50;
            var val_51;
            Rilisoft.ItemViewer val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            val_49 = 与丙丆世丘丑丒丌丄;
            val_50 = 丗丟上上丒丐丗丞丙;
            val_51 = 丆丏七丟不丒与七专;
            val_52 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丌丅丕一丛丛丄一万)) == true)
            {
                    return val_52;
            }
            
            val_52 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) == true)
            {
                    return val_52;
            }
            
            val_53 = null;
            val_53 = null;
            val_48 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            val_52 = 0;
            if(val_48 == 0)
            {
                    return val_52;
            }
            
            val_48 = 1152921505493692416;
            val_54 = null;
            if(Rilisoft.ItemViewer.丏三丑丘三丒丙丞且() == false)
            {
                goto label_34;
            }
            
            val_55 = null;
            val_55 = null;
            val_50 = System.Linq.Enumerable.Last<Rilisoft.ItemViewer>(source:  Rilisoft.ItemViewer.丟下丟专丏丘东丁丄);
            if(val_50 == 0)
            {
                goto label_34;
            }
            
            if(丒不业且丄丅世世下 == false)
            {
                goto label_20;
            }
            
            if(val_50 == null)
            {
                goto label_21;
            }
            
            val_50.HideByBack = false;
            goto label_22;
            label_20:
            Rilisoft.ItemViewer.丂七东丌万丞东丐三();
            if(val_50 != null)
            {
                goto label_34;
            }
            
            goto label_34;
            label_21:
            val_50.HideByBack = false;
            label_22:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_50.gameObject, 丏业丟一东丂东丘丛:  false);
            val_48 = val_50.gameObject.transform;
            val_50 = val_48.parent;
            if(val_50 != 0)
            {
                    val_48 = val_50.gameObject;
                UnityEngine.Object val_14 = (val_48.activeInHierarchy != true) ? (val_50) : (val_51);
            }
            
            label_34:
            val_52 = 0;
            if(val_14 == 0)
            {
                    return val_52;
            }
            
            UnityEngine.GameObject val_17 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  丌丅丕一丛丛丄一万));
            val_48 = val_17;
            val_52 = 0;
            if(val_17 == 0)
            {
                    return val_52;
            }
            
            val_48.transform.SetParent(p:  val_14);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
            val_48.transform.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
            val_48.transform.localScale = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.identity;
            val_48.transform.localRotation = new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_25.z, w = val_25.w};
            int val_28 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_48, 不东丛三丂丌丑专丆:  val_14.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            UIPanel val_29 = val_48.GetComponent<UIPanel>();
            val_50 = val_50;
            if(val_29 == 0)
            {
                goto label_62;
            }
            
            val_56 = 0;
            val_57 = 0;
            goto label_68;
            label_74:
            T val_48 = val_14.gameObject.transform.root.gameObject.GetComponentsInChildren<UIPanel>(includeInactive:  true)[0];
            if(val_48.depth > val_57)
            {
                    val_57 = val_48.depth;
            }
            
            val_56 = 1;
            label_68:
            if(val_56 < val_35.Length)
            {
                goto label_74;
            }
            
            val_29.depth = val_57 + 1;
            val_50 = val_50;
            val_49 = 0;
            goto label_77;
            label_87:
            if((val_48.GetComponentsInChildren<UIPanel>(includeInactive:  true)[0]) != val_29)
            {
                    val_39[0x0] + 32.depth = val_29.depth + (val_39[0x0] + 32.depth);
                val_50 = val_50;
            }
            
            val_49 = 1;
            label_77:
            if(val_49 < val_39.Length)
            {
                goto label_87;
            }
            
            label_62:
            val_48 = val_48;
            val_52 = val_48.GetComponent<Rilisoft.ItemViewer>();
            if(val_52 != null)
            {
                    bool val_45 = 丘丙丞丟丂丅丄丟丐;
                val_44.<业上东丏不丂丛丐且>k__BackingField = val_45;
                val_52.HideByBack = val_45;
            }
            else
            {
                    val_44.<业上东丏不丂丛丐且>k__BackingField = 丘丙丞丟丂丅丄丟丐;
                val_48 = val_44.<业上东丏不丂丛丐且>k__BackingField;
                val_52.HideByBack = val_48;
            }
            
            bool val_47 = 业万丒丌丗丄东丁丕;
            Rilisoft.ItemViewer.丁一丈上世专丙下下(丈丗世丗丟丒一丑丐:  val_52);
            if(Rilisoft.ItemViewer.业丄上丅丐丒下丈丞 == null)
            {
                    return val_52;
            }
            
            Rilisoft.ItemViewer.业丄上丅丐丒下丈丞.Invoke();
            return val_52;
        }
        public virtual void SetContent(string 丕丁下丌不万丅丞丛, int 丅三丟世下丞丝丙万, string 丌丅丕一丛丛丄一万, Rilisoft.ItemViewer.丕丈丏丑丌丂且万不 丗丟上上丒丐丗丞丙, bool 业万丒丌丗丄东丁丕, Rilisoft.OfferItemType 与丙丆世丘丑丒丌丄)
        {
            string val_42;
            string val_100;
            string val_101;
            System.Action val_285;
            string val_286;
            object val_287;
            PGCompany.三东丏不丗世丅丌丄 val_288;
            var val_289;
            var val_290;
            Rilisoft.上专业三丟丁丞专下 val_291;
            int val_292;
            var val_293;
            var val_294;
            object val_295;
            bool val_296;
            丕丈丏丑丌丂且万不 val_297;
            var val_298;
            var val_299;
            string val_300;
            var val_301;
            var val_302;
            float val_303;
            var val_304;
            丙且上东下丏丏丟下 val_305;
            var val_306;
            UnityEngine.GameObject val_307;
            UIPanel val_308;
            IntPtr val_310;
            var val_311;
            var val_312;
            var val_313;
            var val_314;
            val_285 = 与丙丆世丘丑丒丌丄;
            val_286 = 丕丁下丌不万丅丞丛;
            val_287 = this;
            if(((System.String.op_Equality(a:  丌丅丕一丛丛丄一万, b:  "NguiWindows/InfoViewBattlePass")) == false) || (PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false))
            {
                goto label_15;
            }
            
            val_288 = 1152921505138155520;
            if((BattlePassRootUI.丑七不且上丗丁一世() == 0) || (BattlePassRootUI.丑七不且上丗丁一世().丂上三丆东七且世一() == 0))
            {
                goto label_15;
            }
            
            bool val_10 = UnityEngine.Object.op_Equality(x:  PGCompany.BattlePass.BPGetRewards.丑七不且上丗丁一世(), y:  0);
            goto label_18;
            label_15:
            label_18:
            三丅丁丗丗丝丂万且 val_11 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_286);
            if(val_11 != null)
            {
                    val_286 = val_11.与不丞丑七丘丁丂丛();
            }
            
            this.丝三业丌丟丁丗丕丞 = val_286;
            if(((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_286)) & 2147483648) == 0)
            {
                    this.与丆万丆上丐不丕丞 = 0;
            }
            
            val_289 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_286);
            val_290 = 0;
            if((val_289 != null) || ((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_286)) != null))
            {
                goto label_87;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_286)) == false)
            {
                goto label_36;
            }
            
            val_288 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_286);
            if((val_288 == null) || (val_288.上专丗丏丛丁专丑丄() == 0))
            {
                goto label_36;
            }
            
            val_289 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_288.上专丗丏丛丁专丑丄().WeaponIndex);
            if(val_289 == null)
            {
                goto label_87;
            }
            
            CategoryNames val_26 = val_289.丒万丕七专不丏丞丌();
            this.与丆万丆上丐不丕丞 = 0;
            val_290 = val_288.丑丐丙丄丅世世丑丒();
            goto label_87;
            label_36:
            val_290 = 0;
            val_289 = 0;
            label_87:
            if(val_285 == 1130)
            {
                goto label_42;
            }
            
            if(val_285 != 1460)
            {
                goto label_90;
            }
            
            val_291 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  180, 丞丅上丏丂且下丅与:  val_286).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  丅三丟世下丞丝丙万);
            if(val_291.丕丐一丙专丛丒丑万() == false)
            {
                goto label_90;
            }
            
            UnityEngine.GameObject val_31 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LootBoxes/Prefabs/UIParts/LootBoxInfo");
            if(val_31 == 0)
            {
                goto label_90;
            }
            
            UnityEngine.GameObject val_34 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_31, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.业丆丌且上东丂东丗(万且万且丑丗且丌丆:  val_34, 丙业与丙丗丝不丈东:  this._baseWindow.GetComponent<UIPanel>().depth);
            if(val_34 == null)
            {
                goto label_54;
            }
            
            val_34.SetActive(value:  true);
            goto label_55;
            label_42:
            Rilisoft.丛且世丐丆上七业丁 val_38 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_38 == null)
            {
                goto label_90;
            }
            
            List.Enumerator<T> val_41 = val_38.丄三丐丟丗丄丟上丞().GetEnumerator();
            val_288 = 1152921540871088400;
            label_65:
            if((327054368 & 1) == 0)
            {
                goto label_63;
            }
            
            val_291 = 0.丐丏七丌丕丗业且上();
            if(val_291.业上丙丞丐丄丆丅七() != (Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  val_286)))
            {
                goto label_65;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_291 == null)
            {
                goto label_90;
            }
            
            UnityEngine.GameObject val_45 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "GameEvents/EventGUI/Chests/chests_info");
            if(val_45 == 0)
            {
                goto label_90;
            }
            
            UnityEngine.GameObject val_48 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_45, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.业丆丌且上东丂东丗(万且万且丑丗且丌丆:  val_48, 丙业与丙丗丝不丈东:  this._baseWindow.GetComponent<UIPanel>().depth);
            Rilisoft.GameEventExtendedEventInfoView val_51 = val_48.GetComponent<Rilisoft.GameEventExtendedEventInfoView>();
            this.丑丏世丆丞丘丆丞丑 = val_51;
            val_51.Show(丐下丝丘丑丟丟丗丌:  val_291, 丁丞丅上丝三丐丅丆:  true);
            this.丑丏世丆丞丘丆丞丑.gameObject.SetActive(value:  true);
            this.丑丏世丆丞丘丆丞丑.Show(丐下丝丘丑丟丟丗丌:  val_291, 丁丞丅上丝三丐丅丆:  true);
            System.Action val_53 = null;
            val_285 = 1152921543587565632;
            val_53 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.丑丏世丆丞丘丆丞丑.remove_OnCloseRequest(丙业与丙丗丝不丈东:  val_53);
            System.Action val_54 = null;
            val_286 = val_54;
            val_54 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.丑丏世丆丞丘丆丞丑.add_OnCloseRequest(丙业与丙丗丝不丈东:  val_54);
            goto label_149;
            label_63:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_90;
            label_54:
            0.SetActive(value:  true);
            label_55:
            LootBoxInfo val_55 = val_34.GetComponent<LootBoxInfo>();
            this.丗丆丕东万且业专业 = val_55;
            val_55.Setup(丈丄不七三万丄丁不:  val_291);
            System.Action val_56 = null;
            val_285 = 1152921543587565632;
            val_56 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.丗丆丕东万且业专业.丒丅与丙七东丅丅丙(丙业与丙丗丝不丈东:  val_56);
            System.Action val_57 = null;
            val_286 = val_57;
            val_57 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.丗丆丕东万且业专业.丐丂与丑丈下不不下(丙业与丙丗丝不丈东:  val_57);
            goto label_149;
            label_90:
            val_291 = this.与丆万丆上丐不丕丞;
            if(((val_291 & 1) == 0) || ((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_291)) == false))
            {
                goto label_94;
            }
            
            丙且上东下丏丏丟下 val_60 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_286, 七丆丒与丗丌丄且丂:  val_291);
            val_291 = 0;
            if(丗丟上上丒丐丗丞丙 == 0)
            {
                goto label_95;
            }
            
            if(val_60 == null)
            {
                goto label_96;
            }
            
            val_60.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  丗丟上上丒丐丗丞丙 + 16);
            val_292 = mem[丗丟上上丒丐丗丞丙 + 24];
            val_292 = 丗丟上上丒丐丗丞丙 + 24;
            goto label_97;
            label_94:
            if(((val_289 != null) && ((val_289.东七与与不丅丙上上() != true) && ((val_291 & 1) != 0))) && ((System.Linq.Enumerable.Contains<CategoryNames>(source:  WeaponManager.万三不丄丈丙与丁不(), value:  val_291)) != false))
            {
                    var val_64 = (0 != 0) ? 1 : 0;
            }
            else
            {
                    val_293 = 0;
            }
            
            val_293 = val_293 & 业万丒丌丗丄东丁丕;
            if(val_293 == false)
            {
                goto label_107;
            }
            
            if(丗丟上上丒丐丗丞丙 == 0)
            {
                goto label_108;
            }
            
            if((丗丟上上丒丐丗丞丙 + 32) == 0)
            {
                    if((丗丟上上丒丐丗丞丙 + 16) == 0)
            {
                goto label_108;
            }
            
            }
            
            label_107:
            if((val_289 == null) || ((val_289.东七与与不丅丙上上() == true) || ((val_291 & 1) == 0)))
            {
                goto label_115;
            }
            
            var val_68 = (0 == 0) ? 1 : 0;
            val_68 = val_68 | 业万丒丌丗丄东丁丕;
            if((val_68 == false) || ((System.Linq.Enumerable.Contains<CategoryNames>(source:  WeaponManager.万三不丄丈丙与丁不(), value:  val_291)) == false))
            {
                goto label_115;
            }
            
            ItemViewer.丏业业丙丏丂专丞丂 val_69 = new ItemViewer.丏业业丙丏丂专丞丂();
            if(业万丒丌丗丄东丁丕 == false)
            {
                goto label_116;
            }
            
            val_294 = 0;
            goto label_117;
            label_115:
            val_288 = 丁下万丟且丟丛下业.一三专丞丒丅上业上();
            if((((val_288.ContainsKey(key:  this.丝三业丌丟丁丗丕丞)) == false) || ((val_291 & 1) == 0)) || ((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_291)) == false))
            {
                goto label_127;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_74 = null;
            val_288 = val_74;
            val_74 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  val_286);
            if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_74)) == false)
            {
                goto label_127;
            }
            
            ItemViewer.万业万七丂丞下丅丄 val_76 = null;
            val_295 = val_76;
            val_76 = new ItemViewer.万业万七丂丞下丅丄();
            if(业万丒丌丗丄东丁丕 == false)
            {
                goto label_128;
            }
            
            val_288 = 0;
            val_296 = 0;
            goto label_129;
            label_127:
            if(((val_291 & 1) == 0) || ((this.与丆万丆上丐不丕丞.HasValue.丙东专丂世丈丏丁丂() != 7) || ((327054408 & 1) == 0)))
            {
                goto label_132;
            }
            
            ItemViewer.东丟世丐丑丈丟丝丌 val_78 = null;
            val_295 = val_78;
            val_78 = new ItemViewer.东丟世丐丑丈丟丝丌();
            if(业万丒丌丗丄东丁丕 == false)
            {
                goto label_133;
            }
            
            val_288 = 0;
            val_297 = 丗丟上上丒丐丗丞丙;
            val_298 = 0;
            goto label_134;
            label_132:
            if(((val_291 & 1) == 0) || ((this.与丆万丆上丐不丕丞.HasValue.丙东专丂世丈丏丁丂() != 25000) || ((327054408 & 1) == 0)))
            {
                goto label_137;
            }
            
            int val_85 = (UnityEngine.LayerMask.NameToLayer(layerName:  "NGUIShopWorld")) | (UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket"));
            UnityEngine.GameObject val_86 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "PetInfoNurseryForEvent"), 丈东丘丏与丌东东下:  this.transform.parent, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.业丆丌且上东丂东丗(万且万且丑丗且丌丆:  val_86, 丙业与丙丗丝不丈东:  200);
            PetInfoController val_87 = val_86.GetComponent<PetInfoController>();
            this.且世丅业且丁上丘丞 = val_87;
            val_87.WasCreated = true;
            this.且世丅业且丁上丘丞.petCamera.depth = 100f;
            this.且世丅业且丁上丘丞.Show(世丐丗专丅三丝丑丆:  val_286, 下丗丐丙丙丞与与三:  0, 上丑七与丗三丐丈丙:  false, 上世丗与丗东三丐丛:  (this.GetComponent<UIPanel>().depth) + 1);
            System.Action val_91 = null;
            val_285 = 1152921543587565632;
            val_91 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.且世丅业且丁上丘丞.丅七丅丐丗丛一丑丁(丙业与丙丗丝不丈东:  val_91);
            System.Action val_92 = null;
            val_286 = val_92;
            val_92 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.且世丅业且丁上丘丞.丘万丟丕业不万丂丁(丙业与丙丗丝不丈东:  val_92);
            goto label_149;
            label_137:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseWindow, 丏业丟一东丂东丘丛:  true);
            if(0 == 0)
            {
                goto label_152;
            }
            
            val_299 = PGCompany.BattlePass.丈东丁一丁丝且丛丗.丟丒上丌不丏丂丑丄(丕丁下丌不万丅丞丛:  val_286, 业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = this.与丆万丆上丐不丕丞.HasValue});
            goto label_153;
            label_108:
            ItemViewer.丁丟丗丁丘丂丞三世 val_94 = null;
            val_291 = val_94;
            val_94 = new ItemViewer.丁丟丗丁丘丂丞三世();
            if(val_289 == null)
            {
                goto label_154;
            }
            
            val_300 = val_289.与不丞丑七丘丁丂丛();
            goto label_155;
            label_152:
            val_299 = 0;
            label_153:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonTransitionContainer, 丏业丟一东丂东丘丛:  false);
            if(this._window != 0)
            {
                    var val_98 = (val_299 != 0) ? this._battlePassWindowY : this._simpleWindowY;
                this._window.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            丒与上丅丒丘与丒丘 val_99 = Rilisoft.ItemViewer.东且丏丆万与东丙万(丕丁下丌不万丅丞丛:  val_286, 丅三丟世下丞丝丙万:  丅三丟世下丞丝丙万);
            if((val_291 & 1) == 0)
            {
                goto label_165;
            }
            
            val_286 = 0;
            goto label_302;
            label_165:
            val_301 = null;
            val_301 = null;
            if((System.String.op_Equality(a:  val_286, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true)
            {
                    if((System.String.op_Equality(a:  val_286, b:  "Gems")) == false)
            {
                goto label_170;
            }
            
            }
            
            UnityEngine.GameObject val_104 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Common/GemsModel");
            label_303:
            val_286 = 0;
            if(val_104 == 0)
            {
                goto label_302;
            }
            
            val_286 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_104, 丈东丘丏与丌东东下:  this._3dItemPreview.gameObject.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            goto label_302;
            label_154:
            val_300 = 0.与不丞丑七丘丁丂丛();
            label_155:
            丙且上东下丏丏丟下 val_112 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_300, 七丆丒与丗丌丄且丂:  val_289.万上丄下业丛丌不丈() - 1);
            if(val_285 == 1340)
            {
                goto label_179;
            }
            
            val_302 = 0;
            if(val_285 == 1310)
            {
                    val_112.丅丟业下与丏专万且(丙业与丙丗丝不丈东:  丅三丟世下丞丝丙万);
            }
            
            if(0 == 0)
            {
                goto label_182;
            }
            
            label_188:
            PGCompany.三东丏不丗世丅丌丄 val_114 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_286);
            val_114.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丅三丟世下丞丝丙万);
            val_286 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丟丝世万东万丆丟上>(丈丄不七三万丄丁不:  val_114);
            if(val_302 != 0)
            {
                goto label_185;
            }
            
            goto label_239;
            label_179:
            val_302 = 0;
            val_112.丄七丙丙丝东丆丄下(丙业与丙丗丝不丈东:  丅三丟世下丞丝丙万);
            if(0 != 0)
            {
                goto label_188;
            }
            
            label_182:
            val_286 = 0;
            if(val_302 == 0)
            {
                goto label_239;
            }
            
            label_185:
            if(val_112 == null)
            {
                goto label_190;
            }
            
            val_112.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  11993091);
            val_112.与丐丘丌丁丗丞丄丑(丙业与丙丗丝不丈东:  28563616);
            goto label_191;
            label_96:
            val_60.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  丗丟上上丒丐丗丞丙 + 16);
            val_292 = mem[丗丟上上丒丐丗丞丙 + 24];
            val_292 = 丗丟上上丒丐丗丞丙 + 24;
            label_97:
            val_60.与丐丘丌丁丗丞丄丑(丙业与丙丗丝不丈东:  val_292);
            label_95:
            UnityEngine.Object val_117 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "ArmoryInfoScreenForEvent"));
            if(val_117 != null)
            {
                    var val_118 = (null == null) ? (val_117) : 0;
            }
            
            ArmoryInfoScreenController val_119 = 0.GetComponent<ArmoryInfoScreenController>();
            this.下丏丗且丅丟丄丂与 = val_119;
            val_119.transform.parent = this.transform.parent;
            UnityEngine.Vector3 val_124 = UnityEngine.Vector3.zero;
            val_303 = val_124.x;
            this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_303, y = val_124.y, z = val_124.z};
            this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            .丛丘下丗业丂一且业 = this.GetComponent<UIPanel>();
            UIPanel val_135 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIPanel>(丄三丅七丆丛与与上:  this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>(), 七丐丅专且专七三丆:  new System.Action<UIPanel>(object:  new ItemViewer.世丈丛丒丆丕丗不丒(), method:  System.Void ItemViewer.世丈丛丒丆丕丗不丒::丛丌专丅丛丝丁丗丟(UIPanel 七丏丄丅丌业与且丙)));
            this.下丏丗且丅丟丄丂与.上丕丆丒世丒丞丗丞();
            this.下丏丗且丅丟丄丂与.丙业丁丅丗万丞丙且 = true;
            this.下丏丗且丅丟丄丂与.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_60, 丁业丗丈丂七丟东与:  true, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
            System.Action val_136 = null;
            val_288 = 1152921543587565632;
            val_136 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.下丏丗且丅丟丄丂与.丅七丅丐丗丛一丑丁(丙业与丙丗丝不丈东:  val_136);
            System.Action val_137 = null;
            val_285 = val_137;
            val_137 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.下丏丗且丅丟丄丂与.丘万丟丕业不万丂丁(丙业与丙丗丝不丈东:  val_137);
            if(val_291 != 0)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_139 = null;
                val_285 = val_139;
                val_139 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_286);
                val_139.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丅三丟世下丞丝丙万);
                val_286 = this.下丏丗且丅丟丄丂与;
                val_286.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丟丝世万东万丆丟上>(丈丄不七三万丄丁不:  val_139));
            }
            
            val_304 = null;
            goto label_224;
            label_133:
            val_297 = 0;
            val_288 = 0;
            label_134:
            ArmoryInfoScreenController.丘万丕丟丄丂丁东丈(丙业与丙丗丝不丈东:  ((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  this.丝三业丌丟丁丗丕丞))) < 1) ? 1 : 0);
            丙且上东下丏丏丟下 val_145 = null;
            val_305 = val_145;
            val_145 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_286, 七丆丒与丗丌丄且丂:  val_291);
            if(val_297 != 0)
            {
                    val_145.与丐丘丌丁丗丞丄丑(丙业与丙丗丝不丈东:  28563616);
            }
            
            UnityEngine.GameObject val_147 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "ArmoryInfoScreenForEvent"));
            if(val_147 == null)
            {
                goto label_234;
            }
            
            ArmoryInfoScreenController val_148 = val_147.GetComponent<ArmoryInfoScreenController>();
            val_306 = val_287;
            this.下丏丗且丅丟丄丂与 = val_148;
            if(val_148 != null)
            {
                goto label_235;
            }
            
            goto label_236;
            label_190:
            val_112.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  11993091);
            val_112.与丐丘丌丁丗丞丄丑(丙业与丙丗丝不丈东:  28563616);
            label_191:
            if(64 == 0)
            {
                goto label_237;
            }
            
            if(val_112 != null)
            {
                goto label_280;
            }
            
            label_281:
            label_280:
            val_112.丄七丙丙丝东丆丄下(丙业与丙丗丝不丈东:  64 + val_112.丝七丘丏丂丂丏上且());
            if(135970152 != 0)
            {
                    val_286 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丈丄不七三万丄丁不:  135970152);
            }
            
            label_239:
            UnityEngine.Object val_154 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "ArmoryInfoScreenForSkinsEvent"));
            if(val_154 != null)
            {
                    var val_155 = (null == null) ? (val_154) : 0;
            }
            
            ArmoryInfoScreenController val_156 = 0.GetComponent<ArmoryInfoScreenController>();
            this.下丏丗且丅丟丄丂与 = val_156;
            val_156.transform.parent = this.transform.parent;
            UnityEngine.Vector3 val_161 = UnityEngine.Vector3.zero;
            val_303 = val_161.x;
            this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_303, y = val_161.y, z = val_161.z};
            this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            .丛丘下丗业丂一且业 = this.GetComponent<UIPanel>();
            System.Action<UIPanel> val_171 = null;
            label_450:
            val_171 = new System.Action<UIPanel>(object:  val_94, method:  System.Void ItemViewer.丁丟丗丁丘丂丞三世::丝上上一丟世业且丞(UIPanel 七丏丄丅丌业与且丙));
            UIPanel val_172 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIPanel>(丄三丅七丆丛与与上:  this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>(), 七丐丅专且专七三丆:  val_171);
            this.下丏丗且丅丟丄丂与.上丕丆丒世丒丞丗丞();
            this.下丏丗且丅丟丄丂与.丙业丁丅丗万丞丙且 = true;
            if(val_286 == null)
            {
                goto label_266;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_174 = val_286.丑丐丙丄丅世世丑丒();
            if(val_174 == null)
            {
                goto label_267;
            }
            
            if(this.下丏丗且丅丟丄丂与 != null)
            {
                goto label_278;
            }
            
            label_279:
            label_278:
            this.下丏丗且丅丟丄丂与.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_112, 丁业丗丈丂七丟东与:  (val_286 != 0) ? 1 : 0, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  val_174.业上丙丞丐丄丆丅七(), 丝丞丄丝一丞丗丄丛:  0);
            val_285 = 1152921504615739392;
            System.Action val_176 = null;
            val_288 = 1152921543587565632;
            val_176 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.下丏丗且丅丟丄丂与.丅七丅丐丗丛一丑丁(丙业与丙丗丝不丈东:  val_176);
            this.下丏丗且丅丟丄丂与.丘万丟丕业不万丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专()));
            if(val_286 != null)
            {
                    this.下丏丗且丅丟丄丂与.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  val_286);
            }
            
            val_304 = null;
            label_224:
            val_287 = this._baseWindow;
            val_307 = val_287;
            goto label_275;
            label_266:
            if(this.下丏丗且丅丟丄丂与 != null)
            {
                goto label_278;
            }
            
            goto label_279;
            label_267:
            if(this.下丏丗且丅丟丄丂与 != null)
            {
                goto label_278;
            }
            
            goto label_279;
            label_237:
            if(val_112 != null)
            {
                goto label_280;
            }
            
            goto label_281;
            label_234:
            val_306 = val_287;
            this.下丏丗且丅丟丄丂与 = 0;
            label_236:
            label_235:
            0.transform.parent = this.transform.parent;
            UnityEngine.Vector3 val_182 = UnityEngine.Vector3.zero;
            val_303 = val_182.x;
            this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_303, y = val_182.y, z = val_182.z};
            this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            .丛丘下丗业丂一且业 = this.GetComponent<UIPanel>();
            val_308 = this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>();
            val_310 = 1152921543588206960;
            goto label_299;
            label_170:
            val_311 = null;
            val_311 = null;
            val_286 = 0;
            if((System.String.op_Equality(a:  val_286, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_302;
            }
            
            UnityEngine.GameObject val_193 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Common/GoldModel");
            goto label_303;
            label_302:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._headerText.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  0f))) & 1);
            this._headerText.Text = 0f;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemNameText.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_100))) & 1);
            val_291 = 1152921504848912384;
            this._itemNameText.Text = val_100;
            val_288 = this._itemSubNameLabel;
            val_312 = 1152921505284374528;
            if(val_288 != 0)
            {
                    val_288 = this._itemSubNameLabel.gameObject;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_101)) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_288, 丏业丟一东丂东丘丛:  false);
                val_312 = 1152921505284374528;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_288, 丏业丟一东丂东丘丛:  true);
                val_288 = this._itemSubNameLabel;
                val_312 = 1152921505284374528;
                val_288.text = val_101;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemDescriptionLabel.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_42))) & 1);
            this._itemDescriptionLabel.text = val_42;
            if((val_285 == 65) && (this._skinPreview != 0))
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._skinPreview, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丑世丝世丈世丌丝七().gameObject, 丏业丟一东丂东丘丛:  false);
                this._skinPreview.GetComponent<UnityEngine.MeshRenderer>().material.mainTexture = 0;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._skinPreview, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丑世丝世丈世丌丝七().gameObject, 丏业丟一东丂东丘丛:  true);
                UnityEngine.Object val_283 = 0;
                val_283 = UnityEngine.Object.op_Inequality(x:  0, y:  val_283);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丑世丝世丈世丌丝七().gameObject, 丏业丟一东丂东丘丛:  val_283);
                UIBasicSprite val_216 = this.丑世丝世丈世丌丝七();
            }
            
            if(this._3dItemPreview != 0)
            {
                    UnityEngine.Object val_284 = 0;
                val_284 = UnityEngine.Object.op_Inequality(x:  val_286, y:  val_284);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._3dItemPreview.gameObject, 丏业丟一东丂东丘丛:  val_284);
                if(this._3dItemPreview.model != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._3dItemPreview.model.gameObject);
                this._3dItemPreview.model = 0;
            }
            
                if(val_286 != 0)
            {
                    this._3dItemPreview.model = val_286.transform;
                this._3dItemPreview.SetSelected(丏丈丞丙七丛东七丌:  true, 东丝三一丞下业丂丝:  false);
            }
            
            }
            
            if(this._buttonTransitionLabel == 0)
            {
                    return;
            }
            
            val_287 = PGCompany.BattlePass.世下东丌三专上下万.世不丙丌下上丁且万(丕丁下丌不万丅丞丛:  this.丝三业丌丟丁丗丕丞, 业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = this.与丆万丆上丐不丕丞});
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._buttonTransitionLabel, 丕丗丘丑丛与丑业丒:  val_287);
            return;
            label_116:
            label_117:
            ArmoryInfoScreenController.丘万丕丟丄丂丁东丈(丙业与丙丗丝不丈东:  ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_289.业东丅东丌上丗丑不())) == 0) ? 1 : 0);
            丙且上东下丏丏丟下 val_233 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_289.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_289.万上丄下业丛丌不丈() - 1);
            if(val_285 == 1340)
            {
                goto label_375;
            }
            
            val_313 = 0;
            if(val_285 != 1310)
            {
                goto label_376;
            }
            
            val_233.丅丟业下与丏专万且(丙业与丙丗丝不丈东:  丅三丟世下丞丝丙万);
            if(0 != 0)
            {
                goto label_378;
            }
            
            goto label_391;
            label_128:
            val_288 = 0;
            val_296 = (~(Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  val_286))) & 1;
            label_129:
            ArmoryInfoScreenController.丘万丕丟丄丂丁东丈(丙业与丙丗丝不丈东:  val_296);
            丙且上东下丏丏丟下 val_236 = null;
            val_305 = val_236;
            val_236 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_286, 七丆丒与丗丌丄且丂:  val_291);
            if(0 != 0)
            {
                    val_236.与丐丘丌丁丗丞丄丑(丙业与丙丗丝不丈东:  28563616);
            }
            
            UnityEngine.GameObject val_238 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "ArmoryInfoScreenForEvent"));
            if(val_238 == null)
            {
                goto label_387;
            }
            
            ArmoryInfoScreenController val_239 = val_238.GetComponent<ArmoryInfoScreenController>();
            val_306 = val_287;
            this.下丏丗且丅丟丄丂与 = val_239;
            if(val_239 != null)
            {
                goto label_388;
            }
            
            goto label_389;
            label_375:
            val_313 = 0;
            val_233.丄七丙丙丝东丆丄下(丙业与丙丗丝不丈东:  丅三丟世下丞丝丙万);
            label_376:
            if(0 == 0)
            {
                goto label_391;
            }
            
            label_378:
            PGCompany.三东丏不丗世丅丌丄 val_241 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_286);
            val_241.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丅三丟世下丞丝丙万);
            PGCompany.丟丝世万东万丆丟上 val_242 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丟丝世万东万丆丟上>(丈丄不七三万丄丁不:  val_241);
            if(val_313 != 0)
            {
                goto label_394;
            }
            
            goto label_425;
            label_391:
            if(val_313 == 0)
            {
                goto label_425;
            }
            
            label_394:
            if(val_233 == null)
            {
                goto label_397;
            }
            
            val_233.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  11993091);
            val_233.与丐丘丌丁丗丞丄丑(丙业与丙丗丝不丈东:  28563616);
            goto label_398;
            label_387:
            val_306 = val_287;
            this.下丏丗且丅丟丄丂与 = 0;
            label_389:
            label_388:
            0.transform.parent = this.transform.parent;
            UnityEngine.Vector3 val_247 = UnityEngine.Vector3.zero;
            val_303 = val_247.x;
            this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_303, y = val_247.y, z = val_247.z};
            this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            .丛丘下丗业丂一且业 = this.GetComponent<UIPanel>();
            val_308 = this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>();
            System.Action<UIPanel> val_257 = null;
            val_310 = 1152921543588486624;
            label_299:
            val_257 = new System.Action<UIPanel>(object:  val_76, method:  val_310);
            UIPanel val_258 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIPanel>(丄三丅七丆丛与与上:  val_308, 七丐丅专且专七三丆:  val_257);
            this.下丏丗且丅丟丄丂与.上丕丆丒世丒丞丗丞();
            mem[74] = 1;
            this.下丏丗且丅丟丄丂与.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_236, 丁业丗丈丂七丟东与:  true, 下丗丐丙丙丞与与三:  val_288, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
            System.Action val_259 = null;
            val_285 = 1152921543587565632;
            val_259 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.下丏丗且丅丟丄丂与.丅七丅丐丗丛一丑丁(丙业与丙丗丝不丈东:  val_259);
            System.Action val_260 = null;
            val_286 = val_260;
            val_260 = new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专());
            this.下丏丗且丅丟丄丂与.丘万丟丕业不万丂丁(丙业与丙丗丝不丈东:  val_260);
            label_149:
            val_307 = this._baseWindow;
            label_275:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_307, 丏业丟一东丂东丘丛:  false);
            return;
            label_397:
            val_233.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  11993091);
            val_233.与丐丘丌丁丗丞丄丑(丙业与丙丗丝不丈东:  28563616);
            label_398:
            if(64 == 0)
            {
                goto label_421;
            }
            
            val_314 = 64;
            if(val_233 != null)
            {
                goto label_424;
            }
            
            goto label_423;
            label_421:
            val_314 = 0;
            if(val_233 != null)
            {
                goto label_424;
            }
            
            label_423:
            label_424:
            val_233.丄七丙丙丝东丆丄下(丙业与丙丗丝不丈东:  val_314 + val_233.丝七丘丏丂丂丏上且());
            if(135970152 != 0)
            {
                    PGCompany.丟丝世万东万丆丟上 val_264 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丈丄不七三万丄丁不:  135970152);
            }
            
            label_425:
            UnityEngine.Object val_266 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "ArmoryInfoScreenForEvent"));
            if(val_266 != null)
            {
                    var val_267 = (null == null) ? (val_266) : 0;
            }
            
            ArmoryInfoScreenController val_268 = 0.GetComponent<ArmoryInfoScreenController>();
            this.下丏丗且丅丟丄丂与 = val_268;
            val_268.transform.parent = this.transform.parent;
            UnityEngine.Vector3 val_273 = UnityEngine.Vector3.zero;
            this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_273.x, y = val_273.y, z = val_273.z};
            this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            .丛丘下丗业丂一且业 = this.GetComponent<UIPanel>();
            UIPanel val_282 = this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>();
            goto label_450;
        }
        private void 丐且丈专业丝上丞专()
        {
            goto typeof(Rilisoft.ItemViewer).__il2cppRuntimeField_178;
        }
        public void UI_Move()
        {
            PGCompany.BattlePass.世下东丌三专上下万.下丏且一三丐一丐不(丕丁下丌不万丅丞丛:  this.丝三业丌丟丁丗丕丞, 业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = this.与丆万丆上丐不丕丞});
        }
        internal static Rilisoft.ItemViewer.丒与上丅丒丘与丒丘 东且丏丆万与东丙万(string 丕丁下丌不万丅丞丛, int 丅三丟世下丞丝丙万 = 1)
        {
            int val_246;
            string val_247;
            string val_249;
            PGCompany.丐且与丆世丘丟丏丘 val_250;
            var val_251;
            var val_252;
            string val_253;
            string val_255;
            var val_256;
            var val_257;
            var val_258;
            var val_259;
            string val_260;
            string val_261;
            var val_263;
            CategoryNames val_264;
            var val_265;
            string val_266;
            var val_268;
            string val_269;
            var val_271;
            var val_272;
            var val_274;
            string val_276;
            var val_277;
            var val_278;
            var val_279;
            var val_282;
            var val_284;
            object val_285;
            丒与上丅丒丘与丒丘 val_0;
            val_246 = 丅三丟世下丞丝丙万;
            UnityEngine.Texture2D val_108 = 0;
            ItemViewer.丑丆丟丈上与丁丕下 val_1 = new ItemViewer.丑丆丟丈上与丁丕下();
            if(val_1 != null)
            {
                    val_247 = val_1;
                .丕丁下丌不万丅丞丛 = 丕丁下丌不万丅丞丛;
            }
            else
            {
                    val_247 = 16;
                mem[16] = 丕丁下丌不万丅丞丛;
            }
            
            if(((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_247)) & 2147483648) == 0)
            {
                
            }
            
            if(( & 1) == 0)
            {
                goto label_7;
            }
            
            if(( & 1) == 0)
            {
                goto label_203;
            }
            
            int val_3 = 0.丙东专丂世丈丏丁丂();
            if(val_3 <= 30000)
            {
                goto label_9;
            }
            
            if(val_3 <= 180000)
            {
                goto label_10;
            }
            
            if(val_3 <= 200000)
            {
                goto label_11;
            }
            
            if(val_3 == 210000)
            {
                goto label_12;
            }
            
            if(val_3 != 250000)
            {
                goto label_203;
            }
            
            val_249 = mem[16];
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  val_249)) == false)
            {
                goto label_203;
            }
            
            val_249 = mem[16];
            val_250 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丘三丏丌丗丒万丏丈>(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  val_249);
            string val_8 = val_250.丐丞丐丝下上上丐丂();
            if(val_250 != null)
            {
                goto label_21;
            }
            
            goto label_21;
            label_7:
            val_249 = 1152921505171275776;
            val_251 = null;
            val_251 = null;
            if((System.String.op_Equality(a:  mem[16], b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true)
            {
                    if((System.String.op_Equality(a:  mem[16], b:  "Gems")) == false)
            {
                goto label_27;
            }
            
            }
            
            string val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0951");
            string val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1836");
            string val_15 = System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0951"));
            val_252 = null;
            val_252 = null;
            val_253 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            goto label_36;
            label_9:
            if(val_3 <= 12500)
            {
                goto label_37;
            }
            
            if(val_3 <= 13500)
            {
                goto label_38;
            }
            
            if(val_3 == 25000)
            {
                goto label_39;
            }
            
            if(val_3 != 30000)
            {
                goto label_203;
            }
            
            string val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2684");
            val_255 = "Key_3397";
            goto label_199;
            label_27:
            val_256 = null;
            val_256 = null;
            if((System.String.op_Equality(a:  mem[16], b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_47;
            }
            
            string val_18 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0950");
            string val_19 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1835");
            string val_22 = System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0275"));
            val_257 = null;
            val_257 = null;
            val_253 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            label_36:
            label_365:
            label_353:
            UnityEngine.Texture val_24 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  Rilisoft.ItemViewer.丙不丒丒且世丆下丐(丏丂不专上丘丂不丅:  val_253, 丌丒丝东丌下丕丁丅:  val_246));
            goto label_480;
            label_10:
            if(val_3 <= 160000)
            {
                goto label_56;
            }
            
            if(val_3 == 170000)
            {
                goto label_57;
            }
            
            if(val_3 != 180000)
            {
                goto label_203;
            }
            
            string val_25 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5555");
            val_255 = "Key_5532";
            goto label_199;
            label_37:
            if(val_3 <= 2000)
            {
                goto label_62;
            }
            
            if(val_3 == 2100)
            {
                goto label_63;
            }
            
            val_258 = 12500;
            goto label_64;
            label_47:
            if((System.Linq.Enumerable.Any<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean ItemViewer.丑丆丟丈上与丁丕下::世丆业下丛丝丏丁丕(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)))) == false)
            {
                goto label_66;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_33 = System.Linq.Enumerable.First<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean ItemViewer.丑丆丟丈上与丁丕下::丑丝业丂丆万专丄丞(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
            string val_34 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3502");
            string val_35 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3398");
            string val_38 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_33.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
            string val_39 = val_33.丙三专万丛丟万丝丘();
            goto label_365;
            label_11:
            if(val_3 == 190000)
            {
                goto label_74;
            }
            
            if(val_3 != 200000)
            {
                goto label_203;
            }
            
            string val_40 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5555");
            val_255 = "Key_5609";
            goto label_199;
            label_38:
            if(val_3 == 13000)
            {
                goto label_79;
            }
            
            val_258 = 13500;
            label_64:
            if(val_3 != 13500)
            {
                goto label_203;
            }
            
            label_79:
            string val_41 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2197");
            val_255 = "Key_2694";
            goto label_199;
            label_56:
            if(val_3 == 150000)
            {
                goto label_84;
            }
            
            if(val_3 != 160000)
            {
                goto label_203;
            }
            
            string val_42 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7582");
            val_255 = "Key_7583";
            goto label_199;
            label_62:
            if(val_3 > 12)
            {
                goto label_89;
            }
            
            var val_246 = 106030140 + (val_3) << 2;
            val_246 = val_246 + 106030140;
            goto (106030140 + (val_3) << 2 + 106030140);
            label_66:
            val_249 = mem[16].IndexOf(value:  "weapon-upgrade_");
            if((val_249 & 2147483648) != 0)
            {
                goto label_101;
            }
            
            val_246 = 1152921504624312320;
            System.Nullable<T> val_47 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  mem[16].Replace(oldValue:  "weapon-upgrade_", newValue:  System.String.alignConst), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if((329476696 & 1) == 0)
            {
                goto label_480;
            }
            
            string val_49 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3804"), arg0:  System.String.alignConst);
            label_394:
            val_260 = "Key_3805";
            goto label_122;
            label_63:
            string val_50 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0429");
            val_255 = "Key_1830";
            goto label_199;
            label_101:
            val_249 = 1152921505317388288;
            if((Rilisoft.PetsManager.丌丈万丆一丒不世三(世丐丗专丅三丝丑丆:  mem[16])) == false)
            {
                goto label_114;
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  mem[16])) == null)
            {
                goto label_480;
            }
            
            string val_54 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2595");
            string val_56 = System.String.Format(format:  "{0} x{1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_53.Lkey), arg1:  val_246);
            UnityEngine.Texture val_57 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_53.Id, 七丆丒与丗丌丄且丂:  168, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            val_260 = "Key_3811";
            goto label_122;
            label_12:
            string val_58 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7580");
            val_255 = "Key_7581";
            goto label_199;
            label_39:
            string val_59 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2595");
            val_255 = "Key_3539";
            goto label_199;
            label_57:
            val_259 = null;
            string val_60 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5555");
            val_255 = "Key_5531";
            goto label_199;
            label_74:
            string val_61 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5555");
            val_255 = "Key_5533";
            goto label_199;
            label_84:
            val_249 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  46, 丞丅上丏丂且下丅与:  mem[16]);
            if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_249)) == false)
            {
                goto label_138;
            }
            
            string val_64 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  mem[16], 七丆丒与丗丌丄且丂:  0);
            val_261 = "Parts_Description_" + mem[16];
            goto label_145;
            label_114:
            val_249 = Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  mem[16]);
            if(val_249 == false)
            {
                goto label_150;
            }
            
            丞东丌丟与丅丅万丝 val_67 = Rilisoft.FortsManager.丅丁专丘丛丝丆丙丘(丞丅上丏丂且下丅与:  mem[16]);
            if(val_67 == null)
            {
                goto label_480;
            }
            
            string val_68 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4190");
            if(val_246 >= 2)
            {
                goto label_156;
            }
            
            string val_69 = val_67.东丙上东业丆不丟丘();
            goto label_157;
            label_138:
            if(val_246 < 2)
            {
                goto label_203;
            }
            
            string val_70 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  mem[16], 七丆丒与丗丌丄且丂:  0);
            val_261 = "Key_4575";
            label_145:
            string val_71 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_261);
            val_249 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4726");
            string val_73 = System.String.Format(format:  val_249, arg0:  val_246);
            goto label_203;
            label_89:
            if(val_3 != 2000)
            {
                goto label_203;
            }
            
            string val_75 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2452");
            val_255 = "Key_2473";
            goto label_199;
            label_150:
            val_249 = mem[16].IndexOf(value:  "WU_");
            if(val_249 == 0)
            {
                goto label_174;
            }
            
            if((System.String.op_Equality(a:  mem[16], b:  "BattlePassCurrency")) == false)
            {
                goto label_175;
            }
            
            UnityEngine.Texture val_78 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/bp_currency_1");
            label_327:
            val_260 = "Key_5775";
            label_122:
            label_301:
            string val_82 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_260);
            goto label_480;
            label_21:
            val_263 = ;
            goto label_196;
            label_199:
            label_196:
            label_203:
            if(mem[16] == 8)
            {
                goto label_206;
            }
            
            if(mem[16] == 2000)
            {
                goto label_207;
            }
            
            if(mem[16] != 25000)
            {
                goto label_208;
            }
            
            val_246 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            val_249 = mem[16];
            if((val_246.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_249)) == null)
            {
                goto label_261;
            }
            
            val_246 = val_95.Id;
            val_264 = 25000;
            goto label_214;
            label_207:
            val_246 = mem[16];
            val_264 = 2000;
            label_214:
            val_265 = 1;
            val_266 = val_246;
            goto label_218;
            label_206:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  65, 丞丅上丏丂且下丅与:  mem[16])) == false)
            {
                goto label_224;
            }
            
            val_246 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_249 = mem[16];
            if((val_246.一丌世丑丄东丞丘三<PGCompany.丐且与丆世丘丟丏丘>(丁丅丈丌丟世丗丗丟:  65, 丞丅上丏丂且下丅与:  val_249)) == null)
            {
                goto label_224;
            }
            
            goto label_225;
            label_208:
            val_246 = mem[16];
            val_249 = mem[16];
            val_265 = 1;
            val_266 = val_246;
            val_264 = val_249;
            label_218:
            UnityEngine.Texture val_100 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_266, 七丆丒与丗丌丄且丂:  val_264, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            label_225:
            label_261:
            if(mem[16] <= 2000)
            {
                goto label_229;
            }
            
            if(mem[16] == 250000)
            {
                goto label_230;
            }
            
            if(mem[16] == 30000)
            {
                goto label_231;
            }
            
            if(mem[16] != 25000)
            {
                goto label_238;
            }
            
            val_246 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            if((val_246.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  mem[16])) == null)
            {
                goto label_480;
            }
            
            val_268 = 1152921505072021504;
            val_269 = val_102.Lkey;
            goto label_236;
            label_229:
            if(mem[16] == 8)
            {
                goto label_237;
            }
            
            if(mem[16] != 2000)
            {
                goto label_238;
            }
            
            if((Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  mem[16])) == null)
            {
                goto label_480;
            }
            
            val_268 = 1152921505072021504;
            val_269 = val_103.Lkey;
            label_236:
            string val_104 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_269);
            goto label_290;
            label_238:
            val_246 = System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5772"));
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_246)) == false)
            {
                goto label_480;
            }
            
            val_246 = mem[16];
            string val_106 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  mem[16], 七丆丒与丗丌丄且丂:  val_246);
            goto label_290;
            label_224:
            if((SkinsController.三不丛丏丟业丆一专(且丘世丏丛丛万丟万:  mem[16])) == false)
            {
                goto label_261;
            }
            
            val_271 = null;
            val_271 = null;
            bool val_109 = SkinsController.与业七丙三三万丕上.TryGetValue(key:  mem[16], value: out  val_108);
            goto label_261;
            label_237:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  65, 丞丅上丏丂且下丅与:  mem[16])) == false)
            {
                goto label_264;
            }
            
            val_246 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_272 = 65;
            if((val_246.一丌世丑丄东丞丘三<PGCompany.丐且与丆世丘丟丏丘>(丁丅丈丌丟世丗丗丟:  65, 丞丅上丏丂且下丅与:  mem[16])) != null)
            {
                goto label_267;
            }
            
            label_264:
            val_246 = mem[16];
            if((SkinsController.三不丛丏丟业丆一专(且丘世丏丛丛万丟万:  val_246)) == false)
            {
                goto label_480;
            }
            
            val_274 = null;
            val_274 = null;
            val_246 = SkinsController.丛上不下丐丐丞丒专;
            bool val_116 = val_246.TryGetValue(key:  mem[16], value: out  0);
            goto label_480;
            label_231:
            val_246 = PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑().Values;
            System.Func<PGCompany.丑丝丟与丘丐丏上三, System.Boolean> val_119 = new System.Func<PGCompany.丑丝丟与丘丐丏上三, System.Boolean>(object:  val_1, method:  System.Boolean ItemViewer.丑丆丟丈上与丁丕下::丅丘丐丙丒七丑不万(PGCompany.丑丝丟与丘丐丏上三 三万万丒丏丒不丐丙));
            PGCompany.丑丝丟与丘丐丏上三 val_120 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丑丝丟与丘丐丏上三>(source:  val_246, predicate:  null);
            if(val_120 == null)
            {
                goto label_480;
            }
            
            string val_121 = val_120.丄丁下丑丛丗丁不丛();
            if(val_121 == null)
            {
                goto label_480;
            }
            
            string val_122 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_121);
            goto label_290;
            label_230:
            val_246 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_246.丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  mem[16])) == false)
            {
                goto label_480;
            }
            
            val_246 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_272 = 1470;
            PGCompany.丘三丏丌丗丒万丏丈 val_126 = val_246.一丌世丑丄东丞丘三<PGCompany.丘三丏丌丗丒万丏丈>(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  mem[16]);
            if(val_126 == null)
            {
                goto label_290;
            }
            
            label_267:
            string val_127 = val_126.七业丑不七丐业丟丂();
            label_290:
            label_480:
            val_0.丑丕丐丄世丒丞丐丌 = 0;
            val_0.与万丆丛丒万丝丙丑 = val_108;
            val_0.丞丟丂丄下万丈万东 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null);
            return val_0;
            label_174:
            System.Nullable<T> val_129 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  mem[16].Replace(oldValue:  "WU_", newValue:  System.String.alignConst), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
            if((329476688 & 1) == 0)
            {
                goto label_480;
            }
            
            string val_132 = System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246), arg1:  上丑三丁丄丛丁万丑.丝且丙东丄丒丗业丕(丟丆丏且专不丕上专:  val_129.HasValue));
            UnityEngine.Texture val_133 = 上丑三丁丄丛丁万丑.且上丁丅七丟三丙一(丟丆丏且专不丕上专:  val_129.HasValue);
            goto label_301;
            label_156:
            string val_135 = System.String.Format(format:  "{0} {1}", arg0:  val_246, arg1:  val_67.东丙上东业丆不丟丘());
            label_157:
            string val_136 = val_67.丒丗丝不丕丈世丏丞();
            UnityEngine.Texture val_137 = val_67.丆下世世丟七专丞丒();
            string val_139 = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_67.七东与丄丕丁丛世三());
            goto label_480;
            label_175:
            if((System.String.op_Equality(a:  mem[16], b:  "Coupons")) == false)
            {
                goto label_306;
            }
            
            string val_144 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246)) + " " + PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丑丕丙丅丈丈丘丄>(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  mem[16])(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丑丕丙丅丈丈丘丄>(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  mem[16]));
            goto label_480;
            label_306:
            if((System.String.op_Equality(a:  mem[16], b:  "BattlePassExp")) == false)
            {
                goto label_315;
            }
            
            UnityEngine.Texture val_146 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/crown_icon");
            string val_149 = System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5773"));
            goto label_327;
            label_315:
            if((System.String.op_Equality(a:  mem[16], b:  "BattlePassLevel")) == false)
            {
                goto label_322;
            }
            
            string val_153 = System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5774"));
            goto label_327;
            label_322:
            if((System.String.op_Equality(a:  mem[16], b:  "vipInSeconds")) != true)
            {
                    if((System.String.op_Equality(a:  mem[16], b:  "VIPseconds")) == false)
            {
                goto label_331;
            }
            
            }
            
            UnityEngine.Texture val_156 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/MiniOfferIcons/offer_icon_VIP");
            System.TimeSpan val_157 = System.TimeSpan.FromSeconds(value:  (double)val_246);
            if((int)val_157._ticks.TotalHours == (4.94065645841247E-324))
            {
                    val_276 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4074");
                val_277 = null;
            }
            else
            {
                    if(((int)val_157._ticks.TotalHours - 2) > (1.03753785626662E-322))
            {
                    uint32_t val_161 = System.TimeSpan.__il2cppRuntimeField_cctor_finished >> 63;
                System.TimeSpan.__il2cppRuntimeField_cctor_finished = System.TimeSpan.__il2cppRuntimeField_cctor_finished >> 34;
            }
            
                val_276 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4075");
                val_277 = null;
            }
            
            string val_165 = System.String.Format(format:  val_276, arg0:  (int)val_157._ticks.TotalHours);
            string val_166 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4053");
            goto label_394;
            label_331:
            if((System.String.op_Equality(a:  mem[16], b:  "EventCurrency")) == false)
            {
                goto label_346;
            }
            
            val_278 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_278 != null)
            {
                goto label_350;
            }
            
            val_279 = null;
            string val_170 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null);
            string val_172 = System.String.Format(format:  "{0} {1}", arg0:  val_246, arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3411"));
            string val_173 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3432");
            goto label_353;
            label_346:
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(丟丟丄专上丟丁丐丝:  mem[16])) == null)
            {
                goto label_358;
            }
            
            val_278 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_278 == null)
            {
                goto label_480;
            }
            
            label_350:
            string val_179 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_278.丟万丏且上业丐丈一());
            string val_182 = System.String.Format(format:  "{0} {1}", arg0:  val_246, arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_278.丟万丏且上业丐丈一()));
            string val_184 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_278.不丅且万丐专丄丌丂());
            string val_185 = val_278.丐丙丁一丅丞不丅丟(丑丏万丈丟丝丝丌丗:  val_246);
            goto label_365;
            label_358:
            if((Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  mem[16])) < 1)
            {
                goto label_374;
            }
            
            int val_189 = Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  mem[16]);
            UnityEngine.Texture val_190 = Rilisoft.上专业三丟丁丞专下.丑东丐下专丞丕丘世(且东与丞丗与与与专:  mem[16]);
            if(val_246 >= 2)
            {
                    string val_193 = System.String.Format(format:  "{0} {1}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_246), arg1:  Rilisoft.上专业三丟丁丞专下.丄丅三丛丙万丆业业(丐东业丕丕丂丗丅丙:  val_189));
            }
            
            string val_194 = Rilisoft.上专业三丟丁丞专下.丞丙且丘三一万丄丁(丐东业丕丕丂丗丅丙:  val_189);
            goto label_480;
            label_374:
            if((System.String.op_Equality(a:  mem[16], b:  "armor")) == false)
            {
                goto label_387;
            }
            
            UnityEngine.Texture val_196 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  mem[16], 七丆丒与丗丌丄且丂:  7, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            string val_197 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  mem[16], 七丆丒与丗丌丄且丂:  7);
            string val_198 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0428");
            goto label_394;
            label_387:
            if((Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丒丘世丄丟丌且且专(丕且丏丞业业一上丕:  mem[16])) == false)
            {
                goto label_397;
            }
            
            PGCompany.丏丂一丗丙世丏丐三 val_202 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丏丂一丗丙世丏丐三>(丁丅丈丌丟世丗丗丟:  126, 丞丅上丏丂且下丅与:  mem[16]);
            if(val_202 == null)
            {
                goto label_480;
            }
            
            if(val_246 >= 2)
            {
                    string val_204 = System.String.Format(format:  "{0} x{1}", arg0:  val_202.七业丑不七丐业丟丂(), arg1:  val_246);
            }
            
            string val_207 = val_202.世世上丕不丑丅七丆() + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7326")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7326"));
            goto label_480;
            label_397:
            if((丐东不丅丂丂丅丙不.丈丆上丅丏丟东万丞(丞丅上丏丂且下丅与:  mem[16])) == false)
            {
                goto label_408;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_210 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  mem[16]);
            if(val_210 == null)
            {
                goto label_480;
            }
            
            if(val_246 >= 2)
            {
                    string val_211 = System.String.Format(format:  "{0} x{1}", arg0:  val_210, arg1:  val_246);
            }
            
            string val_212 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "ModuleChest_Tutorial");
            goto label_480;
            label_408:
            if((System.String.op_Equality(a:  mem[16], b:  "CraftCurrency")) == false)
            {
                goto label_417;
            }
            
            Rilisoft.OfferItem val_214 = Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  116, 丞丅上丏丂且下丅与:  0, 丌丒丝东丌下丕丁丅:  val_246);
            if(val_214 == null)
            {
                goto label_480;
            }
            
            string val_215 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7143");
            string val_216 = val_214.Name;
            string val_217 = val_214.Description;
            UnityEngine.Texture val_218 = val_214.Texture;
            goto label_480;
            label_417:
            if((PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().且丄丑丆丝丐丕丕丗(丞一丁业丄一一业且:  mem[16], 丁丅丈丌丟世丗丗丟:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false})) == false)
            {
                goto label_480;
            }
            
            System.Collections.Generic.List<System.Int32> val_222 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().上且万东丑与丐丘下(丞一丁业丄一一业且:  mem[16]);
            if(val_222.Count >= 2)
            {
                    UnityEngine.Debug.LogError(message:  "item with id \'" + mem[16] + "\' not found");
            }
            
            if(val_222.Count < 1)
            {
                goto label_480;
            }
            
            PGCompany.丙万丙下三下丄丌丄 val_228 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  val_222.Item[0]);
            if(val_228 == null)
            {
                goto label_448;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_231 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  val_228.不业丙丒丂丞下丆丙(), 丞丅上丏丂且下丅与:  val_228.业上丙丞丐丄丆丅七());
            val_231.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_246);
            PGCompany.丗丟丄丈东丝丕丄世 val_232 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_231);
            if(val_232 == null)
            {
                goto label_448;
            }
            
            if(null == null)
            {
                goto label_449;
            }
            
            val_232.丑丐丙丄丅世世丑丒().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_246);
            val_282 = val_232;
            if(null != null)
            {
                goto label_451;
            }
            
            val_284 = 0;
            if(val_232.不一丆丑业且丆丙三() == null)
            {
                goto label_452;
            }
            
            label_451:
            label_452:
            val_285 = val_232;
            if(val_232 >= 2)
            {
                    val_285 = System.String.Format(format:  "{0} {1}", arg0:  val_285, arg1:  val_232);
            }
            
            if((System.String.op_Equality(a:  mem[16], b:  "Vip20")) == false)
            {
                goto label_480;
            }
            
            string val_238 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10641"), arg0:  val_232);
            goto label_480;
            label_448:
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "item for index \'{0}\' not found", arg0:  val_222.Item[0]));
            goto label_480;
            label_449:
            if((PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_232.上专丗丏丛丁专丑丄().WeaponIndex))) == null)
            {
                goto label_480;
            }
            
            goto label_480;
        }
        internal static bool 万不一一七世丂不不(out Rilisoft.ItemViewer 丆丏万丐丕丒丌东丐)
        {
            null = null;
            Rilisoft.ItemViewer val_1 = System.Linq.Enumerable.LastOrDefault<Rilisoft.ItemViewer>(source:  Rilisoft.ItemViewer.丟下丟专丏丘东丁丄);
            丆丏万丐丕丒丌东丐 = val_1;
            return UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
        }
        private static string 丙不丒丒且世丆下丐(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)
        {
            var val_5 = null;
            return (string)System.String.Format(format:  "{0}{1}", arg0:  ((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true) ? "Textures/Bank/Coins_Shop_Gem_" : "Textures/Bank/Coins_Shop_", arg1:  UnityEngine.Mathf.Clamp(value:  丌丒丝东丌下丕丁丅, min:  1, max:  7));
        }
        public virtual void Hide()
        {
            var val_18;
            System.Action val_19;
            var val_20;
            var val_21;
            bool val_22;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
                this.丐丆七且丞丏下三丙 = 0;
            }
            
            if(this.下丏丗且丅丟丄丂与 != 0)
            {
                    this.下丏丗且丅丟丄丂与.丅七丅丐丗丛一丑丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专()));
                this.下丏丗且丅丟丄丂与.Close();
                this.下丏丗且丅丟丄丂与 = 0;
            }
            
            if(this.且世丅业且丁上丘丞 != 0)
            {
                    this.且世丅业且丁上丘丞.丅七丅丐丗丛一丑丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专()));
                this.且世丅业且丁上丘丞.Close();
                this.且世丅业且丁上丘丞 = 0;
            }
            
            if(this.丑丏世丆丞丘丆丞丑 != 0)
            {
                    this.丑丏世丆丞丘丆丞丑.remove_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专()));
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丑丏世丆丞丘丆丞丑, 丏业丟一东丂东丘丛:  false);
                UnityEngine.Object.Destroy(obj:  this.丑丏世丆丞丘丆丞丑);
                this.丑丏世丆丞丘丆丞丑 = 0;
            }
            
            if(this.丗丆丕东万且业专业 != 0)
            {
                    this.丗丆丕东万且业专业.丒丅与丙七东丅丅丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丐且丈专业丝上丞专()));
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丗丆丕东万且业专业, 丏业丟一东丂东丘丛:  false);
                UnityEngine.Object.Destroy(obj:  this.丗丆丕东万且业专业);
                this.丗丆丕东万且业专业 = 0;
            }
            
            if(this._3dItemPreview != 0)
            {
                    if(this._3dItemPreview.model != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._3dItemPreview.model.gameObject);
                this._3dItemPreview.model = 0;
            }
            
            }
            
            Rilisoft.ItemViewer.丂七东丌万丞东丐三();
            if(this.丛丄业丘不丆丄三丞 != null)
            {
                    this.丛丄业丘不丆丄三丞.Invoke();
            }
            
            val_18 = null;
            val_18 = null;
            val_19 = Rilisoft.ItemViewer.丒丂三丑不丛业丐且;
            if(val_19 != null)
            {
                    val_19 = Rilisoft.ItemViewer.丒丂三丑不丛业丐且;
                if(val_19 == null)
            {
                    val_19 = 0;
            }
            
                val_19.Invoke();
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            val_20 = null;
            val_20 = null;
            if((System.Linq.Enumerable.Any<Rilisoft.ItemViewer>(source:  Rilisoft.ItemViewer.丟下丟专丏丘东丁丄)) == false)
            {
                    return;
            }
            
            val_21 = null;
            val_21 = null;
            Rilisoft.ItemViewer val_15 = System.Linq.Enumerable.Last<Rilisoft.ItemViewer>(source:  Rilisoft.ItemViewer.丟下丟专丏丘东丁丄);
            if(val_15 != null)
            {
                    val_22 = val_15.<业上东丏不丂丛丐且>k__BackingField;
            }
            else
            {
                    val_22 = val_15.<业上东丏不丂丛丐且>k__BackingField;
            }
            
            val_15.HideByBack = (val_22 == true) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_15, 丏业丟一东丂东丘丛:  true);
        }
        private void OnEnable()
        {
            this.丗与业东一不业丈丄();
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void Rilisoft.ItemViewer::丂丞丟丝丆丅丕丐上()));
        }
        private void 丂丞丟丝丆丅丕丐上()
        {
            if(this.丅与丂丞丈下丒丘世 != false)
            {
                    return;
            }
            
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.一丆丛丑与上丝世东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.上丝丙丛下不一丘下(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        }
        private void 丗与业东一不业丈丄()
        {
            UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.业三不丈丌丗丙丆丞();
            this.万丞丞丄丄不丐丛丗 = val_1;
            mem[1152921543592882836] = val_1.g;
            mem[1152921543592882840] = val_1.b;
            mem[1152921543592882844] = val_1.a;
            UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.丗丙丟丂且丂丗业世();
            this.丟且丐丂丂三下丒专 = val_2;
            mem[1152921543592882852] = val_2.g;
            mem[1152921543592882856] = val_2.b;
            mem[1152921543592882860] = val_2.a;
            UnityEngine.Color val_3 = PGCompany.丟丝世世且丗丈丈丞.丄丐丒丆与丅不丗不();
            this.丆丙丅丅东且万一丄 = val_3;
            mem[1152921543592882868] = val_3.g;
            mem[1152921543592882872] = val_3.b;
            mem[1152921543592882876] = val_3.a;
            this.丄丛丏东丝丐丑且一 = true;
            if(this.丅与丂丞丈下丒丘世 != false)
            {
                    return;
            }
            
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.一丆丛丑与上丝世东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.上丝丙丛下不一丘下(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        }
        private void OnDisable()
        {
            this.丈世业丆丞丐丈下专();
        }
        private void OnDestroy()
        {
            this.丈世业丆丞丐丈下专();
        }
        private void 丈世业丆丞丐丈下专()
        {
            if(this.丄丛丏东丝丐丑且一 == false)
            {
                    return;
            }
            
            PGCompany.丟丝世世且丗丈丈丞.一丆丛丑与上丝世东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.万丞丞丄丄不丐丛丗});
            PGCompany.丟丝世世且丗丈丈丞.上丝丙丛下不一丘下(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丟且丐丂丂三下丒专});
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丆丙丅丅东且万一丄});
            this.丄丛丏东丝丐丑且一 = false;
        }
        public ItemViewer()
        {
            this._simpleWindowY = 24f;
            this._battlePassWindowY = 55.5f;
        }
        private static ItemViewer()
        {
            Rilisoft.ItemViewer.丟下丟专丏丘东丁丄 = new System.Collections.Generic.List<Rilisoft.ItemViewer>();
        }
    
    }

}
