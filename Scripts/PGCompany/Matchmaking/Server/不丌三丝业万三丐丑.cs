using UnityEngine;

namespace PGCompany.Matchmaking.Server
{
    internal sealed class 不丌三丝业万三丐丑
    {
        // Fields
        private static PGCompany.Matchmaking.Server.不丌三丝业万三丐丑 丝业丆丁业三丈丟东;
        private PGCompany.Matchmaking.Model.丅丂世与丕丙三世且 且丏丏专丑丁不丄丅;
        private PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 丞一丙丗世专下丘与;
        
        // Properties
        internal static PGCompany.Matchmaking.Server.不丌三丝业万三丐丑 丆丕丝丒不丙且丐丗 { get; }
        internal PGCompany.Matchmaking.Model.丅丂世与丕丙三世且 丈丕东丅一且东与且 { get; }
        internal PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 与丒丛丂七丛下一丄 { get; }
        
        // Methods
        internal 不丌三丝业万三丐丑()
        {
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.Matchmaking.Server.不丌三丝业万三丐丑::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        }
        internal static PGCompany.Matchmaking.Server.不丌三丝业万三丐丑 丑七不且上丗丁一世()
        {
            PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丙丌专东丌丏东丗丕();
            return (PGCompany.Matchmaking.Server.不丌三丝业万三丐丑)PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丝业丆丁业三丈丟东;
        }
        internal PGCompany.Matchmaking.Model.丅丂世与丕丙三世且 丆丕丛且丗上丄丕一()
        {
            PGCompany.Matchmaking.Model.丅丂世与丕丙三世且 val_1 = this.且丏丏专丑丁不丄丅;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            this.丈丑丕丗一丞东丟东();
            val_1 = this.且丏丏专丑丁不丄丅;
            return val_1;
        }
        internal PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 丄专丂上且丌且丅丛()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_1 = this.丞一丙丗世专下丘与;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_1 = this.丞一丙丗世专下丘与;
            return val_1;
        }
        internal static void 丙丌专东丌丏东丗丕()
        {
            PGCompany.Matchmaking.Server.不丌三丝业万三丐丑 val_2;
            if(PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丝业丆丁业三丈丟东 != null)
            {
                    return;
            }
            
            PGCompany.Matchmaking.Server.不丌三丝业万三丐丑 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.Matchmaking.Server.不丌三丝业万三丐丑();
            PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丝业丆丁业三丈丟东 = val_2;
        }
        private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() == 85)
            {
                    this.丈丑丕丗一丞东丟东();
            }
            
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 86)
            {
                    return;
            }
            
            this.且丈丑与丄三七丌且();
        }
        private void 丈丑丕丗一丞东丟东()
        {
            string val_6 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  85);
            if(val_6 == null)
            {
                    val_6 = System.String.alignConst;
            }
            
            DataSystem.丈且丈上不下且丝丒 val_3 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(val_3 == null)
            {
                goto label_10;
            }
            
            label_13:
            this.且丏丏专丑丁不丄丅 = val_3;
            return;
            label_10:
            PGCompany.Matchmaking.Model.丅丂世与丕丙三世且 val_5 = new PGCompany.Matchmaking.Model.丅丂世与丕丙三世且();
            if(this != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        private void 且丈丑与丄三七丌且()
        {
            string val_6 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  86);
            if(val_6 == null)
            {
                    val_6 = System.String.alignConst;
            }
            
            DataSystem.丈且丈上不下且丝丒 val_3 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(val_3 == null)
            {
                goto label_10;
            }
            
            label_13:
            this.丞一丙丗世专下丘与 = val_3;
            return;
            label_10:
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_5 = new PGCompany.Matchmaking.Model.丈丁不丘下专上下丅();
            if(this != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        internal System.Collections.Generic.List<int> 丙世丁丘丘丆丗丅丐()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_5 = this.丞一丙丗世专下丘与;
            if(val_5 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_5 = this.丞一丙丗世专下丘与;
            if(val_5 == null)
            {
                goto label_2;
            }
            
            label_1:
            PGCompany.Matchmaking.Model.丝丛丘丏丞一世丐一 val_2 = this.丞一丙丗世专下丘与.<丐下丁世丑丛下丟专>k__BackingField.Item[this.丛丕丐丏丒一业专世()];
            if((val_2.<丐丛丞不业丈与丅万>k__BackingField) != null)
            {
                    return val_2.<丐丛丞不业丈与丅万>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  val_2.<丐丛丞不业丈与丅万>k__BackingField.Count)];
            }
            
            return val_2.<丐丛丞不业丈与丅万>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  val_2.<丐丛丞不业丈与丅万>k__BackingField.Count)];
            label_2:
        }
        internal string 丕且丘专三世且下丛()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_7;
            int val_8;
            val_7 = this.丞一丙丗世专下丘与;
            if(val_7 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_7 = this.丞一丙丗世专下丘与;
            if(val_7 == null)
            {
                goto label_2;
            }
            
            label_1:
            PGCompany.Matchmaking.Model.丝丛丘丏丞一世丐一 val_2 = this.丞一丙丗世专下丘与.<丐下丁世丑丛下丟专>k__BackingField.Item[this.丛丕丐丏丒一业专世()];
            if((val_2.<丒丄丟丐丟丗七七业>k__BackingField.Count) >= 1)
            {
                    string val_6 = val_2.<丒丄丟丐丟丗七七业>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  val_2.<丒丄丟丐丟丗七七业>k__BackingField.Count)];
                return (string)val_8;
            }
            
            val_8 = System.String.alignConst;
            return (string)val_8;
            label_2:
        }
        internal int 丐丂丏上且世丛丌丙()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_6 = this.丞一丙丗世专下丘与;
            if(val_6 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_6 = this.丞一丙丗世专下丘与;
            if(val_6 == null)
            {
                goto label_2;
            }
            
            label_1:
            PGCompany.Matchmaking.Model.丝丛丘丏丞一世丐一 val_2 = this.丞一丙丗世专下丘与.<丐下丁世丑丛下丟专>k__BackingField.Item[this.丛丕丐丏丒一业专世()];
            if((UnityEngine.Random.Range(min:  1, max:  101)) <= (val_2.<世丞一丄丘丘丌一丅>k__BackingField))
            {
                    return UnityEngine.Random.Range(min:  1, max:  ClanCreateGui.三丗不丙丘丂业丝三().Count);
            }
            
            return 0;
            label_2:
        }
        internal string 丑丐世丞下丈丟丑丄()
        {
            int val_5;
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_6;
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_7;
            int val_8;
            val_5 = this;
            val_6 = this.丞一丙丗世专下丘与;
            if(val_6 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_6 = this.丞一丙丗世专下丘与;
            if(val_6 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<与一丙丑东一一一丅>k__BackingField.Count) < 1)
            {
                goto label_4;
            }
            
            val_7 = this.丞一丙丗世专下丘与;
            if(val_7 != null)
            {
                goto label_5;
            }
            
            this.且丈丑与丄三七丌且();
            val_7 = this.丞一丙丗世专下丘与;
            if(val_7 == null)
            {
                goto label_6;
            }
            
            label_5:
            label_11:
            val_5 = UnityEngine.Random.Range(min:  0, max:  this.丞一丙丗世专下丘与.<与一丙丑东一一一丅>k__BackingField.Count);
            string val_4 = this.丞一丙丗世专下丘与.<与一丙丑东一一一丅>k__BackingField.Item[val_5];
            return (string)val_8;
            label_4:
            val_8 = System.String.alignConst;
            return (string)val_8;
            label_6:
            if(this.丞一丙丗世专下丘与 != null)
            {
                goto label_11;
            }
            
            this.且丈丑与丄三七丌且();
            if(this.丞一丙丗世专下丘与 != null)
            {
                goto label_11;
            }
            
            label_2:
        }
        internal float 三三丐上丐上丐丐丅()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_3 = this.丞一丙丗世专下丘与;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_3 = this.丞一丙丗世专下丘与;
            if(val_3 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<丐下丁世丑丛下丟专>k__BackingField.Item[this.丛丕丐丏丒一业专世()]) != null)
            {
                    return (float)val_2.<丏业丂丕业丛业丝三>k__BackingField;
            }
            
            return (float)val_2.<丏业丂丕业丛业丝三>k__BackingField;
            label_2:
        }
        internal float 丞专丁丒三丄丁丈丁()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_3 = this.丞一丙丗世专下丘与;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_3 = this.丞一丙丗世专下丘与;
            if(val_3 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<丐下丁世丑丛下丟专>k__BackingField.Item[this.丛丕丐丏丒一业专世()]) != null)
            {
                    return (float)val_2.<丄丈丒丁丌丙丈丙丐>k__BackingField;
            }
            
            return (float)val_2.<丄丈丒丁丌丙丈丙丐>k__BackingField;
            label_2:
        }
        public int 专丟一且丘东丟丘丛()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_3 = this.丞一丙丗世专下丘与;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_3 = this.丞一丙丗世专下丘与;
            if(val_3 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<丐下丁世丑丛下丟专>k__BackingField.Item[this.丛丕丐丏丒一业专世()]) != null)
            {
                    return (int)val_2.<万丒与万丕丘丗丆万>k__BackingField;
            }
            
            return (int)val_2.<万丒与万丕丘丗丆万>k__BackingField;
            label_2:
        }
        internal int 丑丗专丅丐丕丙世丕()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_3 = this.丞一丙丗世专下丘与;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_3 = this.丞一丙丗世专下丘与;
            if(val_3 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<丐下丁世丑丛下丟专>k__BackingField.Item[this.丛丕丐丏丒一业专世()]) != null)
            {
                    return (int)val_2.<丗东丈丂一丞丌丒丙>k__BackingField;
            }
            
            return (int)val_2.<丗东丈丂一丞丌丒丙>k__BackingField;
            label_2:
        }
        private int 丛丕丐丏丒一业专世()
        {
            丐丟丙不丗万三丈丆 val_1 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
            if(val_1 != null)
            {
                    return val_1.丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
            }
            
            return val_1.丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        }
        public object 一丆丅万世丗与七丈()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_3 = this.丞一丙丗世专下丘与;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_3 = this.丞一丙丗世专下丘与;
            if(val_3 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<丙丅下丛业七丝东丟>k__BackingField) != null)
            {
                    return this.丞一丙丗世专下丘与.<丙丅下丛业七丝东丟>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  this.丞一丙丗世专下丘与.<丙丅下丛业七丝东丟>k__BackingField.Count)];
            }
            
            return this.丞一丙丗世专下丘与.<丙丅下丛业七丝东丟>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  this.丞一丙丗世专下丘与.<丙丅下丛业七丝东丟>k__BackingField.Count)];
            label_2:
        }
        public object 万七三万丐丑丅一东()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_3 = this.丞一丙丗世专下丘与;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_3 = this.丞一丙丗世专下丘与;
            if(val_3 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<丟丟丕世丛丗丟丗丈>k__BackingField) != null)
            {
                    return this.丞一丙丗世专下丘与.<丟丟丕世丛丗丟丗丈>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  this.丞一丙丗世专下丘与.<丟丟丕世丛丗丟丗丈>k__BackingField.Count)];
            }
            
            return this.丞一丙丗世专下丘与.<丟丟丕世丛丗丟丗丈>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  this.丞一丙丗世专下丘与.<丟丟丕世丛丗丟丗丈>k__BackingField.Count)];
            label_2:
        }
        public object 上丏丞且与三丞一世()
        {
            PGCompany.Matchmaking.Model.丈丁不丘下专上下丅 val_3 = this.丞一丙丗世专下丘与;
            if(val_3 != null)
            {
                goto label_1;
            }
            
            this.且丈丑与丄三七丌且();
            val_3 = this.丞一丙丗世专下丘与;
            if(val_3 == null)
            {
                goto label_2;
            }
            
            label_1:
            if((this.丞一丙丗世专下丘与.<世丙万业与丅且丒不>k__BackingField) != null)
            {
                    return this.丞一丙丗世专下丘与.<世丙万业与丅且丒不>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  this.丞一丙丗世专下丘与.<世丙万业与丅且丒不>k__BackingField.Count)];
            }
            
            return this.丞一丙丗世专下丘与.<世丙万业与丅且丒不>k__BackingField.Item[UnityEngine.Random.Range(min:  0, max:  this.丞一丙丗世专下丘与.<世丙万业与丅且丒不>k__BackingField.Count)];
            label_2:
        }
    
    }

}
