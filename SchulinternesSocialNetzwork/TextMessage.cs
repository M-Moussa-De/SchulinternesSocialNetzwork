using System;

namespace App
{
    class TextMessage
    {
        #region members
        Person sender;
        string message;
        DateTime localDate;
        int likes;
        #endregion

        public TextMessage(Person sender, string message)
        {
            this.sender = sender;
            this.message = message;
            localDate = DateTime.Now;
            likes = 0;
        }

        #region Getters & Setters
        public Person Sender
        {
            get { return sender; }
            set { sender = value; }

        }
        public DateTime Timestamp
        {
            get { return localDate; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public int Likes
        {
            get { return likes; }
            set { likes = value; }
        }
        #endregion

        #region Methods
        public void AddLike()
        {
            likes++;
        }
        public string GetMessage()
        {
            return (
                "{ name: " + this.Sender +
                ", date: " + this.Timestamp +
                 ", message: " + this.Message +
                 ", likes' number: " + this.Likes +
                 " }"
                 );
        }
        #endregion
    }
}