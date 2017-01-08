using System.Collections.Generic;

namespace Recipe03.Models
{
    public class CellPhoneManager
    {
        public static List<CellPhone> GetPhones()
        {
            var list = new List<CellPhone>
            {
                new CellPhone
                {
                    Manufacturer = "Samsung",
                    ModelName = "Galaxy S4",
                    OperatingSystem = "Android",
                    Price = 24.98
                },

                new CellPhone
                {
                    Manufacturer = "Samsung",
                    ModelName = "Galaxy S5",
                    OperatingSystem = "Android",
                    Price = 99.99
                },

                new CellPhone
                {
                    Manufacturer = "Samsung",
                    ModelName = "Galaxy S6",
                    OperatingSystem = "Android",
                    Price = 199.98
                },

                new CellPhone
                {
                    Manufacturer = "Samsung",
                    ModelName = "Galaxy S6 Edge",
                    OperatingSystem = "Android",
                    Price = 299.98
                }
            };
            return list;
        }
    }
}

