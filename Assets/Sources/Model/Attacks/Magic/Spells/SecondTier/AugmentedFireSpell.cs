﻿namespace Game.Model
{
    public sealed class AugmentedFireSpell : SecondTierSpell
    {
        public AugmentedFireSpell() : base(SecondTierElementTypes.Fire, true) { }

        protected override Spell GetCombination(FireSpell spell)
        {
            throw new System.NotImplementedException();
        }

        protected override Spell GetCombination(WaterSpell spell)
        {
            throw new System.NotImplementedException();
        }

        protected override Spell GetCombination(EarthSpell spell)
        {
            throw new System.NotImplementedException();
        }

        protected override Spell GetCombination(AirSpell spell)
        {
            throw new System.NotImplementedException();
        }
    }
}