namespace Complimentree.Models
{
    public class Compliment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public static string GetCompliment()
        {
            var compliments = new List<string>
            {
                "You have a great sense of humor!",
                "Your positivity is contagious.",
                "You are an amazing friend.",
                "Your creativity is inspiring.",
                "You have a heart of gold.",
                "Your smile brightens up the room.",
                "You are so talented!",
                "Your kindness makes the world a better place.",
                "You have a great taste in music!",
                "Your hard work is paying off!",
                "You may not be evergreen, but you are to me.",
                "I bet squirrels consider you prime real estate.",
                "You're so down to earth.",
                "You're very grounded.",
                "Your leaves are soothing.",
                "You sway nicely in the wind.",
                "You're blooming brilliant.",
                "You're really good at standing still and doing nothing.",
                "Let's get to the root of your beauty.",
                "I will never leaf you.",
                "You've really branched out lately.",
                "You provide the perfect amount of shade on a hot day.",
                "I'm really pine-ing for you."
            };
            var random = new Random();
            int index = random.Next(compliments.Count);
            return compliments[index];
        }
    }
}
