using UnityEngine;

namespace Rilisoft
{
    public class 丒丁丙丛上下丌丙丟 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private bool 丒与万丝丁一一丙下;
        
        // Methods
        public 丒丁丙丛上下丌丙丟(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            if(this.世丑丐丅丆丂丘不丁() != false)
            {
                    return;
            }
            
            Player_move_c.丄与三与丂丞丁七丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丒丁丙丛上下丌丙丟::下丙丁一与万丆丌七()));
            System.Action<System.Single> val_3 = new System.Action<System.Single>(object:  this, method:  System.Void Rilisoft.丒丁丙丛上下丌丙丟::东丕专万不丟万丗世(float 丑丅三丗丌丞三丘丂));
            Player_move_c.丌丛丟丐专丝丒东不(丙业与丙丗丝不丈东:  val_3);
            val_3 = new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.丒丁丙丛上下丌丙丟::丙丒专丝丈且且丝丞(bool 万且万且丑丗且丌丆));
            Player_move_c.丂丕世丘丙丆丟丘丏(丙业与丙丗丝不丈东:  val_3);
        }
        private void 下丙丁一与万丆丌七()
        {
            var val_4;
            var val_5;
            if(GameConnect.世丐丄三三上丅七三() == true)
            {
                    return;
            }
            
            if(GameConnect.东且三丆丑世世丘丟() == true)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.万丂丝丁东丑丕丌丌(丙世三一丐丗丄丁万:  this.上专丄丑专丑丘业丌());
        }
        private System.Collections.IEnumerator 上专丄丑专丑丘业丌()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丒丁丙丛上下丌丙丟.上且丙丏丒一七且业();
        }
        private bool 丌丌丕丁万丂业丆一()
        {
            if(GameConnect.丑丌丛丈丅丅与不业() == 11)
            {
                    return true;
            }
            
            if(GameConnect.丑丌丛丈丅丅与不业() == 5)
            {
                    return true;
            }
            
            if(GameConnect.丑丌丛丈丅丅与不业() == 0)
            {
                    return true;
            }
            
            if(GameConnect.丑丌丛丈丅丅与不业() == 8)
            {
                    return true;
            }
            
            if(GameConnect.丑丌丛丈丅丅与不业() == 4)
            {
                    return true;
            }
            
            if(GameConnect.丑丌丛丈丅丅与不业() == 2)
            {
                    return true;
            }
            
            var val_8 = (GameConnect.丑丌丛丈丅丅与不业() == 1) ? 1 : 0;
            return true;
        }
        private void 东丕专万不丟万丗世(float 丑丅三丗丌丞三丘丂)
        {
            this.丒与万丝丁一一丙下 = false;
        }
        private void 丙丒专丝丈且且丝丞(bool 万且万且丑丗且丌丆)
        {
            null = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.Remove(丙世三一丐丗丄丁万:  this.上专丄丑专丑丘业丌());
            this.丒与万丝丁一一丙下 = 万且万且丑丗且丌丆;
        }
        public override void Dispose()
        {
            Player_move_c.丏丟专业丁丘一业丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丒丁丙丛上下丌丙丟::下丙丁一与万丆丌七()));
            Player_move_c.丈丛丅丏一丌丝丗且(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void Rilisoft.丒丁丙丛上下丌丙丟::东丕专万不丟万丗世(float 丑丅三丗丌丞三丘丂)));
            Player_move_c.丏丕丟七万丟专专专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.丒丁丙丛上下丌丙丟::丙丒专丝丈且且丝丞(bool 万且万且丑丗且丌丆)));
        }
    
    }

}
