﻿namespace _7a_pamoka
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }

        public static Address GetCentrineBiblioteka()
        {
            return new Address()
            {
                City = "Kaunas",
                Country = "Lietuva",
                Street = "laisves aleja",
                PostCode = 56654
            };
        }
        public static Address GetViesojiBiblioteka()
        {
            return new Address()
            {
                City = "Kaunas",
                Country = "Lietuva",
                Street = "Vilniaus gatve",
                PostCode = 78985
            };
        }

    }
}