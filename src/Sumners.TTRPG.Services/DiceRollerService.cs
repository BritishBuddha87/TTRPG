using Sumners.TTRPG.Models.DiceRollerModels;

namespace Sumners.TTRPG.Services
{
    public class DiceRollerService
    {
        public int Roll(DiceRollRequest diceRollRequest)
        {
            var dice = new DiceModel(diceRollRequest.DiceType);

            switch (diceRollRequest.Alteration)
            {
                case Models.Constants.DiceRollAlterationEnum.Disadvantage:
                    break;

                case Models.Constants.DiceRollAlterationEnum.Advantage:
                    break;

                case Models.Constants.DiceRollAlterationEnum.AbilityScore:
                    break;

                case Models.Constants.DiceRollAlterationEnum.Flat:
                default:
                    break;
            }
        }
    }
}