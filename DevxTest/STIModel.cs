namespace DevxTest
{
    /// <summary>
    /// Veritabanı verilerini karşılıyacak Model 
    /// </summary>
    public class STIModel
    {
        public long SiraNo { get; set; }
        public string IslemTuru { get; set; }
        public string EvrakNo { get; set; }
        public string Tarih { get; set; }
        public decimal GirisMiktar { get; set; }
        public decimal CikisMiktar { get; set; }
    }
}
