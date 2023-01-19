namespace ModelBindingStyling_Lab.Models
{
    /// <summary>
    /// Individual user profile information
    /// </summary>
    public class UserProfile
    {
        public int UserProfileId { get; set; }

        /// <summary>
        /// First and last legal name of the user
        /// </summary>
        public string FullName { get; set; } = null!;

        /// <summary>
        /// User date of birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Contact email
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Contact phone number
        /// </summary>
        public string PhoneNumber { get; set; } = null!;

        /// <summary>
        /// Profile image of the user
        /// </summary>
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// The users GitHub profile URL
        /// </summary>
        public string GitHubUrl { get; set; } = null!;

        /// <summary>
        /// List of languages the user is skilled in. Will be an empty
        /// list if there are 0
        /// </summary>
        public List<string> SkilledLanguages { get; set; } = new();
    }
}
