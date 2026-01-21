using System;
using System.Collections.Generic;
using System.Text;

namespace ExVet
{
    public class Rent
    {
        public string name { get; set; }
        public string email { get; set; }
        

        public Rent(string name, string email)
        {
            this.name = name;
            this.email = email;
           
        }   

        public override string ToString()
        {
            return 
                name
                + ", "
                + email;
        }
    }
}
