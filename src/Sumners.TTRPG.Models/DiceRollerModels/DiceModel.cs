using Sumners.TTRPG.Models.Constants;
using Sumners.TTRPG.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sumners.TTRPG.Models.DiceRollerModels
{
    public class DiceModel
    {
        private readonly DiceTypeEnum _diceType;

        public DiceModel(int numberOfSides)
        {
            _diceType = ValidateNumberOfSides(numberOfSides);
        }

        public DiceModel(DiceTypeEnum diceType)
        {
            _diceType = diceType;
        }

        public DiceTypeEnum DiceType => _diceType;
        public int NumberOfSides => (int)_diceType;
        public IEnumerable<int> Sides => Enumerable.Range(1, NumberOfSides - 1);
        public static DiceTypeEnum ValidateNumberOfSides(int numberOfSides)
        {
            try
            {
                return (DiceTypeEnum)numberOfSides;
            }
            catch (Exception)
            {
                throw new InvalidDiceTypeException(numberOfSides);
            }
        }
    }
}