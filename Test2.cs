static void ShowListAccount(string[,] authorization)
        {
            Console.WriteLine("Имя | " + "Счет | " + "Статус");
            for (int i = 0; i < authorization.GetLength(0); i++)
            {
                if (authorization[i, 0] != "Admin")
                {
                    Console.WriteLine("{0} | {1} | {2}", authorization[i, 0], authorization[i, 2], authorization[i, 3]);
                }
            }
        }