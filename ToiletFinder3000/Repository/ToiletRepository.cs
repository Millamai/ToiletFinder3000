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


        }
        public void Add(Toilet toilet)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Toilet> GetAll()
        {
            throw new NotImplementedException();
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
