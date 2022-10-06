using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BoxClass;
using DotLiquid.Tags;

namespace WFormsBox
{
    
    public partial class Fild : Form
    {
       
        Model _model = new Model();

        List<Knod> knods = new List<Knod>();
        Button[] _but { get; set; }
       
       public Fild(List<Knod> _knod, Model model)
        {
            Button[] but = new Button[_knod.Count];
            _model = model;
            knods = _knod;
            var size = Math.Sqrt(_knod.Count);
            InitializeComponent();
            //размер поля зависит от количества полей
            var formsize=GeneratingNewSizeForm(size);
            this.Width = (int)formsize;
            this.Height = (int)formsize;

            GeneratingNewButton(_knod, but,size);
        }

        //вычисление ширины поля
        private double GeneratingNewSizeForm(double size)
        {
            double sizeform;
            if (size < 5)
            {
                 sizeform = (int) (150 * size);
                return sizeform;
            }
            else 
            {
                sizeform = (int)(70 * size);
                return sizeform;
            }
           
        }
        //генерация новых кнопок привязанных к ручкам
        private void GeneratingNewButton(List<Knod> _knod, Button[] but,double size)
        { 
            if (size < 5)
                for (int i = 0; i < _knod.Count; i++)
                {
                    but[i] = new Button();

                    but[i].BackColor = System.Drawing.SystemColors.ControlLight;
                    var x = _knod[i].columnumber * 100 + 20;
                    var y = _knod[i].linenumber * 100 + 20;
                    but[i].Width = 90;
                    but[i].Height = 90;
                    TextForButton(but[i], _knod[i]);
                    but[i].Location = new System.Drawing.Point(x, y);
                    Controls.Add(but[i]);
                    but[i].Click += new System.EventHandler(But_Click);
                   
                }
            else  
                for (int i = 0; i < _knod.Count; i++)
                {
                    but[i] = new Button();

                    but[i].BackColor = System.Drawing.SystemColors.ControlLight;
                    var x = _knod[i].columnumber * 50 + 10;
                    var y = _knod[i].linenumber * 50 + 10;
                    but[i].Width = 45;
                    but[i].Height = 45;
                    TextForButton(but[i], _knod[i]);
                    but[i].Location = new System.Drawing.Point(x, y);
                    Controls.Add(but[i]);
                    but[i].Click += new System.EventHandler(But_Click);
                   

                }
            
               _but = but;
        }

             
        //обработка клика на кнопку
        private void But_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < _but.Length; i++)
            {
                if (sender == _but[i])

                {
                    _model.TurmKnodInSameColumAndLine(knods[i]);

                }
            }

            ShowAllnewButton();
            var check = _model.CheckingForParallelism(knods);

            if (check == true)
            {
                                 
                for (int i = 0; i < _but.Length; i++)
                {
                    _but[i].BackColor = Color.Red;

                }
                MessageBox.Show("Поздровляем вы выграли!");
                

            }
               
        }


        //отображение нового текста на всех кнопках
        private void ShowAllnewButton()
        {
            for (int i = 0; i < _but.Length; i++)
            {
                TextForButton(_but[i], knods[i]);

            }
        }

        //отбражение текста на кнопке
        private void TextForButton(Button buttons, Knod knod)
        {
            if (knod.knodPosition == KnodPosition.parallel)
            {
                buttons.Text = "-";
                buttons.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }

            else if (knod.knodPosition == KnodPosition.perpendicular)
            {
                buttons.Text = "|";
                buttons.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }

            else
                throw new Exception("Нельзя отобразить кнопку - нет такой позиции");

        }
        private void Fild_Load(object sender, EventArgs e)
        {


        }
        
       
        private void but1_Click(object sender, EventArgs e)
        {           
            //Form1.ActiveForm.Update();
           //_model = new Model();
           
            this.Close();
            _model.Stop();
         
           
        }

       
    }
}

