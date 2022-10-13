using System;

namespace Loose_Coupling_Dependency
{
    class MailSender
    {
        public void Send()
        {
            // Tight coupling
            // If we create a new object inside of other object, it's coupling
            //Gmail gmail = new Gmail();
            //gmail.Send("ycanayaz2000@gmail.com");

            Hotmail hotmail = new Hotmail();
        }
    }

    class Gmail
    {
        public Gmail()
        {

        }

        public void Send(string to)
        {

        }
    }

    class Hotmail
    {

    }
}
