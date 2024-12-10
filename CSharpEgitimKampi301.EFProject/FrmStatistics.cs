using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblTotalCapacity.Text=db.Location.Sum(x=>x.Capacity.Value).ToString();
            lblGuideCount.Text=db.Guide.Count().ToString();
            //lblAvgCapacity.Text=(db.Location.Sum(x => x.Capacity)/ db.Location.Count()).ToString(); --> Benim Yaptığım Yöntem
            lblAvgCapacity.Text = db.Location.Average(x=>x.Capacity.Value).ToString("F2");
            lblAvgLocationPrice.Text=db.Location.Average(x=>x.Price.Value).ToString("F2")+ " ₺";

            int lastCountrId = db.Location.Max(x=>x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountrId).Select(y => y.Country).FirstOrDefault();

            lblCappdociaLocationCapacity.Text = db.Location.Where(x=>x.City=="Kapadokya").Select(y=>y.Capacity).FirstOrDefault().ToString();

            lblTurkiyCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text =db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName +" "+ y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity=db.Location.Max(x=>x.Capacity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice= db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text= db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByAysegulCınar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysgulCınarLocationCount.Text =db.Location.Where(x=>x.GuideId==guideIdByAysegulCınar).Count().ToString();
        }
    }
}
