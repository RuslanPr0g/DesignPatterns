namespace FluentBuilder
{
    public class UserBuilder
    {
        private User user;
        public UserBuilder()
        {
            user = new User();
        }
        public UserBuilder SetName(string name)
        {
            user.Name = name;
            return this;
        }
        public UserBuilder SetCompany(string company)
        {
            user.Company = company;
            return this;
        }
        public UserBuilder SetAge(int age)
        {
            user.Age = age > 0 ? age : 0;
            return this;
        }
        public UserBuilder IsMarried
        {
            get
            {
                user.IsMarried = true;
                return this;
            }
        }
        public User Build()
        {
            return user;
        }
    }
}
