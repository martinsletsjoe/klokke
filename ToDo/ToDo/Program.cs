namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myText = new TextTasks();
            myText.text = "Vask bil";
            myText.DueTime = new DateTime(2023, 11, 15);
            myText.Completed = true;
            myText.CompletionDate = new DateTime(2023, 11, 14, 15, 23, 00);

            var myText2 = new TextTasks();
            myText2.text = "Gå tur med hund";
            myText2.DueTime = new DateTime(2023, 11, 15, 14, 30, 0);
            myText2.Completed = false;



            Console.WriteLine("To Do List ");
            Console.WriteLine(" Dagens dato: " + DateTime.Now + "\n");

            drawList(myText);
            drawList(myText2);


            Console.WriteLine("Vil du skrive inn en ny oppgave?");
            var numberOfTasks = 2;
            var answer = Console.ReadLine();
            if (answer == "ja")
            {
                numberOfTasks++;
            }

            while (true)
            {
                for (int number = 2; number <= numberOfTasks; number++)
                {
                    TextTasks task = myText[number];
                    
                    
                    if (myText3.text != null)
                    {
                        drawList(myText3);
                    }
                    myText3.text = Console.ReadLine();
                    Console.WriteLine("Når er fristen?");
                    myText3.DueTime = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Skriv ja om ferdig eller nei om du enda holder på");
                    var isCompleted = Console.ReadLine();
                    if (isCompleted == "ja")
                    {
                        myText3.Completed = true;
                    }

                    myText3.CompletionDate = DateTime.Now;
                }

            }

        }

        static void drawList(TextTasks myText)
        {
            TimeSpan timeOfDay = myText.DueTime.TimeOfDay;

            var taskDue = myText.DueTime.ToString();


            if (timeOfDay == TimeSpan.Zero)
            {
                taskDue = myText.DueTime.ToString("dd MM yyyy");
            }
            Console.Write(" - " + myText.text);
            Console.WriteLine(" Frist: " + taskDue);
            Console.WriteLine(myText.Completed ? $"   Oppgaven ble fullført {myText.CompletionDate}" : "   Oppgaven er uferdig");
            //Console.WriteLine("Er oppgaven fullført? "+ myText.Completed ? "ja": "nei");
            Console.WriteLine();
        }

    }
}


/*
 Lag en enkel todo-app med objekter. Hver oppgave har en tekst, en DueTime (dato, les dere opp på DateTime),
og om den er gjort eller ikke  + dato når den ble gjort. Lag en liste av oppgaver og kode som viser dem på en pen måte. 
La brukeren velge fra en meny: legg til ny eller marker som gjort.
*/