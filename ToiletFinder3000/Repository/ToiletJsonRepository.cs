using System.Text.Json;
using ToiletFinder3000.Model;

namespace ToiletFinder3000.Repository
{
    public class ToiletJsonRepository : IToiletRepository
    {
        string path = @"C:\temp\toilet.json";


        List<Toilet> _toilet = new List<Toilet>();

        public ToiletJsonRepository()
        {
            LoadFile();

        }



        private void LoadFile()
        {


            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                _toilet = JsonSerializer.Deserialize<List<Toilet>>(json);
            }

        }

        private void SaveFile()
        {
            string json = JsonSerializer.Serialize(_toilet);
            File.WriteAllText(path, json);

        }

        public void Add(Toilet toilet)
        {
            _toilet.Add(toilet);
            SaveFile();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Toilet> GetAll()
        {
            return _toilet;

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
