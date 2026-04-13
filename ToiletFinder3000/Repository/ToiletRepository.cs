using ToiletFinder3000.Model;

namespace ToiletFinder3000.Repository
{
    public class ToiletRepository : IToiletRepository
    {


        private List<Toilet> _toiletList;


        public ToiletRepository()
        {
            //Vi starter med en tom liste
            _toiletList = new List<Toilet>();

            //Vi tilføjer nogle toiletter til listen her

            Address a = new Address("Jernbanegade", "3A", "4000", "Roskilde", 55.639087200917885, 12.087914569309898);
            Toilet t = new Toilet("Roskilde st.", a);
            _toiletList.Add(t);

            a = new Address("Frederiksborgvej", "21", "4000", "Roskilde", 55.64610006169917, 12.081469522089265);
            t = new Toilet("Byparken", a);
            _toiletList.Add(t);

        }
        public void Add(Toilet toilet)
        {
            _toiletList.Add(toilet);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Toilet> GetAll()
        {
            return _toiletList;
        }

        public Toilet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Toilet> Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public void Update(Toilet toilet)
        {
            throw new NotImplementedException();
        }
    }
}
