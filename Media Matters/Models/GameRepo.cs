using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class GameRepo : IGameRepo
    {
        public IEnumerable<BoardGame> GetBoardGames() =>
            new List<BoardGame>
        {
            new BoardGame{title="Pandemic Legacy Season One ",genre="Strategy, Coop",
                creator="Rob Daviau & Matt Leacock",publisher=" Z-Man Games"
                ,image="~/images/Pandemic.jpg",
                note="This is a game I played with a group of friends once a month until we" +
                " finished the story. It was a great time and a great co-op game we " +
                "could play together and defeat a pandemic."},

            new BoardGame{title="Gloomhaven",genre="Strategy, Coop"
                ,creator="Isaac Childres",publisher="Cephalofair Games"
                ,image="~/images/Gloom.jpg",
                note="This is a game I like because it has a full story and adventure where people" +
                " work together and play over a long time. I also enjoy the strategy" +
                " of trying to manage a shrinking hand and work with other people without" +
                " being able to know exactly what other people on the team will do."},

            new BoardGame{title="Dice Throne",genre="Card Game, Dice, Fighting ",
                creator="Nate Chatellier & Manny Trembley",publisher="Roxley Games"
                ,image="~/images/Dice.jpg",
                note="This is a game that mixes Yahtzee with a strategy game and card game. " +
                "I like having to balance the risk and reward of trying to do cool things" +
                " without messing up your turn, and having cards can help remove some of" +
                " the risk but never know if you will actually be successful."},

            new BoardGame{title="War of the ring",genre="Wargame, Fighting, Miniatures",
                creator="Roberto Di Meglio, Marco Maggi, & Francesco Nepitello",publisher="Ares Games"
                ,image="~/images/War.jpg",
                note="This is my favorite game. It is a huge game of one vs one set in the " +
                "Lord of the Rings world where one player has to take the ring to Mordor" +
                " and the other is trying to take over the map. It plays like risk on steroids," +
                " with a lot more having to do the best with what you are given."},

            new BoardGame{title="Everdell",genre="Card Game, City Building ",
                creator="James A. Wilson",publisher="Starling Games"
                ,image="~/images/Everdell.jpg",
                note="This game is a worker placement game with a town building part where you try to get " +
                "the most points as possible. I enjoy how you have to balance collecting resources with " +
                "building things and trying to plan what would be the best choice at the moment while" +
                " not letting the other players mess up your plans."},


        };
    }
}
