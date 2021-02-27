namespace FluentBuilder
{
    public class User
    {
        public string Name { get; set; }     
        public string Company { get; set; }    
        public int Age { get; set; }        
        public bool IsMarried { get; set; }     

        public static UserBuilder CreateBuilder()
        {
            return new UserBuilder();
        }
    }
}
