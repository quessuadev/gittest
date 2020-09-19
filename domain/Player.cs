namespace testGit.domain {
    public class Player {
        public string Username { get; set; }
        public double Rating { get; set; }

        public string Email { get; set; }

        public int age { get; set; }

        public string favouriteColor { get; set; }
    }

    public enum abilities {

        strength,
        flight,
        speed
    }
}