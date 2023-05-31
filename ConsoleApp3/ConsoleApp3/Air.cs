using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Air
    {
        public void Start()
        {
            RunAutoMenu();
        }
        private void RunAutoMenu()
        {
            string prompt = @"
   ▄████████  ▄█       ▄██   ▄        ▄████████ ███▄▄▄▄   ████████▄    ████████▄   ▄██████▄  ███▄▄▄▄       ███       ████████▄   ▄█     ▄████████ 
  ███    ███ ███       ███   ██▄     ███    ███ ███▀▀▀██▄ ███   ▀███   ███   ▀███ ███    ███ ███▀▀▀██▄ ▀█████████▄   ███   ▀███ ███    ███    ███ 
  ███    █▀  ███       ███▄▄▄███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███    ▀███▀▀██   ███    ███ ███▌   ███    █▀  
 ▄███▄▄▄     ███       ▀▀▀▀▀▀███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███   ▀   ███    ███ ███▌  ▄███▄▄▄     
▀▀███▀▀▀     ███       ▄██   ███   ▀███████████ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███▌ ▀▀███▀▀▀     
  ███        ███       ███   ███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███    ███    █▄  
  ███        ███▌    ▄ ███   ███     ███    ███ ███   ███ ███   ▄███   ███   ▄███ ███    ███ ███   ███     ███       ███   ▄███ ███    ███    ███ 
  ███        █████▄▄██  ▀█████▀      ███    █▀   ▀█   █▀  ████████▀    ████████▀   ▀██████▀   ▀█   █▀     ▄████▀     ████████▀  █▀     ██████████ 
             ▀                                                                                                                                             
";
            string[] options = { @"---------------------------
 |      Registrationt      |
 ---------------------------", @"---------------------------
 |      Authotization      |
 ---------------------------", @"---------------------------
 |      Login Admin        |
 ---------------------------", @"---------------------------
 |          Exit           |
 ---------------------------" };
            Menu autoMenu = new Menu(prompt, options);
            int selectedIndex = autoMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Registrationt();
                    break;
                case 1:
                    Authorization();
                    break;
                case 2:
                    LogAdmin();
                    break;
                case 3:
                    Exit();
                    break;
            }
        }

        private void RunMainMenu()
        {
            string prompt = @"
   ▄████████  ▄█       ▄██   ▄        ▄████████ ███▄▄▄▄   ████████▄    ████████▄   ▄██████▄  ███▄▄▄▄       ███       ████████▄   ▄█     ▄████████ 
  ███    ███ ███       ███   ██▄     ███    ███ ███▀▀▀██▄ ███   ▀███   ███   ▀███ ███    ███ ███▀▀▀██▄ ▀█████████▄   ███   ▀███ ███    ███    ███ 
  ███    █▀  ███       ███▄▄▄███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███    ▀███▀▀██   ███    ███ ███▌   ███    █▀  
 ▄███▄▄▄     ███       ▀▀▀▀▀▀███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███   ▀   ███    ███ ███▌  ▄███▄▄▄     
▀▀███▀▀▀     ███       ▄██   ███   ▀███████████ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███▌ ▀▀███▀▀▀     
  ███        ███       ███   ███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███    ███    █▄  
  ███        ███▌    ▄ ███   ███     ███    ███ ███   ███ ███   ▄███   ███   ▄███ ███    ███ ███   ███     ███       ███   ▄███ ███    ███    ███ 
  ███        █████▄▄██  ▀█████▀      ███    █▀   ▀█   █▀  ████████▀    ████████▀   ▀██████▀   ▀█   █▀     ▄████▀     ████████▀  █▀     ██████████ 
             ▀                                                                                                                                             
";
            string[] options = { @"---------------------------
 |      Buy a ticket       |
 ---------------------------", @"---------------------------
 |        My tickets       |
 ---------------------------",@"---------------------------
 |      Change Password    |
 ---------------------------" ,@"---------------------------
 |          Exit           |
 ---------------------------" };
            Menu allMenu = new Menu(prompt, options);
            int selectedIndex = allMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    BuyTicket();
                    break;
                case 1:
                    MyTicket();
                    break;
                case 2:
                    ChangePassword();
                    break;
                case 3:
                    Exit();
                    break;
            }
        }

        private void RunAdminMenu()
        {
            string prompt = @"
   ▄████████  ▄█       ▄██   ▄        ▄████████ ███▄▄▄▄   ████████▄    ████████▄   ▄██████▄  ███▄▄▄▄       ███       ████████▄   ▄█     ▄████████ 
  ███    ███ ███       ███   ██▄     ███    ███ ███▀▀▀██▄ ███   ▀███   ███   ▀███ ███    ███ ███▀▀▀██▄ ▀█████████▄   ███   ▀███ ███    ███    ███ 
  ███    █▀  ███       ███▄▄▄███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███    ▀███▀▀██   ███    ███ ███▌   ███    █▀  
 ▄███▄▄▄     ███       ▀▀▀▀▀▀███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███   ▀   ███    ███ ███▌  ▄███▄▄▄     
▀▀███▀▀▀     ███       ▄██   ███   ▀███████████ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███▌ ▀▀███▀▀▀     
  ███        ███       ███   ███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███    ███    █▄  
  ███        ███▌    ▄ ███   ███     ███    ███ ███   ███ ███   ▄███   ███   ▄███ ███    ███ ███   ███     ███       ███   ▄███ ███    ███    ███ 
  ███        █████▄▄██  ▀█████▀      ███    █▀   ▀█   █▀  ████████▀    ████████▀   ▀██████▀   ▀█   █▀     ▄████▀     ████████▀  █▀     ██████████ 
             ▀                                                                                                                                             
";
            string[] options = { @" ---------------------------
 |      VIEW BOOKINGS      |
 ---------------------------", @"---------------------------
 |       ADD A FLIGHT      |
 ---------------------------", @"---------------------------
 |          Exit           |
 ---------------------------" };
            Menu allMenu = new Menu(prompt, options);
            int selectedIndex = allMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    View_Bookings();
                    break;
                case 1:
                    Add_Flight();
                    break;
                case 2:
                    Exit();
                    break;
            }
        }

        private void BuyTicket(/*Тут нужно передать массив из базы данных */)
        {
            Console.Clear();
            Console.Write(@"################################################################################
#                                                                              #
#                   __________________              ____________________       #
#      Where from: |                  |     Where: |                    |      #
#                   ^^^^^^^^^^^^^^^^^^              ^^^^^^^^^^^^^^^^^^^^       #
#                                                                              #
################################################################################");
            Console.SetCursorPosition(20, 3);
            string Otkuda = Console.ReadLine();
            Console.SetCursorPosition(52, 3);
            string Kuda = Console.ReadLine();
            Console.SetCursorPosition(0, 7);
            int num = 5; // Кол-во рейсов из базы данных
            string[] num_res = new string[num]; // Массив номеров рейсов
            num_res[0] = "222233334444";
            num_res[1] = "123456789";
            num_res[2] = "32323232323";
            num_res[3] = "6666666555555";
            num_res[4] = "33131313133131";
            string[] data = new string[num]; // Даты массив
            data[0] = "10.22.33";
            data[1] = "32.32.32";
            data[2] = "11.11.11";
            data[3] = "3.4.5";
            data[4] = "2.2.2";
            string[] data_ot = new string[num]; // Даты отправлений массив
            data_ot[0] = "10.22.33";
            data_ot[1] = "32.32.32";
            data_ot[2] = "11.11.11";
            data_ot[3] = "3.4.5";
            data_ot[4] = "2.2.2";
            string[] data_pr = new string[num]; // Даты прибытия отправлений массив
            data_pr[0] = "11.11.11";
            data_pr[1] = "22.22.33";
            data_pr[2] = "44.2.2";
            data_pr[3] = "44.44.44";
            data_pr[4] = "2.22.2";
            string[] place_ot = new string[num]; // Место отправления массив
            place_ot[0] = "Vlad";
            place_ot[1] = "Vlad";
            place_ot[2] = "Vlad";
            place_ot[3] = "Vlad";
            place_ot[4] = "Vlad";
            string[] place_pr = new string[num]; // Место прибытия массив
            place_pr[0] = "Artem";
            place_pr[1] = "Artem";
            place_pr[2] = "Artem";
            place_pr[3] = "Artem";
            place_pr[4] = "Artem";

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i+1}.");
                Console.WriteLine($"\t 1.Flight number: {num_res[i]}");
                Console.WriteLine($"\t 2.Departure date: {data_ot[i]}");
                Console.WriteLine($"\t 3.Arrival date: {data_pr[i]}");
                Console.WriteLine($"\t 4.Place of departure: {place_ot[i]}");
                Console.WriteLine($"\t 5.Place of arrival: {place_pr[i]}");
            }
            Console.WriteLine("Select a flight or enter 0 to exit");
            int number = int.Parse( Console.ReadLine() );
            switch (number)
            {
                case 0:
                    RunMainMenu();
                    break;
                    case 1:
                    RunMainMenu();
                    break;
                    case 2:
                    RunMainMenu();
                    break;
                    case 3:
                    RunMainMenu();
                    break;
                    case 4:
                    RunMainMenu();
                    break;
                    case 5:
                    RunMainMenu();
                    break;
                default:
                    RunMainMenu();
                    break;
            }


            
        }

        private void MyTicket()
        {
            Console.Clear();
            Console.Write(@"################################################################################
#                                  _   _      _        _                       #
#                    /\/\  _   _  | |_(_) ___| | _____| |_ ___                 #
#                   /    \| | | | | __| |/ __| |/ / _ \ __/ __|                #
#                  / /\/\ \ |_| | | |_| | (__|   <  __/ |_\__ \                #
#                  \/    \/\__, |  \__|_|\___|_|\_\___|\__|___/                #
#                           |___/                                              #
#                                                                              #
################################################################################");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine();
            int num = 5; // Кол-во рейсов из базы данных
            string[] num_res = new string[num]; // Массив номеров рейсов
            num_res[0] = "222233334444";
            num_res[1] = "123456789";
            num_res[2] = "32323232323";
            num_res[3] = "6666666555555";
            num_res[4] = "33131313133131";
            string[] data = new string[num]; // Даты массив
            data[0] = "10.22.33";
            data[1] = "32.32.32";
            data[2] = "11.11.11";
            data[3] = "3.4.5";
            data[4] = "2.2.2";
            string[] data_ot = new string[num]; // Даты отправлений массив
            data_ot[0] = "10.22.33";
            data_ot[1] = "32.32.32";
            data_ot[2] = "11.11.11";
            data_ot[3] = "3.4.5";
            data_ot[4] = "2.2.2";
            string[] data_pr = new string[num]; // Даты прибытия отправлений массив
            data_pr[0] = "11.11.11";
            data_pr[1] = "22.22.33";
            data_pr[2] = "44.2.2";
            data_pr[3] = "44.44.44";
            data_pr[4] = "2.22.2";
            string[] place_ot = new string[num]; // Место отправления массив
            place_ot[0] = "Vlad";
            place_ot[1] = "Vlad";
            place_ot[2] = "Vlad";
            place_ot[3] = "Vlad";
            place_ot[4] = "Vlad";
            string[] place_pr = new string[num]; // Место прибытия массив
            place_pr[0] = "Artem";
            place_pr[1] = "Artem";
            place_pr[2] = "Artem";
            place_pr[3] = "Artem";
            place_pr[4] = "Artem";

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i + 1}.");
                Console.WriteLine($"\t 1.Flight number: {num_res[i]}");
                Console.WriteLine($"\t 2.Departure date: {data_ot[i]}");
                Console.WriteLine($"\t 3.Arrival date: {data_pr[i]}");
                Console.WriteLine($"\t 4.Place of departure: {place_ot[i]}");
                Console.WriteLine($"\t 5.Place of arrival: {place_pr[i]}");
            }
            Console.WriteLine("Enter 0 to exit the menu, or the flight number to delete it");
            int vib = int.Parse(Console.ReadLine());
            if (vib == 0)
            {
                RunMainMenu();
            }
            else
            {
                switch (vib)
                {

                    case 1:
                        RunMainMenu();
                        break;
                    case 2:
                        RunMainMenu();
                        break;
                    case 3:
                        RunMainMenu();
                        break;
                    case 4:
                        RunMainMenu();
                        break;
                    case 5:
                        RunMainMenu();
                        break;
                    default:
                        MyTicket();
                        break;
                }
            }
            Console.ReadKey();
            RunMainMenu();

        }

        private void Exit()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);

        }

        private void Add_Flight()
        {
            Console.Clear();
            Console.Write(@"################################################################################
#                 ___      _     _            __ _ _       _     _             #
#                / _ \    | |   | |          / _| (_)     | |   | |            #
#               / /_\ \ __| | __| |   __ _  | |_| |_  __ _| |__ | |_           #
#               |  _  |/ _` |/ _` |  / _` | |  _| | |/ _` | '_ \| __|          #
#               | | | | (_| | (_| | | (_| | | | | | | (_| | | | | |_           #
#               \_| |_/\__,_|\__,_|  \__,_| |_| |_|_|\__, |_| |_|\__|          #
#                                                     __/ |                    #
#                                                     |___/                    #
################################################################################");
            Console.SetCursorPosition(0, 11);
            Console.ReadKey();
            RunAdminMenu();
        }

        private void ChangePassword()
        {
            Console.Clear();
            Console.Write(@"################################################################################
#       _   _                                                           _      #
#      | \ | |                                                         | |     #
#      |  \| | _____      __  _ __   __ _ ___ _____      _____  _ __ __| |     #
#      | . ` |/ _ \ \ /\ / / | '_ \ / _` / __/ __\ \ /\ / / _ \| '__/ _` |     #
#      | |\  |  __/\ V  V /  | |_) | (_| \__ \__ \\ V  V / (_) | | | (_| |     #
#      \_| \_/\___| \_/\_/   | .__/ \__,_|___/___/ \_/\_/ \___/|_|  \__,_|     #
#                            | |                                               #
#                            |_|                                               #
#                                                                              #
#                 New password                      Repeat the password        #
#               __________________                  __________________         #
#              |                  |                |                  |        #
#               ''''''''''''''''''                  ''''''''''''''''''         #
#                                                                              #
################################################################################");
            Console.SetCursorPosition(16, 12);
            string new_password = Console.ReadLine();
            Console.SetCursorPosition (52, 12);
            string rep_password = Console.ReadLine();
            RunMainMenu();
        }

        private void View_Bookings()
        {
            Console.Clear();
            Console.Write(@"################################################################################
#                  ______             _    _                                   #
#                  | ___ \           | |  (_)                                  #
#                  | |_/ / ___   ___ | | ___ _ __   __ _                       #
#                  | ___ \/ _ \ / _ \| |/ / | '_ \ / _` |                      #
#                  | |_/ / (_) | (_) |   <| | | | | (_| |                      #
#                  \____/ \___/ \___/|_|\_\_|_| |_|\__, |                      #
#                                                   __/ |                      #
#                                                  |___/                       #
################################################################################");
            Console.SetCursorPosition(0, 11);
            Console.ReadKey();
            RunAdminMenu();
        }
        private void LogAdmin()
        {
            Console.Clear();
            Console.Write(@"################################################################################
#                  _    _                   _             _    _               #
#     /\          | |  | |                 (_)           | |  (_)              #
#    /  \   _   _ | |_ | |__    ___   _ __  _  ____ __ _ | |_  _   ___   _ __  #
#   / /\ \ | | | || __|| '_ \  / _ \ | '__|| ||_  // _` || __|| | / _ \ | '_ \ #
#  / ____ \| |_| || |_ | | | || (_) || |   | | / /| (_| || |_ | || (_) || | | |#
# /_/    \_\\__,_| \__||_| |_| \___/ |_|   |_|/___|\__,_| \__||_| \___/ |_| |_ #
#                                                                              #
#                                                                              #
#                 ________________                     _______________         #
#        Login : |                |       Password :  |               |        #
#                 ''''''''''''''''                     '''''''''''''''         #
#                                                                              #
#                                                                              #
#                                                                              #
################################################################################");
            Console.SetCursorPosition(18, 10);
            string name = Console.ReadLine();
            Console.SetCursorPosition(55, 10);
            string surname = Console.ReadLine();
            RunAdminMenu();



        }
        private void Authorization()
        {
            Console.Clear();
            FileManager fileManager = new FileManager("users.txt");
            Console.Write(@"################################################################################
#                  _    _                   _             _    _               #
#     /\          | |  | |                 (_)           | |  (_)              #
#    /  \   _   _ | |_ | |__    ___   _ __  _  ____ __ _ | |_  _   ___   _ __  #
#   / /\ \ | | | || __|| '_ \  / _ \ | '__|| ||_  // _` || __|| | / _ \ | '_ \ #
#  / ____ \| |_| || |_ | | | || (_) || |   | | / /| (_| || |_ | || (_) || | | |#
# /_/    \_\\__,_| \__||_| |_| \___/ |_|   |_|/___|\__,_| \__||_| \___/ |_| |_ #
#                                                                              #
#                                                                              #
#                 ________________                     _______________         #
#        Login : |                |       Password :  |               |        #
#                 ''''''''''''''''                     '''''''''''''''         #
#                                                                              #
#                                                                              #
#                                                                              #
################################################################################");
            Console.SetCursorPosition(18, 10);
            string username = Console.ReadLine();
            Console.SetCursorPosition(55, 10);
            string password = Console.ReadLine();
            

            if (fileManager.UserExists(username, password))
            {
                Console.SetCursorPosition(35, 12);
                Console.WriteLine(@"Login successful!");
                Console.ReadKey();
                RunMainMenu();
            }
            else
            {
                Console.Clear() ;
                Console.WriteLine(@"####################################################################################################
#                                                                                                  #
#  _____                _ _ _     _                _                                         _     #
# |_   _|              | | (_)   | |              (_)                                       | |    #
#   | | _ ____   ____ _| | |_  __| |   ___  _ __   _ _ __   ___ _ __ ___  _ __ _ __ ___  ___| |_   #
#   | || '_ \ \ / / _` | | | |/ _` |  / _ \| '__| | | '_ \ / __| '__/ _ \| '__| '__/ _ \/ __| __|  #
#  _| || | | \ V | (_| | | | | (_| | | (_) | |    | | | | | (__| | | (_) | |  | | |  __| (__| |_   #
#  \___|_| |_|\_/ \__,_|_|_|_|\__,_|  \___/|_|    |_|_| |_|\___|_|  \___/|_|  |_|  \___|\___|\__|  #
#                                                                   _       _                      #
#                                                                  | |     | |                     #
#                                                                __| | __ _| |_ __ _               #
#                                                               / _` |/ _` | __/ _` |              #
#                                                              | (_| | (_| | || (_| |              #
#                                                               \__,_|\__,_|\__\__,_|              #
#           Press any button to exit...                                                            #
#                                                                                                  #
#                                                                                                  #
#                                                                                                  #
#                                                                                                  #
####################################################################################################");
                Console.ReadKey();
                RunAutoMenu();
            }
            
        }
        private void Registrationt()
        {
            Console.Clear();
            Console.Write(@"################################################################################
#            _____            _     _             _   _                        #
#           |  __ \          (_)   | |           | | (_)                       #
#           | |__) |___  __ _ _ ___| |_ _ __ __ _| |_ _  ___  _ __             #
#           |  _  // _ \/ _` | / __| __| '__/ _` | __| |/ _ \| '_ \            #
#           | | \ \  __/ (_| | \__ \ |_| | | (_| | |_| | (_) | | | |           #
#           |_|  \_\___|\__, |_|___/\__|_|  \__,_|\__|_|\___/|_| |_|           #
#                        __/ |                                                 #
#                       |___/                                                  #
#                                                                              #
#         Passport details:                                                    #
#                 ________________                     _______________         #
#         Name : |                |         Surname : |               |        #
#                 ''''''''''''''''                     '''''''''''''''         #
#                 ________________                     _______________         #
#       Series : |                |          Number : |               |        #
#                 ''''''''''''''''                     '''''''''''''''         #
#                 ________________                     _______________         #
#        Login : |                |       Password :  |               |        #
#                 ''''''''''''''''                     '''''''''''''''         #
################################################################################");
            FileManager fileManager = new FileManager("users.txt");
            User newUser = new User("Artem", "12345", "johndoe@example.com");
            Console.SetCursorPosition(18, 12);
            string name = Console.ReadLine();
            Console.SetCursorPosition(55, 12);
            string surname = Console.ReadLine();
            Console.SetCursorPosition(18, 15);
            string series = Console.ReadLine();
            Console.SetCursorPosition(55, 15);
            string number = Console.ReadLine();




            Console.SetCursorPosition(18, 18);
            string login = Console.ReadLine();
            newUser.Username = login;
            Console.SetCursorPosition(55, 18);
            string pass = Console.ReadLine();
            newUser.Password = pass;
            fileManager.SaveUser(newUser);
            RunAutoMenu();
        }
    }
}
