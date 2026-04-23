namespace ToiletFinder3000.Model
{

    /**This class represents an address with street, house number, post code and city name
     @link https://danmarksadresser.dk/om-adresser/saadan-gengives-en-adresse
    */
    public class Address
    {

        public string Street { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public string PostCode { get; set; }

        public double Longitude { get; set; }
        public double Latitude { get; set; }


        public Address()
        {
                
        }


        //Constrcutor
        public Address(string street, string number, string postCode, string city)
        {
            Street = street;
            City = city;
            Number = number;
            PostCode = postCode;
        }

        //Constructor with longitude and lattitude
        public Address(string street, string number, string postCode, string city, double longitude, double lattitude)
            : this(street, number, postCode, city)
        {
            Longitude = longitude;
            Latitude = lattitude;
        }
    }
}
