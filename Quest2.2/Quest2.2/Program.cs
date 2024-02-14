using Quest2._2;

internal class Program
  {

    

       static int Scene00()
    {
        string userSelect = "";
        Console.WriteLine("Долгое время вы путешествовали в поисках древнего порошка под названием CreatinMonogidrat. Вы обошли не мало деревень и не в одной из них не было заветной цели");
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("Но пару дней назад вы побывали в одном королевстве и узнали об одном из секретных торговцев и теперь вы отправились к нему");
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("+Вы встретили таинственного торговца");
        Console.WriteLine("+++++++++++++++++++");
        Console.Write("Что вы будете делать?\n");
        Console.Write("1.Заговорю с ним\n2.Буду ждать пока он не начнет диалог\n3.Убью его.\n");
        Console.WriteLine("+++++++++++++++++++");
        Console.Write("> ");
        userSelect = Console.ReadLine();
        Console.Beep();
        Console.WriteLine(userSelect[0]);
      
        switch (userSelect[0])
        {
            case '1':
                Console.WriteLine("Торговец начал с вами диалог");
                return 1;
                break;
            case '2':
                Console.WriteLine("Торговец стоит в стороне и не обращает на вас внимание");
                return 2;
                break;
            case '3':
                Console.WriteLine("Торговец понял что вы собираетесь сделать и моментально сжег вас\nВы проиграли.");
                return 3;
                break;
            default:
                Console.WriteLine("Вы выбрали что то еще");
                Scene00();
                return 0;
                break;
        }

      
      
        
      
    }

    static void Scene0()
    {
        string userSelect = "";
        Console.WriteLine("Долгое время вы путешествовали в поисках древнего порошка под названием CreatinMonogidrat. Вы обошли не мало деревень и не в одной из них не было заветной цели");
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("Но пару дней назад вы побывали в одном королевстве и узнали об одном из секретных торговцев и теперь вы отправились к нему");
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("+Вы встретили таинственного торговца");
        Console.WriteLine("+++++++++++++++++++");
        Console.Write("Что вы будете делать?\n");
        Console.Write("1.Заговорю с ним\n2.Буду ждать пока он не начнет диалог\n3.Убью его.\n");
        Console.WriteLine("+++++++++++++++++++");
        Console.Write("> ");
        userSelect = Console.ReadLine();
        Console.Beep();
        Console.WriteLine(userSelect[0]);

        switch (userSelect[0])
        {
            case '1':
                Console.WriteLine("Торговец начал с вами диалог");               
                break;
            case '2':
                Console.WriteLine("Торговец стоит в стороне и не обращает на вас внимание");             
                break;
            case '3':
                Console.WriteLine("Торговец понял что вы собираетесь сделать и моментально сжег вас\nВы проиграли.");              
                break;
            default:
                Console.WriteLine("Вы выбрали что то еще");
                Scene00();             
                break;
        }
    }


    static void Scene1()
    {
        Console.WriteLine("Долгое время вы путешествовали в поисках древнего порошка под названием CreatinMonogidrat. Вы обошли не мало деревень и не в одной из них не было заветной цели");
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("Но пару дней назад вы побывали в одном королевстве и узнали об одном из секретных торговцев и теперь вы отправились к нему");
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("+Вы встретили таинственного торговца");
        Console.WriteLine("+++++++++++++++++++");
        Console.Write("Что вы будете делать?\n");
        Console.Write("1.Заговорю с ним\n2.Буду ждать пока он не начнет диалог\n3.Убью его.\n");
        Console.WriteLine("+++++++++++++++++++");
    }
     
    private static void Main(string[] args)
    {

        Console.WriteLine(Scene00());
        Console.ReadKey();

        FightClass HardKill = new FightClass();

        HardKill.SceneName = args[0];

    }
}