namespace App
{
    class SocialNetwork
    {
        #region members
        List<Person> members;
        List<TextMessage> messages;
        #endregion

        public SocialNetwork() {
            members = new();
            messages = new();
        }

        #region Methods
        public void AddMembers(Person member)
        {
            if (members.Contains(member)) throw new CustomException("Member is already in the list.");

            members.Add(member);
        }
        public void AddMessage(TextMessage message)
        {
            messages.Add(message);
        }
        public List<TextMessage>? GetAllMessages()
        { 
            if(messages.Count < 1 || messages == null) return null;

            return messages;
        }
        public List<Person>? GetAllMemebers()
        {
            if(members.Count < 1 || members == null) return null;

            return members;
        }

        public List<TextMessage>? GetMessagesFilteredByPerson(Person person)
        {
            if (messages.Count < 1) return null;

            if (!members.Contains(person)) throw new CustomException("Person is not in the list.");
     
            List<TextMessage> personalMessages = new();

            foreach(TextMessage tm in messages)
            {
                if(tm.Sender == person)
                {
                    personalMessages.Add(tm);
                }

            }

            return personalMessages;
        }
        #endregion

    }
}
