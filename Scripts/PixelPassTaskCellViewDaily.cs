using UnityEngine;
internal sealed class PixelPassTaskCellViewDaily : PixelPassTaskCellViewBase
{
    // Fields
    private PixelPassTaskView ppTaskView1;
    private PixelPassTaskView ppTaskView2;
    
    // Methods
    internal override void 丝一丅丆三东丂丞七()
    {
        var val_9;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.ppTaskView1, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.ppTaskView2, 丏业丟一东丂东丘丛:  false);
        if(this.ppTaskView1.与丑丛下且专七万丄().Count >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.ppTaskView1, 丏业丟一东丂东丘丛:  true);
            if(this.ppTaskView1 != null)
        {
                val_9 = X21.与丑丛下且专七万丄();
            this.ppTaskView1.丈且东丑丂且万丒丅(万不且且丛丆东丒业:  val_9.Item[0]);
        }
        
        }
        
        if(this.ppTaskView1.与丑丛下且专七万丄().Count >= 2)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.ppTaskView2, 丏业丟一东丂东丘丛:  true);
            if(this.ppTaskView2 != null)
        {
                val_9 = val_9.与丑丛下且专七万丄();
            this.ppTaskView2.丈且东丑丂且万丒丅(万不且且丛丆东丒业:  val_9.Item[1]);
        }
        
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public PixelPassTaskCellViewDaily()
    {
        val_1 = new PGBehaviour();
    }

}
