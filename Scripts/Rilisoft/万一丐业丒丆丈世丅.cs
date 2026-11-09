using UnityEngine;

namespace Rilisoft
{
    public class 万一丐业丒丆丈世丅
    {
        // Fields
        private Rilisoft.丛且世丐丆上七业丁 丐丘丌三丏与丙且东;
        private string 世丗丈上与丒丛东丁;
        private System.Collections.Generic.List<Rilisoft.GameEventItemData> 丁丗与丁丟丕与世丝;
        private bool 七丘且丂万丄上丟丁;
        private int 不丑丑万丏七丑丂七;
        private int 丞丏七丏丝丈丒上丅;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丘丝丞不丛丅丈丛与;
        
        // Properties
        public System.Collections.Generic.List<Rilisoft.GameEventItemData> 丞专丈丈丟丞且丂不 { get; }
        public int 丗专丈丒丞丟与万上 { get; }
        
        // Methods
        public 万一丐业丒丆丈世丅(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            this.不丑丑万丏七丑丂七 = 50;
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.万一丐业丒丆丈世丅::丛丅万丗万丂世丝上()));
            this.丐丘丌三丏与丙且东 = 丅东专与不三丂丁丝;
            this.世丗丈上与丒丛东丁 = Rilisoft.万一丐业丒丆丈世丅.丄丑丈丏上丝丆丂丐(丅且三万丘丙业丙丗:  丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒());
            this.丈丝丗上丌丟丞丕丈();
        }
        private void 丛丅万丗万丂世丝上()
        {
            this.世丗丈上与丒丛东丁 = Rilisoft.万一丐业丒丆丈世丅.丄丑丈丏上丝丆丂丐(丅且三万丘丙业丙丗:  this.丐丘丌三丏与丙且东.丅丙丛丑丌丆丌丕丒());
            this.丈丝丗上丌丟丞丕丈();
        }
        public System.Collections.Generic.List<Rilisoft.GameEventItemData> 丗七丗业丅丁丟丛丁()
        {
            return (System.Collections.Generic.List<Rilisoft.GameEventItemData>)this.丁丗与丁丟丕与世丝;
        }
        public int 丂且丑丐丁下丅丞上()
        {
            return (int)this.丞丏七丏丝丈丒上丅;
        }
        internal static void 丘上丕不丟丆丗且三(int 丅且三万丘丙业丙丗)
        {
            Rilisoft.万一丐业丒丆丈世丅.与丅上丄丄丆丝丈丝(丅且三万丘丙业丙丗:  丅且三万丘丙业丙丗, 丘丝丞不丛丅丈丛与:  new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>(), 丞丏七丏丝丈丒上丅:  0);
        }
        private static string 丄丑丈丏上丝丆丂丐(int 丅且三万丘丙业丙丗)
        {
            return (string)System.String.Format(format:  "DropHistory_{0}_{1}", arg0:  丅且三万丘丙业丙丗, arg1:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        }
        public void 丝丅东东七三东丐万(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄)
        {
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世() == null)
            {
                    return;
            }
            
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业() == null)
            {
                    return;
            }
            
            if(this.七丘且丂万丄上丟丁 != true)
            {
                    this.丈丝丗上丌丟丞丕丈();
            }
            
            if(this.丁丗与丁丟丕与世丝.Count >= 50)
            {
                    this.丁丗与丁丟丕与世丝.RemoveAt(index:  0);
                this.丘丝丞不丛丅丈丛与.RemoveAt(index:  0);
            }
            
            int val_6 = this.丞丏七丏丝丈丒上丅;
            val_6 = val_6 + 1;
            this.丞丏七丏丝丈丒上丅 = val_6;
            this.丁丗与丁丟丕与世丝.Add(item:  一丐丗丁丞丆丅丟丄);
            this.丘丝丞不丛丅丈丛与.Add(item:  Rilisoft.万一丐业丒丆丈世丅.丆丐与丅丐丕下丈不(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄));
        }
        public void 上下一丛丏丈不丁三()
        {
            this.与丅上丄丄丆丝丈丝();
        }
        private void 丁丂丆丄万丁丏东丒()
        {
            this.丁丗与丁丟丕与世丝.Clear();
            this.丘丝丞不丛丅丈丛与.Clear();
            this.丞丏七丏丝丈丒上丅 = 0;
        }
        public System.Collections.Generic.List<Rilisoft.GameEventItemData> 丒丄下丏专且丙丄丒()
        {
            if(this.七丘且丂万丄上丟丁 == true)
            {
                    return (System.Collections.Generic.List<Rilisoft.GameEventItemData>)this.丁丗与丁丟丕与世丝;
            }
            
            this.丈丝丗上丌丟丞丕丈();
            return (System.Collections.Generic.List<Rilisoft.GameEventItemData>)this.丁丗与丁丟丕与世丝;
        }
        private static System.Collections.Generic.Dictionary<string, object> 丆丐与丅丐丕下丈不(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "i", value:  一丐丗丁丞丆丅丟丄.Id);
            val_1.Add(key:  "t", value:  一丐丗丁丞丆丅丟丄.Type);
            val_1.Add(key:  "s", value:  一丐丗丁丞丆丅丟丄.SubType);
            val_1.Add(key:  "c", value:  一丐丗丁丞丆丅丟丄.Count);
            return val_1;
        }
        private static Rilisoft.GameEventItemData 丗一丕丏业上丙丆万(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
        {
            var val_12;
            string val_13;
            if((丏丂万业丙专丏丒丒.ContainsKey(key:  "i")) == false)
            {
                goto label_2;
            }
            
            Rilisoft.GameEventItemData val_4 = null;
            val_12 = val_4;
            val_4 = new Rilisoft.GameEventItemData();
            string val_12 = "i";
            object val_8 = 丏丂万业丙专丏丒丒.Item[val_12];
            if(val_8 == null)
            {
                goto label_8;
            }
            
            val_12 = (null == null) ? (val_8) : 0;
            goto label_9;
            label_2:
            val_12 = 0;
            return (Rilisoft.GameEventItemData)val_12;
            label_8:
            val_13 = 0;
            label_9:
            .ItemParams = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  PGCompany.专丏丐丄丛丈丄丂丂.丈丏丆丛一丂丐丕丈(丁世万丟不丘不且丏:  System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["t"])), 丞丅上丏丂且下丅与:  val_13, 丂丕丂丏专丂丄丕且:  System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["c"]));
            .SubType = System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["s"]);
            return (Rilisoft.GameEventItemData)val_12;
        }
        private void 丈丝丗上丌丟丞丕丈()
        {
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_19;
            var val_20;
            string val_21;
            object val_22;
            this.丁丗与丁丟丕与世丝 = new System.Collections.Generic.List<Rilisoft.GameEventItemData>(capacity:  this.不丑丑万丏七丑丂七);
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = null;
            val_19 = val_2;
            val_2 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>(capacity:  this.不丑丑万丏七丑丂七);
            this.丘丝丞不丛丅丈丛与 = val_19;
            object val_4 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this.世丗丈上与丒丛东丁));
            if(val_4 != null)
            {
                    val_20 = 1152921516630043280;
                if((val_4.ContainsKey(key:  "eid")) != false)
            {
                    string val_19 = "eid";
                val_19 = this.丐丘丌三丏与丙且东.业上丙丞丐丄丆丅七();
                object val_7 = val_4.Item[val_19];
                if(val_7 != null)
            {
                    val_19 = (null == null) ? (val_7) : 0;
            }
            else
            {
                    val_21 = 0;
            }
            
                if(((System.String.op_Equality(a:  val_19, b:  val_21)) != false) && ((val_4.ContainsKey(key:  "i")) != false))
            {
                    if((val_4.ContainsKey(key:  "c")) != false)
            {
                    val_22 = val_4.Item["c"];
                int val_12 = System.Convert.ToInt32(value:  val_22);
            }
            else
            {
                    val_22 = 0;
            }
            
                this.丞丏七丏丝丈丒上丅 = val_22;
                object val_13 = val_4.Item["i"];
                val_19 = UnityEngine.Mathf.Min(a:  this.不丑丑万丏七丑丂七, b:  0.Count);
                if(val_19 >= 1)
            {
                    var val_20 = 0;
                do
            {
                object val_16 = 0.Item[0];
                val_20 = 0;
                Rilisoft.GameEventItemData val_18 = Rilisoft.万一丐业丒丆丈世丅.丗一丕丏业上丙丆万(丏丂万业丙专丏丒丒:  null);
                if(val_18 != null)
            {
                    this.丁丗与丁丟丕与世丝.Add(item:  val_18);
                this.丘丝丞不丛丅丈丛与.Add(item:  null);
            }
            
                val_20 = val_20 + 1;
            }
            while(val_19 != val_20);
            
            }
            
            }
            
            }
            
            }
            
            this.七丘且丂万丄上丟丁 = true;
        }
        private void 与丅上丄丄丆丝丈丝()
        {
            if(this.丐丘丌三丏与丙且东 == null)
            {
                    return;
            }
            
            if(this.七丘且丂万丄上丟丁 == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "eid", value:  this.丐丘丌三丏与丙且东.业上丙丞丐丄丆丅七());
            val_1.Add(key:  "i", value:  this.丘丝丞不丛丅丈丛与);
            val_1.Add(key:  "c", value:  this.丞丏七丏丝丈丒上丅);
            this = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.世丗丈上与丒丛东丁, 下下丏一丙不丘丌丞:  this);
        }
        private static void 与丅上丄丄丆丝丈丝(int 丅且三万丘丙业丙丗, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丘丝丞不丛丅丈丛与, int 丞丏七丏丝丈丒上丅)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "eid", value:  丅且三万丘丙业丙丗);
            }
            else
            {
                    val_1.Add(key:  "eid", value:  丅且三万丘丙业丙丗);
            }
            
            val_1.Add(key:  "i", value:  丘丝丞不丛丅丈丛与);
            val_1.Add(key:  "c", value:  丞丏七丏丝丈丒上丅);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  Rilisoft.万一丐业丒丆丈世丅.丄丑丈丏上丝丆丂丐(丅且三万丘丙业丙丗:  丅且三万丘丙业丙丗), 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
        }
        protected override void Finalize()
        {
            new System.Action() = new System.Action(object:  this, method:  System.Void Rilisoft.万一丐业丒丆丈世丅::丛丅万丗万丂世丝上());
            专丈专业丆且且业下.丄与东丌丟下丑与丛(丙业与丙丗丝不丈东:  new System.Action());
            this.Finalize();
        }
    
    }

}
