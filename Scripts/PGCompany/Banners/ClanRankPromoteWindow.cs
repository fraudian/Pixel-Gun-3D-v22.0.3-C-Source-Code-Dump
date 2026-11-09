using UnityEngine;

namespace PGCompany.Banners
{
    internal class ClanRankPromoteWindow : BannerWindow
    {
        // Fields
        private UnityEngine.Animator animator;
        private ClanRankScrollElementView scrollElementPrefab;
        private ScrollViewHelper scrollHelper;
        private WidgetLayout widgetLayout;
        private UILabel totalExpLabel;
        private UnityEngine.GameObject blockerObject;
        private UnityEngine.GameObject listOfActionsWindow;
        private UnityEngine.GameObject actualWindow;
        private UnityEngine.Transform listOfActionsGrid;
        private ClanRankAction prefabActionListItem;
        private UISprite oldRankSprite;
        private UISprite newRankSprite;
        private UILabel newRankLabel;
        private string 丏丌与一丐东一万丑;
        private string 丏丗下丂与丅丑丒丁;
        private float 万丅且丆丅丙丏丘丁;
        private float 东丙丝一丙一丝丏世;
        private float 七一丕上丆且丂七三;
        private static bool <与丅七丐丑一专专丞>k__BackingField;
        private static bool <丗东丗丗丑丆丛丒且>k__BackingField;
        private ClanRankScrollElementView[] 万与丞七业业东丝丌;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private static 丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 丂万丝丟丏丅丒业丛;
        private static bool 丏丕丁丑七丕丛丑丌;
        private bool 丗丈丂与不专丂丕万;
        private bool 丞七世丒丞丗丞世丑;
        private bool 丙丈专丛丕丑一丐丗;
        
        // Properties
        internal static bool 且丈丌丁且丗不万下 { get; set; }
        internal static bool 丄丟万七上丄丒且丝 { get; set; }
        
        // Methods
        internal static bool 世下且丒丒三丝丏与()
        {
            null = null;
            return (bool)PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField;
        }
        internal static void 且东丞三丘业丟七丑(bool 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丟丅专与丘丞丕业丁()
        {
            null = null;
            return (bool)PGCompany.Banners.ClanRankPromoteWindow.<丗东丗丗丑丆丛丒且>k__BackingField;
        }
        internal static void 且丞丗不下丗丌与专(bool 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.Banners.ClanRankPromoteWindow.<丗东丗丗丑丆丛丒且>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected override void Awake()
        {
            int val_1 = 丌丅且丗七丘丅丛丑.丅不不丝不不丒下丂();
            this.万与丞七业业东丝丌 = new ClanRankScrollElementView[0];
            int val_3 = 丌丅且丗七丘丅丛丑.丅不不丝不不丒下丂();
            if(val_3 <= 0)
            {
                goto label_3;
            }
            
            label_19:
            ClanRankScrollElementView val_5 = UnityEngine.Object.Instantiate<ClanRankScrollElementView>(original:  this.scrollElementPrefab, parent:  this.widgetLayout.transform);
            int val_6 = 0 + 1;
            val_5.丈且东丑丂且万丒丅(专世专丟丝丌与丘上:  丌丅且丗七丘丅丛丑.丄专丆业世专丕专与(专世专丟丝丌与丘上:  val_6), 丈东丘丏与丌东东下:  this.transform);
            val_5.name = System.String.Format(format:  "Rank{0}", arg0:  val_6);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
            if(this.万与丞七业业东丝丌 == null)
            {
                goto label_13;
            }
            
            if(val_5 != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(val_5 == null)
            {
                goto label_17;
            }
            
            label_14:
            label_17:
            this.万与丞七业业东丝丌[0] = val_5;
            if(val_3 != val_6)
            {
                goto label_19;
            }
            
            label_3:
            this.widgetLayout.CollectWidgets();
            this.widgetLayout.Reposition();
        }
        internal static void 与丏不丂专丕丁世丐(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 与上丟丏业专业与专)
        {
            var val_1;
            var val_6;
            if(与上丟丏业专业与专.丒丗丝七丛丟专丄丂 == 与上丟丏业专业与专.世丛丘丙世丝丟一丂)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            if(PGCompany.Banners.ClanRankPromoteWindow.丏丕丁丑七丕丛丑丌 != false)
            {
                
            }
            else
            {
                    PGCompany.Banners.ClanRankPromoteWindow.丂万丝丟丏丅丒业丛 = 与上丟丏业专业与专.丒丗丝七丛丟专丄丂;
                PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField.__il2cppRuntimeField_8 = 与上丟丏业专业与专.且丅七丏业丛丙丟下;
                PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField.__il2cppRuntimeField_C = 与上丟丏业专业与专.世丛丘丙世丝丟一丂;
                PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField.__il2cppRuntimeField_10 = 与上丟丏业专业与专.丟专丙丐专世丁与一;
            }
            
            val_6 = null;
            val_6 = null;
            PGCompany.Banners.ClanRankPromoteWindow.丏丕丁丑七丕丛丑丌 = true;
        }
        public override void HideSelf()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.actualWindow, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.listOfActionsWindow, 丏业丟一东丂东丘丛:  false);
            this.HideSelf();
        }
        protected override void OnEnable()
        {
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            string val_21;
            var val_22;
            UnityEngine.GameObject val_23;
            this.OnEnable();
            new System.Action() = new System.Action(object:  this, method:  typeof(PGCompany.Banners.ClanRankPromoteWindow).__il2cppRuntimeField_210);
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "ClanRankPromoteWindow");
            val_17 = null;
            val_17 = null;
            if(PGCompany.Banners.ClanRankPromoteWindow.丏丕丁丑七丕丛丑丌 != true)
            {
                    val_18 = null;
                val_18 = null;
                PGCompany.Banners.ClanRankPromoteWindow.丂万丝丟丏丅丒业丛 = 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与();
                PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField.__il2cppRuntimeField_8 = 丌丅且丗七丘丅丛丑.丛丏丒业丂丅丂丕丐();
                PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField.__il2cppRuntimeField_C = 0;
                val_17 = null;
            }
            
            val_17 = null;
            val_19 = 0;
            PGCompany.Banners.ClanRankPromoteWindow.丏丕丁丑七丕丛丑丌 = false;
            goto label_14;
            label_19:
            ClanRankScrollElementView val_17 = this.万与丞七业业东丝丌[0];
            if(val_17 != null)
            {
                    val_17.丛七丝不一与与丙东();
            }
            else
            {
                    0.丛七丝不一与与丙东();
            }
            
            val_17.上与丟丗一上丛丌专();
            val_19 = 1;
            label_14:
            if(val_19 < this.万与丞七业业东丝丌.Length)
            {
                goto label_19;
            }
            
            val_20 = null;
            val_20 = null;
            if(0 > PGCompany.Banners.ClanRankPromoteWindow.丂万丝丟丏丅丒业丛)
            {
                    if(PGCompany.Banners.ClanRankPromoteWindow.丟丅专与丘丞丕业丁() != false)
            {
                    this.丞七世丒丞丗丞世丑 = true;
            }
            else
            {
                    this.一万东丝且丕七丏丕();
            }
            
            }
            
            val_21 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8765"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌丅且丗七丘丅丛丑.丛丏丒业丂丅丂丕丐()));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.totalExpLabel, 丕丗丘丑丛与丑业丒:  val_21);
            val_22 = null;
            if(PGCompany.Banners.ClanRankPromoteWindow.丟丅专与丘丞丕业丁() != false)
            {
                    var val_18 = -8589934592;
                val_18 = val_18 + ((this.万与丞七业业东丝丌.Length) << 32);
                this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  this.万与丞七业业东丝丌[val_18 >> 32].transform, 丌与丟丁万丝丞丄丏:  false);
                this.scrollHelper.下一专业丞万丒丝不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Banners.ClanRankPromoteWindow::丐万丆东丙与与丂丂()));
                System.Action val_15 = null;
                val_21 = val_15;
                val_15 = new System.Action(object:  this, method:  System.Void PGCompany.Banners.ClanRankPromoteWindow::丐万丆东丙与与丂丂());
                this.scrollHelper.丞且丐丂丞丆三丈丌(丙业与丙丗丝不丈东:  val_15);
                val_23 = this.blockerObject;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23, 丏业丟一东丂东丘丛:  true);
            }
            else
            {
                    val_23 = this.三丘丈上丌不七丙三();
                this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  val_23, 丌与丟丁万丝丞丄丏:  false);
            }
            
            this.scrollHelper.丞丂丘丂丙丌上丘丝(丐丛丄三丈丆业七不:  false);
        }
        private void 一万东丝且丕七丏丕()
        {
            null = null;
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.oldRankSprite, 万丑丞一丝丌丐丒丘:  丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  PGCompany.Banners.ClanRankPromoteWindow.丂万丝丟丏丅丒业丛));
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.newRankSprite, 万丑丞一丝丌丐丒丘:  丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField.__il2cppRuntimeField_C>>0&0xFFFFFFFF));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.newRankLabel, 丕丗丘丑丛与丑业丒:  丌丅且丗七丘丅丛丑.丌丂丄丆专丄丞万丅(专世专丟丝丌与丘上:  PGCompany.Banners.ClanRankPromoteWindow.<与丅七丐丑一专专丞>k__BackingField.__il2cppRuntimeField_C>>0&0xFFFFFFFF));
            UnityEngine.Coroutine val_5 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.Banners.ClanRankPromoteWindow::丏不丁与丐丗丙丂三()));
        }
        private void 丐万丆东丙与与丂丂()
        {
            this.scrollHelper.下一专业丞万丒丝不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.Banners.ClanRankPromoteWindow::丐万丆东丙与与丂丂()));
            丌丅且丗七丘丅丛丑.三业丛丁丌与丆上丄();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blockerObject, 丏业丟一东丂东丘丛:  false);
            if(this.丞七世丒丞丗丞世丑 == false)
            {
                    return;
            }
            
            this.丞七世丒丞丗丞世丑 = false;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丌专丝丂业丞丈丒丈(丞下万上三丘上与专:  this.三丘丈上丌不七丙三(), 丆丐七丅丆丗丛上与:  0.1f, 丌与丟丁万丝丞丄丏:  false));
            this.一万东丝且丕七丏丕();
        }
        private UnityEngine.Transform 三丘丈上丌不七丙三()
        {
            ClanRankScrollElementView val_5 = this.万与丞七业业东丝丌[(long)UnityEngine.Mathf.Clamp(value:  丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与() - 1, min:  1, max:  this.万与丞七业业东丝丌.Length - 2)];
            if(val_5 != null)
            {
                    return val_5.transform;
            }
            
            return val_5.transform;
        }
        protected override void OnDisable()
        {
            var val_3;
            this.丑丂丒上东丙丟丕三();
            this.scrollHelper.StopSmoothScroll();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blockerObject, 丏业丟一东丂东丘丛:  false);
            this.blockerObject.丞丂丘丂丙丌上丘丝(丐丛丄三丈丆业七不:  true);
            this.OnDisable();
            val_3 = null;
            if(PGCompany.Banners.ClanRankPromoteWindow.世下且丒丒三丝丏与() == false)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            this.scrollHelper.StopSmoothScroll();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.blockerObject, 丏业丟一东丂东丘丛:  false);
        }
        public void OnIntroEnded()
        {
            var val_5 = null;
            if(PGCompany.Banners.ClanRankPromoteWindow.丟丅专与丘丞丕业丁() == false)
            {
                    return;
            }
            
            this.scrollHelper.smoothScrollParam = this.万丅且丆丅丙丏丘丁;
            this.scrollHelper.smoothScrollEpsilon = this.东丙丝一丙一丝丏世;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丌专丝丂业丞丈丒丈(丞下万上三丘上与专:  this.万与丞七业业东丝丌[1].transform, 丆丐七丅丆丗丛上与:  this.七一丕上丆且丂七三, 丌与丟丁万丝丞丄丏:  true));
        }
        public void OnListTaskClicked()
        {
            var val_22;
            var val_23;
            var val_26;
            var val_27;
            string val_28;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.actualWindow, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.listOfActionsWindow, 丏业丟一东丂东丘丛:  true);
            if(this.listOfActionsGrid == 0)
            {
                goto label_5;
            }
            
            val_22 = 0;
            goto label_6;
            label_12:
            UnityEngine.Object.Destroy(obj:  this.listOfActionsGrid.GetChild(index:  0).gameObject);
            val_22 = 1;
            label_6:
            if(val_22 < this.listOfActionsGrid.childCount)
            {
                goto label_12;
            }
            
            label_5:
            val_23 = null;
            val_23 = null;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, System.Int32>> val_5 = GetEnumerator();
            label_52:
            var val_24 = 0;
            val_24 = val_24 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_22;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            T val_9 = val_5.Current;
            val_26 = null;
            val_26 = null;
            if((丌丅且丗七丘丅丛丑.与三丗丏丘丆一丑丘.ContainsKey(key:  val_9.丐丏七丌丕丗业且上())) != false)
            {
                    val_27 = null;
                val_27 = null;
                val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丌丅且丗七丘丅丛丑.与三丗丏丘丆一丑丘.Item[val_9.丐丏七丌丕丗业且上()]);
            }
            else
            {
                    val_28 = "ERROR: Key not presented for this value!";
            }
            
            val_29 = ;
            if((val_9.丐丏七丌丕丗业且上().Contains(value:  "craft_speed_up")) == false)
            {
                goto label_39;
            }
            
            val_30 = null;
            val_30 = null;
            val_29 = 丌丅且丗七丘丅丛丑.丂丐丝丏且世与且丄;
            goto label_46;
            label_39:
            if((val_9.丐丏七丌丕丗业且上().Contains(value:  "fort_parts_buy")) == true)
            {
                goto label_44;
            }
            
            if((val_9.丐丏七丌丕丗业且上().Contains(value:  "tank_parts_buy")) == false)
            {
                goto label_46;
            }
            
            label_44:
            val_31 = null;
            val_31 = null;
            val_29 = 丌丅且丗七丘丅丛丑.丈丌下丅不丆且丘专;
            label_46:
            UnityEngine.Object.Instantiate<ClanRankAction>(original:  this.prefabActionListItem, parent:  this.listOfActionsGrid).丘上丐世丆丑且丞丒(与丌丞丞丅丒丟一一:  val_28, 下丅丙丐丟万世丂丘:  val_29);
            goto label_52;
            label_22:
            val_32 = 0;
            val_33 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_5.Dispose();
            }
            
            if((this.listOfActionsGrid.GetComponent<UITable>()) != null)
            {
                    return;
            }
        
        }
        public void OnBackListTaskClicked()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.actualWindow, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.listOfActionsWindow, 丏业丟一东丂东丘丛:  false);
        }
        public void OnPromoEnded()
        {
            this.丗丈丂与不专丂丕万 = false;
        }
        private System.Collections.IEnumerator 丌专丝丂业丞丈丒丈(UnityEngine.Transform 丞下万上三丘上与专, float 丆丐七丅丆丗丛上与, bool 丌与丟丁万丝丞丄丏 = False)
        {
            ClanRankPromoteWindow.丁与丁丙丈丅丙一丒 val_1 = new ClanRankPromoteWindow.丁与丁丙丈丅丙一丒();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丞下万上三丘上与专 = 丞下万上三丘上与专;
                .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
            }
            else
            {
                    mem[40] = this;
                mem[48] = 丞下万上三丘上与专;
                mem[32] = 丆丐七丅丆丗丛上与;
            }
            
            .丌与丟丁万丝丞丄丏 = 丌与丟丁万丝丞丄丏;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丑丂丒上东丙丟丕三()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        private void 丞丂丘丂丙丌上丘丝(bool 丐丛丄三丈丆业七不)
        {
            if(PGCompany.GestureInstance.丟专丙丄业一丒丙丘 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  PGCompany.GestureInstance.丟专丙丄业一丒丙丘.gameObject, 丏业丟一东丂东丘丛:  丐丛丄三丈丆业七不);
        }
        public void U_Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.actualWindow, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.listOfActionsWindow, 丏业丟一东丂东丘丛:  false);
            if(this.丗丈丂与不专丂丕万 != false)
            {
                    this.animator.SetTrigger(name:  this.丏丗下丂与丅丑丒丁);
                this.丗丈丂与不专丂丕万 = false;
                return;
            }
            
            this.丑丂丒上东丙丟丕三();
            goto typeof(PGCompany.Banners.ClanRankPromoteWindow).__il2cppRuntimeField_208;
        }
        public ClanRankPromoteWindow()
        {
            this.丏丌与一丐东一万丑 = "SetPromote";
            this.丏丗下丂与丅丑丒丁 = "StopPromote";
            this.万丅且丆丅丙丏丘丁 = 0.5f;
            this.东丙丝一丙一丝丏世 = 7.346868E-41f;
            this.七一丕上丆且丂七三 = 1.2f;
        }
        private static ClanRankPromoteWindow()
        {
        
        }
        private void 丏不丁与丐丗丙丂三()
        {
            this.animator.ResetTrigger(name:  this.丏丗下丂与丅丑丒丁);
            this.animator.SetTrigger(name:  this.丏丌与一丐东一万丑);
            this.丗丈丂与不专丂丕万 = true;
        }
    
    }

}
