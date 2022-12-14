namespace Game.Model
{
    public abstract class Enemy : Character
    {
        private readonly Player _target;

        public Enemy(Player target, string name, EnemyIDs id, DamagableCharacteristics characteristics) : base(characteristics) 
        {
            Name = name;
            ID = id;
            _target = target;
        }

        public EnemyIDs ID { get; private set; }
        public string Name { get; private set; }
    }

    public enum EnemyIDs
    {
        Bat = 1,
    }
}