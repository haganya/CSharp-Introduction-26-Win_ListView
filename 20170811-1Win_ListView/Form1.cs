using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170811_1Win_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * ListView nesnesine kolonlar eklemen için properties üzerinden Colums seçilerek ekleme yapılır.
         * Kolonların görünülür yapılabilmesi için listview propertiesinde view özelliği details olarak değiştirilmelidir.
         * Eklenen kolonların üzerinde yazılan yazıların değiştirilmesi için Colums eklemesinin yapıldığı yerde Text değeri değiştirilir. NAME DEĞİL TEXT!
         * ListView nesnesine değer ataman için öncesinde bir ListViewItem nesnesi doldurulmalıdır. sonrasında bu nesne listviewe gönderilir ve ekleme işlemi yapılmış olur.
         * ListViewItem nesnesinin Text özelliği ilk columna denk gelir.
         * Diğer columnlar subitem olarak alınır.
         * Listview üzerinde ızgaraların görünmesini istiyorsak properties penceresinden GridLines özelliğini TRUE yapmamız gerekir. 
         * Bütün satırı seçmek isteniyorsa FullRowSelect özelliği true yapılmalıdır.
         */
         
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem satir = new ListViewItem();
            satir.Text = txtFilmAdi.Text; // ilk column
            satir.SubItems.Add(txtTur.Text); //2. column
            satir.SubItems.Add(txtYil.Text); //3. column

            listView1.Items.Add(satir); //ListViewItem nesnesini al listviewe ekle

            txtFilmAdi.Clear();
            txtTur.Clear();
            txtYil.Clear();
            txtFilmAdi.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
