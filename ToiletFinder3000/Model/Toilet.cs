namespace ToiletFinder3000.Model
{



    public class Toilet
    {
        public string Nickname { get; set; }
        public double Rating { get; private set; }

        public Address Address { set; get; }
        public int Id { set; get; }


        private static int toiletIdCounter = 0;
        public Toilet(string nickname, Address address)
        {
            Nickname = nickname;
            Address = address;
            Rating = 0;
            Id = toiletIdCounter++;
        }
    }
}
