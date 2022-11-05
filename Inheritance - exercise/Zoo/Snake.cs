
namespace Zoo
{
    public class Snake : Reptile
    {
        public Snake(string name) : base(name)
        {
            Name = name;
        }

        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
