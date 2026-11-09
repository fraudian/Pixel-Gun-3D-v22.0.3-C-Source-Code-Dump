using UnityEngine;
internal class SquareFieldCell : PGBehaviour
{
    // Fields
    private UnityEngine.Vector3 _coordinate;
    private int _rotation;
    private SquareFieldCellSize _size;
    private UnityEngine.Transform _body;
    protected UnityEngine.GameObject _cellObject;
    internal bool 丈万丏下丐与东丂丁;
    internal bool 丘上丒丟丞世丐丑业;
    private bool 丛丗东丑业丗七丈与;
    internal bool 丏东丘丝七业丗丙业;
    internal UnityEngine.GameObject 不丛不丅下三业丕丒;
    internal bool 东丒且上且七丝万丟;
    private float cameraZoomAfterSetup;
    private float cameraZoomSpeed;
    internal PlaceableItemSettings 业世丟丐丘丐专与不;
    
    // Properties
    internal UnityEngine.GameObject 丈丑七丞三丗三丈丂 { get; set; }
    internal int 丁上专万丕万丛且丞 { get; set; }
    internal UnityEngine.Vector3 丛丄世七万丗三三且 { get; set; }
    internal SquareFieldCellSize 丁业丛且一丂一丟丁 { get; set; }
    
    // Methods
    internal UnityEngine.GameObject 丞与业万丙上丐丕丑()
    {
        return (UnityEngine.GameObject)this._cellObject;
    }
    internal void 一丏丟丒丑万世丟七(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        UnityEngine.GameObject val_12 = this._cellObject;
        if(val_12 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        val_12 = this._body;
        if(val_12 == 0)
        {
                return;
        }
        
        val_12 = this._cellObject;
        if(val_12 != 0)
        {
                val_12 = this._cellObject;
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_12);
            this._cellObject = 0;
        }
        
        this._cellObject = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == 0)
        {
                return;
        }
        
        this._cellObject.transform.SetParent(p:  this._body);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this._cellObject.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        this._cellObject.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        this._cellObject.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
    }
    internal int 丘丄丈上与丕三丅丑()
    {
        return (int)this._rotation;
    }
    internal void 丈丌丝丐丆不且万不(int 丙业与丙丗丝不丈东)
    {
        if(this._rotation == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this._rotation = 丙业与丙丗丝不丈东;
        if(this._body == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  0f, y:  (float)this._rotation, z:  0f);
        this._body.transform.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    internal UnityEngine.Vector3 丝专与下丗丐东丛丐()
    {
        return new UnityEngine.Vector3() {x = this._coordinate};
    }
    internal void 丈丒不丑三丄丏丅丌(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this._coordinate = 丙业与丙丗丝不丈东;
        mem[1152921539194672140] = 丙业与丙丗丝不丈东.y;
        mem[1152921539194672144] = 丙业与丙丗丝不丈东.z;
        UnityEngine.Vector3 val_2 = SquareField.上丅专世不丗东丑丛(丗丒且世丆专丄三专:  new UnityEngine.Vector3() {x = this._coordinate, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z}, 丟七丘一丈万业专下:  1f);
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    internal SquareFieldCellSize 专业专专丏丆一万丝()
    {
        return (SquareFieldCellSize)this._size;
    }
    private void 丐丒丕丈丆丗万丐丝(SquareFieldCellSize 丙业与丙丗丝不丈东)
    {
        this._size = 丙业与丙丗丝不丈东;
    }
    internal virtual void 丈且东丑丂且万丒丅(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, SquareFieldCellSize 丟丒且一专丟丙下一, int 七丅丗丆丒丌丑丝不, UnityEngine.GameObject 丄且丄丞丗七丕一丕, PlaceableItemSettings 业世丟丐丘丐专与不, bool 丕丆东上业七丒东三, bool 丘丒世世东七一丕七, bool 丆丆丌上丕丈丏丞丄)
    {
        var val_23;
        UnityEngine.GameObject val_24;
        int val_25;
        float val_26;
        float val_27;
        float val_28;
        var val_29;
        int val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_37;
        float val_38;
        float val_39;
        val_23 = 丆丆丌上丕丈丏丞丄;
        val_24 = 丄且丄丞丗七丕一丕;
        val_25 = 七丅丗丆丒丌丑丝不;
        val_26 = 业丒丝丗与丐丛丟丏.z;
        val_27 = 业丒丝丗与丐丛丟丏.y;
        val_28 = 业丒丝丗与丐丛丟丏.x;
        val_29 = this;
        this._size = 丟丒且一专丟丙下一;
        this.一丏丟丒丑万世丟七(丙业与丙丗丝不丈东:  val_24);
        val_30 = val_25;
        this.丈丌丝丐丆不且万不(丙业与丙丗丝不丈东:  val_30);
        this.业世丟丐丘丐专与不 = 业世丟丐丘丐专与不;
        if(业世丟丐丘丐专与不.moveableInFortField == false)
        {
            goto label_2;
        }
        
        label_7:
        if(丕丆东上业七丒东三 == true)
        {
            goto label_3;
        }
        
        if(业世丟丐丘丐专与不.cellSize != 1)
        {
                val_30 = 0;
            UnityEngine.Vector3 val_1 = FortFieldTurretPlatformController.instance.GetNearestPlatfrom(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_28, y = val_27, z = val_26});
            val_31 = val_1.x;
            val_32 = val_1.y;
            val_33 = val_1.z;
        }
        
        UnityEngine.Vector3 val_2 = this.且世丅专七一丙丛丁(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_33});
        val_37 = val_2.x;
        val_38 = val_2.y;
        val_39 = val_2.z;
        goto label_14;
        label_2:
        if(业世丟丐丘丐专与不.cellSize == 0)
        {
            goto label_7;
        }
        
        val_25 = FortFieldUnmoveableManager.丄丘七三上丕世丞业;
        val_30 = 0;
        if(val_25 != val_30)
        {
                val_25 = FortFieldUnmoveableManager.丄丘七三上丕世丞业;
            val_25.丑丛丞丑上丒丂三三(七丐丌上上万丘三丆:  业世丟丐丘丐专与不.SubcategoryName, 丂下丄丝丆丅丗丆丏:  this.gameObject);
            val_24 = val_24.transform;
            val_30 = 0;
            UnityEngine.Vector3 val_7 = val_24.position;
            val_37 = val_7.x;
            val_38 = val_7.y;
            val_39 = val_7.z;
        }
        
        if(丕丆东上业七丒东三 == false)
        {
            goto label_14;
        }
        
        label_3:
        this.丈万丏下丐与东丂丁 = false;
        label_14:
        this.丈丒不丑三丄丏丅丌(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = val_39});
        this.丘上丒丟丞世丐丑业 = this.丛丗东丑业丗七丈与;
        this.丐且不丗丆专丈丌三(丘丒世世东七一丕七:  丘丒世世东七一丕七);
        if(val_23 == false)
        {
                return;
        }
        
        val_23 = ???;
        val_29 = ???;
        val_24 = ???;
        val_25 = ???;
        val_39 = ???;
        goto typeof(SquareFieldCell).__il2cppRuntimeField_178;
    }
    private void 丐且不丗丆专丈丌三(bool 丘丒世世东七一丕七)
    {
        var val_5;
        var val_12;
        var val_13;
        val_12 = 丘丒世世东七一丕七;
        val_13 = this;
        if((this._cellObject.GetComponent<FortFieldObjectParams>()) == 0)
        {
                return;
        }
        
        if((val_12 == false) || (val_1.objectRenderers == null))
        {
            goto label_20;
        }
        
        List.Enumerator<T> val_3 = val_1.objectRenderers.GetEnumerator();
        label_13:
        if((228646480 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        val_6.material.shader = UnityEngine.Shader.Find(name:  "Rilisoft/WallHackShader");
        val_6.material.renderQueue = 184;
        goto label_13;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_20:
        val_13 = this._cellObject.transform;
        val_13.localScale = new UnityEngine.Vector3() {x = val_1.scaleInFortField, y = V9.16B, z = V10.16B};
    }
    internal virtual void 万丕万与东且丅丌与()
    {
        var val_7 = 0;
        val_7 = val_7 + 1;
        丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑().SmoothZoom(上世东专丅丙一世与:  this.cameraZoomAfterSetup, 丟丞一专丕三东丗一:  this.cameraZoomSpeed);
        UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
        var val_8 = 0;
        val_8 = val_8 + 1;
        丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑().SmoothMove(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 东丗上东丘丄东丘世:  this.cameraZoomSpeed);
    }
    internal virtual void 丕丕业七丙七丅丈丄()
    {
    
    }
    internal UnityEngine.Vector2 丂丗丏丝丈丟丗丕万()
    {
        float val_2;
        if(this._size > 9)
        {
                val_2 = 0f;
        }
        else
        {
                val_2 = (float)this._size;
        }
        
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  (float)this._size, y:  val_2);
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal UnityEngine.Vector3 且世丅专七一丙丛丁(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_6;
        var val_17;
        float val_18;
        var val_19;
        var val_20;
        UnityEngine.Vector3 val_1 = SquareField.丏东七万丞丆丅丒丕(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 丟七丘一丈万业专下:  null);
        this.丛丗东丑业丗七丈与 = this.丘上丒丟丞世丐丑业;
        System.Collections.Generic.List<UnityEngine.RaycastHit> val_2 = this.业丈丐丗丌世七丘丈(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        val_17 = 0;
        val_18 = 0f;
        goto label_1;
        label_8:
        UnityEngine.RaycastHit val_3 = val_2.Item[0];
        if(val_18 < 0)
        {
                UnityEngine.RaycastHit val_7 = val_2.Item[0];
            val_18 = (float)System.Math.Round(value:  (double)val_6, digits:  4);
        }
        
        val_17 = 1;
        label_1:
        if(val_17 < val_2.Count)
        {
            goto label_8;
        }
        
        val_19 = 0;
        val_20 = 0;
        goto label_9;
        label_13:
        if(val_19 >= val_2.Count)
        {
            goto label_10;
        }
        
        label_14:
        UnityEngine.RaycastHit val_11 = val_2.Item[0];
        val_20 = val_20 + ((val_18 == ((float)System.Math.Round(value:  (double)val_6, digits:  4))) ? 1 : 0);
        val_19 = 1;
        label_9:
        if(val_2 == null)
        {
            goto label_13;
        }
        
        if(val_19 < val_2.Count)
        {
            goto label_14;
        }
        
        label_10:
        if(val_20 == val_2.Count)
        {
                return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        this.丛丗东丑业丗七丈与 = true;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private System.Collections.Generic.List<UnityEngine.RaycastHit> 业丈丐丗丌世七丘丈(UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        float val_13;
        float val_14;
        float val_15;
        float val_17;
        float val_18;
        float val_19;
        float val_22;
        float val_21 = 下业丕七东丌丝下且.x;
        this.不丛不丅下三业丕丒 = 0;
        this.丛丗东丑业丗七丈与 = true;
        this.丏东丘丝七业丗丙业 = false;
        System.Collections.Generic.List<UnityEngine.RaycastHit> val_1 = new System.Collections.Generic.List<UnityEngine.RaycastHit>();
        UnityEngine.Vector2 val_2 = this.丂丗丏丝丈丟丗丕万();
        var val_20 = 0;
        do
        {
            val_1.Add(item:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            val_20 = val_20 + 1;
        }
        while(val_20 < ((val_2.x > 1f) ? 4 : (0 + 1)));
        
        UnityEngine.Vector2 val_4 = this.丂丗丏丝丈丟丗丕万();
        val_22 = val_4.x * 0.5f;
        float val_5 = val_4.y * 0.5f;
        val_4.x = val_21 + val_22;
        val_4.y = 下业丕七东丌丝下且.z + val_5;
        float val_6 = val_4.x + (-0.5f);
        float val_7 = val_4.y + (-0.5f);
        UnityEngine.RaycastHit val_8 = this.万丑丂丈丟丂七丒不(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_1.set_Item(index:  0, value:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}});
        if(val_2.x <= 1f)
        {
                return val_1;
        }
        
        val_21 = (val_21 - val_22) + 0.5f;
        UnityEngine.RaycastHit val_10 = this.万丑丂丈丟丂七丒不(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_1.set_Item(index:  1, value:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}});
        val_22 = (下业丕七东丌丝下且.z - val_5) + 0.5f;
        UnityEngine.RaycastHit val_12 = this.万丑丂丈丟丂七丒不(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_1.set_Item(index:  2, value:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_14, y = val_14, z = val_14}, m_Normal = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_15}, m_FaceID = val_15, m_Distance = val_15, m_UV = new UnityEngine.Vector2() {x = val_13, y = val_13}, m_Collider = val_13});
        UnityEngine.RaycastHit val_16 = this.万丑丂丈丟丂七丒不(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_1.set_Item(index:  3, value:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_18, y = val_18, z = val_18}, m_Normal = new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_19}, m_FaceID = val_19, m_Distance = val_19, m_UV = new UnityEngine.Vector2() {x = val_17, y = val_17}, m_Collider = val_17});
        return val_1;
    }
    private UnityEngine.RaycastHit 万丑丂丈丟丂七丒不(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_20;
        var val_21;
        bool val_22;
        var val_23;
        System.Comparison<UnityEngine.RaycastHit> val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        UnityEngine.RaycastHit val_0;
        val_20 = 丅专与丒丈丗丒丘丌.z;
        val_21 = val_0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.RaycastHit>(source:  UnityEngine.Physics.RaycastAll(origin:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, direction:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}));
        val_22 = 1152921505266163712;
        val_23 = null;
        val_23 = null;
        val_25 = SquareFieldCell.<>c.<>9__33_0;
        if(val_25 == null)
        {
            goto label_5;
        }
        
        if(val_3 == null)
        {
            goto label_6;
        }
        
        label_10:
        val_3.Sort(comparison:  val_25);
        goto label_7;
        label_5:
        System.Comparison<UnityEngine.RaycastHit> val_4 = null;
        val_25 = val_4;
        val_4 = new System.Comparison<UnityEngine.RaycastHit>(object:  SquareFieldCell.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 SquareFieldCell.<>c::丑丗与丈世丄与丂一(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂, UnityEngine.RaycastHit 丙专一丌丌丁不丈专));
        SquareFieldCell.<>c.<>9__33_0 = val_25;
        if(val_3 != null)
        {
            goto label_10;
        }
        
        label_6:
        val_3.Sort(comparison:  val_4);
        label_7:
        val_27 = 1152921535793351248;
        int val_19 = val_3.Count;
        if(val_19 == 0)
        {
            goto label_35;
        }
        
        val_20 = 21f;
        val_26 = 0;
        val_22 = true;
        label_32:
        val_19 = val_19 - 1;
        label_20:
        UnityEngine.RaycastHit val_6 = val_3.Item[val_19];
        val_27 = null;
        if((SquareField.丄丘七三上丕世丞业.丝丈丌上丝一丑丙丘(丁丂丝不丟丛丟一丂:  0.gameObject)) == 0)
        {
            goto label_17;
        }
        
        this.丛丗东丑业丗七丈与 = val_22;
        UnityEngine.RaycastHit val_12 = val_3.Item[val_19];
        if(0.targetValue < 0)
        {
            goto label_19;
        }
        
        label_17:
        val_19 = val_19 - 1;
        if(val_19 != 1)
        {
            goto label_20;
        }
        
        goto label_21;
        label_19:
        UnityEngine.RaycastHit val_14 = val_3.Item[val_19];
        val_20 = 0.targetValue;
        if(val_10.canPlaceTowerHere == false)
        {
            goto label_24;
        }
        
        if((val_10.canPlaceTrapHere == true) || (this._size == 1))
        {
            goto label_31;
        }
        
        this.丛丗东丑业丗七丈与 = true;
        this.丏东丘丝七业丗丙业 = true;
        UnityEngine.RaycastHit val_16 = val_3.Item[val_19];
        this.不丛不丅下三业丕丒 = 0.gameObject;
        if(val_10.canPlaceTowerHere == true)
        {
            goto label_31;
        }
        
        label_24:
        if((val_10.canPlaceTrapHere != false) && (this._size == 1))
        {
                this.丛丗东丑业丗七丈与 = false;
        }
        
        label_31:
        val_26 = val_19;
        if(val_19 != 0)
        {
            goto label_32;
        }
        
        val_28 = val_21;
        if(val_3 != null)
        {
            goto label_36;
        }
        
        goto label_34;
        label_21:
        val_29 = val_21;
        if(val_26 == 1)
        {
            goto label_35;
        }
        
        if(val_3 != null)
        {
            goto label_36;
        }
        
        label_34:
        label_36:
        UnityEngine.RaycastHit val_18 = val_3.Item[0];
        return val_0;
        label_35:
        val_0.m_Collider = 0;
        val_0.m_UV.x = 0f;
        val_0.m_UV.y = 0f;
        val_0.m_Point.x = 0f;
        val_0.m_Point.y = 0f;
        val_0.m_Point.z = 0f;
        val_0.m_Normal.x = 0f;
        val_0.m_Normal.y = 0f;
        val_0.m_Normal.z = 0f;
        val_0.m_FaceID = 0;
        val_0.m_Distance = 0f;
        return val_0;
    }
    internal void 万东三世且丘上一下(bool 丑丐丙丞丛业且丟丑 = False)
    {
        if(丑丐丙丞丛业且丟丑 != true)
        {
                if(((this.丛丗东丑业丗七丈与 == true) ? 1 : 0) == ((this.丘上丒丟丞世丐丑业 == true) ? 1 : 0))
        {
                return;
        }
        
        }
        
        this.丘上丒丟丞世丐丑业 = this.丛丗东丑业丗七丈与;
        goto typeof(SquareFieldCell).__il2cppRuntimeField_188;
    }
    internal void 丏丛丁世丑丏丕与与()
    {
        this.丈万丏下丐与东丂丁 = false;
    }
    internal virtual void 丌且丄七丈与丕丆不()
    {
    
    }
    public SquareFieldCell()
    {
        this.丈万丏下丐与东丂丁 = true;
        this.cameraZoomAfterSetup = 0.5f;
        this.cameraZoomSpeed = 2.126765E+38f;
    }

}
