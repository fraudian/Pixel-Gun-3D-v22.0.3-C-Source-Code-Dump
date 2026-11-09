using UnityEngine;

namespace PGCompany
{
    internal class 丛丆与丄且丏与丕丟 : 下丌丐三且丑且七东
    {
        // Fields
        private string 丅丐丂丗丆丁丄丝不;
        
        // Properties
        internal override bool 上丒丂丘丂七丘丂七 { get; }
        
        // Methods
        internal override bool 丈丌丐不丙丕丕丆东()
        {
            return false;
        }
        internal override void 丗下丗丕丂丈万七丛()
        {
            this.丐丆三一不世万七丑();
        }
        private void 丐丆三一不世万七丑()
        {
            var val_9;
            System.Action<PGCompany.业丏世不丞丆不丈下> val_11;
            PGCompany.GameTaskActionSettings val_1 = new PGCompany.GameTaskActionSettings();
            if(val_1 != null)
            {
                    .Type = 71;
            }
            else
            {
                    mem[16] = 71;
            }
            
            .CompoundTag = "CreateCharacterButton";
            PGCompany.业丏世不丞丆不丈下 val_3 = new PGCompany.业丏世不丞丆不丈下(七丞丂丝丈七丙丒丏:  X21, 世丝丛上丑丙丝且丟:  PGCompany.丂丆下丙丙丘一七下.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_1, 三东丏丐丟三丕丈上:  0), 下丙与丂丟丅不七不:  "AccepNameAndPolicy");
            val_3.与世万世三丄丘丈三(三专丞东且丌丘专三:  new 丙上三东丟丒与丟丟(丁业三上丛丐且专东:  new System.Action(object:  this, method:  System.Void PGCompany.丛丆与丄且丏与丕丟::丈丏丕七丅丏东三不())));
            .Type = 100;
            (PGCompany.业丏世不丞丆不丈下)[1152921556039054416].下下丄且丅丂丝丏业.Add(item:  PGCompany.丂丆下丙丙丘一七下.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.GameTaskActionSettings(), 三东丏丐丟三丕丈上:  0));
            val_9 = null;
            val_9 = null;
            val_11 = 丛丆与丄且丏与丕丟.<>c.<>9__3_1;
            if(val_11 == null)
            {
                    System.Action<PGCompany.业丏世不丞丆不丈下> val_8 = null;
                val_11 = val_8;
                val_8 = new System.Action<PGCompany.业丏世不丞丆不丈下>(object:  丛丆与丄且丏与丕丟.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丛丆与丄且丏与丕丟.<>c::丒丒丘丆丁丑丂丅东(PGCompany.业丏世不丞丆不丈下 万丅丘丘丂丘业不七));
                丛丆与丄且丏与丕丟.<>c.<>9__3_1 = val_11;
            }
            
            val_3.丒丆不七丏丂丛丕世(丙业与丙丗丝不丈东:  val_8);
            this.Add(item:  val_3);
        }
        private void 七下丛七丗上东丌专()
        {
            var val_11;
            if(AskNameManager.丙丗业三丅丟三丙业() != false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丅丐丂丗丆丁丄丝不));
            val_11 = null;
            val_11 = null;
            val_3.transform.SetParent(p:  MainMenuController.丄丞丁丈与业上丞丟.专丑丆不不专七丝下().transform);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            val_3.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_3.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public 丛丆与丄且丏与丕丟()
        {
            this.丅丐丂丗丆丁丄丝不 = "AskNamePlayer";
        }
        private void 丈丏丕七丅丏东三不()
        {
            var val_2;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
            {
                    return;
            }
            
            this.七下丛七丗上东丌专();
            val_2 = null;
            val_2 = null;
            if(AskNameManager.丄丘七三上丕世丞业 != null)
            {
                    AskNameManager.丄丘七三上丕世丞业.丂丒丅丛丂丙丁丕丄();
            }
            
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  21);
        }
    
    }

}
