using UnityEngine;

namespace Rilisoft
{
    public class 丄丕丏东丆丌七与且
    {
        // Fields
        internal static Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑[] 丟世丑专丅丌丙丏业;
        public string 丐丕丕万丛丙丗与不;
        public short 丛丌丞丘丟丒七丌专;
        public int 下丄丈不与世丐业专;
        public Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 万丁一东丞丗丄丑业;
        public string 丗丅上丙丅与丒丞丗;
        public string 丌丛丏丂丞丒万下丂;
        public short 丒业上丑丙且专上业;
        public Rilisoft.丄丕丏东丆丌七与且.丗万丞丅丆且丈丗丐 丌丁不丑丛丄丁丁丒;
        
        // Methods
        private static 丄丕丏东丆丌七与且()
        {
            Rilisoft.丄丕丏东丆丌七与且.丟世丑专丅丌丙丏业 = new 丟丙世丙不丛丈下丑[0];
            Rilisoft.丄丕丏东丆丌七与且.丟世丑专丅丌丙丏业 = System.Linq.Enumerable.ToArray<丟丙世丙不丛丈下丑>(source:  System.Linq.Enumerable.Cast<丟丙世丙不丛丈下丑>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))));
        }
        public 丄丕丏东丆丌七与且(Rilisoft.丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 七丆丒与丗丌丄且丂, Rilisoft.丄丕丏东丆丌七与且.丗万丞丅丆且丈丗丐 丁丅丈丌丟世丗丗丟, int 丞丅上丏丂且下丅与, string 丟丒丏丛三丟丑丗丝, string 丁丕且丏丘丝东丆万, string 丅万与丒丈丗丏丗丛, short 不丛丅丞丐丞且丒丈 = 2, short 丁丁丛丗丏三丁万东 = -1)
        {
            this.下丄丈不与世丐业专 = 0;
            this.丛丌丞丘丟丒七丌专 = 65535;
            this.丐丕丕万丛丙丗与不 = System.String.alignConst;
            this.丗丅上丙丅与丒丞丗 = System.String.alignConst;
            this.丒业上丑丙且专上业 = 65535;
            this.丌丛丏丂丞丒万下丂 = System.String.alignConst;
            val_1 = new System.Object();
            this.下丄丈不与世丐业专 = 丞丅上丏丂且下丅与;
            this.万丁一东丞丗丄丑业 = 七丆丒与丗丌丄且丂;
            this.丌丁不丑丛丄丁丁丒 = 丁丅丈丌丟世丗丗丟;
            this.丐丕丕万丛丙丗与不 = 丁丕且丏丘丝东丆万;
            this.丗丅上丙丅与丒丞丗 = val_1;
            this.丌丛丏丂丞丒万下丂 = 丅万与丒丈丗丏丗丛;
            this.丒业上丑丙且专上业 = 不丛丅丞丐丞且丒丈;
            this.丛丌丞丘丟丒七丌专 = 丁丁丛丗丏三丁万东;
        }
        public override string ToString()
        {
            object[] val_1 = new object[6];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.万丁一东丞丗丄丑业 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.万丁一东丞丗丄丑业 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.万丁一东丞丗丄丑业;
            val_1[1] = this.丌丁不丑丛丄丁丁丒;
            val_1[2] = this.丗丅上丙丅与丒丞丗;
            val_1[3] = this.丐丕丕万丛丙丗与不;
            val_1[4] = this.丌丛丏丂丞丒万下丂;
            val_1[5] = this.下丄丈不与世丐业专;
            return (string)System.String.Format(format:  "[LoadingTip] Category {0}, Type {1}, LocalKey {2}, AssistantImageTag {3}, ObjectImageTag {4}, Id {5}", args:  val_1);
        }
    
    }

}
