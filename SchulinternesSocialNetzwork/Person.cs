using System;

namespace App
{
    class Person
    {
        #region members
        private string firstname;
        private string lastname;
        #endregion

        public Person(string fn, string ln)
        {
            firstname = fn;
            lastname = ln;
        }

        #region getters & setters
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        #endregion

        override
        public string ToString()
        {
            return firstname + " " + lastname;
        }
    }
}
