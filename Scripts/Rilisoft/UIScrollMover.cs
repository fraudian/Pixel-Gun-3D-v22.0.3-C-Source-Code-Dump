using UnityEngine;

namespace Rilisoft
{
    public sealed class UIScrollMover : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _itemsContainer;
        private bool 下丒且丐丈三丑丒丗;
        private UIScrollView 业丘丘丕专丞丅丈丙;
        public bool DetectEmptySides;
        public bool InstantMoving;
        public float MoveSpeed;
        
        // Properties
        public bool 丈丛丂丘丝丑下专不 { get; }
        private UnityEngine.GameObject 上丁东且东丕丙丈丒 { get; }
        
        // Methods
        public bool get_IsMoving()
        {
            return (bool)this.下丒且丐丈三丑丒丗;
        }
        private UnityEngine.GameObject 上丙丅丌丒丁东丁东()
        {
            if(this._itemsContainer != 0)
            {
                    return (UnityEngine.GameObject)this._itemsContainer;
            }
            
            UIGrid val_4 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIGrid>(丄三丅七丆丛与与上:  this.业丘丘丕专丞丅丈丙.GetComponentInChildren<UIGrid>(), 七丐丅专且专七三丆:  new System.Action<UIGrid>(object:  this, method:  System.Void Rilisoft.UIScrollMover::丛丙丗丝丐丕专丙七(UIGrid 丝三不丑丏丘丒丂丗)));
            return (UnityEngine.GameObject)this._itemsContainer;
        }
        private void Awake()
        {
            this.业丘丘丕专丞丅丈丙 = this.GetComponent<UIScrollView>();
        }
        private void Start()
        {
            this.业丘丘丕专丞丅丈丙.gameObject.GetComponent<UIPanel>().UpdateAnchors();
        }
        private void OnDisable()
        {
            this.StopAllCoroutines();
            this.丙丘七丅且丆东与世();
        }
        private System.Collections.Generic.IEnumerable<UnityEngine.Transform> 丙万丗丑丐专且与丈()
        {
            var val_4;
            System.Func<UnityEngine.GameObject, UnityEngine.Transform> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = UIScrollMover.<>c.<>9__13_0;
            if(val_6 != null)
            {
                    return System.Linq.Enumerable.Select<UnityEngine.GameObject, UnityEngine.Transform>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.上丙丅丌丒丁东丁东()), selector:  System.Func<UnityEngine.GameObject, UnityEngine.Transform> val_3 = null);
            }
            
            val_6 = val_3;
            val_3 = new System.Func<UnityEngine.GameObject, UnityEngine.Transform>(object:  UIScrollMover.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Transform UIScrollMover.<>c::丒不丏丕丗丆一丕万(UnityEngine.GameObject 丄三丅七丆丛与与上));
            UIScrollMover.<>c.<>9__13_0 = val_6;
            return System.Linq.Enumerable.Select<UnityEngine.GameObject, UnityEngine.Transform>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.上丙丅丌丒丁东丁东()), selector:  val_3);
        }
        public void MoveTo(int 丂丌丑且东世丁且且, System.Action 丙丒丝丂丛丗东丄一)
        {
            var val_27;
            System.Func<UnityEngine.Transform, System.Single> val_29;
            if((this.业丘丘丕专丞丅丈丙 & 1) != 0)
            {
                    val_27 = null;
                val_27 = null;
                val_29 = UIScrollMover.<>c.<>9__14_0;
                if(val_29 == null)
            {
                    System.Func<UnityEngine.Transform, System.Single> val_2 = null;
                val_29 = val_2;
                val_2 = new System.Func<UnityEngine.Transform, System.Single>(object:  UIScrollMover.<>c.__il2cppRuntimeField_static_fields, method:  System.Single UIScrollMover.<>c::不丙七丁业丘丁专丂(UnityEngine.Transform 七丞丙丒三丕且丌丟));
                UIScrollMover.<>c.<>9__14_0 = val_29;
            }
            
                System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<UnityEngine.Transform>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.Transform, System.Single>(source:  this.丙万丗丑丐专且与丈(), keySelector:  val_2));
                if((丂丌丑且东世丁且且 & 2147483648) != 0)
            {
                    return;
            }
            
                if(val_4.Count < 3)
            {
                    return;
            }
            
                if((val_4.Count - 1) < 丂丌丑且东世丁且且)
            {
                    return;
            }
            
                UIPanel val_10 = this.业丘丘丕专丞丅丈丙.panel;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.5f);
                UnityEngine.Transform val_14 = this.业丘丘丕专丞丅丈丙.panel.cachedTransform;
                UnityEngine.Vector3 val_16 = val_4.Item[丂丌丑且东世丁且且].transform.position;
                UnityEngine.Vector3 val_17 = val_14.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
                UnityEngine.Vector3 val_18 = val_14.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                float val_27 = (float)val_4.Count;
                val_27 = this.MoveSpeed * val_27;
                bool val_22 = this.业丘丘丕专丞丅丈丙.canMoveVertically;
                UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  this.丗业万下丕丁丟丞丈(丛上丙丄丄七丈且丅:  (this.业丘丘丕专丞丅丈丙.canMoveHorizontally != true) ? val_19.x : 0f, 东丛丌丆丅世丐不丒:  this.业丘丘丕专丞丅丈丙.canMoveHorizontally, 丏丈三丛业不专丑业:  this.DetectEmptySides, 东丗上东丘丄东丘世:  val_27, 丙丒丝丂丛丗东丄一:  丙丒丝丂丛丗东丄一));
                return;
            }
            
            if(丙丒丝丂丛丗东丄一 == null)
            {
                    return;
            }
            
            丙丒丝丂丛丗东丄一.Invoke();
        }
        private System.Collections.IEnumerator 丗业万下丕丁丟丞丈(float 丛上丙丄丄七丈且丅, bool 东丛丌丆丅世丐不丒, bool 丏丈三丛业不专丑业, float 东丗上东丘丄东丘世, System.Action 丙丒丝丂丛丗东丄一)
        {
            UIScrollMover.业丈丄上东丙东丌丛 val_1 = new UIScrollMover.业丈丄上东丙东丌丛();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .东丛丌丆丅世丐不丒 = 东丛丌丆丅世丐不丒;
                .丏丈三丛业不专丑业 = 丏丈三丛业不专丑业;
                .丛上丙丄丄七丈且丅 = 丛上丙丄丄七丈且丅;
                .东丗上东丘丄东丘世 = 东丗上东丘丄东丘世;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 丛上丙丄丄七丈且丅;
                mem[56] = 东丛丌丆丅世丐不丒;
                .丏丈三丛业不专丑业 = 丏丈三丛业不专丑业;
                .东丗上东丘丄东丘世 = 东丗上东丘丄东丘世;
            }
            
            .丙丒丝丂丛丗东丄一 = 丙丒丝丂丛丗东丄一;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丙丘七丅且丆东与世()
        {
            this.下丒且丐丈三丑丒丗 = false;
            this.业丘丘丕专丞丅丈丙.enabled = true;
            this.业丘丘丕专丞丅丈丙.restrictWithinPanel = true;
        }
        public UIScrollMover()
        {
            this.DetectEmptySides = true;
            this.MoveSpeed = 1f;
        }
        private void 丛丙丗丝丐丕专丙七(UIGrid 丝三不丑丏丘丒丂丗)
        {
            this._itemsContainer = 丝三不丑丏丘丒丂丗.gameObject;
        }
    
    }

}
