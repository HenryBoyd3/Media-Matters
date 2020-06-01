using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public interface IGameRepo
    {
        IEnumerable<BoardGame> GetBoardGames();
    }
}
