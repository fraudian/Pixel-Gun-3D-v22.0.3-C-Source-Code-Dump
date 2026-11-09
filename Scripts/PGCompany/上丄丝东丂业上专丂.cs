using UnityEngine;

namespace PGCompany
{
    internal sealed class 上丄丝东丂业上专丂
    {
        // Methods
        internal 上丄丝东丂业上专丂()
        {
            null = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丆丄丛丂三丘业一, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.上丄丝东丂业上专丂::丑丙丅丈且一丏丌七(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        internal void 丄业丙丈丞东丟丌丘(int 丌丌业丙丌三丗丅丈)
        {
            int val_23;
            object val_25;
            string val_27;
            if(丌丌业丙丌三丗丅丈 <= 0)
            {
                goto label_1;
            }
            
            bool val_1 = this.丗丙丆丝丕一且丂与();
            if(val_1 == false)
            {
                goto label_2;
            }
            
            string val_3 = "[" + this.GetType() + "] Already migrated";
            goto label_30;
            label_1:
            val_25 = this.GetType();
            val_27 = "[{0}] Bad migrating tokens count = {1}";
            goto label_6;
            label_2:
            System.ValueTuple<RatingLeague, System.Int32> val_5 = val_1.不丝上七丗丘与丝不(丌丌业丙丌三丗丅丈:  丌丌业丙丌三丗丅丈);
            val_23 = val_5.Item2;
            int val_6 = val_23 >> 32;
            if(val_23 == 1)
            {
                goto label_7;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  40);
            Rilisoft.Singleton<TournamentController>.Instance.世三丝业下三丗七丕();
            TournamentController.丝丁七丅且且不丂丆(不丘丅丝且丏上一丒:  false);
            TournamentController.下且与一万丙丗且丁();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丆丙丆丝世与丘万(上丗业丂丑三丏上丏:  val_23, 丆丞下七丛上丐世丌:  val_6);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.Analytics.一业丗丆世世上丁且.丙丄世丄万丂一丒世(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 专世专丟丝丌与丘上:  val_6, 丙丑七万丆万丆且丌:  val_23, 世丁丙世丄一万丆三:  76.ToString());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  127, 丙业与丙丗丝不丈东:  1);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_23 = RatingSystem.与一丅丝不丈业与丙();
            string val_20 = System.String.Format(format:  "[{0}] Migrated to league = {1} and rating = {2}", arg0:  this.GetType(), arg1:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏().ToString(), arg2:  val_23.万与一丂丗丞一世丅());
            goto label_30;
            label_7:
            val_25 = this.GetType();
            val_27 = "[{0}] Migrated league = RatingSystem.RatingLeague.none for new rating count = {1}";
            label_6:
            label_30:
            UnityEngine.Debug.Log(message:  System.String.Format(format:  val_27, arg0:  val_25, arg1:  val_6));
        }
        internal bool 丗丙丆丝丕一且丂与()
        {
            Progress.丘东丅丌东丒上七丁 val_1 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
            if(val_1 != null)
            {
                    return val_1.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  127);
            }
            
            return val_1.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  127);
        }
        internal System.ValueTuple<RatingSystem.RatingLeague, int> 不丝上七丗丘与丝不(int 丌丌业丙丌三丗丅丈)
        {
            var val_7;
            var val_8;
            int val_9;
            int val_7 = 丌丌业丙丌三丗丅丈;
            val_7 = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅() + val_7;
            val_7 = 0;
            val_8 = 0;
            goto label_6;
            label_13:
            val_9 = 丞东丑专丛丆丄丝世.丞丏丞丗不丐与一丌<RatingLeague>()[0];
            if(val_9 == 1)
            {
                goto label_8;
            }
            
            if((Rilisoft.Singleton<TournamentController>.Instance.七丌专万专与丗丛一(丙丑七万丆万丆且丌:  val_9)) <= val_7)
            {
                goto label_10;
            }
            
            goto label_11;
            label_8:
            val_9 = val_8;
            label_10:
            val_7 = 1;
            val_8 = val_9;
            label_6:
            if(val_7 < val_3.Length)
            {
                goto label_13;
            }
            
            label_11:
            DiscreteVector2 val_6 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  val_7);
            return (System.ValueTuple<RatingLeague, System.Int32>)val_6._x;
        }
        private void 丑丙丅丈且一丏丌七(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            null = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丆丄丛丂三丘业一, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.上丄丝东丂业上专丂::丑丙丅丈且一丏丌七(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
            Rilisoft.Singleton<TournamentController>.Instance.东丙丗万下丌不下丏();
        }
        protected override void Finalize()
        {
            null = null;
            new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上() = new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.上丄丝东丂业上专丂::丑丙丅丈且一丏丌七(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不));
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丆丄丛丂三丘业一, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上());
            this.Finalize();
        }
    
    }

}
