﻿namespace WebApplication1.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }

    }
}
