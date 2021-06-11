using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFMTB.Domain;

namespace WPFMTB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            load();


        }

        public MountainBikes mountainbike { get; set; }

        public void load()
        {
            using (var db = new MTBContext())
            {
                mountainbike = db.MountainBikes.FirstOrDefault();

                var m = new MountainBikes()
                {
                    BrandName = "Specalized",
                    FrameSize = "Medium",
                    HasSuspension = true,
                    FrameMaterial = "Carbon",
                    TireSize = "28.5"

                };
                db.MountainBikes.Add(m);
                db.SaveChanges();
            }
            
        }
    }
    
}
