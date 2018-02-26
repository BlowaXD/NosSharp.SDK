using System;
using NosSharp.SDK.Enums;

namespace NosSharp.SDK.DTO
{
    public struct AccountDto
    {
        public int Id { get; set; }

        public AuthorityType Authority { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string CreationEmail { get; set; }

        public string IpRegistration { get; set; }

        public int Money { get; set; }

        public int NumberOfVotes { get; set; }

        public int NumberOfVotesThisMonth { get; set; }
    }
}