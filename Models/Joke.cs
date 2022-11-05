namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public string CreatedBy { get; set; }


        public Joke()
        {
        }

        public Joke(int id, string jokeQuestion, string jokeAnswer, string createdBy)
        {
            Id = id;
            JokeQuestion = jokeQuestion;
            JokeAnswer = jokeAnswer;
            this.CreatedBy = createdBy;
        }
    }
}
