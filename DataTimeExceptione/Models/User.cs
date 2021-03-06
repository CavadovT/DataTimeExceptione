using Exceptiones.Helper;
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
        private static int _iduser;
        private List<Status> _statuses;

        #endregion


        #region PROPERTIES
        public  int Iduser
        {
            get;
        
        }
        public List<Status> Statuses
        {
            get
            {
                return _statuses;
            }
            set
            {
                _statuses = value;
            }
        }


        #endregion


        #region METHODS
        public User(string name)
        {
            _iduser++;
            Iduser = _iduser;
            _statuses = new List<Status>();
        }

        public void ShareStatus(Status status)
        {
            Statuses.Add(status);
         
        }

        public void GetStatusByID(int? idinput) // bu halda onsuzda bize nul id gelmir cunki consoldan oxunan ededi biz zaten convert edirik bu sert 
                                                   // burda yoxlamaga ehtiyac qalmir onsuzda bize program cs den null gelmiyecek!!!
        {
            if (idinput == null) 
            {
                Console.WriteLine("Id is null");
                return;
            }
            
           List <Status> statfind = Statuses.FindAll(sval => sval.Idstatus == idinput);
            foreach (var item in statfind)
            {
                item.GetStatusInfo();
            }
            

        }
        public void GetAllStatus() 
        {
            foreach (Status item in Statuses)
            {
                item.GetStatusInfo();
            }
        }

        public void FilterStatusByData(int ? id, DateTime dateTime) 
        {
            int countforstatus = 0;
           
            if (User._iduser    == id)
            {
                foreach (var item in Statuses)
                {
                    if (dateTime < item.Shareddate)
                        item.GetStatusInfo();
                    countforstatus++;
                }
                if (countforstatus == 0)
                {
                    Console.WriteLine("This user don't shared status for this date");
                    return;
                }
            }
            else 
            {
                throw new NoteFoundException("Not Found");
            }

            
        
        }
        #endregion

    }
}
