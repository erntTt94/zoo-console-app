using System.Text;
using Zoo.DataStructures.Animal;
using Zoo.DataStructures.Zoo;


namespace Zoo
{
    public class Zoo
    {
        public string Name { get;}
        public List<ZooKeeper> ZooKeepers { get;}
        public List<IAnimal> CurrentAnimals { get;}

        public Zoo(string name)
        {
            Name = name;
            ZooKeepers = new List<ZooKeeper>();
            CurrentAnimals = new List<IAnimal>();
        }

        public void AddZooKeeper(ZooKeeper zooKeeper)
        {
            ZooKeepers.Add(zooKeeper);
        }

        public void AddAnimal(IAnimal animal)
        {
            CurrentAnimals.Add(animal);
        }

        public void DeleteZooKeeper(ZooKeeper zooKeeper)
        {
            ZooKeepers.Remove(zooKeeper);
        }

        public void DeleteAnimal(IAnimal animal)
        {
            CurrentAnimals.Remove(animal);
        }

        public string GetBasicInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------ Zoo Info ------ ");
            sb.Append("-- Name: ").AppendLine(Name);
            return sb.ToString();
        }

    }
}
