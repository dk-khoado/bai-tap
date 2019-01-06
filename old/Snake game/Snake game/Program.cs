using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake_game
{
    class Player1
    {
        public int headx, heady, ntail = 3, score = 0;
        public int[] xtail = new int[100];
        public int[] ytail = new int[100];
        public string player = "@";
        public bool run;
        public bool deafth = false;
        public string move = "phai";//hướng di chuyển
    }
    class Player2
    {
        public int headx, heady, ntail = 3, score = 0;
        public int[] xtail = new int[100];
        public int[] ytail = new int[100];
        public string player = "@";
        public bool run;
        public bool deafth = false;
        public string move = "phai";//hướng di chuyển
    }
    class Program
    {
        static Player1 player1 = new Player1();
        static Player2 player2 = new Player2();
        const int dai = 60, rong = 30;//kich thước khu chơi
        static ConsoleKeyInfo key1 = new ConsoleKeyInfo();//nhận phím từ bàn phím
        static int[] foodx2 = new int[2];
        static int[] food1 = new int[2];
        static StringBuilder stringBuilder = new StringBuilder();
        static char food;
        static Random random = new Random();

        static void Main(string[] args)//phần chạy chương trình
        {
            Console.SetWindowSize(110, 35);
            Console.SetBufferSize(110, 35);
            Console.OutputEncoding = Encoding.UTF8;
            Welcome();
            Start();
            Updata(10);
            Console.ReadKey();
        }
        static void Start()//khởi tạo nhân vật 
        {
            Show_ui();
            player1 = new Player1();
            player2 = new Player2();
            player1.deafth = false;
            player1.headx = 10;
            player1.heady = 2;
            //player 2
            player2.headx = 10;
            player2.heady = 10;
            for (int i = 0; i < 5; i++)
            {
                food1[0] = random.Next(2, dai - 2);
                food1[1] = random.Next(2, rong - 2);
                food = Convert.ToChar(Convert.ToInt32(random.Next(65, 87)));
                stringBuilder.Append(food);
            }
            foodx2[0] = random.Next(1, dai - 1);
            foodx2[1] = random.Next(1, rong - 1);
        }
        static void Input()//xử lý điều khiển
        {
            while (Console.KeyAvailable)
            {
                key1 = Console.ReadKey(false);
                // key2 = Console.ReadKey(false);
                if ((key1.Key == ConsoleKey.DownArrow && player1.move != "len"))
                {
                    player1.move = "xuong";
                    break;
                }
                else if (key1.Key == ConsoleKey.UpArrow && player1.move != "xuong")
                {
                    player1.move = "len";
                    break;
                }
                else if (key1.Key == ConsoleKey.RightArrow && player1.move != "trai")
                {
                    player1.move = "phai";
                    break;
                }
                else if (key1.Key == ConsoleKey.LeftArrow && player1.move != "phai")
                {
                    player1.move = "trai";
                    break;
                }
                //player 2
                //key2 = Console.ReadKey(false);
                else if (key1.Key == ConsoleKey.S && player2.move != "len")
                {
                    player2.move = "xuong";
                    break;
                }
                else if (key1.Key == ConsoleKey.W && player2.move != "xuong")
                {
                    player2.move = "len";
                    break;
                }
                else if (key1.Key == ConsoleKey.D && player2.move != "trai")
                {
                    player2.move = "phai";
                    break;
                }
                else if (key1.Key == ConsoleKey.A && player2.move != "phai")
                {
                    player2.move = "trai";
                    break;
                }
            }
        }
        static void logic1()//xử lý các sự kiện của player 1
        {
            int pre_x1 = player1.xtail[0];
            int pre_y1 = player1.ytail[0];
            int tempx1, tempy1;
            player1.xtail[0] = player1.headx;
            player1.ytail[0] = player1.heady;//
            for (int i = 1; i < player1.ntail; i++)
            {
                tempx1 = player1.xtail[i];
                tempy1 = player1.ytail[i];
                player1.xtail[i] = pre_x1;
                player1.ytail[i] = pre_y1;
                pre_x1 = tempx1;
                pre_y1 = tempy1;
                if (player1.headx == player2.xtail[i] && player1.heady == player2.ytail[i])
                    player1.score--;
            }
            switch (player1.move)//di chuyển của player 1
            {
                case "len":
                    player1.heady--;
                    break;
                case "xuong":
                    player1.heady++;
                    break;

                case "trai":
                    player1.headx--;
                    break;

                case "phai":
                    player1.headx++;
                    break;
            }
        }
        static void logic2()//xử lý các sự kiện của player 2
        {
            int pre_x1 = player2.xtail[0];
            int pre_y1 = player2.ytail[0];
            int tempx1, tempy1;
            player2.xtail[0] = player2.headx;
            player2.ytail[0] = player2.heady;//
            for (int i = 1; i < player2.ntail; i++)
            {
                tempx1 = player2.xtail[i];
                tempy1 = player2.ytail[i];
                player2.xtail[i] = pre_x1;
                player2.ytail[i] = pre_y1;
                pre_x1 = tempx1;
                pre_y1 = tempy1;
                if (player2.headx == player1.xtail[i] && player2.heady == player1.ytail[i])
                    player2.score--;
            }
            switch (player2.move)//di chuyển của player 1
            {
                case "len":
                    player2.heady--;
                    break;
                case "xuong":
                    player2.heady++;
                    break;

                case "trai":
                    player2.headx--;
                    break;

                case "phai":
                    player2.headx++;
                    break;
            }
        }
        static void render()//xử lý đồ hoạ
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < rong; i++)
            {
                for (int j = 0; j < dai; j++)
                {
                    if ((j == 0 || j == dai - 1 || i == 0 || i == rong - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("▄");
                    }
                    else if (j == food1[0] && i == food1[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(food);
                    }

                    else if (j == foodx2[0] && i == foodx2[1])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("O");
                    }
                    else if (j == player1.headx && i == player1.heady)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(player1.player);
                    }
                    else if (j == player2.headx && i == player2.heady)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(player2.player);
                    }
                    else
                    {

                        player1.run = false;
                        player2.run = false;
                        for (int k = 0; k < player1.ntail; k++)
                        {
                            if (player1.xtail[k] == j && player1.ytail[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("o");
                                player1.run = true;
                            }
                        }
                        for (int k = 0; k < player2.ntail; k++)
                        {
                            if (player2.xtail[k] == j && player2.ytail[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("o");
                                player2.run = true;
                            }
                        }
                        if (player1.run == false && player2.run == false)
                            Console.Write(" ");
                        //kiểm tra va chạm vs giới hạn của trò chơi
                        if (player1.headx <= 0 || player1.heady <= 0 || player1.headx >= dai || player1.heady >= rong)
                        {
                            player1.deafth = true;
                        }
                        //player 2
                        if (player2.headx <= 0 || player2.heady <= 0 || player2.headx >= dai || player2.heady >= rong)
                        {
                            player2.deafth = true;
                        }
                        //kiểm tra va chạm vs vật thể ăn được
                        if (player1.headx == food1[0] && player1.heady == food1[1])
                        {
                            food1[0] = random.Next(1, dai - 1);
                            food1[1] = random.Next(1, rong - 1);
                            food = Convert.ToChar(Convert.ToInt32(random.Next(65, 87)));
                            stringBuilder.Append(food);
                            player1.ntail++;
                            player1.score++;
                        }

                        if (player1.headx == foodx2[0] && player1.heady == foodx2[1])
                        {
                            foodx2[0] = random.Next(1, dai - 1);
                            foodx2[1] = random.Next(1, rong - 1);
                            player1.score += 10;
                            player1.ntail += 2;
                        }
                        //player 2
                        if (player2.headx == food1[0] && player2.heady == food1[1])
                        {
                            food1[0] = random.Next(1, dai - 1);
                            food1[1] = random.Next(1, rong - 1);
                            food = Convert.ToChar(Convert.ToInt32(random.Next(65, 87)));
                            stringBuilder.Append(food);
                            player2.ntail++;
                            player2.score++;
                        }

                        if (player2.headx == foodx2[0] && player2.heady == foodx2[1])
                        {
                            foodx2[0] = random.Next(1, dai - 1);
                            foodx2[1] = random.Next(1, rong - 1);
                            player2.score+=10;
                            player2.ntail += 2;
                        }
                    }
                }

                Console.WriteLine();
            }
            Console.SetCursorPosition(dai + 11, 1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Score Player 1: {0}", player1.score);
            Console.SetCursorPosition(dai + 11, 3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Score Player 2: {0}", player2.score);
            Console.SetCursorPosition(0, 0);
        }
        static void Show_ui()//hiển thị UI
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(dai + 10, i);
                for (int j = 0; j < 20; j++)
                {
                    if (i == 0 || j == 0 || i == 4 || j == 19)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.SetCursorPosition(0, rong + 1);
            Console.WriteLine("game đươc tạo bởi: Kakoi Khoa :)), Lớp 11thc....");
            Console.WriteLine("3=======D '  '_  @ '     '  '");
        }
        static void Updata(int Frame)
        {
            int count = 0;
            while (true)
            {
                Input();
                logic1();
                logic2();
                render();
                //Show_ui_score();
                Thread.Sleep(Frame);
                count++;
                Lose();
                if (count > 30)
                {
                    foodx2[0] = random.Next(1, dai - 1);
                    foodx2[1] = random.Next(1, rong - 1);
                    count = 0;
                }
            }

        }
        static void Welcome()
        {
            Console.Title = "Game Ran san moi";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, 3);
            Console.WriteLine("Chào mừng đến với game Rắn Săn mồi");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, 4);
            Console.WriteLine("Chế độ 2 người SOLO chơi ...... :))");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("Nhấn Enter để bắt đầu");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("Nhấn ESC để thoát");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("=");
            }
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            do
            {
                keyInfo = Console.ReadKey(false);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Đang thoát...");
                    Console.WriteLine("Tam biệt :((");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Đang khởi tao map");
            Thread.Sleep(5000);
        }
        static void Lose()
        {
            if (player1.deafth == true || player1.score <-1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(dai + 10, 10);
                Console.Write("Người chơi 1 thua.");
                Console.SetCursorPosition(dai + 10, 11);
                Console.Write("Người chơi 2 thắng với số điểm: {0}", player2.score);
                Console.SetCursorPosition(dai + 10, 12);
                Console.Write("Nhấn R để chơi lai");
                Console.SetCursorPosition(dai + 10, 13);
                Console.Write("Nhấn ESC để thoát");
                Console.CursorVisible = false;
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                do
                {
                    keyInfo = Console.ReadKey(false);
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Đang thoát...");
                        Console.WriteLine("Tam biệt :((");
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                    }
                } while (keyInfo.Key != ConsoleKey.R);
                Console.Clear();
                Start();

            }
            if (player2.deafth == true || player2.ntail <- 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(dai + 10, 10);
                Console.Write("Người chơi 2 thua.");
                Console.SetCursorPosition(dai + 10, 11);
                Console.Write("Người chơi 1 thắng với số điểm: {0}", player1.score);
                Console.SetCursorPosition(dai + 10, 12);
                Console.Write("Nhấn R để chơi lai");
                Console.SetCursorPosition(dai + 10, 13);
                Console.Write("Nhấn ESC để thoát");
                Console.CursorVisible = false;
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                do
                {
                    keyInfo = Console.ReadKey(false);
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Đang thoát...");
                        Console.WriteLine("Tam biệt :((");
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                    }
                } while (keyInfo.Key != ConsoleKey.R);
                Console.Clear();
                Start();

            }

        }
    }
}
/*
 




















    


    */