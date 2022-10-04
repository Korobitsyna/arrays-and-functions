// Напишите программу, которая подбирает трехзначное число и удаляет вторую цифру.
// 375 -> 35

void AnswerToTask()

{
    Random rnd = new Random(); // генерирует случайное число
    int result = rnd.Next(100, 1000); // число от 100 до 999
    string numericAsstring = result.ToString();
    int res = int.Parse(numericAsstring[0].ToString() + numericAsstring[2].ToString());
    
    Console.WriteLine($"Трехзначное {result}: {res}");
    
    }
AnswerToTask();
