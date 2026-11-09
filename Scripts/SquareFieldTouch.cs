using UnityEngine;
public class SquareFieldTouch : MonoBehaviour
{
    // Fields
    private GestureCamera _mapCamera;
    private SquareFieldCell draggingCell;
    private UnityEngine.Vector3 丐不丕不丑与世丅丟;
    public UnityEngine.Vector2 objectDragOffsetMin;
    public UnityEngine.Vector2 objectDragOffsetMax;
    private System.Collections.Generic.Queue<float> 丝业丆丆业且一丙丏;
    private int heightNumber;
    private int 万下与且下丘且三上;
    private int 丆丘与业丄丄丏丒不;
    private int 丏世专丙丐丘世丆不;
    private int 专下丅万上且且万专;
    private UnityEngine.GameObject 丒三丂丞丝万不丈丗;
    
    // Properties
    internal bool 丂东丟丛世丗丕东丅 { get; }
    internal SquareFieldCell 丝丑丞上三丒丄一下 { get; set; }
    
    // Methods
    internal bool 丑下丐丂万上丂丝丛()
    {
        return UnityEngine.Object.op_Inequality(x:  this.draggingCell, y:  0);
    }
    internal SquareFieldCell 丛丅且三丟丛丝上下()
    {
        return (SquareFieldCell)this.draggingCell;
    }
    internal void 与丏不上丆丅一丆丐(SquareFieldCell 丙业与丙丗丝不丈东)
    {
        this.draggingCell = 丙业与丙丗丝不丈东;
        UnityEngine.Object val_2 = 0;
        val_2 = UnityEngine.Object.op_Equality(x:  丙业与丙丗丝不丈东, y:  val_2);
        this._mapCamera.enabled = val_2;
    }
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.一且丞丁三丟丙下专());
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyUp(key:  67)) == false)
        {
                return;
        }
        
        this.与丏不上丆丅一丆丐(丙业与丙丗丝不丈东:  0);
    }
    private void OnClick()
    {
        if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null)
        {
                return;
        }
        
        }
        
        SquareFieldSelectableCell val_5 = this.丈丌丑丑且丘万丏业<SquareFieldSelectableCell>();
        if(val_5 != 0)
        {
                if(FortFieldTurretPlatformController.instance != 0)
        {
                FortFieldTurretPlatformController.instance.丙丘与丒七丒丞丗丈(丈与丏且丆丗七丑丛:  CategoryName, 七丐丌上上万丘三丆:  X23.SubcategoryName);
        }
        
            SquareField val_11 = ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒();
            if(val_11.丅业丁丆丂业一丐专 != 0)
        {
                SquareField val_14 = ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒();
            if(val_14.丅业丁丆丂业一丐专 != 0)
        {
                SquareField val_17 = ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒();
            if(val_17.丅业丁丆丂业一丐专 != val_5.gameObject)
        {
                return;
        }
        
        }
        
        }
        
            1152921530862937872 = ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒();
            1152921530862937872.业七丘丒丅丏丝丛丘(万且万且丑丗且丌丆:  val_5.gameObject);
        }
        
        this.与丏不上丆丅一丆丐(丙业与丙丗丝不丈东:  val_5);
    }
    private System.Collections.IEnumerator 一且丞丁三丟丙下专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SquareFieldTouch.丏丏丑丈丆七丏丕丞();
    }
    private T 丈丌丑丑且丘万丏业<T>()
    {
        float val_4;
        float val_5;
        float val_19;
        System.Collections.Generic.IEnumerable<TSource> val_21;
        var val_22;
        System.Func<T, TResult> val_23;
        var val_24;
        var val_25;
        UnityEngine.Object val_26;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        val_19 = val_2.x;
        UnityEngine.Ray val_3 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_19, y = val_2.y, z = val_2.z});
        if(GamepadCursorController.丂业丗业世世丛丟七() != false)
        {
                UnityEngine.Vector2 val_8 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            val_19 = val_9.x;
            UnityEngine.Ray val_10 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_19, y = val_9.y, z = val_9.z});
        }
        
        UnityEngine.RaycastHit[] val_11 = UnityEngine.Physics.RaycastAll(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, m_Direction = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}});
        val_21 = val_11;
        if((System.Linq.Enumerable.Any<UnityEngine.RaycastHit>(source:  val_11)) != false)
        {
                val_22 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_22 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_22 & 1) == 0)
        {
                val_22 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_22 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
            val_23 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
            val_23 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
            if(val_23 == 0)
        {
                val_24 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_24 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_24 & 1) == 0)
        {
                val_24 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_24 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
            System.Func<UnityEngine.RaycastHit, System.Single> val_13 = null;
            val_23 = val_13;
            val_13 = new System.Func<UnityEngine.RaycastHit, System.Single>(object:  __RuntimeMethodHiddenParam + 48 + 184, method:  __RuntimeMethodHiddenParam + 48 + 8);
            mem2[0] = val_23;
        }
        
            val_21 = System.Linq.Enumerable.ToArray<UnityEngine.RaycastHit>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.RaycastHit, System.Single>(source:  val_21, keySelector:  val_13));
        }
        
        val_25 = 0;
        goto label_22;
        label_33:
        if( != 0)
        {
                val_26 = gameObject;
            if(val_26 != 0)
        {
                return (SquareFieldSelectableCell)val_26;
        }
        
        }
        
        val_25 = 1;
        label_22:
        if(val_25 < val_15.Length)
        {
            goto label_33;
        }
        
        val_26 = 0;
        return (SquareFieldSelectableCell)val_26;
    }
    private System.Nullable<UnityEngine.Vector3> 丐万丙丗一丌不丘丘()
    {
        var val_7;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        UnityEngine.Ray val_4 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_7;
        if((236461728 & 1) == 0)
        {
                return 0;
        }
        
        val_7 = public System.Void System.Nullable<UnityEngine.Vector3>::.ctor(UnityEngine.Vector3 value);
        return 0;
    }
    internal void 业世业丛丗下七丂专(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_22;
        float val_23;
        System.Collections.Generic.Queue<System.Single> val_33;
        float val_34;
        float val_35;
        float val_36;
        var val_37;
        int val_38;
        float val_41;
        float val_42;
        float val_46;
        var val_47;
        val_33 = 1152921504848912384;
        val_34 = 0;
        if(this.draggingCell == 0)
        {
                return;
        }
        
        if(this.draggingCell.业世丟丐丘丐专与不.moveableInFortField == false)
        {
                return;
        }
        
        int val_32 = this.丆丘与业丄丄丏丒不;
        if(val_32 < this.万下与且下丘且三上)
        {
                val_32 = val_32 + 1;
            this.丆丘与业丄丄丏丒不 = val_32;
            return;
        }
        
        if(GamepadCursorController.丂业丗业世世丛丟七() == true)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        val_3.x = this.丐不丕不丑与世丅丟 - val_3.x;
        val_34 = System.Math.Abs(val_3.x);
        if(val_34 >= 0)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
        val_36 = val_4.y;
        val_34 = System.Math.Abs(S10 - val_36);
        if(val_34 >= 0)
        {
            goto label_15;
        }
        
        val_37 = this;
        val_38 = this.专下丅万上且且万专;
        if(val_38 < this.丏世专丙丐丘世丆不)
        {
            goto label_16;
        }
        
        label_15:
        if(GamepadCursorController.丂业丗业世世丛丟七() == false)
        {
            goto label_26;
        }
        
        UnityEngine.Vector2 val_7 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
        val_7.x = this.丐不丕不丑与世丅丟 - val_7.x;
        val_34 = System.Math.Abs(val_7.x);
        if(val_34 >= 0)
        {
            goto label_26;
        }
        
        UnityEngine.Vector2 val_8 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
        val_36 = val_8.y;
        val_34 = System.Math.Abs(S10 - val_36);
        if(val_34 >= 0)
        {
            goto label_26;
        }
        
        val_37 = this;
        val_38 = this.专下丅万上且且万专;
        if(val_38 >= this.丏世专丙丐丘世丆不)
        {
            goto label_26;
        }
        
        label_16:
        val_38 = val_38 + 1;
        this.专下丅万上且且万专 = val_38;
        return;
        label_26:
        this.丒三丂丞丝万不丈丗 = 0;
        this.draggingCell.东丒且上且七丝万丟 = true;
        this.专下丅万上且且万专 = 0;
        UnityEngine.Vector3 val_10 = UnityEngine.Input.mousePosition;
        this.丐不丕不丑与世丅丟 = val_10;
        mem[1152921539203288892] = val_10.y;
        mem[1152921539203288896] = val_10.z;
        if(GamepadCursorController.丂业丗业世世丛丟七() != false)
        {
                UnityEngine.Vector2 val_12 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
            val_34 = val_12.x;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_34, y = val_12.y});
            this.丐不丕不丑与世丅丟 = val_13;
            mem[1152921539203288892] = val_13.y;
            mem[1152921539203288896] = val_13.z;
        }
        
        UnityEngine.Vector3 val_14 = UnityEngine.Input.mousePosition;
        val_41 = val_14.x;
        val_42 = val_14.y;
        val_36 = val_14.z;
        if(GamepadCursorController.丂业丗业世世丛丟七() != false)
        {
                UnityEngine.Vector2 val_16 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
            val_34 = val_16.x;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_34, y = val_16.y});
            val_41 = val_17.x;
            val_42 = val_17.y;
            val_36 = val_17.z;
        }
        
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = this.objectDragOffsetMax, y = V12.16B}, b:  new UnityEngine.Vector2() {x = this.objectDragOffsetMin, y = V14.16B}, t:  GestureCamera.ZoomValue01);
        val_41 = val_41 + val_19.x;
        val_35 = val_42 + val_19.y;
        UnityEngine.Ray val_21 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_41, y = val_35, z = val_36});
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_23, y = val_23, z = val_23}, m_Direction = new UnityEngine.Vector3() {x = val_23, y = val_22, z = val_22}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}})) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_25 = this.draggingCell.且世丅专七一丙丛丁(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_23, y = val_35, z = val_36});
        val_36 = val_25.x;
        val_46 = val_25.y;
        val_35 = val_25.z;
        if(this.draggingCell.丏东丘丝七业丗丙业 == false)
        {
            goto label_55;
        }
        
        if(this.draggingCell.东丒且上且七丝万丟 == false)
        {
            goto label_45;
        }
        
        label_59:
        this.丆丘与业丄丄丏丒不 = 0;
        this.draggingCell.东丒且上且七丝万丟 = false;
        UnityEngine.Vector3 val_27 = this.draggingCell.不丛不丅下三业丕丒.transform.position;
        val_36 = val_27.x;
        val_46 = val_27.y;
        val_35 = val_27.z;
        val_47 = 1;
        this.丒三丂丞丝万不丈丗 = this.draggingCell.不丛不丅下三业丕丒;
        goto label_69;
        label_45:
        if(this.draggingCell.不丛不丅下三业丕丒 != 0)
        {
                if(this.丒三丂丞丝万不丈丗 != this.draggingCell.不丛不丅下三业丕丒)
        {
            goto label_59;
        }
        
        }
        
        label_55:
        if(this.draggingCell.丏东丘丝七业丗丙业 != true)
        {
                if(this.draggingCell.东丒且上且七丝万丟 == false)
        {
            goto label_63;
        }
        
        }
        
        val_47 = 0;
        label_69:
        if(this.丝业丆丆业且一丙丏.Count >= this.heightNumber)
        {
                float val_31 = this.丝业丆丆业且一丙丏.Dequeue();
        }
        
        val_33 = this.丝业丆丆业且一丙丏;
        val_33.Enqueue(item:  val_46);
        this.专丏万上万东丂丂万(且丌上七丅东与丁万:  new UnityEngine.Vector3() {x = val_36, y = val_46, z = val_35}, 丆下三与丂七下万下:  false);
        return;
        label_63:
        this.丒三丂丞丝万不丈丗 = 0;
        this.draggingCell.东丒且上且七丝万丟 = true;
        goto label_69;
    }
    private void 专丏万上万东丂丂万(UnityEngine.Vector3 且丌上七丅东与丁万, bool 丆下三与丂七下万下)
    {
        UnityEngine.Object val_13;
        var val_14;
        val_13 = 丆下三与丂七下万下;
        SquareFieldTouch.丛东丟丅丙丗世丗不 val_1 = null;
        val_14 = 0;
        val_1 = new SquareFieldTouch.丛东丟丅丙丗世丗不();
        .且丌上七丅东与丁万 = 且丌上七丅东与丁万;
        mem[1152921539203582340] = 且丌上七丅东与丁万.y;
        mem[1152921539203582344] = 且丌上七丅东与丁万.z;
        if(val_13 != true)
        {
                val_14 = public System.Int32 System.Collections.Generic.Queue<System.Single>::get_Count();
            int val_5 = this.丝业丆丆业且一丙丏.Count;
            if((System.Linq.Enumerable.Count<System.Single>(source:  System.Linq.Enumerable.Where<System.Single>(source:  this.丝业丆丆业且一丙丏, predicate:  new System.Func<System.Single, System.Boolean>(object:  val_1, method:  System.Boolean SquareFieldTouch.丛东丟丅丙丗世丗不::丟丄丂与与丘丒丙丙(float 三丟东丕丄丄下下丑))))) <= (((val_5 < 0) ? (val_5 + 1) : (val_5)) >> 1))
        {
                return;
        }
        
        }
        
        if(this.draggingCell == null)
        {
            goto label_5;
        }
        
        if(val_13 == false)
        {
            goto label_6;
        }
        
        label_8:
        this.draggingCell.丘上丒丟丞世丐丑业 = false;
        goto label_9;
        label_5:
        if(val_13 == true)
        {
            goto label_8;
        }
        
        label_6:
        if(((this.draggingCell.丛丗东丑业丗七丈与 == true) ? 1 : 0) != ((this.draggingCell.丘上丒丟丞世丐丑业 == true) ? 1 : 0))
        {
                this.draggingCell.丘上丒丟丞世丐丑业 = this.draggingCell.丛丗东丑业丗七丈与;
        }
        
        label_9:
        val_13 = ClanFieldBuildController.丑七不且上丗丁一世();
        if(val_13 == 0)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒().下丗丒丕一与丏不丁(丌丝万上丅丒一丈丘:  this.draggingCell, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = (SquareFieldTouch.丛东丟丅丙丗世丗不)[1152921539203582320].且丌上七丅东与丁万, y = 且丌上七丅东与丁万.y, z = 且丌上七丅东与丁万.x});
    }
    public SquareFieldTouch()
    {
        this.丝业丆丆业且一丙丏 = new System.Collections.Generic.Queue<System.Single>();
        this.heightNumber = 13;
        this.万下与且下丘且三上 = 8;
        this.丏世专丙丐丘世丆不 = 12;
    }

}
