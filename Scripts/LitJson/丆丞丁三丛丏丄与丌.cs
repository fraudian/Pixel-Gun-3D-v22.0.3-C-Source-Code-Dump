using UnityEngine;

namespace LitJson
{
    public class 丆丞丁三丛丏丄与丌
    {
        // Fields
        private static System.Globalization.NumberFormatInfo 丈不丅丗下丕丈丂与;
        private LitJson.且丌丞丐丟七一丕业 与且专丈不万东一万;
        private System.Collections.Generic.Stack<LitJson.且丌丞丐丟七一丕业> 丏一一丂专下一万丅;
        private bool 丁三丑丒丄三下不一;
        private char[] 万万丂三丘丟丌丄且;
        private int 与丑东丈丗专上丂丝;
        private int 一且丄丒丈丏不丁且;
        private System.Text.StringBuilder 丛与丛丆丙丛万与七;
        private bool 丅下丂丂丂丄专丅丁;
        private bool 丛上上业不三且丞丘;
        private System.IO.TextWriter 业专丘专七丕丟丅与;
        
        // Properties
        public int 且专丘丆丟且丈七丏 { get; set; }
        public bool 丂丆不世丄丑东丒丈 { get; set; }
        public System.IO.TextWriter 丘丐三世下丟丙丘丂 { get; }
        public bool 丏且丕丄世丕不丕丙 { get; set; }
        
        // Methods
        public int 业万三丆且丈丐与与()
        {
            return (int)this.一且丄丒丈丏不丁且;
        }
        public void 与丙丕丈丗上与丕业(int 丙业与丙丗丝不丈东)
        {
            int val_1 = this.与丑东丈丗专上丂丝;
            val_1 = val_1 / this.一且丄丒丈丏不丁且;
            val_1 = val_1 * 丙业与丙丗丝不丈东;
            this.与丑东丈丗专上丂丝 = val_1;
            this.一且丄丒丈丏不丁且 = 丙业与丙丗丝不丈东;
        }
        public bool 世丙专丈东丒万丗丗()
        {
            return (bool)this.丅下丂丂丂丄专丅丁;
        }
        public void 七专不丈业丁丏丕丘(bool 丙业与丙丗丝不丈东)
        {
            this.丅下丂丂丂丄专丅丁 = 丙业与丙丗丝不丈东;
        }
        public System.IO.TextWriter 上世丌丈丅丛世丕丌()
        {
            return (System.IO.TextWriter)this.业专丘专七丕丟丅与;
        }
        public bool 丄不丌一丟丁下丙丂()
        {
            return (bool)this.丛上上业不三且丞丘;
        }
        public void 世不一丘丗丁上丐丙(bool 丙业与丙丗丝不丈东)
        {
            this.丛上上业不三且丞丘 = 丙业与丙丗丝不丈东;
        }
        private static 丆丞丁三丛丏丄与丌()
        {
            LitJson.丆丞丁三丛丏丄与丌.丈不丅丗下丕丈丂与 = System.Globalization.NumberFormatInfo.InvariantInfo;
        }
        public 丆丞丁三丛丏丄与丌()
        {
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            this.丛与丛丆丙丛万与七 = val_1;
            this.业专丘专七丕丟丅与 = new System.IO.StringWriter(sb:  val_1);
            this.丘上丐世丆丑且丞丒();
        }
        public 丆丞丁三丛丏丄与丌(System.Text.StringBuilder 东世丞七丏下不丘丞)
        {
            System.IO.StringWriter val_1 = new System.IO.StringWriter(sb:  东世丞七丏下不丘丞);
        }
        public 丆丞丁三丛丏丄与丌(System.IO.TextWriter 业专丘专七丕丟丅与)
        {
            if(业专丘专七丕丟丅与 != null)
            {
                    this.业专丘专七丕丟丅与 = 业专丘专七丕丟丅与;
                this.丘上丐世丆丑且丞丒();
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "writer");
        }
        private void 丞丈一与丕丒专丏丈(LitJson.丁丑丅丐丌不世丁下 不丂上丝丛丂丏丂丆)
        {
            LitJson.且丌丞丐丟七一丕业 val_2;
            LitJson.且丌丞丐丟七一丕业 val_3;
            int val_4;
            string val_6;
            val_2 = this;
            val_3 = this.与且专丈不万东一万;
            if(this.与且专丈不万东一万.丈丁一上丂世丌丅不 != true)
            {
                    val_3 = this.与且专丈不万东一万;
                if(val_3 != null)
            {
                    val_4 = this.与且专丈不万东一万.丒专下与丑丁丆丟业;
            }
            else
            {
                    val_3 = 16;
                val_4 = 11993091;
            }
            
                mem[16] = 11993092;
            }
            
            if(this.丛上上业不三且丞丘 == false)
            {
                    return;
            }
            
            if(this.丁三丑丒丄三下不一 == true)
            {
                goto label_6;
            }
            
            if(不丂上丝丛丂丏丂丆 > 4)
            {
                    return;
            }
            
            var val_2 = 106017576 + (不丂上丝丛丂丏丂丆) << 2;
            val_2 = val_2 + 106017576;
            goto (106017576 + (不丂上丝丛丂丏丂丆) << 2 + 106017576);
            label_6:
            val_6 = "A complete JSON symbol has already been written";
            label_32:
            null = new LitJson.丗世丗业丈丄丒丙丙(丄丙下丝丛丒七丂丘:  val_6);
            goto label_32;
        }
        private void 丘上丐世丆丑且丞丒()
        {
            this.丁三丑丒丄三下不一 = false;
            this.万万丂三丘丟丌丄且 = new char[4];
            this.与丑东丈丗专上丂丝 = 17179869184;
            this.一且丄丒丈丏不丁且 = 4;
            this.丅下丂丂丂丄专丅丁 = true;
            this.丛上上业不三且丞丘 = true;
            this.丏一一丂专下一万丅 = new System.Collections.Generic.Stack<LitJson.且丌丞丐丟七一丕业>();
            LitJson.且丌丞丐丟七一丕业 val_3 = new LitJson.且丌丞丐丟七一丕业();
            this.与且专丈不万东一万 = val_3;
            this.丏一一丂专下一万丅.Push(item:  val_3);
        }
        private static void 丅上丌专丄专丛世丐(int 丏丟万且丝丒丝丅东, char[] 丞上三丏且丕丅丗丌)
        {
            int val_5;
            int val_6 = 丏丟万且丝丒丝丅东;
            var val_5 = 0;
            goto label_6;
            label_4:
            val_5 = W23 + 48;
            if(X8 >= 丞上三丏且丕丅丗丌.Length)
            {
                goto label_1;
            }
            
            goto label_5;
            label_6:
            var val_2 = (val_6 < 0) ? (val_6 + 15) : (val_6);
            val_2 = val_2 & 4294967280;
            int val_3 = val_6 - val_2;
            if(val_3 <= 9)
            {
                goto label_4;
            }
            
            val_5 = val_3 + 55;
            if((val_5 + 3) < 丞上三丏且丕丅丗丌.Length)
            {
                goto label_5;
            }
            
            label_1:
            label_5:
            mem2[0] = val_5;
            val_5 = val_5 - 1;
            val_6 = val_6 >> 4;
            if(val_5 != 4)
            {
                goto label_6;
            }
        
        }
        private void 万万丑丑丑与不丑丗()
        {
            if(this.丅下丂丂丂丄专丅丁 == false)
            {
                    return;
            }
            
            int val_1 = this.与丑东丈丗专上丂丝;
            val_1 = this.一且丄丒丈丏不丁且 + val_1;
            this.与丑东丈丗专上丂丝 = val_1;
        }
        private void 世丐丘丏万万业业丈(string 下业七不丑丂丏丟东)
        {
            LitJson.且丌丞丐丟七一丕业 val_1;
            if(this.丅下丂丂丂丄专丅丁 != false)
            {
                    val_1 = this.与且专丈不万东一万;
                if((this.与且专丈不万东一万.丈丁一上丂世丌丅不 != true) && (this.与丑东丈丗专上丂丝 >= 1))
            {
                    var val_1 = 0;
                do
            {
                val_1 = this.业专丘专七丕丟丅与;
                val_1 = val_1 + 1;
            }
            while(val_1 < this.与丑东丈丗专上丂丝);
            
            }
            
            }
            
            if(this.业专丘专七丕丟丅与 == null)
            {
                
            }
        
        }
        private void 丄丙丐丑上丑丙丟丅()
        {
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
        }
        private void 丄丙丐丑上丑丙丟丅(bool 万丁丅丛万业丗一丘)
        {
            if(this.丅下丂丂丂丄专丅丁 == false)
            {
                    return;
            }
            
            if(this.与且专丈不万东一万.丈丁一上丂世丌丅不 != false)
            {
                    return;
            }
            
            if(this.业专丘专七丕丟丅与 == null)
            {
                
            }
        
        }
        private void 且且世专与丒丌专世(string 下业七不丑丂丏丟东)
        {
            System.IO.TextWriter val_13;
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  System.String.alignConst);
            int val_1 = 下业七不丑丂丏丟东.Length;
            if(val_1 < 1)
            {
                goto label_3;
            }
            
            var val_13 = 0;
            label_31:
            char val_3 = 下业七不丑丂丏丟东.Chars[0] & 65535;
            if((val_3 - 8) > '')
            {
                goto label_5;
            }
            
            var val_12 = 106017596 + (((val_2 & 65535) - 8)) << 2;
            val_12 = val_12 + 106017596;
            goto (106017596 + (((val_2 & 65535) - 8)) << 2 + 106017596);
            label_5:
            if(val_3 != '"')
            {
                    if(val_3 != '\')
            {
                goto label_9;
            }
            
            }
            
            label_17:
            val_13 = this.业专丘专七丕丟丅与;
            char val_5 = 下业七不丑丂丏丟东.Chars[0];
            if(val_13 != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_9:
            if((下业七不丑丂丏丟东.Chars[0] & 65535) >= ' ')
            {
                    if((下业七不丑丂丏丟东.Chars[0] & 65535) <= ('~'))
            {
                goto label_17;
            }
            
            }
            
            LitJson.丆丞丁三丛丏丄与丌.丅上丌专丄专丛世丐(丏丟万且丝丒丝丅东:  下业七不丑丂丏丟东.Chars[0] & 65535, 丞上三丏且丕丅丗丌:  this.万万丂三丘丟丌丄且);
            val_13 = this.业专丘专七丕丟丅与;
            label_13:
            val_13 = val_13 + 1;
            if(val_1 != val_13)
            {
                goto label_31;
            }
            
            label_3:
            if(this.业专丘专七丕丟丅与 == null)
            {
                
            }
        
        }
        private void 一丗丅不丙丐上世丛()
        {
            if(this.丅下丂丂丂丄专丅丁 == false)
            {
                    return;
            }
            
            int val_1 = this.与丑东丈丗专上丂丝;
            val_1 = val_1 - this.一且丄丒丈丏不丁且;
            this.与丑东丈丗专上丂丝 = val_1;
        }
        public override string ToString()
        {
            if(this.丛与丛丆丙丛万与七 == null)
            {
                    return (string)System.String.alignConst;
            }
            
            this = ???;
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        public void 且七丙丄丘一丄上不()
        {
            this.丁三丑丒丄三下不一 = false;
            this.丏一一丂专下一万丅.Clear();
            LitJson.且丌丞丐丟七一丕业 val_1 = new LitJson.且丌丞丐丟七一丕业();
            this.与且专丈不万东一万 = val_1;
            this.丏一一丂专下一万丅.Push(item:  val_1);
            if(this.丛与丛丆丙丛万与七 == null)
            {
                    return;
            }
            
            System.Text.StringBuilder val_3 = this.丛与丛丆丙丛万与七.Remove(startIndex:  0, length:  this.丛与丛丆丙丛万与七.Length);
        }
        public void 丐丞丆丙下上万业一(bool 丘丗丁丑丒一上丏与)
        {
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  4);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  (丘丗丁丑丒一上丏与 != true) ? "true" : "false");
            this.与且专丈不万东一万.丈丁一上丂世丌丅不 = false;
        }
        public void 丐丞丆丙下上万业一(decimal 丑丅世丐丒丏丐三丅)
        {
            var val_2;
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  4);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            val_2 = null;
            val_2 = null;
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  System.Convert.ToString(value:  new System.Decimal() {flags = 丑丅世丐丒丏丐三丅.flags, hi = 丑丅世丐丒丏丐三丅.hi, lo = 丑丅世丐丒丏丐三丅.lo, mid = 丑丅世丐丒丏丐三丅.mid}, provider:  LitJson.丆丞丁三丛丏丄与丌.丈不丅丗下丕丈丂与));
            this.与且专丈不万东一万.丈丁一上丂世丌丅不 = false;
        }
        public void 丐丞丆丙下上万业一(double 丑丅世丐丒丏丐三丅)
        {
            var val_4;
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  4);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            val_4 = null;
            val_4 = null;
            string val_1 = System.Convert.ToString(value:  丑丅世丐丒丏丐三丅, provider:  LitJson.丆丞丁三丛丏丄与丌.丈不丅丗下丕丈丂与);
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  val_1);
            if((val_1.IndexOf(value:  '.')) == 1)
            {
                    int val_3 = val_1.IndexOf(value:  'E');
            }
            
            this.与且专丈不万东一万.丈丁一上丂世丌丅不 = false;
        }
        public void 丐丞丆丙下上万业一(int 丑丅世丐丒丏丐三丅)
        {
            var val_2;
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  4);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            val_2 = null;
            val_2 = null;
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  System.Convert.ToString(value:  丑丅世丐丒丏丐三丅, provider:  LitJson.丆丞丁三丛丏丄与丌.丈不丅丗下丕丈丂与));
            this.与且专丈不万东一万.丈丁一上丂世丌丅不 = false;
        }
        public void 丐丞丆丙下上万业一(long 丑丅世丐丒丏丐三丅)
        {
            var val_2;
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  4);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            val_2 = null;
            val_2 = null;
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  System.Convert.ToString(value:  丑丅世丐丒丏丐三丅, provider:  LitJson.丆丞丁三丛丏丄与丌.丈不丅丗下丕丈丂与));
            this.与且专丈不万东一万.丈丁一上丂世丌丅不 = false;
        }
        public void 丐丞丆丙下上万业一(string 下业七不丑丂丏丟东)
        {
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  4);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            if(下业七不丑丂丏丟东 != null)
            {
                    this.且且世专与丒丌专世(下业七不丑丂丏丟东:  下业七不丑丂丏丟东);
            }
            else
            {
                    this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  "null");
            }
            
            this.与且专丈不万东一万.丈丁一上丂世丌丅不 = false;
        }
        public void 丐丞丆丙下上万业一(ulong 丑丅世丐丒丏丐三丅)
        {
            var val_2;
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  4);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            val_2 = null;
            val_2 = null;
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  System.Convert.ToString(value:  丑丅世丐丒丏丐三丅, provider:  LitJson.丆丞丁三丛丏丄与丌.丈不丅丗下丕丈丂与));
            this.与且专丈不万东一万.丈丁一上丂世丌丅不 = false;
        }
        public void 丙下丑丙下丘丄与丏()
        {
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  0);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  false);
            LitJson.且丌丞丐丟七一丕业 val_1 = this.丏一一丂专下一万丅.Pop();
            if(this.丏一一丂专下一万丅.Count == 1)
            {
                    this.丁三丑丒丄三下不一 = true;
            }
            else
            {
                    this.与且专丈不万东一万 = this.丏一一丂专下一万丅.Peek();
                val_3.丈丁一上丂世丌丅不 = false;
            }
            
            if(this.丅下丂丂丂丄专丅丁 != false)
            {
                    int val_4 = this.与丑东丈丗专上丂丝;
                val_4 = val_4 - this.一且丄丒丈丏不丁且;
                this.与丑东丈丗专上丂丝 = val_4;
            }
            
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  "]");
        }
        public void 东专丌丐丗丈丑丕丗()
        {
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  2);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  "[");
            this.与且专丈不万东一万 = new LitJson.且丌丞丐丟七一丕业();
            .丅且丂丌丈丟一丁丑 = true;
            this.丏一一丂专下一万丅.Push(item:  this.与且专丈不万东一万);
            if(this.丅下丂丂丂丄专丅丁 == false)
            {
                    return;
            }
            
            int val_2 = this.与丑东丈丗专上丂丝;
            val_2 = this.一且丄丒丈丏不丁且 + val_2;
            this.与丑东丈丗专上丂丝 = val_2;
        }
        public void 丘东上丒丄三下丑丌()
        {
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  1);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  false);
            LitJson.且丌丞丐丟七一丕业 val_1 = this.丏一一丂专下一万丅.Pop();
            if(this.丏一一丂专下一万丅.Count == 1)
            {
                    this.丁三丑丒丄三下不一 = true;
            }
            else
            {
                    this.与且专丈不万东一万 = this.丏一一丂专下一万丅.Peek();
                val_3.丈丁一上丂世丌丅不 = false;
            }
            
            if(this.丅下丂丂丂丄专丅丁 != false)
            {
                    int val_4 = this.与丑东丈丗专上丂丝;
                val_4 = val_4 - this.一且丄丒丈丏不丁且;
                this.与丑东丈丗专上丂丝 = val_4;
            }
            
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  "}");
        }
        public void 一丏世东东丙丌丕东()
        {
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  2);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            this.世丐丘丏万万业业丈(下业七不丑丂丏丟东:  "{");
            this.与且专丈不万东一万 = new LitJson.且丌丞丐丟七一丕业();
            .世三与东世世丈丑世 = true;
            this.丏一一丂专下一万丅.Push(item:  this.与且专丈不万东一万);
            if(this.丅下丂丂丂丄专丅丁 == false)
            {
                    return;
            }
            
            int val_2 = this.与丑东丈丗专上丂丝;
            val_2 = this.一且丄丒丈丏不丁且 + val_2;
            this.与丑东丈丗专上丂丝 = val_2;
        }
        public void 丛世世丗丛丑万丌东(string 丆与丐丐丏丆丗一丗)
        {
            var val_4;
            LitJson.且丌丞丐丟七一丕业 val_5;
            this.丞丈一与丕丒专丏丈(不丂上丝丛丂丏丂丆:  3);
            this.丄丙丐丑上丑丙丟丅(万丁丅丛万业丗一丘:  true);
            this.且且世专与丒丌专世(下业七不丑丂丏丟东:  丆与丐丐丏丆丗一丗);
            if(this.丅下丂丂丂丄专丅丁 == false)
            {
                goto label_1;
            }
            
            val_5 = this;
            if(丆与丐丐丏丆丗一丗.Length > this.与且专丈不万东一万.下丆丑上丙丙丟丑丏)
            {
                    this.与且专丈不万东一万.下丆丑上丙丙丟丑丏 = 丆与丐丐丏丆丗一丗.Length;
            }
            
            val_4 = this.与且专丈不万东一万.下丆丑上丙丙丟丑丏 - 丆与丐丐丏丆丗一丗.Length;
            goto label_9;
            label_11:
            val_4 = val_4 - 1;
            label_9:
            if((val_4 & 2147483648) == 0)
            {
                goto label_11;
            }
            
            goto label_12;
            label_1:
            val_5 = this.与且专丈不万东一万;
            label_12:
            mem2[0] = 1;
        }
    
    }

}
