using System;
using System.Collections.Generic;
using System.Text;

namespace DataTimeExceptione.Models
{
    internal class Status
    {
        #region COMMITS AND CONTITIONS
        /*
                 Status class
        - Id  
        - Title
        - Content
        - SharedDate - DateTime tipindən bir property, statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
        - GetStatusInfo() - geriyə "Title: test title - Content:
        test content - shared 5 seconds ago"(burda qeyd olunan "shared 5 seconds ago" 
        hissəsi dinamik olmalıdı status neçə saniyə əvvəl paylaşılıbsa o yazılmalıdı) bu tipdə bir məlumat qaytaracaq.
        
        ps: Title, content olmadan status obyekti yaratmaq olmaz.

         */
        #endregion

        #region FIELDS
        private static int _id;
        private  string _title;
        private string _content;
        private DateTime _shareddate;

        #endregion

        #region PROPERTIES
        public int ID { get; }
        public string Title 
        {
            get 
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Content 
        {
            get
            {
                return _content;
            
            }
            set
            {
                _content=value;
            }
        }
        public DateTime Shareddate { get; set; }    

        #endregion

        #region CONSTRUCTORS

        public Status(string title,string content)
        {
            _id++;
            ID = _id;
            Title = title;
            Content = content;
        }
        #endregion

        #region METHODS
        public void GetStatusInfo()
        {
            Console.Write($"\nID status: {ID}Title: {Title}");

        }
      
        #endregion
    }
}
