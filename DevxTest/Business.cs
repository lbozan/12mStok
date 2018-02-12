using DevxTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DevxTest
{
    /// <summary>
    /// Veritabanı işlemleri
    /// </summary>
    public class Business : IDisposable
    {
        bool disposed = false;
        private readonly TestContext _dbContext;
        public Business()
        {
            _dbContext = new TestContext();
            var data = _dbContext.STIs.ToList();
            var ndata = data;
        }

        /// <summary>
        /// Veritabanındaki sp ile veriler çekilir.
        /// </summary>
        /// <param name="malKodu"></param>
        /// <param name="baslamaTarih"></param>
        /// <param name="bitisTarih"></param>
        /// <returns></returns>
        public DataTable FilterDate(string malKodu, DateTime baslamaTarih, DateTime bitisTarih)
        {
            try
            {
                int basTarih = Convert.ToInt32((baslamaTarih).ToOADate());
                int bitTarih = Convert.ToInt32((bitisTarih).ToOADate());
                string searchText = malKodu.FiltReplace();
                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter("@MalKodu", IsNull(searchText)),
                    new SqlParameter("@BasTarih", basTarih),
                    new SqlParameter("@BitTarih", bitTarih)
                };

                List<STIModel> model = _dbContext.Database.SqlQuery<STIModel>(@"prc_Test @MalKodu,
                                                                                         @BasTarih,
                                                                                         @BitTarih", parameters.ToArray()).ToList();

                DataTable dt= ConvertToDatatable(model);

                return dt;

            }
            catch (Exception ex)
            {
                string exx = ex.Message;
            }
            return new DataTable();
        }

        /// <summary>
        /// Bütün veriyi DataTable dönüştürme ve Stok hesaplama
        /// </summary>
        /// <param name="list">Veri listesi</param>
        /// <returns></returns>
        public DataTable ConvertToDatatable(List<STIModel> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("SiraNo");
            dt.Columns.Add("IslemTuru");
            dt.Columns.Add("EvrakNo");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("GirisMiktar");
            dt.Columns.Add("CikisMiktar");
            dt.Columns.Add("StokMiktar");
            decimal stokMiktar = 0;
            foreach (var item in list)
            {
                var row = dt.NewRow();

                row["SiraNo"] = item.SiraNo.ToString();
                row["IslemTuru"] = item.IslemTuru;
                row["EvrakNo"] = item.EvrakNo;
                row["Tarih"] = item.Tarih;
                row["GirisMiktar"] = item.GirisMiktar.ToString();
                row["CikisMiktar"] = item.CikisMiktar.ToString();
                #region MyRegion

                switch (item.IslemTuru)
                {
                    case "Giriş":
                        stokMiktar += item.GirisMiktar; 
                        break;
                    case "Çıkış":
                        stokMiktar -= item.CikisMiktar;
                        break;
                }
                #endregion
                row["StokMiktar"] = stokMiktar.ToString();

                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        /// Ara kutucuğu boş ise Veritabanına tipi DBNull çevrilir.
        /// </summary>
        /// <param name="value">Boş olabilecek parametre</param>
        /// <returns></returns>
        private object IsNull(string value)
        {
            object result = string.IsNullOrEmpty(value) ? (object)DBNull.Value : value;
            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                _dbContext.Dispose();
            }
            disposed = true;
        }

        ~Business()
        {
            Dispose(false);
        }
    }
}
