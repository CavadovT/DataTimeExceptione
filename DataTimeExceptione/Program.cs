using DataTimeExceptione.Models;
using System;
using System.Collections.Generic;

namespace DataTimeExceptione
{
    enum MenuBar { Creat_user = 1, Share_Status, Get_All_Status, Get_Status_By_ID, Filter_Status_By_Date, Quit = 0 }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Commits and Conditions
            /*
             Program class

Menu
1. Creat User
2. Share status
3. Get all statuses
4. Get status by id
5. Filter status by date 
0. Quit

ps: Tapşırıqda bütün şərtləri qeyd etməmişəm bəzi şərtləri özünüz fikirləşib yazmalısınız.
 */
            #endregion

            List<User> users = new List<User>();
        L1: try
            {

                do
                {
                    Console.WriteLine("=====MENUBAR=====");
                    Console.Write($"\n1-Creat User\n2-Share status\n3-Get all statuses\n4-Get status by id\n5-Filter status by data\n0-Quit is program\n");
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case (int)MenuBar.Creat_user:
                            {
                                users = new List<User>();
                                Console.Clear();
                                Console.Write("Please enter the User Name: ");
                                string nameuser = Console.ReadLine();
                                users.Add(new User(nameuser));
                                break;
                            }
                        case (int)MenuBar.Share_Status:
                            {
                                Console.Clear();
                                if (users.Count == 0)
                                {
                                    Console.WriteLine("Error: You have to creat User");

                                }
                                else
                                {

                                    Console.Write("Title: ");
                                    string title = Console.ReadLine();
                                    Console.Write("Content: ");
                                    string content = Console.ReadLine();
                                    Status status = new Status(title, content);
                                    foreach (var item in users)
                                    {
                                        item.ShareStatus(status);

                                    }
                                }


                                break;

                            }
                        case (int)MenuBar.Get_All_Status:
                            {

                                Console.Clear();
                                if (users.Count == 0)
                                {
                                    Console.WriteLine("Error: You have to creat User");
                                }
                                else
                                {
                                    foreach (var item in users)
                                    {
                                        item.GetAllStatus();

                                    }

                                }


                                break;
                            }
                        case (int)MenuBar.Get_Status_By_ID:
                            {
                                Console.Clear();
                                if (users.Count == 0)
                                {
                                    Console.WriteLine("Error: You have to creat User");
                                }
                                else
                                {
                                    Console.Write("Please enter the id of status: ");
                                    var inputid = Console.ReadLine();// null gele biler!!!
                                    int? id;
                                    if (string.IsNullOrEmpty(inputid))
                                    {
                                        id = null;
                                        foreach (var item in users)
                                        {
                                            item.GetStatusByID(id);
                                        }

                                    }
                                    else
                                    {
                                        id = int.Parse(inputid);
                                        foreach (var item in users)
                                        {
                                            item.GetStatusByID(id);
                                        }
                                    }
                                }

                                break;
                            }
                        case (int)MenuBar.Filter_Status_By_Date:
                            {
                                Console.Clear();
                                if (users.Count == 0)
                                {
                                    Console.WriteLine("Error: You have to creat User");
                                }
                                else
                                {
                                    Console.Write("Please enter the Id for user: ");
                                    var idinputuser = Console.ReadLine();// null gele bilmesi ehtimalini istemek consoleden
                                    Console.Write("Please enter the Date for filter: ");
                                    DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                                    int? id;
                                    if (string.IsNullOrEmpty(idinputuser))
                                    {
                                        id = null;
                                        foreach (var item in users)
                                        {
                                            item.FilterStatusByData(id, dateTime);
                                        }
                                    }
                                    else
                                    {
                                        id = int.Parse(idinputuser);
                                        foreach (var item in users)
                                        {
                                            item.FilterStatusByData(id, dateTime);

                                        }
                                    }

                                }
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
                goto L1;
            }

        }
    }
}
