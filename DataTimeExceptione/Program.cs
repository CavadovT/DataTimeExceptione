using DataTimeExceptione.Models;
using System;

namespace DataTimeExceptione
{
    enum MenuBar { Share_Status = 1, Get_All_Status, Get_Status_By_ID, Filter_Status_By_Date, Quit = 0 }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Commits and Conditions
            /*
             Program class

Menu
1. Share status
2. Get all statuses
3. Get status by id
4. Filter status by date 
0. Quit

ps: Tapşırıqda bütün şərtləri qeyd etməmişəm bəzi şərtləri özünüz fikirləşib yazmalısınız.
             */
            #endregion
            User user1 = new User("Tural");
            try
            {
              
                do
                {
                    Console.Write($"\n1-Share status\n2-Get all statuses\n3-Get status by id\n4-Filter status by data\0-Quit is program\n");
                    int input = int.Parse(Console.ReadLine());
                    
                    switch (input)
                    {
                        case (int)MenuBar.Share_Status:
                            {
                               Console.Clear();
                                Console.Write("Title: ");
                                string title=Console.ReadLine();
                                Console.Write("Content: ");
                                string content=Console.ReadLine();
                                Status status = new Status(title, content);
                                user1.ShareStatus(status);
                                break;

                            }
                        case (int)MenuBar.Get_All_Status:
                            {
                                Console.Clear();
                                user1.GetAllStatus();
                                break;
                            }
                        case (int)MenuBar.Get_Status_By_ID:
                            {
                                Console.Clear();
                                Console.Write("Please enter the user");
                                int inputid = int.Parse(Console.ReadLine());
                                user1.GetStatusByID(inputid);
                                break;
                            }
                        case (int)MenuBar.Filter_Status_By_Date:
                            {
                                Console.Clear();
                                Console.Write("Please enter the Id for user: ");
                                int idinputuser = int.Parse(Console.ReadLine());
                                Console.Write("Please enter the Date for filter: ");
                               DateTime dateTime=Convert.ToDateTime(Console.ReadLine());

                                user1.FilterStatusByData(idinputuser, dateTime);
                                break;
                            }
                        case (int)MenuBar.Quit:
                            {
                                Console.CursorLeft = 0;
                                return;
                            }

                    }

                } while (true);

            }
            catch (Exception)
            {
                Console.Beep();
                Console.WriteLine("An error occurred");

            }
        }
    }
}
