using UnityEngine;

namespace PGCompany
{
    public sealed class TutorialResourceUI : PGBehaviour
    {
        // Fields
        private string 丌丄丟丂丆丑下丐世;
        private UnityEngine.Transform 丘不丟丈三丈上七丆;
        private UnityEngine.Vector3 专一丌七专不一丘与;
        private string 丅七丁丐丑丐三上下;
        private static int 丞丌丏丕业丛丂世丑;
        
        // Properties
        public string 不丌七丆丏丂丐万丂 { get; }
        public UnityEngine.Transform 丝丗七世东业三丒专 { get; }
        internal static bool 丅业东万丌丕上丌丄 { get; }
        
        // Methods
        public string get_UniqueId()
        {
            return (string)this.丅七丁丐丑丐三上下;
        }
        public UnityEngine.Transform get_AnchorTransform()
        {
            return (UnityEngine.Transform)this.丘不丟丈三丈上七丆;
        }
        internal static bool 丈丐丞丐上丑且丕万()
        {
            return (bool)(PGCompany.TutorialResourceUI.丞丌丏丕业丛丂世丑 > 0) ? 1 : 0;
        }
        internal void 丈且东丑丂且万丒丅(string 丛丄业丕且丗下一万, UnityEngine.Transform 与东三丞三且丟七与, string 与一七丘丏与万丒七)
        {
            this.丌丄丟丂丆丑下丐世 = 丛丄业丕且丗下一万;
            this.丘不丟丈三丈上七丆 = 与东三丞三且丟七与;
            UnityEngine.Vector3 val_1 = 与东三丞三且丟七与.localPosition;
            this.专一丌七专不一丘与 = val_1;
            mem[1152921556096258428] = val_1.y;
            mem[1152921556096258432] = val_1.z;
            this.丅七丁丐丑丐三上下 = 与一七丘丏与万丒七;
            this.七万丞一丑七丟丂万();
        }
        private void OnEnable()
        {
            int val_1 = PGCompany.TutorialResourceUI.丞丌丏丕业丛丂世丑;
            val_1 = val_1 + 1;
            PGCompany.TutorialResourceUI.丞丌丏丕业丛丂世丑 = val_1;
        }
        private void OnDisable()
        {
            PGCompany.TutorialResourceUI.丞丌丏丕业丛丂世丑 = System.Math.Max(val1:  0, val2:  PGCompany.TutorialResourceUI.丞丌丏丕业丛丂世丑 - 1);
        }
        private void 七万丞一丑七丟丂万()
        {
            UnityEngine.GameObject val_3 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丌丄丟丂丆丑下丐世), 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄(), 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        private void 七丒下丂丝且丕丌东()
        {
            if(this.丘不丟丈三丈上七丆 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.丘不丟丈三丈上七丆.localPosition;
            this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Transform val_4 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            UnityEngine.Vector3 val_6 = this.丕业丈一世丂三丒丐();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        private UnityEngine.Vector3 丕业丈一世丂三丒丐()
        {
            null = null;
            PGCompany.TutorialHintUiSettings val_2 = UnityEngine.Resources.Load<PGCompany.TutorialHintUiSettings>(path:  System.IO.Path.Combine(path1:  PGCompany.丈丌上丑丌上丅七东.且专三丁丐世丞丅丕, path2:  "SO", path3:  this.丅七丁丐丑丐三上下));
            if(val_2 == 0)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            if(val_2 != null)
            {
                    return new UnityEngine.Vector3() {x = val_2.resourceOffset};
            }
            
            return new UnityEngine.Vector3() {x = val_2.resourceOffset};
        }
        private void Update()
        {
            this.七丒下丂丝且丕丌东();
        }
        public TutorialResourceUI()
        {
        
        }
    
    }

}
