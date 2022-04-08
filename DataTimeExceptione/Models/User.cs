using System;
using System.Collections.Generic;
using System.Text;

namespace DataTimeExceptione.Models
{
    internal class User
    {
        #region Commits and Conditions
                /*
                 User class
        - Id
        - Statuses - status obyektlərini özündə saxlayan bir list olacaq.
        - Username
        - ShareStatus() - parametr olaraq bir status obyekti qəbul edib statuses listinə əlavə edəcək.
        
        - GetStatusById() - parametr olaraq nullable int tipindən bir id qəbul edəcək həmin id-li statusu tapıb geriyə qaytaracaq.
        - GetAllStatuses() - geriyə user-in bütün statuslarını qaytaracaq.
        - FilterStatusByDate() - parametr olaraq bir nullable id və DateTime tipindən bir tarix qəbul edəcək göndərilən 
                id-li user-in həmin tarixdən sonra paylaşılan bütün statuslarını geriyə qaytaracaq, 
                göndərilən tarixdən sonra heç bir status paylaşılmayıbsa NotFoundException baş verəcək.
        
        ps: Username olmadan user obyekti yaratmaq olmaz.

   */
        #endregion


        #region FIELDS
        private static int _id;

        #endregion

        #region PROPERTIES
        public int MyProperty { get;  }


        #endregion
        List<Status> Statuses=new List<Status>();


        #region METHODS

        public void ShareStatus(Status s)
        {
        
        }

        public void GetStatusByID(int? idstatus) 
        {
        
        }
        public void GetAllStatus() 
        {
            foreach (Status item in Statuses)
            {
                Console.WriteLine(item.GetStatusInfo());
            }
        }
        #endregion

    }
}
