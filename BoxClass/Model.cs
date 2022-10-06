using System;
using System.Collections.Generic;
using System.Text;

namespace BoxClass
{
    public class Model
    {          
        public Box boxinModel { get; set; }
       public bool isWoking { get; set; }
        public Model()
        {
            boxinModel = new Box();
          

        }
        //запуск начального поля для игры
        public List<Knod> KnodinModelStart(int Boxsize)
        {
                  isWoking = true;
            
                var allknod = BoxManagment.AddKnodBox(boxinModel.KnodInBox, Boxsize);
                var allsame = BoxManagment.AllKnodInSamePositionRandom(boxinModel.KnodInBox);
                boxinModel.KnodInBox = BoxManagment.RandomTurnKnodForStartGame(boxinModel.KnodInBox, Boxsize);
            var check = BoxManagment.CheckingForParallelism(boxinModel.KnodInBox);
            if (check==true)
            {
                boxinModel.KnodInBox = BoxManagment.RandomTurnKnodForStartGame(boxinModel.KnodInBox, Boxsize);

            }
                return boxinModel.KnodInBox;
            
        }
        //поворот ручек после выбора играком поля с тойже самой колонкой или столбцом
        public List<Knod> TurmKnodInSameColumAndLine(Knod knod)
        {
            boxinModel.KnodInBox = BoxManagment.RotationKnodSameLineAndColum(boxinModel.KnodInBox, knod);
            return boxinModel.KnodInBox;
        }
        //если все ручки ручки в одном положение то returns true

        public bool  CheckingForParallelism(List<Knod> KnodInBox)
         {
            
            var check=BoxManagment.CheckingForParallelism(KnodInBox);
            return check;

        }
        public void Stop()
        {
            isWoking = false;
            boxinModel = new Box();
        }
    }
}
