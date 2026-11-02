using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Fedorova.FolderforModel; // подключаем папку с моделью EF

namespace Fedorova
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // Метод для заполнения данного UserControl
        // (на входе - экземпляр класса Table_Motorbike)
        public void Fill(Table_Motorbike Motorbike)
        {
            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();

            // картинки лежат в папке Pictures рядом с exe (bin\Debug\Pictures)
            string path = $@"Pictures\{Motorbike.Picture}";
            if (pictureBoxMotorbike.Image != null)
            {
                pictureBoxMotorbike.Image.Dispose();
                pictureBoxMotorbike.Image = null;
            }
            if (File.Exists(path))
                pictureBoxMotorbike.Image = Image.FromFile(path);
        }
    }
}
