﻿using System;
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
 ---------------------------", @"---------------------------
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

        private void BuyTicket()
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

            RunMainMenu();
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
            Console.SetCursorPosition(30, 15);
            string new_password = Console.ReadLine();
            Console.SetCursorPosition (55, 15);
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
                Console.WriteLine("Login successful!");
                Console.ReadKey();
                RunMainMenu();
            }
            else
            {
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("Invalid username or password.");
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
