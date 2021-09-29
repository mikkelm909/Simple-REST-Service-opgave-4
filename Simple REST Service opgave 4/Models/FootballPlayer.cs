using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_REST_Service_opgave_4
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        private string _name;
        private int _price;
        private int _shirtNumber;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("name", value, "Name must be 4 or more characters long");
                }
                _name = value;
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("price", value, "The price must be over 0");
                }
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get { return _shirtNumber; }
            set
            {
                if (value >= 101 || value <= 0)
                {
                    throw new ArgumentOutOfRangeException("shirtNumber", value, "ShirtNumber must be between 1 and 100");
                }
                _shirtNumber = value;
            }
        }

        public FootballPlayer()
        {
            
        }

        public FootballPlayer(int id, string name, int price, int shirtNummber)
        {
            Id = id;
            _name = name;
            _shirtNumber = shirtNummber;
            _price = price;
        }
    }
}
