using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoxClass;

namespace WFormsBox
{
    public partial class Form1 : Form
    {
        Model model =new Model();

        //Размер введенный в текстовое поле
        public string BoxeSizeText
        {
            get
            {
                return this.textBox1_BoxeSise.Text.Trim();
            }
            set
            {

            }
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //обработка ок и запуск поля (Fild) для игры 
        private void GetSize_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(BoxeSizeText))
            {
                MessageBox.Show("Отсутствует размер поля");
            }
            else if (int.TryParse(BoxeSizeText, out int number))
            {
                               
                    model.KnodinModelStart(number);

                    var newFild = new Fild(model.boxinModel.KnodInBox, model);

                    newFild.Show();

                    textBox1_BoxeSise.Text = null;
                
             
            }
            else
                MessageBox.Show("Не удалось распознать число");
        }
    
    }

  }

