using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPChallengeConditionsContainerView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.BattlePass.丘丄上丏不丝不丐丐>
    {
        // Fields
        private PGCompany.BattlePass.丘丄上丏不丝不丐丐 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Collections.Generic.List<UILabel> _descriptions;
        private UITable _table;
        
        // Properties
        public PGCompany.BattlePass.丘丄上丏不丝不丐丐 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public PGCompany.BattlePass.丘丄上丏不丝不丐丐 get_Context()
        {
            return (PGCompany.BattlePass.丘丄上丏不丝不丐丐)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.BattlePass.丘丄上丏不丝不丐丐 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(PGCompany.BattlePass.丘丄上丏不丝不丐丐 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            string val_25;
            val_21 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.String> val_1 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄丆世丌丒世业丅下();
            val_22 = 1152921524394922096;
            val_23 = 1152921516934571616;
            val_24 = 0;
            goto label_2;
            label_16:
            UILabel val_2 = this._descriptions.Item[0];
            if(val_2 != 0)
            {
                    if(val_24 > (val_1.Count - 1))
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  false);
            }
            else
            {
                    val_25 = val_1.Item[0];
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_2, 丕丗丘丑丛与丑业丒:  val_25);
            }
            
            }
            
            val_24 = 1;
            label_2:
            if(val_24 < this._descriptions.Count)
            {
                goto label_16;
            }
            
            if(this._table == 0)
            {
                    return;
            }
            
            this._table.repositionNow = true;
            val_21 = ???;
            val_24 = ???;
            val_25 = ???;
            val_22 = ???;
            val_23 = ???;
            goto typeof(UITable).__il2cppRuntimeField_1A8;
        }
        public BPChallengeConditionsContainerView()
        {
        
        }
    
    }

}
