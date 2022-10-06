using System;
using System.Collections.Generic;
using System.Text;

namespace BoxClass
{
    class BoxManagment
    {
       
        //добавление ручек в бокс
        public static List<Knod> AddKnodBox(List<Knod> KnodInBox, int Boxsize)
        {

            for (int b = 0; b < (Boxsize); b++)
            {
                for (int a = 0; a < (Boxsize ); a++)
                {
                    var Knod = new Knod { columnumber = a, linenumber = b, };

                    KnodInBox.Add(Knod);
                }
            }
            return KnodInBox;
        }

        //все ручки либо вертикально либо горизонтально
        public static  List<Knod> AllKnodInSamePositionRandom(List<Knod> KnodInBox)
        {
            Random rnd = new Random();
            int type =  rnd.Next(0, 1);

            foreach (var knod in KnodInBox)
            {
                knod.knodPosition = (KnodPosition)type;

            }
            return KnodInBox;
        }

        //рандомно поварачиваются от 2 до 5 раз ручки можно сделать настраеваемую сложность игры 
        public static  List<Knod> RandomTurnKnodForStartGame(List<Knod> KnodInBox, int Boxsize)
        {
            Random rnd = new Random();
            var randnumber = rnd.Next(2, 5);

            for (int i = 0; i < randnumber; i++)
            {
                //выбираем рандомную ручку
                int turn = rnd.Next(0, (KnodInBox.Count - 1));

                if (KnodInBox.Contains(KnodInBox[turn]))
                {
                    var randomknod = KnodInBox[turn];

                    RotationKnodSameLineAndColum(KnodInBox, randomknod);
                }

                else
                    throw new Exception("нет такой ячейки");
            }
            return KnodInBox;
        }
        //поворот всех ручек в одной колонке и одном столбце
        public static List<Knod> RotationKnodSameLineAndColum(List<Knod> KnodInBox,  Knod knod)
        {
            for (int a = 0; a < KnodInBox.Count; a++)
            
            {
                if (KnodInBox[a].columnumber == knod.columnumber | KnodInBox[a].linenumber == knod.linenumber)
                    switch (KnodInBox[a].knodPosition)
                    {
                        case KnodPosition.parallel:
                            KnodInBox[a].knodPosition = KnodPosition.perpendicular;
                            break;
                        case KnodPosition.perpendicular:
                            KnodInBox[a].knodPosition = KnodPosition.parallel;
                            break;
                        default:
                            throw new Exception("нет такой позиции ручки");
                            break;
                    }
            }
            return KnodInBox;
        }
        public static bool CheckingForParallelism(List<Knod> KnodInBox)
        {
            bool truforallperpendicular = KnodInBox.TrueForAll(x => x.knodPosition == KnodPosition.perpendicular);
            bool truforallpara = KnodInBox.TrueForAll(x => x.knodPosition == KnodPosition.parallel);
            if (truforallpara == true | truforallperpendicular == true)
            {
                return true;
            }
            else return false;
        }
    }
}
