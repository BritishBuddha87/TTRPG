using Sumners.TTRPG.Models.Constants;

namespace Sumners.TTRPG.Models.DiceRollerModels
{
    public class DiceRollRequest
    {
        private readonly DiceRollAlterationEnum _alteration;
        private readonly DiceTypeEnum _diceType;

        public DiceRollRequest()
        {
            _diceType = DiceTypeEnum.d20;
            _alteration = DiceRollAlterationEnum.Flat;
        }

        public DiceRollRequest(int numberOfDiceSides, DiceRollAlterationEnum alteration)
        {
            _diceType = DiceModel.ValidateNumberOfSides(numberOfDiceSides);
            _alteration = alteration;
        }

        public DiceRollRequest(DiceTypeEnum diceType, DiceRollAlterationEnum alteration)
        {
            _diceType = diceType;
            _alteration = alteration;
        }

        public DiceRollAlterationEnum Alteration => _alteration;
        public DiceTypeEnum DiceType => _diceType;
    }
}