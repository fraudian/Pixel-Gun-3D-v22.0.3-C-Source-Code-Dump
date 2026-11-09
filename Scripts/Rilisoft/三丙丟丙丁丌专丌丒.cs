using UnityEngine;

namespace Rilisoft
{
    public class 三丙丟丙丁丌专丌丒
    {
        // Fields
        private Rilisoft.AchievementProgressData 丁丘丄丕下专东七不;
        private Rilisoft.丝丑丂丛万丐丈丘且 与丌丙丟丘七丛丂丒;
        private Rilisoft.丝丑丂丛万丐丈丘且 丟丗丟七丂丈丌丁丌;
        
        // Properties
        public int 丒丛下与丐世专世丘 { get; }
        public int 且丑业万东丐不丂上 { get; }
        public Rilisoft.AchievementProgressData 丞丑且东丌与丏丏丁 { get; set; }
        
        // Methods
        public 三丙丟丙丁丌专丌丒(Rilisoft.AchievementProgressData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = new Rilisoft.丝丑丂丛万丐丈丘且(丑三不丌丌丆丞丆丐:  19077818);
            Rilisoft.丝丑丂丛万丐丈丘且 val_2;
            this.与丌丙丟丘七丛丂丒 = val_1.七丄不丐丗三丝丑一;
            mem[1152921542195555024] = val_1.上万三丆专丏丒丗业;
            val_2 = new Rilisoft.丝丑丂丛万丐丈丘且(丑三不丌丌丆丞丆丐:  250606678);
            this.丟丗丟七丂丈丌丁丌 = val_2.七丄不丐丗三丝丑一;
            mem[1152921542195555040] = val_2.上万三丆专丏丒丗业;
            if(一丐丗丁丞丆丅丟丄 != null)
            {
                    this.丏丝丈丗丄丛丐万丆(丙业与丙丗丝不丈东:  一丐丗丁丞丆丅丟丄);
                return;
            }
            
            Rilisoft.丞专七丛丛丌世丈丕.丐东丒丌丞丌丄丏丗(丌一一七丗丗七下七:  "AchievementProgressData is null");
        }
        public int 且专丂丐丟一不丌丟()
        {
        
        }
        public int 丙万丙丂一丝丁丂下()
        {
        
        }
        public Rilisoft.AchievementProgressData 丁专丗万三上丟三丆()
        {
            this.丁丘丄丕下专东七不.Points = this.与丌丙丟丘七丛丂丒;
            this.丁丘丄丕下专东七不.Stage = this.丟丗丟七丂丈丌丁丌;
            return (Rilisoft.AchievementProgressData)this.丁丘丄丕下专东七不;
        }
        public void 丏丝丈丗丄丛丐万丆(Rilisoft.AchievementProgressData 丙业与丙丗丝不丈东)
        {
            this.丁丘丄丕下专东七不 = 丙业与丙丗丝不丈东;
        }
        public void 上世丐丗不丆不丆不(int 与丐丕东丝丏丑三丌 = 1)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = this.与丌丙丟丘七丛丂丒 + 与丐丕东丝丏丑三丌;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三世与丆一丝丟一万(丕丞且丂丒丄东不丘:  this.丁专丗万三上丟三丆());
        }
        public void 丝丗丁三且丌三丈专(int 与丐丕东丝丏丑三丌 = 1)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = this.丟丗丟七丂丈丌丁丌 + 与丐丕东丝丏丑三丌;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三世与丆一丝丟一万(丕丞且丂丒丄东不丘:  this.丁专丗万三上丟三丆());
        }
        public bool 丑丕丁三不丛丏丂丞(string 下上丐丆丝丟丝丒不)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下上丐丆丝丟丝丒不)) != false)
            {
                    return false;
            }
            
            Rilisoft.AchievementProgressData val_2 = this.丁专丗万三上丟三丆();
            if(val_2.CustomData != null)
            {
                    return val_2.CustomData.ContainsKey(key:  下上丐丆丝丟丝丒不);
            }
            
            return val_2.CustomData.ContainsKey(key:  下上丐丆丝丟丝丒不);
        }
        public object 专上丗万丕丌丈丟万(string 下上丐丆丝丟丝丒不)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下上丐丆丝丟丝丒不)) == true)
            {
                    return 0;
            }
            
            if((this.丁丘丄丕下专东七不.CustomData.ContainsKey(key:  下上丐丆丝丟丝丒不)) == false)
            {
                    return 0;
            }
            
            Rilisoft.AchievementProgressData val_3 = this.丁专丗万三上丟三丆();
            if(val_3.CustomData != null)
            {
                    return val_3.CustomData.Item[下上丐丆丝丟丝丒不];
            }
            
            return val_3.CustomData.Item[下上丐丆丝丟丝丒不];
        }
        public void 丂丏一业丑丄丝丐丄(string 下上丐丆丝丟丝丒不, object 下下丏一丙不丘丌丞)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下上丐丆丝丟丝丒不)) != false)
            {
                    return;
            }
            
            object val_2 = (下下丏一丙不丘丌丞 == 0) ? "" : 下下丏一丙不丘丌丞;
            Rilisoft.AchievementProgressData val_3 = this.丁专丗万三上丟三丆();
            bool val_4 = val_3.CustomData.ContainsKey(key:  下上丐丆丝丟丝丒不);
            Rilisoft.AchievementProgressData val_5 = this.丁专丗万三上丟三丆();
            if(val_5.CustomData == null)
            {
                goto label_7;
            }
            
            if(val_4 == false)
            {
                goto label_8;
            }
            
            label_13:
            if(val_5.CustomData.Item[下上丐丆丝丟丝丒不] == val_2)
            {
                    return;
            }
            
            Rilisoft.AchievementProgressData val_7 = this.丁专丗万三上丟三丆();
            val_7.CustomData.set_Item(key:  下上丐丆丝丟丝丒不, value:  val_2);
            goto label_12;
            label_7:
            if(val_4 == true)
            {
                goto label_13;
            }
            
            label_8:
            val_5.CustomData.Add(key:  下上丐丆丝丟丝丒不, value:  val_2);
            label_12:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三世与丆一丝丟一万(丕丞且丂丒丄东不丘:  this.丁专丗万三上丟三丆());
        }
        public void 丞与丒下丅丘东丄丙(string 下上丐丆丝丟丝丒不)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下上丐丆丝丟丝丒不)) == true)
            {
                    return;
            }
            
            string val_2 = 下上丐丆丝丟丝丒不.ToLower();
            Rilisoft.AchievementProgressData val_3 = this.丁专丗万三上丟三丆();
            if((val_3.CustomData.ContainsKey(key:  val_2)) == false)
            {
                    return;
            }
            
            Rilisoft.AchievementProgressData val_5 = this.丁专丗万三上丟三丆();
            bool val_6 = val_5.CustomData.Remove(key:  val_2);
        }
    
    }

}
