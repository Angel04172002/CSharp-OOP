
namespace Zoo
{
    public class Lizard : Reptile
    {
        public Lizard(string name) : base(name)
        {
            Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
