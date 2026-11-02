using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Fedorova.FolderforModel; // подключаем папку с моделью EF

namespace Fedorova
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // глобальная статическая переменная, которая необходима для работы с классом ModelDB
        public static ModelDB DB = new ModelDB();

        // список класса Table_Motorbike, содержащий данные из одноимённой таблицы SQL
        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.OrderBy(x => x.ID).ToList();

        // отфильтрованный список, который сейчас показывается на форме (доп. задание)
        List<Table_Motorbike> Shown;

        // переменная нужна для того, чтобы программа понимала,
        // на каком элементе из списка мы сейчас находимся
        int AccNumber = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            // заполняем список марок для фильтра
            comboBoxBrand.Items.Add("Все марки");
            foreach (string brand in Motorbikes.Select(x => x.Brand).Distinct().OrderBy(x => x))
                comboBoxBrand.Items.Add(brand);
            comboBoxBrand.SelectedIndex = 0;

            Shown = Motorbikes;
            Loading();
        }

        // Метод загрузки данных в UserControl'ы
        private void Loading()
        {
            // первый UserControl показывает текущий элемент, второй - следующий (+1)
            if (Shown.Count > AccNumber)
            {
                userControl11.Visible = true;
                userControl11.Fill(Shown[AccNumber]);
            }
            else
                userControl11.Visible = false;

            if (Shown.Count > AccNumber + 1)
            {
                userControl12.Visible = true;
                userControl12.Fill(Shown[AccNumber + 1]);
            }
            else
                userControl12.Visible = false;

            labelCount.Text = Shown.Count == 0
                ? "Ничего не найдено"
                : $"Показаны {AccNumber + 1}–{Math.Min(AccNumber + 2, Shown.Count)} из {Shown.Count}";
        }

        // Перегрузка метода Loading, чтобы на вход были другие параметры
        private void Loading(bool Incr)
        {
            if (Incr == true && Shown.Count > AccNumber + 2) // проверка при нажатии "Листать вправо"
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)    // проверка при нажатии "Листать влево"
                AccNumber--;
            else
                return; // если проверка не пройдена - выход из метода

            Loading();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }

        // Дополнительное задание: фильтрация по марке и цене
        private void ApplyFilter()
        {
            IEnumerable<Table_Motorbike> query = Motorbikes;

            if (comboBoxBrand.SelectedIndex > 0)
            {
                string brand = comboBoxBrand.SelectedItem.ToString();
                query = query.Where(x => x.Brand == brand);
            }

            if (numericMaxPrice.Value > 0)
            {
                double max = (double)numericMaxPrice.Value;
                query = query.Where(x => x.Price <= max);
            }

            Shown = query.ToList();
            AccNumber = 0;
            Loading();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Shown != null) ApplyFilter();
        }

        private void numericMaxPrice_ValueChanged(object sender, EventArgs e)
        {
            if (Shown != null) ApplyFilter();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxBrand.SelectedIndex = 0;
            numericMaxPrice.Value = 0;
            ApplyFilter();
        }
    }
}
