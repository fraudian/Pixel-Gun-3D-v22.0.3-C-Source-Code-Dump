using UnityEngine;

namespace Rilisoft
{
    public class Scroll3dOfferItemCellView : BaseOfferItemCellView
    {
        // Fields
        private const float 丝业丏丄且丌业世丛 = 1.34;
        private const float 丕丏且且丘丙丞丏下 = 0.8;
        private UnityEngine.Transform _body;
        private UnityEngine.Transform _centerObject;
        private Rilisoft.ButtonHandler _clickHandler;
        private UnityEngine.GameObject _modelHandler;
        private UIPanel 丗丒丟下丕丆丗丆丈;
        private UnityEngine.AnimationCurve _scaleCurve;
        private UIWidget _sizeBounds;
        private UIBasicSprite _texture;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        protected override Rilisoft.ButtonHandler 东丐业丘丝丙丆丛丁 { get; }
        private UIPanel 丆丐且丛丒三丗三世 { get; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        protected override Rilisoft.ButtonHandler 丗一丂丏业丅丟丟丞()
        {
            return (Rilisoft.ButtonHandler)this._clickHandler;
        }
        private UIPanel 专丘东丁丆与丒世丝()
        {
            UIPanel val_4;
            if(this.丗丒丟下丕丆丗丆丈 == 0)
            {
                    this.丗丒丟下丕丆丗丆丈 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject);
                return val_4;
            }
            
            val_4 = this.丗丒丟下丕丆丗丆丈;
            return val_4;
        }
        public override void Set(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, System.Action<Rilisoft.BaseOfferItemCellView> 万且丆丈万下不东七)
        {
            System.Action<Rilisoft.BaseOfferItemCellView> val_23 = 万且丆丈万下不东七;
            this.Set(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 万且丆丈万下不东七:  val_23 = 万且丆丈万下不东七);
            if(this.Item == null)
            {
                    return;
            }
            
            if(this.Item.Type == 10)
            {
                    label_10:
                this.丘万东下丌丁不丁专();
                this.丄下丛且丁丅丆丏丛();
                return;
            }
            
            if(this.Item.Type == 1070)
            {
                    if((WeaponManager.丐上业丐丏丐万世丑().Contains(item:  this.Item.Id)) == true)
            {
                goto label_10;
            }
            
            }
            
            if(this.Item.Type != 1010)
            {
                    if(this.Item.Type != 1000)
            {
                goto label_14;
            }
            
            }
            
            this.丘万东下丌丁不丁专();
            this._modelHandler.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_23 = this.Item;
            Rilisoft.BaseOfferPackDrawer.且丑专业上三丌东东(丁丅丈丌丟世丗丗丟:  this.Item.Type, 丌丒丝东丌下丕丁丅:  val_23.Count, 东丙丑万下丁丅一万:  this._modelHandler, 丆一丆七丕丑丛世东:  30f);
            return;
            label_14:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丆下世世丟七专丞丒().gameObject, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._modelHandler, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Texture val_22 = 下丅丙一丂丗丅丝七.Texture;
            if(this.丆下世世丟七专丞丒() == null)
            {
                
            }
        
        }
        protected override void Update()
        {
            float val_11;
            this.Update();
            if(this.专丘东丁丆与丒世丝() == 0)
            {
                    return;
            }
            
            bool val_4 = this.专丘东丁丆与丒世丝().IsVisible(与丘东下丈东丛丂万:  this._sizeBounds);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body.gameObject, 丏业丟一东丂东丘丛:  val_4);
            if(val_4 == false)
            {
                    return;
            }
            
            UnityEngine.Bounds val_9 = 万丗丅且丄丑世专与.与丙丛丞丈业世丒丁(丄上七丟不丗丕下丟:  this.专丘东丁丆与丒世丝().transform, 一丐丂丘专丅丟丞七:  true);
            float val_19 = 0.5f;
            UnityEngine.Vector3 val_14 = this.gameObject.transform.position;
            val_19 = val_11 * val_19;
            UnityEngine.Vector3 val_15 = this._centerObject.position;
            val_15.x = val_14.x - val_15.x;
            float val_20 = System.Math.Abs(val_15.x);
            val_20 = val_20 / val_19;
            this = this._body;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  this._scaleCurve.Evaluate(time:  System.Math.Abs(val_20)));
            this.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        }
        public override void SetSelected(bool 丞丈丌且东丆丅丗万)
        {
            丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
            this.SetSelected(丞丈丌且东丆丅丗万:  丞丈丌且东丆丅丗万);
            if(this.Item == null)
            {
                    return;
            }
            
            if(this.Item.Type != 10)
            {
                    if(this.Item.Type != 1070)
            {
                    return;
            }
            
            }
            
            if(丞丈丌且东丆丅丗万 != false)
            {
                    if(this._modelHandler.transform.childCount < 1)
            {
                    return;
            }
            
            }
            
            this._modelHandler.GetComponent<ItemPreviewInArmoryInfoScreen>().enabled = 丞丈丌且东丆丅丗万;
        }
        private void 丘万东下丌丁不丁专()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丆下世世丟七专丞丒().gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._modelHandler, 丏业丟一东丂东丘丛:  true);
            goto label_4;
            label_12:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._modelHandler.transform.GetChild(index:  0).gameObject);
            label_4:
            if(this._modelHandler.transform.childCount > 0)
            {
                goto label_12;
            }
        
        }
        private void 丄下丛且丁丅丆丏丛()
        {
            UnityEngine.GameObject val_24;
            var val_25;
            UnityEngine.Texture2D val_26;
            var val_27;
            var val_28;
            UnityEngine.Vector3 val_29;
            UnityEngine.Vector3 val_32;
            Scroll3dOfferItemCellView.丒业丛丟专丛丒与东 val_1 = new Scroll3dOfferItemCellView.丒业丛丟专丛丒与东();
            .丝且与丝丒丟万丁专 = this;
            三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.Item.Id);
            .三与世丈丂丕丏三上 = val_4;
            .七丆丒与丗丌丄且丂 = val_4.万上丄下业丛丌不丈() - 1;
            UnityEngine.GameObject val_8 = WeaponManager.丄丟上一上丐丄与丆(三不三丟专丘东东丂:  (Scroll3dOfferItemCellView.丒业丛丟专丛丒与东)[1152921543270484944].三与世丈丂丕丏三上.与不丞丑七丘丁丂丛());
            WeaponSounds val_9 = val_8.GetComponent<WeaponSounds>();
            .丞丑与与一丐丏与丙 = new System.Action<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.Single>(object:  val_1, method:  System.Void Scroll3dOfferItemCellView.丒业丛丟专丛丒与东::丙丏丌下上丌万丘丙(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, float 七丂且丄业丐丂丐丏));
            if((System.String.op_Equality(a:  (Scroll3dOfferItemCellView.丒业丛丟专丛丒与东)[1152921543270484944].三与世丈丂丕丏三上.与不丞丑七丘丁丂丛(), b:  "cyborg_hands")) == false)
            {
                goto label_11;
            }
            
            UnityEngine.Object val_13 = UnityEngine.Resources.Load(path:  "Weapons/Weapon759_info");
            if(val_13 == null)
            {
                goto label_14;
            }
            
            val_13 = (null == null) ? (val_13) : 0;
            goto label_15;
            label_11:
            val_25 = null;
            val_25 = null;
            this._modelHandler.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_26 = (Scroll3dOfferItemCellView.丒业丛丟专丛丒与东)[1152921543270484944].三与世丈丂丕丏三上.与不丞丑七丘丁丂丛();
            if((val_26.Equals(value:  "cape_Custom")) != false)
            {
                    val_27 = null;
                val_27 = null;
                val_26 = SkinsController.丌七丞东丟丌世且不;
                Rilisoft.与丄丁丄丙丞下下丙.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  this._modelHandler.gameObject, 丐丅丁丂丐下丘世丄:  val_26, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
            }
            
            丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_8, 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void Scroll3dOfferItemCellView.丒业丛丟专丛丒与东::上丕三丂东上丅丟丞(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)), 七丆丒与丗丌丄且丂:  (Scroll3dOfferItemCellView.丒业丛丟专丛丒与东)[1152921543270484944].七丆丒与丗丌丄且丂, 丐丑七万丌丂专与丌:  val_9);
            return;
            label_14:
            val_24 = 0;
            label_15:
            UnityEngine.GameObject val_20 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_24);
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_20, 不东丛三丂丌丑专丆:  this.gameObject.layer);
            val_28 = null;
            val_28 = null;
            Player_move_c.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_20, 丐丅丁丂丐下丘世丄:  SkinsController.丌与世丂丘且下丒丑, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
            if(val_9 != null)
            {
                    val_29 = val_9.positionShop;
                val_32 = val_9.rotationShop;
            }
            else
            {
                    val_29 = val_9.positionShop;
                val_32 = val_9.rotationShop;
            }
            
            (Scroll3dOfferItemCellView.丒业丛丟专丛丒与东)[1152921543270484944].丞丑与与一丐丏与丙.Invoke(arg1:  val_20, arg2:  new UnityEngine.Vector3() {x = val_29, y = V9.16B, z = V10.16B}, arg3:  new UnityEngine.Vector3() {x = val_32, y = V12.16B, z = V13.16B}, arg4:  val_9.scaleShop);
        }
        private void 丘丞专上丈丅东丞丟()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public Scroll3dOfferItemCellView()
        {
        
        }
    
    }

}
