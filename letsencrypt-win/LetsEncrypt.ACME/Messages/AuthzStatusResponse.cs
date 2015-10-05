﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt.ACME.Messages
{
    public class AuthzStatusResponse
    {
        public string Status
        { get; set; }

        public DateTime? Expires
        { get; set; }

        public IdentifierPart Identifier
        { get; set; }

        public IEnumerable<ChallengePart> Challenges
        { get; set; }
    }
}
