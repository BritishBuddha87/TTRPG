using Sumners.TTRPG.Models.Constants;
using System;
using System.Collections.Generic;

namespace Sumners.TTRPG.Models.DiceRollerModels
{
    public class DiceRollResult : DiceRollRequest
    {
        private readonly int _overallResult;
        private readonly IEnumerable<int> _results;

        public DiceRollResult(int overallResult, IEnumerable<int> results, DiceRollRequest diceRollRequest) : base(diceRollRequest.DiceType, diceRollRequest.Alteration)
        {
            _overallResult = overallResult;
            _results = results ?? throw new ArgumentNullException(nameof(results));
        }

        public DiceRollResult() : base()
        {
            _overallResult = default;
            _results = default;
        }

        public int OverallResult => _overallResult;
        public IEnumerable<int> Results => _results;


    }
}