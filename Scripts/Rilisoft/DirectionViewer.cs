using UnityEngine;

namespace Rilisoft
{
    public class DirectionViewer : MonoBehaviour
    {
        // Fields
        private readonly System.Collections.Generic.List<Rilisoft.DirectionPointer> 丆丄丐丄丄东业东丝;
        private readonly System.Collections.Generic.Dictionary<Rilisoft.专丂下上东丛专丗七, System.Collections.Generic.Queue<Rilisoft.DirectionPointer>> 丆丒丆丆丆丏丆丗丗;
        private UIPanel _panel;
        private System.Collections.Generic.List<Rilisoft.DirectionViewerSettings> _settings;
        private static Rilisoft.DirectionViewer <不丁丄七丛不丆丁丕>k__BackingField;
        
        // Properties
        internal static Rilisoft.DirectionViewer 丆丕丝丒不丙且丐丗 { get; set; }
        
        // Methods
        internal static Rilisoft.DirectionViewer 丑七不且上丗丁一世()
        {
            return (Rilisoft.DirectionViewer)Rilisoft.DirectionViewer.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.DirectionViewer 丙业与丙丗丝不丈东)
        {
            Rilisoft.DirectionViewer.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            var val_6;
            if((Rilisoft.DirectionViewer.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                    return;
            }
            
            Rilisoft.DirectionViewer.<不丁丄七丛不丆丁丕>k__BackingField = this;
            this.丆丄丐丄丄东业东丝.Clear();
            this.丆丒丆丆丆丏丆丗丗.Clear();
            List.Enumerator<T> val_4 = System.Linq.Enumerable.ToList<Rilisoft.DirectionPointer>(source:  this.GetComponentsInChildren<Rilisoft.DirectionPointer>(includeInactive:  true)).GetEnumerator();
            label_18:
            if(((-1134684960) & 1) == 0)
            {
                goto label_9;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if((this.丆丒丆丆丆丏丆丗丗.ContainsKey(key:  W22)) == false)
            {
                goto label_12;
            }
            
            this.丆丒丆丆丆丏丆丗丗.Item[W22].Enqueue(item:  val_7);
            goto label_18;
            label_12:
            System.Collections.Generic.Queue<Rilisoft.DirectionPointer> val_10 = new System.Collections.Generic.Queue<Rilisoft.DirectionPointer>();
            null.Enqueue(item:  val_7);
            this.丆丒丆丆丆丏丆丗丗.Add(key:  val_7, value:  null);
            goto label_18;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void OnDisable()
        {
            System.Linq.Enumerable.ToList<Rilisoft.DirectionPointer>(source:  this.丆丄丐丄丄东业东丝).ForEach(action:  new System.Action<Rilisoft.DirectionPointer>(object:  this, method:  System.Void Rilisoft.DirectionViewer::丑丁丘丕丐丑丝丈不(Rilisoft.DirectionPointer 七丏丄丅丌业与且丙)));
        }
        private void LateUpdate()
        {
            null = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                    return;
            }
            
            int val_2 = this.丆丄丐丄丄东业东丝.Count;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                this.丕专丞万丛丗不一丞(一丛丆丛不丗专丏丘:  this.丆丄丐丄丄东业东丝.Item[0]);
                val_4 = val_4 + 1;
            }
            while(val_2 != val_4);
        
        }
        public void LookToMe(Rilisoft.DirectionViewerTarget 丞下万上三丘上与专)
        {
            Rilisoft.DirectionViewerTarget val_10;
            var val_11;
            val_10 = 丞下万上三丘上与专;
            DirectionViewer.丗丛丘丑丐不丌丑丙 val_1 = new DirectionViewer.丗丛丘丑丐不丌丑丙();
            if(val_1 != null)
            {
                    val_11 = val_1;
                .丞下万上三丘上与专 = val_10;
            }
            else
            {
                    val_11 = 16;
                mem[16] = val_10;
                val_10 = mem[16];
            }
            
            if(val_10 == 0)
            {
                    return;
            }
            
            val_10 = this.丆丄丐丄丄东业东丝;
            if((System.Linq.Enumerable.Any<Rilisoft.DirectionPointer>(source:  val_10, predicate:  new System.Func<Rilisoft.DirectionPointer, System.Boolean>(object:  val_1, method:  System.Boolean DirectionViewer.丗丛丘丑丐不丌丑丙::丗不七与三不丘丂丟(Rilisoft.DirectionPointer 七丏丄丅丌业与且丙)))) == true)
            {
                    return;
            }
            
            val_10 = this.丆丒丆丆丆丏丆丗丗;
            if((val_10.ContainsKey(key:  丞下万上三丘上与专 + 32)) == false)
            {
                    return;
            }
            
            val_10 = this.丆丒丆丆丆丏丆丗丗.Item[丞下万上三丘上与专 + 32];
            if(val_10.Count == 0)
            {
                    return;
            }
            
            Rilisoft.DirectionPointer val_9 = this.丆丒丆丆丆丏丆丗丗.Item[丞下万上三丘上与专 + 32].Dequeue();
            this.丆丄丐丄丄东业东丝.Add(item:  val_9);
            val_9.TurnOn(一丛丆丛不丗专丏丘:  mem[16]);
        }
        public void ForgetMe(Rilisoft.DirectionViewerTarget 丞下万上三丘上与专)
        {
            .丞下万上三丘上与专 = 丞下万上三丘上与专;
            Rilisoft.DirectionPointer val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.DirectionPointer>(source:  this.丆丄丐丄丄东业东丝, predicate:  new System.Func<Rilisoft.DirectionPointer, System.Boolean>(object:  new DirectionViewer.丒丛丁与丅东丒不七(), method:  System.Boolean DirectionViewer.丒丛丁与丅东丒不七::世丁丈一东丆不丒东(Rilisoft.DirectionPointer 七丏丄丅丌业与且丙)));
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.<专东三丅业丄丈七丈>k__BackingField = 0;
            val_3.OutOfRange = false;
            val_3.Hide();
            bool val_5 = this.丆丄丐丄丄东业东丝.Remove(item:  val_3);
            this.丆丒丆丆丆丏丆丗丗.Item[val_3._forPointerType].Enqueue(item:  val_3);
        }
        private void 专丈不丝专丑丏丟万(Rilisoft.DirectionPointer 一丛丆丛不丗专丏丘)
        {
            一丛丆丛不丗专丏丘.<专东三丅业丄丈七丈>k__BackingField = 0;
            一丛丆丛不丗专丏丘.OutOfRange = false;
            一丛丆丛不丗专丏丘.Hide();
            if((this.丆丄丐丄丄东业东丝.Contains(item:  一丛丆丛不丗专丏丘)) == false)
            {
                    return;
            }
            
            bool val_2 = this.丆丄丐丄丄东业东丝.Remove(item:  一丛丆丛不丗专丏丘);
            this.丆丒丆丆丆丏丆丗丗.Item[一丛丆丛不丗专丏丘._forPointerType].Enqueue(item:  一丛丆丛不丗专丏丘);
        }
        private bool 丌丆七丐万上世与丞(Rilisoft.DirectionViewerTarget 丄不不丄三丐丛丂丑)
        {
            UnityEngine.Object val_11;
            var val_12;
            WeaponManager val_13;
            var val_14;
            var val_15;
            val_11 = 丄不不丄三丐丛丂丑;
            val_12 = null;
            val_12 = null;
            val_13 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_13 != 0)
            {
                    if(val_11 != 0)
            {
                goto label_8;
            }
            
            }
            
            val_14 = 0;
            return (bool)(val_7.x < 0) ? 1 : 0;
            label_8:
            val_15 = null;
            val_15 = null;
            UnityEngine.Vector3 val_4 = transform.position;
            val_13 = val_11.Transform;
            UnityEngine.Vector3 val_6 = val_13.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_11 = this.与丄丆丁丘东丝下七(丁丅丈丌丟世丗丗丟:  丄不不丄三丐丛丂丑._Type);
            float val_9 = val_8.LookRadius * val_8.LookRadius;
            return (bool)(val_7.x < 0) ? 1 : 0;
        }
        private void 丕专丞万丛丗不一丞(Rilisoft.DirectionPointer 一丛丆丛不丗专丏丘)
        {
            UnityEngine.Transform val_13;
            var val_14;
            Rilisoft.DirectionViewerTarget val_15;
            var val_16;
            val_14 = 一丛丆丛不丗专丏丘;
            if(val_14 == null)
            {
                goto label_1;
            }
            
            val_15 = val_14;
            if((this.丌丆七丐万上世与丞(丄不不丄三丐丛丂丑:  一丛丆丛不丗专丏丘.<专东三丅业丄丈七丈>k__BackingField)) == true)
            {
                goto label_2;
            }
            
            一丛丆丛不丗专丏丘.OutOfRange = true;
            goto label_3;
            label_1:
            val_15 = 48;
            val_13 = this.丌丆七丐万上世与丞(丄不不丄三丐丛丂丑:  0);
            if(val_13 == false)
            {
                goto label_4;
            }
            
            label_2:
            if(一丛丆丛不丗专丏丘.OutOfRange != false)
            {
                    一丛丆丛不丗专丏丘.OutOfRange = false;
                val_14.TurnOn(一丛丆丛不丗专丏丘:  val_15);
            }
            
            val_16 = null;
            val_16 = null;
            val_13 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform;
            UnityEngine.Vector3 val_5 = 0.transform.position;
            float val_13 = val_5.y;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            Rilisoft.DirectionViewerSettings val_8 = this.与丄丆丁丘东丝下七(丁丅丈丌丟世丗丗丟:  一丛丆丛不丗专丏丘._forPointerType);
            val_14 = val_14.transform;
            val_13 = (this.丞丛丛丈三且丞世丟(丈丗与丞一上且上上:  val_13, 丞下万上三丘上与专:  new UnityEngine.Vector3() {x = val_5.x, y = val_13, z = val_5.z}, 丏丟万且丝丒丝丅东:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) * 0.01745329f;
            UnityEngine.Vector3 val_10 = val_14.position;
            float val_11 = val_8.CircleRadius * val_13;
            float val_12 = val_8.CircleRadius * val_13;
            val_14.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
            label_4:
            mem[40] = 1;
            label_3:
            val_14.Hide();
        }
        private float 丞丛丛丈三且丞世丟(UnityEngine.Transform 丈丗与丞一上且上上, UnityEngine.Vector3 丞下万上三丘上与专, UnityEngine.Vector3 丏丟万且丝丒丝丅东)
        {
            UnityEngine.Vector3 val_1 = 丈丗与丞一上且上上.forward;
            UnityEngine.Vector3 val_2 = 丈丗与丞一上且上上.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丞下万上三丘上与专.x, y = 丞下万上三丘上与专.y, z = 丞下万上三丘上与专.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            float val_7 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丏丟万且丝丒丝丅东.x, y = 丏丟万且丝丒丝丅东.y, z = 丏丟万且丝丒丝丅东.z}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_7 = val_7 * 57.29578f;
            return (float)val_7;
        }
        private Rilisoft.DirectionViewerSettings 与丄丆丁丘东丝下七(Rilisoft.专丂下上东丛专丗七 丁丅丈丌丟世丗丗丟)
        {
            .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
            return System.Linq.Enumerable.First<Rilisoft.DirectionViewerSettings>(source:  this._settings, predicate:  new System.Func<Rilisoft.DirectionViewerSettings, System.Boolean>(object:  new DirectionViewer.三丅丞丒丕丅专一丅(), method:  System.Boolean DirectionViewer.三丅丞丒丕丅专一丅::丂丁丁丏丂业丝丝万(Rilisoft.DirectionViewerSettings 丏丛与丅丛丌万专丌)));
        }
        public DirectionViewer()
        {
            this.丆丄丐丄丄东业东丝 = new System.Collections.Generic.List<Rilisoft.DirectionPointer>();
            this.丆丒丆丆丆丏丆丗丗 = new System.Collections.Generic.Dictionary<Rilisoft.专丂下上东丛专丗七, System.Collections.Generic.Queue<Rilisoft.DirectionPointer>>();
            System.Collections.Generic.List<Rilisoft.DirectionViewerSettings> val_3 = new System.Collections.Generic.List<Rilisoft.DirectionViewerSettings>();
            Rilisoft.DirectionViewerSettings val_4 = null;
            .CircleRadius = 200f;
            .LookRadius = 10f;
            val_4 = new Rilisoft.DirectionViewerSettings();
            if(val_4 != null)
            {
                    .ForType = 0;
            }
            else
            {
                    .ForType = 0;
                .LookRadius = 10f;
            }
            
            .CircleRadius = 200f;
            val_3.Add(item:  val_4);
            Rilisoft.DirectionViewerSettings val_5 = null;
            .CircleRadius = 200f;
            .LookRadius = 10f;
            val_5 = new Rilisoft.DirectionViewerSettings();
            if(val_5 != null)
            {
                    .ForType = 1;
            }
            else
            {
                    .ForType = 1;
                .LookRadius = 1000f;
            }
            
            .CircleRadius = 400f;
            val_3.Add(item:  val_5);
            this._settings = val_3;
        }
        private void 丑丁丘丕丐丑丝丈不(Rilisoft.DirectionPointer 七丏丄丅丌业与且丙)
        {
            this.专丈不丝专丑丏丟万(一丛丆丛不丗专丏丘:  七丏丄丅丌业与且丙);
        }
    
    }

}
