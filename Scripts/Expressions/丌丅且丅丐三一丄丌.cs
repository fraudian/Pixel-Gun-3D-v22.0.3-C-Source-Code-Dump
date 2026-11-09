using UnityEngine;

namespace Expressions
{
    internal class 丌丅且丅丐三一丄丌 : 业丏丄丙世一丗丕不
    {
        // Fields
        private readonly PGCompany.Attributes.丝万专丆丂丘丌世丟 不丟一丌东不业丙丛;
        
        // Properties
        public override Expressions.丈与业万万一与丗万 丒三丝一上丙专丗丒 { get; }
        
        // Methods
        internal 丌丅且丅丐三一丄丌(string 不丂专丕丐丞丄丟丄)
        {
            val_1 = new System.Object();
            mem[1152921540908843200] = 不丂专丕丐丞丄丟丄;
            System.ValueTuple<PGCompany.Attributes.丝万专丆丂丘丌世丟, System.Boolean> val_2 = PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丞丄万七万丒丅丛上(丞丕丒专一下丙业上:  不丂专丕丐丞丄丟丄);
            if(0 == 0)
            {
                    return;
            }
            
            this.不丟一丌东不业丙丛 = val_2.Item2;
        }
        public override Expressions.丈与业万万一与丗万 不业丙丒丂丞下丆丙()
        {
            return 2;
        }
        public override bool 丞丙东丌一三专丏不()
        {
            var val_2;
            if(this.不丟一丌东不业丙丛 == null)
            {
                goto label_1;
            }
            
            if(this.不丟一丌东不业丙丛.Type == 0)
            {
                goto label_2;
            }
            
            if(this.不丟一丌东不业丙丛 != null)
            {
                    return PGCompany.AttributeSystem.世丆丆丁与七不丁丞.丂丆世世丕丅丕丅上<System.Int32>(三丏丅下专丛七丒丂:  this.不丟一丌东不业丙丛.Type, 一业丑七东世丛丒丕:  PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  this.不丟一丌东不业丙丛.AttributeIndex, 丙业与丙丗丝不丈东:  this.不丟一丌东不业丙丛.Value));
            }
            
            return PGCompany.AttributeSystem.世丆丆丁与七不丁丞.丂丆世世丕丅丕丅上<System.Int32>(三丏丅下专丛七丒丂:  this.不丟一丌东不业丙丛.Type, 一业丑七东世丛丒丕:  PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  this.不丟一丌东不业丙丛.AttributeIndex, 丙业与丙丗丝不丈东:  this.不丟一丌东不业丙丛.Value));
            label_1:
            val_2 = 0;
            return (bool)val_2;
            label_2:
            val_2 = 1;
            return (bool)val_2;
        }
    
    }

}
