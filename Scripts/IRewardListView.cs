using UnityEngine;
internal sealed class IRewardListView : PGBehaviour
{
    // Fields
    public MiniPoolMonoBehaviour pool;
    public WidgetLayout layout;
    private System.Collections.Generic.List<IRewardView> 丕丏丟丟丞与不丛一;
    
    // Methods
    public void Setup(System.Collections.Generic.List<PGCompany.与丏丛丏丏丞丐丌丙> 上业丟世三与七七三)
    {
        this.Clear();
        List.Enumerator<T> val_1 = 上业丟世三与七七三.GetEnumerator();
        label_3:
        if((1903671352 & 1) == 0)
        {
            goto label_2;
        }
        
        this.AddRewardView(丗七丟丈三不丕一三:  0.丐丏七丌丕丗业且上());
        goto label_3;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.layout.Reposition();
    }
    public void Setup(PGCompany.与丏丛丏丏丞丐丌丙 丗七丟丈三不丕一三)
    {
        this.Clear();
        this.AddRewardView(丗七丟丈三不丕一三:  丗七丟丈三不丕一三);
        this.layout.Reposition();
    }
    public void AddRewardView(PGCompany.与丏丛丏丏丞丐丌丙 丗七丟丈三不丕一三)
    {
        IRewardView val_1 = this.pool.Get<IRewardView>();
        this.layout.AddElement(丅丆东丏丙丝丅丆丟:  val_1);
        val_1.丁三丆上丆丗丒且丏 = 丗七丟丈三不丕一三;
        val_1.UpdateView();
        this.丕丏丟丟丞与不丛一.Add(item:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  true);
    }
    public void Clear()
    {
        this.丕丏丟丟丞与不丛一.ForEach(action:  new System.Action<IRewardView>(object:  this, method:  System.Void IRewardListView::丟丅上丝丈丕业七一(IRewardView 三丟东丕丄丄下下丑)));
        this.layout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.丕丏丟丟丞与不丛一.Clear();
    }
    public IRewardListView()
    {
        this.丕丏丟丟丞与不丛一 = new System.Collections.Generic.List<IRewardView>();
    }
    private void 丟丅上丝丈丕业七一(IRewardView 三丟东丕丄丄下下丑)
    {
        this.pool.Return(万且万且丑丗且丌丆:  三丟东丕丄丄下下丑);
    }

}
