using UnityEngine;
internal class 世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗
{
    // Fields
    internal PGCompany.上丅丙丟不业不丆东 SavePaymentType;
    internal PGCompany.上丅丙丟不业不丆东 SaveTimeBuyPromotions;
    internal PGCompany.上丅丙丟不业不丆东 SaveTimeGeneration;
    private Rilisoft.丝丑丂丛万丐丈丘且 _vip20IsOver;
    private Rilisoft.丝丑丂丛万丐丈丘且 _isCompleteMigration;
    private Rilisoft.丝丑丂丛万丐丈丘且 _lastTimeView;
    
    // Properties
    internal bool 丟世东丁丑丐丑丙丌 { get; set; }
    internal bool 丗丕世丑丛不丌丁丈 { get; set; }
    internal int 丆丙丈丘专丆七丘丑 { get; set; }
    
    // Methods
    internal bool 丟一不丐丆丑丕东丅()
    {
        return (bool)(this._vip20IsOver != 0) ? 1 : 0;
    }
    internal void 专丞下世七丄丞丛丞(bool 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        bool val_2 = 丙业与丙丗丝不丈东;
        this._vip20IsOver = 0;
        mem[1152921541358323600] = 0;
    }
    internal bool 丈丂丗与下万丕丁不()
    {
        return (bool)(this._isCompleteMigration != 0) ? 1 : 0;
    }
    internal void 世丕七丕丛上业一丄(bool 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        bool val_2 = 丙业与丙丗丝不丈东;
        this._isCompleteMigration = 0;
        mem[1152921541358547616] = 0;
    }
    internal int 一且丄丄丏丛丁丗东()
    {
    
    }
    internal void 下丒不丘万世丂下丙(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this._lastTimeView = 0;
        mem[1152921541358771632] = 0;
    }
    public 世丝上丗万丙丏世丞.丁丘丏三丙上专丕丗()
    {
        this.SavePaymentType = new PGCompany.上丅丙丟不业不丆东();
        this.SaveTimeBuyPromotions = new PGCompany.上丅丙丟不业不丆东();
        this.SaveTimeGeneration = new PGCompany.上丅丙丟不业不丆东();
    }

}
