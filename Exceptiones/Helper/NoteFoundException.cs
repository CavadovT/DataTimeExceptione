using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptiones.Helper
{
    public class NoteFoundException:Exception
    {
        public NoteFoundException(string message):base(message)
        {

        }
    }
}
