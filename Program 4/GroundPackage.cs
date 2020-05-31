using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
   
    
        public class GroundPackage
        {
            private int _aZipcode; // Package Origin 
            private int _bZipcode; // Package destination
            private double _length; // Package length
        private double _width; // Package width
        private double _height; // Package height
            private double _weigth; // Package weight
            const int OriginZip = 40204; // Dafault Zipcode
            const int DestinationZip = 60606; //default destination
            const int myset = 12; //Default Dimension value


            public GroundPackage(int aZipCode, int bZipcode, double length, double width, double height, double weight)
            {
            // use properties to ensure validation occurs
                AZipcode = aZipCode;
                BZipcode = bZipcode;
                Length = length;
                Width = width;
                Height = height;
                Weight = weight;

            }
            public int AZipcode
            {
            //Precondition: None
            // Postcondition: The package origin zip code has been returned
                get
                {
                    return _aZipcode;
                }
            // Precondition: value >= 00000 and value <= 99999
            //Postcondition: The package's origin zip code has been set to the specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                        _aZipcode = value;
                    else
                        _aZipcode = OriginZip;

                }
            }
            public int BZipcode
            {
            //Precondition: None
            // Postcondition: The package destination zip code has been returned
            get
            {
                    return _bZipcode;
                }
            // Precondition: value >= 00000 and value <= 99999
            //Postcondition: The package's origin zip code has been set to the specified value
            set
            {
                    if (value >= 00000 && value <= 99999)
                        _bZipcode = value;
                    else
                        _bZipcode = DestinationZip;
                }
            }
            public double Length
            {
            //Precondition: None
            // Postcondition: The package length has been returned
            get
            {
                    return _length;
            }
            // Precondition: value > 0 
            //Postcondition: The package's length has been set to the specified value
            set
            {
                    if (value > 0)
                        _length = value;
                    else
                        _length = myset;
                }
            }
            public double Width
            {
            //Precondition: None
            // Postcondition: The package width has been returned
            get
            {
                    return _width;
                }
            // Precondition: value > 0 
            //Postcondition: The package's width has been set to the specified value
            set
            {
                    if (value > 0)
                        _width = value;
                    else
                        _width = myset;
                }
            }
            public double Height
            {
            //Precondition: None
            // Postcondition: The package height has been returned
            get
            {
                    return _height;
                }
            // Precondition: value > 0 
            //Postcondition: The package's height has been set to the specified value
            set
            {
                    if (value > 0)
                        _height = value;
                    else
                        _height = myset;
                }
            }
            public double Weight
            {
            //Precondition: None
            // Postcondition: The package weigth has been returned
            get
            {
                    return _weigth;
                }
            // Precondition: value > 0 
            //Postcondition: The package's weight has been set to the specified value
            set
            {
                    if (value > 0)
                        _weigth = value;
                    else
                        _weigth = myset;
                }
            }
            public int ZoneDistance
            {
            //Precondition: None
            // Postcondition: The package zone distence has been returned
            get
            {
                    const int MY_NUM = 10000; //Denominator to extract 1st digit
                    int mydiff; // calculated zone difference

                    mydiff = (_aZipcode / MY_NUM) - (_bZipcode / MY_NUM);

                    return Math.Abs(mydiff); // Absolute value in case negative
                }
            }

            public double CalcCost()
            {
            //Precondition: None
            // Postcondition: The package cost has been returned
            const double MY_DINUM = .20; // Dimension coefficient in cost equation
                const double WEIGHT_IMP = .5; // weight coefficient in cost equation

                return (MY_DINUM * (Length + Width + Height) + WEIGHT_IMP * (ZoneDistance + 1) * Weight);
            }
            public override string ToString()
            {
            
            string PACKAGE_INFO;

                PACKAGE_INFO = $"OriginZip: {OriginZip}" + Environment.NewLine;
                PACKAGE_INFO += $"DestinationZip: {DestinationZip}" + Environment.NewLine;
                PACKAGE_INFO += $"Length: {Length}" + Environment.NewLine;
                PACKAGE_INFO += $"Width: {Width}" + Environment.NewLine;
                PACKAGE_INFO += $"Height: {Height}" + Environment.NewLine;
                PACKAGE_INFO += $"Weight: {Weight}" + Environment.NewLine;

                return PACKAGE_INFO;

            }
        }
}

