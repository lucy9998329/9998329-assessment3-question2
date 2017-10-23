using System;

namespace _9998329_assessment3_question02
{
    class Falcon
    {
        private string _Name;
        private string _Species;
        private string _Sex;
        private string _Weight;
        private string  _BandNumber;

        public string Name
        {
            set
            {
                _Name = value;
            }
        }
        public string Species
        {
            set
            {
                _Species = value;
            }
        }
        //Setting method for each of the 5 instance variables
        public string Sex
        {
            set
            {
                _Sex = value;
            }
        }
        public string Weight
        {
            set
            {
                _Weight = value;
            }
        }
        public string BandNumber
        {
            set
            {
                _BandNumber = value;
            }
        }
        public Falcon(string _Name, string _Species, string _Sex, string _Weight, string _BandNumber)
        {
            Name = _Name;
            Species = _Species;
            Sex = _Sex;
            Weight = _Weight;
            BandNumber = _BandNumber;
        }
        //Display falcon method
        public string DisplayFalcon()
        {
            var showfalcon = "Enter falcon name:Hisan\n";            
            showfalcon +=$"Falcon name:{_Name}\n";
            showfalcon += $"Species:{_Species}\n";
            showfalcon +=$"Sex:{_Sex}\n";
            showfalcon +=$"Weight:{_Weight}\n";
            showfalcon +=$"BandNumber:{_BandNumber}\n";
            return showfalcon;      

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            var falcon1 = new Falcon("Hisan", "NZ Falcon", "Male", "240grams", "H39878");
            var falcon2 = new Falcon("", "", "","" ,"");
            var falcon3 = new Falcon("", "", "","","");
            var falcon4 = new Falcon("", "", "","","");
            var falcon5 = new Falcon("", "", "","","");
            var falcon6 = new Falcon("", "", "","","");

            Console.WriteLine(falcon1.DisplayFalcon());
            Console.WriteLine("Enter falcon name:");
            Console.WriteLine("Enter falcon species:");
            Console.WriteLine("Enter falcon sex:");
            Console.WriteLine("Enter falcon weight:");
            Console.WriteLine("Enter falcon bandnumber:");
            Console.ReadLine();

                        //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

            
        }
    }
}
