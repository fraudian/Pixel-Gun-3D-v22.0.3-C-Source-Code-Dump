using UnityEngine;

namespace Rilisoft
{
    public class CharactersCorousel : MonoBehaviour
    {
        // Fields
        private float _autoRotateAfterSecs;
        private float 上丕丈业丄与丈丗业;
        private float 丐东丙丘丏丕丌与不;
        private float _autoRotateSpeed;
        private UnityEngine.Camera charactersCamera;
        private UnityEngine.Transform _objectForRotatePers;
        private UnityEngine.Transform _centerPoint;
        private Rilisoft.UIDragInterceptor _characterDragInterceptor;
        private UnityEngine.GameObject _characterPointPrototype;
        private float _characterRotateSpeed;
        private System.Nullable<UnityEngine.Quaternion> 万丛丑丌丄世丟丒丝;
        private float _dragSpeed;
        private bool 丕丄丆丛丒一丒业丞;
        private int 丛业下不丗且丁丂丞;
        private float _radius;
        private float _rotateSpeed;
        private int 东上丏丐丗丕不丆丛;
        private int <一不丈丌丆万丝专丅>k__BackingField;
        private System.Action<int> 一丅丄业丁丌丑丅丅;
        
        // Properties
        public int 一丆业丆丝业业丆丐 { get; set; }
        public bool 丗下丟万不丁且与丆 { get; set; }
        public Rilisoft.CharactersCorouselItem 专一丟丆专丟一世一 { get; }
        
        // Methods
        public int get_SettedCharactersCount()
        {
            return (int)this.<一不丈丌丆万丝专丅>k__BackingField;
        }
        private void 丑丘万与丞七且丕丝(int 丙业与丙丗丝不丈东)
        {
            this.<一不丈丌丆万丝专丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_Visible()
        {
            UnityEngine.GameObject val_1 = this._centerPoint.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void set_Visible(bool 丙业与丙丗丝不丈东)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._centerPoint.gameObject, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        }
        public Rilisoft.CharactersCorouselItem get_SelectedItem()
        {
            UnityEngine.Transform val_1 = this._centerPoint.GetChild(index:  this.东上丏丐丗丕不丆丛);
            if(val_1 != null)
            {
                    return val_1.GetComponent<Rilisoft.CharactersCorouselItem>();
            }
            
            return val_1.GetComponent<Rilisoft.CharactersCorouselItem>();
        }
        public void add_OnDragStopped(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.一丅丄业丁丌丑丅丅, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一丅丄业丁丌丑丅丅 != 1152921542736811384);
        
        }
        public void remove_OnDragStopped(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.一丅丄业丁丌丑丅丅, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一丅丄业丁丌丑丅丅 != 1152921542736947960);
        
        }
        private void OnEnable()
        {
            this._characterDragInterceptor.add_OnDragStarted(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CharactersCorousel::丟丆丒且丏丁丄丛丈()));
            this._characterDragInterceptor.add_OnDragEnded(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CharactersCorousel::上丞丝丒丑且丈上丗()));
            this._characterDragInterceptor.add_OnDragging(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void Rilisoft.CharactersCorousel::丅不丁丆丙东丘丒且(UnityEngine.Vector2 丞且丅三三东不丄且)));
            this._characterDragInterceptor.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CharactersCorousel::丅丛丟一丌专世丞丗()));
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
        }
        private void OnDisable()
        {
            this._characterDragInterceptor.remove_OnDragStarted(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CharactersCorousel::丟丆丒且丏丁丄丛丈()));
            this._characterDragInterceptor.remove_OnDragEnded(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CharactersCorousel::上丞丝丒丑且丈上丗()));
            this._characterDragInterceptor.remove_OnDragging(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void Rilisoft.CharactersCorousel::丅不丁丆丙东丘丒且(UnityEngine.Vector2 丞且丅三三东不丄且)));
            this._characterDragInterceptor.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CharactersCorousel::丅丛丟一丌专世丞丗()));
        }
        private void 丟丆丒且丏丁丄丛丈()
        {
            mem[1152921542737447764] = 0;
            mem[1152921542737447756] = 0;
            this.万丛丑丌丄世丟丒丝 = 0;
        }
        private void 上丞丝丒丑且丈上丗()
        {
            this.上丕丈业丄与丈丗业 = this._autoRotateAfterSecs;
            if(this.一丅丄业丁丌丑丅丅 == null)
            {
                    return;
            }
            
            this.一丅丄业丁丌丑丅丅.Invoke(obj:  this.丌丘上丏专丘丛丕七());
        }
        private int 丌丘上丏专丘丛丕七()
        {
            var val_11;
            var val_12;
            UnityEngine.Transform val_13;
            val_11 = 0;
            val_12 = 0;
            goto label_1;
            label_15:
            if(this._objectForRotatePers != 0)
            {
                goto label_5;
            }
            
            val_13 = this.charactersCamera.transform;
            if(val_13 != null)
            {
                goto label_9;
            }
            
            goto label_8;
            label_5:
            val_13 = this._objectForRotatePers;
            if(val_13 != null)
            {
                goto label_9;
            }
            
            label_8:
            label_9:
            UnityEngine.Vector3 val_4 = val_13.position;
            UnityEngine.Vector3 val_6 = this._centerPoint.GetChild(index:  0).transform.position;
            float val_7 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            var val_8 = ((3.402823E+38f) > val_7) ? (val_7) : 3.402823E+38f;
            val_11 = 1;
            label_1:
            if(val_11 < this._centerPoint.childCount)
            {
                goto label_15;
            }
            
            return (int)((3.402823E+38f) > val_7) ? (val_11) : (val_12);
        }
        private void 丅不丁丆丙东丘丒且(UnityEngine.Vector2 丞且丅三三东不丄且)
        {
            float val_7;
            UnityEngine.Transform val_8;
            val_7 = 丞且丅三三东不丄且.x;
            if(this._centerPoint.childCount < 1)
            {
                    return;
            }
            
            val_8 = this._centerPoint;
            if((this.<一不丈丌丆万丝专丅>k__BackingField) <= 1)
            {
                    val_8 = val_8.GetChild(index:  0);
            }
            
            val_7 = val_7 * UnityEngine.Time.deltaTime;
            float val_7 = (float)UnityEngine.Screen.height;
            val_7 = val_7 * this._dragSpeed;
            val_7 = (-1366f) / val_7;
            val_7 = val_7 * val_7;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            val_8.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, angle:  val_7);
            this.上丕丈业丄与丈丗业 = this._autoRotateAfterSecs;
            this.丐东丙丘丏丕丌与不 = this._autoRotateAfterSecs;
        }
        private void 丅丛丟一丌专世丞丗()
        {
            float val_5;
            float val_6;
            UnityEngine.Object val_14;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            UnityEngine.Ray val_2 = this.charactersCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_14 = this.gameObject;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1000f, layerMask:  1 << (val_14.layer & 31))) == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_10 = 0.gameObject;
            val_14 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<Rilisoft.CharactersCorouselItem>(丝三丁东丈丒世丅业:  val_10);
            if((val_10.CompareTag(tag:  "Pet")) != true)
            {
                    if(val_14 == 0)
            {
                    return;
            }
            
            }
            
            val_14.PlayTapAnimation();
        }
        public void Setup(int 专丁丘三丂丝丅不丐, UnityEngine.Camera 与业丞东丙丕且丏丈)
        {
            var val_32;
            UnityEngine.Object val_33;
            var val_34;
            var val_35;
            this.<一不丈丌丆万丝专丅>k__BackingField = 专丁丘三丂丝丅不丐;
            if(与业丞东丙丕且丏丈 == 0)
            {
                goto label_4;
            }
            
            this.charactersCamera = 与业丞东丙丕且丏丈;
            goto label_4;
            label_26:
            if(this._characterPointPrototype != 0)
            {
                    UnityEngine.GameObject val_3 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._characterPointPrototype, 丈东丘丏与丌东东下:  this._centerPoint, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                val_32 = val_3;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
            }
            else
            {
                    UnityEngine.GameObject val_4 = null;
                val_32 = val_4;
                val_4 = new UnityEngine.GameObject();
                int val_6 = this._centerPoint.gameObject.layer;
                if(val_32 != null)
            {
                    val_4.layer = val_6;
            }
            else
            {
                    val_4.layer = val_6;
            }
            
                val_4.transform.SetParent(p:  this._centerPoint);
                Rilisoft.CharactersCorouselItem val_8 = val_4.AddComponent<Rilisoft.CharactersCorouselItem>();
            }
            
            string val_13 = System.String.Format(format:  "character_" + this._centerPoint.childCount + 1(this._centerPoint.childCount + 1), args:  System.Array.Empty<System.Object>());
            if(val_32 != null)
            {
                    val_4.name = val_13;
            }
            else
            {
                    0.name = val_13;
            }
            
            val_33 = val_4.GetComponent<Rilisoft.CharactersCorouselItem>();
            if(val_33 == 0)
            {
                    val_33 = val_4.AddComponent<Rilisoft.CharactersCorouselItem>();
            }
            
            val_33.CharacterVisible = true;
            label_4:
            if(this._centerPoint.childCount < 专丁丘三丂丝丅不丐)
            {
                goto label_26;
            }
            
            goto label_27;
            label_34:
            if(this._centerPoint != null)
            {
                    val_34 = this._centerPoint.childCount;
            }
            else
            {
                    val_34 = 0.childCount;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._centerPoint.GetChild(index:  val_34 - 1).gameObject);
            label_27:
            if(this._centerPoint.childCount > 专丁丘三丂丝丅不丐)
            {
                goto label_34;
            }
            
            val_35 = 0;
            goto label_35;
            label_45:
            UnityEngine.Transform val_24 = this._centerPoint.GetChild(index:  0);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_27 = this.丆丄与万丝丆与万丆(丙丂丂业丂丁丌丂下:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, 丕与下丒万丛丛丕丒:  this._radius, 专丁丘三丂丝丅不丐:  this._centerPoint.childCount, 丂专丏丐且丁世丏丙:  0);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
            val_24.transform.localScale = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            val_24.transform.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            val_35 = 1;
            label_35:
            if(val_35 < this._centerPoint.childCount)
            {
                goto label_45;
            }
            
            if((this.<一不丈丌丆万丝专丅>k__BackingField) != 1)
            {
                    return;
            }
            
            this.丕丄丆丛丒一丒业丞 = this.<一不丈丌丆万丝专丅>k__BackingField;
        }
        private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new CharactersCorousel.丐世且丅丅丑丒丅丌();
        }
        public Rilisoft.CharactersCorouselItem GetItem(int 世万专丛与丐丌专不)
        {
            int val_4;
            var val_5;
            val_4 = 世万专丛与丐丌专不;
            if((this.<一不丈丌丆万丝专丅>k__BackingField) < (val_4 - 1))
            {
                    val_5 = 0;
                return (Rilisoft.CharactersCorouselItem)val_4.GetComponent<Rilisoft.CharactersCorouselItem>();
            }
            
            val_4 = this._centerPoint.GetChild(index:  val_4);
            return (Rilisoft.CharactersCorouselItem)val_4.GetComponent<Rilisoft.CharactersCorouselItem>();
        }
        public void RotateTo(int 丂专丏丐且丁世丏丙)
        {
            UnityEngine.Transform val_12;
            float val_13;
            var val_14;
            val_12 = this._centerPoint;
            this.东上丏丐丗丕不丆丛 = 丂专丏丐且丁世丏丙;
            this.上丕丈业丄与丈丗业 = this._autoRotateAfterSecs;
            if((val_12.childCount - 1) < 丂专丏丐且丁世丏丙)
            {
                    return;
            }
            
            var val_11 = this._centerPoint.childCount;
            val_11 = 360 / val_11;
            val_11 = val_11 * 丂专丏丐且丁世丏丙;
            val_13 = (float)val_11;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_13, z:  0f);
            mem[1152921542738863988] = 0;
            this.万丛丑丌丄世丟丒丝 = 0;
            UnityEngine.Transform val_5 = this._centerPoint.GetChild(index:  this.东上丏丐丗丕不丆丛);
            val_14 = 0;
            goto label_7;
            label_16:
            Rilisoft.CharactersCorouselItem val_7 = this._centerPoint.GetChild(index:  0).GetComponent<Rilisoft.CharactersCorouselItem>();
            val_7.SetAnimationEnabled(丆丛丆丞下丅丂且丝:  (val_14 == this.东上丏丐丗丕不丆丛) ? 1 : 0);
            if(val_14 == this.东上丏丐丗丕不丆丛)
            {
                    UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
                val_13 = val_9.x;
                val_7.SetRotation(丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_13, y = val_9.y, z = val_9.z, w = val_9.w});
            }
            
            val_14 = 1;
            label_7:
            val_12 = this._centerPoint;
            if(val_14 < val_12.childCount)
            {
                goto label_16;
            }
            
            this.丄丁丁三下一丟与业(丐丕丘丒上丛业三万:  this.东上丏丐丗丕不丆丛);
        }
        private void 丄丁丁三下一丟与业(int 丐丕丘丒上丛业三万)
        {
            var val_6;
            var val_7;
            UnityEngine.Transform val_1 = this._centerPoint.GetChild(index:  丐丕丘丒上丛业三万);
            val_6 = 0;
            goto label_2;
            label_13:
            ShopShootingController val_3 = this._centerPoint.GetChild(index:  0).GetComponent<ShopShootingController>();
            if(val_3 != 0)
            {
                    if(丐丕丘丒上丛业三万 == val_6)
            {
                    val_7 = 1;
            }
            else
            {
                    val_3.Reset();
                val_7 = 0;
            }
            
                val_3.enabled = false;
            }
            
            val_6 = 1;
            label_2:
            if(val_6 < this._centerPoint.childCount)
            {
                goto label_13;
            }
        
        }
        private UnityEngine.Vector3 丆丄与万丝丆与万丆(UnityEngine.Vector3 丙丂丂业丂丁丌丂下, float 丕与下丒万丛丛丕丒, int 专丁丘三丂丝丅不丐, int 丂专丏丐且丁世丏丙)
        {
            float val_4 = 丙丂丂业丂丁丌丂下.x;
            int val_1 = 360 / 专丁丘三丂丝丅不丐;
            val_1 = val_1 * 丂专丏丐且丁世丏丙;
            float val_2 = (float)val_1;
            val_2 = val_2 * 0.01745329f;
            float val_3 = val_2;
            val_3 = val_3 * 丕与下丒万丛丛丕丒;
            val_4 = val_4 + val_3;
            float val_5 = val_2;
            val_5 = val_5 * 丕与下丒万丛丛丕丒;
            丙丂丂业丂丁丌丂下.z = 丙丂丂业丂丁丌丂下.z + val_5;
            return new UnityEngine.Vector3() {x = val_4, y = 丙丂丂业丂丁丌丂下.y, z = 丙丂丂业丂丁丌丂下.z};
        }
        private float 万丟与万丏业丑下三(int 专丁丘三丂丝丅不丐, int 丂专丏丐且丁世丏丙)
        {
            int val_1 = 360 / 专丁丘三丂丝丅不丐;
            val_1 = val_1 * 丂专丏丐且丁世丏丙;
            return (float)(float)val_1;
        }
        private void Update()
        {
            float val_28;
            int val_29;
            float val_30;
            float val_31;
            System.Nullable<UnityEngine.Quaternion> val_32;
            float val_33;
            float val_34;
            var val_35;
            float val_36;
            float val_40;
            float val_41;
            float val_42;
            val_28 = this.上丕丈业丄与丈丗业;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_28 - val_1;
            this.上丕丈业丄与丈丗业 = val_1;
            val_29 = this.东上丏丐丗丕不丆丛;
            val_30 = this._characterRotateSpeed;
            val_31 = this.丐东丙丘丏丕丌与不 - UnityEngine.Time.deltaTime;
            this.丐东丙丘丏丕丌与不 = val_31;
            if(this.丕丄丆丛丒一丒业丞 != false)
            {
                    this.丕丄丆丛丒一丒业丞 = false;
                val_32 = this._centerPoint.GetChild(index:  0);
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(x:  0f, y:  90f, z:  0f);
                val_28 = val_4.x;
                val_33 = val_4.z;
                val_30 = val_4.y;
                val_32.localRotation = new UnityEngine.Quaternion() {x = val_28, y = val_30, z = val_33, w = val_4.w};
                val_31 = this._autoRotateAfterSecs;
                this.丐东丙丘丏丕丌与不 = this._autoRotateAfterSecs;
            }
            
            if((this.<一不丈丌丆万丝专丅>k__BackingField) < 2)
            {
                goto label_6;
            }
            
            if(this.上丕丈业丄与丈丗业 >= 0)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            val_28 = val_5.x;
            val_33 = val_5.z;
            val_34 = this._autoRotateSpeed;
            this._centerPoint.Rotate(axis:  new UnityEngine.Vector3() {x = val_28, y = val_5.y, z = val_33}, angle:  UnityEngine.Time.deltaTime * val_34);
            float val_28 = val_30;
            val_29 = this.丌丘上丏专丘丛丕七();
            val_28 = val_28 * 0.1f;
            goto label_17;
            label_7:
            val_32 = this.万丛丑丌丄世丟丒丝;
            if(val_32.HasValue == false)
            {
                goto label_12;
            }
            
            UnityEngine.Quaternion val_10 = this._centerPoint.localRotation;
            val_35 = 1152921542739387216;
            val_28 = val_10.x;
            val_33 = val_10.z;
            val_34 = val_10.x;
            val_36 = val_10.z;
            if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  new UnityEngine.Quaternion() {x = val_28, y = val_10.y, z = val_33, w = val_10.w}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Quaternion() {x = val_34, y = val_10.y, z = val_36, w = val_10.w}, 不丝丙丌七丄上东丛:  1f)) == false)
            {
                goto label_16;
            }
            
            label_12:
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            goto label_17;
            label_16:
            UnityEngine.Quaternion val_12 = this._centerPoint.localRotation;
            val_34 = val_12.x;
            val_36 = val_12.z;
            float val_13 = UnityEngine.Time.deltaTime;
            val_13 = val_13 * this._rotateSpeed;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, b:  new UnityEngine.Quaternion() {x = val_34, y = val_12.y, z = val_36, w = val_12.w}, t:  val_13);
            val_28 = val_14.x;
            val_33 = val_14.z;
            this._centerPoint.localRotation = new UnityEngine.Quaternion() {x = val_28, y = val_14.y, z = val_33, w = val_14.w};
            label_17:
            if((this.<一不丈丌丆万丝专丅>k__BackingField) > 1)
            {
                goto label_22;
            }
            
            val_31 = this.丐东丙丘丏丕丌与不;
            label_6:
            if(val_31 >= 0)
            {
                    return;
            }
            
            label_22:
            val_32 = 0;
            goto label_25;
            label_44:
            UnityEngine.Transform val_16 = this._centerPoint.GetChild(index:  0);
            val_35 = UnityEngine.Object.op_Equality(x:  val_16, y:  this._centerPoint.GetChild(index:  val_29));
            UnityEngine.Vector3 val_18 = val_16.position;
            UnityEngine.Vector3 val_20 = this.transform.position;
            if(val_35 != false)
            {
                    val_40 = val_18.x;
                val_41 = val_18.z;
                val_42 = val_20.x;
            }
            else
            {
                    UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
                val_42 = val_21.x;
                val_40 = val_18.x;
                val_41 = val_18.z;
            }
            
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_40, y = val_18.y, z = val_41}, b:  new UnityEngine.Vector3() {x = val_42, y = val_21.y, z = val_21.z});
            UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_22.x, y = 0f, z = val_22.z});
            UnityEngine.Quaternion val_24 = val_16.rotation;
            val_34 = val_24.x;
            val_36 = val_24.z;
            float val_29 = val_28;
            val_29 = val_29 * UnityEngine.Time.deltaTime;
            UnityEngine.Quaternion val_26 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_34, y = val_24.y, z = val_36, w = val_24.w}, b:  new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w}, t:  val_29);
            val_28 = val_26.x;
            val_33 = val_26.z;
            val_16.rotation = new UnityEngine.Quaternion() {x = val_28, y = val_26.y, z = val_33, w = val_26.w};
            val_32 = 1;
            label_25:
            if(val_32 < this._centerPoint.childCount)
            {
                goto label_44;
            }
        
        }
        public CharactersCorousel()
        {
            this.丐东丙丘丏丕丌与不 = -1f;
            this._autoRotateSpeed = 10f;
            this._autoRotateAfterSecs = 5f;
            this._characterRotateSpeed = 5f;
            this._dragSpeed = 6f;
            this.丛业下不丗且丁丂丞 = 0;
            this._radius = 1.5f;
            this._rotateSpeed = 3f;
        }
    
    }

}
