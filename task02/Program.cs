﻿Console.Write("Введите номер дня недели (число от 1 до 7): ");
int num = Convert.ToInt32(Console.ReadLine());
if (num ==1) Console.WriteLine($"Ваш день недели под номером {num} ПОНЕДЕЛЬНИК");
else if (num == 2) Console.WriteLine($"Ваш день недели под номером {num} ВТОРНИК");
else if (num == 3) Console.WriteLine($"Ваш день недели под номером {num} СРЕДА");
else if (num == 4) Console.WriteLine($"Ваш день недели под номером {num} ЧЕТВЕРГ");
else if (num == 5) Console.WriteLine($"Ваш день недели под номером {num} ПЯТНИЦА");
else if (num == 6) Console.WriteLine($"Ваш день недели под номером {num} СУББОТА");
else if (num == 7) Console.WriteLine($"Ваш день недели под номером {num} ВОСКРЕСЕНЬЕ");
else Console.WriteLine("Вы ввели неверный номер");