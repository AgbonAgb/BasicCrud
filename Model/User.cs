using System;

namespace BasicCrud.Model
{
    public class User
    {
        public string Id { get; set; }//= Guid.NewGuid().ToString();
        public string Name { get; set; }            
        public string Location { get; set; }
        public string Email { get; set; }   

    }
}
