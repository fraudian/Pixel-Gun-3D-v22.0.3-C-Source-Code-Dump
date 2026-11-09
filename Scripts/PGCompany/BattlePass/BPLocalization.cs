using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPLocalization : MonoBehaviour
    {
        // Fields
        private string _locKey;
        private System.Collections.Generic.List<UILabel> _duplicateLables;
        private UILabel 丟丁万丞七三三丆丄;
        
        // Methods
        private void OnEnable()
        {
            this.丟丁万丞七三三丆丄 = this.GetComponent<UILabel>();
            this.丗三丗丒丏丐且丞丗();
        }
        private void 丗三丗丒丏丐且丞丗()
        {
            string val_12;
            string val_13;
            BPLocalization.世丞丒丅一专丌丐丏 val_1 = new BPLocalization.世丞丒丅一专丌丐丏();
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_3 == null)
            {
                    return;
            }
            
            string val_6 = System.String.Format(format:  "{0}_{1}", arg0:  this._locKey, arg1:  val_3.丕世丝七世与三丞一().ToLower());
            val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
            if(val_1 != null)
            {
                    val_13 = val_1;
                .业丝与丙不丛上下东 = val_12;
            }
            else
            {
                    val_13 = 16;
                mem[16] = val_12;
                val_12 = mem[16];
            }
            
            if((System.String.IsNullOrEmpty(value:  val_12)) != true)
            {
                    if((System.String.op_Equality(a:  val_6, b:  val_13)) == false)
            {
                goto label_11;
            }
            
            }
            
            mem[16] = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._locKey);
            label_11:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丟丁万丞七三三丆丄, 丕丗丘丑丛与丑业丒:  mem[16]);
            this._duplicateLables.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void BPLocalization.世丞丒丅一专丌丐丏::下不一丂下丕丂世东(UILabel 三丟东丕丄丄下下丑)));
        }
        public BPLocalization()
        {
            this._duplicateLables = new System.Collections.Generic.List<UILabel>();
        }
    
    }

}
